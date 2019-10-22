using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class login: UserControl
    {
        private static string username,password;

        public login()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            login.username = txt_username.TextName;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_Load(object sender, EventArgs e)
        {

        }

        private void txt_username_Load(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

       
    }
}
