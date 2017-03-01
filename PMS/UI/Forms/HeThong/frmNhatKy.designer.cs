namespace PMS.UI.Forms.HeThong
{
    partial class frmNhatKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhatKy));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceTaiKhoan = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewTaiKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLamTuoi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.btnMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnMacDinh = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemGridLookUpEditNhomQuyen = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bindingSourceNhomQuyen = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemTextEditNgayDangNhap = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.toolTipController = new DevExpress.Utils.ToolTipController(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditNhomQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNhomQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditNgayDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlTaiKhoan);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(662, 407);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlTaiKhoan
            // 
            this.gridControlTaiKhoan.DataSource = this.bindingSourceTaiKhoan;
            this.gridControlTaiKhoan.Location = new System.Drawing.Point(12, 12);
            this.gridControlTaiKhoan.MainView = this.gridViewTaiKhoan;
            this.gridControlTaiKhoan.MenuManager = this.barManager;
            this.gridControlTaiKhoan.Name = "gridControlTaiKhoan";
            this.gridControlTaiKhoan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditNhomQuyen,
            this.repositoryItemTextEditNgayDangNhap});
            this.gridControlTaiKhoan.Size = new System.Drawing.Size(638, 383);
            this.gridControlTaiKhoan.TabIndex = 4;
            this.gridControlTaiKhoan.ToolTipController = this.toolTipController;
            this.gridControlTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTaiKhoan});
            // 
            // gridViewTaiKhoan
            // 
            this.gridViewTaiKhoan.GridControl = this.gridControlTaiKhoan;
            this.gridViewTaiKhoan.Name = "gridViewTaiKhoan";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Images = this.imageCollection;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnLamTuoi,
            this.btnMatKhau,
            this.btnMacDinh});
            this.barManager.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLamTuoi, true)});
            this.bar1.Text = "Tools";
            // 
            // btnLamTuoi
            // 
            this.btnLamTuoi.Caption = "Làm tươi";
            this.btnLamTuoi.Description = "Làm tươi";
            this.btnLamTuoi.Id = 2;
            this.btnLamTuoi.ImageIndex = 2;
            this.btnLamTuoi.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnLamTuoi.Name = "btnLamTuoi";
            this.btnLamTuoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLamTuoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamTuoi_ItemClick);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "save.png");
            this.imageCollection.Images.SetKeyName(1, "delete.png");
            this.imageCollection.Images.SetKeyName(2, "reload.png");
            this.imageCollection.Images.SetKeyName(3, "undo.png");
            this.imageCollection.Images.SetKeyName(4, "printer.png");
            this.imageCollection.Images.SetKeyName(5, "add.png");
            // 
            // btnMatKhau
            // 
            this.btnMatKhau.Caption = "Đổi mật khẩu";
            this.btnMatKhau.Id = 7;
            this.btnMatKhau.Name = "btnMatKhau";
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Caption = "Mặc định mật khẩu";
            this.btnMacDinh.Id = 8;
            this.btnMacDinh.Name = "btnMacDinh";
            // 
            // repositoryItemGridLookUpEditNhomQuyen
            // 
            this.repositoryItemGridLookUpEditNhomQuyen.AutoHeight = false;
            this.repositoryItemGridLookUpEditNhomQuyen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditNhomQuyen.DataSource = this.bindingSourceNhomQuyen;
            this.repositoryItemGridLookUpEditNhomQuyen.Name = "repositoryItemGridLookUpEditNhomQuyen";
            this.repositoryItemGridLookUpEditNhomQuyen.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemTextEditNgayDangNhap
            // 
            this.repositoryItemTextEditNgayDangNhap.AutoHeight = false;
            this.repositoryItemTextEditNgayDangNhap.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
            this.repositoryItemTextEditNgayDangNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemTextEditNgayDangNhap.Name = "repositoryItemTextEditNgayDangNhap";
            // 
            // toolTipController
            // 
            this.toolTipController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(662, 407);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlTaiKhoan;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(642, 387);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmNhatKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 433);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhatKy";
            this.Text = "Nhật ký đăng nhập";
            this.Load += new System.EventHandler(this.frmNhatKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditNhomQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNhomQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditNgayDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControlTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTaiKhoan;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnLamTuoi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Utils.ToolTipController toolTipController;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditNhomQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraBars.BarButtonItem btnMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnMacDinh;
        private System.Windows.Forms.BindingSource bindingSourceTaiKhoan;
        private System.Windows.Forms.BindingSource bindingSourceNhomQuyen;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditNgayDangNhap;
    }
}