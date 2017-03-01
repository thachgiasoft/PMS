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
	/// This class is the base class for any <see cref="HeSoChucDanhKhoiLuongKhacProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoChucDanhKhoiLuongKhacProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoChucDanhKhoiLuongKhac, PMS.Entities.HeSoChucDanhKhoiLuongKhacKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoChucDanhKhoiLuongKhacKey key)
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
		public override PMS.Entities.HeSoChucDanhKhoiLuongKhac Get(TransactionManager transactionManager, PMS.Entities.HeSoChucDanhKhoiLuongKhacKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeSoChucDanhKhoiLuongKhac index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.HeSoChucDanhKhoiLuongKhac GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanhKhoiLuongKhac index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.HeSoChucDanhKhoiLuongKhac GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanhKhoiLuongKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.HeSoChucDanhKhoiLuongKhac GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanhKhoiLuongKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.HeSoChucDanhKhoiLuongKhac GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanhKhoiLuongKhac index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhKhoiLuongKhac"/> class.</returns>
		public PMS.Entities.HeSoChucDanhKhoiLuongKhac GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoChucDanhKhoiLuongKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoChucDanhKhoiLuongKhac"/> class.</returns>
		public abstract PMS.Entities.HeSoChucDanhKhoiLuongKhac GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HeSoChucDanhKhoiLuongKhac_GetByMaKhoiLuong 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanhKhoiLuongKhac_GetByMaKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maKhoiLuong"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoChucDanhKhoiLuongKhac&gt;"/> instance.</returns>
		public TList<HeSoChucDanhKhoiLuongKhac> GetByMaKhoiLuong(System.Int32 maKhoiLuong)
		{
			return GetByMaKhoiLuong(null, 0, int.MaxValue , maKhoiLuong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanhKhoiLuongKhac_GetByMaKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maKhoiLuong"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoChucDanhKhoiLuongKhac&gt;"/> instance.</returns>
		public TList<HeSoChucDanhKhoiLuongKhac> GetByMaKhoiLuong(int start, int pageLength, System.Int32 maKhoiLuong)
		{
			return GetByMaKhoiLuong(null, start, pageLength , maKhoiLuong);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanhKhoiLuongKhac_GetByMaKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maKhoiLuong"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoChucDanhKhoiLuongKhac&gt;"/> instance.</returns>
		public TList<HeSoChucDanhKhoiLuongKhac> GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 maKhoiLuong)
		{
			return GetByMaKhoiLuong(transactionManager, 0, int.MaxValue , maKhoiLuong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoChucDanhKhoiLuongKhac_GetByMaKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maKhoiLuong"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoChucDanhKhoiLuongKhac&gt;"/> instance.</returns>
		public abstract TList<HeSoChucDanhKhoiLuongKhac> GetByMaKhoiLuong(TransactionManager transactionManager, int start, int pageLength , System.Int32 maKhoiLuong);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoChucDanhKhoiLuongKhac&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoChucDanhKhoiLuongKhac&gt;"/></returns>
		public static TList<HeSoChucDanhKhoiLuongKhac> Fill(IDataReader reader, TList<HeSoChucDanhKhoiLuongKhac> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoChucDanhKhoiLuongKhac c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoChucDanhKhoiLuongKhac")
					.Append("|").Append((System.Int32)reader[((int)HeSoChucDanhKhoiLuongKhacColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoChucDanhKhoiLuongKhac>(
					key.ToString(), // EntityTrackingKey
					"HeSoChucDanhKhoiLuongKhac",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoChucDanhKhoiLuongKhac();
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
					c.Id = (System.Int32)reader[(HeSoChucDanhKhoiLuongKhacColumn.Id.ToString())];
					c.NamHoc = (reader[HeSoChucDanhKhoiLuongKhacColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhKhoiLuongKhacColumn.NamHoc.ToString())];
					c.HocKy = (reader[HeSoChucDanhKhoiLuongKhacColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhKhoiLuongKhacColumn.HocKy.ToString())];
					c.MaKhoiLuong = (reader[HeSoChucDanhKhoiLuongKhacColumn.MaKhoiLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhKhoiLuongKhacColumn.MaKhoiLuong.ToString())];
					c.MaHocHam = (reader[HeSoChucDanhKhoiLuongKhacColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhKhoiLuongKhacColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[HeSoChucDanhKhoiLuongKhacColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhKhoiLuongKhacColumn.MaHocVi.ToString())];
					c.HeSo = (reader[HeSoChucDanhKhoiLuongKhacColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoChucDanhKhoiLuongKhacColumn.HeSo.ToString())];
					c.Stt = (reader[HeSoChucDanhKhoiLuongKhacColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhKhoiLuongKhacColumn.Stt.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoChucDanhKhoiLuongKhac"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoChucDanhKhoiLuongKhac"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoChucDanhKhoiLuongKhac entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(HeSoChucDanhKhoiLuongKhacColumn.Id.ToString())];
			entity.NamHoc = (reader[HeSoChucDanhKhoiLuongKhacColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhKhoiLuongKhacColumn.NamHoc.ToString())];
			entity.HocKy = (reader[HeSoChucDanhKhoiLuongKhacColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoChucDanhKhoiLuongKhacColumn.HocKy.ToString())];
			entity.MaKhoiLuong = (reader[HeSoChucDanhKhoiLuongKhacColumn.MaKhoiLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhKhoiLuongKhacColumn.MaKhoiLuong.ToString())];
			entity.MaHocHam = (reader[HeSoChucDanhKhoiLuongKhacColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhKhoiLuongKhacColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[HeSoChucDanhKhoiLuongKhacColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhKhoiLuongKhacColumn.MaHocVi.ToString())];
			entity.HeSo = (reader[HeSoChucDanhKhoiLuongKhacColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoChucDanhKhoiLuongKhacColumn.HeSo.ToString())];
			entity.Stt = (reader[HeSoChucDanhKhoiLuongKhacColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoChucDanhKhoiLuongKhacColumn.Stt.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoChucDanhKhoiLuongKhac"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoChucDanhKhoiLuongKhac"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoChucDanhKhoiLuongKhac entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaKhoiLuong = Convert.IsDBNull(dataRow["MaKhoiLuong"]) ? null : (System.Int32?)dataRow["MaKhoiLuong"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.Stt = Convert.IsDBNull(dataRow["Stt"]) ? null : (System.Int32?)dataRow["Stt"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoChucDanhKhoiLuongKhac"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoChucDanhKhoiLuongKhac Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoChucDanhKhoiLuongKhac entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoChucDanhKhoiLuongKhac object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoChucDanhKhoiLuongKhac instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoChucDanhKhoiLuongKhac Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoChucDanhKhoiLuongKhac entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HeSoChucDanhKhoiLuongKhacChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoChucDanhKhoiLuongKhac</c>
	///</summary>
	public enum HeSoChucDanhKhoiLuongKhacChildEntityTypes
	{
	}
	
	#endregion HeSoChucDanhKhoiLuongKhacChildEntityTypes
	
	#region HeSoChucDanhKhoiLuongKhacFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoChucDanhKhoiLuongKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhKhoiLuongKhacFilterBuilder : SqlFilterBuilder<HeSoChucDanhKhoiLuongKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhKhoiLuongKhacFilterBuilder class.
		/// </summary>
		public HeSoChucDanhKhoiLuongKhacFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhKhoiLuongKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoChucDanhKhoiLuongKhacFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhKhoiLuongKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoChucDanhKhoiLuongKhacFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoChucDanhKhoiLuongKhacFilterBuilder
	
	#region HeSoChucDanhKhoiLuongKhacParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoChucDanhKhoiLuongKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhKhoiLuongKhacParameterBuilder : ParameterizedSqlFilterBuilder<HeSoChucDanhKhoiLuongKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhKhoiLuongKhacParameterBuilder class.
		/// </summary>
		public HeSoChucDanhKhoiLuongKhacParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhKhoiLuongKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoChucDanhKhoiLuongKhacParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhKhoiLuongKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoChucDanhKhoiLuongKhacParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoChucDanhKhoiLuongKhacParameterBuilder
	
	#region HeSoChucDanhKhoiLuongKhacSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoChucDanhKhoiLuongKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhKhoiLuongKhac"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoChucDanhKhoiLuongKhacSortBuilder : SqlSortBuilder<HeSoChucDanhKhoiLuongKhacColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhKhoiLuongKhacSqlSortBuilder class.
		/// </summary>
		public HeSoChucDanhKhoiLuongKhacSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoChucDanhKhoiLuongKhacSortBuilder
	
} // end namespace
