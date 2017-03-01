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
	/// This class is the base class for any <see cref="KcqNhomMonHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqNhomMonHocProviderBaseCore : EntityProviderBase<PMS.Entities.KcqNhomMonHoc, PMS.Entities.KcqNhomMonHocKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqNhomMonHocKey key)
		{
			return Delete(transactionManager, key.MaNhomMon);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maNhomMon">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maNhomMon)
		{
			return Delete(null, _maNhomMon);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maNhomMon);		
		
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
		public override PMS.Entities.KcqNhomMonHoc Get(TransactionManager transactionManager, PMS.Entities.KcqNhomMonHocKey key, int start, int pageLength)
		{
			return GetByMaNhomMon(transactionManager, key.MaNhomMon, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqNhomMonHoc index.
		/// </summary>
		/// <param name="_maNhomMon"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqNhomMonHoc"/> class.</returns>
		public PMS.Entities.KcqNhomMonHoc GetByMaNhomMon(System.Int32 _maNhomMon)
		{
			int count = -1;
			return GetByMaNhomMon(null,_maNhomMon, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqNhomMonHoc index.
		/// </summary>
		/// <param name="_maNhomMon"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqNhomMonHoc"/> class.</returns>
		public PMS.Entities.KcqNhomMonHoc GetByMaNhomMon(System.Int32 _maNhomMon, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomMon(null, _maNhomMon, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqNhomMonHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqNhomMonHoc"/> class.</returns>
		public PMS.Entities.KcqNhomMonHoc GetByMaNhomMon(TransactionManager transactionManager, System.Int32 _maNhomMon)
		{
			int count = -1;
			return GetByMaNhomMon(transactionManager, _maNhomMon, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqNhomMonHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqNhomMonHoc"/> class.</returns>
		public PMS.Entities.KcqNhomMonHoc GetByMaNhomMon(TransactionManager transactionManager, System.Int32 _maNhomMon, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomMon(transactionManager, _maNhomMon, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqNhomMonHoc index.
		/// </summary>
		/// <param name="_maNhomMon"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqNhomMonHoc"/> class.</returns>
		public PMS.Entities.KcqNhomMonHoc GetByMaNhomMon(System.Int32 _maNhomMon, int start, int pageLength, out int count)
		{
			return GetByMaNhomMon(null, _maNhomMon, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqNhomMonHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqNhomMonHoc"/> class.</returns>
		public abstract PMS.Entities.KcqNhomMonHoc GetByMaNhomMon(TransactionManager transactionManager, System.Int32 _maNhomMon, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqNhomMonHoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqNhomMonHoc&gt;"/></returns>
		public static TList<KcqNhomMonHoc> Fill(IDataReader reader, TList<KcqNhomMonHoc> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqNhomMonHoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqNhomMonHoc")
					.Append("|").Append((System.Int32)reader[((int)KcqNhomMonHocColumn.MaNhomMon - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqNhomMonHoc>(
					key.ToString(), // EntityTrackingKey
					"KcqNhomMonHoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqNhomMonHoc();
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
					c.MaNhomMon = (System.Int32)reader[(KcqNhomMonHocColumn.MaNhomMon.ToString())];
					c.MaQuanLy = (System.String)reader[(KcqNhomMonHocColumn.MaQuanLy.ToString())];
					c.TenNhomMon = (reader[KcqNhomMonHocColumn.TenNhomMon.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqNhomMonHocColumn.TenNhomMon.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqNhomMonHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqNhomMonHoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqNhomMonHoc entity)
		{
			if (!reader.Read()) return;
			
			entity.MaNhomMon = (System.Int32)reader[(KcqNhomMonHocColumn.MaNhomMon.ToString())];
			entity.MaQuanLy = (System.String)reader[(KcqNhomMonHocColumn.MaQuanLy.ToString())];
			entity.TenNhomMon = (reader[KcqNhomMonHocColumn.TenNhomMon.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqNhomMonHocColumn.TenNhomMon.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqNhomMonHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqNhomMonHoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqNhomMonHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaNhomMon = (System.Int32)dataRow["MaNhomMon"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenNhomMon = Convert.IsDBNull(dataRow["TenNhomMon"]) ? null : (System.String)dataRow["TenNhomMon"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqNhomMonHoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqNhomMonHoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqNhomMonHoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqNhomMonHoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqNhomMonHoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqNhomMonHoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqNhomMonHoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KcqNhomMonHocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqNhomMonHoc</c>
	///</summary>
	public enum KcqNhomMonHocChildEntityTypes
	{
	}
	
	#endregion KcqNhomMonHocChildEntityTypes
	
	#region KcqNhomMonHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqNhomMonHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqNhomMonHocFilterBuilder : SqlFilterBuilder<KcqNhomMonHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqNhomMonHocFilterBuilder class.
		/// </summary>
		public KcqNhomMonHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqNhomMonHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqNhomMonHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqNhomMonHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqNhomMonHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqNhomMonHocFilterBuilder
	
	#region KcqNhomMonHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqNhomMonHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqNhomMonHocParameterBuilder : ParameterizedSqlFilterBuilder<KcqNhomMonHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqNhomMonHocParameterBuilder class.
		/// </summary>
		public KcqNhomMonHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqNhomMonHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqNhomMonHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqNhomMonHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqNhomMonHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqNhomMonHocParameterBuilder
	
	#region KcqNhomMonHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqNhomMonHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqNhomMonHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqNhomMonHocSortBuilder : SqlSortBuilder<KcqNhomMonHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqNhomMonHocSqlSortBuilder class.
		/// </summary>
		public KcqNhomMonHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqNhomMonHocSortBuilder
	
} // end namespace
