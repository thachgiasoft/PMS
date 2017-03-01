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
	/// This class is the base class for any <see cref="PscUserConfigApplicationProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PscUserConfigApplicationProviderBaseCore : EntityProviderBase<PMS.Entities.PscUserConfigApplication, PMS.Entities.PscUserConfigApplicationKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.PscUserConfigApplicationKey key)
		{
			return Delete(transactionManager, key.StaffId, key.ConfigName);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_staffId">. Primary Key.</param>
		/// <param name="_configName">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _staffId, System.String _configName)
		{
			return Delete(null, _staffId, _configName);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staffId">. Primary Key.</param>
		/// <param name="_configName">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _staffId, System.String _configName);		
		
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
		public override PMS.Entities.PscUserConfigApplication Get(TransactionManager transactionManager, PMS.Entities.PscUserConfigApplicationKey key, int start, int pageLength)
		{
			return GetByStaffIdConfigName(transactionManager, key.StaffId, key.ConfigName, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_psc_UserConfigApplication index.
		/// </summary>
		/// <param name="_staffId"></param>
		/// <param name="_configName"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PscUserConfigApplication"/> class.</returns>
		public PMS.Entities.PscUserConfigApplication GetByStaffIdConfigName(System.String _staffId, System.String _configName)
		{
			int count = -1;
			return GetByStaffIdConfigName(null,_staffId, _configName, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_psc_UserConfigApplication index.
		/// </summary>
		/// <param name="_staffId"></param>
		/// <param name="_configName"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PscUserConfigApplication"/> class.</returns>
		public PMS.Entities.PscUserConfigApplication GetByStaffIdConfigName(System.String _staffId, System.String _configName, int start, int pageLength)
		{
			int count = -1;
			return GetByStaffIdConfigName(null, _staffId, _configName, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_psc_UserConfigApplication index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staffId"></param>
		/// <param name="_configName"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PscUserConfigApplication"/> class.</returns>
		public PMS.Entities.PscUserConfigApplication GetByStaffIdConfigName(TransactionManager transactionManager, System.String _staffId, System.String _configName)
		{
			int count = -1;
			return GetByStaffIdConfigName(transactionManager, _staffId, _configName, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_psc_UserConfigApplication index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staffId"></param>
		/// <param name="_configName"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PscUserConfigApplication"/> class.</returns>
		public PMS.Entities.PscUserConfigApplication GetByStaffIdConfigName(TransactionManager transactionManager, System.String _staffId, System.String _configName, int start, int pageLength)
		{
			int count = -1;
			return GetByStaffIdConfigName(transactionManager, _staffId, _configName, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_psc_UserConfigApplication index.
		/// </summary>
		/// <param name="_staffId"></param>
		/// <param name="_configName"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PscUserConfigApplication"/> class.</returns>
		public PMS.Entities.PscUserConfigApplication GetByStaffIdConfigName(System.String _staffId, System.String _configName, int start, int pageLength, out int count)
		{
			return GetByStaffIdConfigName(null, _staffId, _configName, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_psc_UserConfigApplication index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staffId"></param>
		/// <param name="_configName"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PscUserConfigApplication"/> class.</returns>
		public abstract PMS.Entities.PscUserConfigApplication GetByStaffIdConfigName(TransactionManager transactionManager, System.String _staffId, System.String _configName, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PscUserConfigApplication&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PscUserConfigApplication&gt;"/></returns>
		public static TList<PscUserConfigApplication> Fill(IDataReader reader, TList<PscUserConfigApplication> rows, int start, int pageLength)
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
				
				PMS.Entities.PscUserConfigApplication c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PscUserConfigApplication")
					.Append("|").Append((System.String)reader[((int)PscUserConfigApplicationColumn.StaffId - 1)])
					.Append("|").Append((System.String)reader[((int)PscUserConfigApplicationColumn.ConfigName - 1)]).ToString();
					c = EntityManager.LocateOrCreate<PscUserConfigApplication>(
					key.ToString(), // EntityTrackingKey
					"PscUserConfigApplication",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.PscUserConfigApplication();
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
					c.StaffId = (System.String)reader[(PscUserConfigApplicationColumn.StaffId.ToString())];
					c.OriginalStaffId = c.StaffId;
					c.ConfigName = (System.String)reader[(PscUserConfigApplicationColumn.ConfigName.ToString())];
					c.OriginalConfigName = c.ConfigName;
					c.ConfigValue = (System.String)reader[(PscUserConfigApplicationColumn.ConfigValue.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.PscUserConfigApplication"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.PscUserConfigApplication"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.PscUserConfigApplication entity)
		{
			if (!reader.Read()) return;
			
			entity.StaffId = (System.String)reader[(PscUserConfigApplicationColumn.StaffId.ToString())];
			entity.OriginalStaffId = (System.String)reader["StaffID"];
			entity.ConfigName = (System.String)reader[(PscUserConfigApplicationColumn.ConfigName.ToString())];
			entity.OriginalConfigName = (System.String)reader["ConfigName"];
			entity.ConfigValue = (System.String)reader[(PscUserConfigApplicationColumn.ConfigValue.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.PscUserConfigApplication"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.PscUserConfigApplication"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.PscUserConfigApplication entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.StaffId = (System.String)dataRow["StaffID"];
			entity.OriginalStaffId = (System.String)dataRow["StaffID"];
			entity.ConfigName = (System.String)dataRow["ConfigName"];
			entity.OriginalConfigName = (System.String)dataRow["ConfigName"];
			entity.ConfigValue = (System.String)dataRow["ConfigValue"];
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
		/// <param name="entity">The <see cref="PMS.Entities.PscUserConfigApplication"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.PscUserConfigApplication Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.PscUserConfigApplication entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
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
		/// Deep Save the entire object graph of the PMS.Entities.PscUserConfigApplication object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.PscUserConfigApplication instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.PscUserConfigApplication Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.PscUserConfigApplication entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region PscUserConfigApplicationChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.PscUserConfigApplication</c>
	///</summary>
	public enum PscUserConfigApplicationChildEntityTypes
	{
	}
	
	#endregion PscUserConfigApplicationChildEntityTypes
	
	#region PscUserConfigApplicationFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PscUserConfigApplicationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PscUserConfigApplication"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PscUserConfigApplicationFilterBuilder : SqlFilterBuilder<PscUserConfigApplicationColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PscUserConfigApplicationFilterBuilder class.
		/// </summary>
		public PscUserConfigApplicationFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PscUserConfigApplicationFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PscUserConfigApplicationFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PscUserConfigApplicationFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PscUserConfigApplicationFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PscUserConfigApplicationFilterBuilder
	
	#region PscUserConfigApplicationParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PscUserConfigApplicationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PscUserConfigApplication"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PscUserConfigApplicationParameterBuilder : ParameterizedSqlFilterBuilder<PscUserConfigApplicationColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PscUserConfigApplicationParameterBuilder class.
		/// </summary>
		public PscUserConfigApplicationParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PscUserConfigApplicationParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PscUserConfigApplicationParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PscUserConfigApplicationParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PscUserConfigApplicationParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PscUserConfigApplicationParameterBuilder
	
	#region PscUserConfigApplicationSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PscUserConfigApplicationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PscUserConfigApplication"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PscUserConfigApplicationSortBuilder : SqlSortBuilder<PscUserConfigApplicationColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PscUserConfigApplicationSqlSortBuilder class.
		/// </summary>
		public PscUserConfigApplicationSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PscUserConfigApplicationSortBuilder
	
} // end namespace
