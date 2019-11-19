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
using DAL_TOUR;

namespace GUI
{
    public partial class frmLichTrinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        dichvuDAL nhanVienService = new dichvuDAL();
        public frmLichTrinh()
        {
            InitializeComponent();
        }
        public void loadImage()
        {
            
        }

        private void frmLichTrinh_Load(object sender, EventArgs e)
        {
            var list = nhanVienService.GetListDV();
            dataGridView1.DataSource = list;
        }

        private void userControl11_DatButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("dat", "thông báo");
        }

        private void userControl11_DetailButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Detail", "thông báo");
        }
    }
        
}
