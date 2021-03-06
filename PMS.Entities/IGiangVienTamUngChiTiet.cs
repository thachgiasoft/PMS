﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'GiangVienTamUngChiTiet' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGiangVienTamUngChiTiet 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GiangVienTamUngChiTiet"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		System.Int32?  MaGiangVien  { get; set; }
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		System.String  MaLopHocPhan  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		System.String  MaMonHoc  { get; set; }
		
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		System.String  TenMonHoc  { get; set; }
		
		/// <summary>
		/// Nhom : 
		/// </summary>
		System.String  Nhom  { get; set; }
		
		/// <summary>
		/// SoTinChi : 
		/// </summary>
		System.Decimal?  SoTinChi  { get; set; }
		
		/// <summary>
		/// SiSo : 
		/// </summary>
		System.Int32?  SiSo  { get; set; }
		
		/// <summary>
		/// MaLoaiHocPhan : 
		/// </summary>
		System.Byte?  MaLoaiHocPhan  { get; set; }
		
		/// <summary>
		/// LoaiHocPhan : 
		/// </summary>
		System.String  LoaiHocPhan  { get; set; }
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		System.String  MaLop  { get; set; }
		
		/// <summary>
		/// SoTietThucDay : 
		/// </summary>
		System.Decimal?  SoTietThucDay  { get; set; }
		
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		System.String  MaBacDaoTao  { get; set; }
		
		/// <summary>
		/// MaKhoa : 
		/// </summary>
		System.String  MaKhoa  { get; set; }
		
		/// <summary>
		/// MaNhomMonHoc : 
		/// </summary>
		System.String  MaNhomMonHoc  { get; set; }
		
		/// <summary>
		/// MaKhoaHoc : 
		/// </summary>
		System.String  MaKhoaHoc  { get; set; }
		
		/// <summary>
		/// MaHocHam : 
		/// </summary>
		System.Int32?  MaHocHam  { get; set; }
		
		/// <summary>
		/// MaHocVi : 
		/// </summary>
		System.Int32?  MaHocVi  { get; set; }
		
		/// <summary>
		/// MaLoaiGiangVien : 
		/// </summary>
		System.Int32?  MaLoaiGiangVien  { get; set; }
		
		/// <summary>
		/// MaChucVu : 
		/// </summary>
		System.Int32?  MaChucVu  { get; set; }
		
		/// <summary>
		/// MaHinhThucDaoTao : 
		/// </summary>
		System.String  MaHinhThucDaoTao  { get; set; }
		
		/// <summary>
		/// LopHocPhanChuyenNganh : 
		/// </summary>
		System.Boolean?  LopHocPhanChuyenNganh  { get; set; }
		
		/// <summary>
		/// DaoTaoTinChi : 
		/// </summary>
		System.Boolean?  DaoTaoTinChi  { get; set; }
		
		/// <summary>
		/// HeSoCongViec : 
		/// </summary>
		System.Decimal?  HeSoCongViec  { get; set; }
		
		/// <summary>
		/// HeSoBacDaoTao : 
		/// </summary>
		System.Decimal?  HeSoBacDaoTao  { get; set; }
		
		/// <summary>
		/// HeSoNgonNgu : 
		/// </summary>
		System.Decimal?  HeSoNgonNgu  { get; set; }
		
		/// <summary>
		/// HeSoChucDanhChuyenMon : 
		/// </summary>
		System.Decimal?  HeSoChucDanhChuyenMon  { get; set; }
		
		/// <summary>
		/// HeSoLopDong : 
		/// </summary>
		System.Decimal?  HeSoLopDong  { get; set; }
		
		/// <summary>
		/// HeSoCoSo : 
		/// </summary>
		System.Decimal?  HeSoCoSo  { get; set; }
		
		/// <summary>
		/// HeSoNienCheTinChi : 
		/// </summary>
		System.Decimal?  HeSoNienCheTinChi  { get; set; }
		
		/// <summary>
		/// SoTietThucTeQuyDoi : 
		/// </summary>
		System.Decimal?  SoTietThucTeQuyDoi  { get; set; }
		
		/// <summary>
		/// TietQuyDoi : 
		/// </summary>
		System.Decimal?  TietQuyDoi  { get; set; }
		
		/// <summary>
		/// HeSoQuyDoiThucHanhSangLyThuyet : 
		/// </summary>
		System.Decimal?  HeSoQuyDoiThucHanhSangLyThuyet  { get; set; }
		
		/// <summary>
		/// HeSoNgoaiGio : 
		/// </summary>
		System.Decimal?  HeSoNgoaiGio  { get; set; }
		
		/// <summary>
		/// LoaiLop : 
		/// </summary>
		System.String  LoaiLop  { get; set; }
		
		/// <summary>
		/// HeSoClcCntn : 
		/// </summary>
		System.Decimal?  HeSoClcCntn  { get; set; }
		
		/// <summary>
		/// HeSoThinhGiangMonChuyenNganh : 
		/// </summary>
		System.Decimal?  HeSoThinhGiangMonChuyenNganh  { get; set; }
		
		/// <summary>
		/// NgonNguGiangDay : 
		/// </summary>
		System.String  NgonNguGiangDay  { get; set; }
		
		/// <summary>
		/// HeSoTroCap : 
		/// </summary>
		System.Decimal?  HeSoTroCap  { get; set; }
		
		/// <summary>
		/// HeSoLuong : 
		/// </summary>
		System.Decimal?  HeSoLuong  { get; set; }
		
		/// <summary>
		/// HeSoMonMoi : 
		/// </summary>
		System.Decimal?  HeSoMonMoi  { get; set; }
		
		/// <summary>
		/// DonGia : 
		/// </summary>
		System.Decimal?  DonGia  { get; set; }
		
		/// <summary>
		/// ThanhTien : 
		/// </summary>
		System.Decimal?  ThanhTien  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
		
		/// <summary>
		/// MucThanhToan : 
		/// </summary>
		System.Decimal?  MucThanhToan  { get; set; }
		
		/// <summary>
		/// NgayTamUng : 
		/// </summary>
		System.DateTime?  NgayTamUng  { get; set; }
		
		/// <summary>
		/// DotTamUng : 
		/// </summary>
		System.String  DotTamUng  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


