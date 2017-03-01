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
	/// This class is the base class for any <see cref="ViewTruongKhoaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewTruongKhoaProviderBaseCore : EntityViewProviderBase<ViewTruongKhoa>
	{
		#region Custom Methods
		
		
		#region cust_View_TruongKhoa_GetByMaDonViMaGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_TruongKhoa_GetByMaDonViMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTruongKhoa&gt;"/> instance.</returns>
		public VList<ViewTruongKhoa> GetByMaDonViMaGiangVien(System.String maDonVi, System.Int32 maGiangVien)
		{
			return GetByMaDonViMaGiangVien(null, 0, int.MaxValue , maDonVi, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TruongKhoa_GetByMaDonViMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTruongKhoa&gt;"/> instance.</returns>
		public VList<ViewTruongKhoa> GetByMaDonViMaGiangVien(int start, int pageLength, System.String maDonVi, System.Int32 maGiangVien)
		{
			return GetByMaDonViMaGiangVien(null, start, pageLength , maDonVi, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_TruongKhoa_GetByMaDonViMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewTruongKhoa&gt;"/> instance.</returns>
		public VList<ViewTruongKhoa> GetByMaDonViMaGiangVien(TransactionManager transactionManager, System.String maDonVi, System.Int32 maGiangVien)
		{
			return GetByMaDonViMaGiangVien(transactionManager, 0, int.MaxValue , maDonVi, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TruongKhoa_GetByMaDonViMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTruongKhoa&gt;"/> instance.</returns>
		public abstract VList<ViewTruongKhoa> GetByMaDonViMaGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi, System.Int32 maGiangVien);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewTruongKhoa&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewTruongKhoa&gt;"/></returns>
		protected static VList&lt;ViewTruongKhoa&gt; Fill(DataSet dataSet, VList<ViewTruongKhoa> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewTruongKhoa>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewTruongKhoa&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewTruongKhoa>"/></returns>
		protected static VList&lt;ViewTruongKhoa&gt; Fill(DataTable dataTable, VList<ViewTruongKhoa> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewTruongKhoa c = new ViewTruongKhoa();
					c.MaBoMon = (Convert.IsDBNull(row["MaBoMon"]))?string.Empty:(System.String)row["MaBoMon"];
					c.TenBoMon = (Convert.IsDBNull(row["TenBoMon"]))?string.Empty:(System.String)row["TenBoMon"];
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
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
		/// Fill an <see cref="VList&lt;ViewTruongKhoa&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewTruongKhoa&gt;"/></returns>
		protected VList<ViewTruongKhoa> Fill(IDataReader reader, VList<ViewTruongKhoa> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewTruongKhoa entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewTruongKhoa>("ViewTruongKhoa",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewTruongKhoa();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaBoMon = (System.String)reader[((int)ViewTruongKhoaColumn.MaBoMon)];
					//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
					entity.TenBoMon = (System.String)reader[((int)ViewTruongKhoaColumn.TenBoMon)];
					//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
					entity.MaKhoa = (reader.IsDBNull(((int)ViewTruongKhoaColumn.MaKhoa)))?null:(System.String)reader[((int)ViewTruongKhoaColumn.MaKhoa)];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.TenKhoa = (reader.IsDBNull(((int)ViewTruongKhoaColumn.TenKhoa)))?null:(System.String)reader[((int)ViewTruongKhoaColumn.TenKhoa)];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.MaGiangVien = (System.Int32)reader[((int)ViewTruongKhoaColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader[((int)ViewTruongKhoaColumn.MaQuanLy)];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.HoTen = (reader.IsDBNull(((int)ViewTruongKhoaColumn.HoTen)))?null:(System.String)reader[((int)ViewTruongKhoaColumn.HoTen)];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
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
		/// Refreshes the <see cref="ViewTruongKhoa"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTruongKhoa"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewTruongKhoa entity)
		{
			reader.Read();
			entity.MaBoMon = (System.String)reader[((int)ViewTruongKhoaColumn.MaBoMon)];
			//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
			entity.TenBoMon = (System.String)reader[((int)ViewTruongKhoaColumn.TenBoMon)];
			//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
			entity.MaKhoa = (reader.IsDBNull(((int)ViewTruongKhoaColumn.MaKhoa)))?null:(System.String)reader[((int)ViewTruongKhoaColumn.MaKhoa)];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.TenKhoa = (reader.IsDBNull(((int)ViewTruongKhoaColumn.TenKhoa)))?null:(System.String)reader[((int)ViewTruongKhoaColumn.TenKhoa)];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.MaGiangVien = (System.Int32)reader[((int)ViewTruongKhoaColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader[((int)ViewTruongKhoaColumn.MaQuanLy)];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.HoTen = (reader.IsDBNull(((int)ViewTruongKhoaColumn.HoTen)))?null:(System.String)reader[((int)ViewTruongKhoaColumn.HoTen)];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewTruongKhoa"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTruongKhoa"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewTruongKhoa entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaBoMon = (Convert.IsDBNull(dataRow["MaBoMon"]))?string.Empty:(System.String)dataRow["MaBoMon"];
			entity.TenBoMon = (Convert.IsDBNull(dataRow["TenBoMon"]))?string.Empty:(System.String)dataRow["TenBoMon"];
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewTruongKhoaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTruongKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTruongKhoaFilterBuilder : SqlFilterBuilder<ViewTruongKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTruongKhoaFilterBuilder class.
		/// </summary>
		public ViewTruongKhoaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTruongKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTruongKhoaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTruongKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTruongKhoaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTruongKhoaFilterBuilder

	#region ViewTruongKhoaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTruongKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTruongKhoaParameterBuilder : ParameterizedSqlFilterBuilder<ViewTruongKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTruongKhoaParameterBuilder class.
		/// </summary>
		public ViewTruongKhoaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTruongKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTruongKhoaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTruongKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTruongKhoaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTruongKhoaParameterBuilder
	
	#region ViewTruongKhoaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTruongKhoa"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewTruongKhoaSortBuilder : SqlSortBuilder<ViewTruongKhoaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTruongKhoaSqlSortBuilder class.
		/// </summary>
		public ViewTruongKhoaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewTruongKhoaSortBuilder

} // end namespace
