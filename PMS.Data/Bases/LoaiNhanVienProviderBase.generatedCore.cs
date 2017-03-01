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
	/// This class is the base class for any <see cref="LoaiNhanVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LoaiNhanVienProviderBaseCore : EntityProviderBase<PMS.Entities.LoaiNhanVien, PMS.Entities.LoaiNhanVienKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.LoaiNhanVienKey key)
		{
			return Delete(transactionManager, key.MaLoaiNhanVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLoaiNhanVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maLoaiNhanVien)
		{
			return Delete(null, _maLoaiNhanVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiNhanVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maLoaiNhanVien);		
		
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
		public override PMS.Entities.LoaiNhanVien Get(TransactionManager transactionManager, PMS.Entities.LoaiNhanVienKey key, int start, int pageLength)
		{
			return GetByMaLoaiNhanVien(transactionManager, key.MaLoaiNhanVien, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_LoaiNhanVien index.
		/// </summary>
		/// <param name="_maLoaiNhanVien"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiNhanVien"/> class.</returns>
		public PMS.Entities.LoaiNhanVien GetByMaLoaiNhanVien(System.Int32 _maLoaiNhanVien)
		{
			int count = -1;
			return GetByMaLoaiNhanVien(null,_maLoaiNhanVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiNhanVien index.
		/// </summary>
		/// <param name="_maLoaiNhanVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiNhanVien"/> class.</returns>
		public PMS.Entities.LoaiNhanVien GetByMaLoaiNhanVien(System.Int32 _maLoaiNhanVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiNhanVien(null, _maLoaiNhanVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiNhanVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiNhanVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiNhanVien"/> class.</returns>
		public PMS.Entities.LoaiNhanVien GetByMaLoaiNhanVien(TransactionManager transactionManager, System.Int32 _maLoaiNhanVien)
		{
			int count = -1;
			return GetByMaLoaiNhanVien(transactionManager, _maLoaiNhanVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiNhanVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiNhanVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiNhanVien"/> class.</returns>
		public PMS.Entities.LoaiNhanVien GetByMaLoaiNhanVien(TransactionManager transactionManager, System.Int32 _maLoaiNhanVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiNhanVien(transactionManager, _maLoaiNhanVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiNhanVien index.
		/// </summary>
		/// <param name="_maLoaiNhanVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiNhanVien"/> class.</returns>
		public PMS.Entities.LoaiNhanVien GetByMaLoaiNhanVien(System.Int32 _maLoaiNhanVien, int start, int pageLength, out int count)
		{
			return GetByMaLoaiNhanVien(null, _maLoaiNhanVien, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiNhanVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiNhanVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiNhanVien"/> class.</returns>
		public abstract PMS.Entities.LoaiNhanVien GetByMaLoaiNhanVien(TransactionManager transactionManager, System.Int32 _maLoaiNhanVien, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LoaiNhanVien&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LoaiNhanVien&gt;"/></returns>
		public static TList<LoaiNhanVien> Fill(IDataReader reader, TList<LoaiNhanVien> rows, int start, int pageLength)
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
				
				PMS.Entities.LoaiNhanVien c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LoaiNhanVien")
					.Append("|").Append((System.Int32)reader[((int)LoaiNhanVienColumn.MaLoaiNhanVien - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LoaiNhanVien>(
					key.ToString(), // EntityTrackingKey
					"LoaiNhanVien",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.LoaiNhanVien();
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
					c.MaLoaiNhanVien = (System.Int32)reader[(LoaiNhanVienColumn.MaLoaiNhanVien.ToString())];
					c.MaQuanLy = (reader[LoaiNhanVienColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNhanVienColumn.MaQuanLy.ToString())];
					c.TenLoaiNhanVien = (reader[LoaiNhanVienColumn.TenLoaiNhanVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNhanVienColumn.TenLoaiNhanVien.ToString())];
					c.GhiChu = (reader[LoaiNhanVienColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNhanVienColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[LoaiNhanVienColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNhanVienColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[LoaiNhanVienColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNhanVienColumn.NguoiCapNhat.ToString())];
					c.Hrmid = (reader[LoaiNhanVienColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(LoaiNhanVienColumn.Hrmid.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiNhanVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiNhanVien"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.LoaiNhanVien entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLoaiNhanVien = (System.Int32)reader[(LoaiNhanVienColumn.MaLoaiNhanVien.ToString())];
			entity.MaQuanLy = (reader[LoaiNhanVienColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNhanVienColumn.MaQuanLy.ToString())];
			entity.TenLoaiNhanVien = (reader[LoaiNhanVienColumn.TenLoaiNhanVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNhanVienColumn.TenLoaiNhanVien.ToString())];
			entity.GhiChu = (reader[LoaiNhanVienColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNhanVienColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[LoaiNhanVienColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNhanVienColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[LoaiNhanVienColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiNhanVienColumn.NguoiCapNhat.ToString())];
			entity.Hrmid = (reader[LoaiNhanVienColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(LoaiNhanVienColumn.Hrmid.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiNhanVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiNhanVien"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.LoaiNhanVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLoaiNhanVien = (System.Int32)dataRow["MaLoaiNhanVien"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.TenLoaiNhanVien = Convert.IsDBNull(dataRow["TenLoaiNhanVien"]) ? null : (System.String)dataRow["TenLoaiNhanVien"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.Hrmid = Convert.IsDBNull(dataRow["HRMID"]) ? null : (System.Guid?)dataRow["HRMID"];
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
		/// <param name="entity">The <see cref="PMS.Entities.LoaiNhanVien"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.LoaiNhanVien Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.LoaiNhanVien entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaLoaiNhanVien methods when available
			
			#region GiangVienCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVien>|GiangVienCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienCollection = DataRepository.GiangVienProvider.GetByMaLoaiNhanVien(transactionManager, entity.MaLoaiNhanVien);

				if (deep && entity.GiangVienCollection.Count > 0)
				{
					deepHandles.Add("GiangVienCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVien>) DataRepository.GiangVienProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region QuyDinhTienCanTrenCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<QuyDinhTienCanTren>|QuyDinhTienCanTrenCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'QuyDinhTienCanTrenCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.QuyDinhTienCanTrenCollection = DataRepository.QuyDinhTienCanTrenProvider.GetByMaLoaiNhanVien(transactionManager, entity.MaLoaiNhanVien);

				if (deep && entity.QuyDinhTienCanTrenCollection.Count > 0)
				{
					deepHandles.Add("QuyDinhTienCanTrenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<QuyDinhTienCanTren>) DataRepository.QuyDinhTienCanTrenProvider.DeepLoad,
						new object[] { transactionManager, entity.QuyDinhTienCanTrenCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.LoaiNhanVien object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.LoaiNhanVien instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.LoaiNhanVien Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.LoaiNhanVien entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<GiangVien>
				if (CanDeepSave(entity.GiangVienCollection, "List<GiangVien>|GiangVienCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVien child in entity.GiangVienCollection)
					{
						if(child.MaLoaiNhanVienSource != null)
						{
							child.MaLoaiNhanVien = child.MaLoaiNhanVienSource.MaLoaiNhanVien;
						}
						else
						{
							child.MaLoaiNhanVien = entity.MaLoaiNhanVien;
						}

					}

					if (entity.GiangVienCollection.Count > 0 || entity.GiangVienCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienProvider.Save(transactionManager, entity.GiangVienCollection);
						
						deepHandles.Add("GiangVienCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVien >) DataRepository.GiangVienProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<QuyDinhTienCanTren>
				if (CanDeepSave(entity.QuyDinhTienCanTrenCollection, "List<QuyDinhTienCanTren>|QuyDinhTienCanTrenCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(QuyDinhTienCanTren child in entity.QuyDinhTienCanTrenCollection)
					{
						if(child.MaLoaiNhanVienSource != null)
						{
							child.MaLoaiNhanVien = child.MaLoaiNhanVienSource.MaLoaiNhanVien;
						}
						else
						{
							child.MaLoaiNhanVien = entity.MaLoaiNhanVien;
						}

					}

					if (entity.QuyDinhTienCanTrenCollection.Count > 0 || entity.QuyDinhTienCanTrenCollection.DeletedItems.Count > 0)
					{
						//DataRepository.QuyDinhTienCanTrenProvider.Save(transactionManager, entity.QuyDinhTienCanTrenCollection);
						
						deepHandles.Add("QuyDinhTienCanTrenCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< QuyDinhTienCanTren >) DataRepository.QuyDinhTienCanTrenProvider.DeepSave,
							new object[] { transactionManager, entity.QuyDinhTienCanTrenCollection, deepSaveType, childTypes, innerList }
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
	
	#region LoaiNhanVienChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.LoaiNhanVien</c>
	///</summary>
	public enum LoaiNhanVienChildEntityTypes
	{
		///<summary>
		/// Collection of <c>LoaiNhanVien</c> as OneToMany for GiangVienCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVien>))]
		GiangVienCollection,
		///<summary>
		/// Collection of <c>LoaiNhanVien</c> as OneToMany for QuyDinhTienCanTrenCollection
		///</summary>
		[ChildEntityType(typeof(TList<QuyDinhTienCanTren>))]
		QuyDinhTienCanTrenCollection,
	}
	
	#endregion LoaiNhanVienChildEntityTypes
	
	#region LoaiNhanVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LoaiNhanVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiNhanVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiNhanVienFilterBuilder : SqlFilterBuilder<LoaiNhanVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiNhanVienFilterBuilder class.
		/// </summary>
		public LoaiNhanVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiNhanVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiNhanVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiNhanVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiNhanVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiNhanVienFilterBuilder
	
	#region LoaiNhanVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LoaiNhanVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiNhanVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiNhanVienParameterBuilder : ParameterizedSqlFilterBuilder<LoaiNhanVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiNhanVienParameterBuilder class.
		/// </summary>
		public LoaiNhanVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiNhanVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiNhanVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiNhanVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiNhanVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiNhanVienParameterBuilder
	
	#region LoaiNhanVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LoaiNhanVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiNhanVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LoaiNhanVienSortBuilder : SqlSortBuilder<LoaiNhanVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiNhanVienSqlSortBuilder class.
		/// </summary>
		public LoaiNhanVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LoaiNhanVienSortBuilder
	
} // end namespace
