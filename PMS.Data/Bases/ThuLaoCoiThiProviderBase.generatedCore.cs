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
	/// This class is the base class for any <see cref="ThuLaoCoiThiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThuLaoCoiThiProviderBaseCore : EntityProviderBase<PMS.Entities.ThuLaoCoiThi, PMS.Entities.ThuLaoCoiThiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThiKey key)
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
		public override PMS.Entities.ThuLaoCoiThi Get(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThiKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThuLaoCoiThi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThi"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThi GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThi"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThi GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThi"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThi GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThi"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThi GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThi index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThi"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThi GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThi"/> class.</returns>
		public abstract PMS.Entities.ThuLaoCoiThi GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThuLaoCoiThi_KiemTraChotTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_KiemTraChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChotTheoKhoa(System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String dotThanhToan, ref System.Int32 reVal)
		{
			 KiemTraChotTheoKhoa(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_KiemTraChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChotTheoKhoa(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String dotThanhToan, ref System.Int32 reVal)
		{
			 KiemTraChotTheoKhoa(null, start, pageLength , namHoc, hocKy, khoaDonVi, dotThanhToan, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_KiemTraChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChotTheoKhoa(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String dotThanhToan, ref System.Int32 reVal)
		{
			 KiemTraChotTheoKhoa(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_KiemTraChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraChotTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String dotThanhToan, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_GetDotThanhToanByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetDotThanhToanByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDotThanhToanByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetDotThanhToanByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetDotThanhToanByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDotThanhToanByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetDotThanhToanByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetDotThanhToanByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDotThanhToanByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetDotThanhToanByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetDotThanhToanByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetDotThanhToanByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_HuyChotTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_HuyChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotTheoKhoa(System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String dotThanhToan)
		{
			 HuyChotTheoKhoa(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_HuyChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotTheoKhoa(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String dotThanhToan)
		{
			 HuyChotTheoKhoa(null, start, pageLength , namHoc, hocKy, khoaDonVi, dotThanhToan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_HuyChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotTheoKhoa(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String dotThanhToan)
		{
			 HuyChotTheoKhoa(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_HuyChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChotTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String dotThanhToan);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal)
		{
			 DongBo(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal)
		{
			 DongBo(null, start, pageLength , namHoc, hocKy, dotThanhToan, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal)
		{
			 DongBo(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_GetByNamHocHocKyDongBo 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDongBo(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyDongBo(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDongBo(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyDongBo(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDongBo(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKyDongBo(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyDongBo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String dotThanhToan)
		{
			return GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String dotThanhToan)
		{
			return GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, dotThanhToan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String dotThanhToan)
		{
			return GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.String dotThanhToan);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_HuyChot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(System.String namHoc, System.String hocKy, System.String dotThanhToan)
		{
			 HuyChot(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dotThanhToan)
		{
			 HuyChot(null, start, pageLength , namHoc, hocKy, dotThanhToan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dotThanhToan)
		{
			 HuyChot(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dotThanhToan);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_GetByMaGiangVienNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHocHocKy(System.String maGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetByMaGiangVienNamHocHocKy(null, 0, int.MaxValue , maGiangVien, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHocHocKy(int start, int pageLength, System.String maGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetByMaGiangVienNamHocHocKy(null, start, pageLength , maGiangVien, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHocHocKy(TransactionManager transactionManager, System.String maGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetByMaGiangVienNamHocHocKy(transactionManager, 0, int.MaxValue , maGiangVien, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByMaGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByMaGiangVienNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVien, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaLoaiGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaLoaiGiangVien(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien)
		{
			return GetByNamHocHocKyKhoaLoaiGiangVien(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaLoaiGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien)
		{
			return GetByNamHocHocKyKhoaLoaiGiangVien(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaLoaiGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien)
		{
			return GetByNamHocHocKyKhoaLoaiGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyKhoaLoaiGiangVien(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_GetByNamHocHocKy_Act 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKy_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy_Act(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy_Act(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKy_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy_Act(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy_Act(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKy_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKy_Act(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy_Act(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKy_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKy_Act(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_GetByNamHocHocKyDotThanhToanDongBo 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyDotThanhToanDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotThanhToanDongBo(System.String namHoc, System.String hocKy, System.String dotThanhToan)
		{
			return GetByNamHocHocKyDotThanhToanDongBo(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyDotThanhToanDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotThanhToanDongBo(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dotThanhToan)
		{
			return GetByNamHocHocKyDotThanhToanDongBo(null, start, pageLength , namHoc, hocKy, dotThanhToan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyDotThanhToanDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotThanhToanDongBo(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dotThanhToan)
		{
			return GetByNamHocHocKyDotThanhToanDongBo(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyDotThanhToanDongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyDotThanhToanDongBo(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dotThanhToan);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_ChotTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_ChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotTheoKhoa(System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String dotThanhToan)
		{
			 ChotTheoKhoa(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_ChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotTheoKhoa(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String dotThanhToan)
		{
			 ChotTheoKhoa(null, start, pageLength , namHoc, hocKy, khoaDonVi, dotThanhToan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_ChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotTheoKhoa(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String dotThanhToan)
		{
			 ChotTheoKhoa(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_ChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ChotTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String dotThanhToan);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_Chot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(System.String namHoc, System.String hocKy, System.String dotThanhToan)
		{
			 Chot(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dotThanhToan)
		{
			 Chot(null, start, pageLength , namHoc, hocKy, dotThanhToan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dotThanhToan)
		{
			 Chot(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Chot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dotThanhToan);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_QuyDoi 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoCoiThi&gt;"/> instance.</returns>
		public TList<ThuLaoCoiThi> QuyDoi(System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal)
		{
			return QuyDoi(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoCoiThi&gt;"/> instance.</returns>
		public TList<ThuLaoCoiThi> QuyDoi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal)
		{
			return QuyDoi(null, start, pageLength , namHoc, hocKy, dotThanhToan, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoCoiThi&gt;"/> instance.</returns>
		public TList<ThuLaoCoiThi> QuyDoi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal)
		{
			return QuyDoi(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoCoiThi&gt;"/> instance.</returns>
		public abstract TList<ThuLaoCoiThi> QuyDoi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_KiemTraChot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal)
		{
			 KiemTraChot(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal)
		{
			 KiemTraChot(null, start, pageLength , namHoc, hocKy, dotThanhToan, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal)
		{
			 KiemTraChot(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_GetByNamHocHocKyMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyMaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyMaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaDonVi_Act 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaDonVi_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi_Act(System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			return GetByNamHocHocKyKhoaDonVi_Act(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaDonVi_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi_Act(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			return GetByNamHocHocKyKhoaDonVi_Act(null, start, pageLength , namHoc, hocKy, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaDonVi_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi_Act(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			return GetByNamHocHocKyKhoaDonVi_Act(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_GetByNamHocHocKyKhoaDonVi_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyKhoaDonVi_Act(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaDonVi);
		
		#endregion
		
		#region cust_ThuLaoCoiThi_DongBoTuThanhTra 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_DongBoTuThanhTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTuThanhTra(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 DongBoTuThanhTra(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_DongBoTuThanhTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTuThanhTra(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 DongBoTuThanhTra(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_DongBoTuThanhTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTuThanhTra(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 DongBoTuThanhTra(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThi_DongBoTuThanhTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBoTuThanhTra(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThuLaoCoiThi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThuLaoCoiThi&gt;"/></returns>
		public static TList<ThuLaoCoiThi> Fill(IDataReader reader, TList<ThuLaoCoiThi> rows, int start, int pageLength)
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
				
				PMS.Entities.ThuLaoCoiThi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThuLaoCoiThi")
					.Append("|").Append((System.Int32)reader[((int)ThuLaoCoiThiColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThuLaoCoiThi>(
					key.ToString(), // EntityTrackingKey
					"ThuLaoCoiThi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThuLaoCoiThi();
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
					c.Id = (System.Int32)reader[(ThuLaoCoiThiColumn.Id.ToString())];
					c.MaGiangVienQuanLy = (reader[ThuLaoCoiThiColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.MaGiangVienQuanLy.ToString())];
					c.KyThi = (reader[ThuLaoCoiThiColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.KyThi.ToString())];
					c.LanThi = (reader[ThuLaoCoiThiColumn.LanThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.LanThi.ToString())];
					c.Ngay = (reader[ThuLaoCoiThiColumn.Ngay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuLaoCoiThiColumn.Ngay.ToString())];
					c.Ca = (reader[ThuLaoCoiThiColumn.Ca.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.Ca.ToString())];
					c.Phong = (reader[ThuLaoCoiThiColumn.Phong.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.Phong.ToString())];
					c.SoTien = (reader[ThuLaoCoiThiColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiColumn.SoTien.ToString())];
					c.NamHoc = (reader[ThuLaoCoiThiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThuLaoCoiThiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.HocKy.ToString())];
					c.NoiDung = (reader[ThuLaoCoiThiColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.NoiDung.ToString())];
					c.MaMonHoc = (reader[ThuLaoCoiThiColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.MaMonHoc.ToString())];
					c.MaHocPhan = (reader[ThuLaoCoiThiColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.MaHocPhan.ToString())];
					c.MaLopHocPhan = (reader[ThuLaoCoiThiColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.MaLopHocPhan.ToString())];
					c.NgayCapNhat = (reader[ThuLaoCoiThiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuLaoCoiThiColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ThuLaoCoiThiColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.NguoiCapNhat.ToString())];
					c.DotChiTra = (reader[ThuLaoCoiThiColumn.DotChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.DotChiTra.ToString())];
					c.MaCoSo = (reader[ThuLaoCoiThiColumn.MaCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.MaCoSo.ToString())];
					c.TietbatDau = (reader[ThuLaoCoiThiColumn.TietbatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiColumn.TietbatDau.ToString())];
					c.ThoiGianLamBai = (reader[ThuLaoCoiThiColumn.ThoiGianLamBai.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiColumn.ThoiGianLamBai.ToString())];
					c.GioCoiThi = (reader[ThuLaoCoiThiColumn.GioCoiThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.GioCoiThi.ToString())];
					c.SoLuongSinhVien = (reader[ThuLaoCoiThiColumn.SoLuongSinhVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiColumn.SoLuongSinhVien.ToString())];
					c.IsSync = (reader[ThuLaoCoiThiColumn.IsSync.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuLaoCoiThiColumn.IsSync.ToString())];
					c.Chot = (reader[ThuLaoCoiThiColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuLaoCoiThiColumn.Chot.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoCoiThi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoCoiThi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThuLaoCoiThi entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ThuLaoCoiThiColumn.Id.ToString())];
			entity.MaGiangVienQuanLy = (reader[ThuLaoCoiThiColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.MaGiangVienQuanLy.ToString())];
			entity.KyThi = (reader[ThuLaoCoiThiColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.KyThi.ToString())];
			entity.LanThi = (reader[ThuLaoCoiThiColumn.LanThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.LanThi.ToString())];
			entity.Ngay = (reader[ThuLaoCoiThiColumn.Ngay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuLaoCoiThiColumn.Ngay.ToString())];
			entity.Ca = (reader[ThuLaoCoiThiColumn.Ca.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.Ca.ToString())];
			entity.Phong = (reader[ThuLaoCoiThiColumn.Phong.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.Phong.ToString())];
			entity.SoTien = (reader[ThuLaoCoiThiColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiColumn.SoTien.ToString())];
			entity.NamHoc = (reader[ThuLaoCoiThiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThuLaoCoiThiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.HocKy.ToString())];
			entity.NoiDung = (reader[ThuLaoCoiThiColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.NoiDung.ToString())];
			entity.MaMonHoc = (reader[ThuLaoCoiThiColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.MaMonHoc.ToString())];
			entity.MaHocPhan = (reader[ThuLaoCoiThiColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.MaHocPhan.ToString())];
			entity.MaLopHocPhan = (reader[ThuLaoCoiThiColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.MaLopHocPhan.ToString())];
			entity.NgayCapNhat = (reader[ThuLaoCoiThiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuLaoCoiThiColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ThuLaoCoiThiColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.NguoiCapNhat.ToString())];
			entity.DotChiTra = (reader[ThuLaoCoiThiColumn.DotChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.DotChiTra.ToString())];
			entity.MaCoSo = (reader[ThuLaoCoiThiColumn.MaCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.MaCoSo.ToString())];
			entity.TietbatDau = (reader[ThuLaoCoiThiColumn.TietbatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiColumn.TietbatDau.ToString())];
			entity.ThoiGianLamBai = (reader[ThuLaoCoiThiColumn.ThoiGianLamBai.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiColumn.ThoiGianLamBai.ToString())];
			entity.GioCoiThi = (reader[ThuLaoCoiThiColumn.GioCoiThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiColumn.GioCoiThi.ToString())];
			entity.SoLuongSinhVien = (reader[ThuLaoCoiThiColumn.SoLuongSinhVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiColumn.SoLuongSinhVien.ToString())];
			entity.IsSync = (reader[ThuLaoCoiThiColumn.IsSync.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuLaoCoiThiColumn.IsSync.ToString())];
			entity.Chot = (reader[ThuLaoCoiThiColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuLaoCoiThiColumn.Chot.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoCoiThi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoCoiThi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThuLaoCoiThi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.KyThi = Convert.IsDBNull(dataRow["KyThi"]) ? null : (System.String)dataRow["KyThi"];
			entity.LanThi = Convert.IsDBNull(dataRow["LanThi"]) ? null : (System.String)dataRow["LanThi"];
			entity.Ngay = Convert.IsDBNull(dataRow["Ngay"]) ? null : (System.DateTime?)dataRow["Ngay"];
			entity.Ca = Convert.IsDBNull(dataRow["Ca"]) ? null : (System.String)dataRow["Ca"];
			entity.Phong = Convert.IsDBNull(dataRow["Phong"]) ? null : (System.String)dataRow["Phong"];
			entity.SoTien = Convert.IsDBNull(dataRow["SoTien"]) ? null : (System.Decimal?)dataRow["SoTien"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.NoiDung = Convert.IsDBNull(dataRow["NoiDung"]) ? null : (System.String)dataRow["NoiDung"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.MaHocPhan = Convert.IsDBNull(dataRow["MaHocPhan"]) ? null : (System.String)dataRow["MaHocPhan"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.DotChiTra = Convert.IsDBNull(dataRow["DotChiTra"]) ? null : (System.String)dataRow["DotChiTra"];
			entity.MaCoSo = Convert.IsDBNull(dataRow["MaCoSo"]) ? null : (System.String)dataRow["MaCoSo"];
			entity.TietbatDau = Convert.IsDBNull(dataRow["TietbatDau"]) ? null : (System.Int32?)dataRow["TietbatDau"];
			entity.ThoiGianLamBai = Convert.IsDBNull(dataRow["ThoiGianLamBai"]) ? null : (System.Int32?)dataRow["ThoiGianLamBai"];
			entity.GioCoiThi = Convert.IsDBNull(dataRow["GioCoiThi"]) ? null : (System.String)dataRow["GioCoiThi"];
			entity.SoLuongSinhVien = Convert.IsDBNull(dataRow["SoLuongSinhVien"]) ? null : (System.Int32?)dataRow["SoLuongSinhVien"];
			entity.IsSync = Convert.IsDBNull(dataRow["IsSync"]) ? null : (System.Boolean?)dataRow["IsSync"];
			entity.Chot = Convert.IsDBNull(dataRow["Chot"]) ? null : (System.Boolean?)dataRow["Chot"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoCoiThi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoCoiThi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThuLaoCoiThi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThuLaoCoiThi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoCoiThi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThuLaoCoiThiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThuLaoCoiThi</c>
	///</summary>
	public enum ThuLaoCoiThiChildEntityTypes
	{
	}
	
	#endregion ThuLaoCoiThiChildEntityTypes
	
	#region ThuLaoCoiThiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThuLaoCoiThiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiFilterBuilder : SqlFilterBuilder<ThuLaoCoiThiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiFilterBuilder class.
		/// </summary>
		public ThuLaoCoiThiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoCoiThiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoCoiThiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoCoiThiFilterBuilder
	
	#region ThuLaoCoiThiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThuLaoCoiThiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiParameterBuilder : ParameterizedSqlFilterBuilder<ThuLaoCoiThiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiParameterBuilder class.
		/// </summary>
		public ThuLaoCoiThiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoCoiThiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoCoiThiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoCoiThiParameterBuilder
	
	#region ThuLaoCoiThiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThuLaoCoiThiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThuLaoCoiThiSortBuilder : SqlSortBuilder<ThuLaoCoiThiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiSqlSortBuilder class.
		/// </summary>
		public ThuLaoCoiThiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThuLaoCoiThiSortBuilder
	
} // end namespace
