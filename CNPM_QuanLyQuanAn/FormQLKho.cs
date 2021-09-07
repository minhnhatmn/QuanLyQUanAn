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
    public partial class FormQLKho : Form
    {
        //XuLy xl = new XuLy();
        Handle_QLKho kho = new Handle_QLKho();
        public String txtval { get; set; }
        public FormQLKho()
        {
            InitializeComponent();
        }
        
        public void loadKho()
        {
            Handle_QLKho kho1 = new Handle_QLKho();
            dgv_nguyenlieu.DataSource = kho1.getNGUYENLIEU();
            dgv_lichsunhap_nguyenlieu.DataSource = kho1.getNGUYENLIEU();
            dgv_lichsuxuat_nguyenlieu.DataSource = kho1.getNGUYENLIEU();
            dgv_lichsunhap.DataSource = kho1.getNhapKho();
            dgv_lichsuxuat.DataSource = kho1.getXuatKho();
            dgv_lichsunhap.Columns["NHANVIEN"].Visible = false;
            dgv_lichsunhap.Columns["NGUYENLIEU"].Visible = false;
            dgv_lichsuxuat.Columns["NHANVIEN"].Visible = false;
            dgv_lichsuxuat.Columns["NGUYENLIEU"].Visible = false;
        }
        private void FormQLKho_Load(object sender, EventArgs e)
        {
            txt_qlnhap_manv.Text = txtval;
            txt_qlxuat_manv.Text = txtval;
            loadKho();
        }

        private void btn_qlxuat_them_Click(object sender, EventArgs e)
        {
            if (int.Parse(numb_qlxuat_soluong.Value.ToString()) == 0)
            {
                MessageBox.Show("Số lượng xuất phải lớn hơn 0", "Thông báo!"); 
                return;
            }
            if(txt_qlxuat_manl.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần xuất", "Thông báo!");
                return;
            }
            if (int.Parse(numb_qlxuat_soluong.Value.ToString()) > 0)
            {            
                
                int kq = kho.XUATKHO(txt_qlxuat_manl.Text, int.Parse(numb_qlxuat_soluong.Text), txt_qlxuat_manv.Text);
                if (kq == 1)
                {
                    loadKho();
                    MessageBox.Show("Xuất thành công", "Thông báo!");
                }
            }
            else
                MessageBox.Show("Xuất thất bại", "Thông báo!");
            //Load
            loadKho();
        }

        private void btn_qlnhap_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txt_qlnhap_soluong.Value.ToString()) > 0)
                {
                    int kq = kho.NHAPKHO(txt_qlnhap_manl.Text, int.Parse(txt_qlnhap_soluong.Value.ToString()), txt_nhacungcap.Text, int.Parse(txt_qlnhap_ngayhethan.Text), txt_qlnhap_manv.Text);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thành công");
                    }
                    else
                        MessageBox.Show("Thất bại");
                }
                loadKho();
            }
            catch (Exception)
            {
                
            }
        }
        private void btn_nguyenlieu_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nguyenlieu_manl.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mã nguyên liệu cần tìm kiếm", "Thông báo!");
                    return;
                }
                if (!kho.KiemtratrungMaNL(txt_nguyenlieu_manl.Text))
                {
                    MessageBox.Show("Không tìm thấy mã nguyên liệu trong hệ thống", "Thông báo");
                    return;
                }
                dgv_nguyenlieu.DataSource = kho.timNGUYENLIEU(txt_nguyenlieu_manl.Text);
            }
            catch (Exception)
            {
                
            }
            

        }

        private void dgv_lichsuxuat_nguyenlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_qlxuat_manl.Text =dgv_lichsuxuat_nguyenlieu.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void dgv_lichsunhap_nguyenlieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_qlnhap_manl.Text = dgv_lichsunhap_nguyenlieu.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void dgv_lichsunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_qlnhap_manl.Text= dgv_lichsunhap.CurrentRow.Cells[1].Value.ToString();
                txt_qlnhap_soluong.Text = dgv_lichsunhap.CurrentRow.Cells[2].Value.ToString();
                txt_nhacungcap.Text = dgv_lichsunhap.CurrentRow.Cells[3].Value.ToString();
                txt_qlnhap_ngayhethan.Text = dgv_lichsunhap.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void dgv_lichsuxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_qlxuat_manl.Text = dgv_lichsuxuat.CurrentRow.Cells[1].Value.ToString();
                numb_qlxuat_soluong.Text = dgv_lichsuxuat.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void dgv_lichsunhap_nguyenlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_qlxuat_manl.Text = dgv_lichsuxuat.CurrentRow.Cells[1].Value.ToString();
                numb_qlxuat_soluong.Text = dgv_lichsuxuat.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void dgv_nguyenlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_nguyenlieu_manl.Text = dgv_nguyenlieu.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadNL();
        }
        public void loadNL()
        {
            dgv_lichsunhap_nguyenlieu.DataSource = kho.getNGUYENLIEU();
            dgv_lichsuxuat_nguyenlieu.DataSource = kho.getNGUYENLIEU();
            dgv_nguyenlieu.DataSource = kho.getNGUYENLIEU();
        }

        private void btn_qlnhap_datlai_Click(object sender, EventArgs e)
        {
            loadNL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadNL();
        }
    }
}
