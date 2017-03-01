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
	/// This class is the base class for any <see cref="ThuLaoThoaThuanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThuLaoThoaThuanProviderBaseCore : EntityProviderBase<PMS.Entities.ThuLaoThoaThuan, PMS.Entities.ThuLaoThoaThuanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThuLaoThoaThuanKey key)
		{
			return Delete(transactionManager, key.MaThuLao);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maThuLao">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maThuLao)
		{
			return Delete(null, _maThuLao);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maThuLao">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maThuLao);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThuLaoThoaThuan_GiangVien key.
		///		FK_ThuLaoThoaThuan_GiangVien Description: 
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.ThuLaoThoaThuan objects.</returns>
		public TList<ThuLaoThoaThuan> GetByMaGiangVien(System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(_maGiangVien, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThuLaoThoaThuan_GiangVien key.
		///		FK_ThuLaoThoaThuan_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of PMS.Entities.ThuLaoThoaThuan objects.</returns>
		/// <remarks></remarks>
		public TList<ThuLaoThoaThuan> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThuLaoThoaThuan_GiangVien key.
		///		FK_ThuLaoThoaThuan_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ThuLaoThoaThuan objects.</returns>
		public TList<ThuLaoThoaThuan> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThuLaoThoaThuan_GiangVien key.
		///		fkThuLaoThoaThuanGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ThuLaoThoaThuan objects.</returns>
		public TList<ThuLaoThoaThuan> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThuLaoThoaThuan_GiangVien key.
		///		fkThuLaoThoaThuanGiangVien Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ThuLaoThoaThuan objects.</returns>
		public TList<ThuLaoThoaThuan> GetByMaGiangVien(System.Int32? _maGiangVien, int start, int pageLength,out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ThuLaoThoaThuan_GiangVien key.
		///		FK_ThuLaoThoaThuan_GiangVien Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.ThuLaoThoaThuan objects.</returns>
		public abstract TList<ThuLaoThoaThuan> GetByMaGiangVien(TransactionManager transactionManager, System.Int32? _maGiangVien, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.ThuLaoThoaThuan Get(TransactionManager transactionManager, PMS.Entities.ThuLaoThoaThuanKey key, int start, int pageLength)
		{
			return GetByMaThuLao(transactionManager, key.MaThuLao, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThuLaoThoaThuan index.
		/// </summary>
		/// <param name="_maThuLao"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoThoaThuan"/> class.</returns>
		public PMS.Entities.ThuLaoThoaThuan GetByMaThuLao(System.Int32 _maThuLao)
		{
			int count = -1;
			return GetByMaThuLao(null,_maThuLao, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoThoaThuan index.
		/// </summary>
		/// <param name="_maThuLao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoThoaThuan"/> class.</returns>
		public PMS.Entities.ThuLaoThoaThuan GetByMaThuLao(System.Int32 _maThuLao, int start, int pageLength)
		{
			int count = -1;
			return GetByMaThuLao(null, _maThuLao, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoThoaThuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maThuLao"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoThoaThuan"/> class.</returns>
		public PMS.Entities.ThuLaoThoaThuan GetByMaThuLao(TransactionManager transactionManager, System.Int32 _maThuLao)
		{
			int count = -1;
			return GetByMaThuLao(transactionManager, _maThuLao, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoThoaThuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maThuLao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoThoaThuan"/> class.</returns>
		public PMS.Entities.ThuLaoThoaThuan GetByMaThuLao(TransactionManager transactionManager, System.Int32 _maThuLao, int start, int pageLength)
		{
			int count = -1;
			return GetByMaThuLao(transactionManager, _maThuLao, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoThoaThuan index.
		/// </summary>
		/// <param name="_maThuLao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoThoaThuan"/> class.</returns>
		public PMS.Entities.ThuLaoThoaThuan GetByMaThuLao(System.Int32 _maThuLao, int start, int pageLength, out int count)
		{
			return GetByMaThuLao(null, _maThuLao, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoThoaThuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maThuLao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoThoaThuan"/> class.</returns>
		public abstract PMS.Entities.ThuLaoThoaThuan GetByMaThuLao(TransactionManager transactionManager, System.Int32 _maThuLao, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThuLaoThoaThuan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThuLaoThoaThuan&gt;"/></returns>
		public static TList<ThuLaoThoaThuan> Fill(IDataReader reader, TList<ThuLaoThoaThuan> rows, int start, int pageLength)
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
				
				PMS.Entities.ThuLaoThoaThuan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThuLaoThoaThuan")
					.Append("|").Append((System.Int32)reader[((int)ThuLaoThoaThuanColumn.MaThuLao - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThuLaoThoaThuan>(
					key.ToString(), // EntityTrackingKey
					"ThuLaoThoaThuan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThuLaoThoaThuan();
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
					c.MaThuLao = (System.Int32)reader[(ThuLaoThoaThuanColumn.MaThuLao.ToString())];
					c.MaGiangVien = (reader[ThuLaoThoaThuanColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoThoaThuanColumn.MaGiangVien.ToString())];
					c.MaHeDaoTao = (reader[ThuLaoThoaThuanColumn.MaHeDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoThoaThuanColumn.MaHeDaoTao.ToString())];
					c.MaBacDaoTao = (reader[ThuLaoThoaThuanColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoThoaThuanColumn.MaBacDaoTao.ToString())];
					c.DonGia = (reader[ThuLaoThoaThuanColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoThoaThuanColumn.DonGia.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoThoaThuan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoThoaThuan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThuLaoThoaThuan entity)
		{
			if (!reader.Read()) return;
			
			entity.MaThuLao = (System.Int32)reader[(ThuLaoThoaThuanColumn.MaThuLao.ToString())];
			entity.MaGiangVien = (reader[ThuLaoThoaThuanColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoThoaThuanColumn.MaGiangVien.ToString())];
			entity.MaHeDaoTao = (reader[ThuLaoThoaThuanColumn.MaHeDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoThoaThuanColumn.MaHeDaoTao.ToString())];
			entity.MaBacDaoTao = (reader[ThuLaoThoaThuanColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoThoaThuanColumn.MaBacDaoTao.ToString())];
			entity.DonGia = (reader[ThuLaoThoaThuanColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoThoaThuanColumn.DonGia.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoThoaThuan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoThoaThuan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThuLaoThoaThuan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaThuLao = (System.Int32)dataRow["MaThuLao"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaHeDaoTao = Convert.IsDBNull(dataRow["MaHeDaoTao"]) ? null : (System.String)dataRow["MaHeDaoTao"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoThoaThuan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoThoaThuan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThuLaoThoaThuan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaGiangVienSource	
			if (CanDeepLoad(entity, "GiangVien|MaGiangVienSource", deepLoadType, innerList) 
				&& entity.MaGiangVienSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaGiangVien ?? (int)0);
				GiangVien tmpEntity = EntityManager.LocateEntity<GiangVien>(EntityLocator.ConstructKeyFromPkItems(typeof(GiangVien), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaGiangVienSource = tmpEntity;
				else
					entity.MaGiangVienSource = DataRepository.GiangVienProvider.GetByMaGiangVien(transactionManager, (entity.MaGiangVien ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaGiangVienSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaGiangVienSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GiangVienProvider.DeepLoad(transactionManager, entity.MaGiangVienSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaGiangVienSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.ThuLaoThoaThuan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThuLaoThoaThuan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoThoaThuan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThuLaoThoaThuan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaGiangVienSource
			if (CanDeepSave(entity, "GiangVien|MaGiangVienSource", deepSaveType, innerList) 
				&& entity.MaGiangVienSource != null)
			{
				DataRepository.GiangVienProvider.Save(transactionManager, entity.MaGiangVienSource);
				entity.MaGiangVien = entity.MaGiangVienSource.MaGiangVien;
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
	
	#region ThuLaoThoaThuanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThuLaoThoaThuan</c>
	///</summary>
	public enum ThuLaoThoaThuanChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GiangVien</c> at MaGiangVienSource
		///</summary>
		[ChildEntityType(typeof(GiangVien))]
		GiangVien,
	}
	
	#endregion ThuLaoThoaThuanChildEntityTypes
	
	#region ThuLaoThoaThuanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThuLaoThoaThuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoThoaThuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoThoaThuanFilterBuilder : SqlFilterBuilder<ThuLaoThoaThuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoThoaThuanFilterBuilder class.
		/// </summary>
		public ThuLaoThoaThuanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoThoaThuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoThoaThuanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoThoaThuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoThoaThuanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoThoaThuanFilterBuilder
	
	#region ThuLaoThoaThuanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThuLaoThoaThuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoThoaThuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoThoaThuanParameterBuilder : ParameterizedSqlFilterBuilder<ThuLaoThoaThuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoThoaThuanParameterBuilder class.
		/// </summary>
		public ThuLaoThoaThuanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoThoaThuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoThoaThuanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoThoaThuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoThoaThuanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoThoaThuanParameterBuilder
	
	#region ThuLaoThoaThuanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThuLaoThoaThuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoThoaThuan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThuLaoThoaThuanSortBuilder : SqlSortBuilder<ThuLaoThoaThuanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoThoaThuanSqlSortBuilder class.
		/// </summary>
		public ThuLaoThoaThuanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThuLaoThoaThuanSortBuilder
	
} // end namespace
