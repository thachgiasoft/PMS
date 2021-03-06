﻿using System;
using System.ComponentModel;

namespace PMS.Entities
{
	/// <summary>
	///		The data structure representation of the 'HocVi' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IHocVi 
	{
		/// <summary>			
		/// MaHocVi : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "HocVi"</remarks>
		System.Int32 MaHocVi { get; set; }
				
		
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		System.String  MaQuanLy  { get; set; }
		
		/// <summary>
		/// TenHocVi : 
		/// </summary>
		System.String  TenHocVi  { get; set; }
		
		/// <summary>
		/// ThuTu : 
		/// </summary>
		System.Int32?  ThuTu  { get; set; }
		
		/// <summary>
		/// HRMID : 
		/// </summary>
		System.Guid?  Hrmid  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _heSoChucDanhTietNghiaVuMaHocVi
		/// </summary>	
		TList<HeSoChucDanhTietNghiaVu> HeSoChucDanhTietNghiaVuCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _donGiaMaHocVi
		/// </summary>	
		TList<DonGia> DonGiaCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _quyDinhTienCanTrenMaHocVi
		/// </summary>	
		TList<QuyDinhTienCanTren> QuyDinhTienCanTrenCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _giangVienMaHocVi
		/// </summary>	
		TList<GiangVien> GiangVienCollection {  get;  set;}	

		#endregion Data Properties

	}
}


