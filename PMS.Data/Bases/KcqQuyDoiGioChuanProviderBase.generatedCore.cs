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
	/// This class is the base class for any <see cref="KcqQuyDoiGioChuanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqQuyDoiGioChuanProviderBaseCore : EntityProviderBase<PMS.Entities.KcqQuyDoiGioChuan, PMS.Entities.KcqQuyDoiGioChuanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqQuyDoiGioChuanKey key)
		{
			return Delete(transactionManager, key.MaQuyDoi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maQuyDoi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maQuyDoi)
		{
			return Delete(null, _maQuyDoi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyDoi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maQuyDoi);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KcqQuyDoiGioChuan_DonViTinh key.
		///		FK_KcqQuyDoiGioChuan_DonViTinh Description: 
		/// </summary>
		/// <param name="_maDonVi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KcqQuyDoiGioChuan objects.</returns>
		public TList<KcqQuyDoiGioChuan> GetByMaDonVi(System.Int32? _maDonVi)
		{
			int count = -1;
			return GetByMaDonVi(_maDonVi, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KcqQuyDoiGioChuan_DonViTinh key.
		///		FK_KcqQuyDoiGioChuan_DonViTinh Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonVi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KcqQuyDoiGioChuan objects.</returns>
		/// <remarks></remarks>
		public TList<KcqQuyDoiGioChuan> GetByMaDonVi(TransactionManager transactionManager, System.Int32? _maDonVi)
		{
			int count = -1;
			return GetByMaDonVi(transactionManager, _maDonVi, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_KcqQuyDoiGioChuan_DonViTinh key.
		///		FK_KcqQuyDoiGioChuan_DonViTinh Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KcqQuyDoiGioChuan objects.</returns>
		public TList<KcqQuyDoiGioChuan> GetByMaDonVi(TransactionManager transactionManager, System.Int32? _maDonVi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDonVi(transactionManager, _maDonVi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KcqQuyDoiGioChuan_DonViTinh key.
		///		fkKcqQuyDoiGioChuanDonViTinh Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maDonVi"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KcqQuyDoiGioChuan objects.</returns>
		public TList<KcqQuyDoiGioChuan> GetByMaDonVi(System.Int32? _maDonVi, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaDonVi(null, _maDonVi, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KcqQuyDoiGioChuan_DonViTinh key.
		///		fkKcqQuyDoiGioChuanDonViTinh Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maDonVi"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KcqQuyDoiGioChuan objects.</returns>
		public TList<KcqQuyDoiGioChuan> GetByMaDonVi(System.Int32? _maDonVi, int start, int pageLength,out int count)
		{
			return GetByMaDonVi(null, _maDonVi, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KcqQuyDoiGioChuan_DonViTinh key.
		///		FK_KcqQuyDoiGioChuan_DonViTinh Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.KcqQuyDoiGioChuan objects.</returns>
		public abstract TList<KcqQuyDoiGioChuan> GetByMaDonVi(TransactionManager transactionManager, System.Int32? _maDonVi, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.KcqQuyDoiGioChuan Get(TransactionManager transactionManager, PMS.Entities.KcqQuyDoiGioChuanKey key, int start, int pageLength)
		{
			return GetByMaQuyDoi(transactionManager, key.MaQuyDoi, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqQuyDoiGioChuan index.
		/// </summary>
		/// <param name="_maQuyDoi"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqQuyDoiGioChuan"/> class.</returns>
		public PMS.Entities.KcqQuyDoiGioChuan GetByMaQuyDoi(System.Int32 _maQuyDoi)
		{
			int count = -1;
			return GetByMaQuyDoi(null,_maQuyDoi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqQuyDoiGioChuan index.
		/// </summary>
		/// <param name="_maQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqQuyDoiGioChuan"/> class.</returns>
		public PMS.Entities.KcqQuyDoiGioChuan GetByMaQuyDoi(System.Int32 _maQuyDoi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuyDoi(null, _maQuyDoi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqQuyDoiGioChuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyDoi"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqQuyDoiGioChuan"/> class.</returns>
		public PMS.Entities.KcqQuyDoiGioChuan GetByMaQuyDoi(TransactionManager transactionManager, System.Int32 _maQuyDoi)
		{
			int count = -1;
			return GetByMaQuyDoi(transactionManager, _maQuyDoi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqQuyDoiGioChuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqQuyDoiGioChuan"/> class.</returns>
		public PMS.Entities.KcqQuyDoiGioChuan GetByMaQuyDoi(TransactionManager transactionManager, System.Int32 _maQuyDoi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuyDoi(transactionManager, _maQuyDoi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqQuyDoiGioChuan index.
		/// </summary>
		/// <param name="_maQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqQuyDoiGioChuan"/> class.</returns>
		public PMS.Entities.KcqQuyDoiGioChuan GetByMaQuyDoi(System.Int32 _maQuyDoi, int start, int pageLength, out int count)
		{
			return GetByMaQuyDoi(null, _maQuyDoi, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqQuyDoiGioChuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqQuyDoiGioChuan"/> class.</returns>
		public abstract PMS.Entities.KcqQuyDoiGioChuan GetByMaQuyDoi(TransactionManager transactionManager, System.Int32 _maQuyDoi, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqQuyDoiGioChuan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqQuyDoiGioChuan&gt;"/></returns>
		public static TList<KcqQuyDoiGioChuan> Fill(IDataReader reader, TList<KcqQuyDoiGioChuan> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqQuyDoiGioChuan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqQuyDoiGioChuan")
					.Append("|").Append((System.Int32)reader[((int)KcqQuyDoiGioChuanColumn.MaQuyDoi - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqQuyDoiGioChuan>(
					key.ToString(), // EntityTrackingKey
					"KcqQuyDoiGioChuan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqQuyDoiGioChuan();
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
					c.MaQuyDoi = (System.Int32)reader[(KcqQuyDoiGioChuanColumn.MaQuyDoi.ToString())];
					c.MaDonVi = (reader[KcqQuyDoiGioChuanColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqQuyDoiGioChuanColumn.MaDonVi.ToString())];
					c.MaQuanLy = (System.String)reader[(KcqQuyDoiGioChuanColumn.MaQuanLy.ToString())];
					c.TenQuyDoi = (reader[KcqQuyDoiGioChuanColumn.TenQuyDoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqQuyDoiGioChuanColumn.TenQuyDoi.ToString())];
					c.SoLuong = (reader[KcqQuyDoiGioChuanColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqQuyDoiGioChuanColumn.SoLuong.ToString())];
					c.HeSo = (reader[KcqQuyDoiGioChuanColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqQuyDoiGioChuanColumn.HeSo.ToString())];
					c.CongDon = (reader[KcqQuyDoiGioChuanColumn.CongDon.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqQuyDoiGioChuanColumn.CongDon.ToString())];
					c.LoaiQuyDoi = (reader[KcqQuyDoiGioChuanColumn.LoaiQuyDoi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqQuyDoiGioChuanColumn.LoaiQuyDoi.ToString())];
					c.ThuTu = (reader[KcqQuyDoiGioChuanColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqQuyDoiGioChuanColumn.ThuTu.ToString())];
					c.NamHoc = (reader[KcqQuyDoiGioChuanColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqQuyDoiGioChuanColumn.NamHoc.ToString())];
					c.HocKy = (reader[KcqQuyDoiGioChuanColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqQuyDoiGioChuanColumn.HocKy.ToString())];
					c.NgayCapNhat = (reader[KcqQuyDoiGioChuanColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqQuyDoiGioChuanColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[KcqQuyDoiGioChuanColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqQuyDoiGioChuanColumn.NguoiCapNhat.ToString())];
					c.GhiChu = (reader[KcqQuyDoiGioChuanColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqQuyDoiGioChuanColumn.GhiChu.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqQuyDoiGioChuan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqQuyDoiGioChuan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqQuyDoiGioChuan entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuyDoi = (System.Int32)reader[(KcqQuyDoiGioChuanColumn.MaQuyDoi.ToString())];
			entity.MaDonVi = (reader[KcqQuyDoiGioChuanColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqQuyDoiGioChuanColumn.MaDonVi.ToString())];
			entity.MaQuanLy = (System.String)reader[(KcqQuyDoiGioChuanColumn.MaQuanLy.ToString())];
			entity.TenQuyDoi = (reader[KcqQuyDoiGioChuanColumn.TenQuyDoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqQuyDoiGioChuanColumn.TenQuyDoi.ToString())];
			entity.SoLuong = (reader[KcqQuyDoiGioChuanColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqQuyDoiGioChuanColumn.SoLuong.ToString())];
			entity.HeSo = (reader[KcqQuyDoiGioChuanColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqQuyDoiGioChuanColumn.HeSo.ToString())];
			entity.CongDon = (reader[KcqQuyDoiGioChuanColumn.CongDon.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqQuyDoiGioChuanColumn.CongDon.ToString())];
			entity.LoaiQuyDoi = (reader[KcqQuyDoiGioChuanColumn.LoaiQuyDoi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqQuyDoiGioChuanColumn.LoaiQuyDoi.ToString())];
			entity.ThuTu = (reader[KcqQuyDoiGioChuanColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqQuyDoiGioChuanColumn.ThuTu.ToString())];
			entity.NamHoc = (reader[KcqQuyDoiGioChuanColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqQuyDoiGioChuanColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KcqQuyDoiGioChuanColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqQuyDoiGioChuanColumn.HocKy.ToString())];
			entity.NgayCapNhat = (reader[KcqQuyDoiGioChuanColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqQuyDoiGioChuanColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[KcqQuyDoiGioChuanColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqQuyDoiGioChuanColumn.NguoiCapNhat.ToString())];
			entity.GhiChu = (reader[KcqQuyDoiGioChuanColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqQuyDoiGioChuanColumn.GhiChu.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqQuyDoiGioChuan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqQuyDoiGioChuan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqQuyDoiGioChuan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuyDoi = (System.Int32)dataRow["MaQuyDoi"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.Int32?)dataRow["MaDonVi"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenQuyDoi = Convert.IsDBNull(dataRow["TenQuyDoi"]) ? null : (System.String)dataRow["TenQuyDoi"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Int32?)dataRow["SoLuong"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.CongDon = Convert.IsDBNull(dataRow["CongDon"]) ? null : (System.Boolean?)dataRow["CongDon"];
			entity.LoaiQuyDoi = Convert.IsDBNull(dataRow["LoaiQuyDoi"]) ? null : (System.Int32?)dataRow["LoaiQuyDoi"];
			entity.ThuTu = Convert.IsDBNull(dataRow["ThuTu"]) ? null : (System.Int32?)dataRow["ThuTu"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqQuyDoiGioChuan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqQuyDoiGioChuan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqQuyDoiGioChuan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaDonViSource	
			if (CanDeepLoad(entity, "DonViTinh|MaDonViSource", deepLoadType, innerList) 
				&& entity.MaDonViSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaDonVi ?? (int)0);
				DonViTinh tmpEntity = EntityManager.LocateEntity<DonViTinh>(EntityLocator.ConstructKeyFromPkItems(typeof(DonViTinh), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaDonViSource = tmpEntity;
				else
					entity.MaDonViSource = DataRepository.DonViTinhProvider.GetByMaDonVi(transactionManager, (entity.MaDonVi ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaDonViSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaDonViSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.DonViTinhProvider.DeepLoad(transactionManager, entity.MaDonViSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaDonViSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaQuyDoi methods when available
			
			#region KcqKhoanQuyDoiCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<KcqKhoanQuyDoi>|KcqKhoanQuyDoiCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'KcqKhoanQuyDoiCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.KcqKhoanQuyDoiCollection = DataRepository.KcqKhoanQuyDoiProvider.GetByMaQuyDoi(transactionManager, entity.MaQuyDoi);

				if (deep && entity.KcqKhoanQuyDoiCollection.Count > 0)
				{
					deepHandles.Add("KcqKhoanQuyDoiCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<KcqKhoanQuyDoi>) DataRepository.KcqKhoanQuyDoiProvider.DeepLoad,
						new object[] { transactionManager, entity.KcqKhoanQuyDoiCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqQuyDoiGioChuan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqQuyDoiGioChuan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqQuyDoiGioChuan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqQuyDoiGioChuan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaDonViSource
			if (CanDeepSave(entity, "DonViTinh|MaDonViSource", deepSaveType, innerList) 
				&& entity.MaDonViSource != null)
			{
				DataRepository.DonViTinhProvider.Save(transactionManager, entity.MaDonViSource);
				entity.MaDonVi = entity.MaDonViSource.MaDonVi;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<KcqKhoanQuyDoi>
				if (CanDeepSave(entity.KcqKhoanQuyDoiCollection, "List<KcqKhoanQuyDoi>|KcqKhoanQuyDoiCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(KcqKhoanQuyDoi child in entity.KcqKhoanQuyDoiCollection)
					{
						if(child.MaQuyDoiSource != null)
						{
							child.MaQuyDoi = child.MaQuyDoiSource.MaQuyDoi;
						}
						else
						{
							child.MaQuyDoi = entity.MaQuyDoi;
						}

					}

					if (entity.KcqKhoanQuyDoiCollection.Count > 0 || entity.KcqKhoanQuyDoiCollection.DeletedItems.Count > 0)
					{
						//DataRepository.KcqKhoanQuyDoiProvider.Save(transactionManager, entity.KcqKhoanQuyDoiCollection);
						
						deepHandles.Add("KcqKhoanQuyDoiCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< KcqKhoanQuyDoi >) DataRepository.KcqKhoanQuyDoiProvider.DeepSave,
							new object[] { transactionManager, entity.KcqKhoanQuyDoiCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
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
	
	#region KcqQuyDoiGioChuanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqQuyDoiGioChuan</c>
	///</summary>
	public enum KcqQuyDoiGioChuanChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>DonViTinh</c> at MaDonViSource
		///</summary>
		[ChildEntityType(typeof(DonViTinh))]
		DonViTinh,
		///<summary>
		/// Collection of <c>KcqQuyDoiGioChuan</c> as OneToMany for KcqKhoanQuyDoiCollection
		///</summary>
		[ChildEntityType(typeof(TList<KcqKhoanQuyDoi>))]
		KcqKhoanQuyDoiCollection,
	}
	
	#endregion KcqQuyDoiGioChuanChildEntityTypes
	
	#region KcqQuyDoiGioChuanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqQuyDoiGioChuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqQuyDoiGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqQuyDoiGioChuanFilterBuilder : SqlFilterBuilder<KcqQuyDoiGioChuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqQuyDoiGioChuanFilterBuilder class.
		/// </summary>
		public KcqQuyDoiGioChuanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqQuyDoiGioChuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqQuyDoiGioChuanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqQuyDoiGioChuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqQuyDoiGioChuanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqQuyDoiGioChuanFilterBuilder
	
	#region KcqQuyDoiGioChuanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqQuyDoiGioChuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqQuyDoiGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqQuyDoiGioChuanParameterBuilder : ParameterizedSqlFilterBuilder<KcqQuyDoiGioChuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqQuyDoiGioChuanParameterBuilder class.
		/// </summary>
		public KcqQuyDoiGioChuanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqQuyDoiGioChuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqQuyDoiGioChuanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqQuyDoiGioChuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqQuyDoiGioChuanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqQuyDoiGioChuanParameterBuilder
	
	#region KcqQuyDoiGioChuanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqQuyDoiGioChuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqQuyDoiGioChuan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqQuyDoiGioChuanSortBuilder : SqlSortBuilder<KcqQuyDoiGioChuanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqQuyDoiGioChuanSqlSortBuilder class.
		/// </summary>
		public KcqQuyDoiGioChuanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqQuyDoiGioChuanSortBuilder
	
} // end namespace
