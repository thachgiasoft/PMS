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
	/// This class is the base class for any <see cref="ReportManagermentsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ReportManagermentsProviderBaseCore : EntityProviderBase<PMS.Entities.ReportManagerments, PMS.Entities.ReportManagermentsKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ReportManagermentsKey key)
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
		public override PMS.Entities.ReportManagerments Get(TransactionManager transactionManager, PMS.Entities.ReportManagermentsKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ReportManagerments index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ReportManagerments"/> class.</returns>
		public PMS.Entities.ReportManagerments GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ReportManagerments index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ReportManagerments"/> class.</returns>
		public PMS.Entities.ReportManagerments GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ReportManagerments index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ReportManagerments"/> class.</returns>
		public PMS.Entities.ReportManagerments GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ReportManagerments index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ReportManagerments"/> class.</returns>
		public PMS.Entities.ReportManagerments GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ReportManagerments index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ReportManagerments"/> class.</returns>
		public PMS.Entities.ReportManagerments GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ReportManagerments index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ReportManagerments"/> class.</returns>
		public abstract PMS.Entities.ReportManagerments GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ReportManagerments_GetData 
		
		/// <summary>
		///	This method wrap the 'cust_ReportManagerments_GetData' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="thoiDiemThongKe"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetData(System.Int32 id, System.String namHoc, System.String hocKy, System.DateTime thoiDiemThongKe)
		{
			return GetData(null, 0, int.MaxValue , id, namHoc, hocKy, thoiDiemThongKe);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ReportManagerments_GetData' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="thoiDiemThongKe"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetData(int start, int pageLength, System.Int32 id, System.String namHoc, System.String hocKy, System.DateTime thoiDiemThongKe)
		{
			return GetData(null, start, pageLength , id, namHoc, hocKy, thoiDiemThongKe);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ReportManagerments_GetData' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="thoiDiemThongKe"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetData(TransactionManager transactionManager, System.Int32 id, System.String namHoc, System.String hocKy, System.DateTime thoiDiemThongKe)
		{
			return GetData(transactionManager, 0, int.MaxValue , id, namHoc, hocKy, thoiDiemThongKe);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ReportManagerments_GetData' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="thoiDiemThongKe"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetData(TransactionManager transactionManager, int start, int pageLength , System.Int32 id, System.String namHoc, System.String hocKy, System.DateTime thoiDiemThongKe);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ReportManagerments&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ReportManagerments&gt;"/></returns>
		public static TList<ReportManagerments> Fill(IDataReader reader, TList<ReportManagerments> rows, int start, int pageLength)
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
				
				PMS.Entities.ReportManagerments c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ReportManagerments")
					.Append("|").Append((System.Int32)reader[((int)ReportManagermentsColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ReportManagerments>(
					key.ToString(), // EntityTrackingKey
					"ReportManagerments",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ReportManagerments();
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
					c.Id = (System.Int32)reader[(ReportManagermentsColumn.Id.ToString())];
					c.ReportName = (reader[ReportManagermentsColumn.ReportName.ToString()] == DBNull.Value) ? null : (System.String)reader[(ReportManagermentsColumn.ReportName.ToString())];
					c.Storeprocedure = (reader[ReportManagermentsColumn.Storeprocedure.ToString()] == DBNull.Value) ? null : (System.String)reader[(ReportManagermentsColumn.Storeprocedure.ToString())];
					c.FileName = (reader[ReportManagermentsColumn.FileName.ToString()] == DBNull.Value) ? null : (System.String)reader[(ReportManagermentsColumn.FileName.ToString())];
					c.Note1 = (reader[ReportManagermentsColumn.Note1.ToString()] == DBNull.Value) ? null : (System.String)reader[(ReportManagermentsColumn.Note1.ToString())];
					c.Note2 = (reader[ReportManagermentsColumn.Note2.ToString()] == DBNull.Value) ? null : (System.String)reader[(ReportManagermentsColumn.Note2.ToString())];
					c.Note3 = (reader[ReportManagermentsColumn.Note3.ToString()] == DBNull.Value) ? null : (System.String)reader[(ReportManagermentsColumn.Note3.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ReportManagerments"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ReportManagerments"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ReportManagerments entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ReportManagermentsColumn.Id.ToString())];
			entity.ReportName = (reader[ReportManagermentsColumn.ReportName.ToString()] == DBNull.Value) ? null : (System.String)reader[(ReportManagermentsColumn.ReportName.ToString())];
			entity.Storeprocedure = (reader[ReportManagermentsColumn.Storeprocedure.ToString()] == DBNull.Value) ? null : (System.String)reader[(ReportManagermentsColumn.Storeprocedure.ToString())];
			entity.FileName = (reader[ReportManagermentsColumn.FileName.ToString()] == DBNull.Value) ? null : (System.String)reader[(ReportManagermentsColumn.FileName.ToString())];
			entity.Note1 = (reader[ReportManagermentsColumn.Note1.ToString()] == DBNull.Value) ? null : (System.String)reader[(ReportManagermentsColumn.Note1.ToString())];
			entity.Note2 = (reader[ReportManagermentsColumn.Note2.ToString()] == DBNull.Value) ? null : (System.String)reader[(ReportManagermentsColumn.Note2.ToString())];
			entity.Note3 = (reader[ReportManagermentsColumn.Note3.ToString()] == DBNull.Value) ? null : (System.String)reader[(ReportManagermentsColumn.Note3.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ReportManagerments"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ReportManagerments"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ReportManagerments entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.ReportName = Convert.IsDBNull(dataRow["ReportName"]) ? null : (System.String)dataRow["ReportName"];
			entity.Storeprocedure = Convert.IsDBNull(dataRow["Storeprocedure"]) ? null : (System.String)dataRow["Storeprocedure"];
			entity.FileName = Convert.IsDBNull(dataRow["FileName"]) ? null : (System.String)dataRow["FileName"];
			entity.Note1 = Convert.IsDBNull(dataRow["Note1"]) ? null : (System.String)dataRow["Note1"];
			entity.Note2 = Convert.IsDBNull(dataRow["Note2"]) ? null : (System.String)dataRow["Note2"];
			entity.Note3 = Convert.IsDBNull(dataRow["Note3"]) ? null : (System.String)dataRow["Note3"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ReportManagerments"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ReportManagerments Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ReportManagerments entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ReportManagerments object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ReportManagerments instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ReportManagerments Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ReportManagerments entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ReportManagermentsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ReportManagerments</c>
	///</summary>
	public enum ReportManagermentsChildEntityTypes
	{
	}
	
	#endregion ReportManagermentsChildEntityTypes
	
	#region ReportManagermentsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ReportManagermentsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ReportManagerments"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ReportManagermentsFilterBuilder : SqlFilterBuilder<ReportManagermentsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportManagermentsFilterBuilder class.
		/// </summary>
		public ReportManagermentsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ReportManagermentsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ReportManagermentsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ReportManagermentsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ReportManagermentsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ReportManagermentsFilterBuilder
	
	#region ReportManagermentsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ReportManagermentsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ReportManagerments"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ReportManagermentsParameterBuilder : ParameterizedSqlFilterBuilder<ReportManagermentsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportManagermentsParameterBuilder class.
		/// </summary>
		public ReportManagermentsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ReportManagermentsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ReportManagermentsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ReportManagermentsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ReportManagermentsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ReportManagermentsParameterBuilder
	
	#region ReportManagermentsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ReportManagermentsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ReportManagerments"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ReportManagermentsSortBuilder : SqlSortBuilder<ReportManagermentsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportManagermentsSqlSortBuilder class.
		/// </summary>
		public ReportManagermentsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ReportManagermentsSortBuilder
	
} // end namespace
