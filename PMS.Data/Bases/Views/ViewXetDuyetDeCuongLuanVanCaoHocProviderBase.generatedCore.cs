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
	/// This class is the base class for any <see cref="ViewXetDuyetDeCuongLuanVanCaoHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewXetDuyetDeCuongLuanVanCaoHocProviderBaseCore : EntityViewProviderBase<ViewXetDuyetDeCuongLuanVanCaoHoc>
	{
		#region Custom Methods
		
		
		#region cust_View_XetDuyetDeCuongLuanVanCaoHoc_GetBYNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_XetDuyetDeCuongLuanVanCaoHoc_GetBYNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewXetDuyetDeCuongLuanVanCaoHoc&gt;"/> instance.</returns>
		public VList<ViewXetDuyetDeCuongLuanVanCaoHoc> GetBYNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetBYNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_XetDuyetDeCuongLuanVanCaoHoc_GetBYNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewXetDuyetDeCuongLuanVanCaoHoc&gt;"/> instance.</returns>
		public VList<ViewXetDuyetDeCuongLuanVanCaoHoc> GetBYNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetBYNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_XetDuyetDeCuongLuanVanCaoHoc_GetBYNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewXetDuyetDeCuongLuanVanCaoHoc&gt;"/> instance.</returns>
		public VList<ViewXetDuyetDeCuongLuanVanCaoHoc> GetBYNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetBYNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_XetDuyetDeCuongLuanVanCaoHoc_GetBYNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewXetDuyetDeCuongLuanVanCaoHoc&gt;"/> instance.</returns>
		public abstract VList<ViewXetDuyetDeCuongLuanVanCaoHoc> GetBYNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewXetDuyetDeCuongLuanVanCaoHoc&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewXetDuyetDeCuongLuanVanCaoHoc&gt;"/></returns>
		protected static VList&lt;ViewXetDuyetDeCuongLuanVanCaoHoc&gt; Fill(DataSet dataSet, VList<ViewXetDuyetDeCuongLuanVanCaoHoc> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewXetDuyetDeCuongLuanVanCaoHoc>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewXetDuyetDeCuongLuanVanCaoHoc&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewXetDuyetDeCuongLuanVanCaoHoc>"/></returns>
		protected static VList&lt;ViewXetDuyetDeCuongLuanVanCaoHoc&gt; Fill(DataTable dataTable, VList<ViewXetDuyetDeCuongLuanVanCaoHoc> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewXetDuyetDeCuongLuanVanCaoHoc c = new ViewXetDuyetDeCuongLuanVanCaoHoc();
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.MaKhoaHoc = (Convert.IsDBNull(row["MaKhoaHoc"]))?string.Empty:(System.String)row["MaKhoaHoc"];
					c.TenKhoaHoc = (Convert.IsDBNull(row["TenKhoaHoc"]))?string.Empty:(System.String)row["TenKhoaHoc"];
					c.SoLuong = (Convert.IsDBNull(row["SoLuong"]))?(int)0:(System.Int32?)row["SoLuong"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal?)row["DonGia"];
					c.ThanhTien = (Convert.IsDBNull(row["ThanhTien"]))?0.0m:(System.Decimal?)row["ThanhTien"];
					c.Thue = (Convert.IsDBNull(row["Thue"]))?0.0m:(System.Decimal?)row["Thue"];
					c.ThucLinh = (Convert.IsDBNull(row["ThucLinh"]))?0.0m:(System.Decimal?)row["ThucLinh"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?string.Empty:(System.String)row["GhiChu"];
					c.NgayCapNhat = (Convert.IsDBNull(row["NgayCapNhat"]))?string.Empty:(System.String)row["NgayCapNhat"];
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
		/// Fill an <see cref="VList&lt;ViewXetDuyetDeCuongLuanVanCaoHoc&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewXetDuyetDeCuongLuanVanCaoHoc&gt;"/></returns>
		protected VList<ViewXetDuyetDeCuongLuanVanCaoHoc> Fill(IDataReader reader, VList<ViewXetDuyetDeCuongLuanVanCaoHoc> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewXetDuyetDeCuongLuanVanCaoHoc entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewXetDuyetDeCuongLuanVanCaoHoc>("ViewXetDuyetDeCuongLuanVanCaoHoc",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewXetDuyetDeCuongLuanVanCaoHoc();
					}
					
					entity.SuppressEntityEvents = true;

					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.TenDonVi = (System.String)reader["TenDonVi"];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.MaKhoaHoc = reader.IsDBNull(reader.GetOrdinal("MaKhoaHoc")) ? null : (System.String)reader["MaKhoaHoc"];
					//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
					entity.TenKhoaHoc = reader.IsDBNull(reader.GetOrdinal("TenKhoaHoc")) ? null : (System.String)reader["TenKhoaHoc"];
					//entity.TenKhoaHoc = (Convert.IsDBNull(reader["TenKhoaHoc"]))?string.Empty:(System.String)reader["TenKhoaHoc"];
					entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Int32?)reader["SoLuong"];
					//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
					entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
					entity.ThanhTien = reader.IsDBNull(reader.GetOrdinal("ThanhTien")) ? null : (System.Decimal?)reader["ThanhTien"];
					//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?0.0m:(System.Decimal?)reader["ThanhTien"];
					entity.Thue = reader.IsDBNull(reader.GetOrdinal("Thue")) ? null : (System.Decimal?)reader["Thue"];
					//entity.Thue = (Convert.IsDBNull(reader["Thue"]))?0.0m:(System.Decimal?)reader["Thue"];
					entity.ThucLinh = reader.IsDBNull(reader.GetOrdinal("ThucLinh")) ? null : (System.Decimal?)reader["ThucLinh"];
					//entity.ThucLinh = (Convert.IsDBNull(reader["ThucLinh"]))?0.0m:(System.Decimal?)reader["ThucLinh"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
					entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
					//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
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
		/// Refreshes the <see cref="ViewXetDuyetDeCuongLuanVanCaoHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewXetDuyetDeCuongLuanVanCaoHoc"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewXetDuyetDeCuongLuanVanCaoHoc entity)
		{
			reader.Read();
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.TenDonVi = (System.String)reader["TenDonVi"];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.MaKhoaHoc = reader.IsDBNull(reader.GetOrdinal("MaKhoaHoc")) ? null : (System.String)reader["MaKhoaHoc"];
			//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
			entity.TenKhoaHoc = reader.IsDBNull(reader.GetOrdinal("TenKhoaHoc")) ? null : (System.String)reader["TenKhoaHoc"];
			//entity.TenKhoaHoc = (Convert.IsDBNull(reader["TenKhoaHoc"]))?string.Empty:(System.String)reader["TenKhoaHoc"];
			entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Int32?)reader["SoLuong"];
			//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32?)reader["SoLuong"];
			entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
			entity.ThanhTien = reader.IsDBNull(reader.GetOrdinal("ThanhTien")) ? null : (System.Decimal?)reader["ThanhTien"];
			//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?0.0m:(System.Decimal?)reader["ThanhTien"];
			entity.Thue = reader.IsDBNull(reader.GetOrdinal("Thue")) ? null : (System.Decimal?)reader["Thue"];
			//entity.Thue = (Convert.IsDBNull(reader["Thue"]))?0.0m:(System.Decimal?)reader["Thue"];
			entity.ThucLinh = reader.IsDBNull(reader.GetOrdinal("ThucLinh")) ? null : (System.Decimal?)reader["ThucLinh"];
			//entity.ThucLinh = (Convert.IsDBNull(reader["ThucLinh"]))?0.0m:(System.Decimal?)reader["ThucLinh"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
			entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
			entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
			//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewXetDuyetDeCuongLuanVanCaoHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewXetDuyetDeCuongLuanVanCaoHoc"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewXetDuyetDeCuongLuanVanCaoHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.MaKhoaHoc = (Convert.IsDBNull(dataRow["MaKhoaHoc"]))?string.Empty:(System.String)dataRow["MaKhoaHoc"];
			entity.TenKhoaHoc = (Convert.IsDBNull(dataRow["TenKhoaHoc"]))?string.Empty:(System.String)dataRow["TenKhoaHoc"];
			entity.SoLuong = (Convert.IsDBNull(dataRow["SoLuong"]))?(int)0:(System.Int32?)dataRow["SoLuong"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal?)dataRow["DonGia"];
			entity.ThanhTien = (Convert.IsDBNull(dataRow["ThanhTien"]))?0.0m:(System.Decimal?)dataRow["ThanhTien"];
			entity.Thue = (Convert.IsDBNull(dataRow["Thue"]))?0.0m:(System.Decimal?)dataRow["Thue"];
			entity.ThucLinh = (Convert.IsDBNull(dataRow["ThucLinh"]))?0.0m:(System.Decimal?)dataRow["ThucLinh"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?string.Empty:(System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?string.Empty:(System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = (Convert.IsDBNull(dataRow["NguoiCapNhat"]))?string.Empty:(System.String)dataRow["NguoiCapNhat"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewXetDuyetDeCuongLuanVanCaoHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewXetDuyetDeCuongLuanVanCaoHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewXetDuyetDeCuongLuanVanCaoHocFilterBuilder : SqlFilterBuilder<ViewXetDuyetDeCuongLuanVanCaoHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewXetDuyetDeCuongLuanVanCaoHocFilterBuilder class.
		/// </summary>
		public ViewXetDuyetDeCuongLuanVanCaoHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewXetDuyetDeCuongLuanVanCaoHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewXetDuyetDeCuongLuanVanCaoHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewXetDuyetDeCuongLuanVanCaoHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewXetDuyetDeCuongLuanVanCaoHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewXetDuyetDeCuongLuanVanCaoHocFilterBuilder

	#region ViewXetDuyetDeCuongLuanVanCaoHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewXetDuyetDeCuongLuanVanCaoHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewXetDuyetDeCuongLuanVanCaoHocParameterBuilder : ParameterizedSqlFilterBuilder<ViewXetDuyetDeCuongLuanVanCaoHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewXetDuyetDeCuongLuanVanCaoHocParameterBuilder class.
		/// </summary>
		public ViewXetDuyetDeCuongLuanVanCaoHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewXetDuyetDeCuongLuanVanCaoHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewXetDuyetDeCuongLuanVanCaoHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewXetDuyetDeCuongLuanVanCaoHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewXetDuyetDeCuongLuanVanCaoHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewXetDuyetDeCuongLuanVanCaoHocParameterBuilder
	
	#region ViewXetDuyetDeCuongLuanVanCaoHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewXetDuyetDeCuongLuanVanCaoHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewXetDuyetDeCuongLuanVanCaoHocSortBuilder : SqlSortBuilder<ViewXetDuyetDeCuongLuanVanCaoHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewXetDuyetDeCuongLuanVanCaoHocSqlSortBuilder class.
		/// </summary>
		public ViewXetDuyetDeCuongLuanVanCaoHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewXetDuyetDeCuongLuanVanCaoHocSortBuilder

} // end namespace
