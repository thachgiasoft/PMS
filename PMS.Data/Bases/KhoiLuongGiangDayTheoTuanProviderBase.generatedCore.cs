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
	/// This class is the base class for any <see cref="KhoiLuongGiangDayTheoTuanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KhoiLuongGiangDayTheoTuanProviderBaseCore : EntityProviderBase<PMS.Entities.KhoiLuongGiangDayTheoTuan, PMS.Entities.KhoiLuongGiangDayTheoTuanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayTheoTuanKey key)
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
		public override PMS.Entities.KhoiLuongGiangDayTheoTuan Get(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayTheoTuanKey key, int start, int pageLength)
		{
			return GetByMaKhoiLuong(transactionManager, key.MaKhoiLuong, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KhoiLuongGiangDayTheoTuan index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayTheoTuan"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayTheoTuan GetByMaKhoiLuong(System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(null,_maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayTheoTuan index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayTheoTuan"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayTheoTuan GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayTheoTuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayTheoTuan"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayTheoTuan GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayTheoTuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayTheoTuan"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayTheoTuan GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayTheoTuan index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayTheoTuan"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayTheoTuan GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength, out int count)
		{
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayTheoTuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayTheoTuan"/> class.</returns>
		public abstract PMS.Entities.KhoiLuongGiangDayTheoTuan GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KhoiLuongGiangDayTheoTuan_GetByMaLopHocPhanMaGiangVienTuanNam 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTheoTuan_GetByMaLopHocPhanMaGiangVienTuanNam' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tuan"> A <c>System.Int32</c> instance.</param>
		/// <param name="nam"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayTheoTuan&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayTheoTuan> GetByMaLopHocPhanMaGiangVienTuanNam(System.String maLopHocPhan, System.String maGiangVien, System.Int32 tuan, System.Int32 nam)
		{
			return GetByMaLopHocPhanMaGiangVienTuanNam(null, 0, int.MaxValue , maLopHocPhan, maGiangVien, tuan, nam);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTheoTuan_GetByMaLopHocPhanMaGiangVienTuanNam' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tuan"> A <c>System.Int32</c> instance.</param>
		/// <param name="nam"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayTheoTuan&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayTheoTuan> GetByMaLopHocPhanMaGiangVienTuanNam(int start, int pageLength, System.String maLopHocPhan, System.String maGiangVien, System.Int32 tuan, System.Int32 nam)
		{
			return GetByMaLopHocPhanMaGiangVienTuanNam(null, start, pageLength , maLopHocPhan, maGiangVien, tuan, nam);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTheoTuan_GetByMaLopHocPhanMaGiangVienTuanNam' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tuan"> A <c>System.Int32</c> instance.</param>
		/// <param name="nam"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayTheoTuan&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayTheoTuan> GetByMaLopHocPhanMaGiangVienTuanNam(TransactionManager transactionManager, System.String maLopHocPhan, System.String maGiangVien, System.Int32 tuan, System.Int32 nam)
		{
			return GetByMaLopHocPhanMaGiangVienTuanNam(transactionManager, 0, int.MaxValue , maLopHocPhan, maGiangVien, tuan, nam);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTheoTuan_GetByMaLopHocPhanMaGiangVienTuanNam' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tuan"> A <c>System.Int32</c> instance.</param>
		/// <param name="nam"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayTheoTuan&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDayTheoTuan> GetByMaLopHocPhanMaGiangVienTuanNam(TransactionManager transactionManager, int start, int pageLength , System.String maLopHocPhan, System.String maGiangVien, System.Int32 tuan, System.Int32 nam);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KhoiLuongGiangDayTheoTuan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KhoiLuongGiangDayTheoTuan&gt;"/></returns>
		public static TList<KhoiLuongGiangDayTheoTuan> Fill(IDataReader reader, TList<KhoiLuongGiangDayTheoTuan> rows, int start, int pageLength)
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
				
				PMS.Entities.KhoiLuongGiangDayTheoTuan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KhoiLuongGiangDayTheoTuan")
					.Append("|").Append((System.Int32)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaKhoiLuong - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KhoiLuongGiangDayTheoTuan>(
					key.ToString(), // EntityTrackingKey
					"KhoiLuongGiangDayTheoTuan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KhoiLuongGiangDayTheoTuan();
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
					c.MaKhoiLuong = (System.Int32)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaKhoiLuong - 1)];
					c.MaToaNha = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.MaToaNha - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaToaNha - 1)];
					c.MaLopHocPhan = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.MaLopHocPhan - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaLopHocPhan - 1)];
					c.MaLop = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.MaLop - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaLop - 1)];
					c.MaNhom = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.MaNhom - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaNhom - 1)];
					c.LoaiHocPhan = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.LoaiHocPhan - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.LoaiHocPhan - 1)];
					c.PhanLoai = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.PhanLoai - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.PhanLoai - 1)];
					c.MaMonHoc = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.MaMonHoc - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaMonHoc - 1)];
					c.DienGiai = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.DienGiai - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.DienGiai - 1)];
					c.SoTiet = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.SoTiet - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.SoTiet - 1)];
					c.SoTinChi = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.SoTinChi - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.SoTinChi - 1)];
					c.SiSoLop = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.SiSoLop - 1)))?null:(System.Int32?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.SiSoLop - 1)];
					c.SoNhom = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.SoNhom - 1)))?null:(System.Int32?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.SoNhom - 1)];
					c.MaDiaDiem = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.MaDiaDiem - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaDiaDiem - 1)];
					c.NgayBatDau = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.NgayBatDau - 1)))?null:(System.DateTime?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.NgayBatDau - 1)];
					c.NgayKetThuc = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.NgayKetThuc - 1)))?null:(System.DateTime?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.NgayKetThuc - 1)];
					c.ChatLuongCao = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.ChatLuongCao - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.ChatLuongCao - 1)];
					c.NgoaiGio = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.NgoaiGio - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.NgoaiGio - 1)];
					c.TrongGio = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.TrongGio - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.TrongGio - 1)];
					c.HeSoLopDong = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.HeSoLopDong - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.HeSoLopDong - 1)];
					c.HeSoCoSo = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.HeSoCoSo - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.HeSoCoSo - 1)];
					c.HeSoHocKy = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.HeSoHocKy - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.HeSoHocKy - 1)];
					c.HeSoThanhPhan = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.HeSoThanhPhan - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.HeSoThanhPhan - 1)];
					c.HeSoTrongGio = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.HeSoTrongGio - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.HeSoTrongGio - 1)];
					c.HeSoNgoaiGio = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.HeSoNgoaiGio - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.HeSoNgoaiGio - 1)];
					c.TietQuyDoi = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.TietQuyDoi - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.TietQuyDoi - 1)];
					c.LoaiHocKy = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.LoaiHocKy - 1)))?null:(System.Int32?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.LoaiHocKy - 1)];
					c.ThoiKhoaBieu = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.ThoiKhoaBieu - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.ThoiKhoaBieu - 1)];
					c.NgayTao = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.NgayTao - 1)))?null:(System.DateTime?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.NgayTao - 1)];
					c.Tuan = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.Tuan - 1)))?null:(System.Int32?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.Tuan - 1)];
					c.Nam = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.Nam - 1)))?null:(System.Int32?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.Nam - 1)];
					c.MaQuanLy = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.MaQuanLy - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaQuanLy - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongGiangDayTheoTuan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayTheoTuan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KhoiLuongGiangDayTheoTuan entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKhoiLuong = (System.Int32)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaKhoiLuong - 1)];
			entity.MaToaNha = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.MaToaNha - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaToaNha - 1)];
			entity.MaLopHocPhan = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.MaLopHocPhan - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaLopHocPhan - 1)];
			entity.MaLop = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.MaLop - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaLop - 1)];
			entity.MaNhom = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.MaNhom - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaNhom - 1)];
			entity.LoaiHocPhan = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.LoaiHocPhan - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.LoaiHocPhan - 1)];
			entity.PhanLoai = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.PhanLoai - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.PhanLoai - 1)];
			entity.MaMonHoc = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.MaMonHoc - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaMonHoc - 1)];
			entity.DienGiai = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.DienGiai - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.DienGiai - 1)];
			entity.SoTiet = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.SoTiet - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.SoTiet - 1)];
			entity.SoTinChi = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.SoTinChi - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.SoTinChi - 1)];
			entity.SiSoLop = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.SiSoLop - 1)))?null:(System.Int32?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.SiSoLop - 1)];
			entity.SoNhom = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.SoNhom - 1)))?null:(System.Int32?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.SoNhom - 1)];
			entity.MaDiaDiem = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.MaDiaDiem - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaDiaDiem - 1)];
			entity.NgayBatDau = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.NgayBatDau - 1)))?null:(System.DateTime?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.NgayBatDau - 1)];
			entity.NgayKetThuc = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.NgayKetThuc - 1)))?null:(System.DateTime?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.NgayKetThuc - 1)];
			entity.ChatLuongCao = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.ChatLuongCao - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.ChatLuongCao - 1)];
			entity.NgoaiGio = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.NgoaiGio - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.NgoaiGio - 1)];
			entity.TrongGio = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.TrongGio - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.TrongGio - 1)];
			entity.HeSoLopDong = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.HeSoLopDong - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.HeSoLopDong - 1)];
			entity.HeSoCoSo = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.HeSoCoSo - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.HeSoCoSo - 1)];
			entity.HeSoHocKy = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.HeSoHocKy - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.HeSoHocKy - 1)];
			entity.HeSoThanhPhan = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.HeSoThanhPhan - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.HeSoThanhPhan - 1)];
			entity.HeSoTrongGio = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.HeSoTrongGio - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.HeSoTrongGio - 1)];
			entity.HeSoNgoaiGio = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.HeSoNgoaiGio - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.HeSoNgoaiGio - 1)];
			entity.TietQuyDoi = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.TietQuyDoi - 1)))?null:(System.Decimal?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.TietQuyDoi - 1)];
			entity.LoaiHocKy = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.LoaiHocKy - 1)))?null:(System.Int32?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.LoaiHocKy - 1)];
			entity.ThoiKhoaBieu = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.ThoiKhoaBieu - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.ThoiKhoaBieu - 1)];
			entity.NgayTao = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.NgayTao - 1)))?null:(System.DateTime?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.NgayTao - 1)];
			entity.Tuan = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.Tuan - 1)))?null:(System.Int32?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.Tuan - 1)];
			entity.Nam = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.Nam - 1)))?null:(System.Int32?)reader[((int)KhoiLuongGiangDayTheoTuanColumn.Nam - 1)];
			entity.MaQuanLy = (reader.IsDBNull(((int)KhoiLuongGiangDayTheoTuanColumn.MaQuanLy - 1)))?null:(System.String)reader[((int)KhoiLuongGiangDayTheoTuanColumn.MaQuanLy - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongGiangDayTheoTuan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayTheoTuan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KhoiLuongGiangDayTheoTuan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoiLuong = (System.Int32)dataRow["MaKhoiLuong"];
			entity.MaToaNha = Convert.IsDBNull(dataRow["MaToaNha"]) ? null : (System.String)dataRow["MaToaNha"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.MaNhom = Convert.IsDBNull(dataRow["MaNhom"]) ? null : (System.String)dataRow["MaNhom"];
			entity.LoaiHocPhan = Convert.IsDBNull(dataRow["LoaiHocPhan"]) ? null : (System.String)dataRow["LoaiHocPhan"];
			entity.PhanLoai = Convert.IsDBNull(dataRow["PhanLoai"]) ? null : (System.String)dataRow["PhanLoai"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.DienGiai = Convert.IsDBNull(dataRow["DienGiai"]) ? null : (System.String)dataRow["DienGiai"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Decimal?)dataRow["SoTinChi"];
			entity.SiSoLop = Convert.IsDBNull(dataRow["SiSoLop"]) ? null : (System.Int32?)dataRow["SiSoLop"];
			entity.SoNhom = Convert.IsDBNull(dataRow["SoNhom"]) ? null : (System.Int32?)dataRow["SoNhom"];
			entity.MaDiaDiem = Convert.IsDBNull(dataRow["MaDiaDiem"]) ? null : (System.String)dataRow["MaDiaDiem"];
			entity.NgayBatDau = Convert.IsDBNull(dataRow["NgayBatDau"]) ? null : (System.DateTime?)dataRow["NgayBatDau"];
			entity.NgayKetThuc = Convert.IsDBNull(dataRow["NgayKetThuc"]) ? null : (System.DateTime?)dataRow["NgayKetThuc"];
			entity.ChatLuongCao = Convert.IsDBNull(dataRow["ChatLuongCao"]) ? null : (System.Decimal?)dataRow["ChatLuongCao"];
			entity.NgoaiGio = Convert.IsDBNull(dataRow["NgoaiGio"]) ? null : (System.Decimal?)dataRow["NgoaiGio"];
			entity.TrongGio = Convert.IsDBNull(dataRow["TrongGio"]) ? null : (System.Decimal?)dataRow["TrongGio"];
			entity.HeSoLopDong = Convert.IsDBNull(dataRow["HeSoLopDong"]) ? null : (System.Decimal?)dataRow["HeSoLopDong"];
			entity.HeSoCoSo = Convert.IsDBNull(dataRow["HeSoCoSo"]) ? null : (System.Decimal?)dataRow["HeSoCoSo"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
			entity.HeSoThanhPhan = Convert.IsDBNull(dataRow["HeSoThanhPhan"]) ? null : (System.Decimal?)dataRow["HeSoThanhPhan"];
			entity.HeSoTrongGio = Convert.IsDBNull(dataRow["HeSoTrongGio"]) ? null : (System.Decimal?)dataRow["HeSoTrongGio"];
			entity.HeSoNgoaiGio = Convert.IsDBNull(dataRow["HeSoNgoaiGio"]) ? null : (System.Decimal?)dataRow["HeSoNgoaiGio"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.LoaiHocKy = Convert.IsDBNull(dataRow["LoaiHocKy"]) ? null : (System.Int32?)dataRow["LoaiHocKy"];
			entity.ThoiKhoaBieu = Convert.IsDBNull(dataRow["ThoiKhoaBieu"]) ? null : (System.String)dataRow["ThoiKhoaBieu"];
			entity.NgayTao = Convert.IsDBNull(dataRow["NgayTao"]) ? null : (System.DateTime?)dataRow["NgayTao"];
			entity.Tuan = Convert.IsDBNull(dataRow["Tuan"]) ? null : (System.Int32?)dataRow["Tuan"];
			entity.Nam = Convert.IsDBNull(dataRow["Nam"]) ? null : (System.Int32?)dataRow["Nam"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayTheoTuan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongGiangDayTheoTuan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayTheoTuan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KhoiLuongGiangDayTheoTuan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KhoiLuongGiangDayTheoTuan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongGiangDayTheoTuan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayTheoTuan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KhoiLuongGiangDayTheoTuanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KhoiLuongGiangDayTheoTuan</c>
	///</summary>
	public enum KhoiLuongGiangDayTheoTuanChildEntityTypes
	{
	}
	
	#endregion KhoiLuongGiangDayTheoTuanChildEntityTypes
	
	#region KhoiLuongGiangDayTheoTuanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KhoiLuongGiangDayTheoTuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayTheoTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayTheoTuanFilterBuilder : SqlFilterBuilder<KhoiLuongGiangDayTheoTuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTheoTuanFilterBuilder class.
		/// </summary>
		public KhoiLuongGiangDayTheoTuanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTheoTuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongGiangDayTheoTuanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTheoTuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongGiangDayTheoTuanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongGiangDayTheoTuanFilterBuilder
	
	#region KhoiLuongGiangDayTheoTuanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KhoiLuongGiangDayTheoTuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayTheoTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayTheoTuanParameterBuilder : ParameterizedSqlFilterBuilder<KhoiLuongGiangDayTheoTuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTheoTuanParameterBuilder class.
		/// </summary>
		public KhoiLuongGiangDayTheoTuanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTheoTuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongGiangDayTheoTuanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTheoTuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongGiangDayTheoTuanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongGiangDayTheoTuanParameterBuilder
	
	#region KhoiLuongGiangDayTheoTuanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KhoiLuongGiangDayTheoTuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayTheoTuan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KhoiLuongGiangDayTheoTuanSortBuilder : SqlSortBuilder<KhoiLuongGiangDayTheoTuanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTheoTuanSqlSortBuilder class.
		/// </summary>
		public KhoiLuongGiangDayTheoTuanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KhoiLuongGiangDayTheoTuanSortBuilder
	
} // end namespace
