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
	/// This class is the base class for any <see cref="TruongKhoaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TruongKhoaProviderBaseCore : EntityProviderBase<PMS.Entities.TruongKhoa, PMS.Entities.TruongKhoaKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.TruongKhoaKey key)
		{
			return Delete(transactionManager, key.MaDonVi, key.MaGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maDonVi">. Primary Key.</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maDonVi, System.Int32 _maGiangVien)
		{
			return Delete(null, _maDonVi, _maGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonVi">. Primary Key.</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maDonVi, System.Int32 _maGiangVien);		
		
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
		public override PMS.Entities.TruongKhoa Get(TransactionManager transactionManager, PMS.Entities.TruongKhoaKey key, int start, int pageLength)
		{
			return GetByMaDonViMaGiangVien(transactionManager, key.MaDonVi, key.MaGiangVien, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_TruongKhoa index.
		/// </summary>
		/// <param name="_maDonVi"></param>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TruongKhoa"/> class.</returns>
		public PMS.Entities.TruongKhoa GetByMaDonViMaGiangVien(System.String _maDonVi, System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaDonViMaGiangVien(null,_maDonVi, _maGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TruongKhoa index.
		/// </summary>
		/// <param name="_maDonVi"></param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TruongKhoa"/> class.</returns>
		public PMS.Entities.TruongKhoa GetByMaDonViMaGiangVien(System.String _maDonVi, System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDonViMaGiangVien(null, _maDonVi, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TruongKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonVi"></param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TruongKhoa"/> class.</returns>
		public PMS.Entities.TruongKhoa GetByMaDonViMaGiangVien(TransactionManager transactionManager, System.String _maDonVi, System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaDonViMaGiangVien(transactionManager, _maDonVi, _maGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TruongKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonVi"></param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TruongKhoa"/> class.</returns>
		public PMS.Entities.TruongKhoa GetByMaDonViMaGiangVien(TransactionManager transactionManager, System.String _maDonVi, System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDonViMaGiangVien(transactionManager, _maDonVi, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TruongKhoa index.
		/// </summary>
		/// <param name="_maDonVi"></param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TruongKhoa"/> class.</returns>
		public PMS.Entities.TruongKhoa GetByMaDonViMaGiangVien(System.String _maDonVi, System.Int32 _maGiangVien, int start, int pageLength, out int count)
		{
			return GetByMaDonViMaGiangVien(null, _maDonVi, _maGiangVien, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TruongKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonVi"></param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TruongKhoa"/> class.</returns>
		public abstract PMS.Entities.TruongKhoa GetByMaDonViMaGiangVien(TransactionManager transactionManager, System.String _maDonVi, System.Int32 _maGiangVien, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TruongKhoa&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TruongKhoa&gt;"/></returns>
		public static TList<TruongKhoa> Fill(IDataReader reader, TList<TruongKhoa> rows, int start, int pageLength)
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
				
				PMS.Entities.TruongKhoa c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TruongKhoa")
					.Append("|").Append((System.String)reader[((int)TruongKhoaColumn.MaDonVi - 1)])
					.Append("|").Append((System.Int32)reader[((int)TruongKhoaColumn.MaGiangVien - 1)]).ToString();
					c = EntityManager.LocateOrCreate<TruongKhoa>(
					key.ToString(), // EntityTrackingKey
					"TruongKhoa",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.TruongKhoa();
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
					c.MaDonVi = (System.String)reader[((int)TruongKhoaColumn.MaDonVi - 1)];
					c.OriginalMaDonVi = c.MaDonVi;
					c.MaGiangVien = (System.Int32)reader[((int)TruongKhoaColumn.MaGiangVien - 1)];
					c.OriginalMaGiangVien = c.MaGiangVien;
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TruongKhoa"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TruongKhoa"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.TruongKhoa entity)
		{
			if (!reader.Read()) return;
			
			entity.MaDonVi = (System.String)reader[((int)TruongKhoaColumn.MaDonVi - 1)];
			entity.OriginalMaDonVi = (System.String)reader["MaDonVi"];
			entity.MaGiangVien = (System.Int32)reader[((int)TruongKhoaColumn.MaGiangVien - 1)];
			entity.OriginalMaGiangVien = (System.Int32)reader["MaGiangVien"];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TruongKhoa"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TruongKhoa"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.TruongKhoa entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaDonVi = (System.String)dataRow["MaDonVi"];
			entity.OriginalMaDonVi = (System.String)dataRow["MaDonVi"];
			entity.MaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.OriginalMaGiangVien = (System.Int32)dataRow["MaGiangVien"];
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
		/// <param name="entity">The <see cref="PMS.Entities.TruongKhoa"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.TruongKhoa Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.TruongKhoa entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.TruongKhoa object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.TruongKhoa instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.TruongKhoa Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.TruongKhoa entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region TruongKhoaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.TruongKhoa</c>
	///</summary>
	public enum TruongKhoaChildEntityTypes
	{
	}
	
	#endregion TruongKhoaChildEntityTypes
	
	#region TruongKhoaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TruongKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TruongKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TruongKhoaFilterBuilder : SqlFilterBuilder<TruongKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TruongKhoaFilterBuilder class.
		/// </summary>
		public TruongKhoaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TruongKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TruongKhoaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TruongKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TruongKhoaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TruongKhoaFilterBuilder
	
	#region TruongKhoaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TruongKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TruongKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TruongKhoaParameterBuilder : ParameterizedSqlFilterBuilder<TruongKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TruongKhoaParameterBuilder class.
		/// </summary>
		public TruongKhoaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TruongKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TruongKhoaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TruongKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TruongKhoaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TruongKhoaParameterBuilder
	
	#region TruongKhoaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TruongKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TruongKhoa"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TruongKhoaSortBuilder : SqlSortBuilder<TruongKhoaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TruongKhoaSqlSortBuilder class.
		/// </summary>
		public TruongKhoaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TruongKhoaSortBuilder
	
} // end namespace
