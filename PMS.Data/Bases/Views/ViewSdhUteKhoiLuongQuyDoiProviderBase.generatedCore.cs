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
	/// This class is the base class for any <see cref="ViewSdhUteKhoiLuongQuyDoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewSdhUteKhoiLuongQuyDoiProviderBaseCore : EntityViewProviderBase<ViewSdhUteKhoiLuongQuyDoi>
	{
		#region Custom Methods
		
		
		#region cust_view_SdhUte_KhoiLuongQuyDoi_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_view_SdhUte_KhoiLuongQuyDoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewSdhUteKhoiLuongQuyDoi&gt;"/> instance.</returns>
		public VList<ViewSdhUteKhoiLuongQuyDoi> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_SdhUte_KhoiLuongQuyDoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewSdhUteKhoiLuongQuyDoi&gt;"/> instance.</returns>
		public VList<ViewSdhUteKhoiLuongQuyDoi> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_SdhUte_KhoiLuongQuyDoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewSdhUteKhoiLuongQuyDoi&gt;"/> instance.</returns>
		public VList<ViewSdhUteKhoiLuongQuyDoi> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_SdhUte_KhoiLuongQuyDoi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewSdhUteKhoiLuongQuyDoi&gt;"/> instance.</returns>
		public abstract VList<ViewSdhUteKhoiLuongQuyDoi> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewSdhUteKhoiLuongQuyDoi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewSdhUteKhoiLuongQuyDoi&gt;"/></returns>
		protected static VList&lt;ViewSdhUteKhoiLuongQuyDoi&gt; Fill(DataSet dataSet, VList<ViewSdhUteKhoiLuongQuyDoi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewSdhUteKhoiLuongQuyDoi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewSdhUteKhoiLuongQuyDoi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewSdhUteKhoiLuongQuyDoi>"/></returns>
		protected static VList&lt;ViewSdhUteKhoiLuongQuyDoi&gt; Fill(DataTable dataTable, VList<ViewSdhUteKhoiLuongQuyDoi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewSdhUteKhoiLuongQuyDoi c = new ViewSdhUteKhoiLuongQuyDoi();
					c.Id = (Convert.IsDBNull(row["Id"]))?(int)0:(System.Int32)row["Id"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.NhomMonHoc = (Convert.IsDBNull(row["NhomMonHoc"]))?string.Empty:(System.String)row["NhomMonHoc"];
					c.MaHocPhan = (Convert.IsDBNull(row["MaHocPhan"]))?string.Empty:(System.String)row["MaHocPhan"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaDot = (Convert.IsDBNull(row["MaDot"]))?string.Empty:(System.String)row["MaDot"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.Nhom = (Convert.IsDBNull(row["Nhom"]))?string.Empty:(System.String)row["Nhom"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.MaDiaDiem = (Convert.IsDBNull(row["MaDiaDiem"]))?string.Empty:(System.String)row["MaDiaDiem"];
					c.TenDiaDiem = (Convert.IsDBNull(row["TenDiaDiem"]))?string.Empty:(System.String)row["TenDiaDiem"];
					c.TienXeDiaDiem = (Convert.IsDBNull(row["TienXeDiaDiem"]))?0.0m:(System.Decimal?)row["TienXeDiaDiem"];
					c.MaGiangVienQuanLy = (Convert.IsDBNull(row["MaGiangVienQuanLy"]))?string.Empty:(System.String)row["MaGiangVienQuanLy"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?(int)0:(System.Int32?)row["SoTinChi"];
					c.SiSo = (Convert.IsDBNull(row["SiSo"]))?(int)0:(System.Int32?)row["SiSo"];
					c.LopClc = (Convert.IsDBNull(row["LopClc"]))?false:(System.Boolean?)row["LopClc"];
					c.SoTietDayChuNhat = (Convert.IsDBNull(row["SoTietDayChuNhat"]))?(int)0:(System.Int32?)row["SoTietDayChuNhat"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?0.0m:(System.Decimal?)row["SoTiet"];
					c.MaLoaiHocPhan = (Convert.IsDBNull(row["MaLoaiHocPhan"]))?(int)0:(System.Int32?)row["MaLoaiHocPhan"];
					c.HeSoLopDongLyThuyet = (Convert.IsDBNull(row["HeSoLopDongLyThuyet"]))?0.0m:(System.Decimal?)row["HeSoLopDongLyThuyet"];
					c.HeSoLopDongThTnTt = (Convert.IsDBNull(row["HeSoLopDongThTnTt"]))?0.0m:(System.Decimal?)row["HeSoLopDongThTnTt"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.TenLoaiHocPhan = (Convert.IsDBNull(row["TenLoaiHocPhan"]))?string.Empty:(System.String)row["TenLoaiHocPhan"];
					c.LoaiHocPhan = (Convert.IsDBNull(row["LoaiHocPhan"]))?string.Empty:(System.String)row["LoaiHocPhan"];
					c.SoGioThucGiangTrenLop = (Convert.IsDBNull(row["SoGioThucGiangTrenLop"]))?0.0m:(System.Decimal?)row["SoGioThucGiangTrenLop"];
					c.SoGioChuanTinhThem = (Convert.IsDBNull(row["SoGioChuanTinhThem"]))?0.0m:(System.Decimal?)row["SoGioChuanTinhThem"];
					c.MaNhomMon = (Convert.IsDBNull(row["MaNhomMon"]))?(int)0:(System.Int32?)row["MaNhomMon"];
					c.TenNhomMon = (Convert.IsDBNull(row["TenNhomMon"]))?string.Empty:(System.String)row["TenNhomMon"];
					c.HeSoHocKy = (Convert.IsDBNull(row["HeSoHocKy"]))?0.0m:(System.Decimal?)row["HeSoHocKy"];
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
		/// Fill an <see cref="VList&lt;ViewSdhUteKhoiLuongQuyDoi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewSdhUteKhoiLuongQuyDoi&gt;"/></returns>
		protected VList<ViewSdhUteKhoiLuongQuyDoi> Fill(IDataReader reader, VList<ViewSdhUteKhoiLuongQuyDoi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewSdhUteKhoiLuongQuyDoi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewSdhUteKhoiLuongQuyDoi>("ViewSdhUteKhoiLuongQuyDoi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewSdhUteKhoiLuongQuyDoi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.Id = (System.Int32)reader["Id"];
					//entity.Id = (Convert.IsDBNull(reader["Id"]))?(int)0:(System.Int32)reader["Id"];
					entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = reader.IsDBNull(reader.GetOrdinal("TenMonHoc")) ? null : (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.NhomMonHoc = reader.IsDBNull(reader.GetOrdinal("NhomMonHoc")) ? null : (System.String)reader["NhomMonHoc"];
					//entity.NhomMonHoc = (Convert.IsDBNull(reader["NhomMonHoc"]))?string.Empty:(System.String)reader["NhomMonHoc"];
					entity.MaHocPhan = reader.IsDBNull(reader.GetOrdinal("MaHocPhan")) ? null : (System.String)reader["MaHocPhan"];
					//entity.MaHocPhan = (Convert.IsDBNull(reader["MaHocPhan"]))?string.Empty:(System.String)reader["MaHocPhan"];
					entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaDot = reader.IsDBNull(reader.GetOrdinal("MaDot")) ? null : (System.String)reader["MaDot"];
					//entity.MaDot = (Convert.IsDBNull(reader["MaDot"]))?string.Empty:(System.String)reader["MaDot"];
					entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.Nhom = reader.IsDBNull(reader.GetOrdinal("Nhom")) ? null : (System.String)reader["Nhom"];
					//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.MaDiaDiem = reader.IsDBNull(reader.GetOrdinal("MaDiaDiem")) ? null : (System.String)reader["MaDiaDiem"];
					//entity.MaDiaDiem = (Convert.IsDBNull(reader["MaDiaDiem"]))?string.Empty:(System.String)reader["MaDiaDiem"];
					entity.TenDiaDiem = reader.IsDBNull(reader.GetOrdinal("TenDiaDiem")) ? null : (System.String)reader["TenDiaDiem"];
					//entity.TenDiaDiem = (Convert.IsDBNull(reader["TenDiaDiem"]))?string.Empty:(System.String)reader["TenDiaDiem"];
					entity.TienXeDiaDiem = reader.IsDBNull(reader.GetOrdinal("TienXeDiaDiem")) ? null : (System.Decimal?)reader["TienXeDiaDiem"];
					//entity.TienXeDiaDiem = (Convert.IsDBNull(reader["TienXeDiaDiem"]))?0.0m:(System.Decimal?)reader["TienXeDiaDiem"];
					entity.MaGiangVienQuanLy = reader.IsDBNull(reader.GetOrdinal("MaGiangVienQuanLy")) ? null : (System.String)reader["MaGiangVienQuanLy"];
					//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
					entity.SoTinChi = reader.IsDBNull(reader.GetOrdinal("SoTinChi")) ? null : (System.Int32?)reader["SoTinChi"];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?(int)0:(System.Int32?)reader["SoTinChi"];
					entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Int32?)reader["SiSo"];
					//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
					entity.LopClc = reader.IsDBNull(reader.GetOrdinal("LopClc")) ? null : (System.Boolean?)reader["LopClc"];
					//entity.LopClc = (Convert.IsDBNull(reader["LopClc"]))?false:(System.Boolean?)reader["LopClc"];
					entity.SoTietDayChuNhat = reader.IsDBNull(reader.GetOrdinal("SoTietDayChuNhat")) ? null : (System.Int32?)reader["SoTietDayChuNhat"];
					//entity.SoTietDayChuNhat = (Convert.IsDBNull(reader["SoTietDayChuNhat"]))?(int)0:(System.Int32?)reader["SoTietDayChuNhat"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Decimal?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
					entity.MaLoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLoaiHocPhan")) ? null : (System.Int32?)reader["MaLoaiHocPhan"];
					//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(int)0:(System.Int32?)reader["MaLoaiHocPhan"];
					entity.HeSoLopDongLyThuyet = reader.IsDBNull(reader.GetOrdinal("HeSoLopDongLyThuyet")) ? null : (System.Decimal?)reader["HeSoLopDongLyThuyet"];
					//entity.HeSoLopDongLyThuyet = (Convert.IsDBNull(reader["HeSoLopDongLyThuyet"]))?0.0m:(System.Decimal?)reader["HeSoLopDongLyThuyet"];
					entity.HeSoLopDongThTnTt = reader.IsDBNull(reader.GetOrdinal("HeSoLopDongThTnTt")) ? null : (System.Decimal?)reader["HeSoLopDongThTnTt"];
					//entity.HeSoLopDongThTnTt = (Convert.IsDBNull(reader["HeSoLopDongThTnTt"]))?0.0m:(System.Decimal?)reader["HeSoLopDongThTnTt"];
					entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.TenLoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("TenLoaiHocPhan")) ? null : (System.String)reader["TenLoaiHocPhan"];
					//entity.TenLoaiHocPhan = (Convert.IsDBNull(reader["TenLoaiHocPhan"]))?string.Empty:(System.String)reader["TenLoaiHocPhan"];
					entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.SoGioThucGiangTrenLop = reader.IsDBNull(reader.GetOrdinal("SoGioThucGiangTrenLop")) ? null : (System.Decimal?)reader["SoGioThucGiangTrenLop"];
					//entity.SoGioThucGiangTrenLop = (Convert.IsDBNull(reader["SoGioThucGiangTrenLop"]))?0.0m:(System.Decimal?)reader["SoGioThucGiangTrenLop"];
					entity.SoGioChuanTinhThem = reader.IsDBNull(reader.GetOrdinal("SoGioChuanTinhThem")) ? null : (System.Decimal?)reader["SoGioChuanTinhThem"];
					//entity.SoGioChuanTinhThem = (Convert.IsDBNull(reader["SoGioChuanTinhThem"]))?0.0m:(System.Decimal?)reader["SoGioChuanTinhThem"];
					entity.MaNhomMon = reader.IsDBNull(reader.GetOrdinal("MaNhomMon")) ? null : (System.Int32?)reader["MaNhomMon"];
					//entity.MaNhomMon = (Convert.IsDBNull(reader["MaNhomMon"]))?(int)0:(System.Int32?)reader["MaNhomMon"];
					entity.TenNhomMon = reader.IsDBNull(reader.GetOrdinal("TenNhomMon")) ? null : (System.String)reader["TenNhomMon"];
					//entity.TenNhomMon = (Convert.IsDBNull(reader["TenNhomMon"]))?string.Empty:(System.String)reader["TenNhomMon"];
					entity.HeSoHocKy = reader.IsDBNull(reader.GetOrdinal("HeSoHocKy")) ? null : (System.Decimal?)reader["HeSoHocKy"];
					//entity.HeSoHocKy = (Convert.IsDBNull(reader["HeSoHocKy"]))?0.0m:(System.Decimal?)reader["HeSoHocKy"];
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
		/// Refreshes the <see cref="ViewSdhUteKhoiLuongQuyDoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewSdhUteKhoiLuongQuyDoi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewSdhUteKhoiLuongQuyDoi entity)
		{
			reader.Read();
			entity.Id = (System.Int32)reader["Id"];
			//entity.Id = (Convert.IsDBNull(reader["Id"]))?(int)0:(System.Int32)reader["Id"];
			entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = reader.IsDBNull(reader.GetOrdinal("TenMonHoc")) ? null : (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.NhomMonHoc = reader.IsDBNull(reader.GetOrdinal("NhomMonHoc")) ? null : (System.String)reader["NhomMonHoc"];
			//entity.NhomMonHoc = (Convert.IsDBNull(reader["NhomMonHoc"]))?string.Empty:(System.String)reader["NhomMonHoc"];
			entity.MaHocPhan = reader.IsDBNull(reader.GetOrdinal("MaHocPhan")) ? null : (System.String)reader["MaHocPhan"];
			//entity.MaHocPhan = (Convert.IsDBNull(reader["MaHocPhan"]))?string.Empty:(System.String)reader["MaHocPhan"];
			entity.NamHoc = reader.IsDBNull(reader.GetOrdinal("NamHoc")) ? null : (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = reader.IsDBNull(reader.GetOrdinal("HocKy")) ? null : (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaDot = reader.IsDBNull(reader.GetOrdinal("MaDot")) ? null : (System.String)reader["MaDot"];
			//entity.MaDot = (Convert.IsDBNull(reader["MaDot"]))?string.Empty:(System.String)reader["MaDot"];
			entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.Nhom = reader.IsDBNull(reader.GetOrdinal("Nhom")) ? null : (System.String)reader["Nhom"];
			//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.MaDiaDiem = reader.IsDBNull(reader.GetOrdinal("MaDiaDiem")) ? null : (System.String)reader["MaDiaDiem"];
			//entity.MaDiaDiem = (Convert.IsDBNull(reader["MaDiaDiem"]))?string.Empty:(System.String)reader["MaDiaDiem"];
			entity.TenDiaDiem = reader.IsDBNull(reader.GetOrdinal("TenDiaDiem")) ? null : (System.String)reader["TenDiaDiem"];
			//entity.TenDiaDiem = (Convert.IsDBNull(reader["TenDiaDiem"]))?string.Empty:(System.String)reader["TenDiaDiem"];
			entity.TienXeDiaDiem = reader.IsDBNull(reader.GetOrdinal("TienXeDiaDiem")) ? null : (System.Decimal?)reader["TienXeDiaDiem"];
			//entity.TienXeDiaDiem = (Convert.IsDBNull(reader["TienXeDiaDiem"]))?0.0m:(System.Decimal?)reader["TienXeDiaDiem"];
			entity.MaGiangVienQuanLy = reader.IsDBNull(reader.GetOrdinal("MaGiangVienQuanLy")) ? null : (System.String)reader["MaGiangVienQuanLy"];
			//entity.MaGiangVienQuanLy = (Convert.IsDBNull(reader["MaGiangVienQuanLy"]))?string.Empty:(System.String)reader["MaGiangVienQuanLy"];
			entity.SoTinChi = reader.IsDBNull(reader.GetOrdinal("SoTinChi")) ? null : (System.Int32?)reader["SoTinChi"];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?(int)0:(System.Int32?)reader["SoTinChi"];
			entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Int32?)reader["SiSo"];
			//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
			entity.LopClc = reader.IsDBNull(reader.GetOrdinal("LopClc")) ? null : (System.Boolean?)reader["LopClc"];
			//entity.LopClc = (Convert.IsDBNull(reader["LopClc"]))?false:(System.Boolean?)reader["LopClc"];
			entity.SoTietDayChuNhat = reader.IsDBNull(reader.GetOrdinal("SoTietDayChuNhat")) ? null : (System.Int32?)reader["SoTietDayChuNhat"];
			//entity.SoTietDayChuNhat = (Convert.IsDBNull(reader["SoTietDayChuNhat"]))?(int)0:(System.Int32?)reader["SoTietDayChuNhat"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Decimal?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
			entity.MaLoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLoaiHocPhan")) ? null : (System.Int32?)reader["MaLoaiHocPhan"];
			//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(int)0:(System.Int32?)reader["MaLoaiHocPhan"];
			entity.HeSoLopDongLyThuyet = reader.IsDBNull(reader.GetOrdinal("HeSoLopDongLyThuyet")) ? null : (System.Decimal?)reader["HeSoLopDongLyThuyet"];
			//entity.HeSoLopDongLyThuyet = (Convert.IsDBNull(reader["HeSoLopDongLyThuyet"]))?0.0m:(System.Decimal?)reader["HeSoLopDongLyThuyet"];
			entity.HeSoLopDongThTnTt = reader.IsDBNull(reader.GetOrdinal("HeSoLopDongThTnTt")) ? null : (System.Decimal?)reader["HeSoLopDongThTnTt"];
			//entity.HeSoLopDongThTnTt = (Convert.IsDBNull(reader["HeSoLopDongThTnTt"]))?0.0m:(System.Decimal?)reader["HeSoLopDongThTnTt"];
			entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.TenLoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("TenLoaiHocPhan")) ? null : (System.String)reader["TenLoaiHocPhan"];
			//entity.TenLoaiHocPhan = (Convert.IsDBNull(reader["TenLoaiHocPhan"]))?string.Empty:(System.String)reader["TenLoaiHocPhan"];
			entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.SoGioThucGiangTrenLop = reader.IsDBNull(reader.GetOrdinal("SoGioThucGiangTrenLop")) ? null : (System.Decimal?)reader["SoGioThucGiangTrenLop"];
			//entity.SoGioThucGiangTrenLop = (Convert.IsDBNull(reader["SoGioThucGiangTrenLop"]))?0.0m:(System.Decimal?)reader["SoGioThucGiangTrenLop"];
			entity.SoGioChuanTinhThem = reader.IsDBNull(reader.GetOrdinal("SoGioChuanTinhThem")) ? null : (System.Decimal?)reader["SoGioChuanTinhThem"];
			//entity.SoGioChuanTinhThem = (Convert.IsDBNull(reader["SoGioChuanTinhThem"]))?0.0m:(System.Decimal?)reader["SoGioChuanTinhThem"];
			entity.MaNhomMon = reader.IsDBNull(reader.GetOrdinal("MaNhomMon")) ? null : (System.Int32?)reader["MaNhomMon"];
			//entity.MaNhomMon = (Convert.IsDBNull(reader["MaNhomMon"]))?(int)0:(System.Int32?)reader["MaNhomMon"];
			entity.TenNhomMon = reader.IsDBNull(reader.GetOrdinal("TenNhomMon")) ? null : (System.String)reader["TenNhomMon"];
			//entity.TenNhomMon = (Convert.IsDBNull(reader["TenNhomMon"]))?string.Empty:(System.String)reader["TenNhomMon"];
			entity.HeSoHocKy = reader.IsDBNull(reader.GetOrdinal("HeSoHocKy")) ? null : (System.Decimal?)reader["HeSoHocKy"];
			//entity.HeSoHocKy = (Convert.IsDBNull(reader["HeSoHocKy"]))?0.0m:(System.Decimal?)reader["HeSoHocKy"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewSdhUteKhoiLuongQuyDoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewSdhUteKhoiLuongQuyDoi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewSdhUteKhoiLuongQuyDoi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (Convert.IsDBNull(dataRow["Id"]))?(int)0:(System.Int32)dataRow["Id"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.NhomMonHoc = (Convert.IsDBNull(dataRow["NhomMonHoc"]))?string.Empty:(System.String)dataRow["NhomMonHoc"];
			entity.MaHocPhan = (Convert.IsDBNull(dataRow["MaHocPhan"]))?string.Empty:(System.String)dataRow["MaHocPhan"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaDot = (Convert.IsDBNull(dataRow["MaDot"]))?string.Empty:(System.String)dataRow["MaDot"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.Nhom = (Convert.IsDBNull(dataRow["Nhom"]))?string.Empty:(System.String)dataRow["Nhom"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.MaDiaDiem = (Convert.IsDBNull(dataRow["MaDiaDiem"]))?string.Empty:(System.String)dataRow["MaDiaDiem"];
			entity.TenDiaDiem = (Convert.IsDBNull(dataRow["TenDiaDiem"]))?string.Empty:(System.String)dataRow["TenDiaDiem"];
			entity.TienXeDiaDiem = (Convert.IsDBNull(dataRow["TienXeDiaDiem"]))?0.0m:(System.Decimal?)dataRow["TienXeDiaDiem"];
			entity.MaGiangVienQuanLy = (Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]))?string.Empty:(System.String)dataRow["MaGiangVienQuanLy"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?(int)0:(System.Int32?)dataRow["SoTinChi"];
			entity.SiSo = (Convert.IsDBNull(dataRow["SiSo"]))?(int)0:(System.Int32?)dataRow["SiSo"];
			entity.LopClc = (Convert.IsDBNull(dataRow["LopClc"]))?false:(System.Boolean?)dataRow["LopClc"];
			entity.SoTietDayChuNhat = (Convert.IsDBNull(dataRow["SoTietDayChuNhat"]))?(int)0:(System.Int32?)dataRow["SoTietDayChuNhat"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?0.0m:(System.Decimal?)dataRow["SoTiet"];
			entity.MaLoaiHocPhan = (Convert.IsDBNull(dataRow["MaLoaiHocPhan"]))?(int)0:(System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.HeSoLopDongLyThuyet = (Convert.IsDBNull(dataRow["HeSoLopDongLyThuyet"]))?0.0m:(System.Decimal?)dataRow["HeSoLopDongLyThuyet"];
			entity.HeSoLopDongThTnTt = (Convert.IsDBNull(dataRow["HeSoLopDongThTnTt"]))?0.0m:(System.Decimal?)dataRow["HeSoLopDongThTnTt"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.TenLoaiHocPhan = (Convert.IsDBNull(dataRow["TenLoaiHocPhan"]))?string.Empty:(System.String)dataRow["TenLoaiHocPhan"];
			entity.LoaiHocPhan = (Convert.IsDBNull(dataRow["LoaiHocPhan"]))?string.Empty:(System.String)dataRow["LoaiHocPhan"];
			entity.SoGioThucGiangTrenLop = (Convert.IsDBNull(dataRow["SoGioThucGiangTrenLop"]))?0.0m:(System.Decimal?)dataRow["SoGioThucGiangTrenLop"];
			entity.SoGioChuanTinhThem = (Convert.IsDBNull(dataRow["SoGioChuanTinhThem"]))?0.0m:(System.Decimal?)dataRow["SoGioChuanTinhThem"];
			entity.MaNhomMon = (Convert.IsDBNull(dataRow["MaNhomMon"]))?(int)0:(System.Int32?)dataRow["MaNhomMon"];
			entity.TenNhomMon = (Convert.IsDBNull(dataRow["TenNhomMon"]))?string.Empty:(System.String)dataRow["TenNhomMon"];
			entity.HeSoHocKy = (Convert.IsDBNull(dataRow["HeSoHocKy"]))?0.0m:(System.Decimal?)dataRow["HeSoHocKy"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewSdhUteKhoiLuongQuyDoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSdhUteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSdhUteKhoiLuongQuyDoiFilterBuilder : SqlFilterBuilder<ViewSdhUteKhoiLuongQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSdhUteKhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		public ViewSdhUteKhoiLuongQuyDoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewSdhUteKhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewSdhUteKhoiLuongQuyDoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewSdhUteKhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewSdhUteKhoiLuongQuyDoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewSdhUteKhoiLuongQuyDoiFilterBuilder

	#region ViewSdhUteKhoiLuongQuyDoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSdhUteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSdhUteKhoiLuongQuyDoiParameterBuilder : ParameterizedSqlFilterBuilder<ViewSdhUteKhoiLuongQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSdhUteKhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		public ViewSdhUteKhoiLuongQuyDoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewSdhUteKhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewSdhUteKhoiLuongQuyDoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewSdhUteKhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewSdhUteKhoiLuongQuyDoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewSdhUteKhoiLuongQuyDoiParameterBuilder
	
	#region ViewSdhUteKhoiLuongQuyDoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSdhUteKhoiLuongQuyDoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewSdhUteKhoiLuongQuyDoiSortBuilder : SqlSortBuilder<ViewSdhUteKhoiLuongQuyDoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSdhUteKhoiLuongQuyDoiSqlSortBuilder class.
		/// </summary>
		public ViewSdhUteKhoiLuongQuyDoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewSdhUteKhoiLuongQuyDoiSortBuilder

} // end namespace
