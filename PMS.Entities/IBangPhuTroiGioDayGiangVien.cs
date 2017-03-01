﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'BangPhuTroiGioDay_GiangVien' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IBangPhuTroiGioDayGiangVien 
	{
		/// <summary>			
		/// MaGiangVien : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "BangPhuTroiGioDay_GiangVien"</remarks>
		System.Int32 MaGiangVien { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalMaGiangVien { get; set; }
			
		
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
		
		/// <summary>
		/// Ho : 
		/// </summary>
		System.String  Ho  { get; set; }
		
		/// <summary>
		/// Ten : 
		/// </summary>
		System.String  Ten  { get; set; }
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		System.String  NamHoc  { get; set; }
		
		/// <summary>
		/// MaDonVi : 
		/// </summary>
		System.String  MaDonVi  { get; set; }
		
		/// <summary>
		/// TenDonVi : 
		/// </summary>
		System.String  TenDonVi  { get; set; }
		
		/// <summary>
		/// MaLoaiGiangVien : 
		/// </summary>
		System.Int32  MaLoaiGiangVien  { get; set; }
		
		/// <summary>
		/// TenLoaiGiangVien : 
		/// </summary>
		System.String  TenLoaiGiangVien  { get; set; }
		
		/// <summary>
		/// TCThucDay : 
		/// </summary>
		System.Decimal?  TcThucDay  { get; set; }
		
		/// <summary>
		/// TietQD : 
		/// </summary>
		System.Decimal?  TietQd  { get; set; }
		
		/// <summary>
		/// NhiemVuGD : 
		/// </summary>
		System.Int32?  NhiemVuGd  { get; set; }
		
		/// <summary>
		/// NhiemVuNCKH : 
		/// </summary>
		System.Int32?  NhiemVuNckh  { get; set; }
		
		/// <summary>
		/// PhanCongCN : 
		/// </summary>
		System.Int32?  PhanCongCn  { get; set; }
		
		/// <summary>
		/// CongTrinhCD : 
		/// </summary>
		System.Int32?  CongTrinhCd  { get; set; }
		
		/// <summary>
		/// CongTrinhTC : 
		/// </summary>
		System.Int32?  CongTrinhTc  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

