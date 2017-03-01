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
	/// This class is the base class for any <see cref="HeSoCoSoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoCoSoProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoCoSo, PMS.Entities.HeSoCoSoKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoCoSoKey key)
		{
			return Delete(transactionManager, key.MaHeSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maHeSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maHeSo)
		{
			return Delete(null, _maHeSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maHeSo);		
		
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
		public override PMS.Entities.HeSoCoSo Get(TransactionManager transactionManager, PMS.Entities.HeSoCoSoKey key, int start, int pageLength)
		{
			return GetByMaHeSo(transactionManager, key.MaHeSo, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeSoCoSo index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoCoSo"/> class.</returns>
		public PMS.Entities.HeSoCoSo GetByMaHeSo(System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(null,_maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoCoSo index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoCoSo"/> class.</returns>
		public PMS.Entities.HeSoCoSo GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoCoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoCoSo"/> class.</returns>
		public PMS.Entities.HeSoCoSo GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoCoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoCoSo"/> class.</returns>
		public PMS.Entities.HeSoCoSo GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoCoSo index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoCoSo"/> class.</returns>
		public PMS.Entities.HeSoCoSo GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength, out int count)
		{
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoCoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoCoSo"/> class.</returns>
		public abstract PMS.Entities.HeSoCoSo GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HeSoCoSo_GetByNamHocHocKyMaBacDaoTaoPhongThuTietBatDau 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByNamHocHocKyMaBacDaoTaoPhongThuTietBatDau' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="phong"> A <c>System.String</c> instance.</param>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKyMaBacDaoTaoPhongThuTietBatDau(System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String phong, System.String thu, System.Int32 tietBatDau, ref System.Double heSo)
		{
			 GetByNamHocHocKyMaBacDaoTaoPhongThuTietBatDau(null, 0, int.MaxValue , namHoc, hocKy, maBacDaoTao, phong, thu, tietBatDau, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByNamHocHocKyMaBacDaoTaoPhongThuTietBatDau' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="phong"> A <c>System.String</c> instance.</param>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKyMaBacDaoTaoPhongThuTietBatDau(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String phong, System.String thu, System.Int32 tietBatDau, ref System.Double heSo)
		{
			 GetByNamHocHocKyMaBacDaoTaoPhongThuTietBatDau(null, start, pageLength , namHoc, hocKy, maBacDaoTao, phong, thu, tietBatDau, ref heSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByNamHocHocKyMaBacDaoTaoPhongThuTietBatDau' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="phong"> A <c>System.String</c> instance.</param>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKyMaBacDaoTaoPhongThuTietBatDau(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String phong, System.String thu, System.Int32 tietBatDau, ref System.Double heSo)
		{
			 GetByNamHocHocKyMaBacDaoTaoPhongThuTietBatDau(transactionManager, 0, int.MaxValue , namHoc, hocKy, maBacDaoTao, phong, thu, tietBatDau, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByNamHocHocKyMaBacDaoTaoPhongThuTietBatDau' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="phong"> A <c>System.String</c> instance.</param>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByNamHocHocKyMaBacDaoTaoPhongThuTietBatDau(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String phong, System.String thu, System.Int32 tietBatDau, ref System.Double heSo);
		
		#endregion
		
		#region cust_HeSoCoSo_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCoSo&gt;"/> instance.</returns>
		public TList<HeSoCoSo> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCoSo&gt;"/> instance.</returns>
		public TList<HeSoCoSo> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCoSo&gt;"/> instance.</returns>
		public TList<HeSoCoSo> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCoSo&gt;"/> instance.</returns>
		public abstract TList<HeSoCoSo> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_HeSoCoSo_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(null, 0, int.MaxValue , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(int start, int pageLength, System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(null, start, pageLength , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(TransactionManager transactionManager, System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(transactionManager, 0, int.MaxValue , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void SaoChep(TransactionManager transactionManager, int start, int pageLength , System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich);
		
		#endregion
		
		#region cust_HeSoCoSo_GetByMaPhongHocNgayDayByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByMaPhongHocNgayDayByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCoSo&gt;"/> instance.</returns>
		public TList<HeSoCoSo> GetByMaPhongHocNgayDayByNamHocHocKy(System.String namHoc, System.String hocKy, System.String maPhongHoc, System.DateTime ngayDay)
		{
			return GetByMaPhongHocNgayDayByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy, maPhongHoc, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByMaPhongHocNgayDayByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCoSo&gt;"/> instance.</returns>
		public TList<HeSoCoSo> GetByMaPhongHocNgayDayByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maPhongHoc, System.DateTime ngayDay)
		{
			return GetByMaPhongHocNgayDayByNamHocHocKy(null, start, pageLength , namHoc, hocKy, maPhongHoc, ngayDay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByMaPhongHocNgayDayByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCoSo&gt;"/> instance.</returns>
		public TList<HeSoCoSo> GetByMaPhongHocNgayDayByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maPhongHoc, System.DateTime ngayDay)
		{
			return GetByMaPhongHocNgayDayByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, maPhongHoc, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByMaPhongHocNgayDayByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCoSo&gt;"/> instance.</returns>
		public abstract TList<HeSoCoSo> GetByMaPhongHocNgayDayByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maPhongHoc, System.DateTime ngayDay);
		
		#endregion
		
		#region cust_HeSoCoSo_GetByMaPhongHocNgayDay 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByMaPhongHocNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCoSo&gt;"/> instance.</returns>
		public TList<HeSoCoSo> GetByMaPhongHocNgayDay(System.String maPhongHoc, System.DateTime ngayDay)
		{
			return GetByMaPhongHocNgayDay(null, 0, int.MaxValue , maPhongHoc, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByMaPhongHocNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCoSo&gt;"/> instance.</returns>
		public TList<HeSoCoSo> GetByMaPhongHocNgayDay(int start, int pageLength, System.String maPhongHoc, System.DateTime ngayDay)
		{
			return GetByMaPhongHocNgayDay(null, start, pageLength , maPhongHoc, ngayDay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByMaPhongHocNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCoSo&gt;"/> instance.</returns>
		public TList<HeSoCoSo> GetByMaPhongHocNgayDay(TransactionManager transactionManager, System.String maPhongHoc, System.DateTime ngayDay)
		{
			return GetByMaPhongHocNgayDay(transactionManager, 0, int.MaxValue , maPhongHoc, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCoSo_GetByMaPhongHocNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maPhongHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCoSo&gt;"/> instance.</returns>
		public abstract TList<HeSoCoSo> GetByMaPhongHocNgayDay(TransactionManager transactionManager, int start, int pageLength , System.String maPhongHoc, System.DateTime ngayDay);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoCoSo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoCoSo&gt;"/></returns>
		public static TList<HeSoCoSo> Fill(IDataReader reader, TList<HeSoCoSo> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoCoSo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoCoSo")
					.Append("|").Append((System.Int32)reader[((int)HeSoCoSoColumn.MaHeSo - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoCoSo>(
					key.ToString(), // EntityTrackingKey
					"HeSoCoSo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoCoSo();
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
					c.MaHeSo = (System.Int32)reader[(HeSoCoSoColumn.MaHeSo.ToString())];
					c.MaQuanLy = (reader[HeSoCoSoColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCoSoColumn.MaQuanLy.ToString())];
					c.MaCoSo = (reader[HeSoCoSoColumn.MaCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCoSoColumn.MaCoSo.ToString())];
					c.HeSo = (reader[HeSoCoSoColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoCoSoColumn.HeSo.ToString())];
					c.ThuTu = (reader[HeSoCoSoColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoCoSoColumn.ThuTu.ToString())];
					c.NgayBdApDung = (reader[HeSoCoSoColumn.NgayBdApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoCoSoColumn.NgayBdApDung.ToString())];
					c.NgayKtApDung = (reader[HeSoCoSoColumn.NgayKtApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoCoSoColumn.NgayKtApDung.ToString())];
					c.ThoiGianHoc = (reader[HeSoCoSoColumn.ThoiGianHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCoSoColumn.ThoiGianHoc.ToString())];
					c.NamHoc = (reader[HeSoCoSoColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCoSoColumn.NamHoc.ToString())];
					c.HocKy = (reader[HeSoCoSoColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCoSoColumn.HocKy.ToString())];
					c.GhiChu = (reader[HeSoCoSoColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCoSoColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoCoSo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoCoSo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoCoSo entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHeSo = (System.Int32)reader[(HeSoCoSoColumn.MaHeSo.ToString())];
			entity.MaQuanLy = (reader[HeSoCoSoColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCoSoColumn.MaQuanLy.ToString())];
			entity.MaCoSo = (reader[HeSoCoSoColumn.MaCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCoSoColumn.MaCoSo.ToString())];
			entity.HeSo = (reader[HeSoCoSoColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoCoSoColumn.HeSo.ToString())];
			entity.ThuTu = (reader[HeSoCoSoColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoCoSoColumn.ThuTu.ToString())];
			entity.NgayBdApDung = (reader[HeSoCoSoColumn.NgayBdApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoCoSoColumn.NgayBdApDung.ToString())];
			entity.NgayKtApDung = (reader[HeSoCoSoColumn.NgayKtApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoCoSoColumn.NgayKtApDung.ToString())];
			entity.ThoiGianHoc = (reader[HeSoCoSoColumn.ThoiGianHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCoSoColumn.ThoiGianHoc.ToString())];
			entity.NamHoc = (reader[HeSoCoSoColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCoSoColumn.NamHoc.ToString())];
			entity.HocKy = (reader[HeSoCoSoColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCoSoColumn.HocKy.ToString())];
			entity.GhiChu = (reader[HeSoCoSoColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCoSoColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoCoSo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoCoSo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoCoSo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHeSo = (System.Int32)dataRow["MaHeSo"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.MaCoSo = Convert.IsDBNull(dataRow["MaCoSo"]) ? null : (System.String)dataRow["MaCoSo"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.ThuTu = Convert.IsDBNull(dataRow["ThuTu"]) ? null : (System.Int32?)dataRow["ThuTu"];
			entity.NgayBdApDung = Convert.IsDBNull(dataRow["NgayBDApDung"]) ? null : (System.DateTime?)dataRow["NgayBDApDung"];
			entity.NgayKtApDung = Convert.IsDBNull(dataRow["NgayKTApDung"]) ? null : (System.DateTime?)dataRow["NgayKTApDung"];
			entity.ThoiGianHoc = Convert.IsDBNull(dataRow["ThoiGianHoc"]) ? null : (System.String)dataRow["ThoiGianHoc"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoCoSo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoCoSo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoCoSo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoCoSo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoCoSo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoCoSo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoCoSo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HeSoCoSoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoCoSo</c>
	///</summary>
	public enum HeSoCoSoChildEntityTypes
	{
	}
	
	#endregion HeSoCoSoChildEntityTypes
	
	#region HeSoCoSoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoCoSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoCoSoFilterBuilder : SqlFilterBuilder<HeSoCoSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoCoSoFilterBuilder class.
		/// </summary>
		public HeSoCoSoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoCoSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoCoSoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoCoSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoCoSoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoCoSoFilterBuilder
	
	#region HeSoCoSoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoCoSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoCoSoParameterBuilder : ParameterizedSqlFilterBuilder<HeSoCoSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoCoSoParameterBuilder class.
		/// </summary>
		public HeSoCoSoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoCoSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoCoSoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoCoSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoCoSoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoCoSoParameterBuilder
	
	#region HeSoCoSoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoCoSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCoSo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoCoSoSortBuilder : SqlSortBuilder<HeSoCoSoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoCoSoSqlSortBuilder class.
		/// </summary>
		public HeSoCoSoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoCoSoSortBuilder
	
} // end namespace
