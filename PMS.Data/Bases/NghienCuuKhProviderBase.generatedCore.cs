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
	/// This class is the base class for any <see cref="NghienCuuKhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class NghienCuuKhProviderBaseCore : EntityProviderBase<PMS.Entities.NghienCuuKh, PMS.Entities.NghienCuuKhKey>
	{		
		#region Get from Many To Many Relationship Functions
		#region GetByMaGiangVienFromGiangVienNghienCuuKh
		
		/// <summary>
		///		Gets NghienCuuKH objects from the datasource by MaGiangVien in the
		///		GiangVien_NghienCuuKH table. Table NghienCuuKH is related to table GiangVien
		///		through the (M:N) relationship defined in the GiangVien_NghienCuuKH table.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of NghienCuuKh objects.</returns>
		public TList<NghienCuuKh> GetByMaGiangVienFromGiangVienNghienCuuKh(System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVienFromGiangVienNghienCuuKh(null,_maGiangVien, 0, int.MaxValue, out count);
			
		}
		
		/// <summary>
		///		Gets PMS.Entities.NghienCuuKh objects from the datasource by MaGiangVien in the
		///		GiangVien_NghienCuuKH table. Table NghienCuuKH is related to table GiangVien
		///		through the (M:N) relationship defined in the GiangVien_NghienCuuKH table.
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a TList of NghienCuuKh objects.</returns>
		public TList<NghienCuuKh> GetByMaGiangVienFromGiangVienNghienCuuKh(System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienFromGiangVienNghienCuuKh(null, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		///		Gets NghienCuuKh objects from the datasource by MaGiangVien in the
		///		GiangVien_NghienCuuKH table. Table NghienCuuKH is related to table GiangVien
		///		through the (M:N) relationship defined in the GiangVien_NghienCuuKH table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of NghienCuuKH objects.</returns>
		public TList<NghienCuuKh> GetByMaGiangVienFromGiangVienNghienCuuKh(TransactionManager transactionManager, System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVienFromGiangVienNghienCuuKh(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
		
		/// <summary>
		///		Gets NghienCuuKh objects from the datasource by MaGiangVien in the
		///		GiangVien_NghienCuuKH table. Table NghienCuuKH is related to table GiangVien
		///		through the (M:N) relationship defined in the GiangVien_NghienCuuKH table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of NghienCuuKH objects.</returns>
		public TList<NghienCuuKh> GetByMaGiangVienFromGiangVienNghienCuuKh(TransactionManager transactionManager, System.Int32 _maGiangVien,int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienFromGiangVienNghienCuuKh(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		///		Gets NghienCuuKh objects from the datasource by MaGiangVien in the
		///		GiangVien_NghienCuuKH table. Table NghienCuuKH is related to table GiangVien
		///		through the (M:N) relationship defined in the GiangVien_NghienCuuKH table.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of NghienCuuKH objects.</returns>
		public TList<NghienCuuKh> GetByMaGiangVienFromGiangVienNghienCuuKh(System.Int32 _maGiangVien,int start, int pageLength, out int count)
		{
			
			return GetByMaGiangVienFromGiangVienNghienCuuKh(null, _maGiangVien, start, pageLength, out count);
		}


		/// <summary>
		///		Gets NghienCuuKH objects from the datasource by MaGiangVien in the
		///		GiangVien_NghienCuuKH table. Table NghienCuuKH is related to table GiangVien
		///		through the (M:N) relationship defined in the GiangVien_NghienCuuKH table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a TList of NghienCuuKh objects.</returns>
		public abstract TList<NghienCuuKh> GetByMaGiangVienFromGiangVienNghienCuuKh(TransactionManager transactionManager,System.Int32 _maGiangVien, int start, int pageLength, out int count);
		
		#endregion GetByMaGiangVienFromGiangVienNghienCuuKh
		
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.NghienCuuKhKey key)
		{
			return Delete(transactionManager, key.MaNckh);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maNckh">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maNckh)
		{
			return Delete(null, _maNckh);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNckh">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maNckh);		
		
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
		public override PMS.Entities.NghienCuuKh Get(TransactionManager transactionManager, PMS.Entities.NghienCuuKhKey key, int start, int pageLength)
		{
			return GetByMaNckh(transactionManager, key.MaNckh, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_NghienCuuKH index.
		/// </summary>
		/// <param name="_maNckh"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NghienCuuKh"/> class.</returns>
		public PMS.Entities.NghienCuuKh GetByMaNckh(System.Int32 _maNckh)
		{
			int count = -1;
			return GetByMaNckh(null,_maNckh, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NghienCuuKH index.
		/// </summary>
		/// <param name="_maNckh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NghienCuuKh"/> class.</returns>
		public PMS.Entities.NghienCuuKh GetByMaNckh(System.Int32 _maNckh, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNckh(null, _maNckh, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NghienCuuKH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNckh"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NghienCuuKh"/> class.</returns>
		public PMS.Entities.NghienCuuKh GetByMaNckh(TransactionManager transactionManager, System.Int32 _maNckh)
		{
			int count = -1;
			return GetByMaNckh(transactionManager, _maNckh, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NghienCuuKH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNckh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NghienCuuKh"/> class.</returns>
		public PMS.Entities.NghienCuuKh GetByMaNckh(TransactionManager transactionManager, System.Int32 _maNckh, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNckh(transactionManager, _maNckh, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NghienCuuKH index.
		/// </summary>
		/// <param name="_maNckh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NghienCuuKh"/> class.</returns>
		public PMS.Entities.NghienCuuKh GetByMaNckh(System.Int32 _maNckh, int start, int pageLength, out int count)
		{
			return GetByMaNckh(null, _maNckh, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NghienCuuKH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNckh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NghienCuuKh"/> class.</returns>
		public abstract PMS.Entities.NghienCuuKh GetByMaNckh(TransactionManager transactionManager, System.Int32 _maNckh, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;NghienCuuKh&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;NghienCuuKh&gt;"/></returns>
		public static TList<NghienCuuKh> Fill(IDataReader reader, TList<NghienCuuKh> rows, int start, int pageLength)
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
				
				PMS.Entities.NghienCuuKh c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("NghienCuuKh")
					.Append("|").Append((System.Int32)reader[((int)NghienCuuKhColumn.MaNckh - 1)]).ToString();
					c = EntityManager.LocateOrCreate<NghienCuuKh>(
					key.ToString(), // EntityTrackingKey
					"NghienCuuKh",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.NghienCuuKh();
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
					c.MaNckh = (System.Int32)reader[((int)NghienCuuKhColumn.MaNckh - 1)];
					c.MaQuanLy = (System.String)reader[((int)NghienCuuKhColumn.MaQuanLy - 1)];
					c.TenNckh = (reader.IsDBNull(((int)NghienCuuKhColumn.TenNckh - 1)))?null:(System.String)reader[((int)NghienCuuKhColumn.TenNckh - 1)];
					c.SoTiet = (reader.IsDBNull(((int)NghienCuuKhColumn.SoTiet - 1)))?null:(System.Int32?)reader[((int)NghienCuuKhColumn.SoTiet - 1)];
					c.ThuTu = (reader.IsDBNull(((int)NghienCuuKhColumn.ThuTu - 1)))?null:(System.Int32?)reader[((int)NghienCuuKhColumn.ThuTu - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NghienCuuKh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NghienCuuKh"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.NghienCuuKh entity)
		{
			if (!reader.Read()) return;
			
			entity.MaNckh = (System.Int32)reader[((int)NghienCuuKhColumn.MaNckh - 1)];
			entity.MaQuanLy = (System.String)reader[((int)NghienCuuKhColumn.MaQuanLy - 1)];
			entity.TenNckh = (reader.IsDBNull(((int)NghienCuuKhColumn.TenNckh - 1)))?null:(System.String)reader[((int)NghienCuuKhColumn.TenNckh - 1)];
			entity.SoTiet = (reader.IsDBNull(((int)NghienCuuKhColumn.SoTiet - 1)))?null:(System.Int32?)reader[((int)NghienCuuKhColumn.SoTiet - 1)];
			entity.ThuTu = (reader.IsDBNull(((int)NghienCuuKhColumn.ThuTu - 1)))?null:(System.Int32?)reader[((int)NghienCuuKhColumn.ThuTu - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NghienCuuKh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NghienCuuKh"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.NghienCuuKh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaNckh = (System.Int32)dataRow["MaNCKH"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenNckh = Convert.IsDBNull(dataRow["TenNCKH"]) ? null : (System.String)dataRow["TenNCKH"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Int32?)dataRow["SoTiet"];
			entity.ThuTu = Convert.IsDBNull(dataRow["ThuTu"]) ? null : (System.Int32?)dataRow["ThuTu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.NghienCuuKh"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.NghienCuuKh Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.NghienCuuKh entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaNckh methods when available
			
			#region MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh
			// RelationshipType.ManyToMany
			if (CanDeepLoad(entity, "List<GiangVien>|MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh", deepLoadType, innerList))
			{
				entity.MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh = DataRepository.GiangVienProvider.GetByMaNckhFromGiangVienNghienCuuKh(transactionManager, entity.MaNckh);			 
		
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh != null)
				{
					deepHandles.Add("MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh",
						new KeyValuePair<Delegate, object>((DeepLoadHandle< GiangVien >) DataRepository.GiangVienProvider.DeepLoad,
						new object[] { transactionManager, entity.MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh, deep, deepLoadType, childTypes, innerList }
					));
				}
			}
			#endregion
			
			
			
			#region GiangVienNghienCuuKhCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienNghienCuuKh>|GiangVienNghienCuuKhCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienNghienCuuKhCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienNghienCuuKhCollection = DataRepository.GiangVienNghienCuuKhProvider.GetByMaNckh(transactionManager, entity.MaNckh);

				if (deep && entity.GiangVienNghienCuuKhCollection.Count > 0)
				{
					deepHandles.Add("GiangVienNghienCuuKhCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienNghienCuuKh>) DataRepository.GiangVienNghienCuuKhProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienNghienCuuKhCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.NghienCuuKh object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.NghienCuuKh instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.NghienCuuKh Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.NghienCuuKh entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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

			#region MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh>
			if (CanDeepSave(entity.MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh, "List<GiangVien>|MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh", deepSaveType, innerList))
			{
				if (entity.MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh.Count > 0 || entity.MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh.DeletedItems.Count > 0)
				{
					DataRepository.GiangVienProvider.Save(transactionManager, entity.MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh); 
					deepHandles.Add("MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh",
						new KeyValuePair<Delegate, object>((DeepSaveHandle<GiangVien>) DataRepository.GiangVienProvider.DeepSave,
						new object[] { transactionManager, entity.MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh, deepSaveType, childTypes, innerList }
					));
				}
			}
			#endregion 
	
			#region List<GiangVienNghienCuuKh>
				if (CanDeepSave(entity.GiangVienNghienCuuKhCollection, "List<GiangVienNghienCuuKh>|GiangVienNghienCuuKhCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienNghienCuuKh child in entity.GiangVienNghienCuuKhCollection)
					{
						if(child.MaNckhSource != null)
						{
								child.MaNckh = child.MaNckhSource.MaNckh;
						}

						if(child.MaGiangVienSource != null)
						{
								child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}

					}

					if (entity.GiangVienNghienCuuKhCollection.Count > 0 || entity.GiangVienNghienCuuKhCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienNghienCuuKhProvider.Save(transactionManager, entity.GiangVienNghienCuuKhCollection);
						
						deepHandles.Add("GiangVienNghienCuuKhCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienNghienCuuKh >) DataRepository.GiangVienNghienCuuKhProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienNghienCuuKhCollection, deepSaveType, childTypes, innerList }
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
	
	#region NghienCuuKhChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.NghienCuuKh</c>
	///</summary>
	public enum NghienCuuKhChildEntityTypes
	{

		///<summary>
		/// Collection of <c>NghienCuuKh</c> as ManyToMany for GiangVienCollection_From_GiangVienNghienCuuKh
		///</summary>
		[ChildEntityType(typeof(TList<GiangVien>))]
		MaGiangVienGiangVienCollection_From_GiangVienNghienCuuKh,

		///<summary>
		/// Collection of <c>NghienCuuKh</c> as OneToMany for GiangVienNghienCuuKhCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienNghienCuuKh>))]
		GiangVienNghienCuuKhCollection,
	}
	
	#endregion NghienCuuKhChildEntityTypes
	
	#region NghienCuuKhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;NghienCuuKhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NghienCuuKh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NghienCuuKhFilterBuilder : SqlFilterBuilder<NghienCuuKhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhFilterBuilder class.
		/// </summary>
		public NghienCuuKhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NghienCuuKhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NghienCuuKhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NghienCuuKhFilterBuilder
	
	#region NghienCuuKhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;NghienCuuKhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NghienCuuKh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NghienCuuKhParameterBuilder : ParameterizedSqlFilterBuilder<NghienCuuKhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhParameterBuilder class.
		/// </summary>
		public NghienCuuKhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NghienCuuKhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NghienCuuKhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NghienCuuKhParameterBuilder
	
	#region NghienCuuKhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;NghienCuuKhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NghienCuuKh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class NghienCuuKhSortBuilder : SqlSortBuilder<NghienCuuKhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhSqlSortBuilder class.
		/// </summary>
		public NghienCuuKhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion NghienCuuKhSortBuilder
	
} // end namespace
