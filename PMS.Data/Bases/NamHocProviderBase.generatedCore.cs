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
	/// This class is the base class for any <see cref="NamHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class NamHocProviderBaseCore : EntityProviderBase<PMS.Entities.NamHoc, PMS.Entities.NamHocKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.NamHocKey key)
		{
			return Delete(transactionManager, key.NamHoc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_namHoc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _namHoc)
		{
			return Delete(null, _namHoc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _namHoc);		
		
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
		public override PMS.Entities.NamHoc Get(TransactionManager transactionManager, PMS.Entities.NamHocKey key, int start, int pageLength)
		{
			return GetByNamHoc(transactionManager, key.NamHoc, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_NamHoc index.
		/// </summary>
		/// <param name="_namHoc"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NamHoc"/> class.</returns>
		public PMS.Entities.NamHoc GetByNamHoc(System.String _namHoc)
		{
			int count = -1;
			return GetByNamHoc(null,_namHoc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NamHoc index.
		/// </summary>
		/// <param name="_namHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NamHoc"/> class.</returns>
		public PMS.Entities.NamHoc GetByNamHoc(System.String _namHoc, int start, int pageLength)
		{
			int count = -1;
			return GetByNamHoc(null, _namHoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NamHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NamHoc"/> class.</returns>
		public PMS.Entities.NamHoc GetByNamHoc(TransactionManager transactionManager, System.String _namHoc)
		{
			int count = -1;
			return GetByNamHoc(transactionManager, _namHoc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NamHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NamHoc"/> class.</returns>
		public PMS.Entities.NamHoc GetByNamHoc(TransactionManager transactionManager, System.String _namHoc, int start, int pageLength)
		{
			int count = -1;
			return GetByNamHoc(transactionManager, _namHoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NamHoc index.
		/// </summary>
		/// <param name="_namHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NamHoc"/> class.</returns>
		public PMS.Entities.NamHoc GetByNamHoc(System.String _namHoc, int start, int pageLength, out int count)
		{
			return GetByNamHoc(null, _namHoc, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NamHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_namHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NamHoc"/> class.</returns>
		public abstract PMS.Entities.NamHoc GetByNamHoc(TransactionManager transactionManager, System.String _namHoc, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;NamHoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;NamHoc&gt;"/></returns>
		public static TList<NamHoc> Fill(IDataReader reader, TList<NamHoc> rows, int start, int pageLength)
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
				
				PMS.Entities.NamHoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("NamHoc")
					.Append("|").Append((System.String)reader[((int)NamHocColumn.NamHoc - 1)]).ToString();
					c = EntityManager.LocateOrCreate<NamHoc>(
					key.ToString(), // EntityTrackingKey
					"NamHoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.NamHoc();
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
					c.NamHoc = (System.String)reader[(NamHocColumn.NamHoc.ToString())];
					c.OriginalNamHoc = c.NamHoc;
					c.NgayBatDau = (reader[NamHocColumn.NgayBatDau.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(NamHocColumn.NgayBatDau.ToString())];
					c.NgayKetThuc = (reader[NamHocColumn.NgayKetThuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(NamHocColumn.NgayKetThuc.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NamHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NamHoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.NamHoc entity)
		{
			if (!reader.Read()) return;
			
			entity.NamHoc = (System.String)reader[(NamHocColumn.NamHoc.ToString())];
			entity.OriginalNamHoc = (System.String)reader["NamHoc"];
			entity.NgayBatDau = (reader[NamHocColumn.NgayBatDau.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(NamHocColumn.NgayBatDau.ToString())];
			entity.NgayKetThuc = (reader[NamHocColumn.NgayKetThuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(NamHocColumn.NgayKetThuc.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NamHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NamHoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.NamHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.NamHoc = (System.String)dataRow["NamHoc"];
			entity.OriginalNamHoc = (System.String)dataRow["NamHoc"];
			entity.NgayBatDau = Convert.IsDBNull(dataRow["NgayBatDau"]) ? null : (System.DateTime?)dataRow["NgayBatDau"];
			entity.NgayKetThuc = Convert.IsDBNull(dataRow["NgayKetThuc"]) ? null : (System.DateTime?)dataRow["NgayKetThuc"];
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
		/// <param name="entity">The <see cref="PMS.Entities.NamHoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.NamHoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.NamHoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.NamHoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.NamHoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.NamHoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.NamHoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region NamHocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.NamHoc</c>
	///</summary>
	public enum NamHocChildEntityTypes
	{
	}
	
	#endregion NamHocChildEntityTypes
	
	#region NamHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;NamHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NamHocFilterBuilder : SqlFilterBuilder<NamHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NamHocFilterBuilder class.
		/// </summary>
		public NamHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NamHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NamHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NamHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NamHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NamHocFilterBuilder
	
	#region NamHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;NamHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NamHocParameterBuilder : ParameterizedSqlFilterBuilder<NamHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NamHocParameterBuilder class.
		/// </summary>
		public NamHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NamHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NamHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NamHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NamHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NamHocParameterBuilder
	
	#region NamHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;NamHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NamHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class NamHocSortBuilder : SqlSortBuilder<NamHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NamHocSqlSortBuilder class.
		/// </summary>
		public NamHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion NamHocSortBuilder
	
} // end namespace
