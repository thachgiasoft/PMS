namespace PMS
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.DangXuat = new DevExpress.XtraBars.BarEditItem();
            this.ItemDangXuat = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.barCompany = new DevExpress.XtraBars.BarStaticItem();
            this.LimageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.toolTipController = new DevExpress.Utils.ToolTipController(this.components);
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.imageCollectionSystem = new DevExpress.Utils.ImageCollection(this.components);
            this.SimageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDangXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonText = null;
            this.ribbon.ApplicationIcon = global::PMS.Properties.Resources.cubes;
            // 
            // 
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.DangXuat,
            this.barCompany});
            this.ribbon.LargeImages = this.LimageCollection;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemDangXuat});
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(782, 52);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.TransparentEditors = true;
            // 
            // DangXuat
            // 
            this.DangXuat.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.DangXuat.Caption = "Đăng xuất";
            this.DangXuat.Description = "Admin";
            this.DangXuat.Edit = this.ItemDangXuat;
            this.DangXuat.EditValue = "Admin";
            this.DangXuat.Hint = "Admin";
            this.DangXuat.Id = 6;
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // ItemDangXuat
            // 
            this.ItemDangXuat.AutoHeight = false;
            this.ItemDangXuat.Caption = "Admin";
            this.ItemDangXuat.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ItemDangXuat.Name = "ItemDangXuat";
            this.ItemDangXuat.NullText = "Admin";
            this.ItemDangXuat.UseParentBackground = true;
            this.ItemDangXuat.Click += new System.EventHandler(this.ItemDangXuat_Click);
            // 
            // barCompany
            // 
            this.barCompany.Caption = "PSC PMS Copyright ©  2010 All rights reserved.";
            this.barCompany.Id = 7;
            this.barCompany.Name = "barCompany";
            this.barCompany.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // LimageCollection
            // 
            this.LimageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.LimageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("LimageCollection.ImageStream")));
            this.LimageCollection.Images.SetKeyName(0, "system-windows.png");
            this.LimageCollection.Images.SetKeyName(1, "agt_forum.png");
            this.LimageCollection.Images.SetKeyName(2, "DB_user.png");
            this.LimageCollection.Images.SetKeyName(3, "1257151143_add_user.png");
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.DangXuat);
            this.ribbonStatusBar.ItemLinks.Add(this.barCompany);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 537);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(782, 32);
            // 
            // toolTipController
            // 
            this.toolTipController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabbedMdiManager.FloatOnDrag = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // imageCollectionSystem
            // 
            this.imageCollectionSystem.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollectionSystem.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionSystem.ImageStream")));
            this.imageCollectionSystem.Images.SetKeyName(0, "system-windows.png");
            this.imageCollectionSystem.Images.SetKeyName(1, "agt_forum.png");
            this.imageCollectionSystem.Images.SetKeyName(2, "DB_user.png");
            this.imageCollectionSystem.Images.SetKeyName(3, "1257151143_add_user.png");
            // 
            // SimageCollection
            // 
            this.SimageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("SimageCollection.ImageStream")));
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 569);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "PMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDangXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        public DevExpress.Utils.ImageCollection LimageCollection;
        public DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        public DevExpress.XtraBars.BarEditItem DangXuat;
        public DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit ItemDangXuat;
        public DevExpress.Utils.ImageCollection imageCollectionSystem;
        private DevExpress.XtraBars.BarStaticItem barCompany;
        private DevExpress.Utils.ToolTipController toolTipController;
        public DevExpress.Utils.ImageCollection SimageCollection;
    }
}