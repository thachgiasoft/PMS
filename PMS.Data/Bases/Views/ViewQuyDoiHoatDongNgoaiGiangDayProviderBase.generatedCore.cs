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
	/// This class is the base class for any <see cref="ViewQuyDoiHoatDongNgoaiGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewQuyDoiHoatDongNgoaiGiangDayProviderBaseCore : EntityViewProviderBase<ViewQuyDoiHoatDongNgoaiGiangDay>
	{
		#region Custom Methods
		
		
		#region cust_view_QuyDoiHoatDongNgoaiGiangDay_GetByNamHocHocKyMaDonVi
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyDoiHoatDongNgoaiGiangDay_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public VList<ViewQuyDoiHoatDongNgoaiGiangDay> GetByNamHocHocKyMaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyDoiHoatDongNgoaiGiangDay_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public VList<ViewQuyDoiHoatDongNgoaiGiangDay> GetByNamHocHocKyMaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_QuyDoiHoatDongNgoaiGiangDay_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public VList<ViewQuyDoiHoatDongNgoaiGiangDay> GetByNamHocHocKyMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyDoiHoatDongNgoaiGiangDay_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewQuyDoiHoatDongNgoaiGiangDay> GetByNamHocHocKyMaDonVi(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion

		
		#region cust_view_QuyDoiHoatDongNgoaiGiangDay_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyDoiHoatDongNgoaiGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public VList<ViewQuyDoiHoatDongNgoaiGiangDay> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyDoiHoatDongNgoaiGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public VList<ViewQuyDoiHoatDongNgoaiGiangDay> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_QuyDoiHoatDongNgoaiGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public VList<ViewQuyDoiHoatDongNgoaiGiangDay> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_QuyDoiHoatDongNgoaiGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewQuyDoiHoatDongNgoaiGiangDay> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt;"/></returns>
		protected static VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt; Fill(DataSet dataSet, VList<ViewQuyDoiHoatDongNgoaiGiangDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewQuyDoiHoatDongNgoaiGiangDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewQuyDoiHoatDongNgoaiGiangDay>"/></returns>
		protected static VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt; Fill(DataTable dataTable, VList<ViewQuyDoiHoatDongNgoaiGiangDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewQuyDoiHoatDongNgoaiGiangDay c = new ViewQuyDoiHoatDongNgoaiGiangDay();
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.TenHoatDong = (Convert.IsDBNull(row["TenHoatDong"]))?string.Empty:(System.String)row["TenHoatDong"];
					c.SoLuong = (Convert.IsDBNull(row["SoLuong"]))?0.0m:(System.Decimal?)row["SoLuong"];
					c.MucQuyDoi = (Convert.IsDBNull(row["MucQuyDoi"]))?0.0m:(System.Decimal?)row["MucQuyDoi"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal?)row["DonGia"];
					c.SoTietQuyDoi = (Convert.IsDBNull(row["SoTietQuyDoi"]))?0.0m:(System.Decimal?)row["SoTietQuyDoi"];
					c.SoTien = (Convert.IsDBNull(row["SoTien"]))?0.0m:(System.Decimal?)row["SoTien"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
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
		/// Fill an <see cref="VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewQuyDoiHoatDongNgoaiGiangDay&gt;"/></returns>
		protected VList<ViewQuyDoiHoatDongNgoaiGiangDay> Fill(IDataReader reader, VList<ViewQuyDoiHoatDongNgoaiGiangDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewQuyDoiHoatDongNgoaiGiangDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewQuyDoiHoatDongNgoaiGiangDay>("ViewQuyDoiHoatDongNgoaiGiangDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewQuyDoiHoatDongNgoaiGiangDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.TenHoatDong = reader.IsDBNull(reader.GetOrdinal("TenHoatDong")) ? null : (System.String)reader["TenHoatDong"];
					//entity.TenHoatDong = (Convert.IsDBNull(reader["TenHoatDong"]))?string.Empty:(System.String)reader["TenHoatDong"];
					entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Decimal?)reader["SoLuong"];
					//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?0.0m:(System.Decimal?)reader["SoLuong"];
					entity.MucQuyDoi = reader.IsDBNull(reader.GetOrdinal("MucQuyDoi")) ? null : (System.Decimal?)reader["MucQuyDoi"];
					//entity.MucQuyDoi = (Convert.IsDBNull(reader["MucQuyDoi"]))?0.0m:(System.Decimal?)reader["MucQuyDoi"];
					entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
					entity.SoTietQuyDoi = reader.IsDBNull(reader.GetOrdinal("SoTietQuyDoi")) ? null : (System.Decimal?)reader["SoTietQuyDoi"];
					//entity.SoTietQuyDoi = (Convert.IsDBNull(reader["SoTietQuyDoi"]))?0.0m:(System.Decimal?)reader["SoTietQuyDoi"];
					entity.SoTien = reader.IsDBNull(reader.GetOrdinal("SoTien")) ? null : (System.Decimal?)reader["SoTien"];
					//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0.0m:(System.Decimal?)reader["SoTien"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
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
		/// Refreshes the <see cref="ViewQuyDoiHoatDongNgoaiGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewQuyDoiHoatDongNgoaiGiangDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewQuyDoiHoatDongNgoaiGiangDay entity)
		{
			reader.Read();
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.TenHoatDong = reader.IsDBNull(reader.GetOrdinal("TenHoatDong")) ? null : (System.String)reader["TenHoatDong"];
			//entity.TenHoatDong = (Convert.IsDBNull(reader["TenHoatDong"]))?string.Empty:(System.String)reader["TenHoatDong"];
			entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Decimal?)reader["SoLuong"];
			//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?0.0m:(System.Decimal?)reader["SoLuong"];
			entity.MucQuyDoi = reader.IsDBNull(reader.GetOrdinal("MucQuyDoi")) ? null : (System.Decimal?)reader["MucQuyDoi"];
			//entity.MucQuyDoi = (Convert.IsDBNull(reader["MucQuyDoi"]))?0.0m:(System.Decimal?)reader["MucQuyDoi"];
			entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
			entity.SoTietQuyDoi = reader.IsDBNull(reader.GetOrdinal("SoTietQuyDoi")) ? null : (System.Decimal?)reader["SoTietQuyDoi"];
			//entity.SoTietQuyDoi = (Convert.IsDBNull(reader["SoTietQuyDoi"]))?0.0m:(System.Decimal?)reader["SoTietQuyDoi"];
			entity.SoTien = reader.IsDBNull(reader.GetOrdinal("SoTien")) ? null : (System.Decimal?)reader["SoTien"];
			//entity.SoTien = (Convert.IsDBNull(reader["SoTien"]))?0.0m:(System.Decimal?)reader["SoTien"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewQuyDoiHoatDongNgoaiGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewQuyDoiHoatDongNgoaiGiangDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewQuyDoiHoatDongNgoaiGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.TenHoatDong = (Convert.IsDBNull(dataRow["TenHoatDong"]))?string.Empty:(System.String)dataRow["TenHoatDong"];
			entity.SoLuong = (Convert.IsDBNull(dataRow["SoLuong"]))?0.0m:(System.Decimal?)dataRow["SoLuong"];
			entity.MucQuyDoi = (Convert.IsDBNull(dataRow["MucQuyDoi"]))?0.0m:(System.Decimal?)dataRow["MucQuyDoi"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal?)dataRow["DonGia"];
			entity.SoTietQuyDoi = (Convert.IsDBNull(dataRow["SoTietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["SoTietQuyDoi"];
			entity.SoTien = (Convert.IsDBNull(dataRow["SoTien"]))?0.0m:(System.Decimal?)dataRow["SoTien"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewQuyDoiHoatDongNgoaiGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewQuyDoiHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewQuyDoiHoatDongNgoaiGiangDayFilterBuilder : SqlFilterBuilder<ViewQuyDoiHoatDongNgoaiGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewQuyDoiHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		public ViewQuyDoiHoatDongNgoaiGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewQuyDoiHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewQuyDoiHoatDongNgoaiGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewQuyDoiHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewQuyDoiHoatDongNgoaiGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewQuyDoiHoatDongNgoaiGiangDayFilterBuilder

	#region ViewQuyDoiHoatDongNgoaiGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewQuyDoiHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewQuyDoiHoatDongNgoaiGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewQuyDoiHoatDongNgoaiGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewQuyDoiHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		public ViewQuyDoiHoatDongNgoaiGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewQuyDoiHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewQuyDoiHoatDongNgoaiGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewQuyDoiHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewQuyDoiHoatDongNgoaiGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewQuyDoiHoatDongNgoaiGiangDayParameterBuilder
	
	#region ViewQuyDoiHoatDongNgoaiGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewQuyDoiHoatDongNgoaiGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewQuyDoiHoatDongNgoaiGiangDaySortBuilder : SqlSortBuilder<ViewQuyDoiHoatDongNgoaiGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewQuyDoiHoatDongNgoaiGiangDaySqlSortBuilder class.
		/// </summary>
		public ViewQuyDoiHoatDongNgoaiGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewQuyDoiHoatDongNgoaiGiangDaySortBuilder

} // end namespace
