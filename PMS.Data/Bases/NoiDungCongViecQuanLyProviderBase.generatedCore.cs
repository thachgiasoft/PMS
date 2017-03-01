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
	/// This class is the base class for any <see cref="NoiDungCongViecQuanLyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class NoiDungCongViecQuanLyProviderBaseCore : EntityProviderBase<PMS.Entities.NoiDungCongViecQuanLy, PMS.Entities.NoiDungCongViecQuanLyKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.NoiDungCongViecQuanLyKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int64 _id)
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
		public abstract bool Delete(TransactionManager transactionManager, System.Int64 _id);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ND_CV key.
		///		FK_ND_CV Description: 
		/// </summary>
		/// <param name="_maCongViec"></param>
		/// <returns>Returns a typed collection of PMS.Entities.NoiDungCongViecQuanLy objects.</returns>
		public TList<NoiDungCongViecQuanLy> GetByMaCongViec(System.Int32? _maCongViec)
		{
			int count = -1;
			return GetByMaCongViec(_maCongViec, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ND_CV key.
		///		FK_ND_CV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCongViec"></param>
		/// <returns>Returns a typed collection of PMS.Entities.NoiDungCongViecQuanLy objects.</returns>
		/// <remarks></remarks>
		public TList<NoiDungCongViecQuanLy> GetByMaCongViec(TransactionManager transactionManager, System.Int32? _maCongViec)
		{
			int count = -1;
			return GetByMaCongViec(transactionManager, _maCongViec, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ND_CV key.
		///		FK_ND_CV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCongViec"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.NoiDungCongViecQuanLy objects.</returns>
		public TList<NoiDungCongViecQuanLy> GetByMaCongViec(TransactionManager transactionManager, System.Int32? _maCongViec, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCongViec(transactionManager, _maCongViec, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ND_CV key.
		///		fkNdCv Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maCongViec"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.NoiDungCongViecQuanLy objects.</returns>
		public TList<NoiDungCongViecQuanLy> GetByMaCongViec(System.Int32? _maCongViec, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaCongViec(null, _maCongViec, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ND_CV key.
		///		fkNdCv Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maCongViec"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.NoiDungCongViecQuanLy objects.</returns>
		public TList<NoiDungCongViecQuanLy> GetByMaCongViec(System.Int32? _maCongViec, int start, int pageLength,out int count)
		{
			return GetByMaCongViec(null, _maCongViec, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ND_CV key.
		///		FK_ND_CV Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCongViec"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.NoiDungCongViecQuanLy objects.</returns>
		public abstract TList<NoiDungCongViecQuanLy> GetByMaCongViec(TransactionManager transactionManager, System.Int32? _maCongViec, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.NoiDungCongViecQuanLy Get(TransactionManager transactionManager, PMS.Entities.NoiDungCongViecQuanLyKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__NoiDungC__3214EC0753486626 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NoiDungCongViecQuanLy"/> class.</returns>
		public PMS.Entities.NoiDungCongViecQuanLy GetById(System.Int64 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NoiDungC__3214EC0753486626 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NoiDungCongViecQuanLy"/> class.</returns>
		public PMS.Entities.NoiDungCongViecQuanLy GetById(System.Int64 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NoiDungC__3214EC0753486626 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NoiDungCongViecQuanLy"/> class.</returns>
		public PMS.Entities.NoiDungCongViecQuanLy GetById(TransactionManager transactionManager, System.Int64 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NoiDungC__3214EC0753486626 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NoiDungCongViecQuanLy"/> class.</returns>
		public PMS.Entities.NoiDungCongViecQuanLy GetById(TransactionManager transactionManager, System.Int64 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NoiDungC__3214EC0753486626 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NoiDungCongViecQuanLy"/> class.</returns>
		public PMS.Entities.NoiDungCongViecQuanLy GetById(System.Int64 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__NoiDungC__3214EC0753486626 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NoiDungCongViecQuanLy"/> class.</returns>
		public abstract PMS.Entities.NoiDungCongViecQuanLy GetById(TransactionManager transactionManager, System.Int64 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;NoiDungCongViecQuanLy&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;NoiDungCongViecQuanLy&gt;"/></returns>
		public static TList<NoiDungCongViecQuanLy> Fill(IDataReader reader, TList<NoiDungCongViecQuanLy> rows, int start, int pageLength)
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
				
				PMS.Entities.NoiDungCongViecQuanLy c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("NoiDungCongViecQuanLy")
					.Append("|").Append((System.Int64)reader[((int)NoiDungCongViecQuanLyColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<NoiDungCongViecQuanLy>(
					key.ToString(), // EntityTrackingKey
					"NoiDungCongViecQuanLy",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.NoiDungCongViecQuanLy();
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
					c.Id = (System.Int64)reader[(NoiDungCongViecQuanLyColumn.Id.ToString())];
					c.MaCongViec = (reader[NoiDungCongViecQuanLyColumn.MaCongViec.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(NoiDungCongViecQuanLyColumn.MaCongViec.ToString())];
					c.NoiDung = (reader[NoiDungCongViecQuanLyColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(NoiDungCongViecQuanLyColumn.NoiDung.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NoiDungCongViecQuanLy"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NoiDungCongViecQuanLy"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.NoiDungCongViecQuanLy entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int64)reader[(NoiDungCongViecQuanLyColumn.Id.ToString())];
			entity.MaCongViec = (reader[NoiDungCongViecQuanLyColumn.MaCongViec.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(NoiDungCongViecQuanLyColumn.MaCongViec.ToString())];
			entity.NoiDung = (reader[NoiDungCongViecQuanLyColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(NoiDungCongViecQuanLyColumn.NoiDung.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NoiDungCongViecQuanLy"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NoiDungCongViecQuanLy"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.NoiDungCongViecQuanLy entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int64)dataRow["Id"];
			entity.MaCongViec = Convert.IsDBNull(dataRow["MaCongViec"]) ? null : (System.Int32?)dataRow["MaCongViec"];
			entity.NoiDung = Convert.IsDBNull(dataRow["NoiDung"]) ? null : (System.String)dataRow["NoiDung"];
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
		/// <param name="entity">The <see cref="PMS.Entities.NoiDungCongViecQuanLy"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.NoiDungCongViecQuanLy Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.NoiDungCongViecQuanLy entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaCongViecSource	
			if (CanDeepLoad(entity, "DanhMucHoatDongQuanLy|MaCongViecSource", deepLoadType, innerList) 
				&& entity.MaCongViecSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaCongViec ?? (int)0);
				DanhMucHoatDongQuanLy tmpEntity = EntityManager.LocateEntity<DanhMucHoatDongQuanLy>(EntityLocator.ConstructKeyFromPkItems(typeof(DanhMucHoatDongQuanLy), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaCongViecSource = tmpEntity;
				else
					entity.MaCongViecSource = DataRepository.DanhMucHoatDongQuanLyProvider.GetById(transactionManager, (entity.MaCongViec ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaCongViecSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaCongViecSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.DanhMucHoatDongQuanLyProvider.DeepLoad(transactionManager, entity.MaCongViecSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaCongViecSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.NoiDungCongViecQuanLy object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.NoiDungCongViecQuanLy instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.NoiDungCongViecQuanLy Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.NoiDungCongViecQuanLy entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaCongViecSource
			if (CanDeepSave(entity, "DanhMucHoatDongQuanLy|MaCongViecSource", deepSaveType, innerList) 
				&& entity.MaCongViecSource != null)
			{
				DataRepository.DanhMucHoatDongQuanLyProvider.Save(transactionManager, entity.MaCongViecSource);
				entity.MaCongViec = entity.MaCongViecSource.Id;
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
	
	#region NoiDungCongViecQuanLyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.NoiDungCongViecQuanLy</c>
	///</summary>
	public enum NoiDungCongViecQuanLyChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>DanhMucHoatDongQuanLy</c> at MaCongViecSource
		///</summary>
		[ChildEntityType(typeof(DanhMucHoatDongQuanLy))]
		DanhMucHoatDongQuanLy,
	}
	
	#endregion NoiDungCongViecQuanLyChildEntityTypes
	
	#region NoiDungCongViecQuanLyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;NoiDungCongViecQuanLyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NoiDungCongViecQuanLy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NoiDungCongViecQuanLyFilterBuilder : SqlFilterBuilder<NoiDungCongViecQuanLyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NoiDungCongViecQuanLyFilterBuilder class.
		/// </summary>
		public NoiDungCongViecQuanLyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NoiDungCongViecQuanLyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NoiDungCongViecQuanLyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NoiDungCongViecQuanLyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NoiDungCongViecQuanLyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NoiDungCongViecQuanLyFilterBuilder
	
	#region NoiDungCongViecQuanLyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;NoiDungCongViecQuanLyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NoiDungCongViecQuanLy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NoiDungCongViecQuanLyParameterBuilder : ParameterizedSqlFilterBuilder<NoiDungCongViecQuanLyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NoiDungCongViecQuanLyParameterBuilder class.
		/// </summary>
		public NoiDungCongViecQuanLyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NoiDungCongViecQuanLyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NoiDungCongViecQuanLyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NoiDungCongViecQuanLyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NoiDungCongViecQuanLyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NoiDungCongViecQuanLyParameterBuilder
	
	#region NoiDungCongViecQuanLySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;NoiDungCongViecQuanLyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NoiDungCongViecQuanLy"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class NoiDungCongViecQuanLySortBuilder : SqlSortBuilder<NoiDungCongViecQuanLyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NoiDungCongViecQuanLySqlSortBuilder class.
		/// </summary>
		public NoiDungCongViecQuanLySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion NoiDungCongViecQuanLySortBuilder
	
} // end namespace
