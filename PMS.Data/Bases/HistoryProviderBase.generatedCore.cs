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
	/// This class is the base class for any <see cref="HistoryProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HistoryProviderBaseCore : EntityProviderBase<PMS.Entities.History, PMS.Entities.HistoryKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HistoryKey key)
		{
			return Delete(transactionManager, key.HistoryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_historyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int64 _historyId)
		{
			return Delete(null, _historyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_historyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int64 _historyId);		
		
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
		public override PMS.Entities.History Get(TransactionManager transactionManager, PMS.Entities.HistoryKey key, int start, int pageLength)
		{
			return GetByHistoryId(transactionManager, key.HistoryId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_History index.
		/// </summary>
		/// <param name="_historyId"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.History"/> class.</returns>
		public PMS.Entities.History GetByHistoryId(System.Int64 _historyId)
		{
			int count = -1;
			return GetByHistoryId(null,_historyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_History index.
		/// </summary>
		/// <param name="_historyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.History"/> class.</returns>
		public PMS.Entities.History GetByHistoryId(System.Int64 _historyId, int start, int pageLength)
		{
			int count = -1;
			return GetByHistoryId(null, _historyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_History index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_historyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.History"/> class.</returns>
		public PMS.Entities.History GetByHistoryId(TransactionManager transactionManager, System.Int64 _historyId)
		{
			int count = -1;
			return GetByHistoryId(transactionManager, _historyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_History index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_historyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.History"/> class.</returns>
		public PMS.Entities.History GetByHistoryId(TransactionManager transactionManager, System.Int64 _historyId, int start, int pageLength)
		{
			int count = -1;
			return GetByHistoryId(transactionManager, _historyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_History index.
		/// </summary>
		/// <param name="_historyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.History"/> class.</returns>
		public PMS.Entities.History GetByHistoryId(System.Int64 _historyId, int start, int pageLength, out int count)
		{
			return GetByHistoryId(null, _historyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_History index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_historyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.History"/> class.</returns>
		public abstract PMS.Entities.History GetByHistoryId(TransactionManager transactionManager, System.Int64 _historyId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;History&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;History&gt;"/></returns>
		public static TList<History> Fill(IDataReader reader, TList<History> rows, int start, int pageLength)
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
				
				PMS.Entities.History c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("History")
					.Append("|").Append((System.Int64)reader[((int)HistoryColumn.HistoryId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<History>(
					key.ToString(), // EntityTrackingKey
					"History",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.History();
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
					c.HistoryId = (System.Int64)reader[(HistoryColumn.HistoryId.ToString())];
					c.OldProfessor = (System.String)reader[(HistoryColumn.OldProfessor.ToString())];
					c.NewProfessor = (System.String)reader[(HistoryColumn.NewProfessor.ToString())];
					c.Username = (reader[HistoryColumn.Username.ToString()] == DBNull.Value) ? null : (System.String)reader[(HistoryColumn.Username.ToString())];
					c.ComputerName = (reader[HistoryColumn.ComputerName.ToString()] == DBNull.Value) ? null : (System.String)reader[(HistoryColumn.ComputerName.ToString())];
					c.UpdatedDate = (System.DateTime)reader[(HistoryColumn.UpdatedDate.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.History"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.History"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.History entity)
		{
			if (!reader.Read()) return;
			
			entity.HistoryId = (System.Int64)reader[(HistoryColumn.HistoryId.ToString())];
			entity.OldProfessor = (System.String)reader[(HistoryColumn.OldProfessor.ToString())];
			entity.NewProfessor = (System.String)reader[(HistoryColumn.NewProfessor.ToString())];
			entity.Username = (reader[HistoryColumn.Username.ToString()] == DBNull.Value) ? null : (System.String)reader[(HistoryColumn.Username.ToString())];
			entity.ComputerName = (reader[HistoryColumn.ComputerName.ToString()] == DBNull.Value) ? null : (System.String)reader[(HistoryColumn.ComputerName.ToString())];
			entity.UpdatedDate = (System.DateTime)reader[(HistoryColumn.UpdatedDate.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.History"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.History"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.History entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.HistoryId = (System.Int64)dataRow["HistoryID"];
			entity.OldProfessor = (System.String)dataRow["OldProfessor"];
			entity.NewProfessor = (System.String)dataRow["NewProfessor"];
			entity.Username = Convert.IsDBNull(dataRow["Username"]) ? null : (System.String)dataRow["Username"];
			entity.ComputerName = Convert.IsDBNull(dataRow["ComputerName"]) ? null : (System.String)dataRow["ComputerName"];
			entity.UpdatedDate = (System.DateTime)dataRow["UpdatedDate"];
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
		/// <param name="entity">The <see cref="PMS.Entities.History"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.History Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.History entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.History object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.History instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.History Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.History entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HistoryChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.History</c>
	///</summary>
	public enum HistoryChildEntityTypes
	{
	}
	
	#endregion HistoryChildEntityTypes
	
	#region HistoryFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HistoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="History"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HistoryFilterBuilder : SqlFilterBuilder<HistoryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HistoryFilterBuilder class.
		/// </summary>
		public HistoryFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HistoryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HistoryFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HistoryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HistoryFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HistoryFilterBuilder
	
	#region HistoryParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HistoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="History"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HistoryParameterBuilder : ParameterizedSqlFilterBuilder<HistoryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HistoryParameterBuilder class.
		/// </summary>
		public HistoryParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HistoryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HistoryParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HistoryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HistoryParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HistoryParameterBuilder
	
	#region HistorySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HistoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="History"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HistorySortBuilder : SqlSortBuilder<HistoryColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HistorySqlSortBuilder class.
		/// </summary>
		public HistorySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HistorySortBuilder
	
} // end namespace
