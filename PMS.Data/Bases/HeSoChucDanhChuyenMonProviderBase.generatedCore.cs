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
	/// This class is the base class for any <see cref="HeSoChucDanhChuyenMonProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoChucDanhChuyenMonProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoChucDanhChuyenMon, PMS.Entities.HeSoChucDanhChuyenMonKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoChucDanhChuyenMonKey key)
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
		public override PMS.Entities.HeSoChucDanhChuyenMon Get(TransactionManager transactionManager, PMS.Entities.HeSoChucDanhChuyenMonKey key, int start, int pageLength)
		{
			return GetByMaHeSo(transactionManager, key.MaHeSo, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeSoChucDanhChuyenMon index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhChuyenMon"/> class.</returns>
		public PMS.Entities.HeSoChucDanhChuyenMon GetByMaHeSo(System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(null,_maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanhChuyenMon index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhChuyenMon"/> class.</returns>
		public PMS.Entities.HeSoChucDanhChuyenMon GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanhChuyenMon index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhChuyenMon"/> class.</returns>
		public PMS.Entities.HeSoChucDanhChuyenMon GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanhChuyenMon index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhChuyenMon"/> class.</returns>
		public PMS.Entities.HeSoChucDanhChuyenMon GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanhChuyenMon index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhChuyenMon"/> class.</returns>
		public PMS.Entities.HeSoChucDanhChuyenMon GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength, out int count)
		{
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanhChuyenMon index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhChuyenMon"/> class.</returns>
		public abstract PMS.Entities.HeSoChucDanhChuyenMon GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HeSoChucDanhChuyenMon_GetByMaGiangVienNgayDayNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanhChuyenMon_GetByMaGiangVienNgayDayNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienNgayDayNamHocHocKy(System.String maGiangVien, System.DateTime ngayDay, System.String namHoc, System.String hocKy, ref System.Double heSo)
		{
			 GetByMaGiangVienNgayDayNamHocHocKy(null, 0, int.MaxValue , maGiangVien, ngayDay, namHoc, hocKy, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanhChuyenMon_GetByMaGiangVienNgayDayNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienNgayDayNamHocHocKy(int start, int pageLength, System.String maGiangVien, System.DateTime ngayDay, System.String namHoc, System.String hocKy, ref System.Double heSo)
		{
			 GetByMaGiangVienNgayDayNamHocHocKy(null, start, pageLength , maGiangVien, ngayDay, namHoc, hocKy, ref heSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanhChuyenMon_GetByMaGiangVienNgayDayNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVienNgayDayNamHocHocKy(TransactionManager transactionManager, System.String maGiangVien, System.DateTime ngayDay, System.String namHoc, System.String hocKy, ref System.Double heSo)
		{
			 GetByMaGiangVienNgayDayNamHocHocKy(transactionManager, 0, int.MaxValue , maGiangVien, ngayDay, namHoc, hocKy, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanhChuyenMon_GetByMaGiangVienNgayDayNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaGiangVienNgayDayNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVien, System.DateTime ngayDay, System.String namHoc, System.String hocKy, ref System.Double heSo);
		
		#endregion
		
		#region cust_HeSoChucDanhChuyenMon_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanhChuyenMon_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoChucDanhChuyenMon&gt;"/> instance.</returns>
		public TList<HeSoChucDanhChuyenMon> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanhChuyenMon_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoChucDanhChuyenMon&gt;"/> instance.</returns>
		public TList<HeSoChucDanhChuyenMon> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanhChuyenMon_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoChucDanhChuyenMon&gt;"/> instance.</returns>
		public TList<HeSoChucDanhChuyenMon> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanhChuyenMon_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoChucDanhChuyenMon&gt;"/> instance.</returns>
		public abstract TList<HeSoChucDanhChuyenMon> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_HeSoChucDanhChuyenMon_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanhChuyenMon_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoChucDanhChuyenMon_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoChucDanhChuyenMon_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoChucDanhChuyenMon_SaoChep' stored procedure. 
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
		/// Fill a TList&lt;HeSoChucDanhChuyenMon&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoChucDanhChuyenMon&gt;"/></returns>
		public static TList<HeSoChucDanhChuyenMon> Fill(IDataReader reader, TList<HeSoChucDanhChuyenMon> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoChucDanhChuyenMon c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoChucDanhChuyenMon")
					.Append("|").Append((System.Int32)reader[((int)HeSoChucDanhChuyenMonColumn.MaHeSo - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoChucDanhChuyenMon>(
					key.ToString(), // EntityTrackingKey
					"HeSoChucDanhChuyenMon",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoChucDanhChuyenMon();
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
					c.MaHeSo = (System.Int32)reader[(HeSoChucDanhChuyenMonColumn.MaHeSo.ToString())];
					c.MaQuanLy = (reader[HeSoChucDanhChuyenMonColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhChuyenMonColumn.MaQuanLy.ToString())];
					c.MaLoaiGiangVien = (reader[HeSoChucDanhChuyenMonColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhChuyenMonColumn.MaLoaiGiangVien.ToString())];
					c.MaHocHam = (reader[HeSoChucDanhChuyenMonColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhChuyenMonColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[HeSoChucDanhChuyenMonColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhChuyenMonColumn.MaHocVi.ToString())];
					c.HeSo = (reader[HeSoChucDanhChuyenMonColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoChucDanhChuyenMonColumn.HeSo.ToString())];
					c.NamHoc = (reader[HeSoChucDanhChuyenMonColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhChuyenMonColumn.NamHoc.ToString())];
					c.HocKy = (reader[HeSoChucDanhChuyenMonColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhChuyenMonColumn.HocKy.ToString())];
					c.BacDaoTao = (reader[HeSoChucDanhChuyenMonColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhChuyenMonColumn.BacDaoTao.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoChucDanhChuyenMon"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoChucDanhChuyenMon"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoChucDanhChuyenMon entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHeSo = (System.Int32)reader[(HeSoChucDanhChuyenMonColumn.MaHeSo.ToString())];
			entity.MaQuanLy = (reader[HeSoChucDanhChuyenMonColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhChuyenMonColumn.MaQuanLy.ToString())];
			entity.MaLoaiGiangVien = (reader[HeSoChucDanhChuyenMonColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhChuyenMonColumn.MaLoaiGiangVien.ToString())];
			entity.MaHocHam = (reader[HeSoChucDanhChuyenMonColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhChuyenMonColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[HeSoChucDanhChuyenMonColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhChuyenMonColumn.MaHocVi.ToString())];
			entity.HeSo = (reader[HeSoChucDanhChuyenMonColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoChucDanhChuyenMonColumn.HeSo.ToString())];
			entity.NamHoc = (reader[HeSoChucDanhChuyenMonColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhChuyenMonColumn.NamHoc.ToString())];
			entity.HocKy = (reader[HeSoChucDanhChuyenMonColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhChuyenMonColumn.HocKy.ToString())];
			entity.BacDaoTao = (reader[HeSoChucDanhChuyenMonColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhChuyenMonColumn.BacDaoTao.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoChucDanhChuyenMon"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoChucDanhChuyenMon"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoChucDanhChuyenMon entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHeSo = (System.Int32)dataRow["MaHeSo"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.BacDaoTao = Convert.IsDBNull(dataRow["BacDaoTao"]) ? null : (System.String)dataRow["BacDaoTao"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoChucDanhChuyenMon"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoChucDanhChuyenMon Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoChucDanhChuyenMon entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoChucDanhChuyenMon object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoChucDanhChuyenMon instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoChucDanhChuyenMon Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoChucDanhChuyenMon entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HeSoChucDanhChuyenMonChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoChucDanhChuyenMon</c>
	///</summary>
	public enum HeSoChucDanhChuyenMonChildEntityTypes
	{
	}
	
	#endregion HeSoChucDanhChuyenMonChildEntityTypes
	
	#region HeSoChucDanhChuyenMonFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoChucDanhChuyenMonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhChuyenMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhChuyenMonFilterBuilder : SqlFilterBuilder<HeSoChucDanhChuyenMonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhChuyenMonFilterBuilder class.
		/// </summary>
		public HeSoChucDanhChuyenMonFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhChuyenMonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoChucDanhChuyenMonFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhChuyenMonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoChucDanhChuyenMonFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoChucDanhChuyenMonFilterBuilder
	
	#region HeSoChucDanhChuyenMonParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoChucDanhChuyenMonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhChuyenMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhChuyenMonParameterBuilder : ParameterizedSqlFilterBuilder<HeSoChucDanhChuyenMonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhChuyenMonParameterBuilder class.
		/// </summary>
		public HeSoChucDanhChuyenMonParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhChuyenMonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoChucDanhChuyenMonParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhChuyenMonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoChucDanhChuyenMonParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoChucDanhChuyenMonParameterBuilder
	
	#region HeSoChucDanhChuyenMonSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoChucDanhChuyenMonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhChuyenMon"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoChucDanhChuyenMonSortBuilder : SqlSortBuilder<HeSoChucDanhChuyenMonColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhChuyenMonSqlSortBuilder class.
		/// </summary>
		public HeSoChucDanhChuyenMonSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoChucDanhChuyenMonSortBuilder
	
} // end namespace
