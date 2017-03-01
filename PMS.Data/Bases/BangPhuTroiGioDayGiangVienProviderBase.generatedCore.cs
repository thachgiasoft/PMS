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
	/// This class is the base class for any <see cref="BangPhuTroiGioDayGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class BangPhuTroiGioDayGiangVienProviderBaseCore : EntityProviderBase<PMS.Entities.BangPhuTroiGioDayGiangVien, PMS.Entities.BangPhuTroiGioDayGiangVienKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.BangPhuTroiGioDayGiangVienKey key)
		{
			return Delete(transactionManager, key.MaGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maGiangVien)
		{
			return Delete(null, _maGiangVien);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maGiangVien);		
		
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
		public override PMS.Entities.BangPhuTroiGioDayGiangVien Get(TransactionManager transactionManager, PMS.Entities.BangPhuTroiGioDayGiangVienKey key, int start, int pageLength)
		{
			return GetByMaGiangVien(transactionManager, key.MaGiangVien, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_BangPhuTroiGioDay_GiangVien index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.BangPhuTroiGioDayGiangVien"/> class.</returns>
		public PMS.Entities.BangPhuTroiGioDayGiangVien GetByMaGiangVien(System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(null,_maGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangPhuTroiGioDay_GiangVien index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.BangPhuTroiGioDayGiangVien"/> class.</returns>
		public PMS.Entities.BangPhuTroiGioDayGiangVien GetByMaGiangVien(System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangPhuTroiGioDay_GiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.BangPhuTroiGioDayGiangVien"/> class.</returns>
		public PMS.Entities.BangPhuTroiGioDayGiangVien GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangPhuTroiGioDay_GiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.BangPhuTroiGioDayGiangVien"/> class.</returns>
		public PMS.Entities.BangPhuTroiGioDayGiangVien GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien, int start, int pageLength)
		{
			int count = -1;
			return GetByMaGiangVien(transactionManager, _maGiangVien, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangPhuTroiGioDay_GiangVien index.
		/// </summary>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.BangPhuTroiGioDayGiangVien"/> class.</returns>
		public PMS.Entities.BangPhuTroiGioDayGiangVien GetByMaGiangVien(System.Int32 _maGiangVien, int start, int pageLength, out int count)
		{
			return GetByMaGiangVien(null, _maGiangVien, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_BangPhuTroiGioDay_GiangVien index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maGiangVien"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.BangPhuTroiGioDayGiangVien"/> class.</returns>
		public abstract PMS.Entities.BangPhuTroiGioDayGiangVien GetByMaGiangVien(TransactionManager transactionManager, System.Int32 _maGiangVien, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_BangPhuTroiGioDay_GiangVien_GetByNamHocHocKyMaDonViMaLoaiGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_BangPhuTroiGioDay_GiangVien_GetByNamHocHocKyMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGv"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;BangPhuTroiGioDayGiangVien&gt;"/> instance.</returns>
		public TList<BangPhuTroiGioDayGiangVien> GetByNamHocHocKyMaDonViMaLoaiGiangVien(System.String namHoc, System.Int32 maLoaiGv, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVien(null, 0, int.MaxValue , namHoc, maLoaiGv, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_BangPhuTroiGioDay_GiangVien_GetByNamHocHocKyMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGv"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;BangPhuTroiGioDayGiangVien&gt;"/> instance.</returns>
		public TList<BangPhuTroiGioDayGiangVien> GetByNamHocHocKyMaDonViMaLoaiGiangVien(int start, int pageLength, System.String namHoc, System.Int32 maLoaiGv, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVien(null, start, pageLength , namHoc, maLoaiGv, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_BangPhuTroiGioDay_GiangVien_GetByNamHocHocKyMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGv"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;BangPhuTroiGioDayGiangVien&gt;"/> instance.</returns>
		public TList<BangPhuTroiGioDayGiangVien> GetByNamHocHocKyMaDonViMaLoaiGiangVien(TransactionManager transactionManager, System.String namHoc, System.Int32 maLoaiGv, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonViMaLoaiGiangVien(transactionManager, 0, int.MaxValue , namHoc, maLoaiGv, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_BangPhuTroiGioDay_GiangVien_GetByNamHocHocKyMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGv"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;BangPhuTroiGioDayGiangVien&gt;"/> instance.</returns>
		public abstract TList<BangPhuTroiGioDayGiangVien> GetByNamHocHocKyMaDonViMaLoaiGiangVien(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.Int32 maLoaiGv, System.String maDonVi);
		
		#endregion
		
		#region cust_BangPhuTroiGioDay_GiangVien_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_BangPhuTroiGioDay_GiangVien_DongBo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGv"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(System.String xmlData, System.String namHoc, System.Int32 maLoaiGv, System.String maDonVi)
		{
			 DongBo(null, 0, int.MaxValue , xmlData, namHoc, maLoaiGv, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_BangPhuTroiGioDay_GiangVien_DongBo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGv"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(int start, int pageLength, System.String xmlData, System.String namHoc, System.Int32 maLoaiGv, System.String maDonVi)
		{
			 DongBo(null, start, pageLength , xmlData, namHoc, maLoaiGv, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_BangPhuTroiGioDay_GiangVien_DongBo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGv"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.Int32 maLoaiGv, System.String maDonVi)
		{
			 DongBo(transactionManager, 0, int.MaxValue , xmlData, namHoc, maLoaiGv, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_BangPhuTroiGioDay_GiangVien_DongBo' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGv"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBo(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.Int32 maLoaiGv, System.String maDonVi);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;BangPhuTroiGioDayGiangVien&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;BangPhuTroiGioDayGiangVien&gt;"/></returns>
		public static TList<BangPhuTroiGioDayGiangVien> Fill(IDataReader reader, TList<BangPhuTroiGioDayGiangVien> rows, int start, int pageLength)
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
				
				PMS.Entities.BangPhuTroiGioDayGiangVien c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("BangPhuTroiGioDayGiangVien")
					.Append("|").Append((System.Int32)reader[((int)BangPhuTroiGioDayGiangVienColumn.MaGiangVien - 1)]).ToString();
					c = EntityManager.LocateOrCreate<BangPhuTroiGioDayGiangVien>(
					key.ToString(), // EntityTrackingKey
					"BangPhuTroiGioDayGiangVien",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.BangPhuTroiGioDayGiangVien();
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
					c.MaGiangVien = (System.Int32)reader[(BangPhuTroiGioDayGiangVienColumn.MaGiangVien.ToString())];
					c.OriginalMaGiangVien = c.MaGiangVien;
					c.MaQuanLy = (System.String)reader[(BangPhuTroiGioDayGiangVienColumn.MaQuanLy.ToString())];
					c.Ho = (reader[BangPhuTroiGioDayGiangVienColumn.Ho.ToString()] == DBNull.Value) ? null : (System.String)reader[(BangPhuTroiGioDayGiangVienColumn.Ho.ToString())];
					c.Ten = (reader[BangPhuTroiGioDayGiangVienColumn.Ten.ToString()] == DBNull.Value) ? null : (System.String)reader[(BangPhuTroiGioDayGiangVienColumn.Ten.ToString())];
					c.NamHoc = (reader[BangPhuTroiGioDayGiangVienColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(BangPhuTroiGioDayGiangVienColumn.NamHoc.ToString())];
					c.MaDonVi = (reader[BangPhuTroiGioDayGiangVienColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(BangPhuTroiGioDayGiangVienColumn.MaDonVi.ToString())];
					c.TenDonVi = (System.String)reader[(BangPhuTroiGioDayGiangVienColumn.TenDonVi.ToString())];
					c.MaLoaiGiangVien = (System.Int32)reader[(BangPhuTroiGioDayGiangVienColumn.MaLoaiGiangVien.ToString())];
					c.TenLoaiGiangVien = (reader[BangPhuTroiGioDayGiangVienColumn.TenLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(BangPhuTroiGioDayGiangVienColumn.TenLoaiGiangVien.ToString())];
					c.TcThucDay = (reader[BangPhuTroiGioDayGiangVienColumn.TcThucDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(BangPhuTroiGioDayGiangVienColumn.TcThucDay.ToString())];
					c.TietQd = (reader[BangPhuTroiGioDayGiangVienColumn.TietQd.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(BangPhuTroiGioDayGiangVienColumn.TietQd.ToString())];
					c.NhiemVuGd = (reader[BangPhuTroiGioDayGiangVienColumn.NhiemVuGd.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(BangPhuTroiGioDayGiangVienColumn.NhiemVuGd.ToString())];
					c.NhiemVuNckh = (reader[BangPhuTroiGioDayGiangVienColumn.NhiemVuNckh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(BangPhuTroiGioDayGiangVienColumn.NhiemVuNckh.ToString())];
					c.PhanCongCn = (reader[BangPhuTroiGioDayGiangVienColumn.PhanCongCn.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(BangPhuTroiGioDayGiangVienColumn.PhanCongCn.ToString())];
					c.CongTrinhCd = (reader[BangPhuTroiGioDayGiangVienColumn.CongTrinhCd.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(BangPhuTroiGioDayGiangVienColumn.CongTrinhCd.ToString())];
					c.CongTrinhTc = (reader[BangPhuTroiGioDayGiangVienColumn.CongTrinhTc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(BangPhuTroiGioDayGiangVienColumn.CongTrinhTc.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.BangPhuTroiGioDayGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.BangPhuTroiGioDayGiangVien"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.BangPhuTroiGioDayGiangVien entity)
		{
			if (!reader.Read()) return;
			
			entity.MaGiangVien = (System.Int32)reader[(BangPhuTroiGioDayGiangVienColumn.MaGiangVien.ToString())];
			entity.OriginalMaGiangVien = (System.Int32)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader[(BangPhuTroiGioDayGiangVienColumn.MaQuanLy.ToString())];
			entity.Ho = (reader[BangPhuTroiGioDayGiangVienColumn.Ho.ToString()] == DBNull.Value) ? null : (System.String)reader[(BangPhuTroiGioDayGiangVienColumn.Ho.ToString())];
			entity.Ten = (reader[BangPhuTroiGioDayGiangVienColumn.Ten.ToString()] == DBNull.Value) ? null : (System.String)reader[(BangPhuTroiGioDayGiangVienColumn.Ten.ToString())];
			entity.NamHoc = (reader[BangPhuTroiGioDayGiangVienColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(BangPhuTroiGioDayGiangVienColumn.NamHoc.ToString())];
			entity.MaDonVi = (reader[BangPhuTroiGioDayGiangVienColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(BangPhuTroiGioDayGiangVienColumn.MaDonVi.ToString())];
			entity.TenDonVi = (System.String)reader[(BangPhuTroiGioDayGiangVienColumn.TenDonVi.ToString())];
			entity.MaLoaiGiangVien = (System.Int32)reader[(BangPhuTroiGioDayGiangVienColumn.MaLoaiGiangVien.ToString())];
			entity.TenLoaiGiangVien = (reader[BangPhuTroiGioDayGiangVienColumn.TenLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(BangPhuTroiGioDayGiangVienColumn.TenLoaiGiangVien.ToString())];
			entity.TcThucDay = (reader[BangPhuTroiGioDayGiangVienColumn.TcThucDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(BangPhuTroiGioDayGiangVienColumn.TcThucDay.ToString())];
			entity.TietQd = (reader[BangPhuTroiGioDayGiangVienColumn.TietQd.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(BangPhuTroiGioDayGiangVienColumn.TietQd.ToString())];
			entity.NhiemVuGd = (reader[BangPhuTroiGioDayGiangVienColumn.NhiemVuGd.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(BangPhuTroiGioDayGiangVienColumn.NhiemVuGd.ToString())];
			entity.NhiemVuNckh = (reader[BangPhuTroiGioDayGiangVienColumn.NhiemVuNckh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(BangPhuTroiGioDayGiangVienColumn.NhiemVuNckh.ToString())];
			entity.PhanCongCn = (reader[BangPhuTroiGioDayGiangVienColumn.PhanCongCn.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(BangPhuTroiGioDayGiangVienColumn.PhanCongCn.ToString())];
			entity.CongTrinhCd = (reader[BangPhuTroiGioDayGiangVienColumn.CongTrinhCd.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(BangPhuTroiGioDayGiangVienColumn.CongTrinhCd.ToString())];
			entity.CongTrinhTc = (reader[BangPhuTroiGioDayGiangVienColumn.CongTrinhTc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(BangPhuTroiGioDayGiangVienColumn.CongTrinhTc.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.BangPhuTroiGioDayGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.BangPhuTroiGioDayGiangVien"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.BangPhuTroiGioDayGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.OriginalMaGiangVien = (System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.Ho = Convert.IsDBNull(dataRow["Ho"]) ? null : (System.String)dataRow["Ho"];
			entity.Ten = Convert.IsDBNull(dataRow["Ten"]) ? null : (System.String)dataRow["Ten"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.String)dataRow["MaDonVi"];
			entity.TenDonVi = (System.String)dataRow["TenDonVi"];
			entity.MaLoaiGiangVien = (System.Int32)dataRow["MaLoaiGiangVien"];
			entity.TenLoaiGiangVien = Convert.IsDBNull(dataRow["TenLoaiGiangVien"]) ? null : (System.String)dataRow["TenLoaiGiangVien"];
			entity.TcThucDay = Convert.IsDBNull(dataRow["TCThucDay"]) ? null : (System.Decimal?)dataRow["TCThucDay"];
			entity.TietQd = Convert.IsDBNull(dataRow["TietQD"]) ? null : (System.Decimal?)dataRow["TietQD"];
			entity.NhiemVuGd = Convert.IsDBNull(dataRow["NhiemVuGD"]) ? null : (System.Int32?)dataRow["NhiemVuGD"];
			entity.NhiemVuNckh = Convert.IsDBNull(dataRow["NhiemVuNCKH"]) ? null : (System.Int32?)dataRow["NhiemVuNCKH"];
			entity.PhanCongCn = Convert.IsDBNull(dataRow["PhanCongCN"]) ? null : (System.Int32?)dataRow["PhanCongCN"];
			entity.CongTrinhCd = Convert.IsDBNull(dataRow["CongTrinhCD"]) ? null : (System.Int32?)dataRow["CongTrinhCD"];
			entity.CongTrinhTc = Convert.IsDBNull(dataRow["CongTrinhTC"]) ? null : (System.Int32?)dataRow["CongTrinhTC"];
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
		/// <param name="entity">The <see cref="PMS.Entities.BangPhuTroiGioDayGiangVien"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.BangPhuTroiGioDayGiangVien Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.BangPhuTroiGioDayGiangVien entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.BangPhuTroiGioDayGiangVien object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.BangPhuTroiGioDayGiangVien instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.BangPhuTroiGioDayGiangVien Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.BangPhuTroiGioDayGiangVien entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region BangPhuTroiGioDayGiangVienChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.BangPhuTroiGioDayGiangVien</c>
	///</summary>
	public enum BangPhuTroiGioDayGiangVienChildEntityTypes
	{
	}
	
	#endregion BangPhuTroiGioDayGiangVienChildEntityTypes
	
	#region BangPhuTroiGioDayGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;BangPhuTroiGioDayGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BangPhuTroiGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BangPhuTroiGioDayGiangVienFilterBuilder : SqlFilterBuilder<BangPhuTroiGioDayGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiGioDayGiangVienFilterBuilder class.
		/// </summary>
		public BangPhuTroiGioDayGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiGioDayGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public BangPhuTroiGioDayGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiGioDayGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public BangPhuTroiGioDayGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion BangPhuTroiGioDayGiangVienFilterBuilder
	
	#region BangPhuTroiGioDayGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;BangPhuTroiGioDayGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BangPhuTroiGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BangPhuTroiGioDayGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<BangPhuTroiGioDayGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiGioDayGiangVienParameterBuilder class.
		/// </summary>
		public BangPhuTroiGioDayGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiGioDayGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public BangPhuTroiGioDayGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiGioDayGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public BangPhuTroiGioDayGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion BangPhuTroiGioDayGiangVienParameterBuilder
	
	#region BangPhuTroiGioDayGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;BangPhuTroiGioDayGiangVienColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BangPhuTroiGioDayGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class BangPhuTroiGioDayGiangVienSortBuilder : SqlSortBuilder<BangPhuTroiGioDayGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiGioDayGiangVienSqlSortBuilder class.
		/// </summary>
		public BangPhuTroiGioDayGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion BangPhuTroiGioDayGiangVienSortBuilder
	
} // end namespace
