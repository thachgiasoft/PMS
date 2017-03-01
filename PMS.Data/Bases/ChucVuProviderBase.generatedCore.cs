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
	/// This class is the base class for any <see cref="ChucVuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ChucVuProviderBaseCore : EntityProviderBase<PMS.Entities.ChucVu, PMS.Entities.ChucVuKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ChucVuKey key)
		{
			return Delete(transactionManager, key.MaChucVu);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maChucVu">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maChucVu)
		{
			return Delete(null, _maChucVu);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucVu">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maChucVu);		
		
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
		public override PMS.Entities.ChucVu Get(TransactionManager transactionManager, PMS.Entities.ChucVuKey key, int start, int pageLength)
		{
			return GetByMaChucVu(transactionManager, key.MaChucVu, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ChucVu index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucVu"/> class.</returns>
		public PMS.Entities.ChucVu GetByMaQuanLy(System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ChucVu index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucVu"/> class.</returns>
		public PMS.Entities.ChucVu GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ChucVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucVu"/> class.</returns>
		public PMS.Entities.ChucVu GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ChucVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucVu"/> class.</returns>
		public PMS.Entities.ChucVu GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ChucVu index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucVu"/> class.</returns>
		public PMS.Entities.ChucVu GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ChucVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucVu"/> class.</returns>
		public abstract PMS.Entities.ChucVu GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ChucVu index.
		/// </summary>
		/// <param name="_maChucVu"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucVu"/> class.</returns>
		public PMS.Entities.ChucVu GetByMaChucVu(System.Int32 _maChucVu)
		{
			int count = -1;
			return GetByMaChucVu(null,_maChucVu, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChucVu index.
		/// </summary>
		/// <param name="_maChucVu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucVu"/> class.</returns>
		public PMS.Entities.ChucVu GetByMaChucVu(System.Int32 _maChucVu, int start, int pageLength)
		{
			int count = -1;
			return GetByMaChucVu(null, _maChucVu, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChucVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucVu"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucVu"/> class.</returns>
		public PMS.Entities.ChucVu GetByMaChucVu(TransactionManager transactionManager, System.Int32 _maChucVu)
		{
			int count = -1;
			return GetByMaChucVu(transactionManager, _maChucVu, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChucVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucVu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucVu"/> class.</returns>
		public PMS.Entities.ChucVu GetByMaChucVu(TransactionManager transactionManager, System.Int32 _maChucVu, int start, int pageLength)
		{
			int count = -1;
			return GetByMaChucVu(transactionManager, _maChucVu, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChucVu index.
		/// </summary>
		/// <param name="_maChucVu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucVu"/> class.</returns>
		public PMS.Entities.ChucVu GetByMaChucVu(System.Int32 _maChucVu, int start, int pageLength, out int count)
		{
			return GetByMaChucVu(null, _maChucVu, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChucVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucVu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucVu"/> class.</returns>
		public abstract PMS.Entities.ChucVu GetByMaChucVu(TransactionManager transactionManager, System.Int32 _maChucVu, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ChucVu_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ChucVu_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucVu&gt;"/> instance.</returns>
		public TList<ChucVu> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucVu_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucVu&gt;"/> instance.</returns>
		public TList<ChucVu> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChucVu_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucVu&gt;"/> instance.</returns>
		public TList<ChucVu> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucVu_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucVu&gt;"/> instance.</returns>
		public abstract TList<ChucVu> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ChucVu_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_ChucVu_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_ChucVu_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_ChucVu_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_ChucVu_SaoChep' stored procedure. 
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
		/// Fill a TList&lt;ChucVu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ChucVu&gt;"/></returns>
		public static TList<ChucVu> Fill(IDataReader reader, TList<ChucVu> rows, int start, int pageLength)
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
				
				PMS.Entities.ChucVu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ChucVu")
					.Append("|").Append((System.Int32)reader[((int)ChucVuColumn.MaChucVu - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ChucVu>(
					key.ToString(), // EntityTrackingKey
					"ChucVu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ChucVu();
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
					c.MaChucVu = (System.Int32)reader[(ChucVuColumn.MaChucVu.ToString())];
					c.MaQuanLy = (System.String)reader[(ChucVuColumn.MaQuanLy.ToString())];
					c.TenChucVu = (reader[ChucVuColumn.TenChucVu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucVuColumn.TenChucVu.ToString())];
					c.ThuTu = (reader[ChucVuColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChucVuColumn.ThuTu.ToString())];
					c.DinhMucToiThieu = (reader[ChucVuColumn.DinhMucToiThieu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChucVuColumn.DinhMucToiThieu.ToString())];
					c.NgayBdApDung = (reader[ChucVuColumn.NgayBdApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ChucVuColumn.NgayBdApDung.ToString())];
					c.NgayKtApDung = (reader[ChucVuColumn.NgayKtApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ChucVuColumn.NgayKtApDung.ToString())];
					c.SoTiet = (reader[ChucVuColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChucVuColumn.SoTiet.ToString())];
					c.PhanTramGio = (reader[ChucVuColumn.PhanTramGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChucVuColumn.PhanTramGio.ToString())];
					c.NguongTiet = (reader[ChucVuColumn.NguongTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChucVuColumn.NguongTiet.ToString())];
					c.CongDonKiemNhiem = (reader[ChucVuColumn.CongDonKiemNhiem.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChucVuColumn.CongDonKiemNhiem.ToString())];
					c.NamHoc = (reader[ChucVuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucVuColumn.NamHoc.ToString())];
					c.HocKy = (reader[ChucVuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucVuColumn.HocKy.ToString())];
					c.Hrmid = (reader[ChucVuColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(ChucVuColumn.Hrmid.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChucVu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChucVu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ChucVu entity)
		{
			if (!reader.Read()) return;
			
			entity.MaChucVu = (System.Int32)reader[(ChucVuColumn.MaChucVu.ToString())];
			entity.MaQuanLy = (System.String)reader[(ChucVuColumn.MaQuanLy.ToString())];
			entity.TenChucVu = (reader[ChucVuColumn.TenChucVu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucVuColumn.TenChucVu.ToString())];
			entity.ThuTu = (reader[ChucVuColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChucVuColumn.ThuTu.ToString())];
			entity.DinhMucToiThieu = (reader[ChucVuColumn.DinhMucToiThieu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChucVuColumn.DinhMucToiThieu.ToString())];
			entity.NgayBdApDung = (reader[ChucVuColumn.NgayBdApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ChucVuColumn.NgayBdApDung.ToString())];
			entity.NgayKtApDung = (reader[ChucVuColumn.NgayKtApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ChucVuColumn.NgayKtApDung.ToString())];
			entity.SoTiet = (reader[ChucVuColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChucVuColumn.SoTiet.ToString())];
			entity.PhanTramGio = (reader[ChucVuColumn.PhanTramGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChucVuColumn.PhanTramGio.ToString())];
			entity.NguongTiet = (reader[ChucVuColumn.NguongTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChucVuColumn.NguongTiet.ToString())];
			entity.CongDonKiemNhiem = (reader[ChucVuColumn.CongDonKiemNhiem.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChucVuColumn.CongDonKiemNhiem.ToString())];
			entity.NamHoc = (reader[ChucVuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucVuColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ChucVuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucVuColumn.HocKy.ToString())];
			entity.Hrmid = (reader[ChucVuColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(ChucVuColumn.Hrmid.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChucVu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChucVu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ChucVu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaChucVu = (System.Int32)dataRow["MaChucVu"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenChucVu = Convert.IsDBNull(dataRow["TenChucVu"]) ? null : (System.String)dataRow["TenChucVu"];
			entity.ThuTu = Convert.IsDBNull(dataRow["ThuTu"]) ? null : (System.Int32?)dataRow["ThuTu"];
			entity.DinhMucToiThieu = Convert.IsDBNull(dataRow["DinhMucToiThieu"]) ? null : (System.Int32?)dataRow["DinhMucToiThieu"];
			entity.NgayBdApDung = Convert.IsDBNull(dataRow["NgayBDApDung"]) ? null : (System.DateTime?)dataRow["NgayBDApDung"];
			entity.NgayKtApDung = Convert.IsDBNull(dataRow["NgayKTApDung"]) ? null : (System.DateTime?)dataRow["NgayKTApDung"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Int32?)dataRow["SoTiet"];
			entity.PhanTramGio = Convert.IsDBNull(dataRow["PhanTramGio"]) ? null : (System.Decimal?)dataRow["PhanTramGio"];
			entity.NguongTiet = Convert.IsDBNull(dataRow["NguongTiet"]) ? null : (System.Int32?)dataRow["NguongTiet"];
			entity.CongDonKiemNhiem = Convert.IsDBNull(dataRow["CongDonKiemNhiem"]) ? null : (System.Boolean?)dataRow["CongDonKiemNhiem"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.Hrmid = Convert.IsDBNull(dataRow["Hrmid"]) ? null : (System.Guid?)dataRow["Hrmid"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ChucVu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ChucVu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ChucVu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaChucVu methods when available
			
			#region DinhMucGioChuanToiThieuTheoChucVuCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<DinhMucGioChuanToiThieuTheoChucVu>|DinhMucGioChuanToiThieuTheoChucVuCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'DinhMucGioChuanToiThieuTheoChucVuCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.DinhMucGioChuanToiThieuTheoChucVuCollection = DataRepository.DinhMucGioChuanToiThieuTheoChucVuProvider.GetByMaChucVu(transactionManager, entity.MaChucVu);

				if (deep && entity.DinhMucGioChuanToiThieuTheoChucVuCollection.Count > 0)
				{
					deepHandles.Add("DinhMucGioChuanToiThieuTheoChucVuCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<DinhMucGioChuanToiThieuTheoChucVu>) DataRepository.DinhMucGioChuanToiThieuTheoChucVuProvider.DeepLoad,
						new object[] { transactionManager, entity.DinhMucGioChuanToiThieuTheoChucVuCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GiangVienChucVuCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienChucVu>|GiangVienChucVuCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienChucVuCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienChucVuCollection = DataRepository.GiangVienChucVuProvider.GetByMaChucVu(transactionManager, entity.MaChucVu);

				if (deep && entity.GiangVienChucVuCollection.Count > 0)
				{
					deepHandles.Add("GiangVienChucVuCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienChucVu>) DataRepository.GiangVienChucVuProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienChucVuCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.ChucVu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ChucVu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ChucVu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ChucVu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<DinhMucGioChuanToiThieuTheoChucVu>
				if (CanDeepSave(entity.DinhMucGioChuanToiThieuTheoChucVuCollection, "List<DinhMucGioChuanToiThieuTheoChucVu>|DinhMucGioChuanToiThieuTheoChucVuCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(DinhMucGioChuanToiThieuTheoChucVu child in entity.DinhMucGioChuanToiThieuTheoChucVuCollection)
					{
						if(child.MaChucVuSource != null)
						{
							child.MaChucVu = child.MaChucVuSource.MaChucVu;
						}
						else
						{
							child.MaChucVu = entity.MaChucVu;
						}

					}

					if (entity.DinhMucGioChuanToiThieuTheoChucVuCollection.Count > 0 || entity.DinhMucGioChuanToiThieuTheoChucVuCollection.DeletedItems.Count > 0)
					{
						//DataRepository.DinhMucGioChuanToiThieuTheoChucVuProvider.Save(transactionManager, entity.DinhMucGioChuanToiThieuTheoChucVuCollection);
						
						deepHandles.Add("DinhMucGioChuanToiThieuTheoChucVuCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< DinhMucGioChuanToiThieuTheoChucVu >) DataRepository.DinhMucGioChuanToiThieuTheoChucVuProvider.DeepSave,
							new object[] { transactionManager, entity.DinhMucGioChuanToiThieuTheoChucVuCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GiangVienChucVu>
				if (CanDeepSave(entity.GiangVienChucVuCollection, "List<GiangVienChucVu>|GiangVienChucVuCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienChucVu child in entity.GiangVienChucVuCollection)
					{
						if(child.MaChucVuSource != null)
						{
							child.MaChucVu = child.MaChucVuSource.MaChucVu;
						}
						else
						{
							child.MaChucVu = entity.MaChucVu;
						}

					}

					if (entity.GiangVienChucVuCollection.Count > 0 || entity.GiangVienChucVuCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienChucVuProvider.Save(transactionManager, entity.GiangVienChucVuCollection);
						
						deepHandles.Add("GiangVienChucVuCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienChucVu >) DataRepository.GiangVienChucVuProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienChucVuCollection, deepSaveType, childTypes, innerList }
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
	
	#region ChucVuChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ChucVu</c>
	///</summary>
	public enum ChucVuChildEntityTypes
	{
		///<summary>
		/// Collection of <c>ChucVu</c> as OneToMany for DinhMucGioChuanToiThieuTheoChucVuCollection
		///</summary>
		[ChildEntityType(typeof(TList<DinhMucGioChuanToiThieuTheoChucVu>))]
		DinhMucGioChuanToiThieuTheoChucVuCollection,
		///<summary>
		/// Collection of <c>ChucVu</c> as OneToMany for GiangVienChucVuCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienChucVu>))]
		GiangVienChucVuCollection,
	}
	
	#endregion ChucVuChildEntityTypes
	
	#region ChucVuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ChucVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChucVuFilterBuilder : SqlFilterBuilder<ChucVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChucVuFilterBuilder class.
		/// </summary>
		public ChucVuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChucVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChucVuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChucVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChucVuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChucVuFilterBuilder
	
	#region ChucVuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ChucVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChucVuParameterBuilder : ParameterizedSqlFilterBuilder<ChucVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChucVuParameterBuilder class.
		/// </summary>
		public ChucVuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChucVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChucVuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChucVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChucVuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChucVuParameterBuilder
	
	#region ChucVuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ChucVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChucVu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ChucVuSortBuilder : SqlSortBuilder<ChucVuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChucVuSqlSortBuilder class.
		/// </summary>
		public ChucVuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ChucVuSortBuilder
	
} // end namespace
