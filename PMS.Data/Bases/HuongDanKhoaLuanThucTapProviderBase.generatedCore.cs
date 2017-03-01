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
	/// This class is the base class for any <see cref="HuongDanKhoaLuanThucTapProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HuongDanKhoaLuanThucTapProviderBaseCore : EntityProviderBase<PMS.Entities.HuongDanKhoaLuanThucTap, PMS.Entities.HuongDanKhoaLuanThucTapKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.HuongDanKhoaLuanThucTapKey key)
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
		public override PMS.Entities.HuongDanKhoaLuanThucTap Get(TransactionManager transactionManager, PMS.Entities.HuongDanKhoaLuanThucTapKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_HuongDanKhoaLuanThucTap index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HuongDanKhoaLuanThucTap"/> class.</returns>
		public PMS.Entities.HuongDanKhoaLuanThucTap GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HuongDanKhoaLuanThucTap index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HuongDanKhoaLuanThucTap"/> class.</returns>
		public PMS.Entities.HuongDanKhoaLuanThucTap GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HuongDanKhoaLuanThucTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HuongDanKhoaLuanThucTap"/> class.</returns>
		public PMS.Entities.HuongDanKhoaLuanThucTap GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HuongDanKhoaLuanThucTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HuongDanKhoaLuanThucTap"/> class.</returns>
		public PMS.Entities.HuongDanKhoaLuanThucTap GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HuongDanKhoaLuanThucTap index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HuongDanKhoaLuanThucTap"/> class.</returns>
		public PMS.Entities.HuongDanKhoaLuanThucTap GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_HuongDanKhoaLuanThucTap index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.HuongDanKhoaLuanThucTap"/> class.</returns>
		public abstract PMS.Entities.HuongDanKhoaLuanThucTap GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_HuongDanKhoaLuanThucTap_ChotKhoiLuongTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_ChotKhoiLuongTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotKhoiLuongTheoKhoa(System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			 ChotKhoiLuongTheoKhoa(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_ChotKhoiLuongTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotKhoiLuongTheoKhoa(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			 ChotKhoiLuongTheoKhoa(null, start, pageLength , namHoc, hocKy, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_ChotKhoiLuongTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotKhoiLuongTheoKhoa(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			 ChotKhoiLuongTheoKhoa(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_ChotKhoiLuongTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ChotKhoiLuongTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaDonVi);
		
		#endregion
		
		#region cust_HuongDanKhoaLuanThucTap_HuyChot 
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(System.String namHoc, System.String hocKy)
		{
			 HuyChot(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 HuyChot(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 HuyChot(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_HuongDanKhoaLuanThucTap_QuyDoi 
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(System.String namHoc, System.String hocKy)
		{
			 QuyDoi(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 QuyDoi(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 QuyDoi(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void QuyDoi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_HuongDanKhoaLuanThucTap_KiemTra 
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTra(System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTra(null, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTra(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTra(null, start, pageLength , namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTra(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 KiemTra(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTra(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_HuongDanKhoaLuanThucTap_KiemTraChot 
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_KiemTraChot' stored procedure. 
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
		
		#region cust_HuongDanKhoaLuanThucTap_ChotKhoiLuong 
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_ChotKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotKhoiLuong(System.String namHoc, System.String hocKy)
		{
			 ChotKhoiLuong(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_ChotKhoiLuong' stored procedure. 
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
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_ChotKhoiLuong' stored procedure. 
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
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_ChotKhoiLuong' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ChotKhoiLuong(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_HuongDanKhoaLuanThucTap_KiemTraChotTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_KiemTraChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChotTheoKhoa(System.String namHoc, System.String hocKy, System.String khoaDonVi, ref System.Int32 reVal)
		{
			 KiemTraChotTheoKhoa(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_KiemTraChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChotTheoKhoa(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi, ref System.Int32 reVal)
		{
			 KiemTraChotTheoKhoa(null, start, pageLength , namHoc, hocKy, khoaDonVi, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_KiemTraChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChotTheoKhoa(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi, ref System.Int32 reVal)
		{
			 KiemTraChotTheoKhoa(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_KiemTraChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraChotTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaDonVi, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_HuongDanKhoaLuanThucTap_HuyChotTheoKhoa 
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_HuyChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotTheoKhoa(System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			 HuyChotTheoKhoa(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_HuyChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotTheoKhoa(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			 HuyChotTheoKhoa(null, start, pageLength , namHoc, hocKy, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_HuyChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotTheoKhoa(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			 HuyChotTheoKhoa(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_HuyChotTheoKhoa' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChotTheoKhoa(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaDonVi);
		
		#endregion
		
		#region cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maHinhThucDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HuongDanKhoaLuanThucTap&gt;"/> instance.</returns>
		public TList<HuongDanKhoaLuanThucTap> GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi(System.String namHoc, System.String hocKy, System.String maHinhThucDaoTao, System.String maLoaiKhoiLuong, System.String maDonVi)
		{
			return GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maHinhThucDaoTao, maLoaiKhoiLuong, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maHinhThucDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HuongDanKhoaLuanThucTap&gt;"/> instance.</returns>
		public TList<HuongDanKhoaLuanThucTap> GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maHinhThucDaoTao, System.String maLoaiKhoiLuong, System.String maDonVi)
		{
			return GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi(null, start, pageLength , namHoc, hocKy, maHinhThucDaoTao, maLoaiKhoiLuong, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maHinhThucDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HuongDanKhoaLuanThucTap&gt;"/> instance.</returns>
		public TList<HuongDanKhoaLuanThucTap> GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maHinhThucDaoTao, System.String maLoaiKhoiLuong, System.String maDonVi)
		{
			return GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maHinhThucDaoTao, maLoaiKhoiLuong, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maHinhThucDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiKhoiLuong"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;HuongDanKhoaLuanThucTap&gt;"/> instance.</returns>
		public abstract TList<HuongDanKhoaLuanThucTap> GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maHinhThucDaoTao, System.String maLoaiKhoiLuong, System.String maDonVi);
		
		#endregion
		
		#region cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKyKhoaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi(System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			return GetByNamHocHocKyKhoaDonVi(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			return GetByNamHocHocKyKhoaDonVi(null, start, pageLength , namHoc, hocKy, khoaDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyKhoaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi)
		{
			return GetByNamHocHocKyKhoaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_HuongDanKhoaLuanThucTap_GetByNamHocHocKyKhoaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyKhoaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaDonVi);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HuongDanKhoaLuanThucTap&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HuongDanKhoaLuanThucTap&gt;"/></returns>
		public static TList<HuongDanKhoaLuanThucTap> Fill(IDataReader reader, TList<HuongDanKhoaLuanThucTap> rows, int start, int pageLength)
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
				
				PMS.Entities.HuongDanKhoaLuanThucTap c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HuongDanKhoaLuanThucTap")
					.Append("|").Append((System.Int32)reader[((int)HuongDanKhoaLuanThucTapColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<HuongDanKhoaLuanThucTap>(
					key.ToString(), // EntityTrackingKey
					"HuongDanKhoaLuanThucTap",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.HuongDanKhoaLuanThucTap();
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
					c.Id = (System.Int32)reader[(HuongDanKhoaLuanThucTapColumn.Id.ToString())];
					c.NamHoc = (reader[HuongDanKhoaLuanThucTapColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.NamHoc.ToString())];
					c.HocKy = (reader[HuongDanKhoaLuanThucTapColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.HocKy.ToString())];
					c.MaHinhThucDaoTao = (reader[HuongDanKhoaLuanThucTapColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.MaHinhThucDaoTao.ToString())];
					c.MaLoaiKhoiLuong = (reader[HuongDanKhoaLuanThucTapColumn.MaLoaiKhoiLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.MaLoaiKhoiLuong.ToString())];
					c.MaGiangVien = (reader[HuongDanKhoaLuanThucTapColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HuongDanKhoaLuanThucTapColumn.MaGiangVien.ToString())];
					c.HoTen = (reader[HuongDanKhoaLuanThucTapColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.HoTen.ToString())];
					c.MaHocHam = (reader[HuongDanKhoaLuanThucTapColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HuongDanKhoaLuanThucTapColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[HuongDanKhoaLuanThucTapColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HuongDanKhoaLuanThucTapColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[HuongDanKhoaLuanThucTapColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HuongDanKhoaLuanThucTapColumn.MaLoaiGiangVien.ToString())];
					c.MaDonVi = (reader[HuongDanKhoaLuanThucTapColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.MaDonVi.ToString())];
					c.SoLuong = (reader[HuongDanKhoaLuanThucTapColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HuongDanKhoaLuanThucTapColumn.SoLuong.ToString())];
					c.HeSoQuyDoi = (reader[HuongDanKhoaLuanThucTapColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HuongDanKhoaLuanThucTapColumn.HeSoQuyDoi.ToString())];
					c.MaDonViTinh = (reader[HuongDanKhoaLuanThucTapColumn.MaDonViTinh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HuongDanKhoaLuanThucTapColumn.MaDonViTinh.ToString())];
					c.SoTietQuyDoi = (reader[HuongDanKhoaLuanThucTapColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HuongDanKhoaLuanThucTapColumn.SoTietQuyDoi.ToString())];
					c.GhiChu = (reader[HuongDanKhoaLuanThucTapColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[HuongDanKhoaLuanThucTapColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HuongDanKhoaLuanThucTapColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[HuongDanKhoaLuanThucTapColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.NguoiCapNhat.ToString())];
					c.MaLop = (reader[HuongDanKhoaLuanThucTapColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.MaLop.ToString())];
					c.Chot = (reader[HuongDanKhoaLuanThucTapColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HuongDanKhoaLuanThucTapColumn.Chot.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HuongDanKhoaLuanThucTap"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HuongDanKhoaLuanThucTap"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.HuongDanKhoaLuanThucTap entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(HuongDanKhoaLuanThucTapColumn.Id.ToString())];
			entity.NamHoc = (reader[HuongDanKhoaLuanThucTapColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.NamHoc.ToString())];
			entity.HocKy = (reader[HuongDanKhoaLuanThucTapColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.HocKy.ToString())];
			entity.MaHinhThucDaoTao = (reader[HuongDanKhoaLuanThucTapColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.MaHinhThucDaoTao.ToString())];
			entity.MaLoaiKhoiLuong = (reader[HuongDanKhoaLuanThucTapColumn.MaLoaiKhoiLuong.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.MaLoaiKhoiLuong.ToString())];
			entity.MaGiangVien = (reader[HuongDanKhoaLuanThucTapColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HuongDanKhoaLuanThucTapColumn.MaGiangVien.ToString())];
			entity.HoTen = (reader[HuongDanKhoaLuanThucTapColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.HoTen.ToString())];
			entity.MaHocHam = (reader[HuongDanKhoaLuanThucTapColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HuongDanKhoaLuanThucTapColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[HuongDanKhoaLuanThucTapColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HuongDanKhoaLuanThucTapColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[HuongDanKhoaLuanThucTapColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HuongDanKhoaLuanThucTapColumn.MaLoaiGiangVien.ToString())];
			entity.MaDonVi = (reader[HuongDanKhoaLuanThucTapColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.MaDonVi.ToString())];
			entity.SoLuong = (reader[HuongDanKhoaLuanThucTapColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HuongDanKhoaLuanThucTapColumn.SoLuong.ToString())];
			entity.HeSoQuyDoi = (reader[HuongDanKhoaLuanThucTapColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HuongDanKhoaLuanThucTapColumn.HeSoQuyDoi.ToString())];
			entity.MaDonViTinh = (reader[HuongDanKhoaLuanThucTapColumn.MaDonViTinh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HuongDanKhoaLuanThucTapColumn.MaDonViTinh.ToString())];
			entity.SoTietQuyDoi = (reader[HuongDanKhoaLuanThucTapColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(HuongDanKhoaLuanThucTapColumn.SoTietQuyDoi.ToString())];
			entity.GhiChu = (reader[HuongDanKhoaLuanThucTapColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[HuongDanKhoaLuanThucTapColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(HuongDanKhoaLuanThucTapColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[HuongDanKhoaLuanThucTapColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.NguoiCapNhat.ToString())];
			entity.MaLop = (reader[HuongDanKhoaLuanThucTapColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(HuongDanKhoaLuanThucTapColumn.MaLop.ToString())];
			entity.Chot = (reader[HuongDanKhoaLuanThucTapColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(HuongDanKhoaLuanThucTapColumn.Chot.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.HuongDanKhoaLuanThucTap"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.HuongDanKhoaLuanThucTap"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.HuongDanKhoaLuanThucTap entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaHinhThucDaoTao = Convert.IsDBNull(dataRow["MaHinhThucDaoTao"]) ? null : (System.String)dataRow["MaHinhThucDaoTao"];
			entity.MaLoaiKhoiLuong = Convert.IsDBNull(dataRow["MaLoaiKhoiLuong"]) ? null : (System.String)dataRow["MaLoaiKhoiLuong"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.HoTen = Convert.IsDBNull(dataRow["HoTen"]) ? null : (System.String)dataRow["HoTen"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.String)dataRow["MaDonVi"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Decimal?)dataRow["SoLuong"];
			entity.HeSoQuyDoi = Convert.IsDBNull(dataRow["HeSoQuyDoi"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoi"];
			entity.MaDonViTinh = Convert.IsDBNull(dataRow["MaDonViTinh"]) ? null : (System.Int32?)dataRow["MaDonViTinh"];
			entity.SoTietQuyDoi = Convert.IsDBNull(dataRow["SoTietQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietQuyDoi"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.Chot = Convert.IsDBNull(dataRow["Chot"]) ? null : (System.Int32?)dataRow["Chot"];
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
		/// <param name="entity">The <see cref="PMS.Entities.HuongDanKhoaLuanThucTap"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.HuongDanKhoaLuanThucTap Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.HuongDanKhoaLuanThucTap entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.HuongDanKhoaLuanThucTap object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.HuongDanKhoaLuanThucTap instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.HuongDanKhoaLuanThucTap Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.HuongDanKhoaLuanThucTap entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HuongDanKhoaLuanThucTapChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.HuongDanKhoaLuanThucTap</c>
	///</summary>
	public enum HuongDanKhoaLuanThucTapChildEntityTypes
	{
	}
	
	#endregion HuongDanKhoaLuanThucTapChildEntityTypes
	
	#region HuongDanKhoaLuanThucTapFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HuongDanKhoaLuanThucTapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HuongDanKhoaLuanThucTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HuongDanKhoaLuanThucTapFilterBuilder : SqlFilterBuilder<HuongDanKhoaLuanThucTapColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HuongDanKhoaLuanThucTapFilterBuilder class.
		/// </summary>
		public HuongDanKhoaLuanThucTapFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HuongDanKhoaLuanThucTapFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HuongDanKhoaLuanThucTapFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HuongDanKhoaLuanThucTapFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HuongDanKhoaLuanThucTapFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HuongDanKhoaLuanThucTapFilterBuilder
	
	#region HuongDanKhoaLuanThucTapParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HuongDanKhoaLuanThucTapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HuongDanKhoaLuanThucTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HuongDanKhoaLuanThucTapParameterBuilder : ParameterizedSqlFilterBuilder<HuongDanKhoaLuanThucTapColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HuongDanKhoaLuanThucTapParameterBuilder class.
		/// </summary>
		public HuongDanKhoaLuanThucTapParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HuongDanKhoaLuanThucTapParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HuongDanKhoaLuanThucTapParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HuongDanKhoaLuanThucTapParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HuongDanKhoaLuanThucTapParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HuongDanKhoaLuanThucTapParameterBuilder
	
	#region HuongDanKhoaLuanThucTapSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HuongDanKhoaLuanThucTapColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HuongDanKhoaLuanThucTap"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HuongDanKhoaLuanThucTapSortBuilder : SqlSortBuilder<HuongDanKhoaLuanThucTapColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HuongDanKhoaLuanThucTapSqlSortBuilder class.
		/// </summary>
		public HuongDanKhoaLuanThucTapSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HuongDanKhoaLuanThucTapSortBuilder
	
} // end namespace
