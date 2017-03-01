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
	/// This class is the base class for any <see cref="UteKhoiLuongQuyDoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class UteKhoiLuongQuyDoiProviderBaseCore : EntityProviderBase<PMS.Entities.UteKhoiLuongQuyDoi, PMS.Entities.UteKhoiLuongQuyDoiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.UteKhoiLuongQuyDoiKey key)
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
		/// 	Gets rows from the datasource based on the FK_Ute_KhoiLuongQuyDoi_Ute_KhoiLuongGiangDay key.
		///		FK_Ute_KhoiLuongQuyDoi_Ute_KhoiLuongGiangDay Description: 
		/// </summary>
		/// <param name="_idKhoiLuongGiangDay"></param>
		/// <returns>Returns a typed collection of PMS.Entities.UteKhoiLuongQuyDoi objects.</returns>
		public TList<UteKhoiLuongQuyDoi> GetByIdKhoiLuongGiangDay(System.Int32 _idKhoiLuongGiangDay)
		{
			int count = -1;
			return GetByIdKhoiLuongGiangDay(_idKhoiLuongGiangDay, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ute_KhoiLuongQuyDoi_Ute_KhoiLuongGiangDay key.
		///		FK_Ute_KhoiLuongQuyDoi_Ute_KhoiLuongGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idKhoiLuongGiangDay"></param>
		/// <returns>Returns a typed collection of PMS.Entities.UteKhoiLuongQuyDoi objects.</returns>
		/// <remarks></remarks>
		public TList<UteKhoiLuongQuyDoi> GetByIdKhoiLuongGiangDay(TransactionManager transactionManager, System.Int32 _idKhoiLuongGiangDay)
		{
			int count = -1;
			return GetByIdKhoiLuongGiangDay(transactionManager, _idKhoiLuongGiangDay, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ute_KhoiLuongQuyDoi_Ute_KhoiLuongGiangDay key.
		///		FK_Ute_KhoiLuongQuyDoi_Ute_KhoiLuongGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idKhoiLuongGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.UteKhoiLuongQuyDoi objects.</returns>
		public TList<UteKhoiLuongQuyDoi> GetByIdKhoiLuongGiangDay(TransactionManager transactionManager, System.Int32 _idKhoiLuongGiangDay, int start, int pageLength)
		{
			int count = -1;
			return GetByIdKhoiLuongGiangDay(transactionManager, _idKhoiLuongGiangDay, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ute_KhoiLuongQuyDoi_Ute_KhoiLuongGiangDay key.
		///		fkUteKhoiLuongQuyDoiUteKhoiLuongGiangDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_idKhoiLuongGiangDay"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.UteKhoiLuongQuyDoi objects.</returns>
		public TList<UteKhoiLuongQuyDoi> GetByIdKhoiLuongGiangDay(System.Int32 _idKhoiLuongGiangDay, int start, int pageLength)
		{
			int count =  -1;
			return GetByIdKhoiLuongGiangDay(null, _idKhoiLuongGiangDay, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ute_KhoiLuongQuyDoi_Ute_KhoiLuongGiangDay key.
		///		fkUteKhoiLuongQuyDoiUteKhoiLuongGiangDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_idKhoiLuongGiangDay"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.UteKhoiLuongQuyDoi objects.</returns>
		public TList<UteKhoiLuongQuyDoi> GetByIdKhoiLuongGiangDay(System.Int32 _idKhoiLuongGiangDay, int start, int pageLength,out int count)
		{
			return GetByIdKhoiLuongGiangDay(null, _idKhoiLuongGiangDay, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Ute_KhoiLuongQuyDoi_Ute_KhoiLuongGiangDay key.
		///		FK_Ute_KhoiLuongQuyDoi_Ute_KhoiLuongGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idKhoiLuongGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.UteKhoiLuongQuyDoi objects.</returns>
		public abstract TList<UteKhoiLuongQuyDoi> GetByIdKhoiLuongGiangDay(TransactionManager transactionManager, System.Int32 _idKhoiLuongGiangDay, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.UteKhoiLuongQuyDoi Get(TransactionManager transactionManager, PMS.Entities.UteKhoiLuongQuyDoiKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_Ute_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.UteKhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.UteKhoiLuongQuyDoi GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ute_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.UteKhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.UteKhoiLuongQuyDoi GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ute_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.UteKhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.UteKhoiLuongQuyDoi GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ute_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.UteKhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.UteKhoiLuongQuyDoi GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ute_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.UteKhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.UteKhoiLuongQuyDoi GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ute_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.UteKhoiLuongQuyDoi"/> class.</returns>
		public abstract PMS.Entities.UteKhoiLuongQuyDoi GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_Ute_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKyQuyCheMoi 
		
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKyQuyCheMoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoNamHocHocKyQuyCheMoi(System.String namHoc, System.String hocKy)
		{
			 QuyDoiTheoNamHocHocKyQuyCheMoi(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKyQuyCheMoi' stored procedure. 
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
		///	This method wrap the 'cust_Ute_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKyQuyCheMoi' stored procedure. 
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
		///	This method wrap the 'cust_Ute_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKyQuyCheMoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void QuyDoiTheoNamHocHocKyQuyCheMoi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_Ute_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			 QuyDoiTheoNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_Ute_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_Ute_KhoiLuongQuyDoi_QuyDoiTheoNamHocHocKy' stored procedure. 
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
		/// Fill a TList&lt;UteKhoiLuongQuyDoi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;UteKhoiLuongQuyDoi&gt;"/></returns>
		public static TList<UteKhoiLuongQuyDoi> Fill(IDataReader reader, TList<UteKhoiLuongQuyDoi> rows, int start, int pageLength)
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
				
				PMS.Entities.UteKhoiLuongQuyDoi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("UteKhoiLuongQuyDoi")
					.Append("|").Append((System.Int32)reader[((int)UteKhoiLuongQuyDoiColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<UteKhoiLuongQuyDoi>(
					key.ToString(), // EntityTrackingKey
					"UteKhoiLuongQuyDoi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.UteKhoiLuongQuyDoi();
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
					c.Id = (System.Int32)reader[(UteKhoiLuongQuyDoiColumn.Id.ToString())];
					c.IdKhoiLuongGiangDay = (System.Int32)reader[(UteKhoiLuongQuyDoiColumn.IdKhoiLuongGiangDay.ToString())];
					c.HeSoLopDongLyThuyet = (reader[UteKhoiLuongQuyDoiColumn.HeSoLopDongLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(UteKhoiLuongQuyDoiColumn.HeSoLopDongLyThuyet.ToString())];
					c.HeSoLopDongThTnTt = (reader[UteKhoiLuongQuyDoiColumn.HeSoLopDongThTnTt.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(UteKhoiLuongQuyDoiColumn.HeSoLopDongThTnTt.ToString())];
					c.TietQuyDoi = (reader[UteKhoiLuongQuyDoiColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(UteKhoiLuongQuyDoiColumn.TietQuyDoi.ToString())];
					c.NgayCapNhat = (reader[UteKhoiLuongQuyDoiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(UteKhoiLuongQuyDoiColumn.NgayCapNhat.ToString())];
					c.SoGioThucGiangTrenLop = (reader[UteKhoiLuongQuyDoiColumn.SoGioThucGiangTrenLop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(UteKhoiLuongQuyDoiColumn.SoGioThucGiangTrenLop.ToString())];
					c.SoGioChuanTinhThem = (reader[UteKhoiLuongQuyDoiColumn.SoGioChuanTinhThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(UteKhoiLuongQuyDoiColumn.SoGioChuanTinhThem.ToString())];
					c.HeSoHocKy = (reader[UteKhoiLuongQuyDoiColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(UteKhoiLuongQuyDoiColumn.HeSoHocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.UteKhoiLuongQuyDoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.UteKhoiLuongQuyDoi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.UteKhoiLuongQuyDoi entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(UteKhoiLuongQuyDoiColumn.Id.ToString())];
			entity.IdKhoiLuongGiangDay = (System.Int32)reader[(UteKhoiLuongQuyDoiColumn.IdKhoiLuongGiangDay.ToString())];
			entity.HeSoLopDongLyThuyet = (reader[UteKhoiLuongQuyDoiColumn.HeSoLopDongLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(UteKhoiLuongQuyDoiColumn.HeSoLopDongLyThuyet.ToString())];
			entity.HeSoLopDongThTnTt = (reader[UteKhoiLuongQuyDoiColumn.HeSoLopDongThTnTt.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(UteKhoiLuongQuyDoiColumn.HeSoLopDongThTnTt.ToString())];
			entity.TietQuyDoi = (reader[UteKhoiLuongQuyDoiColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(UteKhoiLuongQuyDoiColumn.TietQuyDoi.ToString())];
			entity.NgayCapNhat = (reader[UteKhoiLuongQuyDoiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(UteKhoiLuongQuyDoiColumn.NgayCapNhat.ToString())];
			entity.SoGioThucGiangTrenLop = (reader[UteKhoiLuongQuyDoiColumn.SoGioThucGiangTrenLop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(UteKhoiLuongQuyDoiColumn.SoGioThucGiangTrenLop.ToString())];
			entity.SoGioChuanTinhThem = (reader[UteKhoiLuongQuyDoiColumn.SoGioChuanTinhThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(UteKhoiLuongQuyDoiColumn.SoGioChuanTinhThem.ToString())];
			entity.HeSoHocKy = (reader[UteKhoiLuongQuyDoiColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(UteKhoiLuongQuyDoiColumn.HeSoHocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.UteKhoiLuongQuyDoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.UteKhoiLuongQuyDoi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.UteKhoiLuongQuyDoi entity)
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
		/// <param name="entity">The <see cref="PMS.Entities.UteKhoiLuongQuyDoi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.UteKhoiLuongQuyDoi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.UteKhoiLuongQuyDoi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region IdKhoiLuongGiangDaySource	
			if (CanDeepLoad(entity, "UteKhoiLuongGiangDay|IdKhoiLuongGiangDaySource", deepLoadType, innerList) 
				&& entity.IdKhoiLuongGiangDaySource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.IdKhoiLuongGiangDay;
				UteKhoiLuongGiangDay tmpEntity = EntityManager.LocateEntity<UteKhoiLuongGiangDay>(EntityLocator.ConstructKeyFromPkItems(typeof(UteKhoiLuongGiangDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.IdKhoiLuongGiangDaySource = tmpEntity;
				else
					entity.IdKhoiLuongGiangDaySource = DataRepository.UteKhoiLuongGiangDayProvider.GetById(transactionManager, entity.IdKhoiLuongGiangDay);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'IdKhoiLuongGiangDaySource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.IdKhoiLuongGiangDaySource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.UteKhoiLuongGiangDayProvider.DeepLoad(transactionManager, entity.IdKhoiLuongGiangDaySource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion IdKhoiLuongGiangDaySource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetById methods when available
			
			#region UteThanhToanThuLao
			// RelationshipType.OneToOne
			if (CanDeepLoad(entity, "UteThanhToanThuLao|UteThanhToanThuLao", deepLoadType, innerList))
			{
				entity.UteThanhToanThuLao = DataRepository.UteThanhToanThuLaoProvider.GetByIdKhoiLuongQuyDoi(transactionManager, entity.Id);
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'UteThanhToanThuLao' loaded. key " + entity.EntityTrackingKey);
				#endif 

				if (deep && entity.UteThanhToanThuLao != null)
				{
					deepHandles.Add("UteThanhToanThuLao",
						new KeyValuePair<Delegate, object>((DeepLoadSingleHandle< UteThanhToanThuLao >) DataRepository.UteThanhToanThuLaoProvider.DeepLoad,
						new object[] { transactionManager, entity.UteThanhToanThuLao, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.UteKhoiLuongQuyDoi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.UteKhoiLuongQuyDoi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.UteKhoiLuongQuyDoi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.UteKhoiLuongQuyDoi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region IdKhoiLuongGiangDaySource
			if (CanDeepSave(entity, "UteKhoiLuongGiangDay|IdKhoiLuongGiangDaySource", deepSaveType, innerList) 
				&& entity.IdKhoiLuongGiangDaySource != null)
			{
				DataRepository.UteKhoiLuongGiangDayProvider.Save(transactionManager, entity.IdKhoiLuongGiangDaySource);
				entity.IdKhoiLuongGiangDay = entity.IdKhoiLuongGiangDaySource.Id;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();

			#region UteThanhToanThuLao
			if (CanDeepSave(entity.UteThanhToanThuLao, "UteThanhToanThuLao|UteThanhToanThuLao", deepSaveType, innerList))
			{

				if (entity.UteThanhToanThuLao != null)
				{
					// update each child parent id with the real parent id (mostly used on insert)

					entity.UteThanhToanThuLao.IdKhoiLuongQuyDoi = entity.Id;
					//DataRepository.UteThanhToanThuLaoProvider.Save(transactionManager, entity.UteThanhToanThuLao);
					deepHandles.Add("UteThanhToanThuLao",
						new KeyValuePair<Delegate, object>((DeepSaveSingleHandle< UteThanhToanThuLao >) DataRepository.UteThanhToanThuLaoProvider.DeepSave,
						new object[] { transactionManager, entity.UteThanhToanThuLao, deepSaveType, childTypes, innerList }
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
	
	#region UteKhoiLuongQuyDoiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.UteKhoiLuongQuyDoi</c>
	///</summary>
	public enum UteKhoiLuongQuyDoiChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>UteKhoiLuongGiangDay</c> at IdKhoiLuongGiangDaySource
		///</summary>
		[ChildEntityType(typeof(UteKhoiLuongGiangDay))]
		UteKhoiLuongGiangDay,
		///<summary>
		/// Entity <c>UteThanhToanThuLao</c> as OneToOne for UteThanhToanThuLao
		///</summary>
		[ChildEntityType(typeof(UteThanhToanThuLao))]
		UteThanhToanThuLao,
	}
	
	#endregion UteKhoiLuongQuyDoiChildEntityTypes
	
	#region UteKhoiLuongQuyDoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;UteKhoiLuongQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UteKhoiLuongQuyDoiFilterBuilder : SqlFilterBuilder<UteKhoiLuongQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		public UteKhoiLuongQuyDoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UteKhoiLuongQuyDoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UteKhoiLuongQuyDoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UteKhoiLuongQuyDoiFilterBuilder
	
	#region UteKhoiLuongQuyDoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;UteKhoiLuongQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UteKhoiLuongQuyDoiParameterBuilder : ParameterizedSqlFilterBuilder<UteKhoiLuongQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		public UteKhoiLuongQuyDoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UteKhoiLuongQuyDoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UteKhoiLuongQuyDoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UteKhoiLuongQuyDoiParameterBuilder
	
	#region UteKhoiLuongQuyDoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;UteKhoiLuongQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UteKhoiLuongQuyDoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class UteKhoiLuongQuyDoiSortBuilder : SqlSortBuilder<UteKhoiLuongQuyDoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongQuyDoiSqlSortBuilder class.
		/// </summary>
		public UteKhoiLuongQuyDoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion UteKhoiLuongQuyDoiSortBuilder
	
} // end namespace
