namespace GUI
{
    partial class frmNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNV));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_nv = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ma_nv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ten_nv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dia_chi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new JMaterialTextbox.JMaterialTextbox();
            this.txtDiaChi = new JMaterialTextbox.JMaterialTextbox();
            this.txtPass = new JMaterialTextbox.JMaterialTextbox();
            this.txtUser = new JMaterialTextbox.JMaterialTextbox();
            this.txtTenNV = new JMaterialTextbox.JMaterialTextbox();
            this.txtMaNV = new JMaterialTextbox.JMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiAdd,
            this.bbiEdit,
            this.barButtonItem1});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 13;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.ShowCategoryInCaption = false;
            this.mainRibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(1054, 143);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Save And Close";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Save And New";
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
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
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Add";
            this.bbiAdd.Id = 10;
            this.bbiAdd.ImageOptions.ImageUri.Uri = "Add;Size32x32;Office2013";
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 11;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit;Size32x32";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Reset\r\n";
            this.barButtonItem1.Id = 12;
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
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_nv);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1054, 452);
            this.panel2.TabIndex = 5;
            // 
            // dgv_nv
            // 
            this.dgv_nv.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.dgv_nv.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgv_nv.Location = new System.Drawing.Point(369, 0);
            this.dgv_nv.MainView = this.gridView1;
            this.dgv_nv.MenuManager = this.mainRibbonControl;
            this.dgv_nv.Name = "dgv_nv";
            this.dgv_nv.Size = new System.Drawing.Size(685, 452);
            this.dgv_nv.TabIndex = 1;
            this.dgv_nv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ma_nv,
            this.ten_nv,
            this.dia_chi,
            this.email,
            this.username});
            this.gridView1.GridControl = this.dgv_nv;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // ma_nv
            // 
            this.ma_nv.Caption = "Mã nhân viên";
            this.ma_nv.FieldName = "MA_NV";
            this.ma_nv.Name = "ma_nv";
            this.ma_nv.OptionsColumn.AllowEdit = false;
            this.ma_nv.Visible = true;
            this.ma_nv.VisibleIndex = 0;
            // 
            // ten_nv
            // 
            this.ten_nv.Caption = "Tên nhân viên";
            this.ten_nv.FieldName = "TEN_NV";
            this.ten_nv.Name = "ten_nv";
            this.ten_nv.OptionsColumn.AllowEdit = false;
            this.ten_nv.Visible = true;
            this.ten_nv.VisibleIndex = 1;
            // 
            // dia_chi
            // 
            this.dia_chi.Caption = "Địa chỉ";
            this.dia_chi.FieldName = "DIA_CHI";
            this.dia_chi.Name = "dia_chi";
            this.dia_chi.OptionsColumn.AllowEdit = false;
            this.dia_chi.Visible = true;
            this.dia_chi.VisibleIndex = 2;
            // 
            // email
            // 
            this.email.Caption = "Email";
            this.email.FieldName = "EMAIL";
            this.email.Name = "email";
            this.email.OptionsColumn.AllowEdit = false;
            this.email.Visible = true;
            this.email.VisibleIndex = 3;
            // 
            // username
            // 
            this.username.Caption = "Username";
            this.username.FieldName = "USERNAME";
            this.username.Name = "username";
            this.username.OptionsColumn.AllowEdit = false;
            this.username.Visible = true;
            this.username.VisibleIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 452);
            this.panel1.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColors = System.Drawing.Color.Black;
            this.txtEmail.HintText = null;
            this.txtEmail.IsPassword = false;
            this.txtEmail.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(142, 237);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.OnFocusedColor = System.Drawing.Color.Black;
            this.txtEmail.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(188, 29);
            this.txtEmail.TabIndex = 257;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextName = "";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColors = System.Drawing.Color.Black;
            this.txtDiaChi.HintText = null;
            this.txtDiaChi.IsPassword = false;
            this.txtDiaChi.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiaChi.LineThickness = 3;
            this.txtDiaChi.Location = new System.Drawing.Point(142, 187);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.MaxLength = 32767;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.OnFocusedColor = System.Drawing.Color.Black;
            this.txtDiaChi.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtDiaChi.ReadOnly = false;
            this.txtDiaChi.Size = new System.Drawing.Size(188, 29);
            this.txtDiaChi.TabIndex = 256;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiaChi.TextName = "";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColors = System.Drawing.Color.Black;
            this.txtPass.HintText = null;
            this.txtPass.IsPassword = true;
            this.txtPass.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPass.LineThickness = 3;
            this.txtPass.Location = new System.Drawing.Point(142, 341);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.OnFocusedColor = System.Drawing.Color.Black;
            this.txtPass.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtPass.ReadOnly = false;
            this.txtPass.Size = new System.Drawing.Size(188, 29);
            this.txtPass.TabIndex = 255;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.TextName = "";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColors = System.Drawing.Color.Black;
            this.txtUser.HintText = null;
            this.txtUser.IsPassword = false;
            this.txtUser.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUser.LineThickness = 3;
            this.txtUser.Location = new System.Drawing.Point(142, 291);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.OnFocusedColor = System.Drawing.Color.Black;
            this.txtUser.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtUser.ReadOnly = false;
            this.txtUser.Size = new System.Drawing.Size(188, 29);
            this.txtUser.TabIndex = 254;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TextName = "";
            // 
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.Color.Transparent;
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColors = System.Drawing.Color.Black;
            this.txtTenNV.HintText = null;
            this.txtTenNV.IsPassword = false;
            this.txtTenNV.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenNV.LineThickness = 3;
            this.txtTenNV.Location = new System.Drawing.Point(142, 134);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNV.MaxLength = 32767;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.OnFocusedColor = System.Drawing.Color.Black;
            this.txtTenNV.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtTenNV.ReadOnly = false;
            this.txtTenNV.Size = new System.Drawing.Size(188, 29);
            this.txtTenNV.TabIndex = 253;
            this.txtTenNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenNV.TextName = "";
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.Transparent;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColors = System.Drawing.Color.Black;
            this.txtMaNV.HintText = null;
            this.txtMaNV.IsPassword = false;
            this.txtMaNV.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaNV.LineThickness = 3;
            this.txtMaNV.Location = new System.Drawing.Point(142, 86);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNV.MaxLength = 32767;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.OnFocusedColor = System.Drawing.Color.Black;
            this.txtMaNV.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(188, 29);
            this.txtMaNV.TabIndex = 252;
            this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaNV.TextName = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(77, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 251;
            this.label1.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightGray;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(62, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 22);
            this.label12.TabIndex = 250;
            this.label12.Text = "Địa Chỉ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightGray;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(41, 348);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 22);
            this.label13.TabIndex = 249;
            this.label13.Text = "PassWord";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightGray;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(34, 298);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 22);
            this.label14.TabIndex = 248;
            this.label14.Text = "User Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightGray;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(64, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 22);
            this.label15.TabIndex = 247;
            this.label15.Text = "Họ Tên";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LightGray;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(7, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 22);
            this.label16.TabIndex = 246;
            this.label16.Text = "Mã Nhân Viên";
            // 
            // frmNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1054, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmNV";
            this.Ribbon = this.mainRibbonControl;
            this.Load += new System.EventHandler(this.frmNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private JMaterialTextbox.JMaterialTextbox txtEmail;
        private JMaterialTextbox.JMaterialTextbox txtDiaChi;
        private JMaterialTextbox.JMaterialTextbox txtPass;
        private JMaterialTextbox.JMaterialTextbox txtUser;
        private JMaterialTextbox.JMaterialTextbox txtTenNV;
        private JMaterialTextbox.JMaterialTextbox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraGrid.GridControl dgv_nv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ma_nv;
        private DevExpress.XtraGrid.Columns.GridColumn ten_nv;
        private DevExpress.XtraGrid.Columns.GridColumn dia_chi;
        private DevExpress.XtraGrid.Columns.GridColumn email;
        private DevExpress.XtraGrid.Columns.GridColumn username;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}