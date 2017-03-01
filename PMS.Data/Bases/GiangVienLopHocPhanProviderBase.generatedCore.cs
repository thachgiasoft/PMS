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
	/// This class is the base class for any <see cref="GiangVienLopHocPhanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienLopHocPhanProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienLopHocPhan, PMS.Entities.GiangVienLopHocPhanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienLopHocPhanKey key)
		{
			return Delete(transactionManager, key.MaGiangVien, key.MaLopHocPhan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maGiangVien, System.String _maLopHocPhan)
		{
			return Delete(null, _maGiangVien, _maLopHocPhan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _maLopHocPhan);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LopHocPhan_HeSoNgonNgu key.
		///		FK_GiangVien_LopHocPhan_HeSoNgonNgu Description: 
		/// </summary>
		/// <param name="_maHeSoNn"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienLopHocPhan objects.</returns>
		public TList<GiangVienLopHocPhan> GetByMaHeSoNn(System.Int32? _maHeSoNn)
		{
			int count = -1;
			return GetByMaHeSoNn(_maHeSoNn, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LopHocPhan_HeSoNgonNgu key.
		///		FK_GiangVien_LopHocPhan_HeSoNgonNgu Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSoNn"></param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienLopHocPhan objects.</returns>
		/// <remarks></remarks>
		public TList<GiangVienLopHocPhan> GetByMaHeSoNn(TransactionManager transactionManager, System.Int32? _maHeSoNn)
		{
			int count = -1;
			return GetByMaHeSoNn(transactionManager, _maHeSoNn, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LopHocPhan_HeSoNgonNgu key.
		///		FK_GiangVien_LopHocPhan_HeSoNgonNgu Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSoNn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienLopHocPhan objects.</returns>
		public TList<GiangVienLopHocPhan> GetByMaHeSoNn(TransactionManager transactionManager, System.Int32? _maHeSoNn, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSoNn(transactionManager, _maHeSoNn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LopHocPhan_HeSoNgonNgu key.
		///		fkGiangVienLopHocPhanHeSoNgonNgu Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHeSoNn"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienLopHocPhan objects.</returns>
		public TList<GiangVienLopHocPhan> GetByMaHeSoNn(System.Int32? _maHeSoNn, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaHeSoNn(null, _maHeSoNn, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LopHocPhan_HeSoNgonNgu key.
		///		fkGiangVienLopHocPhanHeSoNgonNgu Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maHeSoNn"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienLopHocPhan objects.</returns>
		public TList<GiangVienLopHocPhan> GetByMaHeSoNn(System.Int32? _maHeSoNn, int start, int pageLength,out int count)
		{
			return GetByMaHeSoNn(null, _maHeSoNn, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GiangVien_LopHocPhan_HeSoNgonNgu key.
		///		FK_GiangVien_LopHocPhan_HeSoNgonNgu Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSoNn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.GiangVienLopHocPhan objects.</returns>
		public abstract TList<GiangVienLopHocPhan> GetByMaHeSoNn(TransactionManager transactionManager, System.Int32? _maHeSoNn, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.GiangVienLopHocPhan Get(TransactionManager transactionManager, PMS.Entities.GiangVienLopHocPhanKey key, int start, int pageLength)
		{
			return GetByMaGiangVienMaLopHocPhan(transactionManager, key.MaGiangVien, key.MaLopHocPhan, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiangVien_LopHocPhan index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienLopHocPhan"/> class.</returns>
		public PMS.Entities.GiangVienLopHocPhan GetByMaGiangVienMaLopHocPhan(System.Int32 _maGiangVien, System.String _maLopHocPhan)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhan(null,_maGiangVien, _maLopHocPhan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_LopHocPhan index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienLopHocPhan"/> class.</returns>
		public PMS.Entities.GiangVienLopHocPhan GetByMaGiangVienMaLopHocPhan(System.Int32 _maGiangVien, System.String _maLopHocPhan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhan(null, _maGiangVien, _maLopHocPhan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_LopHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienLopHocPhan"/> class.</returns>
		public PMS.Entities.GiangVienLopHocPhan GetByMaGiangVienMaLopHocPhan(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _maLopHocPhan)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhan(transactionManager, _maGiangVien, _maLopHocPhan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_LopHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienLopHocPhan"/> class.</returns>
		public PMS.Entities.GiangVienLopHocPhan GetByMaGiangVienMaLopHocPhan(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _maLopHocPhan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienMaLopHocPhan(transactionManager, _maGiangVien, _maLopHocPhan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_LopHocPhan index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienLopHocPhan"/> class.</returns>
		public PMS.Entities.GiangVienLopHocPhan GetByMaGiangVienMaLopHocPhan(System.Int32 _maGiangVien, System.String _maLopHocPhan, int start, int pageLength, out int count)
		{
			return GetByMaGiangVienMaLopHocPhan(null, _maGiangVien, _maLopHocPhan, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVien_LopHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienLopHocPhan"/> class.</returns>
		public abstract PMS.Entities.GiangVienLopHocPhan GetByMaGiangVienMaLopHocPhan(TransactionManager transactionManager, System.Int32 _maGiangVien, System.String _maLopHocPhan, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVien_LopHocPhan_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienLopHocPhan&gt;"/> instance.</returns>
		public TList<GiangVienLopHocPhan> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienLopHocPhan&gt;"/> instance.</returns>
		public TList<GiangVienLopHocPhan> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienLopHocPhan&gt;"/> instance.</returns>
		public TList<GiangVienLopHocPhan> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienLopHocPhan&gt;"/> instance.</returns>
		public abstract TList<GiangVienLopHocPhan> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienLopHocPhan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienLopHocPhan&gt;"/></returns>
		public static TList<GiangVienLopHocPhan> Fill(IDataReader reader, TList<GiangVienLopHocPhan> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienLopHocPhan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienLopHocPhan")
					.Append("|").Append((System.Int32)reader[((int)GiangVienLopHocPhanColumn.MaGiangVien - 1)])
					.Append("|").Append((System.String)reader[((int)GiangVienLopHocPhanColumn.MaLopHocPhan - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienLopHocPhan>(
					key.ToString(), // EntityTrackingKey
					"GiangVienLopHocPhan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienLopHocPhan();
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
					c.MaGiangVien = (System.Int32)reader[(GiangVienLopHocPhanColumn.MaGiangVien.ToString())];
					c.OriginalMaGiangVien = c.MaGiangVien;
					c.MaLopHocPhan = (System.String)reader[(GiangVienLopHocPhanColumn.MaLopHocPhan.ToString())];
					c.OriginalMaLopHocPhan = c.MaLopHocPhan;
					c.MaHeSoNn = (reader[GiangVienLopHocPhanColumn.MaHeSoNn.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienLopHocPhanColumn.MaHeSoNn.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienLopHocPhan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienLopHocPhan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienLopHocPhan entity)
		{
			if (!reader.Read()) return;
			
			entity.MaGiangVien = (System.Int32)reader[(GiangVienLopHocPhanColumn.MaGiangVien.ToString())];
			entity.OriginalMaGiangVien = (System.Int32)reader["MaGiangVien"];
			entity.MaLopHocPhan = (System.String)reader[(GiangVienLopHocPhanColumn.MaLopHocPhan.ToString())];
			entity.OriginalMaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			entity.MaHeSoNn = (reader[GiangVienLopHocPhanColumn.MaHeSoNn.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienLopHocPhanColumn.MaHeSoNn.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienLopHocPhan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienLopHocPhan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienLopHocPhan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.OriginalMaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.OriginalMaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.MaHeSoNn = Convert.IsDBNull(dataRow["MaHeSoNN"]) ? null : (System.Int32?)dataRow["MaHeSoNN"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienLopHocPhan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienLopHocPhan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienLopHocPhan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaHeSoNnSource	
			if (CanDeepLoad(entity, "HeSoNgonNgu|MaHeSoNnSource", deepLoadType, innerList) 
				&& entity.MaHeSoNnSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaHeSoNn ?? (int)0);
				HeSoNgonNgu tmpEntity = EntityManager.LocateEntity<HeSoNgonNgu>(EntityLocator.ConstructKeyFromPkItems(typeof(HeSoNgonNgu), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaHeSoNnSource = tmpEntity;
				else
					entity.MaHeSoNnSource = DataRepository.HeSoNgonNguProvider.GetByMaHeSo(transactionManager, (entity.MaHeSoNn ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaHeSoNnSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaHeSoNnSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.HeSoNgonNguProvider.DeepLoad(transactionManager, entity.MaHeSoNnSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaHeSoNnSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienLopHocPhan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienLopHocPhan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienLopHocPhan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienLopHocPhan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaHeSoNnSource
			if (CanDeepSave(entity, "HeSoNgonNgu|MaHeSoNnSource", deepSaveType, innerList) 
				&& entity.MaHeSoNnSource != null)
			{
				DataRepository.HeSoNgonNguProvider.Save(transactionManager, entity.MaHeSoNnSource);
				entity.MaHeSoNn = entity.MaHeSoNnSource.MaHeSo;
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
	
	#region GiangVienLopHocPhanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienLopHocPhan</c>
	///</summary>
	public enum GiangVienLopHocPhanChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>HeSoNgonNgu</c> at MaHeSoNnSource
		///</summary>
		[ChildEntityType(typeof(HeSoNgonNgu))]
		HeSoNgonNgu,
	}
	
	#endregion GiangVienLopHocPhanChildEntityTypes
	
	#region GiangVienLopHocPhanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienLopHocPhanFilterBuilder : SqlFilterBuilder<GiangVienLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienLopHocPhanFilterBuilder class.
		/// </summary>
		public GiangVienLopHocPhanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienLopHocPhanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienLopHocPhanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienLopHocPhanFilterBuilder
	
	#region GiangVienLopHocPhanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienLopHocPhanParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienLopHocPhanParameterBuilder class.
		/// </summary>
		public GiangVienLopHocPhanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienLopHocPhanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienLopHocPhanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienLopHocPhanParameterBuilder
	
	#region GiangVienLopHocPhanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienLopHocPhan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienLopHocPhanSortBuilder : SqlSortBuilder<GiangVienLopHocPhanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienLopHocPhanSqlSortBuilder class.
		/// </summary>
		public GiangVienLopHocPhanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienLopHocPhanSortBuilder
	
} // end namespace
