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
	/// This class is the base class for any <see cref="ViewTheoDoiGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewTheoDoiGiangDayProviderBaseCore : EntityViewProviderBase<ViewTheoDoiGiangDay>
	{
		#region Custom Methods
		
		
		#region cust_View_TheoDoi_GiangDay_GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_TheoDoi_GiangDay_GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maCoSo"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTheoDoiGiangDay&gt;"/> instance.</returns>
		public VList<ViewTheoDoiGiangDay> GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay(System.String maCoSo, System.Int32 maLoaiGiangVien, System.DateTime tuNgay, System.DateTime denNgay, System.String value)
		{
			return GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay(null, 0, int.MaxValue , maCoSo, maLoaiGiangVien, tuNgay, denNgay, value);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TheoDoi_GiangDay_GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maCoSo"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTheoDoiGiangDay&gt;"/> instance.</returns>
		public VList<ViewTheoDoiGiangDay> GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay(int start, int pageLength, System.String maCoSo, System.Int32 maLoaiGiangVien, System.DateTime tuNgay, System.DateTime denNgay, System.String value)
		{
			return GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay(null, start, pageLength , maCoSo, maLoaiGiangVien, tuNgay, denNgay, value);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_TheoDoi_GiangDay_GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maCoSo"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewTheoDoiGiangDay&gt;"/> instance.</returns>
		public VList<ViewTheoDoiGiangDay> GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay(TransactionManager transactionManager, System.String maCoSo, System.Int32 maLoaiGiangVien, System.DateTime tuNgay, System.DateTime denNgay, System.String value)
		{
			return GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay(transactionManager, 0, int.MaxValue , maCoSo, maLoaiGiangVien, tuNgay, denNgay, value);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TheoDoi_GiangDay_GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maCoSo"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTheoDoiGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewTheoDoiGiangDay> GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength, System.String maCoSo, System.Int32 maLoaiGiangVien, System.DateTime tuNgay, System.DateTime denNgay, System.String value);
		
		#endregion

		
		#region cust_View_TheoDoi_GiangDay_GetByMaLoaiGiangVienTuNgayDenNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_TheoDoi_GiangDay_GetByMaLoaiGiangVienTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTheoDoiGiangDay&gt;"/> instance.</returns>
		public VList<ViewTheoDoiGiangDay> GetByMaLoaiGiangVienTuNgayDenNgay(System.Int32 maLoaiGiangVien, System.DateTime tuNgay, System.DateTime denNgay, System.String value)
		{
			return GetByMaLoaiGiangVienTuNgayDenNgay(null, 0, int.MaxValue , maLoaiGiangVien, tuNgay, denNgay, value);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TheoDoi_GiangDay_GetByMaLoaiGiangVienTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTheoDoiGiangDay&gt;"/> instance.</returns>
		public VList<ViewTheoDoiGiangDay> GetByMaLoaiGiangVienTuNgayDenNgay(int start, int pageLength, System.Int32 maLoaiGiangVien, System.DateTime tuNgay, System.DateTime denNgay, System.String value)
		{
			return GetByMaLoaiGiangVienTuNgayDenNgay(null, start, pageLength , maLoaiGiangVien, tuNgay, denNgay, value);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_TheoDoi_GiangDay_GetByMaLoaiGiangVienTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewTheoDoiGiangDay&gt;"/> instance.</returns>
		public VList<ViewTheoDoiGiangDay> GetByMaLoaiGiangVienTuNgayDenNgay(TransactionManager transactionManager, System.Int32 maLoaiGiangVien, System.DateTime tuNgay, System.DateTime denNgay, System.String value)
		{
			return GetByMaLoaiGiangVienTuNgayDenNgay(transactionManager, 0, int.MaxValue , maLoaiGiangVien, tuNgay, denNgay, value);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_TheoDoi_GiangDay_GetByMaLoaiGiangVienTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="value"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTheoDoiGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewTheoDoiGiangDay> GetByMaLoaiGiangVienTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength, System.Int32 maLoaiGiangVien, System.DateTime tuNgay, System.DateTime denNgay, System.String value);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewTheoDoiGiangDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewTheoDoiGiangDay&gt;"/></returns>
		protected static VList&lt;ViewTheoDoiGiangDay&gt; Fill(DataSet dataSet, VList<ViewTheoDoiGiangDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewTheoDoiGiangDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewTheoDoiGiangDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewTheoDoiGiangDay>"/></returns>
		protected static VList&lt;ViewTheoDoiGiangDay&gt; Fill(DataTable dataTable, VList<ViewTheoDoiGiangDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewTheoDoiGiangDay c = new ViewTheoDoiGiangDay();
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32)row["MaLoaiGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.SoDiDong = (Convert.IsDBNull(row["SoDiDong"]))?string.Empty:(System.String)row["SoDiDong"];
					c.ChucDanh = (Convert.IsDBNull(row["ChucDanh"]))?string.Empty:(System.String)row["ChucDanh"];
					c.TenKhoa = (Convert.IsDBNull(row["TenKhoa"]))?string.Empty:(System.String)row["TenKhoa"];
					c.TenBoMon = (Convert.IsDBNull(row["TenBoMon"]))?string.Empty:(System.String)row["TenBoMon"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?0.0m:(System.Decimal?)row["SoTiet"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?0.0m:(System.Decimal?)row["SoTinChi"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.ThoiKhoaBieu = (Convert.IsDBNull(row["ThoiKhoaBieu"]))?string.Empty:(System.String)row["ThoiKhoaBieu"];
					c.MaNhom = (Convert.IsDBNull(row["MaNhom"]))?string.Empty:(System.String)row["MaNhom"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.NgayBatDau = (Convert.IsDBNull(row["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)row["NgayBatDau"];
					c.NgayKetThuc = (Convert.IsDBNull(row["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)row["NgayKetThuc"];
					c.ThoiGianGiang = (Convert.IsDBNull(row["ThoiGianGiang"]))?string.Empty:(System.String)row["ThoiGianGiang"];
					c.MaToaNha = (Convert.IsDBNull(row["MaToaNha"]))?string.Empty:(System.String)row["MaToaNha"];
					c.MaDiaDiem = (Convert.IsDBNull(row["MaDiaDiem"]))?string.Empty:(System.String)row["MaDiaDiem"];
					c.MaBacLoaiHinh = (Convert.IsDBNull(row["MaBacLoaiHinh"]))?string.Empty:(System.String)row["MaBacLoaiHinh"];
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
		/// Fill an <see cref="VList&lt;ViewTheoDoiGiangDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewTheoDoiGiangDay&gt;"/></returns>
		protected VList<ViewTheoDoiGiangDay> Fill(IDataReader reader, VList<ViewTheoDoiGiangDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewTheoDoiGiangDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewTheoDoiGiangDay>("ViewTheoDoiGiangDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewTheoDoiGiangDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLoaiGiangVien = (System.Int32)reader["MaLoaiGiangVien"];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32)reader["MaLoaiGiangVien"];
					entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.SoDiDong = reader.IsDBNull(reader.GetOrdinal("SoDiDong")) ? null : (System.String)reader["SoDiDong"];
					//entity.SoDiDong = (Convert.IsDBNull(reader["SoDiDong"]))?string.Empty:(System.String)reader["SoDiDong"];
					entity.ChucDanh = reader.IsDBNull(reader.GetOrdinal("ChucDanh")) ? null : (System.String)reader["ChucDanh"];
					//entity.ChucDanh = (Convert.IsDBNull(reader["ChucDanh"]))?string.Empty:(System.String)reader["ChucDanh"];
					entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
					//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
					entity.TenBoMon = reader.IsDBNull(reader.GetOrdinal("TenBoMon")) ? null : (System.String)reader["TenBoMon"];
					//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
					entity.MaMonHoc = (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Decimal?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
					entity.SoTinChi = reader.IsDBNull(reader.GetOrdinal("SoTinChi")) ? null : (System.Decimal?)reader["SoTinChi"];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal?)reader["SoTinChi"];
					entity.TenMonHoc = (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.ThoiKhoaBieu = reader.IsDBNull(reader.GetOrdinal("ThoiKhoaBieu")) ? null : (System.String)reader["ThoiKhoaBieu"];
					//entity.ThoiKhoaBieu = (Convert.IsDBNull(reader["ThoiKhoaBieu"]))?string.Empty:(System.String)reader["ThoiKhoaBieu"];
					entity.MaNhom = reader.IsDBNull(reader.GetOrdinal("MaNhom")) ? null : (System.String)reader["MaNhom"];
					//entity.MaNhom = (Convert.IsDBNull(reader["MaNhom"]))?string.Empty:(System.String)reader["MaNhom"];
					entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.NgayBatDau = reader.IsDBNull(reader.GetOrdinal("NgayBatDau")) ? null : (System.DateTime?)reader["NgayBatDau"];
					//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
					entity.NgayKetThuc = reader.IsDBNull(reader.GetOrdinal("NgayKetThuc")) ? null : (System.DateTime?)reader["NgayKetThuc"];
					//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
					entity.ThoiGianGiang = reader.IsDBNull(reader.GetOrdinal("ThoiGianGiang")) ? null : (System.String)reader["ThoiGianGiang"];
					//entity.ThoiGianGiang = (Convert.IsDBNull(reader["ThoiGianGiang"]))?string.Empty:(System.String)reader["ThoiGianGiang"];
					entity.MaToaNha = reader.IsDBNull(reader.GetOrdinal("MaToaNha")) ? null : (System.String)reader["MaToaNha"];
					//entity.MaToaNha = (Convert.IsDBNull(reader["MaToaNha"]))?string.Empty:(System.String)reader["MaToaNha"];
					entity.MaDiaDiem = reader.IsDBNull(reader.GetOrdinal("MaDiaDiem")) ? null : (System.String)reader["MaDiaDiem"];
					//entity.MaDiaDiem = (Convert.IsDBNull(reader["MaDiaDiem"]))?string.Empty:(System.String)reader["MaDiaDiem"];
					entity.MaBacLoaiHinh = (System.String)reader["MaBacLoaiHinh"];
					//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
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
		/// Refreshes the <see cref="ViewTheoDoiGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTheoDoiGiangDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewTheoDoiGiangDay entity)
		{
			reader.Read();
			entity.MaLoaiGiangVien = (System.Int32)reader["MaLoaiGiangVien"];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32)reader["MaLoaiGiangVien"];
			entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.SoDiDong = reader.IsDBNull(reader.GetOrdinal("SoDiDong")) ? null : (System.String)reader["SoDiDong"];
			//entity.SoDiDong = (Convert.IsDBNull(reader["SoDiDong"]))?string.Empty:(System.String)reader["SoDiDong"];
			entity.ChucDanh = reader.IsDBNull(reader.GetOrdinal("ChucDanh")) ? null : (System.String)reader["ChucDanh"];
			//entity.ChucDanh = (Convert.IsDBNull(reader["ChucDanh"]))?string.Empty:(System.String)reader["ChucDanh"];
			entity.TenKhoa = reader.IsDBNull(reader.GetOrdinal("TenKhoa")) ? null : (System.String)reader["TenKhoa"];
			//entity.TenKhoa = (Convert.IsDBNull(reader["TenKhoa"]))?string.Empty:(System.String)reader["TenKhoa"];
			entity.TenBoMon = reader.IsDBNull(reader.GetOrdinal("TenBoMon")) ? null : (System.String)reader["TenBoMon"];
			//entity.TenBoMon = (Convert.IsDBNull(reader["TenBoMon"]))?string.Empty:(System.String)reader["TenBoMon"];
			entity.MaMonHoc = (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Decimal?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
			entity.SoTinChi = reader.IsDBNull(reader.GetOrdinal("SoTinChi")) ? null : (System.Decimal?)reader["SoTinChi"];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal?)reader["SoTinChi"];
			entity.TenMonHoc = (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.ThoiKhoaBieu = reader.IsDBNull(reader.GetOrdinal("ThoiKhoaBieu")) ? null : (System.String)reader["ThoiKhoaBieu"];
			//entity.ThoiKhoaBieu = (Convert.IsDBNull(reader["ThoiKhoaBieu"]))?string.Empty:(System.String)reader["ThoiKhoaBieu"];
			entity.MaNhom = reader.IsDBNull(reader.GetOrdinal("MaNhom")) ? null : (System.String)reader["MaNhom"];
			//entity.MaNhom = (Convert.IsDBNull(reader["MaNhom"]))?string.Empty:(System.String)reader["MaNhom"];
			entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.NgayBatDau = reader.IsDBNull(reader.GetOrdinal("NgayBatDau")) ? null : (System.DateTime?)reader["NgayBatDau"];
			//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
			entity.NgayKetThuc = reader.IsDBNull(reader.GetOrdinal("NgayKetThuc")) ? null : (System.DateTime?)reader["NgayKetThuc"];
			//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
			entity.ThoiGianGiang = reader.IsDBNull(reader.GetOrdinal("ThoiGianGiang")) ? null : (System.String)reader["ThoiGianGiang"];
			//entity.ThoiGianGiang = (Convert.IsDBNull(reader["ThoiGianGiang"]))?string.Empty:(System.String)reader["ThoiGianGiang"];
			entity.MaToaNha = reader.IsDBNull(reader.GetOrdinal("MaToaNha")) ? null : (System.String)reader["MaToaNha"];
			//entity.MaToaNha = (Convert.IsDBNull(reader["MaToaNha"]))?string.Empty:(System.String)reader["MaToaNha"];
			entity.MaDiaDiem = reader.IsDBNull(reader.GetOrdinal("MaDiaDiem")) ? null : (System.String)reader["MaDiaDiem"];
			//entity.MaDiaDiem = (Convert.IsDBNull(reader["MaDiaDiem"]))?string.Empty:(System.String)reader["MaDiaDiem"];
			entity.MaBacLoaiHinh = (System.String)reader["MaBacLoaiHinh"];
			//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewTheoDoiGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTheoDoiGiangDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewTheoDoiGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32)dataRow["MaLoaiGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.SoDiDong = (Convert.IsDBNull(dataRow["SoDiDong"]))?string.Empty:(System.String)dataRow["SoDiDong"];
			entity.ChucDanh = (Convert.IsDBNull(dataRow["ChucDanh"]))?string.Empty:(System.String)dataRow["ChucDanh"];
			entity.TenKhoa = (Convert.IsDBNull(dataRow["TenKhoa"]))?string.Empty:(System.String)dataRow["TenKhoa"];
			entity.TenBoMon = (Convert.IsDBNull(dataRow["TenBoMon"]))?string.Empty:(System.String)dataRow["TenBoMon"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?0.0m:(System.Decimal?)dataRow["SoTiet"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?0.0m:(System.Decimal?)dataRow["SoTinChi"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.ThoiKhoaBieu = (Convert.IsDBNull(dataRow["ThoiKhoaBieu"]))?string.Empty:(System.String)dataRow["ThoiKhoaBieu"];
			entity.MaNhom = (Convert.IsDBNull(dataRow["MaNhom"]))?string.Empty:(System.String)dataRow["MaNhom"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.NgayBatDau = (Convert.IsDBNull(dataRow["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayBatDau"];
			entity.NgayKetThuc = (Convert.IsDBNull(dataRow["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKetThuc"];
			entity.ThoiGianGiang = (Convert.IsDBNull(dataRow["ThoiGianGiang"]))?string.Empty:(System.String)dataRow["ThoiGianGiang"];
			entity.MaToaNha = (Convert.IsDBNull(dataRow["MaToaNha"]))?string.Empty:(System.String)dataRow["MaToaNha"];
			entity.MaDiaDiem = (Convert.IsDBNull(dataRow["MaDiaDiem"]))?string.Empty:(System.String)dataRow["MaDiaDiem"];
			entity.MaBacLoaiHinh = (Convert.IsDBNull(dataRow["MaBacLoaiHinh"]))?string.Empty:(System.String)dataRow["MaBacLoaiHinh"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewTheoDoiGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTheoDoiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTheoDoiGiangDayFilterBuilder : SqlFilterBuilder<ViewTheoDoiGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiGiangDayFilterBuilder class.
		/// </summary>
		public ViewTheoDoiGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTheoDoiGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTheoDoiGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTheoDoiGiangDayFilterBuilder

	#region ViewTheoDoiGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTheoDoiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTheoDoiGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewTheoDoiGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiGiangDayParameterBuilder class.
		/// </summary>
		public ViewTheoDoiGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTheoDoiGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTheoDoiGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTheoDoiGiangDayParameterBuilder
	
	#region ViewTheoDoiGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTheoDoiGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewTheoDoiGiangDaySortBuilder : SqlSortBuilder<ViewTheoDoiGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiGiangDaySqlSortBuilder class.
		/// </summary>
		public ViewTheoDoiGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewTheoDoiGiangDaySortBuilder

} // end namespace
