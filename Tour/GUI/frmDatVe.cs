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
using DevExpress.XtraEditors.Controls;

namespace GUI
{
    public partial class frmDatVe : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        TOUR_DAT tour_dat = new TOUR_DAT();
        khachHangDAL KHService = new khachHangDAL();
        NhanVienDAL NVService = new NhanVienDAL();
        lichKhoiHanhDAL lichService = new lichKhoiHanhDAL();
        tourDatDAL tourdat = new tourDatDAL();
        loaiThanhToanDAL loaiThanhToanService = new loaiThanhToanDAL();
        dichvuDAL dvService = new dichvuDAL();
        public frmDatVe()
        {
            InitializeComponent();
        }
        public void load()
        {
            var Listlich = lichService.GetList();
            cb_LT.ValueMember = "MA_LICH";
            cb_LT.DisplayMember = "TEN_LICH";
            cb_LT.DataSource = Listlich;
            var Listnv = NVService.GetList();
            cb_NV.DataSource = Listnv;
            cb_NV.ValueMember = "MA_NV";
            cb_NV.DisplayMember = "TEN_NV";
            var Listkh = KHService.GetList();
            cb_KH.DataSource = Listkh;
            cb_KH.ValueMember = "MA_KHACH_HANG";
            cb_KH.DisplayMember = "TEN";
            var listTT = loaiThanhToanService.GetList();
            cb_tt.DataSource = listTT;
            cb_tt.ValueMember = "MA_LOAI_TT";
            cb_tt.DisplayMember = "TEN_LOAI_TT";
            var List = dvService.GetListDV();
            listDV.DataSource = List;
            listDV.ValueMember = "MA_DICH_VU";
            listDV.DisplayMember = "TEN_DICH_VU";
        }
        private void frmDatVe_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtDiemDon.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên điểm đón", "Thông báo");
                txtDiemDon.Focus();
            }
            else
            {
                tour_dat.MA_LOAI_TT = Int32.Parse(cb_tt.SelectedValue.ToString());
                tour_dat.DIEM_DON = txtDiemDon.TextName;
                tour_dat.NGAY_DAT = dtp_Ngay.Value;
                tour_dat.MA_LICH = Int32.Parse(cb_LT.SelectedValue.ToString());
                tour_dat.MA_NV = Int32.Parse(cb_NV.SelectedValue.ToString());
                tour_dat.MA_KHACH_HANG = Int32.Parse(cb_KH.SelectedValue.ToString());
                tour_dat.TRANG_THAI = cb_trangthai.SelectedItem.ToString();
                int idlt = Int32.Parse(cb_LT.SelectedValue.ToString());
                LICH_KHOI_HANH l = lichService.GetDVByMa(idlt);
                
                tour_dat.TONG_TIEN = l.TOUR.GIA - (l.TOUR.GIA * (l.TOUR.DISCOUNT / 100));
                if (tourdat.Add(tour_dat) == 1)
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
            if (txtMaTourDat.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn vé !", "Thông báo");
                return;
            }
            if (txtDiemDon.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập chi tiết điểm đón", "Thông báo");
                txtDiemDon.Focus();
            }
            else
            {
                TOUR_DAT t = tourdat.GetDVByMa(Int32.Parse(txtMaTourDat.TextName));
                t.DIEM_DON = txtDiemDon.TextName;
                t.NGAY_DAT = dtp_Ngay.Value;
                t.MA_KHACH_HANG = Int32.Parse(cb_KH.SelectedValue.ToString());
                t.MA_LICH = Int32.Parse(cb_LT.SelectedValue.ToString());
                t.MA_NV = Int32.Parse(cb_NV.SelectedValue.ToString());
                t.TRANG_THAI = cb_trangthai.SelectedItem.ToString();
                if (tourdat.Update(tour_dat) == 1)
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
            if (txtMaTourDat.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn vé !", "Thông báo");
                return;
            }
            else
            {

                if (tourdat.Delete(Int32.Parse(txtMaTourDat.TextName)) == 1)
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
        private void resetTextbox()
        {
            txtMaTourDat.TextName = "";
            txtDiemDon.TextName = "";
           

        }

        private void cb_trangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_LT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_LT.SelectedValue != null )
            {
                int idlt = Int32.Parse(cb_LT.SelectedValue.ToString());
                LICH_KHOI_HANH l = lichService.GetDVByMa(idlt);
                txt_gia.TextName = (l.TOUR.GIA - (l.TOUR.GIA * (l.TOUR.DISCOUNT / 100))).ToString();
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                Image img;
                if (l.TOUR.IMAGE != null)
                {
                    img = Image.FromFile(path + "\\Image\\" + l.TOUR.IMAGE);

                }
                else
                {
                    img = Image.FromFile(path + "\\Image\\Dubai_Kesari_Tours.jpg");
                }
            }

        }

        private void txtMaTourDat_Load(object sender, EventArgs e)
        {

        }

        private void listDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (DICH_VU i in listDV.SelectedItems)
            {
                MessageBox.Show(i.MA_DICH_VU.ToString());
            }
        }
    }
}