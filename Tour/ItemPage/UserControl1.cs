using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemPage
{
    public partial class UserControl1: UserControl
    {
        private Form frmDetail;
        private Form frmDat;
        //public delegate EventHandler 
        public string labelName
        {
            get { return lb_name.Text; }
            set { lb_name.Text = value; }
        }
        public string labelGia
        {
            get { return lb_gia.Text; }
            set { lb_gia.Text = value; }
        }
        public string imgURL
        {
            get { return img.ImageLocation; }
            set { img.ImageLocation = value; }
        }
        public Form formDetail
        {
            get { return frmDetail; }
            set { frmDetail = value; }
        }
        public Form formDat
        {
            set { frmDat = value; }
            get { return frmDat; }
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            frmDetail.Show();
        }

        private void btn_dat_Click(object sender, EventArgs e)
        {
            frmDat.Show();
        }
    }
}
