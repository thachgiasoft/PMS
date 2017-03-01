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
	/// This class is the base class for any <see cref="HoatDongNgoaiGiangDayClcProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HoatDongNgoaiGiangDayClcProviderBaseCore : EntityProviderBase<PMS.Entities.HoatDongNgoaiGiangDayClc, PMS.Entities.HoatDongNgoaiGiangDayClcKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HoatDongNgoaiGiangDayClcKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _id)
		{
			return Delete(null, _id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _id);		
		
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
		public override PMS.Entities.HoatDongNgoaiGiangDayClc Get(TransactionManager transactionManager, PMS.Entities.HoatDongNgoaiGiangDayClcKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HoatDongNgoaiGiangDayClc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoatDongNgoaiGiangDayClc"/> class.</returns>
		public PMS.Entities.HoatDongNgoaiGiangDayClc GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoatDongNgoaiGiangDayClc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoatDongNgoaiGiangDayClc"/> class.</returns>
		public PMS.Entities.HoatDongNgoaiGiangDayClc GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoatDongNgoaiGiangDayClc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoatDongNgoaiGiangDayClc"/> class.</returns>
		public PMS.Entities.HoatDongNgoaiGiangDayClc GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoatDongNgoaiGiangDayClc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoatDongNgoaiGiangDayClc"/> class.</returns>
		public PMS.Entities.HoatDongNgoaiGiangDayClc GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoatDongNgoaiGiangDayClc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoatDongNgoaiGiangDayClc"/> class.</returns>
		public PMS.Entities.HoatDongNgoaiGiangDayClc GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoatDongNgoaiGiangDayClc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoatDongNgoaiGiangDayClc"/> class.</returns>
		public abstract PMS.Entities.HoatDongNgoaiGiangDayClc GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HoatDongNgoaiGiangDayClc_KiemTraDuLieu 
		
		/// <summary>
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_KiemTraDuLieu' stored procedure. 
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
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_KiemTraDuLieu' stored procedure. 
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
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_KiemTraDuLieu' stored procedure. 
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
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_KiemTraDuLieu' stored procedure. 
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
		
		#region cust_HoatDongNgoaiGiangDayClc_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_HoatDongNgoaiGiangDayClc_LayDuLieu 
		
		/// <summary>
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieu(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 LayDuLieu(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieu(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 LayDuLieu(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieu(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 LayDuLieu(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_LayDuLieu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LayDuLieu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion
		
		#region cust_HoatDongNgoaiGiangDayClc_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, System.String khoaDonVi, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, khoaDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String khoaDonVi, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, khoaDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String khoaDonVi, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, khoaDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String khoaDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_HoatDongNgoaiGiangDayClc_GetByNamHocHocKyKhoaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyKhoaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyKhoaDonVi(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyKhoaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HoatDongNgoaiGiangDayClc_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyKhoaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HoatDongNgoaiGiangDayClc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HoatDongNgoaiGiangDayClc&gt;"/></returns>
		public static TList<HoatDongNgoaiGiangDayClc> Fill(IDataReader reader, TList<HoatDongNgoaiGiangDayClc> rows, int start, int pageLength)
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
				
				PMS.Entities.HoatDongNgoaiGiangDayClc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HoatDongNgoaiGiangDayClc")
					.Append("|").Append((System.Int32)reader[((int)HoatDongNgoaiGiangDayClcColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HoatDongNgoaiGiangDayClc>(
					key.ToString(), // EntityTrackingKey
					"HoatDongNgoaiGiangDayClc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HoatDongNgoaiGiangDayClc();
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
					c.Id = (System.Int32)reader[(HoatDongNgoaiGiangDayClcColumn.Id.ToString())];
					c.NamHoc = (reader[HoatDongNgoaiGiangDayClcColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoatDongNgoaiGiangDayClcColumn.NamHoc.ToString())];
					c.HocKy = (reader[HoatDongNgoaiGiangDayClcColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoatDongNgoaiGiangDayClcColumn.HocKy.ToString())];
					c.MaGiangVien = (reader[HoatDongNgoaiGiangDayClcColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HoatDongNgoaiGiangDayClcColumn.MaGiangVien.ToString())];
					c.MaLopHocPhan = (reader[HoatDongNgoaiGiangDayClcColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoatDongNgoaiGiangDayClcColumn.MaLopHocPhan.ToString())];
					c.MaHoatDong = (reader[HoatDongNgoaiGiangDayClcColumn.MaHoatDong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HoatDongNgoaiGiangDayClcColumn.MaHoatDong.ToString())];
					c.SoLuong = (reader[HoatDongNgoaiGiangDayClcColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HoatDongNgoaiGiangDayClcColumn.SoLuong.ToString())];
					c.SoTiet = (reader[HoatDongNgoaiGiangDayClcColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HoatDongNgoaiGiangDayClcColumn.SoTiet.ToString())];
					c.SoTien = (reader[HoatDongNgoaiGiangDayClcColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HoatDongNgoaiGiangDayClcColumn.SoTien.ToString())];
					c.GhiChu = (reader[HoatDongNgoaiGiangDayClcColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoatDongNgoaiGiangDayClcColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HoatDongNgoaiGiangDayClc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HoatDongNgoaiGiangDayClc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HoatDongNgoaiGiangDayClc entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(HoatDongNgoaiGiangDayClcColumn.Id.ToString())];
			entity.NamHoc = (reader[HoatDongNgoaiGiangDayClcColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoatDongNgoaiGiangDayClcColumn.NamHoc.ToString())];
			entity.HocKy = (reader[HoatDongNgoaiGiangDayClcColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoatDongNgoaiGiangDayClcColumn.HocKy.ToString())];
			entity.MaGiangVien = (reader[HoatDongNgoaiGiangDayClcColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HoatDongNgoaiGiangDayClcColumn.MaGiangVien.ToString())];
			entity.MaLopHocPhan = (reader[HoatDongNgoaiGiangDayClcColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoatDongNgoaiGiangDayClcColumn.MaLopHocPhan.ToString())];
			entity.MaHoatDong = (reader[HoatDongNgoaiGiangDayClcColumn.MaHoatDong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HoatDongNgoaiGiangDayClcColumn.MaHoatDong.ToString())];
			entity.SoLuong = (reader[HoatDongNgoaiGiangDayClcColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HoatDongNgoaiGiangDayClcColumn.SoLuong.ToString())];
			entity.SoTiet = (reader[HoatDongNgoaiGiangDayClcColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HoatDongNgoaiGiangDayClcColumn.SoTiet.ToString())];
			entity.SoTien = (reader[HoatDongNgoaiGiangDayClcColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HoatDongNgoaiGiangDayClcColumn.SoTien.ToString())];
			entity.GhiChu = (reader[HoatDongNgoaiGiangDayClcColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoatDongNgoaiGiangDayClcColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HoatDongNgoaiGiangDayClc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HoatDongNgoaiGiangDayClc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HoatDongNgoaiGiangDayClc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaHoatDong = Convert.IsDBNull(dataRow["MaHoatDong"]) ? null : (System.Int32?)dataRow["MaHoatDong"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Decimal?)dataRow["SoLuong"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.SoTien = Convert.IsDBNull(dataRow["SoTien"]) ? null : (System.Decimal?)dataRow["SoTien"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HoatDongNgoaiGiangDayClc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HoatDongNgoaiGiangDayClc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HoatDongNgoaiGiangDayClc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
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
		/// Deep Save the entire object graph of the PMS.Entities.HoatDongNgoaiGiangDayClc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HoatDongNgoaiGiangDayClc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HoatDongNgoaiGiangDayClc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HoatDongNgoaiGiangDayClc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HoatDongNgoaiGiangDayClcChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HoatDongNgoaiGiangDayClc</c>
	///</summary>
	public enum HoatDongNgoaiGiangDayClcChildEntityTypes
	{
	}
	
	#endregion HoatDongNgoaiGiangDayClcChildEntityTypes
	
	#region HoatDongNgoaiGiangDayClcFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HoatDongNgoaiGiangDayClcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongNgoaiGiangDayClc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoatDongNgoaiGiangDayClcFilterBuilder : SqlFilterBuilder<HoatDongNgoaiGiangDayClcColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayClcFilterBuilder class.
		/// </summary>
		public HoatDongNgoaiGiangDayClcFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayClcFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HoatDongNgoaiGiangDayClcFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayClcFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HoatDongNgoaiGiangDayClcFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HoatDongNgoaiGiangDayClcFilterBuilder
	
	#region HoatDongNgoaiGiangDayClcParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HoatDongNgoaiGiangDayClcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongNgoaiGiangDayClc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoatDongNgoaiGiangDayClcParameterBuilder : ParameterizedSqlFilterBuilder<HoatDongNgoaiGiangDayClcColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayClcParameterBuilder class.
		/// </summary>
		public HoatDongNgoaiGiangDayClcParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayClcParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HoatDongNgoaiGiangDayClcParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayClcParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HoatDongNgoaiGiangDayClcParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HoatDongNgoaiGiangDayClcParameterBuilder
	
	#region HoatDongNgoaiGiangDayClcSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HoatDongNgoaiGiangDayClcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongNgoaiGiangDayClc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HoatDongNgoaiGiangDayClcSortBuilder : SqlSortBuilder<HoatDongNgoaiGiangDayClcColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayClcSqlSortBuilder class.
		/// </summary>
		public HoatDongNgoaiGiangDayClcSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HoatDongNgoaiGiangDayClcSortBuilder
	
} // end namespace
