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
	/// This class is the base class for any <see cref="GiangVienGiamTruDinhMucProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienGiamTruDinhMucProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienGiamTruDinhMuc, PMS.Entities.GiangVienGiamTruDinhMucKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienGiamTruDinhMucKey key)
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
		/// 	Gets rows from the datasource based on the FK_GiangVien_GiamTruDinhMuc_GiamTruDinhMuc key.
		///		FK_GiangVien_GiamTruDinhMuc_GiamTruDinhMuc Description: 
		/// </summary>
		/// <param name="_maGiamTru"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienGiamTruDinhMuc objects.</returns>
		public TList<GiangVienGiamTruDinhMuc> GetByMaGiamTru(System.Int32? _maGiamTru)
		{
			int count = -1;
			return GetByMaGiamTru(_maGiamTru, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_GiamTruDinhMuc_GiamTruDinhMuc key.
		///		FK_GiangVien_GiamTruDinhMuc_GiamTruDinhMuc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiamTru"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienGiamTruDinhMuc objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienGiamTruDinhMuc> GetByMaGiamTru(TransactionManager transactionManager, System.Int32? _maGiamTru)
		{
			int count = -1;
			return GetByMaGiamTru(transactionManager, _maGiamTru, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_GiamTruDinhMuc_GiamTruDinhMuc key.
		///		FK_GiangVien_GiamTruDinhMuc_GiamTruDinhMuc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiamTru"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienGiamTruDinhMuc objects.</returns>
		public TList<GiangVienGiamTruDinhMuc> GetByMaGiamTru(TransactionManager transactionManager, System.Int32? _maGiamTru, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiamTru(transactionManager, _maGiamTru, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_GiamTruDinhMuc_GiamTruDinhMuc key.
		///		fkGiangVienGiamTruDinhMucGiamTruDinhMuc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiamTru"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienGiamTruDinhMuc objects.</returns>
		public TList<GiangVienGiamTruDinhMuc> GetByMaGiamTru(System.Int32? _maGiamTru, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiamTru(null, _maGiamTru, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_GiamTruDinhMuc_GiamTruDinhMuc key.
		///		fkGiangVienGiamTruDinhMucGiamTruDinhMuc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiamTru"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienGiamTruDinhMuc objects.</returns>
		public TList<GiangVienGiamTruDinhMuc> GetByMaGiamTru(System.Int32? _maGiamTru, int start, int pageLength,out int count)
		{
			return GetByMaGiamTru(null, _maGiamTru, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_GiamTruDinhMuc_GiamTruDinhMuc key.
		///		FK_GiangVien_GiamTruDinhMuc_GiamTruDinhMuc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiamTru"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienGiamTruDinhMuc objects.</returns>
		public abstract TList<GiangVienGiamTruDinhMuc> GetByMaGiamTru(TransactionManager transactionManager, System.Int32? _maGiamTru, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_GiamTruDinhMuc_GiangVien key.
		///		FK_GiangVien_GiamTruDinhMuc_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienGiamTruDinhMuc objects.</returns>
		public TList<GiangVienGiamTruDinhMuc> GetByMaGiangVien(System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_GiamTruDinhMuc_GiangVien key.
		///		FK_GiangVien_GiamTruDinhMuc_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienGiamTruDinhMuc objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienGiamTruDinhMuc> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_GiamTruDinhMuc_GiangVien key.
		///		FK_GiangVien_GiamTruDinhMuc_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienGiamTruDinhMuc objects.</returns>
		public TList<GiangVienGiamTruDinhMuc> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_GiamTruDinhMuc_GiangVien key.
		///		fkGiangVienGiamTruDinhMucGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienGiamTruDinhMuc objects.</returns>
		public TList<GiangVienGiamTruDinhMuc> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_GiamTruDinhMuc_GiangVien key.
		///		fkGiangVienGiamTruDinhMucGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienGiamTruDinhMuc objects.</returns>
		public TList<GiangVienGiamTruDinhMuc> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_GiamTruDinhMuc_GiangVien key.
		///		FK_GiangVien_GiamTruDinhMuc_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienGiamTruDinhMuc objects.</returns>
		public abstract TList<GiangVienGiamTruDinhMuc> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.GiangVienGiamTruDinhMuc Get(TransactionManager transactionManager, PMS.Entities.GiangVienGiamTruDinhMucKey key, int start, int pageLength)
		{
			return GetByMaQuanLy(transactionManager, key.MaQuanLy, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiangVien_GiamTruDinhMuc index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienGiamTruDinhMuc"/> class.</returns>
		public PMS.Entities.GiangVienGiamTruDinhMuc GetByMaQuanLy(System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_GiamTruDinhMuc index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienGiamTruDinhMuc"/> class.</returns>
		public PMS.Entities.GiangVienGiamTruDinhMuc GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_GiamTruDinhMuc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienGiamTruDinhMuc"/> class.</returns>
		public PMS.Entities.GiangVienGiamTruDinhMuc GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_GiamTruDinhMuc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienGiamTruDinhMuc"/> class.</returns>
		public PMS.Entities.GiangVienGiamTruDinhMuc GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_GiamTruDinhMuc index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienGiamTruDinhMuc"/> class.</returns>
		public PMS.Entities.GiangVienGiamTruDinhMuc GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_GiamTruDinhMuc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienGiamTruDinhMuc"/> class.</returns>
		public abstract PMS.Entities.GiangVienGiamTruDinhMuc GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVien_GiamTruDinhMuc_GetByNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GiamTruDinhMuc_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienGiamTruDinhMuc&gt;"/> instance.</returns>
		public TList<GiangVienGiamTruDinhMuc> GetByNamHoc(System.String namHoc)
		{
			return GetByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GiamTruDinhMuc_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienGiamTruDinhMuc&gt;"/> instance.</returns>
		public TList<GiangVienGiamTruDinhMuc> GetByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return GetByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GiamTruDinhMuc_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienGiamTruDinhMuc&gt;"/> instance.</returns>
		public TList<GiangVienGiamTruDinhMuc> GetByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return GetByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_GiamTruDinhMuc_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienGiamTruDinhMuc&gt;"/> instance.</returns>
		public abstract TList<GiangVienGiamTruDinhMuc> GetByNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienGiamTruDinhMuc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienGiamTruDinhMuc&gt;"/></returns>
		public static TList<GiangVienGiamTruDinhMuc> Fill(IDataReader reader, TList<GiangVienGiamTruDinhMuc> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienGiamTruDinhMuc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienGiamTruDinhMuc")
					.Append("|").Append((System.Int32)reader[((int)GiangVienGiamTruDinhMucColumn.MaQuanLy - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienGiamTruDinhMuc>(
					key.ToString(), // EntityTrackingKey
					"GiangVienGiamTruDinhMuc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienGiamTruDinhMuc();
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
					c.MaQuanLy = (System.Int32)reader[(GiangVienGiamTruDinhMucColumn.MaQuanLy.ToString())];
					c.NamHoc = (reader[GiangVienGiamTruDinhMucColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienGiamTruDinhMucColumn.NamHoc.ToString())];
					c.HocKy = (reader[GiangVienGiamTruDinhMucColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienGiamTruDinhMucColumn.HocKy.ToString())];
					c.MaGiangVien = (reader[GiangVienGiamTruDinhMucColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienGiamTruDinhMucColumn.MaGiangVien.ToString())];
					c.MaGiamTru = (reader[GiangVienGiamTruDinhMucColumn.MaGiamTru.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienGiamTruDinhMucColumn.MaGiamTru.ToString())];
					c.PhanTramGiamTru = (reader[GiangVienGiamTruDinhMucColumn.PhanTramGiamTru.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienGiamTruDinhMucColumn.PhanTramGiamTru.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienGiamTruDinhMuc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienGiamTruDinhMuc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienGiamTruDinhMuc entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuanLy = (System.Int32)reader[(GiangVienGiamTruDinhMucColumn.MaQuanLy.ToString())];
			entity.NamHoc = (reader[GiangVienGiamTruDinhMucColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienGiamTruDinhMucColumn.NamHoc.ToString())];
			entity.HocKy = (reader[GiangVienGiamTruDinhMucColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienGiamTruDinhMucColumn.HocKy.ToString())];
			entity.MaGiangVien = (reader[GiangVienGiamTruDinhMucColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienGiamTruDinhMucColumn.MaGiangVien.ToString())];
			entity.MaGiamTru = (reader[GiangVienGiamTruDinhMucColumn.MaGiamTru.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienGiamTruDinhMucColumn.MaGiamTru.ToString())];
			entity.PhanTramGiamTru = (reader[GiangVienGiamTruDinhMucColumn.PhanTramGiamTru.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienGiamTruDinhMucColumn.PhanTramGiamTru.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienGiamTruDinhMuc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienGiamTruDinhMuc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienGiamTruDinhMuc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (System.Int32)dataRow["MaQuanLy"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaGiamTru = Convert.IsDBNull(dataRow["MaGiamTru"]) ? null : (System.Int32?)dataRow["MaGiamTru"];
			entity.PhanTramGiamTru = Convert.IsDBNull(dataRow["PhanTramGiamTru"]) ? null : (System.Int32?)dataRow["PhanTramGiamTru"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienGiamTruDinhMuc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienGiamTruDinhMuc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienGiamTruDinhMuc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaGiamTruSource	
			if (CanDeepLoad(entity, "GiamTruDinhMuc|MaGiamTruSource", deepLoadType, innerList) 
				&& entity.MaGiamTruSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaGiamTru ?? (int)0);
				GiamTruDinhMuc tmpEntity = EntityManager.LocateEntity<GiamTruDinhMuc>(EntityLocator.ConstructKeyFromPkItems(typeof(GiamTruDinhMuc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaGiamTruSource = tmpEntity;
				else
					entity.MaGiamTruSource = DataRepository.GiamTruDinhMucProvider.GetByMaQuanLy(transactionManager, (entity.MaGiamTru ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaGiamTruSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaGiamTruSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GiamTruDinhMucProvider.DeepLoad(transactionManager, entity.MaGiamTruSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaGiamTruSource

			#region MaGiangVienSource	
			if (CanDeepLoad(entity, "GiangVien|MaGiangVienSource", deepLoadType, innerList) 
				&& entity.MaGiangVienSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaGiangVien ?? (int)0);
				GiangVien tmpEntity = EntityManager.LocateEntity<GiangVien>(EntityLocator.ConstructKeyFromPkItems(typeof(GiangVien), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaGiangVienSource = tmpEntity;
				else
					entity.MaGiangVienSource = DataRepository.GiangVienProvider.GetByMaGiangVien(transactionManager, (entity.MaGiangVien ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaGiangVienSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaGiangVienSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GiangVienProvider.DeepLoad(transactionManager, entity.MaGiangVienSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaGiangVienSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienGiamTruDinhMuc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienGiamTruDinhMuc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienGiamTruDinhMuc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienGiamTruDinhMuc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaGiamTruSource
			if (CanDeepSave(entity, "GiamTruDinhMuc|MaGiamTruSource", deepSaveType, innerList) 
				&& entity.MaGiamTruSource != null)
			{
				DataRepository.GiamTruDinhMucProvider.Save(transactionManager, entity.MaGiamTruSource);
				entity.MaGiamTru = entity.MaGiamTruSource.MaQuanLy;
			}
			#endregion 
			
			#region MaGiangVienSource
			if (CanDeepSave(entity, "GiangVien|MaGiangVienSource", deepSaveType, innerList) 
				&& entity.MaGiangVienSource != null)
			{
				DataRepository.GiangVienProvider.Save(transactionManager, entity.MaGiangVienSource);
				entity.MaGiangVien = entity.MaGiangVienSource.MaGiangVien;
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
	
	#region GiangVienGiamTruDinhMucChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienGiamTruDinhMuc</c>
	///</summary>
	public enum GiangVienGiamTruDinhMucChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiamTruDinhMuc</c> at MaGiamTruSource
		///</summary>
		[ChildEntityType(typeof(GiamTruDinhMuc))]
		GiamTruDinhMuc,
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
	}
	
	#endregion GiangVienGiamTruDinhMucChildEntityTypes
	
	#region GiangVienGiamTruDinhMucFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienGiamTruDinhMucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienGiamTruDinhMuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienGiamTruDinhMucFilterBuilder : SqlFilterBuilder<GiangVienGiamTruDinhMucColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienGiamTruDinhMucFilterBuilder class.
		/// </summary>
		public GiangVienGiamTruDinhMucFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienGiamTruDinhMucFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienGiamTruDinhMucFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienGiamTruDinhMucFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienGiamTruDinhMucFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienGiamTruDinhMucFilterBuilder
	
	#region GiangVienGiamTruDinhMucParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienGiamTruDinhMucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienGiamTruDinhMuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienGiamTruDinhMucParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienGiamTruDinhMucColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienGiamTruDinhMucParameterBuilder class.
		/// </summary>
		public GiangVienGiamTruDinhMucParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienGiamTruDinhMucParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienGiamTruDinhMucParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienGiamTruDinhMucParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienGiamTruDinhMucParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienGiamTruDinhMucParameterBuilder
	
	#region GiangVienGiamTruDinhMucSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienGiamTruDinhMucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienGiamTruDinhMuc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienGiamTruDinhMucSortBuilder : SqlSortBuilder<GiangVienGiamTruDinhMucColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienGiamTruDinhMucSqlSortBuilder class.
		/// </summary>
		public GiangVienGiamTruDinhMucSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienGiamTruDinhMucSortBuilder
	
} // end namespace
