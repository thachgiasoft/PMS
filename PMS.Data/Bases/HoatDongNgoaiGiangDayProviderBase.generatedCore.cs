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
	/// This class is the base class for any <see cref="HoatDongNgoaiGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HoatDongNgoaiGiangDayProviderBaseCore : EntityProviderBase<PMS.Entities.HoatDongNgoaiGiangDay, PMS.Entities.HoatDongNgoaiGiangDayKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HoatDongNgoaiGiangDayKey key)
		{
			return Delete(transactionManager, key.MaQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maQuanLy)
		{
			return Delete(null, _maQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maQuanLy);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HoatDongNgoaiGiangDay_NhomHoatDongNgoaiGiangDay key.
		///		FK_HoatDongNgoaiGiangDay_NhomHoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="_maNhom"></param>
		/// <returns>Returns a typed collection of PMS.Entities.HoatDongNgoaiGiangDay objects.</returns>
		public TList<HoatDongNgoaiGiangDay> GetByMaNhom(System.String _maNhom)
		{
			int count = -1;
			return GetByMaNhom(_maNhom, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HoatDongNgoaiGiangDay_NhomHoatDongNgoaiGiangDay key.
		///		FK_HoatDongNgoaiGiangDay_NhomHoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <returns>Returns a typed collection of PMS.Entities.HoatDongNgoaiGiangDay objects.</returns>
		/// <remarks></remarks>
		public TList<HoatDongNgoaiGiangDay> GetByMaNhom(TransactionManager transactionManager, System.String _maNhom)
		{
			int count = -1;
			return GetByMaNhom(transactionManager, _maNhom, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_HoatDongNgoaiGiangDay_NhomHoatDongNgoaiGiangDay key.
		///		FK_HoatDongNgoaiGiangDay_NhomHoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HoatDongNgoaiGiangDay objects.</returns>
		public TList<HoatDongNgoaiGiangDay> GetByMaNhom(TransactionManager transactionManager, System.String _maNhom, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhom(transactionManager, _maNhom, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HoatDongNgoaiGiangDay_NhomHoatDongNgoaiGiangDay key.
		///		fkHoatDongNgoaiGiangDayNhomHoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhom"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HoatDongNgoaiGiangDay objects.</returns>
		public TList<HoatDongNgoaiGiangDay> GetByMaNhom(System.String _maNhom, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaNhom(null, _maNhom, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HoatDongNgoaiGiangDay_NhomHoatDongNgoaiGiangDay key.
		///		fkHoatDongNgoaiGiangDayNhomHoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhom"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.HoatDongNgoaiGiangDay objects.</returns>
		public TList<HoatDongNgoaiGiangDay> GetByMaNhom(System.String _maNhom, int start, int pageLength,out int count)
		{
			return GetByMaNhom(null, _maNhom, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_HoatDongNgoaiGiangDay_NhomHoatDongNgoaiGiangDay key.
		///		FK_HoatDongNgoaiGiangDay_NhomHoatDongNgoaiGiangDay Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.HoatDongNgoaiGiangDay objects.</returns>
		public abstract TList<HoatDongNgoaiGiangDay> GetByMaNhom(TransactionManager transactionManager, System.String _maNhom, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.HoatDongNgoaiGiangDay Get(TransactionManager transactionManager, PMS.Entities.HoatDongNgoaiGiangDayKey key, int start, int pageLength)
		{
			return GetByMaQuanLy(transactionManager, key.MaQuanLy, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.HoatDongNgoaiGiangDay GetByMaQuanLy(System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.HoatDongNgoaiGiangDay GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.HoatDongNgoaiGiangDay GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.HoatDongNgoaiGiangDay GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoatDongNgoaiGiangDay"/> class.</returns>
		public PMS.Entities.HoatDongNgoaiGiangDay GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HoatDongNgoaiGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HoatDongNgoaiGiangDay"/> class.</returns>
		public abstract PMS.Entities.HoatDongNgoaiGiangDay GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HoatDongNgoaiGiangDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HoatDongNgoaiGiangDay&gt;"/></returns>
		public static TList<HoatDongNgoaiGiangDay> Fill(IDataReader reader, TList<HoatDongNgoaiGiangDay> rows, int start, int pageLength)
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
				
				PMS.Entities.HoatDongNgoaiGiangDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HoatDongNgoaiGiangDay")
					.Append("|").Append((System.Int32)reader[((int)HoatDongNgoaiGiangDayColumn.MaQuanLy - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HoatDongNgoaiGiangDay>(
					key.ToString(), // EntityTrackingKey
					"HoatDongNgoaiGiangDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HoatDongNgoaiGiangDay();
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
					c.MaQuanLy = (System.Int32)reader[(HoatDongNgoaiGiangDayColumn.MaQuanLy.ToString())];
					c.TenHoatDong = (reader[HoatDongNgoaiGiangDayColumn.TenHoatDong.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoatDongNgoaiGiangDayColumn.TenHoatDong.ToString())];
					c.MaDonViTinh = (reader[HoatDongNgoaiGiangDayColumn.MaDonViTinh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HoatDongNgoaiGiangDayColumn.MaDonViTinh.ToString())];
					c.SoLuong = (reader[HoatDongNgoaiGiangDayColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HoatDongNgoaiGiangDayColumn.SoLuong.ToString())];
					c.MucQuyDoi = (reader[HoatDongNgoaiGiangDayColumn.MucQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HoatDongNgoaiGiangDayColumn.MucQuyDoi.ToString())];
					c.DonGia = (reader[HoatDongNgoaiGiangDayColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HoatDongNgoaiGiangDayColumn.DonGia.ToString())];
					c.GhiChu = (reader[HoatDongNgoaiGiangDayColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoatDongNgoaiGiangDayColumn.GhiChu.ToString())];
					c.MaNhom = (reader[HoatDongNgoaiGiangDayColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoatDongNgoaiGiangDayColumn.MaNhom.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HoatDongNgoaiGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HoatDongNgoaiGiangDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HoatDongNgoaiGiangDay entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuanLy = (System.Int32)reader[(HoatDongNgoaiGiangDayColumn.MaQuanLy.ToString())];
			entity.TenHoatDong = (reader[HoatDongNgoaiGiangDayColumn.TenHoatDong.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoatDongNgoaiGiangDayColumn.TenHoatDong.ToString())];
			entity.MaDonViTinh = (reader[HoatDongNgoaiGiangDayColumn.MaDonViTinh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HoatDongNgoaiGiangDayColumn.MaDonViTinh.ToString())];
			entity.SoLuong = (reader[HoatDongNgoaiGiangDayColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HoatDongNgoaiGiangDayColumn.SoLuong.ToString())];
			entity.MucQuyDoi = (reader[HoatDongNgoaiGiangDayColumn.MucQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HoatDongNgoaiGiangDayColumn.MucQuyDoi.ToString())];
			entity.DonGia = (reader[HoatDongNgoaiGiangDayColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HoatDongNgoaiGiangDayColumn.DonGia.ToString())];
			entity.GhiChu = (reader[HoatDongNgoaiGiangDayColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoatDongNgoaiGiangDayColumn.GhiChu.ToString())];
			entity.MaNhom = (reader[HoatDongNgoaiGiangDayColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(HoatDongNgoaiGiangDayColumn.MaNhom.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HoatDongNgoaiGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HoatDongNgoaiGiangDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HoatDongNgoaiGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (System.Int32)dataRow["MaQuanLy"];
			entity.TenHoatDong = Convert.IsDBNull(dataRow["TenHoatDong"]) ? null : (System.String)dataRow["TenHoatDong"];
			entity.MaDonViTinh = Convert.IsDBNull(dataRow["MaDonViTinh"]) ? null : (System.Int32?)dataRow["MaDonViTinh"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Decimal?)dataRow["SoLuong"];
			entity.MucQuyDoi = Convert.IsDBNull(dataRow["MucQuyDoi"]) ? null : (System.Decimal?)dataRow["MucQuyDoi"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.MaNhom = Convert.IsDBNull(dataRow["MaNhom"]) ? null : (System.String)dataRow["MaNhom"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HoatDongNgoaiGiangDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HoatDongNgoaiGiangDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HoatDongNgoaiGiangDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaNhomSource	
			if (CanDeepLoad(entity, "NhomHoatDongNgoaiGiangDay|MaNhomSource", deepLoadType, innerList) 
				&& entity.MaNhomSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaNhom ?? string.Empty);
				NhomHoatDongNgoaiGiangDay tmpEntity = EntityManager.LocateEntity<NhomHoatDongNgoaiGiangDay>(EntityLocator.ConstructKeyFromPkItems(typeof(NhomHoatDongNgoaiGiangDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaNhomSource = tmpEntity;
				else
					entity.MaNhomSource = DataRepository.NhomHoatDongNgoaiGiangDayProvider.GetByMaNhom(transactionManager, (entity.MaNhom ?? string.Empty));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaNhomSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaNhomSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.NhomHoatDongNgoaiGiangDayProvider.DeepLoad(transactionManager, entity.MaNhomSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaNhomSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaQuanLy methods when available
			
			#region GiangVienHoatDongNgoaiGiangDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVienHoatDongNgoaiGiangDay>|GiangVienHoatDongNgoaiGiangDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienHoatDongNgoaiGiangDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienHoatDongNgoaiGiangDayCollection = DataRepository.GiangVienHoatDongNgoaiGiangDayProvider.GetByMaHoatDong(transactionManager, entity.MaQuanLy);

				if (deep && entity.GiangVienHoatDongNgoaiGiangDayCollection.Count > 0)
				{
					deepHandles.Add("GiangVienHoatDongNgoaiGiangDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVienHoatDongNgoaiGiangDay>) DataRepository.GiangVienHoatDongNgoaiGiangDayProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienHoatDongNgoaiGiangDayCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.HoatDongNgoaiGiangDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HoatDongNgoaiGiangDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HoatDongNgoaiGiangDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HoatDongNgoaiGiangDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaNhomSource
			if (CanDeepSave(entity, "NhomHoatDongNgoaiGiangDay|MaNhomSource", deepSaveType, innerList) 
				&& entity.MaNhomSource != null)
			{
				DataRepository.NhomHoatDongNgoaiGiangDayProvider.Save(transactionManager, entity.MaNhomSource);
				entity.MaNhom = entity.MaNhomSource.MaNhom;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GiangVienHoatDongNgoaiGiangDay>
				if (CanDeepSave(entity.GiangVienHoatDongNgoaiGiangDayCollection, "List<GiangVienHoatDongNgoaiGiangDay>|GiangVienHoatDongNgoaiGiangDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVienHoatDongNgoaiGiangDay child in entity.GiangVienHoatDongNgoaiGiangDayCollection)
					{
						if(child.MaHoatDongSource != null)
						{
							child.MaHoatDong = child.MaHoatDongSource.MaQuanLy;
						}
						else
						{
							child.MaHoatDong = entity.MaQuanLy;
						}

					}

					if (entity.GiangVienHoatDongNgoaiGiangDayCollection.Count > 0 || entity.GiangVienHoatDongNgoaiGiangDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienHoatDongNgoaiGiangDayProvider.Save(transactionManager, entity.GiangVienHoatDongNgoaiGiangDayCollection);
						
						deepHandles.Add("GiangVienHoatDongNgoaiGiangDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVienHoatDongNgoaiGiangDay >) DataRepository.GiangVienHoatDongNgoaiGiangDayProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienHoatDongNgoaiGiangDayCollection, deepSaveType, childTypes, innerList }
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
	
	#region HoatDongNgoaiGiangDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HoatDongNgoaiGiangDay</c>
	///</summary>
	public enum HoatDongNgoaiGiangDayChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>NhomHoatDongNgoaiGiangDay</c> at MaNhomSource
		///</summary>
		[ChildEntityType(typeof(NhomHoatDongNgoaiGiangDay))]
		NhomHoatDongNgoaiGiangDay,
		///<summary>
		/// Collection of <c>HoatDongNgoaiGiangDay</c> as OneToMany for GiangVienHoatDongNgoaiGiangDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVienHoatDongNgoaiGiangDay>))]
		GiangVienHoatDongNgoaiGiangDayCollection,
	}
	
	#endregion HoatDongNgoaiGiangDayChildEntityTypes
	
	#region HoatDongNgoaiGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HoatDongNgoaiGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoatDongNgoaiGiangDayFilterBuilder : SqlFilterBuilder<HoatDongNgoaiGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		public HoatDongNgoaiGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HoatDongNgoaiGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HoatDongNgoaiGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HoatDongNgoaiGiangDayFilterBuilder
	
	#region HoatDongNgoaiGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HoatDongNgoaiGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoatDongNgoaiGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<HoatDongNgoaiGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		public HoatDongNgoaiGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HoatDongNgoaiGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HoatDongNgoaiGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HoatDongNgoaiGiangDayParameterBuilder
	
	#region HoatDongNgoaiGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HoatDongNgoaiGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongNgoaiGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HoatDongNgoaiGiangDaySortBuilder : SqlSortBuilder<HoatDongNgoaiGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDaySqlSortBuilder class.
		/// </summary>
		public HoatDongNgoaiGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HoatDongNgoaiGiangDaySortBuilder
	
} // end namespace
