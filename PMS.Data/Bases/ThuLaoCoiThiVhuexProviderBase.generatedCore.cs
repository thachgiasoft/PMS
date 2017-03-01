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
	/// This class is the base class for any <see cref="ThuLaoCoiThiVhuexProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThuLaoCoiThiVhuexProviderBaseCore : EntityProviderBase<PMS.Entities.ThuLaoCoiThiVhuex, PMS.Entities.ThuLaoCoiThiVhuexKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThiVhuexKey key)
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
		public override PMS.Entities.ThuLaoCoiThiVhuex Get(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThiVhuexKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThuLaoCoiThiVHUEX index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiVhuex GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiVHUEX index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiVhuex GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiVHUEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiVhuex GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiVHUEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiVhuex GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiVHUEX index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiVhuex GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiVHUEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiVhuex"/> class.</returns>
		public abstract PMS.Entities.ThuLaoCoiThiVhuex GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThuLaoCoiThiVhuex&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThuLaoCoiThiVhuex&gt;"/></returns>
		public static TList<ThuLaoCoiThiVhuex> Fill(IDataReader reader, TList<ThuLaoCoiThiVhuex> rows, int start, int pageLength)
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
				
				PMS.Entities.ThuLaoCoiThiVhuex c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThuLaoCoiThiVhuex")
					.Append("|").Append((System.Int32)reader[((int)ThuLaoCoiThiVhuexColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThuLaoCoiThiVhuex>(
					key.ToString(), // EntityTrackingKey
					"ThuLaoCoiThiVhuex",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThuLaoCoiThiVhuex();
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
					c.Id = (System.Int32)reader[(ThuLaoCoiThiVhuexColumn.Id.ToString())];
					c.NamHoc = (reader[ThuLaoCoiThiVhuexColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuexColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThuLaoCoiThiVhuexColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuexColumn.HocKy.ToString())];
					c.KyThi = (reader[ThuLaoCoiThiVhuexColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuexColumn.KyThi.ToString())];
					c.LanThi = (reader[ThuLaoCoiThiVhuexColumn.LanThi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiVhuexColumn.LanThi.ToString())];
					c.DotThanhToan = (reader[ThuLaoCoiThiVhuexColumn.DotThanhToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuexColumn.DotThanhToan.ToString())];
					c.MaGv = (reader[ThuLaoCoiThiVhuexColumn.MaGv.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuexColumn.MaGv.ToString())];
					c.DotThi = (reader[ThuLaoCoiThiVhuexColumn.DotThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuexColumn.DotThi.ToString())];
					c.SafeName60Phut = (reader[ThuLaoCoiThiVhuexColumn.SafeName60Phut.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuexColumn.SafeName60Phut.ToString())];
					c.SafeName90Phut = (reader[ThuLaoCoiThiVhuexColumn.SafeName90Phut.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuexColumn.SafeName90Phut.ToString())];
					c.SafeName120Phut = (reader[ThuLaoCoiThiVhuexColumn.SafeName120Phut.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuexColumn.SafeName120Phut.ToString())];
					c.SoCa = (reader[ThuLaoCoiThiVhuexColumn.SoCa.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuexColumn.SoCa.ToString())];
					c.GioChuan = (reader[ThuLaoCoiThiVhuexColumn.GioChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuexColumn.GioChuan.ToString())];
					c.UpdateDate = (reader[ThuLaoCoiThiVhuexColumn.UpdateDate.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuLaoCoiThiVhuexColumn.UpdateDate.ToString())];
					c.UpdateStaff = (reader[ThuLaoCoiThiVhuexColumn.UpdateStaff.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuexColumn.UpdateStaff.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoCoiThiVhuex"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoCoiThiVhuex"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThuLaoCoiThiVhuex entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ThuLaoCoiThiVhuexColumn.Id.ToString())];
			entity.NamHoc = (reader[ThuLaoCoiThiVhuexColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuexColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThuLaoCoiThiVhuexColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuexColumn.HocKy.ToString())];
			entity.KyThi = (reader[ThuLaoCoiThiVhuexColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuexColumn.KyThi.ToString())];
			entity.LanThi = (reader[ThuLaoCoiThiVhuexColumn.LanThi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiVhuexColumn.LanThi.ToString())];
			entity.DotThanhToan = (reader[ThuLaoCoiThiVhuexColumn.DotThanhToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuexColumn.DotThanhToan.ToString())];
			entity.MaGv = (reader[ThuLaoCoiThiVhuexColumn.MaGv.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuexColumn.MaGv.ToString())];
			entity.DotThi = (reader[ThuLaoCoiThiVhuexColumn.DotThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuexColumn.DotThi.ToString())];
			entity.SafeName60Phut = (reader[ThuLaoCoiThiVhuexColumn.SafeName60Phut.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuexColumn.SafeName60Phut.ToString())];
			entity.SafeName90Phut = (reader[ThuLaoCoiThiVhuexColumn.SafeName90Phut.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuexColumn.SafeName90Phut.ToString())];
			entity.SafeName120Phut = (reader[ThuLaoCoiThiVhuexColumn.SafeName120Phut.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuexColumn.SafeName120Phut.ToString())];
			entity.SoCa = (reader[ThuLaoCoiThiVhuexColumn.SoCa.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuexColumn.SoCa.ToString())];
			entity.GioChuan = (reader[ThuLaoCoiThiVhuexColumn.GioChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiVhuexColumn.GioChuan.ToString())];
			entity.UpdateDate = (reader[ThuLaoCoiThiVhuexColumn.UpdateDate.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuLaoCoiThiVhuexColumn.UpdateDate.ToString())];
			entity.UpdateStaff = (reader[ThuLaoCoiThiVhuexColumn.UpdateStaff.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiVhuexColumn.UpdateStaff.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoCoiThiVhuex"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoCoiThiVhuex"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThuLaoCoiThiVhuex entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["ID"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.KyThi = Convert.IsDBNull(dataRow["KyThi"]) ? null : (System.String)dataRow["KyThi"];
			entity.LanThi = Convert.IsDBNull(dataRow["LanThi"]) ? null : (System.Int32?)dataRow["LanThi"];
			entity.DotThanhToan = Convert.IsDBNull(dataRow["DotThanhToan"]) ? null : (System.String)dataRow["DotThanhToan"];
			entity.MaGv = Convert.IsDBNull(dataRow["MaGV"]) ? null : (System.String)dataRow["MaGV"];
			entity.DotThi = Convert.IsDBNull(dataRow["DotThi"]) ? null : (System.String)dataRow["DotThi"];
			entity.SafeName60Phut = Convert.IsDBNull(dataRow["60Phut"]) ? null : (System.Decimal?)dataRow["60Phut"];
			entity.SafeName90Phut = Convert.IsDBNull(dataRow["90Phut"]) ? null : (System.Decimal?)dataRow["90Phut"];
			entity.SafeName120Phut = Convert.IsDBNull(dataRow["120Phut"]) ? null : (System.Decimal?)dataRow["120Phut"];
			entity.SoCa = Convert.IsDBNull(dataRow["SoCa"]) ? null : (System.Decimal?)dataRow["SoCa"];
			entity.GioChuan = Convert.IsDBNull(dataRow["GioChuan"]) ? null : (System.Decimal?)dataRow["GioChuan"];
			entity.UpdateDate = Convert.IsDBNull(dataRow["UpdateDate"]) ? null : (System.DateTime?)dataRow["UpdateDate"];
			entity.UpdateStaff = Convert.IsDBNull(dataRow["UpdateStaff"]) ? null : (System.String)dataRow["UpdateStaff"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoCoiThiVhuex"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoCoiThiVhuex Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThiVhuex entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThuLaoCoiThiVhuex object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThuLaoCoiThiVhuex instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoCoiThiVhuex Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThiVhuex entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThuLaoCoiThiVhuexChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThuLaoCoiThiVhuex</c>
	///</summary>
	public enum ThuLaoCoiThiVhuexChildEntityTypes
	{
	}
	
	#endregion ThuLaoCoiThiVhuexChildEntityTypes
	
	#region ThuLaoCoiThiVhuexFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThuLaoCoiThiVhuexColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiVhuex"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiVhuexFilterBuilder : SqlFilterBuilder<ThuLaoCoiThiVhuexColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuexFilterBuilder class.
		/// </summary>
		public ThuLaoCoiThiVhuexFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuexFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoCoiThiVhuexFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuexFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoCoiThiVhuexFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoCoiThiVhuexFilterBuilder
	
	#region ThuLaoCoiThiVhuexParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThuLaoCoiThiVhuexColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiVhuex"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiVhuexParameterBuilder : ParameterizedSqlFilterBuilder<ThuLaoCoiThiVhuexColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuexParameterBuilder class.
		/// </summary>
		public ThuLaoCoiThiVhuexParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuexParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoCoiThiVhuexParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuexParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoCoiThiVhuexParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoCoiThiVhuexParameterBuilder
	
	#region ThuLaoCoiThiVhuexSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThuLaoCoiThiVhuexColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiVhuex"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThuLaoCoiThiVhuexSortBuilder : SqlSortBuilder<ThuLaoCoiThiVhuexColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuexSqlSortBuilder class.
		/// </summary>
		public ThuLaoCoiThiVhuexSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThuLaoCoiThiVhuexSortBuilder
	
} // end namespace
