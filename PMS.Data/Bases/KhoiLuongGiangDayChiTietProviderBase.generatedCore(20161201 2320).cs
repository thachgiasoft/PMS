#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="KhoiLuongGiangDayChiTietProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KhoiLuongGiangDayChiTietProviderBaseCore : EntityProviderBase<PMS.Entities.KhoiLuongGiangDayChiTiet, PMS.Entities.KhoiLuongGiangDayChiTietKey>
	{		
		#region Get from Many To Many Relationship Functions
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayChiTietKey key)
		{
			return Delete(transactionManager, key.MaKhoiLuong);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maKhoiLuong">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maKhoiLuong)
		{
			return Delete(null, _maKhoiLuong);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maKhoiLuong);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
		#endregion

		#region Get By Index Functions
		
		/// <summary>
		/// 	Gets a row from the DataSource based on its primary key.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public override PMS.Entities.KhoiLuongGiangDayChiTiet Get(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayChiTietKey key, int start, int pageLength)
		{
			return GetByMaKhoiLuong(transactionManager, key.MaKhoiLuong, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KhoiLuongGiangDayChiTiet index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayChiTiet"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayChiTiet GetByMaKhoiLuong(System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(null,_maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayChiTiet index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayChiTiet"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayChiTiet GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayChiTiet"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayChiTiet GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayChiTiet"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayChiTiet GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayChiTiet index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayChiTiet"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayChiTiet GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength, out int count)
		{
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayChiTiet"/> class.</returns>
		public abstract PMS.Entities.KhoiLuongGiangDayChiTiet GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KhoiLuongGiangDayChiTiet_DongBoDuLieu 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_DongBoDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoDuLieu(System.String namHoc, System.String hocKy)
		{
			 DongBoDuLieu(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_DongBoDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoDuLieu(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 DongBoDuLieu(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_DongBoDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoDuLieu(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 DongBoDuLieu(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_DongBoDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBoDuLieu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_LuuSoLuongThucTapTotNghiep 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_LuuSoLuongThucTapTotNghiep' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuSoLuongThucTapTotNghiep(System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 LuuSoLuongThucTapTotNghiep(null, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_LuuSoLuongThucTapTotNghiep' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuSoLuongThucTapTotNghiep(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 LuuSoLuongThucTapTotNghiep(null, start, pageLength , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_LuuSoLuongThucTapTotNghiep' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuSoLuongThucTapTotNghiep(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 LuuSoLuongThucTapTotNghiep(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_LuuSoLuongThucTapTotNghiep' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuSoLuongThucTapTotNghiep(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetByXmlData 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByXmlData' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByXmlData(System.String xmlData, System.String namHoc, System.String hocKy)
		{
			return GetByXmlData(null, 0, int.MaxValue , xmlData, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByXmlData' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByXmlData(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy)
		{
			return GetByXmlData(null, start, pageLength , xmlData, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByXmlData' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByXmlData(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy)
		{
			return GetByXmlData(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByXmlData' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDayChiTiet> GetByXmlData(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetGiangVienSoTiet 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetGiangVienSoTiet' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetGiangVienSoTiet(System.String maLopHocPhan)
		{
			return GetGiangVienSoTiet(null, 0, int.MaxValue , maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetGiangVienSoTiet' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetGiangVienSoTiet(int start, int pageLength, System.String maLopHocPhan)
		{
			return GetGiangVienSoTiet(null, start, pageLength , maLopHocPhan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetGiangVienSoTiet' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetGiangVienSoTiet(TransactionManager transactionManager, System.String maLopHocPhan)
		{
			return GetGiangVienSoTiet(transactionManager, 0, int.MaxValue , maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetGiangVienSoTiet' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetGiangVienSoTiet(TransactionManager transactionManager, int start, int pageLength , System.String maLopHocPhan);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_KiemTraDongBo 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBo(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraDongBo(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBo(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraDongBo(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBo(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraDongBo(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraDongBo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_CapNhatSiSoLopThucTapTotNghiep 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_CapNhatSiSoLopThucTapTotNghiep' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void CapNhatSiSoLopThucTapTotNghiep(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 CapNhatSiSoLopThucTapTotNghiep(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_CapNhatSiSoLopThucTapTotNghiep' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void CapNhatSiSoLopThucTapTotNghiep(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 CapNhatSiSoLopThucTapTotNghiep(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_CapNhatSiSoLopThucTapTotNghiep' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void CapNhatSiSoLopThucTapTotNghiep(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 CapNhatSiSoLopThucTapTotNghiep(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_CapNhatSiSoLopThucTapTotNghiep' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void CapNhatSiSoLopThucTapTotNghiep(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetMonHocByMaGiangVienNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetMonHocByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMonHocByMaGiangVienNamHocHocKy(System.String maGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetMonHocByMaGiangVienNamHocHocKy(null, 0, int.MaxValue , maGiangVien, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetMonHocByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMonHocByMaGiangVienNamHocHocKy(int start, int pageLength, System.String maGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetMonHocByMaGiangVienNamHocHocKy(null, start, pageLength , maGiangVien, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetMonHocByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMonHocByMaGiangVienNamHocHocKy(TransactionManager transactionManager, System.String maGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetMonHocByMaGiangVienNamHocHocKy(transactionManager, 0, int.MaxValue , maGiangVien, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetMonHocByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetMonHocByMaGiangVienNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVien, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_ThongKeChiTietKlgdHvhqByNamHocHocKyMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_ThongKeChiTietKlgdHvhqByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTietKlgdHvhqByNamHocHocKyMaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return ThongKeChiTietKlgdHvhqByNamHocHocKyMaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_ThongKeChiTietKlgdHvhqByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTietKlgdHvhqByNamHocHocKyMaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return ThongKeChiTietKlgdHvhqByNamHocHocKyMaDonVi(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_ThongKeChiTietKlgdHvhqByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTietKlgdHvhqByNamHocHocKyMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return ThongKeChiTietKlgdHvhqByNamHocHocKyMaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_ThongKeChiTietKlgdHvhqByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeChiTietKlgdHvhqByNamHocHocKyMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyCauHinhChotGio 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKyCauHinhChotGio(System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByNamHocHocKyCauHinhChotGio(null, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKyCauHinhChotGio(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByNamHocHocKyCauHinhChotGio(null, start, pageLength , namHoc, hocKy, maCauHinhChotGio);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKyCauHinhChotGio(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByNamHocHocKyCauHinhChotGio(transactionManager, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKyCauHinhChotGio(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_CapNhatSiSo 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_CapNhatSiSo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void CapNhatSiSo(System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 CapNhatSiSo(null, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_CapNhatSiSo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void CapNhatSiSo(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 CapNhatSiSo(null, start, pageLength , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_CapNhatSiSo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void CapNhatSiSo(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 CapNhatSiSo(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_CapNhatSiSo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void CapNhatSiSo(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetLopHocPhanByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetLopHocPhanByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLopHocPhanByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetLopHocPhanByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetLopHocPhanByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLopHocPhanByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetLopHocPhanByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetLopHocPhanByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLopHocPhanByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetLopHocPhanByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetLopHocPhanByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetLopHocPhanByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetMonHocByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetMonHocByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMonHocByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetMonHocByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetMonHocByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMonHocByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetMonHocByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetMonHocByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMonHocByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetMonHocByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetMonHocByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetMonHocByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetByMaGiangVienMaLopHocPhanMaLop 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByMaGiangVienMaLopHocPhanMaLop' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByMaGiangVienMaLopHocPhanMaLop(System.String maGiangVien, System.String maLopHocPhan, System.String maLop)
		{
			return GetByMaGiangVienMaLopHocPhanMaLop(null, 0, int.MaxValue , maGiangVien, maLopHocPhan, maLop);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByMaGiangVienMaLopHocPhanMaLop' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByMaGiangVienMaLopHocPhanMaLop(int start, int pageLength, System.String maGiangVien, System.String maLopHocPhan, System.String maLop)
		{
			return GetByMaGiangVienMaLopHocPhanMaLop(null, start, pageLength , maGiangVien, maLopHocPhan, maLop);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByMaGiangVienMaLopHocPhanMaLop' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByMaGiangVienMaLopHocPhanMaLop(TransactionManager transactionManager, System.String maGiangVien, System.String maLopHocPhan, System.String maLop)
		{
			return GetByMaGiangVienMaLopHocPhanMaLop(transactionManager, 0, int.MaxValue , maGiangVien, maLopHocPhan, maLop);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByMaGiangVienMaLopHocPhanMaLop' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDayChiTiet> GetByMaGiangVienMaLopHocPhanMaLop(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVien, System.String maLopHocPhan, System.String maLop);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKyMaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKyMaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKyMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKyMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoDot 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBoTheoDot(System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, ref System.Int32 reVal)
		{
			 KiemTraDongBoTheoDot(null, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBoTheoDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, ref System.Int32 reVal)
		{
			 KiemTraDongBoTheoDot(null, start, pageLength , namHoc, hocKy, maCauHinhChotGio, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBoTheoDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, ref System.Int32 reVal)
		{
			 KiemTraDongBoTheoDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraDongBoTheoDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoNgay 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBoTheoNgay(System.DateTime tuNgay, System.DateTime denNgay, ref System.Int32 reVal)
		{
			 KiemTraDongBoTheoNgay(null, 0, int.MaxValue , tuNgay, denNgay, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBoTheoNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, ref System.Int32 reVal)
		{
			 KiemTraDongBoTheoNgay(null, start, pageLength , tuNgay, denNgay, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBoTheoNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay, ref System.Int32 reVal)
		{
			 KiemTraDongBoTheoNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraDongBoTheoNgay(TransactionManager transactionManager, int start, int pageLength , System.DateTime tuNgay, System.DateTime denNgay, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetKhoiLuongImportByNamHocHocKyDot 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetKhoiLuongImportByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetKhoiLuongImportByNamHocHocKyDot(System.String namHoc, System.String hocKy, System.String dot)
		{
			return GetKhoiLuongImportByNamHocHocKyDot(null, 0, int.MaxValue , namHoc, hocKy, dot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetKhoiLuongImportByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetKhoiLuongImportByNamHocHocKyDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dot)
		{
			return GetKhoiLuongImportByNamHocHocKyDot(null, start, pageLength , namHoc, hocKy, dot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetKhoiLuongImportByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetKhoiLuongImportByNamHocHocKyDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dot)
		{
			return GetKhoiLuongImportByNamHocHocKyDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, dot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetKhoiLuongImportByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetKhoiLuongImportByNamHocHocKyDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dot);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_XoaDotImportTheoNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_XoaDotImportTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void XoaDotImportTheoNamHocHocKy(System.String namHoc, System.String hocKy, System.String dot, ref System.Int32 reVal)
		{
			 XoaDotImportTheoNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy, dot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_XoaDotImportTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void XoaDotImportTheoNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dot, ref System.Int32 reVal)
		{
			 XoaDotImportTheoNamHocHocKy(null, start, pageLength , namHoc, hocKy, dot, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_XoaDotImportTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void XoaDotImportTheoNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dot, ref System.Int32 reVal)
		{
			 XoaDotImportTheoNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, dot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_XoaDotImportTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void XoaDotImportTheoNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dot, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetLopHocPhanByMaGiangVienMaMonHocNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetLopHocPhanByMaGiangVienMaMonHocNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLopHocPhanByMaGiangVienMaMonHocNamHocHocKy(System.String maGiangVien, System.String maMonHoc, System.String namHoc, System.String hocKy)
		{
			return GetLopHocPhanByMaGiangVienMaMonHocNamHocHocKy(null, 0, int.MaxValue , maGiangVien, maMonHoc, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetLopHocPhanByMaGiangVienMaMonHocNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLopHocPhanByMaGiangVienMaMonHocNamHocHocKy(int start, int pageLength, System.String maGiangVien, System.String maMonHoc, System.String namHoc, System.String hocKy)
		{
			return GetLopHocPhanByMaGiangVienMaMonHocNamHocHocKy(null, start, pageLength , maGiangVien, maMonHoc, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetLopHocPhanByMaGiangVienMaMonHocNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLopHocPhanByMaGiangVienMaMonHocNamHocHocKy(TransactionManager transactionManager, System.String maGiangVien, System.String maMonHoc, System.String namHoc, System.String hocKy)
		{
			return GetLopHocPhanByMaGiangVienMaMonHocNamHocHocKy(transactionManager, 0, int.MaxValue , maGiangVien, maMonHoc, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetLopHocPhanByMaGiangVienMaMonHocNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetLopHocPhanByMaGiangVienMaMonHocNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVien, System.String maMonHoc, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetSinhVienByLopHocPhanNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetSinhVienByLopHocPhanNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSinhVienByLopHocPhanNamHocHocKy(System.String maLopHocPhan, System.String maLoaiHinhDaoTao)
		{
			return GetSinhVienByLopHocPhanNamHocHocKy(null, 0, int.MaxValue , maLopHocPhan, maLoaiHinhDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetSinhVienByLopHocPhanNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSinhVienByLopHocPhanNamHocHocKy(int start, int pageLength, System.String maLopHocPhan, System.String maLoaiHinhDaoTao)
		{
			return GetSinhVienByLopHocPhanNamHocHocKy(null, start, pageLength , maLopHocPhan, maLoaiHinhDaoTao);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetSinhVienByLopHocPhanNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetSinhVienByLopHocPhanNamHocHocKy(TransactionManager transactionManager, System.String maLopHocPhan, System.String maLoaiHinhDaoTao)
		{
			return GetSinhVienByLopHocPhanNamHocHocKy(transactionManager, 0, int.MaxValue , maLopHocPhan, maLoaiHinhDaoTao);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetSinhVienByLopHocPhanNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetSinhVienByLopHocPhanNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maLopHocPhan, System.String maLoaiHinhDaoTao);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetSoTietBoSung 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetSoTietBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetSoTietBoSung(System.String namHoc, System.String hocKy)
		{
			return GetSoTietBoSung(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetSoTietBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetSoTietBoSung(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetSoTietBoSung(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetSoTietBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetSoTietBoSung(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetSoTietBoSung(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetSoTietBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDayChiTiet> GetSoTietBoSung(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetByNgay 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDayChiTiet> GetByNgay(TransactionManager transactionManager, int start, int pageLength , System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetThongTinChiTiet 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetThongTinChiTiet' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongTinChiTiet(System.String maLopHocPhan)
		{
			return GetThongTinChiTiet(null, 0, int.MaxValue , maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetThongTinChiTiet' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongTinChiTiet(int start, int pageLength, System.String maLopHocPhan)
		{
			return GetThongTinChiTiet(null, start, pageLength , maLopHocPhan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetThongTinChiTiet' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThongTinChiTiet(TransactionManager transactionManager, System.String maLopHocPhan)
		{
			return GetThongTinChiTiet(transactionManager, 0, int.MaxValue , maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetThongTinChiTiet' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetThongTinChiTiet(TransactionManager transactionManager, int start, int pageLength , System.String maLopHocPhan);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetDotImportByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetDotImportByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDotImportByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetDotImportByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetDotImportByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDotImportByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetDotImportByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetDotImportByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDotImportByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetDotImportByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetDotImportByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetDotImportByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_Import 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="tenDotImport"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(System.String xmlData, System.String tenDotImport, ref System.Int32 reVal)
		{
			 Import(null, 0, int.MaxValue , xmlData, tenDotImport, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="tenDotImport"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(int start, int pageLength, System.String xmlData, System.String tenDotImport, ref System.Int32 reVal)
		{
			 Import(null, start, pageLength , xmlData, tenDotImport, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="tenDotImport"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(TransactionManager transactionManager, System.String xmlData, System.String tenDotImport, ref System.Int32 reVal)
		{
			 Import(transactionManager, 0, int.MaxValue , xmlData, tenDotImport, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="tenDotImport"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Import(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String tenDotImport, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetMonHocByMaGiangVienNamHocHocKyMaMonHoc 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetMonHocByMaGiangVienNamHocHocKyMaMonHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMonHocByMaGiangVienNamHocHocKyMaMonHoc(System.String maGiangVien, System.String namHoc, System.String hocKy, System.String maMonHoc)
		{
			return GetMonHocByMaGiangVienNamHocHocKyMaMonHoc(null, 0, int.MaxValue , maGiangVien, namHoc, hocKy, maMonHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetMonHocByMaGiangVienNamHocHocKyMaMonHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMonHocByMaGiangVienNamHocHocKyMaMonHoc(int start, int pageLength, System.String maGiangVien, System.String namHoc, System.String hocKy, System.String maMonHoc)
		{
			return GetMonHocByMaGiangVienNamHocHocKyMaMonHoc(null, start, pageLength , maGiangVien, namHoc, hocKy, maMonHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetMonHocByMaGiangVienNamHocHocKyMaMonHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMonHocByMaGiangVienNamHocHocKyMaMonHoc(TransactionManager transactionManager, System.String maGiangVien, System.String namHoc, System.String hocKy, System.String maMonHoc)
		{
			return GetMonHocByMaGiangVienNamHocHocKyMaMonHoc(transactionManager, 0, int.MaxValue , maGiangVien, namHoc, hocKy, maMonHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetMonHocByMaGiangVienNamHocHocKyMaMonHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetMonHocByMaGiangVienNamHocHocKyMaMonHoc(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVien, System.String namHoc, System.String hocKy, System.String maMonHoc);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetHeSoNienCheTinChi 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetHeSoNienCheTinChi' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNienCheTinChi(System.String maLopHocPhan, ref System.Int32 reVal)
		{
			 GetHeSoNienCheTinChi(null, 0, int.MaxValue , maLopHocPhan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetHeSoNienCheTinChi' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNienCheTinChi(int start, int pageLength, System.String maLopHocPhan, ref System.Int32 reVal)
		{
			 GetHeSoNienCheTinChi(null, start, pageLength , maLopHocPhan, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetHeSoNienCheTinChi' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNienCheTinChi(TransactionManager transactionManager, System.String maLopHocPhan, ref System.Int32 reVal)
		{
			 GetHeSoNienCheTinChi(transactionManager, 0, int.MaxValue , maLopHocPhan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetHeSoNienCheTinChi' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetHeSoNienCheTinChi(TransactionManager transactionManager, int start, int pageLength , System.String maLopHocPhan, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetLhpThucTapTotNghiepByNamHocHocKyKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetLhpThucTapTotNghiepByNamHocHocKyKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLhpThucTapTotNghiepByNamHocHocKyKhoa(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetLhpThucTapTotNghiepByNamHocHocKyKhoa(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetLhpThucTapTotNghiepByNamHocHocKyKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLhpThucTapTotNghiepByNamHocHocKyKhoa(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetLhpThucTapTotNghiepByNamHocHocKyKhoa(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetLhpThucTapTotNghiepByNamHocHocKyKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetLhpThucTapTotNghiepByNamHocHocKyKhoa(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetLhpThucTapTotNghiepByNamHocHocKyKhoa(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetLhpThucTapTotNghiepByNamHocHocKyKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetLhpThucTapTotNghiepByNamHocHocKyKhoa(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBoTheoDonVi(System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 KiemTraDongBoTheoDonVi(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBoTheoDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 KiemTraDongBoTheoDonVi(null, start, pageLength , namHoc, hocKy, maDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBoTheoDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 KiemTraDongBoTheoDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_KiemTraDongBoTheoDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraDongBoTheoDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetByMaGiangVienMaLopHocPhan 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByMaGiangVienMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByMaGiangVienMaLopHocPhan(System.String maGiangVien, System.String maLopHocPhan)
		{
			return GetByMaGiangVienMaLopHocPhan(null, 0, int.MaxValue , maGiangVien, maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByMaGiangVienMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByMaGiangVienMaLopHocPhan(int start, int pageLength, System.String maGiangVien, System.String maLopHocPhan)
		{
			return GetByMaGiangVienMaLopHocPhan(null, start, pageLength , maGiangVien, maLopHocPhan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByMaGiangVienMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByMaGiangVienMaLopHocPhan(TransactionManager transactionManager, System.String maGiangVien, System.String maLopHocPhan)
		{
			return GetByMaGiangVienMaLopHocPhan(transactionManager, 0, int.MaxValue , maGiangVien, maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByMaGiangVienMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDayChiTiet> GetByMaGiangVienMaLopHocPhan(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVien, System.String maLopHocPhan);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyBoSung 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKyBoSung(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyBoSung(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKyBoSung(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyBoSung(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKyBoSung(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyBoSung(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayChiTiet_GetByNamHocHocKyBoSung' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDayChiTiet> GetByNamHocHocKyBoSung(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KhoiLuongGiangDayChiTiet&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KhoiLuongGiangDayChiTiet&gt;"/></returns>
		public static TList<KhoiLuongGiangDayChiTiet> Fill(IDataReader reader, TList<KhoiLuongGiangDayChiTiet> rows, int start, int pageLength)
		{
			NetTiersProvider currentProvider = DataRepository.Provider;
            bool useEntityFactory = currentProvider.UseEntityFactory;
            bool enableEntityTracking = currentProvider.EnableEntityTracking;
            LoadPolicy currentLoadPolicy = currentProvider.CurrentLoadPolicy;
			Type entityCreationFactoryType = currentProvider.EntityCreationalFactoryType;
			
			// advance to the starting row
			for (int i = 0; i < start; i++)
			{
				if (!reader.Read())
				return rows; // not enough rows, just return
			}
			for (int i = 0; i < pageLength; i++)
			{
				if (!reader.Read())
					break; // we are done
					
				string key = null;
				
				PMS.Entities.KhoiLuongGiangDayChiTiet c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KhoiLuongGiangDayChiTiet")
					.Append("|").Append((System.Int32)reader[((int)KhoiLuongGiangDayChiTietColumn.MaKhoiLuong - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KhoiLuongGiangDayChiTiet>(
					key.ToString(), // EntityTrackingKey
					"KhoiLuongGiangDayChiTiet",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KhoiLuongGiangDayChiTiet();
				}
				
				if (!enableEntityTracking ||
					c.EntityState == EntityState.Added ||
					(enableEntityTracking &&
					
						(
							(currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) ||
							(currentLoadPolicy == LoadPolicy.DiscardChanges && c.EntityState != EntityState.Unchanged)
						)
					))
				{
					c.SuppressEntityEvents = true;
					c.MaKhoiLuong = (System.Int32)reader[(KhoiLuongGiangDayChiTietColumn.MaKhoiLuong.ToString())];
					c.MaLichHoc = (System.Int32)reader[(KhoiLuongGiangDayChiTietColumn.MaLichHoc.ToString())];
					c.MaGiangVien = (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaGiangVien.ToString())];
					c.MaLopHocPhan = (reader[KhoiLuongGiangDayChiTietColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaLopHocPhan.ToString())];
					c.NamHoc = (System.String)reader[(KhoiLuongGiangDayChiTietColumn.NamHoc.ToString())];
					c.HocKy = (System.String)reader[(KhoiLuongGiangDayChiTietColumn.HocKy.ToString())];
					c.MaMonHoc = (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (System.String)reader[(KhoiLuongGiangDayChiTietColumn.TenMonHoc.ToString())];
					c.Nhom = (reader[KhoiLuongGiangDayChiTietColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.Nhom.ToString())];
					c.SoTinChi = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.SoTinChi.ToString())];
					c.LyThuyet = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.LyThuyet.ToString())];
					c.ThucHanh = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.ThucHanh.ToString())];
					c.BaiTap = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.BaiTap.ToString())];
					c.BaiTapLon = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.BaiTapLon.ToString())];
					c.DoAn = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.DoAn.ToString())];
					c.LuanAn = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.LuanAn.ToString())];
					c.TieuLuan = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.TieuLuan.ToString())];
					c.ThucTap = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.ThucTap.ToString())];
					c.SoLuong = (reader[KhoiLuongGiangDayChiTietColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.SoLuong.ToString())];
					c.MaLoaiHocPhan = (System.Byte)reader[(KhoiLuongGiangDayChiTietColumn.MaLoaiHocPhan.ToString())];
					c.LoaiHocPhan = (reader[KhoiLuongGiangDayChiTietColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.LoaiHocPhan.ToString())];
					c.PhanLoai = (reader[KhoiLuongGiangDayChiTietColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.PhanLoai.ToString())];
					c.HeSoThanhPhan = (reader[KhoiLuongGiangDayChiTietColumn.HeSoThanhPhan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayChiTietColumn.HeSoThanhPhan.ToString())];
					c.Nam = (reader[KhoiLuongGiangDayChiTietColumn.Nam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.Nam.ToString())];
					c.Tuan = (reader[KhoiLuongGiangDayChiTietColumn.Tuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.Tuan.ToString())];
					c.DonViTinh = (reader[KhoiLuongGiangDayChiTietColumn.DonViTinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.DonViTinh.ToString())];
					c.MaBuoiHoc = (reader[KhoiLuongGiangDayChiTietColumn.MaBuoiHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.MaBuoiHoc.ToString())];
					c.MaLop = (reader[KhoiLuongGiangDayChiTietColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaLop.ToString())];
					c.TietBatDau = (reader[KhoiLuongGiangDayChiTietColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.TietBatDau.ToString())];
					c.SoTiet = (reader[KhoiLuongGiangDayChiTietColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayChiTietColumn.SoTiet.ToString())];
					c.TinhTrang = (System.Int32)reader[(KhoiLuongGiangDayChiTietColumn.TinhTrang.ToString())];
					c.NgayDay = (reader[KhoiLuongGiangDayChiTietColumn.NgayDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayChiTietColumn.NgayDay.ToString())];
					c.Compensate = (reader[KhoiLuongGiangDayChiTietColumn.Compensate.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(KhoiLuongGiangDayChiTietColumn.Compensate.ToString())];
					c.MaBacDaoTao = (reader[KhoiLuongGiangDayChiTietColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaBacDaoTao.ToString())];
					c.MaKhoa = (reader[KhoiLuongGiangDayChiTietColumn.MaKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaKhoa.ToString())];
					c.MaNhomMonHoc = (reader[KhoiLuongGiangDayChiTietColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaNhomMonHoc.ToString())];
					c.MaPhongHoc = (reader[KhoiLuongGiangDayChiTietColumn.MaPhongHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaPhongHoc.ToString())];
					c.MaKhoaHoc = (reader[KhoiLuongGiangDayChiTietColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaKhoaHoc.ToString())];
					c.LoaiHocKy = (reader[KhoiLuongGiangDayChiTietColumn.LoaiHocKy.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(KhoiLuongGiangDayChiTietColumn.LoaiHocKy.ToString())];
					c.HeSoHocKy = (reader[KhoiLuongGiangDayChiTietColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayChiTietColumn.HeSoHocKy.ToString())];
					c.NamThu = (reader[KhoiLuongGiangDayChiTietColumn.NamThu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.NamThu.ToString())];
					c.MaHocHam = (reader[KhoiLuongGiangDayChiTietColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KhoiLuongGiangDayChiTietColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[KhoiLuongGiangDayChiTietColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.MaLoaiGiangVien.ToString())];
					c.MaChucVu = (reader[KhoiLuongGiangDayChiTietColumn.MaChucVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.MaChucVu.ToString())];
					c.MaHinhThucDaoTao = (reader[KhoiLuongGiangDayChiTietColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaHinhThucDaoTao.ToString())];
					c.GhiChu = (reader[KhoiLuongGiangDayChiTietColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[KhoiLuongGiangDayChiTietColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.NgayCapNhat.ToString())];
					c.LopHocPhanChuyenNganh = (reader[KhoiLuongGiangDayChiTietColumn.LopHocPhanChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KhoiLuongGiangDayChiTietColumn.LopHocPhanChuyenNganh.ToString())];
					c.DotImport = (reader[KhoiLuongGiangDayChiTietColumn.DotImport.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.DotImport.ToString())];
					c.DaoTaoTinChi = (reader[KhoiLuongGiangDayChiTietColumn.DaoTaoTinChi.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KhoiLuongGiangDayChiTietColumn.DaoTaoTinChi.ToString())];
					c.MaCauHinhChotGio = (reader[KhoiLuongGiangDayChiTietColumn.MaCauHinhChotGio.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.MaCauHinhChotGio.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongGiangDayChiTiet"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayChiTiet"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KhoiLuongGiangDayChiTiet entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKhoiLuong = (System.Int32)reader[(KhoiLuongGiangDayChiTietColumn.MaKhoiLuong.ToString())];
			entity.MaLichHoc = (System.Int32)reader[(KhoiLuongGiangDayChiTietColumn.MaLichHoc.ToString())];
			entity.MaGiangVien = (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaGiangVien.ToString())];
			entity.MaLopHocPhan = (reader[KhoiLuongGiangDayChiTietColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaLopHocPhan.ToString())];
			entity.NamHoc = (System.String)reader[(KhoiLuongGiangDayChiTietColumn.NamHoc.ToString())];
			entity.HocKy = (System.String)reader[(KhoiLuongGiangDayChiTietColumn.HocKy.ToString())];
			entity.MaMonHoc = (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (System.String)reader[(KhoiLuongGiangDayChiTietColumn.TenMonHoc.ToString())];
			entity.Nhom = (reader[KhoiLuongGiangDayChiTietColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.Nhom.ToString())];
			entity.SoTinChi = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.SoTinChi.ToString())];
			entity.LyThuyet = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.LyThuyet.ToString())];
			entity.ThucHanh = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.ThucHanh.ToString())];
			entity.BaiTap = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.BaiTap.ToString())];
			entity.BaiTapLon = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.BaiTapLon.ToString())];
			entity.DoAn = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.DoAn.ToString())];
			entity.LuanAn = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.LuanAn.ToString())];
			entity.TieuLuan = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.TieuLuan.ToString())];
			entity.ThucTap = (System.Decimal)reader[(KhoiLuongGiangDayChiTietColumn.ThucTap.ToString())];
			entity.SoLuong = (reader[KhoiLuongGiangDayChiTietColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.SoLuong.ToString())];
			entity.MaLoaiHocPhan = (System.Byte)reader[(KhoiLuongGiangDayChiTietColumn.MaLoaiHocPhan.ToString())];
			entity.LoaiHocPhan = (reader[KhoiLuongGiangDayChiTietColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.LoaiHocPhan.ToString())];
			entity.PhanLoai = (reader[KhoiLuongGiangDayChiTietColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.PhanLoai.ToString())];
			entity.HeSoThanhPhan = (reader[KhoiLuongGiangDayChiTietColumn.HeSoThanhPhan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayChiTietColumn.HeSoThanhPhan.ToString())];
			entity.Nam = (reader[KhoiLuongGiangDayChiTietColumn.Nam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.Nam.ToString())];
			entity.Tuan = (reader[KhoiLuongGiangDayChiTietColumn.Tuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.Tuan.ToString())];
			entity.DonViTinh = (reader[KhoiLuongGiangDayChiTietColumn.DonViTinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.DonViTinh.ToString())];
			entity.MaBuoiHoc = (reader[KhoiLuongGiangDayChiTietColumn.MaBuoiHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.MaBuoiHoc.ToString())];
			entity.MaLop = (reader[KhoiLuongGiangDayChiTietColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaLop.ToString())];
			entity.TietBatDau = (reader[KhoiLuongGiangDayChiTietColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.TietBatDau.ToString())];
			entity.SoTiet = (reader[KhoiLuongGiangDayChiTietColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayChiTietColumn.SoTiet.ToString())];
			entity.TinhTrang = (System.Int32)reader[(KhoiLuongGiangDayChiTietColumn.TinhTrang.ToString())];
			entity.NgayDay = (reader[KhoiLuongGiangDayChiTietColumn.NgayDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayChiTietColumn.NgayDay.ToString())];
			entity.Compensate = (reader[KhoiLuongGiangDayChiTietColumn.Compensate.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(KhoiLuongGiangDayChiTietColumn.Compensate.ToString())];
			entity.MaBacDaoTao = (reader[KhoiLuongGiangDayChiTietColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaBacDaoTao.ToString())];
			entity.MaKhoa = (reader[KhoiLuongGiangDayChiTietColumn.MaKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaKhoa.ToString())];
			entity.MaNhomMonHoc = (reader[KhoiLuongGiangDayChiTietColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaNhomMonHoc.ToString())];
			entity.MaPhongHoc = (reader[KhoiLuongGiangDayChiTietColumn.MaPhongHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaPhongHoc.ToString())];
			entity.MaKhoaHoc = (reader[KhoiLuongGiangDayChiTietColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaKhoaHoc.ToString())];
			entity.LoaiHocKy = (reader[KhoiLuongGiangDayChiTietColumn.LoaiHocKy.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(KhoiLuongGiangDayChiTietColumn.LoaiHocKy.ToString())];
			entity.HeSoHocKy = (reader[KhoiLuongGiangDayChiTietColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayChiTietColumn.HeSoHocKy.ToString())];
			entity.NamThu = (reader[KhoiLuongGiangDayChiTietColumn.NamThu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.NamThu.ToString())];
			entity.MaHocHam = (reader[KhoiLuongGiangDayChiTietColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KhoiLuongGiangDayChiTietColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[KhoiLuongGiangDayChiTietColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.MaLoaiGiangVien.ToString())];
			entity.MaChucVu = (reader[KhoiLuongGiangDayChiTietColumn.MaChucVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.MaChucVu.ToString())];
			entity.MaHinhThucDaoTao = (reader[KhoiLuongGiangDayChiTietColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.MaHinhThucDaoTao.ToString())];
			entity.GhiChu = (reader[KhoiLuongGiangDayChiTietColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[KhoiLuongGiangDayChiTietColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.NgayCapNhat.ToString())];
			entity.LopHocPhanChuyenNganh = (reader[KhoiLuongGiangDayChiTietColumn.LopHocPhanChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KhoiLuongGiangDayChiTietColumn.LopHocPhanChuyenNganh.ToString())];
			entity.DotImport = (reader[KhoiLuongGiangDayChiTietColumn.DotImport.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayChiTietColumn.DotImport.ToString())];
			entity.DaoTaoTinChi = (reader[KhoiLuongGiangDayChiTietColumn.DaoTaoTinChi.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KhoiLuongGiangDayChiTietColumn.DaoTaoTinChi.ToString())];
			entity.MaCauHinhChotGio = (reader[KhoiLuongGiangDayChiTietColumn.MaCauHinhChotGio.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayChiTietColumn.MaCauHinhChotGio.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongGiangDayChiTiet"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayChiTiet"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KhoiLuongGiangDayChiTiet entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoiLuong = (System.Int32)dataRow["MaKhoiLuong"];
			entity.MaLichHoc = (System.Int32)dataRow["MaLichHoc"];
			entity.MaGiangVien = (System.String)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.NamHoc = (System.String)dataRow["NamHoc"];
			entity.HocKy = (System.String)dataRow["HocKy"];
			entity.MaMonHoc = (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (System.String)dataRow["TenMonHoc"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.SoTinChi = (System.Decimal)dataRow["SoTinChi"];
			entity.LyThuyet = (System.Decimal)dataRow["LyThuyet"];
			entity.ThucHanh = (System.Decimal)dataRow["ThucHanh"];
			entity.BaiTap = (System.Decimal)dataRow["BaiTap"];
			entity.BaiTapLon = (System.Decimal)dataRow["BaiTapLon"];
			entity.DoAn = (System.Decimal)dataRow["DoAn"];
			entity.LuanAn = (System.Decimal)dataRow["LuanAn"];
			entity.TieuLuan = (System.Decimal)dataRow["TieuLuan"];
			entity.ThucTap = (System.Decimal)dataRow["ThucTap"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Int32?)dataRow["SoLuong"];
			entity.MaLoaiHocPhan = (System.Byte)dataRow["MaLoaiHocPhan"];
			entity.LoaiHocPhan = Convert.IsDBNull(dataRow["LoaiHocPhan"]) ? null : (System.String)dataRow["LoaiHocPhan"];
			entity.PhanLoai = Convert.IsDBNull(dataRow["PhanLoai"]) ? null : (System.String)dataRow["PhanLoai"];
			entity.HeSoThanhPhan = Convert.IsDBNull(dataRow["HeSoThanhPhan"]) ? null : (System.Decimal?)dataRow["HeSoThanhPhan"];
			entity.Nam = Convert.IsDBNull(dataRow["Nam"]) ? null : (System.Int32?)dataRow["Nam"];
			entity.Tuan = Convert.IsDBNull(dataRow["Tuan"]) ? null : (System.Int32?)dataRow["Tuan"];
			entity.DonViTinh = Convert.IsDBNull(dataRow["DonViTinh"]) ? null : (System.String)dataRow["DonViTinh"];
			entity.MaBuoiHoc = Convert.IsDBNull(dataRow["MaBuoiHoc"]) ? null : (System.Int32?)dataRow["MaBuoiHoc"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.TietBatDau = Convert.IsDBNull(dataRow["TietBatDau"]) ? null : (System.Int32?)dataRow["TietBatDau"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.TinhTrang = (System.Int32)dataRow["TinhTrang"];
			entity.NgayDay = Convert.IsDBNull(dataRow["NgayDay"]) ? null : (System.DateTime?)dataRow["NgayDay"];
			entity.Compensate = Convert.IsDBNull(dataRow["Compensate"]) ? null : (System.Byte?)dataRow["Compensate"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.MaKhoa = Convert.IsDBNull(dataRow["MaKhoa"]) ? null : (System.String)dataRow["MaKhoa"];
			entity.MaNhomMonHoc = Convert.IsDBNull(dataRow["MaNhomMonHoc"]) ? null : (System.String)dataRow["MaNhomMonHoc"];
			entity.MaPhongHoc = Convert.IsDBNull(dataRow["MaPhongHoc"]) ? null : (System.String)dataRow["MaPhongHoc"];
			entity.MaKhoaHoc = Convert.IsDBNull(dataRow["MaKhoaHoc"]) ? null : (System.String)dataRow["MaKhoaHoc"];
			entity.LoaiHocKy = Convert.IsDBNull(dataRow["LoaiHocKy"]) ? null : (System.Byte?)dataRow["LoaiHocKy"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
			entity.NamThu = Convert.IsDBNull(dataRow["NamThu"]) ? null : (System.String)dataRow["NamThu"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaChucVu = Convert.IsDBNull(dataRow["MaChucVu"]) ? null : (System.Int32?)dataRow["MaChucVu"];
			entity.MaHinhThucDaoTao = Convert.IsDBNull(dataRow["MaHinhThucDaoTao"]) ? null : (System.String)dataRow["MaHinhThucDaoTao"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.LopHocPhanChuyenNganh = Convert.IsDBNull(dataRow["LopHocPhanChuyenNganh"]) ? null : (System.Boolean?)dataRow["LopHocPhanChuyenNganh"];
			entity.DotImport = Convert.IsDBNull(dataRow["DotImport"]) ? null : (System.String)dataRow["DotImport"];
			entity.DaoTaoTinChi = Convert.IsDBNull(dataRow["DaoTaoTinChi"]) ? null : (System.Boolean?)dataRow["DaoTaoTinChi"];
			entity.MaCauHinhChotGio = Convert.IsDBNull(dataRow["MaCauHinhChotGio"]) ? null : (System.Int32?)dataRow["MaCauHinhChotGio"];
			entity.AcceptChanges();
		}
		#endregion 
		
		#region DeepLoad Methods
		/// <summary>
		/// Deep Loads the <see cref="IEntity"/> object with criteria based of the child 
		/// property collections only N Levels Deep based on the <see cref="DeepLoadType"/>.
		/// </summary>
		/// <remarks>
		/// Use this method with caution as it is possible to DeepLoad with Recursion and traverse an entire object graph.
		/// </remarks>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayChiTiet"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongGiangDayChiTiet Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayChiTiet entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaKhoiLuong methods when available
			
			#region KhoiLuongQuyDoiCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<KhoiLuongQuyDoi>|KhoiLuongQuyDoiCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'KhoiLuongQuyDoiCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.KhoiLuongQuyDoiCollection = DataRepository.KhoiLuongQuyDoiProvider.GetByMaKhoiLuongGiangDay(transactionManager, entity.MaKhoiLuong);

				if (deep && entity.KhoiLuongQuyDoiCollection.Count > 0)
				{
					deepHandles.Add("KhoiLuongQuyDoiCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<KhoiLuongQuyDoi>) DataRepository.KhoiLuongQuyDoiProvider.DeepLoad,
						new object[] { transactionManager, entity.KhoiLuongQuyDoiCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			//Fire all DeepLoad Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			deepHandles = null;
		}
		
		#endregion 
		
		#region DeepSave Methods

		/// <summary>
		/// Deep Save the entire object graph of the PMS.Entities.KhoiLuongGiangDayChiTiet object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KhoiLuongGiangDayChiTiet instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongGiangDayChiTiet Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayChiTiet entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<KhoiLuongQuyDoi>
				if (CanDeepSave(entity.KhoiLuongQuyDoiCollection, "List<KhoiLuongQuyDoi>|KhoiLuongQuyDoiCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(KhoiLuongQuyDoi child in entity.KhoiLuongQuyDoiCollection)
					{
						if(child.MaKhoiLuongGiangDaySource != null)
						{
							child.MaKhoiLuongGiangDay = child.MaKhoiLuongGiangDaySource.MaKhoiLuong;
						}
						else
						{
							child.MaKhoiLuongGiangDay = entity.MaKhoiLuong;
						}

					}

					if (entity.KhoiLuongQuyDoiCollection.Count > 0 || entity.KhoiLuongQuyDoiCollection.DeletedItems.Count > 0)
					{
						//DataRepository.KhoiLuongQuyDoiProvider.Save(transactionManager, entity.KhoiLuongQuyDoiCollection);
						
						deepHandles.Add("KhoiLuongQuyDoiCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< KhoiLuongQuyDoi >) DataRepository.KhoiLuongQuyDoiProvider.DeepSave,
							new object[] { transactionManager, entity.KhoiLuongQuyDoiCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
			//Fire all DeepSave Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			
			// Save Root Entity through Provider, if not already saved in delete mode
			if (entity.IsDeleted)
				this.Save(transactionManager, entity);
				

			deepHandles = null;
						
			return true;
		}
		#endregion
	} // end class
	
	#region KhoiLuongGiangDayChiTietChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KhoiLuongGiangDayChiTiet</c>
	///</summary>
	public enum KhoiLuongGiangDayChiTietChildEntityTypes
	{
		///<summary>
		/// Collection of <c>KhoiLuongGiangDayChiTiet</c> as OneToMany for KhoiLuongQuyDoiCollection
		///</summary>
		[ChildEntityType(typeof(TList<KhoiLuongQuyDoi>))]
		KhoiLuongQuyDoiCollection,
	}
	
	#endregion KhoiLuongGiangDayChiTietChildEntityTypes
	
	#region KhoiLuongGiangDayChiTietFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KhoiLuongGiangDayChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayChiTietFilterBuilder : SqlFilterBuilder<KhoiLuongGiangDayChiTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayChiTietFilterBuilder class.
		/// </summary>
		public KhoiLuongGiangDayChiTietFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayChiTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongGiangDayChiTietFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayChiTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongGiangDayChiTietFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongGiangDayChiTietFilterBuilder
	
	#region KhoiLuongGiangDayChiTietParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KhoiLuongGiangDayChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayChiTietParameterBuilder : ParameterizedSqlFilterBuilder<KhoiLuongGiangDayChiTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayChiTietParameterBuilder class.
		/// </summary>
		public KhoiLuongGiangDayChiTietParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayChiTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongGiangDayChiTietParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayChiTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongGiangDayChiTietParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongGiangDayChiTietParameterBuilder
	
	#region KhoiLuongGiangDayChiTietSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KhoiLuongGiangDayChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayChiTiet"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KhoiLuongGiangDayChiTietSortBuilder : SqlSortBuilder<KhoiLuongGiangDayChiTietColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayChiTietSqlSortBuilder class.
		/// </summary>
		public KhoiLuongGiangDayChiTietSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KhoiLuongGiangDayChiTietSortBuilder
	
} // end namespace
