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
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmNV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        NHAN_VIEN nhan_vien = new NHAN_VIEN();
        NhanVienDAL nhanvien = new NhanVienDAL();
        public frmNV()
        {
            InitializeComponent();

           
        }
        public void load()
        {
            var List = nhanvien.GetList();
            dgv_NV.DataSource = List;
        }
        private void frmNV_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nhan_vien.TEN_NV = txtTenNV.TextName;
            nhan_vien.DIA_CHI = txtDiaChi.TextName;
            nhan_vien.EMAIL = txtEmail.TextName;
            nhan_vien.USERNAME = txtUser.TextName;
            nhanvien.Add(nhan_vien);
            load();
        }



        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nhan_vien.TEN_NV = txtTenNV.TextName;
            nhan_vien.DIA_CHI = txtDiaChi.TextName;
            nhan_vien.EMAIL = txtEmail.TextName;
            nhan_vien.USERNAME = txtUser.TextName;
            nhanvien.Update(nhan_vien);
            load();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nhan_vien.TEN_NV = txtTenNV.TextName;
            nhan_vien.DIA_CHI = txtDiaChi.TextName;
            nhan_vien.EMAIL = txtEmail.TextName;
            nhan_vien.USERNAME = txtUser.TextName;
            nhanvien.Delete(nhan_vien.MA_NV);
            load();
        }
    }
}