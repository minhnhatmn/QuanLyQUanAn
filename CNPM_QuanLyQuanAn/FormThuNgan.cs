using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QuanLyQuanAn
{
    public partial class FormThuNgan : Form
    {
        public String txtval { get; set; }
       
        public FormThuNgan()
        {
            InitializeComponent();
        }

        private void kiểmTraThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            FormQLKhachHang frm = new FormQLKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormThuNgan_Load(object sender, EventArgs e)
        {
            label1.Text = txtval;
        }

        private void đặtBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            FormDatBan frm = new FormDatBan();
            frm.MdiParent = this;
            frm.txtval = label1.Text;
            frm.Show();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            FormThanhToan frm = new FormThanhToan();
            frm.MdiParent = this;
            frm.txtval = label1.Text;
            frm.Show();
        }

        private void FormThuNgan_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
        }
    }
}
