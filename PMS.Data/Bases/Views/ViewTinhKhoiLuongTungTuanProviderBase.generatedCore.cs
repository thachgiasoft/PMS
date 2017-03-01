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
	/// This class is the base class for any <see cref="ViewTinhKhoiLuongTungTuanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewTinhKhoiLuongTungTuanProviderBaseCore : EntityViewProviderBase<ViewTinhKhoiLuongTungTuan>
	{
		#region Custom Methods
		
		
		#region cust_View_Tinh_KhoiLuong_TungTuan_GetByTuNgayDenNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_TungTuan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTinhKhoiLuongTungTuan&gt;"/> instance.</returns>
		public VList<ViewTinhKhoiLuongTungTuan> GetByTuNgayDenNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_TungTuan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTinhKhoiLuongTungTuan&gt;"/> instance.</returns>
		public VList<ViewTinhKhoiLuongTungTuan> GetByTuNgayDenNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_TungTuan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewTinhKhoiLuongTungTuan&gt;"/> instance.</returns>
		public VList<ViewTinhKhoiLuongTungTuan> GetByTuNgayDenNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_Tinh_KhoiLuong_TungTuan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewTinhKhoiLuongTungTuan&gt;"/> instance.</returns>
		public abstract VList<ViewTinhKhoiLuongTungTuan> GetByTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewTinhKhoiLuongTungTuan&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewTinhKhoiLuongTungTuan&gt;"/></returns>
		protected static VList&lt;ViewTinhKhoiLuongTungTuan&gt; Fill(DataSet dataSet, VList<ViewTinhKhoiLuongTungTuan> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewTinhKhoiLuongTungTuan>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewTinhKhoiLuongTungTuan&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewTinhKhoiLuongTungTuan>"/></returns>
		protected static VList&lt;ViewTinhKhoiLuongTungTuan&gt; Fill(DataTable dataTable, VList<ViewTinhKhoiLuongTungTuan> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewTinhKhoiLuongTungTuan c = new ViewTinhKhoiLuongTungTuan();
					c.MaKhoiLuong = (Convert.IsDBNull(row["MaKhoiLuong"]))?(int)0:(System.Int32)row["MaKhoiLuong"];
					c.MaToaNha = (Convert.IsDBNull(row["MaToaNha"]))?string.Empty:(System.String)row["MaToaNha"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.MaNhom = (Convert.IsDBNull(row["MaNhom"]))?string.Empty:(System.String)row["MaNhom"];
					c.LoaiHocPhan = (Convert.IsDBNull(row["LoaiHocPhan"]))?string.Empty:(System.String)row["LoaiHocPhan"];
					c.PhanLoai = (Convert.IsDBNull(row["PhanLoai"]))?string.Empty:(System.String)row["PhanLoai"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.DienGiai = (Convert.IsDBNull(row["DienGiai"]))?string.Empty:(System.String)row["DienGiai"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?0.0m:(System.Decimal?)row["SoTiet"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?0.0m:(System.Decimal?)row["SoTinChi"];
					c.SiSoLop = (Convert.IsDBNull(row["SiSoLop"]))?(int)0:(System.Int32?)row["SiSoLop"];
					c.SoNhom = (Convert.IsDBNull(row["SoNhom"]))?(int)0:(System.Int32?)row["SoNhom"];
					c.MaDiaDiem = (Convert.IsDBNull(row["MaDiaDiem"]))?string.Empty:(System.String)row["MaDiaDiem"];
					c.NgayBatDau = (Convert.IsDBNull(row["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)row["NgayBatDau"];
					c.NgayKetThuc = (Convert.IsDBNull(row["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)row["NgayKetThuc"];
					c.ChatLuongCao = (Convert.IsDBNull(row["ChatLuongCao"]))?0.0m:(System.Decimal?)row["ChatLuongCao"];
					c.NgoaiGio = (Convert.IsDBNull(row["NgoaiGio"]))?0.0m:(System.Decimal?)row["NgoaiGio"];
					c.TrongGio = (Convert.IsDBNull(row["TrongGio"]))?0.0m:(System.Decimal?)row["TrongGio"];
					c.HeSoLopDong = (Convert.IsDBNull(row["HeSoLopDong"]))?0.0m:(System.Decimal?)row["HeSoLopDong"];
					c.HeSoCoSo = (Convert.IsDBNull(row["HeSoCoSo"]))?0.0m:(System.Decimal?)row["HeSoCoSo"];
					c.HeSoHocKy = (Convert.IsDBNull(row["HeSoHocKy"]))?0.0m:(System.Decimal?)row["HeSoHocKy"];
					c.HeSoThanhPhan = (Convert.IsDBNull(row["HeSoThanhPhan"]))?0.0m:(System.Decimal?)row["HeSoThanhPhan"];
					c.HeSoTrongGio = (Convert.IsDBNull(row["HeSoTrongGio"]))?0.0m:(System.Decimal?)row["HeSoTrongGio"];
					c.HeSoNgoaiGio = (Convert.IsDBNull(row["HeSoNgoaiGio"]))?0.0m:(System.Decimal?)row["HeSoNgoaiGio"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.LoaiHocKy = (Convert.IsDBNull(row["LoaiHocKy"]))?(int)0:(System.Int32?)row["LoaiHocKy"];
					c.ThoiKhoaBieu = (Convert.IsDBNull(row["ThoiKhoaBieu"]))?string.Empty:(System.String)row["ThoiKhoaBieu"];
					c.NgayTao = (Convert.IsDBNull(row["NgayTao"]))?DateTime.MinValue:(System.DateTime?)row["NgayTao"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Tuan = (Convert.IsDBNull(row["Tuan"]))?(int)0:(System.Int32?)row["Tuan"];
					c.Nam = (Convert.IsDBNull(row["Nam"]))?(int)0:(System.Int32?)row["Nam"];
					c.NgayDay = (Convert.IsDBNull(row["NgayDay"]))?DateTime.MinValue:(System.DateTime?)row["NgayDay"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.TenLop = (Convert.IsDBNull(row["TenLop"]))?string.Empty:(System.String)row["TenLop"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
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
		/// Fill an <see cref="VList&lt;ViewTinhKhoiLuongTungTuan&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewTinhKhoiLuongTungTuan&gt;"/></returns>
		protected VList<ViewTinhKhoiLuongTungTuan> Fill(IDataReader reader, VList<ViewTinhKhoiLuongTungTuan> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewTinhKhoiLuongTungTuan entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewTinhKhoiLuongTungTuan>("ViewTinhKhoiLuongTungTuan",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewTinhKhoiLuongTungTuan();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaKhoiLuong = (System.Int32)reader["MaKhoiLuong"];
					//entity.MaKhoiLuong = (Convert.IsDBNull(reader["MaKhoiLuong"]))?(int)0:(System.Int32)reader["MaKhoiLuong"];
					entity.MaToaNha = reader.IsDBNull(reader.GetOrdinal("MaToaNha")) ? null : (System.String)reader["MaToaNha"];
					//entity.MaToaNha = (Convert.IsDBNull(reader["MaToaNha"]))?string.Empty:(System.String)reader["MaToaNha"];
					entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.MaNhom = reader.IsDBNull(reader.GetOrdinal("MaNhom")) ? null : (System.String)reader["MaNhom"];
					//entity.MaNhom = (Convert.IsDBNull(reader["MaNhom"]))?string.Empty:(System.String)reader["MaNhom"];
					entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.PhanLoai = reader.IsDBNull(reader.GetOrdinal("PhanLoai")) ? null : (System.String)reader["PhanLoai"];
					//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
					entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.DienGiai = reader.IsDBNull(reader.GetOrdinal("DienGiai")) ? null : (System.String)reader["DienGiai"];
					//entity.DienGiai = (Convert.IsDBNull(reader["DienGiai"]))?string.Empty:(System.String)reader["DienGiai"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Decimal?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
					entity.SoTinChi = reader.IsDBNull(reader.GetOrdinal("SoTinChi")) ? null : (System.Decimal?)reader["SoTinChi"];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal?)reader["SoTinChi"];
					entity.SiSoLop = reader.IsDBNull(reader.GetOrdinal("SiSoLop")) ? null : (System.Int32?)reader["SiSoLop"];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
					entity.SoNhom = reader.IsDBNull(reader.GetOrdinal("SoNhom")) ? null : (System.Int32?)reader["SoNhom"];
					//entity.SoNhom = (Convert.IsDBNull(reader["SoNhom"]))?(int)0:(System.Int32?)reader["SoNhom"];
					entity.MaDiaDiem = reader.IsDBNull(reader.GetOrdinal("MaDiaDiem")) ? null : (System.String)reader["MaDiaDiem"];
					//entity.MaDiaDiem = (Convert.IsDBNull(reader["MaDiaDiem"]))?string.Empty:(System.String)reader["MaDiaDiem"];
					entity.NgayBatDau = reader.IsDBNull(reader.GetOrdinal("NgayBatDau")) ? null : (System.DateTime?)reader["NgayBatDau"];
					//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
					entity.NgayKetThuc = reader.IsDBNull(reader.GetOrdinal("NgayKetThuc")) ? null : (System.DateTime?)reader["NgayKetThuc"];
					//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
					entity.ChatLuongCao = reader.IsDBNull(reader.GetOrdinal("ChatLuongCao")) ? null : (System.Decimal?)reader["ChatLuongCao"];
					//entity.ChatLuongCao = (Convert.IsDBNull(reader["ChatLuongCao"]))?0.0m:(System.Decimal?)reader["ChatLuongCao"];
					entity.NgoaiGio = reader.IsDBNull(reader.GetOrdinal("NgoaiGio")) ? null : (System.Decimal?)reader["NgoaiGio"];
					//entity.NgoaiGio = (Convert.IsDBNull(reader["NgoaiGio"]))?0.0m:(System.Decimal?)reader["NgoaiGio"];
					entity.TrongGio = reader.IsDBNull(reader.GetOrdinal("TrongGio")) ? null : (System.Decimal?)reader["TrongGio"];
					//entity.TrongGio = (Convert.IsDBNull(reader["TrongGio"]))?0.0m:(System.Decimal?)reader["TrongGio"];
					entity.HeSoLopDong = reader.IsDBNull(reader.GetOrdinal("HeSoLopDong")) ? null : (System.Decimal?)reader["HeSoLopDong"];
					//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
					entity.HeSoCoSo = reader.IsDBNull(reader.GetOrdinal("HeSoCoSo")) ? null : (System.Decimal?)reader["HeSoCoSo"];
					//entity.HeSoCoSo = (Convert.IsDBNull(reader["HeSoCoSo"]))?0.0m:(System.Decimal?)reader["HeSoCoSo"];
					entity.HeSoHocKy = reader.IsDBNull(reader.GetOrdinal("HeSoHocKy")) ? null : (System.Decimal?)reader["HeSoHocKy"];
					//entity.HeSoHocKy = (Convert.IsDBNull(reader["HeSoHocKy"]))?0.0m:(System.Decimal?)reader["HeSoHocKy"];
					entity.HeSoThanhPhan = reader.IsDBNull(reader.GetOrdinal("HeSoThanhPhan")) ? null : (System.Decimal?)reader["HeSoThanhPhan"];
					//entity.HeSoThanhPhan = (Convert.IsDBNull(reader["HeSoThanhPhan"]))?0.0m:(System.Decimal?)reader["HeSoThanhPhan"];
					entity.HeSoTrongGio = reader.IsDBNull(reader.GetOrdinal("HeSoTrongGio")) ? null : (System.Decimal?)reader["HeSoTrongGio"];
					//entity.HeSoTrongGio = (Convert.IsDBNull(reader["HeSoTrongGio"]))?0.0m:(System.Decimal?)reader["HeSoTrongGio"];
					entity.HeSoNgoaiGio = reader.IsDBNull(reader.GetOrdinal("HeSoNgoaiGio")) ? null : (System.Decimal?)reader["HeSoNgoaiGio"];
					//entity.HeSoNgoaiGio = (Convert.IsDBNull(reader["HeSoNgoaiGio"]))?0.0m:(System.Decimal?)reader["HeSoNgoaiGio"];
					entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.LoaiHocKy = reader.IsDBNull(reader.GetOrdinal("LoaiHocKy")) ? null : (System.Int32?)reader["LoaiHocKy"];
					//entity.LoaiHocKy = (Convert.IsDBNull(reader["LoaiHocKy"]))?(int)0:(System.Int32?)reader["LoaiHocKy"];
					entity.ThoiKhoaBieu = reader.IsDBNull(reader.GetOrdinal("ThoiKhoaBieu")) ? null : (System.String)reader["ThoiKhoaBieu"];
					//entity.ThoiKhoaBieu = (Convert.IsDBNull(reader["ThoiKhoaBieu"]))?string.Empty:(System.String)reader["ThoiKhoaBieu"];
					entity.NgayTao = reader.IsDBNull(reader.GetOrdinal("NgayTao")) ? null : (System.DateTime?)reader["NgayTao"];
					//entity.NgayTao = (Convert.IsDBNull(reader["NgayTao"]))?DateTime.MinValue:(System.DateTime?)reader["NgayTao"];
					entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Tuan = reader.IsDBNull(reader.GetOrdinal("Tuan")) ? null : (System.Int32?)reader["Tuan"];
					//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
					entity.Nam = reader.IsDBNull(reader.GetOrdinal("Nam")) ? null : (System.Int32?)reader["Nam"];
					//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
					entity.NgayDay = reader.IsDBNull(reader.GetOrdinal("NgayDay")) ? null : (System.DateTime?)reader["NgayDay"];
					//entity.NgayDay = (Convert.IsDBNull(reader["NgayDay"]))?DateTime.MinValue:(System.DateTime?)reader["NgayDay"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.TenLop = (System.String)reader["TenLop"];
					//entity.TenLop = (Convert.IsDBNull(reader["TenLop"]))?string.Empty:(System.String)reader["TenLop"];
					entity.TenMonHoc = (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
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
		/// Refreshes the <see cref="ViewTinhKhoiLuongTungTuan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTinhKhoiLuongTungTuan"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewTinhKhoiLuongTungTuan entity)
		{
			reader.Read();
			entity.MaKhoiLuong = (System.Int32)reader["MaKhoiLuong"];
			//entity.MaKhoiLuong = (Convert.IsDBNull(reader["MaKhoiLuong"]))?(int)0:(System.Int32)reader["MaKhoiLuong"];
			entity.MaToaNha = reader.IsDBNull(reader.GetOrdinal("MaToaNha")) ? null : (System.String)reader["MaToaNha"];
			//entity.MaToaNha = (Convert.IsDBNull(reader["MaToaNha"]))?string.Empty:(System.String)reader["MaToaNha"];
			entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.MaNhom = reader.IsDBNull(reader.GetOrdinal("MaNhom")) ? null : (System.String)reader["MaNhom"];
			//entity.MaNhom = (Convert.IsDBNull(reader["MaNhom"]))?string.Empty:(System.String)reader["MaNhom"];
			entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.PhanLoai = reader.IsDBNull(reader.GetOrdinal("PhanLoai")) ? null : (System.String)reader["PhanLoai"];
			//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
			entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.DienGiai = reader.IsDBNull(reader.GetOrdinal("DienGiai")) ? null : (System.String)reader["DienGiai"];
			//entity.DienGiai = (Convert.IsDBNull(reader["DienGiai"]))?string.Empty:(System.String)reader["DienGiai"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Decimal?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal?)reader["SoTiet"];
			entity.SoTinChi = reader.IsDBNull(reader.GetOrdinal("SoTinChi")) ? null : (System.Decimal?)reader["SoTinChi"];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal?)reader["SoTinChi"];
			entity.SiSoLop = reader.IsDBNull(reader.GetOrdinal("SiSoLop")) ? null : (System.Int32?)reader["SiSoLop"];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
			entity.SoNhom = reader.IsDBNull(reader.GetOrdinal("SoNhom")) ? null : (System.Int32?)reader["SoNhom"];
			//entity.SoNhom = (Convert.IsDBNull(reader["SoNhom"]))?(int)0:(System.Int32?)reader["SoNhom"];
			entity.MaDiaDiem = reader.IsDBNull(reader.GetOrdinal("MaDiaDiem")) ? null : (System.String)reader["MaDiaDiem"];
			//entity.MaDiaDiem = (Convert.IsDBNull(reader["MaDiaDiem"]))?string.Empty:(System.String)reader["MaDiaDiem"];
			entity.NgayBatDau = reader.IsDBNull(reader.GetOrdinal("NgayBatDau")) ? null : (System.DateTime?)reader["NgayBatDau"];
			//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
			entity.NgayKetThuc = reader.IsDBNull(reader.GetOrdinal("NgayKetThuc")) ? null : (System.DateTime?)reader["NgayKetThuc"];
			//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
			entity.ChatLuongCao = reader.IsDBNull(reader.GetOrdinal("ChatLuongCao")) ? null : (System.Decimal?)reader["ChatLuongCao"];
			//entity.ChatLuongCao = (Convert.IsDBNull(reader["ChatLuongCao"]))?0.0m:(System.Decimal?)reader["ChatLuongCao"];
			entity.NgoaiGio = reader.IsDBNull(reader.GetOrdinal("NgoaiGio")) ? null : (System.Decimal?)reader["NgoaiGio"];
			//entity.NgoaiGio = (Convert.IsDBNull(reader["NgoaiGio"]))?0.0m:(System.Decimal?)reader["NgoaiGio"];
			entity.TrongGio = reader.IsDBNull(reader.GetOrdinal("TrongGio")) ? null : (System.Decimal?)reader["TrongGio"];
			//entity.TrongGio = (Convert.IsDBNull(reader["TrongGio"]))?0.0m:(System.Decimal?)reader["TrongGio"];
			entity.HeSoLopDong = reader.IsDBNull(reader.GetOrdinal("HeSoLopDong")) ? null : (System.Decimal?)reader["HeSoLopDong"];
			//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
			entity.HeSoCoSo = reader.IsDBNull(reader.GetOrdinal("HeSoCoSo")) ? null : (System.Decimal?)reader["HeSoCoSo"];
			//entity.HeSoCoSo = (Convert.IsDBNull(reader["HeSoCoSo"]))?0.0m:(System.Decimal?)reader["HeSoCoSo"];
			entity.HeSoHocKy = reader.IsDBNull(reader.GetOrdinal("HeSoHocKy")) ? null : (System.Decimal?)reader["HeSoHocKy"];
			//entity.HeSoHocKy = (Convert.IsDBNull(reader["HeSoHocKy"]))?0.0m:(System.Decimal?)reader["HeSoHocKy"];
			entity.HeSoThanhPhan = reader.IsDBNull(reader.GetOrdinal("HeSoThanhPhan")) ? null : (System.Decimal?)reader["HeSoThanhPhan"];
			//entity.HeSoThanhPhan = (Convert.IsDBNull(reader["HeSoThanhPhan"]))?0.0m:(System.Decimal?)reader["HeSoThanhPhan"];
			entity.HeSoTrongGio = reader.IsDBNull(reader.GetOrdinal("HeSoTrongGio")) ? null : (System.Decimal?)reader["HeSoTrongGio"];
			//entity.HeSoTrongGio = (Convert.IsDBNull(reader["HeSoTrongGio"]))?0.0m:(System.Decimal?)reader["HeSoTrongGio"];
			entity.HeSoNgoaiGio = reader.IsDBNull(reader.GetOrdinal("HeSoNgoaiGio")) ? null : (System.Decimal?)reader["HeSoNgoaiGio"];
			//entity.HeSoNgoaiGio = (Convert.IsDBNull(reader["HeSoNgoaiGio"]))?0.0m:(System.Decimal?)reader["HeSoNgoaiGio"];
			entity.TietQuyDoi = reader.IsDBNull(reader.GetOrdinal("TietQuyDoi")) ? null : (System.Decimal?)reader["TietQuyDoi"];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.LoaiHocKy = reader.IsDBNull(reader.GetOrdinal("LoaiHocKy")) ? null : (System.Int32?)reader["LoaiHocKy"];
			//entity.LoaiHocKy = (Convert.IsDBNull(reader["LoaiHocKy"]))?(int)0:(System.Int32?)reader["LoaiHocKy"];
			entity.ThoiKhoaBieu = reader.IsDBNull(reader.GetOrdinal("ThoiKhoaBieu")) ? null : (System.String)reader["ThoiKhoaBieu"];
			//entity.ThoiKhoaBieu = (Convert.IsDBNull(reader["ThoiKhoaBieu"]))?string.Empty:(System.String)reader["ThoiKhoaBieu"];
			entity.NgayTao = reader.IsDBNull(reader.GetOrdinal("NgayTao")) ? null : (System.DateTime?)reader["NgayTao"];
			//entity.NgayTao = (Convert.IsDBNull(reader["NgayTao"]))?DateTime.MinValue:(System.DateTime?)reader["NgayTao"];
			entity.MaQuanLy = reader.IsDBNull(reader.GetOrdinal("MaQuanLy")) ? null : (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Tuan = reader.IsDBNull(reader.GetOrdinal("Tuan")) ? null : (System.Int32?)reader["Tuan"];
			//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
			entity.Nam = reader.IsDBNull(reader.GetOrdinal("Nam")) ? null : (System.Int32?)reader["Nam"];
			//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
			entity.NgayDay = reader.IsDBNull(reader.GetOrdinal("NgayDay")) ? null : (System.DateTime?)reader["NgayDay"];
			//entity.NgayDay = (Convert.IsDBNull(reader["NgayDay"]))?DateTime.MinValue:(System.DateTime?)reader["NgayDay"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.TenLop = (System.String)reader["TenLop"];
			//entity.TenLop = (Convert.IsDBNull(reader["TenLop"]))?string.Empty:(System.String)reader["TenLop"];
			entity.TenMonHoc = (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewTinhKhoiLuongTungTuan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewTinhKhoiLuongTungTuan"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewTinhKhoiLuongTungTuan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoiLuong = (Convert.IsDBNull(dataRow["MaKhoiLuong"]))?(int)0:(System.Int32)dataRow["MaKhoiLuong"];
			entity.MaToaNha = (Convert.IsDBNull(dataRow["MaToaNha"]))?string.Empty:(System.String)dataRow["MaToaNha"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.MaNhom = (Convert.IsDBNull(dataRow["MaNhom"]))?string.Empty:(System.String)dataRow["MaNhom"];
			entity.LoaiHocPhan = (Convert.IsDBNull(dataRow["LoaiHocPhan"]))?string.Empty:(System.String)dataRow["LoaiHocPhan"];
			entity.PhanLoai = (Convert.IsDBNull(dataRow["PhanLoai"]))?string.Empty:(System.String)dataRow["PhanLoai"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.DienGiai = (Convert.IsDBNull(dataRow["DienGiai"]))?string.Empty:(System.String)dataRow["DienGiai"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?0.0m:(System.Decimal?)dataRow["SoTiet"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?0.0m:(System.Decimal?)dataRow["SoTinChi"];
			entity.SiSoLop = (Convert.IsDBNull(dataRow["SiSoLop"]))?(int)0:(System.Int32?)dataRow["SiSoLop"];
			entity.SoNhom = (Convert.IsDBNull(dataRow["SoNhom"]))?(int)0:(System.Int32?)dataRow["SoNhom"];
			entity.MaDiaDiem = (Convert.IsDBNull(dataRow["MaDiaDiem"]))?string.Empty:(System.String)dataRow["MaDiaDiem"];
			entity.NgayBatDau = (Convert.IsDBNull(dataRow["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayBatDau"];
			entity.NgayKetThuc = (Convert.IsDBNull(dataRow["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKetThuc"];
			entity.ChatLuongCao = (Convert.IsDBNull(dataRow["ChatLuongCao"]))?0.0m:(System.Decimal?)dataRow["ChatLuongCao"];
			entity.NgoaiGio = (Convert.IsDBNull(dataRow["NgoaiGio"]))?0.0m:(System.Decimal?)dataRow["NgoaiGio"];
			entity.TrongGio = (Convert.IsDBNull(dataRow["TrongGio"]))?0.0m:(System.Decimal?)dataRow["TrongGio"];
			entity.HeSoLopDong = (Convert.IsDBNull(dataRow["HeSoLopDong"]))?0.0m:(System.Decimal?)dataRow["HeSoLopDong"];
			entity.HeSoCoSo = (Convert.IsDBNull(dataRow["HeSoCoSo"]))?0.0m:(System.Decimal?)dataRow["HeSoCoSo"];
			entity.HeSoHocKy = (Convert.IsDBNull(dataRow["HeSoHocKy"]))?0.0m:(System.Decimal?)dataRow["HeSoHocKy"];
			entity.HeSoThanhPhan = (Convert.IsDBNull(dataRow["HeSoThanhPhan"]))?0.0m:(System.Decimal?)dataRow["HeSoThanhPhan"];
			entity.HeSoTrongGio = (Convert.IsDBNull(dataRow["HeSoTrongGio"]))?0.0m:(System.Decimal?)dataRow["HeSoTrongGio"];
			entity.HeSoNgoaiGio = (Convert.IsDBNull(dataRow["HeSoNgoaiGio"]))?0.0m:(System.Decimal?)dataRow["HeSoNgoaiGio"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.LoaiHocKy = (Convert.IsDBNull(dataRow["LoaiHocKy"]))?(int)0:(System.Int32?)dataRow["LoaiHocKy"];
			entity.ThoiKhoaBieu = (Convert.IsDBNull(dataRow["ThoiKhoaBieu"]))?string.Empty:(System.String)dataRow["ThoiKhoaBieu"];
			entity.NgayTao = (Convert.IsDBNull(dataRow["NgayTao"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayTao"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Tuan = (Convert.IsDBNull(dataRow["Tuan"]))?(int)0:(System.Int32?)dataRow["Tuan"];
			entity.Nam = (Convert.IsDBNull(dataRow["Nam"]))?(int)0:(System.Int32?)dataRow["Nam"];
			entity.NgayDay = (Convert.IsDBNull(dataRow["NgayDay"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayDay"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.TenLop = (Convert.IsDBNull(dataRow["TenLop"]))?string.Empty:(System.String)dataRow["TenLop"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewTinhKhoiLuongTungTuanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTinhKhoiLuongTungTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTinhKhoiLuongTungTuanFilterBuilder : SqlFilterBuilder<ViewTinhKhoiLuongTungTuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongTungTuanFilterBuilder class.
		/// </summary>
		public ViewTinhKhoiLuongTungTuanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongTungTuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTinhKhoiLuongTungTuanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongTungTuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTinhKhoiLuongTungTuanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTinhKhoiLuongTungTuanFilterBuilder

	#region ViewTinhKhoiLuongTungTuanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTinhKhoiLuongTungTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTinhKhoiLuongTungTuanParameterBuilder : ParameterizedSqlFilterBuilder<ViewTinhKhoiLuongTungTuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongTungTuanParameterBuilder class.
		/// </summary>
		public ViewTinhKhoiLuongTungTuanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongTungTuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewTinhKhoiLuongTungTuanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongTungTuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewTinhKhoiLuongTungTuanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewTinhKhoiLuongTungTuanParameterBuilder
	
	#region ViewTinhKhoiLuongTungTuanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTinhKhoiLuongTungTuan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewTinhKhoiLuongTungTuanSortBuilder : SqlSortBuilder<ViewTinhKhoiLuongTungTuanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongTungTuanSqlSortBuilder class.
		/// </summary>
		public ViewTinhKhoiLuongTungTuanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewTinhKhoiLuongTungTuanSortBuilder

} // end namespace
