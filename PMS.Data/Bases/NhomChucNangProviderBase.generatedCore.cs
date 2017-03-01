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
	/// This class is the base class for any <see cref="NhomChucNangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class NhomChucNangProviderBaseCore : EntityProviderBase<PMS.Entities.NhomChucNang, PMS.Entities.NhomChucNangKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.NhomChucNangKey key)
		{
			return Delete(transactionManager, key.MaChucNang, key.MaNhomQuyen);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maChucNang">. Primary Key.</param>
		/// <param name="_maNhomQuyen">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maChucNang, System.Int32 _maNhomQuyen)
		{
			return Delete(null, _maChucNang, _maNhomQuyen);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucNang">. Primary Key.</param>
		/// <param name="_maNhomQuyen">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maChucNang, System.Int32 _maNhomQuyen);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GroupModules_Groups key.
		///		FK_GroupModules_Groups Description: 
		/// </summary>
		/// <param name="_maNhomQuyen"></param>
		/// <returns>Returns a typed collection of PMS.Entities.NhomChucNang objects.</returns>
		public TList<NhomChucNang> GetByMaNhomQuyen(System.Int32 _maNhomQuyen)
		{
			int count = -1;
			return GetByMaNhomQuyen(_maNhomQuyen, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GroupModules_Groups key.
		///		FK_GroupModules_Groups Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomQuyen"></param>
		/// <returns>Returns a typed collection of PMS.Entities.NhomChucNang objects.</returns>
		/// <remarks></remarks>
		public TList<NhomChucNang> GetByMaNhomQuyen(TransactionManager transactionManager, System.Int32 _maNhomQuyen)
		{
			int count = -1;
			return GetByMaNhomQuyen(transactionManager, _maNhomQuyen, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GroupModules_Groups key.
		///		FK_GroupModules_Groups Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.NhomChucNang objects.</returns>
		public TList<NhomChucNang> GetByMaNhomQuyen(TransactionManager transactionManager, System.Int32 _maNhomQuyen, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomQuyen(transactionManager, _maNhomQuyen, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GroupModules_Groups key.
		///		fkGroupModulesGroups Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhomQuyen"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.NhomChucNang objects.</returns>
		public TList<NhomChucNang> GetByMaNhomQuyen(System.Int32 _maNhomQuyen, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaNhomQuyen(null, _maNhomQuyen, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GroupModules_Groups key.
		///		fkGroupModulesGroups Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.NhomChucNang objects.</returns>
		public TList<NhomChucNang> GetByMaNhomQuyen(System.Int32 _maNhomQuyen, int start, int pageLength,out int count)
		{
			return GetByMaNhomQuyen(null, _maNhomQuyen, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GroupModules_Groups key.
		///		FK_GroupModules_Groups Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.NhomChucNang objects.</returns>
		public abstract TList<NhomChucNang> GetByMaNhomQuyen(TransactionManager transactionManager, System.Int32 _maNhomQuyen, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GroupModules_Modules key.
		///		FK_GroupModules_Modules Description: 
		/// </summary>
		/// <param name="_maChucNang"></param>
		/// <returns>Returns a typed collection of PMS.Entities.NhomChucNang objects.</returns>
		public TList<NhomChucNang> GetByMaChucNang(System.Int32 _maChucNang)
		{
			int count = -1;
			return GetByMaChucNang(_maChucNang, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GroupModules_Modules key.
		///		FK_GroupModules_Modules Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucNang"></param>
		/// <returns>Returns a typed collection of PMS.Entities.NhomChucNang objects.</returns>
		/// <remarks></remarks>
		public TList<NhomChucNang> GetByMaChucNang(TransactionManager transactionManager, System.Int32 _maChucNang)
		{
			int count = -1;
			return GetByMaChucNang(transactionManager, _maChucNang, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GroupModules_Modules key.
		///		FK_GroupModules_Modules Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucNang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.NhomChucNang objects.</returns>
		public TList<NhomChucNang> GetByMaChucNang(TransactionManager transactionManager, System.Int32 _maChucNang, int start, int pageLength)
		{
			int count = -1;
			return GetByMaChucNang(transactionManager, _maChucNang, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GroupModules_Modules key.
		///		fkGroupModulesModules Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maChucNang"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.NhomChucNang objects.</returns>
		public TList<NhomChucNang> GetByMaChucNang(System.Int32 _maChucNang, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaChucNang(null, _maChucNang, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GroupModules_Modules key.
		///		fkGroupModulesModules Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maChucNang"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.NhomChucNang objects.</returns>
		public TList<NhomChucNang> GetByMaChucNang(System.Int32 _maChucNang, int start, int pageLength,out int count)
		{
			return GetByMaChucNang(null, _maChucNang, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GroupModules_Modules key.
		///		FK_GroupModules_Modules Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucNang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.NhomChucNang objects.</returns>
		public abstract TList<NhomChucNang> GetByMaChucNang(TransactionManager transactionManager, System.Int32 _maChucNang, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.NhomChucNang Get(TransactionManager transactionManager, PMS.Entities.NhomChucNangKey key, int start, int pageLength)
		{
			return GetByMaChucNangMaNhomQuyen(transactionManager, key.MaChucNang, key.MaNhomQuyen, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GroupModules index.
		/// </summary>
		/// <param name="_maChucNang"></param>
		/// <param name="_maNhomQuyen"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomChucNang"/> class.</returns>
		public PMS.Entities.NhomChucNang GetByMaChucNangMaNhomQuyen(System.Int32 _maChucNang, System.Int32 _maNhomQuyen)
		{
			int count = -1;
			return GetByMaChucNangMaNhomQuyen(null,_maChucNang, _maNhomQuyen, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GroupModules index.
		/// </summary>
		/// <param name="_maChucNang"></param>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomChucNang"/> class.</returns>
		public PMS.Entities.NhomChucNang GetByMaChucNangMaNhomQuyen(System.Int32 _maChucNang, System.Int32 _maNhomQuyen, int start, int pageLength)
		{
			int count = -1;
			return GetByMaChucNangMaNhomQuyen(null, _maChucNang, _maNhomQuyen, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GroupModules index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucNang"></param>
		/// <param name="_maNhomQuyen"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomChucNang"/> class.</returns>
		public PMS.Entities.NhomChucNang GetByMaChucNangMaNhomQuyen(TransactionManager transactionManager, System.Int32 _maChucNang, System.Int32 _maNhomQuyen)
		{
			int count = -1;
			return GetByMaChucNangMaNhomQuyen(transactionManager, _maChucNang, _maNhomQuyen, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GroupModules index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucNang"></param>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomChucNang"/> class.</returns>
		public PMS.Entities.NhomChucNang GetByMaChucNangMaNhomQuyen(TransactionManager transactionManager, System.Int32 _maChucNang, System.Int32 _maNhomQuyen, int start, int pageLength)
		{
			int count = -1;
			return GetByMaChucNangMaNhomQuyen(transactionManager, _maChucNang, _maNhomQuyen, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GroupModules index.
		/// </summary>
		/// <param name="_maChucNang"></param>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomChucNang"/> class.</returns>
		public PMS.Entities.NhomChucNang GetByMaChucNangMaNhomQuyen(System.Int32 _maChucNang, System.Int32 _maNhomQuyen, int start, int pageLength, out int count)
		{
			return GetByMaChucNangMaNhomQuyen(null, _maChucNang, _maNhomQuyen, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GroupModules index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucNang"></param>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomChucNang"/> class.</returns>
		public abstract PMS.Entities.NhomChucNang GetByMaChucNangMaNhomQuyen(TransactionManager transactionManager, System.Int32 _maChucNang, System.Int32 _maNhomQuyen, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;NhomChucNang&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;NhomChucNang&gt;"/></returns>
		public static TList<NhomChucNang> Fill(IDataReader reader, TList<NhomChucNang> rows, int start, int pageLength)
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
				
				PMS.Entities.NhomChucNang c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("NhomChucNang")
					.Append("|").Append((System.Int32)reader[((int)NhomChucNangColumn.MaChucNang - 1)])
					.Append("|").Append((System.Int32)reader[((int)NhomChucNangColumn.MaNhomQuyen - 1)]).ToString();
					c = EntityManager.LocateOrCreate<NhomChucNang>(
					key.ToString(), // EntityTrackingKey
					"NhomChucNang",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.NhomChucNang();
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
					c.MaChucNang = (System.Int32)reader[(NhomChucNangColumn.MaChucNang.ToString())];
					c.OriginalMaChucNang = c.MaChucNang;
					c.MaNhomQuyen = (System.Int32)reader[(NhomChucNangColumn.MaNhomQuyen.ToString())];
					c.OriginalMaNhomQuyen = c.MaNhomQuyen;
					c.DuLieu = (reader[NhomChucNangColumn.DuLieu.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(NhomChucNangColumn.DuLieu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomChucNang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomChucNang"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.NhomChucNang entity)
		{
			if (!reader.Read()) return;
			
			entity.MaChucNang = (System.Int32)reader[(NhomChucNangColumn.MaChucNang.ToString())];
			entity.OriginalMaChucNang = (System.Int32)reader["MaChucNang"];
			entity.MaNhomQuyen = (System.Int32)reader[(NhomChucNangColumn.MaNhomQuyen.ToString())];
			entity.OriginalMaNhomQuyen = (System.Int32)reader["MaNhomQuyen"];
			entity.DuLieu = (reader[NhomChucNangColumn.DuLieu.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(NhomChucNangColumn.DuLieu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomChucNang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomChucNang"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.NhomChucNang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaChucNang = (System.Int32)dataRow["MaChucNang"];
			entity.OriginalMaChucNang = (System.Int32)dataRow["MaChucNang"];
			entity.MaNhomQuyen = (System.Int32)dataRow["MaNhomQuyen"];
			entity.OriginalMaNhomQuyen = (System.Int32)dataRow["MaNhomQuyen"];
			entity.DuLieu = Convert.IsDBNull(dataRow["DuLieu"]) ? null : (System.Byte[])dataRow["DuLieu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.NhomChucNang"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.NhomChucNang Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.NhomChucNang entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaNhomQuyenSource	
			if (CanDeepLoad(entity, "NhomQuyen|MaNhomQuyenSource", deepLoadType, innerList) 
				&& entity.MaNhomQuyenSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MaNhomQuyen;
				NhomQuyen tmpEntity = EntityManager.LocateEntity<NhomQuyen>(EntityLocator.ConstructKeyFromPkItems(typeof(NhomQuyen), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaNhomQuyenSource = tmpEntity;
				else
					entity.MaNhomQuyenSource = DataRepository.NhomQuyenProvider.GetByMaNhomQuyen(transactionManager, entity.MaNhomQuyen);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaNhomQuyenSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaNhomQuyenSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.NhomQuyenProvider.DeepLoad(transactionManager, entity.MaNhomQuyenSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaNhomQuyenSource

			#region MaChucNangSource	
			if (CanDeepLoad(entity, "ChucNang|MaChucNangSource", deepLoadType, innerList) 
				&& entity.MaChucNangSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MaChucNang;
				ChucNang tmpEntity = EntityManager.LocateEntity<ChucNang>(EntityLocator.ConstructKeyFromPkItems(typeof(ChucNang), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaChucNangSource = tmpEntity;
				else
					entity.MaChucNangSource = DataRepository.ChucNangProvider.GetById(transactionManager, entity.MaChucNang);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaChucNangSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaChucNangSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ChucNangProvider.DeepLoad(transactionManager, entity.MaChucNangSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaChucNangSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.NhomChucNang object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.NhomChucNang instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.NhomChucNang Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.NhomChucNang entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaNhomQuyenSource
			if (CanDeepSave(entity, "NhomQuyen|MaNhomQuyenSource", deepSaveType, innerList) 
				&& entity.MaNhomQuyenSource != null)
			{
				DataRepository.NhomQuyenProvider.Save(transactionManager, entity.MaNhomQuyenSource);
				entity.MaNhomQuyen = entity.MaNhomQuyenSource.MaNhomQuyen;
			}
			#endregion 
			
			#region MaChucNangSource
			if (CanDeepSave(entity, "ChucNang|MaChucNangSource", deepSaveType, innerList) 
				&& entity.MaChucNangSource != null)
			{
				DataRepository.ChucNangProvider.Save(transactionManager, entity.MaChucNangSource);
				entity.MaChucNang = entity.MaChucNangSource.Id;
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
	
	#region NhomChucNangChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.NhomChucNang</c>
	///</summary>
	public enum NhomChucNangChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>NhomQuyen</c> at MaNhomQuyenSource
		///</summary>
		[ChildEntityType(typeof(NhomQuyen))]
		NhomQuyen,
		
		///<summary>
		/// Composite Property for <c>ChucNang</c> at MaChucNangSource
		///</summary>
		[ChildEntityType(typeof(ChucNang))]
		ChucNang,
	}
	
	#endregion NhomChucNangChildEntityTypes
	
	#region NhomChucNangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;NhomChucNangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomChucNang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomChucNangFilterBuilder : SqlFilterBuilder<NhomChucNangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomChucNangFilterBuilder class.
		/// </summary>
		public NhomChucNangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomChucNangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomChucNangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomChucNangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomChucNangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomChucNangFilterBuilder
	
	#region NhomChucNangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;NhomChucNangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomChucNang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomChucNangParameterBuilder : ParameterizedSqlFilterBuilder<NhomChucNangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomChucNangParameterBuilder class.
		/// </summary>
		public NhomChucNangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomChucNangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomChucNangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomChucNangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomChucNangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomChucNangParameterBuilder
	
	#region NhomChucNangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;NhomChucNangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomChucNang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class NhomChucNangSortBuilder : SqlSortBuilder<NhomChucNangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomChucNangSqlSortBuilder class.
		/// </summary>
		public NhomChucNangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion NhomChucNangSortBuilder
	
} // end namespace
