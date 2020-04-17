namespace NAIF
{
	partial class Frmmain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.ll = new System.Windows.Forms.GroupBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnTools = new System.Windows.Forms.GroupBox();
            this.btnpicturebox2 = new System.Windows.Forms.Button();
            this.btnpicturebox = new System.Windows.Forms.Button();
            this.btnRandomCombo = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btncheckbox = new System.Windows.Forms.Button();
            this.btnradio = new System.Windows.Forms.Button();
            this.btnApps = new System.Windows.Forms.GroupBox();
            this.btnGroupieApp = new System.Windows.Forms.Button();
            this.btnselfieApp = new System.Windows.Forms.Button();
            this.txtFunctions = new System.Windows.Forms.GroupBox();
            this.btnTalk = new System.Windows.Forms.Button();
            this.ABCAnalysis = new System.Windows.Forms.Button();
            this.Draw = new System.Windows.Forms.Button();
            this.btnArduino = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnJohari = new System.Windows.Forms.Button();
            this.btnCell = new System.Windows.Forms.GroupBox();
            this.btnRoboticCell = new System.Windows.Forms.Button();
            this.btnManufacturingCell = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.Array = new System.Windows.Forms.Button();
            this.ll.SuspendLayout();
            this.btnTools.SuspendLayout();
            this.btnApps.SuspendLayout();
            this.txtFunctions.SuspendLayout();
            this.btnCell.SuspendLayout();
            this.SuspendLayout();
            // 
            // ll
            // 
            this.ll.Controls.Add(this.lblpassword);
            this.ll.Controls.Add(this.lblusername);
            this.ll.Controls.Add(this.txtpassword);
            this.ll.Controls.Add(this.txtuser);
            this.ll.Location = new System.Drawing.Point(36, 41);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(277, 100);
            this.ll.TabIndex = 0;
            this.ll.TabStop = false;
            this.ll.Text = "Login";
            this.ll.Enter += new System.EventHandler(this.ll_Enter);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(41, 71);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 5;
            this.lblpassword.Text = "password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(38, 32);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(54, 13);
            this.lblusername.TabIndex = 4;
            this.lblusername.Text = "username";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(156, 62);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 3;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(156, 23);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 2;
            // 
            // btnTools
            // 
            this.btnTools.Controls.Add(this.Array);
            this.btnTools.Controls.Add(this.btnpicturebox2);
            this.btnTools.Controls.Add(this.btnpicturebox);
            this.btnTools.Controls.Add(this.btnRandomCombo);
            this.btnTools.Controls.Add(this.btnCombo);
            this.btnTools.Controls.Add(this.btncheckbox);
            this.btnTools.Controls.Add(this.btnradio);
            this.btnTools.Location = new System.Drawing.Point(379, 41);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(234, 181);
            this.btnTools.TabIndex = 1;
            this.btnTools.TabStop = false;
            this.btnTools.Text = "Tools";
            // 
            // btnpicturebox2
            // 
            this.btnpicturebox2.Location = new System.Drawing.Point(119, 105);
            this.btnpicturebox2.Name = "btnpicturebox2";
            this.btnpicturebox2.Size = new System.Drawing.Size(75, 23);
            this.btnpicturebox2.TabIndex = 5;
            this.btnpicturebox2.Text = "picturebox2";
            this.btnpicturebox2.UseVisualStyleBackColor = true;
            // 
            // btnpicturebox
            // 
            this.btnpicturebox.Location = new System.Drawing.Point(6, 105);
            this.btnpicturebox.Name = "btnpicturebox";
            this.btnpicturebox.Size = new System.Drawing.Size(75, 23);
            this.btnpicturebox.TabIndex = 4;
            this.btnpicturebox.Text = "Picturebox";
            this.btnpicturebox.UseVisualStyleBackColor = true;
            this.btnpicturebox.Click += new System.EventHandler(this.btnpicturebox_Click);
            // 
            // btnRandomCombo
            // 
            this.btnRandomCombo.Location = new System.Drawing.Point(119, 62);
            this.btnRandomCombo.Name = "btnRandomCombo";
            this.btnRandomCombo.Size = new System.Drawing.Size(95, 23);
            this.btnRandomCombo.TabIndex = 3;
            this.btnRandomCombo.Text = "RandomCombo";
            this.btnRandomCombo.UseVisualStyleBackColor = true;
            this.btnRandomCombo.Click += new System.EventHandler(this.btnRandomCombo_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(6, 59);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(75, 23);
            this.btnCombo.TabIndex = 2;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btncheckbox
            // 
            this.btncheckbox.Location = new System.Drawing.Point(119, 21);
            this.btncheckbox.Name = "btncheckbox";
            this.btncheckbox.Size = new System.Drawing.Size(75, 23);
            this.btncheckbox.TabIndex = 1;
            this.btncheckbox.Text = "checkbox";
            this.btncheckbox.UseVisualStyleBackColor = true;
            this.btncheckbox.Click += new System.EventHandler(this.btncheckbox_Click);
            // 
            // btnradio
            // 
            this.btnradio.Location = new System.Drawing.Point(6, 23);
            this.btnradio.Name = "btnradio";
            this.btnradio.Size = new System.Drawing.Size(75, 23);
            this.btnradio.TabIndex = 0;
            this.btnradio.Text = "Radio";
            this.btnradio.UseVisualStyleBackColor = true;
            this.btnradio.Click += new System.EventHandler(this.btnradio_Click);
            // 
            // btnApps
            // 
            this.btnApps.Controls.Add(this.btnGroupieApp);
            this.btnApps.Controls.Add(this.btnselfieApp);
            this.btnApps.Location = new System.Drawing.Point(677, 41);
            this.btnApps.Name = "btnApps";
            this.btnApps.Size = new System.Drawing.Size(200, 100);
            this.btnApps.TabIndex = 2;
            this.btnApps.TabStop = false;
            this.btnApps.Text = "Apps";
            // 
            // btnGroupieApp
            // 
            this.btnGroupieApp.Location = new System.Drawing.Point(98, 32);
            this.btnGroupieApp.Name = "btnGroupieApp";
            this.btnGroupieApp.Size = new System.Drawing.Size(75, 23);
            this.btnGroupieApp.TabIndex = 1;
            this.btnGroupieApp.Text = "GroupieApp";
            this.btnGroupieApp.UseVisualStyleBackColor = true;
            // 
            // btnselfieApp
            // 
            this.btnselfieApp.Location = new System.Drawing.Point(17, 32);
            this.btnselfieApp.Name = "btnselfieApp";
            this.btnselfieApp.Size = new System.Drawing.Size(75, 23);
            this.btnselfieApp.TabIndex = 0;
            this.btnselfieApp.Text = "selfieApp";
            this.btnselfieApp.UseVisualStyleBackColor = true;
            // 
            // txtFunctions
            // 
            this.txtFunctions.Controls.Add(this.btnTalk);
            this.txtFunctions.Controls.Add(this.ABCAnalysis);
            this.txtFunctions.Controls.Add(this.Draw);
            this.txtFunctions.Controls.Add(this.btnArduino);
            this.txtFunctions.Controls.Add(this.btnTimer);
            this.txtFunctions.Controls.Add(this.btnProgress);
            this.txtFunctions.Controls.Add(this.btnRandom);
            this.txtFunctions.Controls.Add(this.btnJohari);
            this.txtFunctions.Location = new System.Drawing.Point(237, 265);
            this.txtFunctions.Name = "txtFunctions";
            this.txtFunctions.Size = new System.Drawing.Size(573, 100);
            this.txtFunctions.TabIndex = 3;
            this.txtFunctions.TabStop = false;
            this.txtFunctions.Text = "Functions";
            // 
            // btnTalk
            // 
            this.btnTalk.Location = new System.Drawing.Point(457, 60);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(75, 23);
            this.btnTalk.TabIndex = 7;
            this.btnTalk.Text = "Talk";
            this.btnTalk.UseVisualStyleBackColor = true;
            // 
            // ABCAnalysis
            // 
            this.ABCAnalysis.Location = new System.Drawing.Point(440, 19);
            this.ABCAnalysis.Name = "ABCAnalysis";
            this.ABCAnalysis.Size = new System.Drawing.Size(110, 23);
            this.ABCAnalysis.TabIndex = 6;
            this.ABCAnalysis.Text = "ABC Analysis";
            this.ABCAnalysis.UseVisualStyleBackColor = true;
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(327, 60);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 5;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            // 
            // btnArduino
            // 
            this.btnArduino.Location = new System.Drawing.Point(163, 60);
            this.btnArduino.Name = "btnArduino";
            this.btnArduino.Size = new System.Drawing.Size(75, 23);
            this.btnArduino.TabIndex = 4;
            this.btnArduino.Text = "Arduino";
            this.btnArduino.UseVisualStyleBackColor = true;
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(6, 60);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(75, 23);
            this.btnTimer.TabIndex = 3;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(327, 19);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(75, 23);
            this.btnProgress.TabIndex = 2;
            this.btnProgress.Text = "Progress";
            this.btnProgress.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(163, 19);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnJohari
            // 
            this.btnJohari.Location = new System.Drawing.Point(6, 19);
            this.btnJohari.Name = "btnJohari";
            this.btnJohari.Size = new System.Drawing.Size(75, 23);
            this.btnJohari.TabIndex = 0;
            this.btnJohari.Text = "Johari";
            this.btnJohari.UseVisualStyleBackColor = true;
            // 
            // btnCell
            // 
            this.btnCell.Controls.Add(this.btnRoboticCell);
            this.btnCell.Controls.Add(this.btnManufacturingCell);
            this.btnCell.Location = new System.Drawing.Point(677, 159);
            this.btnCell.Name = "btnCell";
            this.btnCell.Size = new System.Drawing.Size(200, 100);
            this.btnCell.TabIndex = 4;
            this.btnCell.TabStop = false;
            this.btnCell.Text = "Cell";
            // 
            // btnRoboticCell
            // 
            this.btnRoboticCell.Location = new System.Drawing.Point(58, 58);
            this.btnRoboticCell.Name = "btnRoboticCell";
            this.btnRoboticCell.Size = new System.Drawing.Size(75, 23);
            this.btnRoboticCell.TabIndex = 1;
            this.btnRoboticCell.Text = "RoboticCell";
            this.btnRoboticCell.UseVisualStyleBackColor = true;
            // 
            // btnManufacturingCell
            // 
            this.btnManufacturingCell.Location = new System.Drawing.Point(58, 19);
            this.btnManufacturingCell.Name = "btnManufacturingCell";
            this.btnManufacturingCell.Size = new System.Drawing.Size(75, 23);
            this.btnManufacturingCell.TabIndex = 0;
            this.btnManufacturingCell.Text = "Manufacturing Cell";
            this.btnManufacturingCell.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(212, 159);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 42);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(53, 159);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 36);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Array
            // 
            this.Array.Location = new System.Drawing.Point(6, 134);
            this.Array.Name = "Array";
            this.Array.Size = new System.Drawing.Size(75, 23);
            this.Array.TabIndex = 6;
            this.Array.Text = "Array";
            this.Array.UseVisualStyleBackColor = true;
            this.Array.Click += new System.EventHandler(this.Array_Click);
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCell);
            this.Controls.Add(this.txtFunctions);
            this.Controls.Add(this.btnApps);
            this.Controls.Add(this.btnTools);
            this.Controls.Add(this.ll);
            this.Name = "Frmmain";
            this.Load += new System.EventHandler(this.Frmmain_Load);
            this.ll.ResumeLayout(false);
            this.ll.PerformLayout();
            this.btnTools.ResumeLayout(false);
            this.btnApps.ResumeLayout(false);
            this.txtFunctions.ResumeLayout(false);
            this.btnCell.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox ll;
		private System.Windows.Forms.Label lblpassword;
		private System.Windows.Forms.Label lblusername;
		private System.Windows.Forms.TextBox txtpassword;
		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.GroupBox btnTools;
		private System.Windows.Forms.Button btnpicturebox2;
		private System.Windows.Forms.Button btnpicturebox;
		private System.Windows.Forms.Button btnRandomCombo;
		private System.Windows.Forms.Button btnCombo;
		private System.Windows.Forms.Button btncheckbox;
		private System.Windows.Forms.Button btnradio;
		private System.Windows.Forms.GroupBox btnApps;
		private System.Windows.Forms.Button btnGroupieApp;
		private System.Windows.Forms.Button btnselfieApp;
		private System.Windows.Forms.GroupBox txtFunctions;
		private System.Windows.Forms.Button Draw;
		private System.Windows.Forms.Button btnArduino;
		private System.Windows.Forms.Button btnTimer;
		private System.Windows.Forms.Button btnProgress;
		private System.Windows.Forms.Button btnRandom;
		private System.Windows.Forms.Button btnJohari;
		private System.Windows.Forms.Button btnTalk;
		private System.Windows.Forms.Button ABCAnalysis;
		private System.Windows.Forms.GroupBox btnCell;
		private System.Windows.Forms.Button btnRoboticCell;
		private System.Windows.Forms.Button btnManufacturingCell;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button Array;
    }
}

