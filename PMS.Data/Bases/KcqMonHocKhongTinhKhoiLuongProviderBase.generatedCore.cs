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
	/// This class is the base class for any <see cref="KcqMonHocKhongTinhKhoiLuongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqMonHocKhongTinhKhoiLuongProviderBaseCore : EntityProviderBase<PMS.Entities.KcqMonHocKhongTinhKhoiLuong, PMS.Entities.KcqMonHocKhongTinhKhoiLuongKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqMonHocKhongTinhKhoiLuongKey key)
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
		public override PMS.Entities.KcqMonHocKhongTinhKhoiLuong Get(TransactionManager transactionManager, PMS.Entities.KcqMonHocKhongTinhKhoiLuongKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqMonHocKhongTinhKhoiLuong index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqMonHocKhongTinhKhoiLuong"/> class.</returns>
		public PMS.Entities.KcqMonHocKhongTinhKhoiLuong GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqMonHocKhongTinhKhoiLuong index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqMonHocKhongTinhKhoiLuong"/> class.</returns>
		public PMS.Entities.KcqMonHocKhongTinhKhoiLuong GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqMonHocKhongTinhKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqMonHocKhongTinhKhoiLuong"/> class.</returns>
		public PMS.Entities.KcqMonHocKhongTinhKhoiLuong GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqMonHocKhongTinhKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqMonHocKhongTinhKhoiLuong"/> class.</returns>
		public PMS.Entities.KcqMonHocKhongTinhKhoiLuong GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqMonHocKhongTinhKhoiLuong index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqMonHocKhongTinhKhoiLuong"/> class.</returns>
		public PMS.Entities.KcqMonHocKhongTinhKhoiLuong GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqMonHocKhongTinhKhoiLuong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqMonHocKhongTinhKhoiLuong"/> class.</returns>
		public abstract PMS.Entities.KcqMonHocKhongTinhKhoiLuong GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KcqMonHocKhongTinhKhoiLuong_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KcqMonHocKhongTinhKhoiLuong_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqMonHocKhongTinhKhoiLuong&gt;"/> instance.</returns>
		public TList<KcqMonHocKhongTinhKhoiLuong> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqMonHocKhongTinhKhoiLuong_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqMonHocKhongTinhKhoiLuong&gt;"/> instance.</returns>
		public TList<KcqMonHocKhongTinhKhoiLuong> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqMonHocKhongTinhKhoiLuong_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqMonHocKhongTinhKhoiLuong&gt;"/> instance.</returns>
		public TList<KcqMonHocKhongTinhKhoiLuong> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqMonHocKhongTinhKhoiLuong_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqMonHocKhongTinhKhoiLuong&gt;"/> instance.</returns>
		public abstract TList<KcqMonHocKhongTinhKhoiLuong> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqMonHocKhongTinhKhoiLuong&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqMonHocKhongTinhKhoiLuong&gt;"/></returns>
		public static TList<KcqMonHocKhongTinhKhoiLuong> Fill(IDataReader reader, TList<KcqMonHocKhongTinhKhoiLuong> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqMonHocKhongTinhKhoiLuong c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqMonHocKhongTinhKhoiLuong")
					.Append("|").Append((System.Int32)reader[((int)KcqMonHocKhongTinhKhoiLuongColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqMonHocKhongTinhKhoiLuong>(
					key.ToString(), // EntityTrackingKey
					"KcqMonHocKhongTinhKhoiLuong",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqMonHocKhongTinhKhoiLuong();
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
					c.Id = (System.Int32)reader[(KcqMonHocKhongTinhKhoiLuongColumn.Id.ToString())];
					c.NamHoc = (reader[KcqMonHocKhongTinhKhoiLuongColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonHocKhongTinhKhoiLuongColumn.NamHoc.ToString())];
					c.HocKy = (reader[KcqMonHocKhongTinhKhoiLuongColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonHocKhongTinhKhoiLuongColumn.HocKy.ToString())];
					c.MaMonHoc = (reader[KcqMonHocKhongTinhKhoiLuongColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonHocKhongTinhKhoiLuongColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[KcqMonHocKhongTinhKhoiLuongColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonHocKhongTinhKhoiLuongColumn.TenMonHoc.ToString())];
					c.SoTinChi = (reader[KcqMonHocKhongTinhKhoiLuongColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonHocKhongTinhKhoiLuongColumn.SoTinChi.ToString())];
					c.TenBoMon = (reader[KcqMonHocKhongTinhKhoiLuongColumn.TenBoMon.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonHocKhongTinhKhoiLuongColumn.TenBoMon.ToString())];
					c.NgayCapNhat = (reader[KcqMonHocKhongTinhKhoiLuongColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqMonHocKhongTinhKhoiLuongColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[KcqMonHocKhongTinhKhoiLuongColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonHocKhongTinhKhoiLuongColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqMonHocKhongTinhKhoiLuong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqMonHocKhongTinhKhoiLuong"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqMonHocKhongTinhKhoiLuong entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KcqMonHocKhongTinhKhoiLuongColumn.Id.ToString())];
			entity.NamHoc = (reader[KcqMonHocKhongTinhKhoiLuongColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonHocKhongTinhKhoiLuongColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KcqMonHocKhongTinhKhoiLuongColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonHocKhongTinhKhoiLuongColumn.HocKy.ToString())];
			entity.MaMonHoc = (reader[KcqMonHocKhongTinhKhoiLuongColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonHocKhongTinhKhoiLuongColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[KcqMonHocKhongTinhKhoiLuongColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonHocKhongTinhKhoiLuongColumn.TenMonHoc.ToString())];
			entity.SoTinChi = (reader[KcqMonHocKhongTinhKhoiLuongColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqMonHocKhongTinhKhoiLuongColumn.SoTinChi.ToString())];
			entity.TenBoMon = (reader[KcqMonHocKhongTinhKhoiLuongColumn.TenBoMon.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonHocKhongTinhKhoiLuongColumn.TenBoMon.ToString())];
			entity.NgayCapNhat = (reader[KcqMonHocKhongTinhKhoiLuongColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqMonHocKhongTinhKhoiLuongColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[KcqMonHocKhongTinhKhoiLuongColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqMonHocKhongTinhKhoiLuongColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqMonHocKhongTinhKhoiLuong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqMonHocKhongTinhKhoiLuong"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqMonHocKhongTinhKhoiLuong entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
			entity.TenBoMon = Convert.IsDBNull(dataRow["TenBoMon"]) ? null : (System.String)dataRow["TenBoMon"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqMonHocKhongTinhKhoiLuong"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqMonHocKhongTinhKhoiLuong Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqMonHocKhongTinhKhoiLuong entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqMonHocKhongTinhKhoiLuong object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqMonHocKhongTinhKhoiLuong instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqMonHocKhongTinhKhoiLuong Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqMonHocKhongTinhKhoiLuong entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KcqMonHocKhongTinhKhoiLuongChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqMonHocKhongTinhKhoiLuong</c>
	///</summary>
	public enum KcqMonHocKhongTinhKhoiLuongChildEntityTypes
	{
	}
	
	#endregion KcqMonHocKhongTinhKhoiLuongChildEntityTypes
	
	#region KcqMonHocKhongTinhKhoiLuongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqMonHocKhongTinhKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonHocKhongTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonHocKhongTinhKhoiLuongFilterBuilder : SqlFilterBuilder<KcqMonHocKhongTinhKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonHocKhongTinhKhoiLuongFilterBuilder class.
		/// </summary>
		public KcqMonHocKhongTinhKhoiLuongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqMonHocKhongTinhKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqMonHocKhongTinhKhoiLuongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqMonHocKhongTinhKhoiLuongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqMonHocKhongTinhKhoiLuongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqMonHocKhongTinhKhoiLuongFilterBuilder
	
	#region KcqMonHocKhongTinhKhoiLuongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqMonHocKhongTinhKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonHocKhongTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonHocKhongTinhKhoiLuongParameterBuilder : ParameterizedSqlFilterBuilder<KcqMonHocKhongTinhKhoiLuongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonHocKhongTinhKhoiLuongParameterBuilder class.
		/// </summary>
		public KcqMonHocKhongTinhKhoiLuongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqMonHocKhongTinhKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqMonHocKhongTinhKhoiLuongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqMonHocKhongTinhKhoiLuongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqMonHocKhongTinhKhoiLuongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqMonHocKhongTinhKhoiLuongParameterBuilder
	
	#region KcqMonHocKhongTinhKhoiLuongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqMonHocKhongTinhKhoiLuongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonHocKhongTinhKhoiLuong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqMonHocKhongTinhKhoiLuongSortBuilder : SqlSortBuilder<KcqMonHocKhongTinhKhoiLuongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonHocKhongTinhKhoiLuongSqlSortBuilder class.
		/// </summary>
		public KcqMonHocKhongTinhKhoiLuongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqMonHocKhongTinhKhoiLuongSortBuilder
	
} // end namespace
