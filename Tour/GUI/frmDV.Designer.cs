namespace GUI
{
    partial class frmDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDV));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaDV = new JMaterialTextbox.JMaterialTextbox();
            this.txtGia = new JMaterialTextbox.JMaterialTextbox();
            this.txt_TenDV = new JMaterialTextbox.JMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmadv = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControlDV = new DevExpress.XtraGrid.GridControl();
            this.dgv_dv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_DV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_DV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dv)).BeginInit();
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
            this.panel1.Controls.Add(this.txtMaDV);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.txt_TenDV);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblmadv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 452);
            this.panel1.TabIndex = 2;
            // 
            // txtMaDV
            // 
            this.txtMaDV.BackColor = System.Drawing.Color.Transparent;
            this.txtMaDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.ForeColors = System.Drawing.Color.Black;
            this.txtMaDV.HintText = null;
            this.txtMaDV.IsPassword = false;
            this.txtMaDV.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaDV.LineThickness = 3;
            this.txtMaDV.Location = new System.Drawing.Point(170, 167);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaDV.MaxLength = 32767;
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.OnFocusedColor = System.Drawing.Color.Black;
            this.txtMaDV.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtMaDV.ReadOnly = true;
            this.txtMaDV.Size = new System.Drawing.Size(146, 28);
            this.txtMaDV.TabIndex = 164;
            this.txtMaDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaDV.TextName = "";
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
            this.txtGia.Location = new System.Drawing.Point(170, 264);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGia.MaxLength = 32767;
            this.txtGia.Name = "txtGia";
            this.txtGia.OnFocusedColor = System.Drawing.Color.Black;
            this.txtGia.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtGia.ReadOnly = false;
            this.txtGia.Size = new System.Drawing.Size(146, 28);
            this.txtGia.TabIndex = 163;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGia.TextName = "";
            // 
            // txt_TenDV
            // 
            this.txt_TenDV.BackColor = System.Drawing.Color.Transparent;
            this.txt_TenDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDV.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDV.ForeColors = System.Drawing.Color.Black;
            this.txt_TenDV.HintText = null;
            this.txt_TenDV.IsPassword = false;
            this.txt_TenDV.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_TenDV.LineThickness = 3;
            this.txt_TenDV.Location = new System.Drawing.Point(170, 214);
            this.txt_TenDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenDV.MaxLength = 32767;
            this.txt_TenDV.Name = "txt_TenDV";
            this.txt_TenDV.OnFocusedColor = System.Drawing.Color.Black;
            this.txt_TenDV.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txt_TenDV.ReadOnly = false;
            this.txt_TenDV.Size = new System.Drawing.Size(146, 28);
            this.txt_TenDV.TabIndex = 162;
            this.txt_TenDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_TenDV.TextName = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(113, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 22);
            this.label8.TabIndex = 160;
            this.label8.Text = "Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 159;
            this.label1.Text = "Tên Dịch Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 158;
            this.label3.Text = "Mã Dịch Vụ";
            // 
            // lblmadv
            // 
            this.lblmadv.AutoSize = true;
            this.lblmadv.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmadv.ForeColor = System.Drawing.Color.Red;
            this.lblmadv.Location = new System.Drawing.Point(145, 161);
            this.lblmadv.Name = "lblmadv";
            this.lblmadv.Size = new System.Drawing.Size(0, 17);
            this.lblmadv.TabIndex = 157;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlDV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(360, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 452);
            this.panel2.TabIndex = 9;
            // 
            // gridControlDV
            // 
            this.gridControlDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDV.Location = new System.Drawing.Point(0, 0);
            this.gridControlDV.MainView = this.dgv_dv;
            this.gridControlDV.MenuManager = this.mainRibbonControl;
            this.gridControlDV.Name = "gridControlDV";
            this.gridControlDV.Size = new System.Drawing.Size(694, 452);
            this.gridControlDV.TabIndex = 0;
            this.gridControlDV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_dv});
            // 
            // dgv_dv
            // 
            this.dgv_dv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_DV,
            this.TEN_DV,
            this.GIA});
            this.dgv_dv.GridControl = this.gridControlDV;
            this.dgv_dv.Name = "dgv_dv";
            this.dgv_dv.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgv_dv_FocusedRowChanged);
            // 
            // MA_DV
            // 
            this.MA_DV.Caption = "Mã dịch vụ";
            this.MA_DV.FieldName = "MA_DICH_VU";
            this.MA_DV.Name = "MA_DV";
            this.MA_DV.OptionsColumn.AllowEdit = false;
            this.MA_DV.Visible = true;
            this.MA_DV.VisibleIndex = 0;
            // 
            // TEN_DV
            // 
            this.TEN_DV.Caption = "Tên dịch vụ";
            this.TEN_DV.FieldName = "TEN_DICH_VU";
            this.TEN_DV.Name = "TEN_DV";
            this.TEN_DV.OptionsColumn.AllowEdit = false;
            this.TEN_DV.Visible = true;
            this.TEN_DV.VisibleIndex = 1;
            // 
            // GIA
            // 
            this.GIA.Caption = "Giá";
            this.GIA.FieldName = "GIA";
            this.GIA.Name = "GIA";
            this.GIA.OptionsColumn.AllowEdit = false;
            this.GIA.Visible = true;
            this.GIA.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã dịch vụ";
            this.gridColumn1.FieldName = "MA_DV";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Reset";
            this.barButtonItem1.Id = 12;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // frmDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1054, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmDV";
            this.Ribbon = this.mainRibbonControl;
            this.Load += new System.EventHandler(this.frmDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dv)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private JMaterialTextbox.JMaterialTextbox txtGia;
        private JMaterialTextbox.JMaterialTextbox txt_TenDV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmadv;
        private JMaterialTextbox.JMaterialTextbox txtMaDV;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControlDV;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_dv;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DV;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_DV;
        private DevExpress.XtraGrid.Columns.GridColumn GIA;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}