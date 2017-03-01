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
	/// This class is the base class for any <see cref="HoSoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HoSoProviderBaseCore : EntityProviderBase<PMS.Entities.HoSo, PMS.Entities.HoSoKey>
	{		
		#region Get from Many To Many Relationship Functions
		#region GetByMaGiangVienFromGiangVienHoSo
		
		/// <summary>
		///		Gets HoSo objects from the datasource by MaGiangVien in the
		///		GiangVien_HoSo table. Table HoSo is related to table GiangVien
		///		through the (M:N) relationship defined in the GiangVien_HoSo table.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns a typed collection of HoSo objects.</returns>
		public TList<HoSo> GetByMaGiangVienFromGiangVienHoSo(System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVienFromGiangVienHoSo(null,_maGiangVien, 0, int.MaxValue, out count);
			
		}
		
		/// <summary>
		///		Gets PMS.Entities.HoSo objects from the datasource by MaGiangVien in the
		///		GiangVien_HoSo table. Table HoSo is related to table GiangVien
		///		through the (M:N) relationship defined in the GiangVien_HoSo table.
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a TList of HoSo objects.</returns>
		public TList<HoSo> GetByMaGiangVienFromGiangVienHoSo(System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienFromGiangVienHoSo(null, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		///		Gets HoSo objects from the datasource by MaGiangVien in the
		///		GiangVien_HoSo table. Table HoSo is related to table GiangVien
		///		through the (M:N) relationship defined in the GiangVien_HoSo table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of HoSo objects.</returns>
		public TList<HoSo> GetByMaGiangVienFromGiangVienHoSo(TransactionManager transactionManager, System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVienFromGiangVienHoSo(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
		
		/// <summary>
		///		Gets HoSo objects from the datasource by MaGiangVien in the
		///		GiangVien_HoSo table. Table HoSo is related to table GiangVien
		///		through the (M:N) relationship defined in the GiangVien_HoSo table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of HoSo objects.</returns>
		public TList<HoSo> GetByMaGiangVienFromGiangVienHoSo(TransactionManager transactionManager, System.Int32 _maGiangVien,int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVienFromGiangVienHoSo(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		///		Gets HoSo objects from the datasource by MaGiangVien in the
		///		GiangVien_HoSo table. Table HoSo is related to table GiangVien
		///		through the (M:N) relationship defined in the GiangVien_HoSo table.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of HoSo objects.</returns>
		public TList<HoSo> GetByMaGiangVienFromGiangVienHoSo(System.Int32 _maGiangVien,int start, int pageLength, out int count)
		{
			
			return GetByMaGiangVienFromGiangVienHoSo(null, _maGiangVien, start, pageLength, out count);
		}


		/// <summary>
		///		Gets HoSo objects from the datasource by MaGiangVien in the
		///		GiangVien_HoSo table. Table HoSo is related to table GiangVien
		///		through the (M:N) relationship defined in the GiangVien_HoSo table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns a TList of HoSo objects.</returns>
		public abstract TList<HoSo> GetByMaGiangVienFromGiangVienHoSo(TransactionManager transactionManager,System.Int32 _maGiangVien, int start, int pageLength, out int count);
		
		#endregion GetByMaGiangVienFromGiangVienHoSo
		
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HoSoKey key)
		{
			return Delete(transactionManager, key.MaHoSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maHoSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maHoSo)
		{
			return Delete(null, _maHoSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maHoSo);		
		
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
		public override PMS.Entities.HoSo Get(TransactionManager transactionManager, PMS.Entities.HoSoKey key, int start, int pageLength)
		{
			return GetByMaHoSo(transactionManager, key.MaHoSo, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_HoSo index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoSo"/> class.</returns>
		public PMS.Entities.HoSo GetByMaQuanLy(System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HoSo index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoSo"/> class.</returns>
		public PMS.Entities.HoSo GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoSo"/> class.</returns>
		public PMS.Entities.HoSo GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoSo"/> class.</returns>
		public PMS.Entities.HoSo GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HoSo index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoSo"/> class.</returns>
		public PMS.Entities.HoSo GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoSo"/> class.</returns>
		public abstract PMS.Entities.HoSo GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HoSo index.
		/// </summary>
		/// <param name="_maHoSo"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoSo"/> class.</returns>
		public PMS.Entities.HoSo GetByMaHoSo(System.Int32 _maHoSo)
		{
			int count = -1;
			return GetByMaHoSo(null,_maHoSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoSo index.
		/// </summary>
		/// <param name="_maHoSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoSo"/> class.</returns>
		public PMS.Entities.HoSo GetByMaHoSo(System.Int32 _maHoSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHoSo(null, _maHoSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoSo"/> class.</returns>
		public PMS.Entities.HoSo GetByMaHoSo(TransactionManager transactionManager, System.Int32 _maHoSo)
		{
			int count = -1;
			return GetByMaHoSo(transactionManager, _maHoSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoSo"/> class.</returns>
		public PMS.Entities.HoSo GetByMaHoSo(TransactionManager transactionManager, System.Int32 _maHoSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHoSo(transactionManager, _maHoSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoSo index.
		/// </summary>
		/// <param name="_maHoSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoSo"/> class.</returns>
		public PMS.Entities.HoSo GetByMaHoSo(System.Int32 _maHoSo, int start, int pageLength, out int count)
		{
			return GetByMaHoSo(null, _maHoSo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoSo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoSo"/> class.</returns>
		public abstract PMS.Entities.HoSo GetByMaHoSo(TransactionManager transactionManager, System.Int32 _maHoSo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HoSo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HoSo&gt;"/></returns>
		public static TList<HoSo> Fill(IDataReader reader, TList<HoSo> rows, int start, int pageLength)
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
				
				PMS.Entities.HoSo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HoSo")
					.Append("|").Append((System.Int32)reader[((int)HoSoColumn.MaHoSo - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HoSo>(
					key.ToString(), // EntityTrackingKey
					"HoSo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HoSo();
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
					c.MaHoSo = (System.Int32)reader[(HoSoColumn.MaHoSo.ToString())];
					c.MaQuanLy = (System.String)reader[(HoSoColumn.MaQuanLy.ToString())];
					c.TenHoSo = (reader[HoSoColumn.TenHoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoSoColumn.TenHoSo.ToString())];
					c.ThuTu = (reader[HoSoColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HoSoColumn.ThuTu.ToString())];
					c.TrangThai = (reader[HoSoColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(HoSoColumn.TrangThai.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HoSo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HoSo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HoSo entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHoSo = (System.Int32)reader[(HoSoColumn.MaHoSo.ToString())];
			entity.MaQuanLy = (System.String)reader[(HoSoColumn.MaQuanLy.ToString())];
			entity.TenHoSo = (reader[HoSoColumn.TenHoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoSoColumn.TenHoSo.ToString())];
			entity.ThuTu = (reader[HoSoColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HoSoColumn.ThuTu.ToString())];
			entity.TrangThai = (reader[HoSoColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(HoSoColumn.TrangThai.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HoSo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HoSo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HoSo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHoSo = (System.Int32)dataRow["MaHoSo"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenHoSo = Convert.IsDBNull(dataRow["TenHoSo"]) ? null : (System.String)dataRow["TenHoSo"];
			entity.ThuTu = Convert.IsDBNull(dataRow["ThuTu"]) ? null : (System.Int32?)dataRow["ThuTu"];
			entity.TrangThai = Convert.IsDBNull(dataRow["TrangThai"]) ? null : (System.Boolean?)dataRow["TrangThai"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HoSo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HoSo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HoSo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaHoSo methods when available
			
			#region GiangVienHoSoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienHoSo>|GiangVienHoSoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienHoSoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienHoSoCollection = DataRepository.GiangVienHoSoProvider.GetByMaHoSo(transactionManager, entity.MaHoSo);

				if (deep && entity.GiangVienHoSoCollection.Count > 0)
				{
					deepHandles.Add("GiangVienHoSoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienHoSo>) DataRepository.GiangVienHoSoProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienHoSoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MaGiangVienGiangVienCollection_From_GiangVienHoSo
			// RelationshipType.ManyToMany
			if (CanDeepLoad(entity, "List<GiangVien>|MaGiangVienGiangVienCollection_From_GiangVienHoSo", deepLoadType, innerList))
			{
				entity.MaGiangVienGiangVienCollection_From_GiangVienHoSo = DataRepository.GiangVienProvider.GetByMaHoSoFromGiangVienHoSo(transactionManager, entity.MaHoSo);			 
		
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaGiangVienGiangVienCollection_From_GiangVienHoSo' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaGiangVienGiangVienCollection_From_GiangVienHoSo != null)
				{
					deepHandles.Add("MaGiangVienGiangVienCollection_From_GiangVienHoSo",
						new KeyValuePair<Delegate, object>((DeepLoadHandle< GiangVien >) DataRepository.GiangVienProvider.DeepLoad,
						new object[] { transactionManager, entity.MaGiangVienGiangVienCollection_From_GiangVienHoSo, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.HoSo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HoSo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HoSo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HoSo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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

			#region MaGiangVienGiangVienCollection_From_GiangVienHoSo>
			if (CanDeepSave(entity.MaGiangVienGiangVienCollection_From_GiangVienHoSo, "List<GiangVien>|MaGiangVienGiangVienCollection_From_GiangVienHoSo", deepSaveType, innerList))
			{
				if (entity.MaGiangVienGiangVienCollection_From_GiangVienHoSo.Count > 0 || entity.MaGiangVienGiangVienCollection_From_GiangVienHoSo.DeletedItems.Count > 0)
				{
					DataRepository.GiangVienProvider.Save(transactionManager, entity.MaGiangVienGiangVienCollection_From_GiangVienHoSo); 
					deepHandles.Add("MaGiangVienGiangVienCollection_From_GiangVienHoSo",
						new KeyValuePair<Delegate, object>((DeepSaveHandle<GiangVien>) DataRepository.GiangVienProvider.DeepSave,
						new object[] { transactionManager, entity.MaGiangVienGiangVienCollection_From_GiangVienHoSo, deepSaveType, childTypes, innerList }
					));
				}
			}
			#endregion 
	
			#region List<GiangVienHoSo>
				if (CanDeepSave(entity.GiangVienHoSoCollection, "List<GiangVienHoSo>|GiangVienHoSoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienHoSo child in entity.GiangVienHoSoCollection)
					{
						if(child.MaHoSoSource != null)
						{
								child.MaHoSo = child.MaHoSoSource.MaHoSo;
						}

						if(child.MaGiangVienSource != null)
						{
								child.MaGiangVien = child.MaGiangVienSource.MaGiangVien;
						}

					}

					if (entity.GiangVienHoSoCollection.Count > 0 || entity.GiangVienHoSoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienHoSoProvider.Save(transactionManager, entity.GiangVienHoSoCollection);
						
						deepHandles.Add("GiangVienHoSoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienHoSo >) DataRepository.GiangVienHoSoProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienHoSoCollection, deepSaveType, childTypes, innerList }
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
	
	#region HoSoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HoSo</c>
	///</summary>
	public enum HoSoChildEntityTypes
	{
		///<summary>
		/// Collection of <c>HoSo</c> as OneToMany for GiangVienHoSoCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienHoSo>))]
		GiangVienHoSoCollection,
		///<summary>
		/// Collection of <c>HoSo</c> as ManyToMany for GiangVienCollection_From_GiangVienHoSo
		///</summary>
		[ChildEntityType(typeof(TList<GiangVien>))]
		MaGiangVienGiangVienCollection_From_GiangVienHoSo,
	}
	
	#endregion HoSoChildEntityTypes
	
	#region HoSoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HoSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoSoFilterBuilder : SqlFilterBuilder<HoSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoSoFilterBuilder class.
		/// </summary>
		public HoSoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HoSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HoSoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HoSoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HoSoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HoSoFilterBuilder
	
	#region HoSoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HoSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoSoParameterBuilder : ParameterizedSqlFilterBuilder<HoSoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoSoParameterBuilder class.
		/// </summary>
		public HoSoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HoSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HoSoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HoSoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HoSoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HoSoParameterBuilder
	
	#region HoSoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HoSoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoSo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HoSoSortBuilder : SqlSortBuilder<HoSoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoSoSqlSortBuilder class.
		/// </summary>
		public HoSoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HoSoSortBuilder
	
} // end namespace
