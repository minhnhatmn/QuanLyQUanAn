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
    public partial class FormQuanLy : Form
    {
        public String txtval { get; set; }
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            label1.Text = txtval;
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            FormBan frm = new FormBan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            FormMonAn frm = new FormMonAn();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            FormQLNhanVien frm = new FormQLNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            FormQlNguyenLieu frm = new FormQlNguyenLieu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormQuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
        }
    }
}
