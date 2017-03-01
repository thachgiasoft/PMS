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
	/// This class is the base class for any <see cref="HeSoTinChiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoTinChiProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoTinChi, PMS.Entities.HeSoTinChiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoTinChiKey key)
		{
			return Delete(transactionManager, key.MaHeDaoTao, key.MaBacDaoTao, key.MaLoaiGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maHeDaoTao">. Primary Key.</param>
		/// <param name="_maBacDaoTao">. Primary Key.</param>
		/// <param name="_maLoaiGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maHeDaoTao, System.String _maBacDaoTao, System.String _maLoaiGiangVien)
		{
			return Delete(null, _maHeDaoTao, _maBacDaoTao, _maLoaiGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeDaoTao">. Primary Key.</param>
		/// <param name="_maBacDaoTao">. Primary Key.</param>
		/// <param name="_maLoaiGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maHeDaoTao, System.String _maBacDaoTao, System.String _maLoaiGiangVien);		
		
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
		public override PMS.Entities.HeSoTinChi Get(TransactionManager transactionManager, PMS.Entities.HeSoTinChiKey key, int start, int pageLength)
		{
			return GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien(transactionManager, key.MaHeDaoTao, key.MaBacDaoTao, key.MaLoaiGiangVien, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeSoTinChi index.
		/// </summary>
		/// <param name="_maHeDaoTao"></param>
		/// <param name="_maBacDaoTao"></param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoTinChi"/> class.</returns>
		public PMS.Entities.HeSoTinChi GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien(System.String _maHeDaoTao, System.String _maBacDaoTao, System.String _maLoaiGiangVien)
		{
			int count = -1;
			return GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien(null,_maHeDaoTao, _maBacDaoTao, _maLoaiGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoTinChi index.
		/// </summary>
		/// <param name="_maHeDaoTao"></param>
		/// <param name="_maBacDaoTao"></param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoTinChi"/> class.</returns>
		public PMS.Entities.HeSoTinChi GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien(System.String _maHeDaoTao, System.String _maBacDaoTao, System.String _maLoaiGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien(null, _maHeDaoTao, _maBacDaoTao, _maLoaiGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoTinChi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeDaoTao"></param>
		/// <param name="_maBacDaoTao"></param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoTinChi"/> class.</returns>
		public PMS.Entities.HeSoTinChi GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien(TransactionManager transactionManager, System.String _maHeDaoTao, System.String _maBacDaoTao, System.String _maLoaiGiangVien)
		{
			int count = -1;
			return GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien(transactionManager, _maHeDaoTao, _maBacDaoTao, _maLoaiGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoTinChi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeDaoTao"></param>
		/// <param name="_maBacDaoTao"></param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoTinChi"/> class.</returns>
		public PMS.Entities.HeSoTinChi GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien(TransactionManager transactionManager, System.String _maHeDaoTao, System.String _maBacDaoTao, System.String _maLoaiGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien(transactionManager, _maHeDaoTao, _maBacDaoTao, _maLoaiGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoTinChi index.
		/// </summary>
		/// <param name="_maHeDaoTao"></param>
		/// <param name="_maBacDaoTao"></param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoTinChi"/> class.</returns>
		public PMS.Entities.HeSoTinChi GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien(System.String _maHeDaoTao, System.String _maBacDaoTao, System.String _maLoaiGiangVien, int start, int pageLength, out int count)
		{
			return GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien(null, _maHeDaoTao, _maBacDaoTao, _maLoaiGiangVien, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoTinChi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeDaoTao"></param>
		/// <param name="_maBacDaoTao"></param>
		/// <param name="_maLoaiGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoTinChi"/> class.</returns>
		public abstract PMS.Entities.HeSoTinChi GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien(TransactionManager transactionManager, System.String _maHeDaoTao, System.String _maBacDaoTao, System.String _maLoaiGiangVien, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoTinChi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoTinChi&gt;"/></returns>
		public static TList<HeSoTinChi> Fill(IDataReader reader, TList<HeSoTinChi> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoTinChi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoTinChi")
					.Append("|").Append((System.String)reader[((int)HeSoTinChiColumn.MaHeDaoTao - 1)])
					.Append("|").Append((System.String)reader[((int)HeSoTinChiColumn.MaBacDaoTao - 1)])
					.Append("|").Append((System.String)reader[((int)HeSoTinChiColumn.MaLoaiGiangVien - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoTinChi>(
					key.ToString(), // EntityTrackingKey
					"HeSoTinChi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoTinChi();
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
					c.MaHeDaoTao = (System.String)reader[(HeSoTinChiColumn.MaHeDaoTao.ToString())];
					c.OriginalMaHeDaoTao = c.MaHeDaoTao;
					c.MaBacDaoTao = (System.String)reader[(HeSoTinChiColumn.MaBacDaoTao.ToString())];
					c.OriginalMaBacDaoTao = c.MaBacDaoTao;
					c.MaLoaiGiangVien = (System.String)reader[(HeSoTinChiColumn.MaLoaiGiangVien.ToString())];
					c.OriginalMaLoaiGiangVien = c.MaLoaiGiangVien;
					c.HeSoTinChi = (reader[HeSoTinChiColumn.HeSoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoTinChiColumn.HeSoTinChi.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoTinChi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoTinChi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoTinChi entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHeDaoTao = (System.String)reader[(HeSoTinChiColumn.MaHeDaoTao.ToString())];
			entity.OriginalMaHeDaoTao = (System.String)reader["MaHeDaoTao"];
			entity.MaBacDaoTao = (System.String)reader[(HeSoTinChiColumn.MaBacDaoTao.ToString())];
			entity.OriginalMaBacDaoTao = (System.String)reader["MaBacDaoTao"];
			entity.MaLoaiGiangVien = (System.String)reader[(HeSoTinChiColumn.MaLoaiGiangVien.ToString())];
			entity.OriginalMaLoaiGiangVien = (System.String)reader["MaLoaiGiangVien"];
			entity.HeSoTinChi = (reader[HeSoTinChiColumn.HeSoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoTinChiColumn.HeSoTinChi.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoTinChi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoTinChi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoTinChi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHeDaoTao = (System.String)dataRow["MaHeDaoTao"];
			entity.OriginalMaHeDaoTao = (System.String)dataRow["MaHeDaoTao"];
			entity.MaBacDaoTao = (System.String)dataRow["MaBacDaoTao"];
			entity.OriginalMaBacDaoTao = (System.String)dataRow["MaBacDaoTao"];
			entity.MaLoaiGiangVien = (System.String)dataRow["MaLoaiGiangVien"];
			entity.OriginalMaLoaiGiangVien = (System.String)dataRow["MaLoaiGiangVien"];
			entity.HeSoTinChi = Convert.IsDBNull(dataRow["HeSoTinChi"]) ? null : (System.Decimal?)dataRow["HeSoTinChi"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoTinChi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoTinChi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoTinChi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoTinChi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoTinChi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoTinChi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoTinChi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HeSoTinChiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoTinChi</c>
	///</summary>
	public enum HeSoTinChiChildEntityTypes
	{
	}
	
	#endregion HeSoTinChiChildEntityTypes
	
	#region HeSoTinChiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoTinChiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoTinChiFilterBuilder : SqlFilterBuilder<HeSoTinChiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoTinChiFilterBuilder class.
		/// </summary>
		public HeSoTinChiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoTinChiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoTinChiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoTinChiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoTinChiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoTinChiFilterBuilder
	
	#region HeSoTinChiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoTinChiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoTinChiParameterBuilder : ParameterizedSqlFilterBuilder<HeSoTinChiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoTinChiParameterBuilder class.
		/// </summary>
		public HeSoTinChiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoTinChiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoTinChiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoTinChiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoTinChiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoTinChiParameterBuilder
	
	#region HeSoTinChiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoTinChiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoTinChi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoTinChiSortBuilder : SqlSortBuilder<HeSoTinChiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoTinChiSqlSortBuilder class.
		/// </summary>
		public HeSoTinChiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoTinChiSortBuilder
	
} // end namespace
