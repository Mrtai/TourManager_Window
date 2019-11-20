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
    public partial class login : UserControl
    {
        public event EventHandler DangNhapButtonClick;
        public event EventHandler ThoatButtonClick;
        public string username
        {
            get { return txt_username.TextName; }
            set { txt_username.TextName = value; }
        }
        public string password
        {
            get { return txt_password.TextName; }
            set { txt_password.TextName = value; }
        }
        public login()
        {
            InitializeComponent();
            jThinButton1.Click += DangNhapButtonClick;

        }

        private void jMaterialTextbox1_Load(object sender, EventArgs e)
        {
            
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
