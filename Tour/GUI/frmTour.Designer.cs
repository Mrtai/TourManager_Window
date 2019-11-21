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
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Tour = new System.Windows.Forms.DataGridView();
            this.jMaterialTextbox6 = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextbox5 = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextbox4 = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextbox3 = new JMaterialTextbox.JMaterialTextbox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.jMaterialTextbox2 = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextbox1 = new JMaterialTextbox.JMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblma = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tour)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiSave,
            this.bbiAdd,
            this.bbiEdit,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(1054, 143);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Add";
            this.bbiAdd.Id = 3;
            this.bbiAdd.ImageOptions.ImageUri.Uri = "Add;Size32x32;Office2013";
            this.bbiAdd.Name = "bbiAdd";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 4;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit;Size32x32";
            this.bbiEdit.Name = "bbiEdit";
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
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
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
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.jMaterialTextbox6);
            this.panel1.Controls.Add(this.jMaterialTextbox5);
            this.panel1.Controls.Add(this.jMaterialTextbox4);
            this.panel1.Controls.Add(this.jMaterialTextbox3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.jMaterialTextbox2);
            this.panel1.Controls.Add(this.jMaterialTextbox1);
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
            this.panel1.Size = new System.Drawing.Size(360, 452);
            this.panel1.TabIndex = 2;
            // 
            // dgv_Tour
            // 
            this.dgv_Tour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Tour.Location = new System.Drawing.Point(360, 143);
            this.dgv_Tour.Name = "dgv_Tour";
            this.dgv_Tour.Size = new System.Drawing.Size(694, 452);
            this.dgv_Tour.TabIndex = 3;
            // 
            // jMaterialTextbox6
            // 
            this.jMaterialTextbox6.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextbox6.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextbox6.ForeColors = System.Drawing.Color.Black;
            this.jMaterialTextbox6.HintText = null;
            this.jMaterialTextbox6.IsPassword = false;
            this.jMaterialTextbox6.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jMaterialTextbox6.LineThickness = 3;
            this.jMaterialTextbox6.Location = new System.Drawing.Point(149, 353);
            this.jMaterialTextbox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMaterialTextbox6.MaxLength = 32767;
            this.jMaterialTextbox6.Name = "jMaterialTextbox6";
            this.jMaterialTextbox6.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox6.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox6.ReadOnly = false;
            this.jMaterialTextbox6.Size = new System.Drawing.Size(170, 28);
            this.jMaterialTextbox6.TabIndex = 204;
            this.jMaterialTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox6.TextName = "";
            // 
            // jMaterialTextbox5
            // 
            this.jMaterialTextbox5.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextbox5.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextbox5.ForeColors = System.Drawing.Color.Black;
            this.jMaterialTextbox5.HintText = null;
            this.jMaterialTextbox5.IsPassword = false;
            this.jMaterialTextbox5.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jMaterialTextbox5.LineThickness = 3;
            this.jMaterialTextbox5.Location = new System.Drawing.Point(149, 308);
            this.jMaterialTextbox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMaterialTextbox5.MaxLength = 32767;
            this.jMaterialTextbox5.Name = "jMaterialTextbox5";
            this.jMaterialTextbox5.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox5.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox5.ReadOnly = false;
            this.jMaterialTextbox5.Size = new System.Drawing.Size(170, 28);
            this.jMaterialTextbox5.TabIndex = 203;
            this.jMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox5.TextName = "";
            // 
            // jMaterialTextbox4
            // 
            this.jMaterialTextbox4.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextbox4.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextbox4.ForeColors = System.Drawing.Color.Black;
            this.jMaterialTextbox4.HintText = null;
            this.jMaterialTextbox4.IsPassword = false;
            this.jMaterialTextbox4.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jMaterialTextbox4.LineThickness = 3;
            this.jMaterialTextbox4.Location = new System.Drawing.Point(149, 263);
            this.jMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMaterialTextbox4.MaxLength = 32767;
            this.jMaterialTextbox4.Name = "jMaterialTextbox4";
            this.jMaterialTextbox4.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox4.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox4.ReadOnly = false;
            this.jMaterialTextbox4.Size = new System.Drawing.Size(170, 28);
            this.jMaterialTextbox4.TabIndex = 202;
            this.jMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox4.TextName = "";
            // 
            // jMaterialTextbox3
            // 
            this.jMaterialTextbox3.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextbox3.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextbox3.ForeColors = System.Drawing.Color.Black;
            this.jMaterialTextbox3.HintText = null;
            this.jMaterialTextbox3.IsPassword = false;
            this.jMaterialTextbox3.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jMaterialTextbox3.LineThickness = 3;
            this.jMaterialTextbox3.Location = new System.Drawing.Point(149, 216);
            this.jMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMaterialTextbox3.MaxLength = 32767;
            this.jMaterialTextbox3.Name = "jMaterialTextbox3";
            this.jMaterialTextbox3.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox3.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox3.ReadOnly = false;
            this.jMaterialTextbox3.Size = new System.Drawing.Size(170, 28);
            this.jMaterialTextbox3.TabIndex = 201;
            this.jMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox3.TextName = "";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 27);
            this.comboBox1.TabIndex = 200;
            // 
            // jMaterialTextbox2
            // 
            this.jMaterialTextbox2.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextbox2.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextbox2.ForeColors = System.Drawing.Color.Black;
            this.jMaterialTextbox2.HintText = null;
            this.jMaterialTextbox2.IsPassword = false;
            this.jMaterialTextbox2.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jMaterialTextbox2.LineThickness = 3;
            this.jMaterialTextbox2.Location = new System.Drawing.Point(149, 166);
            this.jMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMaterialTextbox2.MaxLength = 32767;
            this.jMaterialTextbox2.Name = "jMaterialTextbox2";
            this.jMaterialTextbox2.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox2.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox2.ReadOnly = false;
            this.jMaterialTextbox2.Size = new System.Drawing.Size(170, 28);
            this.jMaterialTextbox2.TabIndex = 199;
            this.jMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox2.TextName = "";
            // 
            // jMaterialTextbox1
            // 
            this.jMaterialTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextbox1.Font_Size = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextbox1.ForeColors = System.Drawing.Color.Black;
            this.jMaterialTextbox1.HintText = null;
            this.jMaterialTextbox1.IsPassword = false;
            this.jMaterialTextbox1.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jMaterialTextbox1.LineThickness = 3;
            this.jMaterialTextbox1.Location = new System.Drawing.Point(149, 72);
            this.jMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMaterialTextbox1.MaxLength = 32767;
            this.jMaterialTextbox1.Name = "jMaterialTextbox1";
            this.jMaterialTextbox1.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox1.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox1.ReadOnly = false;
            this.jMaterialTextbox1.Size = new System.Drawing.Size(170, 28);
            this.jMaterialTextbox1.TabIndex = 198;
            this.jMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox1.TextName = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(51, 128);
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
            this.label5.Location = new System.Drawing.Point(52, 222);
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
            this.label4.Location = new System.Drawing.Point(61, 269);
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
            this.label2.Location = new System.Drawing.Point(45, 172);
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
            this.label8.Location = new System.Drawing.Point(91, 314);
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
            this.label1.Location = new System.Drawing.Point(41, 359);
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
            this.lblma.Location = new System.Drawing.Point(111, 126);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(0, 24);
            this.lblma.TabIndex = 191;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(49, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 190;
            this.label3.Text = "Mã Tour";
            // 
            // frmTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1054, 595);
            this.Controls.Add(this.dgv_Tour);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "frmTour";
            this.Ribbon = this.mainRibbonControl;
            this.Load += new System.EventHandler(this.frmTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Tour;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox6;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox5;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox4;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox2;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.Label label3;
    }
}