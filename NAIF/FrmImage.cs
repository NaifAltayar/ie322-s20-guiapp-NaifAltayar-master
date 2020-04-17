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
    public partial class FrmImage : Form
    {
        public FrmImage()
        {
            InitializeComponent();
        }

        private void BtnImage_Click(object sender, EventArgs e)
        {
            PicTry1.Image = Image.FromFile("C:\\IE322_1845264\\NAIF\\Naif123.jpeg");
        }

        private void FrmImage_Load(object sender, EventArgs e)
        {

        }
    }
}
