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
	/// This class is the base class for any <see cref="ChiTietKhoiLuongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ChiTietKhoiLuongProviderBaseCore : EntityProviderBase<PMS.Entities.ChiTietKhoiLuong, PMS.Entities.ChiTietKhoiLuongKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ChiTietKhoiLuongKey key)
		{
			return Delete(transactionManager, key.MaChiTiet);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maChiTiet">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maChiTiet)
		{
			return Delete(null, _maChiTiet);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChiTiet">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maChiTiet);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ChiTietKhoiLuong_KhoiLuongKhac key.
		///		FK_ChiTietKhoiLuong_KhoiLuongKhac Description: 
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <returns>Returns a typed collection of PMS.Entities.ChiTietKhoiLuong objects.</returns>
		public TList<ChiTietKhoiLuong> GetByMaKhoiLuong(System.Int32? _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(_maKhoiLuong, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ChiTietKhoiLuong_KhoiLuongKhac key.
		///		FK_ChiTietKhoiLuong_KhoiLuongKhac Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <returns>Returns a typed collection of PMS.Entities.ChiTietKhoiLuong objects.</returns>
		/// <remarks></remarks>
		public TList<ChiTietKhoiLuong> GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32? _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ChiTietKhoiLuong_KhoiLuongKhac key.
		///		FK_ChiTietKhoiLuong_KhoiLuongKhac Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ChiTietKhoiLuong objects.</returns>
		public TList<ChiTietKhoiLuong> GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32? _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ChiTietKhoiLuong_KhoiLuongKhac key.
		///		fkChiTietKhoiLuongKhoiLuongKhac Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maKhoiLuong"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ChiTietKhoiLuong objects.</returns>
		public TList<ChiTietKhoiLuong> GetByMaKhoiLuong(System.Int32? _maKhoiLuong, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ChiTietKhoiLuong_KhoiLuongKhac key.
		///		fkChiTietKhoiLuongKhoiLuongKhac Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ChiTietKhoiLuong objects.</returns>
		public TList<ChiTietKhoiLuong> GetByMaKhoiLuong(System.Int32? _maKhoiLuong, int start, int pageLength,out int count)
		{
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ChiTietKhoiLuong_KhoiLuongKhac key.
		///		FK_ChiTietKhoiLuong_KhoiLuongKhac Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.ChiTietKhoiLuong objects.</returns>
		public abstract TList<ChiTietKhoiLuong> GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32? _maKhoiLuong, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.ChiTietKhoiLuong Get(TransactionManager transactionManager, PMS.Entities.ChiTietKhoiLuongKey key, int start, int pageLength)
		{
			return GetByMaChiTiet(transactionManager, key.MaChiTiet, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ChiTietKhoiLuong index.
		/// </summary>
		/// <param name="_maChiTiet"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChiTietKhoiLuong"/> class.</returns>
		public PMS.Entities.ChiTietKhoiLuong GetByMaChiTiet(System.Int32 _maChiTiet)
		{
			int count = -1;
			return GetByMaChiTiet(null,_maChiTiet, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChiTietKhoiLuong index.
		/// </summary>
		/// <param name="_maChiTiet"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChiTietKhoiLuong"/> class.</returns>
		public PMS.Entities.ChiTietKhoiLuong GetByMaChiTiet(System.Int32 _maChiTiet, int start, int pageLength)
		{
			int count = -1;
			return GetByMaChiTiet(null, _maChiTiet, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChiTietKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChiTiet"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChiTietKhoiLuong"/> class.</returns>
		public PMS.Entities.ChiTietKhoiLuong GetByMaChiTiet(TransactionManager transactionManager, System.Int32 _maChiTiet)
		{
			int count = -1;
			return GetByMaChiTiet(transactionManager, _maChiTiet, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChiTietKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChiTiet"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChiTietKhoiLuong"/> class.</returns>
		public PMS.Entities.ChiTietKhoiLuong GetByMaChiTiet(TransactionManager transactionManager, System.Int32 _maChiTiet, int start, int pageLength)
		{
			int count = -1;
			return GetByMaChiTiet(transactionManager, _maChiTiet, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChiTietKhoiLuong index.
		/// </summary>
		/// <param name="_maChiTiet"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChiTietKhoiLuong"/> class.</returns>
		public PMS.Entities.ChiTietKhoiLuong GetByMaChiTiet(System.Int32 _maChiTiet, int start, int pageLength, out int count)
		{
			return GetByMaChiTiet(null, _maChiTiet, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChiTietKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChiTiet"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChiTietKhoiLuong"/> class.</returns>
		public abstract PMS.Entities.ChiTietKhoiLuong GetByMaChiTiet(TransactionManager transactionManager, System.Int32 _maChiTiet, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ChiTietKhoiLuong&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ChiTietKhoiLuong&gt;"/></returns>
		public static TList<ChiTietKhoiLuong> Fill(IDataReader reader, TList<ChiTietKhoiLuong> rows, int start, int pageLength)
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
				
				PMS.Entities.ChiTietKhoiLuong c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ChiTietKhoiLuong")
					.Append("|").Append((System.Int32)reader[((int)ChiTietKhoiLuongColumn.MaChiTiet - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ChiTietKhoiLuong>(
					key.ToString(), // EntityTrackingKey
					"ChiTietKhoiLuong",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ChiTietKhoiLuong();
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
					c.MaChiTiet = (System.Int32)reader[(ChiTietKhoiLuongColumn.MaChiTiet.ToString())];
					c.MaKhoiLuong = (reader[ChiTietKhoiLuongColumn.MaKhoiLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChiTietKhoiLuongColumn.MaKhoiLuong.ToString())];
					c.MaSinhVien = (reader[ChiTietKhoiLuongColumn.MaSinhVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTietKhoiLuongColumn.MaSinhVien.ToString())];
					c.NgayTao = (reader[ChiTietKhoiLuongColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ChiTietKhoiLuongColumn.NgayTao.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChiTietKhoiLuong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChiTietKhoiLuong"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ChiTietKhoiLuong entity)
		{
			if (!reader.Read()) return;
			
			entity.MaChiTiet = (System.Int32)reader[(ChiTietKhoiLuongColumn.MaChiTiet.ToString())];
			entity.MaKhoiLuong = (reader[ChiTietKhoiLuongColumn.MaKhoiLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChiTietKhoiLuongColumn.MaKhoiLuong.ToString())];
			entity.MaSinhVien = (reader[ChiTietKhoiLuongColumn.MaSinhVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChiTietKhoiLuongColumn.MaSinhVien.ToString())];
			entity.NgayTao = (reader[ChiTietKhoiLuongColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ChiTietKhoiLuongColumn.NgayTao.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChiTietKhoiLuong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChiTietKhoiLuong"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ChiTietKhoiLuong entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaChiTiet = (System.Int32)dataRow["MaChiTiet"];
			entity.MaKhoiLuong = Convert.IsDBNull(dataRow["MaKhoiLuong"]) ? null : (System.Int32?)dataRow["MaKhoiLuong"];
			entity.MaSinhVien = Convert.IsDBNull(dataRow["MaSinhVien"]) ? null : (System.String)dataRow["MaSinhVien"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ChiTietKhoiLuong"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ChiTietKhoiLuong Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ChiTietKhoiLuong entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaKhoiLuongSource	
			if (CanDeepLoad(entity, "KhoiLuongKhac|MaKhoiLuongSource", deepLoadType, innerList) 
				&& entity.MaKhoiLuongSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaKhoiLuong ?? (int)0);
				KhoiLuongKhac tmpEntity = EntityManager.LocateEntity<KhoiLuongKhac>(EntityLocator.ConstructKeyFromPkItems(typeof(KhoiLuongKhac), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaKhoiLuongSource = tmpEntity;
				else
					entity.MaKhoiLuongSource = DataRepository.KhoiLuongKhacProvider.GetByMaKhoiLuong(transactionManager, (entity.MaKhoiLuong ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaKhoiLuongSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaKhoiLuongSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.KhoiLuongKhacProvider.DeepLoad(transactionManager, entity.MaKhoiLuongSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaKhoiLuongSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.ChiTietKhoiLuong object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ChiTietKhoiLuong instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ChiTietKhoiLuong Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ChiTietKhoiLuong entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaKhoiLuongSource
			if (CanDeepSave(entity, "KhoiLuongKhac|MaKhoiLuongSource", deepSaveType, innerList) 
				&& entity.MaKhoiLuongSource != null)
			{
				DataRepository.KhoiLuongKhacProvider.Save(transactionManager, entity.MaKhoiLuongSource);
				entity.MaKhoiLuong = entity.MaKhoiLuongSource.MaKhoiLuong;
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
	
	#region ChiTietKhoiLuongChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ChiTietKhoiLuong</c>
	///</summary>
	public enum ChiTietKhoiLuongChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>KhoiLuongKhac</c> at MaKhoiLuongSource
		///</summary>
		[ChildEntityType(typeof(KhoiLuongKhac))]
		KhoiLuongKhac,
	}
	
	#endregion ChiTietKhoiLuongChildEntityTypes
	
	#region ChiTietKhoiLuongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ChiTietKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChiTietKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChiTietKhoiLuongFilterBuilder : SqlFilterBuilder<ChiTietKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChiTietKhoiLuongFilterBuilder class.
		/// </summary>
		public ChiTietKhoiLuongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChiTietKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChiTietKhoiLuongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChiTietKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChiTietKhoiLuongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChiTietKhoiLuongFilterBuilder
	
	#region ChiTietKhoiLuongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ChiTietKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChiTietKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChiTietKhoiLuongParameterBuilder : ParameterizedSqlFilterBuilder<ChiTietKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChiTietKhoiLuongParameterBuilder class.
		/// </summary>
		public ChiTietKhoiLuongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChiTietKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChiTietKhoiLuongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChiTietKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChiTietKhoiLuongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChiTietKhoiLuongParameterBuilder
	
	#region ChiTietKhoiLuongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ChiTietKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChiTietKhoiLuong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ChiTietKhoiLuongSortBuilder : SqlSortBuilder<ChiTietKhoiLuongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChiTietKhoiLuongSqlSortBuilder class.
		/// </summary>
		public ChiTietKhoiLuongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ChiTietKhoiLuongSortBuilder
	
} // end namespace
