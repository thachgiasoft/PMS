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
	/// This class is the base class for any <see cref="KyTinhLuongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KyTinhLuongProviderBaseCore : EntityProviderBase<PMS.Entities.KyTinhLuong, PMS.Entities.KyTinhLuongKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KyTinhLuongKey key)
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
		public override PMS.Entities.KyTinhLuong Get(TransactionManager transactionManager, PMS.Entities.KyTinhLuongKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KyTinhLuong index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KyTinhLuong"/> class.</returns>
		public PMS.Entities.KyTinhLuong GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KyTinhLuong index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KyTinhLuong"/> class.</returns>
		public PMS.Entities.KyTinhLuong GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KyTinhLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KyTinhLuong"/> class.</returns>
		public PMS.Entities.KyTinhLuong GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KyTinhLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KyTinhLuong"/> class.</returns>
		public PMS.Entities.KyTinhLuong GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KyTinhLuong index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KyTinhLuong"/> class.</returns>
		public PMS.Entities.KyTinhLuong GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KyTinhLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KyTinhLuong"/> class.</returns>
		public abstract PMS.Entities.KyTinhLuong GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KyTinhLuong_GetByMaQuanLy 
		
		/// <summary>
		///	This method wrap the 'cust_KyTinhLuong_GetByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KyTinhLuong&gt;"/> instance.</returns>
		public TList<KyTinhLuong> GetByMaQuanLy(System.String maQuanLy)
		{
			return GetByMaQuanLy(null, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KyTinhLuong_GetByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KyTinhLuong&gt;"/> instance.</returns>
		public TList<KyTinhLuong> GetByMaQuanLy(int start, int pageLength, System.String maQuanLy)
		{
			return GetByMaQuanLy(null, start, pageLength , maQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KyTinhLuong_GetByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KyTinhLuong&gt;"/> instance.</returns>
		public TList<KyTinhLuong> GetByMaQuanLy(TransactionManager transactionManager, System.String maQuanLy)
		{
			return GetByMaQuanLy(transactionManager, 0, int.MaxValue , maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KyTinhLuong_GetByMaQuanLy' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KyTinhLuong&gt;"/> instance.</returns>
		public abstract TList<KyTinhLuong> GetByMaQuanLy(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KyTinhLuong&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KyTinhLuong&gt;"/></returns>
		public static TList<KyTinhLuong> Fill(IDataReader reader, TList<KyTinhLuong> rows, int start, int pageLength)
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
				
				PMS.Entities.KyTinhLuong c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KyTinhLuong")
					.Append("|").Append((System.Int32)reader[((int)KyTinhLuongColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KyTinhLuong>(
					key.ToString(), // EntityTrackingKey
					"KyTinhLuong",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KyTinhLuong();
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
					c.Id = (System.Int32)reader[(KyTinhLuongColumn.Id.ToString())];
					c.MaQuanLy = (reader[KyTinhLuongColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyTinhLuongColumn.MaQuanLy.ToString())];
					c.TuNgay = (reader[KyTinhLuongColumn.TuNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KyTinhLuongColumn.TuNgay.ToString())];
					c.DenNgay = (reader[KyTinhLuongColumn.DenNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KyTinhLuongColumn.DenNgay.ToString())];
					c.NamHoc = (reader[KyTinhLuongColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyTinhLuongColumn.NamHoc.ToString())];
					c.HocKy = (reader[KyTinhLuongColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyTinhLuongColumn.HocKy.ToString())];
					c.GhiChu = (reader[KyTinhLuongColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyTinhLuongColumn.GhiChu.ToString())];
					c.Khoa = (reader[KyTinhLuongColumn.Khoa.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KyTinhLuongColumn.Khoa.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KyTinhLuong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KyTinhLuong"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KyTinhLuong entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KyTinhLuongColumn.Id.ToString())];
			entity.MaQuanLy = (reader[KyTinhLuongColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyTinhLuongColumn.MaQuanLy.ToString())];
			entity.TuNgay = (reader[KyTinhLuongColumn.TuNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KyTinhLuongColumn.TuNgay.ToString())];
			entity.DenNgay = (reader[KyTinhLuongColumn.DenNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KyTinhLuongColumn.DenNgay.ToString())];
			entity.NamHoc = (reader[KyTinhLuongColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyTinhLuongColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KyTinhLuongColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyTinhLuongColumn.HocKy.ToString())];
			entity.GhiChu = (reader[KyTinhLuongColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KyTinhLuongColumn.GhiChu.ToString())];
			entity.Khoa = (reader[KyTinhLuongColumn.Khoa.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KyTinhLuongColumn.Khoa.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KyTinhLuong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KyTinhLuong"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KyTinhLuong entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.TuNgay = Convert.IsDBNull(dataRow["TuNgay"]) ? null : (System.DateTime?)dataRow["TuNgay"];
			entity.DenNgay = Convert.IsDBNull(dataRow["DenNgay"]) ? null : (System.DateTime?)dataRow["DenNgay"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.Khoa = Convert.IsDBNull(dataRow["Khoa"]) ? null : (System.Boolean?)dataRow["Khoa"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KyTinhLuong"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KyTinhLuong Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KyTinhLuong entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KyTinhLuong object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KyTinhLuong instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KyTinhLuong Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KyTinhLuong entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KyTinhLuongChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KyTinhLuong</c>
	///</summary>
	public enum KyTinhLuongChildEntityTypes
	{
	}
	
	#endregion KyTinhLuongChildEntityTypes
	
	#region KyTinhLuongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KyTinhLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KyTinhLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KyTinhLuongFilterBuilder : SqlFilterBuilder<KyTinhLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KyTinhLuongFilterBuilder class.
		/// </summary>
		public KyTinhLuongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KyTinhLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KyTinhLuongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KyTinhLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KyTinhLuongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KyTinhLuongFilterBuilder
	
	#region KyTinhLuongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KyTinhLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KyTinhLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KyTinhLuongParameterBuilder : ParameterizedSqlFilterBuilder<KyTinhLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KyTinhLuongParameterBuilder class.
		/// </summary>
		public KyTinhLuongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KyTinhLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KyTinhLuongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KyTinhLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KyTinhLuongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KyTinhLuongParameterBuilder
	
	#region KyTinhLuongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KyTinhLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KyTinhLuong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KyTinhLuongSortBuilder : SqlSortBuilder<KyTinhLuongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KyTinhLuongSqlSortBuilder class.
		/// </summary>
		public KyTinhLuongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KyTinhLuongSortBuilder
	
} // end namespace
