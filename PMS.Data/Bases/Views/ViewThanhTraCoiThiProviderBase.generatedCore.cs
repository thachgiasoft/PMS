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
	/// This class is the base class for any <see cref="ViewThanhTraCoiThiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThanhTraCoiThiProviderBaseCore : EntityViewProviderBase<ViewThanhTraCoiThi>
	{
		#region Custom Methods
		
		
		#region cust_View_ThanhTraCoiThi_GetByNgayCoSoToaNha
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraCoiThi_GetByNgayCoSoToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraCoiThi&gt;"/> instance.</returns>
		public VList<ViewThanhTraCoiThi> GetByNgayCoSoToaNha(System.String tuNgay, System.String denNgay, System.String toaNha)
		{
			return GetByNgayCoSoToaNha(null, 0, int.MaxValue , tuNgay, denNgay, toaNha);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraCoiThi_GetByNgayCoSoToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraCoiThi&gt;"/> instance.</returns>
		public VList<ViewThanhTraCoiThi> GetByNgayCoSoToaNha(int start, int pageLength, System.String tuNgay, System.String denNgay, System.String toaNha)
		{
			return GetByNgayCoSoToaNha(null, start, pageLength , tuNgay, denNgay, toaNha);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraCoiThi_GetByNgayCoSoToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThanhTraCoiThi&gt;"/> instance.</returns>
		public VList<ViewThanhTraCoiThi> GetByNgayCoSoToaNha(TransactionManager transactionManager, System.String tuNgay, System.String denNgay, System.String toaNha)
		{
			return GetByNgayCoSoToaNha(transactionManager, 0, int.MaxValue , tuNgay, denNgay, toaNha);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraCoiThi_GetByNgayCoSoToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraCoiThi&gt;"/> instance.</returns>
		public abstract VList<ViewThanhTraCoiThi> GetByNgayCoSoToaNha(TransactionManager transactionManager, int start, int pageLength, System.String tuNgay, System.String denNgay, System.String toaNha);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThanhTraCoiThi&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThanhTraCoiThi&gt;"/></returns>
		protected static VList&lt;ViewThanhTraCoiThi&gt; Fill(DataSet dataSet, VList<ViewThanhTraCoiThi> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThanhTraCoiThi>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThanhTraCoiThi&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThanhTraCoiThi>"/></returns>
		protected static VList&lt;ViewThanhTraCoiThi&gt; Fill(DataTable dataTable, VList<ViewThanhTraCoiThi> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThanhTraCoiThi c = new ViewThanhTraCoiThi();
					c.Examination = (Convert.IsDBNull(row["Examination"]))?(int)0:(System.Int32)row["Examination"];
					c.MaCanBoCoiThi = (Convert.IsDBNull(row["MaCanBoCoiThi"]))?string.Empty:(System.String)row["MaCanBoCoiThi"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.NgayThi = (Convert.IsDBNull(row["NgayThi"]))?string.Empty:(System.String)row["NgayThi"];
					c.ThoiGianBatDau = (Convert.IsDBNull(row["ThoiGianBatDau"]))?string.Empty:(System.String)row["ThoiGianBatDau"];
					c.MaPhong = (Convert.IsDBNull(row["MaPhong"]))?string.Empty:(System.String)row["MaPhong"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.ThoiGianLamBai = (Convert.IsDBNull(row["ThoiGianLamBai"]))?string.Empty:(System.String)row["ThoiGianLamBai"];
					c.TietBatDau = (Convert.IsDBNull(row["TietBatDau"]))?(int)0:(System.Int32?)row["TietBatDau"];
					c.MaLopSinhVien = (Convert.IsDBNull(row["MaLopSinhVien"]))?string.Empty:(System.String)row["MaLopSinhVien"];
					c.SoLuongSinhVien = (Convert.IsDBNull(row["SoLuongSinhVien"]))?(int)0:(System.Int32?)row["SoLuongSinhVien"];
					c.TenKhoaChuQuan = (Convert.IsDBNull(row["TenKhoaChuQuan"]))?string.Empty:(System.String)row["TenKhoaChuQuan"];
					c.MaViPham = (Convert.IsDBNull(row["MaViPham"]))?string.Empty:(System.String)row["MaViPham"];
					c.MaHinhThucViPhamHrm = (Convert.IsDBNull(row["MaHinhThucViPhamHrm"]))?Guid.Empty:(System.Guid?)row["MaHinhThucViPhamHrm"];
					c.SiSoThanhTra = (Convert.IsDBNull(row["SiSoThanhTra"]))?(int)0:(System.Int32?)row["SiSoThanhTra"];
					c.ThoiDiemGhiNhan = (Convert.IsDBNull(row["ThoiDiemGhiNhan"]))?string.Empty:(System.String)row["ThoiDiemGhiNhan"];
					c.LyDo = (Convert.IsDBNull(row["LyDo"]))?string.Empty:(System.String)row["LyDo"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?string.Empty:(System.String)row["GhiChu"];
					c.NgayCapNhat = (Convert.IsDBNull(row["NgayCapNhat"]))?string.Empty:(System.String)row["NgayCapNhat"];
					c.NguoiCapNhat = (Convert.IsDBNull(row["NguoiCapNhat"]))?string.Empty:(System.String)row["NguoiCapNhat"];
					c.MaLoaiHocPhan = (Convert.IsDBNull(row["MaLoaiHocPhan"]))?(int)0:(System.Int32?)row["MaLoaiHocPhan"];
					c.TuTietDenTiet = (Convert.IsDBNull(row["TuTietDenTiet"]))?string.Empty:(System.String)row["TuTietDenTiet"];
					c.TrangThai = (Convert.IsDBNull(row["TrangThai"]))?false:(System.Boolean?)row["TrangThai"];
					c.XacNhan = (Convert.IsDBNull(row["XacNhan"]))?false:(System.Boolean?)row["XacNhan"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32)row["SoTiet"];
					c.Lt = (Convert.IsDBNull(row["Lt"]))?(int)0:(System.Int32?)row["Lt"];
					c.Th = (Convert.IsDBNull(row["Th"]))?(int)0:(System.Int32?)row["Th"];
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
		/// Fill an <see cref="VList&lt;ViewThanhTraCoiThi&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThanhTraCoiThi&gt;"/></returns>
		protected VList<ViewThanhTraCoiThi> Fill(IDataReader reader, VList<ViewThanhTraCoiThi> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThanhTraCoiThi entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThanhTraCoiThi>("ViewThanhTraCoiThi",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThanhTraCoiThi();
					}
					
					entity.SuppressEntityEvents = true;

					entity.Examination = (System.Int32)reader["Examination"];
					//entity.Examination = (Convert.IsDBNull(reader["Examination"]))?(int)0:(System.Int32)reader["Examination"];
					entity.MaCanBoCoiThi = (System.String)reader["MaCanBoCoiThi"];
					//entity.MaCanBoCoiThi = (Convert.IsDBNull(reader["MaCanBoCoiThi"]))?string.Empty:(System.String)reader["MaCanBoCoiThi"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.NgayThi = reader.IsDBNull(reader.GetOrdinal("NgayThi")) ? null : (System.String)reader["NgayThi"];
					//entity.NgayThi = (Convert.IsDBNull(reader["NgayThi"]))?string.Empty:(System.String)reader["NgayThi"];
					entity.ThoiGianBatDau = reader.IsDBNull(reader.GetOrdinal("ThoiGianBatDau")) ? null : (System.String)reader["ThoiGianBatDau"];
					//entity.ThoiGianBatDau = (Convert.IsDBNull(reader["ThoiGianBatDau"]))?string.Empty:(System.String)reader["ThoiGianBatDau"];
					entity.MaPhong = reader.IsDBNull(reader.GetOrdinal("MaPhong")) ? null : (System.String)reader["MaPhong"];
					//entity.MaPhong = (Convert.IsDBNull(reader["MaPhong"]))?string.Empty:(System.String)reader["MaPhong"];
					entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = reader.IsDBNull(reader.GetOrdinal("TenMonHoc")) ? null : (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.ThoiGianLamBai = reader.IsDBNull(reader.GetOrdinal("ThoiGianLamBai")) ? null : (System.String)reader["ThoiGianLamBai"];
					//entity.ThoiGianLamBai = (Convert.IsDBNull(reader["ThoiGianLamBai"]))?string.Empty:(System.String)reader["ThoiGianLamBai"];
					entity.TietBatDau = reader.IsDBNull(reader.GetOrdinal("TietBatDau")) ? null : (System.Int32?)reader["TietBatDau"];
					//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
					entity.MaLopSinhVien = reader.IsDBNull(reader.GetOrdinal("MaLopSinhVien")) ? null : (System.String)reader["MaLopSinhVien"];
					//entity.MaLopSinhVien = (Convert.IsDBNull(reader["MaLopSinhVien"]))?string.Empty:(System.String)reader["MaLopSinhVien"];
					entity.SoLuongSinhVien = reader.IsDBNull(reader.GetOrdinal("SoLuongSinhVien")) ? null : (System.Int32?)reader["SoLuongSinhVien"];
					//entity.SoLuongSinhVien = (Convert.IsDBNull(reader["SoLuongSinhVien"]))?(int)0:(System.Int32?)reader["SoLuongSinhVien"];
					entity.TenKhoaChuQuan = reader.IsDBNull(reader.GetOrdinal("TenKhoaChuQuan")) ? null : (System.String)reader["TenKhoaChuQuan"];
					//entity.TenKhoaChuQuan = (Convert.IsDBNull(reader["TenKhoaChuQuan"]))?string.Empty:(System.String)reader["TenKhoaChuQuan"];
					entity.MaViPham = reader.IsDBNull(reader.GetOrdinal("MaViPham")) ? null : (System.String)reader["MaViPham"];
					//entity.MaViPham = (Convert.IsDBNull(reader["MaViPham"]))?string.Empty:(System.String)reader["MaViPham"];
					entity.MaHinhThucViPhamHrm = reader.IsDBNull(reader.GetOrdinal("MaHinhThucViPhamHrm")) ? null : (System.Guid?)reader["MaHinhThucViPhamHrm"];
					//entity.MaHinhThucViPhamHrm = (Convert.IsDBNull(reader["MaHinhThucViPhamHrm"]))?Guid.Empty:(System.Guid?)reader["MaHinhThucViPhamHrm"];
					entity.SiSoThanhTra = reader.IsDBNull(reader.GetOrdinal("SiSoThanhTra")) ? null : (System.Int32?)reader["SiSoThanhTra"];
					//entity.SiSoThanhTra = (Convert.IsDBNull(reader["SiSoThanhTra"]))?(int)0:(System.Int32?)reader["SiSoThanhTra"];
					entity.ThoiDiemGhiNhan = reader.IsDBNull(reader.GetOrdinal("ThoiDiemGhiNhan")) ? null : (System.String)reader["ThoiDiemGhiNhan"];
					//entity.ThoiDiemGhiNhan = (Convert.IsDBNull(reader["ThoiDiemGhiNhan"]))?string.Empty:(System.String)reader["ThoiDiemGhiNhan"];
					entity.LyDo = reader.IsDBNull(reader.GetOrdinal("LyDo")) ? null : (System.String)reader["LyDo"];
					//entity.LyDo = (Convert.IsDBNull(reader["LyDo"]))?string.Empty:(System.String)reader["LyDo"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
					entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
					//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
					entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
					//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
					entity.MaLoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLoaiHocPhan")) ? null : (System.Int32?)reader["MaLoaiHocPhan"];
					//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(int)0:(System.Int32?)reader["MaLoaiHocPhan"];
					entity.TuTietDenTiet = reader.IsDBNull(reader.GetOrdinal("TuTietDenTiet")) ? null : (System.String)reader["TuTietDenTiet"];
					//entity.TuTietDenTiet = (Convert.IsDBNull(reader["TuTietDenTiet"]))?string.Empty:(System.String)reader["TuTietDenTiet"];
					entity.TrangThai = reader.IsDBNull(reader.GetOrdinal("TrangThai")) ? null : (System.Boolean?)reader["TrangThai"];
					//entity.TrangThai = (Convert.IsDBNull(reader["TrangThai"]))?false:(System.Boolean?)reader["TrangThai"];
					entity.XacNhan = reader.IsDBNull(reader.GetOrdinal("XacNhan")) ? null : (System.Boolean?)reader["XacNhan"];
					//entity.XacNhan = (Convert.IsDBNull(reader["XacNhan"]))?false:(System.Boolean?)reader["XacNhan"];
					entity.SoTiet = (System.Int32)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32)reader["SoTiet"];
					entity.Lt = reader.IsDBNull(reader.GetOrdinal("Lt")) ? null : (System.Int32?)reader["Lt"];
					//entity.Lt = (Convert.IsDBNull(reader["Lt"]))?(int)0:(System.Int32?)reader["Lt"];
					entity.Th = reader.IsDBNull(reader.GetOrdinal("Th")) ? null : (System.Int32?)reader["Th"];
					//entity.Th = (Convert.IsDBNull(reader["Th"]))?(int)0:(System.Int32?)reader["Th"];
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
		/// Refreshes the <see cref="ViewThanhTraCoiThi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThanhTraCoiThi"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThanhTraCoiThi entity)
		{
			reader.Read();
			entity.Examination = (System.Int32)reader["Examination"];
			//entity.Examination = (Convert.IsDBNull(reader["Examination"]))?(int)0:(System.Int32)reader["Examination"];
			entity.MaCanBoCoiThi = (System.String)reader["MaCanBoCoiThi"];
			//entity.MaCanBoCoiThi = (Convert.IsDBNull(reader["MaCanBoCoiThi"]))?string.Empty:(System.String)reader["MaCanBoCoiThi"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.NgayThi = reader.IsDBNull(reader.GetOrdinal("NgayThi")) ? null : (System.String)reader["NgayThi"];
			//entity.NgayThi = (Convert.IsDBNull(reader["NgayThi"]))?string.Empty:(System.String)reader["NgayThi"];
			entity.ThoiGianBatDau = reader.IsDBNull(reader.GetOrdinal("ThoiGianBatDau")) ? null : (System.String)reader["ThoiGianBatDau"];
			//entity.ThoiGianBatDau = (Convert.IsDBNull(reader["ThoiGianBatDau"]))?string.Empty:(System.String)reader["ThoiGianBatDau"];
			entity.MaPhong = reader.IsDBNull(reader.GetOrdinal("MaPhong")) ? null : (System.String)reader["MaPhong"];
			//entity.MaPhong = (Convert.IsDBNull(reader["MaPhong"]))?string.Empty:(System.String)reader["MaPhong"];
			entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = reader.IsDBNull(reader.GetOrdinal("TenMonHoc")) ? null : (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.ThoiGianLamBai = reader.IsDBNull(reader.GetOrdinal("ThoiGianLamBai")) ? null : (System.String)reader["ThoiGianLamBai"];
			//entity.ThoiGianLamBai = (Convert.IsDBNull(reader["ThoiGianLamBai"]))?string.Empty:(System.String)reader["ThoiGianLamBai"];
			entity.TietBatDau = reader.IsDBNull(reader.GetOrdinal("TietBatDau")) ? null : (System.Int32?)reader["TietBatDau"];
			//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
			entity.MaLopSinhVien = reader.IsDBNull(reader.GetOrdinal("MaLopSinhVien")) ? null : (System.String)reader["MaLopSinhVien"];
			//entity.MaLopSinhVien = (Convert.IsDBNull(reader["MaLopSinhVien"]))?string.Empty:(System.String)reader["MaLopSinhVien"];
			entity.SoLuongSinhVien = reader.IsDBNull(reader.GetOrdinal("SoLuongSinhVien")) ? null : (System.Int32?)reader["SoLuongSinhVien"];
			//entity.SoLuongSinhVien = (Convert.IsDBNull(reader["SoLuongSinhVien"]))?(int)0:(System.Int32?)reader["SoLuongSinhVien"];
			entity.TenKhoaChuQuan = reader.IsDBNull(reader.GetOrdinal("TenKhoaChuQuan")) ? null : (System.String)reader["TenKhoaChuQuan"];
			//entity.TenKhoaChuQuan = (Convert.IsDBNull(reader["TenKhoaChuQuan"]))?string.Empty:(System.String)reader["TenKhoaChuQuan"];
			entity.MaViPham = reader.IsDBNull(reader.GetOrdinal("MaViPham")) ? null : (System.String)reader["MaViPham"];
			//entity.MaViPham = (Convert.IsDBNull(reader["MaViPham"]))?string.Empty:(System.String)reader["MaViPham"];
			entity.MaHinhThucViPhamHrm = reader.IsDBNull(reader.GetOrdinal("MaHinhThucViPhamHrm")) ? null : (System.Guid?)reader["MaHinhThucViPhamHrm"];
			//entity.MaHinhThucViPhamHrm = (Convert.IsDBNull(reader["MaHinhThucViPhamHrm"]))?Guid.Empty:(System.Guid?)reader["MaHinhThucViPhamHrm"];
			entity.SiSoThanhTra = reader.IsDBNull(reader.GetOrdinal("SiSoThanhTra")) ? null : (System.Int32?)reader["SiSoThanhTra"];
			//entity.SiSoThanhTra = (Convert.IsDBNull(reader["SiSoThanhTra"]))?(int)0:(System.Int32?)reader["SiSoThanhTra"];
			entity.ThoiDiemGhiNhan = reader.IsDBNull(reader.GetOrdinal("ThoiDiemGhiNhan")) ? null : (System.String)reader["ThoiDiemGhiNhan"];
			//entity.ThoiDiemGhiNhan = (Convert.IsDBNull(reader["ThoiDiemGhiNhan"]))?string.Empty:(System.String)reader["ThoiDiemGhiNhan"];
			entity.LyDo = reader.IsDBNull(reader.GetOrdinal("LyDo")) ? null : (System.String)reader["LyDo"];
			//entity.LyDo = (Convert.IsDBNull(reader["LyDo"]))?string.Empty:(System.String)reader["LyDo"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
			entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
			entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
			//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
			entity.MaLoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLoaiHocPhan")) ? null : (System.Int32?)reader["MaLoaiHocPhan"];
			//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(int)0:(System.Int32?)reader["MaLoaiHocPhan"];
			entity.TuTietDenTiet = reader.IsDBNull(reader.GetOrdinal("TuTietDenTiet")) ? null : (System.String)reader["TuTietDenTiet"];
			//entity.TuTietDenTiet = (Convert.IsDBNull(reader["TuTietDenTiet"]))?string.Empty:(System.String)reader["TuTietDenTiet"];
			entity.TrangThai = reader.IsDBNull(reader.GetOrdinal("TrangThai")) ? null : (System.Boolean?)reader["TrangThai"];
			//entity.TrangThai = (Convert.IsDBNull(reader["TrangThai"]))?false:(System.Boolean?)reader["TrangThai"];
			entity.XacNhan = reader.IsDBNull(reader.GetOrdinal("XacNhan")) ? null : (System.Boolean?)reader["XacNhan"];
			//entity.XacNhan = (Convert.IsDBNull(reader["XacNhan"]))?false:(System.Boolean?)reader["XacNhan"];
			entity.SoTiet = (System.Int32)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32)reader["SoTiet"];
			entity.Lt = reader.IsDBNull(reader.GetOrdinal("Lt")) ? null : (System.Int32?)reader["Lt"];
			//entity.Lt = (Convert.IsDBNull(reader["Lt"]))?(int)0:(System.Int32?)reader["Lt"];
			entity.Th = reader.IsDBNull(reader.GetOrdinal("Th")) ? null : (System.Int32?)reader["Th"];
			//entity.Th = (Convert.IsDBNull(reader["Th"]))?(int)0:(System.Int32?)reader["Th"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThanhTraCoiThi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThanhTraCoiThi"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThanhTraCoiThi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Examination = (Convert.IsDBNull(dataRow["Examination"]))?(int)0:(System.Int32)dataRow["Examination"];
			entity.MaCanBoCoiThi = (Convert.IsDBNull(dataRow["MaCanBoCoiThi"]))?string.Empty:(System.String)dataRow["MaCanBoCoiThi"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.NgayThi = (Convert.IsDBNull(dataRow["NgayThi"]))?string.Empty:(System.String)dataRow["NgayThi"];
			entity.ThoiGianBatDau = (Convert.IsDBNull(dataRow["ThoiGianBatDau"]))?string.Empty:(System.String)dataRow["ThoiGianBatDau"];
			entity.MaPhong = (Convert.IsDBNull(dataRow["MaPhong"]))?string.Empty:(System.String)dataRow["MaPhong"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.ThoiGianLamBai = (Convert.IsDBNull(dataRow["ThoiGianLamBai"]))?string.Empty:(System.String)dataRow["ThoiGianLamBai"];
			entity.TietBatDau = (Convert.IsDBNull(dataRow["TietBatDau"]))?(int)0:(System.Int32?)dataRow["TietBatDau"];
			entity.MaLopSinhVien = (Convert.IsDBNull(dataRow["MaLopSinhVien"]))?string.Empty:(System.String)dataRow["MaLopSinhVien"];
			entity.SoLuongSinhVien = (Convert.IsDBNull(dataRow["SoLuongSinhVien"]))?(int)0:(System.Int32?)dataRow["SoLuongSinhVien"];
			entity.TenKhoaChuQuan = (Convert.IsDBNull(dataRow["TenKhoaChuQuan"]))?string.Empty:(System.String)dataRow["TenKhoaChuQuan"];
			entity.MaViPham = (Convert.IsDBNull(dataRow["MaViPham"]))?string.Empty:(System.String)dataRow["MaViPham"];
			entity.MaHinhThucViPhamHrm = (Convert.IsDBNull(dataRow["MaHinhThucViPhamHrm"]))?Guid.Empty:(System.Guid?)dataRow["MaHinhThucViPhamHrm"];
			entity.SiSoThanhTra = (Convert.IsDBNull(dataRow["SiSoThanhTra"]))?(int)0:(System.Int32?)dataRow["SiSoThanhTra"];
			entity.ThoiDiemGhiNhan = (Convert.IsDBNull(dataRow["ThoiDiemGhiNhan"]))?string.Empty:(System.String)dataRow["ThoiDiemGhiNhan"];
			entity.LyDo = (Convert.IsDBNull(dataRow["LyDo"]))?string.Empty:(System.String)dataRow["LyDo"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?string.Empty:(System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?string.Empty:(System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = (Convert.IsDBNull(dataRow["NguoiCapNhat"]))?string.Empty:(System.String)dataRow["NguoiCapNhat"];
			entity.MaLoaiHocPhan = (Convert.IsDBNull(dataRow["MaLoaiHocPhan"]))?(int)0:(System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.TuTietDenTiet = (Convert.IsDBNull(dataRow["TuTietDenTiet"]))?string.Empty:(System.String)dataRow["TuTietDenTiet"];
			entity.TrangThai = (Convert.IsDBNull(dataRow["TrangThai"]))?false:(System.Boolean?)dataRow["TrangThai"];
			entity.XacNhan = (Convert.IsDBNull(dataRow["XacNhan"]))?false:(System.Boolean?)dataRow["XacNhan"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32)dataRow["SoTiet"];
			entity.Lt = (Convert.IsDBNull(dataRow["Lt"]))?(int)0:(System.Int32?)dataRow["Lt"];
			entity.Th = (Convert.IsDBNull(dataRow["Th"]))?(int)0:(System.Int32?)dataRow["Th"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThanhTraCoiThiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraCoiThiFilterBuilder : SqlFilterBuilder<ViewThanhTraCoiThiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraCoiThiFilterBuilder class.
		/// </summary>
		public ViewThanhTraCoiThiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraCoiThiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThanhTraCoiThiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraCoiThiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThanhTraCoiThiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThanhTraCoiThiFilterBuilder

	#region ViewThanhTraCoiThiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraCoiThiParameterBuilder : ParameterizedSqlFilterBuilder<ViewThanhTraCoiThiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraCoiThiParameterBuilder class.
		/// </summary>
		public ViewThanhTraCoiThiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraCoiThiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThanhTraCoiThiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraCoiThiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThanhTraCoiThiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThanhTraCoiThiParameterBuilder
	
	#region ViewThanhTraCoiThiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraCoiThi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThanhTraCoiThiSortBuilder : SqlSortBuilder<ViewThanhTraCoiThiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraCoiThiSqlSortBuilder class.
		/// </summary>
		public ViewThanhTraCoiThiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThanhTraCoiThiSortBuilder

} // end namespace
