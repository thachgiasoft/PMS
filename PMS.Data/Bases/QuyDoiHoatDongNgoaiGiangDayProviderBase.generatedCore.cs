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
	/// This class is the base class for any <see cref="QuyDoiHoatDongNgoaiGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class QuyDoiHoatDongNgoaiGiangDayProviderBaseCore : EntityProviderBase<PMS.Entities.QuyDoiHoatDongNgoaiGiangDay, PMS.Entities.QuyDoiHoatDongNgoaiGiangDayKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.QuyDoiHoatDongNgoaiGiangDayKey key)
		{
			return Delete(transactionManager, key.MaQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maQuanLy)
		{
			return Delete(null, _maQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maQuanLy);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiHoatDongNgoaiGiangDay_GiangVien_HoatDongNgoaiGiangDay key.
		///		FK_QuyDoiHoatDongNgoaiGiangDay_GiangVien_HoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="_maHoatDongNgoaiGiangDay"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiHoatDongNgoaiGiangDay objects.</returns>
		public TList<QuyDoiHoatDongNgoaiGiangDay> GetByMaHoatDongNgoaiGiangDay(System.Int32? _maHoatDongNgoaiGiangDay)
		{
			int count = -1;
			return GetByMaHoatDongNgoaiGiangDay(_maHoatDongNgoaiGiangDay, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiHoatDongNgoaiGiangDay_GiangVien_HoatDongNgoaiGiangDay key.
		///		FK_QuyDoiHoatDongNgoaiGiangDay_GiangVien_HoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoatDongNgoaiGiangDay"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiHoatDongNgoaiGiangDay objects.</returns>
		/// <remarks></remarks>
		public TList<QuyDoiHoatDongNgoaiGiangDay> GetByMaHoatDongNgoaiGiangDay(TransactionManager transactionManager, System.Int32? _maHoatDongNgoaiGiangDay)
		{
			int count = -1;
			return GetByMaHoatDongNgoaiGiangDay(transactionManager, _maHoatDongNgoaiGiangDay, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiHoatDongNgoaiGiangDay_GiangVien_HoatDongNgoaiGiangDay key.
		///		FK_QuyDoiHoatDongNgoaiGiangDay_GiangVien_HoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoatDongNgoaiGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiHoatDongNgoaiGiangDay objects.</returns>
		public TList<QuyDoiHoatDongNgoaiGiangDay> GetByMaHoatDongNgoaiGiangDay(TransactionManager transactionManager, System.Int32? _maHoatDongNgoaiGiangDay, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHoatDongNgoaiGiangDay(transactionManager, _maHoatDongNgoaiGiangDay, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiHoatDongNgoaiGiangDay_GiangVien_HoatDongNgoaiGiangDay key.
		///		fkQuyDoiHoatDongNgoaiGiangDayGiangVienHoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHoatDongNgoaiGiangDay"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiHoatDongNgoaiGiangDay objects.</returns>
		public TList<QuyDoiHoatDongNgoaiGiangDay> GetByMaHoatDongNgoaiGiangDay(System.Int32? _maHoatDongNgoaiGiangDay, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHoatDongNgoaiGiangDay(null, _maHoatDongNgoaiGiangDay, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiHoatDongNgoaiGiangDay_GiangVien_HoatDongNgoaiGiangDay key.
		///		fkQuyDoiHoatDongNgoaiGiangDayGiangVienHoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHoatDongNgoaiGiangDay"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiHoatDongNgoaiGiangDay objects.</returns>
		public TList<QuyDoiHoatDongNgoaiGiangDay> GetByMaHoatDongNgoaiGiangDay(System.Int32? _maHoatDongNgoaiGiangDay, int start, int pageLength,out int count)
		{
			return GetByMaHoatDongNgoaiGiangDay(null, _maHoatDongNgoaiGiangDay, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiHoatDongNgoaiGiangDay_GiangVien_HoatDongNgoaiGiangDay key.
		///		FK_QuyDoiHoatDongNgoaiGiangDay_GiangVien_HoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoatDongNgoaiGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiHoatDongNgoaiGiangDay objects.</returns>
		public abstract TList<QuyDoiHoatDongNgoaiGiangDay> GetByMaHoatDongNgoaiGiangDay(TransactionManager transactionManager, System.Int32? _maHoatDongNgoaiGiangDay, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.QuyDoiHoatDongNgoaiGiangDay Get(TransactionManager transactionManager, PMS.Entities.QuyDoiHoatDongNgoaiGiangDayKey key, int start, int pageLength)
		{
			return GetByMaQuanLy(transactionManager, key.MaQuanLy, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_QuyDoiHoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.QuyDoiHoatDongNgoaiGiangDay GetByMaQuanLy(System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiHoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.QuyDoiHoatDongNgoaiGiangDay GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiHoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.QuyDoiHoatDongNgoaiGiangDay GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiHoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.QuyDoiHoatDongNgoaiGiangDay GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiHoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.QuyDoiHoatDongNgoaiGiangDay GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiHoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiHoatDongNgoaiGiangDay"/> class.</returns>
		public abstract PMS.Entities.QuyDoiHoatDongNgoaiGiangDay GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_QuyDoiHoatDongNgoaiGiangDay_QuyDoiTheoNamHocHocKyMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiHoatDongNgoaiGiangDay_QuyDoiTheoNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoNamHocHocKyMaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 QuyDoiTheoNamHocHocKyMaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiHoatDongNgoaiGiangDay_QuyDoiTheoNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoNamHocHocKyMaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 QuyDoiTheoNamHocHocKyMaDonVi(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_QuyDoiHoatDongNgoaiGiangDay_QuyDoiTheoNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoNamHocHocKyMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 QuyDoiTheoNamHocHocKyMaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiHoatDongNgoaiGiangDay_QuyDoiTheoNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void QuyDoiTheoNamHocHocKyMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion
		
		#region cust_QuyDoiHoatDongNgoaiGiangDay_QuyDoiTheoNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiHoatDongNgoaiGiangDay_QuyDoiTheoNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			 QuyDoiTheoNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiHoatDongNgoaiGiangDay_QuyDoiTheoNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_QuyDoiHoatDongNgoaiGiangDay_QuyDoiTheoNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_QuyDoiHoatDongNgoaiGiangDay_QuyDoiTheoNamHocHocKy' stored procedure. 
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
		/// Fill a TList&lt;QuyDoiHoatDongNgoaiGiangDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;QuyDoiHoatDongNgoaiGiangDay&gt;"/></returns>
		public static TList<QuyDoiHoatDongNgoaiGiangDay> Fill(IDataReader reader, TList<QuyDoiHoatDongNgoaiGiangDay> rows, int start, int pageLength)
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
				
				PMS.Entities.QuyDoiHoatDongNgoaiGiangDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("QuyDoiHoatDongNgoaiGiangDay")
					.Append("|").Append((System.Int32)reader[((int)QuyDoiHoatDongNgoaiGiangDayColumn.MaQuanLy - 1)]).ToString();
					c = EntityManager.LocateOrCreate<QuyDoiHoatDongNgoaiGiangDay>(
					key.ToString(), // EntityTrackingKey
					"QuyDoiHoatDongNgoaiGiangDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.QuyDoiHoatDongNgoaiGiangDay();
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
					c.MaQuanLy = (System.Int32)reader[(QuyDoiHoatDongNgoaiGiangDayColumn.MaQuanLy.ToString())];
					c.MaHoatDongNgoaiGiangDay = (reader[QuyDoiHoatDongNgoaiGiangDayColumn.MaHoatDongNgoaiGiangDay.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDoiHoatDongNgoaiGiangDayColumn.MaHoatDongNgoaiGiangDay.ToString())];
					c.SoTietQuyDoi = (reader[QuyDoiHoatDongNgoaiGiangDayColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiHoatDongNgoaiGiangDayColumn.SoTietQuyDoi.ToString())];
					c.SoTien = (reader[QuyDoiHoatDongNgoaiGiangDayColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiHoatDongNgoaiGiangDayColumn.SoTien.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.QuyDoiHoatDongNgoaiGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.QuyDoiHoatDongNgoaiGiangDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.QuyDoiHoatDongNgoaiGiangDay entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuanLy = (System.Int32)reader[(QuyDoiHoatDongNgoaiGiangDayColumn.MaQuanLy.ToString())];
			entity.MaHoatDongNgoaiGiangDay = (reader[QuyDoiHoatDongNgoaiGiangDayColumn.MaHoatDongNgoaiGiangDay.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDoiHoatDongNgoaiGiangDayColumn.MaHoatDongNgoaiGiangDay.ToString())];
			entity.SoTietQuyDoi = (reader[QuyDoiHoatDongNgoaiGiangDayColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiHoatDongNgoaiGiangDayColumn.SoTietQuyDoi.ToString())];
			entity.SoTien = (reader[QuyDoiHoatDongNgoaiGiangDayColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiHoatDongNgoaiGiangDayColumn.SoTien.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.QuyDoiHoatDongNgoaiGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.QuyDoiHoatDongNgoaiGiangDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.QuyDoiHoatDongNgoaiGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (System.Int32)dataRow["MaQuanLy"];
			entity.MaHoatDongNgoaiGiangDay = Convert.IsDBNull(dataRow["MaHoatDongNgoaiGiangDay"]) ? null : (System.Int32?)dataRow["MaHoatDongNgoaiGiangDay"];
			entity.SoTietQuyDoi = Convert.IsDBNull(dataRow["SoTietQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietQuyDoi"];
			entity.SoTien = Convert.IsDBNull(dataRow["SoTien"]) ? null : (System.Decimal?)dataRow["SoTien"];
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
		/// <param name="entity">The <see cref="PMS.Entities.QuyDoiHoatDongNgoaiGiangDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.QuyDoiHoatDongNgoaiGiangDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.QuyDoiHoatDongNgoaiGiangDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaHoatDongNgoaiGiangDaySource	
			if (CanDeepLoad(entity, "GiangVienHoatDongNgoaiGiangDay|MaHoatDongNgoaiGiangDaySource", deepLoadType, innerList) 
				&& entity.MaHoatDongNgoaiGiangDaySource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaHoatDongNgoaiGiangDay ?? (int)0);
				GiangVienHoatDongNgoaiGiangDay tmpEntity = EntityManager.LocateEntity<GiangVienHoatDongNgoaiGiangDay>(EntityLocator.ConstructKeyFromPkItems(typeof(GiangVienHoatDongNgoaiGiangDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaHoatDongNgoaiGiangDaySource = tmpEntity;
				else
					entity.MaHoatDongNgoaiGiangDaySource = DataRepository.GiangVienHoatDongNgoaiGiangDayProvider.GetByMaQuanLy(transactionManager, (entity.MaHoatDongNgoaiGiangDay ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaHoatDongNgoaiGiangDaySource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaHoatDongNgoaiGiangDaySource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GiangVienHoatDongNgoaiGiangDayProvider.DeepLoad(transactionManager, entity.MaHoatDongNgoaiGiangDaySource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaHoatDongNgoaiGiangDaySource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.QuyDoiHoatDongNgoaiGiangDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.QuyDoiHoatDongNgoaiGiangDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.QuyDoiHoatDongNgoaiGiangDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.QuyDoiHoatDongNgoaiGiangDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaHoatDongNgoaiGiangDaySource
			if (CanDeepSave(entity, "GiangVienHoatDongNgoaiGiangDay|MaHoatDongNgoaiGiangDaySource", deepSaveType, innerList) 
				&& entity.MaHoatDongNgoaiGiangDaySource != null)
			{
				DataRepository.GiangVienHoatDongNgoaiGiangDayProvider.Save(transactionManager, entity.MaHoatDongNgoaiGiangDaySource);
				entity.MaHoatDongNgoaiGiangDay = entity.MaHoatDongNgoaiGiangDaySource.MaQuanLy;
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
	
	#region QuyDoiHoatDongNgoaiGiangDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.QuyDoiHoatDongNgoaiGiangDay</c>
	///</summary>
	public enum QuyDoiHoatDongNgoaiGiangDayChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiangVienHoatDongNgoaiGiangDay</c> at MaHoatDongNgoaiGiangDaySource
		///</summary>
		[ChildEntityType(typeof(GiangVienHoatDongNgoaiGiangDay))]
		GiangVienHoatDongNgoaiGiangDay,
	}
	
	#endregion QuyDoiHoatDongNgoaiGiangDayChildEntityTypes
	
	#region QuyDoiHoatDongNgoaiGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;QuyDoiHoatDongNgoaiGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiHoatDongNgoaiGiangDayFilterBuilder : SqlFilterBuilder<QuyDoiHoatDongNgoaiGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		public QuyDoiHoatDongNgoaiGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the QuyDoiHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public QuyDoiHoatDongNgoaiGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the QuyDoiHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public QuyDoiHoatDongNgoaiGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion QuyDoiHoatDongNgoaiGiangDayFilterBuilder
	
	#region QuyDoiHoatDongNgoaiGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;QuyDoiHoatDongNgoaiGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiHoatDongNgoaiGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<QuyDoiHoatDongNgoaiGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		public QuyDoiHoatDongNgoaiGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the QuyDoiHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public QuyDoiHoatDongNgoaiGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the QuyDoiHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public QuyDoiHoatDongNgoaiGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion QuyDoiHoatDongNgoaiGiangDayParameterBuilder
	
	#region QuyDoiHoatDongNgoaiGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;QuyDoiHoatDongNgoaiGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiHoatDongNgoaiGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class QuyDoiHoatDongNgoaiGiangDaySortBuilder : SqlSortBuilder<QuyDoiHoatDongNgoaiGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiHoatDongNgoaiGiangDaySqlSortBuilder class.
		/// </summary>
		public QuyDoiHoatDongNgoaiGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion QuyDoiHoatDongNgoaiGiangDaySortBuilder
	
} // end namespace
