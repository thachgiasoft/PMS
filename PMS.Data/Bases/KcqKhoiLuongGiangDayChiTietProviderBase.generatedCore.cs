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
	/// This class is the base class for any <see cref="KcqKhoiLuongGiangDayChiTietProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqKhoiLuongGiangDayChiTietProviderBaseCore : EntityProviderBase<PMS.Entities.KcqKhoiLuongGiangDayChiTiet, PMS.Entities.KcqKhoiLuongGiangDayChiTietKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongGiangDayChiTietKey key)
		{
			return Delete(transactionManager, key.MaKhoiLuong);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maKhoiLuong">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maKhoiLuong)
		{
			return Delete(null, _maKhoiLuong);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maKhoiLuong);		
		
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
		public override PMS.Entities.KcqKhoiLuongGiangDayChiTiet Get(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongGiangDayChiTietKey key, int start, int pageLength)
		{
			return GetByMaKhoiLuong(transactionManager, key.MaKhoiLuong, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqKhoiLuongGiangDayChiTiet index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayChiTiet"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayChiTiet GetByMaKhoiLuong(System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(null,_maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayChiTiet index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayChiTiet"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayChiTiet GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayChiTiet"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayChiTiet GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayChiTiet"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayChiTiet GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayChiTiet index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayChiTiet"/> class.</returns>
		public PMS.Entities.KcqKhoiLuongGiangDayChiTiet GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength, out int count)
		{
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKhoiLuongGiangDayChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKhoiLuongGiangDayChiTiet"/> class.</returns>
		public abstract PMS.Entities.KcqKhoiLuongGiangDayChiTiet GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqKhoiLuongGiangDayChiTiet&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqKhoiLuongGiangDayChiTiet&gt;"/></returns>
		public static TList<KcqKhoiLuongGiangDayChiTiet> Fill(IDataReader reader, TList<KcqKhoiLuongGiangDayChiTiet> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqKhoiLuongGiangDayChiTiet c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqKhoiLuongGiangDayChiTiet")
					.Append("|").Append((System.Int32)reader[((int)KcqKhoiLuongGiangDayChiTietColumn.MaKhoiLuong - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqKhoiLuongGiangDayChiTiet>(
					key.ToString(), // EntityTrackingKey
					"KcqKhoiLuongGiangDayChiTiet",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqKhoiLuongGiangDayChiTiet();
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
					c.MaLichHoc = (System.Int32)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaLichHoc.ToString())];
					c.MaGiangVien = (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaGiangVien.ToString())];
					c.MaLopHocPhan = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaLopHocPhan.ToString())];
					c.NamHoc = (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.NamHoc.ToString())];
					c.HocKy = (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.HocKy.ToString())];
					c.MaDot = (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaDot.ToString())];
					c.MaMonHoc = (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.TenMonHoc.ToString())];
					c.Nhom = (reader[KcqKhoiLuongGiangDayChiTietColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.Nhom.ToString())];
					c.SoTinChi = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.SoTinChi.ToString())];
					c.LyThuyet = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.LyThuyet.ToString())];
					c.ThucHanh = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.ThucHanh.ToString())];
					c.BaiTap = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.BaiTap.ToString())];
					c.BaiTapLon = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.BaiTapLon.ToString())];
					c.DoAn = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.DoAn.ToString())];
					c.LuanAn = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.LuanAn.ToString())];
					c.TieuLuan = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.TieuLuan.ToString())];
					c.ThucTap = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.ThucTap.ToString())];
					c.SoLuong = (reader[KcqKhoiLuongGiangDayChiTietColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.SoLuong.ToString())];
					c.MaLoaiHocPhan = (System.Byte)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaLoaiHocPhan.ToString())];
					c.LoaiHocPhan = (reader[KcqKhoiLuongGiangDayChiTietColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.LoaiHocPhan.ToString())];
					c.PhanLoai = (reader[KcqKhoiLuongGiangDayChiTietColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.PhanLoai.ToString())];
					c.HeSoThanhPhan = (reader[KcqKhoiLuongGiangDayChiTietColumn.HeSoThanhPhan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongGiangDayChiTietColumn.HeSoThanhPhan.ToString())];
					c.Nam = (reader[KcqKhoiLuongGiangDayChiTietColumn.Nam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.Nam.ToString())];
					c.Tuan = (reader[KcqKhoiLuongGiangDayChiTietColumn.Tuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.Tuan.ToString())];
					c.DonViTinh = (reader[KcqKhoiLuongGiangDayChiTietColumn.DonViTinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.DonViTinh.ToString())];
					c.MaBuoiHoc = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaBuoiHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaBuoiHoc.ToString())];
					c.MaLop = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaLop.ToString())];
					c.TietBatDau = (reader[KcqKhoiLuongGiangDayChiTietColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.TietBatDau.ToString())];
					c.SoTiet = (reader[KcqKhoiLuongGiangDayChiTietColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongGiangDayChiTietColumn.SoTiet.ToString())];
					c.LoaiHocKy = (reader[KcqKhoiLuongGiangDayChiTietColumn.LoaiHocKy.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(KcqKhoiLuongGiangDayChiTietColumn.LoaiHocKy.ToString())];
					c.HeSoHocKy = (reader[KcqKhoiLuongGiangDayChiTietColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongGiangDayChiTietColumn.HeSoHocKy.ToString())];
					c.TinhTrang = (System.Int32)reader[(KcqKhoiLuongGiangDayChiTietColumn.TinhTrang.ToString())];
					c.NgayDay = (reader[KcqKhoiLuongGiangDayChiTietColumn.NgayDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqKhoiLuongGiangDayChiTietColumn.NgayDay.ToString())];
					c.Compensate = (reader[KcqKhoiLuongGiangDayChiTietColumn.Compensate.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(KcqKhoiLuongGiangDayChiTietColumn.Compensate.ToString())];
					c.MaKhoiLuong = (System.Int32)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaKhoiLuong.ToString())];
					c.MaBacDaoTao = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaBacDaoTao.ToString())];
					c.MaKhoa = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaKhoa.ToString())];
					c.MaNhomMonHoc = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaNhomMonHoc.ToString())];
					c.MaPhongHoc = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaPhongHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaPhongHoc.ToString())];
					c.MaKhoaHoc = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaKhoaHoc.ToString())];
					c.NamThu = (reader[KcqKhoiLuongGiangDayChiTietColumn.NamThu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.NamThu.ToString())];
					c.MaHocHam = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaLoaiGiangVien.ToString())];
					c.MaChucVu = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaChucVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaChucVu.ToString())];
					c.MaHinhThucDaoTao = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaHinhThucDaoTao.ToString())];
					c.GhiChu = (reader[KcqKhoiLuongGiangDayChiTietColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[KcqKhoiLuongGiangDayChiTietColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.NgayCapNhat.ToString())];
					c.LopHocPhanChuyenNganh = (reader[KcqKhoiLuongGiangDayChiTietColumn.LopHocPhanChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqKhoiLuongGiangDayChiTietColumn.LopHocPhanChuyenNganh.ToString())];
					c.DotImport = (reader[KcqKhoiLuongGiangDayChiTietColumn.DotImport.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.DotImport.ToString())];
					c.DaoTaoTinChi = (reader[KcqKhoiLuongGiangDayChiTietColumn.DaoTaoTinChi.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqKhoiLuongGiangDayChiTietColumn.DaoTaoTinChi.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqKhoiLuongGiangDayChiTiet"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongGiangDayChiTiet"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqKhoiLuongGiangDayChiTiet entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLichHoc = (System.Int32)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaLichHoc.ToString())];
			entity.MaGiangVien = (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaGiangVien.ToString())];
			entity.MaLopHocPhan = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaLopHocPhan.ToString())];
			entity.NamHoc = (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.NamHoc.ToString())];
			entity.HocKy = (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.HocKy.ToString())];
			entity.MaDot = (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaDot.ToString())];
			entity.MaMonHoc = (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.TenMonHoc.ToString())];
			entity.Nhom = (reader[KcqKhoiLuongGiangDayChiTietColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.Nhom.ToString())];
			entity.SoTinChi = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.SoTinChi.ToString())];
			entity.LyThuyet = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.LyThuyet.ToString())];
			entity.ThucHanh = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.ThucHanh.ToString())];
			entity.BaiTap = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.BaiTap.ToString())];
			entity.BaiTapLon = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.BaiTapLon.ToString())];
			entity.DoAn = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.DoAn.ToString())];
			entity.LuanAn = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.LuanAn.ToString())];
			entity.TieuLuan = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.TieuLuan.ToString())];
			entity.ThucTap = (System.Decimal)reader[(KcqKhoiLuongGiangDayChiTietColumn.ThucTap.ToString())];
			entity.SoLuong = (reader[KcqKhoiLuongGiangDayChiTietColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.SoLuong.ToString())];
			entity.MaLoaiHocPhan = (System.Byte)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaLoaiHocPhan.ToString())];
			entity.LoaiHocPhan = (reader[KcqKhoiLuongGiangDayChiTietColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.LoaiHocPhan.ToString())];
			entity.PhanLoai = (reader[KcqKhoiLuongGiangDayChiTietColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.PhanLoai.ToString())];
			entity.HeSoThanhPhan = (reader[KcqKhoiLuongGiangDayChiTietColumn.HeSoThanhPhan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongGiangDayChiTietColumn.HeSoThanhPhan.ToString())];
			entity.Nam = (reader[KcqKhoiLuongGiangDayChiTietColumn.Nam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.Nam.ToString())];
			entity.Tuan = (reader[KcqKhoiLuongGiangDayChiTietColumn.Tuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.Tuan.ToString())];
			entity.DonViTinh = (reader[KcqKhoiLuongGiangDayChiTietColumn.DonViTinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.DonViTinh.ToString())];
			entity.MaBuoiHoc = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaBuoiHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaBuoiHoc.ToString())];
			entity.MaLop = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaLop.ToString())];
			entity.TietBatDau = (reader[KcqKhoiLuongGiangDayChiTietColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.TietBatDau.ToString())];
			entity.SoTiet = (reader[KcqKhoiLuongGiangDayChiTietColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongGiangDayChiTietColumn.SoTiet.ToString())];
			entity.LoaiHocKy = (reader[KcqKhoiLuongGiangDayChiTietColumn.LoaiHocKy.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(KcqKhoiLuongGiangDayChiTietColumn.LoaiHocKy.ToString())];
			entity.HeSoHocKy = (reader[KcqKhoiLuongGiangDayChiTietColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKhoiLuongGiangDayChiTietColumn.HeSoHocKy.ToString())];
			entity.TinhTrang = (System.Int32)reader[(KcqKhoiLuongGiangDayChiTietColumn.TinhTrang.ToString())];
			entity.NgayDay = (reader[KcqKhoiLuongGiangDayChiTietColumn.NgayDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqKhoiLuongGiangDayChiTietColumn.NgayDay.ToString())];
			entity.Compensate = (reader[KcqKhoiLuongGiangDayChiTietColumn.Compensate.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(KcqKhoiLuongGiangDayChiTietColumn.Compensate.ToString())];
			entity.MaKhoiLuong = (System.Int32)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaKhoiLuong.ToString())];
			entity.MaBacDaoTao = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaBacDaoTao.ToString())];
			entity.MaKhoa = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaKhoa.ToString())];
			entity.MaNhomMonHoc = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaNhomMonHoc.ToString())];
			entity.MaPhongHoc = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaPhongHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaPhongHoc.ToString())];
			entity.MaKhoaHoc = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaKhoaHoc.ToString())];
			entity.NamThu = (reader[KcqKhoiLuongGiangDayChiTietColumn.NamThu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.NamThu.ToString())];
			entity.MaHocHam = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaLoaiGiangVien.ToString())];
			entity.MaChucVu = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaChucVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaChucVu.ToString())];
			entity.MaHinhThucDaoTao = (reader[KcqKhoiLuongGiangDayChiTietColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.MaHinhThucDaoTao.ToString())];
			entity.GhiChu = (reader[KcqKhoiLuongGiangDayChiTietColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[KcqKhoiLuongGiangDayChiTietColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.NgayCapNhat.ToString())];
			entity.LopHocPhanChuyenNganh = (reader[KcqKhoiLuongGiangDayChiTietColumn.LopHocPhanChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqKhoiLuongGiangDayChiTietColumn.LopHocPhanChuyenNganh.ToString())];
			entity.DotImport = (reader[KcqKhoiLuongGiangDayChiTietColumn.DotImport.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKhoiLuongGiangDayChiTietColumn.DotImport.ToString())];
			entity.DaoTaoTinChi = (reader[KcqKhoiLuongGiangDayChiTietColumn.DaoTaoTinChi.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqKhoiLuongGiangDayChiTietColumn.DaoTaoTinChi.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqKhoiLuongGiangDayChiTiet"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongGiangDayChiTiet"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqKhoiLuongGiangDayChiTiet entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLichHoc = (System.Int32)dataRow["MaLichHoc"];
			entity.MaGiangVien = (System.String)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.NamHoc = (System.String)dataRow["NamHoc"];
			entity.HocKy = (System.String)dataRow["HocKy"];
			entity.MaDot = (System.String)dataRow["MaDot"];
			entity.MaMonHoc = (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (System.String)dataRow["TenMonHoc"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.SoTinChi = (System.Decimal)dataRow["SoTinChi"];
			entity.LyThuyet = (System.Decimal)dataRow["LyThuyet"];
			entity.ThucHanh = (System.Decimal)dataRow["ThucHanh"];
			entity.BaiTap = (System.Decimal)dataRow["BaiTap"];
			entity.BaiTapLon = (System.Decimal)dataRow["BaiTapLon"];
			entity.DoAn = (System.Decimal)dataRow["DoAn"];
			entity.LuanAn = (System.Decimal)dataRow["LuanAn"];
			entity.TieuLuan = (System.Decimal)dataRow["TieuLuan"];
			entity.ThucTap = (System.Decimal)dataRow["ThucTap"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Int32?)dataRow["SoLuong"];
			entity.MaLoaiHocPhan = (System.Byte)dataRow["MaLoaiHocPhan"];
			entity.LoaiHocPhan = Convert.IsDBNull(dataRow["LoaiHocPhan"]) ? null : (System.String)dataRow["LoaiHocPhan"];
			entity.PhanLoai = Convert.IsDBNull(dataRow["PhanLoai"]) ? null : (System.String)dataRow["PhanLoai"];
			entity.HeSoThanhPhan = Convert.IsDBNull(dataRow["HeSoThanhPhan"]) ? null : (System.Decimal?)dataRow["HeSoThanhPhan"];
			entity.Nam = Convert.IsDBNull(dataRow["Nam"]) ? null : (System.Int32?)dataRow["Nam"];
			entity.Tuan = Convert.IsDBNull(dataRow["Tuan"]) ? null : (System.Int32?)dataRow["Tuan"];
			entity.DonViTinh = Convert.IsDBNull(dataRow["DonViTinh"]) ? null : (System.String)dataRow["DonViTinh"];
			entity.MaBuoiHoc = Convert.IsDBNull(dataRow["MaBuoiHoc"]) ? null : (System.Int32?)dataRow["MaBuoiHoc"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.TietBatDau = Convert.IsDBNull(dataRow["TietBatDau"]) ? null : (System.Int32?)dataRow["TietBatDau"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.LoaiHocKy = Convert.IsDBNull(dataRow["LoaiHocKy"]) ? null : (System.Byte?)dataRow["LoaiHocKy"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
			entity.TinhTrang = (System.Int32)dataRow["TinhTrang"];
			entity.NgayDay = Convert.IsDBNull(dataRow["NgayDay"]) ? null : (System.DateTime?)dataRow["NgayDay"];
			entity.Compensate = Convert.IsDBNull(dataRow["Compensate"]) ? null : (System.Byte?)dataRow["Compensate"];
			entity.MaKhoiLuong = (System.Int32)dataRow["MaKhoiLuong"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.MaKhoa = Convert.IsDBNull(dataRow["MaKhoa"]) ? null : (System.String)dataRow["MaKhoa"];
			entity.MaNhomMonHoc = Convert.IsDBNull(dataRow["MaNhomMonHoc"]) ? null : (System.String)dataRow["MaNhomMonHoc"];
			entity.MaPhongHoc = Convert.IsDBNull(dataRow["MaPhongHoc"]) ? null : (System.String)dataRow["MaPhongHoc"];
			entity.MaKhoaHoc = Convert.IsDBNull(dataRow["MaKhoaHoc"]) ? null : (System.String)dataRow["MaKhoaHoc"];
			entity.NamThu = Convert.IsDBNull(dataRow["NamThu"]) ? null : (System.String)dataRow["NamThu"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaChucVu = Convert.IsDBNull(dataRow["MaChucVu"]) ? null : (System.Int32?)dataRow["MaChucVu"];
			entity.MaHinhThucDaoTao = Convert.IsDBNull(dataRow["MaHinhThucDaoTao"]) ? null : (System.String)dataRow["MaHinhThucDaoTao"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.LopHocPhanChuyenNganh = Convert.IsDBNull(dataRow["LopHocPhanChuyenNganh"]) ? null : (System.Boolean?)dataRow["LopHocPhanChuyenNganh"];
			entity.DotImport = Convert.IsDBNull(dataRow["DotImport"]) ? null : (System.String)dataRow["DotImport"];
			entity.DaoTaoTinChi = Convert.IsDBNull(dataRow["DaoTaoTinChi"]) ? null : (System.Boolean?)dataRow["DaoTaoTinChi"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqKhoiLuongGiangDayChiTiet"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqKhoiLuongGiangDayChiTiet Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongGiangDayChiTiet entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqKhoiLuongGiangDayChiTiet object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqKhoiLuongGiangDayChiTiet instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqKhoiLuongGiangDayChiTiet Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqKhoiLuongGiangDayChiTiet entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KcqKhoiLuongGiangDayChiTietChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqKhoiLuongGiangDayChiTiet</c>
	///</summary>
	public enum KcqKhoiLuongGiangDayChiTietChildEntityTypes
	{
	}
	
	#endregion KcqKhoiLuongGiangDayChiTietChildEntityTypes
	
	#region KcqKhoiLuongGiangDayChiTietFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqKhoiLuongGiangDayChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayChiTietFilterBuilder : SqlFilterBuilder<KcqKhoiLuongGiangDayChiTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayChiTietFilterBuilder class.
		/// </summary>
		public KcqKhoiLuongGiangDayChiTietFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayChiTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqKhoiLuongGiangDayChiTietFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayChiTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqKhoiLuongGiangDayChiTietFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqKhoiLuongGiangDayChiTietFilterBuilder
	
	#region KcqKhoiLuongGiangDayChiTietParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqKhoiLuongGiangDayChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayChiTietParameterBuilder : ParameterizedSqlFilterBuilder<KcqKhoiLuongGiangDayChiTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayChiTietParameterBuilder class.
		/// </summary>
		public KcqKhoiLuongGiangDayChiTietParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayChiTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqKhoiLuongGiangDayChiTietParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayChiTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqKhoiLuongGiangDayChiTietParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqKhoiLuongGiangDayChiTietParameterBuilder
	
	#region KcqKhoiLuongGiangDayChiTietSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqKhoiLuongGiangDayChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayChiTiet"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqKhoiLuongGiangDayChiTietSortBuilder : SqlSortBuilder<KcqKhoiLuongGiangDayChiTietColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayChiTietSqlSortBuilder class.
		/// </summary>
		public KcqKhoiLuongGiangDayChiTietSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqKhoiLuongGiangDayChiTietSortBuilder
	
} // end namespace
