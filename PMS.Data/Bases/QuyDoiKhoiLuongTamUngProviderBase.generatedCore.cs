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
	/// This class is the base class for any <see cref="QuyDoiKhoiLuongTamUngProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class QuyDoiKhoiLuongTamUngProviderBaseCore : EntityProviderBase<PMS.Entities.QuyDoiKhoiLuongTamUng, PMS.Entities.QuyDoiKhoiLuongTamUngKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.QuyDoiKhoiLuongTamUngKey key)
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
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiKhoiLuongTamUng_KhoiLuongTamUng key.
		///		FK_QuyDoiKhoiLuongTamUng_KhoiLuongTamUng Description: 
		/// </summary>
		/// <param name="_maKhoiLuongTamUng"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiKhoiLuongTamUng objects.</returns>
		public TList<QuyDoiKhoiLuongTamUng> GetByMaKhoiLuongTamUng(System.Int32? _maKhoiLuongTamUng)
		{
			int count = -1;
			return GetByMaKhoiLuongTamUng(_maKhoiLuongTamUng, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiKhoiLuongTamUng_KhoiLuongTamUng key.
		///		FK_QuyDoiKhoiLuongTamUng_KhoiLuongTamUng Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongTamUng"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiKhoiLuongTamUng objects.</returns>
		/// <remarks></remarks>
		public TList<QuyDoiKhoiLuongTamUng> GetByMaKhoiLuongTamUng(TransactionManager transactionManager, System.Int32? _maKhoiLuongTamUng)
		{
			int count = -1;
			return GetByMaKhoiLuongTamUng(transactionManager, _maKhoiLuongTamUng, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiKhoiLuongTamUng_KhoiLuongTamUng key.
		///		FK_QuyDoiKhoiLuongTamUng_KhoiLuongTamUng Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongTamUng"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiKhoiLuongTamUng objects.</returns>
		public TList<QuyDoiKhoiLuongTamUng> GetByMaKhoiLuongTamUng(TransactionManager transactionManager, System.Int32? _maKhoiLuongTamUng, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuongTamUng(transactionManager, _maKhoiLuongTamUng, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiKhoiLuongTamUng_KhoiLuongTamUng key.
		///		fkQuyDoiKhoiLuongTamUngKhoiLuongTamUng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maKhoiLuongTamUng"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiKhoiLuongTamUng objects.</returns>
		public TList<QuyDoiKhoiLuongTamUng> GetByMaKhoiLuongTamUng(System.Int32? _maKhoiLuongTamUng, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaKhoiLuongTamUng(null, _maKhoiLuongTamUng, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiKhoiLuongTamUng_KhoiLuongTamUng key.
		///		fkQuyDoiKhoiLuongTamUngKhoiLuongTamUng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maKhoiLuongTamUng"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiKhoiLuongTamUng objects.</returns>
		public TList<QuyDoiKhoiLuongTamUng> GetByMaKhoiLuongTamUng(System.Int32? _maKhoiLuongTamUng, int start, int pageLength,out int count)
		{
			return GetByMaKhoiLuongTamUng(null, _maKhoiLuongTamUng, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiKhoiLuongTamUng_KhoiLuongTamUng key.
		///		FK_QuyDoiKhoiLuongTamUng_KhoiLuongTamUng Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongTamUng"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiKhoiLuongTamUng objects.</returns>
		public abstract TList<QuyDoiKhoiLuongTamUng> GetByMaKhoiLuongTamUng(TransactionManager transactionManager, System.Int32? _maKhoiLuongTamUng, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.QuyDoiKhoiLuongTamUng Get(TransactionManager transactionManager, PMS.Entities.QuyDoiKhoiLuongTamUngKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_QuyDoiKhoiLuongTamUng index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiKhoiLuongTamUng"/> class.</returns>
		public PMS.Entities.QuyDoiKhoiLuongTamUng GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiKhoiLuongTamUng index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiKhoiLuongTamUng"/> class.</returns>
		public PMS.Entities.QuyDoiKhoiLuongTamUng GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiKhoiLuongTamUng index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiKhoiLuongTamUng"/> class.</returns>
		public PMS.Entities.QuyDoiKhoiLuongTamUng GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiKhoiLuongTamUng index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiKhoiLuongTamUng"/> class.</returns>
		public PMS.Entities.QuyDoiKhoiLuongTamUng GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiKhoiLuongTamUng index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiKhoiLuongTamUng"/> class.</returns>
		public PMS.Entities.QuyDoiKhoiLuongTamUng GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiKhoiLuongTamUng index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiKhoiLuongTamUng"/> class.</returns>
		public abstract PMS.Entities.QuyDoiKhoiLuongTamUng GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_QuyDoiKhoiLuongTamUng_HuyChot 
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 HuyChot(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 HuyChot(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 HuyChot(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_QuyDoiKhoiLuongTamUng_KiemTraChot 
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraChot(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraChot(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraChot(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_QuyDoiKhoiLuongTamUng_Chot 
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Chot(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Chot(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Chot(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Chot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_QuyDoiKhoiLuongTamUng_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiKhoiLuongTamUng_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;QuyDoiKhoiLuongTamUng&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;QuyDoiKhoiLuongTamUng&gt;"/></returns>
		public static TList<QuyDoiKhoiLuongTamUng> Fill(IDataReader reader, TList<QuyDoiKhoiLuongTamUng> rows, int start, int pageLength)
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
				
				PMS.Entities.QuyDoiKhoiLuongTamUng c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("QuyDoiKhoiLuongTamUng")
					.Append("|").Append((System.Int32)reader[((int)QuyDoiKhoiLuongTamUngColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<QuyDoiKhoiLuongTamUng>(
					key.ToString(), // EntityTrackingKey
					"QuyDoiKhoiLuongTamUng",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.QuyDoiKhoiLuongTamUng();
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
					c.Id = (System.Int32)reader[(QuyDoiKhoiLuongTamUngColumn.Id.ToString())];
					c.MaKhoiLuongTamUng = (reader[QuyDoiKhoiLuongTamUngColumn.MaKhoiLuongTamUng.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDoiKhoiLuongTamUngColumn.MaKhoiLuongTamUng.ToString())];
					c.HeSoCongViec = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoCongViec.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoCongViec.ToString())];
					c.HeSoBacDaoTao = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoBacDaoTao.ToString())];
					c.HeSoNgonNgu = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoNgonNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoNgonNgu.ToString())];
					c.HeSoChucDanhChuyenMon = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoChucDanhChuyenMon.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoChucDanhChuyenMon.ToString())];
					c.HeSoLopDong = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoLopDong.ToString())];
					c.HeSoCoSo = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoCoSo.ToString())];
					c.SoTietThucTeQuyDoi = (reader[QuyDoiKhoiLuongTamUngColumn.SoTietThucTeQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.SoTietThucTeQuyDoi.ToString())];
					c.TietQuyDoi = (reader[QuyDoiKhoiLuongTamUngColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.TietQuyDoi.ToString())];
					c.HeSoQuyDoiThucHanhSangLyThuyet = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString())];
					c.HeSoNgoaiGio = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoNgoaiGio.ToString())];
					c.LoaiLop = (reader[QuyDoiKhoiLuongTamUngColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiKhoiLuongTamUngColumn.LoaiLop.ToString())];
					c.HeSoClcCntn = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoClcCntn.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoClcCntn.ToString())];
					c.HeSoThinhGiangMonChuyenNganh = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoThinhGiangMonChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoThinhGiangMonChuyenNganh.ToString())];
					c.HeSoTroCap = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoTroCap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoTroCap.ToString())];
					c.HeSoLuong = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoLuong.ToString())];
					c.HeSoMonMoi = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoMonMoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoMonMoi.ToString())];
					c.HeSoNienCheTinChi = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoNienCheTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoNienCheTinChi.ToString())];
					c.GhiChu = (reader[QuyDoiKhoiLuongTamUngColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiKhoiLuongTamUngColumn.GhiChu.ToString())];
					c.Chot = (reader[QuyDoiKhoiLuongTamUngColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(QuyDoiKhoiLuongTamUngColumn.Chot.ToString())];
					c.MucThanhToan = (reader[QuyDoiKhoiLuongTamUngColumn.MucThanhToan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.MucThanhToan.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.QuyDoiKhoiLuongTamUng"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.QuyDoiKhoiLuongTamUng"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.QuyDoiKhoiLuongTamUng entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(QuyDoiKhoiLuongTamUngColumn.Id.ToString())];
			entity.MaKhoiLuongTamUng = (reader[QuyDoiKhoiLuongTamUngColumn.MaKhoiLuongTamUng.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDoiKhoiLuongTamUngColumn.MaKhoiLuongTamUng.ToString())];
			entity.HeSoCongViec = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoCongViec.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoCongViec.ToString())];
			entity.HeSoBacDaoTao = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoBacDaoTao.ToString())];
			entity.HeSoNgonNgu = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoNgonNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoNgonNgu.ToString())];
			entity.HeSoChucDanhChuyenMon = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoChucDanhChuyenMon.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoChucDanhChuyenMon.ToString())];
			entity.HeSoLopDong = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoLopDong.ToString())];
			entity.HeSoCoSo = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoCoSo.ToString())];
			entity.SoTietThucTeQuyDoi = (reader[QuyDoiKhoiLuongTamUngColumn.SoTietThucTeQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.SoTietThucTeQuyDoi.ToString())];
			entity.TietQuyDoi = (reader[QuyDoiKhoiLuongTamUngColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.TietQuyDoi.ToString())];
			entity.HeSoQuyDoiThucHanhSangLyThuyet = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString())];
			entity.HeSoNgoaiGio = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoNgoaiGio.ToString())];
			entity.LoaiLop = (reader[QuyDoiKhoiLuongTamUngColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiKhoiLuongTamUngColumn.LoaiLop.ToString())];
			entity.HeSoClcCntn = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoClcCntn.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoClcCntn.ToString())];
			entity.HeSoThinhGiangMonChuyenNganh = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoThinhGiangMonChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoThinhGiangMonChuyenNganh.ToString())];
			entity.HeSoTroCap = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoTroCap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoTroCap.ToString())];
			entity.HeSoLuong = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoLuong.ToString())];
			entity.HeSoMonMoi = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoMonMoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoMonMoi.ToString())];
			entity.HeSoNienCheTinChi = (reader[QuyDoiKhoiLuongTamUngColumn.HeSoNienCheTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.HeSoNienCheTinChi.ToString())];
			entity.GhiChu = (reader[QuyDoiKhoiLuongTamUngColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiKhoiLuongTamUngColumn.GhiChu.ToString())];
			entity.Chot = (reader[QuyDoiKhoiLuongTamUngColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(QuyDoiKhoiLuongTamUngColumn.Chot.ToString())];
			entity.MucThanhToan = (reader[QuyDoiKhoiLuongTamUngColumn.MucThanhToan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiKhoiLuongTamUngColumn.MucThanhToan.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.QuyDoiKhoiLuongTamUng"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.QuyDoiKhoiLuongTamUng"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.QuyDoiKhoiLuongTamUng entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaKhoiLuongTamUng = Convert.IsDBNull(dataRow["MaKhoiLuongTamUng"]) ? null : (System.Int32?)dataRow["MaKhoiLuongTamUng"];
			entity.HeSoCongViec = Convert.IsDBNull(dataRow["HeSoCongViec"]) ? null : (System.Decimal?)dataRow["HeSoCongViec"];
			entity.HeSoBacDaoTao = Convert.IsDBNull(dataRow["HeSoBacDaoTao"]) ? null : (System.Decimal?)dataRow["HeSoBacDaoTao"];
			entity.HeSoNgonNgu = Convert.IsDBNull(dataRow["HeSoNgonNgu"]) ? null : (System.Decimal?)dataRow["HeSoNgonNgu"];
			entity.HeSoChucDanhChuyenMon = Convert.IsDBNull(dataRow["HeSoChucDanhChuyenMon"]) ? null : (System.Decimal?)dataRow["HeSoChucDanhChuyenMon"];
			entity.HeSoLopDong = Convert.IsDBNull(dataRow["HeSoLopDong"]) ? null : (System.Decimal?)dataRow["HeSoLopDong"];
			entity.HeSoCoSo = Convert.IsDBNull(dataRow["HeSoCoSo"]) ? null : (System.Decimal?)dataRow["HeSoCoSo"];
			entity.SoTietThucTeQuyDoi = Convert.IsDBNull(dataRow["SoTietThucTeQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietThucTeQuyDoi"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.HeSoQuyDoiThucHanhSangLyThuyet = Convert.IsDBNull(dataRow["HeSoQuyDoiThucHanhSangLyThuyet"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoiThucHanhSangLyThuyet"];
			entity.HeSoNgoaiGio = Convert.IsDBNull(dataRow["HeSoNgoaiGio"]) ? null : (System.Decimal?)dataRow["HeSoNgoaiGio"];
			entity.LoaiLop = Convert.IsDBNull(dataRow["LoaiLop"]) ? null : (System.String)dataRow["LoaiLop"];
			entity.HeSoClcCntn = Convert.IsDBNull(dataRow["HeSoClcCntn"]) ? null : (System.Decimal?)dataRow["HeSoClcCntn"];
			entity.HeSoThinhGiangMonChuyenNganh = Convert.IsDBNull(dataRow["HeSoThinhGiangMonChuyenNganh"]) ? null : (System.Decimal?)dataRow["HeSoThinhGiangMonChuyenNganh"];
			entity.HeSoTroCap = Convert.IsDBNull(dataRow["HeSoTroCap"]) ? null : (System.Decimal?)dataRow["HeSoTroCap"];
			entity.HeSoLuong = Convert.IsDBNull(dataRow["HeSoLuong"]) ? null : (System.Decimal?)dataRow["HeSoLuong"];
			entity.HeSoMonMoi = Convert.IsDBNull(dataRow["HeSoMonMoi"]) ? null : (System.Decimal?)dataRow["HeSoMonMoi"];
			entity.HeSoNienCheTinChi = Convert.IsDBNull(dataRow["HeSoNienCheTinChi"]) ? null : (System.Decimal?)dataRow["HeSoNienCheTinChi"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.Chot = Convert.IsDBNull(dataRow["Chot"]) ? null : (System.Boolean?)dataRow["Chot"];
			entity.MucThanhToan = Convert.IsDBNull(dataRow["MucThanhToan"]) ? null : (System.Decimal?)dataRow["MucThanhToan"];
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
		/// <param name="entity">The <see cref="PMS.Entities.QuyDoiKhoiLuongTamUng"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.QuyDoiKhoiLuongTamUng Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.QuyDoiKhoiLuongTamUng entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaKhoiLuongTamUngSource	
			if (CanDeepLoad(entity, "KhoiLuongTamUng|MaKhoiLuongTamUngSource", deepLoadType, innerList) 
				&& entity.MaKhoiLuongTamUngSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaKhoiLuongTamUng ?? (int)0);
				KhoiLuongTamUng tmpEntity = EntityManager.LocateEntity<KhoiLuongTamUng>(EntityLocator.ConstructKeyFromPkItems(typeof(KhoiLuongTamUng), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaKhoiLuongTamUngSource = tmpEntity;
				else
					entity.MaKhoiLuongTamUngSource = DataRepository.KhoiLuongTamUngProvider.GetByMaKhoiLuong(transactionManager, (entity.MaKhoiLuongTamUng ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaKhoiLuongTamUngSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaKhoiLuongTamUngSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.KhoiLuongTamUngProvider.DeepLoad(transactionManager, entity.MaKhoiLuongTamUngSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaKhoiLuongTamUngSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.QuyDoiKhoiLuongTamUng object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.QuyDoiKhoiLuongTamUng instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.QuyDoiKhoiLuongTamUng Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.QuyDoiKhoiLuongTamUng entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaKhoiLuongTamUngSource
			if (CanDeepSave(entity, "KhoiLuongTamUng|MaKhoiLuongTamUngSource", deepSaveType, innerList) 
				&& entity.MaKhoiLuongTamUngSource != null)
			{
				DataRepository.KhoiLuongTamUngProvider.Save(transactionManager, entity.MaKhoiLuongTamUngSource);
				entity.MaKhoiLuongTamUng = entity.MaKhoiLuongTamUngSource.MaKhoiLuong;
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
	
	#region QuyDoiKhoiLuongTamUngChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.QuyDoiKhoiLuongTamUng</c>
	///</summary>
	public enum QuyDoiKhoiLuongTamUngChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>KhoiLuongTamUng</c> at MaKhoiLuongTamUngSource
		///</summary>
		[ChildEntityType(typeof(KhoiLuongTamUng))]
		KhoiLuongTamUng,
	}
	
	#endregion QuyDoiKhoiLuongTamUngChildEntityTypes
	
	#region QuyDoiKhoiLuongTamUngFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;QuyDoiKhoiLuongTamUngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiKhoiLuongTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiKhoiLuongTamUngFilterBuilder : SqlFilterBuilder<QuyDoiKhoiLuongTamUngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiKhoiLuongTamUngFilterBuilder class.
		/// </summary>
		public QuyDoiKhoiLuongTamUngFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the QuyDoiKhoiLuongTamUngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public QuyDoiKhoiLuongTamUngFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the QuyDoiKhoiLuongTamUngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public QuyDoiKhoiLuongTamUngFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion QuyDoiKhoiLuongTamUngFilterBuilder
	
	#region QuyDoiKhoiLuongTamUngParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;QuyDoiKhoiLuongTamUngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiKhoiLuongTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiKhoiLuongTamUngParameterBuilder : ParameterizedSqlFilterBuilder<QuyDoiKhoiLuongTamUngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiKhoiLuongTamUngParameterBuilder class.
		/// </summary>
		public QuyDoiKhoiLuongTamUngParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the QuyDoiKhoiLuongTamUngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public QuyDoiKhoiLuongTamUngParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the QuyDoiKhoiLuongTamUngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public QuyDoiKhoiLuongTamUngParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion QuyDoiKhoiLuongTamUngParameterBuilder
	
	#region QuyDoiKhoiLuongTamUngSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;QuyDoiKhoiLuongTamUngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiKhoiLuongTamUng"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class QuyDoiKhoiLuongTamUngSortBuilder : SqlSortBuilder<QuyDoiKhoiLuongTamUngColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiKhoiLuongTamUngSqlSortBuilder class.
		/// </summary>
		public QuyDoiKhoiLuongTamUngSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion QuyDoiKhoiLuongTamUngSortBuilder
	
} // end namespace
