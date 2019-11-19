namespace ItemPage
{
    partial class login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new JMaterialTextbox.JMaterialTextbox();
            this.txt_password = new JMaterialTextbox.JMaterialTextbox();
            this.jThinButton1 = new JThinButton.JThinButton();
            this.jThinButton2 = new JThinButton.JThinButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOM TO TOUR MANAGEMENT";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_username.ForeColors = System.Drawing.Color.Black;
            this.txt_username.HintText = "Username";
            this.txt_username.IsPassword = false;
            this.txt_username.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_username.LineThickness = 2;
            this.txt_username.Location = new System.Drawing.Point(51, 130);
            this.txt_username.MaxLength = 32767;
            this.txt_username.Name = "txt_username";
            this.txt_username.OnFocusedColor = System.Drawing.Color.Black;
            this.txt_username.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txt_username.ReadOnly = false;
            this.txt_username.Size = new System.Drawing.Size(298, 23);
            this.txt_username.TabIndex = 3;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username.TextName = "Username";
            this.txt_username.Load += new System.EventHandler(this.jMaterialTextbox1_Load);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_password.ForeColors = System.Drawing.Color.Black;
            this.txt_password.HintText = "Password";
            this.txt_password.IsPassword = false;
            this.txt_password.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_password.LineThickness = 2;
            this.txt_password.Location = new System.Drawing.Point(51, 182);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.OnFocusedColor = System.Drawing.Color.Black;
            this.txt_password.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txt_password.ReadOnly = false;
            this.txt_password.Size = new System.Drawing.Size(298, 18);
            this.txt_password.TabIndex = 4;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.TextName = "Password";
            // 
            // jThinButton1
            // 
            this.jThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton1.BackgroundColor = System.Drawing.Color.White;
            this.jThinButton1.BorderColor = System.Drawing.Color.Red;
            this.jThinButton1.BorderRadius = 18;
            this.jThinButton1.ButtonText = "Đăng nhập";
            this.jThinButton1.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButton1.ForeColors = System.Drawing.SystemColors.Highlight;
            this.jThinButton1.HoverBackground = System.Drawing.Color.White;
            this.jThinButton1.HoverBorder = System.Drawing.Color.Empty;
            this.jThinButton1.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.jThinButton1.LineThickness = 2;
            this.jThinButton1.Location = new System.Drawing.Point(51, 253);
            this.jThinButton1.Name = "jThinButton1";
            this.jThinButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jThinButton1.Size = new System.Drawing.Size(125, 40);
            this.jThinButton1.TabIndex = 5;
            this.jThinButton1.Click += new System.EventHandler(this.jThinButton1_Click);
            // 
            // jThinButton2
            // 
            this.jThinButton2.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton2.BackgroundColor = System.Drawing.Color.White;
            this.jThinButton2.BorderColor = System.Drawing.Color.Red;
            this.jThinButton2.BorderRadius = 18;
            this.jThinButton2.ButtonText = "Thoát";
            this.jThinButton2.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButton2.ForeColors = System.Drawing.SystemColors.Highlight;
            this.jThinButton2.HoverBackground = System.Drawing.Color.White;
            this.jThinButton2.HoverBorder = System.Drawing.Color.Empty;
            this.jThinButton2.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.jThinButton2.LineThickness = 2;
            this.jThinButton2.Location = new System.Drawing.Point(231, 253);
            this.jThinButton2.Name = "jThinButton2";
            this.jThinButton2.Size = new System.Drawing.Size(118, 40);
            this.jThinButton2.TabIndex = 6;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jThinButton2);
            this.Controls.Add(this.jThinButton1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.Size = new System.Drawing.Size(406, 347);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private JMaterialTextbox.JMaterialTextbox txt_username;
        private JMaterialTextbox.JMaterialTextbox txt_password;
        private JThinButton.JThinButton jThinButton1;
        private JThinButton.JThinButton jThinButton2;
    }
}
