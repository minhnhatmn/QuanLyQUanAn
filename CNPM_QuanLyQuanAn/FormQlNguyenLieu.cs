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
    public partial class FormQlNguyenLieu : Form
    {
        //XuLy xl = new XuLy();
        Handle_QLNguyenLieu qlnl = new Handle_QLNguyenLieu();
        public FormQlNguyenLieu()
        {
            InitializeComponent();
        }

        private void btn_nguyenlieu_them_Click(object sender, EventArgs e)
        {
            if (txt_nguyenlieu_manl.Text.Trim() == "" || txt_nguyenlieu_tennl.Text.Trim() == "" || txt_nguyenlieu_dvt.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin cần thêm", "Thông báo!");
                return;
            }
            if(qlnl.KiemtratrungMaNL(txt_nguyenlieu_manl.Text))
            {
                MessageBox.Show("Mã nguyên liệu đã có trong hệ thống", "Thông báo!");
                return;
            }
            if (qlnl.KiemtratrungTenNL(txt_nguyenlieu_tennl.Text))
            {
                MessageBox.Show("Tên nguyên liệu đã có trong hệ thống", "Thông báo!");
                return;
            } if (!qlnl.KiemtratrungMaNL(txt_nguyenlieu_manl.Text) && !qlnl.KiemtratrungTenNL(txt_nguyenlieu_tennl.Text))
            {
                DialogResult result = MessageBox.Show("Bạn muốn thêm nguyên liệu?", "Thông báo!", MessageBoxButtons.OKCancel);
                if(result == DialogResult.Cancel)
                {
                    MessageBox.Show("Hủy thêm thành công", "Thông báo!");
                    return;
                }
                if (result == DialogResult.OK)
                {
                    qlnl.themNGUYENLIEU(txt_nguyenlieu_manl.Text, txt_nguyenlieu_tennl.Text, txt_nguyenlieu_dvt.Text);
                    MessageBox.Show("Thêm thành công " + txt_nguyenlieu_tennl.Text, "Thông báo!");
                }
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo!");

            //Load
            dgv_nguyenlieu.DataSource = qlnl.getNGUYENLIEU();
        }

        private void FormQlNguyenLieu_Load(object sender, EventArgs e)
        {
            dgv_nguyenlieu.DataSource = qlnl.getNGUYENLIEU();
        }

        private void btn_nguyenlieu_xoa_Click(object sender, EventArgs e)
        {
            if (txt_nguyenlieu_manl.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần xóa", "Thông báo!");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn muốn xóa nguyên liệu " + txt_nguyenlieu_tennl.Text, "Thông báo!", MessageBoxButtons.OKCancel);
            if(result == DialogResult.Cancel)
            {
                MessageBox.Show("Huỷ xóa nguyên liệu thành công", "Thông báo!");
                return;
            }
            if(result == DialogResult.OK)
            {
                qlnl.xoaNGUYENLIEU(txt_nguyenlieu_manl.Text);
                MessageBox.Show("Xóa nguyên liệu thành công", "Thông báo!");
            }
            else
                MessageBox.Show("Xóa thất bại", "Thông báo!");
           
            //Load
            dgv_nguyenlieu.DataSource = qlnl.getNGUYENLIEU();
        }



        private void btn_nguyenlieu_timkiem_Click(object sender, EventArgs e)
        {
            if(txt_nguyenlieu_manl.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã nguyên liệu cần tìm kiếm", "Thông báo!");
                return;
            }
            if(!qlnl.KiemtratrungMaNL(txt_nguyenlieu_manl.Text))
            {
                MessageBox.Show("Không tìm thấy mã nguyên liệu trong hệ thống", "Thông báo");
                return;
            }
            dgv_nguyenlieu.DataSource = qlnl.timNGUYENLIEU(txt_nguyenlieu_manl.Text);
        }

        private void dgv_nguyenlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nguyenlieu_manl.Text = dgv_nguyenlieu.CurrentRow.Cells[0].Value.ToString();
            txt_nguyenlieu_tennl.Text = dgv_nguyenlieu.CurrentRow.Cells[1].Value.ToString();
            txt_nguyenlieu_dvt.Text = dgv_nguyenlieu.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
