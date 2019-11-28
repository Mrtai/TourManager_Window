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
    public partial class frmKS : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        KHACH_SAN khach_san = new KHACH_SAN();
        khachSanDAL khachsan = new khachSanDAL();
        public frmKS()
        {
            InitializeComponent();


        }
        public void load()
        {
            var List = khachsan.GetListKS();
            dgv_KS.DataSource = List; 
        }
        private void frmKS_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khach_san.TEN_KHACH_SAN = txtTen.TextName;
            khachsan.AddNewKhachSan(khach_san);
            load();

        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khach_san.TEN_KHACH_SAN = txtTen.TextName;
            khachsan.UpdateKS(khach_san);
            load();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khach_san.TEN_KHACH_SAN = txtTen.TextName;
            khachsan.DeleteKS(khach_san.MA_KHACH_SAN);
            load();
        }
    }
}