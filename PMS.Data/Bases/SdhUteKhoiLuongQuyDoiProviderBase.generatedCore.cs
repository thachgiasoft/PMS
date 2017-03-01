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
	/// This class is the base class for any <see cref="SdhUteKhoiLuongQuyDoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SdhUteKhoiLuongQuyDoiProviderBaseCore : EntityProviderBase<PMS.Entities.SdhUteKhoiLuongQuyDoi, PMS.Entities.SdhUteKhoiLuongQuyDoiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.SdhUteKhoiLuongQuyDoiKey key)
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
		/// 	Gets rows from the datasource based on the FK_SdhUte_KhoiLuongQuyDoi_SdhUte_KhoiLuongGiangDay key.
		///		FK_SdhUte_KhoiLuongQuyDoi_SdhUte_KhoiLuongGiangDay Description: 
		/// </summary>
		/// <param name="_idKhoiLuongGiangDay"></param>
		/// <returns>Returns a typed collection of PMS.Entities.SdhUteKhoiLuongQuyDoi objects.</returns>
		public TList<SdhUteKhoiLuongQuyDoi> GetByIdKhoiLuongGiangDay(System.Int32 _idKhoiLuongGiangDay)
		{
			int count = -1;
			return GetByIdKhoiLuongGiangDay(_idKhoiLuongGiangDay, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SdhUte_KhoiLuongQuyDoi_SdhUte_KhoiLuongGiangDay key.
		///		FK_SdhUte_KhoiLuongQuyDoi_SdhUte_KhoiLuongGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idKhoiLuongGiangDay"></param>
		/// <returns>Returns a typed collection of PMS.Entities.SdhUteKhoiLuongQuyDoi objects.</returns>
		/// <remarks></remarks>
		public TList<SdhUteKhoiLuongQuyDoi> GetByIdKhoiLuongGiangDay(TransactionManager transactionManager, System.Int32 _idKhoiLuongGiangDay)
		{
			int count = -1;
			return GetByIdKhoiLuongGiangDay(transactionManager, _idKhoiLuongGiangDay, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SdhUte_KhoiLuongQuyDoi_SdhUte_KhoiLuongGiangDay key.
		///		FK_SdhUte_KhoiLuongQuyDoi_SdhUte_KhoiLuongGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idKhoiLuongGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.SdhUteKhoiLuongQuyDoi objects.</returns>
		public TList<SdhUteKhoiLuongQuyDoi> GetByIdKhoiLuongGiangDay(TransactionManager transactionManager, System.Int32 _idKhoiLuongGiangDay, int start, int pageLength)
		{
			int count = -1;
			return GetByIdKhoiLuongGiangDay(transactionManager, _idKhoiLuongGiangDay, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SdhUte_KhoiLuongQuyDoi_SdhUte_KhoiLuongGiangDay key.
		///		fkSdhUteKhoiLuongQuyDoiSdhUteKhoiLuongGiangDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_idKhoiLuongGiangDay"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.SdhUteKhoiLuongQuyDoi objects.</returns>
		public TList<SdhUteKhoiLuongQuyDoi> GetByIdKhoiLuongGiangDay(System.Int32 _idKhoiLuongGiangDay, int start, int pageLength)
		{
			int count =  -1;
			return GetByIdKhoiLuongGiangDay(null, _idKhoiLuongGiangDay, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SdhUte_KhoiLuongQuyDoi_SdhUte_KhoiLuongGiangDay key.
		///		fkSdhUteKhoiLuongQuyDoiSdhUteKhoiLuongGiangDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_idKhoiLuongGiangDay"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.SdhUteKhoiLuongQuyDoi objects.</returns>
		public TList<SdhUteKhoiLuongQuyDoi> GetByIdKhoiLuongGiangDay(System.Int32 _idKhoiLuongGiangDay, int start, int pageLength,out int count)
		{
			return GetByIdKhoiLuongGiangDay(null, _idKhoiLuongGiangDay, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SdhUte_KhoiLuongQuyDoi_SdhUte_KhoiLuongGiangDay key.
		///		FK_SdhUte_KhoiLuongQuyDoi_SdhUte_KhoiLuongGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idKhoiLuongGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.SdhUteKhoiLuongQuyDoi objects.</returns>
		public abstract TList<SdhUteKhoiLuongQuyDoi> GetByIdKhoiLuongGiangDay(TransactionManager transactionManager, System.Int32 _idKhoiLuongGiangDay, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.SdhUteKhoiLuongQuyDoi Get(TransactionManager transactionManager, PMS.Entities.SdhUteKhoiLuongQuyDoiKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SdhUte_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhUteKhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.SdhUteKhoiLuongQuyDoi GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhUte_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhUteKhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.SdhUteKhoiLuongQuyDoi GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhUte_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhUteKhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.SdhUteKhoiLuongQuyDoi GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhUte_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhUteKhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.SdhUteKhoiLuongQuyDoi GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhUte_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhUteKhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.SdhUteKhoiLuongQuyDoi GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhUte_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhUteKhoiLuongQuyDoi"/> class.</returns>
		public abstract PMS.Entities.SdhUteKhoiLuongQuyDoi GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_SdhUte_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKyQuyCheMoi 
		
		/// <summary>
		///	This method wrap the 'cust_SdhUte_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKyQuyCheMoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoNamHocHocKyQuyCheMoi(System.String namHoc, System.String hocKy)
		{
			 QuyDoiTheoNamHocHocKyQuyCheMoi(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhUte_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKyQuyCheMoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoNamHocHocKyQuyCheMoi(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 QuyDoiTheoNamHocHocKyQuyCheMoi(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_SdhUte_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKyQuyCheMoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoNamHocHocKyQuyCheMoi(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 QuyDoiTheoNamHocHocKyQuyCheMoi(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhUte_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKyQuyCheMoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void QuyDoiTheoNamHocHocKyQuyCheMoi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_SdhUte_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_SdhUte_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			 QuyDoiTheoNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhUte_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 QuyDoiTheoNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_SdhUte_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 QuyDoiTheoNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhUte_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void QuyDoiTheoNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SdhUteKhoiLuongQuyDoi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SdhUteKhoiLuongQuyDoi&gt;"/></returns>
		public static TList<SdhUteKhoiLuongQuyDoi> Fill(IDataReader reader, TList<SdhUteKhoiLuongQuyDoi> rows, int start, int pageLength)
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
				
				PMS.Entities.SdhUteKhoiLuongQuyDoi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SdhUteKhoiLuongQuyDoi")
					.Append("|").Append((System.Int32)reader[((int)SdhUteKhoiLuongQuyDoiColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<SdhUteKhoiLuongQuyDoi>(
					key.ToString(), // EntityTrackingKey
					"SdhUteKhoiLuongQuyDoi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.SdhUteKhoiLuongQuyDoi();
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
					c.Id = (System.Int32)reader[(SdhUteKhoiLuongQuyDoiColumn.Id.ToString())];
					c.IdKhoiLuongGiangDay = (System.Int32)reader[(SdhUteKhoiLuongQuyDoiColumn.IdKhoiLuongGiangDay.ToString())];
					c.HeSoLopDongLyThuyet = (reader[SdhUteKhoiLuongQuyDoiColumn.HeSoLopDongLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteKhoiLuongQuyDoiColumn.HeSoLopDongLyThuyet.ToString())];
					c.HeSoLopDongThTnTt = (reader[SdhUteKhoiLuongQuyDoiColumn.HeSoLopDongThTnTt.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteKhoiLuongQuyDoiColumn.HeSoLopDongThTnTt.ToString())];
					c.TietQuyDoi = (reader[SdhUteKhoiLuongQuyDoiColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteKhoiLuongQuyDoiColumn.TietQuyDoi.ToString())];
					c.NgayCapNhat = (reader[SdhUteKhoiLuongQuyDoiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(SdhUteKhoiLuongQuyDoiColumn.NgayCapNhat.ToString())];
					c.SoGioThucGiangTrenLop = (reader[SdhUteKhoiLuongQuyDoiColumn.SoGioThucGiangTrenLop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteKhoiLuongQuyDoiColumn.SoGioThucGiangTrenLop.ToString())];
					c.SoGioChuanTinhThem = (reader[SdhUteKhoiLuongQuyDoiColumn.SoGioChuanTinhThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteKhoiLuongQuyDoiColumn.SoGioChuanTinhThem.ToString())];
					c.HeSoHocKy = (reader[SdhUteKhoiLuongQuyDoiColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteKhoiLuongQuyDoiColumn.HeSoHocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SdhUteKhoiLuongQuyDoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SdhUteKhoiLuongQuyDoi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.SdhUteKhoiLuongQuyDoi entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(SdhUteKhoiLuongQuyDoiColumn.Id.ToString())];
			entity.IdKhoiLuongGiangDay = (System.Int32)reader[(SdhUteKhoiLuongQuyDoiColumn.IdKhoiLuongGiangDay.ToString())];
			entity.HeSoLopDongLyThuyet = (reader[SdhUteKhoiLuongQuyDoiColumn.HeSoLopDongLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteKhoiLuongQuyDoiColumn.HeSoLopDongLyThuyet.ToString())];
			entity.HeSoLopDongThTnTt = (reader[SdhUteKhoiLuongQuyDoiColumn.HeSoLopDongThTnTt.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteKhoiLuongQuyDoiColumn.HeSoLopDongThTnTt.ToString())];
			entity.TietQuyDoi = (reader[SdhUteKhoiLuongQuyDoiColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteKhoiLuongQuyDoiColumn.TietQuyDoi.ToString())];
			entity.NgayCapNhat = (reader[SdhUteKhoiLuongQuyDoiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(SdhUteKhoiLuongQuyDoiColumn.NgayCapNhat.ToString())];
			entity.SoGioThucGiangTrenLop = (reader[SdhUteKhoiLuongQuyDoiColumn.SoGioThucGiangTrenLop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteKhoiLuongQuyDoiColumn.SoGioThucGiangTrenLop.ToString())];
			entity.SoGioChuanTinhThem = (reader[SdhUteKhoiLuongQuyDoiColumn.SoGioChuanTinhThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteKhoiLuongQuyDoiColumn.SoGioChuanTinhThem.ToString())];
			entity.HeSoHocKy = (reader[SdhUteKhoiLuongQuyDoiColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteKhoiLuongQuyDoiColumn.HeSoHocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SdhUteKhoiLuongQuyDoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SdhUteKhoiLuongQuyDoi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.SdhUteKhoiLuongQuyDoi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.IdKhoiLuongGiangDay = (System.Int32)dataRow["IdKhoiLuongGiangDay"];
			entity.HeSoLopDongLyThuyet = Convert.IsDBNull(dataRow["HeSoLopDongLyThuyet"]) ? null : (System.Decimal?)dataRow["HeSoLopDongLyThuyet"];
			entity.HeSoLopDongThTnTt = Convert.IsDBNull(dataRow["HeSoLopDongThTnTt"]) ? null : (System.Decimal?)dataRow["HeSoLopDongThTnTt"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.SoGioThucGiangTrenLop = Convert.IsDBNull(dataRow["SoGioThucGiangTrenLop"]) ? null : (System.Decimal?)dataRow["SoGioThucGiangTrenLop"];
			entity.SoGioChuanTinhThem = Convert.IsDBNull(dataRow["SoGioChuanTinhThem"]) ? null : (System.Decimal?)dataRow["SoGioChuanTinhThem"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.SdhUteKhoiLuongQuyDoi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.SdhUteKhoiLuongQuyDoi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.SdhUteKhoiLuongQuyDoi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region IdKhoiLuongGiangDaySource	
			if (CanDeepLoad(entity, "SdhUteKhoiLuongGiangDay|IdKhoiLuongGiangDaySource", deepLoadType, innerList) 
				&& entity.IdKhoiLuongGiangDaySource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.IdKhoiLuongGiangDay;
				SdhUteKhoiLuongGiangDay tmpEntity = EntityManager.LocateEntity<SdhUteKhoiLuongGiangDay>(EntityLocator.ConstructKeyFromPkItems(typeof(SdhUteKhoiLuongGiangDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.IdKhoiLuongGiangDaySource = tmpEntity;
				else
					entity.IdKhoiLuongGiangDaySource = DataRepository.SdhUteKhoiLuongGiangDayProvider.GetById(transactionManager, entity.IdKhoiLuongGiangDay);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'IdKhoiLuongGiangDaySource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.IdKhoiLuongGiangDaySource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SdhUteKhoiLuongGiangDayProvider.DeepLoad(transactionManager, entity.IdKhoiLuongGiangDaySource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion IdKhoiLuongGiangDaySource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetById methods when available
			
			#region SdhUteThanhToanThuLao
			// RelationshipType.OneToOne
			if (CanDeepLoad(entity, "SdhUteThanhToanThuLao|SdhUteThanhToanThuLao", deepLoadType, innerList))
			{
				entity.SdhUteThanhToanThuLao = DataRepository.SdhUteThanhToanThuLaoProvider.GetByIdKhoiLuongQuyDoi(transactionManager, entity.Id);
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SdhUteThanhToanThuLao' loaded. key " + entity.EntityTrackingKey);
				#endif 

				if (deep && entity.SdhUteThanhToanThuLao != null)
				{
					deepHandles.Add("SdhUteThanhToanThuLao",
						new KeyValuePair<Delegate, object>((DeepLoadSingleHandle< SdhUteThanhToanThuLao >) DataRepository.SdhUteThanhToanThuLaoProvider.DeepLoad,
						new object[] { transactionManager, entity.SdhUteThanhToanThuLao, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.SdhUteKhoiLuongQuyDoi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.SdhUteKhoiLuongQuyDoi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.SdhUteKhoiLuongQuyDoi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.SdhUteKhoiLuongQuyDoi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region IdKhoiLuongGiangDaySource
			if (CanDeepSave(entity, "SdhUteKhoiLuongGiangDay|IdKhoiLuongGiangDaySource", deepSaveType, innerList) 
				&& entity.IdKhoiLuongGiangDaySource != null)
			{
				DataRepository.SdhUteKhoiLuongGiangDayProvider.Save(transactionManager, entity.IdKhoiLuongGiangDaySource);
				entity.IdKhoiLuongGiangDay = entity.IdKhoiLuongGiangDaySource.Id;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();

			#region SdhUteThanhToanThuLao
			if (CanDeepSave(entity.SdhUteThanhToanThuLao, "SdhUteThanhToanThuLao|SdhUteThanhToanThuLao", deepSaveType, innerList))
			{

				if (entity.SdhUteThanhToanThuLao != null)
				{
					// update each child parent id with the real parent id (mostly used on insert)

					entity.SdhUteThanhToanThuLao.IdKhoiLuongQuyDoi = entity.Id;
					//DataRepository.SdhUteThanhToanThuLaoProvider.Save(transactionManager, entity.SdhUteThanhToanThuLao);
					deepHandles.Add("SdhUteThanhToanThuLao",
						new KeyValuePair<Delegate, object>((DeepSaveSingleHandle< SdhUteThanhToanThuLao >) DataRepository.SdhUteThanhToanThuLaoProvider.DeepSave,
						new object[] { transactionManager, entity.SdhUteThanhToanThuLao, deepSaveType, childTypes, innerList }
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
	
	#region SdhUteKhoiLuongQuyDoiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.SdhUteKhoiLuongQuyDoi</c>
	///</summary>
	public enum SdhUteKhoiLuongQuyDoiChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SdhUteKhoiLuongGiangDay</c> at IdKhoiLuongGiangDaySource
		///</summary>
		[ChildEntityType(typeof(SdhUteKhoiLuongGiangDay))]
		SdhUteKhoiLuongGiangDay,
		///<summary>
		/// Entity <c>SdhUteThanhToanThuLao</c> as OneToOne for SdhUteThanhToanThuLao
		///</summary>
		[ChildEntityType(typeof(SdhUteThanhToanThuLao))]
		SdhUteThanhToanThuLao,
	}
	
	#endregion SdhUteKhoiLuongQuyDoiChildEntityTypes
	
	#region SdhUteKhoiLuongQuyDoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SdhUteKhoiLuongQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhUteKhoiLuongQuyDoiFilterBuilder : SqlFilterBuilder<SdhUteKhoiLuongQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		public SdhUteKhoiLuongQuyDoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SdhUteKhoiLuongQuyDoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SdhUteKhoiLuongQuyDoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SdhUteKhoiLuongQuyDoiFilterBuilder
	
	#region SdhUteKhoiLuongQuyDoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SdhUteKhoiLuongQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhUteKhoiLuongQuyDoiParameterBuilder : ParameterizedSqlFilterBuilder<SdhUteKhoiLuongQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		public SdhUteKhoiLuongQuyDoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SdhUteKhoiLuongQuyDoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SdhUteKhoiLuongQuyDoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SdhUteKhoiLuongQuyDoiParameterBuilder
	
	#region SdhUteKhoiLuongQuyDoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SdhUteKhoiLuongQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteKhoiLuongQuyDoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SdhUteKhoiLuongQuyDoiSortBuilder : SqlSortBuilder<SdhUteKhoiLuongQuyDoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongQuyDoiSqlSortBuilder class.
		/// </summary>
		public SdhUteKhoiLuongQuyDoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SdhUteKhoiLuongQuyDoiSortBuilder
	
} // end namespace
