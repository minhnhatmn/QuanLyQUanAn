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
    public partial class FormBan : Form
    {
        XuLy xl = new XuLy();
        Handle_Ban ban = new Handle_Ban();
        public FormBan()
        {
            InitializeComponent();
        }

        private void FormBan_Load(object sender, EventArgs e)
        {
            dgv_ban.DataSource = ban.GetBan();

            cbo_loaiban.Items.Add("VIP");
            cbo_loaiban.Items.Add("Bàn gia đình");
            cbo_loaiban.Items.Add("Bàn cặp đôi");
            cbo_loaiban.Items.Add("Bàn tiệc");

            //cbo_loaiban.DataSource = ban.GetBan();
            //cbo_loaiban.DisplayMember = "LOAIBAN";
            //cbo_loaiban.ValueMember = "MABAN";
        }

        private void btn_ban_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ban_maban.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo!");
                    return;
                }
                if (cbo_loaiban.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng chọn loại bàn", "Thông báo!");
                    return;
                }
                if (ban.KiemtratrungMaBan(txt_ban_maban.Text))
                {
                    MessageBox.Show("Trùng mã bàn, vui lòng đổi mã bàn cần thêm", "Thông báo!");
                    return;
                }
                if (!ban.KiemtratrungMaBan(txt_ban_maban.Text))
                {
                    ban.ThemBan(txt_ban_maban.Text.Trim(), cbo_loaiban.Text.Trim(), "Trống");
                    MessageBox.Show("Thêm thành công bàn " + txt_ban_maban.Text, "Thông báo!");
                }
                else
                    MessageBox.Show("Thêm thất bại", "Thông báo!");
                //Load lại 
                dgv_ban.DataSource = ban.GetBan();
                txt_ban_maban.Text = "";
                cbo_loaiban.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo!");
            }
            

        }

        private void btn_ban_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa bàn " + txt_ban_maban.Text + " khỏi hệ thống?", "Thông báo!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Hủy xóa bàn thành công", "Thông báo!");
                    return;
                }
                if (result == DialogResult.OK)
                {
                    ban.XoaBan(txt_ban_maban.Text);
                }
                //Load lại 
                dgv_ban.DataSource = ban.GetBan();
                txt_ban_maban.Text = "";
                cbo_loaiban.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo!");
            }
            
        }

        private void btn_ban_sua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn muốn sửa bàn " + txt_ban_maban.Text, "Thông báo!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Hủy sửa bàn thành công", "Thông báo!");
                    return;
                }
                if (result == DialogResult.OK)
                {
                    if (ban.KiemtratrungMaBan(txt_ban_maban.Text) && ban.KiemtratrungLoaiBan(cbo_loaiban.Text))
                    {
                        ban.SuaBan(txt_ban_maban.Text, cbo_loaiban.Text);
                        MessageBox.Show("Sửa thành công", "Thông báo");
                    }
                    else
                        return;
                }

                //Load lại 
                dgv_ban.DataSource = ban.GetBan();
                txt_ban_maban.Text = "";
                cbo_loaiban.Text = "";
            }
            catch (Exception)
            {
                
            }
        }

        private void dgv_ban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ban_maban.Text = dgv_ban.CurrentRow.Cells[0].Value.ToString();
            cbo_loaiban.Text = dgv_ban.CurrentRow.Cells[1].Value.ToString();
        }

   
    }
}
