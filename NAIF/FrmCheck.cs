using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAIF
{
    public partial class FrmCheck : Form
    {
        public FrmCheck()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (ChkCoffee.Checked == true)
            {
                msg = ChkCoffee.Text;
            }
            if (ChkDount.Checked == true)
            {
                msg = msg + " " + ChkDount.Text;
            }
            if (ChkBrawnie.Checked == true)
            {
                msg = msg + " " + ChkBrawnie.Text;
            }
            if (msg.Length > 0)
            {
                MessageBox.Show(msg + "ordered.");
            }
            else //length is zero
            {
                MessageBox.Show("Nothing ordered,sir/MmE");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
