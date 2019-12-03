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
    public partial class frmBaoCaoVe : Form
    {
       
        tourDatDAL tourService = new tourDatDAL();
        List<TOUR_DAT> list = null;
        public frmBaoCaoVe()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            DateTime frm = txt_from.Value;
            DateTime to = txt_to.Value;
            //list = tourService.GetDVByFilterNgay(frm, to);
            gc_DVe.DataSource = list;
        }

        private void frmBaoCaoVe_Load(object sender, EventArgs e)
        {
            list = tourService.GetList();
            gc_DVe.DataSource = list;
        }

        private void jThinButton1_Click_1(object sender, EventArgs e)
        {
            int month = dpMonth.Value.Month;
            int year = dpYear.Value.Year;
            //list = tourService.GetDVByFilterNgay(month, year);
            gc_DVe.DataSource = list;
        }

        private void txt_nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
