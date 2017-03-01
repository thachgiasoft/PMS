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
	/// This class is the base class for any <see cref="NhomKhoiLuongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class NhomKhoiLuongProviderBaseCore : EntityProviderBase<PMS.Entities.NhomKhoiLuong, PMS.Entities.NhomKhoiLuongKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.NhomKhoiLuongKey key)
		{
			return Delete(transactionManager, key.MaNhom);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maNhom">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maNhom)
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
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maNhom);		
		
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
		public override PMS.Entities.NhomKhoiLuong Get(TransactionManager transactionManager, PMS.Entities.NhomKhoiLuongKey key, int start, int pageLength)
		{
			return GetByMaNhom(transactionManager, key.MaNhom, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_NhomKhoiLuong index.
		/// </summary>
		/// <param name="_maNhom"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomKhoiLuong"/> class.</returns>
		public PMS.Entities.NhomKhoiLuong GetByMaNhom(System.Int32 _maNhom)
		{
			int count = -1;
			return GetByMaNhom(null,_maNhom, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomKhoiLuong index.
		/// </summary>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomKhoiLuong"/> class.</returns>
		public PMS.Entities.NhomKhoiLuong GetByMaNhom(System.Int32 _maNhom, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhom(null, _maNhom, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomKhoiLuong"/> class.</returns>
		public PMS.Entities.NhomKhoiLuong GetByMaNhom(TransactionManager transactionManager, System.Int32 _maNhom)
		{
			int count = -1;
			return GetByMaNhom(transactionManager, _maNhom, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomKhoiLuong"/> class.</returns>
		public PMS.Entities.NhomKhoiLuong GetByMaNhom(TransactionManager transactionManager, System.Int32 _maNhom, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhom(transactionManager, _maNhom, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomKhoiLuong index.
		/// </summary>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomKhoiLuong"/> class.</returns>
		public PMS.Entities.NhomKhoiLuong GetByMaNhom(System.Int32 _maNhom, int start, int pageLength, out int count)
		{
			return GetByMaNhom(null, _maNhom, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomKhoiLuong"/> class.</returns>
		public abstract PMS.Entities.NhomKhoiLuong GetByMaNhom(TransactionManager transactionManager, System.Int32 _maNhom, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;NhomKhoiLuong&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;NhomKhoiLuong&gt;"/></returns>
		public static TList<NhomKhoiLuong> Fill(IDataReader reader, TList<NhomKhoiLuong> rows, int start, int pageLength)
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
				
				PMS.Entities.NhomKhoiLuong c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("NhomKhoiLuong")
					.Append("|").Append((System.Int32)reader[((int)NhomKhoiLuongColumn.MaNhom - 1)]).ToString();
					c = EntityManager.LocateOrCreate<NhomKhoiLuong>(
					key.ToString(), // EntityTrackingKey
					"NhomKhoiLuong",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.NhomKhoiLuong();
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
					c.MaNhom = (System.Int32)reader[(NhomKhoiLuongColumn.MaNhom.ToString())];
					c.MaQuanLy = (reader[NhomKhoiLuongColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomKhoiLuongColumn.MaQuanLy.ToString())];
					c.TenNhom = (reader[NhomKhoiLuongColumn.TenNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomKhoiLuongColumn.TenNhom.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomKhoiLuong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomKhoiLuong"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.NhomKhoiLuong entity)
		{
			if (!reader.Read()) return;
			
			entity.MaNhom = (System.Int32)reader[(NhomKhoiLuongColumn.MaNhom.ToString())];
			entity.MaQuanLy = (reader[NhomKhoiLuongColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomKhoiLuongColumn.MaQuanLy.ToString())];
			entity.TenNhom = (reader[NhomKhoiLuongColumn.TenNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomKhoiLuongColumn.TenNhom.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomKhoiLuong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomKhoiLuong"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.NhomKhoiLuong entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaNhom = (System.Int32)dataRow["MaNhom"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.TenNhom = Convert.IsDBNull(dataRow["TenNhom"]) ? null : (System.String)dataRow["TenNhom"];
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
		/// <param name="entity">The <see cref="PMS.Entities.NhomKhoiLuong"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.NhomKhoiLuong Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.NhomKhoiLuong entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaNhom methods when available
			
			#region LoaiKhoiLuongCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<LoaiKhoiLuong>|LoaiKhoiLuongCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'LoaiKhoiLuongCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.LoaiKhoiLuongCollection = DataRepository.LoaiKhoiLuongProvider.GetByMaNhom(transactionManager, entity.MaNhom);

				if (deep && entity.LoaiKhoiLuongCollection.Count > 0)
				{
					deepHandles.Add("LoaiKhoiLuongCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<LoaiKhoiLuong>) DataRepository.LoaiKhoiLuongProvider.DeepLoad,
						new object[] { transactionManager, entity.LoaiKhoiLuongCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.NhomKhoiLuong object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.NhomKhoiLuong instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.NhomKhoiLuong Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.NhomKhoiLuong entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<LoaiKhoiLuong>
				if (CanDeepSave(entity.LoaiKhoiLuongCollection, "List<LoaiKhoiLuong>|LoaiKhoiLuongCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(LoaiKhoiLuong child in entity.LoaiKhoiLuongCollection)
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

					if (entity.LoaiKhoiLuongCollection.Count > 0 || entity.LoaiKhoiLuongCollection.DeletedItems.Count > 0)
					{
						//DataRepository.LoaiKhoiLuongProvider.Save(transactionManager, entity.LoaiKhoiLuongCollection);
						
						deepHandles.Add("LoaiKhoiLuongCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< LoaiKhoiLuong >) DataRepository.LoaiKhoiLuongProvider.DeepSave,
							new object[] { transactionManager, entity.LoaiKhoiLuongCollection, deepSaveType, childTypes, innerList }
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
	
	#region NhomKhoiLuongChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.NhomKhoiLuong</c>
	///</summary>
	public enum NhomKhoiLuongChildEntityTypes
	{
		///<summary>
		/// Collection of <c>NhomKhoiLuong</c> as OneToMany for LoaiKhoiLuongCollection
		///</summary>
		[ChildEntityType(typeof(TList<LoaiKhoiLuong>))]
		LoaiKhoiLuongCollection,
	}
	
	#endregion NhomKhoiLuongChildEntityTypes
	
	#region NhomKhoiLuongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;NhomKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomKhoiLuongFilterBuilder : SqlFilterBuilder<NhomKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomKhoiLuongFilterBuilder class.
		/// </summary>
		public NhomKhoiLuongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomKhoiLuongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomKhoiLuongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomKhoiLuongFilterBuilder
	
	#region NhomKhoiLuongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;NhomKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomKhoiLuongParameterBuilder : ParameterizedSqlFilterBuilder<NhomKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomKhoiLuongParameterBuilder class.
		/// </summary>
		public NhomKhoiLuongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomKhoiLuongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomKhoiLuongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomKhoiLuongParameterBuilder
	
	#region NhomKhoiLuongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;NhomKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomKhoiLuong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class NhomKhoiLuongSortBuilder : SqlSortBuilder<NhomKhoiLuongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomKhoiLuongSqlSortBuilder class.
		/// </summary>
		public NhomKhoiLuongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion NhomKhoiLuongSortBuilder
	
} // end namespace
