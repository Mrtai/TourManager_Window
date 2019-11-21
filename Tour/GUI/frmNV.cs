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
    public partial class frmNV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        NhanVienDAL nhanvien = new NhanVienDAL();
        public frmNV()
        {
            InitializeComponent();

           
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void frmNV_Load(object sender, EventArgs e)
        {
            var List = nhanvien.GetList();
            dgv_NV.DataSource = List;
        }
    }
}