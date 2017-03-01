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
	/// This class is the base class for any <see cref="SdhLoaiKhoiLuongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SdhLoaiKhoiLuongProviderBaseCore : EntityProviderBase<PMS.Entities.SdhLoaiKhoiLuong, PMS.Entities.SdhLoaiKhoiLuongKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.SdhLoaiKhoiLuongKey key)
		{
			return Delete(transactionManager, key.MaLoaiKhoiLuong);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLoaiKhoiLuong">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maLoaiKhoiLuong)
		{
			return Delete(null, _maLoaiKhoiLuong);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiKhoiLuong">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maLoaiKhoiLuong);		
		
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
		public override PMS.Entities.SdhLoaiKhoiLuong Get(TransactionManager transactionManager, PMS.Entities.SdhLoaiKhoiLuongKey key, int start, int pageLength)
		{
			return GetByMaLoaiKhoiLuong(transactionManager, key.MaLoaiKhoiLuong, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SdhLoaiKhoiLuong index.
		/// </summary>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhLoaiKhoiLuong"/> class.</returns>
		public PMS.Entities.SdhLoaiKhoiLuong GetByMaLoaiKhoiLuong(System.String _maLoaiKhoiLuong)
		{
			int count = -1;
			return GetByMaLoaiKhoiLuong(null,_maLoaiKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhLoaiKhoiLuong index.
		/// </summary>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhLoaiKhoiLuong"/> class.</returns>
		public PMS.Entities.SdhLoaiKhoiLuong GetByMaLoaiKhoiLuong(System.String _maLoaiKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiKhoiLuong(null, _maLoaiKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhLoaiKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhLoaiKhoiLuong"/> class.</returns>
		public PMS.Entities.SdhLoaiKhoiLuong GetByMaLoaiKhoiLuong(TransactionManager transactionManager, System.String _maLoaiKhoiLuong)
		{
			int count = -1;
			return GetByMaLoaiKhoiLuong(transactionManager, _maLoaiKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhLoaiKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhLoaiKhoiLuong"/> class.</returns>
		public PMS.Entities.SdhLoaiKhoiLuong GetByMaLoaiKhoiLuong(TransactionManager transactionManager, System.String _maLoaiKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiKhoiLuong(transactionManager, _maLoaiKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhLoaiKhoiLuong index.
		/// </summary>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhLoaiKhoiLuong"/> class.</returns>
		public PMS.Entities.SdhLoaiKhoiLuong GetByMaLoaiKhoiLuong(System.String _maLoaiKhoiLuong, int start, int pageLength, out int count)
		{
			return GetByMaLoaiKhoiLuong(null, _maLoaiKhoiLuong, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhLoaiKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhLoaiKhoiLuong"/> class.</returns>
		public abstract PMS.Entities.SdhLoaiKhoiLuong GetByMaLoaiKhoiLuong(TransactionManager transactionManager, System.String _maLoaiKhoiLuong, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SdhLoaiKhoiLuong&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SdhLoaiKhoiLuong&gt;"/></returns>
		public static TList<SdhLoaiKhoiLuong> Fill(IDataReader reader, TList<SdhLoaiKhoiLuong> rows, int start, int pageLength)
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
				
				PMS.Entities.SdhLoaiKhoiLuong c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SdhLoaiKhoiLuong")
					.Append("|").Append((System.String)reader[((int)SdhLoaiKhoiLuongColumn.MaLoaiKhoiLuong - 1)]).ToString();
					c = EntityManager.LocateOrCreate<SdhLoaiKhoiLuong>(
					key.ToString(), // EntityTrackingKey
					"SdhLoaiKhoiLuong",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.SdhLoaiKhoiLuong();
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
					c.MaLoaiKhoiLuong = (System.String)reader[(SdhLoaiKhoiLuongColumn.MaLoaiKhoiLuong.ToString())];
					c.OriginalMaLoaiKhoiLuong = c.MaLoaiKhoiLuong;
					c.MaNhom = (reader[SdhLoaiKhoiLuongColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhLoaiKhoiLuongColumn.MaNhom.ToString())];
					c.TenLoaiKhoiLuong = (reader[SdhLoaiKhoiLuongColumn.TenLoaiKhoiLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhLoaiKhoiLuongColumn.TenLoaiKhoiLuong.ToString())];
					c.NghiaVu = (reader[SdhLoaiKhoiLuongColumn.NghiaVu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(SdhLoaiKhoiLuongColumn.NghiaVu.ToString())];
					c.HeSo = (reader[SdhLoaiKhoiLuongColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhLoaiKhoiLuongColumn.HeSo.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SdhLoaiKhoiLuong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SdhLoaiKhoiLuong"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.SdhLoaiKhoiLuong entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLoaiKhoiLuong = (System.String)reader[(SdhLoaiKhoiLuongColumn.MaLoaiKhoiLuong.ToString())];
			entity.OriginalMaLoaiKhoiLuong = (System.String)reader["MaLoaiKhoiLuong"];
			entity.MaNhom = (reader[SdhLoaiKhoiLuongColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhLoaiKhoiLuongColumn.MaNhom.ToString())];
			entity.TenLoaiKhoiLuong = (reader[SdhLoaiKhoiLuongColumn.TenLoaiKhoiLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhLoaiKhoiLuongColumn.TenLoaiKhoiLuong.ToString())];
			entity.NghiaVu = (reader[SdhLoaiKhoiLuongColumn.NghiaVu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(SdhLoaiKhoiLuongColumn.NghiaVu.ToString())];
			entity.HeSo = (reader[SdhLoaiKhoiLuongColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhLoaiKhoiLuongColumn.HeSo.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SdhLoaiKhoiLuong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SdhLoaiKhoiLuong"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.SdhLoaiKhoiLuong entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLoaiKhoiLuong = (System.String)dataRow["MaLoaiKhoiLuong"];
			entity.OriginalMaLoaiKhoiLuong = (System.String)dataRow["MaLoaiKhoiLuong"];
			entity.MaNhom = Convert.IsDBNull(dataRow["MaNhom"]) ? null : (System.Int32?)dataRow["MaNhom"];
			entity.TenLoaiKhoiLuong = Convert.IsDBNull(dataRow["TenLoaiKhoiLuong"]) ? null : (System.String)dataRow["TenLoaiKhoiLuong"];
			entity.NghiaVu = Convert.IsDBNull(dataRow["NghiaVu"]) ? null : (System.Boolean?)dataRow["NghiaVu"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
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
		/// <param name="entity">The <see cref="PMS.Entities.SdhLoaiKhoiLuong"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.SdhLoaiKhoiLuong Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.SdhLoaiKhoiLuong entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.SdhLoaiKhoiLuong object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.SdhLoaiKhoiLuong instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.SdhLoaiKhoiLuong Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.SdhLoaiKhoiLuong entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region SdhLoaiKhoiLuongChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.SdhLoaiKhoiLuong</c>
	///</summary>
	public enum SdhLoaiKhoiLuongChildEntityTypes
	{
	}
	
	#endregion SdhLoaiKhoiLuongChildEntityTypes
	
	#region SdhLoaiKhoiLuongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SdhLoaiKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhLoaiKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhLoaiKhoiLuongFilterBuilder : SqlFilterBuilder<SdhLoaiKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhLoaiKhoiLuongFilterBuilder class.
		/// </summary>
		public SdhLoaiKhoiLuongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SdhLoaiKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SdhLoaiKhoiLuongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SdhLoaiKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SdhLoaiKhoiLuongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SdhLoaiKhoiLuongFilterBuilder
	
	#region SdhLoaiKhoiLuongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SdhLoaiKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhLoaiKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhLoaiKhoiLuongParameterBuilder : ParameterizedSqlFilterBuilder<SdhLoaiKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhLoaiKhoiLuongParameterBuilder class.
		/// </summary>
		public SdhLoaiKhoiLuongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SdhLoaiKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SdhLoaiKhoiLuongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SdhLoaiKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SdhLoaiKhoiLuongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SdhLoaiKhoiLuongParameterBuilder
	
	#region SdhLoaiKhoiLuongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SdhLoaiKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhLoaiKhoiLuong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SdhLoaiKhoiLuongSortBuilder : SqlSortBuilder<SdhLoaiKhoiLuongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhLoaiKhoiLuongSqlSortBuilder class.
		/// </summary>
		public SdhLoaiKhoiLuongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SdhLoaiKhoiLuongSortBuilder
	
} // end namespace
