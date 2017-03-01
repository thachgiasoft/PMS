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
	/// This class is the base class for any <see cref="QuyDoiGioChuanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class QuyDoiGioChuanProviderBaseCore : EntityProviderBase<PMS.Entities.QuyDoiGioChuan, PMS.Entities.QuyDoiGioChuanKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.QuyDoiGioChuanKey key)
		{
			return Delete(transactionManager, key.MaQuyDoi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maQuyDoi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maQuyDoi)
		{
			return Delete(null, _maQuyDoi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyDoi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maQuyDoi);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiGioChuan_DonViTinh key.
		///		FK_QuyDoiGioChuan_DonViTinh Description: 
		/// </summary>
		/// <param name="_maDonVi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiGioChuan objects.</returns>
		public TList<QuyDoiGioChuan> GetByMaDonVi(System.Int32? _maDonVi)
		{
			int count = -1;
			return GetByMaDonVi(_maDonVi, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiGioChuan_DonViTinh key.
		///		FK_QuyDoiGioChuan_DonViTinh Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonVi"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiGioChuan objects.</returns>
		/// <remarks></remarks>
		public TList<QuyDoiGioChuan> GetByMaDonVi(TransactionManager transactionManager, System.Int32? _maDonVi)
		{
			int count = -1;
			return GetByMaDonVi(transactionManager, _maDonVi, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiGioChuan_DonViTinh key.
		///		FK_QuyDoiGioChuan_DonViTinh Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiGioChuan objects.</returns>
		public TList<QuyDoiGioChuan> GetByMaDonVi(TransactionManager transactionManager, System.Int32? _maDonVi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaDonVi(transactionManager, _maDonVi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiGioChuan_DonViTinh key.
		///		fkQuyDoiGioChuanDonViTinh Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maDonVi"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiGioChuan objects.</returns>
		public TList<QuyDoiGioChuan> GetByMaDonVi(System.Int32? _maDonVi, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaDonVi(null, _maDonVi, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiGioChuan_DonViTinh key.
		///		fkQuyDoiGioChuanDonViTinh Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maDonVi"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiGioChuan objects.</returns>
		public TList<QuyDoiGioChuan> GetByMaDonVi(System.Int32? _maDonVi, int start, int pageLength,out int count)
		{
			return GetByMaDonVi(null, _maDonVi, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiGioChuan_DonViTinh key.
		///		FK_QuyDoiGioChuan_DonViTinh Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maDonVi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiGioChuan objects.</returns>
		public abstract TList<QuyDoiGioChuan> GetByMaDonVi(TransactionManager transactionManager, System.Int32? _maDonVi, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiGioChuan_LoaiKhoiLuong key.
		///		FK_QuyDoiGioChuan_LoaiKhoiLuong Description: 
		/// </summary>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiGioChuan objects.</returns>
		public TList<QuyDoiGioChuan> GetByMaLoaiKhoiLuong(System.String _maLoaiKhoiLuong)
		{
			int count = -1;
			return GetByMaLoaiKhoiLuong(_maLoaiKhoiLuong, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiGioChuan_LoaiKhoiLuong key.
		///		FK_QuyDoiGioChuan_LoaiKhoiLuong Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiGioChuan objects.</returns>
		/// <remarks></remarks>
		public TList<QuyDoiGioChuan> GetByMaLoaiKhoiLuong(TransactionManager transactionManager, System.String _maLoaiKhoiLuong)
		{
			int count = -1;
			return GetByMaLoaiKhoiLuong(transactionManager, _maLoaiKhoiLuong, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiGioChuan_LoaiKhoiLuong key.
		///		FK_QuyDoiGioChuan_LoaiKhoiLuong Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiGioChuan objects.</returns>
		public TList<QuyDoiGioChuan> GetByMaLoaiKhoiLuong(TransactionManager transactionManager, System.String _maLoaiKhoiLuong, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiKhoiLuong(transactionManager, _maLoaiKhoiLuong, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiGioChuan_LoaiKhoiLuong key.
		///		fkQuyDoiGioChuanLoaiKhoiLuong Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiGioChuan objects.</returns>
		public TList<QuyDoiGioChuan> GetByMaLoaiKhoiLuong(System.String _maLoaiKhoiLuong, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaLoaiKhoiLuong(null, _maLoaiKhoiLuong, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiGioChuan_LoaiKhoiLuong key.
		///		fkQuyDoiGioChuanLoaiKhoiLuong Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiGioChuan objects.</returns>
		public TList<QuyDoiGioChuan> GetByMaLoaiKhoiLuong(System.String _maLoaiKhoiLuong, int start, int pageLength,out int count)
		{
			return GetByMaLoaiKhoiLuong(null, _maLoaiKhoiLuong, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_QuyDoiGioChuan_LoaiKhoiLuong key.
		///		FK_QuyDoiGioChuan_LoaiKhoiLuong Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiKhoiLuong"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.QuyDoiGioChuan objects.</returns>
		public abstract TList<QuyDoiGioChuan> GetByMaLoaiKhoiLuong(TransactionManager transactionManager, System.String _maLoaiKhoiLuong, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.QuyDoiGioChuan Get(TransactionManager transactionManager, PMS.Entities.QuyDoiGioChuanKey key, int start, int pageLength)
		{
			return GetByMaQuyDoi(transactionManager, key.MaQuyDoi, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_QuyDoiGioChuan index.
		/// </summary>
		/// <param name="_maQuyDoi"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiGioChuan"/> class.</returns>
		public PMS.Entities.QuyDoiGioChuan GetByMaQuyDoi(System.Int32 _maQuyDoi)
		{
			int count = -1;
			return GetByMaQuyDoi(null,_maQuyDoi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiGioChuan index.
		/// </summary>
		/// <param name="_maQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiGioChuan"/> class.</returns>
		public PMS.Entities.QuyDoiGioChuan GetByMaQuyDoi(System.Int32 _maQuyDoi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuyDoi(null, _maQuyDoi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiGioChuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyDoi"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiGioChuan"/> class.</returns>
		public PMS.Entities.QuyDoiGioChuan GetByMaQuyDoi(TransactionManager transactionManager, System.Int32 _maQuyDoi)
		{
			int count = -1;
			return GetByMaQuyDoi(transactionManager, _maQuyDoi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiGioChuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiGioChuan"/> class.</returns>
		public PMS.Entities.QuyDoiGioChuan GetByMaQuyDoi(TransactionManager transactionManager, System.Int32 _maQuyDoi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuyDoi(transactionManager, _maQuyDoi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiGioChuan index.
		/// </summary>
		/// <param name="_maQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiGioChuan"/> class.</returns>
		public PMS.Entities.QuyDoiGioChuan GetByMaQuyDoi(System.Int32 _maQuyDoi, int start, int pageLength, out int count)
		{
			return GetByMaQuyDoi(null, _maQuyDoi, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QuyDoiGioChuan index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.QuyDoiGioChuan"/> class.</returns>
		public abstract PMS.Entities.QuyDoiGioChuan GetByMaQuyDoi(TransactionManager transactionManager, System.Int32 _maQuyDoi, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_QuyDoiGioChuan_GetByMaLoaiKhoiLuongNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiGioChuan_GetByMaLoaiKhoiLuongNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDoiGioChuan&gt;"/> instance.</returns>
		public TList<QuyDoiGioChuan> GetByMaLoaiKhoiLuongNamHocHocKy(System.String maLoaiKhoiLuong, System.String namHoc, System.String hocKy)
		{
			return GetByMaLoaiKhoiLuongNamHocHocKy(null, 0, int.MaxValue , maLoaiKhoiLuong, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiGioChuan_GetByMaLoaiKhoiLuongNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDoiGioChuan&gt;"/> instance.</returns>
		public TList<QuyDoiGioChuan> GetByMaLoaiKhoiLuongNamHocHocKy(int start, int pageLength, System.String maLoaiKhoiLuong, System.String namHoc, System.String hocKy)
		{
			return GetByMaLoaiKhoiLuongNamHocHocKy(null, start, pageLength , maLoaiKhoiLuong, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_QuyDoiGioChuan_GetByMaLoaiKhoiLuongNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDoiGioChuan&gt;"/> instance.</returns>
		public TList<QuyDoiGioChuan> GetByMaLoaiKhoiLuongNamHocHocKy(TransactionManager transactionManager, System.String maLoaiKhoiLuong, System.String namHoc, System.String hocKy)
		{
			return GetByMaLoaiKhoiLuongNamHocHocKy(transactionManager, 0, int.MaxValue , maLoaiKhoiLuong, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiGioChuan_GetByMaLoaiKhoiLuongNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDoiGioChuan&gt;"/> instance.</returns>
		public abstract TList<QuyDoiGioChuan> GetByMaLoaiKhoiLuongNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maLoaiKhoiLuong, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_QuyDoiGioChuan_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiGioChuan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDoiGioChuan&gt;"/> instance.</returns>
		public TList<QuyDoiGioChuan> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiGioChuan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDoiGioChuan&gt;"/> instance.</returns>
		public TList<QuyDoiGioChuan> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_QuyDoiGioChuan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDoiGioChuan&gt;"/> instance.</returns>
		public TList<QuyDoiGioChuan> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiGioChuan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDoiGioChuan&gt;"/> instance.</returns>
		public abstract TList<QuyDoiGioChuan> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_QuyDoiGioChuan_GetByNamHocHocKyKlk 
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiGioChuan_GetByNamHocHocKyKlk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDoiGioChuan&gt;"/> instance.</returns>
		public TList<QuyDoiGioChuan> GetByNamHocHocKyKlk(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyKlk(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiGioChuan_GetByNamHocHocKyKlk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDoiGioChuan&gt;"/> instance.</returns>
		public TList<QuyDoiGioChuan> GetByNamHocHocKyKlk(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyKlk(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_QuyDoiGioChuan_GetByNamHocHocKyKlk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDoiGioChuan&gt;"/> instance.</returns>
		public TList<QuyDoiGioChuan> GetByNamHocHocKyKlk(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyKlk(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiGioChuan_GetByNamHocHocKyKlk' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;QuyDoiGioChuan&gt;"/> instance.</returns>
		public abstract TList<QuyDoiGioChuan> GetByNamHocHocKyKlk(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_QuyDoiGioChuan_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_QuyDoiGioChuan_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_QuyDoiGioChuan_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_QuyDoiGioChuan_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_QuyDoiGioChuan_SaoChep' stored procedure. 
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
		/// Fill a TList&lt;QuyDoiGioChuan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;QuyDoiGioChuan&gt;"/></returns>
		public static TList<QuyDoiGioChuan> Fill(IDataReader reader, TList<QuyDoiGioChuan> rows, int start, int pageLength)
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
				
				PMS.Entities.QuyDoiGioChuan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("QuyDoiGioChuan")
					.Append("|").Append((System.Int32)reader[((int)QuyDoiGioChuanColumn.MaQuyDoi - 1)]).ToString();
					c = EntityManager.LocateOrCreate<QuyDoiGioChuan>(
					key.ToString(), // EntityTrackingKey
					"QuyDoiGioChuan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.QuyDoiGioChuan();
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
					c.MaQuyDoi = (System.Int32)reader[(QuyDoiGioChuanColumn.MaQuyDoi.ToString())];
					c.MaDonVi = (reader[QuyDoiGioChuanColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDoiGioChuanColumn.MaDonVi.ToString())];
					c.MaQuanLy = (System.String)reader[(QuyDoiGioChuanColumn.MaQuanLy.ToString())];
					c.TenQuyDoi = (reader[QuyDoiGioChuanColumn.TenQuyDoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.TenQuyDoi.ToString())];
					c.SoLuong = (reader[QuyDoiGioChuanColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDoiGioChuanColumn.SoLuong.ToString())];
					c.HeSo = (reader[QuyDoiGioChuanColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiGioChuanColumn.HeSo.ToString())];
					c.CongDon = (reader[QuyDoiGioChuanColumn.CongDon.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(QuyDoiGioChuanColumn.CongDon.ToString())];
					c.LoaiQuyDoi = (reader[QuyDoiGioChuanColumn.LoaiQuyDoi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDoiGioChuanColumn.LoaiQuyDoi.ToString())];
					c.ThuTu = (reader[QuyDoiGioChuanColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDoiGioChuanColumn.ThuTu.ToString())];
					c.NamHoc = (reader[QuyDoiGioChuanColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.NamHoc.ToString())];
					c.HocKy = (reader[QuyDoiGioChuanColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.HocKy.ToString())];
					c.NgayCapNhat = (reader[QuyDoiGioChuanColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[QuyDoiGioChuanColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.NguoiCapNhat.ToString())];
					c.GhiChu = (reader[QuyDoiGioChuanColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.GhiChu.ToString())];
					c.MaLoaiKhoiLuong = (reader[QuyDoiGioChuanColumn.MaLoaiKhoiLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.MaLoaiKhoiLuong.ToString())];
					c.CoSuDungHeSoChucDanh = (reader[QuyDoiGioChuanColumn.CoSuDungHeSoChucDanh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(QuyDoiGioChuanColumn.CoSuDungHeSoChucDanh.ToString())];
					c.NhomMonHoc = (reader[QuyDoiGioChuanColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.NhomMonHoc.ToString())];
					c.KhoaNhapLieu = (reader[QuyDoiGioChuanColumn.KhoaNhapLieu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(QuyDoiGioChuanColumn.KhoaNhapLieu.ToString())];
					c.MaBacDaoTao = (reader[QuyDoiGioChuanColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.MaBacDaoTao.ToString())];
					c.MaLoaiHinh = (reader[QuyDoiGioChuanColumn.MaLoaiHinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.MaLoaiHinh.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.QuyDoiGioChuan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.QuyDoiGioChuan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.QuyDoiGioChuan entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuyDoi = (System.Int32)reader[(QuyDoiGioChuanColumn.MaQuyDoi.ToString())];
			entity.MaDonVi = (reader[QuyDoiGioChuanColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDoiGioChuanColumn.MaDonVi.ToString())];
			entity.MaQuanLy = (System.String)reader[(QuyDoiGioChuanColumn.MaQuanLy.ToString())];
			entity.TenQuyDoi = (reader[QuyDoiGioChuanColumn.TenQuyDoi.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.TenQuyDoi.ToString())];
			entity.SoLuong = (reader[QuyDoiGioChuanColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDoiGioChuanColumn.SoLuong.ToString())];
			entity.HeSo = (reader[QuyDoiGioChuanColumn.HeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(QuyDoiGioChuanColumn.HeSo.ToString())];
			entity.CongDon = (reader[QuyDoiGioChuanColumn.CongDon.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(QuyDoiGioChuanColumn.CongDon.ToString())];
			entity.LoaiQuyDoi = (reader[QuyDoiGioChuanColumn.LoaiQuyDoi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDoiGioChuanColumn.LoaiQuyDoi.ToString())];
			entity.ThuTu = (reader[QuyDoiGioChuanColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(QuyDoiGioChuanColumn.ThuTu.ToString())];
			entity.NamHoc = (reader[QuyDoiGioChuanColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.NamHoc.ToString())];
			entity.HocKy = (reader[QuyDoiGioChuanColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.HocKy.ToString())];
			entity.NgayCapNhat = (reader[QuyDoiGioChuanColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[QuyDoiGioChuanColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.NguoiCapNhat.ToString())];
			entity.GhiChu = (reader[QuyDoiGioChuanColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.GhiChu.ToString())];
			entity.MaLoaiKhoiLuong = (reader[QuyDoiGioChuanColumn.MaLoaiKhoiLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.MaLoaiKhoiLuong.ToString())];
			entity.CoSuDungHeSoChucDanh = (reader[QuyDoiGioChuanColumn.CoSuDungHeSoChucDanh.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(QuyDoiGioChuanColumn.CoSuDungHeSoChucDanh.ToString())];
			entity.NhomMonHoc = (reader[QuyDoiGioChuanColumn.NhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.NhomMonHoc.ToString())];
			entity.KhoaNhapLieu = (reader[QuyDoiGioChuanColumn.KhoaNhapLieu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(QuyDoiGioChuanColumn.KhoaNhapLieu.ToString())];
			entity.MaBacDaoTao = (reader[QuyDoiGioChuanColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.MaBacDaoTao.ToString())];
			entity.MaLoaiHinh = (reader[QuyDoiGioChuanColumn.MaLoaiHinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(QuyDoiGioChuanColumn.MaLoaiHinh.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.QuyDoiGioChuan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.QuyDoiGioChuan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.QuyDoiGioChuan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuyDoi = (System.Int32)dataRow["MaQuyDoi"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.Int32?)dataRow["MaDonVi"];
			entity.MaQuanLy = (System.String)dataRow["MaQuanLy"];
			entity.TenQuyDoi = Convert.IsDBNull(dataRow["TenQuyDoi"]) ? null : (System.String)dataRow["TenQuyDoi"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Int32?)dataRow["SoLuong"];
			entity.HeSo = Convert.IsDBNull(dataRow["HeSo"]) ? null : (System.Decimal?)dataRow["HeSo"];
			entity.CongDon = Convert.IsDBNull(dataRow["CongDon"]) ? null : (System.Boolean?)dataRow["CongDon"];
			entity.LoaiQuyDoi = Convert.IsDBNull(dataRow["LoaiQuyDoi"]) ? null : (System.Int32?)dataRow["LoaiQuyDoi"];
			entity.ThuTu = Convert.IsDBNull(dataRow["ThuTu"]) ? null : (System.Int32?)dataRow["ThuTu"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.MaLoaiKhoiLuong = Convert.IsDBNull(dataRow["MaLoaiKhoiLuong"]) ? null : (System.String)dataRow["MaLoaiKhoiLuong"];
			entity.CoSuDungHeSoChucDanh = Convert.IsDBNull(dataRow["CoSuDungHeSoChucDanh"]) ? null : (System.Boolean?)dataRow["CoSuDungHeSoChucDanh"];
			entity.NhomMonHoc = Convert.IsDBNull(dataRow["NhomMonHoc"]) ? null : (System.String)dataRow["NhomMonHoc"];
			entity.KhoaNhapLieu = Convert.IsDBNull(dataRow["KhoaNhapLieu"]) ? null : (System.Boolean?)dataRow["KhoaNhapLieu"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.MaLoaiHinh = Convert.IsDBNull(dataRow["MaLoaiHinh"]) ? null : (System.String)dataRow["MaLoaiHinh"];
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
		/// <param name="entity">The <see cref="PMS.Entities.QuyDoiGioChuan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.QuyDoiGioChuan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.QuyDoiGioChuan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaDonViSource	
			if (CanDeepLoad(entity, "DonViTinh|MaDonViSource", deepLoadType, innerList) 
				&& entity.MaDonViSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaDonVi ?? (int)0);
				DonViTinh tmpEntity = EntityManager.LocateEntity<DonViTinh>(EntityLocator.ConstructKeyFromPkItems(typeof(DonViTinh), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaDonViSource = tmpEntity;
				else
					entity.MaDonViSource = DataRepository.DonViTinhProvider.GetByMaDonVi(transactionManager, (entity.MaDonVi ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaDonViSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaDonViSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.DonViTinhProvider.DeepLoad(transactionManager, entity.MaDonViSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaDonViSource

			#region MaLoaiKhoiLuongSource	
			if (CanDeepLoad(entity, "LoaiKhoiLuong|MaLoaiKhoiLuongSource", deepLoadType, innerList) 
				&& entity.MaLoaiKhoiLuongSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaLoaiKhoiLuong ?? string.Empty);
				LoaiKhoiLuong tmpEntity = EntityManager.LocateEntity<LoaiKhoiLuong>(EntityLocator.ConstructKeyFromPkItems(typeof(LoaiKhoiLuong), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaLoaiKhoiLuongSource = tmpEntity;
				else
					entity.MaLoaiKhoiLuongSource = DataRepository.LoaiKhoiLuongProvider.GetByMaLoaiKhoiLuong(transactionManager, (entity.MaLoaiKhoiLuong ?? string.Empty));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaLoaiKhoiLuongSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaLoaiKhoiLuongSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.LoaiKhoiLuongProvider.DeepLoad(transactionManager, entity.MaLoaiKhoiLuongSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaLoaiKhoiLuongSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaQuyDoi methods when available
			
			#region KhoiLuongCacCongViecKhacCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<KhoiLuongCacCongViecKhac>|KhoiLuongCacCongViecKhacCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'KhoiLuongCacCongViecKhacCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.KhoiLuongCacCongViecKhacCollection = DataRepository.KhoiLuongCacCongViecKhacProvider.GetByMaLoaiCongViec(transactionManager, entity.MaQuyDoi);

				if (deep && entity.KhoiLuongCacCongViecKhacCollection.Count > 0)
				{
					deepHandles.Add("KhoiLuongCacCongViecKhacCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<KhoiLuongCacCongViecKhac>) DataRepository.KhoiLuongCacCongViecKhacProvider.DeepLoad,
						new object[] { transactionManager, entity.KhoiLuongCacCongViecKhacCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region KhoanQuyDoiCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<KhoanQuyDoi>|KhoanQuyDoiCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'KhoanQuyDoiCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.KhoanQuyDoiCollection = DataRepository.KhoanQuyDoiProvider.GetByMaQuyDoi(transactionManager, entity.MaQuyDoi);

				if (deep && entity.KhoanQuyDoiCollection.Count > 0)
				{
					deepHandles.Add("KhoanQuyDoiCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<KhoanQuyDoi>) DataRepository.KhoanQuyDoiProvider.DeepLoad,
						new object[] { transactionManager, entity.KhoanQuyDoiCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.QuyDoiGioChuan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.QuyDoiGioChuan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.QuyDoiGioChuan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.QuyDoiGioChuan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaDonViSource
			if (CanDeepSave(entity, "DonViTinh|MaDonViSource", deepSaveType, innerList) 
				&& entity.MaDonViSource != null)
			{
				DataRepository.DonViTinhProvider.Save(transactionManager, entity.MaDonViSource);
				entity.MaDonVi = entity.MaDonViSource.MaDonVi;
			}
			#endregion 
			
			#region MaLoaiKhoiLuongSource
			if (CanDeepSave(entity, "LoaiKhoiLuong|MaLoaiKhoiLuongSource", deepSaveType, innerList) 
				&& entity.MaLoaiKhoiLuongSource != null)
			{
				DataRepository.LoaiKhoiLuongProvider.Save(transactionManager, entity.MaLoaiKhoiLuongSource);
				entity.MaLoaiKhoiLuong = entity.MaLoaiKhoiLuongSource.MaLoaiKhoiLuong;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<KhoiLuongCacCongViecKhac>
				if (CanDeepSave(entity.KhoiLuongCacCongViecKhacCollection, "List<KhoiLuongCacCongViecKhac>|KhoiLuongCacCongViecKhacCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(KhoiLuongCacCongViecKhac child in entity.KhoiLuongCacCongViecKhacCollection)
					{
						if(child.MaLoaiCongViecSource != null)
						{
							child.MaLoaiCongViec = child.MaLoaiCongViecSource.MaQuyDoi;
						}
						else
						{
							child.MaLoaiCongViec = entity.MaQuyDoi;
						}

					}

					if (entity.KhoiLuongCacCongViecKhacCollection.Count > 0 || entity.KhoiLuongCacCongViecKhacCollection.DeletedItems.Count > 0)
					{
						//DataRepository.KhoiLuongCacCongViecKhacProvider.Save(transactionManager, entity.KhoiLuongCacCongViecKhacCollection);
						
						deepHandles.Add("KhoiLuongCacCongViecKhacCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< KhoiLuongCacCongViecKhac >) DataRepository.KhoiLuongCacCongViecKhacProvider.DeepSave,
							new object[] { transactionManager, entity.KhoiLuongCacCongViecKhacCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<KhoanQuyDoi>
				if (CanDeepSave(entity.KhoanQuyDoiCollection, "List<KhoanQuyDoi>|KhoanQuyDoiCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(KhoanQuyDoi child in entity.KhoanQuyDoiCollection)
					{
						if(child.MaQuyDoiSource != null)
						{
							child.MaQuyDoi = child.MaQuyDoiSource.MaQuyDoi;
						}
						else
						{
							child.MaQuyDoi = entity.MaQuyDoi;
						}

					}

					if (entity.KhoanQuyDoiCollection.Count > 0 || entity.KhoanQuyDoiCollection.DeletedItems.Count > 0)
					{
						//DataRepository.KhoanQuyDoiProvider.Save(transactionManager, entity.KhoanQuyDoiCollection);
						
						deepHandles.Add("KhoanQuyDoiCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< KhoanQuyDoi >) DataRepository.KhoanQuyDoiProvider.DeepSave,
							new object[] { transactionManager, entity.KhoanQuyDoiCollection, deepSaveType, childTypes, innerList }
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
	
	#region QuyDoiGioChuanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.QuyDoiGioChuan</c>
	///</summary>
	public enum QuyDoiGioChuanChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>DonViTinh</c> at MaDonViSource
		///</summary>
		[ChildEntityType(typeof(DonViTinh))]
		DonViTinh,
		
		///<summary>
		/// Composite Property for <c>LoaiKhoiLuong</c> at MaLoaiKhoiLuongSource
		///</summary>
		[ChildEntityType(typeof(LoaiKhoiLuong))]
		LoaiKhoiLuong,
		///<summary>
		/// Collection of <c>QuyDoiGioChuan</c> as OneToMany for KhoiLuongCacCongViecKhacCollection
		///</summary>
		[ChildEntityType(typeof(TList<KhoiLuongCacCongViecKhac>))]
		KhoiLuongCacCongViecKhacCollection,
		///<summary>
		/// Collection of <c>QuyDoiGioChuan</c> as OneToMany for KhoanQuyDoiCollection
		///</summary>
		[ChildEntityType(typeof(TList<KhoanQuyDoi>))]
		KhoanQuyDoiCollection,
	}
	
	#endregion QuyDoiGioChuanChildEntityTypes
	
	#region QuyDoiGioChuanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;QuyDoiGioChuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiGioChuanFilterBuilder : SqlFilterBuilder<QuyDoiGioChuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiGioChuanFilterBuilder class.
		/// </summary>
		public QuyDoiGioChuanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the QuyDoiGioChuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public QuyDoiGioChuanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the QuyDoiGioChuanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public QuyDoiGioChuanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion QuyDoiGioChuanFilterBuilder
	
	#region QuyDoiGioChuanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;QuyDoiGioChuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiGioChuanParameterBuilder : ParameterizedSqlFilterBuilder<QuyDoiGioChuanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiGioChuanParameterBuilder class.
		/// </summary>
		public QuyDoiGioChuanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the QuyDoiGioChuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public QuyDoiGioChuanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the QuyDoiGioChuanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public QuyDoiGioChuanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion QuyDoiGioChuanParameterBuilder
	
	#region QuyDoiGioChuanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;QuyDoiGioChuanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiGioChuan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class QuyDoiGioChuanSortBuilder : SqlSortBuilder<QuyDoiGioChuanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiGioChuanSqlSortBuilder class.
		/// </summary>
		public QuyDoiGioChuanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion QuyDoiGioChuanSortBuilder
	
} // end namespace
