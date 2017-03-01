namespace PMS.UI.Modules.Reports
{
    partial class ucThongKeHopDongTheoThoiGian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThongKeHopDongTheoThoiGian));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btn_LamTuoi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_In = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Excel = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cboKhoaDonVi = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.btn_LocDL = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlThongKeHD = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceThongKeHDTheoThoiGian = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewThongKeHD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateEditNgay = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtKhoa = new DevExpress.XtraLayout.LayoutControlItem();
            this._btnLamTuoi = new DevExpress.XtraBars.BarButtonItem();
            this._btnXuatEcxel = new DevExpress.XtraBars.BarButtonItem();
            this._btnIn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoaDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThongKeHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceThongKeHDTheoThoiGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThongKeHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoa)).BeginInit();
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
            this.btn_LamTuoi,
            this.barButtonItem2,
            this.btn_In,
            this.btn_Excel,
            this._btnLamTuoi,
            this._btnXuatEcxel,
            this._btnIn});
            this.barManager1.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this._btnLamTuoi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this._btnXuatEcxel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this._btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 1;
            this.bar1.Text = "Tools";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(714, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 497);
            this.barDockControlBottom.Size = new System.Drawing.Size(714, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 471);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(714, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 471);
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
            // btn_LamTuoi
            // 
            this.btn_LamTuoi.Caption = "Làm tươi";
            this.btn_LamTuoi.Id = 3;
            this.btn_LamTuoi.ImageIndex = 0;
            this.btn_LamTuoi.Name = "btn_LamTuoi";
            this.btn_LamTuoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_LamTuoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_LamTuoi_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Xuất Excel";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_In
            // 
            this.btn_In.Caption = "In";
            this.btn_In.Id = 5;
            this.btn_In.ImageIndex = 6;
            this.btn_In.Name = "btn_In";
            this.btn_In.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_In.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_In_ItemClick);
            // 
            // btn_Excel
            // 
            this.btn_Excel.Caption = "Xuất Excel";
            this.btn_Excel.Id = 6;
            this.btn_Excel.ImageIndex = 4;
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Excel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Excel_ItemClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboKhoaDonVi);
            this.layoutControl1.Controls.Add(this.btn_LocDL);
            this.layoutControl1.Controls.Add(this.gridControlThongKeHD);
            this.layoutControl1.Controls.Add(this.dateEditNgay);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(714, 471);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cboKhoaDonVi
            // 
            this.cboKhoaDonVi.Location = new System.Drawing.Point(82, 12);
            this.cboKhoaDonVi.MenuManager = this.barManager1;
            this.cboKhoaDonVi.Name = "cboKhoaDonVi";
            this.cboKhoaDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoaDonVi.Size = new System.Drawing.Size(115, 20);
            this.cboKhoaDonVi.StyleController = this.layoutControl1;
            this.cboKhoaDonVi.TabIndex = 7;
            this.cboKhoaDonVi.EditValueChanged += new System.EventHandler(this.cboKhoaDonVi_EditValueChanged);
            // 
            // btn_LocDL
            // 
            this.btn_LocDL.Location = new System.Drawing.Point(516, 12);
            this.btn_LocDL.Name = "btn_LocDL";
            this.btn_LocDL.Size = new System.Drawing.Size(186, 22);
            this.btn_LocDL.StyleController = this.layoutControl1;
            this.btn_LocDL.TabIndex = 6;
            this.btn_LocDL.Text = "Lọc dữ liệu";
            this.btn_LocDL.Click += new System.EventHandler(this.btn_LocDL_Click);
            // 
            // gridControlThongKeHD
            // 
            this.gridControlThongKeHD.DataSource = this.bindingSourceThongKeHDTheoThoiGian;
            this.gridControlThongKeHD.Location = new System.Drawing.Point(12, 38);
            this.gridControlThongKeHD.MainView = this.gridViewThongKeHD;
            this.gridControlThongKeHD.MenuManager = this.barManager1;
            this.gridControlThongKeHD.Name = "gridControlThongKeHD";
            this.gridControlThongKeHD.Size = new System.Drawing.Size(690, 421);
            this.gridControlThongKeHD.TabIndex = 5;
            this.gridControlThongKeHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewThongKeHD});
            // 
            // gridViewThongKeHD
            // 
            this.gridViewThongKeHD.GridControl = this.gridControlThongKeHD;
            this.gridViewThongKeHD.Name = "gridViewThongKeHD";
            // 
            // dateEditNgay
            // 
            this.dateEditNgay.EditValue = null;
            this.dateEditNgay.Location = new System.Drawing.Point(271, 12);
            this.dateEditNgay.MenuManager = this.barManager1;
            this.dateEditNgay.Name = "dateEditNgay";
            this.dateEditNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditNgay.Size = new System.Drawing.Size(241, 20);
            this.dateEditNgay.StyleController = this.layoutControl1;
            this.dateEditNgay.TabIndex = 4;
            this.dateEditNgay.EditValueChanged += new System.EventHandler(this.dateEditNgay_EditValueChanged);
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
            this.txtKhoa});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(714, 471);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateEditNgay;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(189, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(315, 26);
            this.layoutControlItem1.Text = "Ngày";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlThongKeHD;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(694, 425);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_LocDL;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(504, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(190, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Control = this.cboKhoaDonVi;
            this.txtKhoa.CustomizationFormText = "Khoa - đơn vị:";
            this.txtKhoa.Location = new System.Drawing.Point(0, 0);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(189, 26);
            this.txtKhoa.Text = "Khoa - đơn vị:";
            this.txtKhoa.TextSize = new System.Drawing.Size(67, 13);
            // 
            // _btnLamTuoi
            // 
            this._btnLamTuoi.Caption = "Làm tươi";
            this._btnLamTuoi.Id = 7;
            this._btnLamTuoi.ImageIndex = 0;
            this._btnLamTuoi.Name = "_btnLamTuoi";
            this._btnLamTuoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_LamTuoi_ItemClick);
            // 
            // _btnXuatEcxel
            // 
            this._btnXuatEcxel.Caption = "Xuất Excel";
            this._btnXuatEcxel.Id = 8;
            this._btnXuatEcxel.ImageIndex = 4;
            this._btnXuatEcxel.Name = "_btnXuatEcxel";
            this._btnXuatEcxel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Excel_ItemClick);
            // 
            // _btnIn
            // 
            this._btnIn.Caption = "In";
            this._btnIn.Id = 9;
            this._btnIn.ImageIndex = 6;
            this._btnIn.Name = "_btnIn";
            this._btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_In_ItemClick);
            // 
            // ucThongKeHopDongTheoThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucThongKeHopDongTheoThoiGian";
            this.Size = new System.Drawing.Size(714, 497);
            this.Load += new System.EventHandler(this.ucThongKeHopDongTheoThoiGian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoaDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThongKeHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceThongKeHDTheoThoiGian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThongKeHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnLamTuoi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_LamTuoi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btn_In;
        private DevExpress.XtraEditors.SimpleButton btn_LocDL;
        private DevExpress.XtraGrid.GridControl gridControlThongKeHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewThongKeHD;
        private DevExpress.XtraEditors.DateEdit dateEditNgay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource bindingSourceThongKeHDTheoThoiGian;
        private DevExpress.XtraBars.BarButtonItem btn_Excel;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cboKhoaDonVi;
        private DevExpress.XtraLayout.LayoutControlItem txtKhoa;
        private DevExpress.XtraBars.BarButtonItem _btnLamTuoi;
        private DevExpress.XtraBars.BarButtonItem _btnXuatEcxel;
        private DevExpress.XtraBars.BarButtonItem _btnIn;
    }
}
