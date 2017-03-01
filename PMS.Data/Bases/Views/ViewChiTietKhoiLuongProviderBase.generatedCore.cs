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
	/// This class is the base class for any <see cref="ViewChiTietKhoiLuongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewChiTietKhoiLuongProviderBaseCore : EntityViewProviderBase<ViewChiTietKhoiLuong>
	{
		#region Custom Methods
		
		
		#region cust_View_ChiTiet_KhoiLuong_GetByNamHocHocKyMaDonViMaGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_GetByNamHocHocKyMaDonViMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietKhoiLuong&gt;"/> instance.</returns>
		public VList<ViewChiTietKhoiLuong> GetByNamHocHocKyMaDonViMaGiangVien(System.String namHoc, System.String hocKy, System.String maBoMon, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyMaDonViMaGiangVien(null, 0, int.MaxValue , namHoc, hocKy, maBoMon, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_GetByNamHocHocKyMaDonViMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietKhoiLuong&gt;"/> instance.</returns>
		public VList<ViewChiTietKhoiLuong> GetByNamHocHocKyMaDonViMaGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maBoMon, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyMaDonViMaGiangVien(null, start, pageLength , namHoc, hocKy, maBoMon, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_GetByNamHocHocKyMaDonViMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewChiTietKhoiLuong&gt;"/> instance.</returns>
		public VList<ViewChiTietKhoiLuong> GetByNamHocHocKyMaDonViMaGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maBoMon, System.Int32 maGiangVien)
		{
			return GetByNamHocHocKyMaDonViMaGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, maBoMon, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_GetByNamHocHocKyMaDonViMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewChiTietKhoiLuong&gt;"/> instance.</returns>
		public abstract VList<ViewChiTietKhoiLuong> GetByNamHocHocKyMaDonViMaGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maBoMon, System.Int32 maGiangVien);
		
		#endregion

		
		#region cust_View_ChiTiet_KhoiLuong_GiangDay_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_GiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GiangDay_GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GiangDay_GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_GiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GiangDay_GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GiangDay_GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_GiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GiangDay_GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GiangDay_GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_GiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GiangDay_GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_ChiTiet_KhoiLuong_ThucDay_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_ThucDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThucDay_GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return ThucDay_GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_ThucDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThucDay_GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return ThucDay_GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_ThucDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThucDay_GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return ThucDay_GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_KhoiLuong_ThucDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThucDay_GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewChiTietKhoiLuong&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewChiTietKhoiLuong&gt;"/></returns>
		protected static VList&lt;ViewChiTietKhoiLuong&gt; Fill(DataSet dataSet, VList<ViewChiTietKhoiLuong> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewChiTietKhoiLuong>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewChiTietKhoiLuong&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewChiTietKhoiLuong>"/></returns>
		protected static VList&lt;ViewChiTietKhoiLuong&gt; Fill(DataTable dataTable, VList<ViewChiTietKhoiLuong> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewChiTietKhoiLuong c = new ViewChiTietKhoiLuong();
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.MaKhoa = (Convert.IsDBNull(row["MaKhoa"]))?string.Empty:(System.String)row["MaKhoa"];
					c.MaBoMon = (Convert.IsDBNull(row["MaBoMon"]))?string.Empty:(System.String)row["MaBoMon"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.MaNhom = (Convert.IsDBNull(row["MaNhom"]))?string.Empty:(System.String)row["MaNhom"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.SiSoLop = (Convert.IsDBNull(row["SiSoLop"]))?(int)0:(System.Int32?)row["SiSoLop"];
					c.TrongGio = (Convert.IsDBNull(row["TrongGio"]))?0.0m:(System.Decimal?)row["TrongGio"];
					c.ChatLuongCao = (Convert.IsDBNull(row["ChatLuongCao"]))?0.0m:(System.Decimal?)row["ChatLuongCao"];
					c.NgoaiGio = (Convert.IsDBNull(row["NgoaiGio"]))?0.0m:(System.Decimal?)row["NgoaiGio"];
					c.HeSoThanhPhan = (Convert.IsDBNull(row["HeSoThanhPhan"]))?0.0m:(System.Decimal?)row["HeSoThanhPhan"];
					c.HeSoLopDong = (Convert.IsDBNull(row["HeSoLopDong"]))?0.0m:(System.Decimal?)row["HeSoLopDong"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal?)row["DonGia"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.MaLoaiKhoiLuong = (Convert.IsDBNull(row["MaLoaiKhoiLuong"]))?string.Empty:(System.String)row["MaLoaiKhoiLuong"];
					c.TenLoaiKhoiLuong = (Convert.IsDBNull(row["TenLoaiKhoiLuong"]))?string.Empty:(System.String)row["TenLoaiKhoiLuong"];
					c.PhanLoai = (Convert.IsDBNull(row["PhanLoai"]))?string.Empty:(System.String)row["PhanLoai"];
					c.NghiaVu = (Convert.IsDBNull(row["NghiaVu"]))?false:(System.Boolean?)row["NghiaVu"];
					c.NguongTiet = (Convert.IsDBNull(row["NguongTiet"]))?(int)0:(System.Int32?)row["NguongTiet"];
					c.TietNghiaVu = (Convert.IsDBNull(row["TietNghiaVu"]))?0.0m:(System.Decimal?)row["TietNghiaVu"];
					c.ThanhTien = (Convert.IsDBNull(row["ThanhTien"]))?0.0m:(System.Decimal?)row["ThanhTien"];
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
		/// Fill an <see cref="VList&lt;ViewChiTietKhoiLuong&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewChiTietKhoiLuong&gt;"/></returns>
		protected VList<ViewChiTietKhoiLuong> Fill(IDataReader reader, VList<ViewChiTietKhoiLuong> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewChiTietKhoiLuong entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewChiTietKhoiLuong>("ViewChiTietKhoiLuong",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewChiTietKhoiLuong();
					}
					
					entity.SuppressEntityEvents = true;

					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
					//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
					entity.MaBoMon = reader.IsDBNull(reader.GetOrdinal("MaBoMon")) ? null : (System.String)reader["MaBoMon"];
					//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
					entity.MaMonHoc = (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = reader.IsDBNull(reader.GetOrdinal("TenMonHoc")) ? null : (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.MaNhom = reader.IsDBNull(reader.GetOrdinal("MaNhom")) ? null : (System.String)reader["MaNhom"];
					//entity.MaNhom = (Convert.IsDBNull(reader["MaNhom"]))?string.Empty:(System.String)reader["MaNhom"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.SiSoLop = reader.IsDBNull(reader.GetOrdinal("SiSoLop")) ? null : (System.Int32?)reader["SiSoLop"];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
					entity.TrongGio = reader.IsDBNull(reader.GetOrdinal("TrongGio")) ? null : (System.Decimal?)reader["TrongGio"];
					//entity.TrongGio = (Convert.IsDBNull(reader["TrongGio"]))?0.0m:(System.Decimal?)reader["TrongGio"];
					entity.ChatLuongCao = reader.IsDBNull(reader.GetOrdinal("ChatLuongCao")) ? null : (System.Decimal?)reader["ChatLuongCao"];
					//entity.ChatLuongCao = (Convert.IsDBNull(reader["ChatLuongCao"]))?0.0m:(System.Decimal?)reader["ChatLuongCao"];
					entity.NgoaiGio = reader.IsDBNull(reader.GetOrdinal("NgoaiGio")) ? null : (System.Decimal?)reader["NgoaiGio"];
					//entity.NgoaiGio = (Convert.IsDBNull(reader["NgoaiGio"]))?0.0m:(System.Decimal?)reader["NgoaiGio"];
					entity.HeSoThanhPhan = reader.IsDBNull(reader.GetOrdinal("HeSoThanhPhan")) ? null : (System.Decimal?)reader["HeSoThanhPhan"];
					//entity.HeSoThanhPhan = (Convert.IsDBNull(reader["HeSoThanhPhan"]))?0.0m:(System.Decimal?)reader["HeSoThanhPhan"];
					entity.HeSoLopDong = reader.IsDBNull(reader.GetOrdinal("HeSoLopDong")) ? null : (System.Decimal?)reader["HeSoLopDong"];
					//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
					entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
					entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.MaLoaiKhoiLuong = reader.IsDBNull(reader.GetOrdinal("MaLoaiKhoiLuong")) ? null : (System.String)reader["MaLoaiKhoiLuong"];
					//entity.MaLoaiKhoiLuong = (Convert.IsDBNull(reader["MaLoaiKhoiLuong"]))?string.Empty:(System.String)reader["MaLoaiKhoiLuong"];
					entity.TenLoaiKhoiLuong = reader.IsDBNull(reader.GetOrdinal("TenLoaiKhoiLuong")) ? null : (System.String)reader["TenLoaiKhoiLuong"];
					//entity.TenLoaiKhoiLuong = (Convert.IsDBNull(reader["TenLoaiKhoiLuong"]))?string.Empty:(System.String)reader["TenLoaiKhoiLuong"];
					entity.PhanLoai = reader.IsDBNull(reader.GetOrdinal("PhanLoai")) ? null : (System.String)reader["PhanLoai"];
					//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
					entity.NghiaVu = reader.IsDBNull(reader.GetOrdinal("NghiaVu")) ? null : (System.Boolean?)reader["NghiaVu"];
					//entity.NghiaVu = (Convert.IsDBNull(reader["NghiaVu"]))?false:(System.Boolean?)reader["NghiaVu"];
					entity.NguongTiet = reader.IsDBNull(reader.GetOrdinal("NguongTiet")) ? null : (System.Int32?)reader["NguongTiet"];
					//entity.NguongTiet = (Convert.IsDBNull(reader["NguongTiet"]))?(int)0:(System.Int32?)reader["NguongTiet"];
					entity.TietNghiaVu = reader.IsDBNull(reader.GetOrdinal("TietNghiaVu")) ? null : (System.Decimal?)reader["TietNghiaVu"];
					//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?0.0m:(System.Decimal?)reader["TietNghiaVu"];
					entity.ThanhTien = reader.IsDBNull(reader.GetOrdinal("ThanhTien")) ? null : (System.Decimal?)reader["ThanhTien"];
					//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?0.0m:(System.Decimal?)reader["ThanhTien"];
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
		/// Refreshes the <see cref="ViewChiTietKhoiLuong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTietKhoiLuong"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewChiTietKhoiLuong entity)
		{
			reader.Read();
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.MaKhoa = reader.IsDBNull(reader.GetOrdinal("MaKhoa")) ? null : (System.String)reader["MaKhoa"];
			//entity.MaKhoa = (Convert.IsDBNull(reader["MaKhoa"]))?string.Empty:(System.String)reader["MaKhoa"];
			entity.MaBoMon = reader.IsDBNull(reader.GetOrdinal("MaBoMon")) ? null : (System.String)reader["MaBoMon"];
			//entity.MaBoMon = (Convert.IsDBNull(reader["MaBoMon"]))?string.Empty:(System.String)reader["MaBoMon"];
			entity.MaMonHoc = (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = reader.IsDBNull(reader.GetOrdinal("TenMonHoc")) ? null : (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.MaNhom = reader.IsDBNull(reader.GetOrdinal("MaNhom")) ? null : (System.String)reader["MaNhom"];
			//entity.MaNhom = (Convert.IsDBNull(reader["MaNhom"]))?string.Empty:(System.String)reader["MaNhom"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.SiSoLop = reader.IsDBNull(reader.GetOrdinal("SiSoLop")) ? null : (System.Int32?)reader["SiSoLop"];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
			entity.TrongGio = reader.IsDBNull(reader.GetOrdinal("TrongGio")) ? null : (System.Decimal?)reader["TrongGio"];
			//entity.TrongGio = (Convert.IsDBNull(reader["TrongGio"]))?0.0m:(System.Decimal?)reader["TrongGio"];
			entity.ChatLuongCao = reader.IsDBNull(reader.GetOrdinal("ChatLuongCao")) ? null : (System.Decimal?)reader["ChatLuongCao"];
			//entity.ChatLuongCao = (Convert.IsDBNull(reader["ChatLuongCao"]))?0.0m:(System.Decimal?)reader["ChatLuongCao"];
			entity.NgoaiGio = reader.IsDBNull(reader.GetOrdinal("NgoaiGio")) ? null : (System.Decimal?)reader["NgoaiGio"];
			//entity.NgoaiGio = (Convert.IsDBNull(reader["NgoaiGio"]))?0.0m:(System.Decimal?)reader["NgoaiGio"];
			entity.HeSoThanhPhan = reader.IsDBNull(reader.GetOrdinal("HeSoThanhPhan")) ? null : (System.Decimal?)reader["HeSoThanhPhan"];
			//entity.HeSoThanhPhan = (Convert.IsDBNull(reader["HeSoThanhPhan"]))?0.0m:(System.Decimal?)reader["HeSoThanhPhan"];
			entity.HeSoLopDong = reader.IsDBNull(reader.GetOrdinal("HeSoLopDong")) ? null : (System.Decimal?)reader["HeSoLopDong"];
			//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
			entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
			entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.MaLoaiKhoiLuong = reader.IsDBNull(reader.GetOrdinal("MaLoaiKhoiLuong")) ? null : (System.String)reader["MaLoaiKhoiLuong"];
			//entity.MaLoaiKhoiLuong = (Convert.IsDBNull(reader["MaLoaiKhoiLuong"]))?string.Empty:(System.String)reader["MaLoaiKhoiLuong"];
			entity.TenLoaiKhoiLuong = reader.IsDBNull(reader.GetOrdinal("TenLoaiKhoiLuong")) ? null : (System.String)reader["TenLoaiKhoiLuong"];
			//entity.TenLoaiKhoiLuong = (Convert.IsDBNull(reader["TenLoaiKhoiLuong"]))?string.Empty:(System.String)reader["TenLoaiKhoiLuong"];
			entity.PhanLoai = reader.IsDBNull(reader.GetOrdinal("PhanLoai")) ? null : (System.String)reader["PhanLoai"];
			//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
			entity.NghiaVu = reader.IsDBNull(reader.GetOrdinal("NghiaVu")) ? null : (System.Boolean?)reader["NghiaVu"];
			//entity.NghiaVu = (Convert.IsDBNull(reader["NghiaVu"]))?false:(System.Boolean?)reader["NghiaVu"];
			entity.NguongTiet = reader.IsDBNull(reader.GetOrdinal("NguongTiet")) ? null : (System.Int32?)reader["NguongTiet"];
			//entity.NguongTiet = (Convert.IsDBNull(reader["NguongTiet"]))?(int)0:(System.Int32?)reader["NguongTiet"];
			entity.TietNghiaVu = reader.IsDBNull(reader.GetOrdinal("TietNghiaVu")) ? null : (System.Decimal?)reader["TietNghiaVu"];
			//entity.TietNghiaVu = (Convert.IsDBNull(reader["TietNghiaVu"]))?0.0m:(System.Decimal?)reader["TietNghiaVu"];
			entity.ThanhTien = reader.IsDBNull(reader.GetOrdinal("ThanhTien")) ? null : (System.Decimal?)reader["ThanhTien"];
			//entity.ThanhTien = (Convert.IsDBNull(reader["ThanhTien"]))?0.0m:(System.Decimal?)reader["ThanhTien"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewChiTietKhoiLuong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewChiTietKhoiLuong"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewChiTietKhoiLuong entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.MaKhoa = (Convert.IsDBNull(dataRow["MaKhoa"]))?string.Empty:(System.String)dataRow["MaKhoa"];
			entity.MaBoMon = (Convert.IsDBNull(dataRow["MaBoMon"]))?string.Empty:(System.String)dataRow["MaBoMon"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.MaNhom = (Convert.IsDBNull(dataRow["MaNhom"]))?string.Empty:(System.String)dataRow["MaNhom"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.SiSoLop = (Convert.IsDBNull(dataRow["SiSoLop"]))?(int)0:(System.Int32?)dataRow["SiSoLop"];
			entity.TrongGio = (Convert.IsDBNull(dataRow["TrongGio"]))?0.0m:(System.Decimal?)dataRow["TrongGio"];
			entity.ChatLuongCao = (Convert.IsDBNull(dataRow["ChatLuongCao"]))?0.0m:(System.Decimal?)dataRow["ChatLuongCao"];
			entity.NgoaiGio = (Convert.IsDBNull(dataRow["NgoaiGio"]))?0.0m:(System.Decimal?)dataRow["NgoaiGio"];
			entity.HeSoThanhPhan = (Convert.IsDBNull(dataRow["HeSoThanhPhan"]))?0.0m:(System.Decimal?)dataRow["HeSoThanhPhan"];
			entity.HeSoLopDong = (Convert.IsDBNull(dataRow["HeSoLopDong"]))?0.0m:(System.Decimal?)dataRow["HeSoLopDong"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal?)dataRow["DonGia"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.MaLoaiKhoiLuong = (Convert.IsDBNull(dataRow["MaLoaiKhoiLuong"]))?string.Empty:(System.String)dataRow["MaLoaiKhoiLuong"];
			entity.TenLoaiKhoiLuong = (Convert.IsDBNull(dataRow["TenLoaiKhoiLuong"]))?string.Empty:(System.String)dataRow["TenLoaiKhoiLuong"];
			entity.PhanLoai = (Convert.IsDBNull(dataRow["PhanLoai"]))?string.Empty:(System.String)dataRow["PhanLoai"];
			entity.NghiaVu = (Convert.IsDBNull(dataRow["NghiaVu"]))?false:(System.Boolean?)dataRow["NghiaVu"];
			entity.NguongTiet = (Convert.IsDBNull(dataRow["NguongTiet"]))?(int)0:(System.Int32?)dataRow["NguongTiet"];
			entity.TietNghiaVu = (Convert.IsDBNull(dataRow["TietNghiaVu"]))?0.0m:(System.Decimal?)dataRow["TietNghiaVu"];
			entity.ThanhTien = (Convert.IsDBNull(dataRow["ThanhTien"]))?0.0m:(System.Decimal?)dataRow["ThanhTien"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewChiTietKhoiLuongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietKhoiLuongFilterBuilder : SqlFilterBuilder<ViewChiTietKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongFilterBuilder class.
		/// </summary>
		public ViewChiTietKhoiLuongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTietKhoiLuongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTietKhoiLuongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTietKhoiLuongFilterBuilder

	#region ViewChiTietKhoiLuongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietKhoiLuongParameterBuilder : ParameterizedSqlFilterBuilder<ViewChiTietKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongParameterBuilder class.
		/// </summary>
		public ViewChiTietKhoiLuongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewChiTietKhoiLuongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewChiTietKhoiLuongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewChiTietKhoiLuongParameterBuilder
	
	#region ViewChiTietKhoiLuongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewChiTietKhoiLuongSortBuilder : SqlSortBuilder<ViewChiTietKhoiLuongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongSqlSortBuilder class.
		/// </summary>
		public ViewChiTietKhoiLuongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewChiTietKhoiLuongSortBuilder

} // end namespace
