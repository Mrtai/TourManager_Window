namespace GUI
{
    partial class frmLoaiTT
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
            this.txtCT = new JMaterialTextbox.JMaterialTextbox();
            this.txtTT = new JMaterialTextbox.JMaterialTextbox();
            this.txtMa = new JMaterialTextbox.JMaterialTextbox();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dgv_LTT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LTT)).BeginInit();
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
            this.bbiEdit});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 12;
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
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtCT);
            this.panel1.Controls.Add(this.txtTT);
            this.panel1.Controls.Add(this.txtMa);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 452);
            this.panel1.TabIndex = 2;
            // 
            // txtCT
            // 
            this.txtCT.BackColor = System.Drawing.Color.Transparent;
            this.txtCT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCT.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCT.ForeColors = System.Drawing.Color.Black;
            this.txtCT.HintText = null;
            this.txtCT.IsPassword = false;
            this.txtCT.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCT.LineThickness = 3;
            this.txtCT.Location = new System.Drawing.Point(157, 135);
            this.txtCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCT.MaxLength = 32767;
            this.txtCT.Name = "txtCT";
            this.txtCT.OnFocusedColor = System.Drawing.Color.Black;
            this.txtCT.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtCT.ReadOnly = false;
            this.txtCT.Size = new System.Drawing.Size(172, 28);
            this.txtCT.TabIndex = 173;
            this.txtCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCT.TextName = "";
            // 
            // txtTT
            // 
            this.txtTT.BackColor = System.Drawing.Color.Transparent;
            this.txtTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTT.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTT.ForeColors = System.Drawing.Color.Black;
            this.txtTT.HintText = null;
            this.txtTT.IsPassword = false;
            this.txtTT.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTT.LineThickness = 3;
            this.txtTT.Location = new System.Drawing.Point(157, 90);
            this.txtTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTT.MaxLength = 32767;
            this.txtTT.Name = "txtTT";
            this.txtTT.OnFocusedColor = System.Drawing.Color.Black;
            this.txtTT.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtTT.ReadOnly = false;
            this.txtTT.Size = new System.Drawing.Size(172, 28);
            this.txtTT.TabIndex = 172;
            this.txtTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTT.TextName = "";
            // 
            // txtMa
            // 
            this.txtMa.BackColor = System.Drawing.Color.Transparent;
            this.txtMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.ForeColors = System.Drawing.Color.Black;
            this.txtMa.HintText = null;
            this.txtMa.IsPassword = false;
            this.txtMa.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMa.LineThickness = 3;
            this.txtMa.Location = new System.Drawing.Point(157, 44);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMa.MaxLength = 32767;
            this.txtMa.Name = "txtMa";
            this.txtMa.OnFocusedColor = System.Drawing.Color.Black;
            this.txtMa.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtMa.ReadOnly = false;
            this.txtMa.Size = new System.Drawing.Size(172, 28);
            this.txtMa.TabIndex = 171;
            this.txtMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMa.TextName = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.LightGray;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(61, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 22);
            this.label18.TabIndex = 170;
            this.label18.Text = "Chi Tiết";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.LightGray;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(60, 96);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 22);
            this.label22.TabIndex = 169;
            this.label22.Text = "Loại TT";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.LightGray;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(27, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(111, 22);
            this.label23.TabIndex = 168;
            this.label23.Text = "Mã Loại TT";
            // 
            // dgv_LTT
            // 
            this.dgv_LTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_LTT.Location = new System.Drawing.Point(360, 143);
            this.dgv_LTT.Name = "dgv_LTT";
            this.dgv_LTT.Size = new System.Drawing.Size(694, 452);
            this.dgv_LTT.TabIndex = 3;
            // 
            // frmLoaiTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1054, 595);
            this.Controls.Add(this.dgv_LTT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "frmLoaiTT";
            this.Ribbon = this.mainRibbonControl;
            this.Load += new System.EventHandler(this.frmLoaiTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LTT)).EndInit();
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
        private JMaterialTextbox.JMaterialTextbox txtCT;
        private JMaterialTextbox.JMaterialTextbox txtTT;
        private JMaterialTextbox.JMaterialTextbox txtMa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgv_LTT;
    }
}