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
	/// This class is the base class for any <see cref="DanhGiaCoVanHocTapProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DanhGiaCoVanHocTapProviderBaseCore : EntityProviderBase<PMS.Entities.DanhGiaCoVanHocTap, PMS.Entities.DanhGiaCoVanHocTapKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DanhGiaCoVanHocTapKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _id)
		{
			return Delete(null, _id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _id);		
		
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
		public override PMS.Entities.DanhGiaCoVanHocTap Get(TransactionManager transactionManager, PMS.Entities.DanhGiaCoVanHocTapKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DanhGiaCoVanHocTap index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhGiaCoVanHocTap"/> class.</returns>
		public PMS.Entities.DanhGiaCoVanHocTap GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhGiaCoVanHocTap index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhGiaCoVanHocTap"/> class.</returns>
		public PMS.Entities.DanhGiaCoVanHocTap GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhGiaCoVanHocTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhGiaCoVanHocTap"/> class.</returns>
		public PMS.Entities.DanhGiaCoVanHocTap GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhGiaCoVanHocTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhGiaCoVanHocTap"/> class.</returns>
		public PMS.Entities.DanhGiaCoVanHocTap GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhGiaCoVanHocTap index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhGiaCoVanHocTap"/> class.</returns>
		public PMS.Entities.DanhGiaCoVanHocTap GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhGiaCoVanHocTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhGiaCoVanHocTap"/> class.</returns>
		public abstract PMS.Entities.DanhGiaCoVanHocTap GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DanhGiaCoVanHocTap&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DanhGiaCoVanHocTap&gt;"/></returns>
		public static TList<DanhGiaCoVanHocTap> Fill(IDataReader reader, TList<DanhGiaCoVanHocTap> rows, int start, int pageLength)
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
				
				PMS.Entities.DanhGiaCoVanHocTap c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DanhGiaCoVanHocTap")
					.Append("|").Append((System.Int32)reader[((int)DanhGiaCoVanHocTapColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DanhGiaCoVanHocTap>(
					key.ToString(), // EntityTrackingKey
					"DanhGiaCoVanHocTap",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DanhGiaCoVanHocTap();
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
					c.Id = (System.Int32)reader[(DanhGiaCoVanHocTapColumn.Id.ToString())];
					c.NoiDungDanhGia = (reader[DanhGiaCoVanHocTapColumn.NoiDungDanhGia.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhGiaCoVanHocTapColumn.NoiDungDanhGia.ToString())];
					c.PhanTramHuongThu = (reader[DanhGiaCoVanHocTapColumn.PhanTramHuongThu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DanhGiaCoVanHocTapColumn.PhanTramHuongThu.ToString())];
					c.GhiChu = (reader[DanhGiaCoVanHocTapColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhGiaCoVanHocTapColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DanhGiaCoVanHocTap"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DanhGiaCoVanHocTap"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DanhGiaCoVanHocTap entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(DanhGiaCoVanHocTapColumn.Id.ToString())];
			entity.NoiDungDanhGia = (reader[DanhGiaCoVanHocTapColumn.NoiDungDanhGia.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhGiaCoVanHocTapColumn.NoiDungDanhGia.ToString())];
			entity.PhanTramHuongThu = (reader[DanhGiaCoVanHocTapColumn.PhanTramHuongThu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DanhGiaCoVanHocTapColumn.PhanTramHuongThu.ToString())];
			entity.GhiChu = (reader[DanhGiaCoVanHocTapColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhGiaCoVanHocTapColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DanhGiaCoVanHocTap"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DanhGiaCoVanHocTap"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DanhGiaCoVanHocTap entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NoiDungDanhGia = Convert.IsDBNull(dataRow["NoiDungDanhGia"]) ? null : (System.String)dataRow["NoiDungDanhGia"];
			entity.PhanTramHuongThu = Convert.IsDBNull(dataRow["PhanTramHuongThu"]) ? null : (System.Int32?)dataRow["PhanTramHuongThu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DanhGiaCoVanHocTap"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DanhGiaCoVanHocTap Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DanhGiaCoVanHocTap entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.DanhGiaCoVanHocTap object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DanhGiaCoVanHocTap instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DanhGiaCoVanHocTap Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DanhGiaCoVanHocTap entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region DanhGiaCoVanHocTapChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DanhGiaCoVanHocTap</c>
	///</summary>
	public enum DanhGiaCoVanHocTapChildEntityTypes
	{
	}
	
	#endregion DanhGiaCoVanHocTapChildEntityTypes
	
	#region DanhGiaCoVanHocTapFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DanhGiaCoVanHocTapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhGiaCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhGiaCoVanHocTapFilterBuilder : SqlFilterBuilder<DanhGiaCoVanHocTapColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhGiaCoVanHocTapFilterBuilder class.
		/// </summary>
		public DanhGiaCoVanHocTapFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DanhGiaCoVanHocTapFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DanhGiaCoVanHocTapFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DanhGiaCoVanHocTapFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DanhGiaCoVanHocTapFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DanhGiaCoVanHocTapFilterBuilder
	
	#region DanhGiaCoVanHocTapParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DanhGiaCoVanHocTapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhGiaCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhGiaCoVanHocTapParameterBuilder : ParameterizedSqlFilterBuilder<DanhGiaCoVanHocTapColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhGiaCoVanHocTapParameterBuilder class.
		/// </summary>
		public DanhGiaCoVanHocTapParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DanhGiaCoVanHocTapParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DanhGiaCoVanHocTapParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DanhGiaCoVanHocTapParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DanhGiaCoVanHocTapParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DanhGiaCoVanHocTapParameterBuilder
	
	#region DanhGiaCoVanHocTapSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DanhGiaCoVanHocTapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhGiaCoVanHocTap"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DanhGiaCoVanHocTapSortBuilder : SqlSortBuilder<DanhGiaCoVanHocTapColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhGiaCoVanHocTapSqlSortBuilder class.
		/// </summary>
		public DanhGiaCoVanHocTapSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DanhGiaCoVanHocTapSortBuilder
	
} // end namespace
