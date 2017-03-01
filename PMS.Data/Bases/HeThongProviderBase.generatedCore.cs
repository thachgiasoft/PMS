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
	/// This class is the base class for any <see cref="HeThongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeThongProviderBaseCore : EntityProviderBase<PMS.Entities.HeThong, PMS.Entities.HeThongKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeThongKey key)
		{
			return Delete(transactionManager, key.UserId, key.ParentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_userId">. Primary Key.</param>
		/// <param name="_parentId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _userId, System.Int32 _parentId)
		{
			return Delete(null, _userId, _parentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_userId">. Primary Key.</param>
		/// <param name="_parentId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _userId, System.Int32 _parentId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeThong_TaiKhoan key.
		///		FK_HeThong_TaiKhoan Description: 
		/// </summary>
		/// <param name="_userId"></param>
		/// <returns>Returns a typed collection of PMS.Entities.HeThong objects.</returns>
		public TList<HeThong> GetByUserId(System.Int32 _userId)
		{
			int count = -1;
			return GetByUserId(_userId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeThong_TaiKhoan key.
		///		FK_HeThong_TaiKhoan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_userId"></param>
		/// <returns>Returns a typed collection of PMS.Entities.HeThong objects.</returns>
		/// <remarks></remarks>
		public TList<HeThong> GetByUserId(TransactionManager transactionManager, System.Int32 _userId)
		{
			int count = -1;
			return GetByUserId(transactionManager, _userId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeThong_TaiKhoan key.
		///		FK_HeThong_TaiKhoan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_userId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HeThong objects.</returns>
		public TList<HeThong> GetByUserId(TransactionManager transactionManager, System.Int32 _userId, int start, int pageLength)
		{
			int count = -1;
			return GetByUserId(transactionManager, _userId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeThong_TaiKhoan key.
		///		fkHeThongTaiKhoan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_userId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HeThong objects.</returns>
		public TList<HeThong> GetByUserId(System.Int32 _userId, int start, int pageLength)
		{
			int count =  -1;
			return GetByUserId(null, _userId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeThong_TaiKhoan key.
		///		fkHeThongTaiKhoan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_userId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HeThong objects.</returns>
		public TList<HeThong> GetByUserId(System.Int32 _userId, int start, int pageLength,out int count)
		{
			return GetByUserId(null, _userId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeThong_TaiKhoan key.
		///		FK_HeThong_TaiKhoan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_userId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.HeThong objects.</returns>
		public abstract TList<HeThong> GetByUserId(TransactionManager transactionManager, System.Int32 _userId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeThong_TaiKhoan1 key.
		///		FK_HeThong_TaiKhoan1 Description: 
		/// </summary>
		/// <param name="_parentId"></param>
		/// <returns>Returns a typed collection of PMS.Entities.HeThong objects.</returns>
		public TList<HeThong> GetByParentId(System.Int32 _parentId)
		{
			int count = -1;
			return GetByParentId(_parentId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeThong_TaiKhoan1 key.
		///		FK_HeThong_TaiKhoan1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parentId"></param>
		/// <returns>Returns a typed collection of PMS.Entities.HeThong objects.</returns>
		/// <remarks></remarks>
		public TList<HeThong> GetByParentId(TransactionManager transactionManager, System.Int32 _parentId)
		{
			int count = -1;
			return GetByParentId(transactionManager, _parentId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeThong_TaiKhoan1 key.
		///		FK_HeThong_TaiKhoan1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HeThong objects.</returns>
		public TList<HeThong> GetByParentId(TransactionManager transactionManager, System.Int32 _parentId, int start, int pageLength)
		{
			int count = -1;
			return GetByParentId(transactionManager, _parentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeThong_TaiKhoan1 key.
		///		fkHeThongTaiKhoan1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_parentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HeThong objects.</returns>
		public TList<HeThong> GetByParentId(System.Int32 _parentId, int start, int pageLength)
		{
			int count =  -1;
			return GetByParentId(null, _parentId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeThong_TaiKhoan1 key.
		///		fkHeThongTaiKhoan1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_parentId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HeThong objects.</returns>
		public TList<HeThong> GetByParentId(System.Int32 _parentId, int start, int pageLength,out int count)
		{
			return GetByParentId(null, _parentId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HeThong_TaiKhoan1 key.
		///		FK_HeThong_TaiKhoan1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.HeThong objects.</returns>
		public abstract TList<HeThong> GetByParentId(TransactionManager transactionManager, System.Int32 _parentId, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.HeThong Get(TransactionManager transactionManager, PMS.Entities.HeThongKey key, int start, int pageLength)
		{
			return GetByUserIdParentId(transactionManager, key.UserId, key.ParentId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeThong index.
		/// </summary>
		/// <param name="_userId"></param>
		/// <param name="_parentId"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeThong"/> class.</returns>
		public PMS.Entities.HeThong GetByUserIdParentId(System.Int32 _userId, System.Int32 _parentId)
		{
			int count = -1;
			return GetByUserIdParentId(null,_userId, _parentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeThong index.
		/// </summary>
		/// <param name="_userId"></param>
		/// <param name="_parentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeThong"/> class.</returns>
		public PMS.Entities.HeThong GetByUserIdParentId(System.Int32 _userId, System.Int32 _parentId, int start, int pageLength)
		{
			int count = -1;
			return GetByUserIdParentId(null, _userId, _parentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeThong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_userId"></param>
		/// <param name="_parentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeThong"/> class.</returns>
		public PMS.Entities.HeThong GetByUserIdParentId(TransactionManager transactionManager, System.Int32 _userId, System.Int32 _parentId)
		{
			int count = -1;
			return GetByUserIdParentId(transactionManager, _userId, _parentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeThong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_userId"></param>
		/// <param name="_parentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeThong"/> class.</returns>
		public PMS.Entities.HeThong GetByUserIdParentId(TransactionManager transactionManager, System.Int32 _userId, System.Int32 _parentId, int start, int pageLength)
		{
			int count = -1;
			return GetByUserIdParentId(transactionManager, _userId, _parentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeThong index.
		/// </summary>
		/// <param name="_userId"></param>
		/// <param name="_parentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeThong"/> class.</returns>
		public PMS.Entities.HeThong GetByUserIdParentId(System.Int32 _userId, System.Int32 _parentId, int start, int pageLength, out int count)
		{
			return GetByUserIdParentId(null, _userId, _parentId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeThong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_userId"></param>
		/// <param name="_parentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeThong"/> class.</returns>
		public abstract PMS.Entities.HeThong GetByUserIdParentId(TransactionManager transactionManager, System.Int32 _userId, System.Int32 _parentId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeThong&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeThong&gt;"/></returns>
		public static TList<HeThong> Fill(IDataReader reader, TList<HeThong> rows, int start, int pageLength)
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
				
				PMS.Entities.HeThong c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeThong")
					.Append("|").Append((System.Int32)reader[((int)HeThongColumn.UserId - 1)])
					.Append("|").Append((System.Int32)reader[((int)HeThongColumn.ParentId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeThong>(
					key.ToString(), // EntityTrackingKey
					"HeThong",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeThong();
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
					c.UserId = (System.Int32)reader[(HeThongColumn.UserId.ToString())];
					c.OriginalUserId = c.UserId;
					c.ParentId = (System.Int32)reader[(HeThongColumn.ParentId.ToString())];
					c.OriginalParentId = c.ParentId;
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeThong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeThong"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeThong entity)
		{
			if (!reader.Read()) return;
			
			entity.UserId = (System.Int32)reader[(HeThongColumn.UserId.ToString())];
			entity.OriginalUserId = (System.Int32)reader["UserID"];
			entity.ParentId = (System.Int32)reader[(HeThongColumn.ParentId.ToString())];
			entity.OriginalParentId = (System.Int32)reader["ParentID"];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeThong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeThong"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeThong entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.UserId = (System.Int32)dataRow["UserID"];
			entity.OriginalUserId = (System.Int32)dataRow["UserID"];
			entity.ParentId = (System.Int32)dataRow["ParentID"];
			entity.OriginalParentId = (System.Int32)dataRow["ParentID"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeThong"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeThong Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeThong entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region UserIdSource	
			if (CanDeepLoad(entity, "TaiKhoan|UserIdSource", deepLoadType, innerList) 
				&& entity.UserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.UserId;
				TaiKhoan tmpEntity = EntityManager.LocateEntity<TaiKhoan>(EntityLocator.ConstructKeyFromPkItems(typeof(TaiKhoan), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.UserIdSource = tmpEntity;
				else
					entity.UserIdSource = DataRepository.TaiKhoanProvider.GetByMaTaiKhoan(transactionManager, entity.UserId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'UserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.UserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TaiKhoanProvider.DeepLoad(transactionManager, entity.UserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion UserIdSource

			#region ParentIdSource	
			if (CanDeepLoad(entity, "TaiKhoan|ParentIdSource", deepLoadType, innerList) 
				&& entity.ParentIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ParentId;
				TaiKhoan tmpEntity = EntityManager.LocateEntity<TaiKhoan>(EntityLocator.ConstructKeyFromPkItems(typeof(TaiKhoan), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ParentIdSource = tmpEntity;
				else
					entity.ParentIdSource = DataRepository.TaiKhoanProvider.GetByMaTaiKhoan(transactionManager, entity.ParentId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ParentIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ParentIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TaiKhoanProvider.DeepLoad(transactionManager, entity.ParentIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ParentIdSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.HeThong object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeThong instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeThong Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeThong entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region UserIdSource
			if (CanDeepSave(entity, "TaiKhoan|UserIdSource", deepSaveType, innerList) 
				&& entity.UserIdSource != null)
			{
				DataRepository.TaiKhoanProvider.Save(transactionManager, entity.UserIdSource);
				entity.UserId = entity.UserIdSource.MaTaiKhoan;
			}
			#endregion 
			
			#region ParentIdSource
			if (CanDeepSave(entity, "TaiKhoan|ParentIdSource", deepSaveType, innerList) 
				&& entity.ParentIdSource != null)
			{
				DataRepository.TaiKhoanProvider.Save(transactionManager, entity.ParentIdSource);
				entity.ParentId = entity.ParentIdSource.MaTaiKhoan;
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
	
	#region HeThongChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeThong</c>
	///</summary>
	public enum HeThongChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>TaiKhoan</c> at UserIdSource
		///</summary>
		[ChildEntityType(typeof(TaiKhoan))]
		TaiKhoan,
	}
	
	#endregion HeThongChildEntityTypes
	
	#region HeThongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeThongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeThong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeThongFilterBuilder : SqlFilterBuilder<HeThongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeThongFilterBuilder class.
		/// </summary>
		public HeThongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeThongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeThongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeThongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeThongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeThongFilterBuilder
	
	#region HeThongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeThongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeThong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeThongParameterBuilder : ParameterizedSqlFilterBuilder<HeThongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeThongParameterBuilder class.
		/// </summary>
		public HeThongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeThongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeThongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeThongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeThongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeThongParameterBuilder
	
	#region HeThongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeThongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeThong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeThongSortBuilder : SqlSortBuilder<HeThongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeThongSqlSortBuilder class.
		/// </summary>
		public HeThongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeThongSortBuilder
	
} // end namespace
