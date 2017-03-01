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
	/// This class is the base class for any <see cref="KhoiLuongTamUngProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KhoiLuongTamUngProviderBaseCore : EntityProviderBase<PMS.Entities.KhoiLuongTamUng, PMS.Entities.KhoiLuongTamUngKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KhoiLuongTamUngKey key)
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
		public override PMS.Entities.KhoiLuongTamUng Get(TransactionManager transactionManager, PMS.Entities.KhoiLuongTamUngKey key, int start, int pageLength)
		{
			return GetByMaKhoiLuong(transactionManager, key.MaKhoiLuong, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KhoiLuongTamUng index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongTamUng"/> class.</returns>
		public PMS.Entities.KhoiLuongTamUng GetByMaKhoiLuong(System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(null,_maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongTamUng index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongTamUng"/> class.</returns>
		public PMS.Entities.KhoiLuongTamUng GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongTamUng index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongTamUng"/> class.</returns>
		public PMS.Entities.KhoiLuongTamUng GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongTamUng index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongTamUng"/> class.</returns>
		public PMS.Entities.KhoiLuongTamUng GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuong(transactionManager, _maKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongTamUng index.
		/// </summary>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongTamUng"/> class.</returns>
		public PMS.Entities.KhoiLuongTamUng GetByMaKhoiLuong(System.Int32 _maKhoiLuong, int start, int pageLength, out int count)
		{
			return GetByMaKhoiLuong(null, _maKhoiLuong, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongTamUng index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongTamUng"/> class.</returns>
		public abstract PMS.Entities.KhoiLuongTamUng GetByMaKhoiLuong(TransactionManager transactionManager, System.Int32 _maKhoiLuong, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KhoiLuongTamUng_KiemTraDongBo 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_KiemTraDongBo' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongTamUng_KiemTraDongBo' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongTamUng_KiemTraDongBo' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongTamUng_KiemTraDongBo' stored procedure. 
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
		
		#region cust_KhoiLuongTamUng_GetDuLieuThanhToanTamUng 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetDuLieuThanhToanTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDuLieuThanhToanTamUng(System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String loaiHinhDaoTao, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return GetDuLieuThanhToanTamUng(null, 0, int.MaxValue , namHoc, hocKy, bacDaoTao, loaiHinhDaoTao, khoaDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetDuLieuThanhToanTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDuLieuThanhToanTamUng(int start, int pageLength, System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String loaiHinhDaoTao, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return GetDuLieuThanhToanTamUng(null, start, pageLength , namHoc, hocKy, bacDaoTao, loaiHinhDaoTao, khoaDonVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetDuLieuThanhToanTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDuLieuThanhToanTamUng(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String loaiHinhDaoTao, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return GetDuLieuThanhToanTamUng(transactionManager, 0, int.MaxValue , namHoc, hocKy, bacDaoTao, loaiHinhDaoTao, khoaDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetDuLieuThanhToanTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetDuLieuThanhToanTamUng(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String bacDaoTao, System.String loaiHinhDaoTao, System.String khoaDonVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_KhoiLuongTamUng_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongTamUng_GetListByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetListByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongTamUng&gt;"/> instance.</returns>
		public TList<KhoiLuongTamUng> GetListByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetListByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetListByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongTamUng&gt;"/> instance.</returns>
		public TList<KhoiLuongTamUng> GetListByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetListByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetListByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongTamUng&gt;"/> instance.</returns>
		public TList<KhoiLuongTamUng> GetListByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetListByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetListByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;KhoiLuongTamUng&gt;"/> instance.</returns>
		public abstract TList<KhoiLuongTamUng> GetListByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongTamUng_GetByNamHocHocKyLoaiGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetByNamHocHocKyLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyLoaiGiangVien(System.String namHoc, System.String hocKy, System.String loaiGiangVien)
		{
			return GetByNamHocHocKyLoaiGiangVien(null, 0, int.MaxValue , namHoc, hocKy, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetByNamHocHocKyLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyLoaiGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.String loaiGiangVien)
		{
			return GetByNamHocHocKyLoaiGiangVien(null, start, pageLength , namHoc, hocKy, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetByNamHocHocKyLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyLoaiGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String loaiGiangVien)
		{
			return GetByNamHocHocKyLoaiGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_GetByNamHocHocKyLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyLoaiGiangVien(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_KhoiLuongTamUng_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(System.String namHoc, System.String hocKy)
		{
			 DongBo(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongTamUng_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongTamUng_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongTamUng_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KhoiLuongTamUng&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KhoiLuongTamUng&gt;"/></returns>
		public static TList<KhoiLuongTamUng> Fill(IDataReader reader, TList<KhoiLuongTamUng> rows, int start, int pageLength)
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
				
				PMS.Entities.KhoiLuongTamUng c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KhoiLuongTamUng")
					.Append("|").Append((System.Int32)reader[((int)KhoiLuongTamUngColumn.MaKhoiLuong - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KhoiLuongTamUng>(
					key.ToString(), // EntityTrackingKey
					"KhoiLuongTamUng",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KhoiLuongTamUng();
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
					c.MaKhoiLuong = (System.Int32)reader[(KhoiLuongTamUngColumn.MaKhoiLuong.ToString())];
					c.MaLichHoc = (reader[KhoiLuongTamUngColumn.MaLichHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.MaLichHoc.ToString())];
					c.MaQuanLyGv = (reader[KhoiLuongTamUngColumn.MaQuanLyGv.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaQuanLyGv.ToString())];
					c.MaLopHocPhan = (reader[KhoiLuongTamUngColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaLopHocPhan.ToString())];
					c.NamHoc = (reader[KhoiLuongTamUngColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.NamHoc.ToString())];
					c.HocKy = (reader[KhoiLuongTamUngColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.HocKy.ToString())];
					c.MaMonHoc = (reader[KhoiLuongTamUngColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[KhoiLuongTamUngColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.TenMonHoc.ToString())];
					c.Nhom = (reader[KhoiLuongTamUngColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.Nhom.ToString())];
					c.SoTinChi = (reader[KhoiLuongTamUngColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongTamUngColumn.SoTinChi.ToString())];
					c.SoLuong = (reader[KhoiLuongTamUngColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.SoLuong.ToString())];
					c.MaLoaiHocPhan = (reader[KhoiLuongTamUngColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(KhoiLuongTamUngColumn.MaLoaiHocPhan.ToString())];
					c.LoaiHocPhan = (reader[KhoiLuongTamUngColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.LoaiHocPhan.ToString())];
					c.MaBuoiHoc = (reader[KhoiLuongTamUngColumn.MaBuoiHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.MaBuoiHoc.ToString())];
					c.MaLop = (reader[KhoiLuongTamUngColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaLop.ToString())];
					c.TietBatDau = (reader[KhoiLuongTamUngColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.TietBatDau.ToString())];
					c.SoTiet = (reader[KhoiLuongTamUngColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongTamUngColumn.SoTiet.ToString())];
					c.TinhTrang = (reader[KhoiLuongTamUngColumn.TinhTrang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.TinhTrang.ToString())];
					c.NgayDay = (reader[KhoiLuongTamUngColumn.NgayDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongTamUngColumn.NgayDay.ToString())];
					c.MaBacDaoTao = (reader[KhoiLuongTamUngColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaBacDaoTao.ToString())];
					c.MaKhoa = (reader[KhoiLuongTamUngColumn.MaKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaKhoa.ToString())];
					c.MaNhomMonHoc = (reader[KhoiLuongTamUngColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaNhomMonHoc.ToString())];
					c.MaPhongHoc = (reader[KhoiLuongTamUngColumn.MaPhongHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaPhongHoc.ToString())];
					c.MaKhoaHoc = (reader[KhoiLuongTamUngColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaKhoaHoc.ToString())];
					c.LoaiHocKy = (reader[KhoiLuongTamUngColumn.LoaiHocKy.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(KhoiLuongTamUngColumn.LoaiHocKy.ToString())];
					c.NamThu = (reader[KhoiLuongTamUngColumn.NamThu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.NamThu.ToString())];
					c.MaHocHam = (reader[KhoiLuongTamUngColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KhoiLuongTamUngColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[KhoiLuongTamUngColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.MaLoaiGiangVien.ToString())];
					c.MaChucVu = (reader[KhoiLuongTamUngColumn.MaChucVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.MaChucVu.ToString())];
					c.MaHinhThucDaoTao = (reader[KhoiLuongTamUngColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaHinhThucDaoTao.ToString())];
					c.GhiChu = (reader[KhoiLuongTamUngColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.GhiChu.ToString())];
					c.LopHocPhanChuyenNganh = (reader[KhoiLuongTamUngColumn.LopHocPhanChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KhoiLuongTamUngColumn.LopHocPhanChuyenNganh.ToString())];
					c.DotImport = (reader[KhoiLuongTamUngColumn.DotImport.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.DotImport.ToString())];
					c.DaoTaoTinChi = (reader[KhoiLuongTamUngColumn.DaoTaoTinChi.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KhoiLuongTamUngColumn.DaoTaoTinChi.ToString())];
					c.NgonNguGiangDay = (reader[KhoiLuongTamUngColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.NgonNguGiangDay.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongTamUng"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongTamUng"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KhoiLuongTamUng entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKhoiLuong = (System.Int32)reader[(KhoiLuongTamUngColumn.MaKhoiLuong.ToString())];
			entity.MaLichHoc = (reader[KhoiLuongTamUngColumn.MaLichHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.MaLichHoc.ToString())];
			entity.MaQuanLyGv = (reader[KhoiLuongTamUngColumn.MaQuanLyGv.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaQuanLyGv.ToString())];
			entity.MaLopHocPhan = (reader[KhoiLuongTamUngColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaLopHocPhan.ToString())];
			entity.NamHoc = (reader[KhoiLuongTamUngColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KhoiLuongTamUngColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.HocKy.ToString())];
			entity.MaMonHoc = (reader[KhoiLuongTamUngColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[KhoiLuongTamUngColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.TenMonHoc.ToString())];
			entity.Nhom = (reader[KhoiLuongTamUngColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.Nhom.ToString())];
			entity.SoTinChi = (reader[KhoiLuongTamUngColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongTamUngColumn.SoTinChi.ToString())];
			entity.SoLuong = (reader[KhoiLuongTamUngColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.SoLuong.ToString())];
			entity.MaLoaiHocPhan = (reader[KhoiLuongTamUngColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(KhoiLuongTamUngColumn.MaLoaiHocPhan.ToString())];
			entity.LoaiHocPhan = (reader[KhoiLuongTamUngColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.LoaiHocPhan.ToString())];
			entity.MaBuoiHoc = (reader[KhoiLuongTamUngColumn.MaBuoiHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.MaBuoiHoc.ToString())];
			entity.MaLop = (reader[KhoiLuongTamUngColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaLop.ToString())];
			entity.TietBatDau = (reader[KhoiLuongTamUngColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.TietBatDau.ToString())];
			entity.SoTiet = (reader[KhoiLuongTamUngColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongTamUngColumn.SoTiet.ToString())];
			entity.TinhTrang = (reader[KhoiLuongTamUngColumn.TinhTrang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.TinhTrang.ToString())];
			entity.NgayDay = (reader[KhoiLuongTamUngColumn.NgayDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongTamUngColumn.NgayDay.ToString())];
			entity.MaBacDaoTao = (reader[KhoiLuongTamUngColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaBacDaoTao.ToString())];
			entity.MaKhoa = (reader[KhoiLuongTamUngColumn.MaKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaKhoa.ToString())];
			entity.MaNhomMonHoc = (reader[KhoiLuongTamUngColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaNhomMonHoc.ToString())];
			entity.MaPhongHoc = (reader[KhoiLuongTamUngColumn.MaPhongHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaPhongHoc.ToString())];
			entity.MaKhoaHoc = (reader[KhoiLuongTamUngColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaKhoaHoc.ToString())];
			entity.LoaiHocKy = (reader[KhoiLuongTamUngColumn.LoaiHocKy.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(KhoiLuongTamUngColumn.LoaiHocKy.ToString())];
			entity.NamThu = (reader[KhoiLuongTamUngColumn.NamThu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.NamThu.ToString())];
			entity.MaHocHam = (reader[KhoiLuongTamUngColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KhoiLuongTamUngColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[KhoiLuongTamUngColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.MaLoaiGiangVien.ToString())];
			entity.MaChucVu = (reader[KhoiLuongTamUngColumn.MaChucVu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongTamUngColumn.MaChucVu.ToString())];
			entity.MaHinhThucDaoTao = (reader[KhoiLuongTamUngColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.MaHinhThucDaoTao.ToString())];
			entity.GhiChu = (reader[KhoiLuongTamUngColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.GhiChu.ToString())];
			entity.LopHocPhanChuyenNganh = (reader[KhoiLuongTamUngColumn.LopHocPhanChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KhoiLuongTamUngColumn.LopHocPhanChuyenNganh.ToString())];
			entity.DotImport = (reader[KhoiLuongTamUngColumn.DotImport.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.DotImport.ToString())];
			entity.DaoTaoTinChi = (reader[KhoiLuongTamUngColumn.DaoTaoTinChi.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KhoiLuongTamUngColumn.DaoTaoTinChi.ToString())];
			entity.NgonNguGiangDay = (reader[KhoiLuongTamUngColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongTamUngColumn.NgonNguGiangDay.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongTamUng"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongTamUng"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KhoiLuongTamUng entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoiLuong = (System.Int32)dataRow["MaKhoiLuong"];
			entity.MaLichHoc = Convert.IsDBNull(dataRow["MaLichHoc"]) ? null : (System.Int32?)dataRow["MaLichHoc"];
			entity.MaQuanLyGv = Convert.IsDBNull(dataRow["MaQuanLyGv"]) ? null : (System.String)dataRow["MaQuanLyGv"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Decimal?)dataRow["SoTinChi"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Int32?)dataRow["SoLuong"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.Byte?)dataRow["MaLoaiHocPhan"];
			entity.LoaiHocPhan = Convert.IsDBNull(dataRow["LoaiHocPhan"]) ? null : (System.String)dataRow["LoaiHocPhan"];
			entity.MaBuoiHoc = Convert.IsDBNull(dataRow["MaBuoiHoc"]) ? null : (System.Int32?)dataRow["MaBuoiHoc"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.TietBatDau = Convert.IsDBNull(dataRow["TietBatDau"]) ? null : (System.Int32?)dataRow["TietBatDau"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.TinhTrang = Convert.IsDBNull(dataRow["TinhTrang"]) ? null : (System.Int32?)dataRow["TinhTrang"];
			entity.NgayDay = Convert.IsDBNull(dataRow["NgayDay"]) ? null : (System.DateTime?)dataRow["NgayDay"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.MaKhoa = Convert.IsDBNull(dataRow["MaKhoa"]) ? null : (System.String)dataRow["MaKhoa"];
			entity.MaNhomMonHoc = Convert.IsDBNull(dataRow["MaNhomMonHoc"]) ? null : (System.String)dataRow["MaNhomMonHoc"];
			entity.MaPhongHoc = Convert.IsDBNull(dataRow["MaPhongHoc"]) ? null : (System.String)dataRow["MaPhongHoc"];
			entity.MaKhoaHoc = Convert.IsDBNull(dataRow["MaKhoaHoc"]) ? null : (System.String)dataRow["MaKhoaHoc"];
			entity.LoaiHocKy = Convert.IsDBNull(dataRow["LoaiHocKy"]) ? null : (System.Byte?)dataRow["LoaiHocKy"];
			entity.NamThu = Convert.IsDBNull(dataRow["NamThu"]) ? null : (System.String)dataRow["NamThu"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaChucVu = Convert.IsDBNull(dataRow["MaChucVu"]) ? null : (System.Int32?)dataRow["MaChucVu"];
			entity.MaHinhThucDaoTao = Convert.IsDBNull(dataRow["MaHinhThucDaoTao"]) ? null : (System.String)dataRow["MaHinhThucDaoTao"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.LopHocPhanChuyenNganh = Convert.IsDBNull(dataRow["LopHocPhanChuyenNganh"]) ? null : (System.Boolean?)dataRow["LopHocPhanChuyenNganh"];
			entity.DotImport = Convert.IsDBNull(dataRow["DotImport"]) ? null : (System.String)dataRow["DotImport"];
			entity.DaoTaoTinChi = Convert.IsDBNull(dataRow["DaoTaoTinChi"]) ? null : (System.Boolean?)dataRow["DaoTaoTinChi"];
			entity.NgonNguGiangDay = Convert.IsDBNull(dataRow["NgonNguGiangDay"]) ? null : (System.String)dataRow["NgonNguGiangDay"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongTamUng"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongTamUng Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KhoiLuongTamUng entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaKhoiLuong methods when available
			
			#region QuyDoiKhoiLuongTamUngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<QuyDoiKhoiLuongTamUng>|QuyDoiKhoiLuongTamUngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'QuyDoiKhoiLuongTamUngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.QuyDoiKhoiLuongTamUngCollection = DataRepository.QuyDoiKhoiLuongTamUngProvider.GetByMaKhoiLuongTamUng(transactionManager, entity.MaKhoiLuong);

				if (deep && entity.QuyDoiKhoiLuongTamUngCollection.Count > 0)
				{
					deepHandles.Add("QuyDoiKhoiLuongTamUngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<QuyDoiKhoiLuongTamUng>) DataRepository.QuyDoiKhoiLuongTamUngProvider.DeepLoad,
						new object[] { transactionManager, entity.QuyDoiKhoiLuongTamUngCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.KhoiLuongTamUng object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KhoiLuongTamUng instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongTamUng Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KhoiLuongTamUng entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<QuyDoiKhoiLuongTamUng>
				if (CanDeepSave(entity.QuyDoiKhoiLuongTamUngCollection, "List<QuyDoiKhoiLuongTamUng>|QuyDoiKhoiLuongTamUngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(QuyDoiKhoiLuongTamUng child in entity.QuyDoiKhoiLuongTamUngCollection)
					{
						if(child.MaKhoiLuongTamUngSource != null)
						{
							child.MaKhoiLuongTamUng = child.MaKhoiLuongTamUngSource.MaKhoiLuong;
						}
						else
						{
							child.MaKhoiLuongTamUng = entity.MaKhoiLuong;
						}

					}

					if (entity.QuyDoiKhoiLuongTamUngCollection.Count > 0 || entity.QuyDoiKhoiLuongTamUngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.QuyDoiKhoiLuongTamUngProvider.Save(transactionManager, entity.QuyDoiKhoiLuongTamUngCollection);
						
						deepHandles.Add("QuyDoiKhoiLuongTamUngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< QuyDoiKhoiLuongTamUng >) DataRepository.QuyDoiKhoiLuongTamUngProvider.DeepSave,
							new object[] { transactionManager, entity.QuyDoiKhoiLuongTamUngCollection, deepSaveType, childTypes, innerList }
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
	
	#region KhoiLuongTamUngChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KhoiLuongTamUng</c>
	///</summary>
	public enum KhoiLuongTamUngChildEntityTypes
	{
		///<summary>
		/// Collection of <c>KhoiLuongTamUng</c> as OneToMany for QuyDoiKhoiLuongTamUngCollection
		///</summary>
		[ChildEntityType(typeof(TList<QuyDoiKhoiLuongTamUng>))]
		QuyDoiKhoiLuongTamUngCollection,
	}
	
	#endregion KhoiLuongTamUngChildEntityTypes
	
	#region KhoiLuongTamUngFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KhoiLuongTamUngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongTamUngFilterBuilder : SqlFilterBuilder<KhoiLuongTamUngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongTamUngFilterBuilder class.
		/// </summary>
		public KhoiLuongTamUngFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongTamUngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongTamUngFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongTamUngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongTamUngFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongTamUngFilterBuilder
	
	#region KhoiLuongTamUngParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KhoiLuongTamUngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongTamUngParameterBuilder : ParameterizedSqlFilterBuilder<KhoiLuongTamUngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongTamUngParameterBuilder class.
		/// </summary>
		public KhoiLuongTamUngParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongTamUngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongTamUngParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongTamUngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongTamUngParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongTamUngParameterBuilder
	
	#region KhoiLuongTamUngSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KhoiLuongTamUngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongTamUng"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KhoiLuongTamUngSortBuilder : SqlSortBuilder<KhoiLuongTamUngColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongTamUngSqlSortBuilder class.
		/// </summary>
		public KhoiLuongTamUngSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KhoiLuongTamUngSortBuilder
	
} // end namespace
