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
	/// This class is the base class for any <see cref="DanhMucQuyMoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DanhMucQuyMoProviderBaseCore : EntityProviderBase<PMS.Entities.DanhMucQuyMo, PMS.Entities.DanhMucQuyMoKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DanhMucQuyMoKey key)
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
		public override PMS.Entities.DanhMucQuyMo Get(TransactionManager transactionManager, PMS.Entities.DanhMucQuyMoKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DanhMucQuyMon index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucQuyMo"/> class.</returns>
		public PMS.Entities.DanhMucQuyMo GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucQuyMon index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucQuyMo"/> class.</returns>
		public PMS.Entities.DanhMucQuyMo GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucQuyMon index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucQuyMo"/> class.</returns>
		public PMS.Entities.DanhMucQuyMo GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucQuyMon index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucQuyMo"/> class.</returns>
		public PMS.Entities.DanhMucQuyMo GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucQuyMon index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucQuyMo"/> class.</returns>
		public PMS.Entities.DanhMucQuyMo GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucQuyMon index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucQuyMo"/> class.</returns>
		public abstract PMS.Entities.DanhMucQuyMo GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DanhMucQuyMo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DanhMucQuyMo&gt;"/></returns>
		public static TList<DanhMucQuyMo> Fill(IDataReader reader, TList<DanhMucQuyMo> rows, int start, int pageLength)
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
				
				PMS.Entities.DanhMucQuyMo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DanhMucQuyMo")
					.Append("|").Append((System.Int32)reader[((int)DanhMucQuyMoColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DanhMucQuyMo>(
					key.ToString(), // EntityTrackingKey
					"DanhMucQuyMo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DanhMucQuyMo();
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
					c.Id = (System.Int32)reader[(DanhMucQuyMoColumn.Id.ToString())];
					c.MaQuyMo = (reader[DanhMucQuyMoColumn.MaQuyMo.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucQuyMoColumn.MaQuyMo.ToString())];
					c.TenQuyMo = (reader[DanhMucQuyMoColumn.TenQuyMo.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucQuyMoColumn.TenQuyMo.ToString())];
					c.GhiChu = (reader[DanhMucQuyMoColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucQuyMoColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DanhMucQuyMo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucQuyMo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DanhMucQuyMo entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(DanhMucQuyMoColumn.Id.ToString())];
			entity.MaQuyMo = (reader[DanhMucQuyMoColumn.MaQuyMo.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucQuyMoColumn.MaQuyMo.ToString())];
			entity.TenQuyMo = (reader[DanhMucQuyMoColumn.TenQuyMo.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucQuyMoColumn.TenQuyMo.ToString())];
			entity.GhiChu = (reader[DanhMucQuyMoColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucQuyMoColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DanhMucQuyMo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucQuyMo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DanhMucQuyMo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaQuyMo = Convert.IsDBNull(dataRow["MaQuyMo"]) ? null : (System.String)dataRow["MaQuyMo"];
			entity.TenQuyMo = Convert.IsDBNull(dataRow["TenQuyMo"]) ? null : (System.String)dataRow["TenQuyMo"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucQuyMo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DanhMucQuyMo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DanhMucQuyMo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetById methods when available
			
			#region DinhMucGioChuanToiThieuTheoChucVuCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<DinhMucGioChuanToiThieuTheoChucVu>|DinhMucGioChuanToiThieuTheoChucVuCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'DinhMucGioChuanToiThieuTheoChucVuCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.DinhMucGioChuanToiThieuTheoChucVuCollection = DataRepository.DinhMucGioChuanToiThieuTheoChucVuProvider.GetByIdQuyMo(transactionManager, entity.Id);

				if (deep && entity.DinhMucGioChuanToiThieuTheoChucVuCollection.Count > 0)
				{
					deepHandles.Add("DinhMucGioChuanToiThieuTheoChucVuCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<DinhMucGioChuanToiThieuTheoChucVu>) DataRepository.DinhMucGioChuanToiThieuTheoChucVuProvider.DeepLoad,
						new object[] { transactionManager, entity.DinhMucGioChuanToiThieuTheoChucVuCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region QuyMoKhoaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<QuyMoKhoa>|QuyMoKhoaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'QuyMoKhoaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.QuyMoKhoaCollection = DataRepository.QuyMoKhoaProvider.GetByIdQuyMo(transactionManager, entity.Id);

				if (deep && entity.QuyMoKhoaCollection.Count > 0)
				{
					deepHandles.Add("QuyMoKhoaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<QuyMoKhoa>) DataRepository.QuyMoKhoaProvider.DeepLoad,
						new object[] { transactionManager, entity.QuyMoKhoaCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
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
		/// Deep Save the entire object graph of the PMS.Entities.DanhMucQuyMo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DanhMucQuyMo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DanhMucQuyMo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DanhMucQuyMo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<DinhMucGioChuanToiThieuTheoChucVu>
				if (CanDeepSave(entity.DinhMucGioChuanToiThieuTheoChucVuCollection, "List<DinhMucGioChuanToiThieuTheoChucVu>|DinhMucGioChuanToiThieuTheoChucVuCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(DinhMucGioChuanToiThieuTheoChucVu child in entity.DinhMucGioChuanToiThieuTheoChucVuCollection)
					{
						if(child.IdQuyMoSource != null)
						{
							child.IdQuyMo = child.IdQuyMoSource.Id;
						}
						else
						{
							child.IdQuyMo = entity.Id;
						}

					}

					if (entity.DinhMucGioChuanToiThieuTheoChucVuCollection.Count > 0 || entity.DinhMucGioChuanToiThieuTheoChucVuCollection.DeletedItems.Count > 0)
					{
						//DataRepository.DinhMucGioChuanToiThieuTheoChucVuProvider.Save(transactionManager, entity.DinhMucGioChuanToiThieuTheoChucVuCollection);
						
						deepHandles.Add("DinhMucGioChuanToiThieuTheoChucVuCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< DinhMucGioChuanToiThieuTheoChucVu >) DataRepository.DinhMucGioChuanToiThieuTheoChucVuProvider.DeepSave,
							new object[] { transactionManager, entity.DinhMucGioChuanToiThieuTheoChucVuCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<QuyMoKhoa>
				if (CanDeepSave(entity.QuyMoKhoaCollection, "List<QuyMoKhoa>|QuyMoKhoaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(QuyMoKhoa child in entity.QuyMoKhoaCollection)
					{
						if(child.IdQuyMoSource != null)
						{
							child.IdQuyMo = child.IdQuyMoSource.Id;
						}
						else
						{
							child.IdQuyMo = entity.Id;
						}

					}

					if (entity.QuyMoKhoaCollection.Count > 0 || entity.QuyMoKhoaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.QuyMoKhoaProvider.Save(transactionManager, entity.QuyMoKhoaCollection);
						
						deepHandles.Add("QuyMoKhoaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< QuyMoKhoa >) DataRepository.QuyMoKhoaProvider.DeepSave,
							new object[] { transactionManager, entity.QuyMoKhoaCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
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
	
	#region DanhMucQuyMoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DanhMucQuyMo</c>
	///</summary>
	public enum DanhMucQuyMoChildEntityTypes
	{
		///<summary>
		/// Collection of <c>DanhMucQuyMo</c> as OneToMany for DinhMucGioChuanToiThieuTheoChucVuCollection
		///</summary>
		[ChildEntityType(typeof(TList<DinhMucGioChuanToiThieuTheoChucVu>))]
		DinhMucGioChuanToiThieuTheoChucVuCollection,
		///<summary>
		/// Collection of <c>DanhMucQuyMo</c> as OneToMany for QuyMoKhoaCollection
		///</summary>
		[ChildEntityType(typeof(TList<QuyMoKhoa>))]
		QuyMoKhoaCollection,
	}
	
	#endregion DanhMucQuyMoChildEntityTypes
	
	#region DanhMucQuyMoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DanhMucQuyMoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucQuyMo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucQuyMoFilterBuilder : SqlFilterBuilder<DanhMucQuyMoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucQuyMoFilterBuilder class.
		/// </summary>
		public DanhMucQuyMoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DanhMucQuyMoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DanhMucQuyMoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DanhMucQuyMoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DanhMucQuyMoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DanhMucQuyMoFilterBuilder
	
	#region DanhMucQuyMoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DanhMucQuyMoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucQuyMo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucQuyMoParameterBuilder : ParameterizedSqlFilterBuilder<DanhMucQuyMoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucQuyMoParameterBuilder class.
		/// </summary>
		public DanhMucQuyMoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DanhMucQuyMoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DanhMucQuyMoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DanhMucQuyMoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DanhMucQuyMoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DanhMucQuyMoParameterBuilder
	
	#region DanhMucQuyMoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DanhMucQuyMoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucQuyMo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DanhMucQuyMoSortBuilder : SqlSortBuilder<DanhMucQuyMoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucQuyMoSqlSortBuilder class.
		/// </summary>
		public DanhMucQuyMoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DanhMucQuyMoSortBuilder
	
} // end namespace
