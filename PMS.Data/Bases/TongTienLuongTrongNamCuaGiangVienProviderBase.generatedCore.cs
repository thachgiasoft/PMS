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
	/// This class is the base class for any <see cref="TongTienLuongTrongNamCuaGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TongTienLuongTrongNamCuaGiangVienProviderBaseCore : EntityProviderBase<PMS.Entities.TongTienLuongTrongNamCuaGiangVien, PMS.Entities.TongTienLuongTrongNamCuaGiangVienKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.TongTienLuongTrongNamCuaGiangVienKey key)
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
		public override PMS.Entities.TongTienLuongTrongNamCuaGiangVien Get(TransactionManager transactionManager, PMS.Entities.TongTienLuongTrongNamCuaGiangVienKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_TongTienLuongTrongNamCuaGiangVien index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TongTienLuongTrongNamCuaGiangVien"/> class.</returns>
		public PMS.Entities.TongTienLuongTrongNamCuaGiangVien GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TongTienLuongTrongNamCuaGiangVien index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TongTienLuongTrongNamCuaGiangVien"/> class.</returns>
		public PMS.Entities.TongTienLuongTrongNamCuaGiangVien GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TongTienLuongTrongNamCuaGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TongTienLuongTrongNamCuaGiangVien"/> class.</returns>
		public PMS.Entities.TongTienLuongTrongNamCuaGiangVien GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TongTienLuongTrongNamCuaGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TongTienLuongTrongNamCuaGiangVien"/> class.</returns>
		public PMS.Entities.TongTienLuongTrongNamCuaGiangVien GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TongTienLuongTrongNamCuaGiangVien index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TongTienLuongTrongNamCuaGiangVien"/> class.</returns>
		public PMS.Entities.TongTienLuongTrongNamCuaGiangVien GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TongTienLuongTrongNamCuaGiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TongTienLuongTrongNamCuaGiangVien"/> class.</returns>
		public abstract PMS.Entities.TongTienLuongTrongNamCuaGiangVien GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_TongTienLuongTrongNamCuaGiangVien_GetByNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_TongTienLuongTrongNamCuaGiangVien_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHoc(System.String namHoc)
		{
			return GetByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TongTienLuongTrongNamCuaGiangVien_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return GetByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TongTienLuongTrongNamCuaGiangVien_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return GetByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TongTienLuongTrongNamCuaGiangVien_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_TongTienLuongTrongNamCuaGiangVien_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_TongTienLuongTrongNamCuaGiangVien_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TongTienLuongTrongNamCuaGiangVien_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TongTienLuongTrongNamCuaGiangVien_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TongTienLuongTrongNamCuaGiangVien_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TongTienLuongTrongNamCuaGiangVien&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TongTienLuongTrongNamCuaGiangVien&gt;"/></returns>
		public static TList<TongTienLuongTrongNamCuaGiangVien> Fill(IDataReader reader, TList<TongTienLuongTrongNamCuaGiangVien> rows, int start, int pageLength)
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
				
				PMS.Entities.TongTienLuongTrongNamCuaGiangVien c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TongTienLuongTrongNamCuaGiangVien")
					.Append("|").Append((System.Int32)reader[((int)TongTienLuongTrongNamCuaGiangVienColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<TongTienLuongTrongNamCuaGiangVien>(
					key.ToString(), // EntityTrackingKey
					"TongTienLuongTrongNamCuaGiangVien",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.TongTienLuongTrongNamCuaGiangVien();
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
					c.Id = (System.Int32)reader[(TongTienLuongTrongNamCuaGiangVienColumn.Id.ToString())];
					c.NamHoc = (reader[TongTienLuongTrongNamCuaGiangVienColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TongTienLuongTrongNamCuaGiangVienColumn.NamHoc.ToString())];
					c.MaGiangVien = (reader[TongTienLuongTrongNamCuaGiangVienColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TongTienLuongTrongNamCuaGiangVienColumn.MaGiangVien.ToString())];
					c.TongTienLuong = (reader[TongTienLuongTrongNamCuaGiangVienColumn.TongTienLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TongTienLuongTrongNamCuaGiangVienColumn.TongTienLuong.ToString())];
					c.NgayCapNhat = (reader[TongTienLuongTrongNamCuaGiangVienColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(TongTienLuongTrongNamCuaGiangVienColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[TongTienLuongTrongNamCuaGiangVienColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(TongTienLuongTrongNamCuaGiangVienColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TongTienLuongTrongNamCuaGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TongTienLuongTrongNamCuaGiangVien"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.TongTienLuongTrongNamCuaGiangVien entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(TongTienLuongTrongNamCuaGiangVienColumn.Id.ToString())];
			entity.NamHoc = (reader[TongTienLuongTrongNamCuaGiangVienColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(TongTienLuongTrongNamCuaGiangVienColumn.NamHoc.ToString())];
			entity.MaGiangVien = (reader[TongTienLuongTrongNamCuaGiangVienColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TongTienLuongTrongNamCuaGiangVienColumn.MaGiangVien.ToString())];
			entity.TongTienLuong = (reader[TongTienLuongTrongNamCuaGiangVienColumn.TongTienLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(TongTienLuongTrongNamCuaGiangVienColumn.TongTienLuong.ToString())];
			entity.NgayCapNhat = (reader[TongTienLuongTrongNamCuaGiangVienColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(TongTienLuongTrongNamCuaGiangVienColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[TongTienLuongTrongNamCuaGiangVienColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(TongTienLuongTrongNamCuaGiangVienColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TongTienLuongTrongNamCuaGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TongTienLuongTrongNamCuaGiangVien"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.TongTienLuongTrongNamCuaGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.TongTienLuong = Convert.IsDBNull(dataRow["TongTienLuong"]) ? null : (System.Decimal?)dataRow["TongTienLuong"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.TongTienLuongTrongNamCuaGiangVien"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.TongTienLuongTrongNamCuaGiangVien Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.TongTienLuongTrongNamCuaGiangVien entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.TongTienLuongTrongNamCuaGiangVien object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.TongTienLuongTrongNamCuaGiangVien instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.TongTienLuongTrongNamCuaGiangVien Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.TongTienLuongTrongNamCuaGiangVien entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region TongTienLuongTrongNamCuaGiangVienChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.TongTienLuongTrongNamCuaGiangVien</c>
	///</summary>
	public enum TongTienLuongTrongNamCuaGiangVienChildEntityTypes
	{
	}
	
	#endregion TongTienLuongTrongNamCuaGiangVienChildEntityTypes
	
	#region TongTienLuongTrongNamCuaGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TongTienLuongTrongNamCuaGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TongTienLuongTrongNamCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TongTienLuongTrongNamCuaGiangVienFilterBuilder : SqlFilterBuilder<TongTienLuongTrongNamCuaGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TongTienLuongTrongNamCuaGiangVienFilterBuilder class.
		/// </summary>
		public TongTienLuongTrongNamCuaGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TongTienLuongTrongNamCuaGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TongTienLuongTrongNamCuaGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TongTienLuongTrongNamCuaGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TongTienLuongTrongNamCuaGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TongTienLuongTrongNamCuaGiangVienFilterBuilder
	
	#region TongTienLuongTrongNamCuaGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TongTienLuongTrongNamCuaGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TongTienLuongTrongNamCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TongTienLuongTrongNamCuaGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<TongTienLuongTrongNamCuaGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TongTienLuongTrongNamCuaGiangVienParameterBuilder class.
		/// </summary>
		public TongTienLuongTrongNamCuaGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TongTienLuongTrongNamCuaGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TongTienLuongTrongNamCuaGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TongTienLuongTrongNamCuaGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TongTienLuongTrongNamCuaGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TongTienLuongTrongNamCuaGiangVienParameterBuilder
	
	#region TongTienLuongTrongNamCuaGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TongTienLuongTrongNamCuaGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TongTienLuongTrongNamCuaGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TongTienLuongTrongNamCuaGiangVienSortBuilder : SqlSortBuilder<TongTienLuongTrongNamCuaGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TongTienLuongTrongNamCuaGiangVienSqlSortBuilder class.
		/// </summary>
		public TongTienLuongTrongNamCuaGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TongTienLuongTrongNamCuaGiangVienSortBuilder
	
} // end namespace
