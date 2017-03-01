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
	/// This class is the base class for any <see cref="KyThiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KyThiProviderBaseCore : EntityProviderBase<PMS.Entities.KyThi, PMS.Entities.KyThiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KyThiKey key)
		{
			return Delete(transactionManager, key.MaKyThi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maKyThi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maKyThi)
		{
			return Delete(null, _maKyThi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKyThi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maKyThi);		
		
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
		public override PMS.Entities.KyThi Get(TransactionManager transactionManager, PMS.Entities.KyThiKey key, int start, int pageLength)
		{
			return GetByMaKyThi(transactionManager, key.MaKyThi, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KyThi index.
		/// </summary>
		/// <param name="_maKyThi"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KyThi"/> class.</returns>
		public PMS.Entities.KyThi GetByMaKyThi(System.String _maKyThi)
		{
			int count = -1;
			return GetByMaKyThi(null,_maKyThi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KyThi index.
		/// </summary>
		/// <param name="_maKyThi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KyThi"/> class.</returns>
		public PMS.Entities.KyThi GetByMaKyThi(System.String _maKyThi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKyThi(null, _maKyThi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KyThi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKyThi"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KyThi"/> class.</returns>
		public PMS.Entities.KyThi GetByMaKyThi(TransactionManager transactionManager, System.String _maKyThi)
		{
			int count = -1;
			return GetByMaKyThi(transactionManager, _maKyThi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KyThi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKyThi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KyThi"/> class.</returns>
		public PMS.Entities.KyThi GetByMaKyThi(TransactionManager transactionManager, System.String _maKyThi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKyThi(transactionManager, _maKyThi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KyThi index.
		/// </summary>
		/// <param name="_maKyThi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KyThi"/> class.</returns>
		public PMS.Entities.KyThi GetByMaKyThi(System.String _maKyThi, int start, int pageLength, out int count)
		{
			return GetByMaKyThi(null, _maKyThi, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KyThi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKyThi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KyThi"/> class.</returns>
		public abstract PMS.Entities.KyThi GetByMaKyThi(TransactionManager transactionManager, System.String _maKyThi, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KyThi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KyThi&gt;"/></returns>
		public static TList<KyThi> Fill(IDataReader reader, TList<KyThi> rows, int start, int pageLength)
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
				
				PMS.Entities.KyThi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KyThi")
					.Append("|").Append((System.String)reader[((int)KyThiColumn.MaKyThi - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KyThi>(
					key.ToString(), // EntityTrackingKey
					"KyThi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KyThi();
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
					c.MaKyThi = (System.String)reader[(KyThiColumn.MaKyThi.ToString())];
					c.OriginalMaKyThi = c.MaKyThi;
					c.TenKyThi = (reader[KyThiColumn.TenKyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyThiColumn.TenKyThi.ToString())];
					c.GhiChu = (reader[KyThiColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyThiColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[KyThiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyThiColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[KyThiColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyThiColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KyThi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KyThi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KyThi entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKyThi = (System.String)reader[(KyThiColumn.MaKyThi.ToString())];
			entity.OriginalMaKyThi = (System.String)reader["MaKyThi"];
			entity.TenKyThi = (reader[KyThiColumn.TenKyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyThiColumn.TenKyThi.ToString())];
			entity.GhiChu = (reader[KyThiColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyThiColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[KyThiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyThiColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[KyThiColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyThiColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KyThi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KyThi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KyThi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKyThi = (System.String)dataRow["MaKyThi"];
			entity.OriginalMaKyThi = (System.String)dataRow["MaKyThi"];
			entity.TenKyThi = Convert.IsDBNull(dataRow["TenKyThi"]) ? null : (System.String)dataRow["TenKyThi"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KyThi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KyThi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KyThi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KyThi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KyThi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KyThi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KyThi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KyThiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KyThi</c>
	///</summary>
	public enum KyThiChildEntityTypes
	{
	}
	
	#endregion KyThiChildEntityTypes
	
	#region KyThiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KyThiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KyThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KyThiFilterBuilder : SqlFilterBuilder<KyThiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KyThiFilterBuilder class.
		/// </summary>
		public KyThiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KyThiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KyThiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KyThiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KyThiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KyThiFilterBuilder
	
	#region KyThiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KyThiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KyThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KyThiParameterBuilder : ParameterizedSqlFilterBuilder<KyThiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KyThiParameterBuilder class.
		/// </summary>
		public KyThiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KyThiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KyThiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KyThiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KyThiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KyThiParameterBuilder
	
	#region KyThiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KyThiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KyThi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KyThiSortBuilder : SqlSortBuilder<KyThiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KyThiSqlSortBuilder class.
		/// </summary>
		public KyThiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KyThiSortBuilder
	
} // end namespace
