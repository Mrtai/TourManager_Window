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
        loaiThanhToanDAL loaitt = new loaiThanhToanDAL();
        public frmLoaiTT()
        {
            InitializeComponent();


        }

        private void frmLoaiTT_Load(object sender, EventArgs e)
        {
            var List = loaitt.GetList();
            dgv_LTT.DataSource = List;
        }
    }
}