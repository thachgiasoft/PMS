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
	/// This class is the base class for any <see cref="HeSoQuyDoiGioTroiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoQuyDoiGioTroiProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoQuyDoiGioTroi, PMS.Entities.HeSoQuyDoiGioTroiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoQuyDoiGioTroiKey key)
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
		public override PMS.Entities.HeSoQuyDoiGioTroi Get(TransactionManager transactionManager, PMS.Entities.HeSoQuyDoiGioTroiKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeSoQuyDoiGioTroi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoQuyDoiGioTroi"/> class.</returns>
		public PMS.Entities.HeSoQuyDoiGioTroi GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoQuyDoiGioTroi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoQuyDoiGioTroi"/> class.</returns>
		public PMS.Entities.HeSoQuyDoiGioTroi GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoQuyDoiGioTroi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoQuyDoiGioTroi"/> class.</returns>
		public PMS.Entities.HeSoQuyDoiGioTroi GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoQuyDoiGioTroi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoQuyDoiGioTroi"/> class.</returns>
		public PMS.Entities.HeSoQuyDoiGioTroi GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoQuyDoiGioTroi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoQuyDoiGioTroi"/> class.</returns>
		public PMS.Entities.HeSoQuyDoiGioTroi GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoQuyDoiGioTroi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoQuyDoiGioTroi"/> class.</returns>
		public abstract PMS.Entities.HeSoQuyDoiGioTroi GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HeSoQuyDoiGioTroi_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_SaoChep' stored procedure. 
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
		
		#region cust_HeSoQuyDoiGioTroi_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoQuyDoiGioTroi&gt;"/> instance.</returns>
		public TList<HeSoQuyDoiGioTroi> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoQuyDoiGioTroi&gt;"/> instance.</returns>
		public TList<HeSoQuyDoiGioTroi> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoQuyDoiGioTroi&gt;"/> instance.</returns>
		public TList<HeSoQuyDoiGioTroi> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoQuyDoiGioTroi&gt;"/> instance.</returns>
		public abstract TList<HeSoQuyDoiGioTroi> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_HeSoQuyDoiGioTroi_GetByMaGiangVienNgay 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_GetByMaGiangVienNgay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienNgay(System.Int32 maGiangVien, System.String namHoc, System.String hocKy, System.DateTime ngay, ref System.Double heSo)
		{
			 GetByMaGiangVienNgay(null, 0, int.MaxValue , maGiangVien, namHoc, hocKy, ngay, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_GetByMaGiangVienNgay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienNgay(int start, int pageLength, System.Int32 maGiangVien, System.String namHoc, System.String hocKy, System.DateTime ngay, ref System.Double heSo)
		{
			 GetByMaGiangVienNgay(null, start, pageLength , maGiangVien, namHoc, hocKy, ngay, ref heSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_GetByMaGiangVienNgay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienNgay(TransactionManager transactionManager, System.Int32 maGiangVien, System.String namHoc, System.String hocKy, System.DateTime ngay, ref System.Double heSo)
		{
			 GetByMaGiangVienNgay(transactionManager, 0, int.MaxValue , maGiangVien, namHoc, hocKy, ngay, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_GetByMaGiangVienNgay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaGiangVienNgay(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.String namHoc, System.String hocKy, System.DateTime ngay, ref System.Double heSo);
		
		#endregion
		
		#region cust_HeSoQuyDoiGioTroi_GetByMaGiangVienNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienNamHocHocKy(System.Int32 maGiangVien, System.String namHoc, System.String hocKy, ref System.Double heSo)
		{
			 GetByMaGiangVienNamHocHocKy(null, 0, int.MaxValue , maGiangVien, namHoc, hocKy, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienNamHocHocKy(int start, int pageLength, System.Int32 maGiangVien, System.String namHoc, System.String hocKy, ref System.Double heSo)
		{
			 GetByMaGiangVienNamHocHocKy(null, start, pageLength , maGiangVien, namHoc, hocKy, ref heSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienNamHocHocKy(TransactionManager transactionManager, System.Int32 maGiangVien, System.String namHoc, System.String hocKy, ref System.Double heSo)
		{
			 GetByMaGiangVienNamHocHocKy(transactionManager, 0, int.MaxValue , maGiangVien, namHoc, hocKy, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoQuyDoiGioTroi_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaGiangVienNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.String namHoc, System.String hocKy, ref System.Double heSo);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoQuyDoiGioTroi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoQuyDoiGioTroi&gt;"/></returns>
		public static TList<HeSoQuyDoiGioTroi> Fill(IDataReader reader, TList<HeSoQuyDoiGioTroi> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoQuyDoiGioTroi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoQuyDoiGioTroi")
					.Append("|").Append((System.Int32)reader[((int)HeSoQuyDoiGioTroiColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoQuyDoiGioTroi>(
					key.ToString(), // EntityTrackingKey
					"HeSoQuyDoiGioTroi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoQuyDoiGioTroi();
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
					c.Id = (System.Int32)reader[(HeSoQuyDoiGioTroiColumn.Id.ToString())];
					c.NamHoc = (reader[HeSoQuyDoiGioTroiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoQuyDoiGioTroiColumn.NamHoc.ToString())];
					c.HocKy = (reader[HeSoQuyDoiGioTroiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoQuyDoiGioTroiColumn.HocKy.ToString())];
					c.MaHocHam = (reader[HeSoQuyDoiGioTroiColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoQuyDoiGioTroiColumn.MaHocHam.ToString())];
					c.MaBacLuong = (reader[HeSoQuyDoiGioTroiColumn.MaBacLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoQuyDoiGioTroiColumn.MaBacLuong.ToString())];
					c.HeSo = (reader[HeSoQuyDoiGioTroiColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoQuyDoiGioTroiColumn.HeSo.ToString())];
					c.GhiChu = (reader[HeSoQuyDoiGioTroiColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoQuyDoiGioTroiColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoQuyDoiGioTroi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoQuyDoiGioTroi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoQuyDoiGioTroi entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(HeSoQuyDoiGioTroiColumn.Id.ToString())];
			entity.NamHoc = (reader[HeSoQuyDoiGioTroiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoQuyDoiGioTroiColumn.NamHoc.ToString())];
			entity.HocKy = (reader[HeSoQuyDoiGioTroiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoQuyDoiGioTroiColumn.HocKy.ToString())];
			entity.MaHocHam = (reader[HeSoQuyDoiGioTroiColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoQuyDoiGioTroiColumn.MaHocHam.ToString())];
			entity.MaBacLuong = (reader[HeSoQuyDoiGioTroiColumn.MaBacLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoQuyDoiGioTroiColumn.MaBacLuong.ToString())];
			entity.HeSo = (reader[HeSoQuyDoiGioTroiColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoQuyDoiGioTroiColumn.HeSo.ToString())];
			entity.GhiChu = (reader[HeSoQuyDoiGioTroiColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoQuyDoiGioTroiColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoQuyDoiGioTroi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoQuyDoiGioTroi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoQuyDoiGioTroi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaBacLuong = Convert.IsDBNull(dataRow["MaBacLuong"]) ? null : (System.String)dataRow["MaBacLuong"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoQuyDoiGioTroi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoQuyDoiGioTroi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoQuyDoiGioTroi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoQuyDoiGioTroi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoQuyDoiGioTroi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoQuyDoiGioTroi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoQuyDoiGioTroi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HeSoQuyDoiGioTroiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoQuyDoiGioTroi</c>
	///</summary>
	public enum HeSoQuyDoiGioTroiChildEntityTypes
	{
	}
	
	#endregion HeSoQuyDoiGioTroiChildEntityTypes
	
	#region HeSoQuyDoiGioTroiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoQuyDoiGioTroiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiGioTroi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoQuyDoiGioTroiFilterBuilder : SqlFilterBuilder<HeSoQuyDoiGioTroiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioTroiFilterBuilder class.
		/// </summary>
		public HeSoQuyDoiGioTroiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioTroiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoQuyDoiGioTroiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioTroiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoQuyDoiGioTroiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoQuyDoiGioTroiFilterBuilder
	
	#region HeSoQuyDoiGioTroiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoQuyDoiGioTroiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiGioTroi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoQuyDoiGioTroiParameterBuilder : ParameterizedSqlFilterBuilder<HeSoQuyDoiGioTroiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioTroiParameterBuilder class.
		/// </summary>
		public HeSoQuyDoiGioTroiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioTroiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoQuyDoiGioTroiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioTroiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoQuyDoiGioTroiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoQuyDoiGioTroiParameterBuilder
	
	#region HeSoQuyDoiGioTroiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoQuyDoiGioTroiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoQuyDoiGioTroi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoQuyDoiGioTroiSortBuilder : SqlSortBuilder<HeSoQuyDoiGioTroiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioTroiSqlSortBuilder class.
		/// </summary>
		public HeSoQuyDoiGioTroiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoQuyDoiGioTroiSortBuilder
	
} // end namespace
