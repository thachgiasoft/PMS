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
	/// This class is the base class for any <see cref="UteKhoiLuongGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class UteKhoiLuongGiangDayProviderBaseCore : EntityProviderBase<PMS.Entities.UteKhoiLuongGiangDay, PMS.Entities.UteKhoiLuongGiangDayKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.UteKhoiLuongGiangDayKey key)
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
		public override PMS.Entities.UteKhoiLuongGiangDay Get(TransactionManager transactionManager, PMS.Entities.UteKhoiLuongGiangDayKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_Ute_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.UteKhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.UteKhoiLuongGiangDay GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ute_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.UteKhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.UteKhoiLuongGiangDay GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ute_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.UteKhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.UteKhoiLuongGiangDay GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ute_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.UteKhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.UteKhoiLuongGiangDay GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ute_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.UteKhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.UteKhoiLuongGiangDay GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Ute_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.UteKhoiLuongGiangDay"/> class.</returns>
		public abstract PMS.Entities.UteKhoiLuongGiangDay GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_Ute_KhoiLuongGiangDay_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongGiangDay_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(System.String namHoc, System.String hocKy)
		{
			 DongBo(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongGiangDay_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 DongBo(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongGiangDay_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 DongBo(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongGiangDay_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_Ute_KhoiLuongGiangDay_SoSanhMonHocPmsVsTkb 
		
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongGiangDay_SoSanhMonHocPmsVsTkb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader SoSanhMonHocPmsVsTkb(System.String namHoc, System.String hocKy)
		{
			return SoSanhMonHocPmsVsTkb(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongGiangDay_SoSanhMonHocPmsVsTkb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader SoSanhMonHocPmsVsTkb(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return SoSanhMonHocPmsVsTkb(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongGiangDay_SoSanhMonHocPmsVsTkb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader SoSanhMonHocPmsVsTkb(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return SoSanhMonHocPmsVsTkb(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongGiangDay_SoSanhMonHocPmsVsTkb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader SoSanhMonHocPmsVsTkb(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_Ute_KhoiLuongGiangDay_KiemTraDongBo 
		
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongGiangDay_KiemTraDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBo(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraDongBo(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongGiangDay_KiemTraDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBo(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraDongBo(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongGiangDay_KiemTraDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraDongBo(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraDongBo(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_Ute_KhoiLuongGiangDay_KiemTraDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraDongBo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;UteKhoiLuongGiangDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;UteKhoiLuongGiangDay&gt;"/></returns>
		public static TList<UteKhoiLuongGiangDay> Fill(IDataReader reader, TList<UteKhoiLuongGiangDay> rows, int start, int pageLength)
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
				
				PMS.Entities.UteKhoiLuongGiangDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("UteKhoiLuongGiangDay")
					.Append("|").Append((System.Int32)reader[((int)UteKhoiLuongGiangDayColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<UteKhoiLuongGiangDay>(
					key.ToString(), // EntityTrackingKey
					"UteKhoiLuongGiangDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.UteKhoiLuongGiangDay();
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
					c.Id = (System.Int32)reader[(UteKhoiLuongGiangDayColumn.Id.ToString())];
					c.MaMonHoc = (reader[UteKhoiLuongGiangDayColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[UteKhoiLuongGiangDayColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.TenMonHoc.ToString())];
					c.NhomMonHoc = (reader[UteKhoiLuongGiangDayColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.NhomMonHoc.ToString())];
					c.MaHocPhan = (reader[UteKhoiLuongGiangDayColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.MaHocPhan.ToString())];
					c.NamHoc = (reader[UteKhoiLuongGiangDayColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.NamHoc.ToString())];
					c.HocKy = (reader[UteKhoiLuongGiangDayColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.HocKy.ToString())];
					c.MaLopHocPhan = (reader[UteKhoiLuongGiangDayColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.MaLopHocPhan.ToString())];
					c.Nhom = (reader[UteKhoiLuongGiangDayColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.Nhom.ToString())];
					c.MaLop = (reader[UteKhoiLuongGiangDayColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.MaLop.ToString())];
					c.MaGiangVienQuanLy = (reader[UteKhoiLuongGiangDayColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.MaGiangVienQuanLy.ToString())];
					c.SoTinChi = (reader[UteKhoiLuongGiangDayColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(UteKhoiLuongGiangDayColumn.SoTinChi.ToString())];
					c.SiSo = (reader[UteKhoiLuongGiangDayColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(UteKhoiLuongGiangDayColumn.SiSo.ToString())];
					c.LopClc = (reader[UteKhoiLuongGiangDayColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(UteKhoiLuongGiangDayColumn.LopClc.ToString())];
					c.SoTietDayChuNhat = (reader[UteKhoiLuongGiangDayColumn.SoTietDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(UteKhoiLuongGiangDayColumn.SoTietDayChuNhat.ToString())];
					c.SoTiet = (reader[UteKhoiLuongGiangDayColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(UteKhoiLuongGiangDayColumn.SoTiet.ToString())];
					c.MaLoaiHocPhan = (reader[UteKhoiLuongGiangDayColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(UteKhoiLuongGiangDayColumn.MaLoaiHocPhan.ToString())];
					c.MaLoaiGiangVien = (reader[UteKhoiLuongGiangDayColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(UteKhoiLuongGiangDayColumn.MaLoaiGiangVien.ToString())];
					c.MaHocHam = (reader[UteKhoiLuongGiangDayColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(UteKhoiLuongGiangDayColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[UteKhoiLuongGiangDayColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(UteKhoiLuongGiangDayColumn.MaHocVi.ToString())];
					c.NgayCapNhat = (reader[UteKhoiLuongGiangDayColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(UteKhoiLuongGiangDayColumn.NgayCapNhat.ToString())];
					c.MaLoaiHocPhanGanMoi = (reader[UteKhoiLuongGiangDayColumn.MaLoaiHocPhanGanMoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.MaLoaiHocPhanGanMoi.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.UteKhoiLuongGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.UteKhoiLuongGiangDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.UteKhoiLuongGiangDay entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(UteKhoiLuongGiangDayColumn.Id.ToString())];
			entity.MaMonHoc = (reader[UteKhoiLuongGiangDayColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[UteKhoiLuongGiangDayColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.TenMonHoc.ToString())];
			entity.NhomMonHoc = (reader[UteKhoiLuongGiangDayColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.NhomMonHoc.ToString())];
			entity.MaHocPhan = (reader[UteKhoiLuongGiangDayColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.MaHocPhan.ToString())];
			entity.NamHoc = (reader[UteKhoiLuongGiangDayColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.NamHoc.ToString())];
			entity.HocKy = (reader[UteKhoiLuongGiangDayColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.HocKy.ToString())];
			entity.MaLopHocPhan = (reader[UteKhoiLuongGiangDayColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.MaLopHocPhan.ToString())];
			entity.Nhom = (reader[UteKhoiLuongGiangDayColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.Nhom.ToString())];
			entity.MaLop = (reader[UteKhoiLuongGiangDayColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.MaLop.ToString())];
			entity.MaGiangVienQuanLy = (reader[UteKhoiLuongGiangDayColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.MaGiangVienQuanLy.ToString())];
			entity.SoTinChi = (reader[UteKhoiLuongGiangDayColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(UteKhoiLuongGiangDayColumn.SoTinChi.ToString())];
			entity.SiSo = (reader[UteKhoiLuongGiangDayColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(UteKhoiLuongGiangDayColumn.SiSo.ToString())];
			entity.LopClc = (reader[UteKhoiLuongGiangDayColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(UteKhoiLuongGiangDayColumn.LopClc.ToString())];
			entity.SoTietDayChuNhat = (reader[UteKhoiLuongGiangDayColumn.SoTietDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(UteKhoiLuongGiangDayColumn.SoTietDayChuNhat.ToString())];
			entity.SoTiet = (reader[UteKhoiLuongGiangDayColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(UteKhoiLuongGiangDayColumn.SoTiet.ToString())];
			entity.MaLoaiHocPhan = (reader[UteKhoiLuongGiangDayColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(UteKhoiLuongGiangDayColumn.MaLoaiHocPhan.ToString())];
			entity.MaLoaiGiangVien = (reader[UteKhoiLuongGiangDayColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(UteKhoiLuongGiangDayColumn.MaLoaiGiangVien.ToString())];
			entity.MaHocHam = (reader[UteKhoiLuongGiangDayColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(UteKhoiLuongGiangDayColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[UteKhoiLuongGiangDayColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(UteKhoiLuongGiangDayColumn.MaHocVi.ToString())];
			entity.NgayCapNhat = (reader[UteKhoiLuongGiangDayColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(UteKhoiLuongGiangDayColumn.NgayCapNhat.ToString())];
			entity.MaLoaiHocPhanGanMoi = (reader[UteKhoiLuongGiangDayColumn.MaLoaiHocPhanGanMoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(UteKhoiLuongGiangDayColumn.MaLoaiHocPhanGanMoi.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.UteKhoiLuongGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.UteKhoiLuongGiangDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.UteKhoiLuongGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.NhomMonHoc = Convert.IsDBNull(dataRow["NhomMonHoc"]) ? null : (System.String)dataRow["NhomMonHoc"];
			entity.MaHocPhan = Convert.IsDBNull(dataRow["MaHocPhan"]) ? null : (System.String)dataRow["MaHocPhan"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.LopClc = Convert.IsDBNull(dataRow["LopClc"]) ? null : (System.Boolean?)dataRow["LopClc"];
			entity.SoTietDayChuNhat = Convert.IsDBNull(dataRow["SoTietDayChuNhat"]) ? null : (System.Int32?)dataRow["SoTietDayChuNhat"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.MaLoaiHocPhanGanMoi = Convert.IsDBNull(dataRow["MaLoaiHocPhanGanMoi"]) ? null : (System.String)dataRow["MaLoaiHocPhanGanMoi"];
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
		/// <param name="entity">The <see cref="PMS.Entities.UteKhoiLuongGiangDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.UteKhoiLuongGiangDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.UteKhoiLuongGiangDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetById methods when available
			
			#region UteKhoiLuongQuyDoiCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<UteKhoiLuongQuyDoi>|UteKhoiLuongQuyDoiCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'UteKhoiLuongQuyDoiCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.UteKhoiLuongQuyDoiCollection = DataRepository.UteKhoiLuongQuyDoiProvider.GetByIdKhoiLuongGiangDay(transactionManager, entity.Id);

				if (deep && entity.UteKhoiLuongQuyDoiCollection.Count > 0)
				{
					deepHandles.Add("UteKhoiLuongQuyDoiCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<UteKhoiLuongQuyDoi>) DataRepository.UteKhoiLuongQuyDoiProvider.DeepLoad,
						new object[] { transactionManager, entity.UteKhoiLuongQuyDoiCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.UteKhoiLuongGiangDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.UteKhoiLuongGiangDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.UteKhoiLuongGiangDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.UteKhoiLuongGiangDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<UteKhoiLuongQuyDoi>
				if (CanDeepSave(entity.UteKhoiLuongQuyDoiCollection, "List<UteKhoiLuongQuyDoi>|UteKhoiLuongQuyDoiCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(UteKhoiLuongQuyDoi child in entity.UteKhoiLuongQuyDoiCollection)
					{
						if(child.IdKhoiLuongGiangDaySource != null)
						{
							child.IdKhoiLuongGiangDay = child.IdKhoiLuongGiangDaySource.Id;
						}
						else
						{
							child.IdKhoiLuongGiangDay = entity.Id;
						}

					}

					if (entity.UteKhoiLuongQuyDoiCollection.Count > 0 || entity.UteKhoiLuongQuyDoiCollection.DeletedItems.Count > 0)
					{
						//DataRepository.UteKhoiLuongQuyDoiProvider.Save(transactionManager, entity.UteKhoiLuongQuyDoiCollection);
						
						deepHandles.Add("UteKhoiLuongQuyDoiCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< UteKhoiLuongQuyDoi >) DataRepository.UteKhoiLuongQuyDoiProvider.DeepSave,
							new object[] { transactionManager, entity.UteKhoiLuongQuyDoiCollection, deepSaveType, childTypes, innerList }
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
	
	#region UteKhoiLuongGiangDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.UteKhoiLuongGiangDay</c>
	///</summary>
	public enum UteKhoiLuongGiangDayChildEntityTypes
	{
		///<summary>
		/// Collection of <c>UteKhoiLuongGiangDay</c> as OneToMany for UteKhoiLuongQuyDoiCollection
		///</summary>
		[ChildEntityType(typeof(TList<UteKhoiLuongQuyDoi>))]
		UteKhoiLuongQuyDoiCollection,
	}
	
	#endregion UteKhoiLuongGiangDayChildEntityTypes
	
	#region UteKhoiLuongGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;UteKhoiLuongGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UteKhoiLuongGiangDayFilterBuilder : SqlFilterBuilder<UteKhoiLuongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		public UteKhoiLuongGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UteKhoiLuongGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UteKhoiLuongGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UteKhoiLuongGiangDayFilterBuilder
	
	#region UteKhoiLuongGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;UteKhoiLuongGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UteKhoiLuongGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<UteKhoiLuongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		public UteKhoiLuongGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UteKhoiLuongGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UteKhoiLuongGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UteKhoiLuongGiangDayParameterBuilder
	
	#region UteKhoiLuongGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;UteKhoiLuongGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UteKhoiLuongGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class UteKhoiLuongGiangDaySortBuilder : SqlSortBuilder<UteKhoiLuongGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongGiangDaySqlSortBuilder class.
		/// </summary>
		public UteKhoiLuongGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion UteKhoiLuongGiangDaySortBuilder
	
} // end namespace
