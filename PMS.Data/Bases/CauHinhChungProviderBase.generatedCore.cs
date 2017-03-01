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
	/// This class is the base class for any <see cref="CauHinhChungProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CauHinhChungProviderBaseCore : EntityProviderBase<PMS.Entities.CauHinhChung, PMS.Entities.CauHinhChungKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.CauHinhChungKey key)
		{
			return Delete(transactionManager, key.MaCauHinh);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maCauHinh">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maCauHinh)
		{
			return Delete(null, _maCauHinh);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinh">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maCauHinh);		
		
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
		public override PMS.Entities.CauHinhChung Get(TransactionManager transactionManager, PMS.Entities.CauHinhChungKey key, int start, int pageLength)
		{
			return GetByMaCauHinh(transactionManager, key.MaCauHinh, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CauHinhChung index.
		/// </summary>
		/// <param name="_maCauHinh"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhChung"/> class.</returns>
		public PMS.Entities.CauHinhChung GetByMaCauHinh(System.Int32 _maCauHinh)
		{
			int count = -1;
			return GetByMaCauHinh(null,_maCauHinh, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhChung index.
		/// </summary>
		/// <param name="_maCauHinh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhChung"/> class.</returns>
		public PMS.Entities.CauHinhChung GetByMaCauHinh(System.Int32 _maCauHinh, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCauHinh(null, _maCauHinh, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhChung index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinh"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhChung"/> class.</returns>
		public PMS.Entities.CauHinhChung GetByMaCauHinh(TransactionManager transactionManager, System.Int32 _maCauHinh)
		{
			int count = -1;
			return GetByMaCauHinh(transactionManager, _maCauHinh, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhChung index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhChung"/> class.</returns>
		public PMS.Entities.CauHinhChung GetByMaCauHinh(TransactionManager transactionManager, System.Int32 _maCauHinh, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCauHinh(transactionManager, _maCauHinh, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhChung index.
		/// </summary>
		/// <param name="_maCauHinh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhChung"/> class.</returns>
		public PMS.Entities.CauHinhChung GetByMaCauHinh(System.Int32 _maCauHinh, int start, int pageLength, out int count)
		{
			return GetByMaCauHinh(null, _maCauHinh, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinhChung index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinhChung"/> class.</returns>
		public abstract PMS.Entities.CauHinhChung GetByMaCauHinh(TransactionManager transactionManager, System.Int32 _maCauHinh, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_CauHinhChung_GetDeleteFileName 
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChung_GetDeleteFileName' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDeleteFileName()
		{
			return GetDeleteFileName(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChung_GetDeleteFileName' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDeleteFileName(int start, int pageLength)
		{
			return GetDeleteFileName(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_CauHinhChung_GetDeleteFileName' stored procedure. 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDeleteFileName(TransactionManager transactionManager)
		{
			return GetDeleteFileName(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChung_GetDeleteFileName' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetDeleteFileName(TransactionManager transactionManager, int start, int pageLength );
		
		#endregion
		
		#region cust_CauHinhChung_GetHeSoHe 
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChung_GetHeSoHe' stored procedure. 
		/// </summary>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoHe(System.DateTime ngayDay, System.Int32 tietBatDau, ref System.Double reVal)
		{
			 GetHeSoHe(null, 0, int.MaxValue , ngayDay, tietBatDau, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChung_GetHeSoHe' stored procedure. 
		/// </summary>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoHe(int start, int pageLength, System.DateTime ngayDay, System.Int32 tietBatDau, ref System.Double reVal)
		{
			 GetHeSoHe(null, start, pageLength , ngayDay, tietBatDau, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_CauHinhChung_GetHeSoHe' stored procedure. 
		/// </summary>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetHeSoHe(TransactionManager transactionManager, System.DateTime ngayDay, System.Int32 tietBatDau, ref System.Double reVal)
		{
			 GetHeSoHe(transactionManager, 0, int.MaxValue , ngayDay, tietBatDau, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChung_GetHeSoHe' stored procedure. 
		/// </summary>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="tietBatDau"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetHeSoHe(TransactionManager transactionManager, int start, int pageLength , System.DateTime ngayDay, System.Int32 tietBatDau, ref System.Double reVal);
		
		#endregion
		
		#region cust_CauHinhChung_GetUpdateFileName 
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChung_GetUpdateFileName' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetUpdateFileName()
		{
			return GetUpdateFileName(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChung_GetUpdateFileName' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetUpdateFileName(int start, int pageLength)
		{
			return GetUpdateFileName(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_CauHinhChung_GetUpdateFileName' stored procedure. 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetUpdateFileName(TransactionManager transactionManager)
		{
			return GetUpdateFileName(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_CauHinhChung_GetUpdateFileName' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetUpdateFileName(TransactionManager transactionManager, int start, int pageLength );
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CauHinhChung&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CauHinhChung&gt;"/></returns>
		public static TList<CauHinhChung> Fill(IDataReader reader, TList<CauHinhChung> rows, int start, int pageLength)
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
				
				PMS.Entities.CauHinhChung c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CauHinhChung")
					.Append("|").Append((System.Int32)reader[((int)CauHinhChungColumn.MaCauHinh - 1)]).ToString();
					c = EntityManager.LocateOrCreate<CauHinhChung>(
					key.ToString(), // EntityTrackingKey
					"CauHinhChung",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.CauHinhChung();
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
					c.MaCauHinh = (System.Int32)reader[(CauHinhChungColumn.MaCauHinh.ToString())];
					c.TenCauHinh = (reader[CauHinhChungColumn.TenCauHinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhChungColumn.TenCauHinh.ToString())];
					c.GiaTri = (reader[CauHinhChungColumn.GiaTri.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhChungColumn.GiaTri.ToString())];
					c.NgayCapNhat = (reader[CauHinhChungColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(CauHinhChungColumn.NgayCapNhat.ToString())];
					c.GhiChu = (reader[CauHinhChungColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhChungColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CauHinhChung"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CauHinhChung"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.CauHinhChung entity)
		{
			if (!reader.Read()) return;
			
			entity.MaCauHinh = (System.Int32)reader[(CauHinhChungColumn.MaCauHinh.ToString())];
			entity.TenCauHinh = (reader[CauHinhChungColumn.TenCauHinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhChungColumn.TenCauHinh.ToString())];
			entity.GiaTri = (reader[CauHinhChungColumn.GiaTri.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhChungColumn.GiaTri.ToString())];
			entity.NgayCapNhat = (reader[CauHinhChungColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(CauHinhChungColumn.NgayCapNhat.ToString())];
			entity.GhiChu = (reader[CauHinhChungColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhChungColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CauHinhChung"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CauHinhChung"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.CauHinhChung entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaCauHinh = (System.Int32)dataRow["MaCauHinh"];
			entity.TenCauHinh = Convert.IsDBNull(dataRow["TenCauHinh"]) ? null : (System.String)dataRow["TenCauHinh"];
			entity.GiaTri = Convert.IsDBNull(dataRow["GiaTri"]) ? null : (System.String)dataRow["GiaTri"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
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
		/// <param name="entity">The <see cref="PMS.Entities.CauHinhChung"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.CauHinhChung Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.CauHinhChung entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.CauHinhChung object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.CauHinhChung instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.CauHinhChung Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.CauHinhChung entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region CauHinhChungChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.CauHinhChung</c>
	///</summary>
	public enum CauHinhChungChildEntityTypes
	{
	}
	
	#endregion CauHinhChungChildEntityTypes
	
	#region CauHinhChungFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CauHinhChungColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhChung"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhChungFilterBuilder : SqlFilterBuilder<CauHinhChungColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhChungFilterBuilder class.
		/// </summary>
		public CauHinhChungFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CauHinhChungFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CauHinhChungFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CauHinhChungFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CauHinhChungFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CauHinhChungFilterBuilder
	
	#region CauHinhChungParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CauHinhChungColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhChung"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhChungParameterBuilder : ParameterizedSqlFilterBuilder<CauHinhChungColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhChungParameterBuilder class.
		/// </summary>
		public CauHinhChungParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CauHinhChungParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CauHinhChungParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CauHinhChungParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CauHinhChungParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CauHinhChungParameterBuilder
	
	#region CauHinhChungSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CauHinhChungColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhChung"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CauHinhChungSortBuilder : SqlSortBuilder<CauHinhChungColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhChungSqlSortBuilder class.
		/// </summary>
		public CauHinhChungSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CauHinhChungSortBuilder
	
} // end namespace
