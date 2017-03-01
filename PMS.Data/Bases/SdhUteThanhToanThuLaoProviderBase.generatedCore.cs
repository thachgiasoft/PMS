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
	/// This class is the base class for any <see cref="SdhUteThanhToanThuLaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SdhUteThanhToanThuLaoProviderBaseCore : EntityProviderBase<PMS.Entities.SdhUteThanhToanThuLao, PMS.Entities.SdhUteThanhToanThuLaoKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.SdhUteThanhToanThuLaoKey key)
		{
			return Delete(transactionManager, key.IdKhoiLuongQuyDoi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_idKhoiLuongQuyDoi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _idKhoiLuongQuyDoi)
		{
			return Delete(null, _idKhoiLuongQuyDoi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idKhoiLuongQuyDoi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _idKhoiLuongQuyDoi);		
		
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
		public override PMS.Entities.SdhUteThanhToanThuLao Get(TransactionManager transactionManager, PMS.Entities.SdhUteThanhToanThuLaoKey key, int start, int pageLength)
		{
			return GetByIdKhoiLuongQuyDoi(transactionManager, key.IdKhoiLuongQuyDoi, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SdhUte_ThanhToanThuLao index.
		/// </summary>
		/// <param name="_idKhoiLuongQuyDoi"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhUteThanhToanThuLao"/> class.</returns>
		public PMS.Entities.SdhUteThanhToanThuLao GetByIdKhoiLuongQuyDoi(System.Int32 _idKhoiLuongQuyDoi)
		{
			int count = -1;
			return GetByIdKhoiLuongQuyDoi(null,_idKhoiLuongQuyDoi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhUte_ThanhToanThuLao index.
		/// </summary>
		/// <param name="_idKhoiLuongQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhUteThanhToanThuLao"/> class.</returns>
		public PMS.Entities.SdhUteThanhToanThuLao GetByIdKhoiLuongQuyDoi(System.Int32 _idKhoiLuongQuyDoi, int start, int pageLength)
		{
			int count = -1;
			return GetByIdKhoiLuongQuyDoi(null, _idKhoiLuongQuyDoi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhUte_ThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idKhoiLuongQuyDoi"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhUteThanhToanThuLao"/> class.</returns>
		public PMS.Entities.SdhUteThanhToanThuLao GetByIdKhoiLuongQuyDoi(TransactionManager transactionManager, System.Int32 _idKhoiLuongQuyDoi)
		{
			int count = -1;
			return GetByIdKhoiLuongQuyDoi(transactionManager, _idKhoiLuongQuyDoi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhUte_ThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idKhoiLuongQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhUteThanhToanThuLao"/> class.</returns>
		public PMS.Entities.SdhUteThanhToanThuLao GetByIdKhoiLuongQuyDoi(TransactionManager transactionManager, System.Int32 _idKhoiLuongQuyDoi, int start, int pageLength)
		{
			int count = -1;
			return GetByIdKhoiLuongQuyDoi(transactionManager, _idKhoiLuongQuyDoi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhUte_ThanhToanThuLao index.
		/// </summary>
		/// <param name="_idKhoiLuongQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhUteThanhToanThuLao"/> class.</returns>
		public PMS.Entities.SdhUteThanhToanThuLao GetByIdKhoiLuongQuyDoi(System.Int32 _idKhoiLuongQuyDoi, int start, int pageLength, out int count)
		{
			return GetByIdKhoiLuongQuyDoi(null, _idKhoiLuongQuyDoi, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhUte_ThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idKhoiLuongQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhUteThanhToanThuLao"/> class.</returns>
		public abstract PMS.Entities.SdhUteThanhToanThuLao GetByIdKhoiLuongQuyDoi(TransactionManager transactionManager, System.Int32 _idKhoiLuongQuyDoi, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_SdhUte_ThanhToanThuLao_ThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_SdhUte_ThanhToanThuLao_ThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ThanhToan(System.String namHoc, System.String hocKy)
		{
			 ThanhToan(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhUte_ThanhToanThuLao_ThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ThanhToan(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 ThanhToan(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_SdhUte_ThanhToanThuLao_ThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ThanhToan(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 ThanhToan(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhUte_ThanhToanThuLao_ThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ThanhToan(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SdhUteThanhToanThuLao&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SdhUteThanhToanThuLao&gt;"/></returns>
		public static TList<SdhUteThanhToanThuLao> Fill(IDataReader reader, TList<SdhUteThanhToanThuLao> rows, int start, int pageLength)
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
				
				PMS.Entities.SdhUteThanhToanThuLao c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SdhUteThanhToanThuLao")
					.Append("|").Append((System.Int32)reader[((int)SdhUteThanhToanThuLaoColumn.IdKhoiLuongQuyDoi - 1)]).ToString();
					c = EntityManager.LocateOrCreate<SdhUteThanhToanThuLao>(
					key.ToString(), // EntityTrackingKey
					"SdhUteThanhToanThuLao",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.SdhUteThanhToanThuLao();
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
					c.IdKhoiLuongQuyDoi = (System.Int32)reader[(SdhUteThanhToanThuLaoColumn.IdKhoiLuongQuyDoi.ToString())];
					c.OriginalIdKhoiLuongQuyDoi = c.IdKhoiLuongQuyDoi;
					c.MaMonHoc = (reader[SdhUteThanhToanThuLaoColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[SdhUteThanhToanThuLaoColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.TenMonHoc.ToString())];
					c.NhomMonHoc = (reader[SdhUteThanhToanThuLaoColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.NhomMonHoc.ToString())];
					c.NamHoc = (reader[SdhUteThanhToanThuLaoColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.NamHoc.ToString())];
					c.HocKy = (reader[SdhUteThanhToanThuLaoColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.HocKy.ToString())];
					c.MaLopHocPhan = (reader[SdhUteThanhToanThuLaoColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.MaLopHocPhan.ToString())];
					c.Nhom = (reader[SdhUteThanhToanThuLaoColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.Nhom.ToString())];
					c.MaLop = (reader[SdhUteThanhToanThuLaoColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.MaLop.ToString())];
					c.SoTinChi = (reader[SdhUteThanhToanThuLaoColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.SoTinChi.ToString())];
					c.SoTiet = (reader[SdhUteThanhToanThuLaoColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.SoTiet.ToString())];
					c.SiSo = (reader[SdhUteThanhToanThuLaoColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.SiSo.ToString())];
					c.LopClc = (reader[SdhUteThanhToanThuLaoColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(SdhUteThanhToanThuLaoColumn.LopClc.ToString())];
					c.SoTietDayChuNhat = (reader[SdhUteThanhToanThuLaoColumn.SoTietDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.SoTietDayChuNhat.ToString())];
					c.MaLoaiHocPhan = (reader[SdhUteThanhToanThuLaoColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.MaLoaiHocPhan.ToString())];
					c.HeSoLopDongLyThuyet = (reader[SdhUteThanhToanThuLaoColumn.HeSoLopDongLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.HeSoLopDongLyThuyet.ToString())];
					c.HeSoLopDongThTnTt = (reader[SdhUteThanhToanThuLaoColumn.HeSoLopDongThTnTt.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.HeSoLopDongThTnTt.ToString())];
					c.MaQuanLy = (reader[SdhUteThanhToanThuLaoColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.MaQuanLy.ToString())];
					c.Ho = (reader[SdhUteThanhToanThuLaoColumn.Ho.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.Ho.ToString())];
					c.Ten = (reader[SdhUteThanhToanThuLaoColumn.Ten.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.Ten.ToString())];
					c.HoTen = (reader[SdhUteThanhToanThuLaoColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.HoTen.ToString())];
					c.MaHocHam = (reader[SdhUteThanhToanThuLaoColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[SdhUteThanhToanThuLaoColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[SdhUteThanhToanThuLaoColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.MaLoaiGiangVien.ToString())];
					c.MaDonVi = (reader[SdhUteThanhToanThuLaoColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.MaDonVi.ToString())];
					c.DonGia = (reader[SdhUteThanhToanThuLaoColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.DonGia.ToString())];
					c.TietQuyDoi = (reader[SdhUteThanhToanThuLaoColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.TietQuyDoi.ToString())];
					c.ThanhTienDayChuNhat = (reader[SdhUteThanhToanThuLaoColumn.ThanhTienDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.ThanhTienDayChuNhat.ToString())];
					c.ThanhTien = (reader[SdhUteThanhToanThuLaoColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.ThanhTien.ToString())];
					c.TongThanhTien = (reader[SdhUteThanhToanThuLaoColumn.TongThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.TongThanhTien.ToString())];
					c.NgayCapNhat = (reader[SdhUteThanhToanThuLaoColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(SdhUteThanhToanThuLaoColumn.NgayCapNhat.ToString())];
					c.DaChot = (reader[SdhUteThanhToanThuLaoColumn.DaChot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(SdhUteThanhToanThuLaoColumn.DaChot.ToString())];
					c.HeSoHocKy = (reader[SdhUteThanhToanThuLaoColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.HeSoHocKy.ToString())];
					c.SoGioThucGiangTrenLop = (reader[SdhUteThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString())];
					c.SoGioChuanTinhThem = (reader[SdhUteThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString())];
					c.MaDiaDiem = (reader[SdhUteThanhToanThuLaoColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.MaDiaDiem.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SdhUteThanhToanThuLao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SdhUteThanhToanThuLao"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.SdhUteThanhToanThuLao entity)
		{
			if (!reader.Read()) return;
			
			entity.IdKhoiLuongQuyDoi = (System.Int32)reader[(SdhUteThanhToanThuLaoColumn.IdKhoiLuongQuyDoi.ToString())];
			entity.OriginalIdKhoiLuongQuyDoi = (System.Int32)reader["IdKhoiLuongQuyDoi"];
			entity.MaMonHoc = (reader[SdhUteThanhToanThuLaoColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[SdhUteThanhToanThuLaoColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.TenMonHoc.ToString())];
			entity.NhomMonHoc = (reader[SdhUteThanhToanThuLaoColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.NhomMonHoc.ToString())];
			entity.NamHoc = (reader[SdhUteThanhToanThuLaoColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.NamHoc.ToString())];
			entity.HocKy = (reader[SdhUteThanhToanThuLaoColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.HocKy.ToString())];
			entity.MaLopHocPhan = (reader[SdhUteThanhToanThuLaoColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.MaLopHocPhan.ToString())];
			entity.Nhom = (reader[SdhUteThanhToanThuLaoColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.Nhom.ToString())];
			entity.MaLop = (reader[SdhUteThanhToanThuLaoColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.MaLop.ToString())];
			entity.SoTinChi = (reader[SdhUteThanhToanThuLaoColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.SoTinChi.ToString())];
			entity.SoTiet = (reader[SdhUteThanhToanThuLaoColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.SoTiet.ToString())];
			entity.SiSo = (reader[SdhUteThanhToanThuLaoColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.SiSo.ToString())];
			entity.LopClc = (reader[SdhUteThanhToanThuLaoColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(SdhUteThanhToanThuLaoColumn.LopClc.ToString())];
			entity.SoTietDayChuNhat = (reader[SdhUteThanhToanThuLaoColumn.SoTietDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.SoTietDayChuNhat.ToString())];
			entity.MaLoaiHocPhan = (reader[SdhUteThanhToanThuLaoColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.MaLoaiHocPhan.ToString())];
			entity.HeSoLopDongLyThuyet = (reader[SdhUteThanhToanThuLaoColumn.HeSoLopDongLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.HeSoLopDongLyThuyet.ToString())];
			entity.HeSoLopDongThTnTt = (reader[SdhUteThanhToanThuLaoColumn.HeSoLopDongThTnTt.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.HeSoLopDongThTnTt.ToString())];
			entity.MaQuanLy = (reader[SdhUteThanhToanThuLaoColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.MaQuanLy.ToString())];
			entity.Ho = (reader[SdhUteThanhToanThuLaoColumn.Ho.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.Ho.ToString())];
			entity.Ten = (reader[SdhUteThanhToanThuLaoColumn.Ten.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.Ten.ToString())];
			entity.HoTen = (reader[SdhUteThanhToanThuLaoColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.HoTen.ToString())];
			entity.MaHocHam = (reader[SdhUteThanhToanThuLaoColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[SdhUteThanhToanThuLaoColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[SdhUteThanhToanThuLaoColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhUteThanhToanThuLaoColumn.MaLoaiGiangVien.ToString())];
			entity.MaDonVi = (reader[SdhUteThanhToanThuLaoColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.MaDonVi.ToString())];
			entity.DonGia = (reader[SdhUteThanhToanThuLaoColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.DonGia.ToString())];
			entity.TietQuyDoi = (reader[SdhUteThanhToanThuLaoColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.TietQuyDoi.ToString())];
			entity.ThanhTienDayChuNhat = (reader[SdhUteThanhToanThuLaoColumn.ThanhTienDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.ThanhTienDayChuNhat.ToString())];
			entity.ThanhTien = (reader[SdhUteThanhToanThuLaoColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.ThanhTien.ToString())];
			entity.TongThanhTien = (reader[SdhUteThanhToanThuLaoColumn.TongThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.TongThanhTien.ToString())];
			entity.NgayCapNhat = (reader[SdhUteThanhToanThuLaoColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(SdhUteThanhToanThuLaoColumn.NgayCapNhat.ToString())];
			entity.DaChot = (reader[SdhUteThanhToanThuLaoColumn.DaChot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(SdhUteThanhToanThuLaoColumn.DaChot.ToString())];
			entity.HeSoHocKy = (reader[SdhUteThanhToanThuLaoColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.HeSoHocKy.ToString())];
			entity.SoGioThucGiangTrenLop = (reader[SdhUteThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString())];
			entity.SoGioChuanTinhThem = (reader[SdhUteThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhUteThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString())];
			entity.MaDiaDiem = (reader[SdhUteThanhToanThuLaoColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhUteThanhToanThuLaoColumn.MaDiaDiem.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SdhUteThanhToanThuLao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SdhUteThanhToanThuLao"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.SdhUteThanhToanThuLao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.IdKhoiLuongQuyDoi = (System.Int32)dataRow["IdKhoiLuongQuyDoi"];
			entity.OriginalIdKhoiLuongQuyDoi = (System.Int32)dataRow["IdKhoiLuongQuyDoi"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.NhomMonHoc = Convert.IsDBNull(dataRow["NhomMonHoc"]) ? null : (System.String)dataRow["NhomMonHoc"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Int32?)dataRow["SoTiet"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.LopClc = Convert.IsDBNull(dataRow["LopClc"]) ? null : (System.Boolean?)dataRow["LopClc"];
			entity.SoTietDayChuNhat = Convert.IsDBNull(dataRow["SoTietDayChuNhat"]) ? null : (System.Int32?)dataRow["SoTietDayChuNhat"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.HeSoLopDongLyThuyet = Convert.IsDBNull(dataRow["HeSoLopDongLyThuyet"]) ? null : (System.Decimal?)dataRow["HeSoLopDongLyThuyet"];
			entity.HeSoLopDongThTnTt = Convert.IsDBNull(dataRow["HeSoLopDongThTnTt"]) ? null : (System.Decimal?)dataRow["HeSoLopDongThTnTt"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.Ho = Convert.IsDBNull(dataRow["Ho"]) ? null : (System.String)dataRow["Ho"];
			entity.Ten = Convert.IsDBNull(dataRow["Ten"]) ? null : (System.String)dataRow["Ten"];
			entity.HoTen = Convert.IsDBNull(dataRow["HoTen"]) ? null : (System.String)dataRow["HoTen"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.String)dataRow["MaDonVi"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.ThanhTienDayChuNhat = Convert.IsDBNull(dataRow["ThanhTienDayChuNhat"]) ? null : (System.Decimal?)dataRow["ThanhTienDayChuNhat"];
			entity.ThanhTien = Convert.IsDBNull(dataRow["ThanhTien"]) ? null : (System.Decimal?)dataRow["ThanhTien"];
			entity.TongThanhTien = Convert.IsDBNull(dataRow["TongThanhTien"]) ? null : (System.Decimal?)dataRow["TongThanhTien"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.DaChot = Convert.IsDBNull(dataRow["DaChot"]) ? null : (System.Boolean?)dataRow["DaChot"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
			entity.SoGioThucGiangTrenLop = Convert.IsDBNull(dataRow["SoGioThucGiangTrenLop"]) ? null : (System.Decimal?)dataRow["SoGioThucGiangTrenLop"];
			entity.SoGioChuanTinhThem = Convert.IsDBNull(dataRow["SoGioChuanTinhThem"]) ? null : (System.Decimal?)dataRow["SoGioChuanTinhThem"];
			entity.MaDiaDiem = Convert.IsDBNull(dataRow["MaDiaDiem"]) ? null : (System.String)dataRow["MaDiaDiem"];
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
		/// <param name="entity">The <see cref="PMS.Entities.SdhUteThanhToanThuLao"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.SdhUteThanhToanThuLao Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.SdhUteThanhToanThuLao entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region IdKhoiLuongQuyDoiSource	
			if (CanDeepLoad(entity, "SdhUteKhoiLuongQuyDoi|IdKhoiLuongQuyDoiSource", deepLoadType, innerList) 
				&& entity.IdKhoiLuongQuyDoiSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.IdKhoiLuongQuyDoi;
				SdhUteKhoiLuongQuyDoi tmpEntity = EntityManager.LocateEntity<SdhUteKhoiLuongQuyDoi>(EntityLocator.ConstructKeyFromPkItems(typeof(SdhUteKhoiLuongQuyDoi), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.IdKhoiLuongQuyDoiSource = tmpEntity;
				else
					entity.IdKhoiLuongQuyDoiSource = DataRepository.SdhUteKhoiLuongQuyDoiProvider.GetById(transactionManager, entity.IdKhoiLuongQuyDoi);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'IdKhoiLuongQuyDoiSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.IdKhoiLuongQuyDoiSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SdhUteKhoiLuongQuyDoiProvider.DeepLoad(transactionManager, entity.IdKhoiLuongQuyDoiSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion IdKhoiLuongQuyDoiSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.SdhUteThanhToanThuLao object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.SdhUteThanhToanThuLao instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.SdhUteThanhToanThuLao Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.SdhUteThanhToanThuLao entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region IdKhoiLuongQuyDoiSource
			if (CanDeepSave(entity, "SdhUteKhoiLuongQuyDoi|IdKhoiLuongQuyDoiSource", deepSaveType, innerList) 
				&& entity.IdKhoiLuongQuyDoiSource != null)
			{
				DataRepository.SdhUteKhoiLuongQuyDoiProvider.Save(transactionManager, entity.IdKhoiLuongQuyDoiSource);
				entity.IdKhoiLuongQuyDoi = entity.IdKhoiLuongQuyDoiSource.Id;
			}
			#endregion 
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
	
	#region SdhUteThanhToanThuLaoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.SdhUteThanhToanThuLao</c>
	///</summary>
	public enum SdhUteThanhToanThuLaoChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SdhUteKhoiLuongQuyDoi</c> at IdKhoiLuongQuyDoiSource
		///</summary>
		[ChildEntityType(typeof(SdhUteKhoiLuongQuyDoi))]
		SdhUteKhoiLuongQuyDoi,
	}
	
	#endregion SdhUteThanhToanThuLaoChildEntityTypes
	
	#region SdhUteThanhToanThuLaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SdhUteThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhUteThanhToanThuLaoFilterBuilder : SqlFilterBuilder<SdhUteThanhToanThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhUteThanhToanThuLaoFilterBuilder class.
		/// </summary>
		public SdhUteThanhToanThuLaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SdhUteThanhToanThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SdhUteThanhToanThuLaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SdhUteThanhToanThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SdhUteThanhToanThuLaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SdhUteThanhToanThuLaoFilterBuilder
	
	#region SdhUteThanhToanThuLaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SdhUteThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhUteThanhToanThuLaoParameterBuilder : ParameterizedSqlFilterBuilder<SdhUteThanhToanThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhUteThanhToanThuLaoParameterBuilder class.
		/// </summary>
		public SdhUteThanhToanThuLaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SdhUteThanhToanThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SdhUteThanhToanThuLaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SdhUteThanhToanThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SdhUteThanhToanThuLaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SdhUteThanhToanThuLaoParameterBuilder
	
	#region SdhUteThanhToanThuLaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SdhUteThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteThanhToanThuLao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SdhUteThanhToanThuLaoSortBuilder : SqlSortBuilder<SdhUteThanhToanThuLaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhUteThanhToanThuLaoSqlSortBuilder class.
		/// </summary>
		public SdhUteThanhToanThuLaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SdhUteThanhToanThuLaoSortBuilder
	
} // end namespace
