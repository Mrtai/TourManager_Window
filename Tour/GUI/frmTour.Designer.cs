namespace GUI
{
    partial class frmTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTour));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameimg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGiamGia = new JMaterialTextbox.JMaterialTextbox();
            this.txtGia = new JMaterialTextbox.JMaterialTextbox();
            this.txtSoCho = new JMaterialTextbox.JMaterialTextbox();
            this.txtSoNgay = new JMaterialTextbox.JMaterialTextbox();
            this.cb_loait = new System.Windows.Forms.ComboBox();
            this.txtTen = new JMaterialTextbox.JMaterialTextbox();
            this.txtMaTour = new JMaterialTextbox.JMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblma = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gc_tour = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.matour = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tentour = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_tour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiAdd,
            this.bbiEdit,
            this.bbiReset,
            this.bbiDelete,
            this.barButtonItem1});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 11;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(1054, 143);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Add";
            this.bbiAdd.Enabled = false;
            this.bbiAdd.Id = 3;
            this.bbiAdd.ImageOptions.ImageUri.Uri = "Add;Size32x32;Office2013";
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 4;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit;Size32x32";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Reset";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiAdd);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiEdit);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiDelete);
            this.mainRibbonPageGroup.ItemLinks.Add(this.barButtonItem1);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.nameimg);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtGiamGia);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.txtSoCho);
            this.panel1.Controls.Add(this.txtSoNgay);
            this.panel1.Controls.Add(this.cb_loait);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.txtMaTour);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblma);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 452);
            this.panel1.TabIndex = 2;
            // 
            // nameimg
            // 
            this.nameimg.AutoSize = true;
            this.nameimg.Location = new System.Drawing.Point(12, 288);
            this.nameimg.Name = "nameimg";
            this.nameimg.Size = new System.Drawing.Size(0, 13);
            this.nameimg.TabIndex = 207;
            this.nameimg.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 206;
            this.button1.Text = " Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.TabIndex = 205;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.BackColor = System.Drawing.Color.Transparent;
            this.txtGiamGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.ForeColors = System.Drawing.Color.Black;
            this.txtGiamGia.HintText = null;
            this.txtGiamGia.IsPassword = false;
            this.txtGiamGia.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGiamGia.LineThickness = 3;
            this.txtGiamGia.Location = new System.Drawing.Point(308, 321);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiamGia.MaxLength = 32767;
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.OnFocusedColor = System.Drawing.Color.Black;
            this.txtGiamGia.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtGiamGia.ReadOnly = false;
            this.txtGiamGia.Size = new System.Drawing.Size(170, 28);
            this.txtGiamGia.TabIndex = 204;
            this.txtGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGiamGia.TextName = "";
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.Transparent;
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColors = System.Drawing.Color.Black;
            this.txtGia.HintText = null;
            this.txtGia.IsPassword = false;
            this.txtGia.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGia.LineThickness = 3;
            this.txtGia.Location = new System.Drawing.Point(308, 276);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGia.MaxLength = 32767;
            this.txtGia.Name = "txtGia";
            this.txtGia.OnFocusedColor = System.Drawing.Color.Black;
            this.txtGia.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtGia.ReadOnly = false;
            this.txtGia.Size = new System.Drawing.Size(170, 28);
            this.txtGia.TabIndex = 203;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGia.TextName = "";
            // 
            // txtSoCho
            // 
            this.txtSoCho.BackColor = System.Drawing.Color.Transparent;
            this.txtSoCho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCho.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCho.ForeColors = System.Drawing.Color.Black;
            this.txtSoCho.HintText = null;
            this.txtSoCho.IsPassword = false;
            this.txtSoCho.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoCho.LineThickness = 3;
            this.txtSoCho.Location = new System.Drawing.Point(308, 231);
            this.txtSoCho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoCho.MaxLength = 32767;
            this.txtSoCho.Name = "txtSoCho";
            this.txtSoCho.OnFocusedColor = System.Drawing.Color.Black;
            this.txtSoCho.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtSoCho.ReadOnly = false;
            this.txtSoCho.Size = new System.Drawing.Size(170, 28);
            this.txtSoCho.TabIndex = 202;
            this.txtSoCho.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoCho.TextName = "";
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.BackColor = System.Drawing.Color.Transparent;
            this.txtSoNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgay.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgay.ForeColors = System.Drawing.Color.Black;
            this.txtSoNgay.HintText = null;
            this.txtSoNgay.IsPassword = false;
            this.txtSoNgay.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoNgay.LineThickness = 3;
            this.txtSoNgay.Location = new System.Drawing.Point(308, 184);
            this.txtSoNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoNgay.MaxLength = 32767;
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.OnFocusedColor = System.Drawing.Color.Black;
            this.txtSoNgay.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtSoNgay.ReadOnly = false;
            this.txtSoNgay.Size = new System.Drawing.Size(170, 28);
            this.txtSoNgay.TabIndex = 201;
            this.txtSoNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoNgay.TextName = "";
            // 
            // cb_loait
            // 
            this.cb_loait.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_loait.FormattingEnabled = true;
            this.cb_loait.Location = new System.Drawing.Point(308, 91);
            this.cb_loait.Name = "cb_loait";
            this.cb_loait.Size = new System.Drawing.Size(170, 27);
            this.cb_loait.TabIndex = 200;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.Transparent;
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColors = System.Drawing.Color.Black;
            this.txtTen.HintText = null;
            this.txtTen.IsPassword = false;
            this.txtTen.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTen.LineThickness = 3;
            this.txtTen.Location = new System.Drawing.Point(308, 134);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.MaxLength = 32767;
            this.txtTen.Name = "txtTen";
            this.txtTen.OnFocusedColor = System.Drawing.Color.Black;
            this.txtTen.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtTen.ReadOnly = false;
            this.txtTen.Size = new System.Drawing.Size(170, 28);
            this.txtTen.TabIndex = 199;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTen.TextName = "";
            // 
            // txtMaTour
            // 
            this.txtMaTour.BackColor = System.Drawing.Color.Transparent;
            this.txtMaTour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTour.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTour.ForeColors = System.Drawing.Color.Black;
            this.txtMaTour.HintText = null;
            this.txtMaTour.IsPassword = false;
            this.txtMaTour.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaTour.LineThickness = 3;
            this.txtMaTour.Location = new System.Drawing.Point(308, 40);
            this.txtMaTour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTour.MaxLength = 32767;
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.OnFocusedColor = System.Drawing.Color.Black;
            this.txtMaTour.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtMaTour.ReadOnly = true;
            this.txtMaTour.Size = new System.Drawing.Size(170, 28);
            this.txtMaTour.TabIndex = 198;
            this.txtMaTour.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaTour.TextName = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(210, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 197;
            this.label6.Text = "Mã Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(211, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 196;
            this.label5.Text = "Số Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(220, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 195;
            this.label4.Text = "Số Chỗ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(204, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 194;
            this.label2.Text = "Tên Tour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(250, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 22);
            this.label8.TabIndex = 193;
            this.label8.Text = "Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(200, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 192;
            this.label1.Text = "Giảm Giá";
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblma.ForeColor = System.Drawing.Color.Red;
            this.lblma.Location = new System.Drawing.Point(270, 94);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(0, 24);
            this.lblma.TabIndex = 191;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(208, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 190;
            this.label3.Text = "Mã Tour";
            // 
            // gc_tour
            // 
            this.gc_tour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_tour.Location = new System.Drawing.Point(510, 143);
            this.gc_tour.MainView = this.gridView1;
            this.gc_tour.MenuManager = this.mainRibbonControl;
            this.gc_tour.Name = "gc_tour";
            this.gc_tour.Size = new System.Drawing.Size(544, 452);
            this.gc_tour.TabIndex = 5;
            this.gc_tour.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.matour,
            this.tentour,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.GridControl = this.gc_tour;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // matour
            // 
            this.matour.Caption = "Mã Tour";
            this.matour.FieldName = "MA_TOUR";
            this.matour.Name = "matour";
            this.matour.Visible = true;
            this.matour.VisibleIndex = 0;
            // 
            // tentour
            // 
            this.tentour.Caption = "Tên Tour";
            this.tentour.FieldName = "TEN_TOUR";
            this.tentour.Name = "tentour";
            this.tentour.Visible = true;
            this.tentour.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số ngày";
            this.gridColumn3.FieldName = "SO_NGAY";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Loai Tour";
            this.gridColumn4.FieldName = "LOAI_TOUR.TEN_LOAI";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số chỗ";
            this.gridColumn5.FieldName = "SO_CHO";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Giá";
            this.gridColumn6.FieldName = "GIA";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Giảm giá";
            this.gridColumn7.FieldName = "DISCOUNT";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1054, 595);
            this.Controls.Add(this.gc_tour);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "frmTour";
            this.Ribbon = this.mainRibbonControl;
            this.Load += new System.EventHandler(this.frmTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_tour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private System.Windows.Forms.Panel panel1;
        private JMaterialTextbox.JMaterialTextbox txtGiamGia;
        private JMaterialTextbox.JMaterialTextbox txtGia;
        private JMaterialTextbox.JMaterialTextbox txtSoCho;
        private JMaterialTextbox.JMaterialTextbox txtSoNgay;
        private System.Windows.Forms.ComboBox cb_loait;
        private JMaterialTextbox.JMaterialTextbox txtTen;
        private JMaterialTextbox.JMaterialTextbox txtMaTour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.GridControl gc_tour;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.Columns.GridColumn matour;
        private DevExpress.XtraGrid.Columns.GridColumn tentour;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label nameimg;
    }
}