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
	/// This class is the base class for any <see cref="GiangVienTamUngChiTietProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienTamUngChiTietProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienTamUngChiTiet, PMS.Entities.GiangVienTamUngChiTietKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienTamUngChiTietKey key)
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
		public override PMS.Entities.GiangVienTamUngChiTiet Get(TransactionManager transactionManager, PMS.Entities.GiangVienTamUngChiTietKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiangVienTamUngChiTiet index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTamUngChiTiet"/> class.</returns>
		public PMS.Entities.GiangVienTamUngChiTiet GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienTamUngChiTiet index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTamUngChiTiet"/> class.</returns>
		public PMS.Entities.GiangVienTamUngChiTiet GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienTamUngChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTamUngChiTiet"/> class.</returns>
		public PMS.Entities.GiangVienTamUngChiTiet GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienTamUngChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTamUngChiTiet"/> class.</returns>
		public PMS.Entities.GiangVienTamUngChiTiet GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienTamUngChiTiet index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTamUngChiTiet"/> class.</returns>
		public PMS.Entities.GiangVienTamUngChiTiet GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienTamUngChiTiet index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTamUngChiTiet"/> class.</returns>
		public abstract PMS.Entities.GiangVienTamUngChiTiet GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVienTamUngChiTiet_GetTamUngByNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUngChiTiet_GetTamUngByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTamUngByNamHoc(System.String namHoc)
		{
			return GetTamUngByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUngChiTiet_GetTamUngByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTamUngByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return GetTamUngByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUngChiTiet_GetTamUngByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetTamUngByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return GetTamUngByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUngChiTiet_GetTamUngByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetTamUngByNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_GiangVienTamUngChiTiet_LuuTamUng 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUngChiTiet_LuuTamUng' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTamUng(System.String xmlData, System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String khoaDonVi, System.String loaiGiangVien, ref System.Int32 reVal)
		{
			 LuuTamUng(null, 0, int.MaxValue , xmlData, namHoc, hocKy, bacDaoTao, khoaDonVi, loaiGiangVien, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUngChiTiet_LuuTamUng' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTamUng(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String khoaDonVi, System.String loaiGiangVien, ref System.Int32 reVal)
		{
			 LuuTamUng(null, start, pageLength , xmlData, namHoc, hocKy, bacDaoTao, khoaDonVi, loaiGiangVien, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUngChiTiet_LuuTamUng' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTamUng(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String khoaDonVi, System.String loaiGiangVien, ref System.Int32 reVal)
		{
			 LuuTamUng(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, bacDaoTao, khoaDonVi, loaiGiangVien, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUngChiTiet_LuuTamUng' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuTamUng(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String khoaDonVi, System.String loaiGiangVien, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienTamUngChiTiet&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienTamUngChiTiet&gt;"/></returns>
		public static TList<GiangVienTamUngChiTiet> Fill(IDataReader reader, TList<GiangVienTamUngChiTiet> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienTamUngChiTiet c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienTamUngChiTiet")
					.Append("|").Append((System.Int32)reader[((int)GiangVienTamUngChiTietColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienTamUngChiTiet>(
					key.ToString(), // EntityTrackingKey
					"GiangVienTamUngChiTiet",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienTamUngChiTiet();
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
					c.Id = (System.Int32)reader[(GiangVienTamUngChiTietColumn.Id.ToString())];
					c.MaGiangVien = (reader[GiangVienTamUngChiTietColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngChiTietColumn.MaGiangVien.ToString())];
					c.MaLopHocPhan = (reader[GiangVienTamUngChiTietColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaLopHocPhan.ToString())];
					c.NamHoc = (reader[GiangVienTamUngChiTietColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.NamHoc.ToString())];
					c.HocKy = (reader[GiangVienTamUngChiTietColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.HocKy.ToString())];
					c.MaMonHoc = (reader[GiangVienTamUngChiTietColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[GiangVienTamUngChiTietColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.TenMonHoc.ToString())];
					c.Nhom = (reader[GiangVienTamUngChiTietColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.Nhom.ToString())];
					c.SoTinChi = (reader[GiangVienTamUngChiTietColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.SoTinChi.ToString())];
					c.SiSo = (reader[GiangVienTamUngChiTietColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngChiTietColumn.SiSo.ToString())];
					c.MaLoaiHocPhan = (reader[GiangVienTamUngChiTietColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(GiangVienTamUngChiTietColumn.MaLoaiHocPhan.ToString())];
					c.LoaiHocPhan = (reader[GiangVienTamUngChiTietColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.LoaiHocPhan.ToString())];
					c.MaLop = (reader[GiangVienTamUngChiTietColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaLop.ToString())];
					c.SoTietThucDay = (reader[GiangVienTamUngChiTietColumn.SoTietThucDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.SoTietThucDay.ToString())];
					c.MaBacDaoTao = (reader[GiangVienTamUngChiTietColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaBacDaoTao.ToString())];
					c.MaKhoa = (reader[GiangVienTamUngChiTietColumn.MaKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaKhoa.ToString())];
					c.MaNhomMonHoc = (reader[GiangVienTamUngChiTietColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaNhomMonHoc.ToString())];
					c.MaKhoaHoc = (reader[GiangVienTamUngChiTietColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaKhoaHoc.ToString())];
					c.MaHocHam = (reader[GiangVienTamUngChiTietColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngChiTietColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[GiangVienTamUngChiTietColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngChiTietColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[GiangVienTamUngChiTietColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngChiTietColumn.MaLoaiGiangVien.ToString())];
					c.MaChucVu = (reader[GiangVienTamUngChiTietColumn.MaChucVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngChiTietColumn.MaChucVu.ToString())];
					c.MaHinhThucDaoTao = (reader[GiangVienTamUngChiTietColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaHinhThucDaoTao.ToString())];
					c.LopHocPhanChuyenNganh = (reader[GiangVienTamUngChiTietColumn.LopHocPhanChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienTamUngChiTietColumn.LopHocPhanChuyenNganh.ToString())];
					c.DaoTaoTinChi = (reader[GiangVienTamUngChiTietColumn.DaoTaoTinChi.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienTamUngChiTietColumn.DaoTaoTinChi.ToString())];
					c.HeSoCongViec = (reader[GiangVienTamUngChiTietColumn.HeSoCongViec.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoCongViec.ToString())];
					c.HeSoBacDaoTao = (reader[GiangVienTamUngChiTietColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoBacDaoTao.ToString())];
					c.HeSoNgonNgu = (reader[GiangVienTamUngChiTietColumn.HeSoNgonNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoNgonNgu.ToString())];
					c.HeSoChucDanhChuyenMon = (reader[GiangVienTamUngChiTietColumn.HeSoChucDanhChuyenMon.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoChucDanhChuyenMon.ToString())];
					c.HeSoLopDong = (reader[GiangVienTamUngChiTietColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoLopDong.ToString())];
					c.HeSoCoSo = (reader[GiangVienTamUngChiTietColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoCoSo.ToString())];
					c.HeSoNienCheTinChi = (reader[GiangVienTamUngChiTietColumn.HeSoNienCheTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoNienCheTinChi.ToString())];
					c.SoTietThucTeQuyDoi = (reader[GiangVienTamUngChiTietColumn.SoTietThucTeQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.SoTietThucTeQuyDoi.ToString())];
					c.TietQuyDoi = (reader[GiangVienTamUngChiTietColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.TietQuyDoi.ToString())];
					c.HeSoQuyDoiThucHanhSangLyThuyet = (reader[GiangVienTamUngChiTietColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString())];
					c.HeSoNgoaiGio = (reader[GiangVienTamUngChiTietColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoNgoaiGio.ToString())];
					c.LoaiLop = (reader[GiangVienTamUngChiTietColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.LoaiLop.ToString())];
					c.HeSoClcCntn = (reader[GiangVienTamUngChiTietColumn.HeSoClcCntn.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoClcCntn.ToString())];
					c.HeSoThinhGiangMonChuyenNganh = (reader[GiangVienTamUngChiTietColumn.HeSoThinhGiangMonChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoThinhGiangMonChuyenNganh.ToString())];
					c.NgonNguGiangDay = (reader[GiangVienTamUngChiTietColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.NgonNguGiangDay.ToString())];
					c.HeSoTroCap = (reader[GiangVienTamUngChiTietColumn.HeSoTroCap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoTroCap.ToString())];
					c.HeSoLuong = (reader[GiangVienTamUngChiTietColumn.HeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoLuong.ToString())];
					c.HeSoMonMoi = (reader[GiangVienTamUngChiTietColumn.HeSoMonMoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoMonMoi.ToString())];
					c.DonGia = (reader[GiangVienTamUngChiTietColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.DonGia.ToString())];
					c.ThanhTien = (reader[GiangVienTamUngChiTietColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.ThanhTien.ToString())];
					c.GhiChu = (reader[GiangVienTamUngChiTietColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.GhiChu.ToString())];
					c.MucThanhToan = (reader[GiangVienTamUngChiTietColumn.MucThanhToan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.MucThanhToan.ToString())];
					c.NgayTamUng = (reader[GiangVienTamUngChiTietColumn.NgayTamUng.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienTamUngChiTietColumn.NgayTamUng.ToString())];
					c.DotTamUng = (reader[GiangVienTamUngChiTietColumn.DotTamUng.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.DotTamUng.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienTamUngChiTiet"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienTamUngChiTiet"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienTamUngChiTiet entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(GiangVienTamUngChiTietColumn.Id.ToString())];
			entity.MaGiangVien = (reader[GiangVienTamUngChiTietColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngChiTietColumn.MaGiangVien.ToString())];
			entity.MaLopHocPhan = (reader[GiangVienTamUngChiTietColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaLopHocPhan.ToString())];
			entity.NamHoc = (reader[GiangVienTamUngChiTietColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.NamHoc.ToString())];
			entity.HocKy = (reader[GiangVienTamUngChiTietColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.HocKy.ToString())];
			entity.MaMonHoc = (reader[GiangVienTamUngChiTietColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[GiangVienTamUngChiTietColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.TenMonHoc.ToString())];
			entity.Nhom = (reader[GiangVienTamUngChiTietColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.Nhom.ToString())];
			entity.SoTinChi = (reader[GiangVienTamUngChiTietColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.SoTinChi.ToString())];
			entity.SiSo = (reader[GiangVienTamUngChiTietColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngChiTietColumn.SiSo.ToString())];
			entity.MaLoaiHocPhan = (reader[GiangVienTamUngChiTietColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(GiangVienTamUngChiTietColumn.MaLoaiHocPhan.ToString())];
			entity.LoaiHocPhan = (reader[GiangVienTamUngChiTietColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.LoaiHocPhan.ToString())];
			entity.MaLop = (reader[GiangVienTamUngChiTietColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaLop.ToString())];
			entity.SoTietThucDay = (reader[GiangVienTamUngChiTietColumn.SoTietThucDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.SoTietThucDay.ToString())];
			entity.MaBacDaoTao = (reader[GiangVienTamUngChiTietColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaBacDaoTao.ToString())];
			entity.MaKhoa = (reader[GiangVienTamUngChiTietColumn.MaKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaKhoa.ToString())];
			entity.MaNhomMonHoc = (reader[GiangVienTamUngChiTietColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaNhomMonHoc.ToString())];
			entity.MaKhoaHoc = (reader[GiangVienTamUngChiTietColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaKhoaHoc.ToString())];
			entity.MaHocHam = (reader[GiangVienTamUngChiTietColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngChiTietColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[GiangVienTamUngChiTietColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngChiTietColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[GiangVienTamUngChiTietColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngChiTietColumn.MaLoaiGiangVien.ToString())];
			entity.MaChucVu = (reader[GiangVienTamUngChiTietColumn.MaChucVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngChiTietColumn.MaChucVu.ToString())];
			entity.MaHinhThucDaoTao = (reader[GiangVienTamUngChiTietColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.MaHinhThucDaoTao.ToString())];
			entity.LopHocPhanChuyenNganh = (reader[GiangVienTamUngChiTietColumn.LopHocPhanChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienTamUngChiTietColumn.LopHocPhanChuyenNganh.ToString())];
			entity.DaoTaoTinChi = (reader[GiangVienTamUngChiTietColumn.DaoTaoTinChi.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(GiangVienTamUngChiTietColumn.DaoTaoTinChi.ToString())];
			entity.HeSoCongViec = (reader[GiangVienTamUngChiTietColumn.HeSoCongViec.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoCongViec.ToString())];
			entity.HeSoBacDaoTao = (reader[GiangVienTamUngChiTietColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoBacDaoTao.ToString())];
			entity.HeSoNgonNgu = (reader[GiangVienTamUngChiTietColumn.HeSoNgonNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoNgonNgu.ToString())];
			entity.HeSoChucDanhChuyenMon = (reader[GiangVienTamUngChiTietColumn.HeSoChucDanhChuyenMon.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoChucDanhChuyenMon.ToString())];
			entity.HeSoLopDong = (reader[GiangVienTamUngChiTietColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoLopDong.ToString())];
			entity.HeSoCoSo = (reader[GiangVienTamUngChiTietColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoCoSo.ToString())];
			entity.HeSoNienCheTinChi = (reader[GiangVienTamUngChiTietColumn.HeSoNienCheTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoNienCheTinChi.ToString())];
			entity.SoTietThucTeQuyDoi = (reader[GiangVienTamUngChiTietColumn.SoTietThucTeQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.SoTietThucTeQuyDoi.ToString())];
			entity.TietQuyDoi = (reader[GiangVienTamUngChiTietColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.TietQuyDoi.ToString())];
			entity.HeSoQuyDoiThucHanhSangLyThuyet = (reader[GiangVienTamUngChiTietColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString())];
			entity.HeSoNgoaiGio = (reader[GiangVienTamUngChiTietColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoNgoaiGio.ToString())];
			entity.LoaiLop = (reader[GiangVienTamUngChiTietColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.LoaiLop.ToString())];
			entity.HeSoClcCntn = (reader[GiangVienTamUngChiTietColumn.HeSoClcCntn.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoClcCntn.ToString())];
			entity.HeSoThinhGiangMonChuyenNganh = (reader[GiangVienTamUngChiTietColumn.HeSoThinhGiangMonChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoThinhGiangMonChuyenNganh.ToString())];
			entity.NgonNguGiangDay = (reader[GiangVienTamUngChiTietColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.NgonNguGiangDay.ToString())];
			entity.HeSoTroCap = (reader[GiangVienTamUngChiTietColumn.HeSoTroCap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoTroCap.ToString())];
			entity.HeSoLuong = (reader[GiangVienTamUngChiTietColumn.HeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoLuong.ToString())];
			entity.HeSoMonMoi = (reader[GiangVienTamUngChiTietColumn.HeSoMonMoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.HeSoMonMoi.ToString())];
			entity.DonGia = (reader[GiangVienTamUngChiTietColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.DonGia.ToString())];
			entity.ThanhTien = (reader[GiangVienTamUngChiTietColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.ThanhTien.ToString())];
			entity.GhiChu = (reader[GiangVienTamUngChiTietColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.GhiChu.ToString())];
			entity.MucThanhToan = (reader[GiangVienTamUngChiTietColumn.MucThanhToan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngChiTietColumn.MucThanhToan.ToString())];
			entity.NgayTamUng = (reader[GiangVienTamUngChiTietColumn.NgayTamUng.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienTamUngChiTietColumn.NgayTamUng.ToString())];
			entity.DotTamUng = (reader[GiangVienTamUngChiTietColumn.DotTamUng.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngChiTietColumn.DotTamUng.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienTamUngChiTiet"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienTamUngChiTiet"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienTamUngChiTiet entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Decimal?)dataRow["SoTinChi"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.Byte?)dataRow["MaLoaiHocPhan"];
			entity.LoaiHocPhan = Convert.IsDBNull(dataRow["LoaiHocPhan"]) ? null : (System.String)dataRow["LoaiHocPhan"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.SoTietThucDay = Convert.IsDBNull(dataRow["SoTietThucDay"]) ? null : (System.Decimal?)dataRow["SoTietThucDay"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.MaKhoa = Convert.IsDBNull(dataRow["MaKhoa"]) ? null : (System.String)dataRow["MaKhoa"];
			entity.MaNhomMonHoc = Convert.IsDBNull(dataRow["MaNhomMonHoc"]) ? null : (System.String)dataRow["MaNhomMonHoc"];
			entity.MaKhoaHoc = Convert.IsDBNull(dataRow["MaKhoaHoc"]) ? null : (System.String)dataRow["MaKhoaHoc"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaChucVu = Convert.IsDBNull(dataRow["MaChucVu"]) ? null : (System.Int32?)dataRow["MaChucVu"];
			entity.MaHinhThucDaoTao = Convert.IsDBNull(dataRow["MaHinhThucDaoTao"]) ? null : (System.String)dataRow["MaHinhThucDaoTao"];
			entity.LopHocPhanChuyenNganh = Convert.IsDBNull(dataRow["LopHocPhanChuyenNganh"]) ? null : (System.Boolean?)dataRow["LopHocPhanChuyenNganh"];
			entity.DaoTaoTinChi = Convert.IsDBNull(dataRow["DaoTaoTinChi"]) ? null : (System.Boolean?)dataRow["DaoTaoTinChi"];
			entity.HeSoCongViec = Convert.IsDBNull(dataRow["HeSoCongViec"]) ? null : (System.Decimal?)dataRow["HeSoCongViec"];
			entity.HeSoBacDaoTao = Convert.IsDBNull(dataRow["HeSoBacDaoTao"]) ? null : (System.Decimal?)dataRow["HeSoBacDaoTao"];
			entity.HeSoNgonNgu = Convert.IsDBNull(dataRow["HeSoNgonNgu"]) ? null : (System.Decimal?)dataRow["HeSoNgonNgu"];
			entity.HeSoChucDanhChuyenMon = Convert.IsDBNull(dataRow["HeSoChucDanhChuyenMon"]) ? null : (System.Decimal?)dataRow["HeSoChucDanhChuyenMon"];
			entity.HeSoLopDong = Convert.IsDBNull(dataRow["HeSoLopDong"]) ? null : (System.Decimal?)dataRow["HeSoLopDong"];
			entity.HeSoCoSo = Convert.IsDBNull(dataRow["HeSoCoSo"]) ? null : (System.Decimal?)dataRow["HeSoCoSo"];
			entity.HeSoNienCheTinChi = Convert.IsDBNull(dataRow["HeSoNienCheTinChi"]) ? null : (System.Decimal?)dataRow["HeSoNienCheTinChi"];
			entity.SoTietThucTeQuyDoi = Convert.IsDBNull(dataRow["SoTietThucTeQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietThucTeQuyDoi"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.HeSoQuyDoiThucHanhSangLyThuyet = Convert.IsDBNull(dataRow["HeSoQuyDoiThucHanhSangLyThuyet"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoiThucHanhSangLyThuyet"];
			entity.HeSoNgoaiGio = Convert.IsDBNull(dataRow["HeSoNgoaiGio"]) ? null : (System.Decimal?)dataRow["HeSoNgoaiGio"];
			entity.LoaiLop = Convert.IsDBNull(dataRow["LoaiLop"]) ? null : (System.String)dataRow["LoaiLop"];
			entity.HeSoClcCntn = Convert.IsDBNull(dataRow["HeSoClcCntn"]) ? null : (System.Decimal?)dataRow["HeSoClcCntn"];
			entity.HeSoThinhGiangMonChuyenNganh = Convert.IsDBNull(dataRow["HeSoThinhGiangMonChuyenNganh"]) ? null : (System.Decimal?)dataRow["HeSoThinhGiangMonChuyenNganh"];
			entity.NgonNguGiangDay = Convert.IsDBNull(dataRow["NgonNguGiangDay"]) ? null : (System.String)dataRow["NgonNguGiangDay"];
			entity.HeSoTroCap = Convert.IsDBNull(dataRow["HeSoTroCap"]) ? null : (System.Decimal?)dataRow["HeSoTroCap"];
			entity.HeSoLuong = Convert.IsDBNull(dataRow["HeSoLuong"]) ? null : (System.Decimal?)dataRow["HeSoLuong"];
			entity.HeSoMonMoi = Convert.IsDBNull(dataRow["HeSoMonMoi"]) ? null : (System.Decimal?)dataRow["HeSoMonMoi"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.ThanhTien = Convert.IsDBNull(dataRow["ThanhTien"]) ? null : (System.Decimal?)dataRow["ThanhTien"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.MucThanhToan = Convert.IsDBNull(dataRow["MucThanhToan"]) ? null : (System.Decimal?)dataRow["MucThanhToan"];
			entity.NgayTamUng = Convert.IsDBNull(dataRow["NgayTamUng"]) ? null : (System.DateTime?)dataRow["NgayTamUng"];
			entity.DotTamUng = Convert.IsDBNull(dataRow["DotTamUng"]) ? null : (System.String)dataRow["DotTamUng"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienTamUngChiTiet"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienTamUngChiTiet Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienTamUngChiTiet entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienTamUngChiTiet object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienTamUngChiTiet instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienTamUngChiTiet Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienTamUngChiTiet entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GiangVienTamUngChiTietChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienTamUngChiTiet</c>
	///</summary>
	public enum GiangVienTamUngChiTietChildEntityTypes
	{
	}
	
	#endregion GiangVienTamUngChiTietChildEntityTypes
	
	#region GiangVienTamUngChiTietFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienTamUngChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTamUngChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTamUngChiTietFilterBuilder : SqlFilterBuilder<GiangVienTamUngChiTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngChiTietFilterBuilder class.
		/// </summary>
		public GiangVienTamUngChiTietFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngChiTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienTamUngChiTietFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngChiTietFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienTamUngChiTietFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienTamUngChiTietFilterBuilder
	
	#region GiangVienTamUngChiTietParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienTamUngChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTamUngChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTamUngChiTietParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienTamUngChiTietColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngChiTietParameterBuilder class.
		/// </summary>
		public GiangVienTamUngChiTietParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngChiTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienTamUngChiTietParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngChiTietParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienTamUngChiTietParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienTamUngChiTietParameterBuilder
	
	#region GiangVienTamUngChiTietSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienTamUngChiTietColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTamUngChiTiet"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienTamUngChiTietSortBuilder : SqlSortBuilder<GiangVienTamUngChiTietColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngChiTietSqlSortBuilder class.
		/// </summary>
		public GiangVienTamUngChiTietSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienTamUngChiTietSortBuilder
	
} // end namespace
