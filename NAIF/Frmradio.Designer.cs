namespace NAIF
{
    partial class Frmradio
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
            this.btnback = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.RdoYellow2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.RdoBlue2 = new System.Windows.Forms.RadioButton();
            this.RdoRed1 = new System.Windows.Forms.RadioButton();
            this.Rdogreen1 = new System.Windows.Forms.RadioButton();
            this.RdoGreen = new System.Windows.Forms.RadioButton();
            this.Rdored = new System.Windows.Forms.RadioButton();
            this.RdoYellow = new System.Windows.Forms.RadioButton();
            this.RdoBlue = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(266, 364);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(172, 111);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 1;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.RdoYellow2);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.RdoBlue2);
            this.groupBox1.Controls.Add(this.RdoRed1);
            this.groupBox1.Controls.Add(this.Rdogreen1);
            this.groupBox1.Location = new System.Drawing.Point(125, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GroupRadioButons";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(-100, 90);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(55, 17);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Yellow";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // RdoYellow2
            // 
            this.RdoYellow2.AutoSize = true;
            this.RdoYellow2.Location = new System.Drawing.Point(16, 91);
            this.RdoYellow2.Name = "RdoYellow2";
            this.RdoYellow2.Size = new System.Drawing.Size(55, 17);
            this.RdoYellow2.TabIndex = 3;
            this.RdoYellow2.TabStop = true;
            this.RdoYellow2.Text = "Yellow";
            this.RdoYellow2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(-87, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(41, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "red";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.Rdored_CheckedChanged);
            // 
            // RdoBlue2
            // 
            this.RdoBlue2.AutoSize = true;
            this.RdoBlue2.Location = new System.Drawing.Point(16, 66);
            this.RdoBlue2.Name = "RdoBlue2";
            this.RdoBlue2.Size = new System.Drawing.Size(45, 17);
            this.RdoBlue2.TabIndex = 2;
            this.RdoBlue2.TabStop = true;
            this.RdoBlue2.Text = "Blue";
            this.RdoBlue2.UseVisualStyleBackColor = true;
            // 
            // RdoRed1
            // 
            this.RdoRed1.AutoSize = true;
            this.RdoRed1.Location = new System.Drawing.Point(16, 19);
            this.RdoRed1.Name = "RdoRed1";
            this.RdoRed1.Size = new System.Drawing.Size(41, 17);
            this.RdoRed1.TabIndex = 0;
            this.RdoRed1.TabStop = true;
            this.RdoRed1.Text = "red";
            this.RdoRed1.UseVisualStyleBackColor = true;
            this.RdoRed1.CheckedChanged += new System.EventHandler(this.Rdored_CheckedChanged);
            // 
            // Rdogreen1
            // 
            this.Rdogreen1.AutoSize = true;
            this.Rdogreen1.Location = new System.Drawing.Point(16, 43);
            this.Rdogreen1.Name = "Rdogreen1";
            this.Rdogreen1.Size = new System.Drawing.Size(54, 17);
            this.Rdogreen1.TabIndex = 1;
            this.Rdogreen1.TabStop = true;
            this.Rdogreen1.Text = "Green";
            this.Rdogreen1.UseVisualStyleBackColor = true;
            this.Rdogreen1.CheckedChanged += new System.EventHandler(this.RdoGreen_Changed);
            // 
            // RdoGreen
            // 
            this.RdoGreen.AutoSize = true;
            this.RdoGreen.Location = new System.Drawing.Point(61, 205);
            this.RdoGreen.Name = "RdoGreen";
            this.RdoGreen.Size = new System.Drawing.Size(54, 17);
            this.RdoGreen.TabIndex = 1;
            this.RdoGreen.TabStop = true;
            this.RdoGreen.Text = "Green";
            this.RdoGreen.UseVisualStyleBackColor = true;
            this.RdoGreen.CheckedChanged += new System.EventHandler(this.RdoGreen_Changed);
            // 
            // Rdored
            // 
            this.Rdored.AutoSize = true;
            this.Rdored.Location = new System.Drawing.Point(61, 181);
            this.Rdored.Name = "Rdored";
            this.Rdored.Size = new System.Drawing.Size(41, 17);
            this.Rdored.TabIndex = 0;
            this.Rdored.TabStop = true;
            this.Rdored.Text = "red";
            this.Rdored.UseVisualStyleBackColor = true;
            this.Rdored.CheckedChanged += new System.EventHandler(this.Rdored_CheckedChanged);
            // 
            // RdoYellow
            // 
            this.RdoYellow.AutoSize = true;
            this.RdoYellow.Location = new System.Drawing.Point(60, 251);
            this.RdoYellow.Name = "RdoYellow";
            this.RdoYellow.Size = new System.Drawing.Size(55, 17);
            this.RdoYellow.TabIndex = 3;
            this.RdoYellow.TabStop = true;
            this.RdoYellow.Text = "Yellow";
            this.RdoYellow.UseVisualStyleBackColor = true;
            this.RdoYellow.CheckedChanged += new System.EventHandler(this.RdoYellow_CheckedChanged);
            // 
            // RdoBlue
            // 
            this.RdoBlue.AutoSize = true;
            this.RdoBlue.Location = new System.Drawing.Point(61, 228);
            this.RdoBlue.Name = "RdoBlue";
            this.RdoBlue.Size = new System.Drawing.Size(45, 17);
            this.RdoBlue.TabIndex = 2;
            this.RdoBlue.TabStop = true;
            this.RdoBlue.Text = "Blue";
            this.RdoBlue.UseVisualStyleBackColor = true;
            this.RdoBlue.CheckedChanged += new System.EventHandler(this.RdoBlue_CheckedChanged);
            // 
            // Frmradio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RdoYellow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.RdoBlue);
            this.Controls.Add(this.Rdored);
            this.Controls.Add(this.RdoGreen);
            this.Controls.Add(this.btnback);
            this.Name = "Frmradio";
            this.Text = "Frmradio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoYellow2;
        private System.Windows.Forms.RadioButton RdoBlue2;
        private System.Windows.Forms.RadioButton RdoGreen;
        private System.Windows.Forms.RadioButton RdoRed1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton Rdored;
        private System.Windows.Forms.RadioButton RdoYellow;
        private System.Windows.Forms.RadioButton Rdogreen1;
        private System.Windows.Forms.RadioButton RdoBlue;
    }
}