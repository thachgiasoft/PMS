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
	/// This class is the base class for any <see cref="GiangVienHoatDongNgoaiGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienHoatDongNgoaiGiangDayProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienHoatDongNgoaiGiangDay, PMS.Entities.GiangVienHoatDongNgoaiGiangDayKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienHoatDongNgoaiGiangDayKey key)
		{
			return Delete(transactionManager, key.MaQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maQuanLy)
		{
			return Delete(null, _maQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maQuanLy);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoatDongNgoaiGiangDay_GiangVien key.
		///		FK_GiangVien_HoatDongNgoaiGiangDay_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongNgoaiGiangDay objects.</returns>
		public TList<GiangVienHoatDongNgoaiGiangDay> GetByMaGiangVien(System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoatDongNgoaiGiangDay_GiangVien key.
		///		FK_GiangVien_HoatDongNgoaiGiangDay_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongNgoaiGiangDay objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienHoatDongNgoaiGiangDay> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoatDongNgoaiGiangDay_GiangVien key.
		///		FK_GiangVien_HoatDongNgoaiGiangDay_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongNgoaiGiangDay objects.</returns>
		public TList<GiangVienHoatDongNgoaiGiangDay> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoatDongNgoaiGiangDay_GiangVien key.
		///		fkGiangVienHoatDongNgoaiGiangDayGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongNgoaiGiangDay objects.</returns>
		public TList<GiangVienHoatDongNgoaiGiangDay> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoatDongNgoaiGiangDay_GiangVien key.
		///		fkGiangVienHoatDongNgoaiGiangDayGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongNgoaiGiangDay objects.</returns>
		public TList<GiangVienHoatDongNgoaiGiangDay> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoatDongNgoaiGiangDay_GiangVien key.
		///		FK_GiangVien_HoatDongNgoaiGiangDay_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongNgoaiGiangDay objects.</returns>
		public abstract TList<GiangVienHoatDongNgoaiGiangDay> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoatDongNgoaiGiangDay_HoatDongNgoaiGiangDay key.
		///		FK_GiangVien_HoatDongNgoaiGiangDay_HoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="_maHoatDong"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongNgoaiGiangDay objects.</returns>
		public TList<GiangVienHoatDongNgoaiGiangDay> GetByMaHoatDong(System.Int32? _maHoatDong)
		{
			int count = -1;
			return GetByMaHoatDong(_maHoatDong, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoatDongNgoaiGiangDay_HoatDongNgoaiGiangDay key.
		///		FK_GiangVien_HoatDongNgoaiGiangDay_HoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoatDong"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongNgoaiGiangDay objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienHoatDongNgoaiGiangDay> GetByMaHoatDong(TransactionManager transactionManager, System.Int32? _maHoatDong)
		{
			int count = -1;
			return GetByMaHoatDong(transactionManager, _maHoatDong, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoatDongNgoaiGiangDay_HoatDongNgoaiGiangDay key.
		///		FK_GiangVien_HoatDongNgoaiGiangDay_HoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoatDong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongNgoaiGiangDay objects.</returns>
		public TList<GiangVienHoatDongNgoaiGiangDay> GetByMaHoatDong(TransactionManager transactionManager, System.Int32? _maHoatDong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHoatDong(transactionManager, _maHoatDong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoatDongNgoaiGiangDay_HoatDongNgoaiGiangDay key.
		///		fkGiangVienHoatDongNgoaiGiangDayHoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHoatDong"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongNgoaiGiangDay objects.</returns>
		public TList<GiangVienHoatDongNgoaiGiangDay> GetByMaHoatDong(System.Int32? _maHoatDong, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHoatDong(null, _maHoatDong, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoatDongNgoaiGiangDay_HoatDongNgoaiGiangDay key.
		///		fkGiangVienHoatDongNgoaiGiangDayHoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHoatDong"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongNgoaiGiangDay objects.</returns>
		public TList<GiangVienHoatDongNgoaiGiangDay> GetByMaHoatDong(System.Int32? _maHoatDong, int start, int pageLength,out int count)
		{
			return GetByMaHoatDong(null, _maHoatDong, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_HoatDongNgoaiGiangDay_HoatDongNgoaiGiangDay key.
		///		FK_GiangVien_HoatDongNgoaiGiangDay_HoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoatDong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienHoatDongNgoaiGiangDay objects.</returns>
		public abstract TList<GiangVienHoatDongNgoaiGiangDay> GetByMaHoatDong(TransactionManager transactionManager, System.Int32? _maHoatDong, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.GiangVienHoatDongNgoaiGiangDay Get(TransactionManager transactionManager, PMS.Entities.GiangVienHoatDongNgoaiGiangDayKey key, int start, int pageLength)
		{
			return GetByMaQuanLy(transactionManager, key.MaQuanLy, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiangVien_HoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.GiangVienHoatDongNgoaiGiangDay GetByMaQuanLy(System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_HoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.GiangVienHoatDongNgoaiGiangDay GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_HoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.GiangVienHoatDongNgoaiGiangDay GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_HoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.GiangVienHoatDongNgoaiGiangDay GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_HoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.GiangVienHoatDongNgoaiGiangDay GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_HoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienHoatDongNgoaiGiangDay"/> class.</returns>
		public abstract PMS.Entities.GiangVienHoatDongNgoaiGiangDay GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVien_HoatDongNgoaiGiangDay_KiemTraDuLieu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_KiemTraDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDuLieu(System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 KiemTraDuLieu(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_KiemTraDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDuLieu(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 KiemTraDuLieu(null, start, pageLength , namHoc, hocKy, maDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_KiemTraDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDuLieu(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 KiemTraDuLieu(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_KiemTraDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraDuLieu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_HoatDongNgoaiGiangDay_LayDuLieu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LayDuLieu(System.String namHoc, System.String hocKy, System.String maKhoa)
		{
			return LayDuLieu(null, 0, int.MaxValue , namHoc, hocKy, maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LayDuLieu(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maKhoa)
		{
			return LayDuLieu(null, start, pageLength , namHoc, hocKy, maKhoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LayDuLieu(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maKhoa)
		{
			return LayDuLieu(transactionManager, 0, int.MaxValue , namHoc, hocKy, maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader LayDuLieu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maKhoa);
		
		#endregion
		
		#region cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_GiangVien_HoatDongNgoaiGiangDay_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String maDonVi, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, maDonVi, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String maDonVi, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, maDonVi, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String maDonVi, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, maDonVi, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String maDonVi, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public TList<GiangVienHoatDongNgoaiGiangDay> GetByNamHoc(System.String namHoc)
		{
			return GetByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public TList<GiangVienHoatDongNgoaiGiangDay> GetByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return GetByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public TList<GiangVienHoatDongNgoaiGiangDay> GetByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return GetByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienHoatDongNgoaiGiangDay&gt;"/> instance.</returns>
		public abstract TList<GiangVienHoatDongNgoaiGiangDay> GetByNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoa(System.String namHoc, System.String hocKy, System.String maKhoa)
		{
			return GetByNamHocHocKyKhoa(null, 0, int.MaxValue , namHoc, hocKy, maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoa(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maKhoa)
		{
			return GetByNamHocHocKyKhoa(null, start, pageLength , namHoc, hocKy, maKhoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoa(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maKhoa)
		{
			return GetByNamHocHocKyKhoa(transactionManager, 0, int.MaxValue , namHoc, hocKy, maKhoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_HoatDongNgoaiGiangDay_GetByNamHocHocKyKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyKhoa(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maKhoa);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienHoatDongNgoaiGiangDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienHoatDongNgoaiGiangDay&gt;"/></returns>
		public static TList<GiangVienHoatDongNgoaiGiangDay> Fill(IDataReader reader, TList<GiangVienHoatDongNgoaiGiangDay> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienHoatDongNgoaiGiangDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienHoatDongNgoaiGiangDay")
					.Append("|").Append((System.Int32)reader[((int)GiangVienHoatDongNgoaiGiangDayColumn.MaQuanLy - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienHoatDongNgoaiGiangDay>(
					key.ToString(), // EntityTrackingKey
					"GiangVienHoatDongNgoaiGiangDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienHoatDongNgoaiGiangDay();
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
					c.MaQuanLy = (System.Int32)reader[(GiangVienHoatDongNgoaiGiangDayColumn.MaQuanLy.ToString())];
					c.NamHoc = (reader[GiangVienHoatDongNgoaiGiangDayColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongNgoaiGiangDayColumn.NamHoc.ToString())];
					c.HocKy = (reader[GiangVienHoatDongNgoaiGiangDayColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongNgoaiGiangDayColumn.HocKy.ToString())];
					c.MaGiangVien = (reader[GiangVienHoatDongNgoaiGiangDayColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienHoatDongNgoaiGiangDayColumn.MaGiangVien.ToString())];
					c.MaHoatDong = (reader[GiangVienHoatDongNgoaiGiangDayColumn.MaHoatDong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienHoatDongNgoaiGiangDayColumn.MaHoatDong.ToString())];
					c.SoLuong = (reader[GiangVienHoatDongNgoaiGiangDayColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienHoatDongNgoaiGiangDayColumn.SoLuong.ToString())];
					c.GhiChu = (reader[GiangVienHoatDongNgoaiGiangDayColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongNgoaiGiangDayColumn.GhiChu.ToString())];
					c.MaLop = (reader[GiangVienHoatDongNgoaiGiangDayColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongNgoaiGiangDayColumn.MaLop.ToString())];
					c.NgayChiTra = (reader[GiangVienHoatDongNgoaiGiangDayColumn.NgayChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongNgoaiGiangDayColumn.NgayChiTra.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienHoatDongNgoaiGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienHoatDongNgoaiGiangDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienHoatDongNgoaiGiangDay entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuanLy = (System.Int32)reader[(GiangVienHoatDongNgoaiGiangDayColumn.MaQuanLy.ToString())];
			entity.NamHoc = (reader[GiangVienHoatDongNgoaiGiangDayColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongNgoaiGiangDayColumn.NamHoc.ToString())];
			entity.HocKy = (reader[GiangVienHoatDongNgoaiGiangDayColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongNgoaiGiangDayColumn.HocKy.ToString())];
			entity.MaGiangVien = (reader[GiangVienHoatDongNgoaiGiangDayColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienHoatDongNgoaiGiangDayColumn.MaGiangVien.ToString())];
			entity.MaHoatDong = (reader[GiangVienHoatDongNgoaiGiangDayColumn.MaHoatDong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienHoatDongNgoaiGiangDayColumn.MaHoatDong.ToString())];
			entity.SoLuong = (reader[GiangVienHoatDongNgoaiGiangDayColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienHoatDongNgoaiGiangDayColumn.SoLuong.ToString())];
			entity.GhiChu = (reader[GiangVienHoatDongNgoaiGiangDayColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongNgoaiGiangDayColumn.GhiChu.ToString())];
			entity.MaLop = (reader[GiangVienHoatDongNgoaiGiangDayColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongNgoaiGiangDayColumn.MaLop.ToString())];
			entity.NgayChiTra = (reader[GiangVienHoatDongNgoaiGiangDayColumn.NgayChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienHoatDongNgoaiGiangDayColumn.NgayChiTra.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienHoatDongNgoaiGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienHoatDongNgoaiGiangDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienHoatDongNgoaiGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (System.Int32)dataRow["MaQuanLy"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaHoatDong = Convert.IsDBNull(dataRow["MaHoatDong"]) ? null : (System.Int32?)dataRow["MaHoatDong"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Decimal?)dataRow["SoLuong"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.NgayChiTra = Convert.IsDBNull(dataRow["NgayChiTra"]) ? null : (System.String)dataRow["NgayChiTra"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienHoatDongNgoaiGiangDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienHoatDongNgoaiGiangDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienHoatDongNgoaiGiangDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaGiangVienSource	
			if (CanDeepLoad(entity, "GiangVien|MaGiangVienSource", deepLoadType, innerList) 
				&& entity.MaGiangVienSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaGiangVien ?? (int)0);
				GiangVien tmpEntity = EntityManager.LocateEntity<GiangVien>(EntityLocator.ConstructKeyFromPkItems(typeof(GiangVien), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaGiangVienSource = tmpEntity;
				else
					entity.MaGiangVienSource = DataRepository.GiangVienProvider.GetByMaGiangVien(transactionManager, (entity.MaGiangVien ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaGiangVienSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaGiangVienSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GiangVienProvider.DeepLoad(transactionManager, entity.MaGiangVienSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaGiangVienSource

			#region MaHoatDongSource	
			if (CanDeepLoad(entity, "HoatDongNgoaiGiangDay|MaHoatDongSource", deepLoadType, innerList) 
				&& entity.MaHoatDongSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaHoatDong ?? (int)0);
				HoatDongNgoaiGiangDay tmpEntity = EntityManager.LocateEntity<HoatDongNgoaiGiangDay>(EntityLocator.ConstructKeyFromPkItems(typeof(HoatDongNgoaiGiangDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaHoatDongSource = tmpEntity;
				else
					entity.MaHoatDongSource = DataRepository.HoatDongNgoaiGiangDayProvider.GetByMaQuanLy(transactionManager, (entity.MaHoatDong ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaHoatDongSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaHoatDongSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.HoatDongNgoaiGiangDayProvider.DeepLoad(transactionManager, entity.MaHoatDongSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaHoatDongSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaQuanLy methods when available
			
			#region QuyDoiHoatDongNgoaiGiangDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<QuyDoiHoatDongNgoaiGiangDay>|QuyDoiHoatDongNgoaiGiangDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'QuyDoiHoatDongNgoaiGiangDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.QuyDoiHoatDongNgoaiGiangDayCollection = DataRepository.QuyDoiHoatDongNgoaiGiangDayProvider.GetByMaHoatDongNgoaiGiangDay(transactionManager, entity.MaQuanLy);

				if (deep && entity.QuyDoiHoatDongNgoaiGiangDayCollection.Count > 0)
				{
					deepHandles.Add("QuyDoiHoatDongNgoaiGiangDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<QuyDoiHoatDongNgoaiGiangDay>) DataRepository.QuyDoiHoatDongNgoaiGiangDayProvider.DeepLoad,
						new object[] { transactionManager, entity.QuyDoiHoatDongNgoaiGiangDayCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienHoatDongNgoaiGiangDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienHoatDongNgoaiGiangDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienHoatDongNgoaiGiangDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienHoatDongNgoaiGiangDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaGiangVienSource
			if (CanDeepSave(entity, "GiangVien|MaGiangVienSource", deepSaveType, innerList) 
				&& entity.MaGiangVienSource != null)
			{
				DataRepository.GiangVienProvider.Save(transactionManager, entity.MaGiangVienSource);
				entity.MaGiangVien = entity.MaGiangVienSource.MaGiangVien;
			}
			#endregion 
			
			#region MaHoatDongSource
			if (CanDeepSave(entity, "HoatDongNgoaiGiangDay|MaHoatDongSource", deepSaveType, innerList) 
				&& entity.MaHoatDongSource != null)
			{
				DataRepository.HoatDongNgoaiGiangDayProvider.Save(transactionManager, entity.MaHoatDongSource);
				entity.MaHoatDong = entity.MaHoatDongSource.MaQuanLy;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<QuyDoiHoatDongNgoaiGiangDay>
				if (CanDeepSave(entity.QuyDoiHoatDongNgoaiGiangDayCollection, "List<QuyDoiHoatDongNgoaiGiangDay>|QuyDoiHoatDongNgoaiGiangDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(QuyDoiHoatDongNgoaiGiangDay child in entity.QuyDoiHoatDongNgoaiGiangDayCollection)
					{
						if(child.MaHoatDongNgoaiGiangDaySource != null)
						{
							child.MaHoatDongNgoaiGiangDay = child.MaHoatDongNgoaiGiangDaySource.MaQuanLy;
						}
						else
						{
							child.MaHoatDongNgoaiGiangDay = entity.MaQuanLy;
						}

					}

					if (entity.QuyDoiHoatDongNgoaiGiangDayCollection.Count > 0 || entity.QuyDoiHoatDongNgoaiGiangDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.QuyDoiHoatDongNgoaiGiangDayProvider.Save(transactionManager, entity.QuyDoiHoatDongNgoaiGiangDayCollection);
						
						deepHandles.Add("QuyDoiHoatDongNgoaiGiangDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< QuyDoiHoatDongNgoaiGiangDay >) DataRepository.QuyDoiHoatDongNgoaiGiangDayProvider.DeepSave,
							new object[] { transactionManager, entity.QuyDoiHoatDongNgoaiGiangDayCollection, deepSaveType, childTypes, innerList }
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
	
	#region GiangVienHoatDongNgoaiGiangDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienHoatDongNgoaiGiangDay</c>
	///</summary>
	public enum GiangVienHoatDongNgoaiGiangDayChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
		
		///<summary>
		/// Composite Property for <c>HoatDongNgoaiGiangDay</c> at MaHoatDongSource
		///</summary>
		[ChildEntityType(typeof(HoatDongNgoaiGiangDay))]
		HoatDongNgoaiGiangDay,
		///<summary>
		/// Collection of <c>GiangVienHoatDongNgoaiGiangDay</c> as OneToMany for QuyDoiHoatDongNgoaiGiangDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<QuyDoiHoatDongNgoaiGiangDay>))]
		QuyDoiHoatDongNgoaiGiangDayCollection,
	}
	
	#endregion GiangVienHoatDongNgoaiGiangDayChildEntityTypes
	
	#region GiangVienHoatDongNgoaiGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienHoatDongNgoaiGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoatDongNgoaiGiangDayFilterBuilder : SqlFilterBuilder<GiangVienHoatDongNgoaiGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		public GiangVienHoatDongNgoaiGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienHoatDongNgoaiGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienHoatDongNgoaiGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienHoatDongNgoaiGiangDayFilterBuilder
	
	#region GiangVienHoatDongNgoaiGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienHoatDongNgoaiGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoatDongNgoaiGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienHoatDongNgoaiGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		public GiangVienHoatDongNgoaiGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienHoatDongNgoaiGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienHoatDongNgoaiGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienHoatDongNgoaiGiangDayParameterBuilder
	
	#region GiangVienHoatDongNgoaiGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienHoatDongNgoaiGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoatDongNgoaiGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienHoatDongNgoaiGiangDaySortBuilder : SqlSortBuilder<GiangVienHoatDongNgoaiGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongNgoaiGiangDaySqlSortBuilder class.
		/// </summary>
		public GiangVienHoatDongNgoaiGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienHoatDongNgoaiGiangDaySortBuilder
	
} // end namespace
