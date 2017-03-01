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
	/// This class is the base class for any <see cref="KcqHeSoDiaDiemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqHeSoDiaDiemProviderBaseCore : EntityProviderBase<PMS.Entities.KcqHeSoDiaDiem, PMS.Entities.KcqHeSoDiaDiemKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqHeSoDiaDiemKey key)
		{
			return Delete(transactionManager, key.MaHeSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maHeSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maHeSo)
		{
			return Delete(null, _maHeSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maHeSo);		
		
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
		public override PMS.Entities.KcqHeSoDiaDiem Get(TransactionManager transactionManager, PMS.Entities.KcqHeSoDiaDiemKey key, int start, int pageLength)
		{
			return GetByMaHeSo(transactionManager, key.MaHeSo, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqHeSoDiaDiem index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqHeSoDiaDiem"/> class.</returns>
		public PMS.Entities.KcqHeSoDiaDiem GetByMaHeSo(System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(null,_maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqHeSoDiaDiem index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqHeSoDiaDiem"/> class.</returns>
		public PMS.Entities.KcqHeSoDiaDiem GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqHeSoDiaDiem index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqHeSoDiaDiem"/> class.</returns>
		public PMS.Entities.KcqHeSoDiaDiem GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqHeSoDiaDiem index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqHeSoDiaDiem"/> class.</returns>
		public PMS.Entities.KcqHeSoDiaDiem GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqHeSoDiaDiem index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqHeSoDiaDiem"/> class.</returns>
		public PMS.Entities.KcqHeSoDiaDiem GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength, out int count)
		{
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqHeSoDiaDiem index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqHeSoDiaDiem"/> class.</returns>
		public abstract PMS.Entities.KcqHeSoDiaDiem GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqHeSoDiaDiem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqHeSoDiaDiem&gt;"/></returns>
		public static TList<KcqHeSoDiaDiem> Fill(IDataReader reader, TList<KcqHeSoDiaDiem> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqHeSoDiaDiem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqHeSoDiaDiem")
					.Append("|").Append((System.Int32)reader[((int)KcqHeSoDiaDiemColumn.MaHeSo - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqHeSoDiaDiem>(
					key.ToString(), // EntityTrackingKey
					"KcqHeSoDiaDiem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqHeSoDiaDiem();
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
					c.MaHeSo = (System.Int32)reader[(KcqHeSoDiaDiemColumn.MaHeSo.ToString())];
					c.Stt = (reader[KcqHeSoDiaDiemColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqHeSoDiaDiemColumn.Stt.ToString())];
					c.MaQuanLy = (reader[KcqHeSoDiaDiemColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqHeSoDiaDiemColumn.MaQuanLy.ToString())];
					c.TenDiaDiem = (reader[KcqHeSoDiaDiemColumn.TenDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqHeSoDiaDiemColumn.TenDiaDiem.ToString())];
					c.HeSoDiaDiem = (reader[KcqHeSoDiaDiemColumn.HeSoDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqHeSoDiaDiemColumn.HeSoDiaDiem.ToString())];
					c.DonGia = (reader[KcqHeSoDiaDiemColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqHeSoDiaDiemColumn.DonGia.ToString())];
					c.TienXeDiaDiem = (reader[KcqHeSoDiaDiemColumn.TienXeDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqHeSoDiaDiemColumn.TienXeDiaDiem.ToString())];
					c.GhiChu = (reader[KcqHeSoDiaDiemColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqHeSoDiaDiemColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqHeSoDiaDiem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqHeSoDiaDiem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqHeSoDiaDiem entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHeSo = (System.Int32)reader[(KcqHeSoDiaDiemColumn.MaHeSo.ToString())];
			entity.Stt = (reader[KcqHeSoDiaDiemColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqHeSoDiaDiemColumn.Stt.ToString())];
			entity.MaQuanLy = (reader[KcqHeSoDiaDiemColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqHeSoDiaDiemColumn.MaQuanLy.ToString())];
			entity.TenDiaDiem = (reader[KcqHeSoDiaDiemColumn.TenDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqHeSoDiaDiemColumn.TenDiaDiem.ToString())];
			entity.HeSoDiaDiem = (reader[KcqHeSoDiaDiemColumn.HeSoDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqHeSoDiaDiemColumn.HeSoDiaDiem.ToString())];
			entity.DonGia = (reader[KcqHeSoDiaDiemColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqHeSoDiaDiemColumn.DonGia.ToString())];
			entity.TienXeDiaDiem = (reader[KcqHeSoDiaDiemColumn.TienXeDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqHeSoDiaDiemColumn.TienXeDiaDiem.ToString())];
			entity.GhiChu = (reader[KcqHeSoDiaDiemColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqHeSoDiaDiemColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqHeSoDiaDiem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqHeSoDiaDiem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqHeSoDiaDiem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHeSo = (System.Int32)dataRow["MaHeSo"];
			entity.Stt = Convert.IsDBNull(dataRow["Stt"]) ? null : (System.Int32?)dataRow["Stt"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.TenDiaDiem = Convert.IsDBNull(dataRow["TenDiaDiem"]) ? null : (System.String)dataRow["TenDiaDiem"];
			entity.HeSoDiaDiem = Convert.IsDBNull(dataRow["HeSoDiaDiem"]) ? null : (System.Decimal?)dataRow["HeSoDiaDiem"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.TienXeDiaDiem = Convert.IsDBNull(dataRow["TienXeDiaDiem"]) ? null : (System.Decimal?)dataRow["TienXeDiaDiem"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqHeSoDiaDiem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqHeSoDiaDiem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqHeSoDiaDiem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqHeSoDiaDiem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqHeSoDiaDiem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqHeSoDiaDiem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqHeSoDiaDiem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KcqHeSoDiaDiemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqHeSoDiaDiem</c>
	///</summary>
	public enum KcqHeSoDiaDiemChildEntityTypes
	{
	}
	
	#endregion KcqHeSoDiaDiemChildEntityTypes
	
	#region KcqHeSoDiaDiemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqHeSoDiaDiemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoDiaDiem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHeSoDiaDiemFilterBuilder : SqlFilterBuilder<KcqHeSoDiaDiemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqHeSoDiaDiemFilterBuilder class.
		/// </summary>
		public KcqHeSoDiaDiemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqHeSoDiaDiemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqHeSoDiaDiemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqHeSoDiaDiemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqHeSoDiaDiemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqHeSoDiaDiemFilterBuilder
	
	#region KcqHeSoDiaDiemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqHeSoDiaDiemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoDiaDiem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHeSoDiaDiemParameterBuilder : ParameterizedSqlFilterBuilder<KcqHeSoDiaDiemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqHeSoDiaDiemParameterBuilder class.
		/// </summary>
		public KcqHeSoDiaDiemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqHeSoDiaDiemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqHeSoDiaDiemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqHeSoDiaDiemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqHeSoDiaDiemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqHeSoDiaDiemParameterBuilder
	
	#region KcqHeSoDiaDiemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqHeSoDiaDiemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoDiaDiem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqHeSoDiaDiemSortBuilder : SqlSortBuilder<KcqHeSoDiaDiemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqHeSoDiaDiemSqlSortBuilder class.
		/// </summary>
		public KcqHeSoDiaDiemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqHeSoDiaDiemSortBuilder
	
} // end namespace
