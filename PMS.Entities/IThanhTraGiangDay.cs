﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'ThanhTraGiangDay' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IThanhTraGiangDay 
	{
		/// <summary>			
		/// MaHoSoThanhTra : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ThanhTraGiangDay"</remarks>
		System.Int32 MaHoSoThanhTra { get; set; }
				
		
		
		/// <summary>
		/// MaHienThi : 
		/// </summary>
		System.String  MaHienThi  { get; set; }
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
		
		/// <summary>
		/// Khoa : 
		/// </summary>
		System.String  Khoa  { get; set; }
		
		/// <summary>
		/// LoaiGiangVien : 
		/// </summary>
		System.String  LoaiGiangVien  { get; set; }
		
		/// <summary>
		/// TenHocPhan : 
		/// </summary>
		System.String  TenHocPhan  { get; set; }
		
		/// <summary>
		/// TinhHinhGhiNhan : 
		/// </summary>
		System.String  TinhHinhGhiNhan  { get; set; }
		
		/// <summary>
		/// Ngay : 
		/// </summary>
		System.DateTime?  Ngay  { get; set; }
		
		/// <summary>
		/// Tiet : 
		/// </summary>
		System.String  Tiet  { get; set; }
		
		/// <summary>
		/// Lop : 
		/// </summary>
		System.String  Lop  { get; set; }
		
		/// <summary>
		/// Phong : 
		/// </summary>
		System.String  Phong  { get; set; }
		
		/// <summary>
		/// ThoiDiemGhiNhan : 
		/// </summary>
		System.String  ThoiDiemGhiNhan  { get; set; }
		
		/// <summary>
		/// LyDo : 
		/// </summary>
		System.String  LyDo  { get; set; }
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		System.String  GhiChu  { get; set; }
		
		/// <summary>
		/// MaHinhThucViPham : 
		/// </summary>
		System.Guid?  MaHinhThucViPham  { get; set; }
		
		/// <summary>
		/// DaBaoSuaTkb : 
		/// </summary>
		System.Boolean?  DaBaoSuaTkb  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


