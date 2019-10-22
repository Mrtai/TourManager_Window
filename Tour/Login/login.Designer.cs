namespace Login
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
            JMetroTextBox.JMetroTextBox txt_password;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btn_dangnhap = new JThinButton.JThinButton();
            this.btn_thoat = new JThinButton.JThinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new JMetroTextBox.JMetroTextBox();
            txt_password = new JMetroTextBox.JMetroTextBox();
            this.SuspendLayout();
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_dangnhap.BackgroundColor = System.Drawing.Color.White;
            this.btn_dangnhap.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_dangnhap.BorderRadius = 16;
            this.btn_dangnhap.ButtonText = "Đăng nhập";
            this.btn_dangnhap.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btn_dangnhap.HoverBackground = System.Drawing.Color.White;
            this.btn_dangnhap.HoverBorder = System.Drawing.Color.Empty;
            this.btn_dangnhap.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btn_dangnhap.LineThickness = 2;
            this.btn_dangnhap.Location = new System.Drawing.Point(63, 237);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_dangnhap.Size = new System.Drawing.Size(105, 35);
            this.btn_dangnhap.TabIndex = 1;
            this.btn_dangnhap.Click += new System.EventHandler(this.jThinButton1_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_thoat.BackgroundColor = System.Drawing.Color.White;
            this.btn_thoat.BorderColor = System.Drawing.Color.Red;
            this.btn_thoat.BorderRadius = 16;
            this.btn_thoat.ButtonText = "Thoát";
            this.btn_thoat.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColors = System.Drawing.Color.Red;
            this.btn_thoat.HoverBackground = System.Drawing.Color.White;
            this.btn_thoat.HoverBorder = System.Drawing.Color.Empty;
            this.btn_thoat.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btn_thoat.LineThickness = 2;
            this.btn_thoat.Location = new System.Drawing.Point(246, 237);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_thoat.Size = new System.Drawing.Size(76, 35);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to tour management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Niagara Engraved", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Niagara Engraved", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.BorderColor = System.Drawing.Color.Empty;
            this.txt_username.BorderRadius = 15;
            this.txt_username.FillColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txt_username.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_username.ForeColors = System.Drawing.Color.Gray;
            this.txt_username.IsPassword = false;
            this.txt_username.LineThickness = 2;
            this.txt_username.Location = new System.Drawing.Point(49, 118);
            this.txt_username.MaxLength = 32767;
            this.txt_username.MouseOnHover = System.Drawing.Color.Empty;
            this.txt_username.Name = "txt_username";
            this.txt_username.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.OnFocusColor = System.Drawing.Color.Empty;
            this.txt_username.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txt_username.ReadOnly = false;
            this.txt_username.Size = new System.Drawing.Size(273, 39);
            this.txt_username.TabIndex = 8;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username.TextName = "";
            this.txt_username.Load += new System.EventHandler(this.txt_username_Load);
            // 
            // txt_password
            // 
            txt_password.BackColor = System.Drawing.Color.Transparent;
            txt_password.BorderColor = System.Drawing.Color.Empty;
            txt_password.BorderRadius = 15;
            txt_password.FillColor = System.Drawing.Color.LightYellow;
            txt_password.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            txt_password.ForeColors = System.Drawing.Color.Gray;
            txt_password.IsPassword = true;
            txt_password.LineThickness = 2;
            txt_password.Location = new System.Drawing.Point(49, 192);
            txt_password.MaxLength = 32767;
            txt_password.MouseOnHover = System.Drawing.Color.Empty;
            txt_password.Name = "txt_password";
            txt_password.OnCursor = System.Windows.Forms.Cursors.IBeam;
            txt_password.OnFocusColor = System.Drawing.Color.Empty;
            txt_password.OnFocusFontColor = System.Drawing.Color.Empty;
            txt_password.ReadOnly = false;
            txt_password.Size = new System.Drawing.Size(273, 39);
            txt_password.TabIndex = 9;
            txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_password.TextName = "";
            txt_password.Load += new System.EventHandler(this.txt_password_Load);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangnhap);
            this.Name = "login";
            this.Size = new System.Drawing.Size(400, 298);
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private JThinButton.JThinButton btn_dangnhap;
        private JThinButton.JThinButton btn_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private JMetroTextBox.JMetroTextBox txt_username;
    }
}
