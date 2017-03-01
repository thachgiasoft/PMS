namespace PMS.UI.Modules.Reports
{
    partial class ucThongKeChiTietThongTinNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThongKeChiTietThongTinNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLamTuoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnLocDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.cboLoaiNhanVien = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.gridControlThongKeChiTietThongTinNhanVien = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceThongKeChiTietThongTinNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewThongKeChiTietThongTinNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboKhoaDonVi = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThongKeChiTietThongTinNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceThongKeChiTietThongTinNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThongKeChiTietThongTinNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoaDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnLamTuoi,
            this.btnXuatExcel,
            this.btnIn});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamTuoi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuatExcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnLamTuoi
            // 
            this.btnLamTuoi.Caption = "Làm tươi";
            this.btnLamTuoi.Id = 0;
            this.btnLamTuoi.ImageIndex = 0;
            this.btnLamTuoi.Name = "btnLamTuoi";
            this.btnLamTuoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamTuoi_ItemClick);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Caption = "Xuất Excel";
            this.btnXuatExcel.Id = 1;
            this.btnXuatExcel.ImageIndex = 4;
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatExcel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(693, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 430);
            this.barDockControlBottom.Size = new System.Drawing.Size(693, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 404);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(693, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 404);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "reload.png");
            this.imageCollection1.Images.SetKeyName(1, "add.png");
            this.imageCollection1.Images.SetKeyName(2, "delete.png");
            this.imageCollection1.Images.SetKeyName(3, "save.png");
            this.imageCollection1.Images.SetKeyName(4, "Excel16.png");
            this.imageCollection1.Images.SetKeyName(5, "4f140fcc-d9f8-41de-b189-468b5fd37f42.png");
            this.imageCollection1.Images.SetKeyName(6, "print_icon.gif");
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 2;
            this.btnIn.ImageIndex = 6;
            this.btnIn.Name = "btnIn";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnLocDuLieu);
            this.layoutControl1.Controls.Add(this.cboLoaiNhanVien);
            this.layoutControl1.Controls.Add(this.gridControlThongKeChiTietThongTinNhanVien);
            this.layoutControl1.Controls.Add(this.cboKhoaDonVi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(693, 404);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnLocDuLieu
            // 
            this.btnLocDuLieu.Location = new System.Drawing.Point(516, 12);
            this.btnLocDuLieu.Name = "btnLocDuLieu";
            this.btnLocDuLieu.Size = new System.Drawing.Size(165, 22);
            this.btnLocDuLieu.StyleController = this.layoutControl1;
            this.btnLocDuLieu.TabIndex = 7;
            this.btnLocDuLieu.Text = "Lọc dữ liệu";
            this.btnLocDuLieu.Click += new System.EventHandler(this.btnLocDuLieu_Click);
            // 
            // cboLoaiNhanVien
            // 
            this.cboLoaiNhanVien.Location = new System.Drawing.Point(337, 12);
            this.cboLoaiNhanVien.MenuManager = this.barManager1;
            this.cboLoaiNhanVien.Name = "cboLoaiNhanVien";
            this.cboLoaiNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiNhanVien.Size = new System.Drawing.Size(175, 20);
            this.cboLoaiNhanVien.StyleController = this.layoutControl1;
            this.cboLoaiNhanVien.TabIndex = 6;
            // 
            // gridControlThongKeChiTietThongTinNhanVien
            // 
            this.gridControlThongKeChiTietThongTinNhanVien.DataSource = this.bindingSourceThongKeChiTietThongTinNhanVien;
            this.gridControlThongKeChiTietThongTinNhanVien.Location = new System.Drawing.Point(12, 38);
            this.gridControlThongKeChiTietThongTinNhanVien.MainView = this.gridViewThongKeChiTietThongTinNhanVien;
            this.gridControlThongKeChiTietThongTinNhanVien.MenuManager = this.barManager1;
            this.gridControlThongKeChiTietThongTinNhanVien.Name = "gridControlThongKeChiTietThongTinNhanVien";
            this.gridControlThongKeChiTietThongTinNhanVien.Size = new System.Drawing.Size(669, 354);
            this.gridControlThongKeChiTietThongTinNhanVien.TabIndex = 5;
            this.gridControlThongKeChiTietThongTinNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewThongKeChiTietThongTinNhanVien});
            // 
            // gridViewThongKeChiTietThongTinNhanVien
            // 
            this.gridViewThongKeChiTietThongTinNhanVien.GridControl = this.gridControlThongKeChiTietThongTinNhanVien;
            this.gridViewThongKeChiTietThongTinNhanVien.Name = "gridViewThongKeChiTietThongTinNhanVien";
            // 
            // cboKhoaDonVi
            // 
            this.cboKhoaDonVi.Location = new System.Drawing.Point(84, 12);
            this.cboKhoaDonVi.MenuManager = this.barManager1;
            this.cboKhoaDonVi.Name = "cboKhoaDonVi";
            this.cboKhoaDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoaDonVi.Size = new System.Drawing.Size(177, 20);
            this.cboKhoaDonVi.StyleController = this.layoutControl1;
            this.cboKhoaDonVi.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(693, 404);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboKhoaDonVi;
            this.layoutControlItem1.CustomizationFormText = "Khoa - đơn vị";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(253, 26);
            this.layoutControlItem1.Text = "Khoa - đơn vị";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlThongKeChiTietThongTinNhanVien;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(673, 358);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cboLoaiNhanVien;
            this.layoutControlItem3.CustomizationFormText = "Loại nhân viên";
            this.layoutControlItem3.Location = new System.Drawing.Point(253, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(251, 26);
            this.layoutControlItem3.Text = "Loại nhân viên";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnLocDuLieu;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(504, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(169, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // ucThongKeChiTietThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucThongKeChiTietThongTinNhanVien";
            this.Size = new System.Drawing.Size(693, 430);
            this.Load += new System.EventHandler(this.ucThongKeChiTietThongTinNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThongKeChiTietThongTinNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceThongKeChiTietThongTinNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThongKeChiTietThongTinNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoaDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnLamTuoi;
        private DevExpress.XtraBars.BarButtonItem btnXuatExcel;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnLocDuLieu;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cboLoaiNhanVien;
        private DevExpress.XtraGrid.GridControl gridControlThongKeChiTietThongTinNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewThongKeChiTietThongTinNhanVien;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cboKhoaDonVi;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private System.Windows.Forms.BindingSource bindingSourceThongKeChiTietThongTinNhanVien;
    }
}
