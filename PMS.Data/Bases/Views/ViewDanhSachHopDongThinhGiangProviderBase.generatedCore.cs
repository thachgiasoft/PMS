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
	/// This class is the base class for any <see cref="ViewDanhSachHopDongThinhGiangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewDanhSachHopDongThinhGiangProviderBaseCore : EntityViewProviderBase<ViewDanhSachHopDongThinhGiang>
	{
		#region Custom Methods
		
		
		#region cust_View_DanhSachHopDongThinhGiang_GetHopDongChuaXacNhan
		
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachHopDongThinhGiang_GetHopDongChuaXacNhan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDanhSachHopDongThinhGiang&gt;"/> instance.</returns>
		public VList<ViewDanhSachHopDongThinhGiang> GetHopDongChuaXacNhan(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetHopDongChuaXacNhan(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachHopDongThinhGiang_GetHopDongChuaXacNhan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDanhSachHopDongThinhGiang&gt;"/> instance.</returns>
		public VList<ViewDanhSachHopDongThinhGiang> GetHopDongChuaXacNhan(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetHopDongChuaXacNhan(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachHopDongThinhGiang_GetHopDongChuaXacNhan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewDanhSachHopDongThinhGiang&gt;"/> instance.</returns>
		public VList<ViewDanhSachHopDongThinhGiang> GetHopDongChuaXacNhan(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetHopDongChuaXacNhan(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachHopDongThinhGiang_GetHopDongChuaXacNhan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDanhSachHopDongThinhGiang&gt;"/> instance.</returns>
		public abstract VList<ViewDanhSachHopDongThinhGiang> GetHopDongChuaXacNhan(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion

		
		#region cust_View_DanhSachHopDongThinhGiang_GetHopDongDaXacNhan
		
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachHopDongThinhGiang_GetHopDongDaXacNhan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDanhSachHopDongThinhGiang&gt;"/> instance.</returns>
		public VList<ViewDanhSachHopDongThinhGiang> GetHopDongDaXacNhan(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetHopDongDaXacNhan(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachHopDongThinhGiang_GetHopDongDaXacNhan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDanhSachHopDongThinhGiang&gt;"/> instance.</returns>
		public VList<ViewDanhSachHopDongThinhGiang> GetHopDongDaXacNhan(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetHopDongDaXacNhan(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachHopDongThinhGiang_GetHopDongDaXacNhan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewDanhSachHopDongThinhGiang&gt;"/> instance.</returns>
		public VList<ViewDanhSachHopDongThinhGiang> GetHopDongDaXacNhan(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetHopDongDaXacNhan(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_DanhSachHopDongThinhGiang_GetHopDongDaXacNhan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewDanhSachHopDongThinhGiang&gt;"/> instance.</returns>
		public abstract VList<ViewDanhSachHopDongThinhGiang> GetHopDongDaXacNhan(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewDanhSachHopDongThinhGiang&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewDanhSachHopDongThinhGiang&gt;"/></returns>
		protected static VList&lt;ViewDanhSachHopDongThinhGiang&gt; Fill(DataSet dataSet, VList<ViewDanhSachHopDongThinhGiang> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewDanhSachHopDongThinhGiang>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewDanhSachHopDongThinhGiang&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewDanhSachHopDongThinhGiang>"/></returns>
		protected static VList&lt;ViewDanhSachHopDongThinhGiang&gt; Fill(DataTable dataTable, VList<ViewDanhSachHopDongThinhGiang> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewDanhSachHopDongThinhGiang c = new ViewDanhSachHopDongThinhGiang();
					c.Id = (Convert.IsDBNull(row["Id"]))?(int)0:(System.Int32)row["Id"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32?)row["MaGiangVien"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.NgaySinh = (Convert.IsDBNull(row["NgaySinh"]))?string.Empty:(System.String)row["NgaySinh"];
					c.SoCmnd = (Convert.IsDBNull(row["SoCmnd"]))?string.Empty:(System.String)row["SoCmnd"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?(int)0:(System.Int32?)row["MaHocHam"];
					c.TenHocHam = (Convert.IsDBNull(row["TenHocHam"]))?string.Empty:(System.String)row["TenHocHam"];
					c.MaHocVi = (Convert.IsDBNull(row["MaHocVi"]))?(int)0:(System.Int32?)row["MaHocVi"];
					c.TenHocVi = (Convert.IsDBNull(row["TenHocVi"]))?string.Empty:(System.String)row["TenHocVi"];
					c.ChuyenNganh = (Convert.IsDBNull(row["ChuyenNganh"]))?string.Empty:(System.String)row["ChuyenNganh"];
					c.MaSoThue = (Convert.IsDBNull(row["MaSoThue"]))?string.Empty:(System.String)row["MaSoThue"];
					c.CoQuanCongTac = (Convert.IsDBNull(row["CoQuanCongTac"]))?string.Empty:(System.String)row["CoQuanCongTac"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.SoHopDong = (Convert.IsDBNull(row["SoHopDong"]))?string.Empty:(System.String)row["SoHopDong"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.NgayBatDau = (Convert.IsDBNull(row["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)row["NgayBatDau"];
					c.NgayKetThuc = (Convert.IsDBNull(row["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)row["NgayKetThuc"];
					c.SoTietLyThuyet = (Convert.IsDBNull(row["SoTietLyThuyet"]))?0.0m:(System.Decimal?)row["SoTietLyThuyet"];
					c.SoTietThucHanh = (Convert.IsDBNull(row["SoTietThucHanh"]))?0.0m:(System.Decimal?)row["SoTietThucHanh"];
					c.HeSoQuyDoiThucHanh = (Convert.IsDBNull(row["HeSoQuyDoiThucHanh"]))?0.0m:(System.Decimal?)row["HeSoQuyDoiThucHanh"];
					c.SoNhomThucHanh = (Convert.IsDBNull(row["SoNhomThucHanh"]))?(int)0:(System.Int32?)row["SoNhomThucHanh"];
					c.TongSoTiet = (Convert.IsDBNull(row["TongSoTiet"]))?0.0m:(System.Decimal?)row["TongSoTiet"];
					c.SoTietLyThuyetTrenTuan = (Convert.IsDBNull(row["SoTietLyThuyetTrenTuan"]))?0.0m:(System.Decimal?)row["SoTietLyThuyetTrenTuan"];
					c.SoTietThucHanhTrenTuan = (Convert.IsDBNull(row["SoTietThucHanhTrenTuan"]))?0.0m:(System.Decimal?)row["SoTietThucHanhTrenTuan"];
					c.TongSoTietTrenTuan = (Convert.IsDBNull(row["TongSoTietTrenTuan"]))?0.0m:(System.Decimal?)row["TongSoTietTrenTuan"];
					c.HeSoLopDong = (Convert.IsDBNull(row["HeSoLopDong"]))?0.0m:(System.Decimal?)row["HeSoLopDong"];
					c.SiSo = (Convert.IsDBNull(row["SiSo"]))?(int)0:(System.Int32?)row["SiSo"];
					c.TrangThaiHoSo = (Convert.IsDBNull(row["TrangThaiHoSo"]))?string.Empty:(System.String)row["TrangThaiHoSo"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal?)row["DonGia"];
					c.DonViTienTe = (Convert.IsDBNull(row["DonViTienTe"]))?string.Empty:(System.String)row["DonViTienTe"];
					c.TongGiaTriHopDong = (Convert.IsDBNull(row["TongGiaTriHopDong"]))?0.0m:(System.Decimal?)row["TongGiaTriHopDong"];
					c.GiaTriHopDongConLai = (Convert.IsDBNull(row["GiaTriHopDongConLai"]))?0.0m:(System.Decimal?)row["GiaTriHopDongConLai"];
					c.Thue = (Convert.IsDBNull(row["Thue"]))?0.0m:(System.Decimal?)row["Thue"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?string.Empty:(System.String)row["GhiChu"];
					c.DaXacNhan = (Convert.IsDBNull(row["DaXacNhan"]))?false:(System.Boolean?)row["DaXacNhan"];
					c.IsLock = (Convert.IsDBNull(row["IsLock"]))?false:(System.Boolean?)row["IsLock"];
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
		/// Fill an <see cref="VList&lt;ViewDanhSachHopDongThinhGiang&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewDanhSachHopDongThinhGiang&gt;"/></returns>
		protected VList<ViewDanhSachHopDongThinhGiang> Fill(IDataReader reader, VList<ViewDanhSachHopDongThinhGiang> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewDanhSachHopDongThinhGiang entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewDanhSachHopDongThinhGiang>("ViewDanhSachHopDongThinhGiang",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewDanhSachHopDongThinhGiang();
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
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? null : (System.String)reader["NgaySinh"];
					//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
					entity.SoCmnd = reader.IsDBNull(reader.GetOrdinal("SoCmnd")) ? null : (System.String)reader["SoCmnd"];
					//entity.SoCmnd = (Convert.IsDBNull(reader["SoCmnd"]))?string.Empty:(System.String)reader["SoCmnd"];
					entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
					//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
					entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
					//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
					entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
					//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
					entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
					//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
					entity.ChuyenNganh = reader.IsDBNull(reader.GetOrdinal("ChuyenNganh")) ? null : (System.String)reader["ChuyenNganh"];
					//entity.ChuyenNganh = (Convert.IsDBNull(reader["ChuyenNganh"]))?string.Empty:(System.String)reader["ChuyenNganh"];
					entity.MaSoThue = reader.IsDBNull(reader.GetOrdinal("MaSoThue")) ? null : (System.String)reader["MaSoThue"];
					//entity.MaSoThue = (Convert.IsDBNull(reader["MaSoThue"]))?string.Empty:(System.String)reader["MaSoThue"];
					entity.CoQuanCongTac = reader.IsDBNull(reader.GetOrdinal("CoQuanCongTac")) ? null : (System.String)reader["CoQuanCongTac"];
					//entity.CoQuanCongTac = (Convert.IsDBNull(reader["CoQuanCongTac"]))?string.Empty:(System.String)reader["CoQuanCongTac"];
					entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.SoHopDong = reader.IsDBNull(reader.GetOrdinal("SoHopDong")) ? null : (System.String)reader["SoHopDong"];
					//entity.SoHopDong = (Convert.IsDBNull(reader["SoHopDong"]))?string.Empty:(System.String)reader["SoHopDong"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.TenDonVi = (System.String)reader["TenDonVi"];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.NgayBatDau = reader.IsDBNull(reader.GetOrdinal("NgayBatDau")) ? null : (System.DateTime?)reader["NgayBatDau"];
					//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
					entity.NgayKetThuc = reader.IsDBNull(reader.GetOrdinal("NgayKetThuc")) ? null : (System.DateTime?)reader["NgayKetThuc"];
					//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
					entity.SoTietLyThuyet = reader.IsDBNull(reader.GetOrdinal("SoTietLyThuyet")) ? null : (System.Decimal?)reader["SoTietLyThuyet"];
					//entity.SoTietLyThuyet = (Convert.IsDBNull(reader["SoTietLyThuyet"]))?0.0m:(System.Decimal?)reader["SoTietLyThuyet"];
					entity.SoTietThucHanh = reader.IsDBNull(reader.GetOrdinal("SoTietThucHanh")) ? null : (System.Decimal?)reader["SoTietThucHanh"];
					//entity.SoTietThucHanh = (Convert.IsDBNull(reader["SoTietThucHanh"]))?0.0m:(System.Decimal?)reader["SoTietThucHanh"];
					entity.HeSoQuyDoiThucHanh = reader.IsDBNull(reader.GetOrdinal("HeSoQuyDoiThucHanh")) ? null : (System.Decimal?)reader["HeSoQuyDoiThucHanh"];
					//entity.HeSoQuyDoiThucHanh = (Convert.IsDBNull(reader["HeSoQuyDoiThucHanh"]))?0.0m:(System.Decimal?)reader["HeSoQuyDoiThucHanh"];
					entity.SoNhomThucHanh = reader.IsDBNull(reader.GetOrdinal("SoNhomThucHanh")) ? null : (System.Int32?)reader["SoNhomThucHanh"];
					//entity.SoNhomThucHanh = (Convert.IsDBNull(reader["SoNhomThucHanh"]))?(int)0:(System.Int32?)reader["SoNhomThucHanh"];
					entity.TongSoTiet = reader.IsDBNull(reader.GetOrdinal("TongSoTiet")) ? null : (System.Decimal?)reader["TongSoTiet"];
					//entity.TongSoTiet = (Convert.IsDBNull(reader["TongSoTiet"]))?0.0m:(System.Decimal?)reader["TongSoTiet"];
					entity.SoTietLyThuyetTrenTuan = reader.IsDBNull(reader.GetOrdinal("SoTietLyThuyetTrenTuan")) ? null : (System.Decimal?)reader["SoTietLyThuyetTrenTuan"];
					//entity.SoTietLyThuyetTrenTuan = (Convert.IsDBNull(reader["SoTietLyThuyetTrenTuan"]))?0.0m:(System.Decimal?)reader["SoTietLyThuyetTrenTuan"];
					entity.SoTietThucHanhTrenTuan = reader.IsDBNull(reader.GetOrdinal("SoTietThucHanhTrenTuan")) ? null : (System.Decimal?)reader["SoTietThucHanhTrenTuan"];
					//entity.SoTietThucHanhTrenTuan = (Convert.IsDBNull(reader["SoTietThucHanhTrenTuan"]))?0.0m:(System.Decimal?)reader["SoTietThucHanhTrenTuan"];
					entity.TongSoTietTrenTuan = reader.IsDBNull(reader.GetOrdinal("TongSoTietTrenTuan")) ? null : (System.Decimal?)reader["TongSoTietTrenTuan"];
					//entity.TongSoTietTrenTuan = (Convert.IsDBNull(reader["TongSoTietTrenTuan"]))?0.0m:(System.Decimal?)reader["TongSoTietTrenTuan"];
					entity.HeSoLopDong = reader.IsDBNull(reader.GetOrdinal("HeSoLopDong")) ? null : (System.Decimal?)reader["HeSoLopDong"];
					//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
					entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Int32?)reader["SiSo"];
					//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
					entity.TrangThaiHoSo = reader.IsDBNull(reader.GetOrdinal("TrangThaiHoSo")) ? null : (System.String)reader["TrangThaiHoSo"];
					//entity.TrangThaiHoSo = (Convert.IsDBNull(reader["TrangThaiHoSo"]))?string.Empty:(System.String)reader["TrangThaiHoSo"];
					entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
					entity.DonViTienTe = reader.IsDBNull(reader.GetOrdinal("DonViTienTe")) ? null : (System.String)reader["DonViTienTe"];
					//entity.DonViTienTe = (Convert.IsDBNull(reader["DonViTienTe"]))?string.Empty:(System.String)reader["DonViTienTe"];
					entity.TongGiaTriHopDong = reader.IsDBNull(reader.GetOrdinal("TongGiaTriHopDong")) ? null : (System.Decimal?)reader["TongGiaTriHopDong"];
					//entity.TongGiaTriHopDong = (Convert.IsDBNull(reader["TongGiaTriHopDong"]))?0.0m:(System.Decimal?)reader["TongGiaTriHopDong"];
					entity.GiaTriHopDongConLai = reader.IsDBNull(reader.GetOrdinal("GiaTriHopDongConLai")) ? null : (System.Decimal?)reader["GiaTriHopDongConLai"];
					//entity.GiaTriHopDongConLai = (Convert.IsDBNull(reader["GiaTriHopDongConLai"]))?0.0m:(System.Decimal?)reader["GiaTriHopDongConLai"];
					entity.Thue = reader.IsDBNull(reader.GetOrdinal("Thue")) ? null : (System.Decimal?)reader["Thue"];
					//entity.Thue = (Convert.IsDBNull(reader["Thue"]))?0.0m:(System.Decimal?)reader["Thue"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
					entity.DaXacNhan = reader.IsDBNull(reader.GetOrdinal("DaXacNhan")) ? null : (System.Boolean?)reader["DaXacNhan"];
					//entity.DaXacNhan = (Convert.IsDBNull(reader["DaXacNhan"]))?false:(System.Boolean?)reader["DaXacNhan"];
					entity.IsLock = reader.IsDBNull(reader.GetOrdinal("IsLock")) ? null : (System.Boolean?)reader["IsLock"];
					//entity.IsLock = (Convert.IsDBNull(reader["IsLock"]))?false:(System.Boolean?)reader["IsLock"];
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
		/// Refreshes the <see cref="ViewDanhSachHopDongThinhGiang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewDanhSachHopDongThinhGiang"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewDanhSachHopDongThinhGiang entity)
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
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? null : (System.String)reader["NgaySinh"];
			//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
			entity.SoCmnd = reader.IsDBNull(reader.GetOrdinal("SoCmnd")) ? null : (System.String)reader["SoCmnd"];
			//entity.SoCmnd = (Convert.IsDBNull(reader["SoCmnd"]))?string.Empty:(System.String)reader["SoCmnd"];
			entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
			//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
			entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
			//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
			entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
			//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
			entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
			//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
			entity.ChuyenNganh = reader.IsDBNull(reader.GetOrdinal("ChuyenNganh")) ? null : (System.String)reader["ChuyenNganh"];
			//entity.ChuyenNganh = (Convert.IsDBNull(reader["ChuyenNganh"]))?string.Empty:(System.String)reader["ChuyenNganh"];
			entity.MaSoThue = reader.IsDBNull(reader.GetOrdinal("MaSoThue")) ? null : (System.String)reader["MaSoThue"];
			//entity.MaSoThue = (Convert.IsDBNull(reader["MaSoThue"]))?string.Empty:(System.String)reader["MaSoThue"];
			entity.CoQuanCongTac = reader.IsDBNull(reader.GetOrdinal("CoQuanCongTac")) ? null : (System.String)reader["CoQuanCongTac"];
			//entity.CoQuanCongTac = (Convert.IsDBNull(reader["CoQuanCongTac"]))?string.Empty:(System.String)reader["CoQuanCongTac"];
			entity.MaMonHoc = reader.IsDBNull(reader.GetOrdinal("MaMonHoc")) ? null : (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.SoHopDong = reader.IsDBNull(reader.GetOrdinal("SoHopDong")) ? null : (System.String)reader["SoHopDong"];
			//entity.SoHopDong = (Convert.IsDBNull(reader["SoHopDong"]))?string.Empty:(System.String)reader["SoHopDong"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.TenDonVi = (System.String)reader["TenDonVi"];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.NgayBatDau = reader.IsDBNull(reader.GetOrdinal("NgayBatDau")) ? null : (System.DateTime?)reader["NgayBatDau"];
			//entity.NgayBatDau = (Convert.IsDBNull(reader["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)reader["NgayBatDau"];
			entity.NgayKetThuc = reader.IsDBNull(reader.GetOrdinal("NgayKetThuc")) ? null : (System.DateTime?)reader["NgayKetThuc"];
			//entity.NgayKetThuc = (Convert.IsDBNull(reader["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)reader["NgayKetThuc"];
			entity.SoTietLyThuyet = reader.IsDBNull(reader.GetOrdinal("SoTietLyThuyet")) ? null : (System.Decimal?)reader["SoTietLyThuyet"];
			//entity.SoTietLyThuyet = (Convert.IsDBNull(reader["SoTietLyThuyet"]))?0.0m:(System.Decimal?)reader["SoTietLyThuyet"];
			entity.SoTietThucHanh = reader.IsDBNull(reader.GetOrdinal("SoTietThucHanh")) ? null : (System.Decimal?)reader["SoTietThucHanh"];
			//entity.SoTietThucHanh = (Convert.IsDBNull(reader["SoTietThucHanh"]))?0.0m:(System.Decimal?)reader["SoTietThucHanh"];
			entity.HeSoQuyDoiThucHanh = reader.IsDBNull(reader.GetOrdinal("HeSoQuyDoiThucHanh")) ? null : (System.Decimal?)reader["HeSoQuyDoiThucHanh"];
			//entity.HeSoQuyDoiThucHanh = (Convert.IsDBNull(reader["HeSoQuyDoiThucHanh"]))?0.0m:(System.Decimal?)reader["HeSoQuyDoiThucHanh"];
			entity.SoNhomThucHanh = reader.IsDBNull(reader.GetOrdinal("SoNhomThucHanh")) ? null : (System.Int32?)reader["SoNhomThucHanh"];
			//entity.SoNhomThucHanh = (Convert.IsDBNull(reader["SoNhomThucHanh"]))?(int)0:(System.Int32?)reader["SoNhomThucHanh"];
			entity.TongSoTiet = reader.IsDBNull(reader.GetOrdinal("TongSoTiet")) ? null : (System.Decimal?)reader["TongSoTiet"];
			//entity.TongSoTiet = (Convert.IsDBNull(reader["TongSoTiet"]))?0.0m:(System.Decimal?)reader["TongSoTiet"];
			entity.SoTietLyThuyetTrenTuan = reader.IsDBNull(reader.GetOrdinal("SoTietLyThuyetTrenTuan")) ? null : (System.Decimal?)reader["SoTietLyThuyetTrenTuan"];
			//entity.SoTietLyThuyetTrenTuan = (Convert.IsDBNull(reader["SoTietLyThuyetTrenTuan"]))?0.0m:(System.Decimal?)reader["SoTietLyThuyetTrenTuan"];
			entity.SoTietThucHanhTrenTuan = reader.IsDBNull(reader.GetOrdinal("SoTietThucHanhTrenTuan")) ? null : (System.Decimal?)reader["SoTietThucHanhTrenTuan"];
			//entity.SoTietThucHanhTrenTuan = (Convert.IsDBNull(reader["SoTietThucHanhTrenTuan"]))?0.0m:(System.Decimal?)reader["SoTietThucHanhTrenTuan"];
			entity.TongSoTietTrenTuan = reader.IsDBNull(reader.GetOrdinal("TongSoTietTrenTuan")) ? null : (System.Decimal?)reader["TongSoTietTrenTuan"];
			//entity.TongSoTietTrenTuan = (Convert.IsDBNull(reader["TongSoTietTrenTuan"]))?0.0m:(System.Decimal?)reader["TongSoTietTrenTuan"];
			entity.HeSoLopDong = reader.IsDBNull(reader.GetOrdinal("HeSoLopDong")) ? null : (System.Decimal?)reader["HeSoLopDong"];
			//entity.HeSoLopDong = (Convert.IsDBNull(reader["HeSoLopDong"]))?0.0m:(System.Decimal?)reader["HeSoLopDong"];
			entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Int32?)reader["SiSo"];
			//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
			entity.TrangThaiHoSo = reader.IsDBNull(reader.GetOrdinal("TrangThaiHoSo")) ? null : (System.String)reader["TrangThaiHoSo"];
			//entity.TrangThaiHoSo = (Convert.IsDBNull(reader["TrangThaiHoSo"]))?string.Empty:(System.String)reader["TrangThaiHoSo"];
			entity.DonGia = reader.IsDBNull(reader.GetOrdinal("DonGia")) ? null : (System.Decimal?)reader["DonGia"];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal?)reader["DonGia"];
			entity.DonViTienTe = reader.IsDBNull(reader.GetOrdinal("DonViTienTe")) ? null : (System.String)reader["DonViTienTe"];
			//entity.DonViTienTe = (Convert.IsDBNull(reader["DonViTienTe"]))?string.Empty:(System.String)reader["DonViTienTe"];
			entity.TongGiaTriHopDong = reader.IsDBNull(reader.GetOrdinal("TongGiaTriHopDong")) ? null : (System.Decimal?)reader["TongGiaTriHopDong"];
			//entity.TongGiaTriHopDong = (Convert.IsDBNull(reader["TongGiaTriHopDong"]))?0.0m:(System.Decimal?)reader["TongGiaTriHopDong"];
			entity.GiaTriHopDongConLai = reader.IsDBNull(reader.GetOrdinal("GiaTriHopDongConLai")) ? null : (System.Decimal?)reader["GiaTriHopDongConLai"];
			//entity.GiaTriHopDongConLai = (Convert.IsDBNull(reader["GiaTriHopDongConLai"]))?0.0m:(System.Decimal?)reader["GiaTriHopDongConLai"];
			entity.Thue = reader.IsDBNull(reader.GetOrdinal("Thue")) ? null : (System.Decimal?)reader["Thue"];
			//entity.Thue = (Convert.IsDBNull(reader["Thue"]))?0.0m:(System.Decimal?)reader["Thue"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
			entity.DaXacNhan = reader.IsDBNull(reader.GetOrdinal("DaXacNhan")) ? null : (System.Boolean?)reader["DaXacNhan"];
			//entity.DaXacNhan = (Convert.IsDBNull(reader["DaXacNhan"]))?false:(System.Boolean?)reader["DaXacNhan"];
			entity.IsLock = reader.IsDBNull(reader.GetOrdinal("IsLock")) ? null : (System.Boolean?)reader["IsLock"];
			//entity.IsLock = (Convert.IsDBNull(reader["IsLock"]))?false:(System.Boolean?)reader["IsLock"];
			entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
			entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
			//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewDanhSachHopDongThinhGiang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewDanhSachHopDongThinhGiang"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewDanhSachHopDongThinhGiang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (Convert.IsDBNull(dataRow["Id"]))?(int)0:(System.Int32)dataRow["Id"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32?)dataRow["MaGiangVien"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.NgaySinh = (Convert.IsDBNull(dataRow["NgaySinh"]))?string.Empty:(System.String)dataRow["NgaySinh"];
			entity.SoCmnd = (Convert.IsDBNull(dataRow["SoCmnd"]))?string.Empty:(System.String)dataRow["SoCmnd"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?(int)0:(System.Int32?)dataRow["MaHocHam"];
			entity.TenHocHam = (Convert.IsDBNull(dataRow["TenHocHam"]))?string.Empty:(System.String)dataRow["TenHocHam"];
			entity.MaHocVi = (Convert.IsDBNull(dataRow["MaHocVi"]))?(int)0:(System.Int32?)dataRow["MaHocVi"];
			entity.TenHocVi = (Convert.IsDBNull(dataRow["TenHocVi"]))?string.Empty:(System.String)dataRow["TenHocVi"];
			entity.ChuyenNganh = (Convert.IsDBNull(dataRow["ChuyenNganh"]))?string.Empty:(System.String)dataRow["ChuyenNganh"];
			entity.MaSoThue = (Convert.IsDBNull(dataRow["MaSoThue"]))?string.Empty:(System.String)dataRow["MaSoThue"];
			entity.CoQuanCongTac = (Convert.IsDBNull(dataRow["CoQuanCongTac"]))?string.Empty:(System.String)dataRow["CoQuanCongTac"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.SoHopDong = (Convert.IsDBNull(dataRow["SoHopDong"]))?string.Empty:(System.String)dataRow["SoHopDong"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.NgayBatDau = (Convert.IsDBNull(dataRow["NgayBatDau"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayBatDau"];
			entity.NgayKetThuc = (Convert.IsDBNull(dataRow["NgayKetThuc"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayKetThuc"];
			entity.SoTietLyThuyet = (Convert.IsDBNull(dataRow["SoTietLyThuyet"]))?0.0m:(System.Decimal?)dataRow["SoTietLyThuyet"];
			entity.SoTietThucHanh = (Convert.IsDBNull(dataRow["SoTietThucHanh"]))?0.0m:(System.Decimal?)dataRow["SoTietThucHanh"];
			entity.HeSoQuyDoiThucHanh = (Convert.IsDBNull(dataRow["HeSoQuyDoiThucHanh"]))?0.0m:(System.Decimal?)dataRow["HeSoQuyDoiThucHanh"];
			entity.SoNhomThucHanh = (Convert.IsDBNull(dataRow["SoNhomThucHanh"]))?(int)0:(System.Int32?)dataRow["SoNhomThucHanh"];
			entity.TongSoTiet = (Convert.IsDBNull(dataRow["TongSoTiet"]))?0.0m:(System.Decimal?)dataRow["TongSoTiet"];
			entity.SoTietLyThuyetTrenTuan = (Convert.IsDBNull(dataRow["SoTietLyThuyetTrenTuan"]))?0.0m:(System.Decimal?)dataRow["SoTietLyThuyetTrenTuan"];
			entity.SoTietThucHanhTrenTuan = (Convert.IsDBNull(dataRow["SoTietThucHanhTrenTuan"]))?0.0m:(System.Decimal?)dataRow["SoTietThucHanhTrenTuan"];
			entity.TongSoTietTrenTuan = (Convert.IsDBNull(dataRow["TongSoTietTrenTuan"]))?0.0m:(System.Decimal?)dataRow["TongSoTietTrenTuan"];
			entity.HeSoLopDong = (Convert.IsDBNull(dataRow["HeSoLopDong"]))?0.0m:(System.Decimal?)dataRow["HeSoLopDong"];
			entity.SiSo = (Convert.IsDBNull(dataRow["SiSo"]))?(int)0:(System.Int32?)dataRow["SiSo"];
			entity.TrangThaiHoSo = (Convert.IsDBNull(dataRow["TrangThaiHoSo"]))?string.Empty:(System.String)dataRow["TrangThaiHoSo"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal?)dataRow["DonGia"];
			entity.DonViTienTe = (Convert.IsDBNull(dataRow["DonViTienTe"]))?string.Empty:(System.String)dataRow["DonViTienTe"];
			entity.TongGiaTriHopDong = (Convert.IsDBNull(dataRow["TongGiaTriHopDong"]))?0.0m:(System.Decimal?)dataRow["TongGiaTriHopDong"];
			entity.GiaTriHopDongConLai = (Convert.IsDBNull(dataRow["GiaTriHopDongConLai"]))?0.0m:(System.Decimal?)dataRow["GiaTriHopDongConLai"];
			entity.Thue = (Convert.IsDBNull(dataRow["Thue"]))?0.0m:(System.Decimal?)dataRow["Thue"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?string.Empty:(System.String)dataRow["GhiChu"];
			entity.DaXacNhan = (Convert.IsDBNull(dataRow["DaXacNhan"]))?false:(System.Boolean?)dataRow["DaXacNhan"];
			entity.IsLock = (Convert.IsDBNull(dataRow["IsLock"]))?false:(System.Boolean?)dataRow["IsLock"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?string.Empty:(System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = (Convert.IsDBNull(dataRow["NguoiCapNhat"]))?string.Empty:(System.String)dataRow["NguoiCapNhat"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewDanhSachHopDongThinhGiangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanhSachHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDanhSachHopDongThinhGiangFilterBuilder : SqlFilterBuilder<ViewDanhSachHopDongThinhGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachHopDongThinhGiangFilterBuilder class.
		/// </summary>
		public ViewDanhSachHopDongThinhGiangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachHopDongThinhGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewDanhSachHopDongThinhGiangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachHopDongThinhGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewDanhSachHopDongThinhGiangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewDanhSachHopDongThinhGiangFilterBuilder

	#region ViewDanhSachHopDongThinhGiangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanhSachHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDanhSachHopDongThinhGiangParameterBuilder : ParameterizedSqlFilterBuilder<ViewDanhSachHopDongThinhGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachHopDongThinhGiangParameterBuilder class.
		/// </summary>
		public ViewDanhSachHopDongThinhGiangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachHopDongThinhGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewDanhSachHopDongThinhGiangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachHopDongThinhGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewDanhSachHopDongThinhGiangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewDanhSachHopDongThinhGiangParameterBuilder
	
	#region ViewDanhSachHopDongThinhGiangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanhSachHopDongThinhGiang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewDanhSachHopDongThinhGiangSortBuilder : SqlSortBuilder<ViewDanhSachHopDongThinhGiangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachHopDongThinhGiangSqlSortBuilder class.
		/// </summary>
		public ViewDanhSachHopDongThinhGiangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewDanhSachHopDongThinhGiangSortBuilder

} // end namespace
