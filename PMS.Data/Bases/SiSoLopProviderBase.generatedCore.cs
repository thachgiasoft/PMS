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
	/// This class is the base class for any <see cref="SiSoLopProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SiSoLopProviderBaseCore : EntityProviderBase<PMS.Entities.SiSoLop, PMS.Entities.SiSoLopKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.SiSoLopKey key)
		{
			return Delete(transactionManager, key.MaSiSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maSiSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maSiSo)
		{
			return Delete(null, _maSiSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maSiSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maSiSo);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SiSoLop_QuyDoiGioChuan key.
		///		FK_SiSoLop_QuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="_maQuyDoi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.SiSoLop objects.</returns>
		public TList<SiSoLop> GetByMaQuyDoi(System.Int32? _maQuyDoi)
		{
			int count = -1;
			return GetByMaQuyDoi(_maQuyDoi, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SiSoLop_QuyDoiGioChuan key.
		///		FK_SiSoLop_QuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyDoi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.SiSoLop objects.</returns>
		/// <remarks></remarks>
		public TList<SiSoLop> GetByMaQuyDoi(TransactionManager transactionManager, System.Int32? _maQuyDoi)
		{
			int count = -1;
			return GetByMaQuyDoi(transactionManager, _maQuyDoi, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SiSoLop_QuyDoiGioChuan key.
		///		FK_SiSoLop_QuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.SiSoLop objects.</returns>
		public TList<SiSoLop> GetByMaQuyDoi(TransactionManager transactionManager, System.Int32? _maQuyDoi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuyDoi(transactionManager, _maQuyDoi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SiSoLop_QuyDoiGioChuan key.
		///		fkSiSoLopQuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maQuyDoi"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.SiSoLop objects.</returns>
		public TList<SiSoLop> GetByMaQuyDoi(System.Int32? _maQuyDoi, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaQuyDoi(null, _maQuyDoi, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SiSoLop_QuyDoiGioChuan key.
		///		fkSiSoLopQuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maQuyDoi"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.SiSoLop objects.</returns>
		public TList<SiSoLop> GetByMaQuyDoi(System.Int32? _maQuyDoi, int start, int pageLength,out int count)
		{
			return GetByMaQuyDoi(null, _maQuyDoi, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SiSoLop_QuyDoiGioChuan key.
		///		FK_SiSoLop_QuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.SiSoLop objects.</returns>
		public abstract TList<SiSoLop> GetByMaQuyDoi(TransactionManager transactionManager, System.Int32? _maQuyDoi, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.SiSoLop Get(TransactionManager transactionManager, PMS.Entities.SiSoLopKey key, int start, int pageLength)
		{
			return GetByMaSiSo(transactionManager, key.MaSiSo, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SiSoLop index.
		/// </summary>
		/// <param name="_maSiSo"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SiSoLop"/> class.</returns>
		public PMS.Entities.SiSoLop GetByMaSiSo(System.Int32 _maSiSo)
		{
			int count = -1;
			return GetByMaSiSo(null,_maSiSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SiSoLop index.
		/// </summary>
		/// <param name="_maSiSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SiSoLop"/> class.</returns>
		public PMS.Entities.SiSoLop GetByMaSiSo(System.Int32 _maSiSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaSiSo(null, _maSiSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SiSoLop index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maSiSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SiSoLop"/> class.</returns>
		public PMS.Entities.SiSoLop GetByMaSiSo(TransactionManager transactionManager, System.Int32 _maSiSo)
		{
			int count = -1;
			return GetByMaSiSo(transactionManager, _maSiSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SiSoLop index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maSiSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SiSoLop"/> class.</returns>
		public PMS.Entities.SiSoLop GetByMaSiSo(TransactionManager transactionManager, System.Int32 _maSiSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaSiSo(transactionManager, _maSiSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SiSoLop index.
		/// </summary>
		/// <param name="_maSiSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SiSoLop"/> class.</returns>
		public PMS.Entities.SiSoLop GetByMaSiSo(System.Int32 _maSiSo, int start, int pageLength, out int count)
		{
			return GetByMaSiSo(null, _maSiSo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SiSoLop index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maSiSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SiSoLop"/> class.</returns>
		public abstract PMS.Entities.SiSoLop GetByMaSiSo(TransactionManager transactionManager, System.Int32 _maSiSo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SiSoLop&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SiSoLop&gt;"/></returns>
		public static TList<SiSoLop> Fill(IDataReader reader, TList<SiSoLop> rows, int start, int pageLength)
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
				
				PMS.Entities.SiSoLop c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SiSoLop")
					.Append("|").Append((System.Int32)reader[((int)SiSoLopColumn.MaSiSo - 1)]).ToString();
					c = EntityManager.LocateOrCreate<SiSoLop>(
					key.ToString(), // EntityTrackingKey
					"SiSoLop",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.SiSoLop();
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
					c.MaSiSo = (System.Int32)reader[((int)SiSoLopColumn.MaSiSo - 1)];
					c.OriginalMaSiSo = c.MaSiSo;
					c.MaQuyDoi = (reader.IsDBNull(((int)SiSoLopColumn.MaQuyDoi - 1)))?null:(System.Int32?)reader[((int)SiSoLopColumn.MaQuyDoi - 1)];
					c.TuSo = (reader.IsDBNull(((int)SiSoLopColumn.TuSo - 1)))?null:(System.Int32?)reader[((int)SiSoLopColumn.TuSo - 1)];
					c.DenSo = (reader.IsDBNull(((int)SiSoLopColumn.DenSo - 1)))?null:(System.Int32?)reader[((int)SiSoLopColumn.DenSo - 1)];
					c.SoTiet = (reader.IsDBNull(((int)SiSoLopColumn.SoTiet - 1)))?null:(System.Decimal?)reader[((int)SiSoLopColumn.SoTiet - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SiSoLop"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SiSoLop"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.SiSoLop entity)
		{
			if (!reader.Read()) return;
			
			entity.MaSiSo = (System.Int32)reader[((int)SiSoLopColumn.MaSiSo - 1)];
			entity.OriginalMaSiSo = (System.Int32)reader["MaSiSo"];
			entity.MaQuyDoi = (reader.IsDBNull(((int)SiSoLopColumn.MaQuyDoi - 1)))?null:(System.Int32?)reader[((int)SiSoLopColumn.MaQuyDoi - 1)];
			entity.TuSo = (reader.IsDBNull(((int)SiSoLopColumn.TuSo - 1)))?null:(System.Int32?)reader[((int)SiSoLopColumn.TuSo - 1)];
			entity.DenSo = (reader.IsDBNull(((int)SiSoLopColumn.DenSo - 1)))?null:(System.Int32?)reader[((int)SiSoLopColumn.DenSo - 1)];
			entity.SoTiet = (reader.IsDBNull(((int)SiSoLopColumn.SoTiet - 1)))?null:(System.Decimal?)reader[((int)SiSoLopColumn.SoTiet - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SiSoLop"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SiSoLop"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.SiSoLop entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaSiSo = (System.Int32)dataRow["MaSiSo"];
			entity.OriginalMaSiSo = (System.Int32)dataRow["MaSiSo"];
			entity.MaQuyDoi = Convert.IsDBNull(dataRow["MaQuyDoi"]) ? null : (System.Int32?)dataRow["MaQuyDoi"];
			entity.TuSo = Convert.IsDBNull(dataRow["TuSo"]) ? null : (System.Int32?)dataRow["TuSo"];
			entity.DenSo = Convert.IsDBNull(dataRow["DenSo"]) ? null : (System.Int32?)dataRow["DenSo"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
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
		/// <param name="entity">The <see cref="PMS.Entities.SiSoLop"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.SiSoLop Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.SiSoLop entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.SiSoLop object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.SiSoLop instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.SiSoLop Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.SiSoLop entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region SiSoLopChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.SiSoLop</c>
	///</summary>
	public enum SiSoLopChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>QuyDoiGioChuan</c> at MaQuyDoiSource
		///</summary>
		[ChildEntityType(typeof(QuyDoiGioChuan))]
		QuyDoiGioChuan,
		}
	
	#endregion SiSoLopChildEntityTypes
	
	#region SiSoLopFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SiSoLopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SiSoLop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SiSoLopFilterBuilder : SqlFilterBuilder<SiSoLopColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SiSoLopFilterBuilder class.
		/// </summary>
		public SiSoLopFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SiSoLopFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SiSoLopFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SiSoLopFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SiSoLopFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SiSoLopFilterBuilder
	
	#region SiSoLopParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SiSoLopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SiSoLop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SiSoLopParameterBuilder : ParameterizedSqlFilterBuilder<SiSoLopColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SiSoLopParameterBuilder class.
		/// </summary>
		public SiSoLopParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SiSoLopParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SiSoLopParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SiSoLopParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SiSoLopParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SiSoLopParameterBuilder
	
	#region SiSoLopSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SiSoLopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SiSoLop"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SiSoLopSortBuilder : SqlSortBuilder<SiSoLopColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SiSoLopSqlSortBuilder class.
		/// </summary>
		public SiSoLopSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SiSoLopSortBuilder
	
} // end namespace
