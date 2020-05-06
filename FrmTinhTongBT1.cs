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
    public partial class FrmTinhTongBT1 : Form
    {
        public FrmTinhTongBT1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn làm lại ");
            txtSoB.ResetText();
            txtSoB.Focus();
            txtSoA.ResetText();
            txtSoA.Focus();
            return;
        }

        private void btbTong_Click(object sender, EventArgs e)
        {

            if (txtSoA.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập a");
                txtSoA.Focus();
                return;
            }
            if (txtSoB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập b");
                txtSoB.Focus();
                return;
            }

            int tong = 0;
            int a = Convert.ToInt32(txtSoA.Text);
            int b = Convert.ToInt32(txtSoB.Text);
            for (int i = 1; i <=100; i++)
                tong = tong + i;
            
            lbTongBT1.Text = tong.ToString();
        }

        private void txtSoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.') ||
               (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtSoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.') ||
               (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
