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
    public partial class Frmradio : Form
    {
        public Frmradio()
        {
            InitializeComponent();
        }

        private void Rdored_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdored.Checked == true)
                Rdored.ForeColor = Color.FromName("red");
            else
                Rdored.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void RdoGreen_Changed(object sender, EventArgs e)
        {
            if (RdoGreen.Checked == true)
                RdoGreen.ForeColor = Color.FromName("Green");
            else
                RdoGreen.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue.Checked == true)
                RdoBlue.ForeColor = Color.FromName("blue");
            else
                RdoBlue.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow.Checked == true)
                RdoYellow.ForeColor = Color.FromName("Yellow");
            else
                RdoYellow.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
