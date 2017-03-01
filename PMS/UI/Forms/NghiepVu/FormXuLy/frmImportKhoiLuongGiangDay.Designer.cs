namespace PMS.UI.Forms.NghiepVu.FormXuLy
{
    partial class frmImportKhoiLuongGiangDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportKhoiLuongGiangDay));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtDotImport = new DevExpress.XtraEditors.TextEdit();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatCauTruc = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlImport = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceImport = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewImport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnChonFile = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDotImport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChonFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtDotImport);
            this.layoutControl1.Controls.Add(this.btnImport);
            this.layoutControl1.Controls.Add(this.btnXuatCauTruc);
            this.layoutControl1.Controls.Add(this.gridControlImport);
            this.layoutControl1.Controls.Add(this.btnChonFile);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1115, 613);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtDotImport
            // 
            this.txtDotImport.Location = new System.Drawing.Point(90, 36);
            this.txtDotImport.Name = "txtDotImport";
            this.txtDotImport.Size = new System.Drawing.Size(1013, 20);
            this.txtDotImport.StyleController = this.layoutControl1;
            this.txtDotImport.TabIndex = 8;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(947, 579);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(156, 22);
            this.btnImport.StyleController = this.layoutControl1;
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnXuatCauTruc
            // 
            this.btnXuatCauTruc.Location = new System.Drawing.Point(760, 579);
            this.btnXuatCauTruc.Name = "btnXuatCauTruc";
            this.btnXuatCauTruc.Size = new System.Drawing.Size(183, 22);
            this.btnXuatCauTruc.StyleController = this.layoutControl1;
            this.btnXuatCauTruc.TabIndex = 6;
            this.btnXuatCauTruc.Text = "Xuất file cấu trúc";
            this.btnXuatCauTruc.Visible = false;
            this.btnXuatCauTruc.Click += new System.EventHandler(this.btnXuatCauTruc_Click);
            // 
            // gridControlImport
            // 
            this.gridControlImport.DataSource = this.bindingSourceImport;
            this.gridControlImport.Location = new System.Drawing.Point(12, 60);
            this.gridControlImport.MainView = this.gridViewImport;
            this.gridControlImport.Name = "gridControlImport";
            this.gridControlImport.Size = new System.Drawing.Size(1091, 515);
            this.gridControlImport.TabIndex = 5;
            this.gridControlImport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewImport});
            // 
            // gridViewImport
            // 
            this.gridViewImport.GridControl = this.gridControlImport;
            this.gridViewImport.Name = "gridViewImport";
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(90, 12);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnChonFile.Size = new System.Drawing.Size(1013, 20);
            this.btnChonFile.StyleController = this.layoutControl1;
            this.btnChonFile.TabIndex = 4;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1115, 613);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnChonFile;
            this.layoutControlItem1.CustomizationFormText = "Chọn file excel:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1095, 24);
            this.layoutControlItem1.Text = "Chọn file excel:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlImport;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1095, 519);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 567);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(748, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnXuatCauTruc;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(748, 567);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(187, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnImport;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(935, 567);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(160, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtDotImport;
            this.layoutControlItem5.CustomizationFormText = "Đợt import:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1095, 24);
            this.layoutControlItem5.Text = "Đợt import:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(74, 13);
            // 
            // frmImportKhoiLuongGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 613);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImportKhoiLuongGiangDay";
            this.Text = "Import khối lượng giảng dạy";
            this.Load += new System.EventHandler(this.frmImportKhoiLuongGiangDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDotImport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChonFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnXuatCauTruc;
        private DevExpress.XtraGrid.GridControl gridControlImport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewImport;
        private DevExpress.XtraEditors.ButtonEdit btnChonFile;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bindingSourceImport;
        private DevExpress.XtraEditors.TextEdit txtDotImport;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}