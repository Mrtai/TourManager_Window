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
    public partial class frmLoaiTour : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        LOAI_TOUR loai_tour = new LOAI_TOUR();
        loaiTourDAL loaitour = new loaiTourDAL();
        public frmLoaiTour()
        {
            InitializeComponent();


        }
        public void load()
        {
            var List = loaitour.GetList();
            gridControlLoai.DataSource = List;
        }
        private void frmLoaiTour_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên loại tuor", "Thông báo");
                txtTen.Focus();
            }
            else
            {
                loai_tour.TEN_LOAI = txtTen.TextName;

                if (loaitour.Add(loai_tour) == 1)
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
                MessageBox.Show("Bạn phải chọn loại tuor !", "Thông báo");
                return;
            }
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên loại tuor", "Thông báo");
                txtTen.Focus();
            }

            else
            {
                loai_tour.TEN_LOAI = txtTen.TextName;
                if (loaitour.Update(loai_tour) == 1)
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
                MessageBox.Show("Bạn phải chọn loại tuor !", "Thông báo");
                return;
            }
            else
            {
                if (loaitour.Delete(Int32.Parse(txtMa.TextName)) == 1)
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
            txtTen.TextName = "";
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int position = gridView1.FocusedRowHandle;
            txtMa.TextName = gridView1.GetRowCellValue(position, "MA_LOAI").ToString();
            txtTen.TextName = gridView1.GetRowCellValue(position, "TEN_LOAI").ToString();

        }
    }
}