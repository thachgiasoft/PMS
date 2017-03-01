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
	/// This class is the base class for any <see cref="KhoiLuongGiangDayDoAnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KhoiLuongGiangDayDoAnProviderBaseCore : EntityProviderBase<PMS.Entities.KhoiLuongGiangDayDoAn, PMS.Entities.KhoiLuongGiangDayDoAnKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayDoAnKey key)
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
		public override PMS.Entities.KhoiLuongGiangDayDoAn Get(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayDoAnKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KhoiLuongGiangDayDoAn index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayDoAn"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayDoAn GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayDoAn index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayDoAn"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayDoAn GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayDoAn index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayDoAn"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayDoAn GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayDoAn index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayDoAn"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayDoAn GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayDoAn index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayDoAn"/> class.</returns>
		public PMS.Entities.KhoiLuongGiangDayDoAn GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongGiangDayDoAn index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongGiangDayDoAn"/> class.</returns>
		public abstract PMS.Entities.KhoiLuongGiangDayDoAn GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KhoiLuongGiangDayDoAn_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayDoAn_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(System.String namHoc, System.String hocKy)
		{
			 DongBo(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayDoAn_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongGiangDayDoAn_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongGiangDayDoAn_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayDoAn_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayDoAn_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayDoAn&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayDoAn> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayDoAn_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayDoAn&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayDoAn> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayDoAn_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayDoAn&gt;"/> instance.</returns>
		public TList<KhoiLuongGiangDayDoAn> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayDoAn_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongGiangDayDoAn&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongGiangDayDoAn> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongGiangDayDoAn_KiemTraDongBo 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongGiangDayDoAn_KiemTraDongBo' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongGiangDayDoAn_KiemTraDongBo' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongGiangDayDoAn_KiemTraDongBo' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongGiangDayDoAn_KiemTraDongBo' stored procedure. 
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
		/// Fill a TList&lt;KhoiLuongGiangDayDoAn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KhoiLuongGiangDayDoAn&gt;"/></returns>
		public static TList<KhoiLuongGiangDayDoAn> Fill(IDataReader reader, TList<KhoiLuongGiangDayDoAn> rows, int start, int pageLength)
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
				
				PMS.Entities.KhoiLuongGiangDayDoAn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KhoiLuongGiangDayDoAn")
					.Append("|").Append((System.Int32)reader[((int)KhoiLuongGiangDayDoAnColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KhoiLuongGiangDayDoAn>(
					key.ToString(), // EntityTrackingKey
					"KhoiLuongGiangDayDoAn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KhoiLuongGiangDayDoAn();
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
					c.Id = (System.Int32)reader[(KhoiLuongGiangDayDoAnColumn.Id.ToString())];
					c.MaMonHoc = (reader[KhoiLuongGiangDayDoAnColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[KhoiLuongGiangDayDoAnColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.TenMonHoc.ToString())];
					c.MaHocPhan = (reader[KhoiLuongGiangDayDoAnColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.MaHocPhan.ToString())];
					c.NamHoc = (reader[KhoiLuongGiangDayDoAnColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.NamHoc.ToString())];
					c.HocKy = (reader[KhoiLuongGiangDayDoAnColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.HocKy.ToString())];
					c.MaLopHocPhan = (reader[KhoiLuongGiangDayDoAnColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.MaLopHocPhan.ToString())];
					c.Nhom = (reader[KhoiLuongGiangDayDoAnColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.Nhom.ToString())];
					c.MaLop = (reader[KhoiLuongGiangDayDoAnColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.MaLop.ToString())];
					c.SoTinChi = (reader[KhoiLuongGiangDayDoAnColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayDoAnColumn.SoTinChi.ToString())];
					c.LopClc = (reader[KhoiLuongGiangDayDoAnColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KhoiLuongGiangDayDoAnColumn.LopClc.ToString())];
					c.SiSo = (reader[KhoiLuongGiangDayDoAnColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayDoAnColumn.SiSo.ToString())];
					c.MaGiangVienQuanLy = (reader[KhoiLuongGiangDayDoAnColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.MaGiangVienQuanLy.ToString())];
					c.MaLoaiGiangVien = (reader[KhoiLuongGiangDayDoAnColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayDoAnColumn.MaLoaiGiangVien.ToString())];
					c.MaHocHam = (reader[KhoiLuongGiangDayDoAnColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayDoAnColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KhoiLuongGiangDayDoAnColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayDoAnColumn.MaHocVi.ToString())];
					c.NgayCapNhat = (reader[KhoiLuongGiangDayDoAnColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayDoAnColumn.NgayCapNhat.ToString())];
					c.SoTietQuyDoi = (reader[KhoiLuongGiangDayDoAnColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayDoAnColumn.SoTietQuyDoi.ToString())];
					c.DonGia = (reader[KhoiLuongGiangDayDoAnColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayDoAnColumn.DonGia.ToString())];
					c.ThanhTien = (reader[KhoiLuongGiangDayDoAnColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayDoAnColumn.ThanhTien.ToString())];
					c.HeSoHocKy = (reader[KhoiLuongGiangDayDoAnColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayDoAnColumn.HeSoHocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongGiangDayDoAn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayDoAn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KhoiLuongGiangDayDoAn entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KhoiLuongGiangDayDoAnColumn.Id.ToString())];
			entity.MaMonHoc = (reader[KhoiLuongGiangDayDoAnColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[KhoiLuongGiangDayDoAnColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.TenMonHoc.ToString())];
			entity.MaHocPhan = (reader[KhoiLuongGiangDayDoAnColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.MaHocPhan.ToString())];
			entity.NamHoc = (reader[KhoiLuongGiangDayDoAnColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KhoiLuongGiangDayDoAnColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.HocKy.ToString())];
			entity.MaLopHocPhan = (reader[KhoiLuongGiangDayDoAnColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.MaLopHocPhan.ToString())];
			entity.Nhom = (reader[KhoiLuongGiangDayDoAnColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.Nhom.ToString())];
			entity.MaLop = (reader[KhoiLuongGiangDayDoAnColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.MaLop.ToString())];
			entity.SoTinChi = (reader[KhoiLuongGiangDayDoAnColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayDoAnColumn.SoTinChi.ToString())];
			entity.LopClc = (reader[KhoiLuongGiangDayDoAnColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KhoiLuongGiangDayDoAnColumn.LopClc.ToString())];
			entity.SiSo = (reader[KhoiLuongGiangDayDoAnColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayDoAnColumn.SiSo.ToString())];
			entity.MaGiangVienQuanLy = (reader[KhoiLuongGiangDayDoAnColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongGiangDayDoAnColumn.MaGiangVienQuanLy.ToString())];
			entity.MaLoaiGiangVien = (reader[KhoiLuongGiangDayDoAnColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayDoAnColumn.MaLoaiGiangVien.ToString())];
			entity.MaHocHam = (reader[KhoiLuongGiangDayDoAnColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayDoAnColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KhoiLuongGiangDayDoAnColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongGiangDayDoAnColumn.MaHocVi.ToString())];
			entity.NgayCapNhat = (reader[KhoiLuongGiangDayDoAnColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongGiangDayDoAnColumn.NgayCapNhat.ToString())];
			entity.SoTietQuyDoi = (reader[KhoiLuongGiangDayDoAnColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayDoAnColumn.SoTietQuyDoi.ToString())];
			entity.DonGia = (reader[KhoiLuongGiangDayDoAnColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayDoAnColumn.DonGia.ToString())];
			entity.ThanhTien = (reader[KhoiLuongGiangDayDoAnColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayDoAnColumn.ThanhTien.ToString())];
			entity.HeSoHocKy = (reader[KhoiLuongGiangDayDoAnColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongGiangDayDoAnColumn.HeSoHocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongGiangDayDoAn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayDoAn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KhoiLuongGiangDayDoAn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.MaHocPhan = Convert.IsDBNull(dataRow["MaHocPhan"]) ? null : (System.String)dataRow["MaHocPhan"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
			entity.LopClc = Convert.IsDBNull(dataRow["LopClc"]) ? null : (System.Boolean?)dataRow["LopClc"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.SoTietQuyDoi = Convert.IsDBNull(dataRow["SoTietQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietQuyDoi"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.ThanhTien = Convert.IsDBNull(dataRow["ThanhTien"]) ? null : (System.Decimal?)dataRow["ThanhTien"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongGiangDayDoAn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongGiangDayDoAn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayDoAn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KhoiLuongGiangDayDoAn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KhoiLuongGiangDayDoAn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongGiangDayDoAn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KhoiLuongGiangDayDoAn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KhoiLuongGiangDayDoAnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KhoiLuongGiangDayDoAn</c>
	///</summary>
	public enum KhoiLuongGiangDayDoAnChildEntityTypes
	{
	}
	
	#endregion KhoiLuongGiangDayDoAnChildEntityTypes
	
	#region KhoiLuongGiangDayDoAnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KhoiLuongGiangDayDoAnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayDoAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayDoAnFilterBuilder : SqlFilterBuilder<KhoiLuongGiangDayDoAnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnFilterBuilder class.
		/// </summary>
		public KhoiLuongGiangDayDoAnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongGiangDayDoAnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongGiangDayDoAnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongGiangDayDoAnFilterBuilder
	
	#region KhoiLuongGiangDayDoAnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KhoiLuongGiangDayDoAnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayDoAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayDoAnParameterBuilder : ParameterizedSqlFilterBuilder<KhoiLuongGiangDayDoAnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnParameterBuilder class.
		/// </summary>
		public KhoiLuongGiangDayDoAnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongGiangDayDoAnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongGiangDayDoAnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongGiangDayDoAnParameterBuilder
	
	#region KhoiLuongGiangDayDoAnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KhoiLuongGiangDayDoAnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayDoAn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KhoiLuongGiangDayDoAnSortBuilder : SqlSortBuilder<KhoiLuongGiangDayDoAnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnSqlSortBuilder class.
		/// </summary>
		public KhoiLuongGiangDayDoAnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KhoiLuongGiangDayDoAnSortBuilder
	
} // end namespace
