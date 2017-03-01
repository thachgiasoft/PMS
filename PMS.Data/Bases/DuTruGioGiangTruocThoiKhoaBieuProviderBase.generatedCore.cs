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
	/// This class is the base class for any <see cref="DuTruGioGiangTruocThoiKhoaBieuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class DuTruGioGiangTruocThoiKhoaBieuProviderBaseCore : EntityProviderBase<PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu, PMS.Entities.DuTruGioGiangTruocThoiKhoaBieuKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.DuTruGioGiangTruocThoiKhoaBieuKey key)
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
		public override PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu Get(TransactionManager transactionManager, PMS.Entities.DuTruGioGiangTruocThoiKhoaBieuKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_DuTruGioGiangTruocThoiKhoaBieu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DuTruGioGiangTruocThoiKhoaBieu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DuTruGioGiangTruocThoiKhoaBieu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DuTruGioGiangTruocThoiKhoaBieu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DuTruGioGiangTruocThoiKhoaBieu index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_DuTruGioGiangTruocThoiKhoaBieu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu"/> class.</returns>
		public abstract PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_DuTruGioGiangTruocThoiKhoaBieu_TinhQuyDoi 
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_TinhQuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void TinhQuyDoi(System.String namHoc, System.String hocKy)
		{
			 TinhQuyDoi(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_TinhQuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void TinhQuyDoi(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 TinhQuyDoi(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_TinhQuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void TinhQuyDoi(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 TinhQuyDoi(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_TinhQuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void TinhQuyDoi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeSoLuongGiangVienTheoHe 
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeSoLuongGiangVienTheoHe' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSoLuongGiangVienTheoHe(System.DateTime ngay)
		{
			return ThongKeSoLuongGiangVienTheoHe(null, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeSoLuongGiangVienTheoHe' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSoLuongGiangVienTheoHe(int start, int pageLength, System.DateTime ngay)
		{
			return ThongKeSoLuongGiangVienTheoHe(null, start, pageLength , ngay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeSoLuongGiangVienTheoHe' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeSoLuongGiangVienTheoHe(TransactionManager transactionManager, System.DateTime ngay)
		{
			return ThongKeSoLuongGiangVienTheoHe(transactionManager, 0, int.MaxValue , ngay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeSoLuongGiangVienTheoHe' stored procedure. 
		/// </summary>
		/// <param name="ngay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeSoLuongGiangVienTheoHe(TransactionManager transactionManager, int start, int pageLength , System.DateTime ngay);
		
		#endregion
		
		#region cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeCaNamTheoGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeCaNamTheoGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeCaNamTheoGiangVien(System.String namHoc, System.String donVi, System.String loaiGiangVien)
		{
			return ThongKeCaNamTheoGiangVien(null, 0, int.MaxValue , namHoc, donVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeCaNamTheoGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeCaNamTheoGiangVien(int start, int pageLength, System.String namHoc, System.String donVi, System.String loaiGiangVien)
		{
			return ThongKeCaNamTheoGiangVien(null, start, pageLength , namHoc, donVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeCaNamTheoGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeCaNamTheoGiangVien(TransactionManager transactionManager, System.String namHoc, System.String donVi, System.String loaiGiangVien)
		{
			return ThongKeCaNamTheoGiangVien(transactionManager, 0, int.MaxValue , namHoc, donVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeCaNamTheoGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeCaNamTheoGiangVien(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String donVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeTheoNam 
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNam(System.String namHoc)
		{
			return ThongKeTheoNam(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNam(int start, int pageLength, System.String namHoc)
		{
			return ThongKeTheoNam(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNam(TransactionManager transactionManager, System.String namHoc)
		{
			return ThongKeTheoNam(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTheoNam(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_DuTruGioGiangTruocThoiKhoaBieu_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_DuTruGioGiangTruocThoiKhoaBieu_TinhQuyDoiKhiChuaCoLhp 
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_TinhQuyDoiKhiChuaCoLhp' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void TinhQuyDoiKhiChuaCoLhp(System.String namHoc, System.String hocKy)
		{
			 TinhQuyDoiKhiChuaCoLhp(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_TinhQuyDoiKhiChuaCoLhp' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void TinhQuyDoiKhiChuaCoLhp(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 TinhQuyDoiKhiChuaCoLhp(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_TinhQuyDoiKhiChuaCoLhp' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void TinhQuyDoiKhiChuaCoLhp(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 TinhQuyDoiKhiChuaCoLhp(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_TinhQuyDoiKhiChuaCoLhp' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void TinhQuyDoiKhiChuaCoLhp(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeChiTiet_Cdgtvt 
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeChiTiet_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTiet_Cdgtvt(System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien)
		{
			return ThongKeChiTiet_Cdgtvt(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeChiTiet_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTiet_Cdgtvt(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien)
		{
			return ThongKeChiTiet_Cdgtvt(null, start, pageLength , namHoc, hocKy, maDonVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeChiTiet_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeChiTiet_Cdgtvt(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien)
		{
			return ThongKeChiTiet_Cdgtvt(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_ThongKeChiTiet_Cdgtvt' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeChiTiet_Cdgtvt(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_DuTruGioGiangTruocThoiKhoaBieu_GetByNamHocHocKyDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_GetByNamHocHocKyDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDonVi(System.String namHoc, System.String hocKy, System.String donVi)
		{
			return GetByNamHocHocKyDonVi(null, 0, int.MaxValue , namHoc, hocKy, donVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_GetByNamHocHocKyDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi)
		{
			return GetByNamHocHocKyDonVi(null, start, pageLength , namHoc, hocKy, donVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_GetByNamHocHocKyDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi)
		{
			return GetByNamHocHocKyDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_DuTruGioGiangTruocThoiKhoaBieu_GetByNamHocHocKyDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;DuTruGioGiangTruocThoiKhoaBieu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;DuTruGioGiangTruocThoiKhoaBieu&gt;"/></returns>
		public static TList<DuTruGioGiangTruocThoiKhoaBieu> Fill(IDataReader reader, TList<DuTruGioGiangTruocThoiKhoaBieu> rows, int start, int pageLength)
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
				
				PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("DuTruGioGiangTruocThoiKhoaBieu")
					.Append("|").Append((System.Int32)reader[((int)DuTruGioGiangTruocThoiKhoaBieuColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<DuTruGioGiangTruocThoiKhoaBieu>(
					key.ToString(), // EntityTrackingKey
					"DuTruGioGiangTruocThoiKhoaBieu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu();
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
					c.Id = (System.Int32)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.Id.ToString())];
					c.MaQuanLy = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaQuanLy.ToString())];
					c.MaLopHocPhan = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaLopHocPhan.ToString())];
					c.TenLopHocPhan = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.TenLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.TenLopHocPhan.ToString())];
					c.NamHoc = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.NamHoc.ToString())];
					c.HocKy = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.HocKy.ToString())];
					c.MaMonHoc = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.TenMonHoc.ToString())];
					c.SoTiet = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.SoTiet.ToString())];
					c.SiSo = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.SiSo.ToString())];
					c.MaLoaiHocPhan = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaLoaiHocPhan.ToString())];
					c.TenLoaiHocPhan = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.TenLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.TenLoaiHocPhan.ToString())];
					c.MaBacDaoTao = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaBacDaoTao.ToString())];
					c.MaNhomMonHoc = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaNhomMonHoc.ToString())];
					c.HeSoBacDaoTao = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoBacDaoTao.ToString())];
					c.HeSoLopDong = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoLopDong.ToString())];
					c.HeSoMonThucTap = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoMonThucTap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoMonThucTap.ToString())];
					c.HeSoCoVanHocTap = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoCoVanHocTap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoCoVanHocTap.ToString())];
					c.SoTietQuyDoi = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.SoTietQuyDoi.ToString())];
					c.MaHocHam = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaLoaiGiangVien.ToString())];
					c.MaDonVi = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaDonVi.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.Id.ToString())];
			entity.MaQuanLy = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaQuanLy.ToString())];
			entity.MaLopHocPhan = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaLopHocPhan.ToString())];
			entity.TenLopHocPhan = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.TenLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.TenLopHocPhan.ToString())];
			entity.NamHoc = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.NamHoc.ToString())];
			entity.HocKy = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.HocKy.ToString())];
			entity.MaMonHoc = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.TenMonHoc.ToString())];
			entity.SoTiet = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.SoTiet.ToString())];
			entity.SiSo = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.SiSo.ToString())];
			entity.MaLoaiHocPhan = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaLoaiHocPhan.ToString())];
			entity.TenLoaiHocPhan = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.TenLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.TenLoaiHocPhan.ToString())];
			entity.MaBacDaoTao = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaBacDaoTao.ToString())];
			entity.MaNhomMonHoc = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaNhomMonHoc.ToString())];
			entity.HeSoBacDaoTao = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoBacDaoTao.ToString())];
			entity.HeSoLopDong = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoLopDong.ToString())];
			entity.HeSoMonThucTap = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoMonThucTap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoMonThucTap.ToString())];
			entity.HeSoCoVanHocTap = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoCoVanHocTap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.HeSoCoVanHocTap.ToString())];
			entity.SoTietQuyDoi = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.SoTietQuyDoi.ToString())];
			entity.MaHocHam = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaLoaiGiangVien.ToString())];
			entity.MaDonVi = (reader[DuTruGioGiangTruocThoiKhoaBieuColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(DuTruGioGiangTruocThoiKhoaBieuColumn.MaDonVi.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaQuanLy = Convert.IsDBNull(dataRow["MaQuanLy"]) ? null : (System.String)dataRow["MaQuanLy"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.TenLopHocPhan = Convert.IsDBNull(dataRow["TenLopHocPhan"]) ? null : (System.String)dataRow["TenLopHocPhan"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.TenLoaiHocPhan = Convert.IsDBNull(dataRow["TenLoaiHocPhan"]) ? null : (System.String)dataRow["TenLoaiHocPhan"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.MaNhomMonHoc = Convert.IsDBNull(dataRow["MaNhomMonHoc"]) ? null : (System.Int32?)dataRow["MaNhomMonHoc"];
			entity.HeSoBacDaoTao = Convert.IsDBNull(dataRow["HeSoBacDaoTao"]) ? null : (System.Decimal?)dataRow["HeSoBacDaoTao"];
			entity.HeSoLopDong = Convert.IsDBNull(dataRow["HeSoLopDong"]) ? null : (System.Decimal?)dataRow["HeSoLopDong"];
			entity.HeSoMonThucTap = Convert.IsDBNull(dataRow["HeSoMonThucTap"]) ? null : (System.Decimal?)dataRow["HeSoMonThucTap"];
			entity.HeSoCoVanHocTap = Convert.IsDBNull(dataRow["HeSoCoVanHocTap"]) ? null : (System.Decimal?)dataRow["HeSoCoVanHocTap"];
			entity.SoTietQuyDoi = Convert.IsDBNull(dataRow["SoTietQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietQuyDoi"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.String)dataRow["MaDonVi"];
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
		/// <param name="entity">The <see cref="PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region DuTruGioGiangTruocThoiKhoaBieuChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.DuTruGioGiangTruocThoiKhoaBieu</c>
	///</summary>
	public enum DuTruGioGiangTruocThoiKhoaBieuChildEntityTypes
	{
	}
	
	#endregion DuTruGioGiangTruocThoiKhoaBieuChildEntityTypes
	
	#region DuTruGioGiangTruocThoiKhoaBieuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;DuTruGioGiangTruocThoiKhoaBieuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangTruocThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DuTruGioGiangTruocThoiKhoaBieuFilterBuilder : SqlFilterBuilder<DuTruGioGiangTruocThoiKhoaBieuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocThoiKhoaBieuFilterBuilder class.
		/// </summary>
		public DuTruGioGiangTruocThoiKhoaBieuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocThoiKhoaBieuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DuTruGioGiangTruocThoiKhoaBieuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocThoiKhoaBieuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DuTruGioGiangTruocThoiKhoaBieuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DuTruGioGiangTruocThoiKhoaBieuFilterBuilder
	
	#region DuTruGioGiangTruocThoiKhoaBieuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;DuTruGioGiangTruocThoiKhoaBieuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangTruocThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DuTruGioGiangTruocThoiKhoaBieuParameterBuilder : ParameterizedSqlFilterBuilder<DuTruGioGiangTruocThoiKhoaBieuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocThoiKhoaBieuParameterBuilder class.
		/// </summary>
		public DuTruGioGiangTruocThoiKhoaBieuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocThoiKhoaBieuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DuTruGioGiangTruocThoiKhoaBieuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocThoiKhoaBieuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DuTruGioGiangTruocThoiKhoaBieuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DuTruGioGiangTruocThoiKhoaBieuParameterBuilder
	
	#region DuTruGioGiangTruocThoiKhoaBieuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;DuTruGioGiangTruocThoiKhoaBieuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DuTruGioGiangTruocThoiKhoaBieu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class DuTruGioGiangTruocThoiKhoaBieuSortBuilder : SqlSortBuilder<DuTruGioGiangTruocThoiKhoaBieuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocThoiKhoaBieuSqlSortBuilder class.
		/// </summary>
		public DuTruGioGiangTruocThoiKhoaBieuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion DuTruGioGiangTruocThoiKhoaBieuSortBuilder
	
} // end namespace
