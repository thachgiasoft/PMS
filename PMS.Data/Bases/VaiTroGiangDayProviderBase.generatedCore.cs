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
	/// This class is the base class for any <see cref="VaiTroGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class VaiTroGiangDayProviderBaseCore : EntityProviderBase<PMS.Entities.VaiTroGiangDay, PMS.Entities.VaiTroGiangDayKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.VaiTroGiangDayKey key)
		{
			return Delete(transactionManager, key.MaVaiTro);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maVaiTro">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maVaiTro)
		{
			return Delete(null, _maVaiTro);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maVaiTro">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maVaiTro);		
		
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
		public override PMS.Entities.VaiTroGiangDay Get(TransactionManager transactionManager, PMS.Entities.VaiTroGiangDayKey key, int start, int pageLength)
		{
			return GetByMaVaiTro(transactionManager, key.MaVaiTro, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_VaiTroGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.VaiTroGiangDay"/> class.</returns>
		public PMS.Entities.VaiTroGiangDay GetByMaQuanLy(System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_VaiTroGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.VaiTroGiangDay"/> class.</returns>
		public PMS.Entities.VaiTroGiangDay GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_VaiTroGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.VaiTroGiangDay"/> class.</returns>
		public PMS.Entities.VaiTroGiangDay GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_VaiTroGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.VaiTroGiangDay"/> class.</returns>
		public PMS.Entities.VaiTroGiangDay GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_VaiTroGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.VaiTroGiangDay"/> class.</returns>
		public PMS.Entities.VaiTroGiangDay GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_VaiTroGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.VaiTroGiangDay"/> class.</returns>
		public abstract PMS.Entities.VaiTroGiangDay GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_VaiTroGiangDay index.
		/// </summary>
		/// <param name="_maVaiTro"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.VaiTroGiangDay"/> class.</returns>
		public PMS.Entities.VaiTroGiangDay GetByMaVaiTro(System.Int32 _maVaiTro)
		{
			int count = -1;
			return GetByMaVaiTro(null,_maVaiTro, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_VaiTroGiangDay index.
		/// </summary>
		/// <param name="_maVaiTro"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.VaiTroGiangDay"/> class.</returns>
		public PMS.Entities.VaiTroGiangDay GetByMaVaiTro(System.Int32 _maVaiTro, int start, int pageLength)
		{
			int count = -1;
			return GetByMaVaiTro(null, _maVaiTro, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_VaiTroGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maVaiTro"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.VaiTroGiangDay"/> class.</returns>
		public PMS.Entities.VaiTroGiangDay GetByMaVaiTro(TransactionManager transactionManager, System.Int32 _maVaiTro)
		{
			int count = -1;
			return GetByMaVaiTro(transactionManager, _maVaiTro, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_VaiTroGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maVaiTro"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.VaiTroGiangDay"/> class.</returns>
		public PMS.Entities.VaiTroGiangDay GetByMaVaiTro(TransactionManager transactionManager, System.Int32 _maVaiTro, int start, int pageLength)
		{
			int count = -1;
			return GetByMaVaiTro(transactionManager, _maVaiTro, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_VaiTroGiangDay index.
		/// </summary>
		/// <param name="_maVaiTro"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.VaiTroGiangDay"/> class.</returns>
		public PMS.Entities.VaiTroGiangDay GetByMaVaiTro(System.Int32 _maVaiTro, int start, int pageLength, out int count)
		{
			return GetByMaVaiTro(null, _maVaiTro, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_VaiTroGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maVaiTro"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.VaiTroGiangDay"/> class.</returns>
		public abstract PMS.Entities.VaiTroGiangDay GetByMaVaiTro(TransactionManager transactionManager, System.Int32 _maVaiTro, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;VaiTroGiangDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;VaiTroGiangDay&gt;"/></returns>
		public static TList<VaiTroGiangDay> Fill(IDataReader reader, TList<VaiTroGiangDay> rows, int start, int pageLength)
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
				
				PMS.Entities.VaiTroGiangDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("VaiTroGiangDay")
					.Append("|").Append((System.Int32)reader[((int)VaiTroGiangDayColumn.MaVaiTro - 1)]).ToString();
					c = EntityManager.LocateOrCreate<VaiTroGiangDay>(
					key.ToString(), // EntityTrackingKey
					"VaiTroGiangDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.VaiTroGiangDay();
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
					c.MaVaiTro = (System.Int32)reader[((int)VaiTroGiangDayColumn.MaVaiTro - 1)];
					c.MaQuanLy = (System.String)reader[((int)VaiTroGiangDayColumn.MaQuanLy - 1)];
					c.TenVaiTro = (reader.IsDBNull(((int)VaiTroGiangDayColumn.TenVaiTro - 1)))?null:(System.String)reader[((int)VaiTroGiangDayColumn.TenVaiTro - 1)];
					c.SoTiet = (reader.IsDBNull(((int)VaiTroGiangDayColumn.SoTiet - 1)))?null:(System.Decimal?)reader[((int)VaiTroGiangDayColumn.SoTiet - 1)];
					c.HeSo = (reader.IsDBNull(((int)VaiTroGiangDayColumn.HeSo - 1)))?null:(System.Decimal?)reader[((int)VaiTroGiangDayColumn.HeSo - 1)];
					c.ThuTu = (reader.IsDBNull(((int)VaiTroGiangDayColumn.ThuTu - 1)))?null:(System.Int32?)reader[((int)VaiTroGiangDayColumn.ThuTu - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.VaiTroGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.VaiTroGiangDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.VaiTroGiangDay entity)
		{
			if (!reader.Read()) return;
			
			entity.MaVaiTro = (System.Int32)reader[((int)VaiTroGiangDayColumn.MaVaiTro - 1)];
			entity.MaQuanLy = (System.String)reader[((int)VaiTroGiangDayColumn.MaQuanLy - 1)];
			entity.TenVaiTro = (reader.IsDBNull(((int)VaiTroGiangDayColumn.TenVaiTro - 1)))?null:(System.String)reader[((int)VaiTroGiangDayColumn.TenVaiTro - 1)];
			entity.SoTiet = (reader.IsDBNull(((int)VaiTroGiangDayColumn.SoTiet - 1)))?null:(System.Decimal?)reader[((int)VaiTroGiangDayColumn.SoTiet - 1)];
			entity.HeSo = (reader.IsDBNull(((int)VaiTroGiangDayColumn.HeSo - 1)))?null:(System.Decimal?)reader[((int)VaiTroGiangDayColumn.HeSo - 1)];
			entity.ThuTu = (reader.IsDBNull(((int)VaiTroGiangDayColumn.ThuTu - 1)))?null:(System.Int32?)reader[((int)VaiTroGiangDayColumn.ThuTu - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.VaiTroGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.VaiTroGiangDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.VaiTroGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaVaiTro = (System.Int32)dataRow["MaVaiTro"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenVaiTro = Convert.IsDBNull(dataRow["TenVaiTro"]) ? null : (System.String)dataRow["TenVaiTro"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
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
		/// <param name="entity">The <see cref="PMS.Entities.VaiTroGiangDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.VaiTroGiangDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.VaiTroGiangDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaVaiTro methods when available
			
			#region ThuLaoThoaThuanCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ThuLaoThoaThuan>|ThuLaoThoaThuanCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ThuLaoThoaThuanCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ThuLaoThoaThuanCollection = DataRepository.ThuLaoThoaThuanProvider.GetByMaVaiTro(transactionManager, entity.MaVaiTro);

				if (deep && entity.ThuLaoThoaThuanCollection.Count > 0)
				{
					deepHandles.Add("ThuLaoThoaThuanCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ThuLaoThoaThuan>) DataRepository.ThuLaoThoaThuanProvider.DeepLoad,
						new object[] { transactionManager, entity.ThuLaoThoaThuanCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.VaiTroGiangDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.VaiTroGiangDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.VaiTroGiangDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.VaiTroGiangDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<ThuLaoThoaThuan>
				if (CanDeepSave(entity.ThuLaoThoaThuanCollection, "List<ThuLaoThoaThuan>|ThuLaoThoaThuanCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ThuLaoThoaThuan child in entity.ThuLaoThoaThuanCollection)
					{
						if(child.MaVaiTroSource != null)
						{
							child.MaVaiTro = child.MaVaiTroSource.MaVaiTro;
						}
						else
						{
							child.MaVaiTro = entity.MaVaiTro;
						}

					}

					if (entity.ThuLaoThoaThuanCollection.Count > 0 || entity.ThuLaoThoaThuanCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ThuLaoThoaThuanProvider.Save(transactionManager, entity.ThuLaoThoaThuanCollection);
						
						deepHandles.Add("ThuLaoThoaThuanCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ThuLaoThoaThuan >) DataRepository.ThuLaoThoaThuanProvider.DeepSave,
							new object[] { transactionManager, entity.ThuLaoThoaThuanCollection, deepSaveType, childTypes, innerList }
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
	
	#region VaiTroGiangDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.VaiTroGiangDay</c>
	///</summary>
	public enum VaiTroGiangDayChildEntityTypes
	{

		///<summary>
		/// Collection of <c>VaiTroGiangDay</c> as OneToMany for ThuLaoThoaThuanCollection
		///</summary>
		[ChildEntityType(typeof(TList<ThuLaoThoaThuan>))]
		ThuLaoThoaThuanCollection,
	}
	
	#endregion VaiTroGiangDayChildEntityTypes
	
	#region VaiTroGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;VaiTroGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VaiTroGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VaiTroGiangDayFilterBuilder : SqlFilterBuilder<VaiTroGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VaiTroGiangDayFilterBuilder class.
		/// </summary>
		public VaiTroGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VaiTroGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VaiTroGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VaiTroGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VaiTroGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VaiTroGiangDayFilterBuilder
	
	#region VaiTroGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;VaiTroGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VaiTroGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VaiTroGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<VaiTroGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VaiTroGiangDayParameterBuilder class.
		/// </summary>
		public VaiTroGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VaiTroGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VaiTroGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VaiTroGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VaiTroGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VaiTroGiangDayParameterBuilder
	
	#region VaiTroGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;VaiTroGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VaiTroGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VaiTroGiangDaySortBuilder : SqlSortBuilder<VaiTroGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VaiTroGiangDaySqlSortBuilder class.
		/// </summary>
		public VaiTroGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VaiTroGiangDaySortBuilder
	
} // end namespace
