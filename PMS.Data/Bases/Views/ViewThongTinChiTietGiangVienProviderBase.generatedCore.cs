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
	/// This class is the base class for any <see cref="ViewThongTinChiTietGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThongTinChiTietGiangVienProviderBaseCore : EntityViewProviderBase<ViewThongTinChiTietGiangVien>
	{
		#region Custom Methods
		
		
		#region cust_View_ThongTin_ChiTiet_GiangVien_GetByMaDonViMaHocHamMaHocViMaTinhTrang
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTin_ChiTiet_GiangVien_GetByMaDonViMaHocHamMaHocViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinChiTietGiangVien&gt;"/> instance.</returns>
		public VList<ViewThongTinChiTietGiangVien> GetByMaDonViMaHocHamMaHocViMaTinhTrang(System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.String maTinhTrang)
		{
			return GetByMaDonViMaHocHamMaHocViMaTinhTrang(null, 0, int.MaxValue , maDonVi, maHocHam, maHocVi, maTinhTrang);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTin_ChiTiet_GiangVien_GetByMaDonViMaHocHamMaHocViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinChiTietGiangVien&gt;"/> instance.</returns>
		public VList<ViewThongTinChiTietGiangVien> GetByMaDonViMaHocHamMaHocViMaTinhTrang(int start, int pageLength, System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.String maTinhTrang)
		{
			return GetByMaDonViMaHocHamMaHocViMaTinhTrang(null, start, pageLength , maDonVi, maHocHam, maHocVi, maTinhTrang);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThongTin_ChiTiet_GiangVien_GetByMaDonViMaHocHamMaHocViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThongTinChiTietGiangVien&gt;"/> instance.</returns>
		public VList<ViewThongTinChiTietGiangVien> GetByMaDonViMaHocHamMaHocViMaTinhTrang(TransactionManager transactionManager, System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.String maTinhTrang)
		{
			return GetByMaDonViMaHocHamMaHocViMaTinhTrang(transactionManager, 0, int.MaxValue , maDonVi, maHocHam, maHocVi, maTinhTrang);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThongTin_ChiTiet_GiangVien_GetByMaDonViMaHocHamMaHocViMaTinhTrang' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThongTinChiTietGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewThongTinChiTietGiangVien> GetByMaDonViMaHocHamMaHocViMaTinhTrang(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.String maTinhTrang);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThongTinChiTietGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThongTinChiTietGiangVien&gt;"/></returns>
		protected static VList&lt;ViewThongTinChiTietGiangVien&gt; Fill(DataSet dataSet, VList<ViewThongTinChiTietGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThongTinChiTietGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThongTinChiTietGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThongTinChiTietGiangVien>"/></returns>
		protected static VList&lt;ViewThongTinChiTietGiangVien&gt; Fill(DataTable dataTable, VList<ViewThongTinChiTietGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThongTinChiTietGiangVien c = new ViewThongTinChiTietGiangVien();
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.TenDem = (Convert.IsDBNull(row["TenDem"]))?string.Empty:(System.String)row["TenDem"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTenDem = (Convert.IsDBNull(row["HoTenDem"]))?string.Empty:(System.String)row["HoTenDem"];
					c.NgaySinh = (Convert.IsDBNull(row["NgaySinh"]))?string.Empty:(System.String)row["NgaySinh"];
					c.GioiTinh = (Convert.IsDBNull(row["GioiTinh"]))?false:(System.Boolean?)row["GioiTinh"];
					c.TenGioiTinh = (Convert.IsDBNull(row["TenGioiTinh"]))?string.Empty:(System.String)row["TenGioiTinh"];
					c.NoiSinh = (Convert.IsDBNull(row["NoiSinh"]))?string.Empty:(System.String)row["NoiSinh"];
					c.Cmnd = (Convert.IsDBNull(row["Cmnd"]))?string.Empty:(System.String)row["Cmnd"];
					c.NgayCap = (Convert.IsDBNull(row["NgayCap"]))?string.Empty:(System.String)row["NgayCap"];
					c.NoiCap = (Convert.IsDBNull(row["NoiCap"]))?string.Empty:(System.String)row["NoiCap"];
					c.DoanDang = (Convert.IsDBNull(row["DoanDang"]))?false:(System.Boolean?)row["DoanDang"];
					c.NgayVaoDoanDang = (Convert.IsDBNull(row["NgayVaoDoanDang"]))?string.Empty:(System.String)row["NgayVaoDoanDang"];
					c.NgayKyHopDong = (Convert.IsDBNull(row["NgayKyHopDong"]))?DateTime.MinValue:(System.DateTime?)row["NgayKyHopDong"];
					c.NgayKetThucHopDong = (Convert.IsDBNull(row["NgayKetThucHopDong"]))?DateTime.MinValue:(System.DateTime?)row["NgayKetThucHopDong"];
					c.HinhAnh = (Convert.IsDBNull(row["HinhAnh"]))?new byte[] {}:(System.Byte[])row["HinhAnh"];
					c.DiaChi = (Convert.IsDBNull(row["DiaChi"]))?string.Empty:(System.String)row["DiaChi"];
					c.ThuongTru = (Convert.IsDBNull(row["ThuongTru"]))?string.Empty:(System.String)row["ThuongTru"];
					c.NoiLamViec = (Convert.IsDBNull(row["NoiLamViec"]))?string.Empty:(System.String)row["NoiLamViec"];
					c.Email = (Convert.IsDBNull(row["Email"]))?string.Empty:(System.String)row["Email"];
					c.DienThoai = (Convert.IsDBNull(row["DienThoai"]))?string.Empty:(System.String)row["DienThoai"];
					c.SoDiDong = (Convert.IsDBNull(row["SoDiDong"]))?string.Empty:(System.String)row["SoDiDong"];
					c.SoTaiKhoan = (Convert.IsDBNull(row["SoTaiKhoan"]))?string.Empty:(System.String)row["SoTaiKhoan"];
					c.TenNganHang = (Convert.IsDBNull(row["TenNganHang"]))?string.Empty:(System.String)row["TenNganHang"];
					c.MaSoThue = (Convert.IsDBNull(row["MaSoThue"]))?string.Empty:(System.String)row["MaSoThue"];
					c.ChiNhanh = (Convert.IsDBNull(row["ChiNhanh"]))?string.Empty:(System.String)row["ChiNhanh"];
					c.SoSoBaoHiem = (Convert.IsDBNull(row["SoSoBaoHiem"]))?string.Empty:(System.String)row["SoSoBaoHiem"];
					c.ThoiGianBatDau = (Convert.IsDBNull(row["ThoiGianBatDau"]))?string.Empty:(System.String)row["ThoiGianBatDau"];
					c.BacLuong = (Convert.IsDBNull(row["BacLuong"]))?0.0m:(System.Decimal?)row["BacLuong"];
					c.NgayHuongLuong = (Convert.IsDBNull(row["NgayHuongLuong"]))?string.Empty:(System.String)row["NgayHuongLuong"];
					c.NamLamViec = (Convert.IsDBNull(row["NamLamViec"]))?string.Empty:(System.String)row["NamLamViec"];
					c.ChuyenNganh = (Convert.IsDBNull(row["ChuyenNganh"]))?string.Empty:(System.String)row["ChuyenNganh"];
					c.MaHeSoThuLao = (Convert.IsDBNull(row["MaHeSoThuLao"]))?string.Empty:(System.String)row["MaHeSoThuLao"];
					c.MaDanToc = (Convert.IsDBNull(row["MaDanToc"]))?string.Empty:(System.String)row["MaDanToc"];
					c.TenDanToc = (Convert.IsDBNull(row["TenDanToc"]))?string.Empty:(System.String)row["TenDanToc"];
					c.MaTonGiao = (Convert.IsDBNull(row["MaTonGiao"]))?string.Empty:(System.String)row["MaTonGiao"];
					c.TenTonGiao = (Convert.IsDBNull(row["TenTonGiao"]))?string.Empty:(System.String)row["TenTonGiao"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?string.Empty:(System.String)row["MaHocHam"];
					c.TenHocHam = (Convert.IsDBNull(row["TenHocHam"]))?string.Empty:(System.String)row["TenHocHam"];
					c.MaHocVi = (Convert.IsDBNull(row["MaHocVi"]))?string.Empty:(System.String)row["MaHocVi"];
					c.TenHocVi = (Convert.IsDBNull(row["TenHocVi"]))?string.Empty:(System.String)row["TenHocVi"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?string.Empty:(System.String)row["MaLoaiGiangVien"];
					c.TenLoaiGiangVien = (Convert.IsDBNull(row["TenLoaiGiangVien"]))?string.Empty:(System.String)row["TenLoaiGiangVien"];
					c.TenDangNhap = (Convert.IsDBNull(row["TenDangNhap"]))?string.Empty:(System.String)row["TenDangNhap"];
					c.TenMayTinh = (Convert.IsDBNull(row["TenMayTinh"]))?string.Empty:(System.String)row["TenMayTinh"];
					c.MatKhau = (Convert.IsDBNull(row["MatKhau"]))?string.Empty:(System.String)row["MatKhau"];
					c.MaTinhTrang = (Convert.IsDBNull(row["MaTinhTrang"]))?string.Empty:(System.String)row["MaTinhTrang"];
					c.TenTinhTrang = (Convert.IsDBNull(row["TenTinhTrang"]))?string.Empty:(System.String)row["TenTinhTrang"];
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
		/// Fill an <see cref="VList&lt;ViewThongTinChiTietGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThongTinChiTietGiangVien&gt;"/></returns>
		protected VList<ViewThongTinChiTietGiangVien> Fill(IDataReader reader, VList<ViewThongTinChiTietGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThongTinChiTietGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThongTinChiTietGiangVien>("ViewThongTinChiTietGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThongTinChiTietGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.TenDem = reader.IsDBNull(reader.GetOrdinal("TenDem")) ? null : (System.String)reader["TenDem"];
					//entity.TenDem = (Convert.IsDBNull(reader["TenDem"]))?string.Empty:(System.String)reader["TenDem"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.HoTenDem = reader.IsDBNull(reader.GetOrdinal("HoTenDem")) ? null : (System.String)reader["HoTenDem"];
					//entity.HoTenDem = (Convert.IsDBNull(reader["HoTenDem"]))?string.Empty:(System.String)reader["HoTenDem"];
					entity.NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? null : (System.String)reader["NgaySinh"];
					//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
					entity.GioiTinh = reader.IsDBNull(reader.GetOrdinal("GioiTinh")) ? null : (System.Boolean?)reader["GioiTinh"];
					//entity.GioiTinh = (Convert.IsDBNull(reader["GioiTinh"]))?false:(System.Boolean?)reader["GioiTinh"];
					entity.TenGioiTinh = (System.String)reader["TenGioiTinh"];
					//entity.TenGioiTinh = (Convert.IsDBNull(reader["TenGioiTinh"]))?string.Empty:(System.String)reader["TenGioiTinh"];
					entity.NoiSinh = reader.IsDBNull(reader.GetOrdinal("NoiSinh")) ? null : (System.String)reader["NoiSinh"];
					//entity.NoiSinh = (Convert.IsDBNull(reader["NoiSinh"]))?string.Empty:(System.String)reader["NoiSinh"];
					entity.Cmnd = reader.IsDBNull(reader.GetOrdinal("Cmnd")) ? null : (System.String)reader["Cmnd"];
					//entity.Cmnd = (Convert.IsDBNull(reader["Cmnd"]))?string.Empty:(System.String)reader["Cmnd"];
					entity.NgayCap = reader.IsDBNull(reader.GetOrdinal("NgayCap")) ? null : (System.String)reader["NgayCap"];
					//entity.NgayCap = (Convert.IsDBNull(reader["NgayCap"]))?string.Empty:(System.String)reader["NgayCap"];
					entity.NoiCap = reader.IsDBNull(reader.GetOrdinal("NoiCap")) ? null : (System.String)reader["NoiCap"];
					//entity.NoiCap = (Convert.IsDBNull(reader["NoiCap"]))?string.Empty:(System.String)reader["NoiCap"];
					entity.DoanDang = reader.IsDBNull(reader.GetOrdinal("DoanDang")) ? null : (System.Boolean?)reader["DoanDang"];
					//entity.DoanDang = (Convert.IsDBNull(reader["DoanDang"]))?false:(System.Boolean?)reader["DoanDang"];
					entity.NgayVaoDoanDang = reader.IsDBNull(reader.GetOrdinal("NgayVaoDoanDang")) ? null : (System.String)reader["NgayVaoDoanDang"];
					//entity.NgayVaoDoanDang = (Convert.IsDBNull(reader["NgayVaoDoanDang"]))?string.Empty:(System.String)reader["NgayVaoDoanDang"];
					entity.NgayKyHopDong = reader.IsDBNull(reader.GetOrdinal("NgayKyHopDong")) ? null : (System.DateTime?)reader["NgayKyHopDong"];
					//entity.NgayKyHopDong = (Convert.IsDBNull(reader["NgayKyHopDong"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKyHopDong"];
					entity.NgayKetThucHopDong = reader.IsDBNull(reader.GetOrdinal("NgayKetThucHopDong")) ? null : (System.DateTime?)reader["NgayKetThucHopDong"];
					//entity.NgayKetThucHopDong = (Convert.IsDBNull(reader["NgayKetThucHopDong"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThucHopDong"];
					entity.HinhAnh = reader.IsDBNull(reader.GetOrdinal("HinhAnh")) ? null : (System.Byte[])reader["HinhAnh"];
					//entity.HinhAnh = (Convert.IsDBNull(reader["HinhAnh"]))?new byte[] {}:(System.Byte[])reader["HinhAnh"];
					entity.DiaChi = reader.IsDBNull(reader.GetOrdinal("DiaChi")) ? null : (System.String)reader["DiaChi"];
					//entity.DiaChi = (Convert.IsDBNull(reader["DiaChi"]))?string.Empty:(System.String)reader["DiaChi"];
					entity.ThuongTru = reader.IsDBNull(reader.GetOrdinal("ThuongTru")) ? null : (System.String)reader["ThuongTru"];
					//entity.ThuongTru = (Convert.IsDBNull(reader["ThuongTru"]))?string.Empty:(System.String)reader["ThuongTru"];
					entity.NoiLamViec = reader.IsDBNull(reader.GetOrdinal("NoiLamViec")) ? null : (System.String)reader["NoiLamViec"];
					//entity.NoiLamViec = (Convert.IsDBNull(reader["NoiLamViec"]))?string.Empty:(System.String)reader["NoiLamViec"];
					entity.Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : (System.String)reader["Email"];
					//entity.Email = (Convert.IsDBNull(reader["Email"]))?string.Empty:(System.String)reader["Email"];
					entity.DienThoai = reader.IsDBNull(reader.GetOrdinal("DienThoai")) ? null : (System.String)reader["DienThoai"];
					//entity.DienThoai = (Convert.IsDBNull(reader["DienThoai"]))?string.Empty:(System.String)reader["DienThoai"];
					entity.SoDiDong = reader.IsDBNull(reader.GetOrdinal("SoDiDong")) ? null : (System.String)reader["SoDiDong"];
					//entity.SoDiDong = (Convert.IsDBNull(reader["SoDiDong"]))?string.Empty:(System.String)reader["SoDiDong"];
					entity.SoTaiKhoan = reader.IsDBNull(reader.GetOrdinal("SoTaiKhoan")) ? null : (System.String)reader["SoTaiKhoan"];
					//entity.SoTaiKhoan = (Convert.IsDBNull(reader["SoTaiKhoan"]))?string.Empty:(System.String)reader["SoTaiKhoan"];
					entity.TenNganHang = reader.IsDBNull(reader.GetOrdinal("TenNganHang")) ? null : (System.String)reader["TenNganHang"];
					//entity.TenNganHang = (Convert.IsDBNull(reader["TenNganHang"]))?string.Empty:(System.String)reader["TenNganHang"];
					entity.MaSoThue = reader.IsDBNull(reader.GetOrdinal("MaSoThue")) ? null : (System.String)reader["MaSoThue"];
					//entity.MaSoThue = (Convert.IsDBNull(reader["MaSoThue"]))?string.Empty:(System.String)reader["MaSoThue"];
					entity.ChiNhanh = reader.IsDBNull(reader.GetOrdinal("ChiNhanh")) ? null : (System.String)reader["ChiNhanh"];
					//entity.ChiNhanh = (Convert.IsDBNull(reader["ChiNhanh"]))?string.Empty:(System.String)reader["ChiNhanh"];
					entity.SoSoBaoHiem = reader.IsDBNull(reader.GetOrdinal("SoSoBaoHiem")) ? null : (System.String)reader["SoSoBaoHiem"];
					//entity.SoSoBaoHiem = (Convert.IsDBNull(reader["SoSoBaoHiem"]))?string.Empty:(System.String)reader["SoSoBaoHiem"];
					entity.ThoiGianBatDau = reader.IsDBNull(reader.GetOrdinal("ThoiGianBatDau")) ? null : (System.String)reader["ThoiGianBatDau"];
					//entity.ThoiGianBatDau = (Convert.IsDBNull(reader["ThoiGianBatDau"]))?string.Empty:(System.String)reader["ThoiGianBatDau"];
					entity.BacLuong = reader.IsDBNull(reader.GetOrdinal("BacLuong")) ? null : (System.Decimal?)reader["BacLuong"];
					//entity.BacLuong = (Convert.IsDBNull(reader["BacLuong"]))?0.0m:(System.Decimal?)reader["BacLuong"];
					entity.NgayHuongLuong = reader.IsDBNull(reader.GetOrdinal("NgayHuongLuong")) ? null : (System.String)reader["NgayHuongLuong"];
					//entity.NgayHuongLuong = (Convert.IsDBNull(reader["NgayHuongLuong"]))?string.Empty:(System.String)reader["NgayHuongLuong"];
					entity.NamLamViec = reader.IsDBNull(reader.GetOrdinal("NamLamViec")) ? null : (System.String)reader["NamLamViec"];
					//entity.NamLamViec = (Convert.IsDBNull(reader["NamLamViec"]))?string.Empty:(System.String)reader["NamLamViec"];
					entity.ChuyenNganh = reader.IsDBNull(reader.GetOrdinal("ChuyenNganh")) ? null : (System.String)reader["ChuyenNganh"];
					//entity.ChuyenNganh = (Convert.IsDBNull(reader["ChuyenNganh"]))?string.Empty:(System.String)reader["ChuyenNganh"];
					entity.MaHeSoThuLao = reader.IsDBNull(reader.GetOrdinal("MaHeSoThuLao")) ? null : (System.String)reader["MaHeSoThuLao"];
					//entity.MaHeSoThuLao = (Convert.IsDBNull(reader["MaHeSoThuLao"]))?string.Empty:(System.String)reader["MaHeSoThuLao"];
					entity.MaDanToc = reader.IsDBNull(reader.GetOrdinal("MaDanToc")) ? null : (System.String)reader["MaDanToc"];
					//entity.MaDanToc = (Convert.IsDBNull(reader["MaDanToc"]))?string.Empty:(System.String)reader["MaDanToc"];
					entity.TenDanToc = reader.IsDBNull(reader.GetOrdinal("TenDanToc")) ? null : (System.String)reader["TenDanToc"];
					//entity.TenDanToc = (Convert.IsDBNull(reader["TenDanToc"]))?string.Empty:(System.String)reader["TenDanToc"];
					entity.MaTonGiao = reader.IsDBNull(reader.GetOrdinal("MaTonGiao")) ? null : (System.String)reader["MaTonGiao"];
					//entity.MaTonGiao = (Convert.IsDBNull(reader["MaTonGiao"]))?string.Empty:(System.String)reader["MaTonGiao"];
					entity.TenTonGiao = reader.IsDBNull(reader.GetOrdinal("TenTonGiao")) ? null : (System.String)reader["TenTonGiao"];
					//entity.TenTonGiao = (Convert.IsDBNull(reader["TenTonGiao"]))?string.Empty:(System.String)reader["TenTonGiao"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TenDonVi = reader.IsDBNull(reader.GetOrdinal("TenDonVi")) ? null : (System.String)reader["TenDonVi"];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.String)reader["MaHocHam"];
					//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?string.Empty:(System.String)reader["MaHocHam"];
					entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
					//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
					entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.String)reader["MaHocVi"];
					//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?string.Empty:(System.String)reader["MaHocVi"];
					entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
					//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
					entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.String)reader["MaLoaiGiangVien"];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?string.Empty:(System.String)reader["MaLoaiGiangVien"];
					entity.TenLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("TenLoaiGiangVien")) ? null : (System.String)reader["TenLoaiGiangVien"];
					//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
					entity.TenDangNhap = reader.IsDBNull(reader.GetOrdinal("TenDangNhap")) ? null : (System.String)reader["TenDangNhap"];
					//entity.TenDangNhap = (Convert.IsDBNull(reader["TenDangNhap"]))?string.Empty:(System.String)reader["TenDangNhap"];
					entity.TenMayTinh = reader.IsDBNull(reader.GetOrdinal("TenMayTinh")) ? null : (System.String)reader["TenMayTinh"];
					//entity.TenMayTinh = (Convert.IsDBNull(reader["TenMayTinh"]))?string.Empty:(System.String)reader["TenMayTinh"];
					entity.MatKhau = reader.IsDBNull(reader.GetOrdinal("MatKhau")) ? null : (System.String)reader["MatKhau"];
					//entity.MatKhau = (Convert.IsDBNull(reader["MatKhau"]))?string.Empty:(System.String)reader["MatKhau"];
					entity.MaTinhTrang = reader.IsDBNull(reader.GetOrdinal("MaTinhTrang")) ? null : (System.String)reader["MaTinhTrang"];
					//entity.MaTinhTrang = (Convert.IsDBNull(reader["MaTinhTrang"]))?string.Empty:(System.String)reader["MaTinhTrang"];
					entity.TenTinhTrang = reader.IsDBNull(reader.GetOrdinal("TenTinhTrang")) ? null : (System.String)reader["TenTinhTrang"];
					//entity.TenTinhTrang = (Convert.IsDBNull(reader["TenTinhTrang"]))?string.Empty:(System.String)reader["TenTinhTrang"];
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
		/// Refreshes the <see cref="ViewThongTinChiTietGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongTinChiTietGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThongTinChiTietGiangVien entity)
		{
			reader.Read();
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.TenDem = reader.IsDBNull(reader.GetOrdinal("TenDem")) ? null : (System.String)reader["TenDem"];
			//entity.TenDem = (Convert.IsDBNull(reader["TenDem"]))?string.Empty:(System.String)reader["TenDem"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.HoTenDem = reader.IsDBNull(reader.GetOrdinal("HoTenDem")) ? null : (System.String)reader["HoTenDem"];
			//entity.HoTenDem = (Convert.IsDBNull(reader["HoTenDem"]))?string.Empty:(System.String)reader["HoTenDem"];
			entity.NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? null : (System.String)reader["NgaySinh"];
			//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
			entity.GioiTinh = reader.IsDBNull(reader.GetOrdinal("GioiTinh")) ? null : (System.Boolean?)reader["GioiTinh"];
			//entity.GioiTinh = (Convert.IsDBNull(reader["GioiTinh"]))?false:(System.Boolean?)reader["GioiTinh"];
			entity.TenGioiTinh = (System.String)reader["TenGioiTinh"];
			//entity.TenGioiTinh = (Convert.IsDBNull(reader["TenGioiTinh"]))?string.Empty:(System.String)reader["TenGioiTinh"];
			entity.NoiSinh = reader.IsDBNull(reader.GetOrdinal("NoiSinh")) ? null : (System.String)reader["NoiSinh"];
			//entity.NoiSinh = (Convert.IsDBNull(reader["NoiSinh"]))?string.Empty:(System.String)reader["NoiSinh"];
			entity.Cmnd = reader.IsDBNull(reader.GetOrdinal("Cmnd")) ? null : (System.String)reader["Cmnd"];
			//entity.Cmnd = (Convert.IsDBNull(reader["Cmnd"]))?string.Empty:(System.String)reader["Cmnd"];
			entity.NgayCap = reader.IsDBNull(reader.GetOrdinal("NgayCap")) ? null : (System.String)reader["NgayCap"];
			//entity.NgayCap = (Convert.IsDBNull(reader["NgayCap"]))?string.Empty:(System.String)reader["NgayCap"];
			entity.NoiCap = reader.IsDBNull(reader.GetOrdinal("NoiCap")) ? null : (System.String)reader["NoiCap"];
			//entity.NoiCap = (Convert.IsDBNull(reader["NoiCap"]))?string.Empty:(System.String)reader["NoiCap"];
			entity.DoanDang = reader.IsDBNull(reader.GetOrdinal("DoanDang")) ? null : (System.Boolean?)reader["DoanDang"];
			//entity.DoanDang = (Convert.IsDBNull(reader["DoanDang"]))?false:(System.Boolean?)reader["DoanDang"];
			entity.NgayVaoDoanDang = reader.IsDBNull(reader.GetOrdinal("NgayVaoDoanDang")) ? null : (System.String)reader["NgayVaoDoanDang"];
			//entity.NgayVaoDoanDang = (Convert.IsDBNull(reader["NgayVaoDoanDang"]))?string.Empty:(System.String)reader["NgayVaoDoanDang"];
			entity.NgayKyHopDong = reader.IsDBNull(reader.GetOrdinal("NgayKyHopDong")) ? null : (System.DateTime?)reader["NgayKyHopDong"];
			//entity.NgayKyHopDong = (Convert.IsDBNull(reader["NgayKyHopDong"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKyHopDong"];
			entity.NgayKetThucHopDong = reader.IsDBNull(reader.GetOrdinal("NgayKetThucHopDong")) ? null : (System.DateTime?)reader["NgayKetThucHopDong"];
			//entity.NgayKetThucHopDong = (Convert.IsDBNull(reader["NgayKetThucHopDong"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThucHopDong"];
			entity.HinhAnh = reader.IsDBNull(reader.GetOrdinal("HinhAnh")) ? null : (System.Byte[])reader["HinhAnh"];
			//entity.HinhAnh = (Convert.IsDBNull(reader["HinhAnh"]))?new byte[] {}:(System.Byte[])reader["HinhAnh"];
			entity.DiaChi = reader.IsDBNull(reader.GetOrdinal("DiaChi")) ? null : (System.String)reader["DiaChi"];
			//entity.DiaChi = (Convert.IsDBNull(reader["DiaChi"]))?string.Empty:(System.String)reader["DiaChi"];
			entity.ThuongTru = reader.IsDBNull(reader.GetOrdinal("ThuongTru")) ? null : (System.String)reader["ThuongTru"];
			//entity.ThuongTru = (Convert.IsDBNull(reader["ThuongTru"]))?string.Empty:(System.String)reader["ThuongTru"];
			entity.NoiLamViec = reader.IsDBNull(reader.GetOrdinal("NoiLamViec")) ? null : (System.String)reader["NoiLamViec"];
			//entity.NoiLamViec = (Convert.IsDBNull(reader["NoiLamViec"]))?string.Empty:(System.String)reader["NoiLamViec"];
			entity.Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : (System.String)reader["Email"];
			//entity.Email = (Convert.IsDBNull(reader["Email"]))?string.Empty:(System.String)reader["Email"];
			entity.DienThoai = reader.IsDBNull(reader.GetOrdinal("DienThoai")) ? null : (System.String)reader["DienThoai"];
			//entity.DienThoai = (Convert.IsDBNull(reader["DienThoai"]))?string.Empty:(System.String)reader["DienThoai"];
			entity.SoDiDong = reader.IsDBNull(reader.GetOrdinal("SoDiDong")) ? null : (System.String)reader["SoDiDong"];
			//entity.SoDiDong = (Convert.IsDBNull(reader["SoDiDong"]))?string.Empty:(System.String)reader["SoDiDong"];
			entity.SoTaiKhoan = reader.IsDBNull(reader.GetOrdinal("SoTaiKhoan")) ? null : (System.String)reader["SoTaiKhoan"];
			//entity.SoTaiKhoan = (Convert.IsDBNull(reader["SoTaiKhoan"]))?string.Empty:(System.String)reader["SoTaiKhoan"];
			entity.TenNganHang = reader.IsDBNull(reader.GetOrdinal("TenNganHang")) ? null : (System.String)reader["TenNganHang"];
			//entity.TenNganHang = (Convert.IsDBNull(reader["TenNganHang"]))?string.Empty:(System.String)reader["TenNganHang"];
			entity.MaSoThue = reader.IsDBNull(reader.GetOrdinal("MaSoThue")) ? null : (System.String)reader["MaSoThue"];
			//entity.MaSoThue = (Convert.IsDBNull(reader["MaSoThue"]))?string.Empty:(System.String)reader["MaSoThue"];
			entity.ChiNhanh = reader.IsDBNull(reader.GetOrdinal("ChiNhanh")) ? null : (System.String)reader["ChiNhanh"];
			//entity.ChiNhanh = (Convert.IsDBNull(reader["ChiNhanh"]))?string.Empty:(System.String)reader["ChiNhanh"];
			entity.SoSoBaoHiem = reader.IsDBNull(reader.GetOrdinal("SoSoBaoHiem")) ? null : (System.String)reader["SoSoBaoHiem"];
			//entity.SoSoBaoHiem = (Convert.IsDBNull(reader["SoSoBaoHiem"]))?string.Empty:(System.String)reader["SoSoBaoHiem"];
			entity.ThoiGianBatDau = reader.IsDBNull(reader.GetOrdinal("ThoiGianBatDau")) ? null : (System.String)reader["ThoiGianBatDau"];
			//entity.ThoiGianBatDau = (Convert.IsDBNull(reader["ThoiGianBatDau"]))?string.Empty:(System.String)reader["ThoiGianBatDau"];
			entity.BacLuong = reader.IsDBNull(reader.GetOrdinal("BacLuong")) ? null : (System.Decimal?)reader["BacLuong"];
			//entity.BacLuong = (Convert.IsDBNull(reader["BacLuong"]))?0.0m:(System.Decimal?)reader["BacLuong"];
			entity.NgayHuongLuong = reader.IsDBNull(reader.GetOrdinal("NgayHuongLuong")) ? null : (System.String)reader["NgayHuongLuong"];
			//entity.NgayHuongLuong = (Convert.IsDBNull(reader["NgayHuongLuong"]))?string.Empty:(System.String)reader["NgayHuongLuong"];
			entity.NamLamViec = reader.IsDBNull(reader.GetOrdinal("NamLamViec")) ? null : (System.String)reader["NamLamViec"];
			//entity.NamLamViec = (Convert.IsDBNull(reader["NamLamViec"]))?string.Empty:(System.String)reader["NamLamViec"];
			entity.ChuyenNganh = reader.IsDBNull(reader.GetOrdinal("ChuyenNganh")) ? null : (System.String)reader["ChuyenNganh"];
			//entity.ChuyenNganh = (Convert.IsDBNull(reader["ChuyenNganh"]))?string.Empty:(System.String)reader["ChuyenNganh"];
			entity.MaHeSoThuLao = reader.IsDBNull(reader.GetOrdinal("MaHeSoThuLao")) ? null : (System.String)reader["MaHeSoThuLao"];
			//entity.MaHeSoThuLao = (Convert.IsDBNull(reader["MaHeSoThuLao"]))?string.Empty:(System.String)reader["MaHeSoThuLao"];
			entity.MaDanToc = reader.IsDBNull(reader.GetOrdinal("MaDanToc")) ? null : (System.String)reader["MaDanToc"];
			//entity.MaDanToc = (Convert.IsDBNull(reader["MaDanToc"]))?string.Empty:(System.String)reader["MaDanToc"];
			entity.TenDanToc = reader.IsDBNull(reader.GetOrdinal("TenDanToc")) ? null : (System.String)reader["TenDanToc"];
			//entity.TenDanToc = (Convert.IsDBNull(reader["TenDanToc"]))?string.Empty:(System.String)reader["TenDanToc"];
			entity.MaTonGiao = reader.IsDBNull(reader.GetOrdinal("MaTonGiao")) ? null : (System.String)reader["MaTonGiao"];
			//entity.MaTonGiao = (Convert.IsDBNull(reader["MaTonGiao"]))?string.Empty:(System.String)reader["MaTonGiao"];
			entity.TenTonGiao = reader.IsDBNull(reader.GetOrdinal("TenTonGiao")) ? null : (System.String)reader["TenTonGiao"];
			//entity.TenTonGiao = (Convert.IsDBNull(reader["TenTonGiao"]))?string.Empty:(System.String)reader["TenTonGiao"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TenDonVi = reader.IsDBNull(reader.GetOrdinal("TenDonVi")) ? null : (System.String)reader["TenDonVi"];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.String)reader["MaHocHam"];
			//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?string.Empty:(System.String)reader["MaHocHam"];
			entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
			//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
			entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.String)reader["MaHocVi"];
			//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?string.Empty:(System.String)reader["MaHocVi"];
			entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
			//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
			entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.String)reader["MaLoaiGiangVien"];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?string.Empty:(System.String)reader["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("TenLoaiGiangVien")) ? null : (System.String)reader["TenLoaiGiangVien"];
			//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
			entity.TenDangNhap = reader.IsDBNull(reader.GetOrdinal("TenDangNhap")) ? null : (System.String)reader["TenDangNhap"];
			//entity.TenDangNhap = (Convert.IsDBNull(reader["TenDangNhap"]))?string.Empty:(System.String)reader["TenDangNhap"];
			entity.TenMayTinh = reader.IsDBNull(reader.GetOrdinal("TenMayTinh")) ? null : (System.String)reader["TenMayTinh"];
			//entity.TenMayTinh = (Convert.IsDBNull(reader["TenMayTinh"]))?string.Empty:(System.String)reader["TenMayTinh"];
			entity.MatKhau = reader.IsDBNull(reader.GetOrdinal("MatKhau")) ? null : (System.String)reader["MatKhau"];
			//entity.MatKhau = (Convert.IsDBNull(reader["MatKhau"]))?string.Empty:(System.String)reader["MatKhau"];
			entity.MaTinhTrang = reader.IsDBNull(reader.GetOrdinal("MaTinhTrang")) ? null : (System.String)reader["MaTinhTrang"];
			//entity.MaTinhTrang = (Convert.IsDBNull(reader["MaTinhTrang"]))?string.Empty:(System.String)reader["MaTinhTrang"];
			entity.TenTinhTrang = reader.IsDBNull(reader.GetOrdinal("TenTinhTrang")) ? null : (System.String)reader["TenTinhTrang"];
			//entity.TenTinhTrang = (Convert.IsDBNull(reader["TenTinhTrang"]))?string.Empty:(System.String)reader["TenTinhTrang"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThongTinChiTietGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThongTinChiTietGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThongTinChiTietGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.TenDem = (Convert.IsDBNull(dataRow["TenDem"]))?string.Empty:(System.String)dataRow["TenDem"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTenDem = (Convert.IsDBNull(dataRow["HoTenDem"]))?string.Empty:(System.String)dataRow["HoTenDem"];
			entity.NgaySinh = (Convert.IsDBNull(dataRow["NgaySinh"]))?string.Empty:(System.String)dataRow["NgaySinh"];
			entity.GioiTinh = (Convert.IsDBNull(dataRow["GioiTinh"]))?false:(System.Boolean?)dataRow["GioiTinh"];
			entity.TenGioiTinh = (Convert.IsDBNull(dataRow["TenGioiTinh"]))?string.Empty:(System.String)dataRow["TenGioiTinh"];
			entity.NoiSinh = (Convert.IsDBNull(dataRow["NoiSinh"]))?string.Empty:(System.String)dataRow["NoiSinh"];
			entity.Cmnd = (Convert.IsDBNull(dataRow["Cmnd"]))?string.Empty:(System.String)dataRow["Cmnd"];
			entity.NgayCap = (Convert.IsDBNull(dataRow["NgayCap"]))?string.Empty:(System.String)dataRow["NgayCap"];
			entity.NoiCap = (Convert.IsDBNull(dataRow["NoiCap"]))?string.Empty:(System.String)dataRow["NoiCap"];
			entity.DoanDang = (Convert.IsDBNull(dataRow["DoanDang"]))?false:(System.Boolean?)dataRow["DoanDang"];
			entity.NgayVaoDoanDang = (Convert.IsDBNull(dataRow["NgayVaoDoanDang"]))?string.Empty:(System.String)dataRow["NgayVaoDoanDang"];
			entity.NgayKyHopDong = (Convert.IsDBNull(dataRow["NgayKyHopDong"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKyHopDong"];
			entity.NgayKetThucHopDong = (Convert.IsDBNull(dataRow["NgayKetThucHopDong"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKetThucHopDong"];
			entity.HinhAnh = (Convert.IsDBNull(dataRow["HinhAnh"]))?new byte[] {}:(System.Byte[])dataRow["HinhAnh"];
			entity.DiaChi = (Convert.IsDBNull(dataRow["DiaChi"]))?string.Empty:(System.String)dataRow["DiaChi"];
			entity.ThuongTru = (Convert.IsDBNull(dataRow["ThuongTru"]))?string.Empty:(System.String)dataRow["ThuongTru"];
			entity.NoiLamViec = (Convert.IsDBNull(dataRow["NoiLamViec"]))?string.Empty:(System.String)dataRow["NoiLamViec"];
			entity.Email = (Convert.IsDBNull(dataRow["Email"]))?string.Empty:(System.String)dataRow["Email"];
			entity.DienThoai = (Convert.IsDBNull(dataRow["DienThoai"]))?string.Empty:(System.String)dataRow["DienThoai"];
			entity.SoDiDong = (Convert.IsDBNull(dataRow["SoDiDong"]))?string.Empty:(System.String)dataRow["SoDiDong"];
			entity.SoTaiKhoan = (Convert.IsDBNull(dataRow["SoTaiKhoan"]))?string.Empty:(System.String)dataRow["SoTaiKhoan"];
			entity.TenNganHang = (Convert.IsDBNull(dataRow["TenNganHang"]))?string.Empty:(System.String)dataRow["TenNganHang"];
			entity.MaSoThue = (Convert.IsDBNull(dataRow["MaSoThue"]))?string.Empty:(System.String)dataRow["MaSoThue"];
			entity.ChiNhanh = (Convert.IsDBNull(dataRow["ChiNhanh"]))?string.Empty:(System.String)dataRow["ChiNhanh"];
			entity.SoSoBaoHiem = (Convert.IsDBNull(dataRow["SoSoBaoHiem"]))?string.Empty:(System.String)dataRow["SoSoBaoHiem"];
			entity.ThoiGianBatDau = (Convert.IsDBNull(dataRow["ThoiGianBatDau"]))?string.Empty:(System.String)dataRow["ThoiGianBatDau"];
			entity.BacLuong = (Convert.IsDBNull(dataRow["BacLuong"]))?0.0m:(System.Decimal?)dataRow["BacLuong"];
			entity.NgayHuongLuong = (Convert.IsDBNull(dataRow["NgayHuongLuong"]))?string.Empty:(System.String)dataRow["NgayHuongLuong"];
			entity.NamLamViec = (Convert.IsDBNull(dataRow["NamLamViec"]))?string.Empty:(System.String)dataRow["NamLamViec"];
			entity.ChuyenNganh = (Convert.IsDBNull(dataRow["ChuyenNganh"]))?string.Empty:(System.String)dataRow["ChuyenNganh"];
			entity.MaHeSoThuLao = (Convert.IsDBNull(dataRow["MaHeSoThuLao"]))?string.Empty:(System.String)dataRow["MaHeSoThuLao"];
			entity.MaDanToc = (Convert.IsDBNull(dataRow["MaDanToc"]))?string.Empty:(System.String)dataRow["MaDanToc"];
			entity.TenDanToc = (Convert.IsDBNull(dataRow["TenDanToc"]))?string.Empty:(System.String)dataRow["TenDanToc"];
			entity.MaTonGiao = (Convert.IsDBNull(dataRow["MaTonGiao"]))?string.Empty:(System.String)dataRow["MaTonGiao"];
			entity.TenTonGiao = (Convert.IsDBNull(dataRow["TenTonGiao"]))?string.Empty:(System.String)dataRow["TenTonGiao"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?string.Empty:(System.String)dataRow["MaHocHam"];
			entity.TenHocHam = (Convert.IsDBNull(dataRow["TenHocHam"]))?string.Empty:(System.String)dataRow["TenHocHam"];
			entity.MaHocVi = (Convert.IsDBNull(dataRow["MaHocVi"]))?string.Empty:(System.String)dataRow["MaHocVi"];
			entity.TenHocVi = (Convert.IsDBNull(dataRow["TenHocVi"]))?string.Empty:(System.String)dataRow["TenHocVi"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?string.Empty:(System.String)dataRow["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = (Convert.IsDBNull(dataRow["TenLoaiGiangVien"]))?string.Empty:(System.String)dataRow["TenLoaiGiangVien"];
			entity.TenDangNhap = (Convert.IsDBNull(dataRow["TenDangNhap"]))?string.Empty:(System.String)dataRow["TenDangNhap"];
			entity.TenMayTinh = (Convert.IsDBNull(dataRow["TenMayTinh"]))?string.Empty:(System.String)dataRow["TenMayTinh"];
			entity.MatKhau = (Convert.IsDBNull(dataRow["MatKhau"]))?string.Empty:(System.String)dataRow["MatKhau"];
			entity.MaTinhTrang = (Convert.IsDBNull(dataRow["MaTinhTrang"]))?string.Empty:(System.String)dataRow["MaTinhTrang"];
			entity.TenTinhTrang = (Convert.IsDBNull(dataRow["TenTinhTrang"]))?string.Empty:(System.String)dataRow["TenTinhTrang"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThongTinChiTietGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinChiTietGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinChiTietGiangVienFilterBuilder : SqlFilterBuilder<ViewThongTinChiTietGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienFilterBuilder class.
		/// </summary>
		public ViewThongTinChiTietGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongTinChiTietGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongTinChiTietGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongTinChiTietGiangVienFilterBuilder

	#region ViewThongTinChiTietGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinChiTietGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinChiTietGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<ViewThongTinChiTietGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienParameterBuilder class.
		/// </summary>
		public ViewThongTinChiTietGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThongTinChiTietGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThongTinChiTietGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThongTinChiTietGiangVienParameterBuilder
	
	#region ViewThongTinChiTietGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinChiTietGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThongTinChiTietGiangVienSortBuilder : SqlSortBuilder<ViewThongTinChiTietGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienSqlSortBuilder class.
		/// </summary>
		public ViewThongTinChiTietGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThongTinChiTietGiangVienSortBuilder

} // end namespace
