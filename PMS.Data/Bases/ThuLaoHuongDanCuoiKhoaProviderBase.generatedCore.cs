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
	/// This class is the base class for any <see cref="ThuLaoHuongDanCuoiKhoaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThuLaoHuongDanCuoiKhoaProviderBaseCore : EntityProviderBase<PMS.Entities.ThuLaoHuongDanCuoiKhoa, PMS.Entities.ThuLaoHuongDanCuoiKhoaKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThuLaoHuongDanCuoiKhoaKey key)
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
		public override PMS.Entities.ThuLaoHuongDanCuoiKhoa Get(TransactionManager transactionManager, PMS.Entities.ThuLaoHuongDanCuoiKhoaKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThuLaoHuongDanCuoiKhoa index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoHuongDanCuoiKhoa"/> class.</returns>
		public PMS.Entities.ThuLaoHuongDanCuoiKhoa GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoHuongDanCuoiKhoa index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoHuongDanCuoiKhoa"/> class.</returns>
		public PMS.Entities.ThuLaoHuongDanCuoiKhoa GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoHuongDanCuoiKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoHuongDanCuoiKhoa"/> class.</returns>
		public PMS.Entities.ThuLaoHuongDanCuoiKhoa GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoHuongDanCuoiKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoHuongDanCuoiKhoa"/> class.</returns>
		public PMS.Entities.ThuLaoHuongDanCuoiKhoa GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoHuongDanCuoiKhoa index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoHuongDanCuoiKhoa"/> class.</returns>
		public PMS.Entities.ThuLaoHuongDanCuoiKhoa GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoHuongDanCuoiKhoa index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoHuongDanCuoiKhoa"/> class.</returns>
		public abstract PMS.Entities.ThuLaoHuongDanCuoiKhoa GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThuLaoHuongDanCuoiKhoa_QuyDoi 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 QuyDoi(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 QuyDoi(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 QuyDoi(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void QuyDoi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoHuongDanCuoiKhoa_GetDotChiTraByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetDotChiTraByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDotChiTraByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetDotChiTraByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetDotChiTraByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDotChiTraByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetDotChiTraByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetDotChiTraByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDotChiTraByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetDotChiTraByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetDotChiTraByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetDotChiTraByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThuLaoHuongDanCuoiKhoa_KiemTraChot 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraChot(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraChot(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTraChot(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_KiemTraChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyDotChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotChiTra(System.String namHoc, System.String hocKy, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTra(null, 0, int.MaxValue , namHoc, hocKy, dotChiTra);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotChiTra(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTra(null, start, pageLength , namHoc, hocKy, dotChiTra);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotChiTra(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTra(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotChiTra);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyDotChiTra(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dotChiTra);
		
		#endregion
		
		#region cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_ThuLaoHuongDanCuoiKhoa_HuyChotKhoiLuong 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_HuyChotKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotKhoiLuong(System.String namHoc, System.String hocKy)
		{
			 HuyChotKhoiLuong(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_HuyChotKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotKhoiLuong(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 HuyChotKhoiLuong(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_HuyChotKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotKhoiLuong(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 HuyChotKhoiLuong(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_HuyChotKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChotKhoiLuong(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThuLaoHuongDanCuoiKhoa_ChotKhoiLuong 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_ChotKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotKhoiLuong(System.String namHoc, System.String hocKy)
		{
			 ChotKhoiLuong(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_ChotKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotKhoiLuong(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 ChotKhoiLuong(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_ChotKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotKhoiLuong(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 ChotKhoiLuong(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_ChotKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ChotKhoiLuong(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThuLaoHuongDanCuoiKhoa_Import 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="nguoiCapNhat"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(System.String xmlData, System.String nguoiCapNhat, ref System.Int32 reVal)
		{
			 Import(null, 0, int.MaxValue , xmlData, nguoiCapNhat, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="nguoiCapNhat"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(int start, int pageLength, System.String xmlData, System.String nguoiCapNhat, ref System.Int32 reVal)
		{
			 Import(null, start, pageLength , xmlData, nguoiCapNhat, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="nguoiCapNhat"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(TransactionManager transactionManager, System.String xmlData, System.String nguoiCapNhat, ref System.Int32 reVal)
		{
			 Import(transactionManager, 0, int.MaxValue , xmlData, nguoiCapNhat, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="nguoiCapNhat"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Import(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String nguoiCapNhat, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyNhomQuyen 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoHuongDanCuoiKhoa&gt;"/> instance.</returns>
		public TList<ThuLaoHuongDanCuoiKhoa> GetByNamHocHocKyNhomQuyen(System.String namHoc, System.String hocKy, System.String nhomQuyen)
		{
			return GetByNamHocHocKyNhomQuyen(null, 0, int.MaxValue , namHoc, hocKy, nhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoHuongDanCuoiKhoa&gt;"/> instance.</returns>
		public TList<ThuLaoHuongDanCuoiKhoa> GetByNamHocHocKyNhomQuyen(int start, int pageLength, System.String namHoc, System.String hocKy, System.String nhomQuyen)
		{
			return GetByNamHocHocKyNhomQuyen(null, start, pageLength , namHoc, hocKy, nhomQuyen);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoHuongDanCuoiKhoa&gt;"/> instance.</returns>
		public TList<ThuLaoHuongDanCuoiKhoa> GetByNamHocHocKyNhomQuyen(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String nhomQuyen)
		{
			return GetByNamHocHocKyNhomQuyen(transactionManager, 0, int.MaxValue , namHoc, hocKy, nhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoHuongDanCuoiKhoa&gt;"/> instance.</returns>
		public abstract TList<ThuLaoHuongDanCuoiKhoa> GetByNamHocHocKyNhomQuyen(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String nhomQuyen);
		
		#endregion
		
		#region cust_ThuLaoHuongDanCuoiKhoa_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, System.String nhomQuyen, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, nhomQuyen, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String nhomQuyen, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, nhomQuyen, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String nhomQuyen, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, nhomQuyen, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String nhomQuyen, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyKhoaLoaiGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyKhoaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaLoaiGiangVien(System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return GetByNamHocHocKyKhoaLoaiGiangVien(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyKhoaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaLoaiGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return GetByNamHocHocKyKhoaLoaiGiangVien(null, start, pageLength , namHoc, hocKy, khoaDonVi, loaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyKhoaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaLoaiGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String loaiGiangVien)
		{
			return GetByNamHocHocKyKhoaLoaiGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, loaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_GetByNamHocHocKyKhoaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyKhoaLoaiGiangVien(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String loaiGiangVien);
		
		#endregion
		
		#region cust_ThuLaoHuongDanCuoiKhoa_XoaDotChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_XoaDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void XoaDotChiTra(System.String namHoc, System.String hocKy, System.String dotChiTra, ref System.Int32 reVal)
		{
			 XoaDotChiTra(null, 0, int.MaxValue , namHoc, hocKy, dotChiTra, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_XoaDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void XoaDotChiTra(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dotChiTra, ref System.Int32 reVal)
		{
			 XoaDotChiTra(null, start, pageLength , namHoc, hocKy, dotChiTra, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_XoaDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void XoaDotChiTra(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dotChiTra, ref System.Int32 reVal)
		{
			 XoaDotChiTra(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotChiTra, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoHuongDanCuoiKhoa_XoaDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void XoaDotChiTra(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dotChiTra, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThuLaoHuongDanCuoiKhoa&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThuLaoHuongDanCuoiKhoa&gt;"/></returns>
		public static TList<ThuLaoHuongDanCuoiKhoa> Fill(IDataReader reader, TList<ThuLaoHuongDanCuoiKhoa> rows, int start, int pageLength)
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
				
				PMS.Entities.ThuLaoHuongDanCuoiKhoa c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThuLaoHuongDanCuoiKhoa")
					.Append("|").Append((System.Int32)reader[((int)ThuLaoHuongDanCuoiKhoaColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThuLaoHuongDanCuoiKhoa>(
					key.ToString(), // EntityTrackingKey
					"ThuLaoHuongDanCuoiKhoa",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThuLaoHuongDanCuoiKhoa();
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
					c.Id = (System.Int32)reader[(ThuLaoHuongDanCuoiKhoaColumn.Id.ToString())];
					c.MaGiangVienQuanLy = (reader[ThuLaoHuongDanCuoiKhoaColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoHuongDanCuoiKhoaColumn.MaGiangVienQuanLy.ToString())];
					c.NamHoc = (reader[ThuLaoHuongDanCuoiKhoaColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoHuongDanCuoiKhoaColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThuLaoHuongDanCuoiKhoaColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoHuongDanCuoiKhoaColumn.HocKy.ToString())];
					c.DotChiTra = (reader[ThuLaoHuongDanCuoiKhoaColumn.DotChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoHuongDanCuoiKhoaColumn.DotChiTra.ToString())];
					c.HuongDanVietBaoCaoTotNghiep = (reader[ThuLaoHuongDanCuoiKhoaColumn.HuongDanVietBaoCaoTotNghiep.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoHuongDanCuoiKhoaColumn.HuongDanVietBaoCaoTotNghiep.ToString())];
					c.HuongDanChuyenDeThucTapTotNghiep = (reader[ThuLaoHuongDanCuoiKhoaColumn.HuongDanChuyenDeThucTapTotNghiep.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoHuongDanCuoiKhoaColumn.HuongDanChuyenDeThucTapTotNghiep.ToString())];
					c.HuongDanKhoaLuanTotNghiep = (reader[ThuLaoHuongDanCuoiKhoaColumn.HuongDanKhoaLuanTotNghiep.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoHuongDanCuoiKhoaColumn.HuongDanKhoaLuanTotNghiep.ToString())];
					c.PhanBienKhoaLuanTotNghiep = (reader[ThuLaoHuongDanCuoiKhoaColumn.PhanBienKhoaLuanTotNghiep.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoHuongDanCuoiKhoaColumn.PhanBienKhoaLuanTotNghiep.ToString())];
					c.SoTietQuyDoi = (reader[ThuLaoHuongDanCuoiKhoaColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.SoTietQuyDoi.ToString())];
					c.DonGia = (reader[ThuLaoHuongDanCuoiKhoaColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.DonGia.ToString())];
					c.ThanhTienKhoaLuanChuyenDeTotNghiep = (reader[ThuLaoHuongDanCuoiKhoaColumn.ThanhTienKhoaLuanChuyenDeTotNghiep.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.ThanhTienKhoaLuanChuyenDeTotNghiep.ToString())];
					c.SoLuongThamGiaHoiDongTotNghiep = (reader[ThuLaoHuongDanCuoiKhoaColumn.SoLuongThamGiaHoiDongTotNghiep.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoHuongDanCuoiKhoaColumn.SoLuongThamGiaHoiDongTotNghiep.ToString())];
					c.ThanhTienThamGiaHoiDongTotNghiep = (reader[ThuLaoHuongDanCuoiKhoaColumn.ThanhTienThamGiaHoiDongTotNghiep.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.ThanhTienThamGiaHoiDongTotNghiep.ToString())];
					c.SoTietNoGioChuan = (reader[ThuLaoHuongDanCuoiKhoaColumn.SoTietNoGioChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.SoTietNoGioChuan.ToString())];
					c.ThanhTienNoGioChuan = (reader[ThuLaoHuongDanCuoiKhoaColumn.ThanhTienNoGioChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.ThanhTienNoGioChuan.ToString())];
					c.Thue = (reader[ThuLaoHuongDanCuoiKhoaColumn.Thue.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.Thue.ToString())];
					c.ThucLanh = (reader[ThuLaoHuongDanCuoiKhoaColumn.ThucLanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.ThucLanh.ToString())];
					c.NoiDung = (reader[ThuLaoHuongDanCuoiKhoaColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoHuongDanCuoiKhoaColumn.NoiDung.ToString())];
					c.NgayCapNhat = (reader[ThuLaoHuongDanCuoiKhoaColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuLaoHuongDanCuoiKhoaColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ThuLaoHuongDanCuoiKhoaColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoHuongDanCuoiKhoaColumn.NguoiCapNhat.ToString())];
					c.ChotKhoiLuong = (reader[ThuLaoHuongDanCuoiKhoaColumn.ChotKhoiLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoHuongDanCuoiKhoaColumn.ChotKhoiLuong.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoHuongDanCuoiKhoa"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoHuongDanCuoiKhoa"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThuLaoHuongDanCuoiKhoa entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ThuLaoHuongDanCuoiKhoaColumn.Id.ToString())];
			entity.MaGiangVienQuanLy = (reader[ThuLaoHuongDanCuoiKhoaColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoHuongDanCuoiKhoaColumn.MaGiangVienQuanLy.ToString())];
			entity.NamHoc = (reader[ThuLaoHuongDanCuoiKhoaColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoHuongDanCuoiKhoaColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThuLaoHuongDanCuoiKhoaColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoHuongDanCuoiKhoaColumn.HocKy.ToString())];
			entity.DotChiTra = (reader[ThuLaoHuongDanCuoiKhoaColumn.DotChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoHuongDanCuoiKhoaColumn.DotChiTra.ToString())];
			entity.HuongDanVietBaoCaoTotNghiep = (reader[ThuLaoHuongDanCuoiKhoaColumn.HuongDanVietBaoCaoTotNghiep.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoHuongDanCuoiKhoaColumn.HuongDanVietBaoCaoTotNghiep.ToString())];
			entity.HuongDanChuyenDeThucTapTotNghiep = (reader[ThuLaoHuongDanCuoiKhoaColumn.HuongDanChuyenDeThucTapTotNghiep.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoHuongDanCuoiKhoaColumn.HuongDanChuyenDeThucTapTotNghiep.ToString())];
			entity.HuongDanKhoaLuanTotNghiep = (reader[ThuLaoHuongDanCuoiKhoaColumn.HuongDanKhoaLuanTotNghiep.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoHuongDanCuoiKhoaColumn.HuongDanKhoaLuanTotNghiep.ToString())];
			entity.PhanBienKhoaLuanTotNghiep = (reader[ThuLaoHuongDanCuoiKhoaColumn.PhanBienKhoaLuanTotNghiep.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoHuongDanCuoiKhoaColumn.PhanBienKhoaLuanTotNghiep.ToString())];
			entity.SoTietQuyDoi = (reader[ThuLaoHuongDanCuoiKhoaColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.SoTietQuyDoi.ToString())];
			entity.DonGia = (reader[ThuLaoHuongDanCuoiKhoaColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.DonGia.ToString())];
			entity.ThanhTienKhoaLuanChuyenDeTotNghiep = (reader[ThuLaoHuongDanCuoiKhoaColumn.ThanhTienKhoaLuanChuyenDeTotNghiep.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.ThanhTienKhoaLuanChuyenDeTotNghiep.ToString())];
			entity.SoLuongThamGiaHoiDongTotNghiep = (reader[ThuLaoHuongDanCuoiKhoaColumn.SoLuongThamGiaHoiDongTotNghiep.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoHuongDanCuoiKhoaColumn.SoLuongThamGiaHoiDongTotNghiep.ToString())];
			entity.ThanhTienThamGiaHoiDongTotNghiep = (reader[ThuLaoHuongDanCuoiKhoaColumn.ThanhTienThamGiaHoiDongTotNghiep.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.ThanhTienThamGiaHoiDongTotNghiep.ToString())];
			entity.SoTietNoGioChuan = (reader[ThuLaoHuongDanCuoiKhoaColumn.SoTietNoGioChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.SoTietNoGioChuan.ToString())];
			entity.ThanhTienNoGioChuan = (reader[ThuLaoHuongDanCuoiKhoaColumn.ThanhTienNoGioChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.ThanhTienNoGioChuan.ToString())];
			entity.Thue = (reader[ThuLaoHuongDanCuoiKhoaColumn.Thue.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.Thue.ToString())];
			entity.ThucLanh = (reader[ThuLaoHuongDanCuoiKhoaColumn.ThucLanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoHuongDanCuoiKhoaColumn.ThucLanh.ToString())];
			entity.NoiDung = (reader[ThuLaoHuongDanCuoiKhoaColumn.NoiDung.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoHuongDanCuoiKhoaColumn.NoiDung.ToString())];
			entity.NgayCapNhat = (reader[ThuLaoHuongDanCuoiKhoaColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuLaoHuongDanCuoiKhoaColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ThuLaoHuongDanCuoiKhoaColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoHuongDanCuoiKhoaColumn.NguoiCapNhat.ToString())];
			entity.ChotKhoiLuong = (reader[ThuLaoHuongDanCuoiKhoaColumn.ChotKhoiLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoHuongDanCuoiKhoaColumn.ChotKhoiLuong.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoHuongDanCuoiKhoa"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoHuongDanCuoiKhoa"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThuLaoHuongDanCuoiKhoa entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.DotChiTra = Convert.IsDBNull(dataRow["DotChiTra"]) ? null : (System.String)dataRow["DotChiTra"];
			entity.HuongDanVietBaoCaoTotNghiep = Convert.IsDBNull(dataRow["HuongDanVietBaoCaoTotNghiep"]) ? null : (System.Int32?)dataRow["HuongDanVietBaoCaoTotNghiep"];
			entity.HuongDanChuyenDeThucTapTotNghiep = Convert.IsDBNull(dataRow["HuongDanChuyenDeThucTapTotNghiep"]) ? null : (System.Int32?)dataRow["HuongDanChuyenDeThucTapTotNghiep"];
			entity.HuongDanKhoaLuanTotNghiep = Convert.IsDBNull(dataRow["HuongDanKhoaLuanTotNghiep"]) ? null : (System.Int32?)dataRow["HuongDanKhoaLuanTotNghiep"];
			entity.PhanBienKhoaLuanTotNghiep = Convert.IsDBNull(dataRow["PhanBienKhoaLuanTotNghiep"]) ? null : (System.Int32?)dataRow["PhanBienKhoaLuanTotNghiep"];
			entity.SoTietQuyDoi = Convert.IsDBNull(dataRow["SoTietQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietQuyDoi"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.ThanhTienKhoaLuanChuyenDeTotNghiep = Convert.IsDBNull(dataRow["ThanhTienKhoaLuanChuyenDeTotNghiep"]) ? null : (System.Decimal?)dataRow["ThanhTienKhoaLuanChuyenDeTotNghiep"];
			entity.SoLuongThamGiaHoiDongTotNghiep = Convert.IsDBNull(dataRow["SoLuongThamGiaHoiDongTotNghiep"]) ? null : (System.Int32?)dataRow["SoLuongThamGiaHoiDongTotNghiep"];
			entity.ThanhTienThamGiaHoiDongTotNghiep = Convert.IsDBNull(dataRow["ThanhTienThamGiaHoiDongTotNghiep"]) ? null : (System.Decimal?)dataRow["ThanhTienThamGiaHoiDongTotNghiep"];
			entity.SoTietNoGioChuan = Convert.IsDBNull(dataRow["SoTietNoGioChuan"]) ? null : (System.Decimal?)dataRow["SoTietNoGioChuan"];
			entity.ThanhTienNoGioChuan = Convert.IsDBNull(dataRow["ThanhTienNoGioChuan"]) ? null : (System.Decimal?)dataRow["ThanhTienNoGioChuan"];
			entity.Thue = Convert.IsDBNull(dataRow["Thue"]) ? null : (System.Decimal?)dataRow["Thue"];
			entity.ThucLanh = Convert.IsDBNull(dataRow["ThucLanh"]) ? null : (System.Decimal?)dataRow["ThucLanh"];
			entity.NoiDung = Convert.IsDBNull(dataRow["NoiDung"]) ? null : (System.String)dataRow["NoiDung"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.ChotKhoiLuong = Convert.IsDBNull(dataRow["ChotKhoiLuong"]) ? null : (System.Int32?)dataRow["ChotKhoiLuong"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoHuongDanCuoiKhoa"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoHuongDanCuoiKhoa Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThuLaoHuongDanCuoiKhoa entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThuLaoHuongDanCuoiKhoa object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThuLaoHuongDanCuoiKhoa instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoHuongDanCuoiKhoa Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThuLaoHuongDanCuoiKhoa entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThuLaoHuongDanCuoiKhoaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThuLaoHuongDanCuoiKhoa</c>
	///</summary>
	public enum ThuLaoHuongDanCuoiKhoaChildEntityTypes
	{
	}
	
	#endregion ThuLaoHuongDanCuoiKhoaChildEntityTypes
	
	#region ThuLaoHuongDanCuoiKhoaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThuLaoHuongDanCuoiKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoHuongDanCuoiKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoHuongDanCuoiKhoaFilterBuilder : SqlFilterBuilder<ThuLaoHuongDanCuoiKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoHuongDanCuoiKhoaFilterBuilder class.
		/// </summary>
		public ThuLaoHuongDanCuoiKhoaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoHuongDanCuoiKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoHuongDanCuoiKhoaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoHuongDanCuoiKhoaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoHuongDanCuoiKhoaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoHuongDanCuoiKhoaFilterBuilder
	
	#region ThuLaoHuongDanCuoiKhoaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThuLaoHuongDanCuoiKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoHuongDanCuoiKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoHuongDanCuoiKhoaParameterBuilder : ParameterizedSqlFilterBuilder<ThuLaoHuongDanCuoiKhoaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoHuongDanCuoiKhoaParameterBuilder class.
		/// </summary>
		public ThuLaoHuongDanCuoiKhoaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoHuongDanCuoiKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoHuongDanCuoiKhoaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoHuongDanCuoiKhoaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoHuongDanCuoiKhoaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoHuongDanCuoiKhoaParameterBuilder
	
	#region ThuLaoHuongDanCuoiKhoaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThuLaoHuongDanCuoiKhoaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoHuongDanCuoiKhoa"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThuLaoHuongDanCuoiKhoaSortBuilder : SqlSortBuilder<ThuLaoHuongDanCuoiKhoaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoHuongDanCuoiKhoaSqlSortBuilder class.
		/// </summary>
		public ThuLaoHuongDanCuoiKhoaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThuLaoHuongDanCuoiKhoaSortBuilder
	
} // end namespace
