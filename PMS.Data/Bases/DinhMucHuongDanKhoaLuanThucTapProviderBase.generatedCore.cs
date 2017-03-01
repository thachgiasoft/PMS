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
	/// This class is the base class for any <see cref="DinhMucHuongDanKhoaLuanThucTapProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DinhMucHuongDanKhoaLuanThucTapProviderBaseCore : EntityProviderBase<PMS.Entities.DinhMucHuongDanKhoaLuanThucTap, PMS.Entities.DinhMucHuongDanKhoaLuanThucTapKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DinhMucHuongDanKhoaLuanThucTapKey key)
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
		public override PMS.Entities.DinhMucHuongDanKhoaLuanThucTap Get(TransactionManager transactionManager, PMS.Entities.DinhMucHuongDanKhoaLuanThucTapKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DinhMucHuongDanKhoaLuanThucTap index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucHuongDanKhoaLuanThucTap"/> class.</returns>
		public PMS.Entities.DinhMucHuongDanKhoaLuanThucTap GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucHuongDanKhoaLuanThucTap index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucHuongDanKhoaLuanThucTap"/> class.</returns>
		public PMS.Entities.DinhMucHuongDanKhoaLuanThucTap GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucHuongDanKhoaLuanThucTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucHuongDanKhoaLuanThucTap"/> class.</returns>
		public PMS.Entities.DinhMucHuongDanKhoaLuanThucTap GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucHuongDanKhoaLuanThucTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucHuongDanKhoaLuanThucTap"/> class.</returns>
		public PMS.Entities.DinhMucHuongDanKhoaLuanThucTap GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucHuongDanKhoaLuanThucTap index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucHuongDanKhoaLuanThucTap"/> class.</returns>
		public PMS.Entities.DinhMucHuongDanKhoaLuanThucTap GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucHuongDanKhoaLuanThucTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucHuongDanKhoaLuanThucTap"/> class.</returns>
		public abstract PMS.Entities.DinhMucHuongDanKhoaLuanThucTap GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DinhMucHuongDanKhoaLuanThucTap&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DinhMucHuongDanKhoaLuanThucTap&gt;"/></returns>
		public static TList<DinhMucHuongDanKhoaLuanThucTap> Fill(IDataReader reader, TList<DinhMucHuongDanKhoaLuanThucTap> rows, int start, int pageLength)
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
				
				PMS.Entities.DinhMucHuongDanKhoaLuanThucTap c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DinhMucHuongDanKhoaLuanThucTap")
					.Append("|").Append((System.Int32)reader[((int)DinhMucHuongDanKhoaLuanThucTapColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DinhMucHuongDanKhoaLuanThucTap>(
					key.ToString(), // EntityTrackingKey
					"DinhMucHuongDanKhoaLuanThucTap",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DinhMucHuongDanKhoaLuanThucTap();
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
					c.Id = (System.Int32)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.Id.ToString())];
					c.MaHinhThucDaoTao = (System.String)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.MaHinhThucDaoTao.ToString())];
					c.MaLoaiKhoiLuong = (System.String)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.MaLoaiKhoiLuong.ToString())];
					c.SoLuong = (reader[DinhMucHuongDanKhoaLuanThucTapColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.SoLuong.ToString())];
					c.MaDonViTinh = (reader[DinhMucHuongDanKhoaLuanThucTapColumn.MaDonViTinh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.MaDonViTinh.ToString())];
					c.GhiChu = (reader[DinhMucHuongDanKhoaLuanThucTapColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[DinhMucHuongDanKhoaLuanThucTapColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[DinhMucHuongDanKhoaLuanThucTapColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.NguoiCapNhat.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DinhMucHuongDanKhoaLuanThucTap"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DinhMucHuongDanKhoaLuanThucTap"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DinhMucHuongDanKhoaLuanThucTap entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.Id.ToString())];
			entity.MaHinhThucDaoTao = (System.String)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.MaHinhThucDaoTao.ToString())];
			entity.MaLoaiKhoiLuong = (System.String)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.MaLoaiKhoiLuong.ToString())];
			entity.SoLuong = (reader[DinhMucHuongDanKhoaLuanThucTapColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.SoLuong.ToString())];
			entity.MaDonViTinh = (reader[DinhMucHuongDanKhoaLuanThucTapColumn.MaDonViTinh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.MaDonViTinh.ToString())];
			entity.GhiChu = (reader[DinhMucHuongDanKhoaLuanThucTapColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[DinhMucHuongDanKhoaLuanThucTapColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[DinhMucHuongDanKhoaLuanThucTapColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucHuongDanKhoaLuanThucTapColumn.NguoiCapNhat.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DinhMucHuongDanKhoaLuanThucTap"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DinhMucHuongDanKhoaLuanThucTap"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DinhMucHuongDanKhoaLuanThucTap entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaHinhThucDaoTao = (System.String)dataRow["MaHinhThucDaoTao"];
			entity.MaLoaiKhoiLuong = (System.String)dataRow["MaLoaiKhoiLuong"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Decimal?)dataRow["SoLuong"];
			entity.MaDonViTinh = Convert.IsDBNull(dataRow["MaDonViTinh"]) ? null : (System.Int32?)dataRow["MaDonViTinh"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DinhMucHuongDanKhoaLuanThucTap"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DinhMucHuongDanKhoaLuanThucTap Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DinhMucHuongDanKhoaLuanThucTap entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.DinhMucHuongDanKhoaLuanThucTap object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DinhMucHuongDanKhoaLuanThucTap instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DinhMucHuongDanKhoaLuanThucTap Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DinhMucHuongDanKhoaLuanThucTap entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region DinhMucHuongDanKhoaLuanThucTapChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DinhMucHuongDanKhoaLuanThucTap</c>
	///</summary>
	public enum DinhMucHuongDanKhoaLuanThucTapChildEntityTypes
	{
	}
	
	#endregion DinhMucHuongDanKhoaLuanThucTapChildEntityTypes
	
	#region DinhMucHuongDanKhoaLuanThucTapFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DinhMucHuongDanKhoaLuanThucTapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucHuongDanKhoaLuanThucTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucHuongDanKhoaLuanThucTapFilterBuilder : SqlFilterBuilder<DinhMucHuongDanKhoaLuanThucTapColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucHuongDanKhoaLuanThucTapFilterBuilder class.
		/// </summary>
		public DinhMucHuongDanKhoaLuanThucTapFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DinhMucHuongDanKhoaLuanThucTapFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DinhMucHuongDanKhoaLuanThucTapFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DinhMucHuongDanKhoaLuanThucTapFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DinhMucHuongDanKhoaLuanThucTapFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DinhMucHuongDanKhoaLuanThucTapFilterBuilder
	
	#region DinhMucHuongDanKhoaLuanThucTapParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DinhMucHuongDanKhoaLuanThucTapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucHuongDanKhoaLuanThucTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucHuongDanKhoaLuanThucTapParameterBuilder : ParameterizedSqlFilterBuilder<DinhMucHuongDanKhoaLuanThucTapColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucHuongDanKhoaLuanThucTapParameterBuilder class.
		/// </summary>
		public DinhMucHuongDanKhoaLuanThucTapParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DinhMucHuongDanKhoaLuanThucTapParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DinhMucHuongDanKhoaLuanThucTapParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DinhMucHuongDanKhoaLuanThucTapParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DinhMucHuongDanKhoaLuanThucTapParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DinhMucHuongDanKhoaLuanThucTapParameterBuilder
	
	#region DinhMucHuongDanKhoaLuanThucTapSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DinhMucHuongDanKhoaLuanThucTapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucHuongDanKhoaLuanThucTap"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DinhMucHuongDanKhoaLuanThucTapSortBuilder : SqlSortBuilder<DinhMucHuongDanKhoaLuanThucTapColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucHuongDanKhoaLuanThucTapSqlSortBuilder class.
		/// </summary>
		public DinhMucHuongDanKhoaLuanThucTapSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DinhMucHuongDanKhoaLuanThucTapSortBuilder
	
} // end namespace
