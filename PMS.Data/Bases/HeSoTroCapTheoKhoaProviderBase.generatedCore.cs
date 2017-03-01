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
	/// This class is the base class for any <see cref="HeSoTroCapTheoKhoaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoTroCapTheoKhoaProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoTroCapTheoKhoa, PMS.Entities.HeSoTroCapTheoKhoaKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoTroCapTheoKhoaKey key)
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
		public override PMS.Entities.HeSoTroCapTheoKhoa Get(TransactionManager transactionManager, PMS.Entities.HeSoTroCapTheoKhoaKey key, int start, int pageLength)
		{
			return GetByMaKhoa(transactionManager, key.MaKhoa, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeSoTroCapTheoKhoa index.
		/// </summary>
		/// <param name="_maKhoa"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoTroCapTheoKhoa"/> class.</returns>
		public PMS.Entities.HeSoTroCapTheoKhoa GetByMaKhoa(System.String _maKhoa)
		{
			int count = -1;
			return GetByMaKhoa(null,_maKhoa, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoTroCapTheoKhoa index.
		/// </summary>
		/// <param name="_maKhoa"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoTroCapTheoKhoa"/> class.</returns>
		public PMS.Entities.HeSoTroCapTheoKhoa GetByMaKhoa(System.String _maKhoa, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoa(null, _maKhoa, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoTroCapTheoKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoa"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoTroCapTheoKhoa"/> class.</returns>
		public PMS.Entities.HeSoTroCapTheoKhoa GetByMaKhoa(TransactionManager transactionManager, System.String _maKhoa)
		{
			int count = -1;
			return GetByMaKhoa(transactionManager, _maKhoa, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoTroCapTheoKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoa"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoTroCapTheoKhoa"/> class.</returns>
		public PMS.Entities.HeSoTroCapTheoKhoa GetByMaKhoa(TransactionManager transactionManager, System.String _maKhoa, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoa(transactionManager, _maKhoa, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoTroCapTheoKhoa index.
		/// </summary>
		/// <param name="_maKhoa"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoTroCapTheoKhoa"/> class.</returns>
		public PMS.Entities.HeSoTroCapTheoKhoa GetByMaKhoa(System.String _maKhoa, int start, int pageLength, out int count)
		{
			return GetByMaKhoa(null, _maKhoa, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoTroCapTheoKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoa"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoTroCapTheoKhoa"/> class.</returns>
		public abstract PMS.Entities.HeSoTroCapTheoKhoa GetByMaKhoa(TransactionManager transactionManager, System.String _maKhoa, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HeSoTroCapTheoKhoa_GetByMaGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoTroCapTheoKhoa_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVien(System.String maGiangVien, ref System.Double heSo)
		{
			 GetByMaGiangVien(null, 0, int.MaxValue , maGiangVien, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoTroCapTheoKhoa_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVien(int start, int pageLength, System.String maGiangVien, ref System.Double heSo)
		{
			 GetByMaGiangVien(null, start, pageLength , maGiangVien, ref heSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoTroCapTheoKhoa_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByMaGiangVien(TransactionManager transactionManager, System.String maGiangVien, ref System.Double heSo)
		{
			 GetByMaGiangVien(transactionManager, 0, int.MaxValue , maGiangVien, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoTroCapTheoKhoa_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByMaGiangVien(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVien, ref System.Double heSo);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoTroCapTheoKhoa&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoTroCapTheoKhoa&gt;"/></returns>
		public static TList<HeSoTroCapTheoKhoa> Fill(IDataReader reader, TList<HeSoTroCapTheoKhoa> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoTroCapTheoKhoa c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoTroCapTheoKhoa")
					.Append("|").Append((System.String)reader[((int)HeSoTroCapTheoKhoaColumn.MaKhoa - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoTroCapTheoKhoa>(
					key.ToString(), // EntityTrackingKey
					"HeSoTroCapTheoKhoa",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoTroCapTheoKhoa();
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
					c.MaKhoa = (System.String)reader[(HeSoTroCapTheoKhoaColumn.MaKhoa.ToString())];
					c.OriginalMaKhoa = c.MaKhoa;
					c.TenKhoa = (reader[HeSoTroCapTheoKhoaColumn.TenKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoTroCapTheoKhoaColumn.TenKhoa.ToString())];
					c.HeSo = (reader[HeSoTroCapTheoKhoaColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoTroCapTheoKhoaColumn.HeSo.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoTroCapTheoKhoa"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoTroCapTheoKhoa"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoTroCapTheoKhoa entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKhoa = (System.String)reader[(HeSoTroCapTheoKhoaColumn.MaKhoa.ToString())];
			entity.OriginalMaKhoa = (System.String)reader["MaKhoa"];
			entity.TenKhoa = (reader[HeSoTroCapTheoKhoaColumn.TenKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoTroCapTheoKhoaColumn.TenKhoa.ToString())];
			entity.HeSo = (reader[HeSoTroCapTheoKhoaColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoTroCapTheoKhoaColumn.HeSo.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoTroCapTheoKhoa"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoTroCapTheoKhoa"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoTroCapTheoKhoa entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoa = (System.String)dataRow["MaKhoa"];
			entity.OriginalMaKhoa = (System.String)dataRow["MaKhoa"];
			entity.TenKhoa = Convert.IsDBNull(dataRow["TenKhoa"]) ? null : (System.String)dataRow["TenKhoa"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoTroCapTheoKhoa"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoTroCapTheoKhoa Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoTroCapTheoKhoa entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoTroCapTheoKhoa object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoTroCapTheoKhoa instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoTroCapTheoKhoa Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoTroCapTheoKhoa entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HeSoTroCapTheoKhoaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoTroCapTheoKhoa</c>
	///</summary>
	public enum HeSoTroCapTheoKhoaChildEntityTypes
	{
	}
	
	#endregion HeSoTroCapTheoKhoaChildEntityTypes
	
	#region HeSoTroCapTheoKhoaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoTroCapTheoKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoTroCapTheoKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoTroCapTheoKhoaFilterBuilder : SqlFilterBuilder<HeSoTroCapTheoKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoTroCapTheoKhoaFilterBuilder class.
		/// </summary>
		public HeSoTroCapTheoKhoaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoTroCapTheoKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoTroCapTheoKhoaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoTroCapTheoKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoTroCapTheoKhoaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoTroCapTheoKhoaFilterBuilder
	
	#region HeSoTroCapTheoKhoaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoTroCapTheoKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoTroCapTheoKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoTroCapTheoKhoaParameterBuilder : ParameterizedSqlFilterBuilder<HeSoTroCapTheoKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoTroCapTheoKhoaParameterBuilder class.
		/// </summary>
		public HeSoTroCapTheoKhoaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoTroCapTheoKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoTroCapTheoKhoaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoTroCapTheoKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoTroCapTheoKhoaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoTroCapTheoKhoaParameterBuilder
	
	#region HeSoTroCapTheoKhoaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoTroCapTheoKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoTroCapTheoKhoa"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoTroCapTheoKhoaSortBuilder : SqlSortBuilder<HeSoTroCapTheoKhoaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoTroCapTheoKhoaSqlSortBuilder class.
		/// </summary>
		public HeSoTroCapTheoKhoaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoTroCapTheoKhoaSortBuilder
	
} // end namespace
