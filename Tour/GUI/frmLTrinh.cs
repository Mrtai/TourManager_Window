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
    public partial class frmLTrinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        LICH_KHOI_HANH lich_kh = new LICH_KHOI_HANH();
        lichKhoiHanhDAL lichtrinh = new lichKhoiHanhDAL();
        public frmLTrinh()
        {
            InitializeComponent();


        }
        public void load()
        {
            var List = lichtrinh.GetList();
            dgv_LTrinh.DataSource = List;
        }
        private void frmLTrinh_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lich_kh.TEN_LICH = txtTen.TextName;
            lichtrinh.Add(lich_kh);
            load();
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lich_kh.TEN_LICH = txtTen.TextName;
            lichtrinh.Update(lich_kh);
            load();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lich_kh.TEN_LICH = txtTen.TextName;
            lichtrinh.Delete(lich_kh.MA_LICH);
            load();
        }
    }
}