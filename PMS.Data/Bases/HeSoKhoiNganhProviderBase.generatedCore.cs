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
	/// This class is the base class for any <see cref="HeSoKhoiNganhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoKhoiNganhProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoKhoiNganh, PMS.Entities.HeSoKhoiNganhKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoKhoiNganhKey key)
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
		public override PMS.Entities.HeSoKhoiNganh Get(TransactionManager transactionManager, PMS.Entities.HeSoKhoiNganhKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__HeSoKhoi__3214EC07F4734958 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoKhoiNganh"/> class.</returns>
		public PMS.Entities.HeSoKhoiNganh GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__HeSoKhoi__3214EC07F4734958 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoKhoiNganh"/> class.</returns>
		public PMS.Entities.HeSoKhoiNganh GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__HeSoKhoi__3214EC07F4734958 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoKhoiNganh"/> class.</returns>
		public PMS.Entities.HeSoKhoiNganh GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__HeSoKhoi__3214EC07F4734958 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoKhoiNganh"/> class.</returns>
		public PMS.Entities.HeSoKhoiNganh GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__HeSoKhoi__3214EC07F4734958 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoKhoiNganh"/> class.</returns>
		public PMS.Entities.HeSoKhoiNganh GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__HeSoKhoi__3214EC07F4734958 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoKhoiNganh"/> class.</returns>
		public abstract PMS.Entities.HeSoKhoiNganh GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HeSoKhoiNganh_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoKhoiNganh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoKhoiNganh&gt;"/> instance.</returns>
		public TList<HeSoKhoiNganh> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoKhoiNganh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoKhoiNganh&gt;"/> instance.</returns>
		public TList<HeSoKhoiNganh> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoKhoiNganh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoKhoiNganh&gt;"/> instance.</returns>
		public TList<HeSoKhoiNganh> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoKhoiNganh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoKhoiNganh&gt;"/> instance.</returns>
		public abstract TList<HeSoKhoiNganh> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_HeSoKhoiNganh_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoKhoiNganh_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(null, 0, int.MaxValue , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoKhoiNganh_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(int start, int pageLength, System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(null, start, pageLength , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoKhoiNganh_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(TransactionManager transactionManager, System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(transactionManager, 0, int.MaxValue , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoKhoiNganh_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void SaoChep(TransactionManager transactionManager, int start, int pageLength , System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich);
		
		#endregion
		
		#region cust_HeSoKhoiNganh_GetAllKhoiNganh 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoKhoiNganh_GetAllKhoiNganh' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllKhoiNganh()
		{
			return GetAllKhoiNganh(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoKhoiNganh_GetAllKhoiNganh' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllKhoiNganh(int start, int pageLength)
		{
			return GetAllKhoiNganh(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoKhoiNganh_GetAllKhoiNganh' stored procedure. 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllKhoiNganh(TransactionManager transactionManager)
		{
			return GetAllKhoiNganh(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoKhoiNganh_GetAllKhoiNganh' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetAllKhoiNganh(TransactionManager transactionManager, int start, int pageLength );
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoKhoiNganh&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoKhoiNganh&gt;"/></returns>
		public static TList<HeSoKhoiNganh> Fill(IDataReader reader, TList<HeSoKhoiNganh> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoKhoiNganh c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoKhoiNganh")
					.Append("|").Append((System.Int32)reader[((int)HeSoKhoiNganhColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoKhoiNganh>(
					key.ToString(), // EntityTrackingKey
					"HeSoKhoiNganh",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoKhoiNganh();
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
					c.Id = (System.Int32)reader[(HeSoKhoiNganhColumn.Id.ToString())];
					c.MaKhoiNganh = (reader[HeSoKhoiNganhColumn.MaKhoiNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoKhoiNganhColumn.MaKhoiNganh.ToString())];
					c.SiSo = (System.Int32)reader[(HeSoKhoiNganhColumn.SiSo.ToString())];
					c.HeSo = (reader[HeSoKhoiNganhColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoKhoiNganhColumn.HeSo.ToString())];
					c.GhiChu = (reader[HeSoKhoiNganhColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoKhoiNganhColumn.GhiChu.ToString())];
					c.TenKhoiNganh = (reader[HeSoKhoiNganhColumn.TenKhoiNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoKhoiNganhColumn.TenKhoiNganh.ToString())];
					c.NhomKhoiNganh = (reader[HeSoKhoiNganhColumn.NhomKhoiNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoKhoiNganhColumn.NhomKhoiNganh.ToString())];
					c.NamHoc = (reader[HeSoKhoiNganhColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoKhoiNganhColumn.NamHoc.ToString())];
					c.HocKy = (reader[HeSoKhoiNganhColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoKhoiNganhColumn.HocKy.ToString())];
					c.HeSoThucHanh = (reader[HeSoKhoiNganhColumn.HeSoThucHanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoKhoiNganhColumn.HeSoThucHanh.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoKhoiNganh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoKhoiNganh"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoKhoiNganh entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(HeSoKhoiNganhColumn.Id.ToString())];
			entity.MaKhoiNganh = (reader[HeSoKhoiNganhColumn.MaKhoiNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoKhoiNganhColumn.MaKhoiNganh.ToString())];
			entity.SiSo = (System.Int32)reader[(HeSoKhoiNganhColumn.SiSo.ToString())];
			entity.HeSo = (reader[HeSoKhoiNganhColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoKhoiNganhColumn.HeSo.ToString())];
			entity.GhiChu = (reader[HeSoKhoiNganhColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoKhoiNganhColumn.GhiChu.ToString())];
			entity.TenKhoiNganh = (reader[HeSoKhoiNganhColumn.TenKhoiNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoKhoiNganhColumn.TenKhoiNganh.ToString())];
			entity.NhomKhoiNganh = (reader[HeSoKhoiNganhColumn.NhomKhoiNganh.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoKhoiNganhColumn.NhomKhoiNganh.ToString())];
			entity.NamHoc = (reader[HeSoKhoiNganhColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoKhoiNganhColumn.NamHoc.ToString())];
			entity.HocKy = (reader[HeSoKhoiNganhColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoKhoiNganhColumn.HocKy.ToString())];
			entity.HeSoThucHanh = (reader[HeSoKhoiNganhColumn.HeSoThucHanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoKhoiNganhColumn.HeSoThucHanh.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoKhoiNganh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoKhoiNganh"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoKhoiNganh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaKhoiNganh = Convert.IsDBNull(dataRow["MaKhoiNganh"]) ? null : (System.String)dataRow["MaKhoiNganh"];
			entity.SiSo = (System.Int32)dataRow["SiSo"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.TenKhoiNganh = Convert.IsDBNull(dataRow["TenKhoiNganh"]) ? null : (System.String)dataRow["TenKhoiNganh"];
			entity.NhomKhoiNganh = Convert.IsDBNull(dataRow["NhomKhoiNganh"]) ? null : (System.String)dataRow["NhomKhoiNganh"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.HeSoThucHanh = Convert.IsDBNull(dataRow["HeSoThucHanh"]) ? null : (System.Decimal?)dataRow["HeSoThucHanh"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoKhoiNganh"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoKhoiNganh Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoKhoiNganh entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoKhoiNganh object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoKhoiNganh instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoKhoiNganh Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoKhoiNganh entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HeSoKhoiNganhChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoKhoiNganh</c>
	///</summary>
	public enum HeSoKhoiNganhChildEntityTypes
	{
	}
	
	#endregion HeSoKhoiNganhChildEntityTypes
	
	#region HeSoKhoiNganhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoKhoiNganhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoKhoiNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoKhoiNganhFilterBuilder : SqlFilterBuilder<HeSoKhoiNganhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoKhoiNganhFilterBuilder class.
		/// </summary>
		public HeSoKhoiNganhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoKhoiNganhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoKhoiNganhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoKhoiNganhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoKhoiNganhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoKhoiNganhFilterBuilder
	
	#region HeSoKhoiNganhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoKhoiNganhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoKhoiNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoKhoiNganhParameterBuilder : ParameterizedSqlFilterBuilder<HeSoKhoiNganhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoKhoiNganhParameterBuilder class.
		/// </summary>
		public HeSoKhoiNganhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoKhoiNganhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoKhoiNganhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoKhoiNganhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoKhoiNganhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoKhoiNganhParameterBuilder
	
	#region HeSoKhoiNganhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoKhoiNganhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoKhoiNganh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoKhoiNganhSortBuilder : SqlSortBuilder<HeSoKhoiNganhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoKhoiNganhSqlSortBuilder class.
		/// </summary>
		public HeSoKhoiNganhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoKhoiNganhSortBuilder
	
} // end namespace
