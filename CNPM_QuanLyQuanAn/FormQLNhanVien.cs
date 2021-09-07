using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BUS;
namespace CNPM_QuanLyQuanAn
{
    public partial class FormQLNhanVien : Form
    {
        Handle_QLNhanVien qlnv = new Handle_QLNhanVien();
        public FormQLNhanVien()
        {
            InitializeComponent();
        }


        private void LoadNV()
        {
            txt_manv.Text = "";
            txt_tennv.Text = "";
            txt_cmnd.Text = "";
            txt_sdt.Text = "";
            dtp_ngaysinh.Text = "";
            cbo_ChucVu.Text = "";
            txt_matkhau.Text = "";
            txt_diachi.Text = "";
            radio_Nam.Checked = false;
            radio_Nu.Checked = false;
            dgv_nhanvien.DataSource = qlnv.GetNhanVien();
        }
        private void btn_nhanvien_them_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text.Trim() == "" || txt_tennv.Text.Trim() == "" || txt_cmnd.Text.Trim() == "" || txt_sdt.Text.Trim() == "" || dtp_ngaysinh.Text.Trim() == "" || cbo_ChucVu.Text.Trim() == "" || txt_matkhau.Text.Trim() == "" || txt_diachi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thêm", "Thông báo");
                return;
            }
            if (!radio_Nam.Checked && !radio_Nu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo");
                return;
            }
            if (!qlnv.KiemTraMatKhau(txt_matkhau.Text.ToString()))
            {
                MessageBox.Show("Mật khẩu phải từ 5 đến 15 ký tự, không có ký tự đặc biệt và phải có ít nhất 1 ký tự chữ và 1 ký tự số", "Thông báo");
                return;
            }
            if (qlnv.ktsuaSDT(txt_sdt.Text,txt_manv.Text)!=1)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo");
                return;
            }
            int tuoi = DateTime.Now.Year-dtp_ngaysinh.Value.Year;
            if (tuoi <= 18)
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên");
                return;
            }
            if (qlnv.ktsuaCMND(int.Parse(txt_cmnd.Text), txt_manv.Text) != 1)
            {
                MessageBox.Show("Số chứng minh không hợp lệ!", "Thông báo");
                return;
            }
            if (qlnv.KiemTraTrungCMND(int.Parse(txt_cmnd.Text)))
            {
                MessageBox.Show("Số chứng minh đã tồn tại!", "Thông báo");
                return;
            }
            if (qlnv.KiemTraTrungSDT(txt_sdt.Text))
            {
                MessageBox.Show("Số điện thoại đã được sử dụng!", "Thông báo");
                return;
            }
            if (qlnv.KiemTraTrungMaNV(txt_manv.Text.ToString()))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo");
                return;
            }
            try
            {
                    var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                              .FirstOrDefault(r => r.Checked);
                    string txt = checkedButton.Text;
                    int kt = qlnv.themNHANVIEN(txt_manv.Text, txt_tennv.Text, int.Parse(txt_cmnd.Text.Trim()), txt_sdt.Text, DateTime.Parse(dtp_ngaysinh.Text), txt, cbo_ChucVu.Text, txt_matkhau.Text, txt_diachi.Text);
                    if (kt == 1)
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                    LoadNV();
                
            }
            catch (Exception)
            {
                
            }
            
        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            //Set cung chuc vu
            cbo_ChucVu.Items.Add("Thu ngân");
            cbo_ChucVu.Items.Add("Phục vụ");
            cbo_ChucVu.Items.Add("Kiểm kho");
            cbo_ChucVu.Items.Add("Quản lý");

            //load
            dgv_nhanvien.DataSource = qlnv.GetNhanVien();
        }

        private void btn_nhanvien_xoa_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên để xóa", "Thông báo!");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn muốn xóa nhân viên " + txt_tennv.Text + " khỏi hệ thống?", "Thông báo!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Hủy xóa thành công", "Thông báo!");
                return;
            }
            if (result == DialogResult.OK)
            {
                qlnv.xoaNHANVIEN(txt_manv.Text);
                MessageBox.Show("Xoá thành công nhân viên " + txt_tennv.Text, "Thông báo!");
            }
            //Load lại 
            LoadNV();
        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manv.Text = dgv_nhanvien.CurrentRow.Cells[0].Value.ToString();
            txt_tennv.Text = dgv_nhanvien.CurrentRow.Cells[1].Value.ToString();
            txt_cmnd.Text = dgv_nhanvien.CurrentRow.Cells[2].Value.ToString();
            txt_sdt.Text = dgv_nhanvien.CurrentRow.Cells[3].Value.ToString();
            dtp_ngaysinh.Text = dgv_nhanvien.CurrentRow.Cells[4].Value.ToString();
            if (qlnv.KiemTraGioiTinh(dgv_nhanvien.CurrentRow.Cells[5].Value.ToString()))
            {
                radio_Nam.Checked = true;
            }
            else
                radio_Nu.Checked = true;
            cbo_ChucVu.Text = dgv_nhanvien.CurrentRow.Cells[6].Value.ToString();
            txt_matkhau.Text = dgv_nhanvien.CurrentRow.Cells[7].Value.ToString();
            txt_diachi.Text = dgv_nhanvien.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_nhanvien_sua_Click(object sender, EventArgs e)
        {
            if(!qlnv.KiemTraTrungMaNV(txt_manv.Text))
            {
                MessageBox.Show("Mã nhân viên không tồn tại", "Thông báo!");
                return;
            }

            try
            {
                if (txt_manv.Text.Trim() == "" || txt_tennv.Text.Trim() == "" || txt_cmnd.Text.Trim() == "" || txt_sdt.Text.Trim() == "" || dtp_ngaysinh.Text.Trim() == "" || cbo_ChucVu.Text.Trim() == "" || txt_matkhau.Text.Trim() == "" || txt_diachi.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thêm", "Thông báo");
                    return;
                }
                if (!radio_Nam.Checked && !radio_Nu.Checked)
                {
                    MessageBox.Show("Vui lòng chọn giới tính", "Thông báo");
                    return;
                }
                if (qlnv.ktsuaSDT(txt_sdt.Text, txt_manv.Text) != 1)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo");
                    return;
                }
                if (!qlnv.KiemTraMatKhau(txt_matkhau.Text.ToString()))
                {
                    MessageBox.Show("Mật khẩu phải từ 5 đến 15 ký tự, không có ký tự đặc biệt và phải có ít nhất 1 ký tự chữ và 1 ký tự số", "Thông báo");
                    return;
                }
                int tuoi = DateTime.Now.Year - dtp_ngaysinh.Value.Year;
                if (tuoi <= 18)
                {
                    MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên");
                    return;
                }
                if (qlnv.ktsuaCMND(int.Parse(txt_cmnd.Text), txt_manv.Text) != 1)
                {
                    MessageBox.Show("Số chứng minh không hợp lệ!", "Thông báo");
                    return;
                }
                //if (qlnv.KiemTraTrungSDT(txt_sdt.Text.ToString()))
                //{
                //    MessageBox.Show("Trùng số điện thoại!", "Thông báo");
                //    return;
                //}
                //if (qlnv.KiemTraTrungCMND(int.Parse(txt_sdt.Text.ToString())))
                //{
                //    MessageBox.Show("Trùng số chứng minh nhân dân!", "Thông báo");
                //    return;
                //}
                else
                {
                    var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                          .FirstOrDefault(r => r.Checked);
                    string txt = checkedButton.Text;
                    int kt = qlnv.suaNHANVIEN(txt_manv.Text, txt_tennv.Text, int.Parse(txt_cmnd.Text.Trim()), txt_sdt.Text, DateTime.Parse(dtp_ngaysinh.Text), txt, cbo_ChucVu.Text, txt_matkhau.Text, txt_diachi.Text);
                    if (kt == 1)
                    {
                        MessageBox.Show("Thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("That bai");
                    }
                    LoadNV();
                }
                
            }
            catch (Exception)
            {


            }
        }
    }
}
