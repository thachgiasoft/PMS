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
	/// This class is the base class for any <see cref="DanhMucChotGioDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DanhMucChotGioDayProviderBaseCore : EntityProviderBase<PMS.Entities.DanhMucChotGioDay, PMS.Entities.DanhMucChotGioDayKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DanhMucChotGioDayKey key)
		{
			return Delete(transactionManager, key.MaDanhMucChotGio);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maDanhMucChotGio">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maDanhMucChotGio)
		{
			return Delete(null, _maDanhMucChotGio);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDanhMucChotGio">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maDanhMucChotGio);		
		
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
		public override PMS.Entities.DanhMucChotGioDay Get(TransactionManager transactionManager, PMS.Entities.DanhMucChotGioDayKey key, int start, int pageLength)
		{
			return GetByMaDanhMucChotGio(transactionManager, key.MaDanhMucChotGio, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DanhMucChotGioDay index.
		/// </summary>
		/// <param name="_maDanhMucChotGio"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucChotGioDay"/> class.</returns>
		public PMS.Entities.DanhMucChotGioDay GetByMaDanhMucChotGio(System.Int32 _maDanhMucChotGio)
		{
			int count = -1;
			return GetByMaDanhMucChotGio(null,_maDanhMucChotGio, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucChotGioDay index.
		/// </summary>
		/// <param name="_maDanhMucChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucChotGioDay"/> class.</returns>
		public PMS.Entities.DanhMucChotGioDay GetByMaDanhMucChotGio(System.Int32 _maDanhMucChotGio, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDanhMucChotGio(null, _maDanhMucChotGio, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucChotGioDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDanhMucChotGio"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucChotGioDay"/> class.</returns>
		public PMS.Entities.DanhMucChotGioDay GetByMaDanhMucChotGio(TransactionManager transactionManager, System.Int32 _maDanhMucChotGio)
		{
			int count = -1;
			return GetByMaDanhMucChotGio(transactionManager, _maDanhMucChotGio, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucChotGioDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDanhMucChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucChotGioDay"/> class.</returns>
		public PMS.Entities.DanhMucChotGioDay GetByMaDanhMucChotGio(TransactionManager transactionManager, System.Int32 _maDanhMucChotGio, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDanhMucChotGio(transactionManager, _maDanhMucChotGio, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucChotGioDay index.
		/// </summary>
		/// <param name="_maDanhMucChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucChotGioDay"/> class.</returns>
		public PMS.Entities.DanhMucChotGioDay GetByMaDanhMucChotGio(System.Int32 _maDanhMucChotGio, int start, int pageLength, out int count)
		{
			return GetByMaDanhMucChotGio(null, _maDanhMucChotGio, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucChotGioDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDanhMucChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucChotGioDay"/> class.</returns>
		public abstract PMS.Entities.DanhMucChotGioDay GetByMaDanhMucChotGio(TransactionManager transactionManager, System.Int32 _maDanhMucChotGio, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DanhMucChotGioDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DanhMucChotGioDay&gt;"/></returns>
		public static TList<DanhMucChotGioDay> Fill(IDataReader reader, TList<DanhMucChotGioDay> rows, int start, int pageLength)
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
				
				PMS.Entities.DanhMucChotGioDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DanhMucChotGioDay")
					.Append("|").Append((System.Int32)reader[((int)DanhMucChotGioDayColumn.MaDanhMucChotGio - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DanhMucChotGioDay>(
					key.ToString(), // EntityTrackingKey
					"DanhMucChotGioDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DanhMucChotGioDay();
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
					c.MaDanhMucChotGio = (System.Int32)reader[((int)DanhMucChotGioDayColumn.MaDanhMucChotGio - 1)];
					c.MaQuanLy = (reader.IsDBNull(((int)DanhMucChotGioDayColumn.MaQuanLy - 1)))?null:(System.String)reader[((int)DanhMucChotGioDayColumn.MaQuanLy - 1)];
					c.TenChotGio = (reader.IsDBNull(((int)DanhMucChotGioDayColumn.TenChotGio - 1)))?null:(System.String)reader[((int)DanhMucChotGioDayColumn.TenChotGio - 1)];
					c.TuNgay = (reader.IsDBNull(((int)DanhMucChotGioDayColumn.TuNgay - 1)))?null:(System.DateTime?)reader[((int)DanhMucChotGioDayColumn.TuNgay - 1)];
					c.DenNgay = (reader.IsDBNull(((int)DanhMucChotGioDayColumn.DenNgay - 1)))?null:(System.DateTime?)reader[((int)DanhMucChotGioDayColumn.DenNgay - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DanhMucChotGioDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucChotGioDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DanhMucChotGioDay entity)
		{
			if (!reader.Read()) return;
			
			entity.MaDanhMucChotGio = (System.Int32)reader[((int)DanhMucChotGioDayColumn.MaDanhMucChotGio - 1)];
			entity.MaQuanLy = (reader.IsDBNull(((int)DanhMucChotGioDayColumn.MaQuanLy - 1)))?null:(System.String)reader[((int)DanhMucChotGioDayColumn.MaQuanLy - 1)];
			entity.TenChotGio = (reader.IsDBNull(((int)DanhMucChotGioDayColumn.TenChotGio - 1)))?null:(System.String)reader[((int)DanhMucChotGioDayColumn.TenChotGio - 1)];
			entity.TuNgay = (reader.IsDBNull(((int)DanhMucChotGioDayColumn.TuNgay - 1)))?null:(System.DateTime?)reader[((int)DanhMucChotGioDayColumn.TuNgay - 1)];
			entity.DenNgay = (reader.IsDBNull(((int)DanhMucChotGioDayColumn.DenNgay - 1)))?null:(System.DateTime?)reader[((int)DanhMucChotGioDayColumn.DenNgay - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DanhMucChotGioDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucChotGioDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DanhMucChotGioDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaDanhMucChotGio = (System.Int32)dataRow["MaDanhMucChotGio"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.TenChotGio = Convert.IsDBNull(dataRow["TenChotGio"]) ? null : (System.String)dataRow["TenChotGio"];
			entity.TuNgay = Convert.IsDBNull(dataRow["TuNgay"]) ? null : (System.DateTime?)dataRow["TuNgay"];
			entity.DenNgay = Convert.IsDBNull(dataRow["DenNgay"]) ? null : (System.DateTime?)dataRow["DenNgay"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucChotGioDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DanhMucChotGioDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DanhMucChotGioDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaDanhMucChotGio methods when available
			
			#region ChotGioDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ChotGioDay>|ChotGioDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ChotGioDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ChotGioDayCollection = DataRepository.ChotGioDayProvider.GetByMaDanhMucChotGio(transactionManager, entity.MaDanhMucChotGio);

				if (deep && entity.ChotGioDayCollection.Count > 0)
				{
					deepHandles.Add("ChotGioDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ChotGioDay>) DataRepository.ChotGioDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ChotGioDayCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.DanhMucChotGioDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DanhMucChotGioDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DanhMucChotGioDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DanhMucChotGioDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<ChotGioDay>
				if (CanDeepSave(entity.ChotGioDayCollection, "List<ChotGioDay>|ChotGioDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ChotGioDay child in entity.ChotGioDayCollection)
					{
						if(child.MaDanhMucChotGioSource != null)
						{
							child.MaDanhMucChotGio = child.MaDanhMucChotGioSource.MaDanhMucChotGio;
						}
						else
						{
							child.MaDanhMucChotGio = entity.MaDanhMucChotGio;
						}

					}

					if (entity.ChotGioDayCollection.Count > 0 || entity.ChotGioDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ChotGioDayProvider.Save(transactionManager, entity.ChotGioDayCollection);
						
						deepHandles.Add("ChotGioDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ChotGioDay >) DataRepository.ChotGioDayProvider.DeepSave,
							new object[] { transactionManager, entity.ChotGioDayCollection, deepSaveType, childTypes, innerList }
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
	
	#region DanhMucChotGioDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DanhMucChotGioDay</c>
	///</summary>
	public enum DanhMucChotGioDayChildEntityTypes
	{

		///<summary>
		/// Collection of <c>DanhMucChotGioDay</c> as OneToMany for ChotGioDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ChotGioDay>))]
		ChotGioDayCollection,
	}
	
	#endregion DanhMucChotGioDayChildEntityTypes
	
	#region DanhMucChotGioDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DanhMucChotGioDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucChotGioDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucChotGioDayFilterBuilder : SqlFilterBuilder<DanhMucChotGioDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucChotGioDayFilterBuilder class.
		/// </summary>
		public DanhMucChotGioDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DanhMucChotGioDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DanhMucChotGioDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DanhMucChotGioDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DanhMucChotGioDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DanhMucChotGioDayFilterBuilder
	
	#region DanhMucChotGioDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DanhMucChotGioDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucChotGioDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucChotGioDayParameterBuilder : ParameterizedSqlFilterBuilder<DanhMucChotGioDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucChotGioDayParameterBuilder class.
		/// </summary>
		public DanhMucChotGioDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DanhMucChotGioDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DanhMucChotGioDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DanhMucChotGioDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DanhMucChotGioDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DanhMucChotGioDayParameterBuilder
	
	#region DanhMucChotGioDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DanhMucChotGioDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucChotGioDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DanhMucChotGioDaySortBuilder : SqlSortBuilder<DanhMucChotGioDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucChotGioDaySqlSortBuilder class.
		/// </summary>
		public DanhMucChotGioDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DanhMucChotGioDaySortBuilder
	
} // end namespace
