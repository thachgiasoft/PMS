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
	/// This class is the base class for any <see cref="HeSoLopDongProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HeSoLopDongProviderBaseCore : EntityProviderBase<PMS.Entities.HeSoLopDong, PMS.Entities.HeSoLopDongKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HeSoLopDongKey key)
		{
			return Delete(transactionManager, key.MaHeSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maHeSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maHeSo)
		{
			return Delete(null, _maHeSo);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maHeSo);		
		
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
		public override PMS.Entities.HeSoLopDong Get(TransactionManager transactionManager, PMS.Entities.HeSoLopDongKey key, int start, int pageLength)
		{
			return GetByMaHeSo(transactionManager, key.MaHeSo, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HeSoLopDong index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoLopDong"/> class.</returns>
		public PMS.Entities.HeSoLopDong GetByMaHeSo(System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(null,_maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoLopDong index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoLopDong"/> class.</returns>
		public PMS.Entities.HeSoLopDong GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoLopDong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoLopDong"/> class.</returns>
		public PMS.Entities.HeSoLopDong GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoLopDong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoLopDong"/> class.</returns>
		public PMS.Entities.HeSoLopDong GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength)
		{
			int count = -1;
			return GetByMaHeSo(transactionManager, _maHeSo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoLopDong index.
		/// </summary>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoLopDong"/> class.</returns>
		public PMS.Entities.HeSoLopDong GetByMaHeSo(System.Int32 _maHeSo, int start, int pageLength, out int count)
		{
			return GetByMaHeSo(null, _maHeSo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HeSoLopDong index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maHeSo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HeSoLopDong"/> class.</returns>
		public abstract PMS.Entities.HeSoLopDong GetByMaHeSo(TransactionManager transactionManager, System.Int32 _maHeSo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HeSoLopDong_GetBySiSo 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSo' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetBySiSo(System.Int32 siSo)
		{
			return GetBySiSo(null, 0, int.MaxValue , siSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSo' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetBySiSo(int start, int pageLength, System.Int32 siSo)
		{
			return GetBySiSo(null, start, pageLength , siSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSo' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetBySiSo(TransactionManager transactionManager, System.Int32 siSo)
		{
			return GetBySiSo(transactionManager, 0, int.MaxValue , siSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSo' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public abstract TList<HeSoLopDong> GetBySiSo(TransactionManager transactionManager, int start, int pageLength , System.Int32 siSo);
		
		#endregion
		
		#region cust_HeSoLopDong_GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay(System.String maBacDaoTao, System.Int32 siSo, System.String maNhomMonHoc, System.String loaiHocPhan, System.DateTime ngayDay)
		{
			return GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay(null, 0, int.MaxValue , maBacDaoTao, siSo, maNhomMonHoc, loaiHocPhan, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay(int start, int pageLength, System.String maBacDaoTao, System.Int32 siSo, System.String maNhomMonHoc, System.String loaiHocPhan, System.DateTime ngayDay)
		{
			return GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay(null, start, pageLength , maBacDaoTao, siSo, maNhomMonHoc, loaiHocPhan, ngayDay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay(TransactionManager transactionManager, System.String maBacDaoTao, System.Int32 siSo, System.String maNhomMonHoc, System.String loaiHocPhan, System.DateTime ngayDay)
		{
			return GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay(transactionManager, 0, int.MaxValue , maBacDaoTao, siSo, maNhomMonHoc, loaiHocPhan, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public abstract TList<HeSoLopDong> GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay(TransactionManager transactionManager, int start, int pageLength , System.String maBacDaoTao, System.Int32 siSo, System.String maNhomMonHoc, System.String loaiHocPhan, System.DateTime ngayDay);
		
		#endregion
		
		#region cust_HeSoLopDong_GetByNamHocHocKyBacDaoTaoNhomMonHocLoaiKhoiLuongSiSo 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyBacDaoTaoNhomMonHocLoaiKhoiLuongSiSo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiKhoiLuong"> A <c>System.Int32</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKyBacDaoTaoNhomMonHocLoaiKhoiLuongSiSo(System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String nhomMonHoc, System.Int32 loaiKhoiLuong, System.Int32 siSo, ref System.Double heSo)
		{
			 GetByNamHocHocKyBacDaoTaoNhomMonHocLoaiKhoiLuongSiSo(null, 0, int.MaxValue , namHoc, hocKy, bacDaoTao, nhomMonHoc, loaiKhoiLuong, siSo, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyBacDaoTaoNhomMonHocLoaiKhoiLuongSiSo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiKhoiLuong"> A <c>System.Int32</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKyBacDaoTaoNhomMonHocLoaiKhoiLuongSiSo(int start, int pageLength, System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String nhomMonHoc, System.Int32 loaiKhoiLuong, System.Int32 siSo, ref System.Double heSo)
		{
			 GetByNamHocHocKyBacDaoTaoNhomMonHocLoaiKhoiLuongSiSo(null, start, pageLength , namHoc, hocKy, bacDaoTao, nhomMonHoc, loaiKhoiLuong, siSo, ref heSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyBacDaoTaoNhomMonHocLoaiKhoiLuongSiSo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiKhoiLuong"> A <c>System.Int32</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKyBacDaoTaoNhomMonHocLoaiKhoiLuongSiSo(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String nhomMonHoc, System.Int32 loaiKhoiLuong, System.Int32 siSo, ref System.Double heSo)
		{
			 GetByNamHocHocKyBacDaoTaoNhomMonHocLoaiKhoiLuongSiSo(transactionManager, 0, int.MaxValue , namHoc, hocKy, bacDaoTao, nhomMonHoc, loaiKhoiLuong, siSo, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyBacDaoTaoNhomMonHocLoaiKhoiLuongSiSo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="loaiKhoiLuong"> A <c>System.Int32</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByNamHocHocKyBacDaoTaoNhomMonHocLoaiKhoiLuongSiSo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String nhomMonHoc, System.Int32 loaiKhoiLuong, System.Int32 siSo, ref System.Double heSo);
		
		#endregion
		
		#region cust_HeSoLopDong_GetByNamHocHocKyLoaiKhoiLuong 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetByNamHocHocKyLoaiKhoiLuong(System.String namHoc, System.String hocKy, System.String maLoaiKhoiLuong)
		{
			return GetByNamHocHocKyLoaiKhoiLuong(null, 0, int.MaxValue , namHoc, hocKy, maLoaiKhoiLuong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetByNamHocHocKyLoaiKhoiLuong(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maLoaiKhoiLuong)
		{
			return GetByNamHocHocKyLoaiKhoiLuong(null, start, pageLength , namHoc, hocKy, maLoaiKhoiLuong);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetByNamHocHocKyLoaiKhoiLuong(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maLoaiKhoiLuong)
		{
			return GetByNamHocHocKyLoaiKhoiLuong(transactionManager, 0, int.MaxValue , namHoc, hocKy, maLoaiKhoiLuong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public abstract TList<HeSoLopDong> GetByNamHocHocKyLoaiKhoiLuong(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maLoaiKhoiLuong);
		
		#endregion
		
		#region cust_HeSoLopDong_SaoChepTheoLoaiKhoiLuong 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_SaoChepTheoLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChepTheoLoaiKhoiLuong(System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich, System.String maLoaiKhoiLuong)
		{
			 SaoChepTheoLoaiKhoiLuong(null, 0, int.MaxValue , namHocNguon, hocKyNguon, namHocDich, hocKyDich, maLoaiKhoiLuong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_SaoChepTheoLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChepTheoLoaiKhoiLuong(int start, int pageLength, System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich, System.String maLoaiKhoiLuong)
		{
			 SaoChepTheoLoaiKhoiLuong(null, start, pageLength , namHocNguon, hocKyNguon, namHocDich, hocKyDich, maLoaiKhoiLuong);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_SaoChepTheoLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChepTheoLoaiKhoiLuong(TransactionManager transactionManager, System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich, System.String maLoaiKhoiLuong)
		{
			 SaoChepTheoLoaiKhoiLuong(transactionManager, 0, int.MaxValue , namHocNguon, hocKyNguon, namHocDich, hocKyDich, maLoaiKhoiLuong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_SaoChepTheoLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="hocKyDich"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void SaoChepTheoLoaiKhoiLuong(TransactionManager transactionManager, int start, int pageLength , System.String namHocNguon, System.String hocKyNguon, System.String namHocDich, System.String hocKyDich, System.String maLoaiKhoiLuong);
		
		#endregion
		
		#region cust_HeSoLopDong_GetByNamHocHocKyMaLoaiKhoiLuong 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyMaLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetByNamHocHocKyMaLoaiKhoiLuong(System.String namHoc, System.String hocKy, System.String maLoaiKhoiLuong)
		{
			return GetByNamHocHocKyMaLoaiKhoiLuong(null, 0, int.MaxValue , namHoc, hocKy, maLoaiKhoiLuong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyMaLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetByNamHocHocKyMaLoaiKhoiLuong(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maLoaiKhoiLuong)
		{
			return GetByNamHocHocKyMaLoaiKhoiLuong(null, start, pageLength , namHoc, hocKy, maLoaiKhoiLuong);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyMaLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetByNamHocHocKyMaLoaiKhoiLuong(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maLoaiKhoiLuong)
		{
			return GetByNamHocHocKyMaLoaiKhoiLuong(transactionManager, 0, int.MaxValue , namHoc, hocKy, maLoaiKhoiLuong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyMaLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public abstract TList<HeSoLopDong> GetByNamHocHocKyMaLoaiKhoiLuong(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maLoaiKhoiLuong);
		
		#endregion
		
		#region cust_HeSoLopDong_GetByBacDaoTaoLoaiHocPhanSiSoNhomMonHoc 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByBacDaoTaoLoaiHocPhanSiSoNhomMonHoc' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.Int32</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByBacDaoTaoLoaiHocPhanSiSoNhomMonHoc(System.String maBacDaoTao, System.Int32 maLoaiHocPhan, System.Int32 siSo, System.String nhomMonHoc, ref System.Double heSo)
		{
			 GetByBacDaoTaoLoaiHocPhanSiSoNhomMonHoc(null, 0, int.MaxValue , maBacDaoTao, maLoaiHocPhan, siSo, nhomMonHoc, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByBacDaoTaoLoaiHocPhanSiSoNhomMonHoc' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.Int32</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByBacDaoTaoLoaiHocPhanSiSoNhomMonHoc(int start, int pageLength, System.String maBacDaoTao, System.Int32 maLoaiHocPhan, System.Int32 siSo, System.String nhomMonHoc, ref System.Double heSo)
		{
			 GetByBacDaoTaoLoaiHocPhanSiSoNhomMonHoc(null, start, pageLength , maBacDaoTao, maLoaiHocPhan, siSo, nhomMonHoc, ref heSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByBacDaoTaoLoaiHocPhanSiSoNhomMonHoc' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.Int32</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByBacDaoTaoLoaiHocPhanSiSoNhomMonHoc(TransactionManager transactionManager, System.String maBacDaoTao, System.Int32 maLoaiHocPhan, System.Int32 siSo, System.String nhomMonHoc, ref System.Double heSo)
		{
			 GetByBacDaoTaoLoaiHocPhanSiSoNhomMonHoc(transactionManager, 0, int.MaxValue , maBacDaoTao, maLoaiHocPhan, siSo, nhomMonHoc, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByBacDaoTaoLoaiHocPhanSiSoNhomMonHoc' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.Int32</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByBacDaoTaoLoaiHocPhanSiSoNhomMonHoc(TransactionManager transactionManager, int start, int pageLength , System.String maBacDaoTao, System.Int32 maLoaiHocPhan, System.Int32 siSo, System.String nhomMonHoc, ref System.Double heSo);
		
		#endregion
		
		#region cust_HeSoLopDong_GetByBacDaoTaoLoaiHocPhanSiSo 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByBacDaoTaoLoaiHocPhanSiSo' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.Int32</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByBacDaoTaoLoaiHocPhanSiSo(System.String maBacDaoTao, System.Int32 maLoaiHocPhan, System.Int32 siSo, ref System.Double heSo)
		{
			 GetByBacDaoTaoLoaiHocPhanSiSo(null, 0, int.MaxValue , maBacDaoTao, maLoaiHocPhan, siSo, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByBacDaoTaoLoaiHocPhanSiSo' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.Int32</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByBacDaoTaoLoaiHocPhanSiSo(int start, int pageLength, System.String maBacDaoTao, System.Int32 maLoaiHocPhan, System.Int32 siSo, ref System.Double heSo)
		{
			 GetByBacDaoTaoLoaiHocPhanSiSo(null, start, pageLength , maBacDaoTao, maLoaiHocPhan, siSo, ref heSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByBacDaoTaoLoaiHocPhanSiSo' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.Int32</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByBacDaoTaoLoaiHocPhanSiSo(TransactionManager transactionManager, System.String maBacDaoTao, System.Int32 maLoaiHocPhan, System.Int32 siSo, ref System.Double heSo)
		{
			 GetByBacDaoTaoLoaiHocPhanSiSo(transactionManager, 0, int.MaxValue , maBacDaoTao, maLoaiHocPhan, siSo, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByBacDaoTaoLoaiHocPhanSiSo' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHocPhan"> A <c>System.Int32</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByBacDaoTaoLoaiHocPhanSiSo(TransactionManager transactionManager, int start, int pageLength , System.String maBacDaoTao, System.Int32 maLoaiHocPhan, System.Int32 siSo, ref System.Double heSo);
		
		#endregion
		
		#region cust_HeSoLopDong_GetByNhomMonHocLoaiKhoiLuongSiSo 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNhomMonHocLoaiKhoiLuongSiSo' stored procedure. 
		/// </summary>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNhomMonHocLoaiKhoiLuongSiSo(System.String maNhomMonHoc, System.String maLoaiKhoiLuong, System.Int32 siSo, ref System.Double reVal)
		{
			 GetByNhomMonHocLoaiKhoiLuongSiSo(null, 0, int.MaxValue , maNhomMonHoc, maLoaiKhoiLuong, siSo, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNhomMonHocLoaiKhoiLuongSiSo' stored procedure. 
		/// </summary>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNhomMonHocLoaiKhoiLuongSiSo(int start, int pageLength, System.String maNhomMonHoc, System.String maLoaiKhoiLuong, System.Int32 siSo, ref System.Double reVal)
		{
			 GetByNhomMonHocLoaiKhoiLuongSiSo(null, start, pageLength , maNhomMonHoc, maLoaiKhoiLuong, siSo, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNhomMonHocLoaiKhoiLuongSiSo' stored procedure. 
		/// </summary>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNhomMonHocLoaiKhoiLuongSiSo(TransactionManager transactionManager, System.String maNhomMonHoc, System.String maLoaiKhoiLuong, System.Int32 siSo, ref System.Double reVal)
		{
			 GetByNhomMonHocLoaiKhoiLuongSiSo(transactionManager, 0, int.MaxValue , maNhomMonHoc, maLoaiKhoiLuong, siSo, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNhomMonHocLoaiKhoiLuongSiSo' stored procedure. 
		/// </summary>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByNhomMonHocLoaiKhoiLuongSiSo(TransactionManager transactionManager, int start, int pageLength , System.String maNhomMonHoc, System.String maLoaiKhoiLuong, System.Int32 siSo, ref System.Double reVal);
		
		#endregion
		
		#region cust_HeSoLopDong_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public abstract TList<HeSoLopDong> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_HeSoLopDong_GetLoaiKhoiLuong 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="tietBd"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhong"> A <c>System.String</c> instance.</param>
			/// <param name="loaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetLoaiKhoiLuong(System.String maLopHocPhan, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 tietBd, System.DateTime ngayDay, System.String maPhong, ref System.String loaiKhoiLuong)
		{
			 GetLoaiKhoiLuong(null, 0, int.MaxValue , maLopHocPhan, maBacDaoTao, maKhoaHoc, tietBd, ngayDay, maPhong, ref loaiKhoiLuong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="tietBd"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhong"> A <c>System.String</c> instance.</param>
			/// <param name="loaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetLoaiKhoiLuong(int start, int pageLength, System.String maLopHocPhan, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 tietBd, System.DateTime ngayDay, System.String maPhong, ref System.String loaiKhoiLuong)
		{
			 GetLoaiKhoiLuong(null, start, pageLength , maLopHocPhan, maBacDaoTao, maKhoaHoc, tietBd, ngayDay, maPhong, ref loaiKhoiLuong);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="tietBd"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhong"> A <c>System.String</c> instance.</param>
			/// <param name="loaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetLoaiKhoiLuong(TransactionManager transactionManager, System.String maLopHocPhan, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 tietBd, System.DateTime ngayDay, System.String maPhong, ref System.String loaiKhoiLuong)
		{
			 GetLoaiKhoiLuong(transactionManager, 0, int.MaxValue , maLopHocPhan, maBacDaoTao, maKhoaHoc, tietBd, ngayDay, maPhong, ref loaiKhoiLuong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maKhoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="tietBd"> A <c>System.Int32</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maPhong"> A <c>System.String</c> instance.</param>
			/// <param name="loaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetLoaiKhoiLuong(TransactionManager transactionManager, int start, int pageLength , System.String maLopHocPhan, System.String maBacDaoTao, System.String maKhoaHoc, System.Int32 tietBd, System.DateTime ngayDay, System.String maPhong, ref System.String loaiKhoiLuong);
		
		#endregion
		
		#region cust_HeSoLopDong_GetBySiSoBacDaoTaoNhomMonHoc 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSoBacDaoTaoNhomMonHoc' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetBySiSoBacDaoTaoNhomMonHoc(System.Int32 siSo, System.String bacDaoTao, System.String nhomMonHoc)
		{
			return GetBySiSoBacDaoTaoNhomMonHoc(null, 0, int.MaxValue , siSo, bacDaoTao, nhomMonHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSoBacDaoTaoNhomMonHoc' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetBySiSoBacDaoTaoNhomMonHoc(int start, int pageLength, System.Int32 siSo, System.String bacDaoTao, System.String nhomMonHoc)
		{
			return GetBySiSoBacDaoTaoNhomMonHoc(null, start, pageLength , siSo, bacDaoTao, nhomMonHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSoBacDaoTaoNhomMonHoc' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetBySiSoBacDaoTaoNhomMonHoc(TransactionManager transactionManager, System.Int32 siSo, System.String bacDaoTao, System.String nhomMonHoc)
		{
			return GetBySiSoBacDaoTaoNhomMonHoc(transactionManager, 0, int.MaxValue , siSo, bacDaoTao, nhomMonHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSoBacDaoTaoNhomMonHoc' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public abstract TList<HeSoLopDong> GetBySiSoBacDaoTaoNhomMonHoc(TransactionManager transactionManager, int start, int pageLength , System.Int32 siSo, System.String bacDaoTao, System.String nhomMonHoc);
		
		#endregion
		
		#region cust_HeSoLopDong_GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo(System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String nhomMonHoc, System.Int32 siSo, ref System.Double heSo)
		{
			 GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo(null, 0, int.MaxValue , namHoc, hocKy, bacDaoTao, nhomMonHoc, siSo, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo(int start, int pageLength, System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String nhomMonHoc, System.Int32 siSo, ref System.Double heSo)
		{
			 GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo(null, start, pageLength , namHoc, hocKy, bacDaoTao, nhomMonHoc, siSo, ref heSo);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String nhomMonHoc, System.Int32 siSo, ref System.Double heSo)
		{
			 GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo(transactionManager, 0, int.MaxValue , namHoc, hocKy, bacDaoTao, nhomMonHoc, siSo, ref heSo);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="heSo"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String nhomMonHoc, System.Int32 siSo, ref System.Double heSo);
		
		#endregion
		
		#region cust_HeSoLopDong_GetBySiSoNhomMonHocNgayDay 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSoNhomMonHocNgayDay' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetBySiSoNhomMonHocNgayDay(System.Int32 siSo, System.String maNhomMonHoc, System.DateTime ngayDay)
		{
			return GetBySiSoNhomMonHocNgayDay(null, 0, int.MaxValue , siSo, maNhomMonHoc, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSoNhomMonHocNgayDay' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetBySiSoNhomMonHocNgayDay(int start, int pageLength, System.Int32 siSo, System.String maNhomMonHoc, System.DateTime ngayDay)
		{
			return GetBySiSoNhomMonHocNgayDay(null, start, pageLength , siSo, maNhomMonHoc, ngayDay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSoNhomMonHocNgayDay' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetBySiSoNhomMonHocNgayDay(TransactionManager transactionManager, System.Int32 siSo, System.String maNhomMonHoc, System.DateTime ngayDay)
		{
			return GetBySiSoNhomMonHocNgayDay(transactionManager, 0, int.MaxValue , siSo, maNhomMonHoc, ngayDay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetBySiSoNhomMonHocNgayDay' stored procedure. 
		/// </summary>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="ngayDay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public abstract TList<HeSoLopDong> GetBySiSoNhomMonHocNgayDay(TransactionManager transactionManager, int start, int pageLength , System.Int32 siSo, System.String maNhomMonHoc, System.DateTime ngayDay);
		
		#endregion
		
		#region cust_HeSoLopDong_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoLopDong_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoLopDong_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_HeSoLopDong_SaoChep' stored procedure. 
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
		
		#region cust_HeSoLopDong_GetByMaLoaiKhoiLuong 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByMaLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetByMaLoaiKhoiLuong(System.String maLoaiKhoiLuong)
		{
			return GetByMaLoaiKhoiLuong(null, 0, int.MaxValue , maLoaiKhoiLuong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByMaLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetByMaLoaiKhoiLuong(int start, int pageLength, System.String maLoaiKhoiLuong)
		{
			return GetByMaLoaiKhoiLuong(null, start, pageLength , maLoaiKhoiLuong);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByMaLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public TList<HeSoLopDong> GetByMaLoaiKhoiLuong(TransactionManager transactionManager, System.String maLoaiKhoiLuong)
		{
			return GetByMaLoaiKhoiLuong(transactionManager, 0, int.MaxValue , maLoaiKhoiLuong);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByMaLoaiKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HeSoLopDong&gt;"/> instance.</returns>
		public abstract TList<HeSoLopDong> GetByMaLoaiKhoiLuong(TransactionManager transactionManager, int start, int pageLength , System.String maLoaiKhoiLuong);
		
		#endregion
		
		#region cust_HeSoLopDong_GetByNhomMonHocLoaiKhoiLuongSiSoByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNhomMonHocLoaiKhoiLuongSiSoByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNhomMonHocLoaiKhoiLuongSiSoByNamHocHocKy(System.String namHoc, System.String hocKy, System.String maNhomMonHoc, System.String maLoaiKhoiLuong, System.Int32 siSo, ref System.Double reVal)
		{
			 GetByNhomMonHocLoaiKhoiLuongSiSoByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy, maNhomMonHoc, maLoaiKhoiLuong, siSo, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNhomMonHocLoaiKhoiLuongSiSoByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNhomMonHocLoaiKhoiLuongSiSoByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maNhomMonHoc, System.String maLoaiKhoiLuong, System.Int32 siSo, ref System.Double reVal)
		{
			 GetByNhomMonHocLoaiKhoiLuongSiSoByNamHocHocKy(null, start, pageLength , namHoc, hocKy, maNhomMonHoc, maLoaiKhoiLuong, siSo, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNhomMonHocLoaiKhoiLuongSiSoByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetByNhomMonHocLoaiKhoiLuongSiSoByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maNhomMonHoc, System.String maLoaiKhoiLuong, System.Int32 siSo, ref System.Double reVal)
		{
			 GetByNhomMonHocLoaiKhoiLuongSiSoByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, maNhomMonHoc, maLoaiKhoiLuong, siSo, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HeSoLopDong_GetByNhomMonHocLoaiKhoiLuongSiSoByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maNhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="siSo"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetByNhomMonHocLoaiKhoiLuongSiSoByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maNhomMonHoc, System.String maLoaiKhoiLuong, System.Int32 siSo, ref System.Double reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HeSoLopDong&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HeSoLopDong&gt;"/></returns>
		public static TList<HeSoLopDong> Fill(IDataReader reader, TList<HeSoLopDong> rows, int start, int pageLength)
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
				
				PMS.Entities.HeSoLopDong c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HeSoLopDong")
					.Append("|").Append((System.Int32)reader[((int)HeSoLopDongColumn.MaHeSo - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HeSoLopDong>(
					key.ToString(), // EntityTrackingKey
					"HeSoLopDong",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HeSoLopDong();
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
					c.MaHeSo = (System.Int32)reader[(HeSoLopDongColumn.MaHeSo.ToString())];
					c.Stt = (reader[HeSoLopDongColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoLopDongColumn.Stt.ToString())];
					c.MaQuanLy = (System.String)reader[(HeSoLopDongColumn.MaQuanLy.ToString())];
					c.MaBacDaoTao = (reader[HeSoLopDongColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.MaBacDaoTao.ToString())];
					c.MaNhomMonHoc = (reader[HeSoLopDongColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.MaNhomMonHoc.ToString())];
					c.TuKhoan = (reader[HeSoLopDongColumn.TuKhoan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoLopDongColumn.TuKhoan.ToString())];
					c.DenKhoan = (reader[HeSoLopDongColumn.DenKhoan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoLopDongColumn.DenKhoan.ToString())];
					c.HeSo = (reader[HeSoLopDongColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoLopDongColumn.HeSo.ToString())];
					c.NgayBdApDung = (reader[HeSoLopDongColumn.NgayBdApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoLopDongColumn.NgayBdApDung.ToString())];
					c.NgayKtApDung = (reader[HeSoLopDongColumn.NgayKtApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoLopDongColumn.NgayKtApDung.ToString())];
					c.MaLoaiKhoiLuong = (reader[HeSoLopDongColumn.MaLoaiKhoiLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.MaLoaiKhoiLuong.ToString())];
					c.HocKyApDung = (reader[HeSoLopDongColumn.HocKyApDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.HocKyApDung.ToString())];
					c.NamHoc = (reader[HeSoLopDongColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.NamHoc.ToString())];
					c.HocKy = (reader[HeSoLopDongColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.HocKy.ToString())];
					c.NgayCapNhat = (reader[HeSoLopDongColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[HeSoLopDongColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.NguoiCapNhat.ToString())];
					c.LoaiLop = (reader[HeSoLopDongColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.LoaiLop.ToString())];
					c.MaDonVi = (reader[HeSoLopDongColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.MaDonVi.ToString())];
					c.MaLoaiGiangVien = (reader[HeSoLopDongColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.MaLoaiGiangVien.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoLopDong"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoLopDong"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HeSoLopDong entity)
		{
			if (!reader.Read()) return;
			
			entity.MaHeSo = (System.Int32)reader[(HeSoLopDongColumn.MaHeSo.ToString())];
			entity.Stt = (reader[HeSoLopDongColumn.Stt.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoLopDongColumn.Stt.ToString())];
			entity.MaQuanLy = (System.String)reader[(HeSoLopDongColumn.MaQuanLy.ToString())];
			entity.MaBacDaoTao = (reader[HeSoLopDongColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.MaBacDaoTao.ToString())];
			entity.MaNhomMonHoc = (reader[HeSoLopDongColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.MaNhomMonHoc.ToString())];
			entity.TuKhoan = (reader[HeSoLopDongColumn.TuKhoan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoLopDongColumn.TuKhoan.ToString())];
			entity.DenKhoan = (reader[HeSoLopDongColumn.DenKhoan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HeSoLopDongColumn.DenKhoan.ToString())];
			entity.HeSo = (reader[HeSoLopDongColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HeSoLopDongColumn.HeSo.ToString())];
			entity.NgayBdApDung = (reader[HeSoLopDongColumn.NgayBdApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoLopDongColumn.NgayBdApDung.ToString())];
			entity.NgayKtApDung = (reader[HeSoLopDongColumn.NgayKtApDung.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HeSoLopDongColumn.NgayKtApDung.ToString())];
			entity.MaLoaiKhoiLuong = (reader[HeSoLopDongColumn.MaLoaiKhoiLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.MaLoaiKhoiLuong.ToString())];
			entity.HocKyApDung = (reader[HeSoLopDongColumn.HocKyApDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.HocKyApDung.ToString())];
			entity.NamHoc = (reader[HeSoLopDongColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.NamHoc.ToString())];
			entity.HocKy = (reader[HeSoLopDongColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.HocKy.ToString())];
			entity.NgayCapNhat = (reader[HeSoLopDongColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[HeSoLopDongColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.NguoiCapNhat.ToString())];
			entity.LoaiLop = (reader[HeSoLopDongColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.LoaiLop.ToString())];
			entity.MaDonVi = (reader[HeSoLopDongColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.MaDonVi.ToString())];
			entity.MaLoaiGiangVien = (reader[HeSoLopDongColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(HeSoLopDongColumn.MaLoaiGiangVien.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HeSoLopDong"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HeSoLopDong"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HeSoLopDong entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaHeSo = (System.Int32)dataRow["MaHeSo"];
			entity.Stt = Convert.IsDBNull(dataRow["STT"]) ? null : (System.Int32?)dataRow["STT"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.MaNhomMonHoc = Convert.IsDBNull(dataRow["MaNhomMonHoc"]) ? null : (System.String)dataRow["MaNhomMonHoc"];
			entity.TuKhoan = Convert.IsDBNull(dataRow["TuKhoan"]) ? null : (System.Int32?)dataRow["TuKhoan"];
			entity.DenKhoan = Convert.IsDBNull(dataRow["DenKhoan"]) ? null : (System.Int32?)dataRow["DenKhoan"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.NgayBdApDung = Convert.IsDBNull(dataRow["NgayBDApDung"]) ? null : (System.DateTime?)dataRow["NgayBDApDung"];
			entity.NgayKtApDung = Convert.IsDBNull(dataRow["NgayKTApDung"]) ? null : (System.DateTime?)dataRow["NgayKTApDung"];
			entity.MaLoaiKhoiLuong = Convert.IsDBNull(dataRow["MaLoaiKhoiLuong"]) ? null : (System.String)dataRow["MaLoaiKhoiLuong"];
			entity.HocKyApDung = Convert.IsDBNull(dataRow["HocKyApDung"]) ? null : (System.String)dataRow["HocKyApDung"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.LoaiLop = Convert.IsDBNull(dataRow["LoaiLop"]) ? null : (System.String)dataRow["LoaiLop"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.String)dataRow["MaDonVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.String)dataRow["MaLoaiGiangVien"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HeSoLopDong"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HeSoLopDong Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HeSoLopDong entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.HeSoLopDong object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HeSoLopDong instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HeSoLopDong Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HeSoLopDong entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HeSoLopDongChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HeSoLopDong</c>
	///</summary>
	public enum HeSoLopDongChildEntityTypes
	{
	}
	
	#endregion HeSoLopDongChildEntityTypes
	
	#region HeSoLopDongFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HeSoLopDongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoLopDong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoLopDongFilterBuilder : SqlFilterBuilder<HeSoLopDongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoLopDongFilterBuilder class.
		/// </summary>
		public HeSoLopDongFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoLopDongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoLopDongFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoLopDongFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoLopDongFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoLopDongFilterBuilder
	
	#region HeSoLopDongParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HeSoLopDongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoLopDong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoLopDongParameterBuilder : ParameterizedSqlFilterBuilder<HeSoLopDongColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoLopDongParameterBuilder class.
		/// </summary>
		public HeSoLopDongParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HeSoLopDongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HeSoLopDongParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HeSoLopDongParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HeSoLopDongParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HeSoLopDongParameterBuilder
	
	#region HeSoLopDongSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HeSoLopDongColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoLopDong"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HeSoLopDongSortBuilder : SqlSortBuilder<HeSoLopDongColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoLopDongSqlSortBuilder class.
		/// </summary>
		public HeSoLopDongSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HeSoLopDongSortBuilder
	
} // end namespace
