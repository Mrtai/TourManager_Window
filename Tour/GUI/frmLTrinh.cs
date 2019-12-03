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
    public partial class frmLTrinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        LICH_KHOI_HANH lich_kh = new LICH_KHOI_HANH();
        tourDAL tourService = new tourDAL();
        lichKhoiHanhDAL lichtrinh = new lichKhoiHanhDAL();
        public frmLTrinh()
        {
            InitializeComponent();


        }
        public void load()
        {
            var ListTour = tourService.GetList();
            cb_Tour.DataSource = ListTour;
            cb_Tour.ValueMember = "MA_TOUR";
            cb_Tour.DisplayMember = "TEN_TOUR";
            var List = lichtrinh.GetList();
            gc_Lich.DataSource = List;
        }
        private void frmLTrinh_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên lịch trình", "Thông báo");
                txtTen.Focus();
            }
            else
            {
                lich_kh.TEN_LICH = txtTen.TextName;
                lich_kh.NGAY_KHOI_HANH = dtp.Value;
                lich_kh.MA_TOUR = Int32.Parse(cb_Tour.SelectedValue.ToString());
                if (lichtrinh.Add(lich_kh) == 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    load();
                    resetTextbox();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                }

            }
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMa.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn lịch trình !", "Thông báo");
                return;
            }
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên lịch trình", "Thông báo");
                txtTen.Focus();
            }
            else
            {
                lich_kh.TEN_LICH = txtTen.TextName;
                lich_kh.NGAY_KHOI_HANH = dtp.Value;
                if (lichtrinh.Update(lich_kh) == 1)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    load();
                    resetTextbox();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông báo");
                }
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMa.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn lịch trình !", "Thông báo");
                return;
            }
            else
            {
                if (lichtrinh.Delete(Int32.Parse(txtMa.TextName)) == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    load();
                    resetTextbox();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo");
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int position = gridView1.FocusedRowHandle;
            txtMa.TextName = gridView1.GetRowCellValue(position, "MA_LICH").ToString();     
            cb_Tour.SelectedValue = Int32.Parse(gridView1.GetRowCellValue(position, "MA_TOUR").ToString());
            txtTen.TextName = gridView1.GetRowCellValue(position, "TEN_LICH").ToString();
            bbiAdd.Enabled = false;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetTextbox();
        }
        private void resetTextbox()
        {
            txtMa.TextName = "";
            txtTen.TextName = "";
            bbiAdd.Enabled = true;
        }
    }
}