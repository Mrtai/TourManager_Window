using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Sql;
using System.Data.SqlClient;
using DAL_TOUR;

namespace GUI
{
    public partial class frmCH : DevExpress.XtraEditors.XtraForm
    {
        Config config = new Config();
        public frmCH()
        {
            InitializeComponent();
        }

        private void frmCH_Load(object sender, EventArgs e)
        {
            
        }

        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }
        public List<string> GetDatabaseName(string pServerName, string pUser, string pPass)
        {
            List<string> _list = new List<string>();
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM  sys.databases", "Data Source = " + pServerName + "; Initial Catalog = " + "master" + "; User ID = " + pUser + "; pwd = " + pPass + "");
                da.Fill(dt);
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    foreach (System.Data.DataColumn col in dt.Columns)
                    {
                        _list.Add(row[col].ToString());
                    }
                }
            }
            catch
            {
                return null;
            }
            return _list;
        }

        private void cb_server_DropDown(object sender, EventArgs e)
        {
            DataTable dt = GetServerName();
            cb_server.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                foreach (System.Data.DataColumn col in dt.Columns)
                {
                    cb_server.Items.Add(row[col]);
                }
            }
        }

        private void cb_database_DropDown(object sender, EventArgs e)
        {
            cb_database.Items.Clear();
            List<string> _list = GetDatabaseName(cb_server.Text,
            txt_user.TextName, txt_pass.TextName);
            if (_list == null)
            {
                MessageBox.Show("Thông tin cấu hình chưa chính xác");
                return;
            }
            foreach (string item in _list)
            {
                cb_database.Items.Add(item);
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            config.SaveConnectionString(cb_server.Text, cb_database.Text, txt_user.TextName, txt_pass.TextName);
            //DAL_TOUR.Config.SaveConnectionString(cb_server.Text, cb_database.Text, txt_user.TextName, txt_pass.TextName);
            //Program.DangNhap.Close();
            Program.DangNhap = new frmLogin();
            Program.DangNhap.Show();
            this.Close();
        }
    }
}