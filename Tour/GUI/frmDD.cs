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
        public frmDD()
        {
            InitializeComponent();


        }

        private void frmDD_Load(object sender, EventArgs e)
        {
            var List = diadiem.GetListDD();
            dgv_DD.DataSource = List;
        }

    }
}