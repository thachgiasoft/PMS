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
	/// This class is the base class for any <see cref="KcqKhoiLuongGiangDayDoAnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqKhoiLuongGiangDayDoAnProviderBaseCore : EntityProviderBase<PMS.Entities.KcqKhoiLuongGiangDayDoAn, PMS.Entities.KcqKhoiLuongGiangDayDoAnKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongGiangDayDoAnKey key)
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
		public override PMS.Entities.KcqKhoiLuongGiangDayDoAn Get(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongGiangDayDoAnKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqKhoiLuongGiangDayDoAn index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAn"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayDoAn GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayDoAn index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAn"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayDoAn GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayDoAn index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAn"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayDoAn GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayDoAn index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAn"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayDoAn GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayDoAn index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAn"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayDoAn GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayDoAn index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAn"/> class.</returns>
		public abstract PMS.Entities.KcqKhoiLuongGiangDayDoAn GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KcqKhoiLuongGiangDayDoAn_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(System.String namHoc, System.String hocKy)
		{
			 DongBo(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 DongBo(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 DongBo(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KcqKhoiLuongGiangDayDoAn_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_KcqKhoiLuongGiangDayDoAn_GetByNamHocHocKyDot 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_GetByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqKhoiLuongGiangDayDoAn&gt;"/> instance.</returns>
		public TList<KcqKhoiLuongGiangDayDoAn> GetByNamHocHocKyDot(System.String namHoc, System.String hocKy, System.String dot)
		{
			return GetByNamHocHocKyDot(null, 0, int.MaxValue , namHoc, hocKy, dot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_GetByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqKhoiLuongGiangDayDoAn&gt;"/> instance.</returns>
		public TList<KcqKhoiLuongGiangDayDoAn> GetByNamHocHocKyDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dot)
		{
			return GetByNamHocHocKyDot(null, start, pageLength , namHoc, hocKy, dot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_GetByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqKhoiLuongGiangDayDoAn&gt;"/> instance.</returns>
		public TList<KcqKhoiLuongGiangDayDoAn> GetByNamHocHocKyDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dot)
		{
			return GetByNamHocHocKyDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, dot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_GetByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqKhoiLuongGiangDayDoAn&gt;"/> instance.</returns>
		public abstract TList<KcqKhoiLuongGiangDayDoAn> GetByNamHocHocKyDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dot);
		
		#endregion
		
		#region cust_KcqKhoiLuongGiangDayDoAn_KiemTraDongBo 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_KiemTraDongBo' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_KiemTraDongBo' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_KiemTraDongBo' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_KiemTraDongBo' stored procedure. 
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
		
		#region cust_KcqKhoiLuongGiangDayDoAn_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_Luu' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_Luu' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_Luu' stored procedure. 
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
		///	This method wrap the 'cust_KcqKhoiLuongGiangDayDoAn_Luu' stored procedure. 
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
		/// Fill a TList&lt;KcqKhoiLuongGiangDayDoAn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqKhoiLuongGiangDayDoAn&gt;"/></returns>
		public static TList<KcqKhoiLuongGiangDayDoAn> Fill(IDataReader reader, TList<KcqKhoiLuongGiangDayDoAn> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqKhoiLuongGiangDayDoAn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqKhoiLuongGiangDayDoAn")
					.Append("|").Append((System.Int32)reader[((int)KcqKhoiLuongGiangDayDoAnColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqKhoiLuongGiangDayDoAn>(
					key.ToString(), // EntityTrackingKey
					"KcqKhoiLuongGiangDayDoAn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqKhoiLuongGiangDayDoAn();
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
					c.Id = (System.Int32)reader[(KcqKhoiLuongGiangDayDoAnColumn.Id.ToString())];
					c.MaMonHoc = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[KcqKhoiLuongGiangDayDoAnColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.TenMonHoc.ToString())];
					c.MaHocPhan = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaHocPhan.ToString())];
					c.NamHoc = (reader[KcqKhoiLuongGiangDayDoAnColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.NamHoc.ToString())];
					c.HocKy = (reader[KcqKhoiLuongGiangDayDoAnColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.HocKy.ToString())];
					c.MaLopHocPhan = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaLopHocPhan.ToString())];
					c.Nhom = (reader[KcqKhoiLuongGiangDayDoAnColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.Nhom.ToString())];
					c.MaLop = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaLop.ToString())];
					c.SoTinChi = (reader[KcqKhoiLuongGiangDayDoAnColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayDoAnColumn.SoTinChi.ToString())];
					c.LopClc = (reader[KcqKhoiLuongGiangDayDoAnColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqKhoiLuongGiangDayDoAnColumn.LopClc.ToString())];
					c.SiSo = (reader[KcqKhoiLuongGiangDayDoAnColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayDoAnColumn.SiSo.ToString())];
					c.MaGiangVienQuanLy = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaGiangVienQuanLy.ToString())];
					c.MaLoaiGiangVien = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaLoaiGiangVien.ToString())];
					c.MaHocHam = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaHocVi.ToString())];
					c.NgayCapNhat = (reader[KcqKhoiLuongGiangDayDoAnColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqKhoiLuongGiangDayDoAnColumn.NgayCapNhat.ToString())];
					c.SoTietQuyDoi = (reader[KcqKhoiLuongGiangDayDoAnColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongGiangDayDoAnColumn.SoTietQuyDoi.ToString())];
					c.DonGia = (reader[KcqKhoiLuongGiangDayDoAnColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongGiangDayDoAnColumn.DonGia.ToString())];
					c.ThanhTien = (reader[KcqKhoiLuongGiangDayDoAnColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongGiangDayDoAnColumn.ThanhTien.ToString())];
					c.HeSoHocKy = (reader[KcqKhoiLuongGiangDayDoAnColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongGiangDayDoAnColumn.HeSoHocKy.ToString())];
					c.MaDot = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaDot.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaDot.ToString())];
					c.MaDiaDiem = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaDiaDiem.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqKhoiLuongGiangDayDoAn entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KcqKhoiLuongGiangDayDoAnColumn.Id.ToString())];
			entity.MaMonHoc = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[KcqKhoiLuongGiangDayDoAnColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.TenMonHoc.ToString())];
			entity.MaHocPhan = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaHocPhan.ToString())];
			entity.NamHoc = (reader[KcqKhoiLuongGiangDayDoAnColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KcqKhoiLuongGiangDayDoAnColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.HocKy.ToString())];
			entity.MaLopHocPhan = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaLopHocPhan.ToString())];
			entity.Nhom = (reader[KcqKhoiLuongGiangDayDoAnColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.Nhom.ToString())];
			entity.MaLop = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaLop.ToString())];
			entity.SoTinChi = (reader[KcqKhoiLuongGiangDayDoAnColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayDoAnColumn.SoTinChi.ToString())];
			entity.LopClc = (reader[KcqKhoiLuongGiangDayDoAnColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqKhoiLuongGiangDayDoAnColumn.LopClc.ToString())];
			entity.SiSo = (reader[KcqKhoiLuongGiangDayDoAnColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayDoAnColumn.SiSo.ToString())];
			entity.MaGiangVienQuanLy = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaGiangVienQuanLy.ToString())];
			entity.MaLoaiGiangVien = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaLoaiGiangVien.ToString())];
			entity.MaHocHam = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaHocVi.ToString())];
			entity.NgayCapNhat = (reader[KcqKhoiLuongGiangDayDoAnColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqKhoiLuongGiangDayDoAnColumn.NgayCapNhat.ToString())];
			entity.SoTietQuyDoi = (reader[KcqKhoiLuongGiangDayDoAnColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongGiangDayDoAnColumn.SoTietQuyDoi.ToString())];
			entity.DonGia = (reader[KcqKhoiLuongGiangDayDoAnColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongGiangDayDoAnColumn.DonGia.ToString())];
			entity.ThanhTien = (reader[KcqKhoiLuongGiangDayDoAnColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongGiangDayDoAnColumn.ThanhTien.ToString())];
			entity.HeSoHocKy = (reader[KcqKhoiLuongGiangDayDoAnColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongGiangDayDoAnColumn.HeSoHocKy.ToString())];
			entity.MaDot = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaDot.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaDot.ToString())];
			entity.MaDiaDiem = (reader[KcqKhoiLuongGiangDayDoAnColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayDoAnColumn.MaDiaDiem.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqKhoiLuongGiangDayDoAn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.MaHocPhan = Convert.IsDBNull(dataRow["MaHocPhan"]) ? null : (System.String)dataRow["MaHocPhan"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
			entity.LopClc = Convert.IsDBNull(dataRow["LopClc"]) ? null : (System.Boolean?)dataRow["LopClc"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.SoTietQuyDoi = Convert.IsDBNull(dataRow["SoTietQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietQuyDoi"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.ThanhTien = Convert.IsDBNull(dataRow["ThanhTien"]) ? null : (System.Decimal?)dataRow["ThanhTien"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
			entity.MaDot = Convert.IsDBNull(dataRow["MaDot"]) ? null : (System.String)dataRow["MaDot"];
			entity.MaDiaDiem = Convert.IsDBNull(dataRow["MaDiaDiem"]) ? null : (System.String)dataRow["MaDiaDiem"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongGiangDayDoAn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqKhoiLuongGiangDayDoAn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongGiangDayDoAn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqKhoiLuongGiangDayDoAn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqKhoiLuongGiangDayDoAn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqKhoiLuongGiangDayDoAn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongGiangDayDoAn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KcqKhoiLuongGiangDayDoAnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqKhoiLuongGiangDayDoAn</c>
	///</summary>
	public enum KcqKhoiLuongGiangDayDoAnChildEntityTypes
	{
	}
	
	#endregion KcqKhoiLuongGiangDayDoAnChildEntityTypes
	
	#region KcqKhoiLuongGiangDayDoAnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqKhoiLuongGiangDayDoAnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayDoAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayDoAnFilterBuilder : SqlFilterBuilder<KcqKhoiLuongGiangDayDoAnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnFilterBuilder class.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqKhoiLuongGiangDayDoAnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqKhoiLuongGiangDayDoAnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqKhoiLuongGiangDayDoAnFilterBuilder
	
	#region KcqKhoiLuongGiangDayDoAnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqKhoiLuongGiangDayDoAnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayDoAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayDoAnParameterBuilder : ParameterizedSqlFilterBuilder<KcqKhoiLuongGiangDayDoAnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnParameterBuilder class.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqKhoiLuongGiangDayDoAnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqKhoiLuongGiangDayDoAnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqKhoiLuongGiangDayDoAnParameterBuilder
	
	#region KcqKhoiLuongGiangDayDoAnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqKhoiLuongGiangDayDoAnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayDoAn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqKhoiLuongGiangDayDoAnSortBuilder : SqlSortBuilder<KcqKhoiLuongGiangDayDoAnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnSqlSortBuilder class.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqKhoiLuongGiangDayDoAnSortBuilder
	
} // end namespace
