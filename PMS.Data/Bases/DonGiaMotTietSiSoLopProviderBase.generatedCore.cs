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
	/// This class is the base class for any <see cref="DonGiaMotTietSiSoLopProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DonGiaMotTietSiSoLopProviderBaseCore : EntityProviderBase<PMS.Entities.DonGiaMotTietSiSoLop, PMS.Entities.DonGiaMotTietSiSoLopKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DonGiaMotTietSiSoLopKey key)
		{
			return Delete(transactionManager, key.MaDonGiaMotTietSiSoLop);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maDonGiaMotTietSiSoLop">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maDonGiaMotTietSiSoLop)
		{
			return Delete(null, _maDonGiaMotTietSiSoLop);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonGiaMotTietSiSoLop">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maDonGiaMotTietSiSoLop);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaMotTiet_SiSoLop_DonGiaMotTiet key.
		///		FK_DonGiaMotTiet_SiSoLop_DonGiaMotTiet Description: 
		/// </summary>
		/// <param name="_maDonGia"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaMotTietSiSoLop objects.</returns>
		public TList<DonGiaMotTietSiSoLop> GetByMaDonGia(System.Int32 _maDonGia)
		{
			int count = -1;
			return GetByMaDonGia(_maDonGia, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaMotTiet_SiSoLop_DonGiaMotTiet key.
		///		FK_DonGiaMotTiet_SiSoLop_DonGiaMotTiet Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonGia"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaMotTietSiSoLop objects.</returns>
		/// <remarks></remarks>
		public TList<DonGiaMotTietSiSoLop> GetByMaDonGia(TransactionManager transactionManager, System.Int32 _maDonGia)
		{
			int count = -1;
			return GetByMaDonGia(transactionManager, _maDonGia, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaMotTiet_SiSoLop_DonGiaMotTiet key.
		///		FK_DonGiaMotTiet_SiSoLop_DonGiaMotTiet Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonGia"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaMotTietSiSoLop objects.</returns>
		public TList<DonGiaMotTietSiSoLop> GetByMaDonGia(TransactionManager transactionManager, System.Int32 _maDonGia, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDonGia(transactionManager, _maDonGia, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaMotTiet_SiSoLop_DonGiaMotTiet key.
		///		fkDonGiaMotTietSiSoLopDonGiaMotTiet Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maDonGia"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaMotTietSiSoLop objects.</returns>
		public TList<DonGiaMotTietSiSoLop> GetByMaDonGia(System.Int32 _maDonGia, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaDonGia(null, _maDonGia, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaMotTiet_SiSoLop_DonGiaMotTiet key.
		///		fkDonGiaMotTietSiSoLopDonGiaMotTiet Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maDonGia"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaMotTietSiSoLop objects.</returns>
		public TList<DonGiaMotTietSiSoLop> GetByMaDonGia(System.Int32 _maDonGia, int start, int pageLength,out int count)
		{
			return GetByMaDonGia(null, _maDonGia, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DonGiaMotTiet_SiSoLop_DonGiaMotTiet key.
		///		FK_DonGiaMotTiet_SiSoLop_DonGiaMotTiet Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonGia"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DonGiaMotTietSiSoLop objects.</returns>
		public abstract TList<DonGiaMotTietSiSoLop> GetByMaDonGia(TransactionManager transactionManager, System.Int32 _maDonGia, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.DonGiaMotTietSiSoLop Get(TransactionManager transactionManager, PMS.Entities.DonGiaMotTietSiSoLopKey key, int start, int pageLength)
		{
			return GetByMaDonGiaMotTietSiSoLop(transactionManager, key.MaDonGiaMotTietSiSoLop, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DonGiaMotTiet_SiSoLop index.
		/// </summary>
		/// <param name="_maDonGiaMotTietSiSoLop"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaMotTietSiSoLop"/> class.</returns>
		public PMS.Entities.DonGiaMotTietSiSoLop GetByMaDonGiaMotTietSiSoLop(System.Int32 _maDonGiaMotTietSiSoLop)
		{
			int count = -1;
			return GetByMaDonGiaMotTietSiSoLop(null,_maDonGiaMotTietSiSoLop, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaMotTiet_SiSoLop index.
		/// </summary>
		/// <param name="_maDonGiaMotTietSiSoLop"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaMotTietSiSoLop"/> class.</returns>
		public PMS.Entities.DonGiaMotTietSiSoLop GetByMaDonGiaMotTietSiSoLop(System.Int32 _maDonGiaMotTietSiSoLop, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDonGiaMotTietSiSoLop(null, _maDonGiaMotTietSiSoLop, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaMotTiet_SiSoLop index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonGiaMotTietSiSoLop"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaMotTietSiSoLop"/> class.</returns>
		public PMS.Entities.DonGiaMotTietSiSoLop GetByMaDonGiaMotTietSiSoLop(TransactionManager transactionManager, System.Int32 _maDonGiaMotTietSiSoLop)
		{
			int count = -1;
			return GetByMaDonGiaMotTietSiSoLop(transactionManager, _maDonGiaMotTietSiSoLop, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaMotTiet_SiSoLop index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonGiaMotTietSiSoLop"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaMotTietSiSoLop"/> class.</returns>
		public PMS.Entities.DonGiaMotTietSiSoLop GetByMaDonGiaMotTietSiSoLop(TransactionManager transactionManager, System.Int32 _maDonGiaMotTietSiSoLop, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDonGiaMotTietSiSoLop(transactionManager, _maDonGiaMotTietSiSoLop, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaMotTiet_SiSoLop index.
		/// </summary>
		/// <param name="_maDonGiaMotTietSiSoLop"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaMotTietSiSoLop"/> class.</returns>
		public PMS.Entities.DonGiaMotTietSiSoLop GetByMaDonGiaMotTietSiSoLop(System.Int32 _maDonGiaMotTietSiSoLop, int start, int pageLength, out int count)
		{
			return GetByMaDonGiaMotTietSiSoLop(null, _maDonGiaMotTietSiSoLop, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonGiaMotTiet_SiSoLop index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonGiaMotTietSiSoLop"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonGiaMotTietSiSoLop"/> class.</returns>
		public abstract PMS.Entities.DonGiaMotTietSiSoLop GetByMaDonGiaMotTietSiSoLop(TransactionManager transactionManager, System.Int32 _maDonGiaMotTietSiSoLop, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DonGiaMotTietSiSoLop&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DonGiaMotTietSiSoLop&gt;"/></returns>
		public static TList<DonGiaMotTietSiSoLop> Fill(IDataReader reader, TList<DonGiaMotTietSiSoLop> rows, int start, int pageLength)
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
				
				PMS.Entities.DonGiaMotTietSiSoLop c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DonGiaMotTietSiSoLop")
					.Append("|").Append((System.Int32)reader[((int)DonGiaMotTietSiSoLopColumn.MaDonGiaMotTietSiSoLop - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DonGiaMotTietSiSoLop>(
					key.ToString(), // EntityTrackingKey
					"DonGiaMotTietSiSoLop",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DonGiaMotTietSiSoLop();
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
					c.MaDonGiaMotTietSiSoLop = (System.Int32)reader[((int)DonGiaMotTietSiSoLopColumn.MaDonGiaMotTietSiSoLop - 1)];
					c.MaDonGia = (System.Int32)reader[((int)DonGiaMotTietSiSoLopColumn.MaDonGia - 1)];
					c.TuKhoan = (System.Int32)reader[((int)DonGiaMotTietSiSoLopColumn.TuKhoan - 1)];
					c.DenKhoan = (System.Int32)reader[((int)DonGiaMotTietSiSoLopColumn.DenKhoan - 1)];
					c.SoTien = (System.Decimal)reader[((int)DonGiaMotTietSiSoLopColumn.SoTien - 1)];
					c.ThuTu = (reader.IsDBNull(((int)DonGiaMotTietSiSoLopColumn.ThuTu - 1)))?null:(System.Int32?)reader[((int)DonGiaMotTietSiSoLopColumn.ThuTu - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaMotTietSiSoLop"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaMotTietSiSoLop"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DonGiaMotTietSiSoLop entity)
		{
			if (!reader.Read()) return;
			
			entity.MaDonGiaMotTietSiSoLop = (System.Int32)reader[((int)DonGiaMotTietSiSoLopColumn.MaDonGiaMotTietSiSoLop - 1)];
			entity.MaDonGia = (System.Int32)reader[((int)DonGiaMotTietSiSoLopColumn.MaDonGia - 1)];
			entity.TuKhoan = (System.Int32)reader[((int)DonGiaMotTietSiSoLopColumn.TuKhoan - 1)];
			entity.DenKhoan = (System.Int32)reader[((int)DonGiaMotTietSiSoLopColumn.DenKhoan - 1)];
			entity.SoTien = (System.Decimal)reader[((int)DonGiaMotTietSiSoLopColumn.SoTien - 1)];
			entity.ThuTu = (reader.IsDBNull(((int)DonGiaMotTietSiSoLopColumn.ThuTu - 1)))?null:(System.Int32?)reader[((int)DonGiaMotTietSiSoLopColumn.ThuTu - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonGiaMotTietSiSoLop"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaMotTietSiSoLop"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DonGiaMotTietSiSoLop entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaDonGiaMotTietSiSoLop = (System.Int32)dataRow["MaDonGiaMotTiet_SiSoLop"];
			entity.MaDonGia = (System.Int32)dataRow["MaDonGia"];
			entity.TuKhoan = (System.Int32)dataRow["TuKhoan"];
			entity.DenKhoan = (System.Int32)dataRow["DenKhoan"];
			entity.SoTien = (System.Decimal)dataRow["SoTien"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DonGiaMotTietSiSoLop"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaMotTietSiSoLop Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DonGiaMotTietSiSoLop entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaDonGiaSource	
			if (CanDeepLoad(entity, "DonGiaMotTiet|MaDonGiaSource", deepLoadType, innerList) 
				&& entity.MaDonGiaSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MaDonGia;
				DonGiaMotTiet tmpEntity = EntityManager.LocateEntity<DonGiaMotTiet>(EntityLocator.ConstructKeyFromPkItems(typeof(DonGiaMotTiet), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaDonGiaSource = tmpEntity;
				else
					entity.MaDonGiaSource = DataRepository.DonGiaMotTietProvider.GetByMaDonGia(transactionManager, entity.MaDonGia);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaDonGiaSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaDonGiaSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.DonGiaMotTietProvider.DeepLoad(transactionManager, entity.MaDonGiaSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaDonGiaSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.DonGiaMotTietSiSoLop object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DonGiaMotTietSiSoLop instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DonGiaMotTietSiSoLop Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DonGiaMotTietSiSoLop entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaDonGiaSource
			if (CanDeepSave(entity, "DonGiaMotTiet|MaDonGiaSource", deepSaveType, innerList) 
				&& entity.MaDonGiaSource != null)
			{
				DataRepository.DonGiaMotTietProvider.Save(transactionManager, entity.MaDonGiaSource);
				entity.MaDonGia = entity.MaDonGiaSource.MaDonGia;
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
	
	#region DonGiaMotTietSiSoLopChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DonGiaMotTietSiSoLop</c>
	///</summary>
	public enum DonGiaMotTietSiSoLopChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>DonGiaMotTiet</c> at MaDonGiaSource
		///</summary>
		[ChildEntityType(typeof(DonGiaMotTiet))]
		DonGiaMotTiet,
		}
	
	#endregion DonGiaMotTietSiSoLopChildEntityTypes
	
	#region DonGiaMotTietSiSoLopFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DonGiaMotTietSiSoLopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaMotTietSiSoLop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaMotTietSiSoLopFilterBuilder : SqlFilterBuilder<DonGiaMotTietSiSoLopColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietSiSoLopFilterBuilder class.
		/// </summary>
		public DonGiaMotTietSiSoLopFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietSiSoLopFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaMotTietSiSoLopFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietSiSoLopFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaMotTietSiSoLopFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaMotTietSiSoLopFilterBuilder
	
	#region DonGiaMotTietSiSoLopParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DonGiaMotTietSiSoLopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaMotTietSiSoLop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaMotTietSiSoLopParameterBuilder : ParameterizedSqlFilterBuilder<DonGiaMotTietSiSoLopColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietSiSoLopParameterBuilder class.
		/// </summary>
		public DonGiaMotTietSiSoLopParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietSiSoLopParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonGiaMotTietSiSoLopParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietSiSoLopParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonGiaMotTietSiSoLopParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonGiaMotTietSiSoLopParameterBuilder
	
	#region DonGiaMotTietSiSoLopSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DonGiaMotTietSiSoLopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaMotTietSiSoLop"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DonGiaMotTietSiSoLopSortBuilder : SqlSortBuilder<DonGiaMotTietSiSoLopColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaMotTietSiSoLopSqlSortBuilder class.
		/// </summary>
		public DonGiaMotTietSiSoLopSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DonGiaMotTietSiSoLopSortBuilder
	
} // end namespace
