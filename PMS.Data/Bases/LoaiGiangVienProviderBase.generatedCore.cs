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
	/// This class is the base class for any <see cref="LoaiGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LoaiGiangVienProviderBaseCore : EntityProviderBase<PMS.Entities.LoaiGiangVien, PMS.Entities.LoaiGiangVienKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.LoaiGiangVienKey key)
		{
			return Delete(transactionManager, key.MaLoaiGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLoaiGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maLoaiGiangVien)
		{
			return Delete(null, _maLoaiGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maLoaiGiangVien);		
		
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
		public override PMS.Entities.LoaiGiangVien Get(TransactionManager transactionManager, PMS.Entities.LoaiGiangVienKey key, int start, int pageLength)
		{
			return GetByMaLoaiGiangVien(transactionManager, key.MaLoaiGiangVien, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_LoaiGiangVien index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiGiangVien"/> class.</returns>
		public PMS.Entities.LoaiGiangVien GetByMaQuanLy(System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_LoaiGiangVien index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiGiangVien"/> class.</returns>
		public PMS.Entities.LoaiGiangVien GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_LoaiGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiGiangVien"/> class.</returns>
		public PMS.Entities.LoaiGiangVien GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_LoaiGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiGiangVien"/> class.</returns>
		public PMS.Entities.LoaiGiangVien GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_LoaiGiangVien index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiGiangVien"/> class.</returns>
		public PMS.Entities.LoaiGiangVien GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_LoaiGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiGiangVien"/> class.</returns>
		public abstract PMS.Entities.LoaiGiangVien GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_LoaiGiangVien index.
		/// </summary>
		/// <param name="_maLoaiGiangVien"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiGiangVien"/> class.</returns>
		public PMS.Entities.LoaiGiangVien GetByMaLoaiGiangVien(System.Int32 _maLoaiGiangVien)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(null,_maLoaiGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiGiangVien index.
		/// </summary>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiGiangVien"/> class.</returns>
		public PMS.Entities.LoaiGiangVien GetByMaLoaiGiangVien(System.Int32 _maLoaiGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(null, _maLoaiGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiGiangVien"/> class.</returns>
		public PMS.Entities.LoaiGiangVien GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32 _maLoaiGiangVien)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(transactionManager, _maLoaiGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiGiangVien"/> class.</returns>
		public PMS.Entities.LoaiGiangVien GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32 _maLoaiGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiGiangVien(transactionManager, _maLoaiGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiGiangVien index.
		/// </summary>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiGiangVien"/> class.</returns>
		public PMS.Entities.LoaiGiangVien GetByMaLoaiGiangVien(System.Int32 _maLoaiGiangVien, int start, int pageLength, out int count)
		{
			return GetByMaLoaiGiangVien(null, _maLoaiGiangVien, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiGiangVien"/> class.</returns>
		public abstract PMS.Entities.LoaiGiangVien GetByMaLoaiGiangVien(TransactionManager transactionManager, System.Int32 _maLoaiGiangVien, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_LoaiGiangVien_LayLoaiGiangVienThongKe 
		
		/// <summary>
		///	This method wrap the 'cust_LoaiGiangVien_LayLoaiGiangVienThongKe' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;LoaiGiangVien&gt;"/> instance.</returns>
		public TList<LoaiGiangVien> LayLoaiGiangVienThongKe()
		{
			return LayLoaiGiangVienThongKe(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_LoaiGiangVien_LayLoaiGiangVienThongKe' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;LoaiGiangVien&gt;"/> instance.</returns>
		public TList<LoaiGiangVien> LayLoaiGiangVienThongKe(int start, int pageLength)
		{
			return LayLoaiGiangVienThongKe(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_LoaiGiangVien_LayLoaiGiangVienThongKe' stored procedure. 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;LoaiGiangVien&gt;"/> instance.</returns>
		public TList<LoaiGiangVien> LayLoaiGiangVienThongKe(TransactionManager transactionManager)
		{
			return LayLoaiGiangVienThongKe(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_LoaiGiangVien_LayLoaiGiangVienThongKe' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;LoaiGiangVien&gt;"/> instance.</returns>
		public abstract TList<LoaiGiangVien> LayLoaiGiangVienThongKe(TransactionManager transactionManager, int start, int pageLength );
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LoaiGiangVien&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LoaiGiangVien&gt;"/></returns>
		public static TList<LoaiGiangVien> Fill(IDataReader reader, TList<LoaiGiangVien> rows, int start, int pageLength)
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
				
				PMS.Entities.LoaiGiangVien c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LoaiGiangVien")
					.Append("|").Append((System.Int32)reader[((int)LoaiGiangVienColumn.MaLoaiGiangVien - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LoaiGiangVien>(
					key.ToString(), // EntityTrackingKey
					"LoaiGiangVien",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.LoaiGiangVien();
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
					c.MaLoaiGiangVien = (System.Int32)reader[(LoaiGiangVienColumn.MaLoaiGiangVien.ToString())];
					c.MaQuanLy = (System.String)reader[(LoaiGiangVienColumn.MaQuanLy.ToString())];
					c.TenLoaiGiangVien = (reader[LoaiGiangVienColumn.TenLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiGiangVienColumn.TenLoaiGiangVien.ToString())];
					c.TienThem = (reader[LoaiGiangVienColumn.TienThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(LoaiGiangVienColumn.TienThem.ToString())];
					c.ThuTu = (reader[LoaiGiangVienColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(LoaiGiangVienColumn.ThuTu.ToString())];
					c.Hrmid = (reader[LoaiGiangVienColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(LoaiGiangVienColumn.Hrmid.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiGiangVien"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.LoaiGiangVien entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLoaiGiangVien = (System.Int32)reader[(LoaiGiangVienColumn.MaLoaiGiangVien.ToString())];
			entity.MaQuanLy = (System.String)reader[(LoaiGiangVienColumn.MaQuanLy.ToString())];
			entity.TenLoaiGiangVien = (reader[LoaiGiangVienColumn.TenLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiGiangVienColumn.TenLoaiGiangVien.ToString())];
			entity.TienThem = (reader[LoaiGiangVienColumn.TienThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(LoaiGiangVienColumn.TienThem.ToString())];
			entity.ThuTu = (reader[LoaiGiangVienColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(LoaiGiangVienColumn.ThuTu.ToString())];
			entity.Hrmid = (reader[LoaiGiangVienColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(LoaiGiangVienColumn.Hrmid.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiGiangVien"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.LoaiGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLoaiGiangVien = (System.Int32)dataRow["MaLoaiGiangVien"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenLoaiGiangVien = Convert.IsDBNull(dataRow["TenLoaiGiangVien"]) ? null : (System.String)dataRow["TenLoaiGiangVien"];
			entity.TienThem = Convert.IsDBNull(dataRow["TienThem"]) ? null : (System.Decimal?)dataRow["TienThem"];
			entity.ThuTu = Convert.IsDBNull(dataRow["ThuTu"]) ? null : (System.Int32?)dataRow["ThuTu"];
			entity.Hrmid = Convert.IsDBNull(dataRow["HRMID"]) ? null : (System.Guid?)dataRow["HRMID"];
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
		/// <param name="entity">The <see cref="PMS.Entities.LoaiGiangVien"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.LoaiGiangVien Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.LoaiGiangVien entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaLoaiGiangVien methods when available
			
			#region QuyDinhTienCanTrenCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<QuyDinhTienCanTren>|QuyDinhTienCanTrenCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'QuyDinhTienCanTrenCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.QuyDinhTienCanTrenCollection = DataRepository.QuyDinhTienCanTrenProvider.GetByMaLoaiGiangVien(transactionManager, entity.MaLoaiGiangVien);

				if (deep && entity.QuyDinhTienCanTrenCollection.Count > 0)
				{
					deepHandles.Add("QuyDinhTienCanTrenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<QuyDinhTienCanTren>) DataRepository.QuyDinhTienCanTrenProvider.DeepLoad,
						new object[] { transactionManager, entity.QuyDinhTienCanTrenCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region DonGiaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<DonGia>|DonGiaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'DonGiaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.DonGiaCollection = DataRepository.DonGiaProvider.GetByMaLoaiGiangVien(transactionManager, entity.MaLoaiGiangVien);

				if (deep && entity.DonGiaCollection.Count > 0)
				{
					deepHandles.Add("DonGiaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<DonGia>) DataRepository.DonGiaProvider.DeepLoad,
						new object[] { transactionManager, entity.DonGiaCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GiangVienCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVien>|GiangVienCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienCollection = DataRepository.GiangVienProvider.GetByMaLoaiGiangVien(transactionManager, entity.MaLoaiGiangVien);

				if (deep && entity.GiangVienCollection.Count > 0)
				{
					deepHandles.Add("GiangVienCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVien>) DataRepository.GiangVienProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.LoaiGiangVien object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.LoaiGiangVien instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.LoaiGiangVien Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.LoaiGiangVien entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<QuyDinhTienCanTren>
				if (CanDeepSave(entity.QuyDinhTienCanTrenCollection, "List<QuyDinhTienCanTren>|QuyDinhTienCanTrenCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(QuyDinhTienCanTren child in entity.QuyDinhTienCanTrenCollection)
					{
						if(child.MaLoaiGiangVienSource != null)
						{
							child.MaLoaiGiangVien = child.MaLoaiGiangVienSource.MaLoaiGiangVien;
						}
						else
						{
							child.MaLoaiGiangVien = entity.MaLoaiGiangVien;
						}

					}

					if (entity.QuyDinhTienCanTrenCollection.Count > 0 || entity.QuyDinhTienCanTrenCollection.DeletedItems.Count > 0)
					{
						//DataRepository.QuyDinhTienCanTrenProvider.Save(transactionManager, entity.QuyDinhTienCanTrenCollection);
						
						deepHandles.Add("QuyDinhTienCanTrenCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< QuyDinhTienCanTren >) DataRepository.QuyDinhTienCanTrenProvider.DeepSave,
							new object[] { transactionManager, entity.QuyDinhTienCanTrenCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<DonGia>
				if (CanDeepSave(entity.DonGiaCollection, "List<DonGia>|DonGiaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(DonGia child in entity.DonGiaCollection)
					{
						if(child.MaLoaiGiangVienSource != null)
						{
							child.MaLoaiGiangVien = child.MaLoaiGiangVienSource.MaLoaiGiangVien;
						}
						else
						{
							child.MaLoaiGiangVien = entity.MaLoaiGiangVien;
						}

					}

					if (entity.DonGiaCollection.Count > 0 || entity.DonGiaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.DonGiaProvider.Save(transactionManager, entity.DonGiaCollection);
						
						deepHandles.Add("DonGiaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< DonGia >) DataRepository.DonGiaProvider.DeepSave,
							new object[] { transactionManager, entity.DonGiaCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GiangVien>
				if (CanDeepSave(entity.GiangVienCollection, "List<GiangVien>|GiangVienCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVien child in entity.GiangVienCollection)
					{
						if(child.MaLoaiGiangVienSource != null)
						{
							child.MaLoaiGiangVien = child.MaLoaiGiangVienSource.MaLoaiGiangVien;
						}
						else
						{
							child.MaLoaiGiangVien = entity.MaLoaiGiangVien;
						}

					}

					if (entity.GiangVienCollection.Count > 0 || entity.GiangVienCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienProvider.Save(transactionManager, entity.GiangVienCollection);
						
						deepHandles.Add("GiangVienCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVien >) DataRepository.GiangVienProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienCollection, deepSaveType, childTypes, innerList }
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
	
	#region LoaiGiangVienChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.LoaiGiangVien</c>
	///</summary>
	public enum LoaiGiangVienChildEntityTypes
	{
		///<summary>
		/// Collection of <c>LoaiGiangVien</c> as OneToMany for QuyDinhTienCanTrenCollection
		///</summary>
		[ChildEntityType(typeof(TList<QuyDinhTienCanTren>))]
		QuyDinhTienCanTrenCollection,
		///<summary>
		/// Collection of <c>LoaiGiangVien</c> as OneToMany for DonGiaCollection
		///</summary>
		[ChildEntityType(typeof(TList<DonGia>))]
		DonGiaCollection,
		///<summary>
		/// Collection of <c>LoaiGiangVien</c> as OneToMany for GiangVienCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVien>))]
		GiangVienCollection,
	}
	
	#endregion LoaiGiangVienChildEntityTypes
	
	#region LoaiGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LoaiGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiGiangVienFilterBuilder : SqlFilterBuilder<LoaiGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiGiangVienFilterBuilder class.
		/// </summary>
		public LoaiGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiGiangVienFilterBuilder
	
	#region LoaiGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LoaiGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<LoaiGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiGiangVienParameterBuilder class.
		/// </summary>
		public LoaiGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiGiangVienParameterBuilder
	
	#region LoaiGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LoaiGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LoaiGiangVienSortBuilder : SqlSortBuilder<LoaiGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiGiangVienSqlSortBuilder class.
		/// </summary>
		public LoaiGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LoaiGiangVienSortBuilder
	
} // end namespace
