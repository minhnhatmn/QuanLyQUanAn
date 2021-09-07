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
    public partial class FormDatBan : Form
    {
        XuLy xl = new XuLy();
        Handle_DatBan datban = new Handle_DatBan();
        public String txtval { get; set; }

        public FormDatBan()
        {
            InitializeComponent();
        }
        public void LoadDatBan()
        {
            dgv_ban.DataSource = datban.GetBan();
            dgv_datban.DataSource = datban.GetDatBan();
            dgv_khachhang.DataSource = datban.GetKhachHang();
            dgv_monan.DataSource = datban.GetMonAn();
        }
        private void FormDatBan_Load(object sender, EventArgs e)
        {
            LoadDatBan();
            txt_manv.Text = txtval;
        }

        private void btnThemDatban_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_madat.Text.Trim() == "" || txt_datban_maban.Text.Trim() == "" || txt_makh.Text.Trim() == "" || dtp_thoigiandat.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thêm", "Thông báo!");
                    return;
                }
                if (datban.KiemtratrungMaDatBan(txt_madat.Text))
                {
                    MessageBox.Show("Trùng mã đặt bàn trong hệ thống", "Thông báo!");
                    return;
                }
                if (!datban.KiemtratrungMaDatBan(txt_madat.Text))
                {
                    DialogResult result = MessageBox.Show("Bạn muốn đặt bàn?", "Thông báo!", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Hủy đặt bàn thành công", "Thông báo!");
                        return;
                    }
                    if (result == DialogResult.OK)
                    {
                        datban.ThemDatBan(txt_madat.Text, txt_manv.Text, txt_makh.Text, DateTime.Parse(dtp_thoigiandat.Text), txt_datban_maban.Text, txt_thoigian.Text);
                        MessageBox.Show("Đặt bàn thành công, vui lòng nhập thêm món", "Thông báo!");
                    }
                }
                else
                    MessageBox.Show("Thêm thất bại", "Thông báo");

                //load
                LoadDatBan();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }
            
        }

        private void dgv_ban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_datban_maban.Text = dgv_ban.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = dgv_khachhang.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_monan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mamon.Text = dgv_monan.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_datban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_madat.Text = dgv_datban.CurrentRow.Cells[0].Value.ToString();            
            txt_makh.Text = dgv_datban.CurrentRow.Cells[2].Value.ToString();
            dtp_thoigiandat.Text = dgv_datban.CurrentRow.Cells[4].Value.ToString();
            txt_datban_maban.Text = dgv_datban.CurrentRow.Cells[5].Value.ToString();
            txt_thoigian.Text= dgv_datban.CurrentRow.Cells[6].Value.ToString();
            //chitiet
            txt_ctdatban_madat.Text = dgv_datban.CurrentRow.Cells[0].Value.ToString();
            dgv_chitietdatban.DataSource = datban.GetCHITIETDATBAN(dgv_datban.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnSuaDatban_Click(object sender, EventArgs e)
        {
            try
            {
                int kt = datban.SuaDatBan(txt_madat.Text, txt_manv.Text, txt_makh.Text, DateTime.Parse(dtp_thoigiandat.Text), txt_datban_maban.Text, txt_thoigian.Text);
                if (kt == 1)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
                //Load
                LoadDatBan();
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại");
            }
            
        }

        private void btnXoaDatban_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_madat.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng chọn thông tin cần xóa", "Thông báo!");
                    return;
                }
                int kt = datban.XoaDatBan(txt_madat.Text);
                if (kt == 1)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
                //Load
                LoadDatBan();
                //Load
                LoadDatBan();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại");
            }
            
        }

        private void dgv_chitietdatban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_ctdatban_madat.Text = dgv_chitietdatban.CurrentRow.Cells[1].Value.ToString();
                txt_mamon.Text = dgv_chitietdatban.CurrentRow.Cells[2].Value.ToString();
                numb_soluong.Value = int.Parse(dgv_chitietdatban.CurrentRow.Cells[3].Value.ToString());
                txt_stt.Text = dgv_chitietdatban.CurrentRow.Cells[0].Value.ToString();
                //datban
                txt_madat.Text = dgv_chitietdatban.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ctdatban_madat.Text.Trim() == "" || txt_mamon.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin cần thêm", "Thông báo!");
                    return;
                }
                if (int.Parse(numb_soluong.Value.ToString()) == 0)
                {
                    MessageBox.Show("Số lượng món phải lớn hơn 0", "Thông báo!");
                    return;
                }
                if (datban.KiemtratrungMaDatBan(txt_madat.Text))
                {
                    DialogResult result = MessageBox.Show("Bạn muốn đặt món?", "Thông báo!", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Huỷ đặt món thành công", "Thông báo!");
                        return;
                    }
                    if (result == DialogResult.OK)
                    {
                        int kt = datban.ThemCTDatBan(txt_madat.Text, txt_mamon.Text, int.Parse(numb_soluong.Value.ToString()));
                        if (kt == 1)
                        {
                            MessageBox.Show("Thêm thành công");
                            dgv_chitietdatban.DataSource = datban.GetCHITIETDATBAN(txt_datban_maban.Text);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bạn");
                        }
                    }
                }

                else
                    MessageBox.Show("Thêm thất bại", "Thông báo!");

                //Load
                LoadDatBan();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo!");
            }
            
            
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ctdatban_madat.Text.Trim() == "" || txt_mamon.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng chọn thông tin cần xóa", "Thông báo!");
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn muốn xóa thông tin?", "Thông báo!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Huỷ xóa thành công", "Thông báo!");
                    return;
                }
                if (result == DialogResult.OK)
                {
                    datban.XoaCTDatBan(int.Parse(txt_stt.Text));
                    MessageBox.Show("Xóa thành công", "Thông báo!");
                    dgv_chitietdatban.DataSource = datban.GetCHITIETDATBAN(txt_datban_maban.Text);
                }

                else
                    MessageBox.Show("Xóa thất bại", "Thông báo");

                //Load
                LoadDatBan();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn muốn sửa thông tin?", "Thông báo!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Huỷ sửa thành công", "Thông báo!");
                    return;
                }
                if (result == DialogResult.OK)
                {
                    if (int.Parse(numb_soluong.Value.ToString()) == 0)
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo!");
                        return;
                    }
                    else
                    {
                        datban.SuaCTDatBan(int.Parse(txt_stt.Text), txt_mamon.Text, int.Parse(numb_soluong.Value.ToString()));
                        MessageBox.Show("Sửa thành công", "Thông báo!");
                        dgv_chitietdatban.DataSource = datban.GetCHITIETDATBAN(txt_datban_maban.Text);
                    }
                }

                else
                    MessageBox.Show("Sửa thất bại", "Thông báo");

                //Load
                LoadDatBan();
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo");
            }
            
        }

        private void TimDatBan_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_datban.DataSource = datban.TimDatBan(DateTime.Parse(dtp_thoigiandat.Text), txt_thoigian.Text);
            }
            catch (Exception)
            {
                
            }
            
        }

        private void btn_datlai_Click(object sender, EventArgs e)
        {
            LoadDatBan();
        }
    }
}
