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
	/// This class is the base class for any <see cref="ViewGiangVienLichGiangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewGiangVienLichGiangProviderBaseCore : EntityViewProviderBase<ViewGiangVienLichGiang>
	{
		#region Custom Methods
		
		
		#region cust_View_GiangVien_LichGiang_GetByNamHocHocKyMaBacMaHe
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LichGiang_GetByNamHocHocKyMaBacMaHe' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKyMaBacMaHe(System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String maHeDaoTao)
		{
			 GetByNamHocHocKyMaBacMaHe(null, 0, int.MaxValue , namHoc, hocKy, maBacDaoTao, maHeDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LichGiang_GetByNamHocHocKyMaBacMaHe' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKyMaBacMaHe(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String maHeDaoTao)
		{
			 GetByNamHocHocKyMaBacMaHe(null, start, pageLength , namHoc, hocKy, maBacDaoTao, maHeDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LichGiang_GetByNamHocHocKyMaBacMaHe' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKyMaBacMaHe(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String maHeDaoTao)
		{
			 GetByNamHocHocKyMaBacMaHe(transactionManager, 0, int.MaxValue , namHoc, hocKy, maBacDaoTao, maHeDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LichGiang_GetByNamHocHocKyMaBacMaHe' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByNamHocHocKyMaBacMaHe(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String maHeDaoTao);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewGiangVienLichGiang&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewGiangVienLichGiang&gt;"/></returns>
		protected static VList&lt;ViewGiangVienLichGiang&gt; Fill(DataSet dataSet, VList<ViewGiangVienLichGiang> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewGiangVienLichGiang>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewGiangVienLichGiang&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewGiangVienLichGiang>"/></returns>
		protected static VList&lt;ViewGiangVienLichGiang&gt; Fill(DataTable dataTable, VList<ViewGiangVienLichGiang> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewGiangVienLichGiang c = new ViewGiangVienLichGiang();
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.ChuyenNganh = (Convert.IsDBNull(row["ChuyenNganh"]))?string.Empty:(System.String)row["ChuyenNganh"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?(int)0:(System.Int32?)row["MaHocHam"];
					c.Cmnd = (Convert.IsDBNull(row["Cmnd"]))?string.Empty:(System.String)row["Cmnd"];
					c.MaSoThue = (Convert.IsDBNull(row["MaSoThue"]))?string.Empty:(System.String)row["MaSoThue"];
					c.ThuongTru = (Convert.IsDBNull(row["ThuongTru"]))?string.Empty:(System.String)row["ThuongTru"];
					c.TenHocHam = (Convert.IsDBNull(row["TenHocHam"]))?string.Empty:(System.String)row["TenHocHam"];
					c.MaHocPhan = (Convert.IsDBNull(row["MaHocPhan"]))?string.Empty:(System.String)row["MaHocPhan"];
					c.TenHocPhan = (Convert.IsDBNull(row["TenHocPhan"]))?string.Empty:(System.String)row["TenHocPhan"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.TenLopHocPhan = (Convert.IsDBNull(row["TenLopHocPhan"]))?string.Empty:(System.String)row["TenLopHocPhan"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaLoaiHinh = (Convert.IsDBNull(row["MaLoaiHinh"]))?string.Empty:(System.String)row["MaLoaiHinh"];
					c.MaBacLoaiHinh = (Convert.IsDBNull(row["MaBacLoaiHinh"]))?string.Empty:(System.String)row["MaBacLoaiHinh"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32?)row["MaLoaiGiangVien"];
					c.MaPhong = (Convert.IsDBNull(row["MaPhong"]))?string.Empty:(System.String)row["MaPhong"];
					c.MaBuoiHoc = (Convert.IsDBNull(row["MaBuoiHoc"]))?(int)0:(System.Int32?)row["MaBuoiHoc"];
					c.MaThongTinBuoi = (Convert.IsDBNull(row["MaThongTinBuoi"]))?string.Empty:(System.String)row["MaThongTinBuoi"];
					c.ThongTinBuoi = (Convert.IsDBNull(row["ThongTinBuoi"]))?string.Empty:(System.String)row["ThongTinBuoi"];
					c.TenPhong = (Convert.IsDBNull(row["TenPhong"]))?string.Empty:(System.String)row["TenPhong"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?0.0m:(System.Decimal)row["SoTiet"];
					c.SiSoLop = (Convert.IsDBNull(row["SiSoLop"]))?(int)0:(System.Int32?)row["SiSoLop"];
					c.HeSoLd = (Convert.IsDBNull(row["HeSoLD"]))?0.0m:(System.Decimal?)row["HeSoLD"];
					c.HeSoTinChi = (Convert.IsDBNull(row["HeSoTinChi"]))?0.0m:(System.Decimal)row["HeSoTinChi"];
					c.TietQuyDoi = (Convert.IsDBNull(row["TietQuyDoi"]))?0.0m:(System.Decimal?)row["TietQuyDoi"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal)row["DonGia"];
					c.TienThem = (Convert.IsDBNull(row["TienThem"]))?0.0m:(System.Decimal)row["TienThem"];
					c.TongCong = (Convert.IsDBNull(row["TongCong"]))?0.0m:(System.Decimal?)row["TongCong"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.NgayKyHopDong = (Convert.IsDBNull(row["NgayKyHopDong"]))?DateTime.MinValue:(System.DateTime?)row["NgayKyHopDong"];
					c.NgayKetThucHopDong = (Convert.IsDBNull(row["NgayKetThucHopDong"]))?DateTime.MinValue:(System.DateTime?)row["NgayKetThucHopDong"];
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
		/// Fill an <see cref="VList&lt;ViewGiangVienLichGiang&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewGiangVienLichGiang&gt;"/></returns>
		protected VList<ViewGiangVienLichGiang> Fill(IDataReader reader, VList<ViewGiangVienLichGiang> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewGiangVienLichGiang entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewGiangVienLichGiang>("ViewGiangVienLichGiang",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewGiangVienLichGiang();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaGiangVien = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.MaGiangVien)))?null:(System.Int32?)reader[((int)ViewGiangVienLichGiangColumn.MaGiangVien)];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
					entity.MaQuanLy = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.MaQuanLy)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.MaQuanLy)];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Ho = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.Ho)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.Ho)];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.Ten)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.Ten)];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.HoTen = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.HoTen)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.HoTen)];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.ChuyenNganh = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.ChuyenNganh)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.ChuyenNganh)];
					//entity.ChuyenNganh = (Convert.IsDBNull(reader["ChuyenNganh"]))?string.Empty:(System.String)reader["ChuyenNganh"];
					entity.MaHocHam = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.MaHocHam)))?null:(System.Int32?)reader[((int)ViewGiangVienLichGiangColumn.MaHocHam)];
					//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
					entity.Cmnd = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.Cmnd)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.Cmnd)];
					//entity.Cmnd = (Convert.IsDBNull(reader["Cmnd"]))?string.Empty:(System.String)reader["Cmnd"];
					entity.MaSoThue = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.MaSoThue)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.MaSoThue)];
					//entity.MaSoThue = (Convert.IsDBNull(reader["MaSoThue"]))?string.Empty:(System.String)reader["MaSoThue"];
					entity.ThuongTru = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.ThuongTru)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.ThuongTru)];
					//entity.ThuongTru = (Convert.IsDBNull(reader["ThuongTru"]))?string.Empty:(System.String)reader["ThuongTru"];
					entity.TenHocHam = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.TenHocHam)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.TenHocHam)];
					//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
					entity.MaHocPhan = (System.String)reader[((int)ViewGiangVienLichGiangColumn.MaHocPhan)];
					//entity.MaHocPhan = (Convert.IsDBNull(reader["MaHocPhan"]))?string.Empty:(System.String)reader["MaHocPhan"];
					entity.TenHocPhan = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.TenHocPhan)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.TenHocPhan)];
					//entity.TenHocPhan = (Convert.IsDBNull(reader["TenHocPhan"]))?string.Empty:(System.String)reader["TenHocPhan"];
					entity.MaLopHocPhan = (System.String)reader[((int)ViewGiangVienLichGiangColumn.MaLopHocPhan)];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.TenLopHocPhan = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.TenLopHocPhan)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.TenLopHocPhan)];
					//entity.TenLopHocPhan = (Convert.IsDBNull(reader["TenLopHocPhan"]))?string.Empty:(System.String)reader["TenLopHocPhan"];
					entity.MaBacDaoTao = (System.String)reader[((int)ViewGiangVienLichGiangColumn.MaBacDaoTao)];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaLoaiHinh = (System.String)reader[((int)ViewGiangVienLichGiangColumn.MaLoaiHinh)];
					//entity.MaLoaiHinh = (Convert.IsDBNull(reader["MaLoaiHinh"]))?string.Empty:(System.String)reader["MaLoaiHinh"];
					entity.MaBacLoaiHinh = (System.String)reader[((int)ViewGiangVienLichGiangColumn.MaBacLoaiHinh)];
					//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
					entity.MaLoaiGiangVien = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.MaLoaiGiangVien)))?null:(System.Int32?)reader[((int)ViewGiangVienLichGiangColumn.MaLoaiGiangVien)];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
					entity.MaPhong = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.MaPhong)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.MaPhong)];
					//entity.MaPhong = (Convert.IsDBNull(reader["MaPhong"]))?string.Empty:(System.String)reader["MaPhong"];
					entity.MaBuoiHoc = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.MaBuoiHoc)))?null:(System.Int32?)reader[((int)ViewGiangVienLichGiangColumn.MaBuoiHoc)];
					//entity.MaBuoiHoc = (Convert.IsDBNull(reader["MaBuoiHoc"]))?(int)0:(System.Int32?)reader["MaBuoiHoc"];
					entity.MaThongTinBuoi = (System.String)reader[((int)ViewGiangVienLichGiangColumn.MaThongTinBuoi)];
					//entity.MaThongTinBuoi = (Convert.IsDBNull(reader["MaThongTinBuoi"]))?string.Empty:(System.String)reader["MaThongTinBuoi"];
					entity.ThongTinBuoi = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.ThongTinBuoi)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.ThongTinBuoi)];
					//entity.ThongTinBuoi = (Convert.IsDBNull(reader["ThongTinBuoi"]))?string.Empty:(System.String)reader["ThongTinBuoi"];
					entity.TenPhong = (System.String)reader[((int)ViewGiangVienLichGiangColumn.TenPhong)];
					//entity.TenPhong = (Convert.IsDBNull(reader["TenPhong"]))?string.Empty:(System.String)reader["TenPhong"];
					entity.MaMonHoc = (System.String)reader[((int)ViewGiangVienLichGiangColumn.MaMonHoc)];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader[((int)ViewGiangVienLichGiangColumn.TenMonHoc)];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.SoTiet = (System.Decimal)reader[((int)ViewGiangVienLichGiangColumn.SoTiet)];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal)reader["SoTiet"];
					entity.SiSoLop = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewGiangVienLichGiangColumn.SiSoLop)];
					//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
					entity.HeSoLd = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.HeSoLd)))?null:(System.Decimal?)reader[((int)ViewGiangVienLichGiangColumn.HeSoLd)];
					//entity.HeSoLd = (Convert.IsDBNull(reader["HeSoLD"]))?0.0m:(System.Decimal?)reader["HeSoLD"];
					entity.HeSoTinChi = (System.Decimal)reader[((int)ViewGiangVienLichGiangColumn.HeSoTinChi)];
					//entity.HeSoTinChi = (Convert.IsDBNull(reader["HeSoTinChi"]))?0.0m:(System.Decimal)reader["HeSoTinChi"];
					entity.TietQuyDoi = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.TietQuyDoi)))?null:(System.Decimal?)reader[((int)ViewGiangVienLichGiangColumn.TietQuyDoi)];
					//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
					entity.DonGia = (System.Decimal)reader[((int)ViewGiangVienLichGiangColumn.DonGia)];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal)reader["DonGia"];
					entity.TienThem = (System.Decimal)reader[((int)ViewGiangVienLichGiangColumn.TienThem)];
					//entity.TienThem = (Convert.IsDBNull(reader["TienThem"]))?0.0m:(System.Decimal)reader["TienThem"];
					entity.TongCong = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.TongCong)))?null:(System.Decimal?)reader[((int)ViewGiangVienLichGiangColumn.TongCong)];
					//entity.TongCong = (Convert.IsDBNull(reader["TongCong"]))?0.0m:(System.Decimal?)reader["TongCong"];
					entity.NamHoc = (System.String)reader[((int)ViewGiangVienLichGiangColumn.NamHoc)];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader[((int)ViewGiangVienLichGiangColumn.HocKy)];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.NgayKyHopDong = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.NgayKyHopDong)))?null:(System.DateTime?)reader[((int)ViewGiangVienLichGiangColumn.NgayKyHopDong)];
					//entity.NgayKyHopDong = (Convert.IsDBNull(reader["NgayKyHopDong"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKyHopDong"];
					entity.NgayKetThucHopDong = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.NgayKetThucHopDong)))?null:(System.DateTime?)reader[((int)ViewGiangVienLichGiangColumn.NgayKetThucHopDong)];
					//entity.NgayKetThucHopDong = (Convert.IsDBNull(reader["NgayKetThucHopDong"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThucHopDong"];
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
		/// Refreshes the <see cref="ViewGiangVienLichGiang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienLichGiang"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewGiangVienLichGiang entity)
		{
			reader.Read();
			entity.MaGiangVien = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.MaGiangVien)))?null:(System.Int32?)reader[((int)ViewGiangVienLichGiangColumn.MaGiangVien)];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32?)reader["MaGiangVien"];
			entity.MaQuanLy = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.MaQuanLy)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.MaQuanLy)];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Ho = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.Ho)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.Ho)];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.Ten)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.Ten)];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.HoTen = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.HoTen)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.HoTen)];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.ChuyenNganh = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.ChuyenNganh)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.ChuyenNganh)];
			//entity.ChuyenNganh = (Convert.IsDBNull(reader["ChuyenNganh"]))?string.Empty:(System.String)reader["ChuyenNganh"];
			entity.MaHocHam = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.MaHocHam)))?null:(System.Int32?)reader[((int)ViewGiangVienLichGiangColumn.MaHocHam)];
			//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
			entity.Cmnd = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.Cmnd)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.Cmnd)];
			//entity.Cmnd = (Convert.IsDBNull(reader["Cmnd"]))?string.Empty:(System.String)reader["Cmnd"];
			entity.MaSoThue = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.MaSoThue)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.MaSoThue)];
			//entity.MaSoThue = (Convert.IsDBNull(reader["MaSoThue"]))?string.Empty:(System.String)reader["MaSoThue"];
			entity.ThuongTru = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.ThuongTru)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.ThuongTru)];
			//entity.ThuongTru = (Convert.IsDBNull(reader["ThuongTru"]))?string.Empty:(System.String)reader["ThuongTru"];
			entity.TenHocHam = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.TenHocHam)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.TenHocHam)];
			//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
			entity.MaHocPhan = (System.String)reader[((int)ViewGiangVienLichGiangColumn.MaHocPhan)];
			//entity.MaHocPhan = (Convert.IsDBNull(reader["MaHocPhan"]))?string.Empty:(System.String)reader["MaHocPhan"];
			entity.TenHocPhan = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.TenHocPhan)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.TenHocPhan)];
			//entity.TenHocPhan = (Convert.IsDBNull(reader["TenHocPhan"]))?string.Empty:(System.String)reader["TenHocPhan"];
			entity.MaLopHocPhan = (System.String)reader[((int)ViewGiangVienLichGiangColumn.MaLopHocPhan)];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.TenLopHocPhan = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.TenLopHocPhan)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.TenLopHocPhan)];
			//entity.TenLopHocPhan = (Convert.IsDBNull(reader["TenLopHocPhan"]))?string.Empty:(System.String)reader["TenLopHocPhan"];
			entity.MaBacDaoTao = (System.String)reader[((int)ViewGiangVienLichGiangColumn.MaBacDaoTao)];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaLoaiHinh = (System.String)reader[((int)ViewGiangVienLichGiangColumn.MaLoaiHinh)];
			//entity.MaLoaiHinh = (Convert.IsDBNull(reader["MaLoaiHinh"]))?string.Empty:(System.String)reader["MaLoaiHinh"];
			entity.MaBacLoaiHinh = (System.String)reader[((int)ViewGiangVienLichGiangColumn.MaBacLoaiHinh)];
			//entity.MaBacLoaiHinh = (Convert.IsDBNull(reader["MaBacLoaiHinh"]))?string.Empty:(System.String)reader["MaBacLoaiHinh"];
			entity.MaLoaiGiangVien = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.MaLoaiGiangVien)))?null:(System.Int32?)reader[((int)ViewGiangVienLichGiangColumn.MaLoaiGiangVien)];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
			entity.MaPhong = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.MaPhong)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.MaPhong)];
			//entity.MaPhong = (Convert.IsDBNull(reader["MaPhong"]))?string.Empty:(System.String)reader["MaPhong"];
			entity.MaBuoiHoc = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.MaBuoiHoc)))?null:(System.Int32?)reader[((int)ViewGiangVienLichGiangColumn.MaBuoiHoc)];
			//entity.MaBuoiHoc = (Convert.IsDBNull(reader["MaBuoiHoc"]))?(int)0:(System.Int32?)reader["MaBuoiHoc"];
			entity.MaThongTinBuoi = (System.String)reader[((int)ViewGiangVienLichGiangColumn.MaThongTinBuoi)];
			//entity.MaThongTinBuoi = (Convert.IsDBNull(reader["MaThongTinBuoi"]))?string.Empty:(System.String)reader["MaThongTinBuoi"];
			entity.ThongTinBuoi = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.ThongTinBuoi)))?null:(System.String)reader[((int)ViewGiangVienLichGiangColumn.ThongTinBuoi)];
			//entity.ThongTinBuoi = (Convert.IsDBNull(reader["ThongTinBuoi"]))?string.Empty:(System.String)reader["ThongTinBuoi"];
			entity.TenPhong = (System.String)reader[((int)ViewGiangVienLichGiangColumn.TenPhong)];
			//entity.TenPhong = (Convert.IsDBNull(reader["TenPhong"]))?string.Empty:(System.String)reader["TenPhong"];
			entity.MaMonHoc = (System.String)reader[((int)ViewGiangVienLichGiangColumn.MaMonHoc)];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader[((int)ViewGiangVienLichGiangColumn.TenMonHoc)];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.SoTiet = (System.Decimal)reader[((int)ViewGiangVienLichGiangColumn.SoTiet)];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?0.0m:(System.Decimal)reader["SoTiet"];
			entity.SiSoLop = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.SiSoLop)))?null:(System.Int32?)reader[((int)ViewGiangVienLichGiangColumn.SiSoLop)];
			//entity.SiSoLop = (Convert.IsDBNull(reader["SiSoLop"]))?(int)0:(System.Int32?)reader["SiSoLop"];
			entity.HeSoLd = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.HeSoLd)))?null:(System.Decimal?)reader[((int)ViewGiangVienLichGiangColumn.HeSoLd)];
			//entity.HeSoLd = (Convert.IsDBNull(reader["HeSoLD"]))?0.0m:(System.Decimal?)reader["HeSoLD"];
			entity.HeSoTinChi = (System.Decimal)reader[((int)ViewGiangVienLichGiangColumn.HeSoTinChi)];
			//entity.HeSoTinChi = (Convert.IsDBNull(reader["HeSoTinChi"]))?0.0m:(System.Decimal)reader["HeSoTinChi"];
			entity.TietQuyDoi = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.TietQuyDoi)))?null:(System.Decimal?)reader[((int)ViewGiangVienLichGiangColumn.TietQuyDoi)];
			//entity.TietQuyDoi = (Convert.IsDBNull(reader["TietQuyDoi"]))?0.0m:(System.Decimal?)reader["TietQuyDoi"];
			entity.DonGia = (System.Decimal)reader[((int)ViewGiangVienLichGiangColumn.DonGia)];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal)reader["DonGia"];
			entity.TienThem = (System.Decimal)reader[((int)ViewGiangVienLichGiangColumn.TienThem)];
			//entity.TienThem = (Convert.IsDBNull(reader["TienThem"]))?0.0m:(System.Decimal)reader["TienThem"];
			entity.TongCong = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.TongCong)))?null:(System.Decimal?)reader[((int)ViewGiangVienLichGiangColumn.TongCong)];
			//entity.TongCong = (Convert.IsDBNull(reader["TongCong"]))?0.0m:(System.Decimal?)reader["TongCong"];
			entity.NamHoc = (System.String)reader[((int)ViewGiangVienLichGiangColumn.NamHoc)];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader[((int)ViewGiangVienLichGiangColumn.HocKy)];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.NgayKyHopDong = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.NgayKyHopDong)))?null:(System.DateTime?)reader[((int)ViewGiangVienLichGiangColumn.NgayKyHopDong)];
			//entity.NgayKyHopDong = (Convert.IsDBNull(reader["NgayKyHopDong"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKyHopDong"];
			entity.NgayKetThucHopDong = (reader.IsDBNull(((int)ViewGiangVienLichGiangColumn.NgayKetThucHopDong)))?null:(System.DateTime?)reader[((int)ViewGiangVienLichGiangColumn.NgayKetThucHopDong)];
			//entity.NgayKetThucHopDong = (Convert.IsDBNull(reader["NgayKetThucHopDong"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThucHopDong"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewGiangVienLichGiang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVienLichGiang"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewGiangVienLichGiang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.ChuyenNganh = (Convert.IsDBNull(dataRow["ChuyenNganh"]))?string.Empty:(System.String)dataRow["ChuyenNganh"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?(int)0:(System.Int32?)dataRow["MaHocHam"];
			entity.Cmnd = (Convert.IsDBNull(dataRow["Cmnd"]))?string.Empty:(System.String)dataRow["Cmnd"];
			entity.MaSoThue = (Convert.IsDBNull(dataRow["MaSoThue"]))?string.Empty:(System.String)dataRow["MaSoThue"];
			entity.ThuongTru = (Convert.IsDBNull(dataRow["ThuongTru"]))?string.Empty:(System.String)dataRow["ThuongTru"];
			entity.TenHocHam = (Convert.IsDBNull(dataRow["TenHocHam"]))?string.Empty:(System.String)dataRow["TenHocHam"];
			entity.MaHocPhan = (Convert.IsDBNull(dataRow["MaHocPhan"]))?string.Empty:(System.String)dataRow["MaHocPhan"];
			entity.TenHocPhan = (Convert.IsDBNull(dataRow["TenHocPhan"]))?string.Empty:(System.String)dataRow["TenHocPhan"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.TenLopHocPhan = (Convert.IsDBNull(dataRow["TenLopHocPhan"]))?string.Empty:(System.String)dataRow["TenLopHocPhan"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaLoaiHinh = (Convert.IsDBNull(dataRow["MaLoaiHinh"]))?string.Empty:(System.String)dataRow["MaLoaiHinh"];
			entity.MaBacLoaiHinh = (Convert.IsDBNull(dataRow["MaBacLoaiHinh"]))?string.Empty:(System.String)dataRow["MaBacLoaiHinh"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaPhong = (Convert.IsDBNull(dataRow["MaPhong"]))?string.Empty:(System.String)dataRow["MaPhong"];
			entity.MaBuoiHoc = (Convert.IsDBNull(dataRow["MaBuoiHoc"]))?(int)0:(System.Int32?)dataRow["MaBuoiHoc"];
			entity.MaThongTinBuoi = (Convert.IsDBNull(dataRow["MaThongTinBuoi"]))?string.Empty:(System.String)dataRow["MaThongTinBuoi"];
			entity.ThongTinBuoi = (Convert.IsDBNull(dataRow["ThongTinBuoi"]))?string.Empty:(System.String)dataRow["ThongTinBuoi"];
			entity.TenPhong = (Convert.IsDBNull(dataRow["TenPhong"]))?string.Empty:(System.String)dataRow["TenPhong"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?0.0m:(System.Decimal)dataRow["SoTiet"];
			entity.SiSoLop = (Convert.IsDBNull(dataRow["SiSoLop"]))?(int)0:(System.Int32?)dataRow["SiSoLop"];
			entity.HeSoLd = (Convert.IsDBNull(dataRow["HeSoLD"]))?0.0m:(System.Decimal?)dataRow["HeSoLD"];
			entity.HeSoTinChi = (Convert.IsDBNull(dataRow["HeSoTinChi"]))?0.0m:(System.Decimal)dataRow["HeSoTinChi"];
			entity.TietQuyDoi = (Convert.IsDBNull(dataRow["TietQuyDoi"]))?0.0m:(System.Decimal?)dataRow["TietQuyDoi"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal)dataRow["DonGia"];
			entity.TienThem = (Convert.IsDBNull(dataRow["TienThem"]))?0.0m:(System.Decimal)dataRow["TienThem"];
			entity.TongCong = (Convert.IsDBNull(dataRow["TongCong"]))?0.0m:(System.Decimal?)dataRow["TongCong"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.NgayKyHopDong = (Convert.IsDBNull(dataRow["NgayKyHopDong"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKyHopDong"];
			entity.NgayKetThucHopDong = (Convert.IsDBNull(dataRow["NgayKetThucHopDong"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKetThucHopDong"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewGiangVienLichGiangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienLichGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienLichGiangFilterBuilder : SqlFilterBuilder<ViewGiangVienLichGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLichGiangFilterBuilder class.
		/// </summary>
		public ViewGiangVienLichGiangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLichGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienLichGiangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLichGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienLichGiangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienLichGiangFilterBuilder

	#region ViewGiangVienLichGiangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienLichGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienLichGiangParameterBuilder : ParameterizedSqlFilterBuilder<ViewGiangVienLichGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLichGiangParameterBuilder class.
		/// </summary>
		public ViewGiangVienLichGiangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLichGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienLichGiangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLichGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienLichGiangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienLichGiangParameterBuilder
	
	#region ViewGiangVienLichGiangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienLichGiang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewGiangVienLichGiangSortBuilder : SqlSortBuilder<ViewGiangVienLichGiangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLichGiangSqlSortBuilder class.
		/// </summary>
		public ViewGiangVienLichGiangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewGiangVienLichGiangSortBuilder

} // end namespace
