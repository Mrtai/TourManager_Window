namespace GUI
{
    partial class ItemImage
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
            this.btn_chitiet = new JThinButton.JThinButton();
            this.btn_dat = new JThinButton.JThinButton();
            this.lb_gia = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_chitiet);
            this.panel1.Controls.Add(this.btn_dat);
            this.panel1.Controls.Add(this.lb_gia);
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 83);
            this.panel1.TabIndex = 1;
            // 
            // btn_chitiet
            // 
            this.btn_chitiet.BackColor = System.Drawing.Color.Transparent;
            this.btn_chitiet.BackgroundColor = System.Drawing.Color.White;
            this.btn_chitiet.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_chitiet.BorderRadius = 5;
            this.btn_chitiet.ButtonText = "Chi tiết";
            this.btn_chitiet.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chitiet.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chitiet.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btn_chitiet.HoverBackground = System.Drawing.Color.White;
            this.btn_chitiet.HoverBorder = System.Drawing.Color.Empty;
            this.btn_chitiet.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btn_chitiet.LineThickness = 2;
            this.btn_chitiet.Location = new System.Drawing.Point(27, 54);
            this.btn_chitiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_chitiet.Size = new System.Drawing.Size(76, 24);
            this.btn_chitiet.TabIndex = 3;
            // 
            // btn_dat
            // 
            this.btn_dat.BackColor = System.Drawing.Color.Transparent;
            this.btn_dat.BackgroundColor = System.Drawing.Color.White;
            this.btn_dat.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_dat.BorderRadius = 5;
            this.btn_dat.ButtonText = "Đặt";
            this.btn_dat.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dat.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dat.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btn_dat.HoverBackground = System.Drawing.Color.White;
            this.btn_dat.HoverBorder = System.Drawing.Color.Empty;
            this.btn_dat.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btn_dat.LineThickness = 2;
            this.btn_dat.Location = new System.Drawing.Point(140, 54);
            this.btn_dat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dat.Name = "btn_dat";
            this.btn_dat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_dat.Size = new System.Drawing.Size(57, 24);
            this.btn_dat.TabIndex = 2;
            this.btn_dat.Click += new System.EventHandler(this.jThinButton1_Click);
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
            this.img.ImageLocation = "../Resource/img20171226144436468.jpg";
            this.img.Location = new System.Drawing.Point(0, 0);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(230, 136);
            this.img.TabIndex = 0;
            this.img.TabStop = false;
            // 
            // ItemImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img);
            this.Name = "ItemImage";
            this.Size = new System.Drawing.Size(230, 219);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private JThinButton.JThinButton btn_dat;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.Label lb_name;
        private JThinButton.JThinButton btn_chitiet;
        private System.Windows.Forms.PictureBox img;
    }
}
