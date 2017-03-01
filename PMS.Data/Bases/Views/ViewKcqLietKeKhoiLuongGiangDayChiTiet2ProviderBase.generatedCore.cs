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
	/// This class is the base class for any <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2ProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKcqLietKeKhoiLuongGiangDayChiTiet2ProviderBaseCore : EntityViewProviderBase<ViewKcqLietKeKhoiLuongGiangDayChiTiet2>
	{
		#region Custom Methods
		
		
		#region cust_View_KcqLietKeKhoiLuongGiangDayChiTiet2_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqLietKeKhoiLuongGiangDayChiTiet2_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqLietKeKhoiLuongGiangDayChiTiet2&gt;"/> instance.</returns>
		public VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqLietKeKhoiLuongGiangDayChiTiet2_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqLietKeKhoiLuongGiangDayChiTiet2&gt;"/> instance.</returns>
		public VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KcqLietKeKhoiLuongGiangDayChiTiet2_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKcqLietKeKhoiLuongGiangDayChiTiet2&gt;"/> instance.</returns>
		public VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KcqLietKeKhoiLuongGiangDayChiTiet2_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKcqLietKeKhoiLuongGiangDayChiTiet2&gt;"/> instance.</returns>
		public abstract VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKcqLietKeKhoiLuongGiangDayChiTiet2&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKcqLietKeKhoiLuongGiangDayChiTiet2&gt;"/></returns>
		protected static VList&lt;ViewKcqLietKeKhoiLuongGiangDayChiTiet2&gt; Fill(DataSet dataSet, VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKcqLietKeKhoiLuongGiangDayChiTiet2&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2>"/></returns>
		protected static VList&lt;ViewKcqLietKeKhoiLuongGiangDayChiTiet2&gt; Fill(DataTable dataTable, VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKcqLietKeKhoiLuongGiangDayChiTiet2 c = new ViewKcqLietKeKhoiLuongGiangDayChiTiet2();
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?(int)0:(System.Int32?)row["MaHocHam"];
					c.MaHocVi = (Convert.IsDBNull(row["MaHocVi"]))?(int)0:(System.Int32?)row["MaHocVi"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32?)row["MaLoaiGiangVien"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.Loai = (Convert.IsDBNull(row["Loai"]))?string.Empty:(System.String)row["Loai"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.Nhom = (Convert.IsDBNull(row["Nhom"]))?string.Empty:(System.String)row["Nhom"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.SiSo = (Convert.IsDBNull(row["SiSo"]))?(int)0:(System.Int32?)row["SiSo"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?0.0m:(System.Decimal?)row["SoTiet"];
					c.TietChuNhat = (Convert.IsDBNull(row["TietChuNhat"]))?(int)0:(System.Int32?)row["TietChuNhat"];
					c.LopClc = (Convert.IsDBNull(row["LopClc"]))?false:(System.Boolean?)row["LopClc"];
					c.HeSoLopDong = (Convert.IsDBNull(row["HeSoLopDong"]))?0.0m:(System.Decimal?)row["HeSoLopDong"];
					c.HeSoHocKy = (Convert.IsDBNull(row["HeSoHocKy"]))?0.0m:(System.Decimal?)row["HeSoHocKy"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal?)row["DonGia"];
					c.TongThanhTien = (Convert.IsDBNull(row["TongThanhTien"]))?0.0m:(System.Decimal?)row["TongThanhTien"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.PhanLoai = (Convert.IsDBNull(row["PhanLoai"]))?string.Empty:(System.String)row["PhanLoai"];
					c.SoGioThucGiangTrenLop = (Convert.IsDBNull(row["SoGioThucGiangTrenLop"]))?0.0m:(System.Decimal?)row["SoGioThucGiangTrenLop"];
					c.SoGioChuanTinhThem = (Convert.IsDBNull(row["SoGioChuanTinhThem"]))?0.0m:(System.Decimal?)row["SoGioChuanTinhThem"];
					c.MaDiaDiem = (Convert.IsDBNull(row["MaDiaDiem"]))?string.Empty:(System.String)row["MaDiaDiem"];
					c.TenDiaDiem = (Convert.IsDBNull(row["TenDiaDiem"]))?string.Empty:(System.String)row["TenDiaDiem"];
					c.DonGiaDiaDiem = (Convert.IsDBNull(row["DonGiaDiaDiem"]))?0.0m:(System.Decimal?)row["DonGiaDiaDiem"];
					c.TienXeDiaDiem = (Convert.IsDBNull(row["TienXeDiaDiem"]))?0.0m:(System.Decimal?)row["TienXeDiaDiem"];
					c.HeSoDiaDiem = (Convert.IsDBNull(row["HeSoDiaDiem"]))?0.0m:(System.Decimal?)row["HeSoDiaDiem"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?0.0m:(System.Decimal?)row["SoTinChi"];
					c.TenBoMon = (Convert.IsDBNull(row["TenBoMon"]))?string.Empty:(System.String)row["TenBoMon"];
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
		/// Fill an <see cref="VList&lt;ViewKcqLietKeKhoiLuongGiangDayChiTiet2&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKcqLietKeKhoiLuongGiangDayChiTiet2&gt;"/></returns>
		protected VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> Fill(IDataReader reader, VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKcqLietKeKhoiLuongGiangDayChiTiet2 entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKcqLietKeKhoiLuongGiangDayChiTiet2>("ViewKcqLietKeKhoiLuongGiangDayChiTiet2",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKcqLietKeKhoiLuongGiangDayChiTiet2();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
					//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
					entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
					//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
					entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.Loai = reader.IsDBNull(reader.GetOrdinal("Loai")) ? null : (System.String)reader["Loai"];
					//entity.Loai = (Convert.IsDBNull(reader["Loai"]))?string.Empty:(System.String)reader["Loai"];
					entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = reader.IsDBNull(reader.GetOrdinal("TenMonHoc")) ? null : (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.Nhom = reader.IsDBNull(reader.GetOrdinal("Nhom")) ? null : (System.String)reader["Nhom"];
					//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Int32?)reader["SiSo"];
					//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Decimal?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
					entity.TietChuNhat = reader.IsDBNull(reader.GetOrdinal("TietChuNhat")) ? null : (System.Int32?)reader["TietChuNhat"];
					//entity.TietChuNhat = (Convert.IsDBNull(reader["TietChuNhat"]))?(int)0:(System.Int32?)reader["TietChuNhat"];
					entity.LopClc = reader.IsDBNull(reader.GetOrdinal("LopClc")) ? null : (System.Boolean?)reader["LopClc"];
					//entity.LopClc = (Convert.IsDBNull(reader["LopClc"]))?false:(System.Boolean?)reader["LopClc"];
					entity.HeSoLopDong = reader.IsDBNull(reader.GetOrdinal("HeSoLopDong")) ? null : (System.Decimal?)reader["HeSoLopDong"];
					//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
					entity.HeSoHocKy = reader.IsDBNull(reader.GetOrdinal("HeSoHocKy")) ? null : (System.Decimal?)reader["HeSoHocKy"];
					//entity.HeSoHocKy = (Convert.IsDBNull(reader["HeSoHocKy"]))?0.0m:(System.Decimal?)reader["HeSoHocKy"];
					entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
					entity.TongThanhTien = reader.IsDBNull(reader.GetOrdinal("TongThanhTien")) ? null : (System.Decimal?)reader["TongThanhTien"];
					//entity.TongThanhTien = (Convert.IsDBNull(reader["TongThanhTien"]))?0.0m:(System.Decimal?)reader["TongThanhTien"];
					entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.PhanLoai = reader.IsDBNull(reader.GetOrdinal("PhanLoai")) ? null : (System.String)reader["PhanLoai"];
					//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
					entity.SoGioThucGiangTrenLop = reader.IsDBNull(reader.GetOrdinal("SoGioThucGiangTrenLop")) ? null : (System.Decimal?)reader["SoGioThucGiangTrenLop"];
					//entity.SoGioThucGiangTrenLop = (Convert.IsDBNull(reader["SoGioThucGiangTrenLop"]))?0.0m:(System.Decimal?)reader["SoGioThucGiangTrenLop"];
					entity.SoGioChuanTinhThem = reader.IsDBNull(reader.GetOrdinal("SoGioChuanTinhThem")) ? null : (System.Decimal?)reader["SoGioChuanTinhThem"];
					//entity.SoGioChuanTinhThem = (Convert.IsDBNull(reader["SoGioChuanTinhThem"]))?0.0m:(System.Decimal?)reader["SoGioChuanTinhThem"];
					entity.MaDiaDiem = reader.IsDBNull(reader.GetOrdinal("MaDiaDiem")) ? null : (System.String)reader["MaDiaDiem"];
					//entity.MaDiaDiem = (Convert.IsDBNull(reader["MaDiaDiem"]))?string.Empty:(System.String)reader["MaDiaDiem"];
					entity.TenDiaDiem = reader.IsDBNull(reader.GetOrdinal("TenDiaDiem")) ? null : (System.String)reader["TenDiaDiem"];
					//entity.TenDiaDiem = (Convert.IsDBNull(reader["TenDiaDiem"]))?string.Empty:(System.String)reader["TenDiaDiem"];
					entity.DonGiaDiaDiem = reader.IsDBNull(reader.GetOrdinal("DonGiaDiaDiem")) ? null : (System.Decimal?)reader["DonGiaDiaDiem"];
					//entity.DonGiaDiaDiem = (Convert.IsDBNull(reader["DonGiaDiaDiem"]))?0.0m:(System.Decimal?)reader["DonGiaDiaDiem"];
					entity.TienXeDiaDiem = reader.IsDBNull(reader.GetOrdinal("TienXeDiaDiem")) ? null : (System.Decimal?)reader["TienXeDiaDiem"];
					//entity.TienXeDiaDiem = (Convert.IsDBNull(reader["TienXeDiaDiem"]))?0.0m:(System.Decimal?)reader["TienXeDiaDiem"];
					entity.HeSoDiaDiem = reader.IsDBNull(reader.GetOrdinal("HeSoDiaDiem")) ? null : (System.Decimal?)reader["HeSoDiaDiem"];
					//entity.HeSoDiaDiem = (Convert.IsDBNull(reader["HeSoDiaDiem"]))?0.0m:(System.Decimal?)reader["HeSoDiaDiem"];
					entity.SoTinChi = reader.IsDBNull(reader.GetOrdinal("SoTinChi")) ? null : (System.Decimal?)reader["SoTinChi"];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal?)reader["SoTinChi"];
					entity.TenBoMon = reader.IsDBNull(reader.GetOrdinal("TenBoMon")) ? null : (System.String)reader["TenBoMon"];
					//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
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
		/// Refreshes the <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKcqLietKeKhoiLuongGiangDayChiTiet2 entity)
		{
			reader.Read();
			entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
			//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
			entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
			//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
			entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.Loai = reader.IsDBNull(reader.GetOrdinal("Loai")) ? null : (System.String)reader["Loai"];
			//entity.Loai = (Convert.IsDBNull(reader["Loai"]))?string.Empty:(System.String)reader["Loai"];
			entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = reader.IsDBNull(reader.GetOrdinal("TenMonHoc")) ? null : (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.Nhom = reader.IsDBNull(reader.GetOrdinal("Nhom")) ? null : (System.String)reader["Nhom"];
			//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Int32?)reader["SiSo"];
			//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Decimal?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
			entity.TietChuNhat = reader.IsDBNull(reader.GetOrdinal("TietChuNhat")) ? null : (System.Int32?)reader["TietChuNhat"];
			//entity.TietChuNhat = (Convert.IsDBNull(reader["TietChuNhat"]))?(int)0:(System.Int32?)reader["TietChuNhat"];
			entity.LopClc = reader.IsDBNull(reader.GetOrdinal("LopClc")) ? null : (System.Boolean?)reader["LopClc"];
			//entity.LopClc = (Convert.IsDBNull(reader["LopClc"]))?false:(System.Boolean?)reader["LopClc"];
			entity.HeSoLopDong = reader.IsDBNull(reader.GetOrdinal("HeSoLopDong")) ? null : (System.Decimal?)reader["HeSoLopDong"];
			//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
			entity.HeSoHocKy = reader.IsDBNull(reader.GetOrdinal("HeSoHocKy")) ? null : (System.Decimal?)reader["HeSoHocKy"];
			//entity.HeSoHocKy = (Convert.IsDBNull(reader["HeSoHocKy"]))?0.0m:(System.Decimal?)reader["HeSoHocKy"];
			entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
			entity.TongThanhTien = reader.IsDBNull(reader.GetOrdinal("TongThanhTien")) ? null : (System.Decimal?)reader["TongThanhTien"];
			//entity.TongThanhTien = (Convert.IsDBNull(reader["TongThanhTien"]))?0.0m:(System.Decimal?)reader["TongThanhTien"];
			entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.PhanLoai = reader.IsDBNull(reader.GetOrdinal("PhanLoai")) ? null : (System.String)reader["PhanLoai"];
			//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
			entity.SoGioThucGiangTrenLop = reader.IsDBNull(reader.GetOrdinal("SoGioThucGiangTrenLop")) ? null : (System.Decimal?)reader["SoGioThucGiangTrenLop"];
			//entity.SoGioThucGiangTrenLop = (Convert.IsDBNull(reader["SoGioThucGiangTrenLop"]))?0.0m:(System.Decimal?)reader["SoGioThucGiangTrenLop"];
			entity.SoGioChuanTinhThem = reader.IsDBNull(reader.GetOrdinal("SoGioChuanTinhThem")) ? null : (System.Decimal?)reader["SoGioChuanTinhThem"];
			//entity.SoGioChuanTinhThem = (Convert.IsDBNull(reader["SoGioChuanTinhThem"]))?0.0m:(System.Decimal?)reader["SoGioChuanTinhThem"];
			entity.MaDiaDiem = reader.IsDBNull(reader.GetOrdinal("MaDiaDiem")) ? null : (System.String)reader["MaDiaDiem"];
			//entity.MaDiaDiem = (Convert.IsDBNull(reader["MaDiaDiem"]))?string.Empty:(System.String)reader["MaDiaDiem"];
			entity.TenDiaDiem = reader.IsDBNull(reader.GetOrdinal("TenDiaDiem")) ? null : (System.String)reader["TenDiaDiem"];
			//entity.TenDiaDiem = (Convert.IsDBNull(reader["TenDiaDiem"]))?string.Empty:(System.String)reader["TenDiaDiem"];
			entity.DonGiaDiaDiem = reader.IsDBNull(reader.GetOrdinal("DonGiaDiaDiem")) ? null : (System.Decimal?)reader["DonGiaDiaDiem"];
			//entity.DonGiaDiaDiem = (Convert.IsDBNull(reader["DonGiaDiaDiem"]))?0.0m:(System.Decimal?)reader["DonGiaDiaDiem"];
			entity.TienXeDiaDiem = reader.IsDBNull(reader.GetOrdinal("TienXeDiaDiem")) ? null : (System.Decimal?)reader["TienXeDiaDiem"];
			//entity.TienXeDiaDiem = (Convert.IsDBNull(reader["TienXeDiaDiem"]))?0.0m:(System.Decimal?)reader["TienXeDiaDiem"];
			entity.HeSoDiaDiem = reader.IsDBNull(reader.GetOrdinal("HeSoDiaDiem")) ? null : (System.Decimal?)reader["HeSoDiaDiem"];
			//entity.HeSoDiaDiem = (Convert.IsDBNull(reader["HeSoDiaDiem"]))?0.0m:(System.Decimal?)reader["HeSoDiaDiem"];
			entity.SoTinChi = reader.IsDBNull(reader.GetOrdinal("SoTinChi")) ? null : (System.Decimal?)reader["SoTinChi"];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal?)reader["SoTinChi"];
			entity.TenBoMon = reader.IsDBNull(reader.GetOrdinal("TenBoMon")) ? null : (System.String)reader["TenBoMon"];
			//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKcqLietKeKhoiLuongGiangDayChiTiet2 entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?(int)0:(System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = (Convert.IsDBNull(dataRow["MaHocVi"]))?(int)0:(System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.Loai = (Convert.IsDBNull(dataRow["Loai"]))?string.Empty:(System.String)dataRow["Loai"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.Nhom = (Convert.IsDBNull(dataRow["Nhom"]))?string.Empty:(System.String)dataRow["Nhom"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.SiSo = (Convert.IsDBNull(dataRow["SiSo"]))?(int)0:(System.Int32?)dataRow["SiSo"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?0.0m:(System.Decimal?)dataRow["SoTiet"];
			entity.TietChuNhat = (Convert.IsDBNull(dataRow["TietChuNhat"]))?(int)0:(System.Int32?)dataRow["TietChuNhat"];
			entity.LopClc = (Convert.IsDBNull(dataRow["LopClc"]))?false:(System.Boolean?)dataRow["LopClc"];
			entity.HeSoLopDong = (Convert.IsDBNull(dataRow["HeSoLopDong"]))?0.0m:(System.Decimal?)dataRow["HeSoLopDong"];
			entity.HeSoHocKy = (Convert.IsDBNull(dataRow["HeSoHocKy"]))?0.0m:(System.Decimal?)dataRow["HeSoHocKy"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal?)dataRow["DonGia"];
			entity.TongThanhTien = (Convert.IsDBNull(dataRow["TongThanhTien"]))?0.0m:(System.Decimal?)dataRow["TongThanhTien"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.PhanLoai = (Convert.IsDBNull(dataRow["PhanLoai"]))?string.Empty:(System.String)dataRow["PhanLoai"];
			entity.SoGioThucGiangTrenLop = (Convert.IsDBNull(dataRow["SoGioThucGiangTrenLop"]))?0.0m:(System.Decimal?)dataRow["SoGioThucGiangTrenLop"];
			entity.SoGioChuanTinhThem = (Convert.IsDBNull(dataRow["SoGioChuanTinhThem"]))?0.0m:(System.Decimal?)dataRow["SoGioChuanTinhThem"];
			entity.MaDiaDiem = (Convert.IsDBNull(dataRow["MaDiaDiem"]))?string.Empty:(System.String)dataRow["MaDiaDiem"];
			entity.TenDiaDiem = (Convert.IsDBNull(dataRow["TenDiaDiem"]))?string.Empty:(System.String)dataRow["TenDiaDiem"];
			entity.DonGiaDiaDiem = (Convert.IsDBNull(dataRow["DonGiaDiaDiem"]))?0.0m:(System.Decimal?)dataRow["DonGiaDiaDiem"];
			entity.TienXeDiaDiem = (Convert.IsDBNull(dataRow["TienXeDiaDiem"]))?0.0m:(System.Decimal?)dataRow["TienXeDiaDiem"];
			entity.HeSoDiaDiem = (Convert.IsDBNull(dataRow["HeSoDiaDiem"]))?0.0m:(System.Decimal?)dataRow["HeSoDiaDiem"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?0.0m:(System.Decimal?)dataRow["SoTinChi"];
			entity.TenBoMon = (Convert.IsDBNull(dataRow["TenBoMon"]))?string.Empty:(System.String)dataRow["TenBoMon"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKcqLietKeKhoiLuongGiangDayChiTiet2FilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqLietKeKhoiLuongGiangDayChiTiet2FilterBuilder : SqlFilterBuilder<ViewKcqLietKeKhoiLuongGiangDayChiTiet2Column>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqLietKeKhoiLuongGiangDayChiTiet2FilterBuilder class.
		/// </summary>
		public ViewKcqLietKeKhoiLuongGiangDayChiTiet2FilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqLietKeKhoiLuongGiangDayChiTiet2FilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKcqLietKeKhoiLuongGiangDayChiTiet2FilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqLietKeKhoiLuongGiangDayChiTiet2FilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKcqLietKeKhoiLuongGiangDayChiTiet2FilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKcqLietKeKhoiLuongGiangDayChiTiet2FilterBuilder

	#region ViewKcqLietKeKhoiLuongGiangDayChiTiet2ParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqLietKeKhoiLuongGiangDayChiTiet2ParameterBuilder : ParameterizedSqlFilterBuilder<ViewKcqLietKeKhoiLuongGiangDayChiTiet2Column>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqLietKeKhoiLuongGiangDayChiTiet2ParameterBuilder class.
		/// </summary>
		public ViewKcqLietKeKhoiLuongGiangDayChiTiet2ParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqLietKeKhoiLuongGiangDayChiTiet2ParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKcqLietKeKhoiLuongGiangDayChiTiet2ParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKcqLietKeKhoiLuongGiangDayChiTiet2ParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKcqLietKeKhoiLuongGiangDayChiTiet2ParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKcqLietKeKhoiLuongGiangDayChiTiet2ParameterBuilder
	
	#region ViewKcqLietKeKhoiLuongGiangDayChiTiet2SortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKcqLietKeKhoiLuongGiangDayChiTiet2SortBuilder : SqlSortBuilder<ViewKcqLietKeKhoiLuongGiangDayChiTiet2Column>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqLietKeKhoiLuongGiangDayChiTiet2SqlSortBuilder class.
		/// </summary>
		public ViewKcqLietKeKhoiLuongGiangDayChiTiet2SortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKcqLietKeKhoiLuongGiangDayChiTiet2SortBuilder

} // end namespace
