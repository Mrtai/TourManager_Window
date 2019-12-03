namespace GUI
{
    partial class frmDatVe
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

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.jThinButton1 = new JThinButton.JThinButton();
            this.txt_giam = new JMaterialTextbox.JMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.imgTour = new System.Windows.Forms.PictureBox();
            this.txt_gia = new JMaterialTextbox.JMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_tt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_NV = new System.Windows.Forms.ComboBox();
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.cb_LT = new System.Windows.Forms.ComboBox();
            this.cb_KH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemDon = new JMaterialTextbox.JMaterialTextbox();
            this.txtMaTourDat = new JMaterialTextbox.JMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.rb_themDV = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.rb_false = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listDV = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTour)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.jThinButton1);
            this.panel1.Controls.Add(this.txt_giam);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.imgTour);
            this.panel1.Controls.Add(this.txt_gia);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cb_tt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cb_trangthai);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_NV);
            this.panel1.Controls.Add(this.dtp_Ngay);
            this.panel1.Controls.Add(this.cb_LT);
            this.panel1.Controls.Add(this.cb_KH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDiemDon);
            this.panel1.Controls.Add(this.txtMaTourDat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 595);
            this.panel1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(385, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 37);
            this.label10.TabIndex = 241;
            this.label10.Text = "Đặt vé";
            // 
            // jThinButton1
            // 
            this.jThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton1.BackgroundColor = System.Drawing.Color.White;
            this.jThinButton1.BorderColor = System.Drawing.SystemColors.Highlight;
            this.jThinButton1.BorderRadius = 5;
            this.jThinButton1.ButtonText = "Thanh toán";
            this.jThinButton1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButton1.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButton1.ForeColors = System.Drawing.SystemColors.Highlight;
            this.jThinButton1.HoverBackground = System.Drawing.Color.White;
            this.jThinButton1.HoverBorder = System.Drawing.Color.Empty;
            this.jThinButton1.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.jThinButton1.LineThickness = 2;
            this.jThinButton1.Location = new System.Drawing.Point(732, 451);
            this.jThinButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jThinButton1.Name = "jThinButton1";
            this.jThinButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jThinButton1.Size = new System.Drawing.Size(103, 43);
            this.jThinButton1.TabIndex = 240;
            this.jThinButton1.Click += new System.EventHandler(this.jThinButton1_Click);
            // 
            // txt_giam
            // 
            this.txt_giam.BackColor = System.Drawing.Color.Transparent;
            this.txt_giam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giam.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giam.ForeColors = System.Drawing.Color.Black;
            this.txt_giam.HintText = null;
            this.txt_giam.IsPassword = false;
            this.txt_giam.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_giam.LineThickness = 3;
            this.txt_giam.Location = new System.Drawing.Point(706, 374);
            this.txt_giam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_giam.MaxLength = 32767;
            this.txt_giam.Name = "txt_giam";
            this.txt_giam.OnFocusedColor = System.Drawing.Color.Black;
            this.txt_giam.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txt_giam.ReadOnly = true;
            this.txt_giam.Size = new System.Drawing.Size(157, 23);
            this.txt_giam.TabIndex = 239;
            this.txt_giam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_giam.TextName = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightGray;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(600, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 22);
            this.label9.TabIndex = 238;
            this.label9.Text = "Giảm giá";
            // 
            // imgTour
            // 
            this.imgTour.Location = new System.Drawing.Point(659, 92);
            this.imgTour.Name = "imgTour";
            this.imgTour.Size = new System.Drawing.Size(203, 177);
            this.imgTour.TabIndex = 237;
            this.imgTour.TabStop = false;
            // 
            // txt_gia
            // 
            this.txt_gia.BackColor = System.Drawing.Color.Transparent;
            this.txt_gia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gia.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gia.ForeColors = System.Drawing.Color.Black;
            this.txt_gia.HintText = null;
            this.txt_gia.IsPassword = false;
            this.txt_gia.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_gia.LineThickness = 3;
            this.txt_gia.Location = new System.Drawing.Point(706, 411);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_gia.MaxLength = 32767;
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.OnFocusedColor = System.Drawing.Color.Black;
            this.txt_gia.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txt_gia.ReadOnly = true;
            this.txt_gia.Size = new System.Drawing.Size(157, 23);
            this.txt_gia.TabIndex = 236;
            this.txt_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_gia.TextName = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(600, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 235;
            this.label8.Text = "Tổng tiền";
            // 
            // cb_tt
            // 
            this.cb_tt.FormattingEnabled = true;
            this.cb_tt.Items.AddRange(new object[] {
            "Đã nhận",
            "Chưa nhận"});
            this.cb_tt.Location = new System.Drawing.Point(458, 235);
            this.cb_tt.Name = "cb_tt";
            this.cb_tt.Size = new System.Drawing.Size(157, 21);
            this.cb_tt.TabIndex = 234;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(309, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 22);
            this.label7.TabIndex = 233;
            this.label7.Text = "Loại thanh toán";
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Items.AddRange(new object[] {
            "Đã nhận",
            "Chưa nhận"});
            this.cb_trangthai.Location = new System.Drawing.Point(131, 231);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(157, 21);
            this.cb_trangthai.TabIndex = 232;
            this.cb_trangthai.SelectedIndexChanged += new System.EventHandler(this.cb_trangthai_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(345, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 231;
            this.label6.Text = "Nhân Viên";
            // 
            // cb_NV
            // 
            this.cb_NV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_NV.FormattingEnabled = true;
            this.cb_NV.Location = new System.Drawing.Point(458, 187);
            this.cb_NV.Name = "cb_NV";
            this.cb_NV.Size = new System.Drawing.Size(157, 27);
            this.cb_NV.TabIndex = 230;
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Ngay.Location = new System.Drawing.Point(131, 187);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(157, 26);
            this.dtp_Ngay.TabIndex = 229;
            // 
            // cb_LT
            // 
            this.cb_LT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LT.FormattingEnabled = true;
            this.cb_LT.Location = new System.Drawing.Point(458, 139);
            this.cb_LT.Name = "cb_LT";
            this.cb_LT.Size = new System.Drawing.Size(157, 27);
            this.cb_LT.TabIndex = 228;
            this.cb_LT.SelectedIndexChanged += new System.EventHandler(this.cb_LT_SelectedIndexChanged);
            // 
            // cb_KH
            // 
            this.cb_KH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_KH.FormattingEnabled = true;
            this.cb_KH.Location = new System.Drawing.Point(458, 101);
            this.cb_KH.Name = "cb_KH";
            this.cb_KH.Size = new System.Drawing.Size(157, 27);
            this.cb_KH.TabIndex = 227;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(522, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 226;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(345, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 225;
            this.label5.Text = "Lịch Trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(191, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 224;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(377, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 223;
            this.label3.Text = "Mã KH";
            // 
            // txtDiemDon
            // 
            this.txtDiemDon.BackColor = System.Drawing.Color.Transparent;
            this.txtDiemDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemDon.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemDon.ForeColors = System.Drawing.Color.Black;
            this.txtDiemDon.HintText = null;
            this.txtDiemDon.IsPassword = false;
            this.txtDiemDon.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiemDon.LineThickness = 3;
            this.txtDiemDon.Location = new System.Drawing.Point(131, 137);
            this.txtDiemDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiemDon.MaxLength = 32767;
            this.txtDiemDon.Name = "txtDiemDon";
            this.txtDiemDon.OnFocusedColor = System.Drawing.Color.Black;
            this.txtDiemDon.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtDiemDon.ReadOnly = false;
            this.txtDiemDon.Size = new System.Drawing.Size(157, 23);
            this.txtDiemDon.TabIndex = 222;
            this.txtDiemDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiemDon.TextName = "";
            // 
            // txtMaTourDat
            // 
            this.txtMaTourDat.BackColor = System.Drawing.Color.Transparent;
            this.txtMaTourDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTourDat.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTourDat.ForeColors = System.Drawing.Color.Black;
            this.txtMaTourDat.HintText = null;
            this.txtMaTourDat.IsPassword = false;
            this.txtMaTourDat.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaTourDat.LineThickness = 3;
            this.txtMaTourDat.Location = new System.Drawing.Point(131, 92);
            this.txtMaTourDat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTourDat.MaxLength = 32767;
            this.txtMaTourDat.Name = "txtMaTourDat";
            this.txtMaTourDat.OnFocusedColor = System.Drawing.Color.Black;
            this.txtMaTourDat.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtMaTourDat.ReadOnly = false;
            this.txtMaTourDat.Size = new System.Drawing.Size(157, 23);
            this.txtMaTourDat.TabIndex = 221;
            this.txtMaTourDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaTourDat.TextName = "";
            this.txtMaTourDat.Load += new System.EventHandler(this.txtMaTourDat_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 220;
            this.label1.Text = "Ngày";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.LightGray;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(18, 231);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 22);
            this.label18.TabIndex = 219;
            this.label18.Text = "Trạng Thái";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.LightGray;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(29, 138);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 22);
            this.label22.TabIndex = 218;
            this.label22.Text = "Điểm Đón";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.LightGray;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(46, 92);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 22);
            this.label23.TabIndex = 217;
            this.label23.Text = "Mã Vé";
            // 
            // rb_themDV
            // 
            this.rb_themDV.AutoSize = true;
            this.rb_themDV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_themDV.ForeColor = System.Drawing.Color.Black;
            this.rb_themDV.Location = new System.Drawing.Point(154, 29);
            this.rb_themDV.Name = "rb_themDV";
            this.rb_themDV.Size = new System.Drawing.Size(48, 23);
            this.rb_themDV.TabIndex = 244;
            this.rb_themDV.Text = "Có";
            this.rb_themDV.UseVisualStyleBackColor = true;
            this.rb_themDV.CheckedChanged += new System.EventHandler(this.rb_themDV_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightGray;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(24, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 22);
            this.label12.TabIndex = 245;
            this.label12.Text = "Thêm dịch vụ";
            // 
            // rb_false
            // 
            this.rb_false.AutoSize = true;
            this.rb_false.Checked = true;
            this.rb_false.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_false.ForeColor = System.Drawing.Color.Black;
            this.rb_false.Location = new System.Drawing.Point(235, 30);
            this.rb_false.Name = "rb_false";
            this.rb_false.Size = new System.Drawing.Size(78, 23);
            this.rb_false.TabIndex = 246;
            this.rb_false.TabStop = true;
            this.rb_false.Text = "Không";
            this.rb_false.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listDV);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.rb_false);
            this.groupBox1.Controls.Add(this.rb_themDV);
            this.groupBox1.Location = new System.Drawing.Point(22, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 225);
            this.groupBox1.TabIndex = 247;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch vụ";
            // 
            // listDV
            // 
            this.listDV.Enabled = false;
            this.listDV.FormattingEnabled = true;
            this.listDV.Location = new System.Drawing.Point(154, 70);
            this.listDV.Name = "listDV";
            this.listDV.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listDV.Size = new System.Drawing.Size(187, 134);
            this.listDV.TabIndex = 248;
            this.listDV.SelectedIndexChanged += new System.EventHandler(this.listDV_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightGray;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(24, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 22);
            this.label11.TabIndex = 247;
            this.label11.Text = "Dịch vụ";
            // 
            // frmDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1054, 595);
            this.Controls.Add(this.panel1);
            this.Name = "frmDatVe";
            this.Load += new System.EventHandler(this.frmDatVe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_NV;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.ComboBox cb_LT;
        private System.Windows.Forms.ComboBox cb_KH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private JMaterialTextbox.JMaterialTextbox txtDiemDon;
        private JMaterialTextbox.JMaterialTextbox txtMaTourDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.ComboBox cb_tt;
        private System.Windows.Forms.Label label7;
        private JMaterialTextbox.JMaterialTextbox txt_gia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private JThinButton.JThinButton jThinButton1;
        private JMaterialTextbox.JMaterialTextbox txt_giam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox imgTour;
        private System.Windows.Forms.RadioButton rb_themDV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listDV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rb_false;
    }
}