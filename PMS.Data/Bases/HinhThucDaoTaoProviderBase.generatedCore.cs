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
	/// This class is the base class for any <see cref="HinhThucDaoTaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HinhThucDaoTaoProviderBaseCore : EntityProviderBase<PMS.Entities.HinhThucDaoTao, PMS.Entities.HinhThucDaoTaoKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HinhThucDaoTaoKey key)
		{
			return Delete(transactionManager, key.MaHinhThucDaoTao);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maHinhThucDaoTao">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maHinhThucDaoTao)
		{
			return Delete(null, _maHinhThucDaoTao);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHinhThucDaoTao">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maHinhThucDaoTao);		
		
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
		public override PMS.Entities.HinhThucDaoTao Get(TransactionManager transactionManager, PMS.Entities.HinhThucDaoTaoKey key, int start, int pageLength)
		{
			return GetByMaHinhThucDaoTao(transactionManager, key.MaHinhThucDaoTao, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HinhThucDaoTao index.
		/// </summary>
		/// <param name="_maHinhThucDaoTao"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HinhThucDaoTao"/> class.</returns>
		public PMS.Entities.HinhThucDaoTao GetByMaHinhThucDaoTao(System.String _maHinhThucDaoTao)
		{
			int count = -1;
			return GetByMaHinhThucDaoTao(null,_maHinhThucDaoTao, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HinhThucDaoTao index.
		/// </summary>
		/// <param name="_maHinhThucDaoTao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HinhThucDaoTao"/> class.</returns>
		public PMS.Entities.HinhThucDaoTao GetByMaHinhThucDaoTao(System.String _maHinhThucDaoTao, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHinhThucDaoTao(null, _maHinhThucDaoTao, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HinhThucDaoTao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHinhThucDaoTao"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HinhThucDaoTao"/> class.</returns>
		public PMS.Entities.HinhThucDaoTao GetByMaHinhThucDaoTao(TransactionManager transactionManager, System.String _maHinhThucDaoTao)
		{
			int count = -1;
			return GetByMaHinhThucDaoTao(transactionManager, _maHinhThucDaoTao, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HinhThucDaoTao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHinhThucDaoTao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HinhThucDaoTao"/> class.</returns>
		public PMS.Entities.HinhThucDaoTao GetByMaHinhThucDaoTao(TransactionManager transactionManager, System.String _maHinhThucDaoTao, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHinhThucDaoTao(transactionManager, _maHinhThucDaoTao, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HinhThucDaoTao index.
		/// </summary>
		/// <param name="_maHinhThucDaoTao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HinhThucDaoTao"/> class.</returns>
		public PMS.Entities.HinhThucDaoTao GetByMaHinhThucDaoTao(System.String _maHinhThucDaoTao, int start, int pageLength, out int count)
		{
			return GetByMaHinhThucDaoTao(null, _maHinhThucDaoTao, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HinhThucDaoTao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHinhThucDaoTao"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HinhThucDaoTao"/> class.</returns>
		public abstract PMS.Entities.HinhThucDaoTao GetByMaHinhThucDaoTao(TransactionManager transactionManager, System.String _maHinhThucDaoTao, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HinhThucDaoTao&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HinhThucDaoTao&gt;"/></returns>
		public static TList<HinhThucDaoTao> Fill(IDataReader reader, TList<HinhThucDaoTao> rows, int start, int pageLength)
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
				
				PMS.Entities.HinhThucDaoTao c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HinhThucDaoTao")
					.Append("|").Append((System.String)reader[((int)HinhThucDaoTaoColumn.MaHinhThucDaoTao - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HinhThucDaoTao>(
					key.ToString(), // EntityTrackingKey
					"HinhThucDaoTao",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HinhThucDaoTao();
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
					c.MaHinhThucDaoTao = (System.String)reader[(HinhThucDaoTaoColumn.MaHinhThucDaoTao.ToString())];
					c.OriginalMaHinhThucDaoTao = c.MaHinhThucDaoTao;
					c.TenHinhThucDaoTao = (reader[HinhThucDaoTaoColumn.TenHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(HinhThucDaoTaoColumn.TenHinhThucDaoTao.ToString())];
					c.GhiChu = (reader[HinhThucDaoTaoColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HinhThucDaoTaoColumn.GhiChu.ToString())];
					c.HeSoNhanDonGia = (reader[HinhThucDaoTaoColumn.HeSoNhanDonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HinhThucDaoTaoColumn.HeSoNhanDonGia.ToString())];
					c.TinhGioChuan = (reader[HinhThucDaoTaoColumn.TinhGioChuan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(HinhThucDaoTaoColumn.TinhGioChuan.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HinhThucDaoTao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HinhThucDaoTao"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HinhThucDaoTao entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHinhThucDaoTao = (System.String)reader[(HinhThucDaoTaoColumn.MaHinhThucDaoTao.ToString())];
			entity.OriginalMaHinhThucDaoTao = (System.String)reader["MaHinhThucDaoTao"];
			entity.TenHinhThucDaoTao = (reader[HinhThucDaoTaoColumn.TenHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(HinhThucDaoTaoColumn.TenHinhThucDaoTao.ToString())];
			entity.GhiChu = (reader[HinhThucDaoTaoColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HinhThucDaoTaoColumn.GhiChu.ToString())];
			entity.HeSoNhanDonGia = (reader[HinhThucDaoTaoColumn.HeSoNhanDonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HinhThucDaoTaoColumn.HeSoNhanDonGia.ToString())];
			entity.TinhGioChuan = (reader[HinhThucDaoTaoColumn.TinhGioChuan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(HinhThucDaoTaoColumn.TinhGioChuan.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HinhThucDaoTao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HinhThucDaoTao"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HinhThucDaoTao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHinhThucDaoTao = (System.String)dataRow["MaHinhThucDaoTao"];
			entity.OriginalMaHinhThucDaoTao = (System.String)dataRow["MaHinhThucDaoTao"];
			entity.TenHinhThucDaoTao = Convert.IsDBNull(dataRow["TenHinhThucDaoTao"]) ? null : (System.String)dataRow["TenHinhThucDaoTao"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.HeSoNhanDonGia = Convert.IsDBNull(dataRow["HeSoNhanDonGia"]) ? null : (System.Decimal?)dataRow["HeSoNhanDonGia"];
			entity.TinhGioChuan = Convert.IsDBNull(dataRow["TinhGioChuan"]) ? null : (System.Boolean?)dataRow["TinhGioChuan"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HinhThucDaoTao"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HinhThucDaoTao Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HinhThucDaoTao entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.HinhThucDaoTao object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HinhThucDaoTao instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HinhThucDaoTao Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HinhThucDaoTao entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HinhThucDaoTaoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HinhThucDaoTao</c>
	///</summary>
	public enum HinhThucDaoTaoChildEntityTypes
	{
	}
	
	#endregion HinhThucDaoTaoChildEntityTypes
	
	#region HinhThucDaoTaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HinhThucDaoTaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HinhThucDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HinhThucDaoTaoFilterBuilder : SqlFilterBuilder<HinhThucDaoTaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HinhThucDaoTaoFilterBuilder class.
		/// </summary>
		public HinhThucDaoTaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HinhThucDaoTaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HinhThucDaoTaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HinhThucDaoTaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HinhThucDaoTaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HinhThucDaoTaoFilterBuilder
	
	#region HinhThucDaoTaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HinhThucDaoTaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HinhThucDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HinhThucDaoTaoParameterBuilder : ParameterizedSqlFilterBuilder<HinhThucDaoTaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HinhThucDaoTaoParameterBuilder class.
		/// </summary>
		public HinhThucDaoTaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HinhThucDaoTaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HinhThucDaoTaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HinhThucDaoTaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HinhThucDaoTaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HinhThucDaoTaoParameterBuilder
	
	#region HinhThucDaoTaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HinhThucDaoTaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HinhThucDaoTao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HinhThucDaoTaoSortBuilder : SqlSortBuilder<HinhThucDaoTaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HinhThucDaoTaoSqlSortBuilder class.
		/// </summary>
		public HinhThucDaoTaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HinhThucDaoTaoSortBuilder
	
} // end namespace
