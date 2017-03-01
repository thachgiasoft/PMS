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
	/// This class is the base class for any <see cref="LoaiKhoiLuongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LoaiKhoiLuongProviderBaseCore : EntityProviderBase<PMS.Entities.LoaiKhoiLuong, PMS.Entities.LoaiKhoiLuongKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.LoaiKhoiLuongKey key)
		{
			return Delete(transactionManager, key.MaLoaiKhoiLuong);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLoaiKhoiLuong">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maLoaiKhoiLuong)
		{
			return Delete(null, _maLoaiKhoiLuong);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiKhoiLuong">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maLoaiKhoiLuong);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_LoaiKhoiLuong_NhomKhoiLuong key.
		///		FK_LoaiKhoiLuong_NhomKhoiLuong Description: 
		/// </summary>
		/// <param name="_maNhom"></param>
		/// <returns>Returns a typed collection of PMS.Entities.LoaiKhoiLuong objects.</returns>
		public TList<LoaiKhoiLuong> GetByMaNhom(System.Int32? _maNhom)
		{
			int count = -1;
			return GetByMaNhom(_maNhom, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_LoaiKhoiLuong_NhomKhoiLuong key.
		///		FK_LoaiKhoiLuong_NhomKhoiLuong Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <returns>Returns a typed collection of PMS.Entities.LoaiKhoiLuong objects.</returns>
		/// <remarks></remarks>
		public TList<LoaiKhoiLuong> GetByMaNhom(TransactionManager transactionManager, System.Int32? _maNhom)
		{
			int count = -1;
			return GetByMaNhom(transactionManager, _maNhom, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_LoaiKhoiLuong_NhomKhoiLuong key.
		///		FK_LoaiKhoiLuong_NhomKhoiLuong Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.LoaiKhoiLuong objects.</returns>
		public TList<LoaiKhoiLuong> GetByMaNhom(TransactionManager transactionManager, System.Int32? _maNhom, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhom(transactionManager, _maNhom, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_LoaiKhoiLuong_NhomKhoiLuong key.
		///		fkLoaiKhoiLuongNhomKhoiLuong Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhom"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.LoaiKhoiLuong objects.</returns>
		public TList<LoaiKhoiLuong> GetByMaNhom(System.Int32? _maNhom, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaNhom(null, _maNhom, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_LoaiKhoiLuong_NhomKhoiLuong key.
		///		fkLoaiKhoiLuongNhomKhoiLuong Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhom"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.LoaiKhoiLuong objects.</returns>
		public TList<LoaiKhoiLuong> GetByMaNhom(System.Int32? _maNhom, int start, int pageLength,out int count)
		{
			return GetByMaNhom(null, _maNhom, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_LoaiKhoiLuong_NhomKhoiLuong key.
		///		FK_LoaiKhoiLuong_NhomKhoiLuong Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.LoaiKhoiLuong objects.</returns>
		public abstract TList<LoaiKhoiLuong> GetByMaNhom(TransactionManager transactionManager, System.Int32? _maNhom, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.LoaiKhoiLuong Get(TransactionManager transactionManager, PMS.Entities.LoaiKhoiLuongKey key, int start, int pageLength)
		{
			return GetByMaLoaiKhoiLuong(transactionManager, key.MaLoaiKhoiLuong, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_LoaiKhoiLuong index.
		/// </summary>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiKhoiLuong"/> class.</returns>
		public PMS.Entities.LoaiKhoiLuong GetByMaLoaiKhoiLuong(System.String _maLoaiKhoiLuong)
		{
			int count = -1;
			return GetByMaLoaiKhoiLuong(null,_maLoaiKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiKhoiLuong index.
		/// </summary>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiKhoiLuong"/> class.</returns>
		public PMS.Entities.LoaiKhoiLuong GetByMaLoaiKhoiLuong(System.String _maLoaiKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiKhoiLuong(null, _maLoaiKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiKhoiLuong"/> class.</returns>
		public PMS.Entities.LoaiKhoiLuong GetByMaLoaiKhoiLuong(TransactionManager transactionManager, System.String _maLoaiKhoiLuong)
		{
			int count = -1;
			return GetByMaLoaiKhoiLuong(transactionManager, _maLoaiKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiKhoiLuong"/> class.</returns>
		public PMS.Entities.LoaiKhoiLuong GetByMaLoaiKhoiLuong(TransactionManager transactionManager, System.String _maLoaiKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiKhoiLuong(transactionManager, _maLoaiKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiKhoiLuong index.
		/// </summary>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiKhoiLuong"/> class.</returns>
		public PMS.Entities.LoaiKhoiLuong GetByMaLoaiKhoiLuong(System.String _maLoaiKhoiLuong, int start, int pageLength, out int count)
		{
			return GetByMaLoaiKhoiLuong(null, _maLoaiKhoiLuong, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LoaiKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LoaiKhoiLuong"/> class.</returns>
		public abstract PMS.Entities.LoaiKhoiLuong GetByMaLoaiKhoiLuong(TransactionManager transactionManager, System.String _maLoaiKhoiLuong, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LoaiKhoiLuong&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LoaiKhoiLuong&gt;"/></returns>
		public static TList<LoaiKhoiLuong> Fill(IDataReader reader, TList<LoaiKhoiLuong> rows, int start, int pageLength)
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
				
				PMS.Entities.LoaiKhoiLuong c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LoaiKhoiLuong")
					.Append("|").Append((System.String)reader[((int)LoaiKhoiLuongColumn.MaLoaiKhoiLuong - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LoaiKhoiLuong>(
					key.ToString(), // EntityTrackingKey
					"LoaiKhoiLuong",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.LoaiKhoiLuong();
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
					c.MaLoaiKhoiLuong = (System.String)reader[(LoaiKhoiLuongColumn.MaLoaiKhoiLuong.ToString())];
					c.OriginalMaLoaiKhoiLuong = c.MaLoaiKhoiLuong;
					c.MaNhom = (reader[LoaiKhoiLuongColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(LoaiKhoiLuongColumn.MaNhom.ToString())];
					c.TenLoaiKhoiLuong = (reader[LoaiKhoiLuongColumn.TenLoaiKhoiLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiKhoiLuongColumn.TenLoaiKhoiLuong.ToString())];
					c.NghiaVu = (reader[LoaiKhoiLuongColumn.NghiaVu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(LoaiKhoiLuongColumn.NghiaVu.ToString())];
					c.HeSo = (reader[LoaiKhoiLuongColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(LoaiKhoiLuongColumn.HeSo.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiKhoiLuong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiKhoiLuong"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.LoaiKhoiLuong entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLoaiKhoiLuong = (System.String)reader[(LoaiKhoiLuongColumn.MaLoaiKhoiLuong.ToString())];
			entity.OriginalMaLoaiKhoiLuong = (System.String)reader["MaLoaiKhoiLuong"];
			entity.MaNhom = (reader[LoaiKhoiLuongColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(LoaiKhoiLuongColumn.MaNhom.ToString())];
			entity.TenLoaiKhoiLuong = (reader[LoaiKhoiLuongColumn.TenLoaiKhoiLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(LoaiKhoiLuongColumn.TenLoaiKhoiLuong.ToString())];
			entity.NghiaVu = (reader[LoaiKhoiLuongColumn.NghiaVu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(LoaiKhoiLuongColumn.NghiaVu.ToString())];
			entity.HeSo = (reader[LoaiKhoiLuongColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(LoaiKhoiLuongColumn.HeSo.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LoaiKhoiLuong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LoaiKhoiLuong"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.LoaiKhoiLuong entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLoaiKhoiLuong = (System.String)dataRow["MaLoaiKhoiLuong"];
			entity.OriginalMaLoaiKhoiLuong = (System.String)dataRow["MaLoaiKhoiLuong"];
			entity.MaNhom = Convert.IsDBNull(dataRow["MaNhom"]) ? null : (System.Int32?)dataRow["MaNhom"];
			entity.TenLoaiKhoiLuong = Convert.IsDBNull(dataRow["TenLoaiKhoiLuong"]) ? null : (System.String)dataRow["TenLoaiKhoiLuong"];
			entity.NghiaVu = Convert.IsDBNull(dataRow["NghiaVu"]) ? null : (System.Boolean?)dataRow["NghiaVu"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
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
		/// <param name="entity">The <see cref="PMS.Entities.LoaiKhoiLuong"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.LoaiKhoiLuong Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.LoaiKhoiLuong entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaNhomSource	
			if (CanDeepLoad(entity, "NhomKhoiLuong|MaNhomSource", deepLoadType, innerList) 
				&& entity.MaNhomSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaNhom ?? (int)0);
				NhomKhoiLuong tmpEntity = EntityManager.LocateEntity<NhomKhoiLuong>(EntityLocator.ConstructKeyFromPkItems(typeof(NhomKhoiLuong), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaNhomSource = tmpEntity;
				else
					entity.MaNhomSource = DataRepository.NhomKhoiLuongProvider.GetByMaNhom(transactionManager, (entity.MaNhom ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaNhomSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaNhomSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.NhomKhoiLuongProvider.DeepLoad(transactionManager, entity.MaNhomSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaNhomSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaLoaiKhoiLuong methods when available
			
			#region QuyDoiGioChuanCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<QuyDoiGioChuan>|QuyDoiGioChuanCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'QuyDoiGioChuanCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.QuyDoiGioChuanCollection = DataRepository.QuyDoiGioChuanProvider.GetByMaLoaiKhoiLuong(transactionManager, entity.MaLoaiKhoiLuong);

				if (deep && entity.QuyDoiGioChuanCollection.Count > 0)
				{
					deepHandles.Add("QuyDoiGioChuanCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<QuyDoiGioChuan>) DataRepository.QuyDoiGioChuanProvider.DeepLoad,
						new object[] { transactionManager, entity.QuyDoiGioChuanCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.LoaiKhoiLuong object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.LoaiKhoiLuong instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.LoaiKhoiLuong Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.LoaiKhoiLuong entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaNhomSource
			if (CanDeepSave(entity, "NhomKhoiLuong|MaNhomSource", deepSaveType, innerList) 
				&& entity.MaNhomSource != null)
			{
				DataRepository.NhomKhoiLuongProvider.Save(transactionManager, entity.MaNhomSource);
				entity.MaNhom = entity.MaNhomSource.MaNhom;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<QuyDoiGioChuan>
				if (CanDeepSave(entity.QuyDoiGioChuanCollection, "List<QuyDoiGioChuan>|QuyDoiGioChuanCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(QuyDoiGioChuan child in entity.QuyDoiGioChuanCollection)
					{
						if(child.MaLoaiKhoiLuongSource != null)
						{
							child.MaLoaiKhoiLuong = child.MaLoaiKhoiLuongSource.MaLoaiKhoiLuong;
						}
						else
						{
							child.MaLoaiKhoiLuong = entity.MaLoaiKhoiLuong;
						}

					}

					if (entity.QuyDoiGioChuanCollection.Count > 0 || entity.QuyDoiGioChuanCollection.DeletedItems.Count > 0)
					{
						//DataRepository.QuyDoiGioChuanProvider.Save(transactionManager, entity.QuyDoiGioChuanCollection);
						
						deepHandles.Add("QuyDoiGioChuanCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< QuyDoiGioChuan >) DataRepository.QuyDoiGioChuanProvider.DeepSave,
							new object[] { transactionManager, entity.QuyDoiGioChuanCollection, deepSaveType, childTypes, innerList }
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
	
	#region LoaiKhoiLuongChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.LoaiKhoiLuong</c>
	///</summary>
	public enum LoaiKhoiLuongChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>NhomKhoiLuong</c> at MaNhomSource
		///</summary>
		[ChildEntityType(typeof(NhomKhoiLuong))]
		NhomKhoiLuong,
		///<summary>
		/// Collection of <c>LoaiKhoiLuong</c> as OneToMany for QuyDoiGioChuanCollection
		///</summary>
		[ChildEntityType(typeof(TList<QuyDoiGioChuan>))]
		QuyDoiGioChuanCollection,
	}
	
	#endregion LoaiKhoiLuongChildEntityTypes
	
	#region LoaiKhoiLuongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LoaiKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiKhoiLuongFilterBuilder : SqlFilterBuilder<LoaiKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiKhoiLuongFilterBuilder class.
		/// </summary>
		public LoaiKhoiLuongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiKhoiLuongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiKhoiLuongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiKhoiLuongFilterBuilder
	
	#region LoaiKhoiLuongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LoaiKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiKhoiLuongParameterBuilder : ParameterizedSqlFilterBuilder<LoaiKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiKhoiLuongParameterBuilder class.
		/// </summary>
		public LoaiKhoiLuongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoaiKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoaiKhoiLuongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoaiKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoaiKhoiLuongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoaiKhoiLuongParameterBuilder
	
	#region LoaiKhoiLuongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LoaiKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiKhoiLuong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LoaiKhoiLuongSortBuilder : SqlSortBuilder<LoaiKhoiLuongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiKhoiLuongSqlSortBuilder class.
		/// </summary>
		public LoaiKhoiLuongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LoaiKhoiLuongSortBuilder
	
} // end namespace
