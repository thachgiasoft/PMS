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
	/// This class is the base class for any <see cref="KhoiLuongDoAnTotNghiepChiTietProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KhoiLuongDoAnTotNghiepChiTietProviderBaseCore : EntityProviderBase<PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet, PMS.Entities.KhoiLuongDoAnTotNghiepChiTietKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KhoiLuongDoAnTotNghiepChiTietKey key)
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
		public override PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet Get(TransactionManager transactionManager, PMS.Entities.KhoiLuongDoAnTotNghiepChiTietKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KhoiLuongDoAnTotNghiepChiTiet index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet"/> class.</returns>
		public PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongDoAnTotNghiepChiTiet index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet"/> class.</returns>
		public PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongDoAnTotNghiepChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet"/> class.</returns>
		public PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongDoAnTotNghiepChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet"/> class.</returns>
		public PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongDoAnTotNghiepChiTiet index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet"/> class.</returns>
		public PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongDoAnTotNghiepChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet"/> class.</returns>
		public abstract PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KhoiLuongDoAnTotNghiepChiTiet_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongDoAnTotNghiepChiTiet_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(System.String namHoc, System.String hocKy)
		{
			 DongBo(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongDoAnTotNghiepChiTiet_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongDoAnTotNghiepChiTiet_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongDoAnTotNghiepChiTiet_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongDoAnTotNghiepChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongDoAnTotNghiepChiTiet> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongDoAnTotNghiepChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongDoAnTotNghiepChiTiet> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongDoAnTotNghiepChiTiet&gt;"/> instance.</returns>
		public TList<KhoiLuongDoAnTotNghiepChiTiet> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongDoAnTotNghiepChiTiet_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongDoAnTotNghiepChiTiet&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongDoAnTotNghiepChiTiet> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongDoAnTotNghiepChiTiet_QuyDoi 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongDoAnTotNghiepChiTiet_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(System.String namHoc, System.String hocKy, System.String xmlData)
		{
			 QuyDoi(null, 0, int.MaxValue , namHoc, hocKy, xmlData);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongDoAnTotNghiepChiTiet_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String xmlData)
		{
			 QuyDoi(null, start, pageLength , namHoc, hocKy, xmlData);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongDoAnTotNghiepChiTiet_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String xmlData)
		{
			 QuyDoi(transactionManager, 0, int.MaxValue , namHoc, hocKy, xmlData);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongDoAnTotNghiepChiTiet_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void QuyDoi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String xmlData);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KhoiLuongDoAnTotNghiepChiTiet&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KhoiLuongDoAnTotNghiepChiTiet&gt;"/></returns>
		public static TList<KhoiLuongDoAnTotNghiepChiTiet> Fill(IDataReader reader, TList<KhoiLuongDoAnTotNghiepChiTiet> rows, int start, int pageLength)
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
				
				PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KhoiLuongDoAnTotNghiepChiTiet")
					.Append("|").Append((System.Int32)reader[((int)KhoiLuongDoAnTotNghiepChiTietColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KhoiLuongDoAnTotNghiepChiTiet>(
					key.ToString(), // EntityTrackingKey
					"KhoiLuongDoAnTotNghiepChiTiet",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet();
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
					c.Id = (System.Int32)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.Id.ToString())];
					c.MaGiangVien = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.MaGiangVien.ToString())];
					c.HoTen = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.HoTen.ToString())];
					c.MaMonHoc = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.TenMonHoc.ToString())];
					c.SoTinChi = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.SoTinChi.ToString())];
					c.NamHoc = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.NamHoc.ToString())];
					c.HocKy = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.HocKy.ToString())];
					c.MaLopHocPhan = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.MaLopHocPhan.ToString())];
					c.MaLop = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.MaLop.ToString())];
					c.Nhom = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.Nhom.ToString())];
					c.MaLoaiHocPhan = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.MaLoaiHocPhan.ToString())];
					c.LopClc = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.LopClc.ToString())];
					c.SoLuongHuongDan = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.SoLuongHuongDan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.SoLuongHuongDan.ToString())];
					c.SoTiet = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.SoTiet.ToString())];
					c.DonGia = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.DonGia.ToString())];
					c.SoTien = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.SoTien.ToString())];
					c.NgayCapNhat = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.NgayCapNhat.ToString())];
					c.HeSoHocKy = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.HeSoHocKy.ToString())];
					c.HeSoThamGia = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.HeSoThamGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.HeSoThamGia.ToString())];
					c.SoLuongDeTai = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.SoLuongDeTai.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.SoLuongDeTai.ToString())];
					c.LoaiThamGia = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.LoaiThamGia.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.LoaiThamGia.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.Id.ToString())];
			entity.MaGiangVien = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.MaGiangVien.ToString())];
			entity.HoTen = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.HoTen.ToString())];
			entity.MaMonHoc = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.TenMonHoc.ToString())];
			entity.SoTinChi = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.SoTinChi.ToString())];
			entity.NamHoc = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.HocKy.ToString())];
			entity.MaLopHocPhan = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.MaLopHocPhan.ToString())];
			entity.MaLop = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.MaLop.ToString())];
			entity.Nhom = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.Nhom.ToString())];
			entity.MaLoaiHocPhan = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.MaLoaiHocPhan.ToString())];
			entity.LopClc = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.LopClc.ToString())];
			entity.SoLuongHuongDan = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.SoLuongHuongDan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.SoLuongHuongDan.ToString())];
			entity.SoTiet = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.SoTiet.ToString())];
			entity.DonGia = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.DonGia.ToString())];
			entity.SoTien = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.SoTien.ToString())];
			entity.NgayCapNhat = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.NgayCapNhat.ToString())];
			entity.HeSoHocKy = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.HeSoHocKy.ToString())];
			entity.HeSoThamGia = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.HeSoThamGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.HeSoThamGia.ToString())];
			entity.SoLuongDeTai = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.SoLuongDeTai.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.SoLuongDeTai.ToString())];
			entity.LoaiThamGia = (reader[KhoiLuongDoAnTotNghiepChiTietColumn.LoaiThamGia.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongDoAnTotNghiepChiTietColumn.LoaiThamGia.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.HoTen = Convert.IsDBNull(dataRow["HoTen"]) ? null : (System.String)dataRow["HoTen"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.LopClc = Convert.IsDBNull(dataRow["LopClc"]) ? null : (System.Boolean?)dataRow["LopClc"];
			entity.SoLuongHuongDan = Convert.IsDBNull(dataRow["SoLuongHuongDan"]) ? null : (System.Int32?)dataRow["SoLuongHuongDan"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.SoTien = Convert.IsDBNull(dataRow["SoTien"]) ? null : (System.Decimal?)dataRow["SoTien"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
			entity.HeSoThamGia = Convert.IsDBNull(dataRow["HeSoThamGia"]) ? null : (System.Decimal?)dataRow["HeSoThamGia"];
			entity.SoLuongDeTai = Convert.IsDBNull(dataRow["SoLuongDeTai"]) ? null : (System.Int32?)dataRow["SoLuongDeTai"];
			entity.LoaiThamGia = Convert.IsDBNull(dataRow["LoaiThamGia"]) ? null : (System.String)dataRow["LoaiThamGia"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KhoiLuongDoAnTotNghiepChiTietChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KhoiLuongDoAnTotNghiepChiTiet</c>
	///</summary>
	public enum KhoiLuongDoAnTotNghiepChiTietChildEntityTypes
	{
	}
	
	#endregion KhoiLuongDoAnTotNghiepChiTietChildEntityTypes
	
	#region KhoiLuongDoAnTotNghiepChiTietFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KhoiLuongDoAnTotNghiepChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongDoAnTotNghiepChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongDoAnTotNghiepChiTietFilterBuilder : SqlFilterBuilder<KhoiLuongDoAnTotNghiepChiTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongDoAnTotNghiepChiTietFilterBuilder class.
		/// </summary>
		public KhoiLuongDoAnTotNghiepChiTietFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongDoAnTotNghiepChiTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongDoAnTotNghiepChiTietFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongDoAnTotNghiepChiTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongDoAnTotNghiepChiTietFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongDoAnTotNghiepChiTietFilterBuilder
	
	#region KhoiLuongDoAnTotNghiepChiTietParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KhoiLuongDoAnTotNghiepChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongDoAnTotNghiepChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongDoAnTotNghiepChiTietParameterBuilder : ParameterizedSqlFilterBuilder<KhoiLuongDoAnTotNghiepChiTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongDoAnTotNghiepChiTietParameterBuilder class.
		/// </summary>
		public KhoiLuongDoAnTotNghiepChiTietParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongDoAnTotNghiepChiTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongDoAnTotNghiepChiTietParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongDoAnTotNghiepChiTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongDoAnTotNghiepChiTietParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongDoAnTotNghiepChiTietParameterBuilder
	
	#region KhoiLuongDoAnTotNghiepChiTietSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KhoiLuongDoAnTotNghiepChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongDoAnTotNghiepChiTiet"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KhoiLuongDoAnTotNghiepChiTietSortBuilder : SqlSortBuilder<KhoiLuongDoAnTotNghiepChiTietColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongDoAnTotNghiepChiTietSqlSortBuilder class.
		/// </summary>
		public KhoiLuongDoAnTotNghiepChiTietSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KhoiLuongDoAnTotNghiepChiTietSortBuilder
	
} // end namespace
