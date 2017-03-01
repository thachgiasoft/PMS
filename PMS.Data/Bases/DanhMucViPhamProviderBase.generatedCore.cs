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
	/// This class is the base class for any <see cref="DanhMucViPhamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DanhMucViPhamProviderBaseCore : EntityProviderBase<PMS.Entities.DanhMucViPham, PMS.Entities.DanhMucViPhamKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DanhMucViPhamKey key)
		{
			return Delete(transactionManager, key.MaViPham);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maViPham">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maViPham)
		{
			return Delete(null, _maViPham);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maViPham">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maViPham);		
		
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
		public override PMS.Entities.DanhMucViPham Get(TransactionManager transactionManager, PMS.Entities.DanhMucViPhamKey key, int start, int pageLength)
		{
			return GetByMaViPham(transactionManager, key.MaViPham, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DanhMucViPham index.
		/// </summary>
		/// <param name="_maViPham"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucViPham"/> class.</returns>
		public PMS.Entities.DanhMucViPham GetByMaViPham(System.String _maViPham)
		{
			int count = -1;
			return GetByMaViPham(null,_maViPham, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucViPham index.
		/// </summary>
		/// <param name="_maViPham"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucViPham"/> class.</returns>
		public PMS.Entities.DanhMucViPham GetByMaViPham(System.String _maViPham, int start, int pageLength)
		{
			int count = -1;
			return GetByMaViPham(null, _maViPham, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucViPham index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maViPham"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucViPham"/> class.</returns>
		public PMS.Entities.DanhMucViPham GetByMaViPham(TransactionManager transactionManager, System.String _maViPham)
		{
			int count = -1;
			return GetByMaViPham(transactionManager, _maViPham, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucViPham index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maViPham"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucViPham"/> class.</returns>
		public PMS.Entities.DanhMucViPham GetByMaViPham(TransactionManager transactionManager, System.String _maViPham, int start, int pageLength)
		{
			int count = -1;
			return GetByMaViPham(transactionManager, _maViPham, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucViPham index.
		/// </summary>
		/// <param name="_maViPham"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucViPham"/> class.</returns>
		public PMS.Entities.DanhMucViPham GetByMaViPham(System.String _maViPham, int start, int pageLength, out int count)
		{
			return GetByMaViPham(null, _maViPham, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucViPham index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maViPham"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucViPham"/> class.</returns>
		public abstract PMS.Entities.DanhMucViPham GetByMaViPham(TransactionManager transactionManager, System.String _maViPham, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DanhMucViPham&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DanhMucViPham&gt;"/></returns>
		public static TList<DanhMucViPham> Fill(IDataReader reader, TList<DanhMucViPham> rows, int start, int pageLength)
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
				
				PMS.Entities.DanhMucViPham c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DanhMucViPham")
					.Append("|").Append((System.String)reader[((int)DanhMucViPhamColumn.MaViPham - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DanhMucViPham>(
					key.ToString(), // EntityTrackingKey
					"DanhMucViPham",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DanhMucViPham();
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
					c.MaViPham = (System.String)reader[(DanhMucViPhamColumn.MaViPham.ToString())];
					c.OriginalMaViPham = c.MaViPham;
					c.NoiDungViPham = (reader[DanhMucViPhamColumn.NoiDungViPham.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucViPhamColumn.NoiDungViPham.ToString())];
					c.CoXepLoai = (reader[DanhMucViPhamColumn.CoXepLoai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DanhMucViPhamColumn.CoXepLoai.ToString())];
					c.GhiChu = (reader[DanhMucViPhamColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucViPhamColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DanhMucViPham"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucViPham"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DanhMucViPham entity)
		{
			if (!reader.Read()) return;
			
			entity.MaViPham = (System.String)reader[(DanhMucViPhamColumn.MaViPham.ToString())];
			entity.OriginalMaViPham = (System.String)reader["MaViPham"];
			entity.NoiDungViPham = (reader[DanhMucViPhamColumn.NoiDungViPham.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucViPhamColumn.NoiDungViPham.ToString())];
			entity.CoXepLoai = (reader[DanhMucViPhamColumn.CoXepLoai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(DanhMucViPhamColumn.CoXepLoai.ToString())];
			entity.GhiChu = (reader[DanhMucViPhamColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucViPhamColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DanhMucViPham"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucViPham"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DanhMucViPham entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaViPham = (System.String)dataRow["MaViPham"];
			entity.OriginalMaViPham = (System.String)dataRow["MaViPham"];
			entity.NoiDungViPham = Convert.IsDBNull(dataRow["NoiDungViPham"]) ? null : (System.String)dataRow["NoiDungViPham"];
			entity.CoXepLoai = Convert.IsDBNull(dataRow["CoXepLoai"]) ? null : (System.Boolean?)dataRow["CoXepLoai"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucViPham"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DanhMucViPham Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DanhMucViPham entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.DanhMucViPham object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DanhMucViPham instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DanhMucViPham Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DanhMucViPham entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region DanhMucViPhamChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DanhMucViPham</c>
	///</summary>
	public enum DanhMucViPhamChildEntityTypes
	{
	}
	
	#endregion DanhMucViPhamChildEntityTypes
	
	#region DanhMucViPhamFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DanhMucViPhamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucViPham"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucViPhamFilterBuilder : SqlFilterBuilder<DanhMucViPhamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucViPhamFilterBuilder class.
		/// </summary>
		public DanhMucViPhamFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DanhMucViPhamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DanhMucViPhamFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DanhMucViPhamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DanhMucViPhamFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DanhMucViPhamFilterBuilder
	
	#region DanhMucViPhamParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DanhMucViPhamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucViPham"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucViPhamParameterBuilder : ParameterizedSqlFilterBuilder<DanhMucViPhamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucViPhamParameterBuilder class.
		/// </summary>
		public DanhMucViPhamParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DanhMucViPhamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DanhMucViPhamParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DanhMucViPhamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DanhMucViPhamParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DanhMucViPhamParameterBuilder
	
	#region DanhMucViPhamSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DanhMucViPhamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucViPham"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DanhMucViPhamSortBuilder : SqlSortBuilder<DanhMucViPhamColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucViPhamSqlSortBuilder class.
		/// </summary>
		public DanhMucViPhamSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DanhMucViPhamSortBuilder
	
} // end namespace
