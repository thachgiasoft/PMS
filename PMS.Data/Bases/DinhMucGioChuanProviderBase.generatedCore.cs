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
	/// This class is the base class for any <see cref="DinhMucGioChuanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DinhMucGioChuanProviderBaseCore : EntityProviderBase<PMS.Entities.DinhMucGioChuan, PMS.Entities.DinhMucGioChuanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DinhMucGioChuanKey key)
		{
			return Delete(transactionManager, key.MaDinhMuc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maDinhMuc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maDinhMuc)
		{
			return Delete(null, _maDinhMuc);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDinhMuc">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maDinhMuc);		
		
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
		public override PMS.Entities.DinhMucGioChuan Get(TransactionManager transactionManager, PMS.Entities.DinhMucGioChuanKey key, int start, int pageLength)
		{
			return GetByMaDinhMuc(transactionManager, key.MaDinhMuc, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DinhMucGioChuan index.
		/// </summary>
		/// <param name="_maDinhMuc"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucGioChuan"/> class.</returns>
		public PMS.Entities.DinhMucGioChuan GetByMaDinhMuc(System.Int32 _maDinhMuc)
		{
			int count = -1;
			return GetByMaDinhMuc(null,_maDinhMuc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucGioChuan index.
		/// </summary>
		/// <param name="_maDinhMuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucGioChuan"/> class.</returns>
		public PMS.Entities.DinhMucGioChuan GetByMaDinhMuc(System.Int32 _maDinhMuc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDinhMuc(null, _maDinhMuc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucGioChuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDinhMuc"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucGioChuan"/> class.</returns>
		public PMS.Entities.DinhMucGioChuan GetByMaDinhMuc(TransactionManager transactionManager, System.Int32 _maDinhMuc)
		{
			int count = -1;
			return GetByMaDinhMuc(transactionManager, _maDinhMuc, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucGioChuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDinhMuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucGioChuan"/> class.</returns>
		public PMS.Entities.DinhMucGioChuan GetByMaDinhMuc(TransactionManager transactionManager, System.Int32 _maDinhMuc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDinhMuc(transactionManager, _maDinhMuc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucGioChuan index.
		/// </summary>
		/// <param name="_maDinhMuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucGioChuan"/> class.</returns>
		public PMS.Entities.DinhMucGioChuan GetByMaDinhMuc(System.Int32 _maDinhMuc, int start, int pageLength, out int count)
		{
			return GetByMaDinhMuc(null, _maDinhMuc, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DinhMucGioChuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDinhMuc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DinhMucGioChuan"/> class.</returns>
		public abstract PMS.Entities.DinhMucGioChuan GetByMaDinhMuc(TransactionManager transactionManager, System.Int32 _maDinhMuc, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_DinhMucGioChuan_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DinhMucGioChuan&gt;"/> instance.</returns>
		public TList<DinhMucGioChuan> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DinhMucGioChuan&gt;"/> instance.</returns>
		public TList<DinhMucGioChuan> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DinhMucGioChuan&gt;"/> instance.</returns>
		public TList<DinhMucGioChuan> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;DinhMucGioChuan&gt;"/> instance.</returns>
		public abstract TList<DinhMucGioChuan> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_DinhMucGioChuan_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuan_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(null, 0, int.MaxValue , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuan_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(int start, int pageLength, System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(null, start, pageLength , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuan_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChep(TransactionManager transactionManager, System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich)
		{
			 SaoChep(transactionManager, 0, int.MaxValue , namHocNguon, hocKyNguon, namHocDich, hocKyDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DinhMucGioChuan_SaoChep' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void SaoChep(TransactionManager transactionManager, int start, int pageLength , System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DinhMucGioChuan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DinhMucGioChuan&gt;"/></returns>
		public static TList<DinhMucGioChuan> Fill(IDataReader reader, TList<DinhMucGioChuan> rows, int start, int pageLength)
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
				
				PMS.Entities.DinhMucGioChuan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DinhMucGioChuan")
					.Append("|").Append((System.Int32)reader[((int)DinhMucGioChuanColumn.MaDinhMuc - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DinhMucGioChuan>(
					key.ToString(), // EntityTrackingKey
					"DinhMucGioChuan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DinhMucGioChuan();
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
					c.MaDinhMuc = (System.Int32)reader[(DinhMucGioChuanColumn.MaDinhMuc.ToString())];
					c.Stt = (reader[DinhMucGioChuanColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.Stt.ToString())];
					c.MaHocHam = (reader[DinhMucGioChuanColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[DinhMucGioChuanColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.MaHocVi.ToString())];
					c.DinhMucMonHoc = (reader[DinhMucGioChuanColumn.DinhMucMonHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.DinhMucMonHoc.ToString())];
					c.DinhMucMonGdtcQp = (reader[DinhMucGioChuanColumn.DinhMucMonGdtcQp.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.DinhMucMonGdtcQp.ToString())];
					c.DinhMucNckh = (reader[DinhMucGioChuanColumn.DinhMucNckh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.DinhMucNckh.ToString())];
					c.HeSoLuongTangThem = (reader[DinhMucGioChuanColumn.HeSoLuongTangThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DinhMucGioChuanColumn.HeSoLuongTangThem.ToString())];
					c.MaBacLuong = (reader[DinhMucGioChuanColumn.MaBacLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanColumn.MaBacLuong.ToString())];
					c.DinhMucHoatDongChuyenMonKhac = (reader[DinhMucGioChuanColumn.DinhMucHoatDongChuyenMonKhac.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.DinhMucHoatDongChuyenMonKhac.ToString())];
					c.NamHoc = (reader[DinhMucGioChuanColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanColumn.NamHoc.ToString())];
					c.HocKy = (reader[DinhMucGioChuanColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanColumn.HocKy.ToString())];
					c.NgayCapNhat = (reader[DinhMucGioChuanColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[DinhMucGioChuanColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanColumn.NguoiCapNhat.ToString())];
					c.TongDinhMuc = (reader[DinhMucGioChuanColumn.TongDinhMuc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.TongDinhMuc.ToString())];
					c.HeSo = (reader[DinhMucGioChuanColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DinhMucGioChuanColumn.HeSo.ToString())];
					c.PhanLoaiGiangVien = (reader[DinhMucGioChuanColumn.PhanLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanColumn.PhanLoaiGiangVien.ToString())];
					c.TuHeSoLuong = (reader[DinhMucGioChuanColumn.TuHeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DinhMucGioChuanColumn.TuHeSoLuong.ToString())];
					c.DenHeSoLuong = (reader[DinhMucGioChuanColumn.DenHeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DinhMucGioChuanColumn.DenHeSoLuong.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DinhMucGioChuan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DinhMucGioChuan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DinhMucGioChuan entity)
		{
			if (!reader.Read()) return;
			
			entity.MaDinhMuc = (System.Int32)reader[(DinhMucGioChuanColumn.MaDinhMuc.ToString())];
			entity.Stt = (reader[DinhMucGioChuanColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.Stt.ToString())];
			entity.MaHocHam = (reader[DinhMucGioChuanColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[DinhMucGioChuanColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.MaHocVi.ToString())];
			entity.DinhMucMonHoc = (reader[DinhMucGioChuanColumn.DinhMucMonHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.DinhMucMonHoc.ToString())];
			entity.DinhMucMonGdtcQp = (reader[DinhMucGioChuanColumn.DinhMucMonGdtcQp.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.DinhMucMonGdtcQp.ToString())];
			entity.DinhMucNckh = (reader[DinhMucGioChuanColumn.DinhMucNckh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.DinhMucNckh.ToString())];
			entity.HeSoLuongTangThem = (reader[DinhMucGioChuanColumn.HeSoLuongTangThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DinhMucGioChuanColumn.HeSoLuongTangThem.ToString())];
			entity.MaBacLuong = (reader[DinhMucGioChuanColumn.MaBacLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanColumn.MaBacLuong.ToString())];
			entity.DinhMucHoatDongChuyenMonKhac = (reader[DinhMucGioChuanColumn.DinhMucHoatDongChuyenMonKhac.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.DinhMucHoatDongChuyenMonKhac.ToString())];
			entity.NamHoc = (reader[DinhMucGioChuanColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanColumn.NamHoc.ToString())];
			entity.HocKy = (reader[DinhMucGioChuanColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanColumn.HocKy.ToString())];
			entity.NgayCapNhat = (reader[DinhMucGioChuanColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[DinhMucGioChuanColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanColumn.NguoiCapNhat.ToString())];
			entity.TongDinhMuc = (reader[DinhMucGioChuanColumn.TongDinhMuc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DinhMucGioChuanColumn.TongDinhMuc.ToString())];
			entity.HeSo = (reader[DinhMucGioChuanColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DinhMucGioChuanColumn.HeSo.ToString())];
			entity.PhanLoaiGiangVien = (reader[DinhMucGioChuanColumn.PhanLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(DinhMucGioChuanColumn.PhanLoaiGiangVien.ToString())];
			entity.TuHeSoLuong = (reader[DinhMucGioChuanColumn.TuHeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DinhMucGioChuanColumn.TuHeSoLuong.ToString())];
			entity.DenHeSoLuong = (reader[DinhMucGioChuanColumn.DenHeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DinhMucGioChuanColumn.DenHeSoLuong.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DinhMucGioChuan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DinhMucGioChuan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DinhMucGioChuan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaDinhMuc = (System.Int32)dataRow["MaDinhMuc"];
			entity.Stt = Convert.IsDBNull(dataRow["STT"]) ? null : (System.Int32?)dataRow["STT"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.DinhMucMonHoc = Convert.IsDBNull(dataRow["DinhMucMonHoc"]) ? null : (System.Int32?)dataRow["DinhMucMonHoc"];
			entity.DinhMucMonGdtcQp = Convert.IsDBNull(dataRow["DinhMucMonGdtcQp"]) ? null : (System.Int32?)dataRow["DinhMucMonGdtcQp"];
			entity.DinhMucNckh = Convert.IsDBNull(dataRow["DinhMucNckh"]) ? null : (System.Int32?)dataRow["DinhMucNckh"];
			entity.HeSoLuongTangThem = Convert.IsDBNull(dataRow["HeSoLuongTangThem"]) ? null : (System.Decimal?)dataRow["HeSoLuongTangThem"];
			entity.MaBacLuong = Convert.IsDBNull(dataRow["MaBacLuong"]) ? null : (System.String)dataRow["MaBacLuong"];
			entity.DinhMucHoatDongChuyenMonKhac = Convert.IsDBNull(dataRow["DinhMucHoatDongChuyenMonKhac"]) ? null : (System.Int32?)dataRow["DinhMucHoatDongChuyenMonKhac"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.TongDinhMuc = Convert.IsDBNull(dataRow["TongDinhMuc"]) ? null : (System.Int32?)dataRow["TongDinhMuc"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.PhanLoaiGiangVien = Convert.IsDBNull(dataRow["PhanLoaiGiangVien"]) ? null : (System.String)dataRow["PhanLoaiGiangVien"];
			entity.TuHeSoLuong = Convert.IsDBNull(dataRow["TuHeSoLuong"]) ? null : (System.Decimal?)dataRow["TuHeSoLuong"];
			entity.DenHeSoLuong = Convert.IsDBNull(dataRow["DenHeSoLuong"]) ? null : (System.Decimal?)dataRow["DenHeSoLuong"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DinhMucGioChuan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DinhMucGioChuan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DinhMucGioChuan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.DinhMucGioChuan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DinhMucGioChuan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DinhMucGioChuan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DinhMucGioChuan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region DinhMucGioChuanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DinhMucGioChuan</c>
	///</summary>
	public enum DinhMucGioChuanChildEntityTypes
	{
	}
	
	#endregion DinhMucGioChuanChildEntityTypes
	
	#region DinhMucGioChuanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DinhMucGioChuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucGioChuanFilterBuilder : SqlFilterBuilder<DinhMucGioChuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanFilterBuilder class.
		/// </summary>
		public DinhMucGioChuanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DinhMucGioChuanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DinhMucGioChuanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DinhMucGioChuanFilterBuilder
	
	#region DinhMucGioChuanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DinhMucGioChuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucGioChuanParameterBuilder : ParameterizedSqlFilterBuilder<DinhMucGioChuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanParameterBuilder class.
		/// </summary>
		public DinhMucGioChuanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DinhMucGioChuanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DinhMucGioChuanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DinhMucGioChuanParameterBuilder
	
	#region DinhMucGioChuanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DinhMucGioChuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucGioChuan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DinhMucGioChuanSortBuilder : SqlSortBuilder<DinhMucGioChuanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanSqlSortBuilder class.
		/// </summary>
		public DinhMucGioChuanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DinhMucGioChuanSortBuilder
	
} // end namespace
