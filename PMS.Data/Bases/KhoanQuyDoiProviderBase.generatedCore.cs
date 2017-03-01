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
	/// This class is the base class for any <see cref="KhoanQuyDoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KhoanQuyDoiProviderBaseCore : EntityProviderBase<PMS.Entities.KhoanQuyDoi, PMS.Entities.KhoanQuyDoiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KhoanQuyDoiKey key)
		{
			return Delete(transactionManager, key.MaKhoan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maKhoan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maKhoan)
		{
			return Delete(null, _maKhoan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maKhoan);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoanQuyDoi_QuyDoiGioChuan key.
		///		FK_KhoanQuyDoi_QuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="_maQuyDoi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoanQuyDoi objects.</returns>
		public TList<KhoanQuyDoi> GetByMaQuyDoi(System.Int32? _maQuyDoi)
		{
			int count = -1;
			return GetByMaQuyDoi(_maQuyDoi, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoanQuyDoi_QuyDoiGioChuan key.
		///		FK_KhoanQuyDoi_QuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyDoi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoanQuyDoi objects.</returns>
		/// <remarks></remarks>
		public TList<KhoanQuyDoi> GetByMaQuyDoi(TransactionManager transactionManager, System.Int32? _maQuyDoi)
		{
			int count = -1;
			return GetByMaQuyDoi(transactionManager, _maQuyDoi, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoanQuyDoi_QuyDoiGioChuan key.
		///		FK_KhoanQuyDoi_QuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoanQuyDoi objects.</returns>
		public TList<KhoanQuyDoi> GetByMaQuyDoi(TransactionManager transactionManager, System.Int32? _maQuyDoi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuyDoi(transactionManager, _maQuyDoi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoanQuyDoi_QuyDoiGioChuan key.
		///		fkKhoanQuyDoiQuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maQuyDoi"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoanQuyDoi objects.</returns>
		public TList<KhoanQuyDoi> GetByMaQuyDoi(System.Int32? _maQuyDoi, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaQuyDoi(null, _maQuyDoi, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoanQuyDoi_QuyDoiGioChuan key.
		///		fkKhoanQuyDoiQuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maQuyDoi"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoanQuyDoi objects.</returns>
		public TList<KhoanQuyDoi> GetByMaQuyDoi(System.Int32? _maQuyDoi, int start, int pageLength,out int count)
		{
			return GetByMaQuyDoi(null, _maQuyDoi, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoanQuyDoi_QuyDoiGioChuan key.
		///		FK_KhoanQuyDoi_QuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoanQuyDoi objects.</returns>
		public abstract TList<KhoanQuyDoi> GetByMaQuyDoi(TransactionManager transactionManager, System.Int32? _maQuyDoi, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.KhoanQuyDoi Get(TransactionManager transactionManager, PMS.Entities.KhoanQuyDoiKey key, int start, int pageLength)
		{
			return GetByMaKhoan(transactionManager, key.MaKhoan, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KhoanQuyDoi index.
		/// </summary>
		/// <param name="_maKhoan"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoanQuyDoi"/> class.</returns>
		public PMS.Entities.KhoanQuyDoi GetByMaKhoan(System.Int32 _maKhoan)
		{
			int count = -1;
			return GetByMaKhoan(null,_maKhoan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoanQuyDoi index.
		/// </summary>
		/// <param name="_maKhoan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoanQuyDoi"/> class.</returns>
		public PMS.Entities.KhoanQuyDoi GetByMaKhoan(System.Int32 _maKhoan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoan(null, _maKhoan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoanQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoan"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoanQuyDoi"/> class.</returns>
		public PMS.Entities.KhoanQuyDoi GetByMaKhoan(TransactionManager transactionManager, System.Int32 _maKhoan)
		{
			int count = -1;
			return GetByMaKhoan(transactionManager, _maKhoan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoanQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoanQuyDoi"/> class.</returns>
		public PMS.Entities.KhoanQuyDoi GetByMaKhoan(TransactionManager transactionManager, System.Int32 _maKhoan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoan(transactionManager, _maKhoan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoanQuyDoi index.
		/// </summary>
		/// <param name="_maKhoan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoanQuyDoi"/> class.</returns>
		public PMS.Entities.KhoanQuyDoi GetByMaKhoan(System.Int32 _maKhoan, int start, int pageLength, out int count)
		{
			return GetByMaKhoan(null, _maKhoan, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoanQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoanQuyDoi"/> class.</returns>
		public abstract PMS.Entities.KhoanQuyDoi GetByMaKhoan(TransactionManager transactionManager, System.Int32 _maKhoan, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KhoanQuyDoi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KhoanQuyDoi&gt;"/></returns>
		public static TList<KhoanQuyDoi> Fill(IDataReader reader, TList<KhoanQuyDoi> rows, int start, int pageLength)
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
				
				PMS.Entities.KhoanQuyDoi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KhoanQuyDoi")
					.Append("|").Append((System.Int32)reader[((int)KhoanQuyDoiColumn.MaKhoan - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KhoanQuyDoi>(
					key.ToString(), // EntityTrackingKey
					"KhoanQuyDoi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KhoanQuyDoi();
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
					c.MaKhoan = (System.Int32)reader[(KhoanQuyDoiColumn.MaKhoan.ToString())];
					c.MaQuyDoi = (reader[KhoanQuyDoiColumn.MaQuyDoi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoanQuyDoiColumn.MaQuyDoi.ToString())];
					c.TuKhoan = (reader[KhoanQuyDoiColumn.TuKhoan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoanQuyDoiColumn.TuKhoan.ToString())];
					c.DenKhoan = (reader[KhoanQuyDoiColumn.DenKhoan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoanQuyDoiColumn.DenKhoan.ToString())];
					c.HeSo = (reader[KhoanQuyDoiColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoanQuyDoiColumn.HeSo.ToString())];
					c.ThuTu = (reader[KhoanQuyDoiColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoanQuyDoiColumn.ThuTu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoanQuyDoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoanQuyDoi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KhoanQuyDoi entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKhoan = (System.Int32)reader[(KhoanQuyDoiColumn.MaKhoan.ToString())];
			entity.MaQuyDoi = (reader[KhoanQuyDoiColumn.MaQuyDoi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoanQuyDoiColumn.MaQuyDoi.ToString())];
			entity.TuKhoan = (reader[KhoanQuyDoiColumn.TuKhoan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoanQuyDoiColumn.TuKhoan.ToString())];
			entity.DenKhoan = (reader[KhoanQuyDoiColumn.DenKhoan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoanQuyDoiColumn.DenKhoan.ToString())];
			entity.HeSo = (reader[KhoanQuyDoiColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoanQuyDoiColumn.HeSo.ToString())];
			entity.ThuTu = (reader[KhoanQuyDoiColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoanQuyDoiColumn.ThuTu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoanQuyDoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoanQuyDoi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KhoanQuyDoi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoan = (System.Int32)dataRow["MaKhoan"];
			entity.MaQuyDoi = Convert.IsDBNull(dataRow["MaQuyDoi"]) ? null : (System.Int32?)dataRow["MaQuyDoi"];
			entity.TuKhoan = Convert.IsDBNull(dataRow["TuKhoan"]) ? null : (System.Int32?)dataRow["TuKhoan"];
			entity.DenKhoan = Convert.IsDBNull(dataRow["DenKhoan"]) ? null : (System.Int32?)dataRow["DenKhoan"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KhoanQuyDoi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KhoanQuyDoi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KhoanQuyDoi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaQuyDoiSource	
			if (CanDeepLoad(entity, "QuyDoiGioChuan|MaQuyDoiSource", deepLoadType, innerList) 
				&& entity.MaQuyDoiSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaQuyDoi ?? (int)0);
				QuyDoiGioChuan tmpEntity = EntityManager.LocateEntity<QuyDoiGioChuan>(EntityLocator.ConstructKeyFromPkItems(typeof(QuyDoiGioChuan), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaQuyDoiSource = tmpEntity;
				else
					entity.MaQuyDoiSource = DataRepository.QuyDoiGioChuanProvider.GetByMaQuyDoi(transactionManager, (entity.MaQuyDoi ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaQuyDoiSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaQuyDoiSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.QuyDoiGioChuanProvider.DeepLoad(transactionManager, entity.MaQuyDoiSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaQuyDoiSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.KhoanQuyDoi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KhoanQuyDoi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KhoanQuyDoi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KhoanQuyDoi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaQuyDoiSource
			if (CanDeepSave(entity, "QuyDoiGioChuan|MaQuyDoiSource", deepSaveType, innerList) 
				&& entity.MaQuyDoiSource != null)
			{
				DataRepository.QuyDoiGioChuanProvider.Save(transactionManager, entity.MaQuyDoiSource);
				entity.MaQuyDoi = entity.MaQuyDoiSource.MaQuyDoi;
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
	
	#region KhoanQuyDoiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KhoanQuyDoi</c>
	///</summary>
	public enum KhoanQuyDoiChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>QuyDoiGioChuan</c> at MaQuyDoiSource
		///</summary>
		[ChildEntityType(typeof(QuyDoiGioChuan))]
		QuyDoiGioChuan,
	}
	
	#endregion KhoanQuyDoiChildEntityTypes
	
	#region KhoanQuyDoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KhoanQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoanQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoanQuyDoiFilterBuilder : SqlFilterBuilder<KhoanQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoanQuyDoiFilterBuilder class.
		/// </summary>
		public KhoanQuyDoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoanQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoanQuyDoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoanQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoanQuyDoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoanQuyDoiFilterBuilder
	
	#region KhoanQuyDoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KhoanQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoanQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoanQuyDoiParameterBuilder : ParameterizedSqlFilterBuilder<KhoanQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoanQuyDoiParameterBuilder class.
		/// </summary>
		public KhoanQuyDoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoanQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoanQuyDoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoanQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoanQuyDoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoanQuyDoiParameterBuilder
	
	#region KhoanQuyDoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KhoanQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoanQuyDoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KhoanQuyDoiSortBuilder : SqlSortBuilder<KhoanQuyDoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoanQuyDoiSqlSortBuilder class.
		/// </summary>
		public KhoanQuyDoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KhoanQuyDoiSortBuilder
	
} // end namespace
