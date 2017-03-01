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
	/// This class is the base class for any <see cref="CauHinhGiangVienPhanHoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CauHinhGiangVienPhanHoiProviderBaseCore : EntityProviderBase<PMS.Entities.CauHinhGiangVienPhanHoi, PMS.Entities.CauHinhGiangVienPhanHoiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.CauHinhGiangVienPhanHoiKey key)
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
		public override PMS.Entities.CauHinhGiangVienPhanHoi Get(TransactionManager transactionManager, PMS.Entities.CauHinhGiangVienPhanHoiKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CauHinhGiangVienPhanHoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhGiangVienPhanHoi"/> class.</returns>
		public PMS.Entities.CauHinhGiangVienPhanHoi GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhGiangVienPhanHoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhGiangVienPhanHoi"/> class.</returns>
		public PMS.Entities.CauHinhGiangVienPhanHoi GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhGiangVienPhanHoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhGiangVienPhanHoi"/> class.</returns>
		public PMS.Entities.CauHinhGiangVienPhanHoi GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhGiangVienPhanHoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhGiangVienPhanHoi"/> class.</returns>
		public PMS.Entities.CauHinhGiangVienPhanHoi GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhGiangVienPhanHoi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhGiangVienPhanHoi"/> class.</returns>
		public PMS.Entities.CauHinhGiangVienPhanHoi GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhGiangVienPhanHoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhGiangVienPhanHoi"/> class.</returns>
		public abstract PMS.Entities.CauHinhGiangVienPhanHoi GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_CauHinhGiangVienPhanHoi_GetGhiChu 
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhGiangVienPhanHoi_GetGhiChu' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetGhiChu()
		{
			return GetGhiChu(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhGiangVienPhanHoi_GetGhiChu' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetGhiChu(int start, int pageLength)
		{
			return GetGhiChu(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_CauHinhGiangVienPhanHoi_GetGhiChu' stored procedure. 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetGhiChu(TransactionManager transactionManager)
		{
			return GetGhiChu(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhGiangVienPhanHoi_GetGhiChu' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetGhiChu(TransactionManager transactionManager, int start, int pageLength );
		
		#endregion
		
		#region cust_CauHinhGiangVienPhanHoi_KiemTraChoPhepPhanHoi 
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhGiangVienPhanHoi_KiemTraChoPhepPhanHoi' stored procedure. 
		/// </summary>
			/// <param name="ketQua"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChoPhepPhanHoi(ref System.Boolean ketQua)
		{
			 KiemTraChoPhepPhanHoi(null, 0, int.MaxValue , ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhGiangVienPhanHoi_KiemTraChoPhepPhanHoi' stored procedure. 
		/// </summary>
			/// <param name="ketQua"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChoPhepPhanHoi(int start, int pageLength, ref System.Boolean ketQua)
		{
			 KiemTraChoPhepPhanHoi(null, start, pageLength , ref ketQua);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CauHinhGiangVienPhanHoi_KiemTraChoPhepPhanHoi' stored procedure. 
		/// </summary>
			/// <param name="ketQua"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChoPhepPhanHoi(TransactionManager transactionManager, ref System.Boolean ketQua)
		{
			 KiemTraChoPhepPhanHoi(transactionManager, 0, int.MaxValue , ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhGiangVienPhanHoi_KiemTraChoPhepPhanHoi' stored procedure. 
		/// </summary>
			/// <param name="ketQua"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraChoPhepPhanHoi(TransactionManager transactionManager, int start, int pageLength , ref System.Boolean ketQua);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CauHinhGiangVienPhanHoi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CauHinhGiangVienPhanHoi&gt;"/></returns>
		public static TList<CauHinhGiangVienPhanHoi> Fill(IDataReader reader, TList<CauHinhGiangVienPhanHoi> rows, int start, int pageLength)
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
				
				PMS.Entities.CauHinhGiangVienPhanHoi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CauHinhGiangVienPhanHoi")
					.Append("|").Append((System.Int32)reader[((int)CauHinhGiangVienPhanHoiColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<CauHinhGiangVienPhanHoi>(
					key.ToString(), // EntityTrackingKey
					"CauHinhGiangVienPhanHoi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.CauHinhGiangVienPhanHoi();
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
					c.Id = (System.Int32)reader[(CauHinhGiangVienPhanHoiColumn.Id.ToString())];
					c.MaCauHinh = (reader[CauHinhGiangVienPhanHoiColumn.MaCauHinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhGiangVienPhanHoiColumn.MaCauHinh.ToString())];
					c.TenCauHinh = (reader[CauHinhGiangVienPhanHoiColumn.TenCauHinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhGiangVienPhanHoiColumn.TenCauHinh.ToString())];
					c.NoiDung = (reader[CauHinhGiangVienPhanHoiColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhGiangVienPhanHoiColumn.NoiDung.ToString())];
					c.NgayCapNhat = (reader[CauHinhGiangVienPhanHoiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(CauHinhGiangVienPhanHoiColumn.NgayCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CauHinhGiangVienPhanHoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CauHinhGiangVienPhanHoi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.CauHinhGiangVienPhanHoi entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(CauHinhGiangVienPhanHoiColumn.Id.ToString())];
			entity.MaCauHinh = (reader[CauHinhGiangVienPhanHoiColumn.MaCauHinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhGiangVienPhanHoiColumn.MaCauHinh.ToString())];
			entity.TenCauHinh = (reader[CauHinhGiangVienPhanHoiColumn.TenCauHinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhGiangVienPhanHoiColumn.TenCauHinh.ToString())];
			entity.NoiDung = (reader[CauHinhGiangVienPhanHoiColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhGiangVienPhanHoiColumn.NoiDung.ToString())];
			entity.NgayCapNhat = (reader[CauHinhGiangVienPhanHoiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(CauHinhGiangVienPhanHoiColumn.NgayCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CauHinhGiangVienPhanHoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CauHinhGiangVienPhanHoi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.CauHinhGiangVienPhanHoi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaCauHinh = Convert.IsDBNull(dataRow["MaCauHinh"]) ? null : (System.String)dataRow["MaCauHinh"];
			entity.TenCauHinh = Convert.IsDBNull(dataRow["TenCauHinh"]) ? null : (System.String)dataRow["TenCauHinh"];
			entity.NoiDung = Convert.IsDBNull(dataRow["NoiDung"]) ? null : (System.String)dataRow["NoiDung"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.CauHinhGiangVienPhanHoi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.CauHinhGiangVienPhanHoi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.CauHinhGiangVienPhanHoi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.CauHinhGiangVienPhanHoi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.CauHinhGiangVienPhanHoi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.CauHinhGiangVienPhanHoi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.CauHinhGiangVienPhanHoi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region CauHinhGiangVienPhanHoiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.CauHinhGiangVienPhanHoi</c>
	///</summary>
	public enum CauHinhGiangVienPhanHoiChildEntityTypes
	{
	}
	
	#endregion CauHinhGiangVienPhanHoiChildEntityTypes
	
	#region CauHinhGiangVienPhanHoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CauHinhGiangVienPhanHoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhGiangVienPhanHoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhGiangVienPhanHoiFilterBuilder : SqlFilterBuilder<CauHinhGiangVienPhanHoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhGiangVienPhanHoiFilterBuilder class.
		/// </summary>
		public CauHinhGiangVienPhanHoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CauHinhGiangVienPhanHoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CauHinhGiangVienPhanHoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CauHinhGiangVienPhanHoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CauHinhGiangVienPhanHoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CauHinhGiangVienPhanHoiFilterBuilder
	
	#region CauHinhGiangVienPhanHoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CauHinhGiangVienPhanHoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhGiangVienPhanHoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhGiangVienPhanHoiParameterBuilder : ParameterizedSqlFilterBuilder<CauHinhGiangVienPhanHoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhGiangVienPhanHoiParameterBuilder class.
		/// </summary>
		public CauHinhGiangVienPhanHoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CauHinhGiangVienPhanHoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CauHinhGiangVienPhanHoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CauHinhGiangVienPhanHoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CauHinhGiangVienPhanHoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CauHinhGiangVienPhanHoiParameterBuilder
	
	#region CauHinhGiangVienPhanHoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CauHinhGiangVienPhanHoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhGiangVienPhanHoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CauHinhGiangVienPhanHoiSortBuilder : SqlSortBuilder<CauHinhGiangVienPhanHoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhGiangVienPhanHoiSqlSortBuilder class.
		/// </summary>
		public CauHinhGiangVienPhanHoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CauHinhGiangVienPhanHoiSortBuilder
	
} // end namespace
