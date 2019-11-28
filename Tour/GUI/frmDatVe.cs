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
        tourDatDAL tourdat = new tourDatDAL();
        public frmDatVe()
        {
            InitializeComponent();
        }
        public void load()
        {
            var List = tourdat.GetList();
            dgv_DVe.DataSource = List;
        }
        private void frmDatVe_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tour_dat.DIEM_DON = txtDiemDon.TextName;
            tourdat.Add(tour_dat);
            load();
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tour_dat.DIEM_DON = txtDiemDon.TextName;
            tourdat.Update(tour_dat);
            load();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tour_dat.DIEM_DON = txtDiemDon.TextName;
            tourdat.Delete(tour_dat.MA_TOUR_DAT);
            load();
        }

    
    }
}