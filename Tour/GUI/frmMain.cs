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

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();

        }
        //void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        //{
        //    navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        //}
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }

        private void navBarItemNV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            paneload.Controls.Clear();
            frmNV frmnv = new frmNV();
            frmnv.Dock = DockStyle.Fill;
            frmnv.TopLevel = false;
            frmnv.TopMost = true;
            frmnv.MaximizeBox = true;
            frmnv.MinimizeBox = false;
            frmnv.StartPosition = FormStartPosition.CenterScreen;
            paneload.Controls.Add(frmnv);
            frmnv.Show();
        }

        private void navBarItemCH_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
        }

        private void navBarItemKH_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            paneload.Controls.Clear();
            frmKH frmkh = new frmKH();
            frmkh.Dock = DockStyle.Fill;
            frmkh.TopLevel = false;
            frmkh.TopMost = true;
            frmkh.MaximizeBox = true;
            frmkh.MinimizeBox = false;
            frmkh.StartPosition = FormStartPosition.CenterScreen;
            paneload.Controls.Add(frmkh);
            frmkh.Show();
        }

        private void navBarItemTour_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            paneload.Controls.Clear();
            frmTour frmtour = new frmTour();
            frmtour.ShowInTaskbar = false;
            frmtour.ShowIcon = false;
            frmtour.Dock = DockStyle.Fill;
            frmtour.TopLevel = false;
            frmtour.TopMost = true;
            frmtour.MaximizeBox = true;
            frmtour.MinimizeBox = false;
            frmtour.StartPosition = FormStartPosition.CenterScreen;
            paneload.Controls.Add(frmtour);
            frmtour.Show();
        }

        private void navBarItemLTrinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            paneload.Controls.Clear();
            frmLTrinh frmltrinh = new frmLTrinh();
            frmltrinh.Dock = DockStyle.Fill;
            frmltrinh.TopLevel = false;
            frmltrinh.TopMost = true;
            frmltrinh.MaximizeBox = true;
            frmltrinh.MinimizeBox = false;
            frmltrinh.StartPosition = FormStartPosition.CenterScreen;
            paneload.Controls.Add(frmltrinh);
            frmltrinh.Show();
        }

        private void navBarItemCTrinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            paneload.Controls.Clear();
            frmCTTour frmcttour = new frmCTTour();
           
            frmcttour.Dock = DockStyle.Fill;
            frmcttour.TopLevel = false;
            frmcttour.TopMost = true;
            frmcttour.MaximizeBox = true;
            frmcttour.MinimizeBox = false;
            frmcttour.StartPosition = FormStartPosition.CenterScreen;
            paneload.Controls.Add(frmcttour);
            frmcttour.Show();
        }

        private void navBarItemDVu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            paneload.Controls.Clear();
           
            frmDV frmdv = new frmDV();
            frmdv.Dock = DockStyle.Fill;
            frmdv.TopLevel = false;
            frmdv.TopMost = true;
            frmdv.MaximizeBox = true;
            frmdv.MinimizeBox = false;
            frmdv.StartPosition = FormStartPosition.CenterScreen;
            paneload.Controls.Add(frmdv);
            frmdv.Show();

        }

        private void navBarItemDD_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            paneload.Controls.Clear();

            frmDD frmdv = new frmDD();
            frmdv.Dock = DockStyle.Fill;
            frmdv.TopLevel = false;
            frmdv.TopMost = true;
            frmdv.MaximizeBox = true;
            frmdv.MinimizeBox = false;
            frmdv.StartPosition = FormStartPosition.CenterScreen;
            paneload.Controls.Add(frmdv);
            frmdv.Show();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            paneload.Controls.Clear();

            frmKS frmdv = new frmKS();
            frmdv.Dock = DockStyle.Fill;
            frmdv.TopLevel = false;
            frmdv.TopMost = true;
            frmdv.MaximizeBox = true;
            frmdv.MinimizeBox = false;
            frmdv.StartPosition = FormStartPosition.CenterScreen;
            paneload.Controls.Add(frmdv);
            frmdv.Show();
        }
    }
}