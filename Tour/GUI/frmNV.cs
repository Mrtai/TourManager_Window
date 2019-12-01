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
using DevExpress.XtraGrid.Views.Grid;

namespace GUI
{
    public partial class frmNV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        NhanVienDAL nhanvien = new NhanVienDAL();
        
        public frmNV()
        {
            InitializeComponent();
            
        }
        private void frmNV_Load(object sender, EventArgs e)
        {
            
            load();
        }
        public void load()
        {
            var List = nhanvien.GetList();
            dgv_nv.DataSource = List;
        }
        

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NHAN_VIEN nhan_vien = new NHAN_VIEN();
            nhan_vien.TEN_NV = txtTenNV.TextName;
            nhan_vien.DIA_CHI = txtDiaChi.TextName;
            nhan_vien.EMAIL = txtEmail.TextName;
            nhan_vien.USERNAME = txtUser.TextName;
            byte[] pass = Encoding.ASCII.GetBytes(txtPass.TextName);
            nhan_vien.PASSWORD = pass;
            nhanvien.Add(nhan_vien);
            load();
            ResetText();
        }



        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NHAN_VIEN nhan_vien = new NHAN_VIEN();
            nhan_vien.TEN_NV = txtTenNV.TextName;
            nhan_vien.DIA_CHI = txtDiaChi.TextName;
            nhan_vien.EMAIL = txtEmail.TextName;
            nhan_vien.USERNAME = txtUser.TextName;
            nhanvien.Update(nhan_vien);
            byte[] pass = Encoding.ASCII.GetBytes(txtPass.TextName);
            load();
            ResetText();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtMaNV.TextName == "")
            {
                MessageBox.Show("Bạn hãy chọn nhân viên để xóa !", "Thông báo");
            }
            else
            {
                nhanvien.Delete(Int32.Parse(txtMaNV.TextName));
                load();
            }
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int position = gridView1.FocusedRowHandle;
            try
            {
                txtMaNV.TextName = gridView1.GetRowCellValue(position, "MA_NV").ToString();
                txtTenNV.TextName = gridView1.GetRowCellValue(position, "TEN_NV").ToString();
                txtDiaChi.TextName = gridView1.GetRowCellValue(position, "DIA_CHI").ToString();
                txtEmail.TextName = gridView1.GetRowCellValue(position, "EMAIL").ToString();
                txtUser.TextName = gridView1.GetRowCellValue(position, "USERNAME").ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi load data", "Thông báo");
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetTextbox();
        }
        private void resetTextbox()
        {
            txtMaNV.TextName = "";
            txtTenNV.TextName = "";
            txtDiaChi.TextName = "";
            txtEmail.TextName = "";
            txtUser.TextName = "";
            txtPass.TextName = "";
        }
    }
}