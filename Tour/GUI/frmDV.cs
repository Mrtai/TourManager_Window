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
    public partial class frmDV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DICH_VU dich_vu = new DICH_VU();
        dichvuDAL dichvu = new dichvuDAL();
        public frmDV()
        {
            InitializeComponent();

        }
        public void load()
        {
            var List = dichvu.GetListDV();
            dgv_DV.DataSource = List;
        }
        private void frmDV_Load(object sender, EventArgs e)
        {

            load();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dich_vu.TEN_DICH_VU = txt_TenDV.TextName;
            dich_vu.GIA = double.Parse(txtGia.TextName);
            dichvu.DeleteDV(dich_vu.MA_DICH_VU);
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            dich_vu.TEN_DICH_VU = txt_TenDV.TextName;
            dich_vu.GIA = double.Parse(txtGia.TextName);
            dichvu.AddNewDichVu(dich_vu);
            load();
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dich_vu.TEN_DICH_VU = txt_TenDV.TextName;
            dich_vu.GIA = double.Parse(txtGia.TextName);
            dichvu.UpdateDV(dich_vu);
            load();
        }


    }
}