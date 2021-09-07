using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace CNPM_QuanLyQuanAn
{
    public partial class FormLogin : Form
    {
        XuLy xl = new XuLy();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lblUsername.Text.ToLower());
                this.txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                 MessageBox.Show("Không được bỏ trống " + lblPassword.Text.ToLower());
               this.txtPassword.Focus();
                return;
            }
            if (!xl.KiemTraTenDangNhap(txtUsername.Text))
            {
                MessageBox.Show("Sai tên đăng nhập");
                this.txtUsername.Focus();
                return;
            }
            if (!xl.KiemTraMatKhau(txtPassword.Text))
            {
                MessageBox.Show("Sai mật khẩu");
                this.txtPassword.Focus();
                return;
            }
            
            int role = xl.DangNhap(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            switch (role)
            {
                case 1:
                    FormThuNgan frm = new FormThuNgan();
                    frm.txtval = txtUsername.Text.Trim();
                    frm.Show();
                    this.Hide();
                    break;
                case 2:
                    FormPhucVu frm1 = new FormPhucVu();
                    frm1.txtval = txtUsername.Text.Trim();
                    frm1.Show();
                    this.Hide();
                    break;
                case 3:
                    FormThuKho frm2 = new FormThuKho();
                    frm2.txtval = txtUsername.Text.Trim();
                    frm2.Show();
                    this.Hide();
                    break;
                case 4:
                    FormQuanLy frm3 = new FormQuanLy();
                    frm3.txtval = txtUsername.Text.Trim();
                    frm3.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
            
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }



        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }


    }
}
