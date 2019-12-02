namespace GUI
{
    partial class frmCH
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
            this.txt_pass = new JMaterialTextbox.JMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_user = new JMaterialTextbox.JMaterialTextbox();
            this.btn_exit = new JThinButton.JThinButton();
            this.btn_luu = new JThinButton.JThinButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_server = new System.Windows.Forms.ComboBox();
            this.cb_database = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.Transparent;
            this.txt_pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColors = System.Drawing.Color.Black;
            this.txt_pass.HintText = null;
            this.txt_pass.IsPassword = false;
            this.txt_pass.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_pass.LineThickness = 3;
            this.txt_pass.Location = new System.Drawing.Point(158, 102);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_pass.MaxLength = 32767;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.OnFocusedColor = System.Drawing.Color.Black;
            this.txt_pass.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txt_pass.ReadOnly = false;
            this.txt_pass.Size = new System.Drawing.Size(164, 28);
            this.txt_pass.TabIndex = 142;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_pass.TextName = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 141;
            this.label4.Text = "PassWord";
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.Transparent;
            this.txt_user.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColors = System.Drawing.Color.Black;
            this.txt_user.HintText = null;
            this.txt_user.IsPassword = false;
            this.txt_user.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_user.LineThickness = 3;
            this.txt_user.Location = new System.Drawing.Point(158, 66);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_user.MaxLength = 32767;
            this.txt_user.Name = "txt_user";
            this.txt_user.OnFocusedColor = System.Drawing.Color.Black;
            this.txt_user.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txt_user.ReadOnly = false;
            this.txt_user.Size = new System.Drawing.Size(164, 28);
            this.txt_user.TabIndex = 139;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_user.TextName = "";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.btn_exit.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_exit.BorderRadius = 5;
            this.btn_exit.ButtonText = "Thoát";
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Font_Size = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColors = System.Drawing.SystemColors.Desktop;
            this.btn_exit.HoverBackground = System.Drawing.Color.White;
            this.btn_exit.HoverBorder = System.Drawing.Color.Empty;
            this.btn_exit.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btn_exit.LineThickness = 2;
            this.btn_exit.Location = new System.Drawing.Point(205, 217);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_exit.Size = new System.Drawing.Size(78, 39);
            this.btn_exit.TabIndex = 137;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.Transparent;
            this.btn_luu.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.btn_luu.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_luu.BorderRadius = 5;
            this.btn_luu.ButtonText = "Lưu";
            this.btn_luu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Font_Size = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColors = System.Drawing.SystemColors.Desktop;
            this.btn_luu.HoverBackground = System.Drawing.Color.White;
            this.btn_luu.HoverBorder = System.Drawing.Color.Empty;
            this.btn_luu.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btn_luu.LineThickness = 2;
            this.btn_luu.Location = new System.Drawing.Point(73, 217);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_luu.Size = new System.Drawing.Size(78, 39);
            this.btn_luu.TabIndex = 136;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 135;
            this.label3.Text = "Server Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 134;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 133;
            this.label1.Text = "Data Base";
            // 
            // cb_server
            // 
            this.cb_server.FormattingEnabled = true;
            this.cb_server.Location = new System.Drawing.Point(158, 36);
            this.cb_server.Name = "cb_server";
            this.cb_server.Size = new System.Drawing.Size(164, 21);
            this.cb_server.TabIndex = 143;
            this.cb_server.DropDown += new System.EventHandler(this.cb_server_DropDown);
            // 
            // cb_database
            // 
            this.cb_database.FormattingEnabled = true;
            this.cb_database.Location = new System.Drawing.Point(158, 153);
            this.cb_database.Name = "cb_database";
            this.cb_database.Size = new System.Drawing.Size(164, 21);
            this.cb_database.TabIndex = 144;
            this.cb_database.DropDown += new System.EventHandler(this.cb_database_DropDown);
            // 
            // frmCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 284);
            this.Controls.Add(this.cb_database);
            this.Controls.Add(this.cb_server);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCH";
            this.Text = "frmCH";
            this.Load += new System.EventHandler(this.frmCH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JMaterialTextbox.JMaterialTextbox txt_pass;
        private System.Windows.Forms.Label label4;
        private JMaterialTextbox.JMaterialTextbox txt_user;
        private JThinButton.JThinButton btn_exit;
        private JThinButton.JThinButton btn_luu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_server;
        private System.Windows.Forms.ComboBox cb_database;
    }
}