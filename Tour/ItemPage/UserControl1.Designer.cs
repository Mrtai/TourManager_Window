namespace ItemPage
{
    partial class UserControl1
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
            this.lb_gia = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.btn_detail = new JThinButton.JThinButton();
            this.btn_dat = new JThinButton.JThinButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_dat);
            this.panel1.Controls.Add(this.btn_detail);
            this.panel1.Controls.Add(this.lb_gia);
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 88);
            this.panel1.TabIndex = 3;
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.ForeColor = System.Drawing.Color.Red;
            this.lb_gia.Location = new System.Drawing.Point(12, 34);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(23, 13);
            this.lb_gia.TabIndex = 1;
            this.lb_gia.Text = "Giá";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(12, 12);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(35, 13);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Name";
            // 
            // img
            // 
            this.img.Dock = System.Windows.Forms.DockStyle.Top;
            this.img.ImageLocation = "";
            this.img.Location = new System.Drawing.Point(0, 0);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(255, 136);
            this.img.TabIndex = 2;
            this.img.TabStop = false;
            // 
            // btn_detail
            // 
            this.btn_detail.BackColor = System.Drawing.Color.Transparent;
            this.btn_detail.BackgroundColor = System.Drawing.Color.White;
            this.btn_detail.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_detail.BorderRadius = 5;
            this.btn_detail.ButtonText = "Chi tiết";
            this.btn_detail.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detail.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btn_detail.HoverBackground = System.Drawing.Color.White;
            this.btn_detail.HoverBorder = System.Drawing.Color.Empty;
            this.btn_detail.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btn_detail.LineThickness = 2;
            this.btn_detail.Location = new System.Drawing.Point(15, 55);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(71, 30);
            this.btn_detail.TabIndex = 2;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // btn_dat
            // 
            this.btn_dat.BackColor = System.Drawing.Color.Transparent;
            this.btn_dat.BackgroundColor = System.Drawing.Color.White;
            this.btn_dat.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_dat.BorderRadius = 5;
            this.btn_dat.ButtonText = "Đặt";
            this.btn_dat.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dat.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btn_dat.HoverBackground = System.Drawing.Color.White;
            this.btn_dat.HoverBorder = System.Drawing.Color.Empty;
            this.btn_dat.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btn_dat.LineThickness = 2;
            this.btn_dat.Location = new System.Drawing.Point(159, 54);
            this.btn_dat.Name = "btn_dat";
            this.btn_dat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_dat.Size = new System.Drawing.Size(67, 30);
            this.btn_dat.TabIndex = 3;
            this.btn_dat.Click += new System.EventHandler(this.btn_dat_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(255, 224);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.PictureBox img;
        private JThinButton.JThinButton btn_dat;
        private JThinButton.JThinButton btn_detail;

    }
}
