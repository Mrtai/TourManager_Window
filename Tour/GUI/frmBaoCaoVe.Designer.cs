namespace GUI
{
    partial class frmBaoCaoVe
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
            this.txt_from = new System.Windows.Forms.DateTimePicker();
            this.txt_to = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gc_DVe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_ngay = new JThinButton.JThinButton();
            this.jThinButton1 = new JThinButton.JThinButton();
            this.btn_bc = new JThinButton.JThinButton();
            this.dpMonth = new System.Windows.Forms.DateTimePicker();
            this.dpYear = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(367, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo vé";
            // 
            // txt_from
            // 
            this.txt_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_from.Location = new System.Drawing.Point(152, 89);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(200, 20);
            this.txt_from.TabIndex = 1;
            this.txt_from.Value = new System.DateTime(2019, 12, 3, 18, 12, 48, 0);
            this.txt_from.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_to
            // 
            this.txt_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_to.Location = new System.Drawing.Point(568, 89);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(200, 20);
            this.txt_to.TabIndex = 2;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(25, 87);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(84, 24);
            this.label28.TabIndex = 149;
            this.label28.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(442, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 150;
            this.label2.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 152;
            this.label3.Text = "Tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(442, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 154;
            this.label4.Text = "Năm";
            // 
            // gc_DVe
            // 
            this.gc_DVe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_DVe.Location = new System.Drawing.Point(0, 278);
            this.gc_DVe.MainView = this.gridView1;
            this.gc_DVe.Name = "gc_DVe";
            this.gc_DVe.Size = new System.Drawing.Size(1048, 283);
            this.gc_DVe.TabIndex = 157;
            this.gc_DVe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.GridControl = this.gc_DVe;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã vé";
            this.gridColumn1.FieldName = "MA_TOUR_DAT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Khách hàng";
            this.gridColumn2.FieldName = "KHACH_HANG.TEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Lịch trình";
            this.gridColumn3.FieldName = "LICH_KHOI_HANH.TEN_LICH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Điểm đón";
            this.gridColumn4.FieldName = "DIEM_DON";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày đặt";
            this.gridColumn5.FieldName = "NGAY_DAT";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Loại thanh toán";
            this.gridColumn6.FieldName = "LOAI_THANH_TOAN.TEN_LOAI_TT";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tổng tiền";
            this.gridColumn7.FieldName = "TONG_TIEN";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // btn_ngay
            // 
            this.btn_ngay.BackColor = System.Drawing.Color.Transparent;
            this.btn_ngay.BackgroundColor = System.Drawing.Color.White;
            this.btn_ngay.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_ngay.BorderRadius = 5;
            this.btn_ngay.ButtonText = "Lọc";
            this.btn_ngay.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ngay.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ngay.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btn_ngay.HoverBackground = System.Drawing.Color.White;
            this.btn_ngay.HoverBorder = System.Drawing.Color.Empty;
            this.btn_ngay.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btn_ngay.LineThickness = 2;
            this.btn_ngay.Location = new System.Drawing.Point(807, 80);
            this.btn_ngay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ngay.Name = "btn_ngay";
            this.btn_ngay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_ngay.Size = new System.Drawing.Size(86, 31);
            this.btn_ngay.TabIndex = 158;
            this.btn_ngay.Click += new System.EventHandler(this.jThinButton1_Click);
            // 
            // jThinButton1
            // 
            this.jThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton1.BackgroundColor = System.Drawing.Color.White;
            this.jThinButton1.BorderColor = System.Drawing.SystemColors.Highlight;
            this.jThinButton1.BorderRadius = 5;
            this.jThinButton1.ButtonText = "Lọc";
            this.jThinButton1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButton1.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButton1.ForeColors = System.Drawing.SystemColors.Highlight;
            this.jThinButton1.HoverBackground = System.Drawing.Color.White;
            this.jThinButton1.HoverBorder = System.Drawing.Color.Empty;
            this.jThinButton1.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.jThinButton1.LineThickness = 2;
            this.jThinButton1.Location = new System.Drawing.Point(807, 129);
            this.jThinButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jThinButton1.Name = "jThinButton1";
            this.jThinButton1.Size = new System.Drawing.Size(86, 29);
            this.jThinButton1.TabIndex = 159;
            this.jThinButton1.Click += new System.EventHandler(this.jThinButton1_Click_1);
            // 
            // btn_bc
            // 
            this.btn_bc.BackColor = System.Drawing.Color.Transparent;
            this.btn_bc.BackgroundColor = System.Drawing.Color.White;
            this.btn_bc.BorderColor = System.Drawing.Color.Red;
            this.btn_bc.BorderRadius = 5;
            this.btn_bc.ButtonText = "Xuất báo cáo";
            this.btn_bc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bc.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bc.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btn_bc.HoverBackground = System.Drawing.Color.White;
            this.btn_bc.HoverBorder = System.Drawing.Color.Empty;
            this.btn_bc.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btn_bc.LineThickness = 2;
            this.btn_bc.Location = new System.Drawing.Point(386, 162);
            this.btn_bc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_bc.Name = "btn_bc";
            this.btn_bc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_bc.Size = new System.Drawing.Size(119, 34);
            this.btn_bc.TabIndex = 160;
            this.btn_bc.Click += new System.EventHandler(this.btn_bc_Click);
            // 
            // dpMonth
            // 
            this.dpMonth.CustomFormat = "MM";
            this.dpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpMonth.Location = new System.Drawing.Point(152, 141);
            this.dpMonth.Name = "dpMonth";
            this.dpMonth.Size = new System.Drawing.Size(200, 20);
            this.dpMonth.TabIndex = 161;
            // 
            // dpYear
            // 
            this.dpYear.CustomFormat = "yyyy";
            this.dpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpYear.Location = new System.Drawing.Point(568, 139);
            this.dpYear.Name = "dpYear";
            this.dpYear.Size = new System.Drawing.Size(200, 20);
            this.dpYear.TabIndex = 162;
            this.dpYear.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // frmBaoCaoVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 561);
            this.Controls.Add(this.dpYear);
            this.Controls.Add(this.dpMonth);
            this.Controls.Add(this.btn_bc);
            this.Controls.Add(this.jThinButton1);
            this.Controls.Add(this.btn_ngay);
            this.Controls.Add(this.gc_DVe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoVe";
            this.Text = "frmBaoCaoVe";
            this.Load += new System.EventHandler(this.frmBaoCaoVe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt_from;
        private System.Windows.Forms.DateTimePicker txt_to;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gc_DVe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private JThinButton.JThinButton btn_ngay;
        private JThinButton.JThinButton jThinButton1;
        private JThinButton.JThinButton btn_bc;
        private System.Windows.Forms.DateTimePicker dpMonth;
        private System.Windows.Forms.DateTimePicker dpYear;
    }
}