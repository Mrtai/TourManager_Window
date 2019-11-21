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
        loaiTourDAL loaitour = new loaiTourDAL();
        public frmLoaiTour()
        {
            InitializeComponent();


        }

        private void frmLoaiTour_Load(object sender, EventArgs e)
        {
            var List = loaitour.GetList();
            dgv_LTour.DataSource = List;
        }
    }
}