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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void gọiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            FormGoiMon frm = new FormGoiMon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thốngKêKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            FormQLKho frm = new FormQLKho();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
