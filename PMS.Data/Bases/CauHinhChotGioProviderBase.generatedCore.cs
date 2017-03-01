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
	/// This class is the base class for any <see cref="CauHinhChotGioProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CauHinhChotGioProviderBaseCore : EntityProviderBase<PMS.Entities.CauHinhChotGio, PMS.Entities.CauHinhChotGioKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.CauHinhChotGioKey key)
		{
			return Delete(transactionManager, key.MaCauHinhChotGio);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maCauHinhChotGio">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maCauHinhChotGio)
		{
			return Delete(null, _maCauHinhChotGio);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinhChotGio">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maCauHinhChotGio);		
		
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
		public override PMS.Entities.CauHinhChotGio Get(TransactionManager transactionManager, PMS.Entities.CauHinhChotGioKey key, int start, int pageLength)
		{
			return GetByMaCauHinhChotGio(transactionManager, key.MaCauHinhChotGio, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CauHinhChotGio index.
		/// </summary>
		/// <param name="_maCauHinhChotGio"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhChotGio"/> class.</returns>
		public PMS.Entities.CauHinhChotGio GetByMaCauHinhChotGio(System.Int32 _maCauHinhChotGio)
		{
			int count = -1;
			return GetByMaCauHinhChotGio(null,_maCauHinhChotGio, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhChotGio index.
		/// </summary>
		/// <param name="_maCauHinhChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhChotGio"/> class.</returns>
		public PMS.Entities.CauHinhChotGio GetByMaCauHinhChotGio(System.Int32 _maCauHinhChotGio, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCauHinhChotGio(null, _maCauHinhChotGio, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhChotGio index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhChotGio"/> class.</returns>
		public PMS.Entities.CauHinhChotGio GetByMaCauHinhChotGio(TransactionManager transactionManager, System.Int32 _maCauHinhChotGio)
		{
			int count = -1;
			return GetByMaCauHinhChotGio(transactionManager, _maCauHinhChotGio, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhChotGio index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhChotGio"/> class.</returns>
		public PMS.Entities.CauHinhChotGio GetByMaCauHinhChotGio(TransactionManager transactionManager, System.Int32 _maCauHinhChotGio, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCauHinhChotGio(transactionManager, _maCauHinhChotGio, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhChotGio index.
		/// </summary>
		/// <param name="_maCauHinhChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhChotGio"/> class.</returns>
		public PMS.Entities.CauHinhChotGio GetByMaCauHinhChotGio(System.Int32 _maCauHinhChotGio, int start, int pageLength, out int count)
		{
			return GetByMaCauHinhChotGio(null, _maCauHinhChotGio, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhChotGio index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhChotGio"/> class.</returns>
		public abstract PMS.Entities.CauHinhChotGio GetByMaCauHinhChotGio(TransactionManager transactionManager, System.Int32 _maCauHinhChotGio, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_CauHinhChotGio_GetByListMaCauHinhChotGio 
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByListMaCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="listMaCauHinhChotGio"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByListMaCauHinhChotGio(System.String listMaCauHinhChotGio)
		{
			return GetByListMaCauHinhChotGio(null, 0, int.MaxValue , listMaCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByListMaCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="listMaCauHinhChotGio"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByListMaCauHinhChotGio(int start, int pageLength, System.String listMaCauHinhChotGio)
		{
			return GetByListMaCauHinhChotGio(null, start, pageLength , listMaCauHinhChotGio);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByListMaCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="listMaCauHinhChotGio"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByListMaCauHinhChotGio(TransactionManager transactionManager, System.String listMaCauHinhChotGio)
		{
			return GetByListMaCauHinhChotGio(transactionManager, 0, int.MaxValue , listMaCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByListMaCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="listMaCauHinhChotGio"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public abstract TList<CauHinhChotGio> GetByListMaCauHinhChotGio(TransactionManager transactionManager, int start, int pageLength , System.String listMaCauHinhChotGio);
		
		#endregion
		
		#region cust_CauHinhChotGio_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public abstract TList<CauHinhChotGio> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_CauHinhChotGio_GetByNamHocHocKyTamUng 
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByNamHocHocKyTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByNamHocHocKyTamUng(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyTamUng(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByNamHocHocKyTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByNamHocHocKyTamUng(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyTamUng(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByNamHocHocKyTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByNamHocHocKyTamUng(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyTamUng(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByNamHocHocKyTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public abstract TList<CauHinhChotGio> GetByNamHocHocKyTamUng(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_CauHinhChotGio_GetByNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByNamHoc(System.String namHoc)
		{
			return GetByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return GetByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return GetByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public abstract TList<CauHinhChotGio> GetByNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_CauHinhChotGio_GetByTuNgayDenNgay 
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByTuNgayDenNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByTuNgayDenNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public TList<CauHinhChotGio> GetByTuNgayDenNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChotGio_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;CauHinhChotGio&gt;"/> instance.</returns>
		public abstract TList<CauHinhChotGio> GetByTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength , System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CauHinhChotGio&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CauHinhChotGio&gt;"/></returns>
		public static TList<CauHinhChotGio> Fill(IDataReader reader, TList<CauHinhChotGio> rows, int start, int pageLength)
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
				
				PMS.Entities.CauHinhChotGio c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CauHinhChotGio")
					.Append("|").Append((System.Int32)reader[((int)CauHinhChotGioColumn.MaCauHinhChotGio - 1)]).ToString();
					c = EntityManager.LocateOrCreate<CauHinhChotGio>(
					key.ToString(), // EntityTrackingKey
					"CauHinhChotGio",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.CauHinhChotGio();
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
					c.MaCauHinhChotGio = (System.Int32)reader[(CauHinhChotGioColumn.MaCauHinhChotGio.ToString())];
					c.MaQuanLy = (reader[CauHinhChotGioColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhChotGioColumn.MaQuanLy.ToString())];
					c.TenQuanLy = (reader[CauHinhChotGioColumn.TenQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhChotGioColumn.TenQuanLy.ToString())];
					c.TuNgay = (reader[CauHinhChotGioColumn.TuNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(CauHinhChotGioColumn.TuNgay.ToString())];
					c.DenNgay = (reader[CauHinhChotGioColumn.DenNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(CauHinhChotGioColumn.DenNgay.ToString())];
					c.IsLocked = (reader[CauHinhChotGioColumn.IsLocked.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CauHinhChotGioColumn.IsLocked.ToString())];
					c.NamHoc = (System.String)reader[(CauHinhChotGioColumn.NamHoc.ToString())];
					c.HocKy = (System.String)reader[(CauHinhChotGioColumn.HocKy.ToString())];
					c.PhanTramDonGia = (reader[CauHinhChotGioColumn.PhanTramDonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CauHinhChotGioColumn.PhanTramDonGia.ToString())];
					c.PhanTramHeSoCongThem = (reader[CauHinhChotGioColumn.PhanTramHeSoCongThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CauHinhChotGioColumn.PhanTramHeSoCongThem.ToString())];
					c.CoTinhNckh = (reader[CauHinhChotGioColumn.CoTinhNckh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CauHinhChotGioColumn.CoTinhNckh.ToString())];
					c.TinhVaoCaNam = (reader[CauHinhChotGioColumn.TinhVaoCaNam.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CauHinhChotGioColumn.TinhVaoCaNam.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CauHinhChotGio"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CauHinhChotGio"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.CauHinhChotGio entity)
		{
			if (!reader.Read()) return;
			
			entity.MaCauHinhChotGio = (System.Int32)reader[(CauHinhChotGioColumn.MaCauHinhChotGio.ToString())];
			entity.MaQuanLy = (reader[CauHinhChotGioColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhChotGioColumn.MaQuanLy.ToString())];
			entity.TenQuanLy = (reader[CauHinhChotGioColumn.TenQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhChotGioColumn.TenQuanLy.ToString())];
			entity.TuNgay = (reader[CauHinhChotGioColumn.TuNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(CauHinhChotGioColumn.TuNgay.ToString())];
			entity.DenNgay = (reader[CauHinhChotGioColumn.DenNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(CauHinhChotGioColumn.DenNgay.ToString())];
			entity.IsLocked = (reader[CauHinhChotGioColumn.IsLocked.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CauHinhChotGioColumn.IsLocked.ToString())];
			entity.NamHoc = (System.String)reader[(CauHinhChotGioColumn.NamHoc.ToString())];
			entity.HocKy = (System.String)reader[(CauHinhChotGioColumn.HocKy.ToString())];
			entity.PhanTramDonGia = (reader[CauHinhChotGioColumn.PhanTramDonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CauHinhChotGioColumn.PhanTramDonGia.ToString())];
			entity.PhanTramHeSoCongThem = (reader[CauHinhChotGioColumn.PhanTramHeSoCongThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(CauHinhChotGioColumn.PhanTramHeSoCongThem.ToString())];
			entity.CoTinhNckh = (reader[CauHinhChotGioColumn.CoTinhNckh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CauHinhChotGioColumn.CoTinhNckh.ToString())];
			entity.TinhVaoCaNam = (reader[CauHinhChotGioColumn.TinhVaoCaNam.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CauHinhChotGioColumn.TinhVaoCaNam.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CauHinhChotGio"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CauHinhChotGio"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.CauHinhChotGio entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaCauHinhChotGio = (System.Int32)dataRow["MaCauHinhChotGio"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.TenQuanLy = Convert.IsDBNull(dataRow["TenQuanLy"]) ? null : (System.String)dataRow["TenQuanLy"];
			entity.TuNgay = Convert.IsDBNull(dataRow["TuNgay"]) ? null : (System.DateTime?)dataRow["TuNgay"];
			entity.DenNgay = Convert.IsDBNull(dataRow["DenNgay"]) ? null : (System.DateTime?)dataRow["DenNgay"];
			entity.IsLocked = Convert.IsDBNull(dataRow["IsLocked"]) ? null : (System.Boolean?)dataRow["IsLocked"];
			entity.NamHoc = (System.String)dataRow["NamHoc"];
			entity.HocKy = (System.String)dataRow["HocKy"];
			entity.PhanTramDonGia = Convert.IsDBNull(dataRow["PhanTramDonGia"]) ? null : (System.Decimal?)dataRow["PhanTramDonGia"];
			entity.PhanTramHeSoCongThem = Convert.IsDBNull(dataRow["PhanTramHeSoCongThem"]) ? null : (System.Decimal?)dataRow["PhanTramHeSoCongThem"];
			entity.CoTinhNckh = Convert.IsDBNull(dataRow["CoTinhNckh"]) ? null : (System.Boolean?)dataRow["CoTinhNckh"];
			entity.TinhVaoCaNam = Convert.IsDBNull(dataRow["TinhVaoCaNam"]) ? null : (System.Boolean?)dataRow["TinhVaoCaNam"];
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
		/// <param name="entity">The <see cref="PMS.Entities.CauHinhChotGio"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.CauHinhChotGio Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.CauHinhChotGio entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaCauHinhChotGio methods when available
			
			#region KhoiLuongGiangDayCaoDangCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<KhoiLuongGiangDayCaoDang>|KhoiLuongGiangDayCaoDangCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'KhoiLuongGiangDayCaoDangCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.KhoiLuongGiangDayCaoDangCollection = DataRepository.KhoiLuongGiangDayCaoDangProvider.GetByMaCauHinhChotGio(transactionManager, entity.MaCauHinhChotGio);

				if (deep && entity.KhoiLuongGiangDayCaoDangCollection.Count > 0)
				{
					deepHandles.Add("KhoiLuongGiangDayCaoDangCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<KhoiLuongGiangDayCaoDang>) DataRepository.KhoiLuongGiangDayCaoDangProvider.DeepLoad,
						new object[] { transactionManager, entity.KhoiLuongGiangDayCaoDangCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.CauHinhChotGio object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.CauHinhChotGio instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.CauHinhChotGio Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.CauHinhChotGio entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<KhoiLuongGiangDayCaoDang>
				if (CanDeepSave(entity.KhoiLuongGiangDayCaoDangCollection, "List<KhoiLuongGiangDayCaoDang>|KhoiLuongGiangDayCaoDangCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(KhoiLuongGiangDayCaoDang child in entity.KhoiLuongGiangDayCaoDangCollection)
					{
						if(child.MaCauHinhChotGioSource != null)
						{
							child.MaCauHinhChotGio = child.MaCauHinhChotGioSource.MaCauHinhChotGio;
						}
						else
						{
							child.MaCauHinhChotGio = entity.MaCauHinhChotGio;
						}

					}

					if (entity.KhoiLuongGiangDayCaoDangCollection.Count > 0 || entity.KhoiLuongGiangDayCaoDangCollection.DeletedItems.Count > 0)
					{
						//DataRepository.KhoiLuongGiangDayCaoDangProvider.Save(transactionManager, entity.KhoiLuongGiangDayCaoDangCollection);
						
						deepHandles.Add("KhoiLuongGiangDayCaoDangCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< KhoiLuongGiangDayCaoDang >) DataRepository.KhoiLuongGiangDayCaoDangProvider.DeepSave,
							new object[] { transactionManager, entity.KhoiLuongGiangDayCaoDangCollection, deepSaveType, childTypes, innerList }
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
	
	#region CauHinhChotGioChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.CauHinhChotGio</c>
	///</summary>
	public enum CauHinhChotGioChildEntityTypes
	{
		///<summary>
		/// Collection of <c>CauHinhChotGio</c> as OneToMany for KhoiLuongGiangDayCaoDangCollection
		///</summary>
		[ChildEntityType(typeof(TList<KhoiLuongGiangDayCaoDang>))]
		KhoiLuongGiangDayCaoDangCollection,
	}
	
	#endregion CauHinhChotGioChildEntityTypes
	
	#region CauHinhChotGioFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CauHinhChotGioColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhChotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhChotGioFilterBuilder : SqlFilterBuilder<CauHinhChotGioColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhChotGioFilterBuilder class.
		/// </summary>
		public CauHinhChotGioFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CauHinhChotGioFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CauHinhChotGioFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CauHinhChotGioFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CauHinhChotGioFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CauHinhChotGioFilterBuilder
	
	#region CauHinhChotGioParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CauHinhChotGioColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhChotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhChotGioParameterBuilder : ParameterizedSqlFilterBuilder<CauHinhChotGioColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhChotGioParameterBuilder class.
		/// </summary>
		public CauHinhChotGioParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CauHinhChotGioParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CauHinhChotGioParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CauHinhChotGioParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CauHinhChotGioParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CauHinhChotGioParameterBuilder
	
	#region CauHinhChotGioSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CauHinhChotGioColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhChotGio"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CauHinhChotGioSortBuilder : SqlSortBuilder<CauHinhChotGioColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhChotGioSqlSortBuilder class.
		/// </summary>
		public CauHinhChotGioSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CauHinhChotGioSortBuilder
	
} // end namespace
