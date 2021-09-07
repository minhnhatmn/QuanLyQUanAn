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
    public partial class FormThanhToan : Form
    {
        public String txtval { get; set; }
        Handle_ThanhToan thanhtoan = new Handle_ThanhToan();
        public FormThanhToan()
        {
            InitializeComponent();
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            txt_manv.Text = txtval;
            cbo_phuongthucthanhtoan.Items.Add("Thanh toán thẻ");
            cbo_phuongthucthanhtoan.Items.Add("Thanh toán tiền mặt");
            dgv_khachhang.DataSource = thanhtoan.GetKHACHHANG();
            loadDL();
        }
        public void loadDL()
        {
            dgv_datban.DataSource = thanhtoan.GetDATBAN();
            dgv_goimon.DataSource = thanhtoan.GetGoiMon();
            dgv_hoadon.DataSource = thanhtoan.GetHOADON();
            dgv_goimon.Columns["BAN"].Visible = false;
            dgv_goimon.Columns["NHANVIEN"].Visible = false;
            dgv_datban.Columns["BAN"].Visible = false;
            dgv_datban.Columns["NHANVIEN"].Visible = false;
            dgv_datban.Columns["KHACHHANG"].Visible = false;
            dgv_hoadon.Columns["DATBAN"].Visible = false;
            dgv_hoadon.Columns["GOIMON"].Visible = false;
            dgv_hoadon.Columns["KHACHHANG"].Visible = false;
            dgv_hoadon.Columns["NHANVIEN"].Visible = false;
        }

        private void dgv_goimon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgv_chitietgoimon.DataSource = thanhtoan.GetCTGM(dgv_goimon.CurrentRow.Cells[0].Value.ToString());
                dgv_chitietgoimon.Columns["GOIMON"].Visible = false;
                dgv_chitietgoimon.Columns["MONAN"].Visible = false;
                txt_magoimon.Text = dgv_goimon.CurrentRow.Cells[0].Value.ToString();
                txt_madatban.Text = "";
                txt_maban.Text = dgv_goimon.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                
            }
            
        }

        private void dgv_datban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgv_ctdatban.DataSource = thanhtoan.GetCTDB(dgv_datban.CurrentRow.Cells[0].Value.ToString());
                dgv_ctdatban.Columns["DATBAN"].Visible = false;
                dgv_ctdatban.Columns["MONAN"].Visible = false;
                txt_madatban.Text = dgv_datban.CurrentRow.Cells[0].Value.ToString();
                txt_magoimon.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_mahoadon.Text = dgv_hoadon.CurrentRow.Cells[0].Value.ToString();
                txt_makh.Text = dgv_hoadon.CurrentRow.Cells[2].Value.ToString();
                numb_tongtien.Text = dgv_hoadon.CurrentRow.Cells[4].Value.ToString();
                
                cbo_phuongthucthanhtoan.Text = dgv_hoadon.CurrentRow.Cells[5].Value.ToString();
                if (dgv_hoadon.CurrentRow.Cells[3].Value!=null)
                {

                    txt_magoimon.Text = dgv_hoadon.CurrentRow.Cells[3].Value.ToString();
                    dgv_chitiethoadon.DataSource= thanhtoan.GetCTGM(txt_magoimon.Text);
                    dgv_chitiethoadon.Columns["GOIMON"].Visible = false;
                    dgv_chitiethoadon.Columns["MONAN"].Visible = false;
                    //txt_mahoadon.Text = dgv_hoadon.CurrentRow.Cells[0].Value.ToString();
                    //txt_makh.Text = dgv_hoadon.CurrentRow.Cells[2].Value.ToString();
                    //txt_magoimon.Text = dgv_hoadon.CurrentRow.Cells[3].Value.ToString();
                    //numb_tongtien.Text = dgv_hoadon.CurrentRow.Cells[4].Value.ToString();
                    //cbo_phuongthucthanhtoan.SelectedValue = dgv_hoadon.CurrentRow.Cells[5].Value.ToString();
                    txt_maban.Text = thanhtoan.getMABAN_GOIMON(txt_magoimon.Text);
                    
                }
                else if (dgv_hoadon.CurrentRow.Cells[7].Value!=null)
                {
                    txt_madatban.Text = dgv_hoadon.CurrentRow.Cells[7].Value.ToString();
                    dgv_chitiethoadon.DataSource = thanhtoan.GetCTDB(txt_madatban.Text);
                    dgv_chitiethoadon.Columns["DATBAN"].Visible = false;
                    dgv_chitiethoadon.Columns["MONAN"].Visible = false;
                    //txt_mahoadon.Text = dgv_hoadon.CurrentRow.Cells[0].Value.ToString();
                    //txt_makh.Text = dgv_hoadon.CurrentRow.Cells[2].Value.ToString();
                    //txt_madatban.Text = dgv_hoadon.CurrentRow.Cells[7].Value.ToString();
                    //numb_tongtien.Text = dgv_hoadon.CurrentRow.Cells[4].Value.ToString();
                    //cbo_phuongthucthanhtoan.SelectedValue = dgv_hoadon.CurrentRow.Cells[5].Value.ToString();
                    txt_maban.Text = thanhtoan.getMABAN_DATBAN(txt_madatban.Text);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_timkiemkh_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_khachhang.DataSource = thanhtoan.timkiemKHACHHANG(txt_sdt.Text.Trim());
            }
            catch (Exception)
            {
                
            }
        }

        private void dgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_makh.Text = dgv_khachhang.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void btn_tinhtien_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_madatban.Text.Trim().Equals("") == false)
                {
                    numb_tongtien.Text = thanhtoan.tongtienDATBAN(txt_madatban.Text).ToString();
                }
                else if (txt_magoimon.Text.Trim().Equals("") == false)
                {
                    numb_tongtien.Text = thanhtoan.tongtienGOIMON(txt_magoimon.Text).ToString();
                }
            }
            catch (Exception)
            {
                
            }
            
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_madatban.Text.Trim().Equals("") == false)
                {
                    numb_tongtien.Text = thanhtoan.tongtienDATBAN(txt_madatban.Text).ToString();
                    txt_magoimon.Text = "";
                }
                else if (txt_magoimon.Text.Trim().Equals("") == false)
                {
                    numb_tongtien.Text = thanhtoan.tongtienGOIMON(txt_magoimon.Text).ToString();
                    txt_madatban.Text = "";
                }
                int kq = thanhtoan.themHOADON(txt_mahoadon.Text, txt_manv.Text, txt_makh.Text, cbo_phuongthucthanhtoan.SelectedItem.ToString(), txt_magoimon.Text, txt_madatban.Text, int.Parse(numb_tongtien.Text));
                if (kq == 1)
                {
                    MessageBox.Show("Thanh toán thành công");
                    loadDL();
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại");
                    loadDL();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thanh toán thất bại");
            }
        }
    }
}
