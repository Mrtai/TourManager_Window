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
    public partial class frmKS : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        KHACH_SAN khach_san = new KHACH_SAN();
        khachSanDAL khachsan = new khachSanDAL();
        tinhDAL tinhService = new tinhDAL();
        public frmKS()
        {
            InitializeComponent();
        }
        public void load()
        {
            var listT = tinhService.GetListTinh();
            cb_tinh.DataSource = listT;
            cb_tinh.ValueMember = "MA_TINH";
            cb_tinh.DisplayMember = "TEN_TINH";

            var List = khachsan.GetListKS();

            gridControlKS.DataSource = List; 
        }
        private void frmKS_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập đủ trường!", "Thông báo");
            }
            else
            {
                khach_san.TEN_KHACH_SAN = txtTen.TextName;
                khach_san.MA_TINH =Int32.Parse(cb_tinh.SelectedValue.ToString());
                if(khachsan.AddNewKhachSan(khach_san) == 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    load();
                    resetText();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                }
            }
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtMa.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn khách sạn !", "Thông báo");
                return;
            }
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập đủ trường!", "Thông báo");
            }
            else
            {
                KHACH_SAN ks = new KHACH_SAN();
                ks.MA_KHACH_SAN = Int32.Parse(txtMa.TextName);
                ks.TEN_KHACH_SAN = txtTen.TextName;
                ks.MA_TINH = Int32.Parse(cb_tinh.SelectedValue.ToString());
                if (khachsan.UpdateKS(ks) == 1)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    load();
                    resetText();
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
                MessageBox.Show("Bạn phải chọn khách sạn !", "Thông báo");
                return;
            }
            if (khachsan.DeleteKS(Int32.Parse(txtMa.TextName)) == 1)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                load();
                resetText();
            }
            load();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetText();
        }
        private void resetText()
        {
            txtMa.TextName = "";
            txtTen.TextName = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int position = gridView1.FocusedRowHandle;
            txtMa.TextName = gridView1.GetRowCellValue(position, "MA_KHACH_SAN").ToString();
            txtTen.TextName = gridView1.GetRowCellValue(position, "TEN_KHACH_SAN").ToString();
            //int id = Int32.Parse(gridView1.GetRowCellValue(position, "MA_TINH").ToString());
            cb_tinh.SelectedValue = Int32.Parse(gridView1.GetRowCellValue(position, "MA_TINH").ToString());
        }
    }
}