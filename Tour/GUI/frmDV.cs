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
    public partial class frmDV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        dichvuDAL dichvu = new dichvuDAL();
        public frmDV()
        {
            InitializeComponent();

        }
        public void load()
        {
            var List = dichvu.GetListDV();
            gridControlDV.DataSource = List;
        }
        private void frmDV_Load(object sender, EventArgs e)
        {

            load();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaDV.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn dịch vụ !", "Thông báo");
                return;
            }
            if(dichvu.DeleteDV(Int32.Parse(txtMaDV.TextName)) == 1){
                MessageBox.Show("Xóa thành công", "Thông báo");
                load();
                resetTextbox();
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
            
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DICH_VU dich_vu = new DICH_VU();
            if(txt_TenDV.TextName == "" || txtGia.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập đủ trường !", "Thông báo");
            }
            else
            {
                dich_vu.TEN_DICH_VU = txt_TenDV.TextName;
                dich_vu.GIA = double.Parse(txtGia.TextName);
                if (dichvu.AddNewDichVu(dich_vu) == 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    load();
                    resetTextbox();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                }
            }
            
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DICH_VU dich_vu = new DICH_VU();
            if(txtMaDV.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn dịch vụ !", "Thông báo");
                return;
            }
            if (txt_TenDV.TextName == "" || txtGia.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập đủ trường !", "Thông báo");
            }
            else
            {
                dich_vu.MA_DICH_VU = Int32.Parse(txtMaDV.TextName);
                dich_vu.TEN_DICH_VU = txt_TenDV.TextName;
                dich_vu.GIA = double.Parse(txtGia.TextName);
                if (dichvu.UpdateDV(dich_vu) == 1)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    load();
                    resetTextbox();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông báo");
                }
            }
        }

        private void dgv_dv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int position = dgv_dv.FocusedRowHandle;
            txtMaDV.TextName = dgv_dv.GetRowCellValue(position, "MA_DICH_VU").ToString();
            txt_TenDV.TextName = dgv_dv.GetRowCellValue(position, "TEN_DICH_VU").ToString();
            txtGia.TextName = dgv_dv.GetRowCellValue(position, "GIA").ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetTextbox();
        }

        private void resetTextbox()
        {
            txtMaDV.TextName = "";
            txt_TenDV.TextName = "";
            txtGia.TextName = "";
        }
    }
}