using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace DevExpress.Common.SQLHelper
{
    public class Helper
    {
        private OleDbConnection cn;

        public Helper(string connectionString) { cn = new OleDbConnection(connectionString); }

        /// <summary>
        /// Open connection
        /// </summary>
        private void OpenConnection()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
        }

        /// <summary>
        /// Close connection
        /// </summary>
        private void CloseConnection()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }

        /// <summary>
        /// Get data from Schema
        /// </summary>
        /// <returns></returns>
        public DataTable GetOleDbSchemaTable()
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                dt = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            }
            catch (OleDbException) { return null; }
            finally
            {
                CloseConnection();
            } return dt;
        }

        /// <summary>
        /// Fill data to datatable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable FillDataTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                using (OleDbCommand cmd = new OleDbCommand(sql, cn) { CommandType = CommandType.Text })
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

            }
            catch (OleDbException ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }
            return dt;
        }

        /// <summary>
        /// Execute sql
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExcuteSQL(string sql)
        {
            try
            {
                OpenConnection();
                using (OleDbCommand cmd = new OleDbCommand(sql, cn) { CommandType = CommandType.Text })
                {
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (OleDbException ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }
        }
        
    }

    public class SqlHelper
    {
        private SqlConnection cn;

        public SqlHelper(string connectionString) { cn = new SqlConnection(connectionString); }

        /// <summary>
        /// Mo ket noi
        /// </summary>
        private void OpenConnection()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
        }

        /// <summary>
        /// Dong ket noi
        /// </summary>
        private void CloseConnection()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }

        /// <summary>
        /// Kiem tra ket noi
        /// </summary>
        public bool IsConnection
        {
            get { return CheckConnection(); }
        }

        /// <summary>
        /// Kiem tra ket noi
        /// </summary>
        /// <returns></returns>
        public bool CheckConnection()
        {
            try
            {
                OpenConnection();
                if (cn.State == ConnectionState.Open)
                    return true;
            }
            catch (SqlException ex) 
            {
                string filepath = Directory.GetCurrentDirectory() + "\\PMS_LOG.txt";
                    //filepath = @"C:\LOG_UISERVICE.txt";
                string log = ex.Message;
                FileStream fs;
                if (!File.Exists(filepath))
                {
                    // Create the file.
                    fs = File.Create(filepath);
                    fs.Close();
                }

                //Open file
                fs = File.Open(filepath, FileMode.Append, FileAccess.Write);

                StreamWriter swFromFileStream = new StreamWriter(fs);
                log = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss    ") + log;
                swFromFileStream.WriteLine(log);
                swFromFileStream.Flush();
                swFromFileStream.Close();
                fs.Close();
            }
            finally { CloseConnection(); }
            return false;
        }
    }
}
