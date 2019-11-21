using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using DAL_TOUR;
namespace GUI
{
    public partial class frmKH : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        khachHangDAL khachhang = new khachHangDAL();
        public frmKH()
        {
            InitializeComponent();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmKH_Load(object sender, EventArgs e)
        {
            var List = khachhang.GetList();
            dgv_KH.DataSource = List;
        }
    }
}