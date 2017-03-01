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
	/// This class is the base class for any <see cref="KhoiLuongGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KhoiLuongGiangDayProviderBaseCore : EntityProviderBase<PMS.Entities.KhoiLuongGiangDay, PMS.Entities.KhoiLuongGiangDayKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayKey key)
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
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongGiangDay_KetQuaTinh key.
		///		FK_KhoiLuongGiangDay_KetQuaTinh Description: 
		/// </summary>
		/// <param name="_maKetQua"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongGiangDay objects.</returns>
		public TList<KhoiLuongGiangDay> GetByMaKetQua(System.Int32? _maKetQua)
		{
			int count = -1;
			return GetByMaKetQua(_maKetQua, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongGiangDay_KetQuaTinh key.
		///		FK_KhoiLuongGiangDay_KetQuaTinh Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKetQua"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongGiangDay objects.</returns>
		/// <remarks></remarks>
		public TList<KhoiLuongGiangDay> GetByMaKetQua(TransactionManager transactionManager, System.Int32? _maKetQua)
		{
			int count = -1;
			return GetByMaKetQua(transactionManager, _maKetQua, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongGiangDay_KetQuaTinh key.
		///		FK_KhoiLuongGiangDay_KetQuaTinh Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKetQua"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongGiangDay objects.</returns>
		public TList<KhoiLuongGiangDay> GetByMaKetQua(TransactionManager transactionManager, System.Int32? _maKetQua, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKetQua(transactionManager, _maKetQua, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongGiangDay_KetQuaTinh key.
		///		fkKhoiLuongGiangDayKetQuaTinh Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maKetQua"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongGiangDay objects.</returns>
		public TList<KhoiLuongGiangDay> GetByMaKetQua(System.Int32? _maKetQua, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaKetQua(null, _maKetQua, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongGiangDay_KetQuaTinh key.
		///		fkKhoiLuongGiangDayKetQuaTinh Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maKetQua"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongGiangDay objects.</returns>
		public TList<KhoiLuongGiangDay> GetByMaKetQua(System.Int32? _maKetQua, int start, int pageLength,out int count)
		{
			return GetByMaKetQua(null, _maKetQua, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongGiangDay_KetQuaTinh key.
		///		FK_KhoiLuongGiangDay_KetQuaTinh Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKetQua"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongGiangDay objects.</returns>
		public abstract TList<KhoiLuongGiangDay> GetByMaKetQua(TransactionManager transactionManager, System.Int32? _maKetQua, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.KhoiLuongGiangDay Get(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayKey key, int start, int pageLength)
		{
			return GetByMaKhoiLuong(transactionManager, key.MaKhoiLuong, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDay GetByMaKhoiLuong(System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(null,_maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDay GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDay GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDay GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDay GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength, out int count)
		{
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDay"/> class.</returns>
		public abstract PMS.Entities.KhoiLuongGiangDay GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KhoiLuongGiangDay_GetByLoaiHocPhanNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_GetByLoaiHocPhanNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDay&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDay> GetByLoaiHocPhanNamHocHocKy(System.String loaiHocPhan, System.String namHoc, System.String hocKy)
		{
			return GetByLoaiHocPhanNamHocHocKy(null, 0, int.MaxValue , loaiHocPhan, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_GetByLoaiHocPhanNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDay&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDay> GetByLoaiHocPhanNamHocHocKy(int start, int pageLength, System.String loaiHocPhan, System.String namHoc, System.String hocKy)
		{
			return GetByLoaiHocPhanNamHocHocKy(null, start, pageLength , loaiHocPhan, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_GetByLoaiHocPhanNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDay&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDay> GetByLoaiHocPhanNamHocHocKy(TransactionManager transactionManager, System.String loaiHocPhan, System.String namHoc, System.String hocKy)
		{
			return GetByLoaiHocPhanNamHocHocKy(transactionManager, 0, int.MaxValue , loaiHocPhan, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_GetByLoaiHocPhanNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDay&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDay> GetByLoaiHocPhanNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String loaiHocPhan, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongGiangDay_DeleteByMaKetQua 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_DeleteByMaKetQua' stored procedure. 
		/// </summary>
		/// <param name="maKetQua"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByMaKetQua(System.Int32 maKetQua)
		{
			 DeleteByMaKetQua(null, 0, int.MaxValue , maKetQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_DeleteByMaKetQua' stored procedure. 
		/// </summary>
		/// <param name="maKetQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByMaKetQua(int start, int pageLength, System.Int32 maKetQua)
		{
			 DeleteByMaKetQua(null, start, pageLength , maKetQua);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_DeleteByMaKetQua' stored procedure. 
		/// </summary>
		/// <param name="maKetQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByMaKetQua(TransactionManager transactionManager, System.Int32 maKetQua)
		{
			 DeleteByMaKetQua(transactionManager, 0, int.MaxValue , maKetQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_DeleteByMaKetQua' stored procedure. 
		/// </summary>
		/// <param name="maKetQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DeleteByMaKetQua(TransactionManager transactionManager, int start, int pageLength , System.Int32 maKetQua);
		
		#endregion
		
		#region cust_KhoiLuongGiangDay_GetByMaLopMaLopHocPhan 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_GetByMaLopMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDay&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDay> GetByMaLopMaLopHocPhan(System.String maLop, System.String maLopHocPhan)
		{
			return GetByMaLopMaLopHocPhan(null, 0, int.MaxValue , maLop, maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_GetByMaLopMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDay&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDay> GetByMaLopMaLopHocPhan(int start, int pageLength, System.String maLop, System.String maLopHocPhan)
		{
			return GetByMaLopMaLopHocPhan(null, start, pageLength , maLop, maLopHocPhan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_GetByMaLopMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDay&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDay> GetByMaLopMaLopHocPhan(TransactionManager transactionManager, System.String maLop, System.String maLopHocPhan)
		{
			return GetByMaLopMaLopHocPhan(transactionManager, 0, int.MaxValue , maLop, maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_GetByMaLopMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDay&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDay> GetByMaLopMaLopHocPhan(TransactionManager transactionManager, int start, int pageLength , System.String maLop, System.String maLopHocPhan);
		
		#endregion
		
		#region cust_KhoiLuongGiangDay_GetByMaKetQuaMaLopHocPhan 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_GetByMaKetQuaMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maKetQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDay&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDay> GetByMaKetQuaMaLopHocPhan(System.Int32 maKetQua, System.String maLopHocPhan)
		{
			return GetByMaKetQuaMaLopHocPhan(null, 0, int.MaxValue , maKetQua, maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_GetByMaKetQuaMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maKetQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDay&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDay> GetByMaKetQuaMaLopHocPhan(int start, int pageLength, System.Int32 maKetQua, System.String maLopHocPhan)
		{
			return GetByMaKetQuaMaLopHocPhan(null, start, pageLength , maKetQua, maLopHocPhan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_GetByMaKetQuaMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maKetQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDay&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDay> GetByMaKetQuaMaLopHocPhan(TransactionManager transactionManager, System.Int32 maKetQua, System.String maLopHocPhan)
		{
			return GetByMaKetQuaMaLopHocPhan(transactionManager, 0, int.MaxValue , maKetQua, maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDay_GetByMaKetQuaMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maKetQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDay&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDay> GetByMaKetQuaMaLopHocPhan(TransactionManager transactionManager, int start, int pageLength , System.Int32 maKetQua, System.String maLopHocPhan);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KhoiLuongGiangDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KhoiLuongGiangDay&gt;"/></returns>
		public static TList<KhoiLuongGiangDay> Fill(IDataReader reader, TList<KhoiLuongGiangDay> rows, int start, int pageLength)
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
				
				PMS.Entities.KhoiLuongGiangDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KhoiLuongGiangDay")
					.Append("|").Append((System.Int32)reader[((int)KhoiLuongGiangDayColumn.MaKhoiLuong - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KhoiLuongGiangDay>(
					key.ToString(), // EntityTrackingKey
					"KhoiLuongGiangDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KhoiLuongGiangDay();
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
					c.MaKhoiLuong = (System.Int32)reader[(KhoiLuongGiangDayColumn.MaKhoiLuong.ToString())];
					c.MaKetQua = (reader[KhoiLuongGiangDayColumn.MaKetQua.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayColumn.MaKetQua.ToString())];
					c.MaToaNha = (reader[KhoiLuongGiangDayColumn.MaToaNha.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.MaToaNha.ToString())];
					c.MaLopHocPhan = (reader[KhoiLuongGiangDayColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.MaLopHocPhan.ToString())];
					c.MaLop = (reader[KhoiLuongGiangDayColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.MaLop.ToString())];
					c.MaNhom = (reader[KhoiLuongGiangDayColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.MaNhom.ToString())];
					c.LoaiHocPhan = (reader[KhoiLuongGiangDayColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.LoaiHocPhan.ToString())];
					c.PhanLoai = (reader[KhoiLuongGiangDayColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.PhanLoai.ToString())];
					c.MaMonHoc = (reader[KhoiLuongGiangDayColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.MaMonHoc.ToString())];
					c.DienGiai = (reader[KhoiLuongGiangDayColumn.DienGiai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.DienGiai.ToString())];
					c.SoTiet = (reader[KhoiLuongGiangDayColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.SoTiet.ToString())];
					c.SoTinChi = (reader[KhoiLuongGiangDayColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.SoTinChi.ToString())];
					c.SiSoLop = (reader[KhoiLuongGiangDayColumn.SiSoLop.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayColumn.SiSoLop.ToString())];
					c.SoNhom = (reader[KhoiLuongGiangDayColumn.SoNhom.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayColumn.SoNhom.ToString())];
					c.MaDiaDiem = (reader[KhoiLuongGiangDayColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.MaDiaDiem.ToString())];
					c.NgayBatDau = (reader[KhoiLuongGiangDayColumn.NgayBatDau.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayColumn.NgayBatDau.ToString())];
					c.NgayKetThuc = (reader[KhoiLuongGiangDayColumn.NgayKetThuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayColumn.NgayKetThuc.ToString())];
					c.ChatLuongCao = (reader[KhoiLuongGiangDayColumn.ChatLuongCao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.ChatLuongCao.ToString())];
					c.NgoaiGio = (reader[KhoiLuongGiangDayColumn.NgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.NgoaiGio.ToString())];
					c.TrongGio = (reader[KhoiLuongGiangDayColumn.TrongGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.TrongGio.ToString())];
					c.HeSoLopDong = (reader[KhoiLuongGiangDayColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.HeSoLopDong.ToString())];
					c.HeSoCoSo = (reader[KhoiLuongGiangDayColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.HeSoCoSo.ToString())];
					c.HeSoHocKy = (reader[KhoiLuongGiangDayColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.HeSoHocKy.ToString())];
					c.HeSoThanhPhan = (reader[KhoiLuongGiangDayColumn.HeSoThanhPhan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.HeSoThanhPhan.ToString())];
					c.HeSoTrongGio = (reader[KhoiLuongGiangDayColumn.HeSoTrongGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.HeSoTrongGio.ToString())];
					c.HeSoNgoaiGio = (reader[KhoiLuongGiangDayColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.HeSoNgoaiGio.ToString())];
					c.TietQuyDoi = (reader[KhoiLuongGiangDayColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.TietQuyDoi.ToString())];
					c.LoaiHocKy = (reader[KhoiLuongGiangDayColumn.LoaiHocKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayColumn.LoaiHocKy.ToString())];
					c.ThoiKhoaBieu = (reader[KhoiLuongGiangDayColumn.ThoiKhoaBieu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.ThoiKhoaBieu.ToString())];
					c.NgayTao = (reader[KhoiLuongGiangDayColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayColumn.NgayTao.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KhoiLuongGiangDay entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKhoiLuong = (System.Int32)reader[(KhoiLuongGiangDayColumn.MaKhoiLuong.ToString())];
			entity.MaKetQua = (reader[KhoiLuongGiangDayColumn.MaKetQua.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayColumn.MaKetQua.ToString())];
			entity.MaToaNha = (reader[KhoiLuongGiangDayColumn.MaToaNha.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.MaToaNha.ToString())];
			entity.MaLopHocPhan = (reader[KhoiLuongGiangDayColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.MaLopHocPhan.ToString())];
			entity.MaLop = (reader[KhoiLuongGiangDayColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.MaLop.ToString())];
			entity.MaNhom = (reader[KhoiLuongGiangDayColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.MaNhom.ToString())];
			entity.LoaiHocPhan = (reader[KhoiLuongGiangDayColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.LoaiHocPhan.ToString())];
			entity.PhanLoai = (reader[KhoiLuongGiangDayColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.PhanLoai.ToString())];
			entity.MaMonHoc = (reader[KhoiLuongGiangDayColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.MaMonHoc.ToString())];
			entity.DienGiai = (reader[KhoiLuongGiangDayColumn.DienGiai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.DienGiai.ToString())];
			entity.SoTiet = (reader[KhoiLuongGiangDayColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.SoTiet.ToString())];
			entity.SoTinChi = (reader[KhoiLuongGiangDayColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.SoTinChi.ToString())];
			entity.SiSoLop = (reader[KhoiLuongGiangDayColumn.SiSoLop.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayColumn.SiSoLop.ToString())];
			entity.SoNhom = (reader[KhoiLuongGiangDayColumn.SoNhom.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayColumn.SoNhom.ToString())];
			entity.MaDiaDiem = (reader[KhoiLuongGiangDayColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.MaDiaDiem.ToString())];
			entity.NgayBatDau = (reader[KhoiLuongGiangDayColumn.NgayBatDau.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayColumn.NgayBatDau.ToString())];
			entity.NgayKetThuc = (reader[KhoiLuongGiangDayColumn.NgayKetThuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayColumn.NgayKetThuc.ToString())];
			entity.ChatLuongCao = (reader[KhoiLuongGiangDayColumn.ChatLuongCao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.ChatLuongCao.ToString())];
			entity.NgoaiGio = (reader[KhoiLuongGiangDayColumn.NgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.NgoaiGio.ToString())];
			entity.TrongGio = (reader[KhoiLuongGiangDayColumn.TrongGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.TrongGio.ToString())];
			entity.HeSoLopDong = (reader[KhoiLuongGiangDayColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.HeSoLopDong.ToString())];
			entity.HeSoCoSo = (reader[KhoiLuongGiangDayColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.HeSoCoSo.ToString())];
			entity.HeSoHocKy = (reader[KhoiLuongGiangDayColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.HeSoHocKy.ToString())];
			entity.HeSoThanhPhan = (reader[KhoiLuongGiangDayColumn.HeSoThanhPhan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.HeSoThanhPhan.ToString())];
			entity.HeSoTrongGio = (reader[KhoiLuongGiangDayColumn.HeSoTrongGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.HeSoTrongGio.ToString())];
			entity.HeSoNgoaiGio = (reader[KhoiLuongGiangDayColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.HeSoNgoaiGio.ToString())];
			entity.TietQuyDoi = (reader[KhoiLuongGiangDayColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayColumn.TietQuyDoi.ToString())];
			entity.LoaiHocKy = (reader[KhoiLuongGiangDayColumn.LoaiHocKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayColumn.LoaiHocKy.ToString())];
			entity.ThoiKhoaBieu = (reader[KhoiLuongGiangDayColumn.ThoiKhoaBieu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayColumn.ThoiKhoaBieu.ToString())];
			entity.NgayTao = (reader[KhoiLuongGiangDayColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayColumn.NgayTao.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KhoiLuongGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoiLuong = (System.Int32)dataRow["MaKhoiLuong"];
			entity.MaKetQua = Convert.IsDBNull(dataRow["MaKetQua"]) ? null : (System.Int32?)dataRow["MaKetQua"];
			entity.MaToaNha = Convert.IsDBNull(dataRow["MaToaNha"]) ? null : (System.String)dataRow["MaToaNha"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.MaNhom = Convert.IsDBNull(dataRow["MaNhom"]) ? null : (System.String)dataRow["MaNhom"];
			entity.LoaiHocPhan = Convert.IsDBNull(dataRow["LoaiHocPhan"]) ? null : (System.String)dataRow["LoaiHocPhan"];
			entity.PhanLoai = Convert.IsDBNull(dataRow["PhanLoai"]) ? null : (System.String)dataRow["PhanLoai"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.DienGiai = Convert.IsDBNull(dataRow["DienGiai"]) ? null : (System.String)dataRow["DienGiai"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Decimal?)dataRow["SoTinChi"];
			entity.SiSoLop = Convert.IsDBNull(dataRow["SiSoLop"]) ? null : (System.Int32?)dataRow["SiSoLop"];
			entity.SoNhom = Convert.IsDBNull(dataRow["SoNhom"]) ? null : (System.Int32?)dataRow["SoNhom"];
			entity.MaDiaDiem = Convert.IsDBNull(dataRow["MaDiaDiem"]) ? null : (System.String)dataRow["MaDiaDiem"];
			entity.NgayBatDau = Convert.IsDBNull(dataRow["NgayBatDau"]) ? null : (System.DateTime?)dataRow["NgayBatDau"];
			entity.NgayKetThuc = Convert.IsDBNull(dataRow["NgayKetThuc"]) ? null : (System.DateTime?)dataRow["NgayKetThuc"];
			entity.ChatLuongCao = Convert.IsDBNull(dataRow["ChatLuongCao"]) ? null : (System.Decimal?)dataRow["ChatLuongCao"];
			entity.NgoaiGio = Convert.IsDBNull(dataRow["NgoaiGio"]) ? null : (System.Decimal?)dataRow["NgoaiGio"];
			entity.TrongGio = Convert.IsDBNull(dataRow["TrongGio"]) ? null : (System.Decimal?)dataRow["TrongGio"];
			entity.HeSoLopDong = Convert.IsDBNull(dataRow["HeSoLopDong"]) ? null : (System.Decimal?)dataRow["HeSoLopDong"];
			entity.HeSoCoSo = Convert.IsDBNull(dataRow["HeSoCoSo"]) ? null : (System.Decimal?)dataRow["HeSoCoSo"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
			entity.HeSoThanhPhan = Convert.IsDBNull(dataRow["HeSoThanhPhan"]) ? null : (System.Decimal?)dataRow["HeSoThanhPhan"];
			entity.HeSoTrongGio = Convert.IsDBNull(dataRow["HeSoTrongGio"]) ? null : (System.Decimal?)dataRow["HeSoTrongGio"];
			entity.HeSoNgoaiGio = Convert.IsDBNull(dataRow["HeSoNgoaiGio"]) ? null : (System.Decimal?)dataRow["HeSoNgoaiGio"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.LoaiHocKy = Convert.IsDBNull(dataRow["LoaiHocKy"]) ? null : (System.Int32?)dataRow["LoaiHocKy"];
			entity.ThoiKhoaBieu = Convert.IsDBNull(dataRow["ThoiKhoaBieu"]) ? null : (System.String)dataRow["ThoiKhoaBieu"];
			entity.NgayTao = Convert.IsDBNull(dataRow["NgayTao"]) ? null : (System.DateTime?)dataRow["NgayTao"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongGiangDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaKetQuaSource	
			if (CanDeepLoad(entity, "KetQuaTinh|MaKetQuaSource", deepLoadType, innerList) 
				&& entity.MaKetQuaSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaKetQua ?? (int)0);
				KetQuaTinh tmpEntity = EntityManager.LocateEntity<KetQuaTinh>(EntityLocator.ConstructKeyFromPkItems(typeof(KetQuaTinh), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaKetQuaSource = tmpEntity;
				else
					entity.MaKetQuaSource = DataRepository.KetQuaTinhProvider.GetByMaKetQua(transactionManager, (entity.MaKetQua ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaKetQuaSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaKetQuaSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.KetQuaTinhProvider.DeepLoad(transactionManager, entity.MaKetQuaSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaKetQuaSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
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
		/// Deep Save the entire object graph of the PMS.Entities.KhoiLuongGiangDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KhoiLuongGiangDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongGiangDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaKetQuaSource
			if (CanDeepSave(entity, "KetQuaTinh|MaKetQuaSource", deepSaveType, innerList) 
				&& entity.MaKetQuaSource != null)
			{
				DataRepository.KetQuaTinhProvider.Save(transactionManager, entity.MaKetQuaSource);
				entity.MaKetQua = entity.MaKetQuaSource.MaKetQua;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
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
	
	#region KhoiLuongGiangDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KhoiLuongGiangDay</c>
	///</summary>
	public enum KhoiLuongGiangDayChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>KetQuaTinh</c> at MaKetQuaSource
		///</summary>
		[ChildEntityType(typeof(KetQuaTinh))]
		KetQuaTinh,
	}
	
	#endregion KhoiLuongGiangDayChildEntityTypes
	
	#region KhoiLuongGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KhoiLuongGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayFilterBuilder : SqlFilterBuilder<KhoiLuongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		public KhoiLuongGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongGiangDayFilterBuilder
	
	#region KhoiLuongGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KhoiLuongGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<KhoiLuongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		public KhoiLuongGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongGiangDayParameterBuilder
	
	#region KhoiLuongGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KhoiLuongGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KhoiLuongGiangDaySortBuilder : SqlSortBuilder<KhoiLuongGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDaySqlSortBuilder class.
		/// </summary>
		public KhoiLuongGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KhoiLuongGiangDaySortBuilder
	
} // end namespace
