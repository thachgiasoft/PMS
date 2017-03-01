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
	/// This class is the base class for any <see cref="PhanLoaiHocPhanChoLopHocPhanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PhanLoaiHocPhanChoLopHocPhanProviderBaseCore : EntityProviderBase<PMS.Entities.PhanLoaiHocPhanChoLopHocPhan, PMS.Entities.PhanLoaiHocPhanChoLopHocPhanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.PhanLoaiHocPhanChoLopHocPhanKey key)
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
		public override PMS.Entities.PhanLoaiHocPhanChoLopHocPhan Get(TransactionManager transactionManager, PMS.Entities.PhanLoaiHocPhanChoLopHocPhanKey key, int start, int pageLength)
		{
			return GetByMaLopHocPhan(transactionManager, key.MaLopHocPhan, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PhanLoaiHocPhanChoLopHocPhan index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanLoaiHocPhanChoLopHocPhan"/> class.</returns>
		public PMS.Entities.PhanLoaiHocPhanChoLopHocPhan GetByMaLopHocPhan(System.String _maLopHocPhan)
		{
			int count = -1;
			return GetByMaLopHocPhan(null,_maLopHocPhan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanLoaiHocPhanChoLopHocPhan index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanLoaiHocPhanChoLopHocPhan"/> class.</returns>
		public PMS.Entities.PhanLoaiHocPhanChoLopHocPhan GetByMaLopHocPhan(System.String _maLopHocPhan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhan(null, _maLopHocPhan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanLoaiHocPhanChoLopHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanLoaiHocPhanChoLopHocPhan"/> class.</returns>
		public PMS.Entities.PhanLoaiHocPhanChoLopHocPhan GetByMaLopHocPhan(TransactionManager transactionManager, System.String _maLopHocPhan)
		{
			int count = -1;
			return GetByMaLopHocPhan(transactionManager, _maLopHocPhan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanLoaiHocPhanChoLopHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanLoaiHocPhanChoLopHocPhan"/> class.</returns>
		public PMS.Entities.PhanLoaiHocPhanChoLopHocPhan GetByMaLopHocPhan(TransactionManager transactionManager, System.String _maLopHocPhan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLopHocPhan(transactionManager, _maLopHocPhan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanLoaiHocPhanChoLopHocPhan index.
		/// </summary>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanLoaiHocPhanChoLopHocPhan"/> class.</returns>
		public PMS.Entities.PhanLoaiHocPhanChoLopHocPhan GetByMaLopHocPhan(System.String _maLopHocPhan, int start, int pageLength, out int count)
		{
			return GetByMaLopHocPhan(null, _maLopHocPhan, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanLoaiHocPhanChoLopHocPhan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanLoaiHocPhanChoLopHocPhan"/> class.</returns>
		public abstract PMS.Entities.PhanLoaiHocPhanChoLopHocPhan GetByMaLopHocPhan(TransactionManager transactionManager, System.String _maLopHocPhan, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_PhanLoaiHocPhanChoLopHocPhan_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_PhanLoaiHocPhanChoLopHocPhan_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanLoaiHocPhanChoLopHocPhan_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_PhanLoaiHocPhanChoLopHocPhan_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanLoaiHocPhanChoLopHocPhan_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PhanLoaiHocPhanChoLopHocPhan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PhanLoaiHocPhanChoLopHocPhan&gt;"/></returns>
		public static TList<PhanLoaiHocPhanChoLopHocPhan> Fill(IDataReader reader, TList<PhanLoaiHocPhanChoLopHocPhan> rows, int start, int pageLength)
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
				
				PMS.Entities.PhanLoaiHocPhanChoLopHocPhan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PhanLoaiHocPhanChoLopHocPhan")
					.Append("|").Append((System.String)reader[((int)PhanLoaiHocPhanChoLopHocPhanColumn.MaLopHocPhan - 1)]).ToString();
					c = EntityManager.LocateOrCreate<PhanLoaiHocPhanChoLopHocPhan>(
					key.ToString(), // EntityTrackingKey
					"PhanLoaiHocPhanChoLopHocPhan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.PhanLoaiHocPhanChoLopHocPhan();
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
					c.MaLopHocPhan = (System.String)reader[(PhanLoaiHocPhanChoLopHocPhanColumn.MaLopHocPhan.ToString())];
					c.OriginalMaLopHocPhan = c.MaLopHocPhan;
					c.MaLoaiHocPhanGanMoi = (reader[PhanLoaiHocPhanChoLopHocPhanColumn.MaLoaiHocPhanGanMoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(PhanLoaiHocPhanChoLopHocPhanColumn.MaLoaiHocPhanGanMoi.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.PhanLoaiHocPhanChoLopHocPhan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.PhanLoaiHocPhanChoLopHocPhan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.PhanLoaiHocPhanChoLopHocPhan entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLopHocPhan = (System.String)reader[(PhanLoaiHocPhanChoLopHocPhanColumn.MaLopHocPhan.ToString())];
			entity.OriginalMaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			entity.MaLoaiHocPhanGanMoi = (reader[PhanLoaiHocPhanChoLopHocPhanColumn.MaLoaiHocPhanGanMoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(PhanLoaiHocPhanChoLopHocPhanColumn.MaLoaiHocPhanGanMoi.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.PhanLoaiHocPhanChoLopHocPhan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.PhanLoaiHocPhanChoLopHocPhan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.PhanLoaiHocPhanChoLopHocPhan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.OriginalMaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.MaLoaiHocPhanGanMoi = Convert.IsDBNull(dataRow["MaLoaiHocPhanGanMoi"]) ? null : (System.String)dataRow["MaLoaiHocPhanGanMoi"];
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
		/// <param name="entity">The <see cref="PMS.Entities.PhanLoaiHocPhanChoLopHocPhan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.PhanLoaiHocPhanChoLopHocPhan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.PhanLoaiHocPhanChoLopHocPhan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.PhanLoaiHocPhanChoLopHocPhan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.PhanLoaiHocPhanChoLopHocPhan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.PhanLoaiHocPhanChoLopHocPhan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.PhanLoaiHocPhanChoLopHocPhan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region PhanLoaiHocPhanChoLopHocPhanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.PhanLoaiHocPhanChoLopHocPhan</c>
	///</summary>
	public enum PhanLoaiHocPhanChoLopHocPhanChildEntityTypes
	{
	}
	
	#endregion PhanLoaiHocPhanChoLopHocPhanChildEntityTypes
	
	#region PhanLoaiHocPhanChoLopHocPhanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PhanLoaiHocPhanChoLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanLoaiHocPhanChoLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanLoaiHocPhanChoLopHocPhanFilterBuilder : SqlFilterBuilder<PhanLoaiHocPhanChoLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanLoaiHocPhanChoLopHocPhanFilterBuilder class.
		/// </summary>
		public PhanLoaiHocPhanChoLopHocPhanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PhanLoaiHocPhanChoLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PhanLoaiHocPhanChoLopHocPhanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PhanLoaiHocPhanChoLopHocPhanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PhanLoaiHocPhanChoLopHocPhanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PhanLoaiHocPhanChoLopHocPhanFilterBuilder
	
	#region PhanLoaiHocPhanChoLopHocPhanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PhanLoaiHocPhanChoLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanLoaiHocPhanChoLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanLoaiHocPhanChoLopHocPhanParameterBuilder : ParameterizedSqlFilterBuilder<PhanLoaiHocPhanChoLopHocPhanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanLoaiHocPhanChoLopHocPhanParameterBuilder class.
		/// </summary>
		public PhanLoaiHocPhanChoLopHocPhanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PhanLoaiHocPhanChoLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PhanLoaiHocPhanChoLopHocPhanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PhanLoaiHocPhanChoLopHocPhanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PhanLoaiHocPhanChoLopHocPhanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PhanLoaiHocPhanChoLopHocPhanParameterBuilder
	
	#region PhanLoaiHocPhanChoLopHocPhanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PhanLoaiHocPhanChoLopHocPhanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanLoaiHocPhanChoLopHocPhan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PhanLoaiHocPhanChoLopHocPhanSortBuilder : SqlSortBuilder<PhanLoaiHocPhanChoLopHocPhanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanLoaiHocPhanChoLopHocPhanSqlSortBuilder class.
		/// </summary>
		public PhanLoaiHocPhanChoLopHocPhanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PhanLoaiHocPhanChoLopHocPhanSortBuilder
	
} // end namespace
