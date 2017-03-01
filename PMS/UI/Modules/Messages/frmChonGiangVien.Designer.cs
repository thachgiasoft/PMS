namespace PMS.UI.Modules.Messages
{
    partial class frmChonGiangVien
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnHoanTat = new DevExpress.XtraEditors.SimpleButton();
            this.cbbChonTatCa = new DevExpress.XtraEditors.SimpleButton();
            this.cbbLoaiGiangVien = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.gridControlChonGiangVien = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceChonGiangVien = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewChonGiangVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbbKhoaDonVi = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiGiangVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChonGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChonGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChonGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbKhoaDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnHoanTat);
            this.layoutControl1.Controls.Add(this.cbbChonTatCa);
            this.layoutControl1.Controls.Add(this.cbbLoaiGiangVien);
            this.layoutControl1.Controls.Add(this.gridControlChonGiangVien);
            this.layoutControl1.Controls.Add(this.cbbKhoaDonVi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(679, 507);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(468, 12);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(96, 22);
            this.btnHoanTat.StyleController = this.layoutControl1;
            this.btnHoanTat.TabIndex = 8;
            this.btnHoanTat.Text = "Hoàn Tất";
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // cbbChonTatCa
            // 
            this.cbbChonTatCa.Location = new System.Drawing.Point(366, 12);
            this.cbbChonTatCa.Name = "cbbChonTatCa";
            this.cbbChonTatCa.Size = new System.Drawing.Size(98, 22);
            this.cbbChonTatCa.StyleController = this.layoutControl1;
            this.cbbChonTatCa.TabIndex = 7;
            this.cbbChonTatCa.Text = "Chọn tất cả";
            this.cbbChonTatCa.Click += new System.EventHandler(this.cbbChonTatCa_Click);
            // 
            // cbbLoaiGiangVien
            // 
            this.cbbLoaiGiangVien.Location = new System.Drawing.Point(274, 12);
            this.cbbLoaiGiangVien.Name = "cbbLoaiGiangVien";
            this.cbbLoaiGiangVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbLoaiGiangVien.Size = new System.Drawing.Size(88, 20);
            this.cbbLoaiGiangVien.StyleController = this.layoutControl1;
            this.cbbLoaiGiangVien.TabIndex = 6;
            this.cbbLoaiGiangVien.EditValueChanged += new System.EventHandler(this.cbbLoaiGiangVien_EditValueChanged);
            // 
            // gridControlChonGiangVien
            // 
            this.gridControlChonGiangVien.DataSource = this.bindingSourceChonGiangVien;
            this.gridControlChonGiangVien.Location = new System.Drawing.Point(12, 38);
            this.gridControlChonGiangVien.MainView = this.gridViewChonGiangVien;
            this.gridControlChonGiangVien.Name = "gridControlChonGiangVien";
            this.gridControlChonGiangVien.Size = new System.Drawing.Size(655, 457);
            this.gridControlChonGiangVien.TabIndex = 5;
            this.gridControlChonGiangVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChonGiangVien});
            // 
            // gridViewChonGiangVien
            // 
            this.gridViewChonGiangVien.GridControl = this.gridControlChonGiangVien;
            this.gridViewChonGiangVien.Name = "gridViewChonGiangVien";
            this.gridViewChonGiangVien.OptionsSelection.MultiSelect = true;
            // 
            // cbbKhoaDonVi
            // 
            this.cbbKhoaDonVi.Location = new System.Drawing.Point(86, 12);
            this.cbbKhoaDonVi.Name = "cbbKhoaDonVi";
            this.cbbKhoaDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbKhoaDonVi.Size = new System.Drawing.Size(110, 20);
            this.cbbKhoaDonVi.StyleController = this.layoutControl1;
            this.cbbKhoaDonVi.TabIndex = 4;
            this.cbbKhoaDonVi.EditValueChanged += new System.EventHandler(this.cbbKhoaDonVi_EditValueChanged);
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
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(679, 507);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbbKhoaDonVi;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(188, 26);
            this.layoutControlItem1.Text = "Khoa - đơn vị";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlChonGiangVien;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(659, 461);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbbLoaiGiangVien;
            this.layoutControlItem3.CustomizationFormText = "Loại giảng viên";
            this.layoutControlItem3.Location = new System.Drawing.Point(188, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(166, 26);
            this.layoutControlItem3.Text = "Loại giảng viên";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbbChonTatCa;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(354, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(102, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnHoanTat;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(456, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(556, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(103, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmChonGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 507);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmChonGiangVien";
            this.Text = "frmChonGiangVien";
            this.Load += new System.EventHandler(this.frmChonGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiGiangVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChonGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChonGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChonGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbKhoaDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnHoanTat;
        private DevExpress.XtraEditors.SimpleButton cbbChonTatCa;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbbLoaiGiangVien;
        private DevExpress.XtraGrid.GridControl gridControlChonGiangVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChonGiangVien;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbbKhoaDonVi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource bindingSourceChonGiangVien;
    }
}