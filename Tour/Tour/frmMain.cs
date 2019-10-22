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

namespace Tour
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void groupKS_Enter(object sender, EventArgs e)
        {

        }

        private void HideGroupBoxes()
        {
            groupKS.Visible = false;
            groupKH.Visible = false;
            groupTour.Visible = false;
            groupDD.Visible = false;
            groupDV.Visible = false;
            groupVe.Visible = false;
            groupBox2.Visible = false;
            groupKS.Location = new Point(20, 17);
            groupKH.Location = new Point(20, 17);
            groupTour.Location = new Point(20, 17);
            groupDD.Location = new Point(20, 17);
            groupDV.Location = new Point(20, 17);
            groupVe.Location = new Point(20, 17);
            groupBox2.Location = new Point(20, 17);
        }

        private void navBarItemKS_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HideGroupBoxes();
            groupKS.Visible = true;
           
        }

        private void navBarItemKH_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HideGroupBoxes();
            groupKH.Visible = true;
        }

        private void navBarItemTour_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HideGroupBoxes();
            groupTour.Visible = true;
        }

        private void navBarItemDD_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HideGroupBoxes();
            groupDD.Visible = true;
        }

        private void navBarItemDV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HideGroupBoxes();
            groupDV.Visible = true;
        }

        private void navBarItemVe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HideGroupBoxes();
            groupVe.Visible = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

    }
}