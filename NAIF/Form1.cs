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
	public partial class Frmmain : Form
	{
		int x = 1;
		public Frmmain()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if(txtuser.Text=="Naif" && txtpassword.Text=="1234")
			{
				MessageBox.Show("Login Successful");
			}
			else
			{
				MessageBox.Show("Login failed");
			} 
			if (x >= 3)
			{
				MessageBox.Show("Program Terminated");
				Application.Exit();
			}
			if (txtuser.Text == "hi")
			{
				MessageBox.Show("WELCOME");
			}
			else
			{
				x++;
				MessageBox.Show("Invalid Password - Try Again");
				txtuser.Text = "";
			}
		}

		private void btnradio_Click(object sender, EventArgs e)
		{
			Frmradio frm = new Frmradio();
			frm.ShowDialog();
		}

		private void btncheckbox_Click(object sender, EventArgs e)
		{
			FrmCheck frm = new FrmCheck();
			frm.ShowDialog();
		}

		private void btnCombo_Click(object sender, EventArgs e)
		{
			FrmCombo frm = new FrmCombo();
			frm.ShowDialog();
		}

		private void btnRandomCombo_Click(object sender, EventArgs e)
		{
			frmRandomCombo frm = new frmRandomCombo();
			frm.ShowDialog();
		}

		private void btnRandom_Click(object sender, EventArgs e)
		{
			FrmRandom frm = new FrmRandom ();
			frm.ShowDialog();
		}

		private void btnpicturebox_Click(object sender, EventArgs e)
		{
			FrmImage frm = new FrmImage();
			frm.ShowDialog();
		}

		private void ll_Enter(object sender, EventArgs e)
		{

		}

		private void Frmmain_Load(object sender, EventArgs e)
		{

		}

		private void Array_Click(object sender, EventArgs e)
		{
			frmArray frm = new frmArray();
			frm.ShowDialog();
		}
	}
}