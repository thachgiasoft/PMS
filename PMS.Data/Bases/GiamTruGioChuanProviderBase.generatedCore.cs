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
	/// This class is the base class for any <see cref="GiamTruGioChuanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiamTruGioChuanProviderBaseCore : EntityProviderBase<PMS.Entities.GiamTruGioChuan, PMS.Entities.GiamTruGioChuanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiamTruGioChuanKey key)
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
		public override PMS.Entities.GiamTruGioChuan Get(TransactionManager transactionManager, PMS.Entities.GiamTruGioChuanKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiamTruGioChuan index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiamTruGioChuan"/> class.</returns>
		public PMS.Entities.GiamTruGioChuan GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiamTruGioChuan index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiamTruGioChuan"/> class.</returns>
		public PMS.Entities.GiamTruGioChuan GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiamTruGioChuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiamTruGioChuan"/> class.</returns>
		public PMS.Entities.GiamTruGioChuan GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiamTruGioChuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiamTruGioChuan"/> class.</returns>
		public PMS.Entities.GiamTruGioChuan GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiamTruGioChuan index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiamTruGioChuan"/> class.</returns>
		public PMS.Entities.GiamTruGioChuan GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiamTruGioChuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiamTruGioChuan"/> class.</returns>
		public abstract PMS.Entities.GiamTruGioChuan GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiamTruGioChuan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiamTruGioChuan&gt;"/></returns>
		public static TList<GiamTruGioChuan> Fill(IDataReader reader, TList<GiamTruGioChuan> rows, int start, int pageLength)
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
				
				PMS.Entities.GiamTruGioChuan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiamTruGioChuan")
					.Append("|").Append((System.Int32)reader[((int)GiamTruGioChuanColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiamTruGioChuan>(
					key.ToString(), // EntityTrackingKey
					"GiamTruGioChuan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiamTruGioChuan();
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
					c.Id = (System.Int32)reader[(GiamTruGioChuanColumn.Id.ToString())];
					c.NamHoc = (reader[GiamTruGioChuanColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruGioChuanColumn.NamHoc.ToString())];
					c.HocKy = (reader[GiamTruGioChuanColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruGioChuanColumn.HocKy.ToString())];
					c.MaGiangVien = (reader[GiamTruGioChuanColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiamTruGioChuanColumn.MaGiangVien.ToString())];
					c.GioGiamChatLuongCao = (reader[GiamTruGioChuanColumn.GioGiamChatLuongCao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiamTruGioChuanColumn.GioGiamChatLuongCao.ToString())];
					c.GioGiamSauDaiHoc = (reader[GiamTruGioChuanColumn.GioGiamSauDaiHoc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiamTruGioChuanColumn.GioGiamSauDaiHoc.ToString())];
					c.GioGiamNckh = (reader[GiamTruGioChuanColumn.GioGiamNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiamTruGioChuanColumn.GioGiamNckh.ToString())];
					c.GhiChu = (reader[GiamTruGioChuanColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruGioChuanColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[GiamTruGioChuanColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiamTruGioChuanColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[GiamTruGioChuanColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruGioChuanColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiamTruGioChuan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiamTruGioChuan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiamTruGioChuan entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(GiamTruGioChuanColumn.Id.ToString())];
			entity.NamHoc = (reader[GiamTruGioChuanColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruGioChuanColumn.NamHoc.ToString())];
			entity.HocKy = (reader[GiamTruGioChuanColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruGioChuanColumn.HocKy.ToString())];
			entity.MaGiangVien = (reader[GiamTruGioChuanColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiamTruGioChuanColumn.MaGiangVien.ToString())];
			entity.GioGiamChatLuongCao = (reader[GiamTruGioChuanColumn.GioGiamChatLuongCao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiamTruGioChuanColumn.GioGiamChatLuongCao.ToString())];
			entity.GioGiamSauDaiHoc = (reader[GiamTruGioChuanColumn.GioGiamSauDaiHoc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiamTruGioChuanColumn.GioGiamSauDaiHoc.ToString())];
			entity.GioGiamNckh = (reader[GiamTruGioChuanColumn.GioGiamNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiamTruGioChuanColumn.GioGiamNckh.ToString())];
			entity.GhiChu = (reader[GiamTruGioChuanColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruGioChuanColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[GiamTruGioChuanColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiamTruGioChuanColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[GiamTruGioChuanColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiamTruGioChuanColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiamTruGioChuan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiamTruGioChuan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiamTruGioChuan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.GioGiamChatLuongCao = Convert.IsDBNull(dataRow["GioGiamChatLuongCao"]) ? null : (System.Decimal?)dataRow["GioGiamChatLuongCao"];
			entity.GioGiamSauDaiHoc = Convert.IsDBNull(dataRow["GioGiamSauDaiHoc"]) ? null : (System.Decimal?)dataRow["GioGiamSauDaiHoc"];
			entity.GioGiamNckh = Convert.IsDBNull(dataRow["GioGiamNckh"]) ? null : (System.Decimal?)dataRow["GioGiamNckh"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiamTruGioChuan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiamTruGioChuan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiamTruGioChuan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.GiamTruGioChuan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiamTruGioChuan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiamTruGioChuan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiamTruGioChuan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GiamTruGioChuanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiamTruGioChuan</c>
	///</summary>
	public enum GiamTruGioChuanChildEntityTypes
	{
	}
	
	#endregion GiamTruGioChuanChildEntityTypes
	
	#region GiamTruGioChuanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiamTruGioChuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiamTruGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiamTruGioChuanFilterBuilder : SqlFilterBuilder<GiamTruGioChuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiamTruGioChuanFilterBuilder class.
		/// </summary>
		public GiamTruGioChuanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiamTruGioChuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiamTruGioChuanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiamTruGioChuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiamTruGioChuanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiamTruGioChuanFilterBuilder
	
	#region GiamTruGioChuanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiamTruGioChuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiamTruGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiamTruGioChuanParameterBuilder : ParameterizedSqlFilterBuilder<GiamTruGioChuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiamTruGioChuanParameterBuilder class.
		/// </summary>
		public GiamTruGioChuanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiamTruGioChuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiamTruGioChuanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiamTruGioChuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiamTruGioChuanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiamTruGioChuanParameterBuilder
	
	#region GiamTruGioChuanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiamTruGioChuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiamTruGioChuan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiamTruGioChuanSortBuilder : SqlSortBuilder<GiamTruGioChuanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiamTruGioChuanSqlSortBuilder class.
		/// </summary>
		public GiamTruGioChuanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiamTruGioChuanSortBuilder
	
} // end namespace
