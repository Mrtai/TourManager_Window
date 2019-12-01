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
    public partial class frmDatVe : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        TOUR_DAT tour_dat = new TOUR_DAT();
        khachHangDAL KHService = new khachHangDAL();
        NhanVienDAL NVService = new NhanVienDAL();
        lichKhoiHanhDAL lichService = new lichKhoiHanhDAL();
        tourDatDAL tourdat = new tourDatDAL();
        public frmDatVe()
        {
            InitializeComponent();
        }
        public void load()
        {
            var Listlich = lichService.GetList();
            cb_LT.DataSource = Listlich;
            cb_LT.ValueMember = "MA_LICH";
            cb_LT.DisplayMember = "TEN_LICH";
            var Listnv = NVService.GetList();
            cb_NV.DataSource = Listnv;
            cb_NV.ValueMember = "MA_NV";
            cb_NV.DisplayMember = "TEN_NV";
            var Listkh = KHService.GetList();
            cb_KH.DataSource = Listkh;
            cb_KH.ValueMember = "MA_KHACH_HANG";
            cb_KH.DisplayMember = "TEN_KHACH_HANG";
            var List = tourdat.GetList();
            gc_DVe.DataSource = List;
        }
        private void frmDatVe_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtDiemDon.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên điểm đón", "Thông báo");
                txtDiemDon.Focus();
            }
            else
            {
                tour_dat.DIEM_DON = txtDiemDon.TextName;
                tour_dat.NGAY_DAT = dtp_Ngay.Value;
                tour_dat.MA_LICH = Int32.Parse(cb_LT.SelectedValue.ToString());
                tour_dat.MA_NV = Int32.Parse(cb_NV.SelectedValue.ToString());
                tour_dat.MA_KHACH_HANG = Int32.Parse(cb_KH.SelectedValue.ToString());
                if (tourdat.Add(tour_dat) == 1)
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
            txtMaTourDat.TextName = gridView1.GetRowCellValue(position, "MA_TOUR_DAT").ToString();
            cb_KH.SelectedValue = Int32.Parse(gridView1.GetRowCellValue(position, "MA_KHACH_HANG").ToString());
            cb_LT.SelectedValue = Int32.Parse(gridView1.GetRowCellValue(position, "MA_LICH").ToString());
            cb_NV.SelectedValue = Int32.Parse(gridView1.GetRowCellValue(position, "MA_NV").ToString());
            txtDiemDon.TextName = gridView1.GetRowCellValue(position, "DIEM_DON").ToString();

        }
        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaTourDat.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn vé !", "Thông báo");
                return;
            }
            if (txtDiemDon.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập chi tiết điểm đón", "Thông báo");
                txtDiemDon.Focus();
            }
            else
            {
                tour_dat.DIEM_DON = txtDiemDon.TextName;
                tour_dat.NGAY_DAT = dtp_Ngay.Value;
                tour_dat.MA_KHACH_HANG = Int32.Parse(cb_KH.SelectedValue.ToString());
                tour_dat.MA_LICH = Int32.Parse(cb_LT.SelectedValue.ToString());
                tour_dat.MA_NV = Int32.Parse(cb_NV.SelectedValue.ToString());
                if (tourdat.Update(tour_dat) == 1)
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
            if (txtMaTourDat.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn vé !", "Thông báo");
                return;
            }
            else
            {
                if (tourdat.Delete(Int32.Parse(txtMaTourDat.TextName)) == 1)
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
            txtMaTourDat.TextName = "";
            txtDiemDon.TextName = "";

        }
    }
}