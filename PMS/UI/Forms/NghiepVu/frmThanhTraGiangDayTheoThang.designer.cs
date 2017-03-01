using MonthYearDateEdit;
namespace PMS.UI.Forms.NghiepVu
{
    partial class frmThanhTraGiangDayTheoThang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhTraGiangDayTheoThang));
            this.monthYearEdit1 = new MonthYearDateEdit.MonthYearEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Lamtuoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_In = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridLookUpEditDonVi = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceDonVi = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_Loc = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlThanhTraGiangDayTheoNgay = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceThanhTraGiangDay = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewThanhTraGiangDayTheoNgay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.monthYearEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthYearEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThanhTraGiangDayTheoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceThanhTraGiangDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThanhTraGiangDayTheoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // monthYearEdit1
            // 
            this.monthYearEdit1.EditValue = null;
            this.monthYearEdit1.Location = new System.Drawing.Point(85, 12);
            this.monthYearEdit1.MenuManager = this.barManager1;
            this.monthYearEdit1.Name = "monthYearEdit1";
            this.monthYearEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.monthYearEdit1.Properties.Mask.EditMask = "y";
            this.monthYearEdit1.Properties.ShowToday = false;
            this.monthYearEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.monthYearEdit1.Size = new System.Drawing.Size(116, 20);
            this.monthYearEdit1.StyleController = this.layoutControl1;
            this.monthYearEdit1.TabIndex = 5;
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
            this.btn_Lamtuoi,
            this.btn_In});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Lamtuoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_In, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btn_Lamtuoi
            // 
            this.btn_Lamtuoi.Caption = "Làm tươi";
            this.btn_Lamtuoi.Id = 0;
            this.btn_Lamtuoi.ImageIndex = 0;
            this.btn_Lamtuoi.Name = "btn_Lamtuoi";
            // 
            // btn_In
            // 
            this.btn_In.Caption = "In";
            this.btn_In.Id = 1;
            this.btn_In.ImageIndex = 3;
            this.btn_In.Name = "btn_In";
            this.btn_In.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_In_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(673, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 484);
            this.barDockControlBottom.Size = new System.Drawing.Size(673, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 458);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(673, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 458);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "reload.png");
            this.imageCollection1.Images.SetKeyName(1, "undo.png");
            this.imageCollection1.Images.SetKeyName(2, "save.png");
            this.imageCollection1.Images.SetKeyName(3, "printer.png");
            this.imageCollection1.Images.SetKeyName(4, "delete.png");
            this.imageCollection1.Images.SetKeyName(5, "search-footer-icon.png");
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridLookUpEditDonVi);
            this.layoutControl1.Controls.Add(this.btn_Loc);
            this.layoutControl1.Controls.Add(this.monthYearEdit1);
            this.layoutControl1.Controls.Add(this.gridControlThanhTraGiangDayTheoNgay);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(673, 458);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridLookUpEditDonVi
            // 
            this.gridLookUpEditDonVi.Location = new System.Drawing.Point(278, 12);
            this.gridLookUpEditDonVi.MenuManager = this.barManager1;
            this.gridLookUpEditDonVi.Name = "gridLookUpEditDonVi";
            this.gridLookUpEditDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditDonVi.Properties.DataSource = this.bindingSourceDonVi;
            this.gridLookUpEditDonVi.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEditDonVi.Size = new System.Drawing.Size(170, 20);
            this.gridLookUpEditDonVi.StyleController = this.layoutControl1;
            this.gridLookUpEditDonVi.TabIndex = 7;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btn_Loc
            // 
            this.btn_Loc.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Loc.Appearance.Options.UseFont = true;
            this.btn_Loc.ImageIndex = 5;
            this.btn_Loc.ImageList = this.imageCollection1;
            this.btn_Loc.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_Loc.Location = new System.Drawing.Point(452, 12);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(73, 22);
            this.btn_Loc.StyleController = this.layoutControl1;
            this.btn_Loc.TabIndex = 6;
            this.btn_Loc.Text = "&Lọc";
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // gridControlThanhTraGiangDayTheoNgay
            // 
            this.gridControlThanhTraGiangDayTheoNgay.DataSource = this.bindingSourceThanhTraGiangDay;
            this.gridControlThanhTraGiangDayTheoNgay.Location = new System.Drawing.Point(12, 38);
            this.gridControlThanhTraGiangDayTheoNgay.MainView = this.gridViewThanhTraGiangDayTheoNgay;
            this.gridControlThanhTraGiangDayTheoNgay.MenuManager = this.barManager1;
            this.gridControlThanhTraGiangDayTheoNgay.Name = "gridControlThanhTraGiangDayTheoNgay";
            this.gridControlThanhTraGiangDayTheoNgay.Size = new System.Drawing.Size(649, 408);
            this.gridControlThanhTraGiangDayTheoNgay.TabIndex = 4;
            this.gridControlThanhTraGiangDayTheoNgay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewThanhTraGiangDayTheoNgay});
            // 
            // gridViewThanhTraGiangDayTheoNgay
            // 
            this.gridViewThanhTraGiangDayTheoNgay.GridControl = this.gridControlThanhTraGiangDayTheoNgay;
            this.gridViewThanhTraGiangDayTheoNgay.Name = "gridViewThanhTraGiangDayTheoNgay";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(673, 458);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlThanhTraGiangDayTheoNgay;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(653, 412);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_Loc;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(440, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(77, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(517, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(136, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.monthYearEdit1;
            this.layoutControlItem4.CustomizationFormText = "Tháng/ Năm:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(193, 26);
            this.layoutControlItem4.Text = "Tháng/ Năm:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridLookUpEditDonVi;
            this.layoutControlItem5.CustomizationFormText = "Đơn vị - Khoa:";
            this.layoutControlItem5.Location = new System.Drawing.Point(193, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(247, 26);
            this.layoutControlItem5.Text = "Đơn vị - Khoa:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(69, 13);
            // 
            // frmThanhTraGiangDayTheoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 484);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmThanhTraGiangDayTheoThang";
            this.Text = "Bảng tổng hợp tình hình giảng dạy trong tháng";
            this.Load += new System.EventHandler(this.frmThanhTraGiangDayTheoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthYearEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthYearEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThanhTraGiangDayTheoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceThanhTraGiangDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThanhTraGiangDayTheoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private MonthYearEdit monthYearEdit1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_Lamtuoi;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControlThanhTraGiangDayTheoNgay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewThanhTraGiangDayTheoNgay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        //private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btn_Loc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bindingSourceThanhTraGiangDay;
        private DevExpress.XtraBars.BarButtonItem btn_In;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditDonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource bindingSourceDonVi;
    }
}