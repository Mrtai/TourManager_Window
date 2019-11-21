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
        public frmCTTour()
        {
            InitializeComponent();


        }

        private void frmCTTour_Load(object sender, EventArgs e)
        {
            var List = chuongtrinhtour.GetList();
            dgv_CTT.DataSource = List;
        }
    }
}