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
	/// This class is the base class for any <see cref="HocViProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HocViProviderBaseCore : EntityProviderBase<PMS.Entities.HocVi, PMS.Entities.HocViKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HocViKey key)
		{
			return Delete(transactionManager, key.MaHocVi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maHocVi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maHocVi)
		{
			return Delete(null, _maHocVi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maHocVi);		
		
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
		public override PMS.Entities.HocVi Get(TransactionManager transactionManager, PMS.Entities.HocViKey key, int start, int pageLength)
		{
			return GetByMaHocVi(transactionManager, key.MaHocVi, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_HocVi index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HocVi"/> class.</returns>
		public PMS.Entities.HocVi GetByMaQuanLy(System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HocVi index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HocVi"/> class.</returns>
		public PMS.Entities.HocVi GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HocVi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HocVi"/> class.</returns>
		public PMS.Entities.HocVi GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HocVi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HocVi"/> class.</returns>
		public PMS.Entities.HocVi GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HocVi index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HocVi"/> class.</returns>
		public PMS.Entities.HocVi GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HocVi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HocVi"/> class.</returns>
		public abstract PMS.Entities.HocVi GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HocVi index.
		/// </summary>
		/// <param name="_maHocVi"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HocVi"/> class.</returns>
		public PMS.Entities.HocVi GetByMaHocVi(System.Int32 _maHocVi)
		{
			int count = -1;
			return GetByMaHocVi(null,_maHocVi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HocVi index.
		/// </summary>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HocVi"/> class.</returns>
		public PMS.Entities.HocVi GetByMaHocVi(System.Int32 _maHocVi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocVi(null, _maHocVi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HocVi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HocVi"/> class.</returns>
		public PMS.Entities.HocVi GetByMaHocVi(TransactionManager transactionManager, System.Int32 _maHocVi)
		{
			int count = -1;
			return GetByMaHocVi(transactionManager, _maHocVi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HocVi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HocVi"/> class.</returns>
		public PMS.Entities.HocVi GetByMaHocVi(TransactionManager transactionManager, System.Int32 _maHocVi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocVi(transactionManager, _maHocVi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HocVi index.
		/// </summary>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HocVi"/> class.</returns>
		public PMS.Entities.HocVi GetByMaHocVi(System.Int32 _maHocVi, int start, int pageLength, out int count)
		{
			return GetByMaHocVi(null, _maHocVi, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HocVi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HocVi"/> class.</returns>
		public abstract PMS.Entities.HocVi GetByMaHocVi(TransactionManager transactionManager, System.Int32 _maHocVi, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HocVi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HocVi&gt;"/></returns>
		public static TList<HocVi> Fill(IDataReader reader, TList<HocVi> rows, int start, int pageLength)
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
				
				PMS.Entities.HocVi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HocVi")
					.Append("|").Append((System.Int32)reader[((int)HocViColumn.MaHocVi - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HocVi>(
					key.ToString(), // EntityTrackingKey
					"HocVi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HocVi();
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
					c.MaHocVi = (System.Int32)reader[(HocViColumn.MaHocVi.ToString())];
					c.MaQuanLy = (reader[HocViColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HocViColumn.MaQuanLy.ToString())];
					c.TenHocVi = (reader[HocViColumn.TenHocVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(HocViColumn.TenHocVi.ToString())];
					c.ThuTu = (reader[HocViColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HocViColumn.ThuTu.ToString())];
					c.Hrmid = (reader[HocViColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(HocViColumn.Hrmid.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HocVi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HocVi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HocVi entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHocVi = (System.Int32)reader[(HocViColumn.MaHocVi.ToString())];
			entity.MaQuanLy = (reader[HocViColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HocViColumn.MaQuanLy.ToString())];
			entity.TenHocVi = (reader[HocViColumn.TenHocVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(HocViColumn.TenHocVi.ToString())];
			entity.ThuTu = (reader[HocViColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HocViColumn.ThuTu.ToString())];
			entity.Hrmid = (reader[HocViColumn.Hrmid.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(HocViColumn.Hrmid.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HocVi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HocVi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HocVi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHocVi = (System.Int32)dataRow["MaHocVi"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.TenHocVi = Convert.IsDBNull(dataRow["TenHocVi"]) ? null : (System.String)dataRow["TenHocVi"];
			entity.ThuTu = Convert.IsDBNull(dataRow["ThuTu"]) ? null : (System.Int32?)dataRow["ThuTu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HocVi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HocVi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HocVi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaHocVi methods when available
			
			#region HeSoChucDanhTietNghiaVuCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<HeSoChucDanhTietNghiaVu>|HeSoChucDanhTietNghiaVuCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'HeSoChucDanhTietNghiaVuCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.HeSoChucDanhTietNghiaVuCollection = DataRepository.HeSoChucDanhTietNghiaVuProvider.GetByMaHocVi(transactionManager, entity.MaHocVi);

				if (deep && entity.HeSoChucDanhTietNghiaVuCollection.Count > 0)
				{
					deepHandles.Add("HeSoChucDanhTietNghiaVuCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<HeSoChucDanhTietNghiaVu>) DataRepository.HeSoChucDanhTietNghiaVuProvider.DeepLoad,
						new object[] { transactionManager, entity.HeSoChucDanhTietNghiaVuCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region DonGiaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<DonGia>|DonGiaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'DonGiaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.DonGiaCollection = DataRepository.DonGiaProvider.GetByMaHocVi(transactionManager, entity.MaHocVi);

				if (deep && entity.DonGiaCollection.Count > 0)
				{
					deepHandles.Add("DonGiaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<DonGia>) DataRepository.DonGiaProvider.DeepLoad,
						new object[] { transactionManager, entity.DonGiaCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.QuyDinhTienCanTrenCollection = DataRepository.QuyDinhTienCanTrenProvider.GetByMaHocVi(transactionManager, entity.MaHocVi);

				if (deep && entity.QuyDinhTienCanTrenCollection.Count > 0)
				{
					deepHandles.Add("QuyDinhTienCanTrenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<QuyDinhTienCanTren>) DataRepository.QuyDinhTienCanTrenProvider.DeepLoad,
						new object[] { transactionManager, entity.QuyDinhTienCanTrenCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GiangVienCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVien>|GiangVienCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienCollection = DataRepository.GiangVienProvider.GetByMaHocVi(transactionManager, entity.MaHocVi);

				if (deep && entity.GiangVienCollection.Count > 0)
				{
					deepHandles.Add("GiangVienCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVien>) DataRepository.GiangVienProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.HocVi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HocVi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HocVi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HocVi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<HeSoChucDanhTietNghiaVu>
				if (CanDeepSave(entity.HeSoChucDanhTietNghiaVuCollection, "List<HeSoChucDanhTietNghiaVu>|HeSoChucDanhTietNghiaVuCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(HeSoChucDanhTietNghiaVu child in entity.HeSoChucDanhTietNghiaVuCollection)
					{
						if(child.MaHocViSource != null)
						{
							child.MaHocVi = child.MaHocViSource.MaHocVi;
						}
						else
						{
							child.MaHocVi = entity.MaHocVi;
						}

					}

					if (entity.HeSoChucDanhTietNghiaVuCollection.Count > 0 || entity.HeSoChucDanhTietNghiaVuCollection.DeletedItems.Count > 0)
					{
						//DataRepository.HeSoChucDanhTietNghiaVuProvider.Save(transactionManager, entity.HeSoChucDanhTietNghiaVuCollection);
						
						deepHandles.Add("HeSoChucDanhTietNghiaVuCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< HeSoChucDanhTietNghiaVu >) DataRepository.HeSoChucDanhTietNghiaVuProvider.DeepSave,
							new object[] { transactionManager, entity.HeSoChucDanhTietNghiaVuCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<DonGia>
				if (CanDeepSave(entity.DonGiaCollection, "List<DonGia>|DonGiaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(DonGia child in entity.DonGiaCollection)
					{
						if(child.MaHocViSource != null)
						{
							child.MaHocVi = child.MaHocViSource.MaHocVi;
						}
						else
						{
							child.MaHocVi = entity.MaHocVi;
						}

					}

					if (entity.DonGiaCollection.Count > 0 || entity.DonGiaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.DonGiaProvider.Save(transactionManager, entity.DonGiaCollection);
						
						deepHandles.Add("DonGiaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< DonGia >) DataRepository.DonGiaProvider.DeepSave,
							new object[] { transactionManager, entity.DonGiaCollection, deepSaveType, childTypes, innerList }
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
						if(child.MaHocViSource != null)
						{
							child.MaHocVi = child.MaHocViSource.MaHocVi;
						}
						else
						{
							child.MaHocVi = entity.MaHocVi;
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
				
	
			#region List<GiangVien>
				if (CanDeepSave(entity.GiangVienCollection, "List<GiangVien>|GiangVienCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVien child in entity.GiangVienCollection)
					{
						if(child.MaHocViSource != null)
						{
							child.MaHocVi = child.MaHocViSource.MaHocVi;
						}
						else
						{
							child.MaHocVi = entity.MaHocVi;
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
	
	#region HocViChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HocVi</c>
	///</summary>
	public enum HocViChildEntityTypes
	{
		///<summary>
		/// Collection of <c>HocVi</c> as OneToMany for HeSoChucDanhTietNghiaVuCollection
		///</summary>
		[ChildEntityType(typeof(TList<HeSoChucDanhTietNghiaVu>))]
		HeSoChucDanhTietNghiaVuCollection,
		///<summary>
		/// Collection of <c>HocVi</c> as OneToMany for DonGiaCollection
		///</summary>
		[ChildEntityType(typeof(TList<DonGia>))]
		DonGiaCollection,
		///<summary>
		/// Collection of <c>HocVi</c> as OneToMany for QuyDinhTienCanTrenCollection
		///</summary>
		[ChildEntityType(typeof(TList<QuyDinhTienCanTren>))]
		QuyDinhTienCanTrenCollection,
		///<summary>
		/// Collection of <c>HocVi</c> as OneToMany for GiangVienCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVien>))]
		GiangVienCollection,
	}
	
	#endregion HocViChildEntityTypes
	
	#region HocViFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HocViColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HocViFilterBuilder : SqlFilterBuilder<HocViColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HocViFilterBuilder class.
		/// </summary>
		public HocViFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HocViFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HocViFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HocViFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HocViFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HocViFilterBuilder
	
	#region HocViParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HocViColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HocViParameterBuilder : ParameterizedSqlFilterBuilder<HocViColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HocViParameterBuilder class.
		/// </summary>
		public HocViParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HocViParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HocViParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HocViParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HocViParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HocViParameterBuilder
	
	#region HocViSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HocViColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HocVi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HocViSortBuilder : SqlSortBuilder<HocViColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HocViSqlSortBuilder class.
		/// </summary>
		public HocViSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HocViSortBuilder
	
} // end namespace
