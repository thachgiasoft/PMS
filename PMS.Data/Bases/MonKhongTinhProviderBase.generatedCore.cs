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
	/// This class is the base class for any <see cref="MonKhongTinhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MonKhongTinhProviderBaseCore : EntityProviderBase<PMS.Entities.MonKhongTinh, PMS.Entities.MonKhongTinhKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.MonKhongTinhKey key)
		{
			return Delete(transactionManager, key.MaMonHoc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maMonHoc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maMonHoc)
		{
			return Delete(null, _maMonHoc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maMonHoc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maMonHoc);		
		
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
		public override PMS.Entities.MonKhongTinh Get(TransactionManager transactionManager, PMS.Entities.MonKhongTinhKey key, int start, int pageLength)
		{
			return GetByMaMonHoc(transactionManager, key.MaMonHoc, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MonKhongTinh index.
		/// </summary>
		/// <param name="_maMonHoc"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.MonKhongTinh"/> class.</returns>
		public PMS.Entities.MonKhongTinh GetByMaMonHoc(System.String _maMonHoc)
		{
			int count = -1;
			return GetByMaMonHoc(null,_maMonHoc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MonKhongTinh index.
		/// </summary>
		/// <param name="_maMonHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.MonKhongTinh"/> class.</returns>
		public PMS.Entities.MonKhongTinh GetByMaMonHoc(System.String _maMonHoc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaMonHoc(null, _maMonHoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MonKhongTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maMonHoc"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.MonKhongTinh"/> class.</returns>
		public PMS.Entities.MonKhongTinh GetByMaMonHoc(TransactionManager transactionManager, System.String _maMonHoc)
		{
			int count = -1;
			return GetByMaMonHoc(transactionManager, _maMonHoc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MonKhongTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maMonHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.MonKhongTinh"/> class.</returns>
		public PMS.Entities.MonKhongTinh GetByMaMonHoc(TransactionManager transactionManager, System.String _maMonHoc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaMonHoc(transactionManager, _maMonHoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MonKhongTinh index.
		/// </summary>
		/// <param name="_maMonHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.MonKhongTinh"/> class.</returns>
		public PMS.Entities.MonKhongTinh GetByMaMonHoc(System.String _maMonHoc, int start, int pageLength, out int count)
		{
			return GetByMaMonHoc(null, _maMonHoc, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MonKhongTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maMonHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.MonKhongTinh"/> class.</returns>
		public abstract PMS.Entities.MonKhongTinh GetByMaMonHoc(TransactionManager transactionManager, System.String _maMonHoc, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MonKhongTinh&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MonKhongTinh&gt;"/></returns>
		public static TList<MonKhongTinh> Fill(IDataReader reader, TList<MonKhongTinh> rows, int start, int pageLength)
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
				
				PMS.Entities.MonKhongTinh c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MonKhongTinh")
					.Append("|").Append((System.String)reader[((int)MonKhongTinhColumn.MaMonHoc - 1)]).ToString();
					c = EntityManager.LocateOrCreate<MonKhongTinh>(
					key.ToString(), // EntityTrackingKey
					"MonKhongTinh",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.MonKhongTinh();
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
					c.MaMonHoc = (System.String)reader[(MonKhongTinhColumn.MaMonHoc.ToString())];
					c.OriginalMaMonHoc = c.MaMonHoc;
					c.NgayTao = (reader[MonKhongTinhColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(MonKhongTinhColumn.NgayTao.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.MonKhongTinh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.MonKhongTinh"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.MonKhongTinh entity)
		{
			if (!reader.Read()) return;
			
			entity.MaMonHoc = (System.String)reader[(MonKhongTinhColumn.MaMonHoc.ToString())];
			entity.OriginalMaMonHoc = (System.String)reader["MaMonHoc"];
			entity.NgayTao = (reader[MonKhongTinhColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(MonKhongTinhColumn.NgayTao.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.MonKhongTinh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.MonKhongTinh"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.MonKhongTinh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaMonHoc = (System.String)dataRow["MaMonHoc"];
			entity.OriginalMaMonHoc = (System.String)dataRow["MaMonHoc"];
			entity.NgayTao = Convert.IsDBNull(dataRow["NgayTao"]) ? null : (System.DateTime?)dataRow["NgayTao"];
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
		/// <param name="entity">The <see cref="PMS.Entities.MonKhongTinh"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.MonKhongTinh Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.MonKhongTinh entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.MonKhongTinh object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.MonKhongTinh instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.MonKhongTinh Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.MonKhongTinh entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region MonKhongTinhChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.MonKhongTinh</c>
	///</summary>
	public enum MonKhongTinhChildEntityTypes
	{
	}
	
	#endregion MonKhongTinhChildEntityTypes
	
	#region MonKhongTinhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MonKhongTinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonKhongTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonKhongTinhFilterBuilder : SqlFilterBuilder<MonKhongTinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonKhongTinhFilterBuilder class.
		/// </summary>
		public MonKhongTinhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MonKhongTinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MonKhongTinhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MonKhongTinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MonKhongTinhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MonKhongTinhFilterBuilder
	
	#region MonKhongTinhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MonKhongTinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonKhongTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonKhongTinhParameterBuilder : ParameterizedSqlFilterBuilder<MonKhongTinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonKhongTinhParameterBuilder class.
		/// </summary>
		public MonKhongTinhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MonKhongTinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MonKhongTinhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MonKhongTinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MonKhongTinhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MonKhongTinhParameterBuilder
	
	#region MonKhongTinhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MonKhongTinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonKhongTinh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MonKhongTinhSortBuilder : SqlSortBuilder<MonKhongTinhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonKhongTinhSqlSortBuilder class.
		/// </summary>
		public MonKhongTinhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MonKhongTinhSortBuilder
	
} // end namespace
