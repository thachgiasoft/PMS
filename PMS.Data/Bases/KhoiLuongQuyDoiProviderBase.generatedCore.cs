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
	/// This class is the base class for any <see cref="KhoiLuongQuyDoiProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KhoiLuongQuyDoiProviderBaseCore : EntityProviderBase<PMS.Entities.KhoiLuongQuyDoi, PMS.Entities.KhoiLuongQuyDoiKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KhoiLuongQuyDoiKey key)
		{
			return Delete(transactionManager, key.MaKhoiLuongQuyDoi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maKhoiLuongQuyDoi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maKhoiLuongQuyDoi)
		{
			return Delete(null, _maKhoiLuongQuyDoi);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongQuyDoi">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maKhoiLuongQuyDoi);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongQuyDoi_KhoiLuongGiangDayChiTiet key.
		///		FK_KhoiLuongQuyDoi_KhoiLuongGiangDayChiTiet Description: 
		/// </summary>
		/// <param name="_maKhoiLuongGiangDay"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongQuyDoi objects.</returns>
		public TList<KhoiLuongQuyDoi> GetByMaKhoiLuongGiangDay(System.Int32? _maKhoiLuongGiangDay)
		{
			int count = -1;
			return GetByMaKhoiLuongGiangDay(_maKhoiLuongGiangDay, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongQuyDoi_KhoiLuongGiangDayChiTiet key.
		///		FK_KhoiLuongQuyDoi_KhoiLuongGiangDayChiTiet Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongGiangDay"></param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongQuyDoi objects.</returns>
		/// <remarks></remarks>
		public TList<KhoiLuongQuyDoi> GetByMaKhoiLuongGiangDay(TransactionManager transactionManager, System.Int32? _maKhoiLuongGiangDay)
		{
			int count = -1;
			return GetByMaKhoiLuongGiangDay(transactionManager, _maKhoiLuongGiangDay, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongQuyDoi_KhoiLuongGiangDayChiTiet key.
		///		FK_KhoiLuongQuyDoi_KhoiLuongGiangDayChiTiet Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongQuyDoi objects.</returns>
		public TList<KhoiLuongQuyDoi> GetByMaKhoiLuongGiangDay(TransactionManager transactionManager, System.Int32? _maKhoiLuongGiangDay, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuongGiangDay(transactionManager, _maKhoiLuongGiangDay, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongQuyDoi_KhoiLuongGiangDayChiTiet key.
		///		fkKhoiLuongQuyDoiKhoiLuongGiangDayChiTiet Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maKhoiLuongGiangDay"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongQuyDoi objects.</returns>
		public TList<KhoiLuongQuyDoi> GetByMaKhoiLuongGiangDay(System.Int32? _maKhoiLuongGiangDay, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaKhoiLuongGiangDay(null, _maKhoiLuongGiangDay, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongQuyDoi_KhoiLuongGiangDayChiTiet key.
		///		fkKhoiLuongQuyDoiKhoiLuongGiangDayChiTiet Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maKhoiLuongGiangDay"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongQuyDoi objects.</returns>
		public TList<KhoiLuongQuyDoi> GetByMaKhoiLuongGiangDay(System.Int32? _maKhoiLuongGiangDay, int start, int pageLength,out int count)
		{
			return GetByMaKhoiLuongGiangDay(null, _maKhoiLuongGiangDay, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_KhoiLuongQuyDoi_KhoiLuongGiangDayChiTiet key.
		///		FK_KhoiLuongQuyDoi_KhoiLuongGiangDayChiTiet Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.KhoiLuongQuyDoi objects.</returns>
		public abstract TList<KhoiLuongQuyDoi> GetByMaKhoiLuongGiangDay(TransactionManager transactionManager, System.Int32? _maKhoiLuongGiangDay, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.KhoiLuongQuyDoi Get(TransactionManager transactionManager, PMS.Entities.KhoiLuongQuyDoiKey key, int start, int pageLength)
		{
			return GetByMaKhoiLuongQuyDoi(transactionManager, key.MaKhoiLuongQuyDoi, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="_maKhoiLuongQuyDoi"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.KhoiLuongQuyDoi GetByMaKhoiLuongQuyDoi(System.Int32 _maKhoiLuongQuyDoi)
		{
			int count = -1;
			return GetByMaKhoiLuongQuyDoi(null,_maKhoiLuongQuyDoi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="_maKhoiLuongQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.KhoiLuongQuyDoi GetByMaKhoiLuongQuyDoi(System.Int32 _maKhoiLuongQuyDoi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuongQuyDoi(null, _maKhoiLuongQuyDoi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongQuyDoi"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.KhoiLuongQuyDoi GetByMaKhoiLuongQuyDoi(TransactionManager transactionManager, System.Int32 _maKhoiLuongQuyDoi)
		{
			int count = -1;
			return GetByMaKhoiLuongQuyDoi(transactionManager, _maKhoiLuongQuyDoi, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.KhoiLuongQuyDoi GetByMaKhoiLuongQuyDoi(TransactionManager transactionManager, System.Int32 _maKhoiLuongQuyDoi, int start, int pageLength)
		{
			int count = -1;
			return GetByMaKhoiLuongQuyDoi(transactionManager, _maKhoiLuongQuyDoi, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="_maKhoiLuongQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongQuyDoi"/> class.</returns>
		public PMS.Entities.KhoiLuongQuyDoi GetByMaKhoiLuongQuyDoi(System.Int32 _maKhoiLuongQuyDoi, int start, int pageLength, out int count)
		{
			return GetByMaKhoiLuongQuyDoi(null, _maKhoiLuongQuyDoi, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KhoiLuongQuyDoi index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maKhoiLuongQuyDoi"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KhoiLuongQuyDoi"/> class.</returns>
		public abstract PMS.Entities.KhoiLuongQuyDoi GetByMaKhoiLuongQuyDoi(TransactionManager transactionManager, System.Int32 _maKhoiLuongQuyDoi, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KhoiLuongQuyDoi_LuuQuyDoi 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuQuyDoi(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuQuyDoi(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuQuyDoi(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuQuyDoi(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuQuyDoi(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuQuyDoi(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuQuyDoi(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_LuuQuyDoiCtim 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoiCtim' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuQuyDoiCtim(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuQuyDoiCtim(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoiCtim' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuQuyDoiCtim(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuQuyDoiCtim(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoiCtim' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuQuyDoiCtim(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuQuyDoiCtim(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoiCtim' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuQuyDoiCtim(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_GetByMaGiangVienNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHoc(System.String maGiangVien, System.String namHoc)
		{
			return GetByMaGiangVienNamHoc(null, 0, int.MaxValue , maGiangVien, namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHoc(int start, int pageLength, System.String maGiangVien, System.String namHoc)
		{
			return GetByMaGiangVienNamHoc(null, start, pageLength , maGiangVien, namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienNamHoc(TransactionManager transactionManager, System.String maGiangVien, System.String namHoc)
		{
			return GetByMaGiangVienNamHoc(transactionManager, 0, int.MaxValue , maGiangVien, namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByMaGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByMaGiangVienNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVien, System.String namHoc);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_DeleteByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			 DeleteByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 DeleteByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 DeleteByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DeleteByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_DeleteByXmlData 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByXmlData' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByXmlData(System.String xmlData)
		{
			 DeleteByXmlData(null, 0, int.MaxValue , xmlData);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByXmlData' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByXmlData(int start, int pageLength, System.String xmlData)
		{
			 DeleteByXmlData(null, start, pageLength , xmlData);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByXmlData' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByXmlData(TransactionManager transactionManager, System.String xmlData)
		{
			 DeleteByXmlData(transactionManager, 0, int.MaxValue , xmlData);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByXmlData' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DeleteByXmlData(TransactionManager transactionManager, int start, int pageLength , System.String xmlData);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_GetByNamHocHocKyMaDonVi_Act 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKyMaDonVi_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyMaDonVi_Act(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi_Act(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKyMaDonVi_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyMaDonVi_Act(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi_Act(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKyMaDonVi_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyMaDonVi_Act(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return GetByNamHocHocKyMaDonVi_Act(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKyMaDonVi_Act' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyMaDonVi_Act(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_LuuQuyDoiAll 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoiAll' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuQuyDoiAll(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuQuyDoiAll(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoiAll' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuQuyDoiAll(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuQuyDoiAll(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoiAll' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuQuyDoiAll(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 LuuQuyDoiAll(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoiAll' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuQuyDoiAll(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_DeleteByNamHocHocKyMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNamHocHocKyMaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 DeleteByNamHocHocKyMaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNamHocHocKyMaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 DeleteByNamHocHocKyMaDonVi(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNamHocHocKyMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 DeleteByNamHocHocKyMaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DeleteByNamHocHocKyMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_GetByGiangVienNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByGiangVienNamHocHocKy(System.String listMaGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetByGiangVienNamHocHocKy(null, 0, int.MaxValue , listMaGiangVien, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByGiangVienNamHocHocKy(int start, int pageLength, System.String listMaGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetByGiangVienNamHocHocKy(null, start, pageLength , listMaGiangVien, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByGiangVienNamHocHocKy(TransactionManager transactionManager, System.String listMaGiangVien, System.String namHoc, System.String hocKy)
		{
			return GetByGiangVienNamHocHocKy(transactionManager, 0, int.MaxValue , listMaGiangVien, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByGiangVienNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="listMaGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByGiangVienNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String listMaGiangVien, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_TinhLaiGioTroGiangClc 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_TinhLaiGioTroGiangClc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void TinhLaiGioTroGiangClc(System.String namHoc, System.String hocKy)
		{
			 TinhLaiGioTroGiangClc(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_TinhLaiGioTroGiangClc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void TinhLaiGioTroGiangClc(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 TinhLaiGioTroGiangClc(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_TinhLaiGioTroGiangClc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void TinhLaiGioTroGiangClc(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 TinhLaiGioTroGiangClc(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_TinhLaiGioTroGiangClc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void TinhLaiGioTroGiangClc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_GetByNamHocHocKyDotThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKyDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotThanhToan(System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByNamHocHocKyDotThanhToan(null, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKyDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotThanhToan(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByNamHocHocKyDotThanhToan(null, start, pageLength , namHoc, hocKy, maCauHinhChotGio);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKyDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotThanhToan(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByNamHocHocKyDotThanhToan(transactionManager, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKyDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyDotThanhToan(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKy' stored procedure. 
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
		
		#region cust_KhoiLuongQuyDoi_DeleteByNamHocHocKyCauHinhChotGio 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNamHocHocKyCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNamHocHocKyCauHinhChotGio(System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			 DeleteByNamHocHocKyCauHinhChotGio(null, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNamHocHocKyCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNamHocHocKyCauHinhChotGio(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			 DeleteByNamHocHocKyCauHinhChotGio(null, start, pageLength , namHoc, hocKy, maCauHinhChotGio);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNamHocHocKyCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNamHocHocKyCauHinhChotGio(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			 DeleteByNamHocHocKyCauHinhChotGio(transactionManager, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNamHocHocKyCauHinhChotGio' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DeleteByNamHocHocKyCauHinhChotGio(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_DeleteKhoiLuongBoSungByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteKhoiLuongBoSungByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteKhoiLuongBoSungByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			 DeleteKhoiLuongBoSungByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteKhoiLuongBoSungByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteKhoiLuongBoSungByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 DeleteKhoiLuongBoSungByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteKhoiLuongBoSungByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteKhoiLuongBoSungByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 DeleteKhoiLuongBoSungByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteKhoiLuongBoSungByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DeleteKhoiLuongBoSungByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_GetByNamHocHocKyMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKyMaDonVi' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKyMaDonVi' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKyMaDonVi' stored procedure. 
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
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByNamHocHocKyMaDonVi' stored procedure. 
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
		
		#region cust_KhoiLuongQuyDoi_LuuQuyDoiTheoDotAll 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoiTheoDotAll' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuQuyDoiTheoDotAll(System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, ref System.Int32 reVal)
		{
			 LuuQuyDoiTheoDotAll(null, 0, int.MaxValue , xmlData, namHoc, hocKy, maCauHinhChotGio, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoiTheoDotAll' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuQuyDoiTheoDotAll(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, ref System.Int32 reVal)
		{
			 LuuQuyDoiTheoDotAll(null, start, pageLength , xmlData, namHoc, hocKy, maCauHinhChotGio, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoiTheoDotAll' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuQuyDoiTheoDotAll(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, ref System.Int32 reVal)
		{
			 LuuQuyDoiTheoDotAll(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, maCauHinhChotGio, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_LuuQuyDoiTheoDotAll' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuQuyDoiTheoDotAll(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_GetByBacLoaiHinhNamHocHocKyDot 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByBacLoaiHinhNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByBacLoaiHinhNamHocHocKyDot(System.String bacDaoTao, System.String loaiHinhDaoTao, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByBacLoaiHinhNamHocHocKyDot(null, 0, int.MaxValue , bacDaoTao, loaiHinhDaoTao, namHoc, hocKy, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByBacLoaiHinhNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByBacLoaiHinhNamHocHocKyDot(int start, int pageLength, System.String bacDaoTao, System.String loaiHinhDaoTao, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByBacLoaiHinhNamHocHocKyDot(null, start, pageLength , bacDaoTao, loaiHinhDaoTao, namHoc, hocKy, maCauHinhChotGio);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByBacLoaiHinhNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByBacLoaiHinhNamHocHocKyDot(TransactionManager transactionManager, System.String bacDaoTao, System.String loaiHinhDaoTao, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			return GetByBacLoaiHinhNamHocHocKyDot(transactionManager, 0, int.MaxValue , bacDaoTao, loaiHinhDaoTao, namHoc, hocKy, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_GetByBacLoaiHinhNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="bacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="loaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByBacLoaiHinhNamHocHocKyDot(TransactionManager transactionManager, int start, int pageLength , System.String bacDaoTao, System.String loaiHinhDaoTao, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio);
		
		#endregion
		
		#region cust_KhoiLuongQuyDoi_DeleteByNgay 
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			 DeleteByNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			 DeleteByNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DeleteByNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			 DeleteByNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KhoiLuongQuyDoi_DeleteByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DeleteByNgay(TransactionManager transactionManager, int start, int pageLength , System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KhoiLuongQuyDoi&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KhoiLuongQuyDoi&gt;"/></returns>
		public static TList<KhoiLuongQuyDoi> Fill(IDataReader reader, TList<KhoiLuongQuyDoi> rows, int start, int pageLength)
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
				
				PMS.Entities.KhoiLuongQuyDoi c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KhoiLuongQuyDoi")
					.Append("|").Append((System.Int32)reader[((int)KhoiLuongQuyDoiColumn.MaKhoiLuongQuyDoi - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KhoiLuongQuyDoi>(
					key.ToString(), // EntityTrackingKey
					"KhoiLuongQuyDoi",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KhoiLuongQuyDoi();
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
					c.MaKhoiLuongQuyDoi = (System.Int32)reader[(KhoiLuongQuyDoiColumn.MaKhoiLuongQuyDoi.ToString())];
					c.MaKhoiLuongGiangDay = (reader[KhoiLuongQuyDoiColumn.MaKhoiLuongGiangDay.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiColumn.MaKhoiLuongGiangDay.ToString())];
					c.MaGiangVien = (reader[KhoiLuongQuyDoiColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaGiangVien.ToString())];
					c.MaLopHocPhan = (reader[KhoiLuongQuyDoiColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaLopHocPhan.ToString())];
					c.NamHoc = (reader[KhoiLuongQuyDoiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.NamHoc.ToString())];
					c.HocKy = (reader[KhoiLuongQuyDoiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.HocKy.ToString())];
					c.MaMonHoc = (reader[KhoiLuongQuyDoiColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[KhoiLuongQuyDoiColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.TenMonHoc.ToString())];
					c.SoTinChi = (reader[KhoiLuongQuyDoiColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.SoTinChi.ToString())];
					c.SoLuong = (reader[KhoiLuongQuyDoiColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiColumn.SoLuong.ToString())];
					c.MaLoaiHocPhan = (reader[KhoiLuongQuyDoiColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(KhoiLuongQuyDoiColumn.MaLoaiHocPhan.ToString())];
					c.LoaiHocPhan = (reader[KhoiLuongQuyDoiColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.LoaiHocPhan.ToString())];
					c.MaBuoiHoc = (reader[KhoiLuongQuyDoiColumn.MaBuoiHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiColumn.MaBuoiHoc.ToString())];
					c.MaLop = (reader[KhoiLuongQuyDoiColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaLop.ToString())];
					c.TietBatDau = (reader[KhoiLuongQuyDoiColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiColumn.TietBatDau.ToString())];
					c.SoTiet = (reader[KhoiLuongQuyDoiColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.SoTiet.ToString())];
					c.TinhTrang = (reader[KhoiLuongQuyDoiColumn.TinhTrang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiColumn.TinhTrang.ToString())];
					c.NgayDay = (reader[KhoiLuongQuyDoiColumn.NgayDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongQuyDoiColumn.NgayDay.ToString())];
					c.MaBacDaoTao = (reader[KhoiLuongQuyDoiColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaBacDaoTao.ToString())];
					c.MaKhoaHoc = (reader[KhoiLuongQuyDoiColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaKhoaHoc.ToString())];
					c.MaKhoa = (reader[KhoiLuongQuyDoiColumn.MaKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaKhoa.ToString())];
					c.MaNhomMonHoc = (reader[KhoiLuongQuyDoiColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaNhomMonHoc.ToString())];
					c.MaPhongHoc = (reader[KhoiLuongQuyDoiColumn.MaPhongHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaPhongHoc.ToString())];
					c.HeSoCongViec = (reader[KhoiLuongQuyDoiColumn.HeSoCongViec.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoCongViec.ToString())];
					c.HeSoBacDaoTao = (reader[KhoiLuongQuyDoiColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoBacDaoTao.ToString())];
					c.HeSoNgonNgu = (reader[KhoiLuongQuyDoiColumn.HeSoNgonNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoNgonNgu.ToString())];
					c.HeSoChucDanhChuyenMon = (reader[KhoiLuongQuyDoiColumn.HeSoChucDanhChuyenMon.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoChucDanhChuyenMon.ToString())];
					c.HeSoLopDong = (reader[KhoiLuongQuyDoiColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoLopDong.ToString())];
					c.HeSoCoSo = (reader[KhoiLuongQuyDoiColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoCoSo.ToString())];
					c.SoTietThucTeQuyDoi = (reader[KhoiLuongQuyDoiColumn.SoTietThucTeQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.SoTietThucTeQuyDoi.ToString())];
					c.TietQuyDoi = (reader[KhoiLuongQuyDoiColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.TietQuyDoi.ToString())];
					c.HeSoQuyDoiThucHanhSangLyThuyet = (reader[KhoiLuongQuyDoiColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString())];
					c.HeSoNgoaiGio = (reader[KhoiLuongQuyDoiColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoNgoaiGio.ToString())];
					c.LoaiLop = (reader[KhoiLuongQuyDoiColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.LoaiLop.ToString())];
					c.HeSoClcCntn = (reader[KhoiLuongQuyDoiColumn.HeSoClcCntn.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoClcCntn.ToString())];
					c.HeSoThinhGiangMonChuyenNganh = (reader[KhoiLuongQuyDoiColumn.HeSoThinhGiangMonChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoThinhGiangMonChuyenNganh.ToString())];
					c.NgonNguGiangDay = (reader[KhoiLuongQuyDoiColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.NgonNguGiangDay.ToString())];
					c.HeSoTroCapGiangDay = (reader[KhoiLuongQuyDoiColumn.HeSoTroCapGiangDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoTroCapGiangDay.ToString())];
					c.HeSoTroCap = (reader[KhoiLuongQuyDoiColumn.HeSoTroCap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoTroCap.ToString())];
					c.HeSoLuong = (reader[KhoiLuongQuyDoiColumn.HeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoLuong.ToString())];
					c.HeSoMonMoi = (reader[KhoiLuongQuyDoiColumn.HeSoMonMoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoMonMoi.ToString())];
					c.HeSoNienCheTinChi = (reader[KhoiLuongQuyDoiColumn.HeSoNienCheTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoNienCheTinChi.ToString())];
					c.GhiChu = (reader[KhoiLuongQuyDoiColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.GhiChu.ToString())];
					c.MucThanhToan = (reader[KhoiLuongQuyDoiColumn.MucThanhToan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.MucThanhToan.ToString())];
					c.HeSoKhoiNganh = (reader[KhoiLuongQuyDoiColumn.HeSoKhoiNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoKhoiNganh.ToString())];
					c.MaKhoaCuaMonHoc = (reader[KhoiLuongQuyDoiColumn.MaKhoaCuaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaKhoaCuaMonHoc.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongQuyDoi"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongQuyDoi"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KhoiLuongQuyDoi entity)
		{
			if (!reader.Read()) return;
			
			entity.MaKhoiLuongQuyDoi = (System.Int32)reader[(KhoiLuongQuyDoiColumn.MaKhoiLuongQuyDoi.ToString())];
			entity.MaKhoiLuongGiangDay = (reader[KhoiLuongQuyDoiColumn.MaKhoiLuongGiangDay.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiColumn.MaKhoiLuongGiangDay.ToString())];
			entity.MaGiangVien = (reader[KhoiLuongQuyDoiColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaGiangVien.ToString())];
			entity.MaLopHocPhan = (reader[KhoiLuongQuyDoiColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaLopHocPhan.ToString())];
			entity.NamHoc = (reader[KhoiLuongQuyDoiColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KhoiLuongQuyDoiColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.HocKy.ToString())];
			entity.MaMonHoc = (reader[KhoiLuongQuyDoiColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[KhoiLuongQuyDoiColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.TenMonHoc.ToString())];
			entity.SoTinChi = (reader[KhoiLuongQuyDoiColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.SoTinChi.ToString())];
			entity.SoLuong = (reader[KhoiLuongQuyDoiColumn.SoLuong.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiColumn.SoLuong.ToString())];
			entity.MaLoaiHocPhan = (reader[KhoiLuongQuyDoiColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Byte?)reader[(KhoiLuongQuyDoiColumn.MaLoaiHocPhan.ToString())];
			entity.LoaiHocPhan = (reader[KhoiLuongQuyDoiColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.LoaiHocPhan.ToString())];
			entity.MaBuoiHoc = (reader[KhoiLuongQuyDoiColumn.MaBuoiHoc.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiColumn.MaBuoiHoc.ToString())];
			entity.MaLop = (reader[KhoiLuongQuyDoiColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaLop.ToString())];
			entity.TietBatDau = (reader[KhoiLuongQuyDoiColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiColumn.TietBatDau.ToString())];
			entity.SoTiet = (reader[KhoiLuongQuyDoiColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.SoTiet.ToString())];
			entity.TinhTrang = (reader[KhoiLuongQuyDoiColumn.TinhTrang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KhoiLuongQuyDoiColumn.TinhTrang.ToString())];
			entity.NgayDay = (reader[KhoiLuongQuyDoiColumn.NgayDay.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KhoiLuongQuyDoiColumn.NgayDay.ToString())];
			entity.MaBacDaoTao = (reader[KhoiLuongQuyDoiColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaBacDaoTao.ToString())];
			entity.MaKhoaHoc = (reader[KhoiLuongQuyDoiColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaKhoaHoc.ToString())];
			entity.MaKhoa = (reader[KhoiLuongQuyDoiColumn.MaKhoa.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaKhoa.ToString())];
			entity.MaNhomMonHoc = (reader[KhoiLuongQuyDoiColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaNhomMonHoc.ToString())];
			entity.MaPhongHoc = (reader[KhoiLuongQuyDoiColumn.MaPhongHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaPhongHoc.ToString())];
			entity.HeSoCongViec = (reader[KhoiLuongQuyDoiColumn.HeSoCongViec.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoCongViec.ToString())];
			entity.HeSoBacDaoTao = (reader[KhoiLuongQuyDoiColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoBacDaoTao.ToString())];
			entity.HeSoNgonNgu = (reader[KhoiLuongQuyDoiColumn.HeSoNgonNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoNgonNgu.ToString())];
			entity.HeSoChucDanhChuyenMon = (reader[KhoiLuongQuyDoiColumn.HeSoChucDanhChuyenMon.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoChucDanhChuyenMon.ToString())];
			entity.HeSoLopDong = (reader[KhoiLuongQuyDoiColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoLopDong.ToString())];
			entity.HeSoCoSo = (reader[KhoiLuongQuyDoiColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoCoSo.ToString())];
			entity.SoTietThucTeQuyDoi = (reader[KhoiLuongQuyDoiColumn.SoTietThucTeQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.SoTietThucTeQuyDoi.ToString())];
			entity.TietQuyDoi = (reader[KhoiLuongQuyDoiColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.TietQuyDoi.ToString())];
			entity.HeSoQuyDoiThucHanhSangLyThuyet = (reader[KhoiLuongQuyDoiColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString())];
			entity.HeSoNgoaiGio = (reader[KhoiLuongQuyDoiColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoNgoaiGio.ToString())];
			entity.LoaiLop = (reader[KhoiLuongQuyDoiColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.LoaiLop.ToString())];
			entity.HeSoClcCntn = (reader[KhoiLuongQuyDoiColumn.HeSoClcCntn.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoClcCntn.ToString())];
			entity.HeSoThinhGiangMonChuyenNganh = (reader[KhoiLuongQuyDoiColumn.HeSoThinhGiangMonChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoThinhGiangMonChuyenNganh.ToString())];
			entity.NgonNguGiangDay = (reader[KhoiLuongQuyDoiColumn.NgonNguGiangDay.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.NgonNguGiangDay.ToString())];
			entity.HeSoTroCapGiangDay = (reader[KhoiLuongQuyDoiColumn.HeSoTroCapGiangDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoTroCapGiangDay.ToString())];
			entity.HeSoTroCap = (reader[KhoiLuongQuyDoiColumn.HeSoTroCap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoTroCap.ToString())];
			entity.HeSoLuong = (reader[KhoiLuongQuyDoiColumn.HeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoLuong.ToString())];
			entity.HeSoMonMoi = (reader[KhoiLuongQuyDoiColumn.HeSoMonMoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoMonMoi.ToString())];
			entity.HeSoNienCheTinChi = (reader[KhoiLuongQuyDoiColumn.HeSoNienCheTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoNienCheTinChi.ToString())];
			entity.GhiChu = (reader[KhoiLuongQuyDoiColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.GhiChu.ToString())];
			entity.MucThanhToan = (reader[KhoiLuongQuyDoiColumn.MucThanhToan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.MucThanhToan.ToString())];
			entity.HeSoKhoiNganh = (reader[KhoiLuongQuyDoiColumn.HeSoKhoiNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KhoiLuongQuyDoiColumn.HeSoKhoiNganh.ToString())];
			entity.MaKhoaCuaMonHoc = (reader[KhoiLuongQuyDoiColumn.MaKhoaCuaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KhoiLuongQuyDoiColumn.MaKhoaCuaMonHoc.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KhoiLuongQuyDoi"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongQuyDoi"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KhoiLuongQuyDoi entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaKhoiLuongQuyDoi = (System.Int32)dataRow["MaKhoiLuongQuyDoi"];
			entity.MaKhoiLuongGiangDay = Convert.IsDBNull(dataRow["MaKhoiLuongGiangDay"]) ? null : (System.Int32?)dataRow["MaKhoiLuongGiangDay"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.String)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
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
			entity.MaKhoaHoc = Convert.IsDBNull(dataRow["MaKhoaHoc"]) ? null : (System.String)dataRow["MaKhoaHoc"];
			entity.MaKhoa = Convert.IsDBNull(dataRow["MaKhoa"]) ? null : (System.String)dataRow["MaKhoa"];
			entity.MaNhomMonHoc = Convert.IsDBNull(dataRow["MaNhomMonHoc"]) ? null : (System.String)dataRow["MaNhomMonHoc"];
			entity.MaPhongHoc = Convert.IsDBNull(dataRow["MaPhongHoc"]) ? null : (System.String)dataRow["MaPhongHoc"];
			entity.HeSoCongViec = Convert.IsDBNull(dataRow["HeSoCongViec"]) ? null : (System.Decimal?)dataRow["HeSoCongViec"];
			entity.HeSoBacDaoTao = Convert.IsDBNull(dataRow["HeSoBacDaoTao"]) ? null : (System.Decimal?)dataRow["HeSoBacDaoTao"];
			entity.HeSoNgonNgu = Convert.IsDBNull(dataRow["HeSoNgonNgu"]) ? null : (System.Decimal?)dataRow["HeSoNgonNgu"];
			entity.HeSoChucDanhChuyenMon = Convert.IsDBNull(dataRow["HeSoChucDanhChuyenMon"]) ? null : (System.Decimal?)dataRow["HeSoChucDanhChuyenMon"];
			entity.HeSoLopDong = Convert.IsDBNull(dataRow["HeSoLopDong"]) ? null : (System.Decimal?)dataRow["HeSoLopDong"];
			entity.HeSoCoSo = Convert.IsDBNull(dataRow["HeSoCoSo"]) ? null : (System.Decimal?)dataRow["HeSoCoSo"];
			entity.SoTietThucTeQuyDoi = Convert.IsDBNull(dataRow["SoTietThucTeQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietThucTeQuyDoi"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.HeSoQuyDoiThucHanhSangLyThuyet = Convert.IsDBNull(dataRow["HeSoQuyDoiThucHanhSangLyThuyet"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoiThucHanhSangLyThuyet"];
			entity.HeSoNgoaiGio = Convert.IsDBNull(dataRow["HeSoNgoaiGio"]) ? null : (System.Decimal?)dataRow["HeSoNgoaiGio"];
			entity.LoaiLop = Convert.IsDBNull(dataRow["LoaiLop"]) ? null : (System.String)dataRow["LoaiLop"];
			entity.HeSoClcCntn = Convert.IsDBNull(dataRow["HeSoClcCntn"]) ? null : (System.Decimal?)dataRow["HeSoClcCntn"];
			entity.HeSoThinhGiangMonChuyenNganh = Convert.IsDBNull(dataRow["HeSoThinhGiangMonChuyenNganh"]) ? null : (System.Decimal?)dataRow["HeSoThinhGiangMonChuyenNganh"];
			entity.NgonNguGiangDay = Convert.IsDBNull(dataRow["NgonNguGiangDay"]) ? null : (System.String)dataRow["NgonNguGiangDay"];
			entity.HeSoTroCapGiangDay = Convert.IsDBNull(dataRow["HeSoTroCapGiangDay"]) ? null : (System.Decimal?)dataRow["HeSoTroCapGiangDay"];
			entity.HeSoTroCap = Convert.IsDBNull(dataRow["HeSoTroCap"]) ? null : (System.Decimal?)dataRow["HeSoTroCap"];
			entity.HeSoLuong = Convert.IsDBNull(dataRow["HeSoLuong"]) ? null : (System.Decimal?)dataRow["HeSoLuong"];
			entity.HeSoMonMoi = Convert.IsDBNull(dataRow["HeSoMonMoi"]) ? null : (System.Decimal?)dataRow["HeSoMonMoi"];
			entity.HeSoNienCheTinChi = Convert.IsDBNull(dataRow["HeSoNienCheTinChi"]) ? null : (System.Decimal?)dataRow["HeSoNienCheTinChi"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.MucThanhToan = Convert.IsDBNull(dataRow["MucThanhToan"]) ? null : (System.Decimal?)dataRow["MucThanhToan"];
			entity.HeSoKhoiNganh = Convert.IsDBNull(dataRow["HeSoKhoiNganh"]) ? null : (System.Decimal?)dataRow["HeSoKhoiNganh"];
			entity.MaKhoaCuaMonHoc = Convert.IsDBNull(dataRow["MaKhoaCuaMonHoc"]) ? null : (System.String)dataRow["MaKhoaCuaMonHoc"];
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
		/// <param name="entity">The <see cref="PMS.Entities.KhoiLuongQuyDoi"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongQuyDoi Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KhoiLuongQuyDoi entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaKhoiLuongGiangDaySource	
			if (CanDeepLoad(entity, "KhoiLuongGiangDayChiTiet|MaKhoiLuongGiangDaySource", deepLoadType, innerList) 
				&& entity.MaKhoiLuongGiangDaySource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaKhoiLuongGiangDay ?? (int)0);
				KhoiLuongGiangDayChiTiet tmpEntity = EntityManager.LocateEntity<KhoiLuongGiangDayChiTiet>(EntityLocator.ConstructKeyFromPkItems(typeof(KhoiLuongGiangDayChiTiet), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaKhoiLuongGiangDaySource = tmpEntity;
				else
					entity.MaKhoiLuongGiangDaySource = DataRepository.KhoiLuongGiangDayChiTietProvider.GetByMaKhoiLuong(transactionManager, (entity.MaKhoiLuongGiangDay ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaKhoiLuongGiangDaySource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaKhoiLuongGiangDaySource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.KhoiLuongGiangDayChiTietProvider.DeepLoad(transactionManager, entity.MaKhoiLuongGiangDaySource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaKhoiLuongGiangDaySource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.KhoiLuongQuyDoi object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KhoiLuongQuyDoi instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KhoiLuongQuyDoi Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KhoiLuongQuyDoi entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaKhoiLuongGiangDaySource
			if (CanDeepSave(entity, "KhoiLuongGiangDayChiTiet|MaKhoiLuongGiangDaySource", deepSaveType, innerList) 
				&& entity.MaKhoiLuongGiangDaySource != null)
			{
				DataRepository.KhoiLuongGiangDayChiTietProvider.Save(transactionManager, entity.MaKhoiLuongGiangDaySource);
				entity.MaKhoiLuongGiangDay = entity.MaKhoiLuongGiangDaySource.MaKhoiLuong;
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
	
	#region KhoiLuongQuyDoiChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KhoiLuongQuyDoi</c>
	///</summary>
	public enum KhoiLuongQuyDoiChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>KhoiLuongGiangDayChiTiet</c> at MaKhoiLuongGiangDaySource
		///</summary>
		[ChildEntityType(typeof(KhoiLuongGiangDayChiTiet))]
		KhoiLuongGiangDayChiTiet,
	}
	
	#endregion KhoiLuongQuyDoiChildEntityTypes
	
	#region KhoiLuongQuyDoiFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KhoiLuongQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongQuyDoiFilterBuilder : SqlFilterBuilder<KhoiLuongQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		public KhoiLuongQuyDoiFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongQuyDoiFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongQuyDoiFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongQuyDoiFilterBuilder
	
	#region KhoiLuongQuyDoiParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KhoiLuongQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongQuyDoiParameterBuilder : ParameterizedSqlFilterBuilder<KhoiLuongQuyDoiColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		public KhoiLuongQuyDoiParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KhoiLuongQuyDoiParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KhoiLuongQuyDoiParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KhoiLuongQuyDoiParameterBuilder
	
	#region KhoiLuongQuyDoiSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KhoiLuongQuyDoiColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongQuyDoi"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KhoiLuongQuyDoiSortBuilder : SqlSortBuilder<KhoiLuongQuyDoiColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiSqlSortBuilder class.
		/// </summary>
		public KhoiLuongQuyDoiSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KhoiLuongQuyDoiSortBuilder
	
} // end namespace
