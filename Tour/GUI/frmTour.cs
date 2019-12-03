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
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class frmTour : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        TOUR tour = new TOUR();
        loaiTourDAL ltourService = new loaiTourDAL();
        tourDAL tourdal = new tourDAL();
        public frmTour()
        {
            InitializeComponent();


        }
        public void load()
        {
            var Listlt = ltourService.GetList();
            cb_loait.DataSource = Listlt;
            cb_loait.ValueMember = "MA_LOAI";
            cb_loait.DisplayMember = "TEN_LOAI";
            var List = tourdal.GetList();
            gc_tour.DataSource = List;
        }
        private void frmTour_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên tour", "Thông báo");
                txtTen.Focus();
            }
            else
            {
                if(nameimg.Text != "")
                {
                    string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\Image\\" + filename);
                    tour.IMAGE = filename;
                }
                //tour.IMAGE = 
                tour.TEN_TOUR = txtTen.TextName;
                tour.GIA = double.Parse(txtGia.TextName);
                tour.MA_LOAI = Int32.Parse(cb_loait.SelectedValue.ToString());
                tour.SO_NGAY = Int32.Parse(txtSoNgay.TextName);
                tour.SO_CHO = Int32.Parse(txtSoCho.TextName);
                tour.DISCOUNT = double.Parse(txtGiamGia.TextName);
                if (tourdal.Add(tour) == 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    load();
                    //resetTextbox();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                }

            }
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaTour.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn tour !", "Thông báo");
                return;
            }
            if (txtTen.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập tên tour", "Thông báo");
                txtTen.Focus();
            }
            if (txtSoNgay.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập số ngày", "Thông báo");
                txtSoNgay.Focus();
            }
            if (txtSoNgay.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập số ngày", "Thông báo");
                txtSoNgay.Focus();
            }
            if (txtSoCho.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập số chỗ", "Thông báo");
                txtSoCho.Focus();
            }
            if (txtGia.TextName == "")
            {
                MessageBox.Show("Bạn phải nhập giá", "Thông báo");
                txtGia.Focus();
            }
            else
            {
                TOUR t = tourdal.GetDVByMa(Int32.Parse(txtMaTour.TextName));
                if (nameimg.Text != "")
                {
                    string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\Image\\" + filename);
                    t.IMAGE = filename;
                }
                t.TEN_TOUR = txtTen.TextName;
                t.GIA = double.Parse(txtGia.TextName);
                t.MA_LOAI = Int32.Parse(cb_loait.SelectedValue.ToString());
                t.SO_NGAY = Int32.Parse(txtSoNgay.TextName);
                t.SO_CHO = Int32.Parse(txtSoCho.TextName);
                t.DISCOUNT = double.Parse(txtGiamGia.TextName);
                if (tourdal.Update(tour) == 1)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    load();
                    //resetTextbox();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông báo");
                }
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaTour.TextName == "")
            {
                MessageBox.Show("Bạn phải chọn chương trình", "Thông báo");
            }
            else
            {
                if (tourdal.Delete(Int32.Parse(txtMaTour.TextName)) == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    load();
                    //resetTextbox();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo");
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetTexbox();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int position = gridView1.FocusedRowHandle;
            txtMaTour.TextName = gridView1.GetRowCellValue(position, "MA_TOUR").ToString();
            cb_loait.SelectedValue = Int32.Parse(gridView1.GetRowCellValue(position, "MA_LOAI").ToString());
            txtTen.TextName = gridView1.GetRowCellValue(position, "TEN_TOUR").ToString();
            txtSoNgay.TextName = gridView1.GetRowCellValue(position, "SO_NGAY").ToString();
            txtSoCho.TextName = gridView1.GetRowCellValue(position, "SO_CHO").ToString();
            txtGia.TextName = gridView1.GetRowCellValue(position, "GIA").ToString();
            txtGiamGia.TextName = gridView1.GetRowCellValue(position, "DISCOUNT").ToString();
            int id = Int32.Parse(txtMaTour.TextName);
            nameimg.Text = "";
            //Bitmap img = 
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            Image img;
            if (tourdal.GetDVByMa(id).IMAGE != null)
            {
                 img = Image.FromFile(path + "\\Image\\" + tourdal.GetDVByMa(id).IMAGE);
               
            }
            else
            {
                 img = Image.FromFile(path + "\\Image\\Dubai_Kesari_Tours.jpg");
            }
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            bbiAdd.Enabled = false;

            //pictureBox1.Image = CopyDataToBitmap(tourdal.GetDVByMa(id).IMAGE);
        }
        private void resetTexbox()
        {
            txtGia.TextName = "";
            txtGiamGia.TextName = "";
            txtMaTour.TextName = "";
            txtSoCho.TextName = "";
            txtSoNgay.TextName = "";
            txtTen.TextName = "";
            nameimg.Text = "";
            bbiAdd.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select image to be upload.";
            //which type image format you want to upload in database. just add them.
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        nameimg.Text = path;
                        pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }
        }
        
    }

}