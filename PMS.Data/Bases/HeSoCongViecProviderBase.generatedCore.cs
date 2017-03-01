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
	/// This class is the base class for any <see cref="HeSoCongViecProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoCongViecProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoCongViec, PMS.Entities.HeSoCongViecKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoCongViecKey key)
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
		public override PMS.Entities.HeSoCongViec Get(TransactionManager transactionManager, PMS.Entities.HeSoCongViecKey key, int start, int pageLength)
		{
			return GetByMaHeSo(transactionManager, key.MaHeSo, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeSoCongViec index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoCongViec"/> class.</returns>
		public PMS.Entities.HeSoCongViec GetByMaHeSo(System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(null,_maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoCongViec index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoCongViec"/> class.</returns>
		public PMS.Entities.HeSoCongViec GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoCongViec index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoCongViec"/> class.</returns>
		public PMS.Entities.HeSoCongViec GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoCongViec index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoCongViec"/> class.</returns>
		public PMS.Entities.HeSoCongViec GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoCongViec index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoCongViec"/> class.</returns>
		public PMS.Entities.HeSoCongViec GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength, out int count)
		{
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoCongViec index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoCongViec"/> class.</returns>
		public abstract PMS.Entities.HeSoCongViec GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HeSoCongViec_GetHeSoNienCheTinChi 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNienCheTinChi' stored procedure. 
		/// </summary>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNienCheTinChi(System.Boolean daoTaoTinChi, ref System.Double reVal)
		{
			 GetHeSoNienCheTinChi(null, 0, int.MaxValue , daoTaoTinChi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNienCheTinChi' stored procedure. 
		/// </summary>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNienCheTinChi(int start, int pageLength, System.Boolean daoTaoTinChi, ref System.Double reVal)
		{
			 GetHeSoNienCheTinChi(null, start, pageLength , daoTaoTinChi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNienCheTinChi' stored procedure. 
		/// </summary>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNienCheTinChi(TransactionManager transactionManager, System.Boolean daoTaoTinChi, ref System.Double reVal)
		{
			 GetHeSoNienCheTinChi(transactionManager, 0, int.MaxValue , daoTaoTinChi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNienCheTinChi' stored procedure. 
		/// </summary>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetHeSoNienCheTinChi(TransactionManager transactionManager, int start, int pageLength , System.Boolean daoTaoTinChi, ref System.Double reVal);
		
		#endregion
		
		#region cust_HeSoCongViec_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCongViec&gt;"/> instance.</returns>
		public TList<HeSoCongViec> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCongViec&gt;"/> instance.</returns>
		public TList<HeSoCongViec> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCongViec&gt;"/> instance.</returns>
		public TList<HeSoCongViec> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCongViec&gt;"/> instance.</returns>
		public abstract TList<HeSoCongViec> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_HeSoCongViec_GetHeSoNienCheTinChiByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNienCheTinChiByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNienCheTinChiByNamHocHocKy(System.String namHoc, System.String hocKy, System.Boolean daoTaoTinChi, ref System.Double reVal)
		{
			 GetHeSoNienCheTinChiByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy, daoTaoTinChi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNienCheTinChiByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNienCheTinChiByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.Boolean daoTaoTinChi, ref System.Double reVal)
		{
			 GetHeSoNienCheTinChiByNamHocHocKy(null, start, pageLength , namHoc, hocKy, daoTaoTinChi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNienCheTinChiByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNienCheTinChiByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Boolean daoTaoTinChi, ref System.Double reVal)
		{
			 GetHeSoNienCheTinChiByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, daoTaoTinChi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNienCheTinChiByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="daoTaoTinChi"> A <c>System.Boolean</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetHeSoNienCheTinChiByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Boolean daoTaoTinChi, ref System.Double reVal);
		
		#endregion
		
		#region cust_HeSoCongViec_GetHeSoNgonNguGiangDayByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNgonNguGiangDayByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="ngonNgu"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNgonNguGiangDayByNamHocHocKy(System.String namHoc, System.String hocKy, System.String ngonNgu, ref System.Double reVal)
		{
			 GetHeSoNgonNguGiangDayByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy, ngonNgu, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNgonNguGiangDayByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="ngonNgu"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNgonNguGiangDayByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String ngonNgu, ref System.Double reVal)
		{
			 GetHeSoNgonNguGiangDayByNamHocHocKy(null, start, pageLength , namHoc, hocKy, ngonNgu, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNgonNguGiangDayByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="ngonNgu"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNgonNguGiangDayByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String ngonNgu, ref System.Double reVal)
		{
			 GetHeSoNgonNguGiangDayByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, ngonNgu, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNgonNguGiangDayByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="ngonNgu"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetHeSoNgonNguGiangDayByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String ngonNgu, ref System.Double reVal);
		
		#endregion
		
		#region cust_HeSoCongViec_GetHeSoGiangDayNgoaiGioByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoGiangDayNgoaiGioByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoGiangDayNgoaiGioByNamHocHocKy(System.String namHoc, System.String hocKy, System.String thu, System.Int32 tietBatDau, ref System.Double reVal)
		{
			 GetHeSoGiangDayNgoaiGioByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy, thu, tietBatDau, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoGiangDayNgoaiGioByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoGiangDayNgoaiGioByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String thu, System.Int32 tietBatDau, ref System.Double reVal)
		{
			 GetHeSoGiangDayNgoaiGioByNamHocHocKy(null, start, pageLength , namHoc, hocKy, thu, tietBatDau, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoGiangDayNgoaiGioByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoGiangDayNgoaiGioByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String thu, System.Int32 tietBatDau, ref System.Double reVal)
		{
			 GetHeSoGiangDayNgoaiGioByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, thu, tietBatDau, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoGiangDayNgoaiGioByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetHeSoGiangDayNgoaiGioByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String thu, System.Int32 tietBatDau, ref System.Double reVal);
		
		#endregion
		
		#region cust_HeSoCongViec_GetHeSoNgonNguGiangDay 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNgonNguGiangDay' stored procedure. 
		/// </summary>
		/// <param name="ngonNgu"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNgonNguGiangDay(System.String ngonNgu, ref System.Double reVal)
		{
			 GetHeSoNgonNguGiangDay(null, 0, int.MaxValue , ngonNgu, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNgonNguGiangDay' stored procedure. 
		/// </summary>
		/// <param name="ngonNgu"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNgonNguGiangDay(int start, int pageLength, System.String ngonNgu, ref System.Double reVal)
		{
			 GetHeSoNgonNguGiangDay(null, start, pageLength , ngonNgu, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNgonNguGiangDay' stored procedure. 
		/// </summary>
		/// <param name="ngonNgu"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoNgonNguGiangDay(TransactionManager transactionManager, System.String ngonNgu, ref System.Double reVal)
		{
			 GetHeSoNgonNguGiangDay(transactionManager, 0, int.MaxValue , ngonNgu, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoNgonNguGiangDay' stored procedure. 
		/// </summary>
		/// <param name="ngonNgu"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetHeSoNgonNguGiangDay(TransactionManager transactionManager, int start, int pageLength , System.String ngonNgu, ref System.Double reVal);
		
		#endregion
		
		#region cust_HeSoCongViec_GetByLoaiHocPhanNgayDay 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetByLoaiHocPhanNgayDay' stored procedure. 
		/// </summary>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCongViec&gt;"/> instance.</returns>
		public TList<HeSoCongViec> GetByLoaiHocPhanNgayDay(System.String loaiHocPhan, System.DateTime ngayDay)
		{
			return GetByLoaiHocPhanNgayDay(null, 0, int.MaxValue , loaiHocPhan, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetByLoaiHocPhanNgayDay' stored procedure. 
		/// </summary>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCongViec&gt;"/> instance.</returns>
		public TList<HeSoCongViec> GetByLoaiHocPhanNgayDay(int start, int pageLength, System.String loaiHocPhan, System.DateTime ngayDay)
		{
			return GetByLoaiHocPhanNgayDay(null, start, pageLength , loaiHocPhan, ngayDay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetByLoaiHocPhanNgayDay' stored procedure. 
		/// </summary>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCongViec&gt;"/> instance.</returns>
		public TList<HeSoCongViec> GetByLoaiHocPhanNgayDay(TransactionManager transactionManager, System.String loaiHocPhan, System.DateTime ngayDay)
		{
			return GetByLoaiHocPhanNgayDay(transactionManager, 0, int.MaxValue , loaiHocPhan, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetByLoaiHocPhanNgayDay' stored procedure. 
		/// </summary>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoCongViec&gt;"/> instance.</returns>
		public abstract TList<HeSoCongViec> GetByLoaiHocPhanNgayDay(TransactionManager transactionManager, int start, int pageLength , System.String loaiHocPhan, System.DateTime ngayDay);
		
		#endregion
		
		#region cust_HeSoCongViec_GetHeSoGiangDayNgoaiGio 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoGiangDayNgoaiGio' stored procedure. 
		/// </summary>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoGiangDayNgoaiGio(System.String thu, System.Int32 tietBatDau, ref System.Double reVal)
		{
			 GetHeSoGiangDayNgoaiGio(null, 0, int.MaxValue , thu, tietBatDau, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoGiangDayNgoaiGio' stored procedure. 
		/// </summary>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoGiangDayNgoaiGio(int start, int pageLength, System.String thu, System.Int32 tietBatDau, ref System.Double reVal)
		{
			 GetHeSoGiangDayNgoaiGio(null, start, pageLength , thu, tietBatDau, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoGiangDayNgoaiGio' stored procedure. 
		/// </summary>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoGiangDayNgoaiGio(TransactionManager transactionManager, System.String thu, System.Int32 tietBatDau, ref System.Double reVal)
		{
			 GetHeSoGiangDayNgoaiGio(transactionManager, 0, int.MaxValue , thu, tietBatDau, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_GetHeSoGiangDayNgoaiGio' stored procedure. 
		/// </summary>
		/// <param name="thu"> A <c>System.String</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetHeSoGiangDayNgoaiGio(TransactionManager transactionManager, int start, int pageLength , System.String thu, System.Int32 tietBatDau, ref System.Double reVal);
		
		#endregion
		
		#region cust_HeSoCongViec_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoCongViec_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoCongViec_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoCongViec_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoCongViec_SaoChep' stored procedure. 
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
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoCongViec&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoCongViec&gt;"/></returns>
		public static TList<HeSoCongViec> Fill(IDataReader reader, TList<HeSoCongViec> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoCongViec c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoCongViec")
					.Append("|").Append((System.Int32)reader[((int)HeSoCongViecColumn.MaHeSo - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoCongViec>(
					key.ToString(), // EntityTrackingKey
					"HeSoCongViec",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoCongViec();
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
					c.MaHeSo = (System.Int32)reader[(HeSoCongViecColumn.MaHeSo.ToString())];
					c.Stt = (reader[HeSoCongViecColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoCongViecColumn.Stt.ToString())];
					c.MaQuanLy = (System.String)reader[(HeSoCongViecColumn.MaQuanLy.ToString())];
					c.TenCongViec = (reader[HeSoCongViecColumn.TenCongViec.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCongViecColumn.TenCongViec.ToString())];
					c.HeSo = (reader[HeSoCongViecColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoCongViecColumn.HeSo.ToString())];
					c.NgayBdApDung = (reader[HeSoCongViecColumn.NgayBdApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoCongViecColumn.NgayBdApDung.ToString())];
					c.NgayKtApDung = (reader[HeSoCongViecColumn.NgayKtApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoCongViecColumn.NgayKtApDung.ToString())];
					c.NamHoc = (reader[HeSoCongViecColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCongViecColumn.NamHoc.ToString())];
					c.HocKy = (reader[HeSoCongViecColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCongViecColumn.HocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoCongViec"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoCongViec"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoCongViec entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHeSo = (System.Int32)reader[(HeSoCongViecColumn.MaHeSo.ToString())];
			entity.Stt = (reader[HeSoCongViecColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoCongViecColumn.Stt.ToString())];
			entity.MaQuanLy = (System.String)reader[(HeSoCongViecColumn.MaQuanLy.ToString())];
			entity.TenCongViec = (reader[HeSoCongViecColumn.TenCongViec.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCongViecColumn.TenCongViec.ToString())];
			entity.HeSo = (reader[HeSoCongViecColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoCongViecColumn.HeSo.ToString())];
			entity.NgayBdApDung = (reader[HeSoCongViecColumn.NgayBdApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoCongViecColumn.NgayBdApDung.ToString())];
			entity.NgayKtApDung = (reader[HeSoCongViecColumn.NgayKtApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoCongViecColumn.NgayKtApDung.ToString())];
			entity.NamHoc = (reader[HeSoCongViecColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCongViecColumn.NamHoc.ToString())];
			entity.HocKy = (reader[HeSoCongViecColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoCongViecColumn.HocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoCongViec"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoCongViec"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoCongViec entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHeSo = (System.Int32)dataRow["MaHeSo"];
			entity.Stt = Convert.IsDBNull(dataRow["STT"]) ? null : (System.Int32?)dataRow["STT"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenCongViec = Convert.IsDBNull(dataRow["TenCongViec"]) ? null : (System.String)dataRow["TenCongViec"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.NgayBdApDung = Convert.IsDBNull(dataRow["NgayBDApDung"]) ? null : (System.DateTime?)dataRow["NgayBDApDung"];
			entity.NgayKtApDung = Convert.IsDBNull(dataRow["NgayKTApDung"]) ? null : (System.DateTime?)dataRow["NgayKTApDung"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoCongViec"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoCongViec Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoCongViec entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaHeSo methods when available
			
			#region ThucGiangMonThucTeTuHocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ThucGiangMonThucTeTuHoc>|ThucGiangMonThucTeTuHocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ThucGiangMonThucTeTuHocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ThucGiangMonThucTeTuHocCollection = DataRepository.ThucGiangMonThucTeTuHocProvider.GetByMaHeSoCongViec(transactionManager, entity.MaHeSo);

				if (deep && entity.ThucGiangMonThucTeTuHocCollection.Count > 0)
				{
					deepHandles.Add("ThucGiangMonThucTeTuHocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ThucGiangMonThucTeTuHoc>) DataRepository.ThucGiangMonThucTeTuHocProvider.DeepLoad,
						new object[] { transactionManager, entity.ThucGiangMonThucTeTuHocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoCongViec object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoCongViec instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoCongViec Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoCongViec entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<ThucGiangMonThucTeTuHoc>
				if (CanDeepSave(entity.ThucGiangMonThucTeTuHocCollection, "List<ThucGiangMonThucTeTuHoc>|ThucGiangMonThucTeTuHocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ThucGiangMonThucTeTuHoc child in entity.ThucGiangMonThucTeTuHocCollection)
					{
						if(child.MaHeSoCongViecSource != null)
						{
							child.MaHeSoCongViec = child.MaHeSoCongViecSource.MaHeSo;
						}
						else
						{
							child.MaHeSoCongViec = entity.MaHeSo;
						}

					}

					if (entity.ThucGiangMonThucTeTuHocCollection.Count > 0 || entity.ThucGiangMonThucTeTuHocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ThucGiangMonThucTeTuHocProvider.Save(transactionManager, entity.ThucGiangMonThucTeTuHocCollection);
						
						deepHandles.Add("ThucGiangMonThucTeTuHocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ThucGiangMonThucTeTuHoc >) DataRepository.ThucGiangMonThucTeTuHocProvider.DeepSave,
							new object[] { transactionManager, entity.ThucGiangMonThucTeTuHocCollection, deepSaveType, childTypes, innerList }
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
	
	#region HeSoCongViecChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoCongViec</c>
	///</summary>
	public enum HeSoCongViecChildEntityTypes
	{
		///<summary>
		/// Collection of <c>HeSoCongViec</c> as OneToMany for ThucGiangMonThucTeTuHocCollection
		///</summary>
		[ChildEntityType(typeof(TList<ThucGiangMonThucTeTuHoc>))]
		ThucGiangMonThucTeTuHocCollection,
	}
	
	#endregion HeSoCongViecChildEntityTypes
	
	#region HeSoCongViecFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoCongViecColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCongViec"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoCongViecFilterBuilder : SqlFilterBuilder<HeSoCongViecColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoCongViecFilterBuilder class.
		/// </summary>
		public HeSoCongViecFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoCongViecFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoCongViecFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoCongViecFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoCongViecFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoCongViecFilterBuilder
	
	#region HeSoCongViecParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoCongViecColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCongViec"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoCongViecParameterBuilder : ParameterizedSqlFilterBuilder<HeSoCongViecColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoCongViecParameterBuilder class.
		/// </summary>
		public HeSoCongViecParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoCongViecParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoCongViecParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoCongViecParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoCongViecParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoCongViecParameterBuilder
	
	#region HeSoCongViecSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoCongViecColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCongViec"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoCongViecSortBuilder : SqlSortBuilder<HeSoCongViecColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoCongViecSqlSortBuilder class.
		/// </summary>
		public HeSoCongViecSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoCongViecSortBuilder
	
} // end namespace
