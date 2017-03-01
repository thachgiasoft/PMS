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
	/// This class is the base class for any <see cref="ViewKhoiLuongCacCongViecKhacProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKhoiLuongCacCongViecKhacProviderBaseCore : EntityViewProviderBase<ViewKhoiLuongCacCongViecKhac>
	{
		#region Custom Methods
		
		
		#region cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKyDotThanhToan
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKyDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongCacCongViecKhac> GetByNamHocHocKyDotThanhToan(System.String namHoc, System.String hocKy, System.Int32 dotThanhToan)
		{
			return GetByNamHocHocKyDotThanhToan(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKyDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongCacCongViecKhac> GetByNamHocHocKyDotThanhToan(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan)
		{
			return GetByNamHocHocKyDotThanhToan(null, start, pageLength , namHoc, hocKy, dotThanhToan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKyDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongCacCongViecKhac> GetByNamHocHocKyDotThanhToan(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan)
		{
			return GetByNamHocHocKyDotThanhToan(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKyDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/> instance.</returns>
		public abstract VList<ViewKhoiLuongCacCongViecKhac> GetByNamHocHocKyDotThanhToan(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan);
		
		#endregion

		
		#region cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongCacCongViecKhac> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongCacCongViecKhac> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongCacCongViecKhac> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/> instance.</returns>
		public abstract VList<ViewKhoiLuongCacCongViecKhac> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKyLoaiCongViecKhoaDonVi
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKyLoaiCongViecKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongCacCongViecKhac> GetByNamHocHocKyLoaiCongViecKhoaDonVi(System.String namHoc, System.String hocKy, System.String maKhoiLuong, System.String maDonVi)
		{
			return GetByNamHocHocKyLoaiCongViecKhoaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maKhoiLuong, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKyLoaiCongViecKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongCacCongViecKhac> GetByNamHocHocKyLoaiCongViecKhoaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maKhoiLuong, System.String maDonVi)
		{
			return GetByNamHocHocKyLoaiCongViecKhoaDonVi(null, start, pageLength , namHoc, hocKy, maKhoiLuong, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKyLoaiCongViecKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongCacCongViecKhac> GetByNamHocHocKyLoaiCongViecKhoaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maKhoiLuong, System.String maDonVi)
		{
			return GetByNamHocHocKyLoaiCongViecKhoaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maKhoiLuong, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuongCacCongViecKhac_GetByNamHocHocKyLoaiCongViecKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/> instance.</returns>
		public abstract VList<ViewKhoiLuongCacCongViecKhac> GetByNamHocHocKyLoaiCongViecKhoaDonVi(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maKhoiLuong, System.String maDonVi);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKhoiLuongCacCongViecKhac&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/></returns>
		protected static VList&lt;ViewKhoiLuongCacCongViecKhac&gt; Fill(DataSet dataSet, VList<ViewKhoiLuongCacCongViecKhac> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKhoiLuongCacCongViecKhac>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKhoiLuongCacCongViecKhac&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKhoiLuongCacCongViecKhac>"/></returns>
		protected static VList&lt;ViewKhoiLuongCacCongViecKhac&gt; Fill(DataTable dataTable, VList<ViewKhoiLuongCacCongViecKhac> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKhoiLuongCacCongViecKhac c = new ViewKhoiLuongCacCongViecKhac();
					c.Id = (Convert.IsDBNull(row["Id"]))?(int)0:(System.Int32)row["Id"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.MaGiangVienQuanLy = (Convert.IsDBNull(row["MaGiangVienQuanLy"]))?string.Empty:(System.String)row["MaGiangVienQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.MaLoaiCongViec = (Convert.IsDBNull(row["MaLoaiCongViec"]))?(int)0:(System.Int32)row["MaLoaiCongViec"];
					c.MaCongViec = (Convert.IsDBNull(row["MaCongViec"]))?string.Empty:(System.String)row["MaCongViec"];
					c.TenCongViec = (Convert.IsDBNull(row["TenCongViec"]))?string.Empty:(System.String)row["TenCongViec"];
					c.MaDonViTinh = (Convert.IsDBNull(row["MaDonViTinh"]))?(int)0:(System.Int32?)row["MaDonViTinh"];
					c.TenDonViTinh = (Convert.IsDBNull(row["TenDonViTinh"]))?string.Empty:(System.String)row["TenDonViTinh"];
					c.SoLuong = (Convert.IsDBNull(row["SoLuong"]))?0.0m:(System.Decimal?)row["SoLuong"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.MaNhom = (Convert.IsDBNull(row["MaNhom"]))?string.Empty:(System.String)row["MaNhom"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?string.Empty:(System.String)row["GhiChu"];
					c.HeSoQuyDoi = (Convert.IsDBNull(row["HeSoQuyDoi"]))?0.0m:(System.Decimal?)row["HeSoQuyDoi"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.Chot = (Convert.IsDBNull(row["Chot"]))?false:(System.Boolean?)row["Chot"];
					c.NgayCapNhat = (Convert.IsDBNull(row["NgayCapNhat"]))?string.Empty:(System.String)row["NgayCapNhat"];
					c.NguoiCapNhat = (Convert.IsDBNull(row["NguoiCapNhat"]))?string.Empty:(System.String)row["NguoiCapNhat"];
					c.MaLoaiKhoiLuong = (Convert.IsDBNull(row["MaLoaiKhoiLuong"]))?string.Empty:(System.String)row["MaLoaiKhoiLuong"];
					c.HeSoChucDanhKhoiLuongKhac = (Convert.IsDBNull(row["HeSoChucDanhKhoiLuongKhac"]))?0.0m:(System.Decimal?)row["HeSoChucDanhKhoiLuongKhac"];
					c.DotThanhToan = (Convert.IsDBNull(row["DotThanhToan"]))?string.Empty:(System.String)row["DotThanhToan"];
					c.HeSoNhan = (Convert.IsDBNull(row["HeSoNhan"]))?(int)0:(System.Int32?)row["HeSoNhan"];
					c.GioChuanCongThemTrenMotTiet = (Convert.IsDBNull(row["GioChuanCongThemTrenMotTiet"]))?0.0m:(System.Decimal?)row["GioChuanCongThemTrenMotTiet"];
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
		/// Fill an <see cref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKhoiLuongCacCongViecKhac&gt;"/></returns>
		protected VList<ViewKhoiLuongCacCongViecKhac> Fill(IDataReader reader, VList<ViewKhoiLuongCacCongViecKhac> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKhoiLuongCacCongViecKhac entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKhoiLuongCacCongViecKhac>("ViewKhoiLuongCacCongViecKhac",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKhoiLuongCacCongViecKhac();
					}
					
					entity.SuppressEntityEvents = true;

					entity.Id = (System.Int32)reader["Id"];
					//entity.Id = (Convert.IsDBNull(reader["Id"]))?(int)0:(System.Int32)reader["Id"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.MaGiangVienQuanLy = (System.String)reader["MaGiangVienQuanLy"];
					//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.MaLoaiCongViec = (System.Int32)reader["MaLoaiCongViec"];
					//entity.MaLoaiCongViec = (Convert.IsDBNull(reader["MaLoaiCongViec"]))?(int)0:(System.Int32)reader["MaLoaiCongViec"];
					entity.MaCongViec = (System.String)reader["MaCongViec"];
					//entity.MaCongViec = (Convert.IsDBNull(reader["MaCongViec"]))?string.Empty:(System.String)reader["MaCongViec"];
					entity.TenCongViec = reader.IsDBNull(reader.GetOrdinal("TenCongViec")) ? null : (System.String)reader["TenCongViec"];
					//entity.TenCongViec = (Convert.IsDBNull(reader["TenCongViec"]))?string.Empty:(System.String)reader["TenCongViec"];
					entity.MaDonViTinh = reader.IsDBNull(reader.GetOrdinal("MaDonViTinh")) ? null : (System.Int32?)reader["MaDonViTinh"];
					//entity.MaDonViTinh = (Convert.IsDBNull(reader["MaDonViTinh"]))?(int)0:(System.Int32?)reader["MaDonViTinh"];
					entity.TenDonViTinh = reader.IsDBNull(reader.GetOrdinal("TenDonViTinh")) ? null : (System.String)reader["TenDonViTinh"];
					//entity.TenDonViTinh = (Convert.IsDBNull(reader["TenDonViTinh"]))?string.Empty:(System.String)reader["TenDonViTinh"];
					entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Decimal?)reader["SoLuong"];
					//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?0.0m:(System.Decimal?)reader["SoLuong"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.MaNhom = reader.IsDBNull(reader.GetOrdinal("MaNhom")) ? null : (System.String)reader["MaNhom"];
					//entity.MaNhom = (Convert.IsDBNull(reader["MaNhom"]))?string.Empty:(System.String)reader["MaNhom"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
					entity.HeSoQuyDoi = reader.IsDBNull(reader.GetOrdinal("HeSoQuyDoi")) ? null : (System.Decimal?)reader["HeSoQuyDoi"];
					//entity.HeSoQuyDoi = (Convert.IsDBNull(reader["HeSoQuyDoi"]))?0.0m:(System.Decimal?)reader["HeSoQuyDoi"];
					entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.Chot = reader.IsDBNull(reader.GetOrdinal("Chot")) ? null : (System.Boolean?)reader["Chot"];
					//entity.Chot = (Convert.IsDBNull(reader["Chot"]))?false:(System.Boolean?)reader["Chot"];
					entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
					//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
					entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
					//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
					entity.MaLoaiKhoiLuong = reader.IsDBNull(reader.GetOrdinal("MaLoaiKhoiLuong")) ? null : (System.String)reader["MaLoaiKhoiLuong"];
					//entity.MaLoaiKhoiLuong = (Convert.IsDBNull(reader["MaLoaiKhoiLuong"]))?string.Empty:(System.String)reader["MaLoaiKhoiLuong"];
					entity.HeSoChucDanhKhoiLuongKhac = reader.IsDBNull(reader.GetOrdinal("HeSoChucDanhKhoiLuongKhac")) ? null : (System.Decimal?)reader["HeSoChucDanhKhoiLuongKhac"];
					//entity.HeSoChucDanhKhoiLuongKhac = (Convert.IsDBNull(reader["HeSoChucDanhKhoiLuongKhac"]))?0.0m:(System.Decimal?)reader["HeSoChucDanhKhoiLuongKhac"];
					entity.DotThanhToan = reader.IsDBNull(reader.GetOrdinal("DotThanhToan")) ? null : (System.String)reader["DotThanhToan"];
					//entity.DotThanhToan = (Convert.IsDBNull(reader["DotThanhToan"]))?string.Empty:(System.String)reader["DotThanhToan"];
					entity.HeSoNhan = reader.IsDBNull(reader.GetOrdinal("HeSoNhan")) ? null : (System.Int32?)reader["HeSoNhan"];
					//entity.HeSoNhan = (Convert.IsDBNull(reader["HeSoNhan"]))?(int)0:(System.Int32?)reader["HeSoNhan"];
					entity.GioChuanCongThemTrenMotTiet = reader.IsDBNull(reader.GetOrdinal("GioChuanCongThemTrenMotTiet")) ? null : (System.Decimal?)reader["GioChuanCongThemTrenMotTiet"];
					//entity.GioChuanCongThemTrenMotTiet = (Convert.IsDBNull(reader["GioChuanCongThemTrenMotTiet"]))?0.0m:(System.Decimal?)reader["GioChuanCongThemTrenMotTiet"];
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
		/// Refreshes the <see cref="ViewKhoiLuongCacCongViecKhac"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoiLuongCacCongViecKhac"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKhoiLuongCacCongViecKhac entity)
		{
			reader.Read();
			entity.Id = (System.Int32)reader["Id"];
			//entity.Id = (Convert.IsDBNull(reader["Id"]))?(int)0:(System.Int32)reader["Id"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaGiangVien = reader.IsDBNull(reader.GetOrdinal("MaGiangVien")) ? null : (System.Int32?)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.MaGiangVienQuanLy = (System.String)reader["MaGiangVienQuanLy"];
			//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.MaLoaiCongViec = (System.Int32)reader["MaLoaiCongViec"];
			//entity.MaLoaiCongViec = (Convert.IsDBNull(reader["MaLoaiCongViec"]))?(int)0:(System.Int32)reader["MaLoaiCongViec"];
			entity.MaCongViec = (System.String)reader["MaCongViec"];
			//entity.MaCongViec = (Convert.IsDBNull(reader["MaCongViec"]))?string.Empty:(System.String)reader["MaCongViec"];
			entity.TenCongViec = reader.IsDBNull(reader.GetOrdinal("TenCongViec")) ? null : (System.String)reader["TenCongViec"];
			//entity.TenCongViec = (Convert.IsDBNull(reader["TenCongViec"]))?string.Empty:(System.String)reader["TenCongViec"];
			entity.MaDonViTinh = reader.IsDBNull(reader.GetOrdinal("MaDonViTinh")) ? null : (System.Int32?)reader["MaDonViTinh"];
			//entity.MaDonViTinh = (Convert.IsDBNull(reader["MaDonViTinh"]))?(int)0:(System.Int32?)reader["MaDonViTinh"];
			entity.TenDonViTinh = reader.IsDBNull(reader.GetOrdinal("TenDonViTinh")) ? null : (System.String)reader["TenDonViTinh"];
			//entity.TenDonViTinh = (Convert.IsDBNull(reader["TenDonViTinh"]))?string.Empty:(System.String)reader["TenDonViTinh"];
			entity.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? null : (System.Decimal?)reader["SoLuong"];
			//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?0.0m:(System.Decimal?)reader["SoLuong"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.MaNhom = reader.IsDBNull(reader.GetOrdinal("MaNhom")) ? null : (System.String)reader["MaNhom"];
			//entity.MaNhom = (Convert.IsDBNull(reader["MaNhom"]))?string.Empty:(System.String)reader["MaNhom"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
			entity.HeSoQuyDoi = reader.IsDBNull(reader.GetOrdinal("HeSoQuyDoi")) ? null : (System.Decimal?)reader["HeSoQuyDoi"];
			//entity.HeSoQuyDoi = (Convert.IsDBNull(reader["HeSoQuyDoi"]))?0.0m:(System.Decimal?)reader["HeSoQuyDoi"];
			entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.Chot = reader.IsDBNull(reader.GetOrdinal("Chot")) ? null : (System.Boolean?)reader["Chot"];
			//entity.Chot = (Convert.IsDBNull(reader["Chot"]))?false:(System.Boolean?)reader["Chot"];
			entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
			entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
			//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
			entity.MaLoaiKhoiLuong = reader.IsDBNull(reader.GetOrdinal("MaLoaiKhoiLuong")) ? null : (System.String)reader["MaLoaiKhoiLuong"];
			//entity.MaLoaiKhoiLuong = (Convert.IsDBNull(reader["MaLoaiKhoiLuong"]))?string.Empty:(System.String)reader["MaLoaiKhoiLuong"];
			entity.HeSoChucDanhKhoiLuongKhac = reader.IsDBNull(reader.GetOrdinal("HeSoChucDanhKhoiLuongKhac")) ? null : (System.Decimal?)reader["HeSoChucDanhKhoiLuongKhac"];
			//entity.HeSoChucDanhKhoiLuongKhac = (Convert.IsDBNull(reader["HeSoChucDanhKhoiLuongKhac"]))?0.0m:(System.Decimal?)reader["HeSoChucDanhKhoiLuongKhac"];
			entity.DotThanhToan = reader.IsDBNull(reader.GetOrdinal("DotThanhToan")) ? null : (System.String)reader["DotThanhToan"];
			//entity.DotThanhToan = (Convert.IsDBNull(reader["DotThanhToan"]))?string.Empty:(System.String)reader["DotThanhToan"];
			entity.HeSoNhan = reader.IsDBNull(reader.GetOrdinal("HeSoNhan")) ? null : (System.Int32?)reader["HeSoNhan"];
			//entity.HeSoNhan = (Convert.IsDBNull(reader["HeSoNhan"]))?(int)0:(System.Int32?)reader["HeSoNhan"];
			entity.GioChuanCongThemTrenMotTiet = reader.IsDBNull(reader.GetOrdinal("GioChuanCongThemTrenMotTiet")) ? null : (System.Decimal?)reader["GioChuanCongThemTrenMotTiet"];
			//entity.GioChuanCongThemTrenMotTiet = (Convert.IsDBNull(reader["GioChuanCongThemTrenMotTiet"]))?0.0m:(System.Decimal?)reader["GioChuanCongThemTrenMotTiet"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKhoiLuongCacCongViecKhac"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoiLuongCacCongViecKhac"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKhoiLuongCacCongViecKhac entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (Convert.IsDBNull(dataRow["Id"]))?(int)0:(System.Int32)dataRow["Id"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.MaGiangVienQuanLy = (Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]))?string.Empty:(System.String)dataRow["MaGiangVienQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.MaLoaiCongViec = (Convert.IsDBNull(dataRow["MaLoaiCongViec"]))?(int)0:(System.Int32)dataRow["MaLoaiCongViec"];
			entity.MaCongViec = (Convert.IsDBNull(dataRow["MaCongViec"]))?string.Empty:(System.String)dataRow["MaCongViec"];
			entity.TenCongViec = (Convert.IsDBNull(dataRow["TenCongViec"]))?string.Empty:(System.String)dataRow["TenCongViec"];
			entity.MaDonViTinh = (Convert.IsDBNull(dataRow["MaDonViTinh"]))?(int)0:(System.Int32?)dataRow["MaDonViTinh"];
			entity.TenDonViTinh = (Convert.IsDBNull(dataRow["TenDonViTinh"]))?string.Empty:(System.String)dataRow["TenDonViTinh"];
			entity.SoLuong = (Convert.IsDBNull(dataRow["SoLuong"]))?0.0m:(System.Decimal?)dataRow["SoLuong"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.MaNhom = (Convert.IsDBNull(dataRow["MaNhom"]))?string.Empty:(System.String)dataRow["MaNhom"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?string.Empty:(System.String)dataRow["GhiChu"];
			entity.HeSoQuyDoi = (Convert.IsDBNull(dataRow["HeSoQuyDoi"]))?0.0m:(System.Decimal?)dataRow["HeSoQuyDoi"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.Chot = (Convert.IsDBNull(dataRow["Chot"]))?false:(System.Boolean?)dataRow["Chot"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?string.Empty:(System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = (Convert.IsDBNull(dataRow["NguoiCapNhat"]))?string.Empty:(System.String)dataRow["NguoiCapNhat"];
			entity.MaLoaiKhoiLuong = (Convert.IsDBNull(dataRow["MaLoaiKhoiLuong"]))?string.Empty:(System.String)dataRow["MaLoaiKhoiLuong"];
			entity.HeSoChucDanhKhoiLuongKhac = (Convert.IsDBNull(dataRow["HeSoChucDanhKhoiLuongKhac"]))?0.0m:(System.Decimal?)dataRow["HeSoChucDanhKhoiLuongKhac"];
			entity.DotThanhToan = (Convert.IsDBNull(dataRow["DotThanhToan"]))?string.Empty:(System.String)dataRow["DotThanhToan"];
			entity.HeSoNhan = (Convert.IsDBNull(dataRow["HeSoNhan"]))?(int)0:(System.Int32?)dataRow["HeSoNhan"];
			entity.GioChuanCongThemTrenMotTiet = (Convert.IsDBNull(dataRow["GioChuanCongThemTrenMotTiet"]))?0.0m:(System.Decimal?)dataRow["GioChuanCongThemTrenMotTiet"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKhoiLuongCacCongViecKhacFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongCacCongViecKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongCacCongViecKhacFilterBuilder : SqlFilterBuilder<ViewKhoiLuongCacCongViecKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongCacCongViecKhacFilterBuilder class.
		/// </summary>
		public ViewKhoiLuongCacCongViecKhacFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongCacCongViecKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoiLuongCacCongViecKhacFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongCacCongViecKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoiLuongCacCongViecKhacFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoiLuongCacCongViecKhacFilterBuilder

	#region ViewKhoiLuongCacCongViecKhacParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongCacCongViecKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongCacCongViecKhacParameterBuilder : ParameterizedSqlFilterBuilder<ViewKhoiLuongCacCongViecKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongCacCongViecKhacParameterBuilder class.
		/// </summary>
		public ViewKhoiLuongCacCongViecKhacParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongCacCongViecKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoiLuongCacCongViecKhacParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongCacCongViecKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoiLuongCacCongViecKhacParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoiLuongCacCongViecKhacParameterBuilder
	
	#region ViewKhoiLuongCacCongViecKhacSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongCacCongViecKhac"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKhoiLuongCacCongViecKhacSortBuilder : SqlSortBuilder<ViewKhoiLuongCacCongViecKhacColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongCacCongViecKhacSqlSortBuilder class.
		/// </summary>
		public ViewKhoiLuongCacCongViecKhacSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKhoiLuongCacCongViecKhacSortBuilder

} // end namespace
