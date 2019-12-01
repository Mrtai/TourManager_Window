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
    public partial class frmTour : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        TOUR tour = new TOUR();
        loaiTourDAL ltourService = new loaiTourDAL();
        tourDAL tourdal = new tourDAL();
        public frmTour()
        {
            InitializeComponent();


        }
        public void load()
        {
            var Listlt = ltourService.GetList();
            cb_loait.DataSource = Listlt;
            cb_loait.ValueMember = "MA_LOAI";
            cb_loait.DisplayMember = "TEN_LOAI";
            var List = tourdal.GetList();
            gc_tour.DataSource = List;
        }
        private void frmTour_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên tour", "Thông báo");
                txtTen.Focus();
            }
            else
            {
                tour.TEN_TOUR = txtTen.TextName;
                tour.GIA = double.Parse(txtGia.TextName);
                tour.MA_LOAI = Int32.Parse(cb_loait.SelectedValue.ToString());
                tour.SO_NGAY = Int32.Parse(txtSoNgay.TextName);
                tour.SO_CHO = Int32.Parse(txtSoCho.TextName);
                tour.DISCOUNT = double.Parse(txtGiamGia.TextName);
                if (tourdal.Add(tour) == 1)
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
            if (txtMaTour.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn tour !", "Thông báo");
                return;
            }
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên tour", "Thông báo");
                txtTen.Focus();
            }
            if (txtSoNgay.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập số ngày", "Thông báo");
                txtSoNgay.Focus();
            }
            if (txtSoNgay.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập số ngày", "Thông báo");
                txtSoNgay.Focus();
            }
            if (txtSoCho.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập số chỗ", "Thông báo");
                txtSoCho.Focus();
            }
            if (txtGia.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập giá", "Thông báo");
                txtGia.Focus();
            }
            else
            {
                tour.TEN_TOUR = txtTen.TextName;
                tour.GIA = double.Parse(txtGia.TextName);
                tour.MA_LOAI = Int32.Parse(cb_loait.SelectedValue.ToString());
                tour.SO_NGAY = Int32.Parse(txtSoNgay.TextName);
                tour.SO_CHO = Int32.Parse(txtSoCho.TextName);
                tour.DISCOUNT = double.Parse(txtGiamGia.TextName);
                if (tourdal.Update(tour) == 1)
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

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaTour.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn chương trình", "Thông báo");
            }
            else
            {
                if (tourdal.Delete(Int32.Parse(txtMaTour.TextName)) == 1)
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
            txtMaTour.TextName = "";
            txtTen.TextName = "";
            txtGiamGia.TextName = "";
            txtSoNgay.TextName = "";
            txtSoCho.TextName = "";
            txtGia.TextName = "";
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int position = gridView1.FocusedRowHandle;
            txtMaTour.TextName = gridView1.GetRowCellValue(position, "MA_TOUR").ToString();
            cb_loait.SelectedValue = Int32.Parse(gridView1.GetRowCellValue(position, "MA_LOAI").ToString());
            txtTen.TextName = gridView1.GetRowCellValue(position, "TEN_TOUR").ToString();
            txtSoNgay.TextName = gridView1.GetRowCellValue(position, "SO_NGAY").ToString();
            txtSoCho.TextName = gridView1.GetRowCellValue(position, "SO_CHO").ToString();
            txtGia.TextName = gridView1.GetRowCellValue(position, "GIA").ToString();
            txtGiamGia.TextName = gridView1.GetRowCellValue(position, "DISCOUNT").ToString();
        }
    }
}