﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'HoSo' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IHoSo 
	{
		/// <summary>			
		/// MaHoSo : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "HoSo"</remarks>
		System.Int32 MaHoSo { get; set; }
				
		
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
		
		/// <summary>
		/// TenHoSo : 
		/// </summary>
		System.String  TenHoSo  { get; set; }
		
		/// <summary>
		/// ThuTu : 
		/// </summary>
		System.Int32?  ThuTu  { get; set; }
		
		/// <summary>
		/// TrangThai : 
		/// </summary>
		System.Boolean?  TrangThai  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _giangVienHoSoMaHoSo
		/// </summary>	
		TList<GiangVienHoSo> GiangVienHoSoCollection {  get;  set;}	

		
		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the junction table maGiangVienGiangVienCollectionFromGiangVienHoSo
		/// </summary>	
		TList<GiangVien> MaGiangVienGiangVienCollection_From_GiangVienHoSo { get; set; }	

		#endregion Data Properties

	}
}


