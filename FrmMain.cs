using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_Part1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void chàoMừngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChaoMung c1 = new FrmChaoMung();
            c1.Show();
        }

        private void tínhTổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTinhTong c2 = new frmTinhTong();
            c2.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void tínhTổngBT1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTinhTongBT1 c3 = new FrmTinhTongBT1();
            c3.Show();
        }
    }
}
