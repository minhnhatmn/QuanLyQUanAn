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
    public partial class FormGoiMon : Form
    {
        Handle_GoiMon goimon = new Handle_GoiMon();
        public String txtval { get; set; }
        public FormGoiMon()
        {
            InitializeComponent();
        }
        
        private void FormGoiMon_Load(object sender, EventArgs e)
        {
            loadDL();
            txt_manv.Text = txtval;
            
        }
        public void loadDL()
        {
            dgv_goimon.DataSource = goimon.GetGoiMon();
            dgv_monan.DataSource = goimon.GetMonAn();
            dgv_ban.DataSource = goimon.GetBan();
            dgv_goimon.Columns["BAN"].Visible = false;
            dgv_goimon.Columns["NHANVIEN"].Visible = false;
            
        }
        private void dgv_chitietgoimon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_stt.Text = dgv_chitietgoimon.CurrentRow.Cells[0].Value.ToString();
                txt_ctgoimon_magoimon.Text = dgv_chitietgoimon.CurrentRow.Cells[1].Value.ToString();
                txt_mamon.Text = dgv_chitietgoimon.CurrentRow.Cells[2].Value.ToString();
                numb_SoLuongMon.Value = int.Parse(dgv_chitietgoimon.CurrentRow.Cells[3].Value.ToString());
            }
            catch (Exception)
            {
                
            }
            
        }

        private void dgv_goimon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_magoimon.Text = dgv_goimon.CurrentRow.Cells[0].Value.ToString();
                txt_manv.Text = dgv_goimon.CurrentRow.Cells[1].Value.ToString();
                txt_maban.Text = dgv_goimon.CurrentRow.Cells[2].Value.ToString();
                txt_ctgoimon_magoimon.Text= dgv_goimon.CurrentRow.Cells[0].Value.ToString();
                dgv_chitietgoimon.DataSource = goimon.GetCTGM(dgv_goimon.CurrentRow.Cells[0].Value.ToString());
                dgv_chitietgoimon.Columns["GOIMON"].Visible = false;
                dgv_chitietgoimon.Columns["MONAN"].Visible = false;
            }
            catch (Exception)
            {
                
            }
            
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                int kt = goimon.themGOIMON(txt_magoimon.Text, txt_manv.Text, txt_maban.Text);
                if (kt == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    loadDL();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int kt = goimon.xoaGOIMON(txt_magoimon.Text);
                if (kt == 1)
                {
                    MessageBox.Show("Xóa thành công");
                    loadDL();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại");
            }
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                int kt = goimon.suaGOIMON(txt_magoimon.Text, txt_manv.Text, txt_maban.Text);
                if (kt == 1)
                {
                    MessageBox.Show("Sửa thành công");
                    loadDL();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_themct_Click(object sender, EventArgs e)
        {
            try
            {
                int kt = goimon.themCTGOIMON(txt_ctgoimon_magoimon.Text, txt_mamon.Text, int.Parse(numb_SoLuongMon.Text));
                if (kt == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    loadDL();
                    dgv_chitietgoimon.DataSource = goimon.GetCTGM(txt_ctgoimon_magoimon.Text);
                    dgv_chitietgoimon.Columns["GOIMON"].Visible = false;
                    dgv_chitietgoimon.Columns["MONAN"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }
            
        }

        private void btn_xoact_Click(object sender, EventArgs e)
        {
            try
            {
                int kt = goimon.xoaCTGOIMON(int.Parse(txt_stt.Text));
                if (kt == 1)
                {
                    MessageBox.Show("Xóa thành công");
                    loadDL();
                    dgv_chitietgoimon.DataSource = goimon.GetCTGM(txt_ctgoimon_magoimon.Text);
                    dgv_chitietgoimon.Columns["GOIMON"].Visible = false;
                    dgv_chitietgoimon.Columns["MONAN"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại");
            }
            
        }

        private void btn_suact_Click(object sender, EventArgs e)
        {
            try
            {
                int kt = goimon.suaCTGOIMON(int.Parse(txt_stt.Text), txt_mamon.Text, int.Parse(numb_SoLuongMon.Text));
                if (kt == 1)
                {
                    MessageBox.Show("Sửa thành công");
                    loadDL();
                    dgv_chitietgoimon.DataSource = goimon.GetCTGM(txt_ctgoimon_magoimon.Text);
                    dgv_chitietgoimon.Columns["GOIMON"].Visible = false;
                    dgv_chitietgoimon.Columns["MONAN"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại");
            }
            
        }

        private void dgv_monan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txt_mamon.Text = dgv_monan.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void dgv_ban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txt_maban.Text = dgv_ban.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
