﻿#region Using directives

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
	/// This class is the base class for any <see cref="SdhMonHocKhongTinhKhoiLuongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SdhMonHocKhongTinhKhoiLuongProviderBaseCore : EntityProviderBase<PMS.Entities.SdhMonHocKhongTinhKhoiLuong, PMS.Entities.SdhMonHocKhongTinhKhoiLuongKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.SdhMonHocKhongTinhKhoiLuongKey key)
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
		public override PMS.Entities.SdhMonHocKhongTinhKhoiLuong Get(TransactionManager transactionManager, PMS.Entities.SdhMonHocKhongTinhKhoiLuongKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SdhMonHocKhongTinhKhoiLuong index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhMonHocKhongTinhKhoiLuong"/> class.</returns>
		public PMS.Entities.SdhMonHocKhongTinhKhoiLuong GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhMonHocKhongTinhKhoiLuong index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhMonHocKhongTinhKhoiLuong"/> class.</returns>
		public PMS.Entities.SdhMonHocKhongTinhKhoiLuong GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhMonHocKhongTinhKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhMonHocKhongTinhKhoiLuong"/> class.</returns>
		public PMS.Entities.SdhMonHocKhongTinhKhoiLuong GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhMonHocKhongTinhKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhMonHocKhongTinhKhoiLuong"/> class.</returns>
		public PMS.Entities.SdhMonHocKhongTinhKhoiLuong GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhMonHocKhongTinhKhoiLuong index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhMonHocKhongTinhKhoiLuong"/> class.</returns>
		public PMS.Entities.SdhMonHocKhongTinhKhoiLuong GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhMonHocKhongTinhKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhMonHocKhongTinhKhoiLuong"/> class.</returns>
		public abstract PMS.Entities.SdhMonHocKhongTinhKhoiLuong GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SdhMonHocKhongTinhKhoiLuong&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SdhMonHocKhongTinhKhoiLuong&gt;"/></returns>
		public static TList<SdhMonHocKhongTinhKhoiLuong> Fill(IDataReader reader, TList<SdhMonHocKhongTinhKhoiLuong> rows, int start, int pageLength)
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
				
				PMS.Entities.SdhMonHocKhongTinhKhoiLuong c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SdhMonHocKhongTinhKhoiLuong")
					.Append("|").Append((System.Int32)reader[((int)SdhMonHocKhongTinhKhoiLuongColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<SdhMonHocKhongTinhKhoiLuong>(
					key.ToString(), // EntityTrackingKey
					"SdhMonHocKhongTinhKhoiLuong",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.SdhMonHocKhongTinhKhoiLuong();
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
					c.Id = (System.Int32)reader[(SdhMonHocKhongTinhKhoiLuongColumn.Id.ToString())];
					c.NamHoc = (reader[SdhMonHocKhongTinhKhoiLuongColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonHocKhongTinhKhoiLuongColumn.NamHoc.ToString())];
					c.HocKy = (reader[SdhMonHocKhongTinhKhoiLuongColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonHocKhongTinhKhoiLuongColumn.HocKy.ToString())];
					c.MaMonHoc = (reader[SdhMonHocKhongTinhKhoiLuongColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonHocKhongTinhKhoiLuongColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[SdhMonHocKhongTinhKhoiLuongColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonHocKhongTinhKhoiLuongColumn.TenMonHoc.ToString())];
					c.SoTinChi = (reader[SdhMonHocKhongTinhKhoiLuongColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonHocKhongTinhKhoiLuongColumn.SoTinChi.ToString())];
					c.TenBoMon = (reader[SdhMonHocKhongTinhKhoiLuongColumn.TenBoMon.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonHocKhongTinhKhoiLuongColumn.TenBoMon.ToString())];
					c.NgayCapNhat = (reader[SdhMonHocKhongTinhKhoiLuongColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(SdhMonHocKhongTinhKhoiLuongColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[SdhMonHocKhongTinhKhoiLuongColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonHocKhongTinhKhoiLuongColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SdhMonHocKhongTinhKhoiLuong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SdhMonHocKhongTinhKhoiLuong"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.SdhMonHocKhongTinhKhoiLuong entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(SdhMonHocKhongTinhKhoiLuongColumn.Id.ToString())];
			entity.NamHoc = (reader[SdhMonHocKhongTinhKhoiLuongColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonHocKhongTinhKhoiLuongColumn.NamHoc.ToString())];
			entity.HocKy = (reader[SdhMonHocKhongTinhKhoiLuongColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonHocKhongTinhKhoiLuongColumn.HocKy.ToString())];
			entity.MaMonHoc = (reader[SdhMonHocKhongTinhKhoiLuongColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonHocKhongTinhKhoiLuongColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[SdhMonHocKhongTinhKhoiLuongColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonHocKhongTinhKhoiLuongColumn.TenMonHoc.ToString())];
			entity.SoTinChi = (reader[SdhMonHocKhongTinhKhoiLuongColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhMonHocKhongTinhKhoiLuongColumn.SoTinChi.ToString())];
			entity.TenBoMon = (reader[SdhMonHocKhongTinhKhoiLuongColumn.TenBoMon.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonHocKhongTinhKhoiLuongColumn.TenBoMon.ToString())];
			entity.NgayCapNhat = (reader[SdhMonHocKhongTinhKhoiLuongColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(SdhMonHocKhongTinhKhoiLuongColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[SdhMonHocKhongTinhKhoiLuongColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhMonHocKhongTinhKhoiLuongColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SdhMonHocKhongTinhKhoiLuong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SdhMonHocKhongTinhKhoiLuong"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.SdhMonHocKhongTinhKhoiLuong entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
			entity.TenBoMon = Convert.IsDBNull(dataRow["TenBoMon"]) ? null : (System.String)dataRow["TenBoMon"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.SdhMonHocKhongTinhKhoiLuong"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.SdhMonHocKhongTinhKhoiLuong Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.SdhMonHocKhongTinhKhoiLuong entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.SdhMonHocKhongTinhKhoiLuong object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.SdhMonHocKhongTinhKhoiLuong instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.SdhMonHocKhongTinhKhoiLuong Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.SdhMonHocKhongTinhKhoiLuong entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region SdhMonHocKhongTinhKhoiLuongChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.SdhMonHocKhongTinhKhoiLuong</c>
	///</summary>
	public enum SdhMonHocKhongTinhKhoiLuongChildEntityTypes
	{
	}
	
	#endregion SdhMonHocKhongTinhKhoiLuongChildEntityTypes
	
	#region SdhMonHocKhongTinhKhoiLuongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SdhMonHocKhongTinhKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhMonHocKhongTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhMonHocKhongTinhKhoiLuongFilterBuilder : SqlFilterBuilder<SdhMonHocKhongTinhKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhMonHocKhongTinhKhoiLuongFilterBuilder class.
		/// </summary>
		public SdhMonHocKhongTinhKhoiLuongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SdhMonHocKhongTinhKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SdhMonHocKhongTinhKhoiLuongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SdhMonHocKhongTinhKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SdhMonHocKhongTinhKhoiLuongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SdhMonHocKhongTinhKhoiLuongFilterBuilder
	
	#region SdhMonHocKhongTinhKhoiLuongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SdhMonHocKhongTinhKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhMonHocKhongTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhMonHocKhongTinhKhoiLuongParameterBuilder : ParameterizedSqlFilterBuilder<SdhMonHocKhongTinhKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhMonHocKhongTinhKhoiLuongParameterBuilder class.
		/// </summary>
		public SdhMonHocKhongTinhKhoiLuongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SdhMonHocKhongTinhKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SdhMonHocKhongTinhKhoiLuongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SdhMonHocKhongTinhKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SdhMonHocKhongTinhKhoiLuongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SdhMonHocKhongTinhKhoiLuongParameterBuilder
	
	#region SdhMonHocKhongTinhKhoiLuongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SdhMonHocKhongTinhKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhMonHocKhongTinhKhoiLuong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SdhMonHocKhongTinhKhoiLuongSortBuilder : SqlSortBuilder<SdhMonHocKhongTinhKhoiLuongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhMonHocKhongTinhKhoiLuongSqlSortBuilder class.
		/// </summary>
		public SdhMonHocKhongTinhKhoiLuongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SdhMonHocKhongTinhKhoiLuongSortBuilder
	
} // end namespace
