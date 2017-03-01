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
	/// This class is the base class for any <see cref="KhoiLuongGiangDayCaoDangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KhoiLuongGiangDayCaoDangProviderBaseCore : EntityProviderBase<PMS.Entities.KhoiLuongGiangDayCaoDang, PMS.Entities.KhoiLuongGiangDayCaoDangKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayCaoDangKey key)
		{
			return Delete(transactionManager, key.MaKhoiLuongCaoDang);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maKhoiLuongCaoDang">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maKhoiLuongCaoDang)
		{
			return Delete(null, _maKhoiLuongCaoDang);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongCaoDang">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maKhoiLuongCaoDang);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongGiangDayCaoDang_CauHinhChotGio key.
		///		FK_KhoiLuongGiangDayCaoDang_CauHinhChotGio Description: 
		/// </summary>
		/// <param name="_maCauHinhChotGio"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongGiangDayCaoDang objects.</returns>
		public TList<KhoiLuongGiangDayCaoDang> GetByMaCauHinhChotGio(System.Int32? _maCauHinhChotGio)
		{
			int count = -1;
			return GetByMaCauHinhChotGio(_maCauHinhChotGio, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongGiangDayCaoDang_CauHinhChotGio key.
		///		FK_KhoiLuongGiangDayCaoDang_CauHinhChotGio Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongGiangDayCaoDang objects.</returns>
		/// <remarks></remarks>
		public TList<KhoiLuongGiangDayCaoDang> GetByMaCauHinhChotGio(TransactionManager transactionManager, System.Int32? _maCauHinhChotGio)
		{
			int count = -1;
			return GetByMaCauHinhChotGio(transactionManager, _maCauHinhChotGio, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongGiangDayCaoDang_CauHinhChotGio key.
		///		FK_KhoiLuongGiangDayCaoDang_CauHinhChotGio Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongGiangDayCaoDang objects.</returns>
		public TList<KhoiLuongGiangDayCaoDang> GetByMaCauHinhChotGio(TransactionManager transactionManager, System.Int32? _maCauHinhChotGio, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCauHinhChotGio(transactionManager, _maCauHinhChotGio, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongGiangDayCaoDang_CauHinhChotGio key.
		///		fkKhoiLuongGiangDayCaoDangCauHinhChotGio Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongGiangDayCaoDang objects.</returns>
		public TList<KhoiLuongGiangDayCaoDang> GetByMaCauHinhChotGio(System.Int32? _maCauHinhChotGio, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaCauHinhChotGio(null, _maCauHinhChotGio, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongGiangDayCaoDang_CauHinhChotGio key.
		///		fkKhoiLuongGiangDayCaoDangCauHinhChotGio Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongGiangDayCaoDang objects.</returns>
		public TList<KhoiLuongGiangDayCaoDang> GetByMaCauHinhChotGio(System.Int32? _maCauHinhChotGio, int start, int pageLength,out int count)
		{
			return GetByMaCauHinhChotGio(null, _maCauHinhChotGio, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongGiangDayCaoDang_CauHinhChotGio key.
		///		FK_KhoiLuongGiangDayCaoDang_CauHinhChotGio Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongGiangDayCaoDang objects.</returns>
		public abstract TList<KhoiLuongGiangDayCaoDang> GetByMaCauHinhChotGio(TransactionManager transactionManager, System.Int32? _maCauHinhChotGio, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.KhoiLuongGiangDayCaoDang Get(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayCaoDangKey key, int start, int pageLength)
		{
			return GetByMaKhoiLuongCaoDang(transactionManager, key.MaKhoiLuongCaoDang, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KhoiLuongGiangDayCaoDang index.
		/// </summary>
		/// <param name="_maKhoiLuongCaoDang"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayCaoDang"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayCaoDang GetByMaKhoiLuongCaoDang(System.Int32 _maKhoiLuongCaoDang)
		{
			int count = -1;
			return GetByMaKhoiLuongCaoDang(null,_maKhoiLuongCaoDang, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayCaoDang index.
		/// </summary>
		/// <param name="_maKhoiLuongCaoDang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayCaoDang"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayCaoDang GetByMaKhoiLuongCaoDang(System.Int32 _maKhoiLuongCaoDang, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuongCaoDang(null, _maKhoiLuongCaoDang, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayCaoDang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongCaoDang"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayCaoDang"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayCaoDang GetByMaKhoiLuongCaoDang(TransactionManager transactionManager, System.Int32 _maKhoiLuongCaoDang)
		{
			int count = -1;
			return GetByMaKhoiLuongCaoDang(transactionManager, _maKhoiLuongCaoDang, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayCaoDang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongCaoDang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayCaoDang"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayCaoDang GetByMaKhoiLuongCaoDang(TransactionManager transactionManager, System.Int32 _maKhoiLuongCaoDang, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuongCaoDang(transactionManager, _maKhoiLuongCaoDang, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayCaoDang index.
		/// </summary>
		/// <param name="_maKhoiLuongCaoDang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayCaoDang"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayCaoDang GetByMaKhoiLuongCaoDang(System.Int32 _maKhoiLuongCaoDang, int start, int pageLength, out int count)
		{
			return GetByMaKhoiLuongCaoDang(null, _maKhoiLuongCaoDang, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayCaoDang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongCaoDang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayCaoDang"/> class.</returns>
		public abstract PMS.Entities.KhoiLuongGiangDayCaoDang GetByMaKhoiLuongCaoDang(TransactionManager transactionManager, System.Int32 _maKhoiLuongCaoDang, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KhoiLuongGiangDayCaoDang_GetByMaBoMonMaCauHinhChotGio 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayCaoDang_GetByMaBoMonMaCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayCaoDang&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayCaoDang> GetByMaBoMonMaCauHinhChotGio(System.String maBoMon, System.Int32 maCauHinhChotGio)
		{
			return GetByMaBoMonMaCauHinhChotGio(null, 0, int.MaxValue , maBoMon, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayCaoDang_GetByMaBoMonMaCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayCaoDang&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayCaoDang> GetByMaBoMonMaCauHinhChotGio(int start, int pageLength, System.String maBoMon, System.Int32 maCauHinhChotGio)
		{
			return GetByMaBoMonMaCauHinhChotGio(null, start, pageLength , maBoMon, maCauHinhChotGio);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayCaoDang_GetByMaBoMonMaCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayCaoDang&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayCaoDang> GetByMaBoMonMaCauHinhChotGio(TransactionManager transactionManager, System.String maBoMon, System.Int32 maCauHinhChotGio)
		{
			return GetByMaBoMonMaCauHinhChotGio(transactionManager, 0, int.MaxValue , maBoMon, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayCaoDang_GetByMaBoMonMaCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayCaoDang&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDayCaoDang> GetByMaBoMonMaCauHinhChotGio(TransactionManager transactionManager, int start, int pageLength , System.String maBoMon, System.Int32 maCauHinhChotGio);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayCaoDang_DeleteByMaCauHinhChotGioMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayCaoDang_DeleteByMaCauHinhChotGioMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByMaCauHinhChotGioMaDonVi(System.Int32 maCauHinhChotGio, System.String maDonVi)
		{
			 DeleteByMaCauHinhChotGioMaDonVi(null, 0, int.MaxValue , maCauHinhChotGio, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayCaoDang_DeleteByMaCauHinhChotGioMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByMaCauHinhChotGioMaDonVi(int start, int pageLength, System.Int32 maCauHinhChotGio, System.String maDonVi)
		{
			 DeleteByMaCauHinhChotGioMaDonVi(null, start, pageLength , maCauHinhChotGio, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayCaoDang_DeleteByMaCauHinhChotGioMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByMaCauHinhChotGioMaDonVi(TransactionManager transactionManager, System.Int32 maCauHinhChotGio, System.String maDonVi)
		{
			 DeleteByMaCauHinhChotGioMaDonVi(transactionManager, 0, int.MaxValue , maCauHinhChotGio, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayCaoDang_DeleteByMaCauHinhChotGioMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DeleteByMaCauHinhChotGioMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.Int32 maCauHinhChotGio, System.String maDonVi);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayCaoDang_KiemTraGioThucDay 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayCaoDang_KiemTraGioThucDay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
			/// <param name="tongTietThucDay"> A <c>System.Int32</c> instance.</param>
			/// <param name="tongTietTheoLich"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraGioThucDay(System.String maGiangVienQuanLy, System.String namHoc, System.String maLopHocPhan, ref System.Int32 tongTietThucDay, ref System.Int32 tongTietTheoLich)
		{
			 KiemTraGioThucDay(null, 0, int.MaxValue , maGiangVienQuanLy, namHoc, maLopHocPhan, ref tongTietThucDay, ref tongTietTheoLich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayCaoDang_KiemTraGioThucDay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
			/// <param name="tongTietThucDay"> A <c>System.Int32</c> instance.</param>
			/// <param name="tongTietTheoLich"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraGioThucDay(int start, int pageLength, System.String maGiangVienQuanLy, System.String namHoc, System.String maLopHocPhan, ref System.Int32 tongTietThucDay, ref System.Int32 tongTietTheoLich)
		{
			 KiemTraGioThucDay(null, start, pageLength , maGiangVienQuanLy, namHoc, maLopHocPhan, ref tongTietThucDay, ref tongTietTheoLich);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayCaoDang_KiemTraGioThucDay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
			/// <param name="tongTietThucDay"> A <c>System.Int32</c> instance.</param>
			/// <param name="tongTietTheoLich"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraGioThucDay(TransactionManager transactionManager, System.String maGiangVienQuanLy, System.String namHoc, System.String maLopHocPhan, ref System.Int32 tongTietThucDay, ref System.Int32 tongTietTheoLich)
		{
			 KiemTraGioThucDay(transactionManager, 0, int.MaxValue , maGiangVienQuanLy, namHoc, maLopHocPhan, ref tongTietThucDay, ref tongTietTheoLich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayCaoDang_KiemTraGioThucDay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
			/// <param name="tongTietThucDay"> A <c>System.Int32</c> instance.</param>
			/// <param name="tongTietTheoLich"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraGioThucDay(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVienQuanLy, System.String namHoc, System.String maLopHocPhan, ref System.Int32 tongTietThucDay, ref System.Int32 tongTietTheoLich);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KhoiLuongGiangDayCaoDang&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KhoiLuongGiangDayCaoDang&gt;"/></returns>
		public static TList<KhoiLuongGiangDayCaoDang> Fill(IDataReader reader, TList<KhoiLuongGiangDayCaoDang> rows, int start, int pageLength)
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
				
				PMS.Entities.KhoiLuongGiangDayCaoDang c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KhoiLuongGiangDayCaoDang")
					.Append("|").Append((System.Int32)reader[((int)KhoiLuongGiangDayCaoDangColumn.MaKhoiLuongCaoDang - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KhoiLuongGiangDayCaoDang>(
					key.ToString(), // EntityTrackingKey
					"KhoiLuongGiangDayCaoDang",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KhoiLuongGiangDayCaoDang();
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
					c.MaKhoiLuongCaoDang = (System.Int32)reader[(KhoiLuongGiangDayCaoDangColumn.MaKhoiLuongCaoDang.ToString())];
					c.MaGiangVienQuanLy = (reader[KhoiLuongGiangDayCaoDangColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayCaoDangColumn.MaGiangVienQuanLy.ToString())];
					c.MaLopHocPhan = (reader[KhoiLuongGiangDayCaoDangColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayCaoDangColumn.MaLopHocPhan.ToString())];
					c.SiSoLop = (reader[KhoiLuongGiangDayCaoDangColumn.SiSoLop.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayCaoDangColumn.SiSoLop.ToString())];
					c.MaMonHoc = (reader[KhoiLuongGiangDayCaoDangColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayCaoDangColumn.MaMonHoc.ToString())];
					c.TietThucDayLt = (reader[KhoiLuongGiangDayCaoDangColumn.TietThucDayLt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayCaoDangColumn.TietThucDayLt.ToString())];
					c.TietThucDayTh = (reader[KhoiLuongGiangDayCaoDangColumn.TietThucDayTh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayCaoDangColumn.TietThucDayTh.ToString())];
					c.MaCauHinhChotGio = (reader[KhoiLuongGiangDayCaoDangColumn.MaCauHinhChotGio.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayCaoDangColumn.MaCauHinhChotGio.ToString())];
					c.TenLopHocPhan = (reader[KhoiLuongGiangDayCaoDangColumn.TenLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayCaoDangColumn.TenLopHocPhan.ToString())];
					c.MaLoaiGiangVien = (reader[KhoiLuongGiangDayCaoDangColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayCaoDangColumn.MaLoaiGiangVien.ToString())];
					c.MaHocHam = (reader[KhoiLuongGiangDayCaoDangColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayCaoDangColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KhoiLuongGiangDayCaoDangColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayCaoDangColumn.MaHocVi.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongGiangDayCaoDang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayCaoDang"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KhoiLuongGiangDayCaoDang entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKhoiLuongCaoDang = (System.Int32)reader[(KhoiLuongGiangDayCaoDangColumn.MaKhoiLuongCaoDang.ToString())];
			entity.MaGiangVienQuanLy = (reader[KhoiLuongGiangDayCaoDangColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayCaoDangColumn.MaGiangVienQuanLy.ToString())];
			entity.MaLopHocPhan = (reader[KhoiLuongGiangDayCaoDangColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayCaoDangColumn.MaLopHocPhan.ToString())];
			entity.SiSoLop = (reader[KhoiLuongGiangDayCaoDangColumn.SiSoLop.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayCaoDangColumn.SiSoLop.ToString())];
			entity.MaMonHoc = (reader[KhoiLuongGiangDayCaoDangColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayCaoDangColumn.MaMonHoc.ToString())];
			entity.TietThucDayLt = (reader[KhoiLuongGiangDayCaoDangColumn.TietThucDayLt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayCaoDangColumn.TietThucDayLt.ToString())];
			entity.TietThucDayTh = (reader[KhoiLuongGiangDayCaoDangColumn.TietThucDayTh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayCaoDangColumn.TietThucDayTh.ToString())];
			entity.MaCauHinhChotGio = (reader[KhoiLuongGiangDayCaoDangColumn.MaCauHinhChotGio.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayCaoDangColumn.MaCauHinhChotGio.ToString())];
			entity.TenLopHocPhan = (reader[KhoiLuongGiangDayCaoDangColumn.TenLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayCaoDangColumn.TenLopHocPhan.ToString())];
			entity.MaLoaiGiangVien = (reader[KhoiLuongGiangDayCaoDangColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayCaoDangColumn.MaLoaiGiangVien.ToString())];
			entity.MaHocHam = (reader[KhoiLuongGiangDayCaoDangColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayCaoDangColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KhoiLuongGiangDayCaoDangColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayCaoDangColumn.MaHocVi.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongGiangDayCaoDang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayCaoDang"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KhoiLuongGiangDayCaoDang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoiLuongCaoDang = (System.Int32)dataRow["MaKhoiLuongCaoDang"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.SiSoLop = Convert.IsDBNull(dataRow["SiSoLop"]) ? null : (System.Int32?)dataRow["SiSoLop"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TietThucDayLt = Convert.IsDBNull(dataRow["TietThucDayLT"]) ? null : (System.Int32?)dataRow["TietThucDayLT"];
			entity.TietThucDayTh = Convert.IsDBNull(dataRow["TietThucDayTH"]) ? null : (System.Int32?)dataRow["TietThucDayTH"];
			entity.MaCauHinhChotGio = Convert.IsDBNull(dataRow["MaCauHinhChotGio"]) ? null : (System.Int32?)dataRow["MaCauHinhChotGio"];
			entity.TenLopHocPhan = Convert.IsDBNull(dataRow["TenLopHocPhan"]) ? null : (System.String)dataRow["TenLopHocPhan"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayCaoDang"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongGiangDayCaoDang Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayCaoDang entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaCauHinhChotGioSource	
			if (CanDeepLoad(entity, "CauHinhChotGio|MaCauHinhChotGioSource", deepLoadType, innerList) 
				&& entity.MaCauHinhChotGioSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaCauHinhChotGio ?? (int)0);
				CauHinhChotGio tmpEntity = EntityManager.LocateEntity<CauHinhChotGio>(EntityLocator.ConstructKeyFromPkItems(typeof(CauHinhChotGio), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaCauHinhChotGioSource = tmpEntity;
				else
					entity.MaCauHinhChotGioSource = DataRepository.CauHinhChotGioProvider.GetByMaCauHinhChotGio(transactionManager, (entity.MaCauHinhChotGio ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaCauHinhChotGioSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaCauHinhChotGioSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CauHinhChotGioProvider.DeepLoad(transactionManager, entity.MaCauHinhChotGioSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaCauHinhChotGioSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaKhoiLuongCaoDang methods when available
			
			#region KhoiLuongQuyDoiCaoDangCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<KhoiLuongQuyDoiCaoDang>|KhoiLuongQuyDoiCaoDangCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'KhoiLuongQuyDoiCaoDangCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.KhoiLuongQuyDoiCaoDangCollection = DataRepository.KhoiLuongQuyDoiCaoDangProvider.GetByMaKhoiLuongCaoDang(transactionManager, entity.MaKhoiLuongCaoDang);

				if (deep && entity.KhoiLuongQuyDoiCaoDangCollection.Count > 0)
				{
					deepHandles.Add("KhoiLuongQuyDoiCaoDangCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<KhoiLuongQuyDoiCaoDang>) DataRepository.KhoiLuongQuyDoiCaoDangProvider.DeepLoad,
						new object[] { transactionManager, entity.KhoiLuongQuyDoiCaoDangCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.KhoiLuongGiangDayCaoDang object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KhoiLuongGiangDayCaoDang instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongGiangDayCaoDang Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayCaoDang entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaCauHinhChotGioSource
			if (CanDeepSave(entity, "CauHinhChotGio|MaCauHinhChotGioSource", deepSaveType, innerList) 
				&& entity.MaCauHinhChotGioSource != null)
			{
				DataRepository.CauHinhChotGioProvider.Save(transactionManager, entity.MaCauHinhChotGioSource);
				entity.MaCauHinhChotGio = entity.MaCauHinhChotGioSource.MaCauHinhChotGio;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<KhoiLuongQuyDoiCaoDang>
				if (CanDeepSave(entity.KhoiLuongQuyDoiCaoDangCollection, "List<KhoiLuongQuyDoiCaoDang>|KhoiLuongQuyDoiCaoDangCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(KhoiLuongQuyDoiCaoDang child in entity.KhoiLuongQuyDoiCaoDangCollection)
					{
						if(child.MaKhoiLuongCaoDangSource != null)
						{
							child.MaKhoiLuongCaoDang = child.MaKhoiLuongCaoDangSource.MaKhoiLuongCaoDang;
						}
						else
						{
							child.MaKhoiLuongCaoDang = entity.MaKhoiLuongCaoDang;
						}

					}

					if (entity.KhoiLuongQuyDoiCaoDangCollection.Count > 0 || entity.KhoiLuongQuyDoiCaoDangCollection.DeletedItems.Count > 0)
					{
						//DataRepository.KhoiLuongQuyDoiCaoDangProvider.Save(transactionManager, entity.KhoiLuongQuyDoiCaoDangCollection);
						
						deepHandles.Add("KhoiLuongQuyDoiCaoDangCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< KhoiLuongQuyDoiCaoDang >) DataRepository.KhoiLuongQuyDoiCaoDangProvider.DeepSave,
							new object[] { transactionManager, entity.KhoiLuongQuyDoiCaoDangCollection, deepSaveType, childTypes, innerList }
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
	
	#region KhoiLuongGiangDayCaoDangChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KhoiLuongGiangDayCaoDang</c>
	///</summary>
	public enum KhoiLuongGiangDayCaoDangChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CauHinhChotGio</c> at MaCauHinhChotGioSource
		///</summary>
		[ChildEntityType(typeof(CauHinhChotGio))]
		CauHinhChotGio,
		///<summary>
		/// Collection of <c>KhoiLuongGiangDayCaoDang</c> as OneToMany for KhoiLuongQuyDoiCaoDangCollection
		///</summary>
		[ChildEntityType(typeof(TList<KhoiLuongQuyDoiCaoDang>))]
		KhoiLuongQuyDoiCaoDangCollection,
	}
	
	#endregion KhoiLuongGiangDayCaoDangChildEntityTypes
	
	#region KhoiLuongGiangDayCaoDangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KhoiLuongGiangDayCaoDangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayCaoDang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayCaoDangFilterBuilder : SqlFilterBuilder<KhoiLuongGiangDayCaoDangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayCaoDangFilterBuilder class.
		/// </summary>
		public KhoiLuongGiangDayCaoDangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayCaoDangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongGiangDayCaoDangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayCaoDangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongGiangDayCaoDangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongGiangDayCaoDangFilterBuilder
	
	#region KhoiLuongGiangDayCaoDangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KhoiLuongGiangDayCaoDangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayCaoDang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayCaoDangParameterBuilder : ParameterizedSqlFilterBuilder<KhoiLuongGiangDayCaoDangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayCaoDangParameterBuilder class.
		/// </summary>
		public KhoiLuongGiangDayCaoDangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayCaoDangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongGiangDayCaoDangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayCaoDangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongGiangDayCaoDangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongGiangDayCaoDangParameterBuilder
	
	#region KhoiLuongGiangDayCaoDangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KhoiLuongGiangDayCaoDangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayCaoDang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KhoiLuongGiangDayCaoDangSortBuilder : SqlSortBuilder<KhoiLuongGiangDayCaoDangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayCaoDangSqlSortBuilder class.
		/// </summary>
		public KhoiLuongGiangDayCaoDangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KhoiLuongGiangDayCaoDangSortBuilder
	
} // end namespace
