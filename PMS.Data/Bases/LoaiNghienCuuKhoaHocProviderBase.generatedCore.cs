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
	/// This class is the base class for any <see cref="LoaiNghienCuuKhoaHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LoaiNghienCuuKhoaHocProviderBaseCore : EntityProviderBase<PMS.Entities.LoaiNghienCuuKhoaHoc, PMS.Entities.LoaiNghienCuuKhoaHocKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.LoaiNghienCuuKhoaHocKey key)
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
		public override PMS.Entities.LoaiNghienCuuKhoaHoc Get(TransactionManager transactionManager, PMS.Entities.LoaiNghienCuuKhoaHocKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__LoaiNghi__3214EC079BAAAFE5 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiNghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.LoaiNghienCuuKhoaHoc GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiNghi__3214EC079BAAAFE5 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiNghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.LoaiNghienCuuKhoaHoc GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiNghi__3214EC079BAAAFE5 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiNghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.LoaiNghienCuuKhoaHoc GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiNghi__3214EC079BAAAFE5 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiNghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.LoaiNghienCuuKhoaHoc GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiNghi__3214EC079BAAAFE5 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiNghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.LoaiNghienCuuKhoaHoc GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__LoaiNghi__3214EC079BAAAFE5 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiNghienCuuKhoaHoc"/> class.</returns>
		public abstract PMS.Entities.LoaiNghienCuuKhoaHoc GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LoaiNghienCuuKhoaHoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LoaiNghienCuuKhoaHoc&gt;"/></returns>
		public static TList<LoaiNghienCuuKhoaHoc> Fill(IDataReader reader, TList<LoaiNghienCuuKhoaHoc> rows, int start, int pageLength)
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
				
				PMS.Entities.LoaiNghienCuuKhoaHoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LoaiNghienCuuKhoaHoc")
					.Append("|").Append((System.Int32)reader[((int)LoaiNghienCuuKhoaHocColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LoaiNghienCuuKhoaHoc>(
					key.ToString(), // EntityTrackingKey
					"LoaiNghienCuuKhoaHoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.LoaiNghienCuuKhoaHoc();
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
					c.Id = (System.Int32)reader[(LoaiNghienCuuKhoaHocColumn.Id.ToString())];
					c.MaLoaiNckh = (reader[LoaiNghienCuuKhoaHocColumn.MaLoaiNckh.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNghienCuuKhoaHocColumn.MaLoaiNckh.ToString())];
					c.TenLoaiNckh = (reader[LoaiNghienCuuKhoaHocColumn.TenLoaiNckh.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNghienCuuKhoaHocColumn.TenLoaiNckh.ToString())];
					c.GhiChu = (reader[LoaiNghienCuuKhoaHocColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNghienCuuKhoaHocColumn.GhiChu.ToString())];
					c.ChuTriDeTaiHuong = (reader[LoaiNghienCuuKhoaHocColumn.ChuTriDeTaiHuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(LoaiNghienCuuKhoaHocColumn.ChuTriDeTaiHuong.ToString())];
					c.ThanhVienHuong = (reader[LoaiNghienCuuKhoaHocColumn.ThanhVienHuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(LoaiNghienCuuKhoaHocColumn.ThanhVienHuong.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiNghienCuuKhoaHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiNghienCuuKhoaHoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.LoaiNghienCuuKhoaHoc entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(LoaiNghienCuuKhoaHocColumn.Id.ToString())];
			entity.MaLoaiNckh = (reader[LoaiNghienCuuKhoaHocColumn.MaLoaiNckh.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNghienCuuKhoaHocColumn.MaLoaiNckh.ToString())];
			entity.TenLoaiNckh = (reader[LoaiNghienCuuKhoaHocColumn.TenLoaiNckh.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNghienCuuKhoaHocColumn.TenLoaiNckh.ToString())];
			entity.GhiChu = (reader[LoaiNghienCuuKhoaHocColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNghienCuuKhoaHocColumn.GhiChu.ToString())];
			entity.ChuTriDeTaiHuong = (reader[LoaiNghienCuuKhoaHocColumn.ChuTriDeTaiHuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(LoaiNghienCuuKhoaHocColumn.ChuTriDeTaiHuong.ToString())];
			entity.ThanhVienHuong = (reader[LoaiNghienCuuKhoaHocColumn.ThanhVienHuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(LoaiNghienCuuKhoaHocColumn.ThanhVienHuong.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiNghienCuuKhoaHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiNghienCuuKhoaHoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.LoaiNghienCuuKhoaHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaLoaiNckh = Convert.IsDBNull(dataRow["MaLoaiNCKH"]) ? null : (System.String)dataRow["MaLoaiNCKH"];
			entity.TenLoaiNckh = Convert.IsDBNull(dataRow["TenLoaiNCKH"]) ? null : (System.String)dataRow["TenLoaiNCKH"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.ChuTriDeTaiHuong = Convert.IsDBNull(dataRow["ChuTriDeTaiHuong"]) ? null : (System.Decimal?)dataRow["ChuTriDeTaiHuong"];
			entity.ThanhVienHuong = Convert.IsDBNull(dataRow["ThanhVienHuong"]) ? null : (System.Decimal?)dataRow["ThanhVienHuong"];
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
		/// <param name="entity">The <see cref="PMS.Entities.LoaiNghienCuuKhoaHoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.LoaiNghienCuuKhoaHoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.LoaiNghienCuuKhoaHoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetById methods when available
			
			#region DanhMucNghienCuuKhoaHocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<DanhMucNghienCuuKhoaHoc>|DanhMucNghienCuuKhoaHocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'DanhMucNghienCuuKhoaHocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.DanhMucNghienCuuKhoaHocCollection = DataRepository.DanhMucNghienCuuKhoaHocProvider.GetByMaLoaiNckh(transactionManager, entity.Id);

				if (deep && entity.DanhMucNghienCuuKhoaHocCollection.Count > 0)
				{
					deepHandles.Add("DanhMucNghienCuuKhoaHocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<DanhMucNghienCuuKhoaHoc>) DataRepository.DanhMucNghienCuuKhoaHocProvider.DeepLoad,
						new object[] { transactionManager, entity.DanhMucNghienCuuKhoaHocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.LoaiNghienCuuKhoaHoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.LoaiNghienCuuKhoaHoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.LoaiNghienCuuKhoaHoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.LoaiNghienCuuKhoaHoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<DanhMucNghienCuuKhoaHoc>
				if (CanDeepSave(entity.DanhMucNghienCuuKhoaHocCollection, "List<DanhMucNghienCuuKhoaHoc>|DanhMucNghienCuuKhoaHocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(DanhMucNghienCuuKhoaHoc child in entity.DanhMucNghienCuuKhoaHocCollection)
					{
						if(child.MaLoaiNckhSource != null)
						{
							child.MaLoaiNckh = child.MaLoaiNckhSource.Id;
						}
						else
						{
							child.MaLoaiNckh = entity.Id;
						}

					}

					if (entity.DanhMucNghienCuuKhoaHocCollection.Count > 0 || entity.DanhMucNghienCuuKhoaHocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.DanhMucNghienCuuKhoaHocProvider.Save(transactionManager, entity.DanhMucNghienCuuKhoaHocCollection);
						
						deepHandles.Add("DanhMucNghienCuuKhoaHocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< DanhMucNghienCuuKhoaHoc >) DataRepository.DanhMucNghienCuuKhoaHocProvider.DeepSave,
							new object[] { transactionManager, entity.DanhMucNghienCuuKhoaHocCollection, deepSaveType, childTypes, innerList }
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
	
	#region LoaiNghienCuuKhoaHocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.LoaiNghienCuuKhoaHoc</c>
	///</summary>
	public enum LoaiNghienCuuKhoaHocChildEntityTypes
	{
		///<summary>
		/// Collection of <c>LoaiNghienCuuKhoaHoc</c> as OneToMany for DanhMucNghienCuuKhoaHocCollection
		///</summary>
		[ChildEntityType(typeof(TList<DanhMucNghienCuuKhoaHoc>))]
		DanhMucNghienCuuKhoaHocCollection,
	}
	
	#endregion LoaiNghienCuuKhoaHocChildEntityTypes
	
	#region LoaiNghienCuuKhoaHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LoaiNghienCuuKhoaHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiNghienCuuKhoaHocFilterBuilder : SqlFilterBuilder<LoaiNghienCuuKhoaHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiNghienCuuKhoaHocFilterBuilder class.
		/// </summary>
		public LoaiNghienCuuKhoaHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiNghienCuuKhoaHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiNghienCuuKhoaHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiNghienCuuKhoaHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiNghienCuuKhoaHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiNghienCuuKhoaHocFilterBuilder
	
	#region LoaiNghienCuuKhoaHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LoaiNghienCuuKhoaHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiNghienCuuKhoaHocParameterBuilder : ParameterizedSqlFilterBuilder<LoaiNghienCuuKhoaHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiNghienCuuKhoaHocParameterBuilder class.
		/// </summary>
		public LoaiNghienCuuKhoaHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiNghienCuuKhoaHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiNghienCuuKhoaHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiNghienCuuKhoaHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiNghienCuuKhoaHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiNghienCuuKhoaHocParameterBuilder
	
	#region LoaiNghienCuuKhoaHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LoaiNghienCuuKhoaHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiNghienCuuKhoaHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LoaiNghienCuuKhoaHocSortBuilder : SqlSortBuilder<LoaiNghienCuuKhoaHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiNghienCuuKhoaHocSqlSortBuilder class.
		/// </summary>
		public LoaiNghienCuuKhoaHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LoaiNghienCuuKhoaHocSortBuilder
	
} // end namespace
