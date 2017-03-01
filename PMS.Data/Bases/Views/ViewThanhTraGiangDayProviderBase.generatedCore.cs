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
	/// This class is the base class for any <see cref="ViewThanhTraGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThanhTraGiangDayProviderBaseCore : EntityViewProviderBase<ViewThanhTraGiangDay>
	{
		#region Custom Methods
		
		
		#region cust_View_ThanhTraGiangDay_GetByTuNgayDenNgayMaDonVi
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraGiangDay_GetByTuNgayDenNgayMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraGiangDay&gt;"/> instance.</returns>
		public VList<ViewThanhTraGiangDay> GetByTuNgayDenNgayMaDonVi(System.DateTime tuNgay, System.DateTime denNgay, System.String maBoMon)
		{
			return GetByTuNgayDenNgayMaDonVi(null, 0, int.MaxValue , tuNgay, denNgay, maBoMon);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraGiangDay_GetByTuNgayDenNgayMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraGiangDay&gt;"/> instance.</returns>
		public VList<ViewThanhTraGiangDay> GetByTuNgayDenNgayMaDonVi(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.String maBoMon)
		{
			return GetByTuNgayDenNgayMaDonVi(null, start, pageLength , tuNgay, denNgay, maBoMon);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraGiangDay_GetByTuNgayDenNgayMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThanhTraGiangDay&gt;"/> instance.</returns>
		public VList<ViewThanhTraGiangDay> GetByTuNgayDenNgayMaDonVi(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay, System.String maBoMon)
		{
			return GetByTuNgayDenNgayMaDonVi(transactionManager, 0, int.MaxValue , tuNgay, denNgay, maBoMon);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraGiangDay_GetByTuNgayDenNgayMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewThanhTraGiangDay> GetByTuNgayDenNgayMaDonVi(TransactionManager transactionManager, int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.String maBoMon);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThanhTraGiangDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThanhTraGiangDay&gt;"/></returns>
		protected static VList&lt;ViewThanhTraGiangDay&gt; Fill(DataSet dataSet, VList<ViewThanhTraGiangDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThanhTraGiangDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThanhTraGiangDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThanhTraGiangDay>"/></returns>
		protected static VList&lt;ViewThanhTraGiangDay&gt; Fill(DataTable dataTable, VList<ViewThanhTraGiangDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThanhTraGiangDay c = new ViewThanhTraGiangDay();
					c.MaHienThi = (Convert.IsDBNull(row["MaHienThi"]))?string.Empty:(System.String)row["MaHienThi"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Khoa = (Convert.IsDBNull(row["Khoa"]))?string.Empty:(System.String)row["Khoa"];
					c.LoaiGiangVien = (Convert.IsDBNull(row["LoaiGiangVien"]))?string.Empty:(System.String)row["LoaiGiangVien"];
					c.TenHocPhan = (Convert.IsDBNull(row["TenHocPhan"]))?string.Empty:(System.String)row["TenHocPhan"];
					c.TinhHinhGhiNhan = (Convert.IsDBNull(row["TinhHinhGhiNhan"]))?string.Empty:(System.String)row["TinhHinhGhiNhan"];
					c.Ngay = (Convert.IsDBNull(row["Ngay"]))?DateTime.MinValue:(System.DateTime?)row["Ngay"];
					c.Tiet = (Convert.IsDBNull(row["Tiet"]))?string.Empty:(System.String)row["Tiet"];
					c.Lop = (Convert.IsDBNull(row["Lop"]))?string.Empty:(System.String)row["Lop"];
					c.Phong = (Convert.IsDBNull(row["Phong"]))?string.Empty:(System.String)row["Phong"];
					c.ThoiDiemGhiNhan = (Convert.IsDBNull(row["ThoiDiemGhiNhan"]))?string.Empty:(System.String)row["ThoiDiemGhiNhan"];
					c.LyDo = (Convert.IsDBNull(row["LyDo"]))?string.Empty:(System.String)row["LyDo"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?string.Empty:(System.String)row["GhiChu"];
					c.MaHinhThucViPham = (Convert.IsDBNull(row["MaHinhThucViPham"]))?Guid.Empty:(System.Guid?)row["MaHinhThucViPham"];
					c.DaBaoSuaTkb = (Convert.IsDBNull(row["DaBaoSuaTkb"]))?false:(System.Boolean?)row["DaBaoSuaTkb"];
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
		/// Fill an <see cref="VList&lt;ViewThanhTraGiangDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThanhTraGiangDay&gt;"/></returns>
		protected VList<ViewThanhTraGiangDay> Fill(IDataReader reader, VList<ViewThanhTraGiangDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThanhTraGiangDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThanhTraGiangDay>("ViewThanhTraGiangDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThanhTraGiangDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaHienThi = reader.IsDBNull(reader.GetOrdinal("MaHienThi")) ? null : (System.String)reader["MaHienThi"];
					//entity.MaHienThi = (Convert.IsDBNull(reader["MaHienThi"]))?string.Empty:(System.String)reader["MaHienThi"];
					entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Khoa = (System.String)reader["Khoa"];
					//entity.Khoa = (Convert.IsDBNull(reader["Khoa"]))?string.Empty:(System.String)reader["Khoa"];
					entity.LoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("LoaiGiangVien")) ? null : (System.String)reader["LoaiGiangVien"];
					//entity.LoaiGiangVien = (Convert.IsDBNull(reader["LoaiGiangVien"]))?string.Empty:(System.String)reader["LoaiGiangVien"];
					entity.TenHocPhan = reader.IsDBNull(reader.GetOrdinal("TenHocPhan")) ? null : (System.String)reader["TenHocPhan"];
					//entity.TenHocPhan = (Convert.IsDBNull(reader["TenHocPhan"]))?string.Empty:(System.String)reader["TenHocPhan"];
					entity.TinhHinhGhiNhan = reader.IsDBNull(reader.GetOrdinal("TinhHinhGhiNhan")) ? null : (System.String)reader["TinhHinhGhiNhan"];
					//entity.TinhHinhGhiNhan = (Convert.IsDBNull(reader["TinhHinhGhiNhan"]))?string.Empty:(System.String)reader["TinhHinhGhiNhan"];
					entity.Ngay = reader.IsDBNull(reader.GetOrdinal("Ngay")) ? null : (System.DateTime?)reader["Ngay"];
					//entity.Ngay = (Convert.IsDBNull(reader["Ngay"]))?DateTime.MinValue:(System.DateTime?)reader["Ngay"];
					entity.Tiet = reader.IsDBNull(reader.GetOrdinal("Tiet")) ? null : (System.String)reader["Tiet"];
					//entity.Tiet = (Convert.IsDBNull(reader["Tiet"]))?string.Empty:(System.String)reader["Tiet"];
					entity.Lop = reader.IsDBNull(reader.GetOrdinal("Lop")) ? null : (System.String)reader["Lop"];
					//entity.Lop = (Convert.IsDBNull(reader["Lop"]))?string.Empty:(System.String)reader["Lop"];
					entity.Phong = reader.IsDBNull(reader.GetOrdinal("Phong")) ? null : (System.String)reader["Phong"];
					//entity.Phong = (Convert.IsDBNull(reader["Phong"]))?string.Empty:(System.String)reader["Phong"];
					entity.ThoiDiemGhiNhan = reader.IsDBNull(reader.GetOrdinal("ThoiDiemGhiNhan")) ? null : (System.String)reader["ThoiDiemGhiNhan"];
					//entity.ThoiDiemGhiNhan = (Convert.IsDBNull(reader["ThoiDiemGhiNhan"]))?string.Empty:(System.String)reader["ThoiDiemGhiNhan"];
					entity.LyDo = reader.IsDBNull(reader.GetOrdinal("LyDo")) ? null : (System.String)reader["LyDo"];
					//entity.LyDo = (Convert.IsDBNull(reader["LyDo"]))?string.Empty:(System.String)reader["LyDo"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
					entity.MaHinhThucViPham = reader.IsDBNull(reader.GetOrdinal("MaHinhThucViPham")) ? null : (System.Guid?)reader["MaHinhThucViPham"];
					//entity.MaHinhThucViPham = (Convert.IsDBNull(reader["MaHinhThucViPham"]))?Guid.Empty:(System.Guid?)reader["MaHinhThucViPham"];
					entity.DaBaoSuaTkb = reader.IsDBNull(reader.GetOrdinal("DaBaoSuaTkb")) ? null : (System.Boolean?)reader["DaBaoSuaTkb"];
					//entity.DaBaoSuaTkb = (Convert.IsDBNull(reader["DaBaoSuaTkb"]))?false:(System.Boolean?)reader["DaBaoSuaTkb"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
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
		/// Refreshes the <see cref="ViewThanhTraGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThanhTraGiangDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThanhTraGiangDay entity)
		{
			reader.Read();
			entity.MaHienThi = reader.IsDBNull(reader.GetOrdinal("MaHienThi")) ? null : (System.String)reader["MaHienThi"];
			//entity.MaHienThi = (Convert.IsDBNull(reader["MaHienThi"]))?string.Empty:(System.String)reader["MaHienThi"];
			entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Khoa = (System.String)reader["Khoa"];
			//entity.Khoa = (Convert.IsDBNull(reader["Khoa"]))?string.Empty:(System.String)reader["Khoa"];
			entity.LoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("LoaiGiangVien")) ? null : (System.String)reader["LoaiGiangVien"];
			//entity.LoaiGiangVien = (Convert.IsDBNull(reader["LoaiGiangVien"]))?string.Empty:(System.String)reader["LoaiGiangVien"];
			entity.TenHocPhan = reader.IsDBNull(reader.GetOrdinal("TenHocPhan")) ? null : (System.String)reader["TenHocPhan"];
			//entity.TenHocPhan = (Convert.IsDBNull(reader["TenHocPhan"]))?string.Empty:(System.String)reader["TenHocPhan"];
			entity.TinhHinhGhiNhan = reader.IsDBNull(reader.GetOrdinal("TinhHinhGhiNhan")) ? null : (System.String)reader["TinhHinhGhiNhan"];
			//entity.TinhHinhGhiNhan = (Convert.IsDBNull(reader["TinhHinhGhiNhan"]))?string.Empty:(System.String)reader["TinhHinhGhiNhan"];
			entity.Ngay = reader.IsDBNull(reader.GetOrdinal("Ngay")) ? null : (System.DateTime?)reader["Ngay"];
			//entity.Ngay = (Convert.IsDBNull(reader["Ngay"]))?DateTime.MinValue:(System.DateTime?)reader["Ngay"];
			entity.Tiet = reader.IsDBNull(reader.GetOrdinal("Tiet")) ? null : (System.String)reader["Tiet"];
			//entity.Tiet = (Convert.IsDBNull(reader["Tiet"]))?string.Empty:(System.String)reader["Tiet"];
			entity.Lop = reader.IsDBNull(reader.GetOrdinal("Lop")) ? null : (System.String)reader["Lop"];
			//entity.Lop = (Convert.IsDBNull(reader["Lop"]))?string.Empty:(System.String)reader["Lop"];
			entity.Phong = reader.IsDBNull(reader.GetOrdinal("Phong")) ? null : (System.String)reader["Phong"];
			//entity.Phong = (Convert.IsDBNull(reader["Phong"]))?string.Empty:(System.String)reader["Phong"];
			entity.ThoiDiemGhiNhan = reader.IsDBNull(reader.GetOrdinal("ThoiDiemGhiNhan")) ? null : (System.String)reader["ThoiDiemGhiNhan"];
			//entity.ThoiDiemGhiNhan = (Convert.IsDBNull(reader["ThoiDiemGhiNhan"]))?string.Empty:(System.String)reader["ThoiDiemGhiNhan"];
			entity.LyDo = reader.IsDBNull(reader.GetOrdinal("LyDo")) ? null : (System.String)reader["LyDo"];
			//entity.LyDo = (Convert.IsDBNull(reader["LyDo"]))?string.Empty:(System.String)reader["LyDo"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
			entity.MaHinhThucViPham = reader.IsDBNull(reader.GetOrdinal("MaHinhThucViPham")) ? null : (System.Guid?)reader["MaHinhThucViPham"];
			//entity.MaHinhThucViPham = (Convert.IsDBNull(reader["MaHinhThucViPham"]))?Guid.Empty:(System.Guid?)reader["MaHinhThucViPham"];
			entity.DaBaoSuaTkb = reader.IsDBNull(reader.GetOrdinal("DaBaoSuaTkb")) ? null : (System.Boolean?)reader["DaBaoSuaTkb"];
			//entity.DaBaoSuaTkb = (Convert.IsDBNull(reader["DaBaoSuaTkb"]))?false:(System.Boolean?)reader["DaBaoSuaTkb"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThanhTraGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThanhTraGiangDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThanhTraGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHienThi = (Convert.IsDBNull(dataRow["MaHienThi"]))?string.Empty:(System.String)dataRow["MaHienThi"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Khoa = (Convert.IsDBNull(dataRow["Khoa"]))?string.Empty:(System.String)dataRow["Khoa"];
			entity.LoaiGiangVien = (Convert.IsDBNull(dataRow["LoaiGiangVien"]))?string.Empty:(System.String)dataRow["LoaiGiangVien"];
			entity.TenHocPhan = (Convert.IsDBNull(dataRow["TenHocPhan"]))?string.Empty:(System.String)dataRow["TenHocPhan"];
			entity.TinhHinhGhiNhan = (Convert.IsDBNull(dataRow["TinhHinhGhiNhan"]))?string.Empty:(System.String)dataRow["TinhHinhGhiNhan"];
			entity.Ngay = (Convert.IsDBNull(dataRow["Ngay"]))?DateTime.MinValue:(System.DateTime?)dataRow["Ngay"];
			entity.Tiet = (Convert.IsDBNull(dataRow["Tiet"]))?string.Empty:(System.String)dataRow["Tiet"];
			entity.Lop = (Convert.IsDBNull(dataRow["Lop"]))?string.Empty:(System.String)dataRow["Lop"];
			entity.Phong = (Convert.IsDBNull(dataRow["Phong"]))?string.Empty:(System.String)dataRow["Phong"];
			entity.ThoiDiemGhiNhan = (Convert.IsDBNull(dataRow["ThoiDiemGhiNhan"]))?string.Empty:(System.String)dataRow["ThoiDiemGhiNhan"];
			entity.LyDo = (Convert.IsDBNull(dataRow["LyDo"]))?string.Empty:(System.String)dataRow["LyDo"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?string.Empty:(System.String)dataRow["GhiChu"];
			entity.MaHinhThucViPham = (Convert.IsDBNull(dataRow["MaHinhThucViPham"]))?Guid.Empty:(System.Guid?)dataRow["MaHinhThucViPham"];
			entity.DaBaoSuaTkb = (Convert.IsDBNull(dataRow["DaBaoSuaTkb"]))?false:(System.Boolean?)dataRow["DaBaoSuaTkb"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThanhTraGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraGiangDayFilterBuilder : SqlFilterBuilder<ViewThanhTraGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraGiangDayFilterBuilder class.
		/// </summary>
		public ViewThanhTraGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThanhTraGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThanhTraGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThanhTraGiangDayFilterBuilder

	#region ViewThanhTraGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewThanhTraGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraGiangDayParameterBuilder class.
		/// </summary>
		public ViewThanhTraGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThanhTraGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThanhTraGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThanhTraGiangDayParameterBuilder
	
	#region ViewThanhTraGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThanhTraGiangDaySortBuilder : SqlSortBuilder<ViewThanhTraGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraGiangDaySqlSortBuilder class.
		/// </summary>
		public ViewThanhTraGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThanhTraGiangDaySortBuilder

} // end namespace
