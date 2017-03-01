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
	/// This class is the base class for any <see cref="HeSoHocKyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoHocKyProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoHocKy, PMS.Entities.HeSoHocKyKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoHocKyKey key)
		{
			return Delete(transactionManager, key.MaHocKy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maHocKy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maHocKy)
		{
			return Delete(null, _maHocKy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocKy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maHocKy);		
		
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
		public override PMS.Entities.HeSoHocKy Get(TransactionManager transactionManager, PMS.Entities.HeSoHocKyKey key, int start, int pageLength)
		{
			return GetByMaHocKy(transactionManager, key.MaHocKy, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_HeSoHocKy index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoHocKy"/> class.</returns>
		public PMS.Entities.HeSoHocKy GetByMaQuanLy(System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HeSoHocKy index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoHocKy"/> class.</returns>
		public PMS.Entities.HeSoHocKy GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HeSoHocKy index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoHocKy"/> class.</returns>
		public PMS.Entities.HeSoHocKy GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HeSoHocKy index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoHocKy"/> class.</returns>
		public PMS.Entities.HeSoHocKy GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HeSoHocKy index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoHocKy"/> class.</returns>
		public PMS.Entities.HeSoHocKy GetByMaQuanLy(System.String _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_HeSoHocKy index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoHocKy"/> class.</returns>
		public abstract PMS.Entities.HeSoHocKy GetByMaQuanLy(TransactionManager transactionManager, System.String _maQuanLy, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeSoHocKy index.
		/// </summary>
		/// <param name="_maHocKy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoHocKy"/> class.</returns>
		public PMS.Entities.HeSoHocKy GetByMaHocKy(System.Int32 _maHocKy)
		{
			int count = -1;
			return GetByMaHocKy(null,_maHocKy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoHocKy index.
		/// </summary>
		/// <param name="_maHocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoHocKy"/> class.</returns>
		public PMS.Entities.HeSoHocKy GetByMaHocKy(System.Int32 _maHocKy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocKy(null, _maHocKy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoHocKy index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocKy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoHocKy"/> class.</returns>
		public PMS.Entities.HeSoHocKy GetByMaHocKy(TransactionManager transactionManager, System.Int32 _maHocKy)
		{
			int count = -1;
			return GetByMaHocKy(transactionManager, _maHocKy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoHocKy index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoHocKy"/> class.</returns>
		public PMS.Entities.HeSoHocKy GetByMaHocKy(TransactionManager transactionManager, System.Int32 _maHocKy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHocKy(transactionManager, _maHocKy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoHocKy index.
		/// </summary>
		/// <param name="_maHocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoHocKy"/> class.</returns>
		public PMS.Entities.HeSoHocKy GetByMaHocKy(System.Int32 _maHocKy, int start, int pageLength, out int count)
		{
			return GetByMaHocKy(null, _maHocKy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoHocKy index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHocKy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoHocKy"/> class.</returns>
		public abstract PMS.Entities.HeSoHocKy GetByMaHocKy(TransactionManager transactionManager, System.Int32 _maHocKy, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HeSoHocKy_GetByHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoHocKy_GetByHocKy' stored procedure. 
		/// </summary>
		/// <param name="maHocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoHocKy&gt;"/> instance.</returns>
		public TList<HeSoHocKy> GetByHocKy(System.String maHocKy)
		{
			return GetByHocKy(null, 0, int.MaxValue , maHocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoHocKy_GetByHocKy' stored procedure. 
		/// </summary>
		/// <param name="maHocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoHocKy&gt;"/> instance.</returns>
		public TList<HeSoHocKy> GetByHocKy(int start, int pageLength, System.String maHocKy)
		{
			return GetByHocKy(null, start, pageLength , maHocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoHocKy_GetByHocKy' stored procedure. 
		/// </summary>
		/// <param name="maHocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoHocKy&gt;"/> instance.</returns>
		public TList<HeSoHocKy> GetByHocKy(TransactionManager transactionManager, System.String maHocKy)
		{
			return GetByHocKy(transactionManager, 0, int.MaxValue , maHocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoHocKy_GetByHocKy' stored procedure. 
		/// </summary>
		/// <param name="maHocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoHocKy&gt;"/> instance.</returns>
		public abstract TList<HeSoHocKy> GetByHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maHocKy);
		
		#endregion
		
		#region cust_HeSoHocKy_GetByMaHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoHocKy_GetByMaHocKy' stored procedure. 
		/// </summary>
		/// <param name="maHocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoHocKy&gt;"/> instance.</returns>
		public TList<HeSoHocKy> GetByMaHocKy(System.String maHocKy)
		{
			return GetByMaHocKy(null, 0, int.MaxValue , maHocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoHocKy_GetByMaHocKy' stored procedure. 
		/// </summary>
		/// <param name="maHocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoHocKy&gt;"/> instance.</returns>
		public TList<HeSoHocKy> GetByMaHocKy(int start, int pageLength, System.String maHocKy)
		{
			return GetByMaHocKy(null, start, pageLength , maHocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoHocKy_GetByMaHocKy' stored procedure. 
		/// </summary>
		/// <param name="maHocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoHocKy&gt;"/> instance.</returns>
		public TList<HeSoHocKy> GetByMaHocKy(TransactionManager transactionManager, System.String maHocKy)
		{
			return GetByMaHocKy(transactionManager, 0, int.MaxValue , maHocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoHocKy_GetByMaHocKy' stored procedure. 
		/// </summary>
		/// <param name="maHocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoHocKy&gt;"/> instance.</returns>
		public abstract TList<HeSoHocKy> GetByMaHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maHocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoHocKy&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoHocKy&gt;"/></returns>
		public static TList<HeSoHocKy> Fill(IDataReader reader, TList<HeSoHocKy> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoHocKy c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoHocKy")
					.Append("|").Append((System.Int32)reader[((int)HeSoHocKyColumn.MaHocKy - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoHocKy>(
					key.ToString(), // EntityTrackingKey
					"HeSoHocKy",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoHocKy();
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
					c.MaHocKy = (System.Int32)reader[(HeSoHocKyColumn.MaHocKy.ToString())];
					c.MaQuanLy = (reader[HeSoHocKyColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoHocKyColumn.MaQuanLy.ToString())];
					c.TenHocKy = (reader[HeSoHocKyColumn.TenHocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoHocKyColumn.TenHocKy.ToString())];
					c.HeSo = (reader[HeSoHocKyColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoHocKyColumn.HeSo.ToString())];
					c.ThuTu = (reader[HeSoHocKyColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoHocKyColumn.ThuTu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoHocKy"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoHocKy"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoHocKy entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHocKy = (System.Int32)reader[(HeSoHocKyColumn.MaHocKy.ToString())];
			entity.MaQuanLy = (reader[HeSoHocKyColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoHocKyColumn.MaQuanLy.ToString())];
			entity.TenHocKy = (reader[HeSoHocKyColumn.TenHocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoHocKyColumn.TenHocKy.ToString())];
			entity.HeSo = (reader[HeSoHocKyColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoHocKyColumn.HeSo.ToString())];
			entity.ThuTu = (reader[HeSoHocKyColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoHocKyColumn.ThuTu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoHocKy"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoHocKy"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoHocKy entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHocKy = (System.Int32)dataRow["MaHocKy"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.TenHocKy = Convert.IsDBNull(dataRow["TenHocKy"]) ? null : (System.String)dataRow["TenHocKy"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoHocKy"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoHocKy Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoHocKy entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoHocKy object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoHocKy instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoHocKy Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoHocKy entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HeSoHocKyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoHocKy</c>
	///</summary>
	public enum HeSoHocKyChildEntityTypes
	{
	}
	
	#endregion HeSoHocKyChildEntityTypes
	
	#region HeSoHocKyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoHocKyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoHocKyFilterBuilder : SqlFilterBuilder<HeSoHocKyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoHocKyFilterBuilder class.
		/// </summary>
		public HeSoHocKyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoHocKyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoHocKyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoHocKyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoHocKyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoHocKyFilterBuilder
	
	#region HeSoHocKyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoHocKyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoHocKyParameterBuilder : ParameterizedSqlFilterBuilder<HeSoHocKyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoHocKyParameterBuilder class.
		/// </summary>
		public HeSoHocKyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoHocKyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoHocKyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoHocKyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoHocKyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoHocKyParameterBuilder
	
	#region HeSoHocKySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoHocKyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoHocKy"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoHocKySortBuilder : SqlSortBuilder<HeSoHocKyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoHocKySqlSortBuilder class.
		/// </summary>
		public HeSoHocKySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoHocKySortBuilder
	
} // end namespace
