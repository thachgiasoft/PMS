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
	/// This class is the base class for any <see cref="DonGiaMotTietProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DonGiaMotTietProviderBaseCore : EntityProviderBase<PMS.Entities.DonGiaMotTiet, PMS.Entities.DonGiaMotTietKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DonGiaMotTietKey key)
		{
			return Delete(transactionManager, key.MaHocHam, key.MaHocVi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maHocHam">. Primary Key.</param>
		/// <param name="_maHocVi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maHocHam, System.String _maHocVi)
		{
			return Delete(null, _maHocHam, _maHocVi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam">. Primary Key.</param>
		/// <param name="_maHocVi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maHocHam, System.String _maHocVi);		
		
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
		public override PMS.Entities.DonGiaMotTiet Get(TransactionManager transactionManager, PMS.Entities.DonGiaMotTietKey key, int start, int pageLength)
		{
			return GetByMaHocHamMaHocVi(transactionManager, key.MaHocHam, key.MaHocVi, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DonGiaMotTiet index.
		/// </summary>
		/// <param name="_maHocHam"></param>
		/// <param name="_maHocVi"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaMotTiet"/> class.</returns>
		public PMS.Entities.DonGiaMotTiet GetByMaHocHamMaHocVi(System.String _maHocHam, System.String _maHocVi)
		{
			int count = -1;
			return GetByMaHocHamMaHocVi(null,_maHocHam, _maHocVi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaMotTiet index.
		/// </summary>
		/// <param name="_maHocHam"></param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaMotTiet"/> class.</returns>
		public PMS.Entities.DonGiaMotTiet GetByMaHocHamMaHocVi(System.String _maHocHam, System.String _maHocVi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocHamMaHocVi(null, _maHocHam, _maHocVi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaMotTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <param name="_maHocVi"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaMotTiet"/> class.</returns>
		public PMS.Entities.DonGiaMotTiet GetByMaHocHamMaHocVi(TransactionManager transactionManager, System.String _maHocHam, System.String _maHocVi)
		{
			int count = -1;
			return GetByMaHocHamMaHocVi(transactionManager, _maHocHam, _maHocVi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaMotTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaMotTiet"/> class.</returns>
		public PMS.Entities.DonGiaMotTiet GetByMaHocHamMaHocVi(TransactionManager transactionManager, System.String _maHocHam, System.String _maHocVi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocHamMaHocVi(transactionManager, _maHocHam, _maHocVi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaMotTiet index.
		/// </summary>
		/// <param name="_maHocHam"></param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaMotTiet"/> class.</returns>
		public PMS.Entities.DonGiaMotTiet GetByMaHocHamMaHocVi(System.String _maHocHam, System.String _maHocVi, int start, int pageLength, out int count)
		{
			return GetByMaHocHamMaHocVi(null, _maHocHam, _maHocVi, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaMotTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocHam"></param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaMotTiet"/> class.</returns>
		public abstract PMS.Entities.DonGiaMotTiet GetByMaHocHamMaHocVi(TransactionManager transactionManager, System.String _maHocHam, System.String _maHocVi, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DonGiaMotTiet&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DonGiaMotTiet&gt;"/></returns>
		public static TList<DonGiaMotTiet> Fill(IDataReader reader, TList<DonGiaMotTiet> rows, int start, int pageLength)
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
				
				PMS.Entities.DonGiaMotTiet c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DonGiaMotTiet")
					.Append("|").Append((System.String)reader[((int)DonGiaMotTietColumn.MaHocHam - 1)])
					.Append("|").Append((System.String)reader[((int)DonGiaMotTietColumn.MaHocVi - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DonGiaMotTiet>(
					key.ToString(), // EntityTrackingKey
					"DonGiaMotTiet",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DonGiaMotTiet();
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
					c.MaHocHam = (System.String)reader[(DonGiaMotTietColumn.MaHocHam.ToString())];
					c.OriginalMaHocHam = c.MaHocHam;
					c.MaHocVi = (System.String)reader[(DonGiaMotTietColumn.MaHocVi.ToString())];
					c.OriginalMaHocVi = c.MaHocVi;
					c.TenHocHam = (reader[DonGiaMotTietColumn.TenHocHam.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaMotTietColumn.TenHocHam.ToString())];
					c.TenHocVi = (reader[DonGiaMotTietColumn.TenHocVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaMotTietColumn.TenHocVi.ToString())];
					c.DonGiaMotTiet = (reader[DonGiaMotTietColumn.DonGiaMotTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaMotTietColumn.DonGiaMotTiet.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaMotTiet"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaMotTiet"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DonGiaMotTiet entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHocHam = (System.String)reader[(DonGiaMotTietColumn.MaHocHam.ToString())];
			entity.OriginalMaHocHam = (System.String)reader["MaHocHam"];
			entity.MaHocVi = (System.String)reader[(DonGiaMotTietColumn.MaHocVi.ToString())];
			entity.OriginalMaHocVi = (System.String)reader["MaHocVi"];
			entity.TenHocHam = (reader[DonGiaMotTietColumn.TenHocHam.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaMotTietColumn.TenHocHam.ToString())];
			entity.TenHocVi = (reader[DonGiaMotTietColumn.TenHocVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonGiaMotTietColumn.TenHocVi.ToString())];
			entity.DonGiaMotTiet = (reader[DonGiaMotTietColumn.DonGiaMotTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DonGiaMotTietColumn.DonGiaMotTiet.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaMotTiet"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaMotTiet"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DonGiaMotTiet entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHocHam = (System.String)dataRow["MaHocHam"];
			entity.OriginalMaHocHam = (System.String)dataRow["MaHocHam"];
			entity.MaHocVi = (System.String)dataRow["MaHocVi"];
			entity.OriginalMaHocVi = (System.String)dataRow["MaHocVi"];
			entity.TenHocHam = Convert.IsDBNull(dataRow["TenHocHam"]) ? null : (System.String)dataRow["TenHocHam"];
			entity.TenHocVi = Convert.IsDBNull(dataRow["TenHocVi"]) ? null : (System.String)dataRow["TenHocVi"];
			entity.DonGiaMotTiet = Convert.IsDBNull(dataRow["DonGiaMotTiet"]) ? null : (System.Decimal?)dataRow["DonGiaMotTiet"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaMotTiet"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaMotTiet Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DonGiaMotTiet entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.DonGiaMotTiet object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DonGiaMotTiet instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaMotTiet Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DonGiaMotTiet entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region DonGiaMotTietChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DonGiaMotTiet</c>
	///</summary>
	public enum DonGiaMotTietChildEntityTypes
	{
	}
	
	#endregion DonGiaMotTietChildEntityTypes
	
	#region DonGiaMotTietFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DonGiaMotTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaMotTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaMotTietFilterBuilder : SqlFilterBuilder<DonGiaMotTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietFilterBuilder class.
		/// </summary>
		public DonGiaMotTietFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaMotTietFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaMotTietFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaMotTietFilterBuilder
	
	#region DonGiaMotTietParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DonGiaMotTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaMotTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaMotTietParameterBuilder : ParameterizedSqlFilterBuilder<DonGiaMotTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietParameterBuilder class.
		/// </summary>
		public DonGiaMotTietParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaMotTietParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaMotTietParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaMotTietParameterBuilder
	
	#region DonGiaMotTietSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DonGiaMotTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaMotTiet"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DonGiaMotTietSortBuilder : SqlSortBuilder<DonGiaMotTietColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietSqlSortBuilder class.
		/// </summary>
		public DonGiaMotTietSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DonGiaMotTietSortBuilder
	
} // end namespace
