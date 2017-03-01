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
	/// This class is the base class for any <see cref="HeSoNgonNguProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoNgonNguProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoNgonNgu, PMS.Entities.HeSoNgonNguKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoNgonNguKey key)
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
		public override PMS.Entities.HeSoNgonNgu Get(TransactionManager transactionManager, PMS.Entities.HeSoNgonNguKey key, int start, int pageLength)
		{
			return GetByMaHeSo(transactionManager, key.MaHeSo, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeSoNgoaiNgu index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgonNgu"/> class.</returns>
		public PMS.Entities.HeSoNgonNgu GetByMaHeSo(System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(null,_maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNgoaiNgu index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgonNgu"/> class.</returns>
		public PMS.Entities.HeSoNgonNgu GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNgoaiNgu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgonNgu"/> class.</returns>
		public PMS.Entities.HeSoNgonNgu GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNgoaiNgu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgonNgu"/> class.</returns>
		public PMS.Entities.HeSoNgonNgu GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNgoaiNgu index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgonNgu"/> class.</returns>
		public PMS.Entities.HeSoNgonNgu GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength, out int count)
		{
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoNgoaiNgu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoNgonNgu"/> class.</returns>
		public abstract PMS.Entities.HeSoNgonNgu GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HeSoNgonNgu_GetByMaLopHocPhanNgayDay 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgonNgu_GetByMaLopHocPhanNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNgonNgu&gt;"/> instance.</returns>
		public TList<HeSoNgonNgu> GetByMaLopHocPhanNgayDay(System.String maLopHocPhan, System.DateTime ngayDay)
		{
			return GetByMaLopHocPhanNgayDay(null, 0, int.MaxValue , maLopHocPhan, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgonNgu_GetByMaLopHocPhanNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNgonNgu&gt;"/> instance.</returns>
		public TList<HeSoNgonNgu> GetByMaLopHocPhanNgayDay(int start, int pageLength, System.String maLopHocPhan, System.DateTime ngayDay)
		{
			return GetByMaLopHocPhanNgayDay(null, start, pageLength , maLopHocPhan, ngayDay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoNgonNgu_GetByMaLopHocPhanNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNgonNgu&gt;"/> instance.</returns>
		public TList<HeSoNgonNgu> GetByMaLopHocPhanNgayDay(TransactionManager transactionManager, System.String maLopHocPhan, System.DateTime ngayDay)
		{
			return GetByMaLopHocPhanNgayDay(transactionManager, 0, int.MaxValue , maLopHocPhan, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgonNgu_GetByMaLopHocPhanNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNgonNgu&gt;"/> instance.</returns>
		public abstract TList<HeSoNgonNgu> GetByMaLopHocPhanNgayDay(TransactionManager transactionManager, int start, int pageLength , System.String maLopHocPhan, System.DateTime ngayDay);
		
		#endregion
		
		#region cust_HeSoNgonNgu_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgonNgu_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoNgonNgu_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoNgonNgu_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoNgonNgu_SaoChep' stored procedure. 
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
		
		#region cust_HeSoNgonNgu_GetByMaNgonNguNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgonNgu_GetByMaNgonNguNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maNgonNgu"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaNgonNguNamHocHocKy(System.String maNgonNgu, System.String namHoc, System.String hocKy, ref System.Double reVal)
		{
			 GetByMaNgonNguNamHocHocKy(null, 0, int.MaxValue , maNgonNgu, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgonNgu_GetByMaNgonNguNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maNgonNgu"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaNgonNguNamHocHocKy(int start, int pageLength, System.String maNgonNgu, System.String namHoc, System.String hocKy, ref System.Double reVal)
		{
			 GetByMaNgonNguNamHocHocKy(null, start, pageLength , maNgonNgu, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoNgonNgu_GetByMaNgonNguNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maNgonNgu"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaNgonNguNamHocHocKy(TransactionManager transactionManager, System.String maNgonNgu, System.String namHoc, System.String hocKy, ref System.Double reVal)
		{
			 GetByMaNgonNguNamHocHocKy(transactionManager, 0, int.MaxValue , maNgonNgu, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgonNgu_GetByMaNgonNguNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maNgonNgu"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaNgonNguNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maNgonNgu, System.String namHoc, System.String hocKy, ref System.Double reVal);
		
		#endregion
		
		#region cust_HeSoNgonNgu_GetByNamHocKocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgonNgu_GetByNamHocKocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNgonNgu&gt;"/> instance.</returns>
		public TList<HeSoNgonNgu> GetByNamHocKocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocKocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgonNgu_GetByNamHocKocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNgonNgu&gt;"/> instance.</returns>
		public TList<HeSoNgonNgu> GetByNamHocKocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocKocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoNgonNgu_GetByNamHocKocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNgonNgu&gt;"/> instance.</returns>
		public TList<HeSoNgonNgu> GetByNamHocKocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocKocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoNgonNgu_GetByNamHocKocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoNgonNgu&gt;"/> instance.</returns>
		public abstract TList<HeSoNgonNgu> GetByNamHocKocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoNgonNgu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoNgonNgu&gt;"/></returns>
		public static TList<HeSoNgonNgu> Fill(IDataReader reader, TList<HeSoNgonNgu> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoNgonNgu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoNgonNgu")
					.Append("|").Append((System.Int32)reader[((int)HeSoNgonNguColumn.MaHeSo - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoNgonNgu>(
					key.ToString(), // EntityTrackingKey
					"HeSoNgonNgu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoNgonNgu();
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
					c.MaHeSo = (System.Int32)reader[(HeSoNgonNguColumn.MaHeSo.ToString())];
					c.Stt = (reader[HeSoNgonNguColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoNgonNguColumn.Stt.ToString())];
					c.MaQuanLy = (System.String)reader[(HeSoNgonNguColumn.MaQuanLy.ToString())];
					c.TenNgonNgu = (reader[HeSoNgonNguColumn.TenNgonNgu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgonNguColumn.TenNgonNgu.ToString())];
					c.HeSo = (reader[HeSoNgonNguColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoNgonNguColumn.HeSo.ToString())];
					c.NgayBdApDung = (reader[HeSoNgonNguColumn.NgayBdApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoNgonNguColumn.NgayBdApDung.ToString())];
					c.NgayKtApDung = (reader[HeSoNgonNguColumn.NgayKtApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoNgonNguColumn.NgayKtApDung.ToString())];
					c.NamHoc = (reader[HeSoNgonNguColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgonNguColumn.NamHoc.ToString())];
					c.HocKy = (reader[HeSoNgonNguColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgonNguColumn.HocKy.ToString())];
					c.NgayCapNhat = (reader[HeSoNgonNguColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgonNguColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[HeSoNgonNguColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgonNguColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoNgonNgu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoNgonNgu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoNgonNgu entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHeSo = (System.Int32)reader[(HeSoNgonNguColumn.MaHeSo.ToString())];
			entity.Stt = (reader[HeSoNgonNguColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoNgonNguColumn.Stt.ToString())];
			entity.MaQuanLy = (System.String)reader[(HeSoNgonNguColumn.MaQuanLy.ToString())];
			entity.TenNgonNgu = (reader[HeSoNgonNguColumn.TenNgonNgu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgonNguColumn.TenNgonNgu.ToString())];
			entity.HeSo = (reader[HeSoNgonNguColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoNgonNguColumn.HeSo.ToString())];
			entity.NgayBdApDung = (reader[HeSoNgonNguColumn.NgayBdApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoNgonNguColumn.NgayBdApDung.ToString())];
			entity.NgayKtApDung = (reader[HeSoNgonNguColumn.NgayKtApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoNgonNguColumn.NgayKtApDung.ToString())];
			entity.NamHoc = (reader[HeSoNgonNguColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgonNguColumn.NamHoc.ToString())];
			entity.HocKy = (reader[HeSoNgonNguColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgonNguColumn.HocKy.ToString())];
			entity.NgayCapNhat = (reader[HeSoNgonNguColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgonNguColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[HeSoNgonNguColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoNgonNguColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoNgonNgu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoNgonNgu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoNgonNgu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHeSo = (System.Int32)dataRow["MaHeSo"];
			entity.Stt = Convert.IsDBNull(dataRow["STT"]) ? null : (System.Int32?)dataRow["STT"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenNgonNgu = Convert.IsDBNull(dataRow["TenNgonNgu"]) ? null : (System.String)dataRow["TenNgonNgu"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.NgayBdApDung = Convert.IsDBNull(dataRow["NgayBDApDung"]) ? null : (System.DateTime?)dataRow["NgayBDApDung"];
			entity.NgayKtApDung = Convert.IsDBNull(dataRow["NgayKTApDung"]) ? null : (System.DateTime?)dataRow["NgayKTApDung"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoNgonNgu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoNgonNgu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoNgonNgu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaHeSo methods when available
			
			#region GiangVienLopHocPhanCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienLopHocPhan>|GiangVienLopHocPhanCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienLopHocPhanCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienLopHocPhanCollection = DataRepository.GiangVienLopHocPhanProvider.GetByMaHeSoNn(transactionManager, entity.MaHeSo);

				if (deep && entity.GiangVienLopHocPhanCollection.Count > 0)
				{
					deepHandles.Add("GiangVienLopHocPhanCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienLopHocPhan>) DataRepository.GiangVienLopHocPhanProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienLopHocPhanCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoNgonNgu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoNgonNgu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoNgonNgu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoNgonNgu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<GiangVienLopHocPhan>
				if (CanDeepSave(entity.GiangVienLopHocPhanCollection, "List<GiangVienLopHocPhan>|GiangVienLopHocPhanCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienLopHocPhan child in entity.GiangVienLopHocPhanCollection)
					{
						if(child.MaHeSoNnSource != null)
						{
							child.MaHeSoNn = child.MaHeSoNnSource.MaHeSo;
						}
						else
						{
							child.MaHeSoNn = entity.MaHeSo;
						}

					}

					if (entity.GiangVienLopHocPhanCollection.Count > 0 || entity.GiangVienLopHocPhanCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienLopHocPhanProvider.Save(transactionManager, entity.GiangVienLopHocPhanCollection);
						
						deepHandles.Add("GiangVienLopHocPhanCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienLopHocPhan >) DataRepository.GiangVienLopHocPhanProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienLopHocPhanCollection, deepSaveType, childTypes, innerList }
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
	
	#region HeSoNgonNguChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoNgonNgu</c>
	///</summary>
	public enum HeSoNgonNguChildEntityTypes
	{
		///<summary>
		/// Collection of <c>HeSoNgonNgu</c> as OneToMany for GiangVienLopHocPhanCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienLopHocPhan>))]
		GiangVienLopHocPhanCollection,
	}
	
	#endregion HeSoNgonNguChildEntityTypes
	
	#region HeSoNgonNguFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoNgonNguColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNgonNgu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNgonNguFilterBuilder : SqlFilterBuilder<HeSoNgonNguColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNgonNguFilterBuilder class.
		/// </summary>
		public HeSoNgonNguFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoNgonNguFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoNgonNguFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoNgonNguFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoNgonNguFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoNgonNguFilterBuilder
	
	#region HeSoNgonNguParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoNgonNguColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNgonNgu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNgonNguParameterBuilder : ParameterizedSqlFilterBuilder<HeSoNgonNguColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNgonNguParameterBuilder class.
		/// </summary>
		public HeSoNgonNguParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoNgonNguParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoNgonNguParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoNgonNguParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoNgonNguParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoNgonNguParameterBuilder
	
	#region HeSoNgonNguSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoNgonNguColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNgonNgu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoNgonNguSortBuilder : SqlSortBuilder<HeSoNgonNguColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNgonNguSqlSortBuilder class.
		/// </summary>
		public HeSoNgonNguSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoNgonNguSortBuilder
	
} // end namespace
