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
	/// This class is the base class for any <see cref="KhoiLuongGiangDayTungTuanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KhoiLuongGiangDayTungTuanProviderBaseCore : EntityProviderBase<PMS.Entities.KhoiLuongGiangDayTungTuan, PMS.Entities.KhoiLuongGiangDayTungTuanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayTungTuanKey key)
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
		public override PMS.Entities.KhoiLuongGiangDayTungTuan Get(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayTungTuanKey key, int start, int pageLength)
		{
			return GetByMaKhoiLuong(transactionManager, key.MaKhoiLuong, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KhoiLuongGiangDayTungTuan index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayTungTuan"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayTungTuan GetByMaKhoiLuong(System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(null,_maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayTungTuan index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayTungTuan"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayTungTuan GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayTungTuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayTungTuan"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayTungTuan GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayTungTuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayTungTuan"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayTungTuan GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayTungTuan index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayTungTuan"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayTungTuan GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength, out int count)
		{
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayTungTuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayTungTuan"/> class.</returns>
		public abstract PMS.Entities.KhoiLuongGiangDayTungTuan GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KhoiLuongGiangDayTungTuan_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTungTuan_DongBo' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(System.DateTime tuNgay, System.DateTime denNgay)
		{
			 DongBo(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTungTuan_DongBo' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			 DongBo(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTungTuan_DongBo' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			 DongBo(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTungTuan_DongBo' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBo(TransactionManager transactionManager, int start, int pageLength , System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayTungTuan_GetByMaLopHocPhanMaGiangVienTuanNam 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTungTuan_GetByMaLopHocPhanMaGiangVienTuanNam' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tuan"> A <c>System.Int32</c> instance.</param>
		/// <param name="nam"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayTungTuan&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayTungTuan> GetByMaLopHocPhanMaGiangVienTuanNam(System.String maLopHocPhan, System.String maGiangVien, System.Int32 tuan, System.Int32 nam)
		{
			return GetByMaLopHocPhanMaGiangVienTuanNam(null, 0, int.MaxValue , maLopHocPhan, maGiangVien, tuan, nam);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTungTuan_GetByMaLopHocPhanMaGiangVienTuanNam' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tuan"> A <c>System.Int32</c> instance.</param>
		/// <param name="nam"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayTungTuan&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayTungTuan> GetByMaLopHocPhanMaGiangVienTuanNam(int start, int pageLength, System.String maLopHocPhan, System.String maGiangVien, System.Int32 tuan, System.Int32 nam)
		{
			return GetByMaLopHocPhanMaGiangVienTuanNam(null, start, pageLength , maLopHocPhan, maGiangVien, tuan, nam);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTungTuan_GetByMaLopHocPhanMaGiangVienTuanNam' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tuan"> A <c>System.Int32</c> instance.</param>
		/// <param name="nam"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayTungTuan&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayTungTuan> GetByMaLopHocPhanMaGiangVienTuanNam(TransactionManager transactionManager, System.String maLopHocPhan, System.String maGiangVien, System.Int32 tuan, System.Int32 nam)
		{
			return GetByMaLopHocPhanMaGiangVienTuanNam(transactionManager, 0, int.MaxValue , maLopHocPhan, maGiangVien, tuan, nam);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTungTuan_GetByMaLopHocPhanMaGiangVienTuanNam' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="tuan"> A <c>System.Int32</c> instance.</param>
		/// <param name="nam"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayTungTuan&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDayTungTuan> GetByMaLopHocPhanMaGiangVienTuanNam(TransactionManager transactionManager, int start, int pageLength , System.String maLopHocPhan, System.String maGiangVien, System.Int32 tuan, System.Int32 nam);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayTungTuan_GetByTuNgayDenNgay 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTungTuan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayTungTuan&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayTungTuan> GetByTuNgayDenNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTungTuan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayTungTuan&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayTungTuan> GetByTuNgayDenNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTungTuan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayTungTuan&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayTungTuan> GetByTuNgayDenNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayTungTuan_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayTungTuan&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDayTungTuan> GetByTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength , System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KhoiLuongGiangDayTungTuan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KhoiLuongGiangDayTungTuan&gt;"/></returns>
		public static TList<KhoiLuongGiangDayTungTuan> Fill(IDataReader reader, TList<KhoiLuongGiangDayTungTuan> rows, int start, int pageLength)
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
				
				PMS.Entities.KhoiLuongGiangDayTungTuan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KhoiLuongGiangDayTungTuan")
					.Append("|").Append((System.Int32)reader[((int)KhoiLuongGiangDayTungTuanColumn.MaKhoiLuong - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KhoiLuongGiangDayTungTuan>(
					key.ToString(), // EntityTrackingKey
					"KhoiLuongGiangDayTungTuan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KhoiLuongGiangDayTungTuan();
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
					c.MaKhoiLuong = (System.Int32)reader[(KhoiLuongGiangDayTungTuanColumn.MaKhoiLuong.ToString())];
					c.MaToaNha = (reader[KhoiLuongGiangDayTungTuanColumn.MaToaNha.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.MaToaNha.ToString())];
					c.MaLopHocPhan = (reader[KhoiLuongGiangDayTungTuanColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.MaLopHocPhan.ToString())];
					c.MaLop = (reader[KhoiLuongGiangDayTungTuanColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.MaLop.ToString())];
					c.MaNhom = (reader[KhoiLuongGiangDayTungTuanColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.MaNhom.ToString())];
					c.LoaiHocPhan = (reader[KhoiLuongGiangDayTungTuanColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.LoaiHocPhan.ToString())];
					c.PhanLoai = (reader[KhoiLuongGiangDayTungTuanColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.PhanLoai.ToString())];
					c.MaMonHoc = (reader[KhoiLuongGiangDayTungTuanColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.MaMonHoc.ToString())];
					c.DienGiai = (reader[KhoiLuongGiangDayTungTuanColumn.DienGiai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.DienGiai.ToString())];
					c.SoTiet = (reader[KhoiLuongGiangDayTungTuanColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.SoTiet.ToString())];
					c.SoTinChi = (reader[KhoiLuongGiangDayTungTuanColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.SoTinChi.ToString())];
					c.SiSoLop = (reader[KhoiLuongGiangDayTungTuanColumn.SiSoLop.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayTungTuanColumn.SiSoLop.ToString())];
					c.SoNhom = (reader[KhoiLuongGiangDayTungTuanColumn.SoNhom.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayTungTuanColumn.SoNhom.ToString())];
					c.MaDiaDiem = (reader[KhoiLuongGiangDayTungTuanColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.MaDiaDiem.ToString())];
					c.NgayBatDau = (reader[KhoiLuongGiangDayTungTuanColumn.NgayBatDau.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayTungTuanColumn.NgayBatDau.ToString())];
					c.NgayKetThuc = (reader[KhoiLuongGiangDayTungTuanColumn.NgayKetThuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayTungTuanColumn.NgayKetThuc.ToString())];
					c.ChatLuongCao = (reader[KhoiLuongGiangDayTungTuanColumn.ChatLuongCao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.ChatLuongCao.ToString())];
					c.NgoaiGio = (reader[KhoiLuongGiangDayTungTuanColumn.NgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.NgoaiGio.ToString())];
					c.TrongGio = (reader[KhoiLuongGiangDayTungTuanColumn.TrongGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.TrongGio.ToString())];
					c.HeSoLopDong = (reader[KhoiLuongGiangDayTungTuanColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.HeSoLopDong.ToString())];
					c.HeSoCoSo = (reader[KhoiLuongGiangDayTungTuanColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.HeSoCoSo.ToString())];
					c.HeSoHocKy = (reader[KhoiLuongGiangDayTungTuanColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.HeSoHocKy.ToString())];
					c.HeSoThanhPhan = (reader[KhoiLuongGiangDayTungTuanColumn.HeSoThanhPhan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.HeSoThanhPhan.ToString())];
					c.HeSoTrongGio = (reader[KhoiLuongGiangDayTungTuanColumn.HeSoTrongGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.HeSoTrongGio.ToString())];
					c.HeSoNgoaiGio = (reader[KhoiLuongGiangDayTungTuanColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.HeSoNgoaiGio.ToString())];
					c.TietQuyDoi = (reader[KhoiLuongGiangDayTungTuanColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.TietQuyDoi.ToString())];
					c.LoaiHocKy = (reader[KhoiLuongGiangDayTungTuanColumn.LoaiHocKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayTungTuanColumn.LoaiHocKy.ToString())];
					c.ThoiKhoaBieu = (reader[KhoiLuongGiangDayTungTuanColumn.ThoiKhoaBieu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.ThoiKhoaBieu.ToString())];
					c.NgayTao = (reader[KhoiLuongGiangDayTungTuanColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayTungTuanColumn.NgayTao.ToString())];
					c.MaQuanLy = (reader[KhoiLuongGiangDayTungTuanColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.MaQuanLy.ToString())];
					c.Tuan = (reader[KhoiLuongGiangDayTungTuanColumn.Tuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayTungTuanColumn.Tuan.ToString())];
					c.Nam = (reader[KhoiLuongGiangDayTungTuanColumn.Nam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayTungTuanColumn.Nam.ToString())];
					c.NgayDay = (reader[KhoiLuongGiangDayTungTuanColumn.NgayDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayTungTuanColumn.NgayDay.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongGiangDayTungTuan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayTungTuan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KhoiLuongGiangDayTungTuan entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKhoiLuong = (System.Int32)reader[(KhoiLuongGiangDayTungTuanColumn.MaKhoiLuong.ToString())];
			entity.MaToaNha = (reader[KhoiLuongGiangDayTungTuanColumn.MaToaNha.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.MaToaNha.ToString())];
			entity.MaLopHocPhan = (reader[KhoiLuongGiangDayTungTuanColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.MaLopHocPhan.ToString())];
			entity.MaLop = (reader[KhoiLuongGiangDayTungTuanColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.MaLop.ToString())];
			entity.MaNhom = (reader[KhoiLuongGiangDayTungTuanColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.MaNhom.ToString())];
			entity.LoaiHocPhan = (reader[KhoiLuongGiangDayTungTuanColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.LoaiHocPhan.ToString())];
			entity.PhanLoai = (reader[KhoiLuongGiangDayTungTuanColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.PhanLoai.ToString())];
			entity.MaMonHoc = (reader[KhoiLuongGiangDayTungTuanColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.MaMonHoc.ToString())];
			entity.DienGiai = (reader[KhoiLuongGiangDayTungTuanColumn.DienGiai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.DienGiai.ToString())];
			entity.SoTiet = (reader[KhoiLuongGiangDayTungTuanColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.SoTiet.ToString())];
			entity.SoTinChi = (reader[KhoiLuongGiangDayTungTuanColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.SoTinChi.ToString())];
			entity.SiSoLop = (reader[KhoiLuongGiangDayTungTuanColumn.SiSoLop.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayTungTuanColumn.SiSoLop.ToString())];
			entity.SoNhom = (reader[KhoiLuongGiangDayTungTuanColumn.SoNhom.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayTungTuanColumn.SoNhom.ToString())];
			entity.MaDiaDiem = (reader[KhoiLuongGiangDayTungTuanColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.MaDiaDiem.ToString())];
			entity.NgayBatDau = (reader[KhoiLuongGiangDayTungTuanColumn.NgayBatDau.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayTungTuanColumn.NgayBatDau.ToString())];
			entity.NgayKetThuc = (reader[KhoiLuongGiangDayTungTuanColumn.NgayKetThuc.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayTungTuanColumn.NgayKetThuc.ToString())];
			entity.ChatLuongCao = (reader[KhoiLuongGiangDayTungTuanColumn.ChatLuongCao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.ChatLuongCao.ToString())];
			entity.NgoaiGio = (reader[KhoiLuongGiangDayTungTuanColumn.NgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.NgoaiGio.ToString())];
			entity.TrongGio = (reader[KhoiLuongGiangDayTungTuanColumn.TrongGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.TrongGio.ToString())];
			entity.HeSoLopDong = (reader[KhoiLuongGiangDayTungTuanColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.HeSoLopDong.ToString())];
			entity.HeSoCoSo = (reader[KhoiLuongGiangDayTungTuanColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.HeSoCoSo.ToString())];
			entity.HeSoHocKy = (reader[KhoiLuongGiangDayTungTuanColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.HeSoHocKy.ToString())];
			entity.HeSoThanhPhan = (reader[KhoiLuongGiangDayTungTuanColumn.HeSoThanhPhan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.HeSoThanhPhan.ToString())];
			entity.HeSoTrongGio = (reader[KhoiLuongGiangDayTungTuanColumn.HeSoTrongGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.HeSoTrongGio.ToString())];
			entity.HeSoNgoaiGio = (reader[KhoiLuongGiangDayTungTuanColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.HeSoNgoaiGio.ToString())];
			entity.TietQuyDoi = (reader[KhoiLuongGiangDayTungTuanColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayTungTuanColumn.TietQuyDoi.ToString())];
			entity.LoaiHocKy = (reader[KhoiLuongGiangDayTungTuanColumn.LoaiHocKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayTungTuanColumn.LoaiHocKy.ToString())];
			entity.ThoiKhoaBieu = (reader[KhoiLuongGiangDayTungTuanColumn.ThoiKhoaBieu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.ThoiKhoaBieu.ToString())];
			entity.NgayTao = (reader[KhoiLuongGiangDayTungTuanColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayTungTuanColumn.NgayTao.ToString())];
			entity.MaQuanLy = (reader[KhoiLuongGiangDayTungTuanColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayTungTuanColumn.MaQuanLy.ToString())];
			entity.Tuan = (reader[KhoiLuongGiangDayTungTuanColumn.Tuan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayTungTuanColumn.Tuan.ToString())];
			entity.Nam = (reader[KhoiLuongGiangDayTungTuanColumn.Nam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayTungTuanColumn.Nam.ToString())];
			entity.NgayDay = (reader[KhoiLuongGiangDayTungTuanColumn.NgayDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayTungTuanColumn.NgayDay.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongGiangDayTungTuan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayTungTuan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KhoiLuongGiangDayTungTuan entity)
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
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.Tuan = Convert.IsDBNull(dataRow["Tuan"]) ? null : (System.Int32?)dataRow["Tuan"];
			entity.Nam = Convert.IsDBNull(dataRow["Nam"]) ? null : (System.Int32?)dataRow["Nam"];
			entity.NgayDay = Convert.IsDBNull(dataRow["NgayDay"]) ? null : (System.DateTime?)dataRow["NgayDay"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayTungTuan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongGiangDayTungTuan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayTungTuan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KhoiLuongGiangDayTungTuan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KhoiLuongGiangDayTungTuan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongGiangDayTungTuan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayTungTuan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KhoiLuongGiangDayTungTuanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KhoiLuongGiangDayTungTuan</c>
	///</summary>
	public enum KhoiLuongGiangDayTungTuanChildEntityTypes
	{
	}
	
	#endregion KhoiLuongGiangDayTungTuanChildEntityTypes
	
	#region KhoiLuongGiangDayTungTuanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KhoiLuongGiangDayTungTuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayTungTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayTungTuanFilterBuilder : SqlFilterBuilder<KhoiLuongGiangDayTungTuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTungTuanFilterBuilder class.
		/// </summary>
		public KhoiLuongGiangDayTungTuanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTungTuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongGiangDayTungTuanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTungTuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongGiangDayTungTuanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongGiangDayTungTuanFilterBuilder
	
	#region KhoiLuongGiangDayTungTuanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KhoiLuongGiangDayTungTuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayTungTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayTungTuanParameterBuilder : ParameterizedSqlFilterBuilder<KhoiLuongGiangDayTungTuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTungTuanParameterBuilder class.
		/// </summary>
		public KhoiLuongGiangDayTungTuanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTungTuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongGiangDayTungTuanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTungTuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongGiangDayTungTuanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongGiangDayTungTuanParameterBuilder
	
	#region KhoiLuongGiangDayTungTuanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KhoiLuongGiangDayTungTuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayTungTuan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KhoiLuongGiangDayTungTuanSortBuilder : SqlSortBuilder<KhoiLuongGiangDayTungTuanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTungTuanSqlSortBuilder class.
		/// </summary>
		public KhoiLuongGiangDayTungTuanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KhoiLuongGiangDayTungTuanSortBuilder
	
} // end namespace
