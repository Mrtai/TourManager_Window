namespace GUI
{
    partial class frmDD
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
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_DD = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaTinh = new JMaterialTextbox.JMaterialTextbox();
            this.txtDD = new JMaterialTextbox.JMaterialTextbox();
            this.txtMa = new JMaterialTextbox.JMaterialTextbox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DD)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
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
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_DD);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 452);
            this.panel1.TabIndex = 2;
            // 
            // dgv_DD
            // 
            this.dgv_DD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DD.Location = new System.Drawing.Point(360, 0);
            this.dgv_DD.Name = "dgv_DD";
            this.dgv_DD.Size = new System.Drawing.Size(694, 452);
            this.dgv_DD.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.txtMaTinh);
            this.panel2.Controls.Add(this.txtDD);
            this.panel2.Controls.Add(this.txtMa);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 452);
            this.panel2.TabIndex = 0;
            // 
            // txtMaTinh
            // 
            this.txtMaTinh.BackColor = System.Drawing.Color.Transparent;
            this.txtMaTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTinh.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTinh.ForeColors = System.Drawing.Color.Black;
            this.txtMaTinh.HintText = null;
            this.txtMaTinh.IsPassword = false;
            this.txtMaTinh.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaTinh.LineThickness = 3;
            this.txtMaTinh.Location = new System.Drawing.Point(171, 273);
            this.txtMaTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTinh.MaxLength = 32767;
            this.txtMaTinh.Name = "txtMaTinh";
            this.txtMaTinh.OnFocusedColor = System.Drawing.Color.Black;
            this.txtMaTinh.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtMaTinh.ReadOnly = false;
            this.txtMaTinh.Size = new System.Drawing.Size(166, 28);
            this.txtMaTinh.TabIndex = 153;
            this.txtMaTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaTinh.TextName = "";
            // 
            // txtDD
            // 
            this.txtDD.BackColor = System.Drawing.Color.Transparent;
            this.txtDD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDD.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDD.ForeColors = System.Drawing.Color.Black;
            this.txtDD.HintText = null;
            this.txtDD.IsPassword = false;
            this.txtDD.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDD.LineThickness = 3;
            this.txtDD.Location = new System.Drawing.Point(171, 226);
            this.txtDD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDD.MaxLength = 32767;
            this.txtDD.Name = "txtDD";
            this.txtDD.OnFocusedColor = System.Drawing.Color.Black;
            this.txtDD.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtDD.ReadOnly = false;
            this.txtDD.Size = new System.Drawing.Size(166, 28);
            this.txtDD.TabIndex = 152;
            this.txtDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDD.TextName = "";
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
            this.txtMa.Location = new System.Drawing.Point(171, 177);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMa.MaxLength = 32767;
            this.txtMa.Name = "txtMa";
            this.txtMa.OnFocusedColor = System.Drawing.Color.Black;
            this.txtMa.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(166, 28);
            this.txtMa.TabIndex = 151;
            this.txtMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMa.TextName = "";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(52, 230);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 24);
            this.label26.TabIndex = 150;
            this.label26.Text = "Địa Điểm";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(52, 277);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(85, 24);
            this.label27.TabIndex = 149;
            this.label27.Text = "Mã Tỉnh";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(24, 181);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(128, 24);
            this.label28.TabIndex = 148;
            this.label28.Text = "Mã Địa Điểm";
            // 
            // frmDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1054, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "frmDD";
            this.Ribbon = this.mainRibbonControl;
            this.Load += new System.EventHandler(this.frmDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgv_DD;
        private JMaterialTextbox.JMaterialTextbox txtMaTinh;
        private JMaterialTextbox.JMaterialTextbox txtDD;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        public JMaterialTextbox.JMaterialTextbox txtMa;
    }
}