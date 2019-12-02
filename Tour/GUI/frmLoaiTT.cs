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
    public partial class frmLoaiTT : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        LOAI_THANH_TOAN loai_TT = new LOAI_THANH_TOAN();
        loaiThanhToanDAL loaitt = new loaiThanhToanDAL();
        public frmLoaiTT()
        {
            InitializeComponent();


        }
        public void load()
        {
            var List = loaitt.GetList();
            gc_LTT.DataSource = List;
        }
        private void frmLoaiTT_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTT.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên loại thanh toán", "Thông báo");
                txtTT.Focus();
            }
            if (txtCT.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập chi tiết loại thanh toán", "Thông báo");
                txtTT.Focus();
            }
            else
            {
                loai_TT.TEN_LOAI_TT = txtTT.TextName;
                loai_TT.CHI_TIET = txtCT.TextName;

                if (loaitt.Add(loai_TT) == 1)
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
            if (txtMa.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn loại thanh toán !", "Thông báo");
                return;
            }
            if (txtTT.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên loại thanh toán", "Thông báo");
                txtTT.Focus();
            }
            if (txtCT.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập chi tiết loại thanh toán", "Thông báo");
                txtTT.Focus();
            }
            else
            {
                loai_TT.TEN_LOAI_TT = txtTT.TextName;
                loai_TT.CHI_TIET = txtCT.TextName;
                if (loaitt.Update(loai_TT) == 1)
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
            if (txtMa.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn loại thanh toán !", "Thông báo");
                return;
            }
            else
            {
                if (loaitt.Delete(Int32.Parse(txtMa.TextName)) == 1)
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
            txtMa.TextName = "";
            txtTT.TextName = "";
            txtCT.TextName = "";
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int position = gridView1.FocusedRowHandle;
            txtMa.TextName = gridView1.GetRowCellValue(position, "MA_LOAI_TT").ToString();
            txtTT.TextName = gridView1.GetRowCellValue(position, "TEN_LOAI_TT").ToString();
            txtCT.TextName = gridView1.GetRowCellValue(position, "CHI_TIET").ToString();
        }
    }
}