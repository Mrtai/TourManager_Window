using DAL_TOUR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmNhom : Form
    {
        nhomDAL nhomService = new nhomDAL();
        public FrmNhom()
        {
            InitializeComponent();
        }

        private void FrmNhom_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên địa điểm", "Thông báo");
                txtTen.Focus();
            }
            else
            {
                NHOM nhom = new NHOM();
                nhom.TEN_NHOM = txtTen.TextName;
                if (nhomService.Add(nhom) == 1)
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

        private void resetTextbox()
        {
            txtTen.TextName = "";
            bbiAdd.Enabled = true;
        }

        private void load()
        {
            var list = nhomService.GetList();
            gc_DD.DataSource = list;
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMa.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn nhóm !", "Thông báo");
                return;
            }
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhóm", "Thông báo");
                txtTen.Focus();
            }
            else
            {
                NHOM nhom = nhomService.GetDVByMa(Int32.Parse(txtMa.TextName));
                nhom.TEN_NHOM = txtTen.TextName;
                
                if (nhomService.Update(nhom) == 1)
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
                MessageBox.Show("Bạn phải chọn nhóm !", "Thông báo");
                return;
            }
            else
            {
               
                if (nhomService.Delete(Int32.Parse(txtMa.TextName)) == 1)
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetTextbox();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int position = gridView1.FocusedRowHandle;
            txtMa.TextName = gridView1.GetRowCellValue(position, "MA_NHOM").ToString();
            txtTen.TextName = gridView1.GetRowCellValue(position, "TEN_NHOM").ToString();
            bbiAdd.Enabled = false;
        }
    }
}
