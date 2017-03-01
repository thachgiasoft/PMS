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
	/// This class is the base class for any <see cref="ViewKhoaBoMonProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKhoaBoMonProviderBaseCore : EntityViewProviderBase<ViewKhoaBoMon>
	{
		#region Custom Methods
		
		
		#region cust_View_Khoa_BoMon_GetByMaCoSo
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaCoSo' stored procedure. 
		/// </summary>
		/// <param name="coSo"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaBoMon&gt;"/> instance.</returns>
		public VList<ViewKhoaBoMon> GetByMaCoSo(System.String coSo)
		{
			return GetByMaCoSo(null, 0, int.MaxValue , coSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaCoSo' stored procedure. 
		/// </summary>
		/// <param name="coSo"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaBoMon&gt;"/> instance.</returns>
		public VList<ViewKhoaBoMon> GetByMaCoSo(int start, int pageLength, System.String coSo)
		{
			return GetByMaCoSo(null, start, pageLength , coSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaCoSo' stored procedure. 
		/// </summary>
		/// <param name="coSo"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKhoaBoMon&gt;"/> instance.</returns>
		public VList<ViewKhoaBoMon> GetByMaCoSo(TransactionManager transactionManager, System.String coSo)
		{
			return GetByMaCoSo(transactionManager, 0, int.MaxValue , coSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaCoSo' stored procedure. 
		/// </summary>
		/// <param name="coSo"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaBoMon&gt;"/> instance.</returns>
		public abstract VList<ViewKhoaBoMon> GetByMaCoSo(TransactionManager transactionManager, int start, int pageLength, System.String coSo);
		
		#endregion

		
		#region cust_View_Khoa_BoMon_GetByMaKhoa
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaKhoa' stored procedure. 
		/// </summary>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaBoMon&gt;"/> instance.</returns>
		public VList<ViewKhoaBoMon> GetByMaKhoa(System.String maKhoa)
		{
			return GetByMaKhoa(null, 0, int.MaxValue , maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaKhoa' stored procedure. 
		/// </summary>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaBoMon&gt;"/> instance.</returns>
		public VList<ViewKhoaBoMon> GetByMaKhoa(int start, int pageLength, System.String maKhoa)
		{
			return GetByMaKhoa(null, start, pageLength , maKhoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaKhoa' stored procedure. 
		/// </summary>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKhoaBoMon&gt;"/> instance.</returns>
		public VList<ViewKhoaBoMon> GetByMaKhoa(TransactionManager transactionManager, System.String maKhoa)
		{
			return GetByMaKhoa(transactionManager, 0, int.MaxValue , maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaKhoa' stored procedure. 
		/// </summary>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaBoMon&gt;"/> instance.</returns>
		public abstract VList<ViewKhoaBoMon> GetByMaKhoa(TransactionManager transactionManager, int start, int pageLength, System.String maKhoa);
		
		#endregion

		
		#region cust_View_Khoa_BoMon_GetByMaBoMon
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaBoMon' stored procedure. 
		/// </summary>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaBoMon&gt;"/> instance.</returns>
		public VList<ViewKhoaBoMon> GetByMaBoMon(System.String maBoMon)
		{
			return GetByMaBoMon(null, 0, int.MaxValue , maBoMon);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaBoMon' stored procedure. 
		/// </summary>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaBoMon&gt;"/> instance.</returns>
		public VList<ViewKhoaBoMon> GetByMaBoMon(int start, int pageLength, System.String maBoMon)
		{
			return GetByMaBoMon(null, start, pageLength , maBoMon);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaBoMon' stored procedure. 
		/// </summary>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKhoaBoMon&gt;"/> instance.</returns>
		public VList<ViewKhoaBoMon> GetByMaBoMon(TransactionManager transactionManager, System.String maBoMon)
		{
			return GetByMaBoMon(transactionManager, 0, int.MaxValue , maBoMon);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Khoa_BoMon_GetByMaBoMon' stored procedure. 
		/// </summary>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoaBoMon&gt;"/> instance.</returns>
		public abstract VList<ViewKhoaBoMon> GetByMaBoMon(TransactionManager transactionManager, int start, int pageLength, System.String maBoMon);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKhoaBoMon&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKhoaBoMon&gt;"/></returns>
		protected static VList&lt;ViewKhoaBoMon&gt; Fill(DataSet dataSet, VList<ViewKhoaBoMon> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKhoaBoMon>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKhoaBoMon&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKhoaBoMon>"/></returns>
		protected static VList&lt;ViewKhoaBoMon&gt; Fill(DataTable dataTable, VList<ViewKhoaBoMon> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKhoaBoMon c = new ViewKhoaBoMon();
					c.ThuTu = (Convert.IsDBNull(row["ThuTu"]))?(long)0:(System.Int64?)row["ThuTu"];
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.MaBoMon = (Convert.IsDBNull(row["MaBoMon"]))?string.Empty:(System.String)row["MaBoMon"];
					c.TenBoMon = (Convert.IsDBNull(row["TenBoMon"]))?string.Empty:(System.String)row["TenBoMon"];
					c.MaCoSo = (Convert.IsDBNull(row["MaCoSo"]))?string.Empty:(System.String)row["MaCoSo"];
					c.TenCoSo = (Convert.IsDBNull(row["TenCoSo"]))?string.Empty:(System.String)row["TenCoSo"];
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
		/// Fill an <see cref="VList&lt;ViewKhoaBoMon&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKhoaBoMon&gt;"/></returns>
		protected VList<ViewKhoaBoMon> Fill(IDataReader reader, VList<ViewKhoaBoMon> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKhoaBoMon entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKhoaBoMon>("ViewKhoaBoMon",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKhoaBoMon();
					}
					
					entity.SuppressEntityEvents = true;

					entity.ThuTu = reader.IsDBNull(reader.GetOrdinal("ThuTu")) ? null : (System.Int64?)reader["ThuTu"];
					//entity.ThuTu = (Convert.IsDBNull(reader["ThuTu"]))?(long)0:(System.Int64?)reader["ThuTu"];
					entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.MaBoMon = (System.String)reader["MaBoMon"];
					//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
					entity.TenBoMon = (System.String)reader["TenBoMon"];
					//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
					entity.MaCoSo = reader.IsDBNull(reader.GetOrdinal("MaCoSo")) ? null : (System.String)reader["MaCoSo"];
					//entity.MaCoSo = (Convert.IsDBNull(reader["MaCoSo"]))?string.Empty:(System.String)reader["MaCoSo"];
					entity.TenCoSo = reader.IsDBNull(reader.GetOrdinal("TenCoSo")) ? null : (System.String)reader["TenCoSo"];
					//entity.TenCoSo = (Convert.IsDBNull(reader["TenCoSo"]))?string.Empty:(System.String)reader["TenCoSo"];
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
		/// Refreshes the <see cref="ViewKhoaBoMon"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoaBoMon"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKhoaBoMon entity)
		{
			reader.Read();
			entity.ThuTu = reader.IsDBNull(reader.GetOrdinal("ThuTu")) ? null : (System.Int64?)reader["ThuTu"];
			//entity.ThuTu = (Convert.IsDBNull(reader["ThuTu"]))?(long)0:(System.Int64?)reader["ThuTu"];
			entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.MaBoMon = (System.String)reader["MaBoMon"];
			//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
			entity.TenBoMon = (System.String)reader["TenBoMon"];
			//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
			entity.MaCoSo = reader.IsDBNull(reader.GetOrdinal("MaCoSo")) ? null : (System.String)reader["MaCoSo"];
			//entity.MaCoSo = (Convert.IsDBNull(reader["MaCoSo"]))?string.Empty:(System.String)reader["MaCoSo"];
			entity.TenCoSo = reader.IsDBNull(reader.GetOrdinal("TenCoSo")) ? null : (System.String)reader["TenCoSo"];
			//entity.TenCoSo = (Convert.IsDBNull(reader["TenCoSo"]))?string.Empty:(System.String)reader["TenCoSo"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKhoaBoMon"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoaBoMon"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKhoaBoMon entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ThuTu = (Convert.IsDBNull(dataRow["ThuTu"]))?(long)0:(System.Int64?)dataRow["ThuTu"];
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.MaBoMon = (Convert.IsDBNull(dataRow["MaBoMon"]))?string.Empty:(System.String)dataRow["MaBoMon"];
			entity.TenBoMon = (Convert.IsDBNull(dataRow["TenBoMon"]))?string.Empty:(System.String)dataRow["TenBoMon"];
			entity.MaCoSo = (Convert.IsDBNull(dataRow["MaCoSo"]))?string.Empty:(System.String)dataRow["MaCoSo"];
			entity.TenCoSo = (Convert.IsDBNull(dataRow["TenCoSo"]))?string.Empty:(System.String)dataRow["TenCoSo"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKhoaBoMonFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaBoMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaBoMonFilterBuilder : SqlFilterBuilder<ViewKhoaBoMonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaBoMonFilterBuilder class.
		/// </summary>
		public ViewKhoaBoMonFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaBoMonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoaBoMonFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaBoMonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoaBoMonFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoaBoMonFilterBuilder

	#region ViewKhoaBoMonParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaBoMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaBoMonParameterBuilder : ParameterizedSqlFilterBuilder<ViewKhoaBoMonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaBoMonParameterBuilder class.
		/// </summary>
		public ViewKhoaBoMonParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaBoMonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoaBoMonParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoaBoMonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoaBoMonParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoaBoMonParameterBuilder
	
	#region ViewKhoaBoMonSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaBoMon"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKhoaBoMonSortBuilder : SqlSortBuilder<ViewKhoaBoMonColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaBoMonSqlSortBuilder class.
		/// </summary>
		public ViewKhoaBoMonSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKhoaBoMonSortBuilder

} // end namespace
