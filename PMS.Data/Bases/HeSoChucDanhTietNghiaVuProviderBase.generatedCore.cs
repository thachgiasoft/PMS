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
	/// This class is the base class for any <see cref="HeSoChucDanhTietNghiaVuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoChucDanhTietNghiaVuProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoChucDanhTietNghiaVu, PMS.Entities.HeSoChucDanhTietNghiaVuKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoChucDanhTietNghiaVuKey key)
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
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeSoChucDanh_TietNghiaVu_HocHam key.
		///		FK_HeSoChucDanh_TietNghiaVu_HocHam Description: 
		/// </summary>
		/// <param name="_maHocHam"></param>
		/// <returns>Returns a typed collection of PMS.Entities.HeSoChucDanhTietNghiaVu objects.</returns>
		public TList<HeSoChucDanhTietNghiaVu> GetByMaHocHam(System.Int32? _maHocHam)
		{
			int count = -1;
			return GetByMaHocHam(_maHocHam, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeSoChucDanh_TietNghiaVu_HocHam key.
		///		FK_HeSoChucDanh_TietNghiaVu_HocHam Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <returns>Returns a typed collection of PMS.Entities.HeSoChucDanhTietNghiaVu objects.</returns>
		/// <remarks></remarks>
		public TList<HeSoChucDanhTietNghiaVu> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam)
		{
			int count = -1;
			return GetByMaHocHam(transactionManager, _maHocHam, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeSoChucDanh_TietNghiaVu_HocHam key.
		///		FK_HeSoChucDanh_TietNghiaVu_HocHam Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HeSoChucDanhTietNghiaVu objects.</returns>
		public TList<HeSoChucDanhTietNghiaVu> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocHam(transactionManager, _maHocHam, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeSoChucDanh_TietNghiaVu_HocHam key.
		///		fkHeSoChucDanhTietNghiaVuHocHam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocHam"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HeSoChucDanhTietNghiaVu objects.</returns>
		public TList<HeSoChucDanhTietNghiaVu> GetByMaHocHam(System.Int32? _maHocHam, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHocHam(null, _maHocHam, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeSoChucDanh_TietNghiaVu_HocHam key.
		///		fkHeSoChucDanhTietNghiaVuHocHam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocHam"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HeSoChucDanhTietNghiaVu objects.</returns>
		public TList<HeSoChucDanhTietNghiaVu> GetByMaHocHam(System.Int32? _maHocHam, int start, int pageLength,out int count)
		{
			return GetByMaHocHam(null, _maHocHam, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeSoChucDanh_TietNghiaVu_HocHam key.
		///		FK_HeSoChucDanh_TietNghiaVu_HocHam Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.HeSoChucDanhTietNghiaVu objects.</returns>
		public abstract TList<HeSoChucDanhTietNghiaVu> GetByMaHocHam(TransactionManager transactionManager, System.Int32? _maHocHam, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeSoChucDanh_TietNghiaVu_HocVi key.
		///		FK_HeSoChucDanh_TietNghiaVu_HocVi Description: 
		/// </summary>
		/// <param name="_maHocVi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.HeSoChucDanhTietNghiaVu objects.</returns>
		public TList<HeSoChucDanhTietNghiaVu> GetByMaHocVi(System.Int32? _maHocVi)
		{
			int count = -1;
			return GetByMaHocVi(_maHocVi, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeSoChucDanh_TietNghiaVu_HocVi key.
		///		FK_HeSoChucDanh_TietNghiaVu_HocVi Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.HeSoChucDanhTietNghiaVu objects.</returns>
		/// <remarks></remarks>
		public TList<HeSoChucDanhTietNghiaVu> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi)
		{
			int count = -1;
			return GetByMaHocVi(transactionManager, _maHocVi, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeSoChucDanh_TietNghiaVu_HocVi key.
		///		FK_HeSoChucDanh_TietNghiaVu_HocVi Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HeSoChucDanhTietNghiaVu objects.</returns>
		public TList<HeSoChucDanhTietNghiaVu> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocVi(transactionManager, _maHocVi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeSoChucDanh_TietNghiaVu_HocVi key.
		///		fkHeSoChucDanhTietNghiaVuHocVi Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocVi"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HeSoChucDanhTietNghiaVu objects.</returns>
		public TList<HeSoChucDanhTietNghiaVu> GetByMaHocVi(System.Int32? _maHocVi, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHocVi(null, _maHocVi, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeSoChucDanh_TietNghiaVu_HocVi key.
		///		fkHeSoChucDanhTietNghiaVuHocVi Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHocVi"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HeSoChucDanhTietNghiaVu objects.</returns>
		public TList<HeSoChucDanhTietNghiaVu> GetByMaHocVi(System.Int32? _maHocVi, int start, int pageLength,out int count)
		{
			return GetByMaHocVi(null, _maHocVi, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeSoChucDanh_TietNghiaVu_HocVi key.
		///		FK_HeSoChucDanh_TietNghiaVu_HocVi Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.HeSoChucDanhTietNghiaVu objects.</returns>
		public abstract TList<HeSoChucDanhTietNghiaVu> GetByMaHocVi(TransactionManager transactionManager, System.Int32? _maHocVi, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.HeSoChucDanhTietNghiaVu Get(TransactionManager transactionManager, PMS.Entities.HeSoChucDanhTietNghiaVuKey key, int start, int pageLength)
		{
			return GetByMaHeSo(transactionManager, key.MaHeSo, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeSoChucDanh_TietNghiaVu index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhTietNghiaVu"/> class.</returns>
		public PMS.Entities.HeSoChucDanhTietNghiaVu GetByMaHeSo(System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(null,_maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanh_TietNghiaVu index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhTietNghiaVu"/> class.</returns>
		public PMS.Entities.HeSoChucDanhTietNghiaVu GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanh_TietNghiaVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhTietNghiaVu"/> class.</returns>
		public PMS.Entities.HeSoChucDanhTietNghiaVu GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanh_TietNghiaVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhTietNghiaVu"/> class.</returns>
		public PMS.Entities.HeSoChucDanhTietNghiaVu GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanh_TietNghiaVu index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhTietNghiaVu"/> class.</returns>
		public PMS.Entities.HeSoChucDanhTietNghiaVu GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength, out int count)
		{
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanh_TietNghiaVu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhTietNghiaVu"/> class.</returns>
		public abstract PMS.Entities.HeSoChucDanhTietNghiaVu GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HeSoChucDanh_TietNghiaVu_GetByMaGiangVienNgayDay 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanh_TietNghiaVu_GetByMaGiangVienNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoChucDanhTietNghiaVu&gt;"/> instance.</returns>
		public TList<HeSoChucDanhTietNghiaVu> GetByMaGiangVienNgayDay(System.String maGiangVien, System.DateTime ngayDay, System.String namHoc, System.String hocKy)
		{
			return GetByMaGiangVienNgayDay(null, 0, int.MaxValue , maGiangVien, ngayDay, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanh_TietNghiaVu_GetByMaGiangVienNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoChucDanhTietNghiaVu&gt;"/> instance.</returns>
		public TList<HeSoChucDanhTietNghiaVu> GetByMaGiangVienNgayDay(int start, int pageLength, System.String maGiangVien, System.DateTime ngayDay, System.String namHoc, System.String hocKy)
		{
			return GetByMaGiangVienNgayDay(null, start, pageLength , maGiangVien, ngayDay, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanh_TietNghiaVu_GetByMaGiangVienNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoChucDanhTietNghiaVu&gt;"/> instance.</returns>
		public TList<HeSoChucDanhTietNghiaVu> GetByMaGiangVienNgayDay(TransactionManager transactionManager, System.String maGiangVien, System.DateTime ngayDay, System.String namHoc, System.String hocKy)
		{
			return GetByMaGiangVienNgayDay(transactionManager, 0, int.MaxValue , maGiangVien, ngayDay, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanh_TietNghiaVu_GetByMaGiangVienNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoChucDanhTietNghiaVu&gt;"/> instance.</returns>
		public abstract TList<HeSoChucDanhTietNghiaVu> GetByMaGiangVienNgayDay(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVien, System.DateTime ngayDay, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoChucDanhTietNghiaVu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoChucDanhTietNghiaVu&gt;"/></returns>
		public static TList<HeSoChucDanhTietNghiaVu> Fill(IDataReader reader, TList<HeSoChucDanhTietNghiaVu> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoChucDanhTietNghiaVu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoChucDanhTietNghiaVu")
					.Append("|").Append((System.Int32)reader[((int)HeSoChucDanhTietNghiaVuColumn.MaHeSo - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoChucDanhTietNghiaVu>(
					key.ToString(), // EntityTrackingKey
					"HeSoChucDanhTietNghiaVu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoChucDanhTietNghiaVu();
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
					c.MaHeSo = (System.Int32)reader[(HeSoChucDanhTietNghiaVuColumn.MaHeSo.ToString())];
					c.Stt = (reader[HeSoChucDanhTietNghiaVuColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhTietNghiaVuColumn.Stt.ToString())];
					c.MaQuanLy = (System.String)reader[(HeSoChucDanhTietNghiaVuColumn.MaQuanLy.ToString())];
					c.MaHocHam = (reader[HeSoChucDanhTietNghiaVuColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhTietNghiaVuColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[HeSoChucDanhTietNghiaVuColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhTietNghiaVuColumn.MaHocVi.ToString())];
					c.HeSo = (reader[HeSoChucDanhTietNghiaVuColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoChucDanhTietNghiaVuColumn.HeSo.ToString())];
					c.SoTietNghiaVu = (reader[HeSoChucDanhTietNghiaVuColumn.SoTietNghiaVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhTietNghiaVuColumn.SoTietNghiaVu.ToString())];
					c.NgayBdApDung = (reader[HeSoChucDanhTietNghiaVuColumn.NgayBdApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoChucDanhTietNghiaVuColumn.NgayBdApDung.ToString())];
					c.NgayKtApDung = (reader[HeSoChucDanhTietNghiaVuColumn.NgayKtApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoChucDanhTietNghiaVuColumn.NgayKtApDung.ToString())];
					c.HeSoLuongTangThem = (reader[HeSoChucDanhTietNghiaVuColumn.HeSoLuongTangThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoChucDanhTietNghiaVuColumn.HeSoLuongTangThem.ToString())];
					c.SoTietNghiaVuMonGdtc = (reader[HeSoChucDanhTietNghiaVuColumn.SoTietNghiaVuMonGdtc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhTietNghiaVuColumn.SoTietNghiaVuMonGdtc.ToString())];
					c.GiangDaySauDaiHoc = (reader[HeSoChucDanhTietNghiaVuColumn.GiangDaySauDaiHoc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(HeSoChucDanhTietNghiaVuColumn.GiangDaySauDaiHoc.ToString())];
					c.NamHoc = (reader[HeSoChucDanhTietNghiaVuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhTietNghiaVuColumn.NamHoc.ToString())];
					c.HocKy = (reader[HeSoChucDanhTietNghiaVuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhTietNghiaVuColumn.HocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoChucDanhTietNghiaVu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoChucDanhTietNghiaVu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoChucDanhTietNghiaVu entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHeSo = (System.Int32)reader[(HeSoChucDanhTietNghiaVuColumn.MaHeSo.ToString())];
			entity.Stt = (reader[HeSoChucDanhTietNghiaVuColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhTietNghiaVuColumn.Stt.ToString())];
			entity.MaQuanLy = (System.String)reader[(HeSoChucDanhTietNghiaVuColumn.MaQuanLy.ToString())];
			entity.MaHocHam = (reader[HeSoChucDanhTietNghiaVuColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhTietNghiaVuColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[HeSoChucDanhTietNghiaVuColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhTietNghiaVuColumn.MaHocVi.ToString())];
			entity.HeSo = (reader[HeSoChucDanhTietNghiaVuColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoChucDanhTietNghiaVuColumn.HeSo.ToString())];
			entity.SoTietNghiaVu = (reader[HeSoChucDanhTietNghiaVuColumn.SoTietNghiaVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhTietNghiaVuColumn.SoTietNghiaVu.ToString())];
			entity.NgayBdApDung = (reader[HeSoChucDanhTietNghiaVuColumn.NgayBdApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoChucDanhTietNghiaVuColumn.NgayBdApDung.ToString())];
			entity.NgayKtApDung = (reader[HeSoChucDanhTietNghiaVuColumn.NgayKtApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoChucDanhTietNghiaVuColumn.NgayKtApDung.ToString())];
			entity.HeSoLuongTangThem = (reader[HeSoChucDanhTietNghiaVuColumn.HeSoLuongTangThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoChucDanhTietNghiaVuColumn.HeSoLuongTangThem.ToString())];
			entity.SoTietNghiaVuMonGdtc = (reader[HeSoChucDanhTietNghiaVuColumn.SoTietNghiaVuMonGdtc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhTietNghiaVuColumn.SoTietNghiaVuMonGdtc.ToString())];
			entity.GiangDaySauDaiHoc = (reader[HeSoChucDanhTietNghiaVuColumn.GiangDaySauDaiHoc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(HeSoChucDanhTietNghiaVuColumn.GiangDaySauDaiHoc.ToString())];
			entity.NamHoc = (reader[HeSoChucDanhTietNghiaVuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhTietNghiaVuColumn.NamHoc.ToString())];
			entity.HocKy = (reader[HeSoChucDanhTietNghiaVuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhTietNghiaVuColumn.HocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoChucDanhTietNghiaVu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoChucDanhTietNghiaVu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoChucDanhTietNghiaVu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHeSo = (System.Int32)dataRow["MaHeSo"];
			entity.Stt = Convert.IsDBNull(dataRow["STT"]) ? null : (System.Int32?)dataRow["STT"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.SoTietNghiaVu = Convert.IsDBNull(dataRow["SoTietNghiaVu"]) ? null : (System.Int32?)dataRow["SoTietNghiaVu"];
			entity.NgayBdApDung = Convert.IsDBNull(dataRow["NgayBDApDung"]) ? null : (System.DateTime?)dataRow["NgayBDApDung"];
			entity.NgayKtApDung = Convert.IsDBNull(dataRow["NgayKTApDung"]) ? null : (System.DateTime?)dataRow["NgayKTApDung"];
			entity.HeSoLuongTangThem = Convert.IsDBNull(dataRow["HeSoLuongTangThem"]) ? null : (System.Decimal?)dataRow["HeSoLuongTangThem"];
			entity.SoTietNghiaVuMonGdtc = Convert.IsDBNull(dataRow["SoTietNghiaVuMonGdtc"]) ? null : (System.Int32?)dataRow["SoTietNghiaVuMonGdtc"];
			entity.GiangDaySauDaiHoc = Convert.IsDBNull(dataRow["GiangDaySauDaiHoc"]) ? null : (System.Boolean?)dataRow["GiangDaySauDaiHoc"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoChucDanhTietNghiaVu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoChucDanhTietNghiaVu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoChucDanhTietNghiaVu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaHocHamSource	
			if (CanDeepLoad(entity, "HocHam|MaHocHamSource", deepLoadType, innerList) 
				&& entity.MaHocHamSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaHocHam ?? (int)0);
				HocHam tmpEntity = EntityManager.LocateEntity<HocHam>(EntityLocator.ConstructKeyFromPkItems(typeof(HocHam), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaHocHamSource = tmpEntity;
				else
					entity.MaHocHamSource = DataRepository.HocHamProvider.GetByMaHocHam(transactionManager, (entity.MaHocHam ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaHocHamSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaHocHamSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.HocHamProvider.DeepLoad(transactionManager, entity.MaHocHamSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaHocHamSource

			#region MaHocViSource	
			if (CanDeepLoad(entity, "HocVi|MaHocViSource", deepLoadType, innerList) 
				&& entity.MaHocViSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaHocVi ?? (int)0);
				HocVi tmpEntity = EntityManager.LocateEntity<HocVi>(EntityLocator.ConstructKeyFromPkItems(typeof(HocVi), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaHocViSource = tmpEntity;
				else
					entity.MaHocViSource = DataRepository.HocViProvider.GetByMaHocVi(transactionManager, (entity.MaHocVi ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaHocViSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaHocViSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.HocViProvider.DeepLoad(transactionManager, entity.MaHocViSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaHocViSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoChucDanhTietNghiaVu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoChucDanhTietNghiaVu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoChucDanhTietNghiaVu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoChucDanhTietNghiaVu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaHocHamSource
			if (CanDeepSave(entity, "HocHam|MaHocHamSource", deepSaveType, innerList) 
				&& entity.MaHocHamSource != null)
			{
				DataRepository.HocHamProvider.Save(transactionManager, entity.MaHocHamSource);
				entity.MaHocHam = entity.MaHocHamSource.MaHocHam;
			}
			#endregion 
			
			#region MaHocViSource
			if (CanDeepSave(entity, "HocVi|MaHocViSource", deepSaveType, innerList) 
				&& entity.MaHocViSource != null)
			{
				DataRepository.HocViProvider.Save(transactionManager, entity.MaHocViSource);
				entity.MaHocVi = entity.MaHocViSource.MaHocVi;
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
	
	#region HeSoChucDanhTietNghiaVuChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoChucDanhTietNghiaVu</c>
	///</summary>
	public enum HeSoChucDanhTietNghiaVuChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>HocHam</c> at MaHocHamSource
		///</summary>
		[ChildEntityType(typeof(HocHam))]
		HocHam,
		
		///<summary>
		/// Composite Property for <c>HocVi</c> at MaHocViSource
		///</summary>
		[ChildEntityType(typeof(HocVi))]
		HocVi,
	}
	
	#endregion HeSoChucDanhTietNghiaVuChildEntityTypes
	
	#region HeSoChucDanhTietNghiaVuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoChucDanhTietNghiaVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhTietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhTietNghiaVuFilterBuilder : SqlFilterBuilder<HeSoChucDanhTietNghiaVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhTietNghiaVuFilterBuilder class.
		/// </summary>
		public HeSoChucDanhTietNghiaVuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhTietNghiaVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoChucDanhTietNghiaVuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhTietNghiaVuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoChucDanhTietNghiaVuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoChucDanhTietNghiaVuFilterBuilder
	
	#region HeSoChucDanhTietNghiaVuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoChucDanhTietNghiaVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhTietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhTietNghiaVuParameterBuilder : ParameterizedSqlFilterBuilder<HeSoChucDanhTietNghiaVuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhTietNghiaVuParameterBuilder class.
		/// </summary>
		public HeSoChucDanhTietNghiaVuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhTietNghiaVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoChucDanhTietNghiaVuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhTietNghiaVuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoChucDanhTietNghiaVuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoChucDanhTietNghiaVuParameterBuilder
	
	#region HeSoChucDanhTietNghiaVuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoChucDanhTietNghiaVuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhTietNghiaVu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoChucDanhTietNghiaVuSortBuilder : SqlSortBuilder<HeSoChucDanhTietNghiaVuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhTietNghiaVuSqlSortBuilder class.
		/// </summary>
		public HeSoChucDanhTietNghiaVuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoChucDanhTietNghiaVuSortBuilder
	
} // end namespace
