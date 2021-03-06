﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'BangPhuTroiNamHoc' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IBangPhuTroiNamHoc 
	{
		/// <summary>			
		/// MaGiangVien : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "BangPhuTroiNamHoc"</remarks>
		System.Int32 MaGiangVien { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalMaGiangVien { get; set; }
			
		/// <summary>			
		/// NamHoc : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "BangPhuTroiNamHoc"</remarks>
		System.String NamHoc { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalNamHoc { get; set; }
			
		
		
		/// <summary>
		/// SoTietNCKH_TrungCap : 
		/// </summary>
		System.Decimal?  SoTietNckhTrungCap  { get; set; }
		
		/// <summary>
		/// SoTietNCKH_CaoDang : 
		/// </summary>
		System.Decimal?  SoTietNckhCaoDang  { get; set; }
		
		/// <summary>
		/// GioThiHK1 : 
		/// </summary>
		System.Decimal?  GioThiHk1  { get; set; }
		
		/// <summary>
		/// GioThiHK2 : 
		/// </summary>
		System.Decimal?  GioThiHk2  { get; set; }
		
		/// <summary>
		/// TietQuyDoiHuongDanGvTinhNguyen : 
		/// </summary>
		System.Decimal?  TietQuyDoiHuongDanGvTinhNguyen  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


