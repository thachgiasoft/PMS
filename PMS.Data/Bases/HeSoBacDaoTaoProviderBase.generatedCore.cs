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
	/// This class is the base class for any <see cref="HeSoBacDaoTaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoBacDaoTaoProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoBacDaoTao, PMS.Entities.HeSoBacDaoTaoKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoBacDaoTaoKey key)
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
		public override PMS.Entities.HeSoBacDaoTao Get(TransactionManager transactionManager, PMS.Entities.HeSoBacDaoTaoKey key, int start, int pageLength)
		{
			return GetByMaHeSo(transactionManager, key.MaHeSo, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeSoBacDaoTao index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoBacDaoTao"/> class.</returns>
		public PMS.Entities.HeSoBacDaoTao GetByMaHeSo(System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(null,_maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoBacDaoTao index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoBacDaoTao"/> class.</returns>
		public PMS.Entities.HeSoBacDaoTao GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoBacDaoTao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoBacDaoTao"/> class.</returns>
		public PMS.Entities.HeSoBacDaoTao GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoBacDaoTao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoBacDaoTao"/> class.</returns>
		public PMS.Entities.HeSoBacDaoTao GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoBacDaoTao index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoBacDaoTao"/> class.</returns>
		public PMS.Entities.HeSoBacDaoTao GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength, out int count)
		{
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoBacDaoTao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoBacDaoTao"/> class.</returns>
		public abstract PMS.Entities.HeSoBacDaoTao GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HeSoBacDaoTao_GetByBacDaoTaoKhoaNgayDay 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoBacDaoTao_GetByBacDaoTaoKhoaNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoBacDaoTao&gt;"/> instance.</returns>
		public TList<HeSoBacDaoTao> GetByBacDaoTaoKhoaNgayDay(System.String maBacDaoTao, System.String maKhoa, System.DateTime ngayDay)
		{
			return GetByBacDaoTaoKhoaNgayDay(null, 0, int.MaxValue , maBacDaoTao, maKhoa, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoBacDaoTao_GetByBacDaoTaoKhoaNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoBacDaoTao&gt;"/> instance.</returns>
		public TList<HeSoBacDaoTao> GetByBacDaoTaoKhoaNgayDay(int start, int pageLength, System.String maBacDaoTao, System.String maKhoa, System.DateTime ngayDay)
		{
			return GetByBacDaoTaoKhoaNgayDay(null, start, pageLength , maBacDaoTao, maKhoa, ngayDay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoBacDaoTao_GetByBacDaoTaoKhoaNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoBacDaoTao&gt;"/> instance.</returns>
		public TList<HeSoBacDaoTao> GetByBacDaoTaoKhoaNgayDay(TransactionManager transactionManager, System.String maBacDaoTao, System.String maKhoa, System.DateTime ngayDay)
		{
			return GetByBacDaoTaoKhoaNgayDay(transactionManager, 0, int.MaxValue , maBacDaoTao, maKhoa, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoBacDaoTao_GetByBacDaoTaoKhoaNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoa"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoBacDaoTao&gt;"/> instance.</returns>
		public abstract TList<HeSoBacDaoTao> GetByBacDaoTaoKhoaNgayDay(TransactionManager transactionManager, int start, int pageLength , System.String maBacDaoTao, System.String maKhoa, System.DateTime ngayDay);
		
		#endregion
		
		#region cust_HeSoBacDaoTao_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoBacDaoTao_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoBacDaoTao&gt;"/> instance.</returns>
		public TList<HeSoBacDaoTao> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoBacDaoTao_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoBacDaoTao&gt;"/> instance.</returns>
		public TList<HeSoBacDaoTao> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoBacDaoTao_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoBacDaoTao&gt;"/> instance.</returns>
		public TList<HeSoBacDaoTao> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoBacDaoTao_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoBacDaoTao&gt;"/> instance.</returns>
		public abstract TList<HeSoBacDaoTao> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_HeSoBacDaoTao_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoBacDaoTao_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoBacDaoTao_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoBacDaoTao_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoBacDaoTao_SaoChep' stored procedure. 
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
		
		#region cust_HeSoBacDaoTao_GetByMaBacNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoBacDaoTao_GetByMaBacNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaBacNamHocHocKy(System.String maBacDaoTao, System.String namHoc, System.String hocKy, ref System.Double reVal)
		{
			 GetByMaBacNamHocHocKy(null, 0, int.MaxValue , maBacDaoTao, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoBacDaoTao_GetByMaBacNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaBacNamHocHocKy(int start, int pageLength, System.String maBacDaoTao, System.String namHoc, System.String hocKy, ref System.Double reVal)
		{
			 GetByMaBacNamHocHocKy(null, start, pageLength , maBacDaoTao, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoBacDaoTao_GetByMaBacNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaBacNamHocHocKy(TransactionManager transactionManager, System.String maBacDaoTao, System.String namHoc, System.String hocKy, ref System.Double reVal)
		{
			 GetByMaBacNamHocHocKy(transactionManager, 0, int.MaxValue , maBacDaoTao, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoBacDaoTao_GetByMaBacNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaBacNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maBacDaoTao, System.String namHoc, System.String hocKy, ref System.Double reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoBacDaoTao&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoBacDaoTao&gt;"/></returns>
		public static TList<HeSoBacDaoTao> Fill(IDataReader reader, TList<HeSoBacDaoTao> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoBacDaoTao c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoBacDaoTao")
					.Append("|").Append((System.Int32)reader[((int)HeSoBacDaoTaoColumn.MaHeSo - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoBacDaoTao>(
					key.ToString(), // EntityTrackingKey
					"HeSoBacDaoTao",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoBacDaoTao();
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
					c.MaHeSo = (System.Int32)reader[(HeSoBacDaoTaoColumn.MaHeSo.ToString())];
					c.Stt = (reader[HeSoBacDaoTaoColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoBacDaoTaoColumn.Stt.ToString())];
					c.MaQuanLy = (System.String)reader[(HeSoBacDaoTaoColumn.MaQuanLy.ToString())];
					c.TenBacDaoTao = (reader[HeSoBacDaoTaoColumn.TenBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoBacDaoTaoColumn.TenBacDaoTao.ToString())];
					c.HeSo = (reader[HeSoBacDaoTaoColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoBacDaoTaoColumn.HeSo.ToString())];
					c.NgayBdApDung = (reader[HeSoBacDaoTaoColumn.NgayBdApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoBacDaoTaoColumn.NgayBdApDung.ToString())];
					c.NgayKtApDung = (reader[HeSoBacDaoTaoColumn.NgayKtApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoBacDaoTaoColumn.NgayKtApDung.ToString())];
					c.NamHoc = (reader[HeSoBacDaoTaoColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoBacDaoTaoColumn.NamHoc.ToString())];
					c.HocKy = (reader[HeSoBacDaoTaoColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoBacDaoTaoColumn.HocKy.ToString())];
					c.NgayCapNhat = (reader[HeSoBacDaoTaoColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoBacDaoTaoColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[HeSoBacDaoTaoColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoBacDaoTaoColumn.NguoiCapNhat.ToString())];
					c.LoaiLop = (reader[HeSoBacDaoTaoColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoBacDaoTaoColumn.LoaiLop.ToString())];
					c.TinhVaoGioChuan = (reader[HeSoBacDaoTaoColumn.TinhVaoGioChuan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(HeSoBacDaoTaoColumn.TinhVaoGioChuan.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoBacDaoTao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoBacDaoTao"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoBacDaoTao entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHeSo = (System.Int32)reader[(HeSoBacDaoTaoColumn.MaHeSo.ToString())];
			entity.Stt = (reader[HeSoBacDaoTaoColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoBacDaoTaoColumn.Stt.ToString())];
			entity.MaQuanLy = (System.String)reader[(HeSoBacDaoTaoColumn.MaQuanLy.ToString())];
			entity.TenBacDaoTao = (reader[HeSoBacDaoTaoColumn.TenBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoBacDaoTaoColumn.TenBacDaoTao.ToString())];
			entity.HeSo = (reader[HeSoBacDaoTaoColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoBacDaoTaoColumn.HeSo.ToString())];
			entity.NgayBdApDung = (reader[HeSoBacDaoTaoColumn.NgayBdApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoBacDaoTaoColumn.NgayBdApDung.ToString())];
			entity.NgayKtApDung = (reader[HeSoBacDaoTaoColumn.NgayKtApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoBacDaoTaoColumn.NgayKtApDung.ToString())];
			entity.NamHoc = (reader[HeSoBacDaoTaoColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoBacDaoTaoColumn.NamHoc.ToString())];
			entity.HocKy = (reader[HeSoBacDaoTaoColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoBacDaoTaoColumn.HocKy.ToString())];
			entity.NgayCapNhat = (reader[HeSoBacDaoTaoColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoBacDaoTaoColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[HeSoBacDaoTaoColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoBacDaoTaoColumn.NguoiCapNhat.ToString())];
			entity.LoaiLop = (reader[HeSoBacDaoTaoColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoBacDaoTaoColumn.LoaiLop.ToString())];
			entity.TinhVaoGioChuan = (reader[HeSoBacDaoTaoColumn.TinhVaoGioChuan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(HeSoBacDaoTaoColumn.TinhVaoGioChuan.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoBacDaoTao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoBacDaoTao"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoBacDaoTao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHeSo = (System.Int32)dataRow["MaHeSo"];
			entity.Stt = Convert.IsDBNull(dataRow["STT"]) ? null : (System.Int32?)dataRow["STT"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenBacDaoTao = Convert.IsDBNull(dataRow["TenBacDaoTao"]) ? null : (System.String)dataRow["TenBacDaoTao"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.NgayBdApDung = Convert.IsDBNull(dataRow["NgayBDApDung"]) ? null : (System.DateTime?)dataRow["NgayBDApDung"];
			entity.NgayKtApDung = Convert.IsDBNull(dataRow["NgayKTApDung"]) ? null : (System.DateTime?)dataRow["NgayKTApDung"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.LoaiLop = Convert.IsDBNull(dataRow["LoaiLop"]) ? null : (System.String)dataRow["LoaiLop"];
			entity.TinhVaoGioChuan = Convert.IsDBNull(dataRow["TinhVaoGioChuan"]) ? null : (System.Boolean?)dataRow["TinhVaoGioChuan"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoBacDaoTao"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoBacDaoTao Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoBacDaoTao entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaHeSo methods when available
			
			#region LopHocPhanBacDaoTaoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<LopHocPhanBacDaoTao>|LopHocPhanBacDaoTaoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'LopHocPhanBacDaoTaoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.LopHocPhanBacDaoTaoCollection = DataRepository.LopHocPhanBacDaoTaoProvider.GetByMaHeSoBacDaoTao(transactionManager, entity.MaHeSo);

				if (deep && entity.LopHocPhanBacDaoTaoCollection.Count > 0)
				{
					deepHandles.Add("LopHocPhanBacDaoTaoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<LopHocPhanBacDaoTao>) DataRepository.LopHocPhanBacDaoTaoProvider.DeepLoad,
						new object[] { transactionManager, entity.LopHocPhanBacDaoTaoCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoBacDaoTao object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoBacDaoTao instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoBacDaoTao Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoBacDaoTao entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<LopHocPhanBacDaoTao>
				if (CanDeepSave(entity.LopHocPhanBacDaoTaoCollection, "List<LopHocPhanBacDaoTao>|LopHocPhanBacDaoTaoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(LopHocPhanBacDaoTao child in entity.LopHocPhanBacDaoTaoCollection)
					{
						if(child.MaHeSoBacDaoTaoSource != null)
						{
							child.MaHeSoBacDaoTao = child.MaHeSoBacDaoTaoSource.MaHeSo;
						}
						else
						{
							child.MaHeSoBacDaoTao = entity.MaHeSo;
						}

					}

					if (entity.LopHocPhanBacDaoTaoCollection.Count > 0 || entity.LopHocPhanBacDaoTaoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.LopHocPhanBacDaoTaoProvider.Save(transactionManager, entity.LopHocPhanBacDaoTaoCollection);
						
						deepHandles.Add("LopHocPhanBacDaoTaoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< LopHocPhanBacDaoTao >) DataRepository.LopHocPhanBacDaoTaoProvider.DeepSave,
							new object[] { transactionManager, entity.LopHocPhanBacDaoTaoCollection, deepSaveType, childTypes, innerList }
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
	
	#region HeSoBacDaoTaoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoBacDaoTao</c>
	///</summary>
	public enum HeSoBacDaoTaoChildEntityTypes
	{
		///<summary>
		/// Collection of <c>HeSoBacDaoTao</c> as OneToMany for LopHocPhanBacDaoTaoCollection
		///</summary>
		[ChildEntityType(typeof(TList<LopHocPhanBacDaoTao>))]
		LopHocPhanBacDaoTaoCollection,
	}
	
	#endregion HeSoBacDaoTaoChildEntityTypes
	
	#region HeSoBacDaoTaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoBacDaoTaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoBacDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoBacDaoTaoFilterBuilder : SqlFilterBuilder<HeSoBacDaoTaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoBacDaoTaoFilterBuilder class.
		/// </summary>
		public HeSoBacDaoTaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoBacDaoTaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoBacDaoTaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoBacDaoTaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoBacDaoTaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoBacDaoTaoFilterBuilder
	
	#region HeSoBacDaoTaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoBacDaoTaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoBacDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoBacDaoTaoParameterBuilder : ParameterizedSqlFilterBuilder<HeSoBacDaoTaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoBacDaoTaoParameterBuilder class.
		/// </summary>
		public HeSoBacDaoTaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoBacDaoTaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoBacDaoTaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoBacDaoTaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoBacDaoTaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoBacDaoTaoParameterBuilder
	
	#region HeSoBacDaoTaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoBacDaoTaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoBacDaoTao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoBacDaoTaoSortBuilder : SqlSortBuilder<HeSoBacDaoTaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoBacDaoTaoSqlSortBuilder class.
		/// </summary>
		public HeSoBacDaoTaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoBacDaoTaoSortBuilder
	
} // end namespace
