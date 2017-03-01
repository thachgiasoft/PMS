namespace PMS.UI.Forms.NghiepVu.SauDaiHoc
{
    partial class frmXuLyQuyDoiGioiChuanUTE_SDH
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
            this.progressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblTenHoiDong = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(8, 49);
            this.progressBar.Name = "progressBar";
            this.progressBar.Properties.ShowTitle = true;
            this.progressBar.Size = new System.Drawing.Size(407, 13);
            this.progressBar.TabIndex = 0;
            this.progressBar.Visible = false;
            // 
            // lblTenHoiDong
            // 
            this.lblTenHoiDong.Location = new System.Drawing.Point(8, 9);
            this.lblTenHoiDong.Name = "lblTenHoiDong";
            this.lblTenHoiDong.Size = new System.Drawing.Size(50, 13);
            this.lblTenHoiDong.TabIndex = 2;
            this.lblTenHoiDong.Text = "User state";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.EditValue = "Đang xử lý...";
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(9, 24);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Properties.ShowTitle = true;
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(407, 18);
            this.marqueeProgressBarControl1.TabIndex = 4;
            // 
            // frmXuLyQuyDoiGioiChuanUTE_SDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 66);
            this.ControlBox = false;
            this.Controls.Add(this.marqueeProgressBarControl1);
            this.Controls.Add(this.lblTenHoiDong);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXuLyQuyDoiGioiChuanUTE_SDH";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đang xử lý...";
            this.Load += new System.EventHandler(this.frmXuLyQuyDoiGioiChuanUTE_SDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl progressBar;
        private DevExpress.XtraEditors.LabelControl lblTenHoiDong;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
    }
}