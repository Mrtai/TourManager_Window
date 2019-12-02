using DAL_TOUR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        Config config = new Config();
       
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.TextName == "")
            {
                MessageBox.Show("Không được bỏ trống Username");
                this.txt_username.Focus();
                return;
            }
            if (txt_pass.TextName == "")
            {
                MessageBox.Show("Không được bỏ trống Password");
                this.txt_pass.Focus();
                return;
            }
            int kq = config.Check_Config();
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                ProcessConfig();
            }
        }
        private void ProcessLogin()
        {

            byte[] pass = UnicodeEncoding.ASCII.GetBytes(txt_pass.TextName);
            NhanVienDAL NhanVienService = new NhanVienDAL();
            if (NhanVienService.Login(txt_username.TextName, pass))
            {
                if (Program.frmMain == null || Program.frmMain.IsDisposed)
                {
                    Program.frmMain = new frmMain();
                }
                this.Hide();
                Program.frmMain.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công", "Thông báo");
            }

            
            
           
           
        }
        public void ProcessConfig()
        {
            this.Hide();
            frmCH frm = new frmCH();

            frm.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(config.GetConnectionString());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
