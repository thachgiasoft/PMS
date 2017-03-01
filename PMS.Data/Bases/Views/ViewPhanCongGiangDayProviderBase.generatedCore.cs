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
	/// This class is the base class for any <see cref="ViewPhanCongGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewPhanCongGiangDayProviderBaseCore : EntityViewProviderBase<ViewPhanCongGiangDay>
	{
		#region Custom Methods
		
		
		#region cust_View_PhanCongGiangDay_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanCongGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanCongGiangDay&gt;"/> instance.</returns>
		public VList<ViewPhanCongGiangDay> GetByNamHocHocKy(System.String namHoc, System.String hocKy, System.String maGiangVien)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanCongGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanCongGiangDay&gt;"/> instance.</returns>
		public VList<ViewPhanCongGiangDay> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maGiangVien)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_PhanCongGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewPhanCongGiangDay&gt;"/> instance.</returns>
		public VList<ViewPhanCongGiangDay> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maGiangVien)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_PhanCongGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewPhanCongGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewPhanCongGiangDay> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maGiangVien);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewPhanCongGiangDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewPhanCongGiangDay&gt;"/></returns>
		protected static VList&lt;ViewPhanCongGiangDay&gt; Fill(DataSet dataSet, VList<ViewPhanCongGiangDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewPhanCongGiangDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewPhanCongGiangDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewPhanCongGiangDay>"/></returns>
		protected static VList&lt;ViewPhanCongGiangDay&gt; Fill(DataTable dataTable, VList<ViewPhanCongGiangDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewPhanCongGiangDay c = new ViewPhanCongGiangDay();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.SoLuong = (Convert.IsDBNull(row["SoLuong"]))?(int)0:(System.Int32?)row["SoLuong"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.TenLop = (Convert.IsDBNull(row["TenLop"]))?string.Empty:(System.String)row["TenLop"];
					c.NgayBatDauDay = (Convert.IsDBNull(row["NgayBatDauDay"]))?DateTime.MinValue:(System.DateTime?)row["NgayBatDauDay"];
					c.NgayKetThucDay = (Convert.IsDBNull(row["NgayKetThucDay"]))?DateTime.MinValue:(System.DateTime?)row["NgayKetThucDay"];
					c.NoiLamViec = (Convert.IsDBNull(row["NoiLamViec"]))?string.Empty:(System.String)row["NoiLamViec"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.TenHocKy = (Convert.IsDBNull(row["TenHocKy"]))?string.Empty:(System.String)row["TenHocKy"];
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
		/// Fill an <see cref="VList&lt;ViewPhanCongGiangDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewPhanCongGiangDay&gt;"/></returns>
		protected VList<ViewPhanCongGiangDay> Fill(IDataReader reader, VList<ViewPhanCongGiangDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewPhanCongGiangDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewPhanCongGiangDay>("ViewPhanCongGiangDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewPhanCongGiangDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (System.String)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Int32?)reader["SoLuong"];
					//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
					entity.MaMonHoc = (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaLop = (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.TenLop = (System.String)reader["TenLop"];
					//entity.TenLop = (Convert.IsDBNull(reader["TenLop"]))?string.Empty:(System.String)reader["TenLop"];
					entity.NgayBatDauDay = reader.IsDBNull(reader.GetOrdinal("NgayBatDauDay")) ? null : (System.DateTime?)reader["NgayBatDauDay"];
					//entity.NgayBatDauDay = (Convert.IsDBNull(reader["NgayBatDauDay"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDauDay"];
					entity.NgayKetThucDay = reader.IsDBNull(reader.GetOrdinal("NgayKetThucDay")) ? null : (System.DateTime?)reader["NgayKetThucDay"];
					//entity.NgayKetThucDay = (Convert.IsDBNull(reader["NgayKetThucDay"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThucDay"];
					entity.NoiLamViec = reader.IsDBNull(reader.GetOrdinal("NoiLamViec")) ? null : (System.String)reader["NoiLamViec"];
					//entity.NoiLamViec = (Convert.IsDBNull(reader["NoiLamViec"]))?string.Empty:(System.String)reader["NoiLamViec"];
					entity.NamHoc = (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.TenHocKy = reader.IsDBNull(reader.GetOrdinal("TenHocKy")) ? null : (System.String)reader["TenHocKy"];
					//entity.TenHocKy = (Convert.IsDBNull(reader["TenHocKy"]))?string.Empty:(System.String)reader["TenHocKy"];
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
		/// Refreshes the <see cref="ViewPhanCongGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhanCongGiangDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewPhanCongGiangDay entity)
		{
			reader.Read();
			entity.MaGiangVien = (System.String)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Int32?)reader["SoLuong"];
			//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
			entity.MaMonHoc = (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaLop = (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.TenLop = (System.String)reader["TenLop"];
			//entity.TenLop = (Convert.IsDBNull(reader["TenLop"]))?string.Empty:(System.String)reader["TenLop"];
			entity.NgayBatDauDay = reader.IsDBNull(reader.GetOrdinal("NgayBatDauDay")) ? null : (System.DateTime?)reader["NgayBatDauDay"];
			//entity.NgayBatDauDay = (Convert.IsDBNull(reader["NgayBatDauDay"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDauDay"];
			entity.NgayKetThucDay = reader.IsDBNull(reader.GetOrdinal("NgayKetThucDay")) ? null : (System.DateTime?)reader["NgayKetThucDay"];
			//entity.NgayKetThucDay = (Convert.IsDBNull(reader["NgayKetThucDay"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThucDay"];
			entity.NoiLamViec = reader.IsDBNull(reader.GetOrdinal("NoiLamViec")) ? null : (System.String)reader["NoiLamViec"];
			//entity.NoiLamViec = (Convert.IsDBNull(reader["NoiLamViec"]))?string.Empty:(System.String)reader["NoiLamViec"];
			entity.NamHoc = (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.TenHocKy = reader.IsDBNull(reader.GetOrdinal("TenHocKy")) ? null : (System.String)reader["TenHocKy"];
			//entity.TenHocKy = (Convert.IsDBNull(reader["TenHocKy"]))?string.Empty:(System.String)reader["TenHocKy"];
			entity.TenCoSo = reader.IsDBNull(reader.GetOrdinal("TenCoSo")) ? null : (System.String)reader["TenCoSo"];
			//entity.TenCoSo = (Convert.IsDBNull(reader["TenCoSo"]))?string.Empty:(System.String)reader["TenCoSo"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewPhanCongGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewPhanCongGiangDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewPhanCongGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.SoLuong = (Convert.IsDBNull(dataRow["SoLuong"]))?(int)0:(System.Int32?)dataRow["SoLuong"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.TenLop = (Convert.IsDBNull(dataRow["TenLop"]))?string.Empty:(System.String)dataRow["TenLop"];
			entity.NgayBatDauDay = (Convert.IsDBNull(dataRow["NgayBatDauDay"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayBatDauDay"];
			entity.NgayKetThucDay = (Convert.IsDBNull(dataRow["NgayKetThucDay"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKetThucDay"];
			entity.NoiLamViec = (Convert.IsDBNull(dataRow["NoiLamViec"]))?string.Empty:(System.String)dataRow["NoiLamViec"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.TenHocKy = (Convert.IsDBNull(dataRow["TenHocKy"]))?string.Empty:(System.String)dataRow["TenHocKy"];
			entity.TenCoSo = (Convert.IsDBNull(dataRow["TenCoSo"]))?string.Empty:(System.String)dataRow["TenCoSo"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewPhanCongGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanCongGiangDayFilterBuilder : SqlFilterBuilder<ViewPhanCongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongGiangDayFilterBuilder class.
		/// </summary>
		public ViewPhanCongGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhanCongGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhanCongGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhanCongGiangDayFilterBuilder

	#region ViewPhanCongGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanCongGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewPhanCongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongGiangDayParameterBuilder class.
		/// </summary>
		public ViewPhanCongGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewPhanCongGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewPhanCongGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewPhanCongGiangDayParameterBuilder
	
	#region ViewPhanCongGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewPhanCongGiangDaySortBuilder : SqlSortBuilder<ViewPhanCongGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongGiangDaySqlSortBuilder class.
		/// </summary>
		public ViewPhanCongGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewPhanCongGiangDaySortBuilder

} // end namespace
