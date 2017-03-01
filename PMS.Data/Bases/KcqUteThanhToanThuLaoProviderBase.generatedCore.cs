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
	/// This class is the base class for any <see cref="KcqUteThanhToanThuLaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqUteThanhToanThuLaoProviderBaseCore : EntityProviderBase<PMS.Entities.KcqUteThanhToanThuLao, PMS.Entities.KcqUteThanhToanThuLaoKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqUteThanhToanThuLaoKey key)
		{
			return Delete(transactionManager, key.IdKhoiLuongQuyDoi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_idKhoiLuongQuyDoi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _idKhoiLuongQuyDoi)
		{
			return Delete(null, _idKhoiLuongQuyDoi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idKhoiLuongQuyDoi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _idKhoiLuongQuyDoi);		
		
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
		public override PMS.Entities.KcqUteThanhToanThuLao Get(TransactionManager transactionManager, PMS.Entities.KcqUteThanhToanThuLaoKey key, int start, int pageLength)
		{
			return GetByIdKhoiLuongQuyDoi(transactionManager, key.IdKhoiLuongQuyDoi, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqUte_ThanhToanThuLao index.
		/// </summary>
		/// <param name="_idKhoiLuongQuyDoi"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KcqUteThanhToanThuLao GetByIdKhoiLuongQuyDoi(System.Int32 _idKhoiLuongQuyDoi)
		{
			int count = -1;
			return GetByIdKhoiLuongQuyDoi(null,_idKhoiLuongQuyDoi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_ThanhToanThuLao index.
		/// </summary>
		/// <param name="_idKhoiLuongQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KcqUteThanhToanThuLao GetByIdKhoiLuongQuyDoi(System.Int32 _idKhoiLuongQuyDoi, int start, int pageLength)
		{
			int count = -1;
			return GetByIdKhoiLuongQuyDoi(null, _idKhoiLuongQuyDoi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_ThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idKhoiLuongQuyDoi"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KcqUteThanhToanThuLao GetByIdKhoiLuongQuyDoi(TransactionManager transactionManager, System.Int32 _idKhoiLuongQuyDoi)
		{
			int count = -1;
			return GetByIdKhoiLuongQuyDoi(transactionManager, _idKhoiLuongQuyDoi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_ThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idKhoiLuongQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KcqUteThanhToanThuLao GetByIdKhoiLuongQuyDoi(TransactionManager transactionManager, System.Int32 _idKhoiLuongQuyDoi, int start, int pageLength)
		{
			int count = -1;
			return GetByIdKhoiLuongQuyDoi(transactionManager, _idKhoiLuongQuyDoi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_ThanhToanThuLao index.
		/// </summary>
		/// <param name="_idKhoiLuongQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KcqUteThanhToanThuLao GetByIdKhoiLuongQuyDoi(System.Int32 _idKhoiLuongQuyDoi, int start, int pageLength, out int count)
		{
			return GetByIdKhoiLuongQuyDoi(null, _idKhoiLuongQuyDoi, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqUte_ThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idKhoiLuongQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqUteThanhToanThuLao"/> class.</returns>
		public abstract PMS.Entities.KcqUteThanhToanThuLao GetByIdKhoiLuongQuyDoi(TransactionManager transactionManager, System.Int32 _idKhoiLuongQuyDoi, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KcqUte_ThanhToanThuLao_GetByNamHocHocKyDonViLoaiGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_ThanhToanThuLao_GetByNamHocHocKyDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqUteThanhToanThuLao&gt;"/> instance.</returns>
		public TList<KcqUteThanhToanThuLao> GetByNamHocHocKyDonViLoaiGiangVien(System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByNamHocHocKyDonViLoaiGiangVien(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_ThanhToanThuLao_GetByNamHocHocKyDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqUteThanhToanThuLao&gt;"/> instance.</returns>
		public TList<KcqUteThanhToanThuLao> GetByNamHocHocKyDonViLoaiGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByNamHocHocKyDonViLoaiGiangVien(null, start, pageLength , namHoc, hocKy, maDonVi, maLoaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqUte_ThanhToanThuLao_GetByNamHocHocKyDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqUteThanhToanThuLao&gt;"/> instance.</returns>
		public TList<KcqUteThanhToanThuLao> GetByNamHocHocKyDonViLoaiGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien)
		{
			return GetByNamHocHocKyDonViLoaiGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_ThanhToanThuLao_GetByNamHocHocKyDonViLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KcqUteThanhToanThuLao&gt;"/> instance.</returns>
		public abstract TList<KcqUteThanhToanThuLao> GetByNamHocHocKyDonViLoaiGiangVien(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.Int32 maLoaiGiangVien);
		
		#endregion
		
		#region cust_KcqUte_ThanhToanThuLao_ThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_ThanhToanThuLao_ThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ThanhToan(System.String namHoc, System.String hocKy)
		{
			 ThanhToan(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_ThanhToanThuLao_ThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ThanhToan(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 ThanhToan(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqUte_ThanhToanThuLao_ThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ThanhToan(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 ThanhToan(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqUte_ThanhToanThuLao_ThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ThanhToan(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqUteThanhToanThuLao&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqUteThanhToanThuLao&gt;"/></returns>
		public static TList<KcqUteThanhToanThuLao> Fill(IDataReader reader, TList<KcqUteThanhToanThuLao> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqUteThanhToanThuLao c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqUteThanhToanThuLao")
					.Append("|").Append((System.Int32)reader[((int)KcqUteThanhToanThuLaoColumn.IdKhoiLuongQuyDoi - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqUteThanhToanThuLao>(
					key.ToString(), // EntityTrackingKey
					"KcqUteThanhToanThuLao",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqUteThanhToanThuLao();
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
					c.IdKhoiLuongQuyDoi = (System.Int32)reader[(KcqUteThanhToanThuLaoColumn.IdKhoiLuongQuyDoi.ToString())];
					c.OriginalIdKhoiLuongQuyDoi = c.IdKhoiLuongQuyDoi;
					c.MaMonHoc = (reader[KcqUteThanhToanThuLaoColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[KcqUteThanhToanThuLaoColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.TenMonHoc.ToString())];
					c.NhomMonHoc = (reader[KcqUteThanhToanThuLaoColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.NhomMonHoc.ToString())];
					c.NamHoc = (reader[KcqUteThanhToanThuLaoColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.NamHoc.ToString())];
					c.HocKy = (reader[KcqUteThanhToanThuLaoColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.HocKy.ToString())];
					c.MaLopHocPhan = (reader[KcqUteThanhToanThuLaoColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.MaLopHocPhan.ToString())];
					c.Nhom = (reader[KcqUteThanhToanThuLaoColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.Nhom.ToString())];
					c.MaLop = (reader[KcqUteThanhToanThuLaoColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.MaLop.ToString())];
					c.SoTinChi = (reader[KcqUteThanhToanThuLaoColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.SoTinChi.ToString())];
					c.SoTiet = (reader[KcqUteThanhToanThuLaoColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.SoTiet.ToString())];
					c.SiSo = (reader[KcqUteThanhToanThuLaoColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.SiSo.ToString())];
					c.LopClc = (reader[KcqUteThanhToanThuLaoColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqUteThanhToanThuLaoColumn.LopClc.ToString())];
					c.SoTietDayChuNhat = (reader[KcqUteThanhToanThuLaoColumn.SoTietDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.SoTietDayChuNhat.ToString())];
					c.MaLoaiHocPhan = (reader[KcqUteThanhToanThuLaoColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.MaLoaiHocPhan.ToString())];
					c.HeSoLopDongLyThuyet = (reader[KcqUteThanhToanThuLaoColumn.HeSoLopDongLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.HeSoLopDongLyThuyet.ToString())];
					c.HeSoLopDongThTnTt = (reader[KcqUteThanhToanThuLaoColumn.HeSoLopDongThTnTt.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.HeSoLopDongThTnTt.ToString())];
					c.MaQuanLy = (reader[KcqUteThanhToanThuLaoColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.MaQuanLy.ToString())];
					c.Ho = (reader[KcqUteThanhToanThuLaoColumn.Ho.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.Ho.ToString())];
					c.Ten = (reader[KcqUteThanhToanThuLaoColumn.Ten.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.Ten.ToString())];
					c.HoTen = (reader[KcqUteThanhToanThuLaoColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.HoTen.ToString())];
					c.MaHocHam = (reader[KcqUteThanhToanThuLaoColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KcqUteThanhToanThuLaoColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[KcqUteThanhToanThuLaoColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.MaLoaiGiangVien.ToString())];
					c.MaDonVi = (reader[KcqUteThanhToanThuLaoColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.MaDonVi.ToString())];
					c.DonGia = (reader[KcqUteThanhToanThuLaoColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.DonGia.ToString())];
					c.TietQuyDoi = (reader[KcqUteThanhToanThuLaoColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.TietQuyDoi.ToString())];
					c.ThanhTienDayChuNhat = (reader[KcqUteThanhToanThuLaoColumn.ThanhTienDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.ThanhTienDayChuNhat.ToString())];
					c.ThanhTien = (reader[KcqUteThanhToanThuLaoColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.ThanhTien.ToString())];
					c.TongThanhTien = (reader[KcqUteThanhToanThuLaoColumn.TongThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.TongThanhTien.ToString())];
					c.NgayCapNhat = (reader[KcqUteThanhToanThuLaoColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqUteThanhToanThuLaoColumn.NgayCapNhat.ToString())];
					c.DaChot = (reader[KcqUteThanhToanThuLaoColumn.DaChot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqUteThanhToanThuLaoColumn.DaChot.ToString())];
					c.HeSoHocKy = (reader[KcqUteThanhToanThuLaoColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.HeSoHocKy.ToString())];
					c.SoGioThucGiangTrenLop = (reader[KcqUteThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString())];
					c.SoGioChuanTinhThem = (reader[KcqUteThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString())];
					c.MaDiaDiem = (reader[KcqUteThanhToanThuLaoColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.MaDiaDiem.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqUteThanhToanThuLao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqUteThanhToanThuLao"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqUteThanhToanThuLao entity)
		{
			if (!reader.Read()) return;
			
			entity.IdKhoiLuongQuyDoi = (System.Int32)reader[(KcqUteThanhToanThuLaoColumn.IdKhoiLuongQuyDoi.ToString())];
			entity.OriginalIdKhoiLuongQuyDoi = (System.Int32)reader["IdKhoiLuongQuyDoi"];
			entity.MaMonHoc = (reader[KcqUteThanhToanThuLaoColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[KcqUteThanhToanThuLaoColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.TenMonHoc.ToString())];
			entity.NhomMonHoc = (reader[KcqUteThanhToanThuLaoColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.NhomMonHoc.ToString())];
			entity.NamHoc = (reader[KcqUteThanhToanThuLaoColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KcqUteThanhToanThuLaoColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.HocKy.ToString())];
			entity.MaLopHocPhan = (reader[KcqUteThanhToanThuLaoColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.MaLopHocPhan.ToString())];
			entity.Nhom = (reader[KcqUteThanhToanThuLaoColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.Nhom.ToString())];
			entity.MaLop = (reader[KcqUteThanhToanThuLaoColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.MaLop.ToString())];
			entity.SoTinChi = (reader[KcqUteThanhToanThuLaoColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.SoTinChi.ToString())];
			entity.SoTiet = (reader[KcqUteThanhToanThuLaoColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.SoTiet.ToString())];
			entity.SiSo = (reader[KcqUteThanhToanThuLaoColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.SiSo.ToString())];
			entity.LopClc = (reader[KcqUteThanhToanThuLaoColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqUteThanhToanThuLaoColumn.LopClc.ToString())];
			entity.SoTietDayChuNhat = (reader[KcqUteThanhToanThuLaoColumn.SoTietDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.SoTietDayChuNhat.ToString())];
			entity.MaLoaiHocPhan = (reader[KcqUteThanhToanThuLaoColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.MaLoaiHocPhan.ToString())];
			entity.HeSoLopDongLyThuyet = (reader[KcqUteThanhToanThuLaoColumn.HeSoLopDongLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.HeSoLopDongLyThuyet.ToString())];
			entity.HeSoLopDongThTnTt = (reader[KcqUteThanhToanThuLaoColumn.HeSoLopDongThTnTt.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.HeSoLopDongThTnTt.ToString())];
			entity.MaQuanLy = (reader[KcqUteThanhToanThuLaoColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.MaQuanLy.ToString())];
			entity.Ho = (reader[KcqUteThanhToanThuLaoColumn.Ho.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.Ho.ToString())];
			entity.Ten = (reader[KcqUteThanhToanThuLaoColumn.Ten.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.Ten.ToString())];
			entity.HoTen = (reader[KcqUteThanhToanThuLaoColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.HoTen.ToString())];
			entity.MaHocHam = (reader[KcqUteThanhToanThuLaoColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KcqUteThanhToanThuLaoColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[KcqUteThanhToanThuLaoColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqUteThanhToanThuLaoColumn.MaLoaiGiangVien.ToString())];
			entity.MaDonVi = (reader[KcqUteThanhToanThuLaoColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.MaDonVi.ToString())];
			entity.DonGia = (reader[KcqUteThanhToanThuLaoColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.DonGia.ToString())];
			entity.TietQuyDoi = (reader[KcqUteThanhToanThuLaoColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.TietQuyDoi.ToString())];
			entity.ThanhTienDayChuNhat = (reader[KcqUteThanhToanThuLaoColumn.ThanhTienDayChuNhat.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.ThanhTienDayChuNhat.ToString())];
			entity.ThanhTien = (reader[KcqUteThanhToanThuLaoColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.ThanhTien.ToString())];
			entity.TongThanhTien = (reader[KcqUteThanhToanThuLaoColumn.TongThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.TongThanhTien.ToString())];
			entity.NgayCapNhat = (reader[KcqUteThanhToanThuLaoColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqUteThanhToanThuLaoColumn.NgayCapNhat.ToString())];
			entity.DaChot = (reader[KcqUteThanhToanThuLaoColumn.DaChot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqUteThanhToanThuLaoColumn.DaChot.ToString())];
			entity.HeSoHocKy = (reader[KcqUteThanhToanThuLaoColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.HeSoHocKy.ToString())];
			entity.SoGioThucGiangTrenLop = (reader[KcqUteThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString())];
			entity.SoGioChuanTinhThem = (reader[KcqUteThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqUteThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString())];
			entity.MaDiaDiem = (reader[KcqUteThanhToanThuLaoColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqUteThanhToanThuLaoColumn.MaDiaDiem.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqUteThanhToanThuLao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqUteThanhToanThuLao"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqUteThanhToanThuLao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.IdKhoiLuongQuyDoi = (System.Int32)dataRow["IdKhoiLuongQuyDoi"];
			entity.OriginalIdKhoiLuongQuyDoi = (System.Int32)dataRow["IdKhoiLuongQuyDoi"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.NhomMonHoc = Convert.IsDBNull(dataRow["NhomMonHoc"]) ? null : (System.String)dataRow["NhomMonHoc"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Int32?)dataRow["SoTiet"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.LopClc = Convert.IsDBNull(dataRow["LopClc"]) ? null : (System.Boolean?)dataRow["LopClc"];
			entity.SoTietDayChuNhat = Convert.IsDBNull(dataRow["SoTietDayChuNhat"]) ? null : (System.Int32?)dataRow["SoTietDayChuNhat"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.HeSoLopDongLyThuyet = Convert.IsDBNull(dataRow["HeSoLopDongLyThuyet"]) ? null : (System.Decimal?)dataRow["HeSoLopDongLyThuyet"];
			entity.HeSoLopDongThTnTt = Convert.IsDBNull(dataRow["HeSoLopDongThTnTt"]) ? null : (System.Decimal?)dataRow["HeSoLopDongThTnTt"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.Ho = Convert.IsDBNull(dataRow["Ho"]) ? null : (System.String)dataRow["Ho"];
			entity.Ten = Convert.IsDBNull(dataRow["Ten"]) ? null : (System.String)dataRow["Ten"];
			entity.HoTen = Convert.IsDBNull(dataRow["HoTen"]) ? null : (System.String)dataRow["HoTen"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.String)dataRow["MaDonVi"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.ThanhTienDayChuNhat = Convert.IsDBNull(dataRow["ThanhTienDayChuNhat"]) ? null : (System.Decimal?)dataRow["ThanhTienDayChuNhat"];
			entity.ThanhTien = Convert.IsDBNull(dataRow["ThanhTien"]) ? null : (System.Decimal?)dataRow["ThanhTien"];
			entity.TongThanhTien = Convert.IsDBNull(dataRow["TongThanhTien"]) ? null : (System.Decimal?)dataRow["TongThanhTien"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.DaChot = Convert.IsDBNull(dataRow["DaChot"]) ? null : (System.Boolean?)dataRow["DaChot"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
			entity.SoGioThucGiangTrenLop = Convert.IsDBNull(dataRow["SoGioThucGiangTrenLop"]) ? null : (System.Decimal?)dataRow["SoGioThucGiangTrenLop"];
			entity.SoGioChuanTinhThem = Convert.IsDBNull(dataRow["SoGioChuanTinhThem"]) ? null : (System.Decimal?)dataRow["SoGioChuanTinhThem"];
			entity.MaDiaDiem = Convert.IsDBNull(dataRow["MaDiaDiem"]) ? null : (System.String)dataRow["MaDiaDiem"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqUteThanhToanThuLao"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqUteThanhToanThuLao Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqUteThanhToanThuLao entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region IdKhoiLuongQuyDoiSource	
			if (CanDeepLoad(entity, "KcqUteKhoiLuongQuyDoi|IdKhoiLuongQuyDoiSource", deepLoadType, innerList) 
				&& entity.IdKhoiLuongQuyDoiSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.IdKhoiLuongQuyDoi;
				KcqUteKhoiLuongQuyDoi tmpEntity = EntityManager.LocateEntity<KcqUteKhoiLuongQuyDoi>(EntityLocator.ConstructKeyFromPkItems(typeof(KcqUteKhoiLuongQuyDoi), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.IdKhoiLuongQuyDoiSource = tmpEntity;
				else
					entity.IdKhoiLuongQuyDoiSource = DataRepository.KcqUteKhoiLuongQuyDoiProvider.GetById(transactionManager, entity.IdKhoiLuongQuyDoi);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'IdKhoiLuongQuyDoiSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.IdKhoiLuongQuyDoiSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.KcqUteKhoiLuongQuyDoiProvider.DeepLoad(transactionManager, entity.IdKhoiLuongQuyDoiSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion IdKhoiLuongQuyDoiSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqUteThanhToanThuLao object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqUteThanhToanThuLao instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqUteThanhToanThuLao Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqUteThanhToanThuLao entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region IdKhoiLuongQuyDoiSource
			if (CanDeepSave(entity, "KcqUteKhoiLuongQuyDoi|IdKhoiLuongQuyDoiSource", deepSaveType, innerList) 
				&& entity.IdKhoiLuongQuyDoiSource != null)
			{
				DataRepository.KcqUteKhoiLuongQuyDoiProvider.Save(transactionManager, entity.IdKhoiLuongQuyDoiSource);
				entity.IdKhoiLuongQuyDoi = entity.IdKhoiLuongQuyDoiSource.Id;
			}
			#endregion 
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
	
	#region KcqUteThanhToanThuLaoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqUteThanhToanThuLao</c>
	///</summary>
	public enum KcqUteThanhToanThuLaoChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>KcqUteKhoiLuongQuyDoi</c> at IdKhoiLuongQuyDoiSource
		///</summary>
		[ChildEntityType(typeof(KcqUteKhoiLuongQuyDoi))]
		KcqUteKhoiLuongQuyDoi,
	}
	
	#endregion KcqUteThanhToanThuLaoChildEntityTypes
	
	#region KcqUteThanhToanThuLaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqUteThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqUteThanhToanThuLaoFilterBuilder : SqlFilterBuilder<KcqUteThanhToanThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqUteThanhToanThuLaoFilterBuilder class.
		/// </summary>
		public KcqUteThanhToanThuLaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqUteThanhToanThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqUteThanhToanThuLaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqUteThanhToanThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqUteThanhToanThuLaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqUteThanhToanThuLaoFilterBuilder
	
	#region KcqUteThanhToanThuLaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqUteThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqUteThanhToanThuLaoParameterBuilder : ParameterizedSqlFilterBuilder<KcqUteThanhToanThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqUteThanhToanThuLaoParameterBuilder class.
		/// </summary>
		public KcqUteThanhToanThuLaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqUteThanhToanThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqUteThanhToanThuLaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqUteThanhToanThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqUteThanhToanThuLaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqUteThanhToanThuLaoParameterBuilder
	
	#region KcqUteThanhToanThuLaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqUteThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteThanhToanThuLao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqUteThanhToanThuLaoSortBuilder : SqlSortBuilder<KcqUteThanhToanThuLaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqUteThanhToanThuLaoSqlSortBuilder class.
		/// </summary>
		public KcqUteThanhToanThuLaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqUteThanhToanThuLaoSortBuilder
	
} // end namespace
