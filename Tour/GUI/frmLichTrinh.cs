using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using DAL.DAL;

namespace GUI
{
    public partial class frmLichTrinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private lichKhoiHanhDAL lichKhoiHanhService = new lichKhoiHanhDAL();
        public frmLichTrinh()
        {
            InitializeComponent();
        }
        public void loadImage()
        {
            
        }

        private void frmLichTrinh_Load(object sender, EventArgs e)
        {
            var listLT = lichKhoiHanhService.GetList();

        }
    }
        
}
