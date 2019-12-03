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
using GUI.Report;

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
            list = tourService.GetDVByFilterNgay(frm, to);
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
            list = tourService.GetDVByFilterNgay(month, year);
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

        private void btn_bc_Click(object sender, EventArgs e)
        {
            ExcelExport excel = new ExcelExport();
            List<Ve> listVe = new List<Ve>();
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                Ve v = new Ve();
                v.STT = i;
                v.KHACH_HANG = gridView1.GetRowCellValue(i, "KHACH_HANG.TEN").ToString();
                v.LICH = gridView1.GetRowCellValue(i, "LICH_KHOI_HANH.TEN_LICH").ToString();
                if(gridView1.GetRowCellValue(i, "LOAI_THANH_TOAN.TEN_LOAI_TT")!=null)
                    v.LOAI_TT = gridView1.GetRowCellValue(i, "LOAI_THANH_TOAN.TEN_LOAI_TT").ToString();
                v.NGAY_DAT = gridView1.GetRowCellValue(i, "NGAY_DAT").ToString();
                v.TONG_TIEN = double.Parse(gridView1.GetRowCellValue(i, "TONG_TIEN").ToString());
                v.DIEM_DON = gridView1.GetRowCellValue(i, "DIEM_DON").ToString();
                listVe.Add(v);
            }
            if (listVe.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất");
                return;
            }
            string path = string.Empty;

            excel.ExportExcelVe(listVe, ref path, false);    
            // Confirm for open file was exported
            if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                MessageBox.Show("Khổng thể xuất file!","Thông báo");
            }
        }
    }
}
