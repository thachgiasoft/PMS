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
	/// This class is the base class for any <see cref="XetDuyetDeCuongLuanVanCaoHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class XetDuyetDeCuongLuanVanCaoHocProviderBaseCore : EntityProviderBase<PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc, PMS.Entities.XetDuyetDeCuongLuanVanCaoHocKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.XetDuyetDeCuongLuanVanCaoHocKey key)
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
		/// 	Gets rows from the datasource based on the FK_XetDuyetDeCuongLuanVanCaoHoc_GiangVien key.
		///		FK_XetDuyetDeCuongLuanVanCaoHoc_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc objects.</returns>
		public TList<XetDuyetDeCuongLuanVanCaoHoc> GetByMaGiangVien(System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_XetDuyetDeCuongLuanVanCaoHoc_GiangVien key.
		///		FK_XetDuyetDeCuongLuanVanCaoHoc_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc objects.</returns>
		/// <remarks></remarks>
		public TList<XetDuyetDeCuongLuanVanCaoHoc> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_XetDuyetDeCuongLuanVanCaoHoc_GiangVien key.
		///		FK_XetDuyetDeCuongLuanVanCaoHoc_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc objects.</returns>
		public TList<XetDuyetDeCuongLuanVanCaoHoc> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_XetDuyetDeCuongLuanVanCaoHoc_GiangVien key.
		///		fkXetDuyetDeCuongLuanVanCaoHocGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc objects.</returns>
		public TList<XetDuyetDeCuongLuanVanCaoHoc> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_XetDuyetDeCuongLuanVanCaoHoc_GiangVien key.
		///		fkXetDuyetDeCuongLuanVanCaoHocGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc objects.</returns>
		public TList<XetDuyetDeCuongLuanVanCaoHoc> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_XetDuyetDeCuongLuanVanCaoHoc_GiangVien key.
		///		FK_XetDuyetDeCuongLuanVanCaoHoc_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc objects.</returns>
		public abstract TList<XetDuyetDeCuongLuanVanCaoHoc> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc Get(TransactionManager transactionManager, PMS.Entities.XetDuyetDeCuongLuanVanCaoHocKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_XetDuyetDeCuongLuanVanCaoHoc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc"/> class.</returns>
		public PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_XetDuyetDeCuongLuanVanCaoHoc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc"/> class.</returns>
		public PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_XetDuyetDeCuongLuanVanCaoHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc"/> class.</returns>
		public PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_XetDuyetDeCuongLuanVanCaoHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc"/> class.</returns>
		public PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_XetDuyetDeCuongLuanVanCaoHoc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc"/> class.</returns>
		public PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_XetDuyetDeCuongLuanVanCaoHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc"/> class.</returns>
		public abstract PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_XetDuyetDeCuongLuanVanCaoHoc_HuyChot 
		
		/// <summary>
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(System.String namHoc, System.String hocKy)
		{
			 HuyChot(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 HuyChot(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 HuyChot(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_XetDuyetDeCuongLuanVanCaoHoc_KiemTraChot 
		
		/// <summary>
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_KiemTraChot' stored procedure. 
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
		
		#region cust_XetDuyetDeCuongLuanVanCaoHoc_Chot 
		
		/// <summary>
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(System.String namHoc, System.String hocKy)
		{
			 Chot(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 Chot(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 Chot(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Chot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_XetDuyetDeCuongLuanVanCaoHoc_QuyDoi 
		
		/// <summary>
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(System.String namHoc, System.String hocKy)
		{
			 QuyDoi(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 QuyDoi(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 QuyDoi(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void QuyDoi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_XetDuyetDeCuongLuanVanCaoHoc_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_Luu' stored procedure. 
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
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_Luu' stored procedure. 
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
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_Luu' stored procedure. 
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
		///	This method wrap the 'cust_XetDuyetDeCuongLuanVanCaoHoc_Luu' stored procedure. 
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
		/// Fill a TList&lt;XetDuyetDeCuongLuanVanCaoHoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;XetDuyetDeCuongLuanVanCaoHoc&gt;"/></returns>
		public static TList<XetDuyetDeCuongLuanVanCaoHoc> Fill(IDataReader reader, TList<XetDuyetDeCuongLuanVanCaoHoc> rows, int start, int pageLength)
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
				
				PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("XetDuyetDeCuongLuanVanCaoHoc")
					.Append("|").Append((System.Int32)reader[((int)XetDuyetDeCuongLuanVanCaoHocColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<XetDuyetDeCuongLuanVanCaoHoc>(
					key.ToString(), // EntityTrackingKey
					"XetDuyetDeCuongLuanVanCaoHoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc();
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
					c.Id = (System.Int32)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.Id.ToString())];
					c.NamHoc = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.NamHoc.ToString())];
					c.HocKy = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.HocKy.ToString())];
					c.MaGiangVien = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.MaGiangVien.ToString())];
					c.MaKhoaHoc = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.MaKhoaHoc.ToString())];
					c.SoLuong = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.SoLuong.ToString())];
					c.DonGia = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.DonGia.ToString())];
					c.ThanhTien = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.ThanhTien.ToString())];
					c.Thue = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.Thue.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.Thue.ToString())];
					c.ThucLinh = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.ThucLinh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.ThucLinh.ToString())];
					c.GhiChu = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.GhiChu.ToString())];
					c.Chot = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.Chot.ToString())];
					c.NgayCapNhat = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.Id.ToString())];
			entity.NamHoc = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.NamHoc.ToString())];
			entity.HocKy = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.HocKy.ToString())];
			entity.MaGiangVien = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.MaGiangVien.ToString())];
			entity.MaKhoaHoc = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.MaKhoaHoc.ToString())];
			entity.SoLuong = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.SoLuong.ToString())];
			entity.DonGia = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.DonGia.ToString())];
			entity.ThanhTien = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.ThanhTien.ToString())];
			entity.Thue = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.Thue.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.Thue.ToString())];
			entity.ThucLinh = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.ThucLinh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.ThucLinh.ToString())];
			entity.GhiChu = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.GhiChu.ToString())];
			entity.Chot = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.Chot.ToString())];
			entity.NgayCapNhat = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[XetDuyetDeCuongLuanVanCaoHocColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(XetDuyetDeCuongLuanVanCaoHocColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaKhoaHoc = Convert.IsDBNull(dataRow["MaKhoaHoc"]) ? null : (System.String)dataRow["MaKhoaHoc"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Int32?)dataRow["SoLuong"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.ThanhTien = Convert.IsDBNull(dataRow["ThanhTien"]) ? null : (System.Decimal?)dataRow["ThanhTien"];
			entity.Thue = Convert.IsDBNull(dataRow["Thue"]) ? null : (System.Decimal?)dataRow["Thue"];
			entity.ThucLinh = Convert.IsDBNull(dataRow["ThucLinh"]) ? null : (System.Decimal?)dataRow["ThucLinh"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.Chot = Convert.IsDBNull(dataRow["Chot"]) ? null : (System.Boolean?)dataRow["Chot"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region XetDuyetDeCuongLuanVanCaoHocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.XetDuyetDeCuongLuanVanCaoHoc</c>
	///</summary>
	public enum XetDuyetDeCuongLuanVanCaoHocChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
	}
	
	#endregion XetDuyetDeCuongLuanVanCaoHocChildEntityTypes
	
	#region XetDuyetDeCuongLuanVanCaoHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;XetDuyetDeCuongLuanVanCaoHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="XetDuyetDeCuongLuanVanCaoHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class XetDuyetDeCuongLuanVanCaoHocFilterBuilder : SqlFilterBuilder<XetDuyetDeCuongLuanVanCaoHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the XetDuyetDeCuongLuanVanCaoHocFilterBuilder class.
		/// </summary>
		public XetDuyetDeCuongLuanVanCaoHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the XetDuyetDeCuongLuanVanCaoHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public XetDuyetDeCuongLuanVanCaoHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the XetDuyetDeCuongLuanVanCaoHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public XetDuyetDeCuongLuanVanCaoHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion XetDuyetDeCuongLuanVanCaoHocFilterBuilder
	
	#region XetDuyetDeCuongLuanVanCaoHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;XetDuyetDeCuongLuanVanCaoHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="XetDuyetDeCuongLuanVanCaoHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class XetDuyetDeCuongLuanVanCaoHocParameterBuilder : ParameterizedSqlFilterBuilder<XetDuyetDeCuongLuanVanCaoHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the XetDuyetDeCuongLuanVanCaoHocParameterBuilder class.
		/// </summary>
		public XetDuyetDeCuongLuanVanCaoHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the XetDuyetDeCuongLuanVanCaoHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public XetDuyetDeCuongLuanVanCaoHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the XetDuyetDeCuongLuanVanCaoHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public XetDuyetDeCuongLuanVanCaoHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion XetDuyetDeCuongLuanVanCaoHocParameterBuilder
	
	#region XetDuyetDeCuongLuanVanCaoHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;XetDuyetDeCuongLuanVanCaoHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="XetDuyetDeCuongLuanVanCaoHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class XetDuyetDeCuongLuanVanCaoHocSortBuilder : SqlSortBuilder<XetDuyetDeCuongLuanVanCaoHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the XetDuyetDeCuongLuanVanCaoHocSqlSortBuilder class.
		/// </summary>
		public XetDuyetDeCuongLuanVanCaoHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion XetDuyetDeCuongLuanVanCaoHocSortBuilder
	
} // end namespace
