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
	/// This class is the base class for any <see cref="QuyMoKhoaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class QuyMoKhoaProviderBaseCore : EntityProviderBase<PMS.Entities.QuyMoKhoa, PMS.Entities.QuyMoKhoaKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.QuyMoKhoaKey key)
		{
			return Delete(transactionManager, key.MaKhoa);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maKhoa">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maKhoa)
		{
			return Delete(null, _maKhoa);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoa">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maKhoa);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyMoKhoa_DanhMucQuyMon key.
		///		FK_QuyMoKhoa_DanhMucQuyMon Description: 
		/// </summary>
		/// <param name="_idQuyMo"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyMoKhoa objects.</returns>
		public TList<QuyMoKhoa> GetByIdQuyMo(System.Int32? _idQuyMo)
		{
			int count = -1;
			return GetByIdQuyMo(_idQuyMo, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyMoKhoa_DanhMucQuyMon key.
		///		FK_QuyMoKhoa_DanhMucQuyMon Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idQuyMo"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyMoKhoa objects.</returns>
		/// <remarks></remarks>
		public TList<QuyMoKhoa> GetByIdQuyMo(TransactionManager transactionManager, System.Int32? _idQuyMo)
		{
			int count = -1;
			return GetByIdQuyMo(transactionManager, _idQuyMo, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyMoKhoa_DanhMucQuyMon key.
		///		FK_QuyMoKhoa_DanhMucQuyMon Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idQuyMo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyMoKhoa objects.</returns>
		public TList<QuyMoKhoa> GetByIdQuyMo(TransactionManager transactionManager, System.Int32? _idQuyMo, int start, int pageLength)
		{
			int count = -1;
			return GetByIdQuyMo(transactionManager, _idQuyMo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyMoKhoa_DanhMucQuyMon key.
		///		fkQuyMoKhoaDanhMucQuyMon Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_idQuyMo"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyMoKhoa objects.</returns>
		public TList<QuyMoKhoa> GetByIdQuyMo(System.Int32? _idQuyMo, int start, int pageLength)
		{
			int count =  -1;
			return GetByIdQuyMo(null, _idQuyMo, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyMoKhoa_DanhMucQuyMon key.
		///		fkQuyMoKhoaDanhMucQuyMon Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_idQuyMo"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyMoKhoa objects.</returns>
		public TList<QuyMoKhoa> GetByIdQuyMo(System.Int32? _idQuyMo, int start, int pageLength,out int count)
		{
			return GetByIdQuyMo(null, _idQuyMo, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyMoKhoa_DanhMucQuyMon key.
		///		FK_QuyMoKhoa_DanhMucQuyMon Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idQuyMo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyMoKhoa objects.</returns>
		public abstract TList<QuyMoKhoa> GetByIdQuyMo(TransactionManager transactionManager, System.Int32? _idQuyMo, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.QuyMoKhoa Get(TransactionManager transactionManager, PMS.Entities.QuyMoKhoaKey key, int start, int pageLength)
		{
			return GetByMaKhoa(transactionManager, key.MaKhoa, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_QuyMoKhoa index.
		/// </summary>
		/// <param name="_maKhoa"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyMoKhoa"/> class.</returns>
		public PMS.Entities.QuyMoKhoa GetByMaKhoa(System.String _maKhoa)
		{
			int count = -1;
			return GetByMaKhoa(null,_maKhoa, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyMoKhoa index.
		/// </summary>
		/// <param name="_maKhoa"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyMoKhoa"/> class.</returns>
		public PMS.Entities.QuyMoKhoa GetByMaKhoa(System.String _maKhoa, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoa(null, _maKhoa, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyMoKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoa"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyMoKhoa"/> class.</returns>
		public PMS.Entities.QuyMoKhoa GetByMaKhoa(TransactionManager transactionManager, System.String _maKhoa)
		{
			int count = -1;
			return GetByMaKhoa(transactionManager, _maKhoa, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyMoKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoa"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyMoKhoa"/> class.</returns>
		public PMS.Entities.QuyMoKhoa GetByMaKhoa(TransactionManager transactionManager, System.String _maKhoa, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoa(transactionManager, _maKhoa, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyMoKhoa index.
		/// </summary>
		/// <param name="_maKhoa"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyMoKhoa"/> class.</returns>
		public PMS.Entities.QuyMoKhoa GetByMaKhoa(System.String _maKhoa, int start, int pageLength, out int count)
		{
			return GetByMaKhoa(null, _maKhoa, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyMoKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoa"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyMoKhoa"/> class.</returns>
		public abstract PMS.Entities.QuyMoKhoa GetByMaKhoa(TransactionManager transactionManager, System.String _maKhoa, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_QuyMoKhoa_GetQuyMoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_QuyMoKhoa_GetQuyMoKhoa' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyMoKhoa&gt;"/> instance.</returns>
		public TList<QuyMoKhoa> GetQuyMoKhoa()
		{
			return GetQuyMoKhoa(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyMoKhoa_GetQuyMoKhoa' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyMoKhoa&gt;"/> instance.</returns>
		public TList<QuyMoKhoa> GetQuyMoKhoa(int start, int pageLength)
		{
			return GetQuyMoKhoa(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_QuyMoKhoa_GetQuyMoKhoa' stored procedure. 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyMoKhoa&gt;"/> instance.</returns>
		public TList<QuyMoKhoa> GetQuyMoKhoa(TransactionManager transactionManager)
		{
			return GetQuyMoKhoa(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyMoKhoa_GetQuyMoKhoa' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyMoKhoa&gt;"/> instance.</returns>
		public abstract TList<QuyMoKhoa> GetQuyMoKhoa(TransactionManager transactionManager, int start, int pageLength );
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;QuyMoKhoa&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;QuyMoKhoa&gt;"/></returns>
		public static TList<QuyMoKhoa> Fill(IDataReader reader, TList<QuyMoKhoa> rows, int start, int pageLength)
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
				
				PMS.Entities.QuyMoKhoa c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("QuyMoKhoa")
					.Append("|").Append((System.String)reader[((int)QuyMoKhoaColumn.MaKhoa - 1)]).ToString();
					c = EntityManager.LocateOrCreate<QuyMoKhoa>(
					key.ToString(), // EntityTrackingKey
					"QuyMoKhoa",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.QuyMoKhoa();
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
					c.MaKhoa = (System.String)reader[(QuyMoKhoaColumn.MaKhoa.ToString())];
					c.OriginalMaKhoa = c.MaKhoa;
					c.IdQuyMo = (reader[QuyMoKhoaColumn.IdQuyMo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyMoKhoaColumn.IdQuyMo.ToString())];
					c.GhiChu = (reader[QuyMoKhoaColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyMoKhoaColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.QuyMoKhoa"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.QuyMoKhoa"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.QuyMoKhoa entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKhoa = (System.String)reader[(QuyMoKhoaColumn.MaKhoa.ToString())];
			entity.OriginalMaKhoa = (System.String)reader["MaKhoa"];
			entity.IdQuyMo = (reader[QuyMoKhoaColumn.IdQuyMo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyMoKhoaColumn.IdQuyMo.ToString())];
			entity.GhiChu = (reader[QuyMoKhoaColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyMoKhoaColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.QuyMoKhoa"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.QuyMoKhoa"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.QuyMoKhoa entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoa = (System.String)dataRow["MaKhoa"];
			entity.OriginalMaKhoa = (System.String)dataRow["MaKhoa"];
			entity.IdQuyMo = Convert.IsDBNull(dataRow["IdQuyMo"]) ? null : (System.Int32?)dataRow["IdQuyMo"];
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
		/// <param name="entity">The <see cref="PMS.Entities.QuyMoKhoa"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.QuyMoKhoa Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.QuyMoKhoa entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region IdQuyMoSource	
			if (CanDeepLoad(entity, "DanhMucQuyMo|IdQuyMoSource", deepLoadType, innerList) 
				&& entity.IdQuyMoSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.IdQuyMo ?? (int)0);
				DanhMucQuyMo tmpEntity = EntityManager.LocateEntity<DanhMucQuyMo>(EntityLocator.ConstructKeyFromPkItems(typeof(DanhMucQuyMo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.IdQuyMoSource = tmpEntity;
				else
					entity.IdQuyMoSource = DataRepository.DanhMucQuyMoProvider.GetById(transactionManager, (entity.IdQuyMo ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'IdQuyMoSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.IdQuyMoSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.DanhMucQuyMoProvider.DeepLoad(transactionManager, entity.IdQuyMoSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion IdQuyMoSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.QuyMoKhoa object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.QuyMoKhoa instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.QuyMoKhoa Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.QuyMoKhoa entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region IdQuyMoSource
			if (CanDeepSave(entity, "DanhMucQuyMo|IdQuyMoSource", deepSaveType, innerList) 
				&& entity.IdQuyMoSource != null)
			{
				DataRepository.DanhMucQuyMoProvider.Save(transactionManager, entity.IdQuyMoSource);
				entity.IdQuyMo = entity.IdQuyMoSource.Id;
			}
			#endregion 
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
	
	#region QuyMoKhoaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.QuyMoKhoa</c>
	///</summary>
	public enum QuyMoKhoaChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>DanhMucQuyMo</c> at IdQuyMoSource
		///</summary>
		[ChildEntityType(typeof(DanhMucQuyMo))]
		DanhMucQuyMo,
	}
	
	#endregion QuyMoKhoaChildEntityTypes
	
	#region QuyMoKhoaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;QuyMoKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyMoKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyMoKhoaFilterBuilder : SqlFilterBuilder<QuyMoKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyMoKhoaFilterBuilder class.
		/// </summary>
		public QuyMoKhoaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the QuyMoKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public QuyMoKhoaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the QuyMoKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public QuyMoKhoaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion QuyMoKhoaFilterBuilder
	
	#region QuyMoKhoaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;QuyMoKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyMoKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyMoKhoaParameterBuilder : ParameterizedSqlFilterBuilder<QuyMoKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyMoKhoaParameterBuilder class.
		/// </summary>
		public QuyMoKhoaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the QuyMoKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public QuyMoKhoaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the QuyMoKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public QuyMoKhoaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion QuyMoKhoaParameterBuilder
	
	#region QuyMoKhoaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;QuyMoKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyMoKhoa"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class QuyMoKhoaSortBuilder : SqlSortBuilder<QuyMoKhoaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyMoKhoaSqlSortBuilder class.
		/// </summary>
		public QuyMoKhoaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion QuyMoKhoaSortBuilder
	
} // end namespace
