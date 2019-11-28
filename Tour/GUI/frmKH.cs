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
        KHACH_HANG khach_hang = new KHACH_HANG();
        khachHangDAL khachhang = new khachHangDAL();
        public frmKH()
        {
            InitializeComponent();


        }
        public void load()
        {
            var List = khachhang.GetList();
            dgv_KH.DataSource = List;
        }


        private void frmKH_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khach_hang.TEN = txtTen.TextName;
            khach_hang.DIEN_THOAI = txtSDT.TextName;
            khach_hang.DIA_CHI = txtDC.TextName;
            khach_hang.EMAIL = txtEmail.TextName;
            khachhang.Add(khach_hang);
            load();
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khach_hang.TEN = txtTen.TextName;
            khach_hang.DIEN_THOAI = txtSDT.TextName;
            khach_hang.DIA_CHI = txtDC.TextName;
            khach_hang.EMAIL = txtEmail.TextName;
            khachhang.Update(khach_hang);
            load();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khach_hang.TEN = txtTen.TextName;
            khach_hang.DIEN_THOAI = txtSDT.TextName;
            khach_hang.DIA_CHI = txtDC.TextName;
            khach_hang.EMAIL = txtEmail.TextName;
            khachhang.Delete(khach_hang.MA_KHACH_HANG);
            load();
        }
    }
}