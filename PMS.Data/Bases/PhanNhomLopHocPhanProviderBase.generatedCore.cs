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
	/// This class is the base class for any <see cref="PhanNhomLopHocPhanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PhanNhomLopHocPhanProviderBaseCore : EntityProviderBase<PMS.Entities.PhanNhomLopHocPhan, PMS.Entities.PhanNhomLopHocPhanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.PhanNhomLopHocPhanKey key)
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
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PhanNhomLopHocPhan_NhomMonHoc key.
		///		FK_PhanNhomLopHocPhan_NhomMonHoc Description: 
		/// </summary>
		/// <param name="_maNhomMon"></param>
		/// <returns>Returns a typed collection of PMS.Entities.PhanNhomLopHocPhan objects.</returns>
		public TList<PhanNhomLopHocPhan> GetByMaNhomMon(System.Int32 _maNhomMon)
		{
			int count = -1;
			return GetByMaNhomMon(_maNhomMon, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PhanNhomLopHocPhan_NhomMonHoc key.
		///		FK_PhanNhomLopHocPhan_NhomMonHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <returns>Returns a typed collection of PMS.Entities.PhanNhomLopHocPhan objects.</returns>
		/// <remarks></remarks>
		public TList<PhanNhomLopHocPhan> GetByMaNhomMon(TransactionManager transactionManager, System.Int32 _maNhomMon)
		{
			int count = -1;
			return GetByMaNhomMon(transactionManager, _maNhomMon, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PhanNhomLopHocPhan_NhomMonHoc key.
		///		FK_PhanNhomLopHocPhan_NhomMonHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.PhanNhomLopHocPhan objects.</returns>
		public TList<PhanNhomLopHocPhan> GetByMaNhomMon(TransactionManager transactionManager, System.Int32 _maNhomMon, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomMon(transactionManager, _maNhomMon, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PhanNhomLopHocPhan_NhomMonHoc key.
		///		fkPhanNhomLopHocPhanNhomMonHoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhomMon"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.PhanNhomLopHocPhan objects.</returns>
		public TList<PhanNhomLopHocPhan> GetByMaNhomMon(System.Int32 _maNhomMon, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaNhomMon(null, _maNhomMon, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PhanNhomLopHocPhan_NhomMonHoc key.
		///		fkPhanNhomLopHocPhanNhomMonHoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhomMon"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.PhanNhomLopHocPhan objects.</returns>
		public TList<PhanNhomLopHocPhan> GetByMaNhomMon(System.Int32 _maNhomMon, int start, int pageLength,out int count)
		{
			return GetByMaNhomMon(null, _maNhomMon, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PhanNhomLopHocPhan_NhomMonHoc key.
		///		FK_PhanNhomLopHocPhan_NhomMonHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.PhanNhomLopHocPhan objects.</returns>
		public abstract TList<PhanNhomLopHocPhan> GetByMaNhomMon(TransactionManager transactionManager, System.Int32 _maNhomMon, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.PhanNhomLopHocPhan Get(TransactionManager transactionManager, PMS.Entities.PhanNhomLopHocPhanKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PhanNhomLopHocPhan index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanNhomLopHocPhan"/> class.</returns>
		public PMS.Entities.PhanNhomLopHocPhan GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanNhomLopHocPhan index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanNhomLopHocPhan"/> class.</returns>
		public PMS.Entities.PhanNhomLopHocPhan GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanNhomLopHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanNhomLopHocPhan"/> class.</returns>
		public PMS.Entities.PhanNhomLopHocPhan GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanNhomLopHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanNhomLopHocPhan"/> class.</returns>
		public PMS.Entities.PhanNhomLopHocPhan GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanNhomLopHocPhan index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanNhomLopHocPhan"/> class.</returns>
		public PMS.Entities.PhanNhomLopHocPhan GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanNhomLopHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanNhomLopHocPhan"/> class.</returns>
		public abstract PMS.Entities.PhanNhomLopHocPhan GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PhanNhomLopHocPhan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PhanNhomLopHocPhan&gt;"/></returns>
		public static TList<PhanNhomLopHocPhan> Fill(IDataReader reader, TList<PhanNhomLopHocPhan> rows, int start, int pageLength)
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
				
				PMS.Entities.PhanNhomLopHocPhan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PhanNhomLopHocPhan")
					.Append("|").Append((System.Int32)reader[((int)PhanNhomLopHocPhanColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<PhanNhomLopHocPhan>(
					key.ToString(), // EntityTrackingKey
					"PhanNhomLopHocPhan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.PhanNhomLopHocPhan();
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
					c.Id = (System.Int32)reader[((int)PhanNhomLopHocPhanColumn.Id - 1)];
					c.OriginalId = c.Id;
					c.MaNhomMon = (System.Int32)reader[((int)PhanNhomLopHocPhanColumn.MaNhomMon - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.PhanNhomLopHocPhan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.PhanNhomLopHocPhan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.PhanNhomLopHocPhan entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[((int)PhanNhomLopHocPhanColumn.Id - 1)];
			entity.OriginalId = (System.Int32)reader["Id"];
			entity.MaNhomMon = (System.Int32)reader[((int)PhanNhomLopHocPhanColumn.MaNhomMon - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.PhanNhomLopHocPhan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.PhanNhomLopHocPhan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.PhanNhomLopHocPhan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.OriginalId = (System.Int32)dataRow["Id"];
			entity.MaNhomMon = (System.Int32)dataRow["MaNhomMon"];
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
		/// <param name="entity">The <see cref="PMS.Entities.PhanNhomLopHocPhan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.PhanNhomLopHocPhan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.PhanNhomLopHocPhan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaNhomMonSource	
			if (CanDeepLoad(entity, "NhomMonHoc|MaNhomMonSource", deepLoadType, innerList) 
				&& entity.MaNhomMonSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MaNhomMon;
				NhomMonHoc tmpEntity = EntityManager.LocateEntity<NhomMonHoc>(EntityLocator.ConstructKeyFromPkItems(typeof(NhomMonHoc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaNhomMonSource = tmpEntity;
				else
					entity.MaNhomMonSource = DataRepository.NhomMonHocProvider.GetByMaNhomMon(transactionManager, entity.MaNhomMon);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaNhomMonSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaNhomMonSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.NhomMonHocProvider.DeepLoad(transactionManager, entity.MaNhomMonSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaNhomMonSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.PhanNhomLopHocPhan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.PhanNhomLopHocPhan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.PhanNhomLopHocPhan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.PhanNhomLopHocPhan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaNhomMonSource
			if (CanDeepSave(entity, "NhomMonHoc|MaNhomMonSource", deepSaveType, innerList) 
				&& entity.MaNhomMonSource != null)
			{
				DataRepository.NhomMonHocProvider.Save(transactionManager, entity.MaNhomMonSource);
				entity.MaNhomMon = entity.MaNhomMonSource.MaNhomMon;
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
	
	#region PhanNhomLopHocPhanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.PhanNhomLopHocPhan</c>
	///</summary>
	public enum PhanNhomLopHocPhanChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>NhomMonHoc</c> at MaNhomMonSource
		///</summary>
		[ChildEntityType(typeof(NhomMonHoc))]
		NhomMonHoc,
		}
	
	#endregion PhanNhomLopHocPhanChildEntityTypes
	
	#region PhanNhomLopHocPhanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PhanNhomLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanNhomLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanNhomLopHocPhanFilterBuilder : SqlFilterBuilder<PhanNhomLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanNhomLopHocPhanFilterBuilder class.
		/// </summary>
		public PhanNhomLopHocPhanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PhanNhomLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PhanNhomLopHocPhanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PhanNhomLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PhanNhomLopHocPhanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PhanNhomLopHocPhanFilterBuilder
	
	#region PhanNhomLopHocPhanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PhanNhomLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanNhomLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanNhomLopHocPhanParameterBuilder : ParameterizedSqlFilterBuilder<PhanNhomLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanNhomLopHocPhanParameterBuilder class.
		/// </summary>
		public PhanNhomLopHocPhanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PhanNhomLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PhanNhomLopHocPhanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PhanNhomLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PhanNhomLopHocPhanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PhanNhomLopHocPhanParameterBuilder
	
	#region PhanNhomLopHocPhanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PhanNhomLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanNhomLopHocPhan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PhanNhomLopHocPhanSortBuilder : SqlSortBuilder<PhanNhomLopHocPhanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanNhomLopHocPhanSqlSortBuilder class.
		/// </summary>
		public PhanNhomLopHocPhanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PhanNhomLopHocPhanSortBuilder
	
} // end namespace
