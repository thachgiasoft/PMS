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
	/// This class is the base class for any <see cref="KcqCauHinhChotGioProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqCauHinhChotGioProviderBaseCore : EntityProviderBase<PMS.Entities.KcqCauHinhChotGio, PMS.Entities.KcqCauHinhChotGioKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqCauHinhChotGioKey key)
		{
			return Delete(transactionManager, key.MaCauHinhChotGio);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maCauHinhChotGio">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maCauHinhChotGio)
		{
			return Delete(null, _maCauHinhChotGio);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinhChotGio">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maCauHinhChotGio);		
		
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
		public override PMS.Entities.KcqCauHinhChotGio Get(TransactionManager transactionManager, PMS.Entities.KcqCauHinhChotGioKey key, int start, int pageLength)
		{
			return GetByMaCauHinhChotGio(transactionManager, key.MaCauHinhChotGio, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqCauHinhChotGio index.
		/// </summary>
		/// <param name="_maCauHinhChotGio"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqCauHinhChotGio"/> class.</returns>
		public PMS.Entities.KcqCauHinhChotGio GetByMaCauHinhChotGio(System.Int32 _maCauHinhChotGio)
		{
			int count = -1;
			return GetByMaCauHinhChotGio(null,_maCauHinhChotGio, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqCauHinhChotGio index.
		/// </summary>
		/// <param name="_maCauHinhChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqCauHinhChotGio"/> class.</returns>
		public PMS.Entities.KcqCauHinhChotGio GetByMaCauHinhChotGio(System.Int32 _maCauHinhChotGio, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCauHinhChotGio(null, _maCauHinhChotGio, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqCauHinhChotGio index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqCauHinhChotGio"/> class.</returns>
		public PMS.Entities.KcqCauHinhChotGio GetByMaCauHinhChotGio(TransactionManager transactionManager, System.Int32 _maCauHinhChotGio)
		{
			int count = -1;
			return GetByMaCauHinhChotGio(transactionManager, _maCauHinhChotGio, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqCauHinhChotGio index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqCauHinhChotGio"/> class.</returns>
		public PMS.Entities.KcqCauHinhChotGio GetByMaCauHinhChotGio(TransactionManager transactionManager, System.Int32 _maCauHinhChotGio, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCauHinhChotGio(transactionManager, _maCauHinhChotGio, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqCauHinhChotGio index.
		/// </summary>
		/// <param name="_maCauHinhChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqCauHinhChotGio"/> class.</returns>
		public PMS.Entities.KcqCauHinhChotGio GetByMaCauHinhChotGio(System.Int32 _maCauHinhChotGio, int start, int pageLength, out int count)
		{
			return GetByMaCauHinhChotGio(null, _maCauHinhChotGio, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqCauHinhChotGio index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinhChotGio"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqCauHinhChotGio"/> class.</returns>
		public abstract PMS.Entities.KcqCauHinhChotGio GetByMaCauHinhChotGio(TransactionManager transactionManager, System.Int32 _maCauHinhChotGio, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KcqCauHinhChotGio_GetByNamHocDot 
		
		/// <summary>
		///	This method wrap the 'cust_KcqCauHinhChotGio_GetByNamHocDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqCauHinhChotGio&gt;"/> instance.</returns>
		public TList<KcqCauHinhChotGio> GetByNamHocDot(System.String namHoc, System.String dot)
		{
			return GetByNamHocDot(null, 0, int.MaxValue , namHoc, dot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqCauHinhChotGio_GetByNamHocDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqCauHinhChotGio&gt;"/> instance.</returns>
		public TList<KcqCauHinhChotGio> GetByNamHocDot(int start, int pageLength, System.String namHoc, System.String dot)
		{
			return GetByNamHocDot(null, start, pageLength , namHoc, dot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqCauHinhChotGio_GetByNamHocDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqCauHinhChotGio&gt;"/> instance.</returns>
		public TList<KcqCauHinhChotGio> GetByNamHocDot(TransactionManager transactionManager, System.String namHoc, System.String dot)
		{
			return GetByNamHocDot(transactionManager, 0, int.MaxValue , namHoc, dot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqCauHinhChotGio_GetByNamHocDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqCauHinhChotGio&gt;"/> instance.</returns>
		public abstract TList<KcqCauHinhChotGio> GetByNamHocDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String dot);
		
		#endregion
		
		#region cust_KcqCauHinhChotGio_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KcqCauHinhChotGio_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqCauHinhChotGio&gt;"/> instance.</returns>
		public TList<KcqCauHinhChotGio> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqCauHinhChotGio_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqCauHinhChotGio&gt;"/> instance.</returns>
		public TList<KcqCauHinhChotGio> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqCauHinhChotGio_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqCauHinhChotGio&gt;"/> instance.</returns>
		public TList<KcqCauHinhChotGio> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqCauHinhChotGio_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqCauHinhChotGio&gt;"/> instance.</returns>
		public abstract TList<KcqCauHinhChotGio> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqCauHinhChotGio&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqCauHinhChotGio&gt;"/></returns>
		public static TList<KcqCauHinhChotGio> Fill(IDataReader reader, TList<KcqCauHinhChotGio> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqCauHinhChotGio c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqCauHinhChotGio")
					.Append("|").Append((System.Int32)reader[((int)KcqCauHinhChotGioColumn.MaCauHinhChotGio - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqCauHinhChotGio>(
					key.ToString(), // EntityTrackingKey
					"KcqCauHinhChotGio",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqCauHinhChotGio();
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
					c.MaCauHinhChotGio = (System.Int32)reader[(KcqCauHinhChotGioColumn.MaCauHinhChotGio.ToString())];
					c.MaQuanLy = (reader[KcqCauHinhChotGioColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqCauHinhChotGioColumn.MaQuanLy.ToString())];
					c.TenQuanLy = (reader[KcqCauHinhChotGioColumn.TenQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqCauHinhChotGioColumn.TenQuanLy.ToString())];
					c.TuNgay = (reader[KcqCauHinhChotGioColumn.TuNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqCauHinhChotGioColumn.TuNgay.ToString())];
					c.DenNgay = (reader[KcqCauHinhChotGioColumn.DenNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqCauHinhChotGioColumn.DenNgay.ToString())];
					c.IsLocked = (reader[KcqCauHinhChotGioColumn.IsLocked.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqCauHinhChotGioColumn.IsLocked.ToString())];
					c.NamHoc = (System.String)reader[(KcqCauHinhChotGioColumn.NamHoc.ToString())];
					c.HocKy = (System.String)reader[(KcqCauHinhChotGioColumn.HocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqCauHinhChotGio"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqCauHinhChotGio"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqCauHinhChotGio entity)
		{
			if (!reader.Read()) return;
			
			entity.MaCauHinhChotGio = (System.Int32)reader[(KcqCauHinhChotGioColumn.MaCauHinhChotGio.ToString())];
			entity.MaQuanLy = (reader[KcqCauHinhChotGioColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqCauHinhChotGioColumn.MaQuanLy.ToString())];
			entity.TenQuanLy = (reader[KcqCauHinhChotGioColumn.TenQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqCauHinhChotGioColumn.TenQuanLy.ToString())];
			entity.TuNgay = (reader[KcqCauHinhChotGioColumn.TuNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqCauHinhChotGioColumn.TuNgay.ToString())];
			entity.DenNgay = (reader[KcqCauHinhChotGioColumn.DenNgay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqCauHinhChotGioColumn.DenNgay.ToString())];
			entity.IsLocked = (reader[KcqCauHinhChotGioColumn.IsLocked.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqCauHinhChotGioColumn.IsLocked.ToString())];
			entity.NamHoc = (System.String)reader[(KcqCauHinhChotGioColumn.NamHoc.ToString())];
			entity.HocKy = (System.String)reader[(KcqCauHinhChotGioColumn.HocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqCauHinhChotGio"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqCauHinhChotGio"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqCauHinhChotGio entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaCauHinhChotGio = (System.Int32)dataRow["MaCauHinhChotGio"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.TenQuanLy = Convert.IsDBNull(dataRow["TenQuanLy"]) ? null : (System.String)dataRow["TenQuanLy"];
			entity.TuNgay = Convert.IsDBNull(dataRow["TuNgay"]) ? null : (System.DateTime?)dataRow["TuNgay"];
			entity.DenNgay = Convert.IsDBNull(dataRow["DenNgay"]) ? null : (System.DateTime?)dataRow["DenNgay"];
			entity.IsLocked = Convert.IsDBNull(dataRow["IsLocked"]) ? null : (System.Boolean?)dataRow["IsLocked"];
			entity.NamHoc = (System.String)dataRow["NamHoc"];
			entity.HocKy = (System.String)dataRow["HocKy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqCauHinhChotGio"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqCauHinhChotGio Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqCauHinhChotGio entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqCauHinhChotGio object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqCauHinhChotGio instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqCauHinhChotGio Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqCauHinhChotGio entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KcqCauHinhChotGioChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqCauHinhChotGio</c>
	///</summary>
	public enum KcqCauHinhChotGioChildEntityTypes
	{
	}
	
	#endregion KcqCauHinhChotGioChildEntityTypes
	
	#region KcqCauHinhChotGioFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqCauHinhChotGioColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqCauHinhChotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqCauHinhChotGioFilterBuilder : SqlFilterBuilder<KcqCauHinhChotGioColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqCauHinhChotGioFilterBuilder class.
		/// </summary>
		public KcqCauHinhChotGioFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqCauHinhChotGioFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqCauHinhChotGioFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqCauHinhChotGioFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqCauHinhChotGioFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqCauHinhChotGioFilterBuilder
	
	#region KcqCauHinhChotGioParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqCauHinhChotGioColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqCauHinhChotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqCauHinhChotGioParameterBuilder : ParameterizedSqlFilterBuilder<KcqCauHinhChotGioColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqCauHinhChotGioParameterBuilder class.
		/// </summary>
		public KcqCauHinhChotGioParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqCauHinhChotGioParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqCauHinhChotGioParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqCauHinhChotGioParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqCauHinhChotGioParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqCauHinhChotGioParameterBuilder
	
	#region KcqCauHinhChotGioSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqCauHinhChotGioColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqCauHinhChotGio"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqCauHinhChotGioSortBuilder : SqlSortBuilder<KcqCauHinhChotGioColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqCauHinhChotGioSqlSortBuilder class.
		/// </summary>
		public KcqCauHinhChotGioSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqCauHinhChotGioSortBuilder
	
} // end namespace
