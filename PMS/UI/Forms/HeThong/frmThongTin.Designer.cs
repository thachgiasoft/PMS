namespace PMS.UI.Forms.HeThong
{
    partial class frmThongTin
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblUser = new DevExpress.XtraEditors.LabelControl();
            this.linkDoiMatKhau = new System.Windows.Forms.LinkLabel();
            this.lblThoiGian = new DevExpress.XtraEditors.LabelControl();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lblNhomQuyen = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bindingSourceNamHoc = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceHocKy = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNamHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHocKy)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblUser);
            this.panelControl1.Controls.Add(this.linkDoiMatKhau);
            this.panelControl1.Controls.Add(this.lblThoiGian);
            this.panelControl1.Controls.Add(this.lblHoTen);
            this.panelControl1.Controls.Add(this.lblNhomQuyen);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(205, 166);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(276, 122);
            this.panelControl1.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(90, 15);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "Admin";
            // 
            // linkDoiMatKhau
            // 
            this.linkDoiMatKhau.AutoSize = true;
            this.linkDoiMatKhau.Location = new System.Drawing.Point(195, 95);
            this.linkDoiMatKhau.Name = "linkDoiMatKhau";
            this.linkDoiMatKhau.Size = new System.Drawing.Size(70, 13);
            this.linkDoiMatKhau.TabIndex = 8;
            this.linkDoiMatKhau.TabStop = true;
            this.linkDoiMatKhau.Text = "Đổi mật khẩu";
            this.linkDoiMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDoiMatKhau_LinkClicked);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Location = new System.Drawing.Point(90, 75);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(121, 13);
            this.lblThoiGian.TabIndex = 7;
            this.lblThoiGian.Text = "03/09/2010 01:20:30 AM";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(91, 55);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(29, 13);
            this.lblHoTen.TabIndex = 6;
            this.lblHoTen.Text = "Admin";
            // 
            // lblNhomQuyen
            // 
            this.lblNhomQuyen.Location = new System.Drawing.Point(90, 35);
            this.lblNhomQuyen.Name = "lblNhomQuyen";
            this.lblNhomQuyen.Size = new System.Drawing.Size(64, 13);
            this.lblNhomQuyen.TabIndex = 5;
            this.lblNhomQuyen.Text = "Administrator";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 75);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Thời gian:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Họ tên:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nhóm quyền:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên truy cập:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.44125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.55875F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.83908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.16092F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 476);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // frmThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 476);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmThongTin";
            this.Text = "Thông tin người dùng";
            this.Load += new System.EventHandler(this.frmThongTin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNamHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHocKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblUser;
        private System.Windows.Forms.LinkLabel linkDoiMatKhau;
        private DevExpress.XtraEditors.LabelControl lblThoiGian;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraEditors.LabelControl lblNhomQuyen;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.BindingSource bindingSourceNamHoc;
        public System.Windows.Forms.BindingSource bindingSourceHocKy;

    }
}