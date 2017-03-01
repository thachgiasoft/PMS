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
	/// This class is the base class for any <see cref="SdhDonGiaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SdhDonGiaProviderBaseCore : EntityProviderBase<PMS.Entities.SdhDonGia, PMS.Entities.SdhDonGiaKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.SdhDonGiaKey key)
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
		public override PMS.Entities.SdhDonGia Get(TransactionManager transactionManager, PMS.Entities.SdhDonGiaKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SdhDonGia index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhDonGia"/> class.</returns>
		public PMS.Entities.SdhDonGia GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhDonGia index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhDonGia"/> class.</returns>
		public PMS.Entities.SdhDonGia GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhDonGia index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhDonGia"/> class.</returns>
		public PMS.Entities.SdhDonGia GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhDonGia index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhDonGia"/> class.</returns>
		public PMS.Entities.SdhDonGia GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhDonGia index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhDonGia"/> class.</returns>
		public PMS.Entities.SdhDonGia GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhDonGia index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhDonGia"/> class.</returns>
		public abstract PMS.Entities.SdhDonGia GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SdhDonGia&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SdhDonGia&gt;"/></returns>
		public static TList<SdhDonGia> Fill(IDataReader reader, TList<SdhDonGia> rows, int start, int pageLength)
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
				
				PMS.Entities.SdhDonGia c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SdhDonGia")
					.Append("|").Append((System.Int32)reader[((int)SdhDonGiaColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<SdhDonGia>(
					key.ToString(), // EntityTrackingKey
					"SdhDonGia",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.SdhDonGia();
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
					c.Id = (System.Int32)reader[(SdhDonGiaColumn.Id.ToString())];
					c.MaQuanLy = (reader[SdhDonGiaColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhDonGiaColumn.MaQuanLy.ToString())];
					c.MaLoaiGiangVien = (reader[SdhDonGiaColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhDonGiaColumn.MaLoaiGiangVien.ToString())];
					c.MaHocHam = (reader[SdhDonGiaColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhDonGiaColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[SdhDonGiaColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhDonGiaColumn.MaHocVi.ToString())];
					c.DonGia = (reader[SdhDonGiaColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhDonGiaColumn.DonGia.ToString())];
					c.NgayCapNhat = (reader[SdhDonGiaColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(SdhDonGiaColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[SdhDonGiaColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhDonGiaColumn.NguoiCapNhat.ToString())];
					c.DonGiaClc = (reader[SdhDonGiaColumn.DonGiaClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhDonGiaColumn.DonGiaClc.ToString())];
					c.HeSoQuyDoiChatLuong = (reader[SdhDonGiaColumn.HeSoQuyDoiChatLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhDonGiaColumn.HeSoQuyDoiChatLuong.ToString())];
					c.DonGiaTrongChuan = (reader[SdhDonGiaColumn.DonGiaTrongChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhDonGiaColumn.DonGiaTrongChuan.ToString())];
					c.DonGiaNgoaiChuan = (reader[SdhDonGiaColumn.DonGiaNgoaiChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhDonGiaColumn.DonGiaNgoaiChuan.ToString())];
					c.MaHinhThucDaoTao = (reader[SdhDonGiaColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhDonGiaColumn.MaHinhThucDaoTao.ToString())];
					c.BacDaoTao = (reader[SdhDonGiaColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhDonGiaColumn.BacDaoTao.ToString())];
					c.NgonNguGiangDay = (reader[SdhDonGiaColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhDonGiaColumn.NgonNguGiangDay.ToString())];
					c.NamHoc = (reader[SdhDonGiaColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhDonGiaColumn.NamHoc.ToString())];
					c.HocKy = (reader[SdhDonGiaColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhDonGiaColumn.HocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SdhDonGia"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SdhDonGia"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.SdhDonGia entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(SdhDonGiaColumn.Id.ToString())];
			entity.MaQuanLy = (reader[SdhDonGiaColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhDonGiaColumn.MaQuanLy.ToString())];
			entity.MaLoaiGiangVien = (reader[SdhDonGiaColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhDonGiaColumn.MaLoaiGiangVien.ToString())];
			entity.MaHocHam = (reader[SdhDonGiaColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhDonGiaColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[SdhDonGiaColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhDonGiaColumn.MaHocVi.ToString())];
			entity.DonGia = (reader[SdhDonGiaColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhDonGiaColumn.DonGia.ToString())];
			entity.NgayCapNhat = (reader[SdhDonGiaColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(SdhDonGiaColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[SdhDonGiaColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhDonGiaColumn.NguoiCapNhat.ToString())];
			entity.DonGiaClc = (reader[SdhDonGiaColumn.DonGiaClc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhDonGiaColumn.DonGiaClc.ToString())];
			entity.HeSoQuyDoiChatLuong = (reader[SdhDonGiaColumn.HeSoQuyDoiChatLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhDonGiaColumn.HeSoQuyDoiChatLuong.ToString())];
			entity.DonGiaTrongChuan = (reader[SdhDonGiaColumn.DonGiaTrongChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhDonGiaColumn.DonGiaTrongChuan.ToString())];
			entity.DonGiaNgoaiChuan = (reader[SdhDonGiaColumn.DonGiaNgoaiChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhDonGiaColumn.DonGiaNgoaiChuan.ToString())];
			entity.MaHinhThucDaoTao = (reader[SdhDonGiaColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhDonGiaColumn.MaHinhThucDaoTao.ToString())];
			entity.BacDaoTao = (reader[SdhDonGiaColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhDonGiaColumn.BacDaoTao.ToString())];
			entity.NgonNguGiangDay = (reader[SdhDonGiaColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhDonGiaColumn.NgonNguGiangDay.ToString())];
			entity.NamHoc = (reader[SdhDonGiaColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhDonGiaColumn.NamHoc.ToString())];
			entity.HocKy = (reader[SdhDonGiaColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhDonGiaColumn.HocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SdhDonGia"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SdhDonGia"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.SdhDonGia entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.DonGiaClc = Convert.IsDBNull(dataRow["DonGiaClc"]) ? null : (System.Decimal?)dataRow["DonGiaClc"];
			entity.HeSoQuyDoiChatLuong = Convert.IsDBNull(dataRow["HeSoQuyDoiChatLuong"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoiChatLuong"];
			entity.DonGiaTrongChuan = Convert.IsDBNull(dataRow["DonGiaTrongChuan"]) ? null : (System.Decimal?)dataRow["DonGiaTrongChuan"];
			entity.DonGiaNgoaiChuan = Convert.IsDBNull(dataRow["DonGiaNgoaiChuan"]) ? null : (System.Decimal?)dataRow["DonGiaNgoaiChuan"];
			entity.MaHinhThucDaoTao = Convert.IsDBNull(dataRow["MaHinhThucDaoTao"]) ? null : (System.String)dataRow["MaHinhThucDaoTao"];
			entity.BacDaoTao = Convert.IsDBNull(dataRow["BacDaoTao"]) ? null : (System.String)dataRow["BacDaoTao"];
			entity.NgonNguGiangDay = Convert.IsDBNull(dataRow["NgonNguGiangDay"]) ? null : (System.String)dataRow["NgonNguGiangDay"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.SdhDonGia"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.SdhDonGia Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.SdhDonGia entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.SdhDonGia object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.SdhDonGia instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.SdhDonGia Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.SdhDonGia entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region SdhDonGiaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.SdhDonGia</c>
	///</summary>
	public enum SdhDonGiaChildEntityTypes
	{
	}
	
	#endregion SdhDonGiaChildEntityTypes
	
	#region SdhDonGiaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SdhDonGiaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhDonGiaFilterBuilder : SqlFilterBuilder<SdhDonGiaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhDonGiaFilterBuilder class.
		/// </summary>
		public SdhDonGiaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SdhDonGiaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SdhDonGiaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SdhDonGiaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SdhDonGiaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SdhDonGiaFilterBuilder
	
	#region SdhDonGiaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SdhDonGiaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhDonGiaParameterBuilder : ParameterizedSqlFilterBuilder<SdhDonGiaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhDonGiaParameterBuilder class.
		/// </summary>
		public SdhDonGiaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SdhDonGiaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SdhDonGiaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SdhDonGiaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SdhDonGiaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SdhDonGiaParameterBuilder
	
	#region SdhDonGiaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SdhDonGiaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhDonGia"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SdhDonGiaSortBuilder : SqlSortBuilder<SdhDonGiaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhDonGiaSqlSortBuilder class.
		/// </summary>
		public SdhDonGiaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SdhDonGiaSortBuilder
	
} // end namespace
