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
	/// This class is the base class for any <see cref="TienCongTacPhiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TienCongTacPhiProviderBaseCore : EntityProviderBase<PMS.Entities.TienCongTacPhi, PMS.Entities.TienCongTacPhiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.TienCongTacPhiKey key)
		{
			return Delete(transactionManager, key.MaCoSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maCoSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maCoSo)
		{
			return Delete(null, _maCoSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCoSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maCoSo);		
		
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
		public override PMS.Entities.TienCongTacPhi Get(TransactionManager transactionManager, PMS.Entities.TienCongTacPhiKey key, int start, int pageLength)
		{
			return GetByMaCoSo(transactionManager, key.MaCoSo, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_TienCongTacPhi index.
		/// </summary>
		/// <param name="_maCoSo"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TienCongTacPhi"/> class.</returns>
		public PMS.Entities.TienCongTacPhi GetByMaCoSo(System.String _maCoSo)
		{
			int count = -1;
			return GetByMaCoSo(null,_maCoSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TienCongTacPhi index.
		/// </summary>
		/// <param name="_maCoSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TienCongTacPhi"/> class.</returns>
		public PMS.Entities.TienCongTacPhi GetByMaCoSo(System.String _maCoSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCoSo(null, _maCoSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TienCongTacPhi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCoSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TienCongTacPhi"/> class.</returns>
		public PMS.Entities.TienCongTacPhi GetByMaCoSo(TransactionManager transactionManager, System.String _maCoSo)
		{
			int count = -1;
			return GetByMaCoSo(transactionManager, _maCoSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TienCongTacPhi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCoSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TienCongTacPhi"/> class.</returns>
		public PMS.Entities.TienCongTacPhi GetByMaCoSo(TransactionManager transactionManager, System.String _maCoSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCoSo(transactionManager, _maCoSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TienCongTacPhi index.
		/// </summary>
		/// <param name="_maCoSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TienCongTacPhi"/> class.</returns>
		public PMS.Entities.TienCongTacPhi GetByMaCoSo(System.String _maCoSo, int start, int pageLength, out int count)
		{
			return GetByMaCoSo(null, _maCoSo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TienCongTacPhi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCoSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TienCongTacPhi"/> class.</returns>
		public abstract PMS.Entities.TienCongTacPhi GetByMaCoSo(TransactionManager transactionManager, System.String _maCoSo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_TienCongTacPhi_GetByCoSo 
		
		/// <summary>
		///	This method wrap the 'cust_TienCongTacPhi_GetByCoSo' stored procedure. 
		/// </summary>
		/// <param name="maCoSo"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TienCongTacPhi&gt;"/> instance.</returns>
		public TList<TienCongTacPhi> GetByCoSo(System.String maCoSo)
		{
			return GetByCoSo(null, 0, int.MaxValue , maCoSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TienCongTacPhi_GetByCoSo' stored procedure. 
		/// </summary>
		/// <param name="maCoSo"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TienCongTacPhi&gt;"/> instance.</returns>
		public TList<TienCongTacPhi> GetByCoSo(int start, int pageLength, System.String maCoSo)
		{
			return GetByCoSo(null, start, pageLength , maCoSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TienCongTacPhi_GetByCoSo' stored procedure. 
		/// </summary>
		/// <param name="maCoSo"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TienCongTacPhi&gt;"/> instance.</returns>
		public TList<TienCongTacPhi> GetByCoSo(TransactionManager transactionManager, System.String maCoSo)
		{
			return GetByCoSo(transactionManager, 0, int.MaxValue , maCoSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TienCongTacPhi_GetByCoSo' stored procedure. 
		/// </summary>
		/// <param name="maCoSo"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TienCongTacPhi&gt;"/> instance.</returns>
		public abstract TList<TienCongTacPhi> GetByCoSo(TransactionManager transactionManager, int start, int pageLength , System.String maCoSo);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TienCongTacPhi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TienCongTacPhi&gt;"/></returns>
		public static TList<TienCongTacPhi> Fill(IDataReader reader, TList<TienCongTacPhi> rows, int start, int pageLength)
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
				
				PMS.Entities.TienCongTacPhi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TienCongTacPhi")
					.Append("|").Append((System.String)reader[((int)TienCongTacPhiColumn.MaCoSo - 1)]).ToString();
					c = EntityManager.LocateOrCreate<TienCongTacPhi>(
					key.ToString(), // EntityTrackingKey
					"TienCongTacPhi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.TienCongTacPhi();
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
					c.MaCoSo = (System.String)reader[(TienCongTacPhiColumn.MaCoSo.ToString())];
					c.OriginalMaCoSo = c.MaCoSo;
					c.TenCoSo = (reader[TienCongTacPhiColumn.TenCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(TienCongTacPhiColumn.TenCoSo.ToString())];
					c.SoTien = (reader[TienCongTacPhiColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TienCongTacPhiColumn.SoTien.ToString())];
					c.GhiChu = (reader[TienCongTacPhiColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(TienCongTacPhiColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TienCongTacPhi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TienCongTacPhi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.TienCongTacPhi entity)
		{
			if (!reader.Read()) return;
			
			entity.MaCoSo = (System.String)reader[(TienCongTacPhiColumn.MaCoSo.ToString())];
			entity.OriginalMaCoSo = (System.String)reader["MaCoSo"];
			entity.TenCoSo = (reader[TienCongTacPhiColumn.TenCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(TienCongTacPhiColumn.TenCoSo.ToString())];
			entity.SoTien = (reader[TienCongTacPhiColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TienCongTacPhiColumn.SoTien.ToString())];
			entity.GhiChu = (reader[TienCongTacPhiColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(TienCongTacPhiColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TienCongTacPhi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TienCongTacPhi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.TienCongTacPhi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaCoSo = (System.String)dataRow["MaCoSo"];
			entity.OriginalMaCoSo = (System.String)dataRow["MaCoSo"];
			entity.TenCoSo = Convert.IsDBNull(dataRow["TenCoSo"]) ? null : (System.String)dataRow["TenCoSo"];
			entity.SoTien = Convert.IsDBNull(dataRow["SoTien"]) ? null : (System.Decimal?)dataRow["SoTien"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.TienCongTacPhi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.TienCongTacPhi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.TienCongTacPhi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.TienCongTacPhi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.TienCongTacPhi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.TienCongTacPhi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.TienCongTacPhi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region TienCongTacPhiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.TienCongTacPhi</c>
	///</summary>
	public enum TienCongTacPhiChildEntityTypes
	{
	}
	
	#endregion TienCongTacPhiChildEntityTypes
	
	#region TienCongTacPhiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TienCongTacPhiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TienCongTacPhi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TienCongTacPhiFilterBuilder : SqlFilterBuilder<TienCongTacPhiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TienCongTacPhiFilterBuilder class.
		/// </summary>
		public TienCongTacPhiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TienCongTacPhiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TienCongTacPhiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TienCongTacPhiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TienCongTacPhiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TienCongTacPhiFilterBuilder
	
	#region TienCongTacPhiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TienCongTacPhiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TienCongTacPhi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TienCongTacPhiParameterBuilder : ParameterizedSqlFilterBuilder<TienCongTacPhiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TienCongTacPhiParameterBuilder class.
		/// </summary>
		public TienCongTacPhiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TienCongTacPhiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TienCongTacPhiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TienCongTacPhiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TienCongTacPhiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TienCongTacPhiParameterBuilder
	
	#region TienCongTacPhiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TienCongTacPhiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TienCongTacPhi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TienCongTacPhiSortBuilder : SqlSortBuilder<TienCongTacPhiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TienCongTacPhiSqlSortBuilder class.
		/// </summary>
		public TienCongTacPhiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TienCongTacPhiSortBuilder
	
} // end namespace
