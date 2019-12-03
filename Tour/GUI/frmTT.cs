using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_TOUR;

namespace GUI
{
    public partial class frmTT : Form
    {
        tourDatDAL tourDatService = new tourDatDAL();
        DanhSachDichVuDAL DanhSachDichVuService = new DanhSachDichVuDAL();
        public frmTT()
        {
            InitializeComponent();
        }

        private void frmTT_Load(object sender, EventArgs e)
        {
            var list = tourDatService.GetList();
            gc_DVe.DataSource = list;


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int position = gridView1.FocusedRowHandle;
            int mave = Int32.Parse(gridView1.GetRowCellValue(position, "MA_TOUR_DAT").ToString());
            var listdv = DanhSachDichVuService.GetList(mave);
            grid_dv.DataSource = listdv;
        }
    }
}
