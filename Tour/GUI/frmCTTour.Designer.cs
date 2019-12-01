namespace GUI
{
    partial class frmCTTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTTour));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.cb_ks = new System.Windows.Forms.ComboBox();
            this.cb_tour = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChiTiet = new JMaterialTextbox.JMaterialTextbox();
            this.txtTen = new JMaterialTextbox.JMaterialTextbox();
            this.txtMaCT = new JMaterialTextbox.JMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.gc_CCT = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.AllowMdiChildButtons = false;
            this.mainRibbonControl.AllowMinimizeRibbon = false;
            this.mainRibbonControl.AutoSizeItems = true;
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiDelete,
            this.bbiAdd,
            this.bbiEdit,
            this.barButtonItem1});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 15;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(1054, 143);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.mainRibbonControl.Visible = false;
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
            this.bbiAdd.ImageOptions.ImageUri.Uri = "Add;Office2013";
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
            this.panel1.Controls.Add(this.gc_CCT);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 452);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.dtpNgay);
            this.panel2.Controls.Add(this.cb_ks);
            this.panel2.Controls.Add(this.cb_tour);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtChiTiet);
            this.panel2.Controls.Add(this.txtTen);
            this.panel2.Controls.Add(this.txtMaCT);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 452);
            this.panel2.TabIndex = 0;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(189, 274);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(147, 26);
            this.dtpNgay.TabIndex = 186;
            // 
            // cb_ks
            // 
            this.cb_ks.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ks.FormattingEnabled = true;
            this.cb_ks.Location = new System.Drawing.Point(189, 188);
            this.cb_ks.Name = "cb_ks";
            this.cb_ks.Size = new System.Drawing.Size(147, 27);
            this.cb_ks.TabIndex = 185;
            // 
            // cb_tour
            // 
            this.cb_tour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tour.FormattingEnabled = true;
            this.cb_tour.Location = new System.Drawing.Point(189, 150);
            this.cb_tour.Name = "cb_tour";
            this.cb_tour.Size = new System.Drawing.Size(147, 27);
            this.cb_tour.TabIndex = 184;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(253, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 183;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(47, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 182;
            this.label5.Text = "Mã Khách Sạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(253, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 181;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(97, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 180;
            this.label3.Text = "Mã Tour";
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.BackColor = System.Drawing.Color.Transparent;
            this.txtChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiTiet.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiTiet.ForeColors = System.Drawing.Color.Black;
            this.txtChiTiet.HintText = null;
            this.txtChiTiet.IsPassword = false;
            this.txtChiTiet.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtChiTiet.LineThickness = 3;
            this.txtChiTiet.Location = new System.Drawing.Point(189, 320);
            this.txtChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChiTiet.MaxLength = 32767;
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.OnFocusedColor = System.Drawing.Color.Black;
            this.txtChiTiet.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtChiTiet.ReadOnly = false;
            this.txtChiTiet.Size = new System.Drawing.Size(147, 23);
            this.txtChiTiet.TabIndex = 179;
            this.txtChiTiet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChiTiet.TextName = "";
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
            this.txtTen.Location = new System.Drawing.Point(189, 230);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.MaxLength = 32767;
            this.txtTen.Name = "txtTen";
            this.txtTen.OnFocusedColor = System.Drawing.Color.Black;
            this.txtTen.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtTen.ReadOnly = false;
            this.txtTen.Size = new System.Drawing.Size(147, 23);
            this.txtTen.TabIndex = 177;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTen.TextName = "";
            // 
            // txtMaCT
            // 
            this.txtMaCT.BackColor = System.Drawing.Color.Transparent;
            this.txtMaCT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCT.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCT.ForeColors = System.Drawing.Color.Black;
            this.txtMaCT.HintText = null;
            this.txtMaCT.IsPassword = false;
            this.txtMaCT.LineBackColor = System.Drawing.Color.Black;
            this.txtMaCT.LineThickness = 3;
            this.txtMaCT.Location = new System.Drawing.Point(189, 110);
            this.txtMaCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaCT.MaxLength = 32767;
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.OnFocusedColor = System.Drawing.Color.Black;
            this.txtMaCT.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtMaCT.ReadOnly = true;
            this.txtMaCT.Size = new System.Drawing.Size(147, 23);
            this.txtMaCT.TabIndex = 176;
            this.txtMaCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaCT.TextName = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(126, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 175;
            this.label1.Text = "Ngày";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.LightGray;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(102, 321);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 22);
            this.label18.TabIndex = 174;
            this.label18.Text = "Chi Tiết";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.LightGray;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(16, 231);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(163, 22);
            this.label22.TabIndex = 173;
            this.label22.Text = "Tên Chương Trình";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.LightGray;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(20, 111);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(159, 22);
            this.label23.TabIndex = 172;
            this.label23.Text = "Mã Chương Trình";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Reset";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // gc_CCT
            // 
            this.gc_CCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_CCT.Location = new System.Drawing.Point(369, 0);
            this.gc_CCT.MainView = this.gridView1;
            this.gc_CCT.MenuManager = this.mainRibbonControl;
            this.gc_CCT.Name = "gc_CCT";
            this.gc_CCT.Size = new System.Drawing.Size(685, 452);
            this.gc_CCT.TabIndex = 1;
            this.gc_CCT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_CCT;
            this.gridView1.Name = "gridView1";
            // 
            // frmCTTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1054, 595);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainRibbonControl);
            this.Enabled = false;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Name = "frmCTTour";
            this.Ribbon = this.mainRibbonControl;
            this.RibbonAlwaysAtBack = false;
            this.Load += new System.EventHandler(this.frmCTTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_ks;
        private System.Windows.Forms.ComboBox cb_tour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private JMaterialTextbox.JMaterialTextbox txtChiTiet;
        private JMaterialTextbox.JMaterialTextbox txtTen;
        private JMaterialTextbox.JMaterialTextbox txtMaCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.GridControl gc_CCT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}