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
	/// This class is the base class for any <see cref="DanhMucHoatDongQuanLyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DanhMucHoatDongQuanLyProviderBaseCore : EntityProviderBase<PMS.Entities.DanhMucHoatDongQuanLy, PMS.Entities.DanhMucHoatDongQuanLyKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DanhMucHoatDongQuanLyKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _id)
		{
			return Delete(null, _id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _id);		
		
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
		public override PMS.Entities.DanhMucHoatDongQuanLy Get(TransactionManager transactionManager, PMS.Entities.DanhMucHoatDongQuanLyKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__DanhMucH__3214EC07FF8B9A1A index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucHoatDongQuanLy"/> class.</returns>
		public PMS.Entities.DanhMucHoatDongQuanLy GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DanhMucH__3214EC07FF8B9A1A index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucHoatDongQuanLy"/> class.</returns>
		public PMS.Entities.DanhMucHoatDongQuanLy GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DanhMucH__3214EC07FF8B9A1A index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucHoatDongQuanLy"/> class.</returns>
		public PMS.Entities.DanhMucHoatDongQuanLy GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DanhMucH__3214EC07FF8B9A1A index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucHoatDongQuanLy"/> class.</returns>
		public PMS.Entities.DanhMucHoatDongQuanLy GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DanhMucH__3214EC07FF8B9A1A index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucHoatDongQuanLy"/> class.</returns>
		public PMS.Entities.DanhMucHoatDongQuanLy GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DanhMucH__3214EC07FF8B9A1A index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucHoatDongQuanLy"/> class.</returns>
		public abstract PMS.Entities.DanhMucHoatDongQuanLy GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DanhMucHoatDongQuanLy&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DanhMucHoatDongQuanLy&gt;"/></returns>
		public static TList<DanhMucHoatDongQuanLy> Fill(IDataReader reader, TList<DanhMucHoatDongQuanLy> rows, int start, int pageLength)
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
				
				PMS.Entities.DanhMucHoatDongQuanLy c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DanhMucHoatDongQuanLy")
					.Append("|").Append((System.Int32)reader[((int)DanhMucHoatDongQuanLyColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DanhMucHoatDongQuanLy>(
					key.ToString(), // EntityTrackingKey
					"DanhMucHoatDongQuanLy",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DanhMucHoatDongQuanLy();
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
					c.Id = (System.Int32)reader[(DanhMucHoatDongQuanLyColumn.Id.ToString())];
					c.MaHoatDong = (reader[DanhMucHoatDongQuanLyColumn.MaHoatDong.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucHoatDongQuanLyColumn.MaHoatDong.ToString())];
					c.TenHoatDong = (reader[DanhMucHoatDongQuanLyColumn.TenHoatDong.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucHoatDongQuanLyColumn.TenHoatDong.ToString())];
					c.GhiChu = (reader[DanhMucHoatDongQuanLyColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucHoatDongQuanLyColumn.GhiChu.ToString())];
					c.HienThiLenWeb = (reader[DanhMucHoatDongQuanLyColumn.HienThiLenWeb.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DanhMucHoatDongQuanLyColumn.HienThiLenWeb.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DanhMucHoatDongQuanLy"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucHoatDongQuanLy"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DanhMucHoatDongQuanLy entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(DanhMucHoatDongQuanLyColumn.Id.ToString())];
			entity.MaHoatDong = (reader[DanhMucHoatDongQuanLyColumn.MaHoatDong.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucHoatDongQuanLyColumn.MaHoatDong.ToString())];
			entity.TenHoatDong = (reader[DanhMucHoatDongQuanLyColumn.TenHoatDong.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucHoatDongQuanLyColumn.TenHoatDong.ToString())];
			entity.GhiChu = (reader[DanhMucHoatDongQuanLyColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucHoatDongQuanLyColumn.GhiChu.ToString())];
			entity.HienThiLenWeb = (reader[DanhMucHoatDongQuanLyColumn.HienThiLenWeb.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DanhMucHoatDongQuanLyColumn.HienThiLenWeb.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DanhMucHoatDongQuanLy"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucHoatDongQuanLy"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DanhMucHoatDongQuanLy entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaHoatDong = Convert.IsDBNull(dataRow["MaHoatDong"]) ? null : (System.String)dataRow["MaHoatDong"];
			entity.TenHoatDong = Convert.IsDBNull(dataRow["TenHoatDong"]) ? null : (System.String)dataRow["TenHoatDong"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.HienThiLenWeb = Convert.IsDBNull(dataRow["HienThiLenWeb"]) ? null : (System.Boolean?)dataRow["HienThiLenWeb"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucHoatDongQuanLy"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DanhMucHoatDongQuanLy Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DanhMucHoatDongQuanLy entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetById methods when available
			
			#region NoiDungCongViecQuanLyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<NoiDungCongViecQuanLy>|NoiDungCongViecQuanLyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'NoiDungCongViecQuanLyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.NoiDungCongViecQuanLyCollection = DataRepository.NoiDungCongViecQuanLyProvider.GetByMaCongViec(transactionManager, entity.Id);

				if (deep && entity.NoiDungCongViecQuanLyCollection.Count > 0)
				{
					deepHandles.Add("NoiDungCongViecQuanLyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<NoiDungCongViecQuanLy>) DataRepository.NoiDungCongViecQuanLyProvider.DeepLoad,
						new object[] { transactionManager, entity.NoiDungCongViecQuanLyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GiangVienHoatDongQuanLyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienHoatDongQuanLy>|GiangVienHoatDongQuanLyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienHoatDongQuanLyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienHoatDongQuanLyCollection = DataRepository.GiangVienHoatDongQuanLyProvider.GetByMaHoatDongQuanLy(transactionManager, entity.Id);

				if (deep && entity.GiangVienHoatDongQuanLyCollection.Count > 0)
				{
					deepHandles.Add("GiangVienHoatDongQuanLyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienHoatDongQuanLy>) DataRepository.GiangVienHoatDongQuanLyProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienHoatDongQuanLyCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.DanhMucHoatDongQuanLy object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DanhMucHoatDongQuanLy instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DanhMucHoatDongQuanLy Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DanhMucHoatDongQuanLy entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<NoiDungCongViecQuanLy>
				if (CanDeepSave(entity.NoiDungCongViecQuanLyCollection, "List<NoiDungCongViecQuanLy>|NoiDungCongViecQuanLyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(NoiDungCongViecQuanLy child in entity.NoiDungCongViecQuanLyCollection)
					{
						if(child.MaCongViecSource != null)
						{
							child.MaCongViec = child.MaCongViecSource.Id;
						}
						else
						{
							child.MaCongViec = entity.Id;
						}

					}

					if (entity.NoiDungCongViecQuanLyCollection.Count > 0 || entity.NoiDungCongViecQuanLyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.NoiDungCongViecQuanLyProvider.Save(transactionManager, entity.NoiDungCongViecQuanLyCollection);
						
						deepHandles.Add("NoiDungCongViecQuanLyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< NoiDungCongViecQuanLy >) DataRepository.NoiDungCongViecQuanLyProvider.DeepSave,
							new object[] { transactionManager, entity.NoiDungCongViecQuanLyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GiangVienHoatDongQuanLy>
				if (CanDeepSave(entity.GiangVienHoatDongQuanLyCollection, "List<GiangVienHoatDongQuanLy>|GiangVienHoatDongQuanLyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienHoatDongQuanLy child in entity.GiangVienHoatDongQuanLyCollection)
					{
						if(child.MaHoatDongQuanLySource != null)
						{
							child.MaHoatDongQuanLy = child.MaHoatDongQuanLySource.Id;
						}
						else
						{
							child.MaHoatDongQuanLy = entity.Id;
						}

					}

					if (entity.GiangVienHoatDongQuanLyCollection.Count > 0 || entity.GiangVienHoatDongQuanLyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienHoatDongQuanLyProvider.Save(transactionManager, entity.GiangVienHoatDongQuanLyCollection);
						
						deepHandles.Add("GiangVienHoatDongQuanLyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienHoatDongQuanLy >) DataRepository.GiangVienHoatDongQuanLyProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienHoatDongQuanLyCollection, deepSaveType, childTypes, innerList }
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
	
	#region DanhMucHoatDongQuanLyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DanhMucHoatDongQuanLy</c>
	///</summary>
	public enum DanhMucHoatDongQuanLyChildEntityTypes
	{
		///<summary>
		/// Collection of <c>DanhMucHoatDongQuanLy</c> as OneToMany for NoiDungCongViecQuanLyCollection
		///</summary>
		[ChildEntityType(typeof(TList<NoiDungCongViecQuanLy>))]
		NoiDungCongViecQuanLyCollection,
		///<summary>
		/// Collection of <c>DanhMucHoatDongQuanLy</c> as OneToMany for GiangVienHoatDongQuanLyCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienHoatDongQuanLy>))]
		GiangVienHoatDongQuanLyCollection,
	}
	
	#endregion DanhMucHoatDongQuanLyChildEntityTypes
	
	#region DanhMucHoatDongQuanLyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DanhMucHoatDongQuanLyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucHoatDongQuanLy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucHoatDongQuanLyFilterBuilder : SqlFilterBuilder<DanhMucHoatDongQuanLyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucHoatDongQuanLyFilterBuilder class.
		/// </summary>
		public DanhMucHoatDongQuanLyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DanhMucHoatDongQuanLyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DanhMucHoatDongQuanLyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DanhMucHoatDongQuanLyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DanhMucHoatDongQuanLyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DanhMucHoatDongQuanLyFilterBuilder
	
	#region DanhMucHoatDongQuanLyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DanhMucHoatDongQuanLyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucHoatDongQuanLy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucHoatDongQuanLyParameterBuilder : ParameterizedSqlFilterBuilder<DanhMucHoatDongQuanLyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucHoatDongQuanLyParameterBuilder class.
		/// </summary>
		public DanhMucHoatDongQuanLyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DanhMucHoatDongQuanLyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DanhMucHoatDongQuanLyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DanhMucHoatDongQuanLyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DanhMucHoatDongQuanLyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DanhMucHoatDongQuanLyParameterBuilder
	
	#region DanhMucHoatDongQuanLySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DanhMucHoatDongQuanLyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucHoatDongQuanLy"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DanhMucHoatDongQuanLySortBuilder : SqlSortBuilder<DanhMucHoatDongQuanLyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucHoatDongQuanLySqlSortBuilder class.
		/// </summary>
		public DanhMucHoatDongQuanLySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DanhMucHoatDongQuanLySortBuilder
	
} // end namespace
