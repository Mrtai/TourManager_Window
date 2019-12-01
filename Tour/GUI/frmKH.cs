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
            gc_kh.DataSource = List;
        }


        private void frmKH_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo");
                txtTen.Focus();
            }
            else
            {
                khach_hang.TEN = txtTen.TextName;
                khach_hang.DIEN_THOAI = txtSDT.TextName;
                khach_hang.DIA_CHI = txtDC.TextName;
                khach_hang.EMAIL = txtEmail.TextName;
                khach_hang.NGAY_SINH = dtp_NgayS.Value;
                if (khachhang.Add(khach_hang) == 1)
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
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int position = gridView1.FocusedRowHandle;
            txtMaKH.TextName = gridView1.GetRowCellValue(position, "MA_KHACH_HANG").ToString();
            txtTen.TextName = gridView1.GetRowCellValue(position, "TEN").ToString();
            txtSDT.TextName = gridView1.GetRowCellValue(position, "DIEN_THOAI").ToString();
            txtDC.TextName = gridView1.GetRowCellValue(position, "DIA_CHI").ToString();
            txtEmail.TextName = gridView1.GetRowCellValue(position, "EMAIL").ToString();
        }
        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKH.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn khách hàng !", "Thông báo");
                return;
            }
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo");
                txtTen.Focus();
            }
            if (txtSDT.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo");
                txtSDT.Focus();
            }
            if (txtDC.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo");
                txtDC.Focus();
            }
            if (txtEmail.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo");
                txtEmail.Focus();
            }
            else
            {
                khach_hang.TEN = txtTen.TextName;
                khach_hang.DIEN_THOAI = txtSDT.TextName;
                khach_hang.DIA_CHI = txtDC.TextName;
                khach_hang.EMAIL = txtEmail.TextName;
                if (khachhang.Update(khach_hang) == 1)
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

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKH.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn khách hàng !", "Thông báo");
                return;
            }
            else
            {
                if (khachhang.Delete(Int32.Parse(txtMaKH.TextName)) == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    load();
                    resetTextbox();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo");
                }

            }
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetTextbox();
        }
        private void resetTextbox()
        {
            txtMaKH.TextName = "";
            txtTen.TextName = "";
            txtSDT.TextName = "";
            txtDC.TextName = "";
            txtEmail.TextName = "";
        }
    }
}