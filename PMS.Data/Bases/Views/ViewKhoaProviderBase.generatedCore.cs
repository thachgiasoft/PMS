#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="ViewKhoaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKhoaProviderBaseCore : EntityViewProviderBase<ViewKhoa>
	{
		#region Custom Methods
		
		
		#region cust_View_Khoa_BoMon_GetByMaKhoa
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaKhoa' stored procedure. 
		/// </summary>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BoMon_GetByMaKhoa(System.String maKhoa)
		{
			return BoMon_GetByMaKhoa(null, 0, int.MaxValue , maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaKhoa' stored procedure. 
		/// </summary>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BoMon_GetByMaKhoa(int start, int pageLength, System.String maKhoa)
		{
			return BoMon_GetByMaKhoa(null, start, pageLength , maKhoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaKhoa' stored procedure. 
		/// </summary>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BoMon_GetByMaKhoa(TransactionManager transactionManager, System.String maKhoa)
		{
			return BoMon_GetByMaKhoa(transactionManager, 0, int.MaxValue , maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaKhoa' stored procedure. 
		/// </summary>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BoMon_GetByMaKhoa(TransactionManager transactionManager, int start, int pageLength, System.String maKhoa);
		
		#endregion

		
		#region cust_View_Khoa_BoMon_GetByMaBoMon
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaBoMon' stored procedure. 
		/// </summary>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BoMon_GetByMaBoMon(System.String maBoMon)
		{
			return BoMon_GetByMaBoMon(null, 0, int.MaxValue , maBoMon);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaBoMon' stored procedure. 
		/// </summary>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BoMon_GetByMaBoMon(int start, int pageLength, System.String maBoMon)
		{
			return BoMon_GetByMaBoMon(null, start, pageLength , maBoMon);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaBoMon' stored procedure. 
		/// </summary>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BoMon_GetByMaBoMon(TransactionManager transactionManager, System.String maBoMon)
		{
			return BoMon_GetByMaBoMon(transactionManager, 0, int.MaxValue , maBoMon);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaBoMon' stored procedure. 
		/// </summary>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BoMon_GetByMaBoMon(TransactionManager transactionManager, int start, int pageLength, System.String maBoMon);
		
		#endregion

		
		#region cust_View_Khoa_GetAllKhoa
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_GetAllKhoa' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllKhoa()
		{
			return GetAllKhoa(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_GetAllKhoa' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllKhoa(int start, int pageLength)
		{
			return GetAllKhoa(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_GetAllKhoa' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllKhoa(TransactionManager transactionManager)
		{
			return GetAllKhoa(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_GetAllKhoa' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetAllKhoa(TransactionManager transactionManager, int start, int pageLength);
		
		#endregion

		
		#region cust_View_Khoa_BoMon_GetByMaCoSo
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaCoSo' stored procedure. 
		/// </summary>
		/// <param name="coSo"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BoMon_GetByMaCoSo(System.String coSo)
		{
			return BoMon_GetByMaCoSo(null, 0, int.MaxValue , coSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaCoSo' stored procedure. 
		/// </summary>
		/// <param name="coSo"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BoMon_GetByMaCoSo(int start, int pageLength, System.String coSo)
		{
			return BoMon_GetByMaCoSo(null, start, pageLength , coSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaCoSo' stored procedure. 
		/// </summary>
		/// <param name="coSo"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BoMon_GetByMaCoSo(TransactionManager transactionManager, System.String coSo)
		{
			return BoMon_GetByMaCoSo(transactionManager, 0, int.MaxValue , coSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaCoSo' stored procedure. 
		/// </summary>
		/// <param name="coSo"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BoMon_GetByMaCoSo(TransactionManager transactionManager, int start, int pageLength, System.String coSo);
		
		#endregion

		
		#region cust_View_Khoa_GetBoMonByKhoa
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_GetBoMonByKhoa' stored procedure. 
		/// </summary>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetBoMonByKhoa(System.String khoa)
		{
			return GetBoMonByKhoa(null, 0, int.MaxValue , khoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_GetBoMonByKhoa' stored procedure. 
		/// </summary>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetBoMonByKhoa(int start, int pageLength, System.String khoa)
		{
			return GetBoMonByKhoa(null, start, pageLength , khoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_GetBoMonByKhoa' stored procedure. 
		/// </summary>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetBoMonByKhoa(TransactionManager transactionManager, System.String khoa)
		{
			return GetBoMonByKhoa(transactionManager, 0, int.MaxValue , khoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_GetBoMonByKhoa' stored procedure. 
		/// </summary>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetBoMonByKhoa(TransactionManager transactionManager, int start, int pageLength, System.String khoa);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKhoa&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKhoa&gt;"/></returns>
		protected static VList&lt;ViewKhoa&gt; Fill(DataSet dataSet, VList<ViewKhoa> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKhoa>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKhoa&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKhoa>"/></returns>
		protected static VList&lt;ViewKhoa&gt; Fill(DataTable dataTable, VList<ViewKhoa> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKhoa c = new ViewKhoa();
					c.ThuTu = (Convert.IsDBNull(row["ThuTu"]))?(int)0:(System.Int32?)row["ThuTu"];
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.AcceptChanges();
					rows.Add(c);
					pagelen -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		*/	
						
		///<summary>
		/// Fill an <see cref="VList&lt;ViewKhoa&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKhoa&gt;"/></returns>
		protected VList<ViewKhoa> Fill(IDataReader reader, VList<ViewKhoa> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKhoa entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKhoa>("ViewKhoa",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKhoa();
					}
					
					entity.SuppressEntityEvents = true;

					entity.ThuTu = reader.IsDBNull(reader.GetOrdinal("ThuTu")) ? null : (System.Int32?)reader["ThuTu"];
					//entity.ThuTu = (Convert.IsDBNull(reader["ThuTu"]))?(int)0:(System.Int32?)reader["ThuTu"];
					entity.MaKhoa = (System.String)reader["MaKhoa"];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.TenKhoa = (System.String)reader["TenKhoa"];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.AcceptChanges();
					entity.SuppressEntityEvents = false;
					
					rows.Add(entity);
					pageLength -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		
		
		/// <summary>
		/// Refreshes the <see cref="ViewKhoa"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoa"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKhoa entity)
		{
			reader.Read();
			entity.ThuTu = reader.IsDBNull(reader.GetOrdinal("ThuTu")) ? null : (System.Int32?)reader["ThuTu"];
			//entity.ThuTu = (Convert.IsDBNull(reader["ThuTu"]))?(int)0:(System.Int32?)reader["ThuTu"];
			entity.MaKhoa = (System.String)reader["MaKhoa"];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.TenKhoa = (System.String)reader["TenKhoa"];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKhoa"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoa"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKhoa entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ThuTu = (Convert.IsDBNull(dataRow["ThuTu"]))?(int)0:(System.Int32?)dataRow["ThuTu"];
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKhoaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaFilterBuilder : SqlFilterBuilder<ViewKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaFilterBuilder class.
		/// </summary>
		public ViewKhoaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoaFilterBuilder

	#region ViewKhoaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaParameterBuilder : ParameterizedSqlFilterBuilder<ViewKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaParameterBuilder class.
		/// </summary>
		public ViewKhoaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoaParameterBuilder
	
	#region ViewKhoaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoa"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKhoaSortBuilder : SqlSortBuilder<ViewKhoaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaSqlSortBuilder class.
		/// </summary>
		public ViewKhoaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKhoaSortBuilder

} // end namespace
