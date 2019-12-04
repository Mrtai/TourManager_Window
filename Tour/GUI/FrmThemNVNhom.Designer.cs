namespace GUI
{
    partial class FrmThemNVNhom
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
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_them = new System.Windows.Forms.Button();
            this.cb_nhom = new System.Windows.Forms.ComboBox();
            this.gc_nhomnv = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_nv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_nhomnv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_nv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 100);
            this.panel1.TabIndex = 244;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(322, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(376, 37);
            this.label10.TabIndex = 243;
            this.label10.Text = "Thêm người dùng vào nhóm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gc_nv);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.cb_nhom);
            this.panel2.Controls.Add(this.gc_nhomnv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 461);
            this.panel2.TabIndex = 246;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(494, 73);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(96, 23);
            this.btn_them.TabIndex = 246;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // cb_nhom
            // 
            this.cb_nhom.FormattingEnabled = true;
            this.cb_nhom.Location = new System.Drawing.Point(472, 24);
            this.cb_nhom.Name = "cb_nhom";
            this.cb_nhom.Size = new System.Drawing.Size(139, 21);
            this.cb_nhom.TabIndex = 245;
            this.cb_nhom.SelectedIndexChanged += new System.EventHandler(this.cb_nhom_SelectedIndexChanged);
            // 
            // gc_nhomnv
            // 
            this.gc_nhomnv.Dock = System.Windows.Forms.DockStyle.Right;
            this.gc_nhomnv.Location = new System.Drawing.Point(630, 0);
            this.gc_nhomnv.MainView = this.gridView2;
            this.gc_nhomnv.Name = "gc_nhomnv";
            this.gc_nhomnv.Size = new System.Drawing.Size(418, 461);
            this.gc_nhomnv.TabIndex = 244;
            this.gc_nhomnv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.GridControl = this.gc_nhomnv;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã nhân viên";
            this.gridColumn3.FieldName = "MA_NHAN_VIEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã nhóm";
            this.gridColumn4.FieldName = "MA_NHOM";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gc_nv
            // 
            this.gc_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gc_nv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gc_nv.Dock = System.Windows.Forms.DockStyle.Left;
            this.gc_nv.Location = new System.Drawing.Point(0, 0);
            this.gc_nv.Name = "gc_nv";
            this.gc_nv.Size = new System.Drawing.Size(417, 461);
            this.gc_nv.TabIndex = 247;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MA_NV";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TEN_NV";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.Name = "Column2";
            // 
            // FrmThemNVNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmThemNVNhom";
            this.Text = "FrmThemNVNhom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_nhomnv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_nv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cb_nhom;
        private DevExpress.XtraGrid.GridControl gc_nhomnv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.DataGridView gc_nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}