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
	/// This class is the base class for any <see cref="ReportTemplateProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ReportTemplateProviderBaseCore : EntityProviderBase<PMS.Entities.ReportTemplate, PMS.Entities.ReportTemplateKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ReportTemplateKey key)
		{
			return Delete(transactionManager, key.ReportId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_reportId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _reportId)
		{
			return Delete(null, _reportId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_reportId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _reportId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ReportTemplate_TaiKhoan key.
		///		FK_ReportTemplate_TaiKhoan Description: 
		/// </summary>
		/// <param name="_userId"></param>
		/// <returns>Returns a typed collection of PMS.Entities.ReportTemplate objects.</returns>
		public TList<ReportTemplate> GetByUserId(System.Int32? _userId)
		{
			int count = -1;
			return GetByUserId(_userId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ReportTemplate_TaiKhoan key.
		///		FK_ReportTemplate_TaiKhoan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_userId"></param>
		/// <returns>Returns a typed collection of PMS.Entities.ReportTemplate objects.</returns>
		/// <remarks></remarks>
		public TList<ReportTemplate> GetByUserId(TransactionManager transactionManager, System.Int32? _userId)
		{
			int count = -1;
			return GetByUserId(transactionManager, _userId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ReportTemplate_TaiKhoan key.
		///		FK_ReportTemplate_TaiKhoan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_userId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ReportTemplate objects.</returns>
		public TList<ReportTemplate> GetByUserId(TransactionManager transactionManager, System.Int32? _userId, int start, int pageLength)
		{
			int count = -1;
			return GetByUserId(transactionManager, _userId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ReportTemplate_TaiKhoan key.
		///		fkReportTemplateTaiKhoan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_userId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ReportTemplate objects.</returns>
		public TList<ReportTemplate> GetByUserId(System.Int32? _userId, int start, int pageLength)
		{
			int count =  -1;
			return GetByUserId(null, _userId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ReportTemplate_TaiKhoan key.
		///		fkReportTemplateTaiKhoan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_userId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ReportTemplate objects.</returns>
		public TList<ReportTemplate> GetByUserId(System.Int32? _userId, int start, int pageLength,out int count)
		{
			return GetByUserId(null, _userId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ReportTemplate_TaiKhoan key.
		///		FK_ReportTemplate_TaiKhoan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_userId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.ReportTemplate objects.</returns>
		public abstract TList<ReportTemplate> GetByUserId(TransactionManager transactionManager, System.Int32? _userId, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.ReportTemplate Get(TransactionManager transactionManager, PMS.Entities.ReportTemplateKey key, int start, int pageLength)
		{
			return GetByReportId(transactionManager, key.ReportId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ReportTemplate index.
		/// </summary>
		/// <param name="_reportId"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ReportTemplate"/> class.</returns>
		public PMS.Entities.ReportTemplate GetByReportId(System.String _reportId)
		{
			int count = -1;
			return GetByReportId(null,_reportId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ReportTemplate index.
		/// </summary>
		/// <param name="_reportId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ReportTemplate"/> class.</returns>
		public PMS.Entities.ReportTemplate GetByReportId(System.String _reportId, int start, int pageLength)
		{
			int count = -1;
			return GetByReportId(null, _reportId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ReportTemplate index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_reportId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ReportTemplate"/> class.</returns>
		public PMS.Entities.ReportTemplate GetByReportId(TransactionManager transactionManager, System.String _reportId)
		{
			int count = -1;
			return GetByReportId(transactionManager, _reportId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ReportTemplate index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_reportId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ReportTemplate"/> class.</returns>
		public PMS.Entities.ReportTemplate GetByReportId(TransactionManager transactionManager, System.String _reportId, int start, int pageLength)
		{
			int count = -1;
			return GetByReportId(transactionManager, _reportId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ReportTemplate index.
		/// </summary>
		/// <param name="_reportId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ReportTemplate"/> class.</returns>
		public PMS.Entities.ReportTemplate GetByReportId(System.String _reportId, int start, int pageLength, out int count)
		{
			return GetByReportId(null, _reportId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ReportTemplate index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_reportId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ReportTemplate"/> class.</returns>
		public abstract PMS.Entities.ReportTemplate GetByReportId(TransactionManager transactionManager, System.String _reportId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ReportTemplate&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ReportTemplate&gt;"/></returns>
		public static TList<ReportTemplate> Fill(IDataReader reader, TList<ReportTemplate> rows, int start, int pageLength)
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
				
				PMS.Entities.ReportTemplate c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ReportTemplate")
					.Append("|").Append((System.String)reader[((int)ReportTemplateColumn.ReportId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ReportTemplate>(
					key.ToString(), // EntityTrackingKey
					"ReportTemplate",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ReportTemplate();
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
					c.ReportId = (System.String)reader[(ReportTemplateColumn.ReportId.ToString())];
					c.OriginalReportId = c.ReportId;
					c.UserId = (reader[ReportTemplateColumn.UserId.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ReportTemplateColumn.UserId.ToString())];
					c.DuLieu = (reader[ReportTemplateColumn.DuLieu.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(ReportTemplateColumn.DuLieu.ToString())];
					c.NgayTao = (reader[ReportTemplateColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ReportTemplateColumn.NgayTao.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ReportTemplate"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ReportTemplate"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ReportTemplate entity)
		{
			if (!reader.Read()) return;
			
			entity.ReportId = (System.String)reader[(ReportTemplateColumn.ReportId.ToString())];
			entity.OriginalReportId = (System.String)reader["ReportID"];
			entity.UserId = (reader[ReportTemplateColumn.UserId.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ReportTemplateColumn.UserId.ToString())];
			entity.DuLieu = (reader[ReportTemplateColumn.DuLieu.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(ReportTemplateColumn.DuLieu.ToString())];
			entity.NgayTao = (reader[ReportTemplateColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ReportTemplateColumn.NgayTao.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ReportTemplate"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ReportTemplate"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ReportTemplate entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ReportId = (System.String)dataRow["ReportID"];
			entity.OriginalReportId = (System.String)dataRow["ReportID"];
			entity.UserId = Convert.IsDBNull(dataRow["UserID"]) ? null : (System.Int32?)dataRow["UserID"];
			entity.DuLieu = Convert.IsDBNull(dataRow["DuLieu"]) ? null : (System.Byte[])dataRow["DuLieu"];
			entity.NgayTao = Convert.IsDBNull(dataRow["NgayTao"]) ? null : (System.DateTime?)dataRow["NgayTao"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ReportTemplate"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ReportTemplate Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ReportTemplate entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region UserIdSource	
			if (CanDeepLoad(entity, "TaiKhoan|UserIdSource", deepLoadType, innerList) 
				&& entity.UserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.UserId ?? (int)0);
				TaiKhoan tmpEntity = EntityManager.LocateEntity<TaiKhoan>(EntityLocator.ConstructKeyFromPkItems(typeof(TaiKhoan), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.UserIdSource = tmpEntity;
				else
					entity.UserIdSource = DataRepository.TaiKhoanProvider.GetByMaTaiKhoan(transactionManager, (entity.UserId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'UserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.UserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TaiKhoanProvider.DeepLoad(transactionManager, entity.UserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion UserIdSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.ReportTemplate object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ReportTemplate instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ReportTemplate Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ReportTemplate entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region UserIdSource
			if (CanDeepSave(entity, "TaiKhoan|UserIdSource", deepSaveType, innerList) 
				&& entity.UserIdSource != null)
			{
				DataRepository.TaiKhoanProvider.Save(transactionManager, entity.UserIdSource);
				entity.UserId = entity.UserIdSource.MaTaiKhoan;
			}
			#endregion 
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
	
	#region ReportTemplateChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ReportTemplate</c>
	///</summary>
	public enum ReportTemplateChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>TaiKhoan</c> at UserIdSource
		///</summary>
		[ChildEntityType(typeof(TaiKhoan))]
		TaiKhoan,
	}
	
	#endregion ReportTemplateChildEntityTypes
	
	#region ReportTemplateFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ReportTemplateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ReportTemplate"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ReportTemplateFilterBuilder : SqlFilterBuilder<ReportTemplateColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportTemplateFilterBuilder class.
		/// </summary>
		public ReportTemplateFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ReportTemplateFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ReportTemplateFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ReportTemplateFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ReportTemplateFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ReportTemplateFilterBuilder
	
	#region ReportTemplateParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ReportTemplateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ReportTemplate"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ReportTemplateParameterBuilder : ParameterizedSqlFilterBuilder<ReportTemplateColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportTemplateParameterBuilder class.
		/// </summary>
		public ReportTemplateParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ReportTemplateParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ReportTemplateParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ReportTemplateParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ReportTemplateParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ReportTemplateParameterBuilder
	
	#region ReportTemplateSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ReportTemplateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ReportTemplate"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ReportTemplateSortBuilder : SqlSortBuilder<ReportTemplateColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportTemplateSqlSortBuilder class.
		/// </summary>
		public ReportTemplateSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ReportTemplateSortBuilder
	
} // end namespace
