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
        CHUONG_TRINH_TOUR chuong_trinh_tour = new CHUONG_TRINH_TOUR();
        public frmCTTour()
        {
            InitializeComponent();


        }
        public void load()
        {
            var List = chuongtrinhtour.GetList();
            dgv_CTT.DataSource = List; 
        }
        private void frmCTTour_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chuong_trinh_tour.TEN_CHUONG_TRINH = txtTen.TextName;
            chuong_trinh_tour.CHI_TIET = txtChiTiet.TextName;
            chuongtrinhtour.Add(chuong_trinh_tour);
            load();
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chuong_trinh_tour.TEN_CHUONG_TRINH = txtTen.TextName;
            chuong_trinh_tour.CHI_TIET = txtChiTiet.TextName;
            chuongtrinhtour.Update(chuong_trinh_tour);
            load();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chuong_trinh_tour.TEN_CHUONG_TRINH = txtTen.TextName;
            chuong_trinh_tour.CHI_TIET = txtChiTiet.TextName;
            chuongtrinhtour.Delete(chuong_trinh_tour.MA_CHUONG_TRINH);
            load();
        }
    }
}