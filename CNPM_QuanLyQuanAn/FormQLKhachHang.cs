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
    public partial class FormQLKhachHang : Form
    {
        Handle_QLKhachHang qlkh = new Handle_QLKhachHang();

        public FormQLKhachHang()
        {
            InitializeComponent();
        }

        private void FormQLKhachHang_Load(object sender, EventArgs e)
        {
            dgv_khachhang.DataSource = qlkh.GetKhachHang();

        }

        private void dgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = dgv_khachhang.CurrentRow.Cells[0].Value.ToString();
            txt_tenkh.Text = dgv_khachhang.CurrentRow.Cells[1].Value.ToString();
            txt_sdtkh.Text = dgv_khachhang.CurrentRow.Cells[2].Value.ToString();
            txt_ngaysinh.Text = dgv_khachhang.CurrentRow.Cells[3].Value.ToString();
            if(qlkh.KiemTraGioiTinh(dgv_khachhang.CurrentRow.Cells[4].Value.ToString()))
            {
                radio_Nam.Checked = true;
            }
            else 
                radio_Nu.Checked = true;
        }
        //Load KH
        private void LoadKhachHang()
        {
            dgv_khachhang.DataSource = qlkh.GetKhachHang();
            txt_makh.Text = "";
            txt_tenkh.Text = "";
            txt_sdtkh.Text = "";
            txt_ngaysinh.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text.Trim() == "" && txt_tenkh.Text.Trim() == "" && txt_sdtkh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                return;
            }
            if (qlkh.KiemTraSDT(txt_sdtkh.Text.ToString()) == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo");
                return;
            }
            if (txt_ngaysinh.Value.Year >= 2009)
            {
                MessageBox.Show("Thành viên phải từ 12 tuổi trở lên");
                return;
            }
            if (qlkh.KiemtratrungMaKH(txt_makh.Text))
            {
                MessageBox.Show("Mã thành viên đã tồn tại", "Thông báo");
                return;
            }
            if (qlkh.KiemtratrungSDT(txt_sdtkh.Text))
            {
                MessageBox.Show("Số điện thoại đã đăng ký thành viên", "Thông báo");
                return;
            }
            if (!qlkh.KiemtratrungMaKH(txt_makh.Text))
            {
                if(radio_Nam.Checked == true)
                {
                    qlkh.ThemKH(txt_makh.Text, txt_tenkh.Text, txt_sdtkh.Text, txt_ngaysinh.Text, radio_Nam.Text, 0);
                    MessageBox.Show("Thêm thành công thành viên " + txt_tenkh.Text.ToString(), "Thông báo");
                }
                else
                {
                    qlkh.ThemKH(txt_makh.Text, txt_tenkh.Text, txt_sdtkh.Text, txt_ngaysinh.Text, radio_Nu.Text, 0);
                    MessageBox.Show("Thêm thành công thành viên " + txt_tenkh.Text.ToString(), "Thông báo");
                }
            }

            //Load lại 
            LoadKhachHang();
        }
       
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(txt_makh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Thông báo");
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa thành viên " + txt_tenkh.Text + " khỏi hệ thống?", "Thông báo!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Hủy xóa bàn thành công", "Thông báo!");
                    return;
                }
                if (result == DialogResult.OK)
                {
                    qlkh.XoaNV(txt_makh.Text);
                    MessageBox.Show("Xoá thành công thành viên " + txt_tenkh.Text, "Thông báo!");
                }
                //Load lại 
                LoadKhachHang();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo!");
            }            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //Khong duoc trung sdt
            if (!qlkh.KiemtratrungSDT(txt_sdtkh.Text))
            {
                if (radio_Nam.Checked == true)
                {
                    qlkh.SuaKH(txt_makh.Text, txt_tenkh.Text, txt_sdtkh.Text, txt_ngaysinh.Text, radio_Nam.Text);
                    MessageBox.Show("Sửa thành công thành viên " + txt_tenkh.Text, "Thông báo");
                }
                else
                {
                    qlkh.SuaKH(txt_makh.Text, txt_tenkh.Text, txt_sdtkh.Text, txt_ngaysinh.Text, radio_Nu.Text);
                    MessageBox.Show("Sửa thành công thành viên " + txt_tenkh.Text, "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Sửa thất bại thành viên " + txt_tenkh.Text, "Thông báo");
                return;
            }
            //Load lại 
            LoadKhachHang();

        }
    }
}
