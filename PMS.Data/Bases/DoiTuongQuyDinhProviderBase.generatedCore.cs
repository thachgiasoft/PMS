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
	/// This class is the base class for any <see cref="DoiTuongQuyDinhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DoiTuongQuyDinhProviderBaseCore : EntityProviderBase<PMS.Entities.DoiTuongQuyDinh, PMS.Entities.DoiTuongQuyDinhKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DoiTuongQuyDinhKey key)
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
		public override PMS.Entities.DoiTuongQuyDinh Get(TransactionManager transactionManager, PMS.Entities.DoiTuongQuyDinhKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__DoiTuong__3214EC27B79501BE index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DoiTuongQuyDinh"/> class.</returns>
		public PMS.Entities.DoiTuongQuyDinh GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DoiTuong__3214EC27B79501BE index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DoiTuongQuyDinh"/> class.</returns>
		public PMS.Entities.DoiTuongQuyDinh GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DoiTuong__3214EC27B79501BE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DoiTuongQuyDinh"/> class.</returns>
		public PMS.Entities.DoiTuongQuyDinh GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DoiTuong__3214EC27B79501BE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DoiTuongQuyDinh"/> class.</returns>
		public PMS.Entities.DoiTuongQuyDinh GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DoiTuong__3214EC27B79501BE index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DoiTuongQuyDinh"/> class.</returns>
		public PMS.Entities.DoiTuongQuyDinh GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__DoiTuong__3214EC27B79501BE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DoiTuongQuyDinh"/> class.</returns>
		public abstract PMS.Entities.DoiTuongQuyDinh GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DoiTuongQuyDinh&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DoiTuongQuyDinh&gt;"/></returns>
		public static TList<DoiTuongQuyDinh> Fill(IDataReader reader, TList<DoiTuongQuyDinh> rows, int start, int pageLength)
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
				
				PMS.Entities.DoiTuongQuyDinh c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DoiTuongQuyDinh")
					.Append("|").Append((System.Int32)reader[((int)DoiTuongQuyDinhColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DoiTuongQuyDinh>(
					key.ToString(), // EntityTrackingKey
					"DoiTuongQuyDinh",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DoiTuongQuyDinh();
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
					c.Id = (System.Int32)reader[(DoiTuongQuyDinhColumn.Id.ToString())];
					c.MaQuanLy = (reader[DoiTuongQuyDinhColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DoiTuongQuyDinhColumn.MaQuanLy.ToString())];
					c.TenDoiTuong = (reader[DoiTuongQuyDinhColumn.TenDoiTuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(DoiTuongQuyDinhColumn.TenDoiTuong.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DoiTuongQuyDinh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DoiTuongQuyDinh"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DoiTuongQuyDinh entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(DoiTuongQuyDinhColumn.Id.ToString())];
			entity.MaQuanLy = (reader[DoiTuongQuyDinhColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DoiTuongQuyDinhColumn.MaQuanLy.ToString())];
			entity.TenDoiTuong = (reader[DoiTuongQuyDinhColumn.TenDoiTuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(DoiTuongQuyDinhColumn.TenDoiTuong.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DoiTuongQuyDinh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DoiTuongQuyDinh"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DoiTuongQuyDinh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["ID"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.TenDoiTuong = Convert.IsDBNull(dataRow["TenDoiTuong"]) ? null : (System.String)dataRow["TenDoiTuong"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DoiTuongQuyDinh"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DoiTuongQuyDinh Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DoiTuongQuyDinh entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetById methods when available
			
			#region QuyDinhTienCanTrenCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<QuyDinhTienCanTren>|QuyDinhTienCanTrenCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'QuyDinhTienCanTrenCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.QuyDinhTienCanTrenCollection = DataRepository.QuyDinhTienCanTrenProvider.GetByMaDoiTuong(transactionManager, entity.Id);

				if (deep && entity.QuyDinhTienCanTrenCollection.Count > 0)
				{
					deepHandles.Add("QuyDinhTienCanTrenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<QuyDinhTienCanTren>) DataRepository.QuyDinhTienCanTrenProvider.DeepLoad,
						new object[] { transactionManager, entity.QuyDinhTienCanTrenCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.DoiTuongQuyDinh object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DoiTuongQuyDinh instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DoiTuongQuyDinh Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DoiTuongQuyDinh entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
						if(child.MaDoiTuongSource != null)
						{
							child.MaDoiTuong = child.MaDoiTuongSource.Id;
						}
						else
						{
							child.MaDoiTuong = entity.Id;
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
	
	#region DoiTuongQuyDinhChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DoiTuongQuyDinh</c>
	///</summary>
	public enum DoiTuongQuyDinhChildEntityTypes
	{
		///<summary>
		/// Collection of <c>DoiTuongQuyDinh</c> as OneToMany for QuyDinhTienCanTrenCollection
		///</summary>
		[ChildEntityType(typeof(TList<QuyDinhTienCanTren>))]
		QuyDinhTienCanTrenCollection,
	}
	
	#endregion DoiTuongQuyDinhChildEntityTypes
	
	#region DoiTuongQuyDinhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DoiTuongQuyDinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DoiTuongQuyDinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DoiTuongQuyDinhFilterBuilder : SqlFilterBuilder<DoiTuongQuyDinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DoiTuongQuyDinhFilterBuilder class.
		/// </summary>
		public DoiTuongQuyDinhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DoiTuongQuyDinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DoiTuongQuyDinhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DoiTuongQuyDinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DoiTuongQuyDinhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DoiTuongQuyDinhFilterBuilder
	
	#region DoiTuongQuyDinhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DoiTuongQuyDinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DoiTuongQuyDinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DoiTuongQuyDinhParameterBuilder : ParameterizedSqlFilterBuilder<DoiTuongQuyDinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DoiTuongQuyDinhParameterBuilder class.
		/// </summary>
		public DoiTuongQuyDinhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DoiTuongQuyDinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DoiTuongQuyDinhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DoiTuongQuyDinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DoiTuongQuyDinhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DoiTuongQuyDinhParameterBuilder
	
	#region DoiTuongQuyDinhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DoiTuongQuyDinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DoiTuongQuyDinh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DoiTuongQuyDinhSortBuilder : SqlSortBuilder<DoiTuongQuyDinhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DoiTuongQuyDinhSqlSortBuilder class.
		/// </summary>
		public DoiTuongQuyDinhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DoiTuongQuyDinhSortBuilder
	
} // end namespace
