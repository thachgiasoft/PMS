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
	/// This class is the base class for any <see cref="DonViTinhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DonViTinhProviderBaseCore : EntityProviderBase<PMS.Entities.DonViTinh, PMS.Entities.DonViTinhKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DonViTinhKey key)
		{
			return Delete(transactionManager, key.MaDonVi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maDonVi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maDonVi)
		{
			return Delete(null, _maDonVi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonVi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maDonVi);		
		
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
		public override PMS.Entities.DonViTinh Get(TransactionManager transactionManager, PMS.Entities.DonViTinhKey key, int start, int pageLength)
		{
			return GetByMaDonVi(transactionManager, key.MaDonVi, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_DonViTinh index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonViTinh"/> class.</returns>
		public PMS.Entities.DonViTinh GetByMaQuanLy(System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_DonViTinh index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonViTinh"/> class.</returns>
		public PMS.Entities.DonViTinh GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_DonViTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonViTinh"/> class.</returns>
		public PMS.Entities.DonViTinh GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_DonViTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonViTinh"/> class.</returns>
		public PMS.Entities.DonViTinh GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_DonViTinh index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonViTinh"/> class.</returns>
		public PMS.Entities.DonViTinh GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_DonViTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonViTinh"/> class.</returns>
		public abstract PMS.Entities.DonViTinh GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DonViTinh index.
		/// </summary>
		/// <param name="_maDonVi"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonViTinh"/> class.</returns>
		public PMS.Entities.DonViTinh GetByMaDonVi(System.Int32 _maDonVi)
		{
			int count = -1;
			return GetByMaDonVi(null,_maDonVi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonViTinh index.
		/// </summary>
		/// <param name="_maDonVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonViTinh"/> class.</returns>
		public PMS.Entities.DonViTinh GetByMaDonVi(System.Int32 _maDonVi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDonVi(null, _maDonVi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonViTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonVi"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonViTinh"/> class.</returns>
		public PMS.Entities.DonViTinh GetByMaDonVi(TransactionManager transactionManager, System.Int32 _maDonVi)
		{
			int count = -1;
			return GetByMaDonVi(transactionManager, _maDonVi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonViTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonViTinh"/> class.</returns>
		public PMS.Entities.DonViTinh GetByMaDonVi(TransactionManager transactionManager, System.Int32 _maDonVi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDonVi(transactionManager, _maDonVi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonViTinh index.
		/// </summary>
		/// <param name="_maDonVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonViTinh"/> class.</returns>
		public PMS.Entities.DonViTinh GetByMaDonVi(System.Int32 _maDonVi, int start, int pageLength, out int count)
		{
			return GetByMaDonVi(null, _maDonVi, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DonViTinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DonViTinh"/> class.</returns>
		public abstract PMS.Entities.DonViTinh GetByMaDonVi(TransactionManager transactionManager, System.Int32 _maDonVi, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_DonViTinh_GetByLoaiKhoiLuong 
		
		/// <summary>
		///	This method wrap the 'cust_DonViTinh_GetByLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
			/// <param name="maDonViTinh"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByLoaiKhoiLuong(System.String maLoaiKhoiLuong, ref System.String maDonViTinh)
		{
			 GetByLoaiKhoiLuong(null, 0, int.MaxValue , maLoaiKhoiLuong, ref maDonViTinh);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonViTinh_GetByLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
			/// <param name="maDonViTinh"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByLoaiKhoiLuong(int start, int pageLength, System.String maLoaiKhoiLuong, ref System.String maDonViTinh)
		{
			 GetByLoaiKhoiLuong(null, start, pageLength , maLoaiKhoiLuong, ref maDonViTinh);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DonViTinh_GetByLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
			/// <param name="maDonViTinh"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByLoaiKhoiLuong(TransactionManager transactionManager, System.String maLoaiKhoiLuong, ref System.String maDonViTinh)
		{
			 GetByLoaiKhoiLuong(transactionManager, 0, int.MaxValue , maLoaiKhoiLuong, ref maDonViTinh);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DonViTinh_GetByLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
			/// <param name="maDonViTinh"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByLoaiKhoiLuong(TransactionManager transactionManager, int start, int pageLength , System.String maLoaiKhoiLuong, ref System.String maDonViTinh);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DonViTinh&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DonViTinh&gt;"/></returns>
		public static TList<DonViTinh> Fill(IDataReader reader, TList<DonViTinh> rows, int start, int pageLength)
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
				
				PMS.Entities.DonViTinh c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DonViTinh")
					.Append("|").Append((System.Int32)reader[((int)DonViTinhColumn.MaDonVi - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DonViTinh>(
					key.ToString(), // EntityTrackingKey
					"DonViTinh",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DonViTinh();
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
					c.MaDonVi = (System.Int32)reader[(DonViTinhColumn.MaDonVi.ToString())];
					c.MaQuanLy = (System.String)reader[(DonViTinhColumn.MaQuanLy.ToString())];
					c.TenDonVi = (reader[DonViTinhColumn.TenDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonViTinhColumn.TenDonVi.ToString())];
					c.ThuTu = (reader[DonViTinhColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonViTinhColumn.ThuTu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonViTinh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonViTinh"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DonViTinh entity)
		{
			if (!reader.Read()) return;
			
			entity.MaDonVi = (System.Int32)reader[(DonViTinhColumn.MaDonVi.ToString())];
			entity.MaQuanLy = (System.String)reader[(DonViTinhColumn.MaQuanLy.ToString())];
			entity.TenDonVi = (reader[DonViTinhColumn.TenDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DonViTinhColumn.TenDonVi.ToString())];
			entity.ThuTu = (reader[DonViTinhColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DonViTinhColumn.ThuTu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DonViTinh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DonViTinh"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DonViTinh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaDonVi = (System.Int32)dataRow["MaDonVi"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenDonVi = Convert.IsDBNull(dataRow["TenDonVi"]) ? null : (System.String)dataRow["TenDonVi"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DonViTinh"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DonViTinh Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DonViTinh entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaDonVi methods when available
			
			#region QuyDoiGioChuanCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<QuyDoiGioChuan>|QuyDoiGioChuanCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'QuyDoiGioChuanCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.QuyDoiGioChuanCollection = DataRepository.QuyDoiGioChuanProvider.GetByMaDonVi(transactionManager, entity.MaDonVi);

				if (deep && entity.QuyDoiGioChuanCollection.Count > 0)
				{
					deepHandles.Add("QuyDoiGioChuanCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<QuyDoiGioChuan>) DataRepository.QuyDoiGioChuanProvider.DeepLoad,
						new object[] { transactionManager, entity.QuyDoiGioChuanCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region KcqQuyDoiGioChuanCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<KcqQuyDoiGioChuan>|KcqQuyDoiGioChuanCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'KcqQuyDoiGioChuanCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.KcqQuyDoiGioChuanCollection = DataRepository.KcqQuyDoiGioChuanProvider.GetByMaDonVi(transactionManager, entity.MaDonVi);

				if (deep && entity.KcqQuyDoiGioChuanCollection.Count > 0)
				{
					deepHandles.Add("KcqQuyDoiGioChuanCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<KcqQuyDoiGioChuan>) DataRepository.KcqQuyDoiGioChuanProvider.DeepLoad,
						new object[] { transactionManager, entity.KcqQuyDoiGioChuanCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.DonViTinh object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DonViTinh instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DonViTinh Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DonViTinh entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<QuyDoiGioChuan>
				if (CanDeepSave(entity.QuyDoiGioChuanCollection, "List<QuyDoiGioChuan>|QuyDoiGioChuanCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(QuyDoiGioChuan child in entity.QuyDoiGioChuanCollection)
					{
						if(child.MaDonViSource != null)
						{
							child.MaDonVi = child.MaDonViSource.MaDonVi;
						}
						else
						{
							child.MaDonVi = entity.MaDonVi;
						}

					}

					if (entity.QuyDoiGioChuanCollection.Count > 0 || entity.QuyDoiGioChuanCollection.DeletedItems.Count > 0)
					{
						//DataRepository.QuyDoiGioChuanProvider.Save(transactionManager, entity.QuyDoiGioChuanCollection);
						
						deepHandles.Add("QuyDoiGioChuanCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< QuyDoiGioChuan >) DataRepository.QuyDoiGioChuanProvider.DeepSave,
							new object[] { transactionManager, entity.QuyDoiGioChuanCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<KcqQuyDoiGioChuan>
				if (CanDeepSave(entity.KcqQuyDoiGioChuanCollection, "List<KcqQuyDoiGioChuan>|KcqQuyDoiGioChuanCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(KcqQuyDoiGioChuan child in entity.KcqQuyDoiGioChuanCollection)
					{
						if(child.MaDonViSource != null)
						{
							child.MaDonVi = child.MaDonViSource.MaDonVi;
						}
						else
						{
							child.MaDonVi = entity.MaDonVi;
						}

					}

					if (entity.KcqQuyDoiGioChuanCollection.Count > 0 || entity.KcqQuyDoiGioChuanCollection.DeletedItems.Count > 0)
					{
						//DataRepository.KcqQuyDoiGioChuanProvider.Save(transactionManager, entity.KcqQuyDoiGioChuanCollection);
						
						deepHandles.Add("KcqQuyDoiGioChuanCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< KcqQuyDoiGioChuan >) DataRepository.KcqQuyDoiGioChuanProvider.DeepSave,
							new object[] { transactionManager, entity.KcqQuyDoiGioChuanCollection, deepSaveType, childTypes, innerList }
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
	
	#region DonViTinhChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DonViTinh</c>
	///</summary>
	public enum DonViTinhChildEntityTypes
	{
		///<summary>
		/// Collection of <c>DonViTinh</c> as OneToMany for QuyDoiGioChuanCollection
		///</summary>
		[ChildEntityType(typeof(TList<QuyDoiGioChuan>))]
		QuyDoiGioChuanCollection,
		///<summary>
		/// Collection of <c>DonViTinh</c> as OneToMany for KcqQuyDoiGioChuanCollection
		///</summary>
		[ChildEntityType(typeof(TList<KcqQuyDoiGioChuan>))]
		KcqQuyDoiGioChuanCollection,
	}
	
	#endregion DonViTinhChildEntityTypes
	
	#region DonViTinhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DonViTinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonViTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonViTinhFilterBuilder : SqlFilterBuilder<DonViTinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonViTinhFilterBuilder class.
		/// </summary>
		public DonViTinhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonViTinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonViTinhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonViTinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonViTinhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonViTinhFilterBuilder
	
	#region DonViTinhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DonViTinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonViTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonViTinhParameterBuilder : ParameterizedSqlFilterBuilder<DonViTinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonViTinhParameterBuilder class.
		/// </summary>
		public DonViTinhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DonViTinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DonViTinhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DonViTinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DonViTinhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DonViTinhParameterBuilder
	
	#region DonViTinhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DonViTinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonViTinh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DonViTinhSortBuilder : SqlSortBuilder<DonViTinhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonViTinhSqlSortBuilder class.
		/// </summary>
		public DonViTinhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DonViTinhSortBuilder
	
} // end namespace
