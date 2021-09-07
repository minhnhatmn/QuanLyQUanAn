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
    public partial class FormMonAn : Form
    {
        //XuLy xl = new XuLy();
        Handle_MonAN monan = new Handle_MonAN();
        public FormMonAn()
        {
            InitializeComponent();
        }

        private void FormMonAn_Load(object sender, EventArgs e)
        {
            LoadMonAn();
        }
        private void LoadMonAn()
        {
            dgv_monan.DataSource = monan.getMONAN();
            txt_mamon.Text = "";
            txt_tenmon.Text = "";
            txt_gia.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_tenmon.Text.Trim() == "" || txt_mamon.Text.Trim() == "" || txt_gia.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thêm", "Thông báo");
                return;
            }
            if (monan.KiemtratrungMaMon(txt_mamon.Text))
            {
                MessageBox.Show("Trùng mã món ăn trong hệ thống");
                return;
            } 
            if (monan.KiemtratrungTenMon(txt_tenmon.Text))
            {
                MessageBox.Show("Trùng tên món ăn trong hệ thống");
                return;
            }
            if (!monan.KiemtratrungMaMon(txt_mamon.Text) && !monan.KiemtratrungTenMon(txt_tenmon.Text))
            {
                DialogResult result = MessageBox.Show("Bạn muốn thêm món " + txt_tenmon.Text + " vào hệ thống?", "Thông báo!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Hủy thêm món thành công", "Thông báo!");
                    return;
                }
                if (result == DialogResult.OK)
                {
                    monan.themMONAN(txt_mamon.Text, txt_tenmon.Text, int.Parse(txt_gia.Text.Trim()));
                    MessageBox.Show("Thêm món thành công", "Thông báo!");
                }
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo!");
            //Load lai
            LoadMonAn();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_tenmon.Text.Trim() == "" || txt_mamon.Text.Trim() == "" || txt_gia.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa", "Thông báo!");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn muốn sửa thông tin trong hệ thống?", "Thông báo!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                monan.xoaMONAN(txt_mamon.Text);
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Hủy xóa thành công", "Thông báo");
                return;
            }
            else
                MessageBox.Show("Xóa thất bại", "Thông báo");

            //Load lai
            LoadMonAn();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_tenmon.Text.Trim() == "" || txt_mamon.Text.Trim() == "" || txt_gia.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn muốn sửa thông tin trong hệ thống?", "Thông báo!", MessageBoxButtons.OKCancel); 
            if(result == DialogResult.OK)
            {
                if(monan.KiemtratrungTenMon(txt_tenmon.Text) && monan.KiemtratrungMaMon(txt_mamon.Text))
                {
                    MessageBox.Show("Tên món ăn cần sửa không được trùng với hệ thống", "Thông báo!");
                    return;
                }
                if(!monan.KiemtratrungMaMon(txt_mamon.Text))
                {
                    DialogResult kq = MessageBox.Show("Bạn muốn thêm thông tin trong hệ thống?", "Thông báo!", MessageBoxButtons.OKCancel); 

                }
                else
                {
                    monan.suaMONAN(txt_mamon.Text, txt_tenmon.Text, int.Parse(txt_gia.Text.Trim()));
                    MessageBox.Show("Sửa thành công", "Thông báo!");
                }
            }
            if(result == DialogResult.Cancel)
            {
                MessageBox.Show("Huỷ sửa món thành công", "Thông báo!");
                return;
            }
 
            else
                MessageBox.Show("Sửa thất bại", "Thông báo!");

            //Load lai
            LoadMonAn();
        }

        private void dgv_monan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_mamon.Text = dgv_monan.CurrentRow.Cells[0].Value.ToString();
                txt_tenmon.Text = dgv_monan.CurrentRow.Cells[1].Value.ToString();
                txt_gia.Text = dgv_monan.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
            
        }
    }
}
