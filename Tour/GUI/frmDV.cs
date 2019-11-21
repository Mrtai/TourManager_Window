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
        dichvuDAL dichvu = new dichvuDAL();
        public frmDV()
        {
            InitializeComponent();

        }

        private void frmDV_Load(object sender, EventArgs e)
        {
            var List = dichvu.GetListDV();
            dgv_DV.DataSource = List;
        }
    }
}