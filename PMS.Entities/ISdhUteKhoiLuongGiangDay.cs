﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'SdhUte_KhoiLuongGiangDay' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISdhUteKhoiLuongGiangDay 
	{
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SdhUte_KhoiLuongGiangDay"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		System.String  MaMonHoc  { get; set; }
		
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		System.String  TenMonHoc  { get; set; }
		
		/// <summary>
		/// NhomMonHoc : 
		/// </summary>
		System.String  NhomMonHoc  { get; set; }
		
		/// <summary>
		/// MaHocPhan : 
		/// </summary>
		System.String  MaHocPhan  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		System.String  HocKy  { get; set; }
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		System.String  MaLopHocPhan  { get; set; }
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		System.String  MaLop  { get; set; }
		
		/// <summary>
		/// MaGiangVienQuanLy : 
		/// </summary>
		System.String  MaGiangVienQuanLy  { get; set; }
		
		/// <summary>
		/// SoTinChi : 
		/// </summary>
		System.Int32?  SoTinChi  { get; set; }
		
		/// <summary>
		/// SiSo : 
		/// </summary>
		System.Int32?  SiSo  { get; set; }
		
		/// <summary>
		/// LopClc : 
		/// </summary>
		System.Boolean?  LopClc  { get; set; }
		
		/// <summary>
		/// SoTietDayChuNhat : 
		/// </summary>
		System.Int32?  SoTietDayChuNhat  { get; set; }
		
		/// <summary>
		/// SoTiet : 
		/// </summary>
		System.Decimal?  SoTiet  { get; set; }
		
		/// <summary>
		/// MaLoaiHocPhan : 
		/// </summary>
		System.Int32?  MaLoaiHocPhan  { get; set; }
		
		/// <summary>
		/// MaLoaiGiangVien : 
		/// </summary>
		System.Int32?  MaLoaiGiangVien  { get; set; }
		
		/// <summary>
		/// MaHocHam : 
		/// </summary>
		System.Int32?  MaHocHam  { get; set; }
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		System.DateTime?  NgayCapNhat  { get; set; }
		
		/// <summary>
		/// MaHocVi : 
		/// </summary>
		System.Int32?  MaHocVi  { get; set; }
		
		/// <summary>
		/// Nhom : 
		/// </summary>
		System.String  Nhom  { get; set; }
		
		/// <summary>
		/// MaLoaiHocPhanGanMoi : 
		/// </summary>
		System.String  MaLoaiHocPhanGanMoi  { get; set; }
		
		/// <summary>
		/// MaDiaDiem : 
		/// </summary>
		System.String  MaDiaDiem  { get; set; }
		
		/// <summary>
		/// MaDot : 
		/// </summary>
		System.String  MaDot  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _sdhUteKhoiLuongQuyDoiIdKhoiLuongGiangDay
		/// </summary>	
		TList<SdhUteKhoiLuongQuyDoi> SdhUteKhoiLuongQuyDoiCollection {  get;  set;}	

		#endregion Data Properties

	}
}


