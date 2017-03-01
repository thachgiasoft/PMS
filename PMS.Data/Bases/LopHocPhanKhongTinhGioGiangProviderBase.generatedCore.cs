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
	/// This class is the base class for any <see cref="LopHocPhanKhongTinhGioGiangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LopHocPhanKhongTinhGioGiangProviderBaseCore : EntityProviderBase<PMS.Entities.LopHocPhanKhongTinhGioGiang, PMS.Entities.LopHocPhanKhongTinhGioGiangKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.LopHocPhanKhongTinhGioGiangKey key)
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
		public override PMS.Entities.LopHocPhanKhongTinhGioGiang Get(TransactionManager transactionManager, PMS.Entities.LopHocPhanKhongTinhGioGiangKey key, int start, int pageLength)
		{
			return GetByMaLopHocPhan(transactionManager, key.MaLopHocPhan, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_LopHocPhanKhongTinhGioGiang index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanKhongTinhGioGiang"/> class.</returns>
		public PMS.Entities.LopHocPhanKhongTinhGioGiang GetByMaLopHocPhan(System.String _maLopHocPhan)
		{
			int count = -1;
			return GetByMaLopHocPhan(null,_maLopHocPhan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanKhongTinhGioGiang index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanKhongTinhGioGiang"/> class.</returns>
		public PMS.Entities.LopHocPhanKhongTinhGioGiang GetByMaLopHocPhan(System.String _maLopHocPhan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhan(null, _maLopHocPhan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanKhongTinhGioGiang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanKhongTinhGioGiang"/> class.</returns>
		public PMS.Entities.LopHocPhanKhongTinhGioGiang GetByMaLopHocPhan(TransactionManager transactionManager, System.String _maLopHocPhan)
		{
			int count = -1;
			return GetByMaLopHocPhan(transactionManager, _maLopHocPhan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanKhongTinhGioGiang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanKhongTinhGioGiang"/> class.</returns>
		public PMS.Entities.LopHocPhanKhongTinhGioGiang GetByMaLopHocPhan(TransactionManager transactionManager, System.String _maLopHocPhan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhan(transactionManager, _maLopHocPhan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanKhongTinhGioGiang index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanKhongTinhGioGiang"/> class.</returns>
		public PMS.Entities.LopHocPhanKhongTinhGioGiang GetByMaLopHocPhan(System.String _maLopHocPhan, int start, int pageLength, out int count)
		{
			return GetByMaLopHocPhan(null, _maLopHocPhan, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_LopHocPhanKhongTinhGioGiang index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.LopHocPhanKhongTinhGioGiang"/> class.</returns>
		public abstract PMS.Entities.LopHocPhanKhongTinhGioGiang GetByMaLopHocPhan(TransactionManager transactionManager, System.String _maLopHocPhan, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_LopHocPhanKhongTinhGioGiang_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanKhongTinhGioGiang_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanKhongTinhGioGiang_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanKhongTinhGioGiang_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanKhongTinhGioGiang_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_LopHocPhanKhongTinhGioGiang_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanKhongTinhGioGiang_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanKhongTinhGioGiang_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanKhongTinhGioGiang_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_LopHocPhanKhongTinhGioGiang_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LopHocPhanKhongTinhGioGiang&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LopHocPhanKhongTinhGioGiang&gt;"/></returns>
		public static TList<LopHocPhanKhongTinhGioGiang> Fill(IDataReader reader, TList<LopHocPhanKhongTinhGioGiang> rows, int start, int pageLength)
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
				
				PMS.Entities.LopHocPhanKhongTinhGioGiang c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LopHocPhanKhongTinhGioGiang")
					.Append("|").Append((System.String)reader[((int)LopHocPhanKhongTinhGioGiangColumn.MaLopHocPhan - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LopHocPhanKhongTinhGioGiang>(
					key.ToString(), // EntityTrackingKey
					"LopHocPhanKhongTinhGioGiang",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.LopHocPhanKhongTinhGioGiang();
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
					c.MaLopHocPhan = (System.String)reader[(LopHocPhanKhongTinhGioGiangColumn.MaLopHocPhan.ToString())];
					c.OriginalMaLopHocPhan = c.MaLopHocPhan;
					c.NgayCapNhat = (reader[LopHocPhanKhongTinhGioGiangColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanKhongTinhGioGiangColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[LopHocPhanKhongTinhGioGiangColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanKhongTinhGioGiangColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LopHocPhanKhongTinhGioGiang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanKhongTinhGioGiang"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.LopHocPhanKhongTinhGioGiang entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLopHocPhan = (System.String)reader[(LopHocPhanKhongTinhGioGiangColumn.MaLopHocPhan.ToString())];
			entity.OriginalMaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			entity.NgayCapNhat = (reader[LopHocPhanKhongTinhGioGiangColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanKhongTinhGioGiangColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[LopHocPhanKhongTinhGioGiangColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(LopHocPhanKhongTinhGioGiangColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.LopHocPhanKhongTinhGioGiang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanKhongTinhGioGiang"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.LopHocPhanKhongTinhGioGiang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.OriginalMaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
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
		/// <param name="entity">The <see cref="PMS.Entities.LopHocPhanKhongTinhGioGiang"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.LopHocPhanKhongTinhGioGiang Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.LopHocPhanKhongTinhGioGiang entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.LopHocPhanKhongTinhGioGiang object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.LopHocPhanKhongTinhGioGiang instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.LopHocPhanKhongTinhGioGiang Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.LopHocPhanKhongTinhGioGiang entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region LopHocPhanKhongTinhGioGiangChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.LopHocPhanKhongTinhGioGiang</c>
	///</summary>
	public enum LopHocPhanKhongTinhGioGiangChildEntityTypes
	{
	}
	
	#endregion LopHocPhanKhongTinhGioGiangChildEntityTypes
	
	#region LopHocPhanKhongTinhGioGiangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LopHocPhanKhongTinhGioGiangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanKhongTinhGioGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanKhongTinhGioGiangFilterBuilder : SqlFilterBuilder<LopHocPhanKhongTinhGioGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanKhongTinhGioGiangFilterBuilder class.
		/// </summary>
		public LopHocPhanKhongTinhGioGiangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanKhongTinhGioGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LopHocPhanKhongTinhGioGiangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanKhongTinhGioGiangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LopHocPhanKhongTinhGioGiangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LopHocPhanKhongTinhGioGiangFilterBuilder
	
	#region LopHocPhanKhongTinhGioGiangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LopHocPhanKhongTinhGioGiangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanKhongTinhGioGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanKhongTinhGioGiangParameterBuilder : ParameterizedSqlFilterBuilder<LopHocPhanKhongTinhGioGiangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanKhongTinhGioGiangParameterBuilder class.
		/// </summary>
		public LopHocPhanKhongTinhGioGiangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanKhongTinhGioGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LopHocPhanKhongTinhGioGiangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LopHocPhanKhongTinhGioGiangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LopHocPhanKhongTinhGioGiangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LopHocPhanKhongTinhGioGiangParameterBuilder
	
	#region LopHocPhanKhongTinhGioGiangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LopHocPhanKhongTinhGioGiangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanKhongTinhGioGiang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LopHocPhanKhongTinhGioGiangSortBuilder : SqlSortBuilder<LopHocPhanKhongTinhGioGiangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanKhongTinhGioGiangSqlSortBuilder class.
		/// </summary>
		public LopHocPhanKhongTinhGioGiangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LopHocPhanKhongTinhGioGiangSortBuilder
	
} // end namespace
