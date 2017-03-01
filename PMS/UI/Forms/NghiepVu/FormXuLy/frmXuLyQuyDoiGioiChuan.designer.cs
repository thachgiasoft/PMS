namespace PMS.UI.Forms.NghiepVu
{
    partial class frmXuLyQuyDoiGioiChuan
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
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(8, 28);
            this.progressBar.Name = "progressBar";
            this.progressBar.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.progressBar.Properties.ShowTitle = true;
            this.progressBar.Size = new System.Drawing.Size(450, 20);
            this.progressBar.TabIndex = 0;
            // 
            // lblTenHoiDong
            // 
            this.lblTenHoiDong.Location = new System.Drawing.Point(8, 9);
            this.lblTenHoiDong.Name = "lblTenHoiDong";
            this.lblTenHoiDong.Size = new System.Drawing.Size(18, 13);
            this.lblTenHoiDong.TabIndex = 2;
            this.lblTenHoiDong.Text = ". . .";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // frmXuLyQuyDoiGioiChuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 57);
            this.ControlBox = false;
            this.Controls.Add(this.lblTenHoiDong);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXuLyQuyDoiGioiChuan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đang xử lý...";
            this.Load += new System.EventHandler(this.frmXuLyTinhThanhToanGioGiang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl progressBar;
        private DevExpress.XtraEditors.LabelControl lblTenHoiDong;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}