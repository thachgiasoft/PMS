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
	/// This class is the base class for any <see cref="LopHocPhanGiangBangTiengNuocNgoaiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LopHocPhanGiangBangTiengNuocNgoaiProviderBaseCore : EntityProviderBase<PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai, PMS.Entities.LopHocPhanGiangBangTiengNuocNgoaiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.LopHocPhanGiangBangTiengNuocNgoaiKey key)
		{
			return Delete(transactionManager, key.MaLopHocPhan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maLopHocPhan)
		{
			return Delete(null, _maLopHocPhan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maLopHocPhan);		
		
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
		public override PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai Get(TransactionManager transactionManager, PMS.Entities.LopHocPhanGiangBangTiengNuocNgoaiKey key, int start, int pageLength)
		{
			return GetByMaLopHocPhan(transactionManager, key.MaLopHocPhan, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_LopHocPhanGiangBangTiengNuocNgoai index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai"/> class.</returns>
		public PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai GetByMaLopHocPhan(System.String _maLopHocPhan)
		{
			int count = -1;
			return GetByMaLopHocPhan(null,_maLopHocPhan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanGiangBangTiengNuocNgoai index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai"/> class.</returns>
		public PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai GetByMaLopHocPhan(System.String _maLopHocPhan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhan(null, _maLopHocPhan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanGiangBangTiengNuocNgoai index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai"/> class.</returns>
		public PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai GetByMaLopHocPhan(TransactionManager transactionManager, System.String _maLopHocPhan)
		{
			int count = -1;
			return GetByMaLopHocPhan(transactionManager, _maLopHocPhan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanGiangBangTiengNuocNgoai index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai"/> class.</returns>
		public PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai GetByMaLopHocPhan(TransactionManager transactionManager, System.String _maLopHocPhan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhan(transactionManager, _maLopHocPhan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanGiangBangTiengNuocNgoai index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai"/> class.</returns>
		public PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai GetByMaLopHocPhan(System.String _maLopHocPhan, int start, int pageLength, out int count)
		{
			return GetByMaLopHocPhan(null, _maLopHocPhan, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanGiangBangTiengNuocNgoai index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai"/> class.</returns>
		public abstract PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai GetByMaLopHocPhan(TransactionManager transactionManager, System.String _maLopHocPhan, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_LopHocPhanGiangBangTiengNuocNgoai_Luu_BUH 
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGiangBangTiengNuocNgoai_Luu_BUH' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu_BUH(System.String xmlData, ref System.Int32 reVal)
		{
			 Luu_BUH(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGiangBangTiengNuocNgoai_Luu_BUH' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu_BUH(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 Luu_BUH(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGiangBangTiengNuocNgoai_Luu_BUH' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu_BUH(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 Luu_BUH(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGiangBangTiengNuocNgoai_Luu_BUH' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu_BUH(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_LopHocPhanGiangBangTiengNuocNgoai_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGiangBangTiengNuocNgoai_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String maDonVi, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGiangBangTiengNuocNgoai_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String maDonVi, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, maDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGiangBangTiengNuocNgoai_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String maDonVi, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanGiangBangTiengNuocNgoai_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String maDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LopHocPhanGiangBangTiengNuocNgoai&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LopHocPhanGiangBangTiengNuocNgoai&gt;"/></returns>
		public static TList<LopHocPhanGiangBangTiengNuocNgoai> Fill(IDataReader reader, TList<LopHocPhanGiangBangTiengNuocNgoai> rows, int start, int pageLength)
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
				
				PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LopHocPhanGiangBangTiengNuocNgoai")
					.Append("|").Append((System.String)reader[((int)LopHocPhanGiangBangTiengNuocNgoaiColumn.MaLopHocPhan - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LopHocPhanGiangBangTiengNuocNgoai>(
					key.ToString(), // EntityTrackingKey
					"LopHocPhanGiangBangTiengNuocNgoai",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai();
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
					c.MaLopHocPhan = (System.String)reader[(LopHocPhanGiangBangTiengNuocNgoaiColumn.MaLopHocPhan.ToString())];
					c.OriginalMaLopHocPhan = c.MaLopHocPhan;
					c.Chon = (reader[LopHocPhanGiangBangTiengNuocNgoaiColumn.Chon.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(LopHocPhanGiangBangTiengNuocNgoaiColumn.Chon.ToString())];
					c.NamHoc = (reader[LopHocPhanGiangBangTiengNuocNgoaiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGiangBangTiengNuocNgoaiColumn.NamHoc.ToString())];
					c.HocKy = (reader[LopHocPhanGiangBangTiengNuocNgoaiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGiangBangTiengNuocNgoaiColumn.HocKy.ToString())];
					c.NgonNgu = (reader[LopHocPhanGiangBangTiengNuocNgoaiColumn.NgonNgu.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGiangBangTiengNuocNgoaiColumn.NgonNgu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLopHocPhan = (System.String)reader[(LopHocPhanGiangBangTiengNuocNgoaiColumn.MaLopHocPhan.ToString())];
			entity.OriginalMaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			entity.Chon = (reader[LopHocPhanGiangBangTiengNuocNgoaiColumn.Chon.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(LopHocPhanGiangBangTiengNuocNgoaiColumn.Chon.ToString())];
			entity.NamHoc = (reader[LopHocPhanGiangBangTiengNuocNgoaiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGiangBangTiengNuocNgoaiColumn.NamHoc.ToString())];
			entity.HocKy = (reader[LopHocPhanGiangBangTiengNuocNgoaiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGiangBangTiengNuocNgoaiColumn.HocKy.ToString())];
			entity.NgonNgu = (reader[LopHocPhanGiangBangTiengNuocNgoaiColumn.NgonNgu.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanGiangBangTiengNuocNgoaiColumn.NgonNgu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.OriginalMaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.Chon = Convert.IsDBNull(dataRow["Chon"]) ? null : (System.Boolean?)dataRow["Chon"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.NgonNgu = Convert.IsDBNull(dataRow["NgonNgu"]) ? null : (System.String)dataRow["NgonNgu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
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
		/// Deep Save the entire object graph of the PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region LopHocPhanGiangBangTiengNuocNgoaiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.LopHocPhanGiangBangTiengNuocNgoai</c>
	///</summary>
	public enum LopHocPhanGiangBangTiengNuocNgoaiChildEntityTypes
	{
	}
	
	#endregion LopHocPhanGiangBangTiengNuocNgoaiChildEntityTypes
	
	#region LopHocPhanGiangBangTiengNuocNgoaiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LopHocPhanGiangBangTiengNuocNgoaiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanGiangBangTiengNuocNgoai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanGiangBangTiengNuocNgoaiFilterBuilder : SqlFilterBuilder<LopHocPhanGiangBangTiengNuocNgoaiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGiangBangTiengNuocNgoaiFilterBuilder class.
		/// </summary>
		public LopHocPhanGiangBangTiengNuocNgoaiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGiangBangTiengNuocNgoaiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LopHocPhanGiangBangTiengNuocNgoaiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGiangBangTiengNuocNgoaiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LopHocPhanGiangBangTiengNuocNgoaiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LopHocPhanGiangBangTiengNuocNgoaiFilterBuilder
	
	#region LopHocPhanGiangBangTiengNuocNgoaiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LopHocPhanGiangBangTiengNuocNgoaiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanGiangBangTiengNuocNgoai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanGiangBangTiengNuocNgoaiParameterBuilder : ParameterizedSqlFilterBuilder<LopHocPhanGiangBangTiengNuocNgoaiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGiangBangTiengNuocNgoaiParameterBuilder class.
		/// </summary>
		public LopHocPhanGiangBangTiengNuocNgoaiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGiangBangTiengNuocNgoaiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LopHocPhanGiangBangTiengNuocNgoaiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGiangBangTiengNuocNgoaiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LopHocPhanGiangBangTiengNuocNgoaiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LopHocPhanGiangBangTiengNuocNgoaiParameterBuilder
	
	#region LopHocPhanGiangBangTiengNuocNgoaiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LopHocPhanGiangBangTiengNuocNgoaiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanGiangBangTiengNuocNgoai"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LopHocPhanGiangBangTiengNuocNgoaiSortBuilder : SqlSortBuilder<LopHocPhanGiangBangTiengNuocNgoaiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanGiangBangTiengNuocNgoaiSqlSortBuilder class.
		/// </summary>
		public LopHocPhanGiangBangTiengNuocNgoaiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LopHocPhanGiangBangTiengNuocNgoaiSortBuilder
	
} // end namespace
