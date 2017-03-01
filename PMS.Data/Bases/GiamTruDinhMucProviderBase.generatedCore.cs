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
	/// This class is the base class for any <see cref="GiamTruDinhMucProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiamTruDinhMucProviderBaseCore : EntityProviderBase<PMS.Entities.GiamTruDinhMuc, PMS.Entities.GiamTruDinhMucKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiamTruDinhMucKey key)
		{
			return Delete(transactionManager, key.MaQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maQuanLy)
		{
			return Delete(null, _maQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maQuanLy);		
		
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
		public override PMS.Entities.GiamTruDinhMuc Get(TransactionManager transactionManager, PMS.Entities.GiamTruDinhMucKey key, int start, int pageLength)
		{
			return GetByMaQuanLy(transactionManager, key.MaQuanLy, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiamTruDinhMuc index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiamTruDinhMuc"/> class.</returns>
		public PMS.Entities.GiamTruDinhMuc GetByMaQuanLy(System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiamTruDinhMuc index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiamTruDinhMuc"/> class.</returns>
		public PMS.Entities.GiamTruDinhMuc GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiamTruDinhMuc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiamTruDinhMuc"/> class.</returns>
		public PMS.Entities.GiamTruDinhMuc GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiamTruDinhMuc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiamTruDinhMuc"/> class.</returns>
		public PMS.Entities.GiamTruDinhMuc GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiamTruDinhMuc index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiamTruDinhMuc"/> class.</returns>
		public PMS.Entities.GiamTruDinhMuc GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiamTruDinhMuc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiamTruDinhMuc"/> class.</returns>
		public abstract PMS.Entities.GiamTruDinhMuc GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiamTruDinhMuc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiamTruDinhMuc&gt;"/></returns>
		public static TList<GiamTruDinhMuc> Fill(IDataReader reader, TList<GiamTruDinhMuc> rows, int start, int pageLength)
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
				
				PMS.Entities.GiamTruDinhMuc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiamTruDinhMuc")
					.Append("|").Append((System.Int32)reader[((int)GiamTruDinhMucColumn.MaQuanLy - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiamTruDinhMuc>(
					key.ToString(), // EntityTrackingKey
					"GiamTruDinhMuc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiamTruDinhMuc();
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
					c.MaQuanLy = (System.Int32)reader[(GiamTruDinhMucColumn.MaQuanLy.ToString())];
					c.NoiDungGiamTru = (reader[GiamTruDinhMucColumn.NoiDungGiamTru.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruDinhMucColumn.NoiDungGiamTru.ToString())];
					c.PhanTramGiamTru = (reader[GiamTruDinhMucColumn.PhanTramGiamTru.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiamTruDinhMucColumn.PhanTramGiamTru.ToString())];
					c.GhiChu = (reader[GiamTruDinhMucColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruDinhMucColumn.GhiChu.ToString())];
					c.MucGiam = (reader[GiamTruDinhMucColumn.MucGiam.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiamTruDinhMucColumn.MucGiam.ToString())];
					c.DonVi = (reader[GiamTruDinhMucColumn.DonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruDinhMucColumn.DonVi.ToString())];
					c.NgayCapNhat = (reader[GiamTruDinhMucColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruDinhMucColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[GiamTruDinhMucColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruDinhMucColumn.NguoiCapNhat.ToString())];
					c.MucGiamNckh = (reader[GiamTruDinhMucColumn.MucGiamNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiamTruDinhMucColumn.MucGiamNckh.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiamTruDinhMuc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiamTruDinhMuc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiamTruDinhMuc entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuanLy = (System.Int32)reader[(GiamTruDinhMucColumn.MaQuanLy.ToString())];
			entity.NoiDungGiamTru = (reader[GiamTruDinhMucColumn.NoiDungGiamTru.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruDinhMucColumn.NoiDungGiamTru.ToString())];
			entity.PhanTramGiamTru = (reader[GiamTruDinhMucColumn.PhanTramGiamTru.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiamTruDinhMucColumn.PhanTramGiamTru.ToString())];
			entity.GhiChu = (reader[GiamTruDinhMucColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruDinhMucColumn.GhiChu.ToString())];
			entity.MucGiam = (reader[GiamTruDinhMucColumn.MucGiam.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiamTruDinhMucColumn.MucGiam.ToString())];
			entity.DonVi = (reader[GiamTruDinhMucColumn.DonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruDinhMucColumn.DonVi.ToString())];
			entity.NgayCapNhat = (reader[GiamTruDinhMucColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruDinhMucColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[GiamTruDinhMucColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruDinhMucColumn.NguoiCapNhat.ToString())];
			entity.MucGiamNckh = (reader[GiamTruDinhMucColumn.MucGiamNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiamTruDinhMucColumn.MucGiamNckh.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiamTruDinhMuc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiamTruDinhMuc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiamTruDinhMuc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (System.Int32)dataRow["MaQuanLy"];
			entity.NoiDungGiamTru = Convert.IsDBNull(dataRow["NoiDungGiamTru"]) ? null : (System.String)dataRow["NoiDungGiamTru"];
			entity.PhanTramGiamTru = Convert.IsDBNull(dataRow["PhanTramGiamTru"]) ? null : (System.Decimal?)dataRow["PhanTramGiamTru"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.MucGiam = Convert.IsDBNull(dataRow["MucGiam"]) ? null : (System.Decimal?)dataRow["MucGiam"];
			entity.DonVi = Convert.IsDBNull(dataRow["DonVi"]) ? null : (System.String)dataRow["DonVi"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.MucGiamNckh = Convert.IsDBNull(dataRow["MucGiamNckh"]) ? null : (System.Decimal?)dataRow["MucGiamNckh"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiamTruDinhMuc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiamTruDinhMuc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiamTruDinhMuc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaQuanLy methods when available
			
			#region GiangVienGiamTruDinhMucCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienGiamTruDinhMuc>|GiangVienGiamTruDinhMucCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienGiamTruDinhMucCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienGiamTruDinhMucCollection = DataRepository.GiangVienGiamTruDinhMucProvider.GetByMaGiamTru(transactionManager, entity.MaQuanLy);

				if (deep && entity.GiangVienGiamTruDinhMucCollection.Count > 0)
				{
					deepHandles.Add("GiangVienGiamTruDinhMucCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienGiamTruDinhMuc>) DataRepository.GiangVienGiamTruDinhMucProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienGiamTruDinhMucCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TietNghiaVuCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TietNghiaVu>|TietNghiaVuCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TietNghiaVuCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TietNghiaVuCollection = DataRepository.TietNghiaVuProvider.GetByMaGiamTruKhac(transactionManager, entity.MaQuanLy);

				if (deep && entity.TietNghiaVuCollection.Count > 0)
				{
					deepHandles.Add("TietNghiaVuCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TietNghiaVu>) DataRepository.TietNghiaVuProvider.DeepLoad,
						new object[] { transactionManager, entity.TietNghiaVuCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.GiamTruDinhMuc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiamTruDinhMuc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiamTruDinhMuc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiamTruDinhMuc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<GiangVienGiamTruDinhMuc>
				if (CanDeepSave(entity.GiangVienGiamTruDinhMucCollection, "List<GiangVienGiamTruDinhMuc>|GiangVienGiamTruDinhMucCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienGiamTruDinhMuc child in entity.GiangVienGiamTruDinhMucCollection)
					{
						if(child.MaGiamTruSource != null)
						{
							child.MaGiamTru = child.MaGiamTruSource.MaQuanLy;
						}
						else
						{
							child.MaGiamTru = entity.MaQuanLy;
						}

					}

					if (entity.GiangVienGiamTruDinhMucCollection.Count > 0 || entity.GiangVienGiamTruDinhMucCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienGiamTruDinhMucProvider.Save(transactionManager, entity.GiangVienGiamTruDinhMucCollection);
						
						deepHandles.Add("GiangVienGiamTruDinhMucCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienGiamTruDinhMuc >) DataRepository.GiangVienGiamTruDinhMucProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienGiamTruDinhMucCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TietNghiaVu>
				if (CanDeepSave(entity.TietNghiaVuCollection, "List<TietNghiaVu>|TietNghiaVuCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TietNghiaVu child in entity.TietNghiaVuCollection)
					{
						if(child.MaGiamTruKhacSource != null)
						{
							child.MaGiamTruKhac = child.MaGiamTruKhacSource.MaQuanLy;
						}
						else
						{
							child.MaGiamTruKhac = entity.MaQuanLy;
						}

					}

					if (entity.TietNghiaVuCollection.Count > 0 || entity.TietNghiaVuCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TietNghiaVuProvider.Save(transactionManager, entity.TietNghiaVuCollection);
						
						deepHandles.Add("TietNghiaVuCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TietNghiaVu >) DataRepository.TietNghiaVuProvider.DeepSave,
							new object[] { transactionManager, entity.TietNghiaVuCollection, deepSaveType, childTypes, innerList }
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
	
	#region GiamTruDinhMucChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiamTruDinhMuc</c>
	///</summary>
	public enum GiamTruDinhMucChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GiamTruDinhMuc</c> as OneToMany for GiangVienGiamTruDinhMucCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienGiamTruDinhMuc>))]
		GiangVienGiamTruDinhMucCollection,
		///<summary>
		/// Collection of <c>GiamTruDinhMuc</c> as OneToMany for TietNghiaVuCollection
		///</summary>
		[ChildEntityType(typeof(TList<TietNghiaVu>))]
		TietNghiaVuCollection,
	}
	
	#endregion GiamTruDinhMucChildEntityTypes
	
	#region GiamTruDinhMucFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiamTruDinhMucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiamTruDinhMuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiamTruDinhMucFilterBuilder : SqlFilterBuilder<GiamTruDinhMucColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiamTruDinhMucFilterBuilder class.
		/// </summary>
		public GiamTruDinhMucFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiamTruDinhMucFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiamTruDinhMucFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiamTruDinhMucFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiamTruDinhMucFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiamTruDinhMucFilterBuilder
	
	#region GiamTruDinhMucParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiamTruDinhMucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiamTruDinhMuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiamTruDinhMucParameterBuilder : ParameterizedSqlFilterBuilder<GiamTruDinhMucColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiamTruDinhMucParameterBuilder class.
		/// </summary>
		public GiamTruDinhMucParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiamTruDinhMucParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiamTruDinhMucParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiamTruDinhMucParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiamTruDinhMucParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiamTruDinhMucParameterBuilder
	
	#region GiamTruDinhMucSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiamTruDinhMucColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiamTruDinhMuc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiamTruDinhMucSortBuilder : SqlSortBuilder<GiamTruDinhMucColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiamTruDinhMucSqlSortBuilder class.
		/// </summary>
		public GiamTruDinhMucSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiamTruDinhMucSortBuilder
	
} // end namespace
