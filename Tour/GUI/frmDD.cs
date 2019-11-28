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
    public partial class frmDD : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        diaDiemDuLichDAL diadiem = new diaDiemDuLichDAL();
        DIA_DIEM_DU_LICH dia_diem = new DIA_DIEM_DU_LICH();
        public frmDD()
        {
            InitializeComponent();


        }
        public void load()
        {
            var List = diadiem.GetListDD();
            dgv_DD.DataSource = List;
        }
        private void frmDD_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dia_diem.TEN_DIA_DIEM = txtDD.TextName;
            diadiem.Add(dia_diem);
            load();
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dia_diem.TEN_DIA_DIEM = txtDD.TextName;
            diadiem.Update(dia_diem);
            load();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dia_diem.TEN_DIA_DIEM = txtDD.TextName;
            diadiem.Delete(dia_diem.MA_DIA_DIEM);
            load();
        }

    }
}