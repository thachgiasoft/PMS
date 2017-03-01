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
	/// This class is the base class for any <see cref="KcqUteKhoiLuongGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqUteKhoiLuongGiangDayProviderBaseCore : EntityProviderBase<PMS.Entities.KcqUteKhoiLuongGiangDay, PMS.Entities.KcqUteKhoiLuongGiangDayKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqUteKhoiLuongGiangDayKey key)
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
		public override PMS.Entities.KcqUteKhoiLuongGiangDay Get(TransactionManager transactionManager, PMS.Entities.KcqUteKhoiLuongGiangDayKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqUte_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteKhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.KcqUteKhoiLuongGiangDay GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteKhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.KcqUteKhoiLuongGiangDay GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteKhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.KcqUteKhoiLuongGiangDay GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteKhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.KcqUteKhoiLuongGiangDay GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteKhoiLuongGiangDay"/> class.</returns>
		public PMS.Entities.KcqUteKhoiLuongGiangDay GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_KhoiLuongGiangDay index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteKhoiLuongGiangDay"/> class.</returns>
		public abstract PMS.Entities.KcqUteKhoiLuongGiangDay GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KcqUte_KhoiLuongGiangDay_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongGiangDay_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(System.String namHoc, System.String hocKy)
		{
			 DongBo(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongGiangDay_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_KcqUte_KhoiLuongGiangDay_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_KcqUte_KhoiLuongGiangDay_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KcqUte_KhoiLuongGiangDay_KiemTraDongBo 
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongGiangDay_KiemTraDongBo' stored procedure. 
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
		///	This method wrap the 'cust_KcqUte_KhoiLuongGiangDay_KiemTraDongBo' stored procedure. 
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
		///	This method wrap the 'cust_KcqUte_KhoiLuongGiangDay_KiemTraDongBo' stored procedure. 
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
		///	This method wrap the 'cust_KcqUte_KhoiLuongGiangDay_KiemTraDongBo' stored procedure. 
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
		
		#region cust_KcqUte_KhoiLuongGiangDay_CapNhatSiSo 
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongGiangDay_CapNhatSiSo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void CapNhatSiSo(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 CapNhatSiSo(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongGiangDay_CapNhatSiSo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void CapNhatSiSo(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 CapNhatSiSo(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongGiangDay_CapNhatSiSo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void CapNhatSiSo(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 CapNhatSiSo(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_KhoiLuongGiangDay_CapNhatSiSo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void CapNhatSiSo(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqUteKhoiLuongGiangDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqUteKhoiLuongGiangDay&gt;"/></returns>
		public static TList<KcqUteKhoiLuongGiangDay> Fill(IDataReader reader, TList<KcqUteKhoiLuongGiangDay> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqUteKhoiLuongGiangDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqUteKhoiLuongGiangDay")
					.Append("|").Append((System.Int32)reader[((int)KcqUteKhoiLuongGiangDayColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqUteKhoiLuongGiangDay>(
					key.ToString(), // EntityTrackingKey
					"KcqUteKhoiLuongGiangDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqUteKhoiLuongGiangDay();
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
					c.Id = (System.Int32)reader[(KcqUteKhoiLuongGiangDayColumn.Id.ToString())];
					c.MaMonHoc = (reader[KcqUteKhoiLuongGiangDayColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[KcqUteKhoiLuongGiangDayColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.TenMonHoc.ToString())];
					c.NhomMonHoc = (reader[KcqUteKhoiLuongGiangDayColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.NhomMonHoc.ToString())];
					c.MaHocPhan = (reader[KcqUteKhoiLuongGiangDayColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaHocPhan.ToString())];
					c.NamHoc = (reader[KcqUteKhoiLuongGiangDayColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.NamHoc.ToString())];
					c.HocKy = (reader[KcqUteKhoiLuongGiangDayColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.HocKy.ToString())];
					c.MaLopHocPhan = (reader[KcqUteKhoiLuongGiangDayColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaLopHocPhan.ToString())];
					c.MaLop = (reader[KcqUteKhoiLuongGiangDayColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaLop.ToString())];
					c.MaGiangVienQuanLy = (reader[KcqUteKhoiLuongGiangDayColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaGiangVienQuanLy.ToString())];
					c.SoTinChi = (reader[KcqUteKhoiLuongGiangDayColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongGiangDayColumn.SoTinChi.ToString())];
					c.SiSo = (reader[KcqUteKhoiLuongGiangDayColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongGiangDayColumn.SiSo.ToString())];
					c.LopClc = (reader[KcqUteKhoiLuongGiangDayColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqUteKhoiLuongGiangDayColumn.LopClc.ToString())];
					c.SoTietDayChuNhat = (reader[KcqUteKhoiLuongGiangDayColumn.SoTietDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongGiangDayColumn.SoTietDayChuNhat.ToString())];
					c.SoTiet = (reader[KcqUteKhoiLuongGiangDayColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteKhoiLuongGiangDayColumn.SoTiet.ToString())];
					c.MaLoaiHocPhan = (reader[KcqUteKhoiLuongGiangDayColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongGiangDayColumn.MaLoaiHocPhan.ToString())];
					c.MaLoaiGiangVien = (reader[KcqUteKhoiLuongGiangDayColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongGiangDayColumn.MaLoaiGiangVien.ToString())];
					c.MaHocHam = (reader[KcqUteKhoiLuongGiangDayColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongGiangDayColumn.MaHocHam.ToString())];
					c.NgayCapNhat = (reader[KcqUteKhoiLuongGiangDayColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqUteKhoiLuongGiangDayColumn.NgayCapNhat.ToString())];
					c.MaHocVi = (reader[KcqUteKhoiLuongGiangDayColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongGiangDayColumn.MaHocVi.ToString())];
					c.Nhom = (reader[KcqUteKhoiLuongGiangDayColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.Nhom.ToString())];
					c.MaLoaiHocPhanGanMoi = (reader[KcqUteKhoiLuongGiangDayColumn.MaLoaiHocPhanGanMoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaLoaiHocPhanGanMoi.ToString())];
					c.MaDiaDiem = (reader[KcqUteKhoiLuongGiangDayColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaDiaDiem.ToString())];
					c.MaDot = (reader[KcqUteKhoiLuongGiangDayColumn.MaDot.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaDot.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqUteKhoiLuongGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqUteKhoiLuongGiangDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqUteKhoiLuongGiangDay entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KcqUteKhoiLuongGiangDayColumn.Id.ToString())];
			entity.MaMonHoc = (reader[KcqUteKhoiLuongGiangDayColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[KcqUteKhoiLuongGiangDayColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.TenMonHoc.ToString())];
			entity.NhomMonHoc = (reader[KcqUteKhoiLuongGiangDayColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.NhomMonHoc.ToString())];
			entity.MaHocPhan = (reader[KcqUteKhoiLuongGiangDayColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaHocPhan.ToString())];
			entity.NamHoc = (reader[KcqUteKhoiLuongGiangDayColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KcqUteKhoiLuongGiangDayColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.HocKy.ToString())];
			entity.MaLopHocPhan = (reader[KcqUteKhoiLuongGiangDayColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaLopHocPhan.ToString())];
			entity.MaLop = (reader[KcqUteKhoiLuongGiangDayColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaLop.ToString())];
			entity.MaGiangVienQuanLy = (reader[KcqUteKhoiLuongGiangDayColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaGiangVienQuanLy.ToString())];
			entity.SoTinChi = (reader[KcqUteKhoiLuongGiangDayColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongGiangDayColumn.SoTinChi.ToString())];
			entity.SiSo = (reader[KcqUteKhoiLuongGiangDayColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongGiangDayColumn.SiSo.ToString())];
			entity.LopClc = (reader[KcqUteKhoiLuongGiangDayColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqUteKhoiLuongGiangDayColumn.LopClc.ToString())];
			entity.SoTietDayChuNhat = (reader[KcqUteKhoiLuongGiangDayColumn.SoTietDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongGiangDayColumn.SoTietDayChuNhat.ToString())];
			entity.SoTiet = (reader[KcqUteKhoiLuongGiangDayColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteKhoiLuongGiangDayColumn.SoTiet.ToString())];
			entity.MaLoaiHocPhan = (reader[KcqUteKhoiLuongGiangDayColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongGiangDayColumn.MaLoaiHocPhan.ToString())];
			entity.MaLoaiGiangVien = (reader[KcqUteKhoiLuongGiangDayColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongGiangDayColumn.MaLoaiGiangVien.ToString())];
			entity.MaHocHam = (reader[KcqUteKhoiLuongGiangDayColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongGiangDayColumn.MaHocHam.ToString())];
			entity.NgayCapNhat = (reader[KcqUteKhoiLuongGiangDayColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqUteKhoiLuongGiangDayColumn.NgayCapNhat.ToString())];
			entity.MaHocVi = (reader[KcqUteKhoiLuongGiangDayColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteKhoiLuongGiangDayColumn.MaHocVi.ToString())];
			entity.Nhom = (reader[KcqUteKhoiLuongGiangDayColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.Nhom.ToString())];
			entity.MaLoaiHocPhanGanMoi = (reader[KcqUteKhoiLuongGiangDayColumn.MaLoaiHocPhanGanMoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaLoaiHocPhanGanMoi.ToString())];
			entity.MaDiaDiem = (reader[KcqUteKhoiLuongGiangDayColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaDiaDiem.ToString())];
			entity.MaDot = (reader[KcqUteKhoiLuongGiangDayColumn.MaDot.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteKhoiLuongGiangDayColumn.MaDot.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqUteKhoiLuongGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqUteKhoiLuongGiangDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqUteKhoiLuongGiangDay entity)
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
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.MaLoaiHocPhanGanMoi = Convert.IsDBNull(dataRow["MaLoaiHocPhanGanMoi"]) ? null : (System.String)dataRow["MaLoaiHocPhanGanMoi"];
			entity.MaDiaDiem = Convert.IsDBNull(dataRow["MaDiaDiem"]) ? null : (System.String)dataRow["MaDiaDiem"];
			entity.MaDot = Convert.IsDBNull(dataRow["MaDot"]) ? null : (System.String)dataRow["MaDot"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqUteKhoiLuongGiangDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqUteKhoiLuongGiangDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqUteKhoiLuongGiangDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetById methods when available
			
			#region KcqUteKhoiLuongQuyDoiCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<KcqUteKhoiLuongQuyDoi>|KcqUteKhoiLuongQuyDoiCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'KcqUteKhoiLuongQuyDoiCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.KcqUteKhoiLuongQuyDoiCollection = DataRepository.KcqUteKhoiLuongQuyDoiProvider.GetByIdKhoiLuongGiangDay(transactionManager, entity.Id);

				if (deep && entity.KcqUteKhoiLuongQuyDoiCollection.Count > 0)
				{
					deepHandles.Add("KcqUteKhoiLuongQuyDoiCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<KcqUteKhoiLuongQuyDoi>) DataRepository.KcqUteKhoiLuongQuyDoiProvider.DeepLoad,
						new object[] { transactionManager, entity.KcqUteKhoiLuongQuyDoiCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqUteKhoiLuongGiangDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqUteKhoiLuongGiangDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqUteKhoiLuongGiangDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqUteKhoiLuongGiangDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<KcqUteKhoiLuongQuyDoi>
				if (CanDeepSave(entity.KcqUteKhoiLuongQuyDoiCollection, "List<KcqUteKhoiLuongQuyDoi>|KcqUteKhoiLuongQuyDoiCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(KcqUteKhoiLuongQuyDoi child in entity.KcqUteKhoiLuongQuyDoiCollection)
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

					if (entity.KcqUteKhoiLuongQuyDoiCollection.Count > 0 || entity.KcqUteKhoiLuongQuyDoiCollection.DeletedItems.Count > 0)
					{
						//DataRepository.KcqUteKhoiLuongQuyDoiProvider.Save(transactionManager, entity.KcqUteKhoiLuongQuyDoiCollection);
						
						deepHandles.Add("KcqUteKhoiLuongQuyDoiCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< KcqUteKhoiLuongQuyDoi >) DataRepository.KcqUteKhoiLuongQuyDoiProvider.DeepSave,
							new object[] { transactionManager, entity.KcqUteKhoiLuongQuyDoiCollection, deepSaveType, childTypes, innerList }
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
	
	#region KcqUteKhoiLuongGiangDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqUteKhoiLuongGiangDay</c>
	///</summary>
	public enum KcqUteKhoiLuongGiangDayChildEntityTypes
	{
		///<summary>
		/// Collection of <c>KcqUteKhoiLuongGiangDay</c> as OneToMany for KcqUteKhoiLuongQuyDoiCollection
		///</summary>
		[ChildEntityType(typeof(TList<KcqUteKhoiLuongQuyDoi>))]
		KcqUteKhoiLuongQuyDoiCollection,
	}
	
	#endregion KcqUteKhoiLuongGiangDayChildEntityTypes
	
	#region KcqUteKhoiLuongGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqUteKhoiLuongGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqUteKhoiLuongGiangDayFilterBuilder : SqlFilterBuilder<KcqUteKhoiLuongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		public KcqUteKhoiLuongGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqUteKhoiLuongGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqUteKhoiLuongGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqUteKhoiLuongGiangDayFilterBuilder
	
	#region KcqUteKhoiLuongGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqUteKhoiLuongGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqUteKhoiLuongGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<KcqUteKhoiLuongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		public KcqUteKhoiLuongGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqUteKhoiLuongGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqUteKhoiLuongGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqUteKhoiLuongGiangDayParameterBuilder
	
	#region KcqUteKhoiLuongGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqUteKhoiLuongGiangDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteKhoiLuongGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqUteKhoiLuongGiangDaySortBuilder : SqlSortBuilder<KcqUteKhoiLuongGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongGiangDaySqlSortBuilder class.
		/// </summary>
		public KcqUteKhoiLuongGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqUteKhoiLuongGiangDaySortBuilder
	
} // end namespace
