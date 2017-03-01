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
	/// This class is the base class for any <see cref="ChietTinhBoiDuongGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ChietTinhBoiDuongGiangDayProviderBaseCore : EntityProviderBase<PMS.Entities.ChietTinhBoiDuongGiangDay, PMS.Entities.ChietTinhBoiDuongGiangDayKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ChietTinhBoiDuongGiangDayKey key)
		{
			return Delete(transactionManager, key.MaQuanLy, key.MaLopHocPhan, key.MaLopSinhVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <param name="_maLopSinhVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _maQuanLy, System.String _maLopHocPhan, System.String _maLopSinhVien)
		{
			return Delete(null, _maQuanLy, _maLopHocPhan, _maLopSinhVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <param name="_maLopHocPhan">. Primary Key.</param>
		/// <param name="_maLopSinhVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _maQuanLy, System.String _maLopHocPhan, System.String _maLopSinhVien);		
		
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
		public override PMS.Entities.ChietTinhBoiDuongGiangDay Get(TransactionManager transactionManager, PMS.Entities.ChietTinhBoiDuongGiangDayKey key, int start, int pageLength)
		{
			return GetByMaQuanLyMaLopHocPhanMaLopSinhVien(transactionManager, key.MaQuanLy, key.MaLopHocPhan, key.MaLopSinhVien, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ChietTinhBoiDuongGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maLopSinhVien"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChietTinhBoiDuongGiangDay"/> class.</returns>
		public PMS.Entities.ChietTinhBoiDuongGiangDay GetByMaQuanLyMaLopHocPhanMaLopSinhVien(System.String _maQuanLy, System.String _maLopHocPhan, System.String _maLopSinhVien)
		{
			int count = -1;
			return GetByMaQuanLyMaLopHocPhanMaLopSinhVien(null,_maQuanLy, _maLopHocPhan, _maLopSinhVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChietTinhBoiDuongGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maLopSinhVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChietTinhBoiDuongGiangDay"/> class.</returns>
		public PMS.Entities.ChietTinhBoiDuongGiangDay GetByMaQuanLyMaLopHocPhanMaLopSinhVien(System.String _maQuanLy, System.String _maLopHocPhan, System.String _maLopSinhVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLyMaLopHocPhanMaLopSinhVien(null, _maQuanLy, _maLopHocPhan, _maLopSinhVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChietTinhBoiDuongGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maLopSinhVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChietTinhBoiDuongGiangDay"/> class.</returns>
		public PMS.Entities.ChietTinhBoiDuongGiangDay GetByMaQuanLyMaLopHocPhanMaLopSinhVien(TransactionManager transactionManager, System.String _maQuanLy, System.String _maLopHocPhan, System.String _maLopSinhVien)
		{
			int count = -1;
			return GetByMaQuanLyMaLopHocPhanMaLopSinhVien(transactionManager, _maQuanLy, _maLopHocPhan, _maLopSinhVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChietTinhBoiDuongGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maLopSinhVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChietTinhBoiDuongGiangDay"/> class.</returns>
		public PMS.Entities.ChietTinhBoiDuongGiangDay GetByMaQuanLyMaLopHocPhanMaLopSinhVien(TransactionManager transactionManager, System.String _maQuanLy, System.String _maLopHocPhan, System.String _maLopSinhVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLyMaLopHocPhanMaLopSinhVien(transactionManager, _maQuanLy, _maLopHocPhan, _maLopSinhVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChietTinhBoiDuongGiangDay index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maLopSinhVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChietTinhBoiDuongGiangDay"/> class.</returns>
		public PMS.Entities.ChietTinhBoiDuongGiangDay GetByMaQuanLyMaLopHocPhanMaLopSinhVien(System.String _maQuanLy, System.String _maLopHocPhan, System.String _maLopSinhVien, int start, int pageLength, out int count)
		{
			return GetByMaQuanLyMaLopHocPhanMaLopSinhVien(null, _maQuanLy, _maLopHocPhan, _maLopSinhVien, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ChietTinhBoiDuongGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="_maLopHocPhan"></param>
		/// <param name="_maLopSinhVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChietTinhBoiDuongGiangDay"/> class.</returns>
		public abstract PMS.Entities.ChietTinhBoiDuongGiangDay GetByMaQuanLyMaLopHocPhanMaLopSinhVien(TransactionManager transactionManager, System.String _maQuanLy, System.String _maLopHocPhan, System.String _maLopSinhVien, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ChietTinhBoiDuongGiangDay_GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ChietTinhBoiDuongGiangDay_GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChietTinhBoiDuongGiangDay&gt;"/> instance.</returns>
		public TList<ChietTinhBoiDuongGiangDay> GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy(System.String maGiangVien, System.String maLopHocPhan, System.String maLop, System.String namHoc, System.String hocKy)
		{
			return GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy(null, 0, int.MaxValue , maGiangVien, maLopHocPhan, maLop, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChietTinhBoiDuongGiangDay_GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChietTinhBoiDuongGiangDay&gt;"/> instance.</returns>
		public TList<ChietTinhBoiDuongGiangDay> GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy(int start, int pageLength, System.String maGiangVien, System.String maLopHocPhan, System.String maLop, System.String namHoc, System.String hocKy)
		{
			return GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy(null, start, pageLength , maGiangVien, maLopHocPhan, maLop, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChietTinhBoiDuongGiangDay_GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChietTinhBoiDuongGiangDay&gt;"/> instance.</returns>
		public TList<ChietTinhBoiDuongGiangDay> GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy(TransactionManager transactionManager, System.String maGiangVien, System.String maLopHocPhan, System.String maLop, System.String namHoc, System.String hocKy)
		{
			return GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy(transactionManager, 0, int.MaxValue , maGiangVien, maLopHocPhan, maLop, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChietTinhBoiDuongGiangDay_GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChietTinhBoiDuongGiangDay&gt;"/> instance.</returns>
		public abstract TList<ChietTinhBoiDuongGiangDay> GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVien, System.String maLopHocPhan, System.String maLop, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ChietTinhBoiDuongGiangDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ChietTinhBoiDuongGiangDay&gt;"/></returns>
		public static TList<ChietTinhBoiDuongGiangDay> Fill(IDataReader reader, TList<ChietTinhBoiDuongGiangDay> rows, int start, int pageLength)
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
				
				PMS.Entities.ChietTinhBoiDuongGiangDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ChietTinhBoiDuongGiangDay")
					.Append("|").Append((System.String)reader[((int)ChietTinhBoiDuongGiangDayColumn.MaQuanLy - 1)])
					.Append("|").Append((System.String)reader[((int)ChietTinhBoiDuongGiangDayColumn.MaLopHocPhan - 1)])
					.Append("|").Append((System.String)reader[((int)ChietTinhBoiDuongGiangDayColumn.MaLopSinhVien - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ChietTinhBoiDuongGiangDay>(
					key.ToString(), // EntityTrackingKey
					"ChietTinhBoiDuongGiangDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ChietTinhBoiDuongGiangDay();
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
					c.MaQuanLy = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.MaQuanLy.ToString())];
					c.OriginalMaQuanLy = c.MaQuanLy;
					c.HoTen = (reader[ChietTinhBoiDuongGiangDayColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.HoTen.ToString())];
					c.MaLopHocPhan = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.MaLopHocPhan.ToString())];
					c.OriginalMaLopHocPhan = c.MaLopHocPhan;
					c.TenLopHocPhan = (reader[ChietTinhBoiDuongGiangDayColumn.TenLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.TenLopHocPhan.ToString())];
					c.MaPhong = (reader[ChietTinhBoiDuongGiangDayColumn.MaPhong.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.MaPhong.ToString())];
					c.TenPhong = (reader[ChietTinhBoiDuongGiangDayColumn.TenPhong.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.TenPhong.ToString())];
					c.MaCoSo = (reader[ChietTinhBoiDuongGiangDayColumn.MaCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.MaCoSo.ToString())];
					c.TenCoSo = (reader[ChietTinhBoiDuongGiangDayColumn.TenCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.TenCoSo.ToString())];
					c.MaMonHoc = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.TenMonHoc.ToString())];
					c.SoTiet = (reader[ChietTinhBoiDuongGiangDayColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChietTinhBoiDuongGiangDayColumn.SoTiet.ToString())];
					c.SiSoLop = (reader[ChietTinhBoiDuongGiangDayColumn.SiSoLop.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChietTinhBoiDuongGiangDayColumn.SiSoLop.ToString())];
					c.HeSoLd = (reader[ChietTinhBoiDuongGiangDayColumn.HeSoLd.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChietTinhBoiDuongGiangDayColumn.HeSoLd.ToString())];
					c.HeSoTinChi = (System.Decimal)reader[(ChietTinhBoiDuongGiangDayColumn.HeSoTinChi.ToString())];
					c.TietQuyDoi = (reader[ChietTinhBoiDuongGiangDayColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChietTinhBoiDuongGiangDayColumn.TietQuyDoi.ToString())];
					c.DonGia = (System.Decimal)reader[(ChietTinhBoiDuongGiangDayColumn.DonGia.ToString())];
					c.TienThem = (System.Decimal)reader[(ChietTinhBoiDuongGiangDayColumn.TienThem.ToString())];
					c.TongCong = (reader[ChietTinhBoiDuongGiangDayColumn.TongCong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChietTinhBoiDuongGiangDayColumn.TongCong.ToString())];
					c.NamHoc = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.NamHoc.ToString())];
					c.HocKy = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.HocKy.ToString())];
					c.MaLopSinhVien = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.MaLopSinhVien.ToString())];
					c.OriginalMaLopSinhVien = c.MaLopSinhVien;
					c.TenLopSinhVien = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.TenLopSinhVien.ToString())];
					c.HoanTat = (reader[ChietTinhBoiDuongGiangDayColumn.HoanTat.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChietTinhBoiDuongGiangDayColumn.HoanTat.ToString())];
					c.SoLanDiLai = (reader[ChietTinhBoiDuongGiangDayColumn.SoLanDiLai.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChietTinhBoiDuongGiangDayColumn.SoLanDiLai.ToString())];
					c.SoNgayLuuTru = (reader[ChietTinhBoiDuongGiangDayColumn.SoNgayLuuTru.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChietTinhBoiDuongGiangDayColumn.SoNgayLuuTru.ToString())];
					c.ChiPhiLuuTru = (reader[ChietTinhBoiDuongGiangDayColumn.ChiPhiLuuTru.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChietTinhBoiDuongGiangDayColumn.ChiPhiLuuTru.ToString())];
					c.ChiPhiDiLai = (reader[ChietTinhBoiDuongGiangDayColumn.ChiPhiDiLai.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChietTinhBoiDuongGiangDayColumn.ChiPhiDiLai.ToString())];
					c.SoDeThiDapAn = (reader[ChietTinhBoiDuongGiangDayColumn.SoDeThiDapAn.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChietTinhBoiDuongGiangDayColumn.SoDeThiDapAn.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChietTinhBoiDuongGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChietTinhBoiDuongGiangDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ChietTinhBoiDuongGiangDay entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuanLy = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.MaQuanLy.ToString())];
			entity.OriginalMaQuanLy = (System.String)reader["MaQuanLy"];
			entity.HoTen = (reader[ChietTinhBoiDuongGiangDayColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.HoTen.ToString())];
			entity.MaLopHocPhan = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.MaLopHocPhan.ToString())];
			entity.OriginalMaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			entity.TenLopHocPhan = (reader[ChietTinhBoiDuongGiangDayColumn.TenLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.TenLopHocPhan.ToString())];
			entity.MaPhong = (reader[ChietTinhBoiDuongGiangDayColumn.MaPhong.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.MaPhong.ToString())];
			entity.TenPhong = (reader[ChietTinhBoiDuongGiangDayColumn.TenPhong.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.TenPhong.ToString())];
			entity.MaCoSo = (reader[ChietTinhBoiDuongGiangDayColumn.MaCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.MaCoSo.ToString())];
			entity.TenCoSo = (reader[ChietTinhBoiDuongGiangDayColumn.TenCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.TenCoSo.ToString())];
			entity.MaMonHoc = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.TenMonHoc.ToString())];
			entity.SoTiet = (reader[ChietTinhBoiDuongGiangDayColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChietTinhBoiDuongGiangDayColumn.SoTiet.ToString())];
			entity.SiSoLop = (reader[ChietTinhBoiDuongGiangDayColumn.SiSoLop.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChietTinhBoiDuongGiangDayColumn.SiSoLop.ToString())];
			entity.HeSoLd = (reader[ChietTinhBoiDuongGiangDayColumn.HeSoLd.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChietTinhBoiDuongGiangDayColumn.HeSoLd.ToString())];
			entity.HeSoTinChi = (System.Decimal)reader[(ChietTinhBoiDuongGiangDayColumn.HeSoTinChi.ToString())];
			entity.TietQuyDoi = (reader[ChietTinhBoiDuongGiangDayColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChietTinhBoiDuongGiangDayColumn.TietQuyDoi.ToString())];
			entity.DonGia = (System.Decimal)reader[(ChietTinhBoiDuongGiangDayColumn.DonGia.ToString())];
			entity.TienThem = (System.Decimal)reader[(ChietTinhBoiDuongGiangDayColumn.TienThem.ToString())];
			entity.TongCong = (reader[ChietTinhBoiDuongGiangDayColumn.TongCong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChietTinhBoiDuongGiangDayColumn.TongCong.ToString())];
			entity.NamHoc = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.NamHoc.ToString())];
			entity.HocKy = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.HocKy.ToString())];
			entity.MaLopSinhVien = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.MaLopSinhVien.ToString())];
			entity.OriginalMaLopSinhVien = (System.String)reader["MaLopSinhVien"];
			entity.TenLopSinhVien = (System.String)reader[(ChietTinhBoiDuongGiangDayColumn.TenLopSinhVien.ToString())];
			entity.HoanTat = (reader[ChietTinhBoiDuongGiangDayColumn.HoanTat.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChietTinhBoiDuongGiangDayColumn.HoanTat.ToString())];
			entity.SoLanDiLai = (reader[ChietTinhBoiDuongGiangDayColumn.SoLanDiLai.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChietTinhBoiDuongGiangDayColumn.SoLanDiLai.ToString())];
			entity.SoNgayLuuTru = (reader[ChietTinhBoiDuongGiangDayColumn.SoNgayLuuTru.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChietTinhBoiDuongGiangDayColumn.SoNgayLuuTru.ToString())];
			entity.ChiPhiLuuTru = (reader[ChietTinhBoiDuongGiangDayColumn.ChiPhiLuuTru.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChietTinhBoiDuongGiangDayColumn.ChiPhiLuuTru.ToString())];
			entity.ChiPhiDiLai = (reader[ChietTinhBoiDuongGiangDayColumn.ChiPhiDiLai.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ChietTinhBoiDuongGiangDayColumn.ChiPhiDiLai.ToString())];
			entity.SoDeThiDapAn = (reader[ChietTinhBoiDuongGiangDayColumn.SoDeThiDapAn.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChietTinhBoiDuongGiangDayColumn.SoDeThiDapAn.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChietTinhBoiDuongGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChietTinhBoiDuongGiangDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ChietTinhBoiDuongGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.OriginalMaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.HoTen = Convert.IsDBNull(dataRow["HoTen"]) ? null : (System.String)dataRow["HoTen"];
			entity.MaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.OriginalMaLopHocPhan = (System.String)dataRow["MaLopHocPhan"];
			entity.TenLopHocPhan = Convert.IsDBNull(dataRow["TenLopHocPhan"]) ? null : (System.String)dataRow["TenLopHocPhan"];
			entity.MaPhong = Convert.IsDBNull(dataRow["MaPhong"]) ? null : (System.String)dataRow["MaPhong"];
			entity.TenPhong = Convert.IsDBNull(dataRow["TenPhong"]) ? null : (System.String)dataRow["TenPhong"];
			entity.MaCoSo = Convert.IsDBNull(dataRow["MaCoSo"]) ? null : (System.String)dataRow["MaCoSo"];
			entity.TenCoSo = Convert.IsDBNull(dataRow["TenCoSo"]) ? null : (System.String)dataRow["TenCoSo"];
			entity.MaMonHoc = (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (System.String)dataRow["TenMonHoc"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Int32?)dataRow["SoTiet"];
			entity.SiSoLop = Convert.IsDBNull(dataRow["SiSoLop"]) ? null : (System.Int32?)dataRow["SiSoLop"];
			entity.HeSoLd = Convert.IsDBNull(dataRow["HeSoLD"]) ? null : (System.Decimal?)dataRow["HeSoLD"];
			entity.HeSoTinChi = (System.Decimal)dataRow["HeSoTinChi"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.DonGia = (System.Decimal)dataRow["DonGia"];
			entity.TienThem = (System.Decimal)dataRow["TienThem"];
			entity.TongCong = Convert.IsDBNull(dataRow["TongCong"]) ? null : (System.Decimal?)dataRow["TongCong"];
			entity.NamHoc = (System.String)dataRow["NamHoc"];
			entity.HocKy = (System.String)dataRow["HocKy"];
			entity.MaLopSinhVien = (System.String)dataRow["MaLopSinhVien"];
			entity.OriginalMaLopSinhVien = (System.String)dataRow["MaLopSinhVien"];
			entity.TenLopSinhVien = (System.String)dataRow["TenLopSinhVien"];
			entity.HoanTat = Convert.IsDBNull(dataRow["HoanTat"]) ? null : (System.Boolean?)dataRow["HoanTat"];
			entity.SoLanDiLai = Convert.IsDBNull(dataRow["SoLanDiLai"]) ? null : (System.Int32?)dataRow["SoLanDiLai"];
			entity.SoNgayLuuTru = Convert.IsDBNull(dataRow["SoNgayLuuTru"]) ? null : (System.Int32?)dataRow["SoNgayLuuTru"];
			entity.ChiPhiLuuTru = Convert.IsDBNull(dataRow["ChiPhiLuuTru"]) ? null : (System.Decimal?)dataRow["ChiPhiLuuTru"];
			entity.ChiPhiDiLai = Convert.IsDBNull(dataRow["ChiPhiDiLai"]) ? null : (System.Decimal?)dataRow["ChiPhiDiLai"];
			entity.SoDeThiDapAn = Convert.IsDBNull(dataRow["SoDeThiDapAn"]) ? null : (System.Int32?)dataRow["SoDeThiDapAn"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ChietTinhBoiDuongGiangDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ChietTinhBoiDuongGiangDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ChietTinhBoiDuongGiangDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ChietTinhBoiDuongGiangDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ChietTinhBoiDuongGiangDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ChietTinhBoiDuongGiangDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ChietTinhBoiDuongGiangDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ChietTinhBoiDuongGiangDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ChietTinhBoiDuongGiangDay</c>
	///</summary>
	public enum ChietTinhBoiDuongGiangDayChildEntityTypes
	{
	}
	
	#endregion ChietTinhBoiDuongGiangDayChildEntityTypes
	
	#region ChietTinhBoiDuongGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ChietTinhBoiDuongGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChietTinhBoiDuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChietTinhBoiDuongGiangDayFilterBuilder : SqlFilterBuilder<ChietTinhBoiDuongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChietTinhBoiDuongGiangDayFilterBuilder class.
		/// </summary>
		public ChietTinhBoiDuongGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChietTinhBoiDuongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChietTinhBoiDuongGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChietTinhBoiDuongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChietTinhBoiDuongGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChietTinhBoiDuongGiangDayFilterBuilder
	
	#region ChietTinhBoiDuongGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ChietTinhBoiDuongGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChietTinhBoiDuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChietTinhBoiDuongGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ChietTinhBoiDuongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChietTinhBoiDuongGiangDayParameterBuilder class.
		/// </summary>
		public ChietTinhBoiDuongGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChietTinhBoiDuongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChietTinhBoiDuongGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChietTinhBoiDuongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChietTinhBoiDuongGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChietTinhBoiDuongGiangDayParameterBuilder
	
	#region ChietTinhBoiDuongGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ChietTinhBoiDuongGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChietTinhBoiDuongGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ChietTinhBoiDuongGiangDaySortBuilder : SqlSortBuilder<ChietTinhBoiDuongGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChietTinhBoiDuongGiangDaySqlSortBuilder class.
		/// </summary>
		public ChietTinhBoiDuongGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ChietTinhBoiDuongGiangDaySortBuilder
	
} // end namespace
