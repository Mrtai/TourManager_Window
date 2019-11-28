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
        tourDAL tourdal = new tourDAL();
        public frmTour()
        {
            InitializeComponent();


        }
        public void load()
        {
            var List = tourdal.GetList();
            dgv_Tour.DataSource = List;
        }
        private void frmTour_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tour.TEN_TOUR = txtTen.TextName;
            tour.GIA = double.Parse(txtGia.TextName);
            tour.SO_NGAY = Int32.Parse(txtSoNgay.TextName);
            tour.SO_CHO = Int32.Parse(txtSoCho.TextName);
            tour.DISCOUNT = double.Parse(txtGiamGia.TextName);
            tourdal.Add(tour);
            load();
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tour.TEN_TOUR = txtTen.TextName;
            tour.GIA = double.Parse(txtGia.TextName);
            tour.SO_NGAY = Int32.Parse(txtSoNgay.TextName);
            tour.SO_CHO = Int32.Parse(txtSoCho.TextName);
            tour.DISCOUNT = double.Parse(txtGiamGia.TextName);
            tourdal.Update(tour);
            load();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tour.TEN_TOUR = txtTen.TextName;
            tour.GIA = double.Parse(txtGia.TextName);
            tour.SO_NGAY = Int32.Parse(txtSoNgay.TextName);
            tour.SO_CHO = Int32.Parse(txtSoCho.TextName);
            tour.DISCOUNT = double.Parse(txtGiamGia.TextName);
            tourdal.Delete(tour.MA_TOUR);
            load();
        }
    }
}