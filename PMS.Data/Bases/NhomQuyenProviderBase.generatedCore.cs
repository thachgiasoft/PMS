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
	/// This class is the base class for any <see cref="NhomQuyenProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class NhomQuyenProviderBaseCore : EntityProviderBase<PMS.Entities.NhomQuyen, PMS.Entities.NhomQuyenKey>
	{		
		#region Get from Many To Many Relationship Functions
		#region GetByMaChucNangFromNhomChucNang
		
		/// <summary>
		///		Gets NhomQuyen objects from the datasource by MaChucNang in the
		///		NhomChucNang table. Table NhomQuyen is related to table ChucNang
		///		through the (M:N) relationship defined in the NhomChucNang table.
		/// </summary>
		/// <param name="_maChucNang"></param>
		/// <returns>Returns a typed collection of NhomQuyen objects.</returns>
		public TList<NhomQuyen> GetByMaChucNangFromNhomChucNang(System.Int32 _maChucNang)
		{
			int count = -1;
			return GetByMaChucNangFromNhomChucNang(null,_maChucNang, 0, int.MaxValue, out count);
			
		}
		
		/// <summary>
		///		Gets PMS.Entities.NhomQuyen objects from the datasource by MaChucNang in the
		///		NhomChucNang table. Table NhomQuyen is related to table ChucNang
		///		through the (M:N) relationship defined in the NhomChucNang table.
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maChucNang"></param>
		/// <remarks></remarks>
		/// <returns>Returns a TList of NhomQuyen objects.</returns>
		public TList<NhomQuyen> GetByMaChucNangFromNhomChucNang(System.Int32 _maChucNang, int start, int pageLength)
		{
			int count = -1;
			return GetByMaChucNangFromNhomChucNang(null, _maChucNang, start, pageLength, out count);
		}
		
		/// <summary>
		///		Gets NhomQuyen objects from the datasource by MaChucNang in the
		///		NhomChucNang table. Table NhomQuyen is related to table ChucNang
		///		through the (M:N) relationship defined in the NhomChucNang table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucNang"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of NhomQuyen objects.</returns>
		public TList<NhomQuyen> GetByMaChucNangFromNhomChucNang(TransactionManager transactionManager, System.Int32 _maChucNang)
		{
			int count = -1;
			return GetByMaChucNangFromNhomChucNang(transactionManager, _maChucNang, 0, int.MaxValue, out count);
		}
		
		
		/// <summary>
		///		Gets NhomQuyen objects from the datasource by MaChucNang in the
		///		NhomChucNang table. Table NhomQuyen is related to table ChucNang
		///		through the (M:N) relationship defined in the NhomChucNang table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maChucNang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of NhomQuyen objects.</returns>
		public TList<NhomQuyen> GetByMaChucNangFromNhomChucNang(TransactionManager transactionManager, System.Int32 _maChucNang,int start, int pageLength)
		{
			int count = -1;
			return GetByMaChucNangFromNhomChucNang(transactionManager, _maChucNang, start, pageLength, out count);
		}
		
		/// <summary>
		///		Gets NhomQuyen objects from the datasource by MaChucNang in the
		///		NhomChucNang table. Table NhomQuyen is related to table ChucNang
		///		through the (M:N) relationship defined in the NhomChucNang table.
		/// </summary>
		/// <param name="_maChucNang"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of NhomQuyen objects.</returns>
		public TList<NhomQuyen> GetByMaChucNangFromNhomChucNang(System.Int32 _maChucNang,int start, int pageLength, out int count)
		{
			
			return GetByMaChucNangFromNhomChucNang(null, _maChucNang, start, pageLength, out count);
		}


		/// <summary>
		///		Gets NhomQuyen objects from the datasource by MaChucNang in the
		///		NhomChucNang table. Table NhomQuyen is related to table ChucNang
		///		through the (M:N) relationship defined in the NhomChucNang table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <param name="_maChucNang"></param>
		/// <remarks></remarks>
		/// <returns>Returns a TList of NhomQuyen objects.</returns>
		public abstract TList<NhomQuyen> GetByMaChucNangFromNhomChucNang(TransactionManager transactionManager,System.Int32 _maChucNang, int start, int pageLength, out int count);
		
		#endregion GetByMaChucNangFromNhomChucNang
		
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.NhomQuyenKey key)
		{
			return Delete(transactionManager, key.MaNhomQuyen);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maNhomQuyen">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maNhomQuyen)
		{
			return Delete(null, _maNhomQuyen);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomQuyen">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maNhomQuyen);		
		
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
		public override PMS.Entities.NhomQuyen Get(TransactionManager transactionManager, PMS.Entities.NhomQuyenKey key, int start, int pageLength)
		{
			return GetByMaNhomQuyen(transactionManager, key.MaNhomQuyen, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_UserGroup index.
		/// </summary>
		/// <param name="_maNhomQuyen"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomQuyen"/> class.</returns>
		public PMS.Entities.NhomQuyen GetByMaNhomQuyen(System.Int32 _maNhomQuyen)
		{
			int count = -1;
			return GetByMaNhomQuyen(null,_maNhomQuyen, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_UserGroup index.
		/// </summary>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomQuyen"/> class.</returns>
		public PMS.Entities.NhomQuyen GetByMaNhomQuyen(System.Int32 _maNhomQuyen, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomQuyen(null, _maNhomQuyen, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_UserGroup index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomQuyen"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomQuyen"/> class.</returns>
		public PMS.Entities.NhomQuyen GetByMaNhomQuyen(TransactionManager transactionManager, System.Int32 _maNhomQuyen)
		{
			int count = -1;
			return GetByMaNhomQuyen(transactionManager, _maNhomQuyen, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_UserGroup index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomQuyen"/> class.</returns>
		public PMS.Entities.NhomQuyen GetByMaNhomQuyen(TransactionManager transactionManager, System.Int32 _maNhomQuyen, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomQuyen(transactionManager, _maNhomQuyen, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_UserGroup index.
		/// </summary>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomQuyen"/> class.</returns>
		public PMS.Entities.NhomQuyen GetByMaNhomQuyen(System.Int32 _maNhomQuyen, int start, int pageLength, out int count)
		{
			return GetByMaNhomQuyen(null, _maNhomQuyen, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_UserGroup index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.NhomQuyen"/> class.</returns>
		public abstract PMS.Entities.NhomQuyen GetByMaNhomQuyen(TransactionManager transactionManager, System.Int32 _maNhomQuyen, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_NhomQuyen_GetByNhomQuyenQL 
		
		/// <summary>
		///	This method wrap the 'cust_NhomQuyen_GetByNhomQuyenQL' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NhomQuyen&gt;"/> instance.</returns>
		public TList<NhomQuyen> GetByNhomQuyenQL(System.Int32 maNhomQuyen)
		{
			return GetByNhomQuyenQL(null, 0, int.MaxValue , maNhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_NhomQuyen_GetByNhomQuyenQL' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NhomQuyen&gt;"/> instance.</returns>
		public TList<NhomQuyen> GetByNhomQuyenQL(int start, int pageLength, System.Int32 maNhomQuyen)
		{
			return GetByNhomQuyenQL(null, start, pageLength , maNhomQuyen);
		}
				
		/// <summary>
		///	This method wrap the 'cust_NhomQuyen_GetByNhomQuyenQL' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NhomQuyen&gt;"/> instance.</returns>
		public TList<NhomQuyen> GetByNhomQuyenQL(TransactionManager transactionManager, System.Int32 maNhomQuyen)
		{
			return GetByNhomQuyenQL(transactionManager, 0, int.MaxValue , maNhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_NhomQuyen_GetByNhomQuyenQL' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;NhomQuyen&gt;"/> instance.</returns>
		public abstract TList<NhomQuyen> GetByNhomQuyenQL(TransactionManager transactionManager, int start, int pageLength , System.Int32 maNhomQuyen);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;NhomQuyen&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;NhomQuyen&gt;"/></returns>
		public static TList<NhomQuyen> Fill(IDataReader reader, TList<NhomQuyen> rows, int start, int pageLength)
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
				
				PMS.Entities.NhomQuyen c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("NhomQuyen")
					.Append("|").Append((System.Int32)reader[((int)NhomQuyenColumn.MaNhomQuyen - 1)]).ToString();
					c = EntityManager.LocateOrCreate<NhomQuyen>(
					key.ToString(), // EntityTrackingKey
					"NhomQuyen",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.NhomQuyen();
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
					c.MaNhomQuyen = (System.Int32)reader[(NhomQuyenColumn.MaNhomQuyen.ToString())];
					c.TenNhomQuyen = (reader[NhomQuyenColumn.TenNhomQuyen.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomQuyenColumn.TenNhomQuyen.ToString())];
					c.GhiChu = (reader[NhomQuyenColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomQuyenColumn.GhiChu.ToString())];
					c.QlNhomQuyen = (reader[NhomQuyenColumn.QlNhomQuyen.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomQuyenColumn.QlNhomQuyen.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomQuyen"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomQuyen"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.NhomQuyen entity)
		{
			if (!reader.Read()) return;
			
			entity.MaNhomQuyen = (System.Int32)reader[(NhomQuyenColumn.MaNhomQuyen.ToString())];
			entity.TenNhomQuyen = (reader[NhomQuyenColumn.TenNhomQuyen.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomQuyenColumn.TenNhomQuyen.ToString())];
			entity.GhiChu = (reader[NhomQuyenColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomQuyenColumn.GhiChu.ToString())];
			entity.QlNhomQuyen = (reader[NhomQuyenColumn.QlNhomQuyen.ToString()] == DBNull.Value) ? null : (System.String)reader[(NhomQuyenColumn.QlNhomQuyen.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.NhomQuyen"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.NhomQuyen"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.NhomQuyen entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaNhomQuyen = (System.Int32)dataRow["MaNhomQuyen"];
			entity.TenNhomQuyen = Convert.IsDBNull(dataRow["TenNhomQuyen"]) ? null : (System.String)dataRow["TenNhomQuyen"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.QlNhomQuyen = Convert.IsDBNull(dataRow["QLNhomQuyen"]) ? null : (System.String)dataRow["QLNhomQuyen"];
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
		/// <param name="entity">The <see cref="PMS.Entities.NhomQuyen"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.NhomQuyen Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.NhomQuyen entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaNhomQuyen methods when available
			
			#region MaChucNangChucNangCollection_From_NhomChucNang
			// RelationshipType.ManyToMany
			if (CanDeepLoad(entity, "List<ChucNang>|MaChucNangChucNangCollection_From_NhomChucNang", deepLoadType, innerList))
			{
				entity.MaChucNangChucNangCollection_From_NhomChucNang = DataRepository.ChucNangProvider.GetByMaNhomQuyenFromNhomChucNang(transactionManager, entity.MaNhomQuyen);			 
		
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaChucNangChucNangCollection_From_NhomChucNang' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaChucNangChucNangCollection_From_NhomChucNang != null)
				{
					deepHandles.Add("MaChucNangChucNangCollection_From_NhomChucNang",
						new KeyValuePair<Delegate, object>((DeepLoadHandle< ChucNang >) DataRepository.ChucNangProvider.DeepLoad,
						new object[] { transactionManager, entity.MaChucNangChucNangCollection_From_NhomChucNang, deep, deepLoadType, childTypes, innerList }
					));
				}
			}
			#endregion
			
			
			
			#region NhomChucNangCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<NhomChucNang>|NhomChucNangCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'NhomChucNangCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.NhomChucNangCollection = DataRepository.NhomChucNangProvider.GetByMaNhomQuyen(transactionManager, entity.MaNhomQuyen);

				if (deep && entity.NhomChucNangCollection.Count > 0)
				{
					deepHandles.Add("NhomChucNangCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<NhomChucNang>) DataRepository.NhomChucNangProvider.DeepLoad,
						new object[] { transactionManager, entity.NhomChucNangCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TaiKhoanCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TaiKhoan>|TaiKhoanCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TaiKhoanCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TaiKhoanCollection = DataRepository.TaiKhoanProvider.GetByMaNhomQuyen(transactionManager, entity.MaNhomQuyen);

				if (deep && entity.TaiKhoanCollection.Count > 0)
				{
					deepHandles.Add("TaiKhoanCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TaiKhoan>) DataRepository.TaiKhoanProvider.DeepLoad,
						new object[] { transactionManager, entity.TaiKhoanCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.NhomQuyen object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.NhomQuyen instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.NhomQuyen Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.NhomQuyen entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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

			#region MaChucNangChucNangCollection_From_NhomChucNang>
			if (CanDeepSave(entity.MaChucNangChucNangCollection_From_NhomChucNang, "List<ChucNang>|MaChucNangChucNangCollection_From_NhomChucNang", deepSaveType, innerList))
			{
				if (entity.MaChucNangChucNangCollection_From_NhomChucNang.Count > 0 || entity.MaChucNangChucNangCollection_From_NhomChucNang.DeletedItems.Count > 0)
				{
					DataRepository.ChucNangProvider.Save(transactionManager, entity.MaChucNangChucNangCollection_From_NhomChucNang); 
					deepHandles.Add("MaChucNangChucNangCollection_From_NhomChucNang",
						new KeyValuePair<Delegate, object>((DeepSaveHandle<ChucNang>) DataRepository.ChucNangProvider.DeepSave,
						new object[] { transactionManager, entity.MaChucNangChucNangCollection_From_NhomChucNang, deepSaveType, childTypes, innerList }
					));
				}
			}
			#endregion 
	
			#region List<NhomChucNang>
				if (CanDeepSave(entity.NhomChucNangCollection, "List<NhomChucNang>|NhomChucNangCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(NhomChucNang child in entity.NhomChucNangCollection)
					{
						if(child.MaNhomQuyenSource != null)
						{
								child.MaNhomQuyen = child.MaNhomQuyenSource.MaNhomQuyen;
						}

						if(child.MaChucNangSource != null)
						{
								child.MaChucNang = child.MaChucNangSource.Id;
						}

					}

					if (entity.NhomChucNangCollection.Count > 0 || entity.NhomChucNangCollection.DeletedItems.Count > 0)
					{
						//DataRepository.NhomChucNangProvider.Save(transactionManager, entity.NhomChucNangCollection);
						
						deepHandles.Add("NhomChucNangCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< NhomChucNang >) DataRepository.NhomChucNangProvider.DeepSave,
							new object[] { transactionManager, entity.NhomChucNangCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TaiKhoan>
				if (CanDeepSave(entity.TaiKhoanCollection, "List<TaiKhoan>|TaiKhoanCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TaiKhoan child in entity.TaiKhoanCollection)
					{
						if(child.MaNhomQuyenSource != null)
						{
							child.MaNhomQuyen = child.MaNhomQuyenSource.MaNhomQuyen;
						}
						else
						{
							child.MaNhomQuyen = entity.MaNhomQuyen;
						}

					}

					if (entity.TaiKhoanCollection.Count > 0 || entity.TaiKhoanCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TaiKhoanProvider.Save(transactionManager, entity.TaiKhoanCollection);
						
						deepHandles.Add("TaiKhoanCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TaiKhoan >) DataRepository.TaiKhoanProvider.DeepSave,
							new object[] { transactionManager, entity.TaiKhoanCollection, deepSaveType, childTypes, innerList }
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
	
	#region NhomQuyenChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.NhomQuyen</c>
	///</summary>
	public enum NhomQuyenChildEntityTypes
	{
		///<summary>
		/// Collection of <c>NhomQuyen</c> as ManyToMany for ChucNangCollection_From_NhomChucNang
		///</summary>
		[ChildEntityType(typeof(TList<ChucNang>))]
		MaChucNangChucNangCollection_From_NhomChucNang,
		///<summary>
		/// Collection of <c>NhomQuyen</c> as OneToMany for NhomChucNangCollection
		///</summary>
		[ChildEntityType(typeof(TList<NhomChucNang>))]
		NhomChucNangCollection,
		///<summary>
		/// Collection of <c>NhomQuyen</c> as OneToMany for TaiKhoanCollection
		///</summary>
		[ChildEntityType(typeof(TList<TaiKhoan>))]
		TaiKhoanCollection,
	}
	
	#endregion NhomQuyenChildEntityTypes
	
	#region NhomQuyenFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;NhomQuyenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomQuyen"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomQuyenFilterBuilder : SqlFilterBuilder<NhomQuyenColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomQuyenFilterBuilder class.
		/// </summary>
		public NhomQuyenFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomQuyenFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomQuyenFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomQuyenFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomQuyenFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomQuyenFilterBuilder
	
	#region NhomQuyenParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;NhomQuyenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomQuyen"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomQuyenParameterBuilder : ParameterizedSqlFilterBuilder<NhomQuyenColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomQuyenParameterBuilder class.
		/// </summary>
		public NhomQuyenParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NhomQuyenParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NhomQuyenParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NhomQuyenParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NhomQuyenParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NhomQuyenParameterBuilder
	
	#region NhomQuyenSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;NhomQuyenColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomQuyen"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class NhomQuyenSortBuilder : SqlSortBuilder<NhomQuyenColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomQuyenSqlSortBuilder class.
		/// </summary>
		public NhomQuyenSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion NhomQuyenSortBuilder
	
} // end namespace
