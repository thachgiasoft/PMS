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
	/// This class is the base class for any <see cref="ChiTienThuLaoGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ChiTienThuLaoGiangDayProviderBaseCore : EntityProviderBase<PMS.Entities.ChiTienThuLaoGiangDay, PMS.Entities.ChiTienThuLaoGiangDayKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ChiTienThuLaoGiangDayKey key)
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
		public override PMS.Entities.ChiTienThuLaoGiangDay Get(TransactionManager transactionManager, PMS.Entities.ChiTienThuLaoGiangDayKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ChiTienThuLaoGiangDay index.
		/// </summary>
		/// <param name="_oid"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;ChiTienThuLaoGiangDay&gt;"/> class.</returns>
		public TList<ChiTienThuLaoGiangDay> GetByOid(System.Guid? _oid)
		{
			int count = -1;
			return GetByOid(null,_oid, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ChiTienThuLaoGiangDay index.
		/// </summary>
		/// <param name="_oid"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;ChiTienThuLaoGiangDay&gt;"/> class.</returns>
		public TList<ChiTienThuLaoGiangDay> GetByOid(System.Guid? _oid, int start, int pageLength)
		{
			int count = -1;
			return GetByOid(null, _oid, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ChiTienThuLaoGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_oid"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;ChiTienThuLaoGiangDay&gt;"/> class.</returns>
		public TList<ChiTienThuLaoGiangDay> GetByOid(TransactionManager transactionManager, System.Guid? _oid)
		{
			int count = -1;
			return GetByOid(transactionManager, _oid, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ChiTienThuLaoGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_oid"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;ChiTienThuLaoGiangDay&gt;"/> class.</returns>
		public TList<ChiTienThuLaoGiangDay> GetByOid(TransactionManager transactionManager, System.Guid? _oid, int start, int pageLength)
		{
			int count = -1;
			return GetByOid(transactionManager, _oid, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ChiTienThuLaoGiangDay index.
		/// </summary>
		/// <param name="_oid"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;ChiTienThuLaoGiangDay&gt;"/> class.</returns>
		public TList<ChiTienThuLaoGiangDay> GetByOid(System.Guid? _oid, int start, int pageLength, out int count)
		{
			return GetByOid(null, _oid, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ChiTienThuLaoGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_oid"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;ChiTienThuLaoGiangDay&gt;"/> class.</returns>
		public abstract TList<ChiTienThuLaoGiangDay> GetByOid(TransactionManager transactionManager, System.Guid? _oid, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ChiTienThuLaoGiangDay index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChiTienThuLaoGiangDay"/> class.</returns>
		public PMS.Entities.ChiTienThuLaoGiangDay GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChiTienThuLaoGiangDay index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChiTienThuLaoGiangDay"/> class.</returns>
		public PMS.Entities.ChiTienThuLaoGiangDay GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChiTienThuLaoGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChiTienThuLaoGiangDay"/> class.</returns>
		public PMS.Entities.ChiTienThuLaoGiangDay GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChiTienThuLaoGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChiTienThuLaoGiangDay"/> class.</returns>
		public PMS.Entities.ChiTienThuLaoGiangDay GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChiTienThuLaoGiangDay index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChiTienThuLaoGiangDay"/> class.</returns>
		public PMS.Entities.ChiTienThuLaoGiangDay GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChiTienThuLaoGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChiTienThuLaoGiangDay"/> class.</returns>
		public abstract PMS.Entities.ChiTienThuLaoGiangDay GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ChiTienThuLaoGiangDay_KiemTraChiTien 
		
		/// <summary>
		///	This method wrap the 'cust_ChiTienThuLaoGiangDay_KiemTraChiTien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChiTien(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraChiTien(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChiTienThuLaoGiangDay_KiemTraChiTien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChiTien(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraChiTien(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChiTienThuLaoGiangDay_KiemTraChiTien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChiTien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraChiTien(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChiTienThuLaoGiangDay_KiemTraChiTien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraChiTien(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ChiTienThuLaoGiangDay_ChiTienHrm 
		
		/// <summary>
		///	This method wrap the 'cust_ChiTienThuLaoGiangDay_ChiTienHrm' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChiTienHrm(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 ChiTienHrm(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChiTienThuLaoGiangDay_ChiTienHrm' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChiTienHrm(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 ChiTienHrm(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChiTienThuLaoGiangDay_ChiTienHrm' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChiTienHrm(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 ChiTienHrm(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChiTienThuLaoGiangDay_ChiTienHrm' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ChiTienHrm(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ChiTienThuLaoGiangDay_LayThongTinChiTien 
		
		/// <summary>
		///	This method wrap the 'cust_ChiTienThuLaoGiangDay_LayThongTinChiTien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LayThongTinChiTien(System.String namHoc, System.String hocKy)
		{
			return LayThongTinChiTien(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChiTienThuLaoGiangDay_LayThongTinChiTien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LayThongTinChiTien(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return LayThongTinChiTien(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChiTienThuLaoGiangDay_LayThongTinChiTien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LayThongTinChiTien(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return LayThongTinChiTien(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChiTienThuLaoGiangDay_LayThongTinChiTien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader LayThongTinChiTien(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ChiTienThuLaoGiangDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ChiTienThuLaoGiangDay&gt;"/></returns>
		public static TList<ChiTienThuLaoGiangDay> Fill(IDataReader reader, TList<ChiTienThuLaoGiangDay> rows, int start, int pageLength)
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
				
				PMS.Entities.ChiTienThuLaoGiangDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ChiTienThuLaoGiangDay")
					.Append("|").Append((System.Int32)reader[((int)ChiTienThuLaoGiangDayColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ChiTienThuLaoGiangDay>(
					key.ToString(), // EntityTrackingKey
					"ChiTienThuLaoGiangDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ChiTienThuLaoGiangDay();
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
					c.Id = (System.Int32)reader[(ChiTienThuLaoGiangDayColumn.Id.ToString())];
					c.NamHoc = (reader[ChiTienThuLaoGiangDayColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.NamHoc.ToString())];
					c.HocKy = (reader[ChiTienThuLaoGiangDayColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.HocKy.ToString())];
					c.MaCanBoGiangDay = (reader[ChiTienThuLaoGiangDayColumn.MaCanBoGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.MaCanBoGiangDay.ToString())];
					c.Oid = (reader[ChiTienThuLaoGiangDayColumn.Oid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(ChiTienThuLaoGiangDayColumn.Oid.ToString())];
					c.LaGiangVienThinhGiang = (reader[ChiTienThuLaoGiangDayColumn.LaGiangVienThinhGiang.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChiTienThuLaoGiangDayColumn.LaGiangVienThinhGiang.ToString())];
					c.TongTien = (reader[ChiTienThuLaoGiangDayColumn.TongTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChiTienThuLaoGiangDayColumn.TongTien.ToString())];
					c.SoChungTuHrm = (reader[ChiTienThuLaoGiangDayColumn.SoChungTuHrm.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.SoChungTuHrm.ToString())];
					c.NgayCapNhat = (reader[ChiTienThuLaoGiangDayColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ChiTienThuLaoGiangDayColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.NguoiCapNhat.ToString())];
					c.NgayLayDuLieu = (reader[ChiTienThuLaoGiangDayColumn.NgayLayDuLieu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.NgayLayDuLieu.ToString())];
					c.MaMonHoc = (reader[ChiTienThuLaoGiangDayColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.MaMonHoc.ToString())];
					c.TongSoTietQuyDoi = (reader[ChiTienThuLaoGiangDayColumn.TongSoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChiTienThuLaoGiangDayColumn.TongSoTietQuyDoi.ToString())];
					c.MaLopHocPhan = (reader[ChiTienThuLaoGiangDayColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.MaLopHocPhan.ToString())];
					c.MaLopSinhVien = (reader[ChiTienThuLaoGiangDayColumn.MaLopSinhVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.MaLopSinhVien.ToString())];
					c.LopClc = (reader[ChiTienThuLaoGiangDayColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChiTienThuLaoGiangDayColumn.LopClc.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChiTienThuLaoGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChiTienThuLaoGiangDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ChiTienThuLaoGiangDay entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ChiTienThuLaoGiangDayColumn.Id.ToString())];
			entity.NamHoc = (reader[ChiTienThuLaoGiangDayColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ChiTienThuLaoGiangDayColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.HocKy.ToString())];
			entity.MaCanBoGiangDay = (reader[ChiTienThuLaoGiangDayColumn.MaCanBoGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.MaCanBoGiangDay.ToString())];
			entity.Oid = (reader[ChiTienThuLaoGiangDayColumn.Oid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(ChiTienThuLaoGiangDayColumn.Oid.ToString())];
			entity.LaGiangVienThinhGiang = (reader[ChiTienThuLaoGiangDayColumn.LaGiangVienThinhGiang.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChiTienThuLaoGiangDayColumn.LaGiangVienThinhGiang.ToString())];
			entity.TongTien = (reader[ChiTienThuLaoGiangDayColumn.TongTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChiTienThuLaoGiangDayColumn.TongTien.ToString())];
			entity.SoChungTuHrm = (reader[ChiTienThuLaoGiangDayColumn.SoChungTuHrm.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.SoChungTuHrm.ToString())];
			entity.NgayCapNhat = (reader[ChiTienThuLaoGiangDayColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ChiTienThuLaoGiangDayColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.NguoiCapNhat.ToString())];
			entity.NgayLayDuLieu = (reader[ChiTienThuLaoGiangDayColumn.NgayLayDuLieu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.NgayLayDuLieu.ToString())];
			entity.MaMonHoc = (reader[ChiTienThuLaoGiangDayColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.MaMonHoc.ToString())];
			entity.TongSoTietQuyDoi = (reader[ChiTienThuLaoGiangDayColumn.TongSoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChiTienThuLaoGiangDayColumn.TongSoTietQuyDoi.ToString())];
			entity.MaLopHocPhan = (reader[ChiTienThuLaoGiangDayColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.MaLopHocPhan.ToString())];
			entity.MaLopSinhVien = (reader[ChiTienThuLaoGiangDayColumn.MaLopSinhVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTienThuLaoGiangDayColumn.MaLopSinhVien.ToString())];
			entity.LopClc = (reader[ChiTienThuLaoGiangDayColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChiTienThuLaoGiangDayColumn.LopClc.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChiTienThuLaoGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChiTienThuLaoGiangDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ChiTienThuLaoGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaCanBoGiangDay = Convert.IsDBNull(dataRow["MaCanBoGiangDay"]) ? null : (System.String)dataRow["MaCanBoGiangDay"];
			entity.Oid = Convert.IsDBNull(dataRow["Oid"]) ? null : (System.Guid?)dataRow["Oid"];
			entity.LaGiangVienThinhGiang = Convert.IsDBNull(dataRow["LaGiangVienThinhGiang"]) ? null : (System.Boolean?)dataRow["LaGiangVienThinhGiang"];
			entity.TongTien = Convert.IsDBNull(dataRow["TongTien"]) ? null : (System.Decimal?)dataRow["TongTien"];
			entity.SoChungTuHrm = Convert.IsDBNull(dataRow["SoChungTuHrm"]) ? null : (System.String)dataRow["SoChungTuHrm"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.NgayLayDuLieu = Convert.IsDBNull(dataRow["NgayLayDuLieu"]) ? null : (System.String)dataRow["NgayLayDuLieu"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TongSoTietQuyDoi = Convert.IsDBNull(dataRow["TongSoTietQuyDoi"]) ? null : (System.Decimal?)dataRow["TongSoTietQuyDoi"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaLopSinhVien = Convert.IsDBNull(dataRow["MaLopSinhVien"]) ? null : (System.String)dataRow["MaLopSinhVien"];
			entity.LopClc = Convert.IsDBNull(dataRow["LopClc"]) ? null : (System.Boolean?)dataRow["LopClc"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ChiTienThuLaoGiangDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ChiTienThuLaoGiangDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ChiTienThuLaoGiangDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ChiTienThuLaoGiangDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ChiTienThuLaoGiangDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ChiTienThuLaoGiangDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ChiTienThuLaoGiangDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ChiTienThuLaoGiangDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ChiTienThuLaoGiangDay</c>
	///</summary>
	public enum ChiTienThuLaoGiangDayChildEntityTypes
	{
	}
	
	#endregion ChiTienThuLaoGiangDayChildEntityTypes
	
	#region ChiTienThuLaoGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ChiTienThuLaoGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChiTienThuLaoGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChiTienThuLaoGiangDayFilterBuilder : SqlFilterBuilder<ChiTienThuLaoGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChiTienThuLaoGiangDayFilterBuilder class.
		/// </summary>
		public ChiTienThuLaoGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChiTienThuLaoGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChiTienThuLaoGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChiTienThuLaoGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChiTienThuLaoGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChiTienThuLaoGiangDayFilterBuilder
	
	#region ChiTienThuLaoGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ChiTienThuLaoGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChiTienThuLaoGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChiTienThuLaoGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ChiTienThuLaoGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChiTienThuLaoGiangDayParameterBuilder class.
		/// </summary>
		public ChiTienThuLaoGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChiTienThuLaoGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChiTienThuLaoGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChiTienThuLaoGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChiTienThuLaoGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChiTienThuLaoGiangDayParameterBuilder
	
	#region ChiTienThuLaoGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ChiTienThuLaoGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChiTienThuLaoGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ChiTienThuLaoGiangDaySortBuilder : SqlSortBuilder<ChiTienThuLaoGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChiTienThuLaoGiangDaySqlSortBuilder class.
		/// </summary>
		public ChiTienThuLaoGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ChiTienThuLaoGiangDaySortBuilder
	
} // end namespace
