using System;
using System.Windows.Forms;
using DevExpress.Common.SQLHelper;
using DevExpress.Common.Config;
using DevExpress.XtraEditors;
using PMS.Data.SqlClient;
using PMS.Data;
using System.Collections.Specialized;

namespace PMS.UI.Forms.HeThong
{
    public partial class frmConfig : XtraForm
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Configuration sql provider for application.
        /// </summary>
        /// <param name="connectionString"></param>
        private static void DynamidConfiguration(string connectionString)
        {
            SqlNetTiersProvider provider = new SqlNetTiersProvider();
            NameValueCollection collection = new NameValueCollection();
            collection.Add("UseStoredProcedure", "true");
            collection.Add("EnableEntityTracking", "false");
            collection.Add("EntityCreationalFactoryType", "PMS.Entities.EntityFactory");
            collection.Add("EnableMethodAuthorization", "false");
            collection.Add("ConnectionString", connectionString);
            collection.Add("ConnectionStringName", "netTiersConnectionString");
            collection.Add("ProviderInvariantName", "System.Data.SqlClient");
            provider.Initialize("SqlNetTiersProvider", collection);
            DataRepository.LoadProvider(provider, true);
        }

        /// <summary>
        /// Save connectionstring for application.
        /// </summary>
        private void SaveConfig()
        {
            SqlHelper helper;
            string ConnectionString = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cboServer.Text.Trim(), txtCatalog.Text, txtUserName.Text.Trim(), txtPassword.Text.Trim());
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                ConnectionString = String.Format("Data Source={0};Initial Catalog={1}; Integrated Security=true;", cboServer.Text.Trim(), txtCatalog.Text);
                helper = new SqlHelper(ConnectionString);
                if (helper.CheckConnection())
                {
                    XtraMessageBox.Show("Bạn đã cấu hình kết nối đến Sever thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AppConnection.ConnectionString = ConnectionString;
                    DynamidConfiguration(ConnectionString);
                    Close();
                }
                else
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình kết nối đến Server.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                helper = new SqlHelper(ConnectionString);
                if (helper.CheckConnection())
                {
                    XtraMessageBox.Show("Bạn đã cấu hình kết nối đến Sever thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AppConnection.ConnectionString = ConnectionString;
                    DynamidConfiguration(ConnectionString);
                    Close();
                }
                else
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình kết nối đến Server.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            cboServer.Properties.Items.Add(".");
            cboServer.Properties.Items.Add("(local)");
            cboServer.Properties.Items.Add(@".\SQLEXPRESS");
            cboServer.Properties.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cboServer.SelectedIndex = 3;
        }

        private void txtCatalog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtUserName.Focus();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SaveConfig();
        }
    }
}