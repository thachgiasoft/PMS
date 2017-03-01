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
	/// This class is the base class for any <see cref="TrinhDoNgoaiNguProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TrinhDoNgoaiNguProviderBaseCore : EntityProviderBase<PMS.Entities.TrinhDoNgoaiNgu, PMS.Entities.TrinhDoNgoaiNguKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.TrinhDoNgoaiNguKey key)
		{
			return Delete(transactionManager, key.MaTrinhDoNgoaiNgu);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maTrinhDoNgoaiNgu">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maTrinhDoNgoaiNgu)
		{
			return Delete(null, _maTrinhDoNgoaiNgu);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoNgoaiNgu">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maTrinhDoNgoaiNgu);		
		
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
		public override PMS.Entities.TrinhDoNgoaiNgu Get(TransactionManager transactionManager, PMS.Entities.TrinhDoNgoaiNguKey key, int start, int pageLength)
		{
			return GetByMaTrinhDoNgoaiNgu(transactionManager, key.MaTrinhDoNgoaiNgu, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_TrinhDoNgoaiNgu index.
		/// </summary>
		/// <param name="_maTrinhDoNgoaiNgu"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TrinhDoNgoaiNgu"/> class.</returns>
		public PMS.Entities.TrinhDoNgoaiNgu GetByMaTrinhDoNgoaiNgu(System.Int32 _maTrinhDoNgoaiNgu)
		{
			int count = -1;
			return GetByMaTrinhDoNgoaiNgu(null,_maTrinhDoNgoaiNgu, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TrinhDoNgoaiNgu index.
		/// </summary>
		/// <param name="_maTrinhDoNgoaiNgu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TrinhDoNgoaiNgu"/> class.</returns>
		public PMS.Entities.TrinhDoNgoaiNgu GetByMaTrinhDoNgoaiNgu(System.Int32 _maTrinhDoNgoaiNgu, int start, int pageLength)
		{
			int count = -1;
			return GetByMaTrinhDoNgoaiNgu(null, _maTrinhDoNgoaiNgu, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TrinhDoNgoaiNgu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoNgoaiNgu"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TrinhDoNgoaiNgu"/> class.</returns>
		public PMS.Entities.TrinhDoNgoaiNgu GetByMaTrinhDoNgoaiNgu(TransactionManager transactionManager, System.Int32 _maTrinhDoNgoaiNgu)
		{
			int count = -1;
			return GetByMaTrinhDoNgoaiNgu(transactionManager, _maTrinhDoNgoaiNgu, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TrinhDoNgoaiNgu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoNgoaiNgu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TrinhDoNgoaiNgu"/> class.</returns>
		public PMS.Entities.TrinhDoNgoaiNgu GetByMaTrinhDoNgoaiNgu(TransactionManager transactionManager, System.Int32 _maTrinhDoNgoaiNgu, int start, int pageLength)
		{
			int count = -1;
			return GetByMaTrinhDoNgoaiNgu(transactionManager, _maTrinhDoNgoaiNgu, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TrinhDoNgoaiNgu index.
		/// </summary>
		/// <param name="_maTrinhDoNgoaiNgu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TrinhDoNgoaiNgu"/> class.</returns>
		public PMS.Entities.TrinhDoNgoaiNgu GetByMaTrinhDoNgoaiNgu(System.Int32 _maTrinhDoNgoaiNgu, int start, int pageLength, out int count)
		{
			return GetByMaTrinhDoNgoaiNgu(null, _maTrinhDoNgoaiNgu, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TrinhDoNgoaiNgu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTrinhDoNgoaiNgu"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TrinhDoNgoaiNgu"/> class.</returns>
		public abstract PMS.Entities.TrinhDoNgoaiNgu GetByMaTrinhDoNgoaiNgu(TransactionManager transactionManager, System.Int32 _maTrinhDoNgoaiNgu, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TrinhDoNgoaiNgu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TrinhDoNgoaiNgu&gt;"/></returns>
		public static TList<TrinhDoNgoaiNgu> Fill(IDataReader reader, TList<TrinhDoNgoaiNgu> rows, int start, int pageLength)
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
				
				PMS.Entities.TrinhDoNgoaiNgu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TrinhDoNgoaiNgu")
					.Append("|").Append((System.Int32)reader[((int)TrinhDoNgoaiNguColumn.MaTrinhDoNgoaiNgu - 1)]).ToString();
					c = EntityManager.LocateOrCreate<TrinhDoNgoaiNgu>(
					key.ToString(), // EntityTrackingKey
					"TrinhDoNgoaiNgu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.TrinhDoNgoaiNgu();
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
					c.MaTrinhDoNgoaiNgu = (System.Int32)reader[(TrinhDoNgoaiNguColumn.MaTrinhDoNgoaiNgu.ToString())];
					c.MaQuanLy = (reader[TrinhDoNgoaiNguColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrinhDoNgoaiNguColumn.MaQuanLy.ToString())];
					c.TenTrinhDoNgoaiNgu = (reader[TrinhDoNgoaiNguColumn.TenTrinhDoNgoaiNgu.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrinhDoNgoaiNguColumn.TenTrinhDoNgoaiNgu.ToString())];
					c.GhiChu = (reader[TrinhDoNgoaiNguColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrinhDoNgoaiNguColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[TrinhDoNgoaiNguColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrinhDoNgoaiNguColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[TrinhDoNgoaiNguColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrinhDoNgoaiNguColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TrinhDoNgoaiNgu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TrinhDoNgoaiNgu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.TrinhDoNgoaiNgu entity)
		{
			if (!reader.Read()) return;
			
			entity.MaTrinhDoNgoaiNgu = (System.Int32)reader[(TrinhDoNgoaiNguColumn.MaTrinhDoNgoaiNgu.ToString())];
			entity.MaQuanLy = (reader[TrinhDoNgoaiNguColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrinhDoNgoaiNguColumn.MaQuanLy.ToString())];
			entity.TenTrinhDoNgoaiNgu = (reader[TrinhDoNgoaiNguColumn.TenTrinhDoNgoaiNgu.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrinhDoNgoaiNguColumn.TenTrinhDoNgoaiNgu.ToString())];
			entity.GhiChu = (reader[TrinhDoNgoaiNguColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrinhDoNgoaiNguColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[TrinhDoNgoaiNguColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrinhDoNgoaiNguColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[TrinhDoNgoaiNguColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(TrinhDoNgoaiNguColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TrinhDoNgoaiNgu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TrinhDoNgoaiNgu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.TrinhDoNgoaiNgu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaTrinhDoNgoaiNgu = (System.Int32)dataRow["MaTrinhDoNgoaiNgu"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.TenTrinhDoNgoaiNgu = Convert.IsDBNull(dataRow["TenTrinhDoNgoaiNgu"]) ? null : (System.String)dataRow["TenTrinhDoNgoaiNgu"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.TrinhDoNgoaiNgu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.TrinhDoNgoaiNgu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.TrinhDoNgoaiNgu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaTrinhDoNgoaiNgu methods when available
			
			#region GiangVienCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVien>|GiangVienCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienCollection = DataRepository.GiangVienProvider.GetByMaTrinhDoNgoaiNgu(transactionManager, entity.MaTrinhDoNgoaiNgu);

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
		/// Deep Save the entire object graph of the PMS.Entities.TrinhDoNgoaiNgu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.TrinhDoNgoaiNgu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.TrinhDoNgoaiNgu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.TrinhDoNgoaiNgu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
						if(child.MaTrinhDoNgoaiNguSource != null)
						{
							child.MaTrinhDoNgoaiNgu = child.MaTrinhDoNgoaiNguSource.MaTrinhDoNgoaiNgu;
						}
						else
						{
							child.MaTrinhDoNgoaiNgu = entity.MaTrinhDoNgoaiNgu;
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
	
	#region TrinhDoNgoaiNguChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.TrinhDoNgoaiNgu</c>
	///</summary>
	public enum TrinhDoNgoaiNguChildEntityTypes
	{
		///<summary>
		/// Collection of <c>TrinhDoNgoaiNgu</c> as OneToMany for GiangVienCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVien>))]
		GiangVienCollection,
	}
	
	#endregion TrinhDoNgoaiNguChildEntityTypes
	
	#region TrinhDoNgoaiNguFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TrinhDoNgoaiNguColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoNgoaiNgu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoNgoaiNguFilterBuilder : SqlFilterBuilder<TrinhDoNgoaiNguColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrinhDoNgoaiNguFilterBuilder class.
		/// </summary>
		public TrinhDoNgoaiNguFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrinhDoNgoaiNguFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrinhDoNgoaiNguFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrinhDoNgoaiNguFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrinhDoNgoaiNguFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrinhDoNgoaiNguFilterBuilder
	
	#region TrinhDoNgoaiNguParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TrinhDoNgoaiNguColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoNgoaiNgu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoNgoaiNguParameterBuilder : ParameterizedSqlFilterBuilder<TrinhDoNgoaiNguColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrinhDoNgoaiNguParameterBuilder class.
		/// </summary>
		public TrinhDoNgoaiNguParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrinhDoNgoaiNguParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrinhDoNgoaiNguParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrinhDoNgoaiNguParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrinhDoNgoaiNguParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrinhDoNgoaiNguParameterBuilder
	
	#region TrinhDoNgoaiNguSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TrinhDoNgoaiNguColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoNgoaiNgu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TrinhDoNgoaiNguSortBuilder : SqlSortBuilder<TrinhDoNgoaiNguColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrinhDoNgoaiNguSqlSortBuilder class.
		/// </summary>
		public TrinhDoNgoaiNguSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TrinhDoNgoaiNguSortBuilder
	
} // end namespace
