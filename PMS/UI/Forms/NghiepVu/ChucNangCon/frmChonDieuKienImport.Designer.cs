namespace PMS.UI.Forms.NghiepVu.ChucNangCon
{
    partial class frmChonDieuKienImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonDieuKienImport));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnTiepTuc = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cboDotThanhToan = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceDotThanhToan = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboLoaiHinhDaoTao = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceLoaiHinhDaoTao = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboHocKy = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceHocKy = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboNamHoc = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceNamHoc = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDotThanhToan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDotThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiHinhDaoTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLoaiHinhDaoTao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNamHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnTiepTuc);
            this.layoutControl1.Controls.Add(this.btnThoat);
            this.layoutControl1.Controls.Add(this.cboDotThanhToan);
            this.layoutControl1.Controls.Add(this.cboLoaiHinhDaoTao);
            this.layoutControl1.Controls.Add(this.cboHocKy);
            this.layoutControl1.Controls.Add(this.cboNamHoc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(448, 95);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTiepTuc.Appearance.Options.UseFont = true;
            this.btnTiepTuc.Image = global::PMS.Properties.Resources.forward;
            this.btnTiepTuc.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnTiepTuc.Location = new System.Drawing.Point(226, 60);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(210, 23);
            this.btnTiepTuc.StyleController = this.layoutControl1;
            this.btnTiepTuc.TabIndex = 9;
            this.btnTiepTuc.Text = "Tiến tới";
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = global::PMS.Properties.Resources.delete;
            this.btnThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(12, 60);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(210, 23);
            this.btnThoat.StyleController = this.layoutControl1;
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboDotThanhToan
            // 
            this.cboDotThanhToan.Location = new System.Drawing.Point(315, 36);
            this.cboDotThanhToan.Name = "cboDotThanhToan";
            this.cboDotThanhToan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDotThanhToan.Properties.DataSource = this.bindingSourceDotThanhToan;
            this.cboDotThanhToan.Properties.View = this.gridView3;
            this.cboDotThanhToan.Size = new System.Drawing.Size(121, 20);
            this.cboDotThanhToan.StyleController = this.layoutControl1;
            this.cboDotThanhToan.TabIndex = 7;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // cboLoaiHinhDaoTao
            // 
            this.cboLoaiHinhDaoTao.Location = new System.Drawing.Point(101, 36);
            this.cboLoaiHinhDaoTao.Name = "cboLoaiHinhDaoTao";
            this.cboLoaiHinhDaoTao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiHinhDaoTao.Properties.DataSource = this.bindingSourceLoaiHinhDaoTao;
            this.cboLoaiHinhDaoTao.Properties.View = this.gridView2;
            this.cboLoaiHinhDaoTao.Size = new System.Drawing.Size(121, 20);
            this.cboLoaiHinhDaoTao.StyleController = this.layoutControl1;
            this.cboLoaiHinhDaoTao.TabIndex = 6;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // cboHocKy
            // 
            this.cboHocKy.Location = new System.Drawing.Point(315, 12);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHocKy.Properties.DataSource = this.bindingSourceHocKy;
            this.cboHocKy.Properties.View = this.gridView1;
            this.cboHocKy.Size = new System.Drawing.Size(121, 20);
            this.cboHocKy.StyleController = this.layoutControl1;
            this.cboHocKy.TabIndex = 5;
            this.cboHocKy.EditValueChanged += new System.EventHandler(this.cboHocKy_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Location = new System.Drawing.Point(101, 12);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNamHoc.Properties.DataSource = this.bindingSourceNamHoc;
            this.cboNamHoc.Properties.View = this.gridLookUpEdit1View;
            this.cboNamHoc.Size = new System.Drawing.Size(121, 20);
            this.cboNamHoc.StyleController = this.layoutControl1;
            this.cboNamHoc.TabIndex = 4;
            this.cboNamHoc.EditValueChanged += new System.EventHandler(this.cboNamHoc_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(448, 95);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboNamHoc;
            this.layoutControlItem1.CustomizationFormText = "Năm học:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(214, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(214, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(214, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Năm học:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(86, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboHocKy;
            this.layoutControlItem2.CustomizationFormText = "Học kỳ:";
            this.layoutControlItem2.Location = new System.Drawing.Point(214, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(214, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(214, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(214, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Học kỳ:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(86, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cboLoaiHinhDaoTao;
            this.layoutControlItem3.CustomizationFormText = "Loại hình đào tạo:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(214, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(214, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(214, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Loại hình đào tạo:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(86, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cboDotThanhToan;
            this.layoutControlItem4.CustomizationFormText = "Đợt thanh toán:";
            this.layoutControlItem4.Location = new System.Drawing.Point(214, 24);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(214, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(214, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(214, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Đợt thanh toán:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(86, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnThoat;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(214, 27);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(214, 27);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(214, 27);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnTiepTuc;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(214, 48);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(214, 27);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(214, 27);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(214, 27);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // frmChonDieuKienImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 95);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChonDieuKienImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn điều kiện import";
            this.Load += new System.EventHandler(this.frmChonDieuKienImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboDotThanhToan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDotThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiHinhDaoTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLoaiHinhDaoTao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNamHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnTiepTuc;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.GridLookUpEdit cboDotThanhToan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GridLookUpEdit cboLoaiHinhDaoTao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit cboHocKy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit cboNamHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource bindingSourceDotThanhToan;
        private System.Windows.Forms.BindingSource bindingSourceLoaiHinhDaoTao;
        private System.Windows.Forms.BindingSource bindingSourceHocKy;
        private System.Windows.Forms.BindingSource bindingSourceNamHoc;
    }
}