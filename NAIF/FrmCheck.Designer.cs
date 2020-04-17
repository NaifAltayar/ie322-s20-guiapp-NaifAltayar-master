namespace NAIF
{
    partial class FrmCheck
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.ChkCoffee = new System.Windows.Forms.CheckBox();
            this.ChkDount = new System.Windows.Forms.CheckBox();
            this.ChkBrawnie = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkBrawnie);
            this.groupBox1.Controls.Add(this.ChkDount);
            this.groupBox1.Controls.Add(this.ChkCoffee);
            this.groupBox1.Location = new System.Drawing.Point(167, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(167, 73);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 23);
            this.BtnShow.TabIndex = 1;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(271, 263);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ChkCoffee
            // 
            this.ChkCoffee.AutoSize = true;
            this.ChkCoffee.Location = new System.Drawing.Point(6, 31);
            this.ChkCoffee.Name = "ChkCoffee";
            this.ChkCoffee.Size = new System.Drawing.Size(59, 17);
            this.ChkCoffee.TabIndex = 0;
            this.ChkCoffee.Text = "Coffee";
            this.ChkCoffee.UseVisualStyleBackColor = true;
            // 
            // ChkDount
            // 
            this.ChkDount.AutoSize = true;
            this.ChkDount.Location = new System.Drawing.Point(6, 54);
            this.ChkDount.Name = "ChkDount";
            this.ChkDount.Size = new System.Drawing.Size(55, 17);
            this.ChkDount.TabIndex = 0;
            this.ChkDount.Text = "Dount";
            this.ChkDount.UseVisualStyleBackColor = true;
            // 
            // ChkBrawnie
            // 
            this.ChkBrawnie.AutoSize = true;
            this.ChkBrawnie.Location = new System.Drawing.Point(6, 77);
            this.ChkBrawnie.Name = "ChkBrawnie";
            this.ChkBrawnie.Size = new System.Drawing.Size(64, 17);
            this.ChkBrawnie.TabIndex = 0;
            this.ChkBrawnie.Text = "Brawnie";
            this.ChkBrawnie.UseVisualStyleBackColor = true;
            // 
            // FrmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCheck";
            this.Text = "FrmCheck";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkBrawnie;
        private System.Windows.Forms.CheckBox ChkDount;
        private System.Windows.Forms.CheckBox ChkCoffee;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnBack;
    }
}