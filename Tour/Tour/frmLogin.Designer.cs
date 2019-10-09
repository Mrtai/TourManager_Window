namespace Tour
{
    partial class frmLogin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.jMaterialTextbox1 = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextbox2 = new JMaterialTextbox.JMaterialTextbox();
            this.jThinButton1 = new JThinButton.JThinButton();
            this.jThinButton2 = new JThinButton.JThinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.jThinButton2);
            this.panel2.Controls.Add(this.jThinButton1);
            this.panel2.Controls.Add(this.jMaterialTextbox2);
            this.panel2.Controls.Add(this.jMaterialTextbox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 265);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // jMaterialTextbox1
            // 
            this.jMaterialTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox1.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox1.ForeColors = System.Drawing.Color.Black;
            this.jMaterialTextbox1.HintText = "Fill username";
            this.jMaterialTextbox1.IsPassword = false;
            this.jMaterialTextbox1.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jMaterialTextbox1.LineThickness = 2;
            this.jMaterialTextbox1.Location = new System.Drawing.Point(105, 54);
            this.jMaterialTextbox1.MaxLength = 32767;
            this.jMaterialTextbox1.Name = "jMaterialTextbox1";
            this.jMaterialTextbox1.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox1.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox1.ReadOnly = false;
            this.jMaterialTextbox1.Size = new System.Drawing.Size(244, 23);
            this.jMaterialTextbox1.TabIndex = 0;
            this.jMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox1.TextName = "Fill username";
            // 
            // jMaterialTextbox2
            // 
            this.jMaterialTextbox2.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox2.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox2.ForeColors = System.Drawing.Color.Black;
            this.jMaterialTextbox2.HintText = "Fill password";
            this.jMaterialTextbox2.IsPassword = false;
            this.jMaterialTextbox2.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jMaterialTextbox2.LineThickness = 2;
            this.jMaterialTextbox2.Location = new System.Drawing.Point(105, 116);
            this.jMaterialTextbox2.MaxLength = 32767;
            this.jMaterialTextbox2.Name = "jMaterialTextbox2";
            this.jMaterialTextbox2.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox2.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox2.ReadOnly = false;
            this.jMaterialTextbox2.Size = new System.Drawing.Size(244, 18);
            this.jMaterialTextbox2.TabIndex = 1;
            this.jMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox2.TextName = "Fill password";
            // 
            // jThinButton1
            // 
            this.jThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton1.BackgroundColor = System.Drawing.Color.White;
            this.jThinButton1.BorderColor = System.Drawing.SystemColors.Highlight;
            this.jThinButton1.BorderRadius = 17;
            this.jThinButton1.ButtonText = "Login";
            this.jThinButton1.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButton1.ForeColors = System.Drawing.SystemColors.Highlight;
            this.jThinButton1.HoverBackground = System.Drawing.Color.White;
            this.jThinButton1.HoverBorder = System.Drawing.Color.Empty;
            this.jThinButton1.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.jThinButton1.LineThickness = 2;
            this.jThinButton1.Location = new System.Drawing.Point(105, 161);
            this.jThinButton1.Name = "jThinButton1";
            this.jThinButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jThinButton1.Size = new System.Drawing.Size(74, 38);
            this.jThinButton1.TabIndex = 2;
            // 
            // jThinButton2
            // 
            this.jThinButton2.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton2.BackgroundColor = System.Drawing.Color.White;
            this.jThinButton2.BorderColor = System.Drawing.SystemColors.Highlight;
            this.jThinButton2.BorderRadius = 17;
            this.jThinButton2.ButtonText = "Exit";
            this.jThinButton2.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButton2.ForeColors = System.Drawing.SystemColors.Highlight;
            this.jThinButton2.HoverBackground = System.Drawing.Color.White;
            this.jThinButton2.HoverBorder = System.Drawing.Color.Empty;
            this.jThinButton2.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.jThinButton2.LineThickness = 2;
            this.jThinButton2.Location = new System.Drawing.Point(257, 161);
            this.jThinButton2.Margin = new System.Windows.Forms.Padding(2);
            this.jThinButton2.Name = "jThinButton2";
            this.jThinButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jThinButton2.Size = new System.Drawing.Size(83, 38);
            this.jThinButton2.TabIndex = 3;
            this.jThinButton2.Click += new System.EventHandler(this.jThinButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(83, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tour Management";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 365);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox2;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private JThinButton.JThinButton jThinButton2;
        private JThinButton.JThinButton jThinButton1;
    }
}