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
    public partial class frmDD : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        diaDiemDuLichDAL diadiem = new diaDiemDuLichDAL();
        tinhDAL tinhService = new tinhDAL();
        DIA_DIEM_DU_LICH dia_diem = new DIA_DIEM_DU_LICH();
        public frmDD()
        {
            InitializeComponent();

            

        }
        public void load()
        {
            var listT = tinhService.GetListTinh();
            cb_tinh.DataSource = listT;
            cb_tinh.ValueMember = "MA_TINH";
            cb_tinh.DisplayMember = "TEN_TINH";
            var List = diadiem.GetListDD();
            dgv_DD.DataSource = List;
            
            

        }
        private void frmDD_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtDD.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên địa điểm", "Thông báo");
                txtDD.Focus();
            }
            else
            {
                dia_diem.TEN_DIA_DIEM = txtDD.TextName;
                dia_diem.MA_TINH = Int32.Parse(cb_tinh.SelectedValue.ToString());

                if (diadiem.Add(dia_diem) == 1)
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
                MessageBox.Show("Bạn phải chọn địa điểm !", "Thông báo");
                return;
            }
            if (txtDD.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên địa điểm", "Thông báo");
                txtDD.Focus();
            }
            else
            {
                dia_diem.TEN_DIA_DIEM = txtDD.TextName;
                dia_diem.MA_TINH = Int32.Parse(cb_tinh.SelectedValue.ToString());
                if(diadiem.Update(dia_diem) == 1)
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
            if(txtMa.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn địa điểm", "Thông báo");
            }
            else
            {
                if(diadiem.Delete(Int32.Parse(txtMa.TextName)) == 1)
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
            txtMa.TextName = gridView1.GetRowCellValue(position, "MA_DIA_DIEM").ToString();
            txtDD.TextName = gridView1.GetRowCellValue(position, "TEN_DIA_DIEM").ToString();
            cb_tinh.SelectedValue = Int32.Parse(gridView1.GetRowCellValue(position, "MA_TINH").ToString());
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetTextbox();
        }
        private void resetTextbox()
        {
            txtMa.TextName = "";
            txtDD.TextName = "";
        }
    }
}