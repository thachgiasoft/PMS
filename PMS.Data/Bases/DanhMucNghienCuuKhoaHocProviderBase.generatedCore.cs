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
	/// This class is the base class for any <see cref="DanhMucNghienCuuKhoaHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DanhMucNghienCuuKhoaHocProviderBaseCore : EntityProviderBase<PMS.Entities.DanhMucNghienCuuKhoaHoc, PMS.Entities.DanhMucNghienCuuKhoaHocKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DanhMucNghienCuuKhoaHocKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _id)
		{
			return Delete(null, _id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _id);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DanhMucNghienCuuKhoaHoc_LoaiNghienCuuKhoaHoc key.
		///		FK_DanhMucNghienCuuKhoaHoc_LoaiNghienCuuKhoaHoc Description: 
		/// </summary>
		/// <param name="_maLoaiNckh"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DanhMucNghienCuuKhoaHoc objects.</returns>
		public TList<DanhMucNghienCuuKhoaHoc> GetByMaLoaiNckh(System.Int32? _maLoaiNckh)
		{
			int count = -1;
			return GetByMaLoaiNckh(_maLoaiNckh, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DanhMucNghienCuuKhoaHoc_LoaiNghienCuuKhoaHoc key.
		///		FK_DanhMucNghienCuuKhoaHoc_LoaiNghienCuuKhoaHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiNckh"></param>
		/// <returns>Returns a typed collection of PMS.Entities.DanhMucNghienCuuKhoaHoc objects.</returns>
		/// <remarks></remarks>
		public TList<DanhMucNghienCuuKhoaHoc> GetByMaLoaiNckh(TransactionManager transactionManager, System.Int32? _maLoaiNckh)
		{
			int count = -1;
			return GetByMaLoaiNckh(transactionManager, _maLoaiNckh, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_DanhMucNghienCuuKhoaHoc_LoaiNghienCuuKhoaHoc key.
		///		FK_DanhMucNghienCuuKhoaHoc_LoaiNghienCuuKhoaHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiNckh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DanhMucNghienCuuKhoaHoc objects.</returns>
		public TList<DanhMucNghienCuuKhoaHoc> GetByMaLoaiNckh(TransactionManager transactionManager, System.Int32? _maLoaiNckh, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiNckh(transactionManager, _maLoaiNckh, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DanhMucNghienCuuKhoaHoc_LoaiNghienCuuKhoaHoc key.
		///		fkDanhMucNghienCuuKhoaHocLoaiNghienCuuKhoaHoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiNckh"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DanhMucNghienCuuKhoaHoc objects.</returns>
		public TList<DanhMucNghienCuuKhoaHoc> GetByMaLoaiNckh(System.Int32? _maLoaiNckh, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaLoaiNckh(null, _maLoaiNckh, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DanhMucNghienCuuKhoaHoc_LoaiNghienCuuKhoaHoc key.
		///		fkDanhMucNghienCuuKhoaHocLoaiNghienCuuKhoaHoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiNckh"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.DanhMucNghienCuuKhoaHoc objects.</returns>
		public TList<DanhMucNghienCuuKhoaHoc> GetByMaLoaiNckh(System.Int32? _maLoaiNckh, int start, int pageLength,out int count)
		{
			return GetByMaLoaiNckh(null, _maLoaiNckh, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_DanhMucNghienCuuKhoaHoc_LoaiNghienCuuKhoaHoc key.
		///		FK_DanhMucNghienCuuKhoaHoc_LoaiNghienCuuKhoaHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiNckh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.DanhMucNghienCuuKhoaHoc objects.</returns>
		public abstract TList<DanhMucNghienCuuKhoaHoc> GetByMaLoaiNckh(TransactionManager transactionManager, System.Int32? _maLoaiNckh, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.DanhMucNghienCuuKhoaHoc Get(TransactionManager transactionManager, PMS.Entities.DanhMucNghienCuuKhoaHocKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DanhMucNghienCuuKhoaHoc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucNghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.DanhMucNghienCuuKhoaHoc GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucNghienCuuKhoaHoc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucNghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.DanhMucNghienCuuKhoaHoc GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucNghienCuuKhoaHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucNghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.DanhMucNghienCuuKhoaHoc GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucNghienCuuKhoaHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucNghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.DanhMucNghienCuuKhoaHoc GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucNghienCuuKhoaHoc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucNghienCuuKhoaHoc"/> class.</returns>
		public PMS.Entities.DanhMucNghienCuuKhoaHoc GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DanhMucNghienCuuKhoaHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DanhMucNghienCuuKhoaHoc"/> class.</returns>
		public abstract PMS.Entities.DanhMucNghienCuuKhoaHoc GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DanhMucNghienCuuKhoaHoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DanhMucNghienCuuKhoaHoc&gt;"/></returns>
		public static TList<DanhMucNghienCuuKhoaHoc> Fill(IDataReader reader, TList<DanhMucNghienCuuKhoaHoc> rows, int start, int pageLength)
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
				
				PMS.Entities.DanhMucNghienCuuKhoaHoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DanhMucNghienCuuKhoaHoc")
					.Append("|").Append((System.Int32)reader[((int)DanhMucNghienCuuKhoaHocColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DanhMucNghienCuuKhoaHoc>(
					key.ToString(), // EntityTrackingKey
					"DanhMucNghienCuuKhoaHoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DanhMucNghienCuuKhoaHoc();
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
					c.Id = (System.Int32)reader[(DanhMucNghienCuuKhoaHocColumn.Id.ToString())];
					c.MaQuanLy = (reader[DanhMucNghienCuuKhoaHocColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucNghienCuuKhoaHocColumn.MaQuanLy.ToString())];
					c.TenNghienCuuKhoaHoc = (reader[DanhMucNghienCuuKhoaHocColumn.TenNghienCuuKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucNghienCuuKhoaHocColumn.TenNghienCuuKhoaHoc.ToString())];
					c.SoTiet = (reader[DanhMucNghienCuuKhoaHocColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhMucNghienCuuKhoaHocColumn.SoTiet.ToString())];
					c.GhiChu = (reader[DanhMucNghienCuuKhoaHocColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucNghienCuuKhoaHocColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[DanhMucNghienCuuKhoaHocColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucNghienCuuKhoaHocColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[DanhMucNghienCuuKhoaHocColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucNghienCuuKhoaHocColumn.NguoiCapNhat.ToString())];
					c.MaLoaiNckh = (reader[DanhMucNghienCuuKhoaHocColumn.MaLoaiNckh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DanhMucNghienCuuKhoaHocColumn.MaLoaiNckh.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DanhMucNghienCuuKhoaHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucNghienCuuKhoaHoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DanhMucNghienCuuKhoaHoc entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(DanhMucNghienCuuKhoaHocColumn.Id.ToString())];
			entity.MaQuanLy = (reader[DanhMucNghienCuuKhoaHocColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucNghienCuuKhoaHocColumn.MaQuanLy.ToString())];
			entity.TenNghienCuuKhoaHoc = (reader[DanhMucNghienCuuKhoaHocColumn.TenNghienCuuKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucNghienCuuKhoaHocColumn.TenNghienCuuKhoaHoc.ToString())];
			entity.SoTiet = (reader[DanhMucNghienCuuKhoaHocColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DanhMucNghienCuuKhoaHocColumn.SoTiet.ToString())];
			entity.GhiChu = (reader[DanhMucNghienCuuKhoaHocColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucNghienCuuKhoaHocColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[DanhMucNghienCuuKhoaHocColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucNghienCuuKhoaHocColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[DanhMucNghienCuuKhoaHocColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DanhMucNghienCuuKhoaHocColumn.NguoiCapNhat.ToString())];
			entity.MaLoaiNckh = (reader[DanhMucNghienCuuKhoaHocColumn.MaLoaiNckh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DanhMucNghienCuuKhoaHocColumn.MaLoaiNckh.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DanhMucNghienCuuKhoaHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucNghienCuuKhoaHoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DanhMucNghienCuuKhoaHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.TenNghienCuuKhoaHoc = Convert.IsDBNull(dataRow["TenNghienCuuKhoaHoc"]) ? null : (System.String)dataRow["TenNghienCuuKhoaHoc"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.MaLoaiNckh = Convert.IsDBNull(dataRow["MaLoaiNCKH"]) ? null : (System.Int32?)dataRow["MaLoaiNCKH"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DanhMucNghienCuuKhoaHoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DanhMucNghienCuuKhoaHoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DanhMucNghienCuuKhoaHoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaLoaiNckhSource	
			if (CanDeepLoad(entity, "LoaiNghienCuuKhoaHoc|MaLoaiNckhSource", deepLoadType, innerList) 
				&& entity.MaLoaiNckhSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaLoaiNckh ?? (int)0);
				LoaiNghienCuuKhoaHoc tmpEntity = EntityManager.LocateEntity<LoaiNghienCuuKhoaHoc>(EntityLocator.ConstructKeyFromPkItems(typeof(LoaiNghienCuuKhoaHoc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaLoaiNckhSource = tmpEntity;
				else
					entity.MaLoaiNckhSource = DataRepository.LoaiNghienCuuKhoaHocProvider.GetById(transactionManager, (entity.MaLoaiNckh ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaLoaiNckhSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaLoaiNckhSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.LoaiNghienCuuKhoaHocProvider.DeepLoad(transactionManager, entity.MaLoaiNckhSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaLoaiNckhSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetById methods when available
			
			#region GiangVienNghienCuuKhCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienNghienCuuKh>|GiangVienNghienCuuKhCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienNghienCuuKhCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienNghienCuuKhCollection = DataRepository.GiangVienNghienCuuKhProvider.GetByMaNckh(transactionManager, entity.Id);

				if (deep && entity.GiangVienNghienCuuKhCollection.Count > 0)
				{
					deepHandles.Add("GiangVienNghienCuuKhCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienNghienCuuKh>) DataRepository.GiangVienNghienCuuKhProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienNghienCuuKhCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.DanhMucNghienCuuKhoaHoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DanhMucNghienCuuKhoaHoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DanhMucNghienCuuKhoaHoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DanhMucNghienCuuKhoaHoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaLoaiNckhSource
			if (CanDeepSave(entity, "LoaiNghienCuuKhoaHoc|MaLoaiNckhSource", deepSaveType, innerList) 
				&& entity.MaLoaiNckhSource != null)
			{
				DataRepository.LoaiNghienCuuKhoaHocProvider.Save(transactionManager, entity.MaLoaiNckhSource);
				entity.MaLoaiNckh = entity.MaLoaiNckhSource.Id;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GiangVienNghienCuuKh>
				if (CanDeepSave(entity.GiangVienNghienCuuKhCollection, "List<GiangVienNghienCuuKh>|GiangVienNghienCuuKhCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienNghienCuuKh child in entity.GiangVienNghienCuuKhCollection)
					{
						if(child.MaNckhSource != null)
						{
							child.MaNckh = child.MaNckhSource.Id;
						}
						else
						{
							child.MaNckh = entity.Id;
						}

					}

					if (entity.GiangVienNghienCuuKhCollection.Count > 0 || entity.GiangVienNghienCuuKhCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienNghienCuuKhProvider.Save(transactionManager, entity.GiangVienNghienCuuKhCollection);
						
						deepHandles.Add("GiangVienNghienCuuKhCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienNghienCuuKh >) DataRepository.GiangVienNghienCuuKhProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienNghienCuuKhCollection, deepSaveType, childTypes, innerList }
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
	
	#region DanhMucNghienCuuKhoaHocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DanhMucNghienCuuKhoaHoc</c>
	///</summary>
	public enum DanhMucNghienCuuKhoaHocChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>LoaiNghienCuuKhoaHoc</c> at MaLoaiNckhSource
		///</summary>
		[ChildEntityType(typeof(LoaiNghienCuuKhoaHoc))]
		LoaiNghienCuuKhoaHoc,
		///<summary>
		/// Collection of <c>DanhMucNghienCuuKhoaHoc</c> as OneToMany for GiangVienNghienCuuKhCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienNghienCuuKh>))]
		GiangVienNghienCuuKhCollection,
	}
	
	#endregion DanhMucNghienCuuKhoaHocChildEntityTypes
	
	#region DanhMucNghienCuuKhoaHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DanhMucNghienCuuKhoaHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucNghienCuuKhoaHocFilterBuilder : SqlFilterBuilder<DanhMucNghienCuuKhoaHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucNghienCuuKhoaHocFilterBuilder class.
		/// </summary>
		public DanhMucNghienCuuKhoaHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DanhMucNghienCuuKhoaHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DanhMucNghienCuuKhoaHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DanhMucNghienCuuKhoaHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DanhMucNghienCuuKhoaHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DanhMucNghienCuuKhoaHocFilterBuilder
	
	#region DanhMucNghienCuuKhoaHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DanhMucNghienCuuKhoaHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucNghienCuuKhoaHocParameterBuilder : ParameterizedSqlFilterBuilder<DanhMucNghienCuuKhoaHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucNghienCuuKhoaHocParameterBuilder class.
		/// </summary>
		public DanhMucNghienCuuKhoaHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DanhMucNghienCuuKhoaHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DanhMucNghienCuuKhoaHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DanhMucNghienCuuKhoaHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DanhMucNghienCuuKhoaHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DanhMucNghienCuuKhoaHocParameterBuilder
	
	#region DanhMucNghienCuuKhoaHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DanhMucNghienCuuKhoaHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucNghienCuuKhoaHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DanhMucNghienCuuKhoaHocSortBuilder : SqlSortBuilder<DanhMucNghienCuuKhoaHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucNghienCuuKhoaHocSqlSortBuilder class.
		/// </summary>
		public DanhMucNghienCuuKhoaHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DanhMucNghienCuuKhoaHocSortBuilder
	
} // end namespace
