﻿using System;
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
    public partial class frmRandomCombo : Form
    {
        public frmRandomCombo()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RdoLess500_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnGenrate2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 50) - 1; i++)
            {
                CmbRandom2.Items.Add(r.Next(1, 100));
            }

        }

        private void rmRandomCombo_Load(object sender, EventArgs e)
        {

        }

        private void BtnGenrate1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 50) - 1; i++)
            {
                CmbRandom1.Items.Add(r.Next(1, 1000));
            }
        }

        private void CmbRandom1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRandomCombo_Load(object sender, EventArgs e)
        {

        }
    }
}





