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
	/// This class is the base class for any <see cref="ThuLaoRaDeThiVhuexProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThuLaoRaDeThiVhuexProviderBaseCore : EntityProviderBase<PMS.Entities.ThuLaoRaDeThiVhuex, PMS.Entities.ThuLaoRaDeThiVhuexKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThuLaoRaDeThiVhuexKey key)
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
		public override PMS.Entities.ThuLaoRaDeThiVhuex Get(TransactionManager transactionManager, PMS.Entities.ThuLaoRaDeThiVhuexKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThuLaoRaDeThiVHUEX index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoRaDeThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoRaDeThiVhuex GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoRaDeThiVHUEX index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoRaDeThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoRaDeThiVhuex GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoRaDeThiVHUEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoRaDeThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoRaDeThiVhuex GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoRaDeThiVHUEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoRaDeThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoRaDeThiVhuex GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoRaDeThiVHUEX index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoRaDeThiVhuex"/> class.</returns>
		public PMS.Entities.ThuLaoRaDeThiVhuex GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoRaDeThiVHUEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoRaDeThiVhuex"/> class.</returns>
		public abstract PMS.Entities.ThuLaoRaDeThiVhuex GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThuLaoRaDeThiVhuex&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThuLaoRaDeThiVhuex&gt;"/></returns>
		public static TList<ThuLaoRaDeThiVhuex> Fill(IDataReader reader, TList<ThuLaoRaDeThiVhuex> rows, int start, int pageLength)
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
				
				PMS.Entities.ThuLaoRaDeThiVhuex c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThuLaoRaDeThiVhuex")
					.Append("|").Append((System.Int32)reader[((int)ThuLaoRaDeThiVhuexColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThuLaoRaDeThiVhuex>(
					key.ToString(), // EntityTrackingKey
					"ThuLaoRaDeThiVhuex",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThuLaoRaDeThiVhuex();
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
					c.Id = (System.Int32)reader[(ThuLaoRaDeThiVhuexColumn.Id.ToString())];
					c.NamHoc = (reader[ThuLaoRaDeThiVhuexColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeThiVhuexColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThuLaoRaDeThiVhuexColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeThiVhuexColumn.HocKy.ToString())];
					c.KyThi = (reader[ThuLaoRaDeThiVhuexColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeThiVhuexColumn.KyThi.ToString())];
					c.LanThi = (reader[ThuLaoRaDeThiVhuexColumn.LanThi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoRaDeThiVhuexColumn.LanThi.ToString())];
					c.DotThanhToan = (reader[ThuLaoRaDeThiVhuexColumn.DotThanhToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeThiVhuexColumn.DotThanhToan.ToString())];
					c.MaGv = (reader[ThuLaoRaDeThiVhuexColumn.MaGv.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeThiVhuexColumn.MaGv.ToString())];
					c.DotThi = (reader[ThuLaoRaDeThiVhuexColumn.DotThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeThiVhuexColumn.DotThi.ToString())];
					c.TracNghiemDuoi50 = (reader[ThuLaoRaDeThiVhuexColumn.TracNghiemDuoi50.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.TracNghiemDuoi50.ToString())];
					c.TracNghiemTren50 = (reader[ThuLaoRaDeThiVhuexColumn.TracNghiemTren50.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.TracNghiemTren50.ToString())];
					c.TuLuan = (reader[ThuLaoRaDeThiVhuexColumn.TuLuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.TuLuan.ToString())];
					c.TongHop = (reader[ThuLaoRaDeThiVhuexColumn.TongHop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.TongHop.ToString())];
					c.VanDap = (reader[ThuLaoRaDeThiVhuexColumn.VanDap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.VanDap.ToString())];
					c.ThucHanh = (reader[ThuLaoRaDeThiVhuexColumn.ThucHanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.ThucHanh.ToString())];
					c.TieuLuan = (reader[ThuLaoRaDeThiVhuexColumn.TieuLuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.TieuLuan.ToString())];
					c.GioChuan = (reader[ThuLaoRaDeThiVhuexColumn.GioChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.GioChuan.ToString())];
					c.UpdateDate = (reader[ThuLaoRaDeThiVhuexColumn.UpdateDate.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuLaoRaDeThiVhuexColumn.UpdateDate.ToString())];
					c.UpdateStaff = (reader[ThuLaoRaDeThiVhuexColumn.UpdateStaff.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeThiVhuexColumn.UpdateStaff.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoRaDeThiVhuex"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoRaDeThiVhuex"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThuLaoRaDeThiVhuex entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ThuLaoRaDeThiVhuexColumn.Id.ToString())];
			entity.NamHoc = (reader[ThuLaoRaDeThiVhuexColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeThiVhuexColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThuLaoRaDeThiVhuexColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeThiVhuexColumn.HocKy.ToString())];
			entity.KyThi = (reader[ThuLaoRaDeThiVhuexColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeThiVhuexColumn.KyThi.ToString())];
			entity.LanThi = (reader[ThuLaoRaDeThiVhuexColumn.LanThi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoRaDeThiVhuexColumn.LanThi.ToString())];
			entity.DotThanhToan = (reader[ThuLaoRaDeThiVhuexColumn.DotThanhToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeThiVhuexColumn.DotThanhToan.ToString())];
			entity.MaGv = (reader[ThuLaoRaDeThiVhuexColumn.MaGv.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeThiVhuexColumn.MaGv.ToString())];
			entity.DotThi = (reader[ThuLaoRaDeThiVhuexColumn.DotThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeThiVhuexColumn.DotThi.ToString())];
			entity.TracNghiemDuoi50 = (reader[ThuLaoRaDeThiVhuexColumn.TracNghiemDuoi50.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.TracNghiemDuoi50.ToString())];
			entity.TracNghiemTren50 = (reader[ThuLaoRaDeThiVhuexColumn.TracNghiemTren50.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.TracNghiemTren50.ToString())];
			entity.TuLuan = (reader[ThuLaoRaDeThiVhuexColumn.TuLuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.TuLuan.ToString())];
			entity.TongHop = (reader[ThuLaoRaDeThiVhuexColumn.TongHop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.TongHop.ToString())];
			entity.VanDap = (reader[ThuLaoRaDeThiVhuexColumn.VanDap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.VanDap.ToString())];
			entity.ThucHanh = (reader[ThuLaoRaDeThiVhuexColumn.ThucHanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.ThucHanh.ToString())];
			entity.TieuLuan = (reader[ThuLaoRaDeThiVhuexColumn.TieuLuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.TieuLuan.ToString())];
			entity.GioChuan = (reader[ThuLaoRaDeThiVhuexColumn.GioChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoRaDeThiVhuexColumn.GioChuan.ToString())];
			entity.UpdateDate = (reader[ThuLaoRaDeThiVhuexColumn.UpdateDate.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuLaoRaDeThiVhuexColumn.UpdateDate.ToString())];
			entity.UpdateStaff = (reader[ThuLaoRaDeThiVhuexColumn.UpdateStaff.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoRaDeThiVhuexColumn.UpdateStaff.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoRaDeThiVhuex"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoRaDeThiVhuex"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThuLaoRaDeThiVhuex entity)
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
			entity.TracNghiemDuoi50 = Convert.IsDBNull(dataRow["TracNghiemDuoi50"]) ? null : (System.Decimal?)dataRow["TracNghiemDuoi50"];
			entity.TracNghiemTren50 = Convert.IsDBNull(dataRow["TracNghiemTren50"]) ? null : (System.Decimal?)dataRow["TracNghiemTren50"];
			entity.TuLuan = Convert.IsDBNull(dataRow["TuLuan"]) ? null : (System.Decimal?)dataRow["TuLuan"];
			entity.TongHop = Convert.IsDBNull(dataRow["TongHop"]) ? null : (System.Decimal?)dataRow["TongHop"];
			entity.VanDap = Convert.IsDBNull(dataRow["VanDap"]) ? null : (System.Decimal?)dataRow["VanDap"];
			entity.ThucHanh = Convert.IsDBNull(dataRow["ThucHanh"]) ? null : (System.Decimal?)dataRow["ThucHanh"];
			entity.TieuLuan = Convert.IsDBNull(dataRow["TieuLuan"]) ? null : (System.Decimal?)dataRow["TieuLuan"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoRaDeThiVhuex"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoRaDeThiVhuex Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThuLaoRaDeThiVhuex entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThuLaoRaDeThiVhuex object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThuLaoRaDeThiVhuex instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoRaDeThiVhuex Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThuLaoRaDeThiVhuex entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThuLaoRaDeThiVhuexChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThuLaoRaDeThiVhuex</c>
	///</summary>
	public enum ThuLaoRaDeThiVhuexChildEntityTypes
	{
	}
	
	#endregion ThuLaoRaDeThiVhuexChildEntityTypes
	
	#region ThuLaoRaDeThiVhuexFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThuLaoRaDeThiVhuexColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoRaDeThiVhuex"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoRaDeThiVhuexFilterBuilder : SqlFilterBuilder<ThuLaoRaDeThiVhuexColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeThiVhuexFilterBuilder class.
		/// </summary>
		public ThuLaoRaDeThiVhuexFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeThiVhuexFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoRaDeThiVhuexFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeThiVhuexFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoRaDeThiVhuexFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoRaDeThiVhuexFilterBuilder
	
	#region ThuLaoRaDeThiVhuexParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThuLaoRaDeThiVhuexColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoRaDeThiVhuex"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoRaDeThiVhuexParameterBuilder : ParameterizedSqlFilterBuilder<ThuLaoRaDeThiVhuexColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeThiVhuexParameterBuilder class.
		/// </summary>
		public ThuLaoRaDeThiVhuexParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeThiVhuexParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoRaDeThiVhuexParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeThiVhuexParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoRaDeThiVhuexParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoRaDeThiVhuexParameterBuilder
	
	#region ThuLaoRaDeThiVhuexSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThuLaoRaDeThiVhuexColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoRaDeThiVhuex"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThuLaoRaDeThiVhuexSortBuilder : SqlSortBuilder<ThuLaoRaDeThiVhuexColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeThiVhuexSqlSortBuilder class.
		/// </summary>
		public ThuLaoRaDeThiVhuexSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThuLaoRaDeThiVhuexSortBuilder
	
} // end namespace
