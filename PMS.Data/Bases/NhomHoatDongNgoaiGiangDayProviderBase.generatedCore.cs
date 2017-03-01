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
	/// This class is the base class for any <see cref="NhomHoatDongNgoaiGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class NhomHoatDongNgoaiGiangDayProviderBaseCore : EntityProviderBase<PMS.Entities.NhomHoatDongNgoaiGiangDay, PMS.Entities.NhomHoatDongNgoaiGiangDayKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.NhomHoatDongNgoaiGiangDayKey key)
		{
			return Delete(transactionManager, key.MaNhom);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maNhom">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maNhom)
		{
			return Delete(null, _maNhom);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maNhom);		
		
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
		public override PMS.Entities.NhomHoatDongNgoaiGiangDay Get(TransactionManager transactionManager, PMS.Entities.NhomHoatDongNgoaiGiangDayKey key, int start, int pageLength)
		{
			return GetByMaNhom(transactionManager, key.MaNhom, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_NhomHoatDongNgoaiGiangDay_1 index.
		/// </summary>
		/// <param name="_maNhom"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.NhomHoatDongNgoaiGiangDay GetByMaNhom(System.String _maNhom)
		{
			int count = -1;
			return GetByMaNhom(null,_maNhom, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomHoatDongNgoaiGiangDay_1 index.
		/// </summary>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.NhomHoatDongNgoaiGiangDay GetByMaNhom(System.String _maNhom, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhom(null, _maNhom, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomHoatDongNgoaiGiangDay_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.NhomHoatDongNgoaiGiangDay GetByMaNhom(TransactionManager transactionManager, System.String _maNhom)
		{
			int count = -1;
			return GetByMaNhom(transactionManager, _maNhom, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomHoatDongNgoaiGiangDay_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.NhomHoatDongNgoaiGiangDay GetByMaNhom(TransactionManager transactionManager, System.String _maNhom, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhom(transactionManager, _maNhom, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomHoatDongNgoaiGiangDay_1 index.
		/// </summary>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomHoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.NhomHoatDongNgoaiGiangDay GetByMaNhom(System.String _maNhom, int start, int pageLength, out int count)
		{
			return GetByMaNhom(null, _maNhom, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomHoatDongNgoaiGiangDay_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomHoatDongNgoaiGiangDay"/> class.</returns>
		public abstract PMS.Entities.NhomHoatDongNgoaiGiangDay GetByMaNhom(TransactionManager transactionManager, System.String _maNhom, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;NhomHoatDongNgoaiGiangDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;NhomHoatDongNgoaiGiangDay&gt;"/></returns>
		public static TList<NhomHoatDongNgoaiGiangDay> Fill(IDataReader reader, TList<NhomHoatDongNgoaiGiangDay> rows, int start, int pageLength)
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
				
				PMS.Entities.NhomHoatDongNgoaiGiangDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("NhomHoatDongNgoaiGiangDay")
					.Append("|").Append((System.String)reader[((int)NhomHoatDongNgoaiGiangDayColumn.MaNhom - 1)]).ToString();
					c = EntityManager.LocateOrCreate<NhomHoatDongNgoaiGiangDay>(
					key.ToString(), // EntityTrackingKey
					"NhomHoatDongNgoaiGiangDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.NhomHoatDongNgoaiGiangDay();
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
					c.MaNhom = (System.String)reader[(NhomHoatDongNgoaiGiangDayColumn.MaNhom.ToString())];
					c.OriginalMaNhom = c.MaNhom;
					c.TenNhom = (System.String)reader[(NhomHoatDongNgoaiGiangDayColumn.TenNhom.ToString())];
					c.GhiChu = (reader[NhomHoatDongNgoaiGiangDayColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomHoatDongNgoaiGiangDayColumn.GhiChu.ToString())];
					c.OrderBy = (reader[NhomHoatDongNgoaiGiangDayColumn.OrderBy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(NhomHoatDongNgoaiGiangDayColumn.OrderBy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomHoatDongNgoaiGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomHoatDongNgoaiGiangDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.NhomHoatDongNgoaiGiangDay entity)
		{
			if (!reader.Read()) return;
			
			entity.MaNhom = (System.String)reader[(NhomHoatDongNgoaiGiangDayColumn.MaNhom.ToString())];
			entity.OriginalMaNhom = (System.String)reader["MaNhom"];
			entity.TenNhom = (System.String)reader[(NhomHoatDongNgoaiGiangDayColumn.TenNhom.ToString())];
			entity.GhiChu = (reader[NhomHoatDongNgoaiGiangDayColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomHoatDongNgoaiGiangDayColumn.GhiChu.ToString())];
			entity.OrderBy = (reader[NhomHoatDongNgoaiGiangDayColumn.OrderBy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(NhomHoatDongNgoaiGiangDayColumn.OrderBy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomHoatDongNgoaiGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomHoatDongNgoaiGiangDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.NhomHoatDongNgoaiGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaNhom = (System.String)dataRow["MaNhom"];
			entity.OriginalMaNhom = (System.String)dataRow["MaNhom"];
			entity.TenNhom = (System.String)dataRow["TenNhom"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.OrderBy = Convert.IsDBNull(dataRow["OrderBy"]) ? null : (System.Int32?)dataRow["OrderBy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.NhomHoatDongNgoaiGiangDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.NhomHoatDongNgoaiGiangDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.NhomHoatDongNgoaiGiangDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaNhom methods when available
			
			#region HoatDongNgoaiGiangDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<HoatDongNgoaiGiangDay>|HoatDongNgoaiGiangDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'HoatDongNgoaiGiangDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.HoatDongNgoaiGiangDayCollection = DataRepository.HoatDongNgoaiGiangDayProvider.GetByMaNhom(transactionManager, entity.MaNhom);

				if (deep && entity.HoatDongNgoaiGiangDayCollection.Count > 0)
				{
					deepHandles.Add("HoatDongNgoaiGiangDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<HoatDongNgoaiGiangDay>) DataRepository.HoatDongNgoaiGiangDayProvider.DeepLoad,
						new object[] { transactionManager, entity.HoatDongNgoaiGiangDayCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.NhomHoatDongNgoaiGiangDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.NhomHoatDongNgoaiGiangDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.NhomHoatDongNgoaiGiangDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.NhomHoatDongNgoaiGiangDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<HoatDongNgoaiGiangDay>
				if (CanDeepSave(entity.HoatDongNgoaiGiangDayCollection, "List<HoatDongNgoaiGiangDay>|HoatDongNgoaiGiangDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(HoatDongNgoaiGiangDay child in entity.HoatDongNgoaiGiangDayCollection)
					{
						if(child.MaNhomSource != null)
						{
							child.MaNhom = child.MaNhomSource.MaNhom;
						}
						else
						{
							child.MaNhom = entity.MaNhom;
						}

					}

					if (entity.HoatDongNgoaiGiangDayCollection.Count > 0 || entity.HoatDongNgoaiGiangDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.HoatDongNgoaiGiangDayProvider.Save(transactionManager, entity.HoatDongNgoaiGiangDayCollection);
						
						deepHandles.Add("HoatDongNgoaiGiangDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< HoatDongNgoaiGiangDay >) DataRepository.HoatDongNgoaiGiangDayProvider.DeepSave,
							new object[] { transactionManager, entity.HoatDongNgoaiGiangDayCollection, deepSaveType, childTypes, innerList }
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
	
	#region NhomHoatDongNgoaiGiangDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.NhomHoatDongNgoaiGiangDay</c>
	///</summary>
	public enum NhomHoatDongNgoaiGiangDayChildEntityTypes
	{
		///<summary>
		/// Collection of <c>NhomHoatDongNgoaiGiangDay</c> as OneToMany for HoatDongNgoaiGiangDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<HoatDongNgoaiGiangDay>))]
		HoatDongNgoaiGiangDayCollection,
	}
	
	#endregion NhomHoatDongNgoaiGiangDayChildEntityTypes
	
	#region NhomHoatDongNgoaiGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;NhomHoatDongNgoaiGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomHoatDongNgoaiGiangDayFilterBuilder : SqlFilterBuilder<NhomHoatDongNgoaiGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		public NhomHoatDongNgoaiGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomHoatDongNgoaiGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomHoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomHoatDongNgoaiGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomHoatDongNgoaiGiangDayFilterBuilder
	
	#region NhomHoatDongNgoaiGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;NhomHoatDongNgoaiGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomHoatDongNgoaiGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<NhomHoatDongNgoaiGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		public NhomHoatDongNgoaiGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomHoatDongNgoaiGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomHoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomHoatDongNgoaiGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomHoatDongNgoaiGiangDayParameterBuilder
	
	#region NhomHoatDongNgoaiGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;NhomHoatDongNgoaiGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomHoatDongNgoaiGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class NhomHoatDongNgoaiGiangDaySortBuilder : SqlSortBuilder<NhomHoatDongNgoaiGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomHoatDongNgoaiGiangDaySqlSortBuilder class.
		/// </summary>
		public NhomHoatDongNgoaiGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion NhomHoatDongNgoaiGiangDaySortBuilder
	
} // end namespace
