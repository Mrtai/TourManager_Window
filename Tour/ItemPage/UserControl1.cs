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
        public event EventHandler DatButtonClick;
        public event EventHandler DetailButtonClick;

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
        public UserControl1()
        {
            InitializeComponent();
            btn_dat.Click += DatButtonClick;
            btn_detail.Click += DetailButtonClick;
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            DetailButtonClick?.Invoke(btn_detail, e);
        }

        private void btn_dat_Click(object sender, EventArgs e)
        {
            DatButtonClick?.Invoke(btn_dat, e);
        }
    }
}
