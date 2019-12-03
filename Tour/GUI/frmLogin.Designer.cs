namespace GUI
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_pass = new JMaterialTextbox.JMaterialTextbox();
            this.txt_username = new JMaterialTextbox.JMaterialTextbox();
            this.btn_exit = new JThinButton.JThinButton();
            this.btn_login = new JThinButton.JThinButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 117);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Tour Management";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_pass);
            this.panel2.Controls.Add(this.txt_username);
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 207);
            this.panel2.TabIndex = 1;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.Transparent;
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_pass.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_pass.ForeColors = System.Drawing.Color.Black;
            this.txt_pass.HintText = "";
            this.txt_pass.IsPassword = true;
            this.txt_pass.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_pass.LineThickness = 2;
            this.txt_pass.Location = new System.Drawing.Point(72, 88);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_pass.MaxLength = 32767;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.OnFocusedColor = System.Drawing.Color.Black;
            this.txt_pass.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txt_pass.ReadOnly = false;
            this.txt_pass.Size = new System.Drawing.Size(244, 23);
            this.txt_pass.TabIndex = 5;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_pass.TextName = "123456";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_username.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_username.ForeColors = System.Drawing.Color.Black;
            this.txt_username.HintText = "";
            this.txt_username.IsPassword = false;
            this.txt_username.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_username.LineThickness = 2;
            this.txt_username.Location = new System.Drawing.Point(72, 29);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_username.MaxLength = 32767;
            this.txt_username.Name = "txt_username";
            this.txt_username.OnFocusedColor = System.Drawing.Color.Black;
            this.txt_username.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txt_username.ReadOnly = false;
            this.txt_username.Size = new System.Drawing.Size(244, 23);
            this.txt_username.TabIndex = 4;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username.TextName = "Admin";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundColor = System.Drawing.Color.White;
            this.btn_exit.BorderColor = System.Drawing.Color.Blue;
            this.btn_exit.BorderRadius = 16;
            this.btn_exit.ButtonText = "Exit";
            this.btn_exit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btn_exit.HoverBackground = System.Drawing.Color.White;
            this.btn_exit.HoverBorder = System.Drawing.Color.Empty;
            this.btn_exit.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btn_exit.LineThickness = 2;
            this.btn_exit.Location = new System.Drawing.Point(216, 144);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_exit.Size = new System.Drawing.Size(92, 36);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BackgroundColor = System.Drawing.Color.White;
            this.btn_login.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_login.BorderRadius = 16;
            this.btn_login.ButtonText = "Login";
            this.btn_login.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btn_login.HoverBackground = System.Drawing.Color.White;
            this.btn_login.HoverBorder = System.Drawing.Color.Empty;
            this.btn_login.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btn_login.LineThickness = 2;
            this.btn_login.Location = new System.Drawing.Point(72, 144);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_login.Size = new System.Drawing.Size(99, 36);
            this.btn_login.TabIndex = 2;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 324);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private JMaterialTextbox.JMaterialTextbox txt_pass;
        private JMaterialTextbox.JMaterialTextbox txt_username;
        private JThinButton.JThinButton btn_exit;
        private JThinButton.JThinButton btn_login;
    }
}