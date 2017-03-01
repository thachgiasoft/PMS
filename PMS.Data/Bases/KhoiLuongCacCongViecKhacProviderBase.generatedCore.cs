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
	/// This class is the base class for any <see cref="KhoiLuongCacCongViecKhacProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KhoiLuongCacCongViecKhacProviderBaseCore : EntityProviderBase<PMS.Entities.KhoiLuongCacCongViecKhac, PMS.Entities.KhoiLuongCacCongViecKhacKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KhoiLuongCacCongViecKhacKey key)
		{
			return Delete(transactionManager, key.Id, key.MaLoaiCongViec);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <param name="_maLoaiCongViec">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _id, System.Int32 _maLoaiCongViec)
		{
			return Delete(null, _id, _maLoaiCongViec);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <param name="_maLoaiCongViec">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _id, System.Int32 _maLoaiCongViec);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongCacCongViecKhac_QuyDoiGioChuan key.
		///		FK_KhoiLuongCacCongViecKhac_QuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="_maLoaiCongViec"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongCacCongViecKhac objects.</returns>
		public TList<KhoiLuongCacCongViecKhac> GetByMaLoaiCongViec(System.Int32 _maLoaiCongViec)
		{
			int count = -1;
			return GetByMaLoaiCongViec(_maLoaiCongViec, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongCacCongViecKhac_QuyDoiGioChuan key.
		///		FK_KhoiLuongCacCongViecKhac_QuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiCongViec"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongCacCongViecKhac objects.</returns>
		/// <remarks></remarks>
		public TList<KhoiLuongCacCongViecKhac> GetByMaLoaiCongViec(TransactionManager transactionManager, System.Int32 _maLoaiCongViec)
		{
			int count = -1;
			return GetByMaLoaiCongViec(transactionManager, _maLoaiCongViec, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongCacCongViecKhac_QuyDoiGioChuan key.
		///		FK_KhoiLuongCacCongViecKhac_QuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiCongViec"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongCacCongViecKhac objects.</returns>
		public TList<KhoiLuongCacCongViecKhac> GetByMaLoaiCongViec(TransactionManager transactionManager, System.Int32 _maLoaiCongViec, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLoaiCongViec(transactionManager, _maLoaiCongViec, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongCacCongViecKhac_QuyDoiGioChuan key.
		///		fkKhoiLuongCacCongViecKhacQuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiCongViec"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongCacCongViecKhac objects.</returns>
		public TList<KhoiLuongCacCongViecKhac> GetByMaLoaiCongViec(System.Int32 _maLoaiCongViec, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaLoaiCongViec(null, _maLoaiCongViec, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongCacCongViecKhac_QuyDoiGioChuan key.
		///		fkKhoiLuongCacCongViecKhacQuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maLoaiCongViec"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongCacCongViecKhac objects.</returns>
		public TList<KhoiLuongCacCongViecKhac> GetByMaLoaiCongViec(System.Int32 _maLoaiCongViec, int start, int pageLength,out int count)
		{
			return GetByMaLoaiCongViec(null, _maLoaiCongViec, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongCacCongViecKhac_QuyDoiGioChuan key.
		///		FK_KhoiLuongCacCongViecKhac_QuyDoiGioChuan Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLoaiCongViec"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongCacCongViecKhac objects.</returns>
		public abstract TList<KhoiLuongCacCongViecKhac> GetByMaLoaiCongViec(TransactionManager transactionManager, System.Int32 _maLoaiCongViec, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.KhoiLuongCacCongViecKhac Get(TransactionManager transactionManager, PMS.Entities.KhoiLuongCacCongViecKhacKey key, int start, int pageLength)
		{
			return GetByIdMaLoaiCongViec(transactionManager, key.Id, key.MaLoaiCongViec, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KhoiLuongCacCongViecKhac index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="_maLoaiCongViec"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongCacCongViecKhac"/> class.</returns>
		public PMS.Entities.KhoiLuongCacCongViecKhac GetByIdMaLoaiCongViec(System.Int32 _id, System.Int32 _maLoaiCongViec)
		{
			int count = -1;
			return GetByIdMaLoaiCongViec(null,_id, _maLoaiCongViec, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongCacCongViecKhac index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="_maLoaiCongViec"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongCacCongViecKhac"/> class.</returns>
		public PMS.Entities.KhoiLuongCacCongViecKhac GetByIdMaLoaiCongViec(System.Int32 _id, System.Int32 _maLoaiCongViec, int start, int pageLength)
		{
			int count = -1;
			return GetByIdMaLoaiCongViec(null, _id, _maLoaiCongViec, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongCacCongViecKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="_maLoaiCongViec"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongCacCongViecKhac"/> class.</returns>
		public PMS.Entities.KhoiLuongCacCongViecKhac GetByIdMaLoaiCongViec(TransactionManager transactionManager, System.Int32 _id, System.Int32 _maLoaiCongViec)
		{
			int count = -1;
			return GetByIdMaLoaiCongViec(transactionManager, _id, _maLoaiCongViec, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongCacCongViecKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="_maLoaiCongViec"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongCacCongViecKhac"/> class.</returns>
		public PMS.Entities.KhoiLuongCacCongViecKhac GetByIdMaLoaiCongViec(TransactionManager transactionManager, System.Int32 _id, System.Int32 _maLoaiCongViec, int start, int pageLength)
		{
			int count = -1;
			return GetByIdMaLoaiCongViec(transactionManager, _id, _maLoaiCongViec, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongCacCongViecKhac index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="_maLoaiCongViec"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongCacCongViecKhac"/> class.</returns>
		public PMS.Entities.KhoiLuongCacCongViecKhac GetByIdMaLoaiCongViec(System.Int32 _id, System.Int32 _maLoaiCongViec, int start, int pageLength, out int count)
		{
			return GetByIdMaLoaiCongViec(null, _id, _maLoaiCongViec, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongCacCongViecKhac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="_maLoaiCongViec"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongCacCongViecKhac"/> class.</returns>
		public abstract PMS.Entities.KhoiLuongCacCongViecKhac GetByIdMaLoaiCongViec(TransactionManager transactionManager, System.Int32 _id, System.Int32 _maLoaiCongViec, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KhoiLuongCacCongViecKhac_QuyDoiTheoDot 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_QuyDoiTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoDot(System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 QuyDoiTheoDot(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_QuyDoiTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 QuyDoiTheoDot(null, start, pageLength , namHoc, hocKy, dotThanhToan, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_QuyDoiTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoiTheoDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 QuyDoiTheoDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_QuyDoiTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void QuyDoiTheoDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongCacCongViecKhac_Chot 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(System.String namHoc, System.String hocKy)
		{
			 Chot(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 Chot(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Chot(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 Chot(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_Chot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Chot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongCacCongViecKhac_QuyDoi 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_QuyDoi' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_QuyDoi' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_QuyDoi' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_QuyDoi' stored procedure. 
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
		
		#region cust_KhoiLuongCacCongViecKhac_HuyChotTheoDot 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_HuyChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotTheoDot(System.String namHoc, System.String hocKy, System.Int32 dotThanhToan)
		{
			 HuyChotTheoDot(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_HuyChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotTheoDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan)
		{
			 HuyChotTheoDot(null, start, pageLength , namHoc, hocKy, dotThanhToan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_HuyChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotTheoDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan)
		{
			 HuyChotTheoDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_HuyChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChotTheoDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 dotThanhToan);
		
		#endregion
		
		#region cust_KhoiLuongCacCongViecKhac_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiCongViec"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maLoaiCongViec, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, maLoaiCongViec, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiCongViec"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maLoaiCongViec, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, maDonVi, maLoaiCongViec, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiCongViec"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maLoaiCongViec, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, maDonVi, maLoaiCongViec, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiCongViec"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String maDonVi, System.String maLoaiCongViec, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongCacCongViecKhac_HuyChot 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChot(System.String namHoc, System.String hocKy)
		{
			 HuyChot(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_HuyChot' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_HuyChot' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_HuyChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongCacCongViecKhac_KiemTraChotTheoDot 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_KiemTraChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChotTheoDot(System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 KiemTraChotTheoDot(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_KiemTraChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChotTheoDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 KiemTraChotTheoDot(null, start, pageLength , namHoc, hocKy, dotThanhToan, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_KiemTraChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraChotTheoDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 KiemTraChotTheoDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_KiemTraChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraChotTheoDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongCacCongViecKhac_KiemTraChot 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_KiemTraChot' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_KiemTraChot' stored procedure. 
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
		
		#region cust_KhoiLuongCacCongViecKhac_Import 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(System.String xmlData, ref System.Int32 reVal)
		{
			 Import(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 Import(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 Import(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Import(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongCacCongViecKhac_GetByNamHocHocKyDotThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_GetByNamHocHocKyDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotThanhToan(System.String namHoc, System.String hocKy, System.Int32 dotThanhToan)
		{
			return GetByNamHocHocKyDotThanhToan(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_GetByNamHocHocKyDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotThanhToan(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan)
		{
			return GetByNamHocHocKyDotThanhToan(null, start, pageLength , namHoc, hocKy, dotThanhToan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_GetByNamHocHocKyDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotThanhToan(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan)
		{
			return GetByNamHocHocKyDotThanhToan(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_GetByNamHocHocKyDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyDotThanhToan(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 dotThanhToan);
		
		#endregion
		
		#region cust_KhoiLuongCacCongViecKhac_ChotTheoDot 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_ChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotTheoDot(System.String namHoc, System.String hocKy, System.Int32 dotThanhToan)
		{
			 ChotTheoDot(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_ChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotTheoDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan)
		{
			 ChotTheoDot(null, start, pageLength , namHoc, hocKy, dotThanhToan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_ChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotTheoDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan)
		{
			 ChotTheoDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongCacCongViecKhac_ChotTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ChotTheoDot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 dotThanhToan);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KhoiLuongCacCongViecKhac&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KhoiLuongCacCongViecKhac&gt;"/></returns>
		public static TList<KhoiLuongCacCongViecKhac> Fill(IDataReader reader, TList<KhoiLuongCacCongViecKhac> rows, int start, int pageLength)
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
				
				PMS.Entities.KhoiLuongCacCongViecKhac c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KhoiLuongCacCongViecKhac")
					.Append("|").Append((System.Int32)reader[((int)KhoiLuongCacCongViecKhacColumn.Id - 1)])
					.Append("|").Append((System.Int32)reader[((int)KhoiLuongCacCongViecKhacColumn.MaLoaiCongViec - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KhoiLuongCacCongViecKhac>(
					key.ToString(), // EntityTrackingKey
					"KhoiLuongCacCongViecKhac",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KhoiLuongCacCongViecKhac();
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
					c.Id = (System.Int32)reader[(KhoiLuongCacCongViecKhacColumn.Id.ToString())];
					c.NamHoc = (reader[KhoiLuongCacCongViecKhacColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.NamHoc.ToString())];
					c.HocKy = (reader[KhoiLuongCacCongViecKhacColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.HocKy.ToString())];
					c.MaGiangVien = (reader[KhoiLuongCacCongViecKhacColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongCacCongViecKhacColumn.MaGiangVien.ToString())];
					c.MaLoaiCongViec = (System.Int32)reader[(KhoiLuongCacCongViecKhacColumn.MaLoaiCongViec.ToString())];
					c.OriginalMaLoaiCongViec = c.MaLoaiCongViec;
					c.MaDonViTinh = (reader[KhoiLuongCacCongViecKhacColumn.MaDonViTinh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongCacCongViecKhacColumn.MaDonViTinh.ToString())];
					c.SoLuong = (reader[KhoiLuongCacCongViecKhacColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongCacCongViecKhacColumn.SoLuong.ToString())];
					c.HeSoNhan = (reader[KhoiLuongCacCongViecKhacColumn.HeSoNhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongCacCongViecKhacColumn.HeSoNhan.ToString())];
					c.GioChuanCongThemTrenMotTiet = (reader[KhoiLuongCacCongViecKhacColumn.GioChuanCongThemTrenMotTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongCacCongViecKhacColumn.GioChuanCongThemTrenMotTiet.ToString())];
					c.MaLop = (reader[KhoiLuongCacCongViecKhacColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.MaLop.ToString())];
					c.MaNhom = (reader[KhoiLuongCacCongViecKhacColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.MaNhom.ToString())];
					c.GhiChu = (reader[KhoiLuongCacCongViecKhacColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.GhiChu.ToString())];
					c.HeSoQuyDoi = (reader[KhoiLuongCacCongViecKhacColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongCacCongViecKhacColumn.HeSoQuyDoi.ToString())];
					c.TietQuyDoi = (reader[KhoiLuongCacCongViecKhacColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongCacCongViecKhacColumn.TietQuyDoi.ToString())];
					c.Chot = (reader[KhoiLuongCacCongViecKhacColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KhoiLuongCacCongViecKhacColumn.Chot.ToString())];
					c.NgayCapNhat = (reader[KhoiLuongCacCongViecKhacColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[KhoiLuongCacCongViecKhacColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.NguoiCapNhat.ToString())];
					c.HeSoChucDanhKhoiLuongKhac = (reader[KhoiLuongCacCongViecKhacColumn.HeSoChucDanhKhoiLuongKhac.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongCacCongViecKhacColumn.HeSoChucDanhKhoiLuongKhac.ToString())];
					c.DotThanhToan = (reader[KhoiLuongCacCongViecKhacColumn.DotThanhToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.DotThanhToan.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongCacCongViecKhac"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongCacCongViecKhac"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KhoiLuongCacCongViecKhac entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KhoiLuongCacCongViecKhacColumn.Id.ToString())];
			entity.NamHoc = (reader[KhoiLuongCacCongViecKhacColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KhoiLuongCacCongViecKhacColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.HocKy.ToString())];
			entity.MaGiangVien = (reader[KhoiLuongCacCongViecKhacColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongCacCongViecKhacColumn.MaGiangVien.ToString())];
			entity.MaLoaiCongViec = (System.Int32)reader[(KhoiLuongCacCongViecKhacColumn.MaLoaiCongViec.ToString())];
			entity.OriginalMaLoaiCongViec = (System.Int32)reader["MaLoaiCongViec"];
			entity.MaDonViTinh = (reader[KhoiLuongCacCongViecKhacColumn.MaDonViTinh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongCacCongViecKhacColumn.MaDonViTinh.ToString())];
			entity.SoLuong = (reader[KhoiLuongCacCongViecKhacColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongCacCongViecKhacColumn.SoLuong.ToString())];
			entity.HeSoNhan = (reader[KhoiLuongCacCongViecKhacColumn.HeSoNhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongCacCongViecKhacColumn.HeSoNhan.ToString())];
			entity.GioChuanCongThemTrenMotTiet = (reader[KhoiLuongCacCongViecKhacColumn.GioChuanCongThemTrenMotTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongCacCongViecKhacColumn.GioChuanCongThemTrenMotTiet.ToString())];
			entity.MaLop = (reader[KhoiLuongCacCongViecKhacColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.MaLop.ToString())];
			entity.MaNhom = (reader[KhoiLuongCacCongViecKhacColumn.MaNhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.MaNhom.ToString())];
			entity.GhiChu = (reader[KhoiLuongCacCongViecKhacColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.GhiChu.ToString())];
			entity.HeSoQuyDoi = (reader[KhoiLuongCacCongViecKhacColumn.HeSoQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongCacCongViecKhacColumn.HeSoQuyDoi.ToString())];
			entity.TietQuyDoi = (reader[KhoiLuongCacCongViecKhacColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongCacCongViecKhacColumn.TietQuyDoi.ToString())];
			entity.Chot = (reader[KhoiLuongCacCongViecKhacColumn.Chot.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KhoiLuongCacCongViecKhacColumn.Chot.ToString())];
			entity.NgayCapNhat = (reader[KhoiLuongCacCongViecKhacColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[KhoiLuongCacCongViecKhacColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.NguoiCapNhat.ToString())];
			entity.HeSoChucDanhKhoiLuongKhac = (reader[KhoiLuongCacCongViecKhacColumn.HeSoChucDanhKhoiLuongKhac.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongCacCongViecKhacColumn.HeSoChucDanhKhoiLuongKhac.ToString())];
			entity.DotThanhToan = (reader[KhoiLuongCacCongViecKhacColumn.DotThanhToan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongCacCongViecKhacColumn.DotThanhToan.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongCacCongViecKhac"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongCacCongViecKhac"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KhoiLuongCacCongViecKhac entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.MaLoaiCongViec = (System.Int32)dataRow["MaLoaiCongViec"];
			entity.OriginalMaLoaiCongViec = (System.Int32)dataRow["MaLoaiCongViec"];
			entity.MaDonViTinh = Convert.IsDBNull(dataRow["MaDonViTinh"]) ? null : (System.Int32?)dataRow["MaDonViTinh"];
			entity.SoLuong = Convert.IsDBNull(dataRow["SoLuong"]) ? null : (System.Decimal?)dataRow["SoLuong"];
			entity.HeSoNhan = Convert.IsDBNull(dataRow["HeSoNhan"]) ? null : (System.Int32?)dataRow["HeSoNhan"];
			entity.GioChuanCongThemTrenMotTiet = Convert.IsDBNull(dataRow["GioChuanCongThemTrenMotTiet"]) ? null : (System.Decimal?)dataRow["GioChuanCongThemTrenMotTiet"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.MaNhom = Convert.IsDBNull(dataRow["MaNhom"]) ? null : (System.String)dataRow["MaNhom"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.HeSoQuyDoi = Convert.IsDBNull(dataRow["HeSoQuyDoi"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoi"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.Chot = Convert.IsDBNull(dataRow["Chot"]) ? null : (System.Boolean?)dataRow["Chot"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.HeSoChucDanhKhoiLuongKhac = Convert.IsDBNull(dataRow["HeSoChucDanhKhoiLuongKhac"]) ? null : (System.Decimal?)dataRow["HeSoChucDanhKhoiLuongKhac"];
			entity.DotThanhToan = Convert.IsDBNull(dataRow["DotThanhToan"]) ? null : (System.String)dataRow["DotThanhToan"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongCacCongViecKhac"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongCacCongViecKhac Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KhoiLuongCacCongViecKhac entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaLoaiCongViecSource	
			if (CanDeepLoad(entity, "QuyDoiGioChuan|MaLoaiCongViecSource", deepLoadType, innerList) 
				&& entity.MaLoaiCongViecSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MaLoaiCongViec;
				QuyDoiGioChuan tmpEntity = EntityManager.LocateEntity<QuyDoiGioChuan>(EntityLocator.ConstructKeyFromPkItems(typeof(QuyDoiGioChuan), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaLoaiCongViecSource = tmpEntity;
				else
					entity.MaLoaiCongViecSource = DataRepository.QuyDoiGioChuanProvider.GetByMaQuyDoi(transactionManager, entity.MaLoaiCongViec);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaLoaiCongViecSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaLoaiCongViecSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.QuyDoiGioChuanProvider.DeepLoad(transactionManager, entity.MaLoaiCongViecSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaLoaiCongViecSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.KhoiLuongCacCongViecKhac object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KhoiLuongCacCongViecKhac instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongCacCongViecKhac Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KhoiLuongCacCongViecKhac entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaLoaiCongViecSource
			if (CanDeepSave(entity, "QuyDoiGioChuan|MaLoaiCongViecSource", deepSaveType, innerList) 
				&& entity.MaLoaiCongViecSource != null)
			{
				DataRepository.QuyDoiGioChuanProvider.Save(transactionManager, entity.MaLoaiCongViecSource);
				entity.MaLoaiCongViec = entity.MaLoaiCongViecSource.MaQuyDoi;
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
	
	#region KhoiLuongCacCongViecKhacChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KhoiLuongCacCongViecKhac</c>
	///</summary>
	public enum KhoiLuongCacCongViecKhacChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>QuyDoiGioChuan</c> at MaLoaiCongViecSource
		///</summary>
		[ChildEntityType(typeof(QuyDoiGioChuan))]
		QuyDoiGioChuan,
	}
	
	#endregion KhoiLuongCacCongViecKhacChildEntityTypes
	
	#region KhoiLuongCacCongViecKhacFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KhoiLuongCacCongViecKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongCacCongViecKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongCacCongViecKhacFilterBuilder : SqlFilterBuilder<KhoiLuongCacCongViecKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongCacCongViecKhacFilterBuilder class.
		/// </summary>
		public KhoiLuongCacCongViecKhacFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongCacCongViecKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongCacCongViecKhacFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongCacCongViecKhacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongCacCongViecKhacFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongCacCongViecKhacFilterBuilder
	
	#region KhoiLuongCacCongViecKhacParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KhoiLuongCacCongViecKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongCacCongViecKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongCacCongViecKhacParameterBuilder : ParameterizedSqlFilterBuilder<KhoiLuongCacCongViecKhacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongCacCongViecKhacParameterBuilder class.
		/// </summary>
		public KhoiLuongCacCongViecKhacParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongCacCongViecKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongCacCongViecKhacParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongCacCongViecKhacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongCacCongViecKhacParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongCacCongViecKhacParameterBuilder
	
	#region KhoiLuongCacCongViecKhacSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KhoiLuongCacCongViecKhacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongCacCongViecKhac"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KhoiLuongCacCongViecKhacSortBuilder : SqlSortBuilder<KhoiLuongCacCongViecKhacColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongCacCongViecKhacSqlSortBuilder class.
		/// </summary>
		public KhoiLuongCacCongViecKhacSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KhoiLuongCacCongViecKhacSortBuilder
	
} // end namespace
