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
	/// This class is the base class for any <see cref="CauHinhProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CauHinhProviderBaseCore : EntityProviderBase<PMS.Entities.CauHinh, PMS.Entities.CauHinhKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.CauHinhKey key)
		{
			return Delete(transactionManager, key.MaCauHinh);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maCauHinh">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maCauHinh)
		{
			return Delete(null, _maCauHinh);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinh">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maCauHinh);		
		
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
		public override PMS.Entities.CauHinh Get(TransactionManager transactionManager, PMS.Entities.CauHinhKey key, int start, int pageLength)
		{
			return GetByMaCauHinh(transactionManager, key.MaCauHinh, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CauHinh index.
		/// </summary>
		/// <param name="_maCauHinh"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinh"/> class.</returns>
		public PMS.Entities.CauHinh GetByMaCauHinh(System.Int32 _maCauHinh)
		{
			int count = -1;
			return GetByMaCauHinh(null,_maCauHinh, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinh index.
		/// </summary>
		/// <param name="_maCauHinh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinh"/> class.</returns>
		public PMS.Entities.CauHinh GetByMaCauHinh(System.Int32 _maCauHinh, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCauHinh(null, _maCauHinh, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinh"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinh"/> class.</returns>
		public PMS.Entities.CauHinh GetByMaCauHinh(TransactionManager transactionManager, System.Int32 _maCauHinh)
		{
			int count = -1;
			return GetByMaCauHinh(transactionManager, _maCauHinh, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinh"/> class.</returns>
		public PMS.Entities.CauHinh GetByMaCauHinh(TransactionManager transactionManager, System.Int32 _maCauHinh, int start, int pageLength)
		{
			int count = -1;
			return GetByMaCauHinh(transactionManager, _maCauHinh, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinh index.
		/// </summary>
		/// <param name="_maCauHinh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinh"/> class.</returns>
		public PMS.Entities.CauHinh GetByMaCauHinh(System.Int32 _maCauHinh, int start, int pageLength, out int count)
		{
			return GetByMaCauHinh(null, _maCauHinh, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CauHinh index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maCauHinh"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.CauHinh"/> class.</returns>
		public abstract PMS.Entities.CauHinh GetByMaCauHinh(TransactionManager transactionManager, System.Int32 _maCauHinh, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CauHinh&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CauHinh&gt;"/></returns>
		public static TList<CauHinh> Fill(IDataReader reader, TList<CauHinh> rows, int start, int pageLength)
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
				
				PMS.Entities.CauHinh c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CauHinh")
					.Append("|").Append((System.Int32)reader[((int)CauHinhColumn.MaCauHinh - 1)]).ToString();
					c = EntityManager.LocateOrCreate<CauHinh>(
					key.ToString(), // EntityTrackingKey
					"CauHinh",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.CauHinh();
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
					c.MaCauHinh = (System.Int32)reader[(CauHinhColumn.MaCauHinh.ToString())];
					c.TenTruong = (reader[CauHinhColumn.TenTruong.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.TenTruong.ToString())];
					c.PhongDaoTao = (reader[CauHinhColumn.PhongDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.PhongDaoTao.ToString())];
					c.NguoiLapbieu = (reader[CauHinhColumn.NguoiLapbieu.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.NguoiLapbieu.ToString())];
					c.TrangThai = (reader[CauHinhColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CauHinhColumn.TrangThai.ToString())];
					c.PhongToChucCanBo = (reader[CauHinhColumn.PhongToChucCanBo.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.PhongToChucCanBo.ToString())];
					c.PhongKeHoachTaiChinh = (reader[CauHinhColumn.PhongKeHoachTaiChinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.PhongKeHoachTaiChinh.ToString())];
					c.BanGiamHieu = (reader[CauHinhColumn.BanGiamHieu.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.BanGiamHieu.ToString())];
					c.KeToan = (reader[CauHinhColumn.KeToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.KeToan.ToString())];
					c.ChucVuBanGiamHieu = (reader[CauHinhColumn.ChucVuBanGiamHieu.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuBanGiamHieu.ToString())];
					c.DaiDienHopDongThinhGiang = (reader[CauHinhColumn.DaiDienHopDongThinhGiang.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.DaiDienHopDongThinhGiang.ToString())];
					c.ChucVuDaiDienHopDongThinhGiang = (reader[CauHinhColumn.ChucVuDaiDienHopDongThinhGiang.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuDaiDienHopDongThinhGiang.ToString())];
					c.ChucVuDaiDienHopDongThinhGiang02 = (reader[CauHinhColumn.ChucVuDaiDienHopDongThinhGiang02.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuDaiDienHopDongThinhGiang02.ToString())];
					c.ChucVuKeToan = (reader[CauHinhColumn.ChucVuKeToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuKeToan.ToString())];
					c.ChucVuDaoTao = (reader[CauHinhColumn.ChucVuDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuDaoTao.ToString())];
					c.DiaChiDaiDien = (reader[CauHinhColumn.DiaChiDaiDien.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.DiaChiDaiDien.ToString())];
					c.DienThoaiDaiDien = (reader[CauHinhColumn.DienThoaiDaiDien.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.DienThoaiDaiDien.ToString())];
					c.FaxDaiDien = (reader[CauHinhColumn.FaxDaiDien.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.FaxDaiDien.ToString())];
					c.ChucVuKhoa = (reader[CauHinhColumn.ChucVuKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuKhoa.ToString())];
					c.ChucVuToChucCanBo = (reader[CauHinhColumn.ChucVuToChucCanBo.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuToChucCanBo.ToString())];
					c.ChucVuKeHoachTaiChinh = (reader[CauHinhColumn.ChucVuKeHoachTaiChinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuKeHoachTaiChinh.ToString())];
					c.DaiDienHopDongThinhGiang02 = (reader[CauHinhColumn.DaiDienHopDongThinhGiang02.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.DaiDienHopDongThinhGiang02.ToString())];
					c.MaSoThue = (reader[CauHinhColumn.MaSoThue.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.MaSoThue.ToString())];
					c.ChucVuKiemNhiemKhac = (reader[CauHinhColumn.ChucVuKiemNhiemKhac.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuKiemNhiemKhac.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CauHinh"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CauHinh"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.CauHinh entity)
		{
			if (!reader.Read()) return;
			
			entity.MaCauHinh = (System.Int32)reader[(CauHinhColumn.MaCauHinh.ToString())];
			entity.TenTruong = (reader[CauHinhColumn.TenTruong.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.TenTruong.ToString())];
			entity.PhongDaoTao = (reader[CauHinhColumn.PhongDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.PhongDaoTao.ToString())];
			entity.NguoiLapbieu = (reader[CauHinhColumn.NguoiLapbieu.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.NguoiLapbieu.ToString())];
			entity.TrangThai = (reader[CauHinhColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(CauHinhColumn.TrangThai.ToString())];
			entity.PhongToChucCanBo = (reader[CauHinhColumn.PhongToChucCanBo.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.PhongToChucCanBo.ToString())];
			entity.PhongKeHoachTaiChinh = (reader[CauHinhColumn.PhongKeHoachTaiChinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.PhongKeHoachTaiChinh.ToString())];
			entity.BanGiamHieu = (reader[CauHinhColumn.BanGiamHieu.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.BanGiamHieu.ToString())];
			entity.KeToan = (reader[CauHinhColumn.KeToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.KeToan.ToString())];
			entity.ChucVuBanGiamHieu = (reader[CauHinhColumn.ChucVuBanGiamHieu.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuBanGiamHieu.ToString())];
			entity.DaiDienHopDongThinhGiang = (reader[CauHinhColumn.DaiDienHopDongThinhGiang.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.DaiDienHopDongThinhGiang.ToString())];
			entity.ChucVuDaiDienHopDongThinhGiang = (reader[CauHinhColumn.ChucVuDaiDienHopDongThinhGiang.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuDaiDienHopDongThinhGiang.ToString())];
			entity.ChucVuDaiDienHopDongThinhGiang02 = (reader[CauHinhColumn.ChucVuDaiDienHopDongThinhGiang02.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuDaiDienHopDongThinhGiang02.ToString())];
			entity.ChucVuKeToan = (reader[CauHinhColumn.ChucVuKeToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuKeToan.ToString())];
			entity.ChucVuDaoTao = (reader[CauHinhColumn.ChucVuDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuDaoTao.ToString())];
			entity.DiaChiDaiDien = (reader[CauHinhColumn.DiaChiDaiDien.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.DiaChiDaiDien.ToString())];
			entity.DienThoaiDaiDien = (reader[CauHinhColumn.DienThoaiDaiDien.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.DienThoaiDaiDien.ToString())];
			entity.FaxDaiDien = (reader[CauHinhColumn.FaxDaiDien.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.FaxDaiDien.ToString())];
			entity.ChucVuKhoa = (reader[CauHinhColumn.ChucVuKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuKhoa.ToString())];
			entity.ChucVuToChucCanBo = (reader[CauHinhColumn.ChucVuToChucCanBo.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuToChucCanBo.ToString())];
			entity.ChucVuKeHoachTaiChinh = (reader[CauHinhColumn.ChucVuKeHoachTaiChinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuKeHoachTaiChinh.ToString())];
			entity.DaiDienHopDongThinhGiang02 = (reader[CauHinhColumn.DaiDienHopDongThinhGiang02.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.DaiDienHopDongThinhGiang02.ToString())];
			entity.MaSoThue = (reader[CauHinhColumn.MaSoThue.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.MaSoThue.ToString())];
			entity.ChucVuKiemNhiemKhac = (reader[CauHinhColumn.ChucVuKiemNhiemKhac.ToString()] == DBNull.Value) ? null : (System.String)reader[(CauHinhColumn.ChucVuKiemNhiemKhac.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.CauHinh"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.CauHinh"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.CauHinh entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaCauHinh = (System.Int32)dataRow["MaCauHinh"];
			entity.TenTruong = Convert.IsDBNull(dataRow["TenTruong"]) ? null : (System.String)dataRow["TenTruong"];
			entity.PhongDaoTao = Convert.IsDBNull(dataRow["PhongDaoTao"]) ? null : (System.String)dataRow["PhongDaoTao"];
			entity.NguoiLapbieu = Convert.IsDBNull(dataRow["NguoiLapbieu"]) ? null : (System.String)dataRow["NguoiLapbieu"];
			entity.TrangThai = Convert.IsDBNull(dataRow["TrangThai"]) ? null : (System.Boolean?)dataRow["TrangThai"];
			entity.PhongToChucCanBo = Convert.IsDBNull(dataRow["PhongToChucCanBo"]) ? null : (System.String)dataRow["PhongToChucCanBo"];
			entity.PhongKeHoachTaiChinh = Convert.IsDBNull(dataRow["PhongKeHoachTaiChinh"]) ? null : (System.String)dataRow["PhongKeHoachTaiChinh"];
			entity.BanGiamHieu = Convert.IsDBNull(dataRow["BanGiamHieu"]) ? null : (System.String)dataRow["BanGiamHieu"];
			entity.KeToan = Convert.IsDBNull(dataRow["KeToan"]) ? null : (System.String)dataRow["KeToan"];
			entity.ChucVuBanGiamHieu = Convert.IsDBNull(dataRow["ChucVuBanGiamHieu"]) ? null : (System.String)dataRow["ChucVuBanGiamHieu"];
			entity.DaiDienHopDongThinhGiang = Convert.IsDBNull(dataRow["DaiDienHopDongThinhGiang"]) ? null : (System.String)dataRow["DaiDienHopDongThinhGiang"];
			entity.ChucVuDaiDienHopDongThinhGiang = Convert.IsDBNull(dataRow["ChucVuDaiDienHopDongThinhGiang"]) ? null : (System.String)dataRow["ChucVuDaiDienHopDongThinhGiang"];
			entity.ChucVuDaiDienHopDongThinhGiang02 = Convert.IsDBNull(dataRow["ChucVuDaiDienHopDongThinhGiang02"]) ? null : (System.String)dataRow["ChucVuDaiDienHopDongThinhGiang02"];
			entity.ChucVuKeToan = Convert.IsDBNull(dataRow["ChucVuKeToan"]) ? null : (System.String)dataRow["ChucVuKeToan"];
			entity.ChucVuDaoTao = Convert.IsDBNull(dataRow["ChucVuDaoTao"]) ? null : (System.String)dataRow["ChucVuDaoTao"];
			entity.DiaChiDaiDien = Convert.IsDBNull(dataRow["DiaChiDaiDien"]) ? null : (System.String)dataRow["DiaChiDaiDien"];
			entity.DienThoaiDaiDien = Convert.IsDBNull(dataRow["DienThoaiDaiDien"]) ? null : (System.String)dataRow["DienThoaiDaiDien"];
			entity.FaxDaiDien = Convert.IsDBNull(dataRow["FaxDaiDien"]) ? null : (System.String)dataRow["FaxDaiDien"];
			entity.ChucVuKhoa = Convert.IsDBNull(dataRow["ChucVuKhoa"]) ? null : (System.String)dataRow["ChucVuKhoa"];
			entity.ChucVuToChucCanBo = Convert.IsDBNull(dataRow["ChucVuToChucCanBo"]) ? null : (System.String)dataRow["ChucVuToChucCanBo"];
			entity.ChucVuKeHoachTaiChinh = Convert.IsDBNull(dataRow["ChucVuKeHoachTaiChinh"]) ? null : (System.String)dataRow["ChucVuKeHoachTaiChinh"];
			entity.DaiDienHopDongThinhGiang02 = Convert.IsDBNull(dataRow["DaiDienHopDongThinhGiang02"]) ? null : (System.String)dataRow["DaiDienHopDongThinhGiang02"];
			entity.MaSoThue = Convert.IsDBNull(dataRow["MaSoThue"]) ? null : (System.String)dataRow["MaSoThue"];
			entity.ChucVuKiemNhiemKhac = Convert.IsDBNull(dataRow["ChucVuKiemNhiemKhac"]) ? null : (System.String)dataRow["ChucVuKiemNhiemKhac"];
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
		/// <param name="entity">The <see cref="PMS.Entities.CauHinh"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.CauHinh Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.CauHinh entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.CauHinh object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.CauHinh instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.CauHinh Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.CauHinh entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region CauHinhChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.CauHinh</c>
	///</summary>
	public enum CauHinhChildEntityTypes
	{
	}
	
	#endregion CauHinhChildEntityTypes
	
	#region CauHinhFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CauHinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhFilterBuilder : SqlFilterBuilder<CauHinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhFilterBuilder class.
		/// </summary>
		public CauHinhFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CauHinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CauHinhFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CauHinhFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CauHinhFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CauHinhFilterBuilder
	
	#region CauHinhParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CauHinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhParameterBuilder : ParameterizedSqlFilterBuilder<CauHinhColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhParameterBuilder class.
		/// </summary>
		public CauHinhParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CauHinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CauHinhParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CauHinhParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CauHinhParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CauHinhParameterBuilder
	
	#region CauHinhSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CauHinhColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinh"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CauHinhSortBuilder : SqlSortBuilder<CauHinhColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhSqlSortBuilder class.
		/// </summary>
		public CauHinhSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CauHinhSortBuilder
	
} // end namespace
