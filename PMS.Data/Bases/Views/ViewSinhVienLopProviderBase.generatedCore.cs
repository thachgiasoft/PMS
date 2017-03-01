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
	/// This class is the base class for any <see cref="ViewSinhVienLopProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewSinhVienLopProviderBaseCore : EntityViewProviderBase<ViewSinhVienLop>
	{
		#region Custom Methods
		
		
		#region cust_View_SinhVien_Lop_GetByMaKhoa
		
		/// <summary>
		///	This method wrap the 'cust_View_SinhVien_Lop_GetByMaKhoa' stored procedure. 
		/// </summary>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewSinhVienLop&gt;"/> instance.</returns>
		public VList<ViewSinhVienLop> GetByMaKhoa(System.String maKhoa)
		{
			return GetByMaKhoa(null, 0, int.MaxValue , maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_SinhVien_Lop_GetByMaKhoa' stored procedure. 
		/// </summary>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewSinhVienLop&gt;"/> instance.</returns>
		public VList<ViewSinhVienLop> GetByMaKhoa(int start, int pageLength, System.String maKhoa)
		{
			return GetByMaKhoa(null, start, pageLength , maKhoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_SinhVien_Lop_GetByMaKhoa' stored procedure. 
		/// </summary>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewSinhVienLop&gt;"/> instance.</returns>
		public VList<ViewSinhVienLop> GetByMaKhoa(TransactionManager transactionManager, System.String maKhoa)
		{
			return GetByMaKhoa(transactionManager, 0, int.MaxValue , maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_SinhVien_Lop_GetByMaKhoa' stored procedure. 
		/// </summary>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewSinhVienLop&gt;"/> instance.</returns>
		public abstract VList<ViewSinhVienLop> GetByMaKhoa(TransactionManager transactionManager, int start, int pageLength, System.String maKhoa);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewSinhVienLop&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewSinhVienLop&gt;"/></returns>
		protected static VList&lt;ViewSinhVienLop&gt; Fill(DataSet dataSet, VList<ViewSinhVienLop> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewSinhVienLop>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewSinhVienLop&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewSinhVienLop>"/></returns>
		protected static VList&lt;ViewSinhVienLop&gt; Fill(DataTable dataTable, VList<ViewSinhVienLop> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewSinhVienLop c = new ViewSinhVienLop();
					c.MaSinhVien = (Convert.IsDBNull(row["MaSinhVien"]))?string.Empty:(System.String)row["MaSinhVien"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.GioiTinh = (Convert.IsDBNull(row["GioiTinh"]))?string.Empty:(System.String)row["GioiTinh"];
					c.NgaySinh = (Convert.IsDBNull(row["NgaySinh"]))?string.Empty:(System.String)row["NgaySinh"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
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
		/// Fill an <see cref="VList&lt;ViewSinhVienLop&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewSinhVienLop&gt;"/></returns>
		protected VList<ViewSinhVienLop> Fill(IDataReader reader, VList<ViewSinhVienLop> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewSinhVienLop entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewSinhVienLop>("ViewSinhVienLop",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewSinhVienLop();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaSinhVien = (System.String)reader["MaSinhVien"];
					//entity.MaSinhVien = (Convert.IsDBNull(reader["MaSinhVien"]))?string.Empty:(System.String)reader["MaSinhVien"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.GioiTinh = reader.IsDBNull(reader.GetOrdinal("GioiTinh")) ? null : (System.String)reader["GioiTinh"];
					//entity.GioiTinh = (Convert.IsDBNull(reader["GioiTinh"]))?string.Empty:(System.String)reader["GioiTinh"];
					entity.NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? null : (System.String)reader["NgaySinh"];
					//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
					entity.MaLop = (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.MaKhoa = (System.String)reader["MaKhoa"];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
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
		/// Refreshes the <see cref="ViewSinhVienLop"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewSinhVienLop"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewSinhVienLop entity)
		{
			reader.Read();
			entity.MaSinhVien = (System.String)reader["MaSinhVien"];
			//entity.MaSinhVien = (Convert.IsDBNull(reader["MaSinhVien"]))?string.Empty:(System.String)reader["MaSinhVien"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.GioiTinh = reader.IsDBNull(reader.GetOrdinal("GioiTinh")) ? null : (System.String)reader["GioiTinh"];
			//entity.GioiTinh = (Convert.IsDBNull(reader["GioiTinh"]))?string.Empty:(System.String)reader["GioiTinh"];
			entity.NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? null : (System.String)reader["NgaySinh"];
			//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
			entity.MaLop = (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.MaKhoa = (System.String)reader["MaKhoa"];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewSinhVienLop"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewSinhVienLop"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewSinhVienLop entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaSinhVien = (Convert.IsDBNull(dataRow["MaSinhVien"]))?string.Empty:(System.String)dataRow["MaSinhVien"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.GioiTinh = (Convert.IsDBNull(dataRow["GioiTinh"]))?string.Empty:(System.String)dataRow["GioiTinh"];
			entity.NgaySinh = (Convert.IsDBNull(dataRow["NgaySinh"]))?string.Empty:(System.String)dataRow["NgaySinh"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewSinhVienLopFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienLop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSinhVienLopFilterBuilder : SqlFilterBuilder<ViewSinhVienLopColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopFilterBuilder class.
		/// </summary>
		public ViewSinhVienLopFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewSinhVienLopFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewSinhVienLopFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewSinhVienLopFilterBuilder

	#region ViewSinhVienLopParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienLop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSinhVienLopParameterBuilder : ParameterizedSqlFilterBuilder<ViewSinhVienLopColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopParameterBuilder class.
		/// </summary>
		public ViewSinhVienLopParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewSinhVienLopParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewSinhVienLopParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewSinhVienLopParameterBuilder
	
	#region ViewSinhVienLopSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienLop"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewSinhVienLopSortBuilder : SqlSortBuilder<ViewSinhVienLopColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopSqlSortBuilder class.
		/// </summary>
		public ViewSinhVienLopSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewSinhVienLopSortBuilder

} // end namespace
