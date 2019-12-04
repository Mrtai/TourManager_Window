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
using DAL_TOUR;

namespace GUI
{
    public partial class FrmThemNVNhom : DevExpress.XtraEditors.XtraForm
    {
        nhomDAL nhomDAL = new nhomDAL();
        nhanVienNhomDAL nhanVienNhom = new nhanVienNhomDAL();
        NhanVienDAL nhanvienservice = new NhanVienDAL();

        public FrmThemNVNhom()
        {
            InitializeComponent();
        }

        private void cb_nhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listnvn = nhanVienNhom.GetDVByMaNhom(Int32.Parse(cb_nhom.SelectedValue.ToString()));
            gc_nhomnv.DataSource = listnvn;
        }
        private void Loaddata()
        {
            var listNhom = nhomDAL.GetList();
            cb_nhom.ValueMember = "MA_NHOM";
            cb_nhom.DisplayMember = "TEN_NHOM";
            cb_nhom.DataSource = listNhom;
            var listnvn = nhanVienNhom.GetList();
            gc_nhomnv.DataSource = listnvn;
            var listnv = nhanvienservice.GetList();
            gc_nv.DataSource = listnv;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int tnDN =Int32.Parse(gc_nv.CurrentRow.Cells[0].Value.ToString());
            int maNhom = Int32.Parse(cb_nhom.SelectedValue.ToString());

            NHAN_VIEN_NHOM nvn = new NHAN_VIEN_NHOM();
            nvn.MA_NHOM = maNhom;
            nvn.MA_NV = tnDN;
            if (nhanVienNhom.Add(nvn) == 1)
            {
                MessageBox.Show("Thành công");
                Loaddata();
                
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
       
           
        }
    }
}