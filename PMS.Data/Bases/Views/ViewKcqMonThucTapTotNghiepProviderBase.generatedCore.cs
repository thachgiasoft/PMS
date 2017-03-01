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
	/// This class is the base class for any <see cref="ViewKcqMonThucTapTotNghiepProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKcqMonThucTapTotNghiepProviderBaseCore : EntityViewProviderBase<ViewKcqMonThucTapTotNghiep>
	{
		#region Custom Methods
		
		
		#region cust_View_KcqMonThucTapTotNghiep_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqMonThucTapTotNghiep_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqMonThucTapTotNghiep&gt;"/> instance.</returns>
		public VList<ViewKcqMonThucTapTotNghiep> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqMonThucTapTotNghiep_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqMonThucTapTotNghiep&gt;"/> instance.</returns>
		public VList<ViewKcqMonThucTapTotNghiep> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KcqMonThucTapTotNghiep_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKcqMonThucTapTotNghiep&gt;"/> instance.</returns>
		public VList<ViewKcqMonThucTapTotNghiep> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqMonThucTapTotNghiep_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqMonThucTapTotNghiep&gt;"/> instance.</returns>
		public abstract VList<ViewKcqMonThucTapTotNghiep> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKcqMonThucTapTotNghiep&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKcqMonThucTapTotNghiep&gt;"/></returns>
		protected static VList&lt;ViewKcqMonThucTapTotNghiep&gt; Fill(DataSet dataSet, VList<ViewKcqMonThucTapTotNghiep> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKcqMonThucTapTotNghiep>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKcqMonThucTapTotNghiep&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKcqMonThucTapTotNghiep>"/></returns>
		protected static VList&lt;ViewKcqMonThucTapTotNghiep&gt; Fill(DataTable dataTable, VList<ViewKcqMonThucTapTotNghiep> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKcqMonThucTapTotNghiep c = new ViewKcqMonThucTapTotNghiep();
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.Stc = (Convert.IsDBNull(row["Stc"]))?0.0m:(System.Decimal)row["Stc"];
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.SoTuan = (Convert.IsDBNull(row["SoTuan"]))?(int)0:(System.Int32?)row["SoTuan"];
					c.NgayCapNhat = (Convert.IsDBNull(row["NgayCapNhat"]))?DateTime.MinValue:(System.DateTime?)row["NgayCapNhat"];
					c.NguoiCapNhat = (Convert.IsDBNull(row["NguoiCapNhat"]))?string.Empty:(System.String)row["NguoiCapNhat"];
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
		/// Fill an <see cref="VList&lt;ViewKcqMonThucTapTotNghiep&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKcqMonThucTapTotNghiep&gt;"/></returns>
		protected VList<ViewKcqMonThucTapTotNghiep> Fill(IDataReader reader, VList<ViewKcqMonThucTapTotNghiep> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKcqMonThucTapTotNghiep entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKcqMonThucTapTotNghiep>("ViewKcqMonThucTapTotNghiep",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKcqMonThucTapTotNghiep();
					}
					
					entity.SuppressEntityEvents = true;

					entity.NamHoc = (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.Stc = (System.Decimal)reader["Stc"];
					//entity.Stc = (Convert.IsDBNull(reader["Stc"]))?0.0m:(System.Decimal)reader["Stc"];
					entity.MaKhoa = (System.String)reader["MaKhoa"];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.TenKhoa = (System.String)reader["TenKhoa"];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.SoTuan = reader.IsDBNull(reader.GetOrdinal("SoTuan")) ? null : (System.Int32?)reader["SoTuan"];
					//entity.SoTuan = (Convert.IsDBNull(reader["SoTuan"]))?(int)0:(System.Int32?)reader["SoTuan"];
					entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.DateTime?)reader["NgayCapNhat"];
					//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?DateTime.MinValue:(System.DateTime?)reader["NgayCapNhat"];
					entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
					//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
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
		/// Refreshes the <see cref="ViewKcqMonThucTapTotNghiep"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKcqMonThucTapTotNghiep"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKcqMonThucTapTotNghiep entity)
		{
			reader.Read();
			entity.NamHoc = (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.Stc = (System.Decimal)reader["Stc"];
			//entity.Stc = (Convert.IsDBNull(reader["Stc"]))?0.0m:(System.Decimal)reader["Stc"];
			entity.MaKhoa = (System.String)reader["MaKhoa"];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.TenKhoa = (System.String)reader["TenKhoa"];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.SoTuan = reader.IsDBNull(reader.GetOrdinal("SoTuan")) ? null : (System.Int32?)reader["SoTuan"];
			//entity.SoTuan = (Convert.IsDBNull(reader["SoTuan"]))?(int)0:(System.Int32?)reader["SoTuan"];
			entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.DateTime?)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?DateTime.MinValue:(System.DateTime?)reader["NgayCapNhat"];
			entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
			//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKcqMonThucTapTotNghiep"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKcqMonThucTapTotNghiep"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKcqMonThucTapTotNghiep entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.Stc = (Convert.IsDBNull(dataRow["Stc"]))?0.0m:(System.Decimal)dataRow["Stc"];
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.SoTuan = (Convert.IsDBNull(dataRow["SoTuan"]))?(int)0:(System.Int32?)dataRow["SoTuan"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = (Convert.IsDBNull(dataRow["NguoiCapNhat"]))?string.Empty:(System.String)dataRow["NguoiCapNhat"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKcqMonThucTapTotNghiepFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqMonThucTapTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqMonThucTapTotNghiepFilterBuilder : SqlFilterBuilder<ViewKcqMonThucTapTotNghiepColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonThucTapTotNghiepFilterBuilder class.
		/// </summary>
		public ViewKcqMonThucTapTotNghiepFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonThucTapTotNghiepFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKcqMonThucTapTotNghiepFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonThucTapTotNghiepFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKcqMonThucTapTotNghiepFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKcqMonThucTapTotNghiepFilterBuilder

	#region ViewKcqMonThucTapTotNghiepParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqMonThucTapTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqMonThucTapTotNghiepParameterBuilder : ParameterizedSqlFilterBuilder<ViewKcqMonThucTapTotNghiepColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonThucTapTotNghiepParameterBuilder class.
		/// </summary>
		public ViewKcqMonThucTapTotNghiepParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonThucTapTotNghiepParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKcqMonThucTapTotNghiepParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonThucTapTotNghiepParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKcqMonThucTapTotNghiepParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKcqMonThucTapTotNghiepParameterBuilder
	
	#region ViewKcqMonThucTapTotNghiepSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqMonThucTapTotNghiep"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKcqMonThucTapTotNghiepSortBuilder : SqlSortBuilder<ViewKcqMonThucTapTotNghiepColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonThucTapTotNghiepSqlSortBuilder class.
		/// </summary>
		public ViewKcqMonThucTapTotNghiepSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKcqMonThucTapTotNghiepSortBuilder

} // end namespace
