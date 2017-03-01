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
	/// This class is the base class for any <see cref="ThuLaoChamBaiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThuLaoChamBaiProviderBaseCore : EntityProviderBase<PMS.Entities.ThuLaoChamBai, PMS.Entities.ThuLaoChamBaiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThuLaoChamBaiKey key)
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
		public override PMS.Entities.ThuLaoChamBai Get(TransactionManager transactionManager, PMS.Entities.ThuLaoChamBaiKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThuLaoChamBai index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamBai"/> class.</returns>
		public PMS.Entities.ThuLaoChamBai GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamBai index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamBai"/> class.</returns>
		public PMS.Entities.ThuLaoChamBai GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamBai index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamBai"/> class.</returns>
		public PMS.Entities.ThuLaoChamBai GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamBai index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamBai"/> class.</returns>
		public PMS.Entities.ThuLaoChamBai GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamBai index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamBai"/> class.</returns>
		public PMS.Entities.ThuLaoChamBai GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoChamBai index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoChamBai"/> class.</returns>
		public abstract PMS.Entities.ThuLaoChamBai GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThuLaoChamBai_KiemTraChotTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_KiemTraChotTheoKhoa' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_KiemTraChotTheoKhoa' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_KiemTraChotTheoKhoa' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_KiemTraChotTheoKhoa' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_GetDotThanhToanByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetDotThanhToanByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetDotThanhToanByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetDotThanhToanByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetDotThanhToanByNamHocHocKy' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_HuyChotTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_HuyChotTheoKhoa' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_HuyChotTheoKhoa' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_HuyChotTheoKhoa' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_HuyChotTheoKhoa' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_KiemTraLayDuLieuChamBaiGiuaKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_KiemTraLayDuLieuChamBaiGiuaKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraLayDuLieuChamBaiGiuaKy(System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 KiemTraLayDuLieuChamBaiGiuaKy(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_KiemTraLayDuLieuChamBaiGiuaKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraLayDuLieuChamBaiGiuaKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 KiemTraLayDuLieuChamBaiGiuaKy(null, start, pageLength , namHoc, hocKy, maDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_KiemTraLayDuLieuChamBaiGiuaKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraLayDuLieuChamBaiGiuaKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 KiemTraLayDuLieuChamBaiGiuaKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_KiemTraLayDuLieuChamBaiGiuaKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraLayDuLieuChamBaiGiuaKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoChamBai_GetDuLieuChamBaiGiuaKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetDuLieuChamBaiGiuaKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDuLieuChamBaiGiuaKy(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetDuLieuChamBaiGiuaKy(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetDuLieuChamBaiGiuaKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDuLieuChamBaiGiuaKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetDuLieuChamBaiGiuaKy(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetDuLieuChamBaiGiuaKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDuLieuChamBaiGiuaKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetDuLieuChamBaiGiuaKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetDuLieuChamBaiGiuaKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetDuLieuChamBaiGiuaKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion
		
		#region cust_ThuLaoChamBai_DongBo 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_DongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_DongBo' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_GetByNamHocHocKyDongBo 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyDongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyDongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyDongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyDongBo' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_BangKeThanhToanTienChamBaiCtim 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_BangKeThanhToanTienChamBaiCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanTienChamBaiCtim(System.String namHoc, System.String hocKy, System.String khoaHoc, System.String bacDaoTao, System.String khoaBoMon, System.Int32 maLoaiGiangVien)
		{
			return BangKeThanhToanTienChamBaiCtim(null, 0, int.MaxValue , namHoc, hocKy, khoaHoc, bacDaoTao, khoaBoMon, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_BangKeThanhToanTienChamBaiCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanTienChamBaiCtim(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaHoc, System.String bacDaoTao, System.String khoaBoMon, System.Int32 maLoaiGiangVien)
		{
			return BangKeThanhToanTienChamBaiCtim(null, start, pageLength , namHoc, hocKy, khoaHoc, bacDaoTao, khoaBoMon, maLoaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_BangKeThanhToanTienChamBaiCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader BangKeThanhToanTienChamBaiCtim(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaHoc, System.String bacDaoTao, System.String khoaBoMon, System.Int32 maLoaiGiangVien)
		{
			return BangKeThanhToanTienChamBaiCtim(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaHoc, bacDaoTao, khoaBoMon, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_BangKeThanhToanTienChamBaiCtim' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="khoaBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader BangKeThanhToanTienChamBaiCtim(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaHoc, System.String bacDaoTao, System.String khoaBoMon, System.Int32 maLoaiGiangVien);
		
		#endregion
		
		#region cust_ThuLaoChamBai_GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoChamBai&gt;"/> instance.</returns>
		public TList<ThuLaoChamBai> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoChamBai&gt;"/> instance.</returns>
		public TList<ThuLaoChamBai> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoChamBai&gt;"/> instance.</returns>
		public TList<ThuLaoChamBai> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoChamBai&gt;"/> instance.</returns>
		public abstract TList<ThuLaoChamBai> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThuLaoChamBai_HuyChot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_HuyChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_HuyChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_HuyChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_HuyChot' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_LuuChamBaiGiuaKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_LuuChamBaiGiuaKy' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuChamBaiGiuaKy(System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 LuuChamBaiGiuaKy(null, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_LuuChamBaiGiuaKy' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuChamBaiGiuaKy(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 LuuChamBaiGiuaKy(null, start, pageLength , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_LuuChamBaiGiuaKy' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuChamBaiGiuaKy(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 LuuChamBaiGiuaKy(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_LuuChamBaiGiuaKy' stored procedure. 
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
		public abstract void LuuChamBaiGiuaKy(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoChamBai_GetByMaGiangVienNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetByMaGiangVienNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByMaGiangVienNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByMaGiangVienNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByMaGiangVienNamHocHocKy' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_GetByNamHocHocKyKhoaLoaiGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyKhoaLoaiGiangVien' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyKhoaLoaiGiangVien' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyKhoaLoaiGiangVien' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyKhoaLoaiGiangVien' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_GetByNamHocHocKy_Act 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKy_Act' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKy_Act' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKy_Act' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKy_Act' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_GetByNamHocHocKyDotThanhToanDongBo 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyDotThanhToanDongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyDotThanhToanDongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyDotThanhToanDongBo' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyDotThanhToanDongBo' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_ChotTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_ChotTheoKhoa' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_ChotTheoKhoa' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_ChotTheoKhoa' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_ChotTheoKhoa' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_Chot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_Chot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_Chot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_Chot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_Chot' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_QuyDoi 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal)
		{
			 QuyDoi(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal)
		{
			 QuyDoi(null, start, pageLength , namHoc, hocKy, dotThanhToan, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal)
		{
			 QuyDoi(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void QuyDoi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dotThanhToan, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoChamBai_KiemTraChot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_KiemTraChot' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_GetByNamHocHocKyKhoaDonVi_Act 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyKhoaDonVi_Act' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyKhoaDonVi_Act' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyKhoaDonVi_Act' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoChamBai_GetByNamHocHocKyKhoaDonVi_Act' stored procedure. 
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
		
		#region cust_ThuLaoChamBai_LayDuLieuGiuaKyTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_LayDuLieuGiuaKyTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieuGiuaKyTheoKhoa(System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 LayDuLieuGiuaKyTheoKhoa(null, 0, int.MaxValue , namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_LayDuLieuGiuaKyTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieuGiuaKyTheoKhoa(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 LayDuLieuGiuaKyTheoKhoa(null, start, pageLength , namHoc, hocKy, maDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_LayDuLieuGiuaKyTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LayDuLieuGiuaKyTheoKhoa(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal)
		{
			 LayDuLieuGiuaKyTheoKhoa(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoChamBai_LayDuLieuGiuaKyTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LayDuLieuGiuaKyTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThuLaoChamBai&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThuLaoChamBai&gt;"/></returns>
		public static TList<ThuLaoChamBai> Fill(IDataReader reader, TList<ThuLaoChamBai> rows, int start, int pageLength)
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
				
				PMS.Entities.ThuLaoChamBai c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThuLaoChamBai")
					.Append("|").Append((System.Int32)reader[((int)ThuLaoChamBaiColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThuLaoChamBai>(
					key.ToString(), // EntityTrackingKey
					"ThuLaoChamBai",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThuLaoChamBai();
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
					c.Id = (System.Int32)reader[(ThuLaoChamBaiColumn.Id.ToString())];
					c.MaGiangVienQuanLy = (reader[ThuLaoChamBaiColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MaGiangVienQuanLy.ToString())];
					c.MaMonHoc = (reader[ThuLaoChamBaiColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MaMonHoc.ToString())];
					c.MaHocPhan = (reader[ThuLaoChamBaiColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MaHocPhan.ToString())];
					c.MaLopHocPhan = (reader[ThuLaoChamBaiColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MaLopHocPhan.ToString())];
					c.MaLop = (reader[ThuLaoChamBaiColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MaLop.ToString())];
					c.LanThi = (reader[ThuLaoChamBaiColumn.LanThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.LanThi.ToString())];
					c.KyThi = (reader[ThuLaoChamBaiColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.KyThi.ToString())];
					c.SoBaiGiuaKy = (reader[ThuLaoChamBaiColumn.SoBaiGiuaKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiColumn.SoBaiGiuaKy.ToString())];
					c.SoBaiQuaTrinh = (reader[ThuLaoChamBaiColumn.SoBaiQuaTrinh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiColumn.SoBaiQuaTrinh.ToString())];
					c.SoBaiCuoiKy = (reader[ThuLaoChamBaiColumn.SoBaiCuoiKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiColumn.SoBaiCuoiKy.ToString())];
					c.DonGiaGiuaKy = (reader[ThuLaoChamBaiColumn.DonGiaGiuaKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.DonGiaGiuaKy.ToString())];
					c.DonGiaQuaTrinh = (reader[ThuLaoChamBaiColumn.DonGiaQuaTrinh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.DonGiaQuaTrinh.ToString())];
					c.DonGiaCuoiKy = (reader[ThuLaoChamBaiColumn.DonGiaCuoiKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.DonGiaCuoiKy.ToString())];
					c.TienGiuaKy = (reader[ThuLaoChamBaiColumn.TienGiuaKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.TienGiuaKy.ToString())];
					c.TienQuaTrinh = (reader[ThuLaoChamBaiColumn.TienQuaTrinh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.TienQuaTrinh.ToString())];
					c.TienCuoiKy = (reader[ThuLaoChamBaiColumn.TienCuoiKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.TienCuoiKy.ToString())];
					c.TongCong = (reader[ThuLaoChamBaiColumn.TongCong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.TongCong.ToString())];
					c.Thue = (reader[ThuLaoChamBaiColumn.Thue.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.Thue.ToString())];
					c.ThucLanh = (reader[ThuLaoChamBaiColumn.ThucLanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.ThucLanh.ToString())];
					c.GhiChu = (reader[ThuLaoChamBaiColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.GhiChu.ToString())];
					c.NamHoc = (reader[ThuLaoChamBaiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThuLaoChamBaiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.HocKy.ToString())];
					c.NgayCapNhat = (reader[ThuLaoChamBaiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ThuLaoChamBaiColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.NguoiCapNhat.ToString())];
					c.DotChiTra = (reader[ThuLaoChamBaiColumn.DotChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.DotChiTra.ToString())];
					c.IsSync = (reader[ThuLaoChamBaiColumn.IsSync.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuLaoChamBaiColumn.IsSync.ToString())];
					c.Chot = (reader[ThuLaoChamBaiColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuLaoChamBaiColumn.Chot.ToString())];
					c.MaBacDaoTao = (reader[ThuLaoChamBaiColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MaBacDaoTao.ToString())];
					c.MucChi = (reader[ThuLaoChamBaiColumn.MucChi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MucChi.ToString())];
					c.MaHinhThucThi = (reader[ThuLaoChamBaiColumn.MaHinhThucThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MaHinhThucThi.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoChamBai"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoChamBai"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThuLaoChamBai entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ThuLaoChamBaiColumn.Id.ToString())];
			entity.MaGiangVienQuanLy = (reader[ThuLaoChamBaiColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MaGiangVienQuanLy.ToString())];
			entity.MaMonHoc = (reader[ThuLaoChamBaiColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MaMonHoc.ToString())];
			entity.MaHocPhan = (reader[ThuLaoChamBaiColumn.MaHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MaHocPhan.ToString())];
			entity.MaLopHocPhan = (reader[ThuLaoChamBaiColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MaLopHocPhan.ToString())];
			entity.MaLop = (reader[ThuLaoChamBaiColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MaLop.ToString())];
			entity.LanThi = (reader[ThuLaoChamBaiColumn.LanThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.LanThi.ToString())];
			entity.KyThi = (reader[ThuLaoChamBaiColumn.KyThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.KyThi.ToString())];
			entity.SoBaiGiuaKy = (reader[ThuLaoChamBaiColumn.SoBaiGiuaKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiColumn.SoBaiGiuaKy.ToString())];
			entity.SoBaiQuaTrinh = (reader[ThuLaoChamBaiColumn.SoBaiQuaTrinh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiColumn.SoBaiQuaTrinh.ToString())];
			entity.SoBaiCuoiKy = (reader[ThuLaoChamBaiColumn.SoBaiCuoiKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoChamBaiColumn.SoBaiCuoiKy.ToString())];
			entity.DonGiaGiuaKy = (reader[ThuLaoChamBaiColumn.DonGiaGiuaKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.DonGiaGiuaKy.ToString())];
			entity.DonGiaQuaTrinh = (reader[ThuLaoChamBaiColumn.DonGiaQuaTrinh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.DonGiaQuaTrinh.ToString())];
			entity.DonGiaCuoiKy = (reader[ThuLaoChamBaiColumn.DonGiaCuoiKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.DonGiaCuoiKy.ToString())];
			entity.TienGiuaKy = (reader[ThuLaoChamBaiColumn.TienGiuaKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.TienGiuaKy.ToString())];
			entity.TienQuaTrinh = (reader[ThuLaoChamBaiColumn.TienQuaTrinh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.TienQuaTrinh.ToString())];
			entity.TienCuoiKy = (reader[ThuLaoChamBaiColumn.TienCuoiKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.TienCuoiKy.ToString())];
			entity.TongCong = (reader[ThuLaoChamBaiColumn.TongCong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.TongCong.ToString())];
			entity.Thue = (reader[ThuLaoChamBaiColumn.Thue.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.Thue.ToString())];
			entity.ThucLanh = (reader[ThuLaoChamBaiColumn.ThucLanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoChamBaiColumn.ThucLanh.ToString())];
			entity.GhiChu = (reader[ThuLaoChamBaiColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.GhiChu.ToString())];
			entity.NamHoc = (reader[ThuLaoChamBaiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThuLaoChamBaiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.HocKy.ToString())];
			entity.NgayCapNhat = (reader[ThuLaoChamBaiColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ThuLaoChamBaiColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.NguoiCapNhat.ToString())];
			entity.DotChiTra = (reader[ThuLaoChamBaiColumn.DotChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.DotChiTra.ToString())];
			entity.IsSync = (reader[ThuLaoChamBaiColumn.IsSync.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuLaoChamBaiColumn.IsSync.ToString())];
			entity.Chot = (reader[ThuLaoChamBaiColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThuLaoChamBaiColumn.Chot.ToString())];
			entity.MaBacDaoTao = (reader[ThuLaoChamBaiColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MaBacDaoTao.ToString())];
			entity.MucChi = (reader[ThuLaoChamBaiColumn.MucChi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MucChi.ToString())];
			entity.MaHinhThucThi = (reader[ThuLaoChamBaiColumn.MaHinhThucThi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoChamBaiColumn.MaHinhThucThi.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoChamBai"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoChamBai"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThuLaoChamBai entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.MaHocPhan = Convert.IsDBNull(dataRow["MaHocPhan"]) ? null : (System.String)dataRow["MaHocPhan"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.LanThi = Convert.IsDBNull(dataRow["LanThi"]) ? null : (System.String)dataRow["LanThi"];
			entity.KyThi = Convert.IsDBNull(dataRow["KyThi"]) ? null : (System.String)dataRow["KyThi"];
			entity.SoBaiGiuaKy = Convert.IsDBNull(dataRow["SoBaiGiuaKy"]) ? null : (System.Int32?)dataRow["SoBaiGiuaKy"];
			entity.SoBaiQuaTrinh = Convert.IsDBNull(dataRow["SoBaiQuaTrinh"]) ? null : (System.Int32?)dataRow["SoBaiQuaTrinh"];
			entity.SoBaiCuoiKy = Convert.IsDBNull(dataRow["SoBaiCuoiKy"]) ? null : (System.Int32?)dataRow["SoBaiCuoiKy"];
			entity.DonGiaGiuaKy = Convert.IsDBNull(dataRow["DonGiaGiuaKy"]) ? null : (System.Decimal?)dataRow["DonGiaGiuaKy"];
			entity.DonGiaQuaTrinh = Convert.IsDBNull(dataRow["DonGiaQuaTrinh"]) ? null : (System.Decimal?)dataRow["DonGiaQuaTrinh"];
			entity.DonGiaCuoiKy = Convert.IsDBNull(dataRow["DonGiaCuoiKy"]) ? null : (System.Decimal?)dataRow["DonGiaCuoiKy"];
			entity.TienGiuaKy = Convert.IsDBNull(dataRow["TienGiuaKy"]) ? null : (System.Decimal?)dataRow["TienGiuaKy"];
			entity.TienQuaTrinh = Convert.IsDBNull(dataRow["TienQuaTrinh"]) ? null : (System.Decimal?)dataRow["TienQuaTrinh"];
			entity.TienCuoiKy = Convert.IsDBNull(dataRow["TienCuoiKy"]) ? null : (System.Decimal?)dataRow["TienCuoiKy"];
			entity.TongCong = Convert.IsDBNull(dataRow["TongCong"]) ? null : (System.Decimal?)dataRow["TongCong"];
			entity.Thue = Convert.IsDBNull(dataRow["Thue"]) ? null : (System.Decimal?)dataRow["Thue"];
			entity.ThucLanh = Convert.IsDBNull(dataRow["ThucLanh"]) ? null : (System.Decimal?)dataRow["ThucLanh"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.DotChiTra = Convert.IsDBNull(dataRow["DotChiTra"]) ? null : (System.String)dataRow["DotChiTra"];
			entity.IsSync = Convert.IsDBNull(dataRow["IsSync"]) ? null : (System.Boolean?)dataRow["IsSync"];
			entity.Chot = Convert.IsDBNull(dataRow["Chot"]) ? null : (System.Boolean?)dataRow["Chot"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.MucChi = Convert.IsDBNull(dataRow["MucChi"]) ? null : (System.String)dataRow["MucChi"];
			entity.MaHinhThucThi = Convert.IsDBNull(dataRow["MaHinhThucThi"]) ? null : (System.String)dataRow["MaHinhThucThi"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoChamBai"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoChamBai Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThuLaoChamBai entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThuLaoChamBai object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThuLaoChamBai instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoChamBai Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThuLaoChamBai entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThuLaoChamBaiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThuLaoChamBai</c>
	///</summary>
	public enum ThuLaoChamBaiChildEntityTypes
	{
	}
	
	#endregion ThuLaoChamBaiChildEntityTypes
	
	#region ThuLaoChamBaiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThuLaoChamBaiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamBai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamBaiFilterBuilder : SqlFilterBuilder<ThuLaoChamBaiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiFilterBuilder class.
		/// </summary>
		public ThuLaoChamBaiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoChamBaiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoChamBaiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoChamBaiFilterBuilder
	
	#region ThuLaoChamBaiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThuLaoChamBaiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamBai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamBaiParameterBuilder : ParameterizedSqlFilterBuilder<ThuLaoChamBaiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiParameterBuilder class.
		/// </summary>
		public ThuLaoChamBaiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoChamBaiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoChamBaiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoChamBaiParameterBuilder
	
	#region ThuLaoChamBaiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThuLaoChamBaiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamBai"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThuLaoChamBaiSortBuilder : SqlSortBuilder<ThuLaoChamBaiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiSqlSortBuilder class.
		/// </summary>
		public ThuLaoChamBaiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThuLaoChamBaiSortBuilder
	
} // end namespace
