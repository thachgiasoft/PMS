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
	/// This class is the base class for any <see cref="ThanhTraGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThanhTraGiangDayProviderBaseCore : EntityProviderBase<PMS.Entities.ThanhTraGiangDay, PMS.Entities.ThanhTraGiangDayKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThanhTraGiangDayKey key)
		{
			return Delete(transactionManager, key.MaHoSoThanhTra);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maHoSoThanhTra">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maHoSoThanhTra)
		{
			return Delete(null, _maHoSoThanhTra);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSoThanhTra">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maHoSoThanhTra);		
		
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
		public override PMS.Entities.ThanhTraGiangDay Get(TransactionManager transactionManager, PMS.Entities.ThanhTraGiangDayKey key, int start, int pageLength)
		{
			return GetByMaHoSoThanhTra(transactionManager, key.MaHoSoThanhTra, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThanhTraGiangDay index.
		/// </summary>
		/// <param name="_maHoSoThanhTra"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraGiangDay"/> class.</returns>
		public PMS.Entities.ThanhTraGiangDay GetByMaHoSoThanhTra(System.Int32 _maHoSoThanhTra)
		{
			int count = -1;
			return GetByMaHoSoThanhTra(null,_maHoSoThanhTra, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraGiangDay index.
		/// </summary>
		/// <param name="_maHoSoThanhTra"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraGiangDay"/> class.</returns>
		public PMS.Entities.ThanhTraGiangDay GetByMaHoSoThanhTra(System.Int32 _maHoSoThanhTra, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHoSoThanhTra(null, _maHoSoThanhTra, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSoThanhTra"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraGiangDay"/> class.</returns>
		public PMS.Entities.ThanhTraGiangDay GetByMaHoSoThanhTra(TransactionManager transactionManager, System.Int32 _maHoSoThanhTra)
		{
			int count = -1;
			return GetByMaHoSoThanhTra(transactionManager, _maHoSoThanhTra, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSoThanhTra"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraGiangDay"/> class.</returns>
		public PMS.Entities.ThanhTraGiangDay GetByMaHoSoThanhTra(TransactionManager transactionManager, System.Int32 _maHoSoThanhTra, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHoSoThanhTra(transactionManager, _maHoSoThanhTra, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraGiangDay index.
		/// </summary>
		/// <param name="_maHoSoThanhTra"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraGiangDay"/> class.</returns>
		public PMS.Entities.ThanhTraGiangDay GetByMaHoSoThanhTra(System.Int32 _maHoSoThanhTra, int start, int pageLength, out int count)
		{
			return GetByMaHoSoThanhTra(null, _maHoSoThanhTra, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHoSoThanhTra"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraGiangDay"/> class.</returns>
		public abstract PMS.Entities.ThanhTraGiangDay GetByMaHoSoThanhTra(TransactionManager transactionManager, System.Int32 _maHoSoThanhTra, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThanhTraGiangDay_GetByTuNgayDenNgay 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraGiangDay_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThanhTraGiangDay&gt;"/> instance.</returns>
		public TList<ThanhTraGiangDay> GetByTuNgayDenNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraGiangDay_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThanhTraGiangDay&gt;"/> instance.</returns>
		public TList<ThanhTraGiangDay> GetByTuNgayDenNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraGiangDay_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThanhTraGiangDay&gt;"/> instance.</returns>
		public TList<ThanhTraGiangDay> GetByTuNgayDenNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraGiangDay_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThanhTraGiangDay&gt;"/> instance.</returns>
		public abstract TList<ThanhTraGiangDay> GetByTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength , System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion
		
		#region cust_ThanhTraGiangDay_GetByTuNgayDenNgayMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraGiangDay_GetByTuNgayDenNgayMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThanhTraGiangDay&gt;"/> instance.</returns>
		public TList<ThanhTraGiangDay> GetByTuNgayDenNgayMaDonVi(System.DateTime tuNgay, System.DateTime denNgay, System.String maBoMon)
		{
			return GetByTuNgayDenNgayMaDonVi(null, 0, int.MaxValue , tuNgay, denNgay, maBoMon);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraGiangDay_GetByTuNgayDenNgayMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThanhTraGiangDay&gt;"/> instance.</returns>
		public TList<ThanhTraGiangDay> GetByTuNgayDenNgayMaDonVi(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.String maBoMon)
		{
			return GetByTuNgayDenNgayMaDonVi(null, start, pageLength , tuNgay, denNgay, maBoMon);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraGiangDay_GetByTuNgayDenNgayMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThanhTraGiangDay&gt;"/> instance.</returns>
		public TList<ThanhTraGiangDay> GetByTuNgayDenNgayMaDonVi(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay, System.String maBoMon)
		{
			return GetByTuNgayDenNgayMaDonVi(transactionManager, 0, int.MaxValue , tuNgay, denNgay, maBoMon);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraGiangDay_GetByTuNgayDenNgayMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThanhTraGiangDay&gt;"/> instance.</returns>
		public abstract TList<ThanhTraGiangDay> GetByTuNgayDenNgayMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.DateTime tuNgay, System.DateTime denNgay, System.String maBoMon);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThanhTraGiangDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThanhTraGiangDay&gt;"/></returns>
		public static TList<ThanhTraGiangDay> Fill(IDataReader reader, TList<ThanhTraGiangDay> rows, int start, int pageLength)
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
				
				PMS.Entities.ThanhTraGiangDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThanhTraGiangDay")
					.Append("|").Append((System.Int32)reader[((int)ThanhTraGiangDayColumn.MaHoSoThanhTra - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThanhTraGiangDay>(
					key.ToString(), // EntityTrackingKey
					"ThanhTraGiangDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThanhTraGiangDay();
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
					c.MaHoSoThanhTra = (System.Int32)reader[(ThanhTraGiangDayColumn.MaHoSoThanhTra.ToString())];
					c.MaHienThi = (reader[ThanhTraGiangDayColumn.MaHienThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.MaHienThi.ToString())];
					c.MaQuanLy = (reader[ThanhTraGiangDayColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.MaQuanLy.ToString())];
					c.Khoa = (reader[ThanhTraGiangDayColumn.Khoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.Khoa.ToString())];
					c.LoaiGiangVien = (reader[ThanhTraGiangDayColumn.LoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.LoaiGiangVien.ToString())];
					c.TenHocPhan = (reader[ThanhTraGiangDayColumn.TenHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.TenHocPhan.ToString())];
					c.TinhHinhGhiNhan = (reader[ThanhTraGiangDayColumn.TinhHinhGhiNhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.TinhHinhGhiNhan.ToString())];
					c.Ngay = (reader[ThanhTraGiangDayColumn.Ngay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThanhTraGiangDayColumn.Ngay.ToString())];
					c.Tiet = (reader[ThanhTraGiangDayColumn.Tiet.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.Tiet.ToString())];
					c.Lop = (reader[ThanhTraGiangDayColumn.Lop.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.Lop.ToString())];
					c.Phong = (reader[ThanhTraGiangDayColumn.Phong.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.Phong.ToString())];
					c.ThoiDiemGhiNhan = (reader[ThanhTraGiangDayColumn.ThoiDiemGhiNhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.ThoiDiemGhiNhan.ToString())];
					c.LyDo = (reader[ThanhTraGiangDayColumn.LyDo.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.LyDo.ToString())];
					c.GhiChu = (reader[ThanhTraGiangDayColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.GhiChu.ToString())];
					c.MaHinhThucViPham = (reader[ThanhTraGiangDayColumn.MaHinhThucViPham.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(ThanhTraGiangDayColumn.MaHinhThucViPham.ToString())];
					c.DaBaoSuaTkb = (reader[ThanhTraGiangDayColumn.DaBaoSuaTkb.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThanhTraGiangDayColumn.DaBaoSuaTkb.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThanhTraGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThanhTraGiangDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThanhTraGiangDay entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHoSoThanhTra = (System.Int32)reader[(ThanhTraGiangDayColumn.MaHoSoThanhTra.ToString())];
			entity.MaHienThi = (reader[ThanhTraGiangDayColumn.MaHienThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.MaHienThi.ToString())];
			entity.MaQuanLy = (reader[ThanhTraGiangDayColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.MaQuanLy.ToString())];
			entity.Khoa = (reader[ThanhTraGiangDayColumn.Khoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.Khoa.ToString())];
			entity.LoaiGiangVien = (reader[ThanhTraGiangDayColumn.LoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.LoaiGiangVien.ToString())];
			entity.TenHocPhan = (reader[ThanhTraGiangDayColumn.TenHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.TenHocPhan.ToString())];
			entity.TinhHinhGhiNhan = (reader[ThanhTraGiangDayColumn.TinhHinhGhiNhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.TinhHinhGhiNhan.ToString())];
			entity.Ngay = (reader[ThanhTraGiangDayColumn.Ngay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThanhTraGiangDayColumn.Ngay.ToString())];
			entity.Tiet = (reader[ThanhTraGiangDayColumn.Tiet.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.Tiet.ToString())];
			entity.Lop = (reader[ThanhTraGiangDayColumn.Lop.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.Lop.ToString())];
			entity.Phong = (reader[ThanhTraGiangDayColumn.Phong.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.Phong.ToString())];
			entity.ThoiDiemGhiNhan = (reader[ThanhTraGiangDayColumn.ThoiDiemGhiNhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.ThoiDiemGhiNhan.ToString())];
			entity.LyDo = (reader[ThanhTraGiangDayColumn.LyDo.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.LyDo.ToString())];
			entity.GhiChu = (reader[ThanhTraGiangDayColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraGiangDayColumn.GhiChu.ToString())];
			entity.MaHinhThucViPham = (reader[ThanhTraGiangDayColumn.MaHinhThucViPham.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(ThanhTraGiangDayColumn.MaHinhThucViPham.ToString())];
			entity.DaBaoSuaTkb = (reader[ThanhTraGiangDayColumn.DaBaoSuaTkb.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThanhTraGiangDayColumn.DaBaoSuaTkb.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThanhTraGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThanhTraGiangDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThanhTraGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHoSoThanhTra = (System.Int32)dataRow["MaHoSoThanhTra"];
			entity.MaHienThi = Convert.IsDBNull(dataRow["MaHienThi"]) ? null : (System.String)dataRow["MaHienThi"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.Khoa = Convert.IsDBNull(dataRow["Khoa"]) ? null : (System.String)dataRow["Khoa"];
			entity.LoaiGiangVien = Convert.IsDBNull(dataRow["LoaiGiangVien"]) ? null : (System.String)dataRow["LoaiGiangVien"];
			entity.TenHocPhan = Convert.IsDBNull(dataRow["TenHocPhan"]) ? null : (System.String)dataRow["TenHocPhan"];
			entity.TinhHinhGhiNhan = Convert.IsDBNull(dataRow["TinhHinhGhiNhan"]) ? null : (System.String)dataRow["TinhHinhGhiNhan"];
			entity.Ngay = Convert.IsDBNull(dataRow["Ngay"]) ? null : (System.DateTime?)dataRow["Ngay"];
			entity.Tiet = Convert.IsDBNull(dataRow["Tiet"]) ? null : (System.String)dataRow["Tiet"];
			entity.Lop = Convert.IsDBNull(dataRow["Lop"]) ? null : (System.String)dataRow["Lop"];
			entity.Phong = Convert.IsDBNull(dataRow["Phong"]) ? null : (System.String)dataRow["Phong"];
			entity.ThoiDiemGhiNhan = Convert.IsDBNull(dataRow["ThoiDiemGhiNhan"]) ? null : (System.String)dataRow["ThoiDiemGhiNhan"];
			entity.LyDo = Convert.IsDBNull(dataRow["LyDo"]) ? null : (System.String)dataRow["LyDo"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.MaHinhThucViPham = Convert.IsDBNull(dataRow["MaHinhThucViPham"]) ? null : (System.Guid?)dataRow["MaHinhThucViPham"];
			entity.DaBaoSuaTkb = Convert.IsDBNull(dataRow["DaBaoSuaTkb"]) ? null : (System.Boolean?)dataRow["DaBaoSuaTkb"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThanhTraGiangDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThanhTraGiangDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThanhTraGiangDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThanhTraGiangDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThanhTraGiangDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThanhTraGiangDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThanhTraGiangDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThanhTraGiangDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThanhTraGiangDay</c>
	///</summary>
	public enum ThanhTraGiangDayChildEntityTypes
	{
	}
	
	#endregion ThanhTraGiangDayChildEntityTypes
	
	#region ThanhTraGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThanhTraGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraGiangDayFilterBuilder : SqlFilterBuilder<ThanhTraGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraGiangDayFilterBuilder class.
		/// </summary>
		public ThanhTraGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThanhTraGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThanhTraGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThanhTraGiangDayFilterBuilder
	
	#region ThanhTraGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThanhTraGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ThanhTraGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraGiangDayParameterBuilder class.
		/// </summary>
		public ThanhTraGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThanhTraGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThanhTraGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThanhTraGiangDayParameterBuilder
	
	#region ThanhTraGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThanhTraGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThanhTraGiangDaySortBuilder : SqlSortBuilder<ThanhTraGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraGiangDaySqlSortBuilder class.
		/// </summary>
		public ThanhTraGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThanhTraGiangDaySortBuilder
	
} // end namespace
