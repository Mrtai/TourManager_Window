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
    public partial class frmCTTour : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        chuongTrinhTourDAL chuongtrinhtour = new chuongTrinhTourDAL();
        tourDAL tourService = new tourDAL();
        khachSanDAL khachSanService = new khachSanDAL();
        diaDiemDuLichDAL diaDiemService = new diaDiemDuLichDAL();
        CHUONG_TRINH_TOUR chuong_trinh_tour = new CHUONG_TRINH_TOUR();
        public frmCTTour()
        {
            InitializeComponent();


        }
        public void load()
        {
            var ListTour = tourService.GetList();
            cb_tour.DataSource = ListTour;
            cb_tour.ValueMember = "MA_TOUR";
            cb_tour.DisplayMember = "TEN_TOUR";
            var Listks = khachSanService.GetListKS();
            cb_ks.DataSource = Listks;
            cb_ks.ValueMember = "MA_KHACH_SAN";
            cb_ks.DisplayMember = "TEN_KHACH_SAN";
            var listdd = diaDiemService.GetListDD();
            cb_diadiem.DataSource = listdd;
            cb_diadiem.ValueMember = "MA_DIA_DIEM";
            cb_diadiem.DisplayMember = "TEN_DIA_DIEM";
            var List = chuongtrinhtour.GetList();
            gc_CCT.DataSource = List; 
        }
        private void frmCTTour_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên chương trình tour", "Thông báo");
                txtTen.Focus();
            }
            else
            {
                chuong_trinh_tour.MA_DIA_DIEM = Int32.Parse(cb_diadiem.SelectedValue.ToString());
                chuong_trinh_tour.TEN_CHUONG_TRINH = txtTen.TextName;
                chuong_trinh_tour.CHI_TIET = txtchitiet.Text;
                chuong_trinh_tour.NGAY = dtpNgay.Value;
                chuong_trinh_tour.MA_TOUR = Int32.Parse(cb_tour.SelectedValue.ToString());
                chuong_trinh_tour.MA_KHACH_SAN = Int32.Parse(cb_ks.SelectedValue.ToString());
                if (chuongtrinhtour.Add(chuong_trinh_tour) == 1)
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
            txtMaCT.TextName = gridView1.GetRowCellValue(position, "MA_CHUONG_TRINH").ToString();
            cb_ks.SelectedValue = Int32.Parse(gridView1.GetRowCellValue(position, "MA_KHACH_SAN").ToString());
            cb_tour.SelectedValue = Int32.Parse(gridView1.GetRowCellValue(position, "MA_TOUR").ToString());
            cb_diadiem.SelectedValue = Int32.Parse(gridView1.GetRowCellValue(position, "MA_DIA_DIEM").ToString());
            txtTen.TextName = gridView1.GetRowCellValue(position, "TEN_CHUONG_TRINH").ToString();
            txtchitiet.Text = gridView1.GetRowCellValue(position, "CHI_TIET").ToString();
            bbiAdd.Enabled = false;
        }
        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaCT.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn chương trình !", "Thông báo");
                return;
            }
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên chương trình", "Thông báo");
                txtTen.Focus();
            }
            if (txtchitiet.Text== "")
            {
                MessageBox.Show("Bạn phải nhập chi tiết chương trình", "Thông báo");
                txtchitiet.Focus();
            }
            else
            {
                chuong_trinh_tour.TEN_CHUONG_TRINH = txtTen.TextName;
                chuong_trinh_tour.CHI_TIET = txtchitiet.Text;
                chuong_trinh_tour.NGAY = dtpNgay.Value;
                chuong_trinh_tour.MA_TOUR = Int32.Parse(cb_tour.SelectedValue.ToString());
                chuong_trinh_tour.MA_KHACH_SAN = Int32.Parse(cb_ks.SelectedValue.ToString());
                if (chuongtrinhtour.Update(chuong_trinh_tour) == 1)
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
            if (txtMaCT.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn chương trình", "Thông báo");
            }
            else
            {
                if (chuongtrinhtour.Delete(Int32.Parse(txtMaCT.TextName)) == 1)
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
            txtMaCT.TextName = "";
            txtTen.TextName = "";
            txtchitiet.Text = "";
            bbiAdd.Enabled = true;
        
        }

        private void gc_CCT_Click(object sender, EventArgs e)
        {

        }
    }
}