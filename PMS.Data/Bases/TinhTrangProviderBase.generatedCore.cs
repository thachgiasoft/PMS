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
	/// This class is the base class for any <see cref="TinhTrangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TinhTrangProviderBaseCore : EntityProviderBase<PMS.Entities.TinhTrang, PMS.Entities.TinhTrangKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.TinhTrangKey key)
		{
			return Delete(transactionManager, key.MaTinhTrang);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maTinhTrang">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maTinhTrang)
		{
			return Delete(null, _maTinhTrang);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTinhTrang">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maTinhTrang);		
		
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
		public override PMS.Entities.TinhTrang Get(TransactionManager transactionManager, PMS.Entities.TinhTrangKey key, int start, int pageLength)
		{
			return GetByMaTinhTrang(transactionManager, key.MaTinhTrang, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_TinhTrang index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TinhTrang"/> class.</returns>
		public PMS.Entities.TinhTrang GetByMaQuanLy(System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_TinhTrang index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TinhTrang"/> class.</returns>
		public PMS.Entities.TinhTrang GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_TinhTrang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TinhTrang"/> class.</returns>
		public PMS.Entities.TinhTrang GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_TinhTrang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TinhTrang"/> class.</returns>
		public PMS.Entities.TinhTrang GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_TinhTrang index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TinhTrang"/> class.</returns>
		public PMS.Entities.TinhTrang GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_TinhTrang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TinhTrang"/> class.</returns>
		public abstract PMS.Entities.TinhTrang GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_TinhTrang index.
		/// </summary>
		/// <param name="_maTinhTrang"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TinhTrang"/> class.</returns>
		public PMS.Entities.TinhTrang GetByMaTinhTrang(System.Int32 _maTinhTrang)
		{
			int count = -1;
			return GetByMaTinhTrang(null,_maTinhTrang, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TinhTrang index.
		/// </summary>
		/// <param name="_maTinhTrang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TinhTrang"/> class.</returns>
		public PMS.Entities.TinhTrang GetByMaTinhTrang(System.Int32 _maTinhTrang, int start, int pageLength)
		{
			int count = -1;
			return GetByMaTinhTrang(null, _maTinhTrang, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TinhTrang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTinhTrang"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TinhTrang"/> class.</returns>
		public PMS.Entities.TinhTrang GetByMaTinhTrang(TransactionManager transactionManager, System.Int32 _maTinhTrang)
		{
			int count = -1;
			return GetByMaTinhTrang(transactionManager, _maTinhTrang, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TinhTrang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTinhTrang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TinhTrang"/> class.</returns>
		public PMS.Entities.TinhTrang GetByMaTinhTrang(TransactionManager transactionManager, System.Int32 _maTinhTrang, int start, int pageLength)
		{
			int count = -1;
			return GetByMaTinhTrang(transactionManager, _maTinhTrang, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TinhTrang index.
		/// </summary>
		/// <param name="_maTinhTrang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TinhTrang"/> class.</returns>
		public PMS.Entities.TinhTrang GetByMaTinhTrang(System.Int32 _maTinhTrang, int start, int pageLength, out int count)
		{
			return GetByMaTinhTrang(null, _maTinhTrang, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TinhTrang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTinhTrang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TinhTrang"/> class.</returns>
		public abstract PMS.Entities.TinhTrang GetByMaTinhTrang(TransactionManager transactionManager, System.Int32 _maTinhTrang, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TinhTrang&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TinhTrang&gt;"/></returns>
		public static TList<TinhTrang> Fill(IDataReader reader, TList<TinhTrang> rows, int start, int pageLength)
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
				
				PMS.Entities.TinhTrang c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TinhTrang")
					.Append("|").Append((System.Int32)reader[((int)TinhTrangColumn.MaTinhTrang - 1)]).ToString();
					c = EntityManager.LocateOrCreate<TinhTrang>(
					key.ToString(), // EntityTrackingKey
					"TinhTrang",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.TinhTrang();
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
					c.MaTinhTrang = (System.Int32)reader[(TinhTrangColumn.MaTinhTrang.ToString())];
					c.MaQuanLy = (System.String)reader[(TinhTrangColumn.MaQuanLy.ToString())];
					c.TenTinhTrang = (reader[TinhTrangColumn.TenTinhTrang.ToString()] == DBNull.Value) ? null : (System.String)reader[(TinhTrangColumn.TenTinhTrang.ToString())];
					c.ThuTu = (reader[TinhTrangColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TinhTrangColumn.ThuTu.ToString())];
					c.Hrmid = (reader[TinhTrangColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(TinhTrangColumn.Hrmid.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TinhTrang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TinhTrang"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.TinhTrang entity)
		{
			if (!reader.Read()) return;
			
			entity.MaTinhTrang = (System.Int32)reader[(TinhTrangColumn.MaTinhTrang.ToString())];
			entity.MaQuanLy = (System.String)reader[(TinhTrangColumn.MaQuanLy.ToString())];
			entity.TenTinhTrang = (reader[TinhTrangColumn.TenTinhTrang.ToString()] == DBNull.Value) ? null : (System.String)reader[(TinhTrangColumn.TenTinhTrang.ToString())];
			entity.ThuTu = (reader[TinhTrangColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TinhTrangColumn.ThuTu.ToString())];
			entity.Hrmid = (reader[TinhTrangColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(TinhTrangColumn.Hrmid.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TinhTrang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TinhTrang"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.TinhTrang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaTinhTrang = (System.Int32)dataRow["MaTinhTrang"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenTinhTrang = Convert.IsDBNull(dataRow["TenTinhTrang"]) ? null : (System.String)dataRow["TenTinhTrang"];
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
		/// <param name="entity">The <see cref="PMS.Entities.TinhTrang"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.TinhTrang Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.TinhTrang entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaTinhTrang methods when available
			
			#region GiangVienCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVien>|GiangVienCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienCollection = DataRepository.GiangVienProvider.GetByMaTinhTrang(transactionManager, entity.MaTinhTrang);

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
		/// Deep Save the entire object graph of the PMS.Entities.TinhTrang object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.TinhTrang instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.TinhTrang Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.TinhTrang entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<GiangVien>
				if (CanDeepSave(entity.GiangVienCollection, "List<GiangVien>|GiangVienCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVien child in entity.GiangVienCollection)
					{
						if(child.MaTinhTrangSource != null)
						{
							child.MaTinhTrang = child.MaTinhTrangSource.MaTinhTrang;
						}
						else
						{
							child.MaTinhTrang = entity.MaTinhTrang;
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
	
	#region TinhTrangChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.TinhTrang</c>
	///</summary>
	public enum TinhTrangChildEntityTypes
	{
		///<summary>
		/// Collection of <c>TinhTrang</c> as OneToMany for GiangVienCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVien>))]
		GiangVienCollection,
	}
	
	#endregion TinhTrangChildEntityTypes
	
	#region TinhTrangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TinhTrangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TinhTrang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TinhTrangFilterBuilder : SqlFilterBuilder<TinhTrangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TinhTrangFilterBuilder class.
		/// </summary>
		public TinhTrangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TinhTrangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TinhTrangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TinhTrangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TinhTrangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TinhTrangFilterBuilder
	
	#region TinhTrangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TinhTrangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TinhTrang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TinhTrangParameterBuilder : ParameterizedSqlFilterBuilder<TinhTrangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TinhTrangParameterBuilder class.
		/// </summary>
		public TinhTrangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TinhTrangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TinhTrangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TinhTrangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TinhTrangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TinhTrangParameterBuilder
	
	#region TinhTrangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TinhTrangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TinhTrang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TinhTrangSortBuilder : SqlSortBuilder<TinhTrangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TinhTrangSqlSortBuilder class.
		/// </summary>
		public TinhTrangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TinhTrangSortBuilder
	
} // end namespace
