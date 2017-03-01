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
	/// This class is the base class for any <see cref="ThuLaoChamThiVhuexProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThuLaoChamThiVhuexProviderBaseCore : EntityProviderBase<PMS.Entities.ThuLaoChamThiVhuex, PMS.Entities.ThuLaoChamThiVhuexKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThuLaoChamThiVhuexKey key)
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
		public override PMS.Entities.ThuLaoChamThiVhuex Get(TransactionManager transactionManager, PMS.Entities.ThuLaoChamThiVhuexKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThuLaoChamThiVHUEX index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoChamThiVhuex GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamThiVHUEX index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoChamThiVhuex GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamThiVHUEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoChamThiVhuex GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamThiVHUEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoChamThiVhuex GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamThiVHUEX index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoChamThiVhuex GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamThiVHUEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamThiVhuex"/> class.</returns>
		public abstract PMS.Entities.ThuLaoChamThiVhuex GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThuLaoChamThiVhuex&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThuLaoChamThiVhuex&gt;"/></returns>
		public static TList<ThuLaoChamThiVhuex> Fill(IDataReader reader, TList<ThuLaoChamThiVhuex> rows, int start, int pageLength)
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
				
				PMS.Entities.ThuLaoChamThiVhuex c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThuLaoChamThiVhuex")
					.Append("|").Append((System.Int32)reader[((int)ThuLaoChamThiVhuexColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThuLaoChamThiVhuex>(
					key.ToString(), // EntityTrackingKey
					"ThuLaoChamThiVhuex",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThuLaoChamThiVhuex();
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
					c.Id = (System.Int32)reader[(ThuLaoChamThiVhuexColumn.Id.ToString())];
					c.NamHoc = (reader[ThuLaoChamThiVhuexColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamThiVhuexColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThuLaoChamThiVhuexColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamThiVhuexColumn.HocKy.ToString())];
					c.KyThi = (reader[ThuLaoChamThiVhuexColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamThiVhuexColumn.KyThi.ToString())];
					c.LanThi = (reader[ThuLaoChamThiVhuexColumn.LanThi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamThiVhuexColumn.LanThi.ToString())];
					c.DotThanhToan = (reader[ThuLaoChamThiVhuexColumn.DotThanhToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamThiVhuexColumn.DotThanhToan.ToString())];
					c.MaGv = (reader[ThuLaoChamThiVhuexColumn.MaGv.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamThiVhuexColumn.MaGv.ToString())];
					c.DotThi = (reader[ThuLaoChamThiVhuexColumn.DotThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamThiVhuexColumn.DotThi.ToString())];
					c.GiuaKy = (reader[ThuLaoChamThiVhuexColumn.GiuaKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.GiuaKy.ToString())];
					c.TracNghiem = (reader[ThuLaoChamThiVhuexColumn.TracNghiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.TracNghiem.ToString())];
					c.TuLuan = (reader[ThuLaoChamThiVhuexColumn.TuLuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.TuLuan.ToString())];
					c.TongHop = (reader[ThuLaoChamThiVhuexColumn.TongHop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.TongHop.ToString())];
					c.VanDap = (reader[ThuLaoChamThiVhuexColumn.VanDap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.VanDap.ToString())];
					c.TieuLuan = (reader[ThuLaoChamThiVhuexColumn.TieuLuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.TieuLuan.ToString())];
					c.ThucHanh = (reader[ThuLaoChamThiVhuexColumn.ThucHanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.ThucHanh.ToString())];
					c.DoAn = (reader[ThuLaoChamThiVhuexColumn.DoAn.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.DoAn.ToString())];
					c.UpdateDate = (reader[ThuLaoChamThiVhuexColumn.UpdateDate.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuLaoChamThiVhuexColumn.UpdateDate.ToString())];
					c.UpdateStaff = (reader[ThuLaoChamThiVhuexColumn.UpdateStaff.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamThiVhuexColumn.UpdateStaff.ToString())];
					c.GioChuan = (reader[ThuLaoChamThiVhuexColumn.GioChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.GioChuan.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoChamThiVhuex"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoChamThiVhuex"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThuLaoChamThiVhuex entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ThuLaoChamThiVhuexColumn.Id.ToString())];
			entity.NamHoc = (reader[ThuLaoChamThiVhuexColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamThiVhuexColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThuLaoChamThiVhuexColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamThiVhuexColumn.HocKy.ToString())];
			entity.KyThi = (reader[ThuLaoChamThiVhuexColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamThiVhuexColumn.KyThi.ToString())];
			entity.LanThi = (reader[ThuLaoChamThiVhuexColumn.LanThi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamThiVhuexColumn.LanThi.ToString())];
			entity.DotThanhToan = (reader[ThuLaoChamThiVhuexColumn.DotThanhToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamThiVhuexColumn.DotThanhToan.ToString())];
			entity.MaGv = (reader[ThuLaoChamThiVhuexColumn.MaGv.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamThiVhuexColumn.MaGv.ToString())];
			entity.DotThi = (reader[ThuLaoChamThiVhuexColumn.DotThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamThiVhuexColumn.DotThi.ToString())];
			entity.GiuaKy = (reader[ThuLaoChamThiVhuexColumn.GiuaKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.GiuaKy.ToString())];
			entity.TracNghiem = (reader[ThuLaoChamThiVhuexColumn.TracNghiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.TracNghiem.ToString())];
			entity.TuLuan = (reader[ThuLaoChamThiVhuexColumn.TuLuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.TuLuan.ToString())];
			entity.TongHop = (reader[ThuLaoChamThiVhuexColumn.TongHop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.TongHop.ToString())];
			entity.VanDap = (reader[ThuLaoChamThiVhuexColumn.VanDap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.VanDap.ToString())];
			entity.TieuLuan = (reader[ThuLaoChamThiVhuexColumn.TieuLuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.TieuLuan.ToString())];
			entity.ThucHanh = (reader[ThuLaoChamThiVhuexColumn.ThucHanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.ThucHanh.ToString())];
			entity.DoAn = (reader[ThuLaoChamThiVhuexColumn.DoAn.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.DoAn.ToString())];
			entity.UpdateDate = (reader[ThuLaoChamThiVhuexColumn.UpdateDate.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuLaoChamThiVhuexColumn.UpdateDate.ToString())];
			entity.UpdateStaff = (reader[ThuLaoChamThiVhuexColumn.UpdateStaff.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamThiVhuexColumn.UpdateStaff.ToString())];
			entity.GioChuan = (reader[ThuLaoChamThiVhuexColumn.GioChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamThiVhuexColumn.GioChuan.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoChamThiVhuex"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoChamThiVhuex"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThuLaoChamThiVhuex entity)
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
			entity.GiuaKy = Convert.IsDBNull(dataRow["GiuaKy"]) ? null : (System.Decimal?)dataRow["GiuaKy"];
			entity.TracNghiem = Convert.IsDBNull(dataRow["TracNghiem"]) ? null : (System.Decimal?)dataRow["TracNghiem"];
			entity.TuLuan = Convert.IsDBNull(dataRow["TuLuan"]) ? null : (System.Decimal?)dataRow["TuLuan"];
			entity.TongHop = Convert.IsDBNull(dataRow["TongHop"]) ? null : (System.Decimal?)dataRow["TongHop"];
			entity.VanDap = Convert.IsDBNull(dataRow["VanDap"]) ? null : (System.Decimal?)dataRow["VanDap"];
			entity.TieuLuan = Convert.IsDBNull(dataRow["TieuLuan"]) ? null : (System.Decimal?)dataRow["TieuLuan"];
			entity.ThucHanh = Convert.IsDBNull(dataRow["ThucHanh"]) ? null : (System.Decimal?)dataRow["ThucHanh"];
			entity.DoAn = Convert.IsDBNull(dataRow["DoAn"]) ? null : (System.Decimal?)dataRow["DoAn"];
			entity.UpdateDate = Convert.IsDBNull(dataRow["UpdateDate"]) ? null : (System.DateTime?)dataRow["UpdateDate"];
			entity.UpdateStaff = Convert.IsDBNull(dataRow["UpdateStaff"]) ? null : (System.String)dataRow["UpdateStaff"];
			entity.GioChuan = Convert.IsDBNull(dataRow["GioChuan"]) ? null : (System.Decimal?)dataRow["GioChuan"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoChamThiVhuex"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoChamThiVhuex Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThuLaoChamThiVhuex entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThuLaoChamThiVhuex object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThuLaoChamThiVhuex instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoChamThiVhuex Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThuLaoChamThiVhuex entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThuLaoChamThiVhuexChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThuLaoChamThiVhuex</c>
	///</summary>
	public enum ThuLaoChamThiVhuexChildEntityTypes
	{
	}
	
	#endregion ThuLaoChamThiVhuexChildEntityTypes
	
	#region ThuLaoChamThiVhuexFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThuLaoChamThiVhuexColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamThiVhuex"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamThiVhuexFilterBuilder : SqlFilterBuilder<ThuLaoChamThiVhuexColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamThiVhuexFilterBuilder class.
		/// </summary>
		public ThuLaoChamThiVhuexFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamThiVhuexFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoChamThiVhuexFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamThiVhuexFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoChamThiVhuexFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoChamThiVhuexFilterBuilder
	
	#region ThuLaoChamThiVhuexParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThuLaoChamThiVhuexColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamThiVhuex"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamThiVhuexParameterBuilder : ParameterizedSqlFilterBuilder<ThuLaoChamThiVhuexColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamThiVhuexParameterBuilder class.
		/// </summary>
		public ThuLaoChamThiVhuexParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamThiVhuexParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoChamThiVhuexParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamThiVhuexParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoChamThiVhuexParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoChamThiVhuexParameterBuilder
	
	#region ThuLaoChamThiVhuexSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThuLaoChamThiVhuexColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamThiVhuex"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThuLaoChamThiVhuexSortBuilder : SqlSortBuilder<ThuLaoChamThiVhuexColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamThiVhuexSqlSortBuilder class.
		/// </summary>
		public ThuLaoChamThiVhuexSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThuLaoChamThiVhuexSortBuilder
	
} // end namespace
