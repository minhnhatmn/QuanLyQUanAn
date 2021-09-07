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
    public partial class FormThuKho : Form
    {
        public String txtval { get; set; }
        public FormThuKho()
        {
            InitializeComponent();
        }

        private void FormThuKho_Load(object sender, EventArgs e)
        {
            label1.Text = txtval;
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            FormQLKho frm = new FormQLKho();
            frm.MdiParent = this;
            frm.txtval = label1.Text;     
            frm.Show();
        }

        private void FormThuKho_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
        }
    }
}
