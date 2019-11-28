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
            loai_tour.TEN_LOAI = txtTen.TextName;
            loaitour.Add(loai_tour);
            load();
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loai_tour.TEN_LOAI = txtTen.TextName;
            loaitour.Update(loai_tour);
            load();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loai_tour.TEN_LOAI = txtTen.TextName;
            loaitour.Delete(loai_tour.MA_LOAI);
            load();
        }

    }
}