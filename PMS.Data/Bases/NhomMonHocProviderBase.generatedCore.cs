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
	/// This class is the base class for any <see cref="NhomMonHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class NhomMonHocProviderBaseCore : EntityProviderBase<PMS.Entities.NhomMonHoc, PMS.Entities.NhomMonHocKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.NhomMonHocKey key)
		{
			return Delete(transactionManager, key.MaNhomMon);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maNhomMon">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maNhomMon)
		{
			return Delete(null, _maNhomMon);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maNhomMon);		
		
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
		public override PMS.Entities.NhomMonHoc Get(TransactionManager transactionManager, PMS.Entities.NhomMonHocKey key, int start, int pageLength)
		{
			return GetByMaNhomMon(transactionManager, key.MaNhomMon, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_NhomMonHoc index.
		/// </summary>
		/// <param name="_maNhomMon"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomMonHoc"/> class.</returns>
		public PMS.Entities.NhomMonHoc GetByMaNhomMon(System.Int32 _maNhomMon)
		{
			int count = -1;
			return GetByMaNhomMon(null,_maNhomMon, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomMonHoc index.
		/// </summary>
		/// <param name="_maNhomMon"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomMonHoc"/> class.</returns>
		public PMS.Entities.NhomMonHoc GetByMaNhomMon(System.Int32 _maNhomMon, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomMon(null, _maNhomMon, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomMonHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomMonHoc"/> class.</returns>
		public PMS.Entities.NhomMonHoc GetByMaNhomMon(TransactionManager transactionManager, System.Int32 _maNhomMon)
		{
			int count = -1;
			return GetByMaNhomMon(transactionManager, _maNhomMon, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomMonHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomMonHoc"/> class.</returns>
		public PMS.Entities.NhomMonHoc GetByMaNhomMon(TransactionManager transactionManager, System.Int32 _maNhomMon, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomMon(transactionManager, _maNhomMon, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomMonHoc index.
		/// </summary>
		/// <param name="_maNhomMon"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomMonHoc"/> class.</returns>
		public PMS.Entities.NhomMonHoc GetByMaNhomMon(System.Int32 _maNhomMon, int start, int pageLength, out int count)
		{
			return GetByMaNhomMon(null, _maNhomMon, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomMonHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMon"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomMonHoc"/> class.</returns>
		public abstract PMS.Entities.NhomMonHoc GetByMaNhomMon(TransactionManager transactionManager, System.Int32 _maNhomMon, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_NhomMonHoc_GetHeSoNhomMonThucTap 
		
		/// <summary>
		///	This method wrap the 'cust_NhomMonHoc_GetHeSoNhomMonThucTap' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoNhomMonThucTap()
		{
			return GetHeSoNhomMonThucTap(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_NhomMonHoc_GetHeSoNhomMonThucTap' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoNhomMonThucTap(int start, int pageLength)
		{
			return GetHeSoNhomMonThucTap(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_NhomMonHoc_GetHeSoNhomMonThucTap' stored procedure. 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetHeSoNhomMonThucTap(TransactionManager transactionManager)
		{
			return GetHeSoNhomMonThucTap(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_NhomMonHoc_GetHeSoNhomMonThucTap' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetHeSoNhomMonThucTap(TransactionManager transactionManager, int start, int pageLength );
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;NhomMonHoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;NhomMonHoc&gt;"/></returns>
		public static TList<NhomMonHoc> Fill(IDataReader reader, TList<NhomMonHoc> rows, int start, int pageLength)
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
				
				PMS.Entities.NhomMonHoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("NhomMonHoc")
					.Append("|").Append((System.Int32)reader[((int)NhomMonHocColumn.MaNhomMon - 1)]).ToString();
					c = EntityManager.LocateOrCreate<NhomMonHoc>(
					key.ToString(), // EntityTrackingKey
					"NhomMonHoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.NhomMonHoc();
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
					c.MaNhomMon = (System.Int32)reader[(NhomMonHocColumn.MaNhomMon.ToString())];
					c.MaQuanLy = (System.String)reader[(NhomMonHocColumn.MaQuanLy.ToString())];
					c.TenNhomMon = (reader[NhomMonHocColumn.TenNhomMon.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomMonHocColumn.TenNhomMon.ToString())];
					c.MucThanhToan = (reader[NhomMonHocColumn.MucThanhToan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(NhomMonHocColumn.MucThanhToan.ToString())];
					c.SiSoNhomThucHanh = (reader[NhomMonHocColumn.SiSoNhomThucHanh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(NhomMonHocColumn.SiSoNhomThucHanh.ToString())];
					c.HeSoQuyDoiThSangLt = (reader[NhomMonHocColumn.HeSoQuyDoiThSangLt.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(NhomMonHocColumn.HeSoQuyDoiThSangLt.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomMonHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomMonHoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.NhomMonHoc entity)
		{
			if (!reader.Read()) return;
			
			entity.MaNhomMon = (System.Int32)reader[(NhomMonHocColumn.MaNhomMon.ToString())];
			entity.MaQuanLy = (System.String)reader[(NhomMonHocColumn.MaQuanLy.ToString())];
			entity.TenNhomMon = (reader[NhomMonHocColumn.TenNhomMon.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomMonHocColumn.TenNhomMon.ToString())];
			entity.MucThanhToan = (reader[NhomMonHocColumn.MucThanhToan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(NhomMonHocColumn.MucThanhToan.ToString())];
			entity.SiSoNhomThucHanh = (reader[NhomMonHocColumn.SiSoNhomThucHanh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(NhomMonHocColumn.SiSoNhomThucHanh.ToString())];
			entity.HeSoQuyDoiThSangLt = (reader[NhomMonHocColumn.HeSoQuyDoiThSangLt.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(NhomMonHocColumn.HeSoQuyDoiThSangLt.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomMonHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomMonHoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.NhomMonHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaNhomMon = (System.Int32)dataRow["MaNhomMon"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenNhomMon = Convert.IsDBNull(dataRow["TenNhomMon"]) ? null : (System.String)dataRow["TenNhomMon"];
			entity.MucThanhToan = Convert.IsDBNull(dataRow["MucThanhToan"]) ? null : (System.Decimal?)dataRow["MucThanhToan"];
			entity.SiSoNhomThucHanh = Convert.IsDBNull(dataRow["SiSoNhomThucHanh"]) ? null : (System.Int32?)dataRow["SiSoNhomThucHanh"];
			entity.HeSoQuyDoiThSangLt = Convert.IsDBNull(dataRow["HeSoQuyDoiThSangLt"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoiThSangLt"];
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
		/// <param name="entity">The <see cref="PMS.Entities.NhomMonHoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.NhomMonHoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.NhomMonHoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaNhomMon methods when available
			
			#region PhanNhomMonHocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PhanNhomMonHoc>|PhanNhomMonHocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PhanNhomMonHocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PhanNhomMonHocCollection = DataRepository.PhanNhomMonHocProvider.GetByMaNhomMonHoc(transactionManager, entity.MaNhomMon);

				if (deep && entity.PhanNhomMonHocCollection.Count > 0)
				{
					deepHandles.Add("PhanNhomMonHocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PhanNhomMonHoc>) DataRepository.PhanNhomMonHocProvider.DeepLoad,
						new object[] { transactionManager, entity.PhanNhomMonHocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region KcqPhanNhomMonHocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<KcqPhanNhomMonHoc>|KcqPhanNhomMonHocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'KcqPhanNhomMonHocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.KcqPhanNhomMonHocCollection = DataRepository.KcqPhanNhomMonHocProvider.GetByMaNhomMonHoc(transactionManager, entity.MaNhomMon);

				if (deep && entity.KcqPhanNhomMonHocCollection.Count > 0)
				{
					deepHandles.Add("KcqPhanNhomMonHocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<KcqPhanNhomMonHoc>) DataRepository.KcqPhanNhomMonHocProvider.DeepLoad,
						new object[] { transactionManager, entity.KcqPhanNhomMonHocCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.DonGiaCollection = DataRepository.DonGiaProvider.GetByMaNhomMon(transactionManager, entity.MaNhomMon);

				if (deep && entity.DonGiaCollection.Count > 0)
				{
					deepHandles.Add("DonGiaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<DonGia>) DataRepository.DonGiaProvider.DeepLoad,
						new object[] { transactionManager, entity.DonGiaCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SdhPhanNhomMonHocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SdhPhanNhomMonHoc>|SdhPhanNhomMonHocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SdhPhanNhomMonHocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SdhPhanNhomMonHocCollection = DataRepository.SdhPhanNhomMonHocProvider.GetByMaNhomMonHoc(transactionManager, entity.MaNhomMon);

				if (deep && entity.SdhPhanNhomMonHocCollection.Count > 0)
				{
					deepHandles.Add("SdhPhanNhomMonHocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SdhPhanNhomMonHoc>) DataRepository.SdhPhanNhomMonHocProvider.DeepLoad,
						new object[] { transactionManager, entity.SdhPhanNhomMonHocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.NhomMonHoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.NhomMonHoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.NhomMonHoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.NhomMonHoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<PhanNhomMonHoc>
				if (CanDeepSave(entity.PhanNhomMonHocCollection, "List<PhanNhomMonHoc>|PhanNhomMonHocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PhanNhomMonHoc child in entity.PhanNhomMonHocCollection)
					{
						if(child.MaNhomMonHocSource != null)
						{
							child.MaNhomMonHoc = child.MaNhomMonHocSource.MaNhomMon;
						}
						else
						{
							child.MaNhomMonHoc = entity.MaNhomMon;
						}

					}

					if (entity.PhanNhomMonHocCollection.Count > 0 || entity.PhanNhomMonHocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PhanNhomMonHocProvider.Save(transactionManager, entity.PhanNhomMonHocCollection);
						
						deepHandles.Add("PhanNhomMonHocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PhanNhomMonHoc >) DataRepository.PhanNhomMonHocProvider.DeepSave,
							new object[] { transactionManager, entity.PhanNhomMonHocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<KcqPhanNhomMonHoc>
				if (CanDeepSave(entity.KcqPhanNhomMonHocCollection, "List<KcqPhanNhomMonHoc>|KcqPhanNhomMonHocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(KcqPhanNhomMonHoc child in entity.KcqPhanNhomMonHocCollection)
					{
						if(child.MaNhomMonHocSource != null)
						{
							child.MaNhomMonHoc = child.MaNhomMonHocSource.MaNhomMon;
						}
						else
						{
							child.MaNhomMonHoc = entity.MaNhomMon;
						}

					}

					if (entity.KcqPhanNhomMonHocCollection.Count > 0 || entity.KcqPhanNhomMonHocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.KcqPhanNhomMonHocProvider.Save(transactionManager, entity.KcqPhanNhomMonHocCollection);
						
						deepHandles.Add("KcqPhanNhomMonHocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< KcqPhanNhomMonHoc >) DataRepository.KcqPhanNhomMonHocProvider.DeepSave,
							new object[] { transactionManager, entity.KcqPhanNhomMonHocCollection, deepSaveType, childTypes, innerList }
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
						if(child.MaNhomMonSource != null)
						{
							child.MaNhomMon = child.MaNhomMonSource.MaNhomMon;
						}
						else
						{
							child.MaNhomMon = entity.MaNhomMon;
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
				
	
			#region List<SdhPhanNhomMonHoc>
				if (CanDeepSave(entity.SdhPhanNhomMonHocCollection, "List<SdhPhanNhomMonHoc>|SdhPhanNhomMonHocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SdhPhanNhomMonHoc child in entity.SdhPhanNhomMonHocCollection)
					{
						if(child.MaNhomMonHocSource != null)
						{
							child.MaNhomMonHoc = child.MaNhomMonHocSource.MaNhomMon;
						}
						else
						{
							child.MaNhomMonHoc = entity.MaNhomMon;
						}

					}

					if (entity.SdhPhanNhomMonHocCollection.Count > 0 || entity.SdhPhanNhomMonHocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SdhPhanNhomMonHocProvider.Save(transactionManager, entity.SdhPhanNhomMonHocCollection);
						
						deepHandles.Add("SdhPhanNhomMonHocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SdhPhanNhomMonHoc >) DataRepository.SdhPhanNhomMonHocProvider.DeepSave,
							new object[] { transactionManager, entity.SdhPhanNhomMonHocCollection, deepSaveType, childTypes, innerList }
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
	
	#region NhomMonHocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.NhomMonHoc</c>
	///</summary>
	public enum NhomMonHocChildEntityTypes
	{
		///<summary>
		/// Collection of <c>NhomMonHoc</c> as OneToMany for PhanNhomMonHocCollection
		///</summary>
		[ChildEntityType(typeof(TList<PhanNhomMonHoc>))]
		PhanNhomMonHocCollection,
		///<summary>
		/// Collection of <c>NhomMonHoc</c> as OneToMany for KcqPhanNhomMonHocCollection
		///</summary>
		[ChildEntityType(typeof(TList<KcqPhanNhomMonHoc>))]
		KcqPhanNhomMonHocCollection,
		///<summary>
		/// Collection of <c>NhomMonHoc</c> as OneToMany for DonGiaCollection
		///</summary>
		[ChildEntityType(typeof(TList<DonGia>))]
		DonGiaCollection,
		///<summary>
		/// Collection of <c>NhomMonHoc</c> as OneToMany for SdhPhanNhomMonHocCollection
		///</summary>
		[ChildEntityType(typeof(TList<SdhPhanNhomMonHoc>))]
		SdhPhanNhomMonHocCollection,
	}
	
	#endregion NhomMonHocChildEntityTypes
	
	#region NhomMonHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;NhomMonHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomMonHocFilterBuilder : SqlFilterBuilder<NhomMonHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomMonHocFilterBuilder class.
		/// </summary>
		public NhomMonHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomMonHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomMonHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomMonHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomMonHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomMonHocFilterBuilder
	
	#region NhomMonHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;NhomMonHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomMonHocParameterBuilder : ParameterizedSqlFilterBuilder<NhomMonHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomMonHocParameterBuilder class.
		/// </summary>
		public NhomMonHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomMonHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomMonHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomMonHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomMonHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomMonHocParameterBuilder
	
	#region NhomMonHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;NhomMonHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomMonHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class NhomMonHocSortBuilder : SqlSortBuilder<NhomMonHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomMonHocSqlSortBuilder class.
		/// </summary>
		public NhomMonHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion NhomMonHocSortBuilder
	
} // end namespace
