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
	/// This class is the base class for any <see cref="ViewPhanCongChuyenMonProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewPhanCongChuyenMonProviderBaseCore : EntityViewProviderBase<ViewPhanCongChuyenMon>
	{
		#region Custom Methods
		
		
		#region cust_View_PhanCong_ChuyenMon_GetByMaDonVi
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanCong_ChuyenMon_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanCongChuyenMon&gt;"/> instance.</returns>
		public VList<ViewPhanCongChuyenMon> GetByMaDonVi(System.String maDonVi)
		{
			return GetByMaDonVi(null, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanCong_ChuyenMon_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanCongChuyenMon&gt;"/> instance.</returns>
		public VList<ViewPhanCongChuyenMon> GetByMaDonVi(int start, int pageLength, System.String maDonVi)
		{
			return GetByMaDonVi(null, start, pageLength , maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_PhanCong_ChuyenMon_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewPhanCongChuyenMon&gt;"/> instance.</returns>
		public VList<ViewPhanCongChuyenMon> GetByMaDonVi(TransactionManager transactionManager, System.String maDonVi)
		{
			return GetByMaDonVi(transactionManager, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanCong_ChuyenMon_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanCongChuyenMon&gt;"/> instance.</returns>
		public abstract VList<ViewPhanCongChuyenMon> GetByMaDonVi(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewPhanCongChuyenMon&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewPhanCongChuyenMon&gt;"/></returns>
		protected static VList&lt;ViewPhanCongChuyenMon&gt; Fill(DataSet dataSet, VList<ViewPhanCongChuyenMon> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewPhanCongChuyenMon>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewPhanCongChuyenMon&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewPhanCongChuyenMon>"/></returns>
		protected static VList&lt;ViewPhanCongChuyenMon&gt; Fill(DataTable dataTable, VList<ViewPhanCongChuyenMon> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewPhanCongChuyenMon c = new ViewPhanCongChuyenMon();
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.MaBoMon = (Convert.IsDBNull(row["MaBoMon"]))?string.Empty:(System.String)row["MaBoMon"];
					c.TenBoMon = (Convert.IsDBNull(row["TenBoMon"]))?string.Empty:(System.String)row["TenBoMon"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.ChucDanh = (Convert.IsDBNull(row["ChucDanh"]))?string.Empty:(System.String)row["ChucDanh"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?0.0m:(System.Decimal)row["SoTinChi"];
					c.NgayPhanCong = (Convert.IsDBNull(row["NgayPhanCong"]))?DateTime.MinValue:(System.DateTime?)row["NgayPhanCong"];
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
		/// Fill an <see cref="VList&lt;ViewPhanCongChuyenMon&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewPhanCongChuyenMon&gt;"/></returns>
		protected VList<ViewPhanCongChuyenMon> Fill(IDataReader reader, VList<ViewPhanCongChuyenMon> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewPhanCongChuyenMon entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewPhanCongChuyenMon>("ViewPhanCongChuyenMon",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewPhanCongChuyenMon();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.MaBoMon = reader.IsDBNull(reader.GetOrdinal("MaBoMon")) ? null : (System.String)reader["MaBoMon"];
					//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
					entity.TenBoMon = reader.IsDBNull(reader.GetOrdinal("TenBoMon")) ? null : (System.String)reader["TenBoMon"];
					//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.ChucDanh = (System.String)reader["ChucDanh"];
					//entity.ChucDanh = (Convert.IsDBNull(reader["ChucDanh"]))?string.Empty:(System.String)reader["ChucDanh"];
					entity.MaMonHoc = (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.SoTinChi = (System.Decimal)reader["SoTinChi"];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
					entity.NgayPhanCong = reader.IsDBNull(reader.GetOrdinal("NgayPhanCong")) ? null : (System.DateTime?)reader["NgayPhanCong"];
					//entity.NgayPhanCong = (Convert.IsDBNull(reader["NgayPhanCong"]))?DateTime.MinValue:(System.DateTime?)reader["NgayPhanCong"];
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
		/// Refreshes the <see cref="ViewPhanCongChuyenMon"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhanCongChuyenMon"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewPhanCongChuyenMon entity)
		{
			reader.Read();
			entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.MaBoMon = reader.IsDBNull(reader.GetOrdinal("MaBoMon")) ? null : (System.String)reader["MaBoMon"];
			//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
			entity.TenBoMon = reader.IsDBNull(reader.GetOrdinal("TenBoMon")) ? null : (System.String)reader["TenBoMon"];
			//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.ChucDanh = (System.String)reader["ChucDanh"];
			//entity.ChucDanh = (Convert.IsDBNull(reader["ChucDanh"]))?string.Empty:(System.String)reader["ChucDanh"];
			entity.MaMonHoc = (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.SoTinChi = (System.Decimal)reader["SoTinChi"];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
			entity.NgayPhanCong = reader.IsDBNull(reader.GetOrdinal("NgayPhanCong")) ? null : (System.DateTime?)reader["NgayPhanCong"];
			//entity.NgayPhanCong = (Convert.IsDBNull(reader["NgayPhanCong"]))?DateTime.MinValue:(System.DateTime?)reader["NgayPhanCong"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewPhanCongChuyenMon"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhanCongChuyenMon"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewPhanCongChuyenMon entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.MaBoMon = (Convert.IsDBNull(dataRow["MaBoMon"]))?string.Empty:(System.String)dataRow["MaBoMon"];
			entity.TenBoMon = (Convert.IsDBNull(dataRow["TenBoMon"]))?string.Empty:(System.String)dataRow["TenBoMon"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.ChucDanh = (Convert.IsDBNull(dataRow["ChucDanh"]))?string.Empty:(System.String)dataRow["ChucDanh"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?0.0m:(System.Decimal)dataRow["SoTinChi"];
			entity.NgayPhanCong = (Convert.IsDBNull(dataRow["NgayPhanCong"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayPhanCong"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewPhanCongChuyenMonFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongChuyenMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanCongChuyenMonFilterBuilder : SqlFilterBuilder<ViewPhanCongChuyenMonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongChuyenMonFilterBuilder class.
		/// </summary>
		public ViewPhanCongChuyenMonFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongChuyenMonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhanCongChuyenMonFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongChuyenMonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhanCongChuyenMonFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhanCongChuyenMonFilterBuilder

	#region ViewPhanCongChuyenMonParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongChuyenMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanCongChuyenMonParameterBuilder : ParameterizedSqlFilterBuilder<ViewPhanCongChuyenMonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongChuyenMonParameterBuilder class.
		/// </summary>
		public ViewPhanCongChuyenMonParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongChuyenMonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhanCongChuyenMonParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongChuyenMonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhanCongChuyenMonParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhanCongChuyenMonParameterBuilder
	
	#region ViewPhanCongChuyenMonSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongChuyenMon"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewPhanCongChuyenMonSortBuilder : SqlSortBuilder<ViewPhanCongChuyenMonColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongChuyenMonSqlSortBuilder class.
		/// </summary>
		public ViewPhanCongChuyenMonSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewPhanCongChuyenMonSortBuilder

} // end namespace
