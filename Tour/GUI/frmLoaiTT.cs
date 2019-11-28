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
            dgv_LTT.DataSource = List;
        }
        private void frmLoaiTT_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loai_TT.TEN_LOAI_TT = txtTT.TextName;
            loai_TT.CHI_TIET = txtCT.TextName;
            loaitt.Add(loai_TT);
            load();
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loai_TT.TEN_LOAI_TT = txtTT.TextName;
            loai_TT.CHI_TIET = txtCT.TextName;
            loaitt.Update(loai_TT);
            load();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loai_TT.TEN_LOAI_TT = txtTT.TextName;
            loai_TT.CHI_TIET = txtCT.TextName;
            loaitt.Delete(loai_TT.MA_LOAI_TT);
            load();
        }
    }
}