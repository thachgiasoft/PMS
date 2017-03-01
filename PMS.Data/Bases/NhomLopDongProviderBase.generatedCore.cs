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
	/// This class is the base class for any <see cref="NhomLopDongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class NhomLopDongProviderBaseCore : EntityProviderBase<PMS.Entities.NhomLopDong, PMS.Entities.NhomLopDongKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.NhomLopDongKey key)
		{
			return Delete(transactionManager, key.MaNhomLop);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maNhomLop">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maNhomLop)
		{
			return Delete(null, _maNhomLop);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomLop">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maNhomLop);		
		
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
		public override PMS.Entities.NhomLopDong Get(TransactionManager transactionManager, PMS.Entities.NhomLopDongKey key, int start, int pageLength)
		{
			return GetByMaNhomLop(transactionManager, key.MaNhomLop, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_NhomLopDong index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomLopDong"/> class.</returns>
		public PMS.Entities.NhomLopDong GetByMaQuanLy(System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_NhomLopDong index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomLopDong"/> class.</returns>
		public PMS.Entities.NhomLopDong GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_NhomLopDong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomLopDong"/> class.</returns>
		public PMS.Entities.NhomLopDong GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_NhomLopDong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomLopDong"/> class.</returns>
		public PMS.Entities.NhomLopDong GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_NhomLopDong index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomLopDong"/> class.</returns>
		public PMS.Entities.NhomLopDong GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_NhomLopDong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomLopDong"/> class.</returns>
		public abstract PMS.Entities.NhomLopDong GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_NhomLopDong index.
		/// </summary>
		/// <param name="_maNhomLop"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomLopDong"/> class.</returns>
		public PMS.Entities.NhomLopDong GetByMaNhomLop(System.Int32 _maNhomLop)
		{
			int count = -1;
			return GetByMaNhomLop(null,_maNhomLop, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomLopDong index.
		/// </summary>
		/// <param name="_maNhomLop"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomLopDong"/> class.</returns>
		public PMS.Entities.NhomLopDong GetByMaNhomLop(System.Int32 _maNhomLop, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomLop(null, _maNhomLop, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomLopDong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomLop"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomLopDong"/> class.</returns>
		public PMS.Entities.NhomLopDong GetByMaNhomLop(TransactionManager transactionManager, System.Int32 _maNhomLop)
		{
			int count = -1;
			return GetByMaNhomLop(transactionManager, _maNhomLop, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomLopDong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomLop"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomLopDong"/> class.</returns>
		public PMS.Entities.NhomLopDong GetByMaNhomLop(TransactionManager transactionManager, System.Int32 _maNhomLop, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomLop(transactionManager, _maNhomLop, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomLopDong index.
		/// </summary>
		/// <param name="_maNhomLop"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomLopDong"/> class.</returns>
		public PMS.Entities.NhomLopDong GetByMaNhomLop(System.Int32 _maNhomLop, int start, int pageLength, out int count)
		{
			return GetByMaNhomLop(null, _maNhomLop, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_NhomLopDong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomLop"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomLopDong"/> class.</returns>
		public abstract PMS.Entities.NhomLopDong GetByMaNhomLop(TransactionManager transactionManager, System.Int32 _maNhomLop, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;NhomLopDong&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;NhomLopDong&gt;"/></returns>
		public static TList<NhomLopDong> Fill(IDataReader reader, TList<NhomLopDong> rows, int start, int pageLength)
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
				
				PMS.Entities.NhomLopDong c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("NhomLopDong")
					.Append("|").Append((System.Int32)reader[((int)NhomLopDongColumn.MaNhomLop - 1)]).ToString();
					c = EntityManager.LocateOrCreate<NhomLopDong>(
					key.ToString(), // EntityTrackingKey
					"NhomLopDong",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.NhomLopDong();
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
					c.MaNhomLop = (System.Int32)reader[((int)NhomLopDongColumn.MaNhomLop - 1)];
					c.OriginalMaNhomLop = c.MaNhomLop;
					c.MaQuanLy = (System.String)reader[((int)NhomLopDongColumn.MaQuanLy - 1)];
					c.TenNhomLop = (reader.IsDBNull(((int)NhomLopDongColumn.TenNhomLop - 1)))?null:(System.String)reader[((int)NhomLopDongColumn.TenNhomLop - 1)];
					c.ThuTu = (reader.IsDBNull(((int)NhomLopDongColumn.ThuTu - 1)))?null:(System.Int32?)reader[((int)NhomLopDongColumn.ThuTu - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomLopDong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomLopDong"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.NhomLopDong entity)
		{
			if (!reader.Read()) return;
			
			entity.MaNhomLop = (System.Int32)reader[((int)NhomLopDongColumn.MaNhomLop - 1)];
			entity.OriginalMaNhomLop = (System.Int32)reader["MaNhomLop"];
			entity.MaQuanLy = (System.String)reader[((int)NhomLopDongColumn.MaQuanLy - 1)];
			entity.TenNhomLop = (reader.IsDBNull(((int)NhomLopDongColumn.TenNhomLop - 1)))?null:(System.String)reader[((int)NhomLopDongColumn.TenNhomLop - 1)];
			entity.ThuTu = (reader.IsDBNull(((int)NhomLopDongColumn.ThuTu - 1)))?null:(System.Int32?)reader[((int)NhomLopDongColumn.ThuTu - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomLopDong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomLopDong"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.NhomLopDong entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaNhomLop = (System.Int32)dataRow["MaNhomLop"];
			entity.OriginalMaNhomLop = (System.Int32)dataRow["MaNhomLop"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenNhomLop = Convert.IsDBNull(dataRow["TenNhomLop"]) ? null : (System.String)dataRow["TenNhomLop"];
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
		/// <param name="entity">The <see cref="PMS.Entities.NhomLopDong"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.NhomLopDong Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.NhomLopDong entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaNhomLop methods when available
			
			#region HeSoLopDongCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<HeSoLopDong>|HeSoLopDongCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'HeSoLopDongCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.HeSoLopDongCollection = DataRepository.HeSoLopDongProvider.GetByMaNhomLop(transactionManager, entity.MaNhomLop);

				if (deep && entity.HeSoLopDongCollection.Count > 0)
				{
					deepHandles.Add("HeSoLopDongCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<HeSoLopDong>) DataRepository.HeSoLopDongProvider.DeepLoad,
						new object[] { transactionManager, entity.HeSoLopDongCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.NhomLopDong object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.NhomLopDong instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.NhomLopDong Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.NhomLopDong entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<HeSoLopDong>
				if (CanDeepSave(entity.HeSoLopDongCollection, "List<HeSoLopDong>|HeSoLopDongCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(HeSoLopDong child in entity.HeSoLopDongCollection)
					{
						if(child.MaNhomLopSource != null)
						{
							child.MaNhomLop = child.MaNhomLopSource.MaNhomLop;
						}
						else
						{
							child.MaNhomLop = entity.MaNhomLop;
						}

					}

					if (entity.HeSoLopDongCollection.Count > 0 || entity.HeSoLopDongCollection.DeletedItems.Count > 0)
					{
						//DataRepository.HeSoLopDongProvider.Save(transactionManager, entity.HeSoLopDongCollection);
						
						deepHandles.Add("HeSoLopDongCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< HeSoLopDong >) DataRepository.HeSoLopDongProvider.DeepSave,
							new object[] { transactionManager, entity.HeSoLopDongCollection, deepSaveType, childTypes, innerList }
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
	
	#region NhomLopDongChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.NhomLopDong</c>
	///</summary>
	public enum NhomLopDongChildEntityTypes
	{

		///<summary>
		/// Collection of <c>NhomLopDong</c> as OneToMany for HeSoLopDongCollection
		///</summary>
		[ChildEntityType(typeof(TList<HeSoLopDong>))]
		HeSoLopDongCollection,
	}
	
	#endregion NhomLopDongChildEntityTypes
	
	#region NhomLopDongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;NhomLopDongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomLopDong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomLopDongFilterBuilder : SqlFilterBuilder<NhomLopDongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomLopDongFilterBuilder class.
		/// </summary>
		public NhomLopDongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomLopDongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomLopDongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomLopDongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomLopDongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomLopDongFilterBuilder
	
	#region NhomLopDongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;NhomLopDongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomLopDong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomLopDongParameterBuilder : ParameterizedSqlFilterBuilder<NhomLopDongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomLopDongParameterBuilder class.
		/// </summary>
		public NhomLopDongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomLopDongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomLopDongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomLopDongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomLopDongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomLopDongParameterBuilder
	
	#region NhomLopDongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;NhomLopDongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomLopDong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class NhomLopDongSortBuilder : SqlSortBuilder<NhomLopDongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomLopDongSqlSortBuilder class.
		/// </summary>
		public NhomLopDongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion NhomLopDongSortBuilder
	
} // end namespace
