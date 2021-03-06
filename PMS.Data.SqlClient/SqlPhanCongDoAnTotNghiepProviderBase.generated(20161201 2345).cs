﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file SqlPhanCongDoAnTotNghiepProvider.cs instead.
*/

#region using directives

using System;
using System.Data;
using System.Data.Common;
using System.Text;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

using System.Collections;
using System.Collections.Specialized;

using System.Diagnostics;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;

#endregion

namespace PMS.Data.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="PhanCongDoAnTotNghiep"/> entity.
	///</summary>
	public abstract partial class SqlPhanCongDoAnTotNghiepProviderBase : PhanCongDoAnTotNghiepProviderBase
	{
		#region Declarations
		
		string _connectionString;
	    bool _useStoredProcedure;
	    string _providerInvariantName;
			
		#endregion "Declarations"
			
		#region Constructors
		
		/// <summary>
		/// Creates a new <see cref="SqlPhanCongDoAnTotNghiepProviderBase"/> instance.
		/// </summary>
		public SqlPhanCongDoAnTotNghiepProviderBase()
		{
		}
	
	/// <summary>
	/// Creates a new <see cref="SqlPhanCongDoAnTotNghiepProviderBase"/> instance.
	/// Uses connection string to connect to datasource.
	/// </summary>
	/// <param name="connectionString">The connection string to the database.</param>
	/// <param name="useStoredProcedure">A boolean value that indicates if we should use stored procedures or embedded queries.</param>
	/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
	public SqlPhanCongDoAnTotNghiepProviderBase(string connectionString, bool useStoredProcedure, string providerInvariantName)
	{
		this._connectionString = connectionString;
		this._useStoredProcedure = useStoredProcedure;
		this._providerInvariantName = providerInvariantName;
	}
		
	#endregion "Constructors"
	
		#region Public properties
	/// <summary>
    /// Gets or sets the connection string.
    /// </summary>
    /// <value>The connection string.</value>
    public string ConnectionString
	{
		get {return this._connectionString;}
		set {this._connectionString = value;}
	}
	
	/// <summary>
    /// Gets or sets a value indicating whether to use stored procedures.
    /// </summary>
    /// <value><c>true</c> if we choose to use use stored procedures; otherwise, <c>false</c>.</value>
	public bool UseStoredProcedure
	{
		get {return this._useStoredProcedure;}
		set {this._useStoredProcedure = value;}
	}
	
	/// <summary>
    /// Gets or sets the invariant provider name listed in the DbProviderFactories machine.config section.
    /// </summary>
    /// <value>The name of the provider invariant.</value>
    public string ProviderInvariantName
    {
        get { return this._providerInvariantName; }
        set { this._providerInvariantName = value; }
    }
	#endregion
	
		#region Get Many To Many Relationship Functions
		#endregion
	
		#region Delete Functions
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLopHocPhan">. Primary Key.</param>	
		/// <param name="_maSinhVien">. Primary Key.</param>	
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Delete(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _maSinhVien)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_PhanCongDoAnTotNghiep_Delete", _useStoredProcedure);
			database.AddInParameter(commandWrapper, "@MaLopHocPhan", DbType.AnsiString, _maLopHocPhan);
			database.AddInParameter(commandWrapper, "@MaSinhVien", DbType.AnsiString, _maSinhVien);
			
			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Delete")); 

			int results = 0;
			
			if (transactionManager != null)
			{	
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}
			
			//Stop Tracking Now that it has been updated and persisted.
			if (DataRepository.Provider.EnableEntityTracking)
			{
				string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(PhanCongDoAnTotNghiep)
					,_maLopHocPhan,_maSinhVien);
                EntityManager.StopTracking(entityKey);
                
			}
			
			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Delete")); 

			commandWrapper = null;
			
			return Convert.ToBoolean(results);
		}//end Delete
		#endregion

		#region Find Functions

		#region Parsed Find Methods
		/// <summary>
		/// 	Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <remarks>Operators must be capitalized (OR, AND).</remarks>
		/// <returns>Returns a typed collection of PMS.Entities.PhanCongDoAnTotNghiep objects.</returns>
		public override TList<PhanCongDoAnTotNghiep> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
		{
			count = -1;
			if (whereClause.IndexOf(";") > -1)
				return new TList<PhanCongDoAnTotNghiep>();
	
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_PhanCongDoAnTotNghiep_Find", _useStoredProcedure);

		bool searchUsingOR = false;
		if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
			searchUsingOR = true;
		
		database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);
		
		database.AddInParameter(commandWrapper, "@MaLopHocPhan", DbType.AnsiString, DBNull.Value);
		database.AddInParameter(commandWrapper, "@MaSinhVien", DbType.AnsiString, DBNull.Value);
		database.AddInParameter(commandWrapper, "@HoTen", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@GiangVienHuongDan", DbType.Int32, DBNull.Value);
		database.AddInParameter(commandWrapper, "@GiangVienPhanBien1", DbType.Int32, DBNull.Value);
		database.AddInParameter(commandWrapper, "@GiangVienPhanBien2", DbType.Int32, DBNull.Value);
		database.AddInParameter(commandWrapper, "@GhiChu", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@NgayCapNhat", DbType.DateTime, DBNull.Value);
	
			// replace all instances of 'AND' and 'OR' because we already set searchUsingOR
			whereClause = whereClause.Replace(" AND ", "|").Replace(" OR ", "|") ; 
			string[] clauses = whereClause.ToLower().Split('|');
		
			// Here's what's going on below: Find a field, then to get the value we
			// drop the field name from the front, trim spaces, drop the '=' sign,
			// trim more spaces, and drop any outer single quotes.
			// Now handles the case when two fields start off the same way - like "Friendly='Yes' AND Friend='john'"
				
			char[] equalSign = {'='};
			char[] singleQuote = {'\''};
	   		foreach (string clause in clauses)
			{
				if (clause.Trim().StartsWith("malophocphan ") || clause.Trim().StartsWith("malophocphan="))
				{
					database.SetParameterValue(commandWrapper, "@MaLopHocPhan", 
						clause.Trim().Remove(0,12).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("masinhvien ") || clause.Trim().StartsWith("masinhvien="))
				{
					database.SetParameterValue(commandWrapper, "@MaSinhVien", 
						clause.Trim().Remove(0,10).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("hoten ") || clause.Trim().StartsWith("hoten="))
				{
					database.SetParameterValue(commandWrapper, "@HoTen", 
						clause.Trim().Remove(0,5).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("giangvienhuongdan ") || clause.Trim().StartsWith("giangvienhuongdan="))
				{
					database.SetParameterValue(commandWrapper, "@GiangVienHuongDan", 
						clause.Trim().Remove(0,17).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("giangvienphanbien1 ") || clause.Trim().StartsWith("giangvienphanbien1="))
				{
					database.SetParameterValue(commandWrapper, "@GiangVienPhanBien1", 
						clause.Trim().Remove(0,18).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("giangvienphanbien2 ") || clause.Trim().StartsWith("giangvienphanbien2="))
				{
					database.SetParameterValue(commandWrapper, "@GiangVienPhanBien2", 
						clause.Trim().Remove(0,18).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("ghichu ") || clause.Trim().StartsWith("ghichu="))
				{
					database.SetParameterValue(commandWrapper, "@GhiChu", 
						clause.Trim().Remove(0,6).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("ngaycapnhat ") || clause.Trim().StartsWith("ngaycapnhat="))
				{
					database.SetParameterValue(commandWrapper, "@NgayCapNhat", 
						clause.Trim().Remove(0,11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
	
				throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
			}
					
			IDataReader reader = null;
			//Create Collection
			TList<PhanCongDoAnTotNghiep> rows = new TList<PhanCongDoAnTotNghiep>();
	
				
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "Find", rows)); 

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}		
				
				Fill(reader, rows, start, pageLength);
				
				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "Find", rows)); 
			}
			finally
			{
				if (reader != null) 
					reader.Close();	
					
				commandWrapper = null;
			}
			return rows;
		}

		#endregion Parsed Find Methods
		
		#region Parameterized Find Methods
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <returns>Returns a typed collection of PMS.Entities.PhanCongDoAnTotNghiep objects.</returns>
		public override TList<PhanCongDoAnTotNghiep> Find(TransactionManager transactionManager, IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			SqlFilterParameterCollection filter = null;
			
			if (parameters == null)
				filter = new SqlFilterParameterCollection();
			else 
				filter = parameters.GetParameters();
				
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_PhanCongDoAnTotNghiep_Find_Dynamic", typeof(PhanCongDoAnTotNghiepColumn), filter, orderBy, start, pageLength);
		
			SqlFilterParameter param;

			for ( int i = 0; i < filter.Count; i++ )
			{
				param = filter[i];
				database.AddInParameter(commandWrapper, param.Name, param.DbType, param.GetValue());
			}

			TList<PhanCongDoAnTotNghiep> rows = new TList<PhanCongDoAnTotNghiep>();
			IDataReader reader = null;
			
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "Find", rows)); 

				if ( transactionManager != null )
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}
				
				Fill(reader, rows, 0, int.MaxValue);
				count = rows.Count;
				
				if ( reader.NextResult() )
				{
					if ( reader.Read() )
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "Find", rows)); 
			}
			finally
			{
				if ( reader != null )
					reader.Close();
					
				commandWrapper = null;
			}
			
			return rows;
		}
		
		#endregion Parameterized Find Methods
		
		#endregion Find Functions
	
		#region GetAll Methods
				
		/// <summary>
		/// 	Gets All rows from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.PhanCongDoAnTotNghiep objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<PhanCongDoAnTotNghiep> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_PhanCongDoAnTotNghiep_Get_List", _useStoredProcedure);
			
			IDataReader reader = null;
		
			//Create Collection
			TList<PhanCongDoAnTotNghiep> rows = new TList<PhanCongDoAnTotNghiep>();
			
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAll", rows)); 
					
				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}		
		
				Fill(reader, rows, start, pageLength);
				count = -1;
				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows)); 
			}
			finally 
			{
				if (reader != null) 
					reader.Close();
					
				commandWrapper = null;	
			}
			return rows;
		}//end getall
		
		#endregion
				
		#region GetPaged Methods
				
		/// <summary>
		/// Gets a page of rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">Number of rows in the DataSource.</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.PhanCongDoAnTotNghiep objects.</returns>
		public override TList<PhanCongDoAnTotNghiep> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_PhanCongDoAnTotNghiep_GetPaged", _useStoredProcedure);
		
			
            if (commandWrapper.CommandType == CommandType.Text
                && commandWrapper.CommandText != null)
            {
                commandWrapper.CommandText = commandWrapper.CommandText.Replace(SqlUtil.PAGE_INDEX, string.Concat(SqlUtil.PAGE_INDEX, Guid.NewGuid().ToString("N").Substring(0, 8)));
            }
			
			database.AddInParameter(commandWrapper, "@WhereClause", DbType.String, whereClause);
			database.AddInParameter(commandWrapper, "@OrderBy", DbType.String, orderBy);
			database.AddInParameter(commandWrapper, "@PageIndex", DbType.Int32, start);
			database.AddInParameter(commandWrapper, "@PageSize", DbType.Int32, pageLength);
		
			IDataReader reader = null;
			//Create Collection
			TList<PhanCongDoAnTotNghiep> rows = new TList<PhanCongDoAnTotNghiep>();
			
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetPaged", rows)); 

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}
				
				Fill(reader, rows, 0, int.MaxValue);
				count = rows.Count;

				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetPaged", rows)); 

			}
			catch(Exception)
			{			
				throw;
			}
			finally
			{
				if (reader != null) 
					reader.Close();
				
				commandWrapper = null;
			}
			
			return rows;
		}
		
		#endregion	
		
		#region Get By Foreign Key Functions
	#endregion
	
		#region Get By Index Functions

		#region GetByMaLopHocPhanMaSinhVien
					
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanCongDoAnTotNghiep index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maSinhVien"></param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanCongDoAnTotNghiep"/> class.</returns>
		/// <remarks></remarks>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override PMS.Entities.PhanCongDoAnTotNghiep GetByMaLopHocPhanMaSinhVien(TransactionManager transactionManager, System.String _maLopHocPhan, System.String _maSinhVien, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_PhanCongDoAnTotNghiep_GetByMaLopHocPhanMaSinhVien", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@MaLopHocPhan", DbType.AnsiString, _maLopHocPhan);
				database.AddInParameter(commandWrapper, "@MaSinhVien", DbType.AnsiString, _maSinhVien);
			
			IDataReader reader = null;
			TList<PhanCongDoAnTotNghiep> tmp = new TList<PhanCongDoAnTotNghiep>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByMaLopHocPhanMaSinhVien", tmp)); 

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}		
		
				//Create collection and fill
				Fill(reader, tmp, start, pageLength);
				count = -1;
				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetByMaLopHocPhanMaSinhVien", tmp));
			}
			finally 
			{
				if (reader != null) 
					reader.Close();
					
				commandWrapper = null;
			}
			
			if (tmp.Count == 1)
			{
				return tmp[0];
			}
			else if (tmp.Count == 0)
			{
				return null;
			}
			else
			{
				throw new DataException("Cannot find the unique instance of the class.");
			}
			
			//return rows;
		}
		
		#endregion

	#endregion Get By Index Functions

		#region Insert Methods
		/// <summary>
		/// Lets you efficiently bulk insert many entities to the database.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entities">The entities.</param>
		/// <remarks>
		///		After inserting into the datasource, the PMS.Entities.PhanCongDoAnTotNghiep object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		public override void BulkInsert(TransactionManager transactionManager, TList<PMS.Entities.PhanCongDoAnTotNghiep> entities)
		{
			//System.Data.SqlClient.SqlBulkCopy bulkCopy = new System.Data.SqlClient.SqlBulkCopy(this._connectionString, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints); //, null);
			
			System.Data.SqlClient.SqlBulkCopy bulkCopy = null;
	
			if (transactionManager != null && transactionManager.IsOpen)
			{			
				System.Data.SqlClient.SqlConnection cnx = transactionManager.TransactionObject.Connection as System.Data.SqlClient.SqlConnection;
				System.Data.SqlClient.SqlTransaction transaction = transactionManager.TransactionObject as System.Data.SqlClient.SqlTransaction;
				bulkCopy = new System.Data.SqlClient.SqlBulkCopy(cnx, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints, transaction); //, null);
			}
			else
			{
				bulkCopy = new System.Data.SqlClient.SqlBulkCopy(this._connectionString, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints); //, null);
			}
			
			bulkCopy.BulkCopyTimeout = 360;
			bulkCopy.DestinationTableName = "PhanCongDoAnTotNghiep";
			
			DataTable dataTable = new DataTable();
			DataColumn col0 = dataTable.Columns.Add("MaLopHocPhan", typeof(System.String));
			col0.AllowDBNull = false;		
			DataColumn col1 = dataTable.Columns.Add("MaSinhVien", typeof(System.String));
			col1.AllowDBNull = false;		
			DataColumn col2 = dataTable.Columns.Add("HoTen", typeof(System.String));
			col2.AllowDBNull = true;		
			DataColumn col3 = dataTable.Columns.Add("GiangVienHuongDan", typeof(System.Int32));
			col3.AllowDBNull = true;		
			DataColumn col4 = dataTable.Columns.Add("GiangVienPhanBien1", typeof(System.Int32));
			col4.AllowDBNull = true;		
			DataColumn col5 = dataTable.Columns.Add("GiangVienPhanBien2", typeof(System.Int32));
			col5.AllowDBNull = true;		
			DataColumn col6 = dataTable.Columns.Add("GhiChu", typeof(System.String));
			col6.AllowDBNull = true;		
			DataColumn col7 = dataTable.Columns.Add("NgayCapNhat", typeof(System.DateTime));
			col7.AllowDBNull = true;		
			
			bulkCopy.ColumnMappings.Add("MaLopHocPhan", "MaLopHocPhan");
			bulkCopy.ColumnMappings.Add("MaSinhVien", "MaSinhVien");
			bulkCopy.ColumnMappings.Add("HoTen", "HoTen");
			bulkCopy.ColumnMappings.Add("GiangVienHuongDan", "GiangVienHuongDan");
			bulkCopy.ColumnMappings.Add("GiangVienPhanBien1", "GiangVienPhanBien1");
			bulkCopy.ColumnMappings.Add("GiangVienPhanBien2", "GiangVienPhanBien2");
			bulkCopy.ColumnMappings.Add("GhiChu", "GhiChu");
			bulkCopy.ColumnMappings.Add("NgayCapNhat", "NgayCapNhat");
			
			foreach(PMS.Entities.PhanCongDoAnTotNghiep entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
					
				DataRow row = dataTable.NewRow();
				
					row["MaLopHocPhan"] = entity.MaLopHocPhan;
							
				
					row["MaSinhVien"] = entity.MaSinhVien;
							
				
					row["HoTen"] = entity.HoTen;
							
				
					row["GiangVienHuongDan"] = entity.GiangVienHuongDan.HasValue ? (object) entity.GiangVienHuongDan  : System.DBNull.Value;
							
				
					row["GiangVienPhanBien1"] = entity.GiangVienPhanBien1.HasValue ? (object) entity.GiangVienPhanBien1  : System.DBNull.Value;
							
				
					row["GiangVienPhanBien2"] = entity.GiangVienPhanBien2.HasValue ? (object) entity.GiangVienPhanBien2  : System.DBNull.Value;
							
				
					row["GhiChu"] = entity.GhiChu;
							
				
					row["NgayCapNhat"] = entity.NgayCapNhat.HasValue ? (object) entity.NgayCapNhat  : System.DBNull.Value;
							
				
				dataTable.Rows.Add(row);
			}		
			
			// send the data to the server		
			bulkCopy.WriteToServer(dataTable);		
			
			// update back the state
			foreach(PMS.Entities.PhanCongDoAnTotNghiep entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
			
				entity.AcceptChanges();
			}
		}
				
		/// <summary>
		/// 	Inserts a PMS.Entities.PhanCongDoAnTotNghiep object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">PMS.Entities.PhanCongDoAnTotNghiep object to insert.</param>
		/// <remarks>
		///		After inserting into the datasource, the PMS.Entities.PhanCongDoAnTotNghiep object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Insert(TransactionManager transactionManager, PMS.Entities.PhanCongDoAnTotNghiep entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_PhanCongDoAnTotNghiep_Insert", _useStoredProcedure);
			
            database.AddInParameter(commandWrapper, "@MaLopHocPhan", DbType.AnsiString, entity.MaLopHocPhan );
            database.AddInParameter(commandWrapper, "@MaSinhVien", DbType.AnsiString, entity.MaSinhVien );
            database.AddInParameter(commandWrapper, "@HoTen", DbType.String, entity.HoTen );
			database.AddInParameter(commandWrapper, "@GiangVienHuongDan", DbType.Int32, (entity.GiangVienHuongDan.HasValue ? (object) entity.GiangVienHuongDan  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@GiangVienPhanBien1", DbType.Int32, (entity.GiangVienPhanBien1.HasValue ? (object) entity.GiangVienPhanBien1  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@GiangVienPhanBien2", DbType.Int32, (entity.GiangVienPhanBien2.HasValue ? (object) entity.GiangVienPhanBien2  : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GhiChu", DbType.String, entity.GhiChu );
			database.AddInParameter(commandWrapper, "@NgayCapNhat", DbType.DateTime, (entity.NgayCapNhat.HasValue ? (object) entity.NgayCapNhat  : System.DBNull.Value));
			
			int results = 0;
			
			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert", entity));
				
			if (transactionManager != null)
			{
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}
					
			
			entity.OriginalMaLopHocPhan = entity.MaLopHocPhan;
			entity.OriginalMaSinhVien = entity.MaSinhVien;
			
			entity.AcceptChanges();
	
			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

			return Convert.ToBoolean(results);
		}	
		#endregion

		#region Update Methods
				
		/// <summary>
		/// 	Update an existing row in the datasource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">PMS.Entities.PhanCongDoAnTotNghiep object to update.</param>
		/// <remarks>
		///		After updating the datasource, the PMS.Entities.PhanCongDoAnTotNghiep object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Update(TransactionManager transactionManager, PMS.Entities.PhanCongDoAnTotNghiep entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.sp_PhanCongDoAnTotNghiep_Update", _useStoredProcedure);
			
            database.AddInParameter(commandWrapper, "@MaLopHocPhan", DbType.AnsiString, entity.MaLopHocPhan );
			database.AddInParameter(commandWrapper, "@OriginalMaLopHocPhan", DbType.AnsiString, entity.OriginalMaLopHocPhan);
            database.AddInParameter(commandWrapper, "@MaSinhVien", DbType.AnsiString, entity.MaSinhVien );
			database.AddInParameter(commandWrapper, "@OriginalMaSinhVien", DbType.AnsiString, entity.OriginalMaSinhVien);
            database.AddInParameter(commandWrapper, "@HoTen", DbType.String, entity.HoTen );
			database.AddInParameter(commandWrapper, "@GiangVienHuongDan", DbType.Int32, (entity.GiangVienHuongDan.HasValue ? (object) entity.GiangVienHuongDan : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@GiangVienPhanBien1", DbType.Int32, (entity.GiangVienPhanBien1.HasValue ? (object) entity.GiangVienPhanBien1 : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@GiangVienPhanBien2", DbType.Int32, (entity.GiangVienPhanBien2.HasValue ? (object) entity.GiangVienPhanBien2 : System.DBNull.Value) );
            database.AddInParameter(commandWrapper, "@GhiChu", DbType.String, entity.GhiChu );
			database.AddInParameter(commandWrapper, "@NgayCapNhat", DbType.DateTime, (entity.NgayCapNhat.HasValue ? (object) entity.NgayCapNhat : System.DBNull.Value) );
			
			int results = 0;
			
			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Update", entity));

			if (transactionManager != null)
			{
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}
			
			//Stop Tracking Now that it has been updated and persisted.
			if (DataRepository.Provider.EnableEntityTracking)
            {
                EntityManager.StopTracking(entity.EntityTrackingKey);				
            }
			
			entity.OriginalMaLopHocPhan = entity.MaLopHocPhan;
			entity.OriginalMaSinhVien = entity.MaSinhVien;
			
			entity.AcceptChanges();
			
			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

			return Convert.ToBoolean(results);
		}
			
		#endregion
		
		#region Custom Methods
	

		#region cust_PhanCongDoAnTotNghiep_GetByMaLopHocPhan
					
		/// <summary>
		///	This method wraps the 'cust_PhanCongDoAnTotNghiep_GetByMaLopHocPhan' stored procedure. 
		/// </summary>	
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object.</param>
		/// <remark>This method is generated from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;PhanCongDoAnTotNghiep&gt;"/> instance.</returns>
		public override TList<PhanCongDoAnTotNghiep> GetByMaLopHocPhan(TransactionManager transactionManager, int start, int pageLength , System.String maLopHocPhan)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.cust_PhanCongDoAnTotNghiep_GetByMaLopHocPhan", true);
			
			database.AddInParameter(commandWrapper, "@MaLopHocPhan", DbType.AnsiString,  maLopHocPhan );
	
			
			IDataReader reader = null;
			
			//Create Collection
				TList<PhanCongDoAnTotNghiep> rows = new TList<PhanCongDoAnTotNghiep>();
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByMaLopHocPhan", rows));
	
				if (transactionManager != null)
				{	
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}	
				
				try
				{    
					Fill(reader, rows, start, pageLength);
				}
				finally
				{
					if (reader != null) 
						reader.Close();
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetByMaLopHocPhan", rows));


				return rows;
		}
		#endregion
		#endregion
	}//end class
} // end namespace
