namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
            this.employeesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.customersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();

            this.btn_logout = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dangxuat = new DevExpress.XtraBars.BarButtonItem();

            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.officeNavigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem13 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem14 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem15 = new DevExpress.XtraNavBar.NavBarItem();
            this.employeesNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemNV = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemCH = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.customersNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemKH = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemTour = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemLTrinh = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemCTrinh = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemDVu = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemDV = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem12 = new DevExpress.XtraNavBar.NavBarItem();
            this.paneload = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paneload)).BeginInit();
            this.SuspendLayout();
            // 
            // tabbedView
            // 
            this.tabbedView.RootContainer.Element = null;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem,
            this.barSubItemNavigation,
            this.employeesBarButtonItem,
            this.customersBarButtonItem,
            this.ribbonGalleryBarItem1,
            this.barButtonItem1,
            this.btn_logout,
            this.barButtonItem3,
            this.btn_dangxuat});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 55;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.barButtonItem1);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1094, 143);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Id = 14;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // barSubItemNavigation
            // 
            this.barSubItemNavigation.Caption = "Navigation";
            this.barSubItemNavigation.Id = 15;
            this.barSubItemNavigation.ImageOptions.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.employeesBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.customersBarButtonItem)});
            this.barSubItemNavigation.Name = "barSubItemNavigation";
            // 
            // employeesBarButtonItem
            // 
            this.employeesBarButtonItem.Caption = "Employees";
            this.employeesBarButtonItem.Id = 44;
            this.employeesBarButtonItem.Name = "employeesBarButtonItem";
            this.employeesBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNavigation_ItemClick);
            // 
            // customersBarButtonItem
            // 
            this.customersBarButtonItem.Caption = "Customers";
            this.customersBarButtonItem.Id = 45;
            this.customersBarButtonItem.Name = "customersBarButtonItem";
            this.customersBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNavigation_ItemClick);
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            // 
            // 
            // 
            this.ribbonGalleryBarItem1.Gallery.ImageSize = new System.Drawing.Size(100, 100);
            this.ribbonGalleryBarItem1.Id = 46;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.ActAsDropDown = true;
            this.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem1.Caption = "btn_user";
            this.barButtonItem1.Id = 51;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btn_logout
            // 
            this.btn_logout.Caption = "Log out";
            this.btn_logout.Id = 52;
            this.btn_logout.Name = "btn_logout";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Đăng xuất";
            this.barButtonItem3.Id = 53;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Caption = "Log out";
            this.btn_dangxuat.Id = 54;
            this.btn_dangxuat.Name = "btn_dangxuat";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.ActAsDropDown = true;
            this.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem1.Caption = "btn_user";
            this.barButtonItem1.Id = 51;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
          
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Caption = "Log out";
            this.btn_dangxuat.Id = 54;
            this.btn_dangxuat.Name = "btn_dangxuat";
            // 
            // btn_logout
            // 
            this.btn_logout.Caption = "Log out";
            this.btn_logout.Id = 52;
            this.btn_logout.Name = "btn_logout";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Đăng xuất";
            this.barButtonItem3.Id = 53;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "View";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.AllowTextClipping = false;
            this.ribbonPageGroup.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.ShowCaptionButton = false;
            this.ribbonPageGroup.Text = "Appearance";
            //  
            // officeNavigationBar
            // 
            this.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar.Location = new System.Drawing.Point(0, 595);
            this.officeNavigationBar.Name = "officeNavigationBar";
            this.officeNavigationBar.NavigationClient = this.navBarControl;
            this.officeNavigationBar.Size = new System.Drawing.Size(1094, 45);
            this.officeNavigationBar.TabIndex = 1;
            this.officeNavigationBar.Text = "officeNavigationBar";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.navBarGroup3;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.employeesNavBarGroup,
            this.customersNavBarGroup,
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemNV,
            this.navBarItem2,
            this.navBarItemCH,
            this.navBarItem4,
            this.navBarItemKH,
            this.navBarItemTour,
            this.navBarItemLTrinh,
            this.navBarItemCTrinh,
            this.navBarItemDVu,
            this.navBarItemDV,
            this.navBarItem11,
            this.navBarItem12,
            this.navBarItem13,
            this.navBarItem14,
            this.navBarItem15});
            this.navBarControl.Location = new System.Drawing.Point(0, 143);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 165;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(165, 452);
            this.navBarControl.TabIndex = 0;
            this.navBarControl.Text = "navBarControl";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Báo cáo";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem13),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem14),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem15)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItem13
            // 
            this.navBarItem13.Caption = "Tour";
            this.navBarItem13.Name = "navBarItem13";
            // 
            // navBarItem14
            // 
            this.navBarItem14.Caption = "Vé";
            this.navBarItem14.Name = "navBarItem14";
            // 
            // navBarItem15
            // 
            this.navBarItem15.Caption = "Doanh thu";
            this.navBarItem15.Name = "navBarItem15";
            // 
            // employeesNavBarGroup
            // 
            this.employeesNavBarGroup.Caption = "Hệ thống";
            this.employeesNavBarGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemNV),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemCH),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.employeesNavBarGroup.Name = "employeesNavBarGroup";
            // 
            // navBarItemNV
            // 
            this.navBarItemNV.Caption = "Tài khoản";
            this.navBarItemNV.Name = "navBarItemNV";
            this.navBarItemNV.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemNV_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Phân quyền";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarItemCH
            // 
            this.navBarItemCH.Caption = "Màn hình";
            this.navBarItemCH.Name = "navBarItemCH";
            this.navBarItemCH.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemCH_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Nhóm quyền";
            this.navBarItem4.Name = "navBarItem4";
            // 
            // customersNavBarGroup
            // 
            this.customersNavBarGroup.Caption = "Khách hàng";
            this.customersNavBarGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemKH)});
            this.customersNavBarGroup.Name = "customersNavBarGroup";
            // 
            // navBarItemKH
            // 
            this.navBarItemKH.Caption = "Khách hàng";
            this.navBarItemKH.Name = "navBarItemKH";
            this.navBarItemKH.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemKH_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Tour";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTour),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemLTrinh),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemCTrinh),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDVu)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItemTour
            // 
            this.navBarItemTour.Caption = "Tour";
            this.navBarItemTour.Name = "navBarItemTour";
            this.navBarItemTour.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemTour_LinkClicked);
            // 
            // navBarItemLTrinh
            // 
            this.navBarItemLTrinh.Caption = "Lịch trình";
            this.navBarItemLTrinh.Name = "navBarItemLTrinh";
            this.navBarItemLTrinh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemLTrinh_LinkClicked);
            // 
            // navBarItemCTrinh
            // 
            this.navBarItemCTrinh.Caption = "Chương trình";
            this.navBarItemCTrinh.Name = "navBarItemCTrinh";
            this.navBarItemCTrinh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemCTrinh_LinkClicked);
            // 
            // navBarItemDVu
            // 
            this.navBarItemDVu.Caption = "Dịch vụ";
            this.navBarItemDVu.Name = "navBarItemDVu";
            this.navBarItemDVu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemDVu_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Vé";
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDV),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem11),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem12)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItemDV
            // 
            this.navBarItemDV.Caption = "Đặt vé";
            this.navBarItemDV.Name = "navBarItemDV";
            // 
            // navBarItem11
            // 
            this.navBarItem11.Caption = "Thanh toán";
            this.navBarItem11.Name = "navBarItem11";
            // 
            // navBarItem12
            // 
            this.navBarItem12.Caption = "Danh sách vé";
            this.navBarItem12.Name = "navBarItem12";
            // 
            // paneload
            // 
            this.paneload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneload.Location = new System.Drawing.Point(165, 143);
            this.paneload.Name = "paneload";
            this.paneload.Size = new System.Drawing.Size(929, 452);
            this.paneload.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 671);
            this.Controls.Add(this.paneload);
            this.Controls.Add(this.navBarControl);
            this.Controls.Add(this.officeNavigationBar);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paneload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar;
        private DevExpress.XtraBars.BarButtonItem employeesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem customersBarButtonItem;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem13;
        private DevExpress.XtraNavBar.NavBarItem navBarItem14;
        private DevExpress.XtraNavBar.NavBarItem navBarItem15;
        private DevExpress.XtraNavBar.NavBarGroup employeesNavBarGroup;
        private DevExpress.XtraNavBar.NavBarItem navBarItemNV;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItemCH;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarGroup customersNavBarGroup;
        private DevExpress.XtraNavBar.NavBarItem navBarItemKH;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTour;
        private DevExpress.XtraNavBar.NavBarItem navBarItemLTrinh;
        private DevExpress.XtraNavBar.NavBarItem navBarItemCTrinh;
        private DevExpress.XtraNavBar.NavBarItem navBarItemDVu;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItemDV;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
        private DevExpress.XtraNavBar.NavBarItem navBarItem12;
        private DevExpress.XtraEditors.PanelControl paneload;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_dangxuat;
        private DevExpress.XtraBars.BarButtonItem btn_logout;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}