namespace PMS.UI.Forms.NghiepVu.ChucNangCon
{
    partial class frmChiTietLopHocPhanGhepSiSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietLopHocPhanGhepSiSo));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlLopGhep = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceChiTiet = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewLopGhep = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEditMaLopHocPhanChinh = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLopGhep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLopGhep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaLopHocPhanChinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlLopGhep);
            this.layoutControl1.Controls.Add(this.textEditMaLopHocPhanChinh);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(837, 321);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlLopGhep
            // 
            this.gridControlLopGhep.DataSource = this.bindingSourceChiTiet;
            this.gridControlLopGhep.Location = new System.Drawing.Point(12, 36);
            this.gridControlLopGhep.MainView = this.gridViewLopGhep;
            this.gridControlLopGhep.Name = "gridControlLopGhep";
            this.gridControlLopGhep.Size = new System.Drawing.Size(813, 273);
            this.gridControlLopGhep.TabIndex = 5;
            this.gridControlLopGhep.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLopGhep});
            // 
            // gridViewLopGhep
            // 
            this.gridViewLopGhep.GridControl = this.gridControlLopGhep;
            this.gridViewLopGhep.Name = "gridViewLopGhep";
            // 
            // textEditMaLopHocPhanChinh
            // 
            this.textEditMaLopHocPhanChinh.Location = new System.Drawing.Point(112, 12);
            this.textEditMaLopHocPhanChinh.Name = "textEditMaLopHocPhanChinh";
            this.textEditMaLopHocPhanChinh.Properties.ReadOnly = true;
            this.textEditMaLopHocPhanChinh.Size = new System.Drawing.Size(713, 20);
            this.textEditMaLopHocPhanChinh.StyleController = this.layoutControl1;
            this.textEditMaLopHocPhanChinh.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(837, 321);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEditMaLopHocPhanChinh;
            this.layoutControlItem1.CustomizationFormText = "Lớp học phần chính:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(817, 24);
            this.layoutControlItem1.Text = "Lớp học phần chính:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlLopGhep;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(817, 277);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmChiTietLopHocPhanGhepSiSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 321);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChiTietLopHocPhanGhepSiSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết lớp học phần ghép sĩ số";
            this.Load += new System.EventHandler(this.frmChiTietLopHocPhanGhepSiSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLopGhep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLopGhep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaLopHocPhanChinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceChiTiet;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControlLopGhep;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLopGhep;
        private DevExpress.XtraEditors.TextEdit textEditMaLopHocPhanChinh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}