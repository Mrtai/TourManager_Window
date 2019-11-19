namespace GUI
{
    partial class frmLichTrinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichTrinh));
            this.header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Panel();
            this.userControl11 = new ItemPage.UserControl1();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.label1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(790, 118);
            this.header.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(590, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách tour du lịch";
            // 
            // body
            // 
            this.body.Controls.Add(this.userControl11);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 118);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(790, 477);
            this.body.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.formDat = null;
            this.userControl11.formDetail = null;
            this.userControl11.imgURL = "";
            this.userControl11.labelGia = "Giá";
            this.userControl11.labelName = "Name";
            this.userControl11.Location = new System.Drawing.Point(12, 18);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(255, 224);
            this.userControl11.TabIndex = 0;
            // 
            // frmLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(790, 595);
            this.Controls.Add(this.body);
            this.Controls.Add(this.header);
            this.Name = "frmLichTrinh";
            this.Load += new System.EventHandler(this.frmLichTrinh_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ItemPage.UserControl1 userControl11;
    }
}