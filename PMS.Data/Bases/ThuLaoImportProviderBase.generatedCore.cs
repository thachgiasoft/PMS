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
	/// This class is the base class for any <see cref="ThuLaoImportProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThuLaoImportProviderBaseCore : EntityProviderBase<PMS.Entities.ThuLaoImport, PMS.Entities.ThuLaoImportKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThuLaoImportKey key)
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
		public override PMS.Entities.ThuLaoImport Get(TransactionManager transactionManager, PMS.Entities.ThuLaoImportKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThuLaoImport index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoImport"/> class.</returns>
		public PMS.Entities.ThuLaoImport GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoImport index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoImport"/> class.</returns>
		public PMS.Entities.ThuLaoImport GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoImport index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoImport"/> class.</returns>
		public PMS.Entities.ThuLaoImport GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoImport index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoImport"/> class.</returns>
		public PMS.Entities.ThuLaoImport GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoImport index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoImport"/> class.</returns>
		public PMS.Entities.ThuLaoImport GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoImport index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoImport"/> class.</returns>
		public abstract PMS.Entities.ThuLaoImport GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThuLaoImport_GetByNamHocHocKyLoaiHinhDaoTaoDotThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByNamHocHocKyLoaiHinhDaoTaoDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyLoaiHinhDaoTaoDotThanhToan(System.String namHoc, System.String hocKy, System.String maLoaiHinhDaoTao, System.Int32 dotThanhToan)
		{
			return GetByNamHocHocKyLoaiHinhDaoTaoDotThanhToan(null, 0, int.MaxValue , namHoc, hocKy, maLoaiHinhDaoTao, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByNamHocHocKyLoaiHinhDaoTaoDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyLoaiHinhDaoTaoDotThanhToan(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maLoaiHinhDaoTao, System.Int32 dotThanhToan)
		{
			return GetByNamHocHocKyLoaiHinhDaoTaoDotThanhToan(null, start, pageLength , namHoc, hocKy, maLoaiHinhDaoTao, dotThanhToan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByNamHocHocKyLoaiHinhDaoTaoDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyLoaiHinhDaoTaoDotThanhToan(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maLoaiHinhDaoTao, System.Int32 dotThanhToan)
		{
			return GetByNamHocHocKyLoaiHinhDaoTaoDotThanhToan(transactionManager, 0, int.MaxValue , namHoc, hocKy, maLoaiHinhDaoTao, dotThanhToan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByNamHocHocKyLoaiHinhDaoTaoDotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyLoaiHinhDaoTaoDotThanhToan(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maLoaiHinhDaoTao, System.Int32 dotThanhToan);
		
		#endregion
		
		#region cust_ThuLaoImport_GetByDotChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoImport&gt;"/> instance.</returns>
		public TList<ThuLaoImport> GetByDotChiTra(System.String dotChiTra)
		{
			return GetByDotChiTra(null, 0, int.MaxValue , dotChiTra);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoImport&gt;"/> instance.</returns>
		public TList<ThuLaoImport> GetByDotChiTra(int start, int pageLength, System.String dotChiTra)
		{
			return GetByDotChiTra(null, start, pageLength , dotChiTra);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoImport&gt;"/> instance.</returns>
		public TList<ThuLaoImport> GetByDotChiTra(TransactionManager transactionManager, System.String dotChiTra)
		{
			return GetByDotChiTra(transactionManager, 0, int.MaxValue , dotChiTra);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoImport&gt;"/> instance.</returns>
		public abstract TList<ThuLaoImport> GetByDotChiTra(TransactionManager transactionManager, int start, int pageLength , System.String dotChiTra);
		
		#endregion
		
		#region cust_ThuLaoImport_GetByNamHocHocKyDotChiTraWeb 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByNamHocHocKyDotChiTraWeb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotChiTraWeb(System.String namHoc, System.String hocKy, System.String maGiangVien, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTraWeb(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien, dotChiTra);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByNamHocHocKyDotChiTraWeb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotChiTraWeb(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maGiangVien, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTraWeb(null, start, pageLength , namHoc, hocKy, maGiangVien, dotChiTra);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByNamHocHocKyDotChiTraWeb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotChiTraWeb(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maGiangVien, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTraWeb(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien, dotChiTra);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByNamHocHocKyDotChiTraWeb' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyDotChiTraWeb(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maGiangVien, System.String dotChiTra);
		
		#endregion
		
		#region cust_ThuLaoImport_GetByNamHocHocKyDotChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByNamHocHocKyDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoImport&gt;"/> instance.</returns>
		public TList<ThuLaoImport> GetByNamHocHocKyDotChiTra(System.String namHoc, System.String hocKy, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTra(null, 0, int.MaxValue , namHoc, hocKy, dotChiTra);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByNamHocHocKyDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoImport&gt;"/> instance.</returns>
		public TList<ThuLaoImport> GetByNamHocHocKyDotChiTra(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTra(null, start, pageLength , namHoc, hocKy, dotChiTra);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByNamHocHocKyDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoImport&gt;"/> instance.</returns>
		public TList<ThuLaoImport> GetByNamHocHocKyDotChiTra(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTra(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotChiTra);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetByNamHocHocKyDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoImport&gt;"/> instance.</returns>
		public abstract TList<ThuLaoImport> GetByNamHocHocKyDotChiTra(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dotChiTra);
		
		#endregion
		
		#region cust_ThuLaoImport_XoaDotChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_XoaDotChiTra' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoImport_XoaDotChiTra' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoImport_XoaDotChiTra' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoImport_XoaDotChiTra' stored procedure. 
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
		
		#region cust_ThuLaoImport_GetAllDotChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetAllDotChiTra' stored procedure. 
		/// </summary>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllDotChiTra()
		{
			return GetAllDotChiTra(null, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetAllDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllDotChiTra(int start, int pageLength)
		{
			return GetAllDotChiTra(null, start, pageLength );
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetAllDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetAllDotChiTra(TransactionManager transactionManager)
		{
			return GetAllDotChiTra(transactionManager, 0, int.MaxValue );
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetAllDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetAllDotChiTra(TransactionManager transactionManager, int start, int pageLength );
		
		#endregion
		
		#region cust_ThuLaoImport_Import 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_Import' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoImport_Import' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoImport_Import' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoImport_Import' stored procedure. 
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
		
		#region cust_ThuLaoImport_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, System.String maLoaiHinhDaoTao, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, maLoaiHinhDaoTao, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String maLoaiHinhDaoTao, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, maLoaiHinhDaoTao, dotThanhToan, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String maLoaiHinhDaoTao, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, maLoaiHinhDaoTao, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiHinhDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String maLoaiHinhDaoTao, System.Int32 dotThanhToan, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoImport_GetDotChiTraByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoImport_GetDotChiTraByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoImport_GetDotChiTraByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoImport_GetDotChiTraByNamHocHocKy' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoImport_GetDotChiTraByNamHocHocKy' stored procedure. 
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
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThuLaoImport&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThuLaoImport&gt;"/></returns>
		public static TList<ThuLaoImport> Fill(IDataReader reader, TList<ThuLaoImport> rows, int start, int pageLength)
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
				
				PMS.Entities.ThuLaoImport c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThuLaoImport")
					.Append("|").Append((System.Int32)reader[((int)ThuLaoImportColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThuLaoImport>(
					key.ToString(), // EntityTrackingKey
					"ThuLaoImport",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThuLaoImport();
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
					c.Id = (System.Int32)reader[(ThuLaoImportColumn.Id.ToString())];
					c.NamHoc = (reader[ThuLaoImportColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThuLaoImportColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.HocKy.ToString())];
					c.MaCauHinhChotGio = (reader[ThuLaoImportColumn.MaCauHinhChotGio.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoImportColumn.MaCauHinhChotGio.ToString())];
					c.DotChiTra = (reader[ThuLaoImportColumn.DotChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.DotChiTra.ToString())];
					c.MaGiangVienQuanLy = (reader[ThuLaoImportColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.MaGiangVienQuanLy.ToString())];
					c.HoTen = (reader[ThuLaoImportColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.HoTen.ToString())];
					c.NoiDungChi = (reader[ThuLaoImportColumn.NoiDungChi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.NoiDungChi.ToString())];
					c.MaMonHoc = (reader[ThuLaoImportColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[ThuLaoImportColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.TenMonHoc.ToString())];
					c.MaLop = (reader[ThuLaoImportColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.MaLop.ToString())];
					c.SiSo = (reader[ThuLaoImportColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoImportColumn.SiSo.ToString())];
					c.CuNhanTaiNang = (reader[ThuLaoImportColumn.CuNhanTaiNang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoImportColumn.CuNhanTaiNang.ToString())];
					c.SoTiet = (reader[ThuLaoImportColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.SoTiet.ToString())];
					c.HeSoChucDanh = (reader[ThuLaoImportColumn.HeSoChucDanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.HeSoChucDanh.ToString())];
					c.HeSoCoSo = (reader[ThuLaoImportColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.HeSoCoSo.ToString())];
					c.HeSoLopDong = (reader[ThuLaoImportColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.HeSoLopDong.ToString())];
					c.HeSoKhac = (reader[ThuLaoImportColumn.HeSoKhac.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.HeSoKhac.ToString())];
					c.TongCongHeSo = (reader[ThuLaoImportColumn.TongCongHeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.TongCongHeSo.ToString())];
					c.TietGiangGoc = (reader[ThuLaoImportColumn.TietGiangGoc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.TietGiangGoc.ToString())];
					c.TietQuyDoi = (reader[ThuLaoImportColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.TietQuyDoi.ToString())];
					c.ChiPhiDiLai = (reader[ThuLaoImportColumn.ChiPhiDiLai.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.ChiPhiDiLai.ToString())];
					c.DonGia = (reader[ThuLaoImportColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.DonGia.ToString())];
					c.ThanhTien = (reader[ThuLaoImportColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.ThanhTien.ToString())];
					c.TongCong = (reader[ThuLaoImportColumn.TongCong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.TongCong.ToString())];
					c.TietNoKyTruoc = (reader[ThuLaoImportColumn.TietNoKyTruoc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.TietNoKyTruoc.ToString())];
					c.TietNoKyNay = (reader[ThuLaoImportColumn.TietNoKyNay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.TietNoKyNay.ToString())];
					c.TongNoGioChuan = (reader[ThuLaoImportColumn.TongNoGioChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.TongNoGioChuan.ToString())];
					c.Thue = (reader[ThuLaoImportColumn.Thue.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.Thue.ToString())];
					c.ThucLanh = (reader[ThuLaoImportColumn.ThucLanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.ThucLanh.ToString())];
					c.NgayCapNhat = (reader[ThuLaoImportColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuLaoImportColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ThuLaoImportColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.NguoiCapNhat.ToString())];
					c.HeSoBacDaoTao = (reader[ThuLaoImportColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.HeSoBacDaoTao.ToString())];
					c.HeSoThucHanh = (reader[ThuLaoImportColumn.HeSoThucHanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.HeSoThucHanh.ToString())];
					c.MaBacDaoTao = (reader[ThuLaoImportColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.MaBacDaoTao.ToString())];
					c.MaLoaiHinhDaoTao = (reader[ThuLaoImportColumn.MaLoaiHinhDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.MaLoaiHinhDaoTao.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoImport"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoImport"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThuLaoImport entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ThuLaoImportColumn.Id.ToString())];
			entity.NamHoc = (reader[ThuLaoImportColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThuLaoImportColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.HocKy.ToString())];
			entity.MaCauHinhChotGio = (reader[ThuLaoImportColumn.MaCauHinhChotGio.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoImportColumn.MaCauHinhChotGio.ToString())];
			entity.DotChiTra = (reader[ThuLaoImportColumn.DotChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.DotChiTra.ToString())];
			entity.MaGiangVienQuanLy = (reader[ThuLaoImportColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.MaGiangVienQuanLy.ToString())];
			entity.HoTen = (reader[ThuLaoImportColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.HoTen.ToString())];
			entity.NoiDungChi = (reader[ThuLaoImportColumn.NoiDungChi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.NoiDungChi.ToString())];
			entity.MaMonHoc = (reader[ThuLaoImportColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[ThuLaoImportColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.TenMonHoc.ToString())];
			entity.MaLop = (reader[ThuLaoImportColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.MaLop.ToString())];
			entity.SiSo = (reader[ThuLaoImportColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoImportColumn.SiSo.ToString())];
			entity.CuNhanTaiNang = (reader[ThuLaoImportColumn.CuNhanTaiNang.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoImportColumn.CuNhanTaiNang.ToString())];
			entity.SoTiet = (reader[ThuLaoImportColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.SoTiet.ToString())];
			entity.HeSoChucDanh = (reader[ThuLaoImportColumn.HeSoChucDanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.HeSoChucDanh.ToString())];
			entity.HeSoCoSo = (reader[ThuLaoImportColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.HeSoCoSo.ToString())];
			entity.HeSoLopDong = (reader[ThuLaoImportColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.HeSoLopDong.ToString())];
			entity.HeSoKhac = (reader[ThuLaoImportColumn.HeSoKhac.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.HeSoKhac.ToString())];
			entity.TongCongHeSo = (reader[ThuLaoImportColumn.TongCongHeSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.TongCongHeSo.ToString())];
			entity.TietGiangGoc = (reader[ThuLaoImportColumn.TietGiangGoc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.TietGiangGoc.ToString())];
			entity.TietQuyDoi = (reader[ThuLaoImportColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.TietQuyDoi.ToString())];
			entity.ChiPhiDiLai = (reader[ThuLaoImportColumn.ChiPhiDiLai.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.ChiPhiDiLai.ToString())];
			entity.DonGia = (reader[ThuLaoImportColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.DonGia.ToString())];
			entity.ThanhTien = (reader[ThuLaoImportColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.ThanhTien.ToString())];
			entity.TongCong = (reader[ThuLaoImportColumn.TongCong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.TongCong.ToString())];
			entity.TietNoKyTruoc = (reader[ThuLaoImportColumn.TietNoKyTruoc.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.TietNoKyTruoc.ToString())];
			entity.TietNoKyNay = (reader[ThuLaoImportColumn.TietNoKyNay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.TietNoKyNay.ToString())];
			entity.TongNoGioChuan = (reader[ThuLaoImportColumn.TongNoGioChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.TongNoGioChuan.ToString())];
			entity.Thue = (reader[ThuLaoImportColumn.Thue.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.Thue.ToString())];
			entity.ThucLanh = (reader[ThuLaoImportColumn.ThucLanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.ThucLanh.ToString())];
			entity.NgayCapNhat = (reader[ThuLaoImportColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(ThuLaoImportColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ThuLaoImportColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.NguoiCapNhat.ToString())];
			entity.HeSoBacDaoTao = (reader[ThuLaoImportColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.HeSoBacDaoTao.ToString())];
			entity.HeSoThucHanh = (reader[ThuLaoImportColumn.HeSoThucHanh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoImportColumn.HeSoThucHanh.ToString())];
			entity.MaBacDaoTao = (reader[ThuLaoImportColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.MaBacDaoTao.ToString())];
			entity.MaLoaiHinhDaoTao = (reader[ThuLaoImportColumn.MaLoaiHinhDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoImportColumn.MaLoaiHinhDaoTao.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoImport"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoImport"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThuLaoImport entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaCauHinhChotGio = Convert.IsDBNull(dataRow["MaCauHinhChotGio"]) ? null : (System.Int32?)dataRow["MaCauHinhChotGio"];
			entity.DotChiTra = Convert.IsDBNull(dataRow["DotChiTra"]) ? null : (System.String)dataRow["DotChiTra"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.HoTen = Convert.IsDBNull(dataRow["HoTen"]) ? null : (System.String)dataRow["HoTen"];
			entity.NoiDungChi = Convert.IsDBNull(dataRow["NoiDungChi"]) ? null : (System.String)dataRow["NoiDungChi"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.CuNhanTaiNang = Convert.IsDBNull(dataRow["CuNhanTaiNang"]) ? null : (System.Int32?)dataRow["CuNhanTaiNang"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.HeSoChucDanh = Convert.IsDBNull(dataRow["HeSoChucDanh"]) ? null : (System.Decimal?)dataRow["HeSoChucDanh"];
			entity.HeSoCoSo = Convert.IsDBNull(dataRow["HeSoCoSo"]) ? null : (System.Decimal?)dataRow["HeSoCoSo"];
			entity.HeSoLopDong = Convert.IsDBNull(dataRow["HeSoLopDong"]) ? null : (System.Decimal?)dataRow["HeSoLopDong"];
			entity.HeSoKhac = Convert.IsDBNull(dataRow["HeSoKhac"]) ? null : (System.Decimal?)dataRow["HeSoKhac"];
			entity.TongCongHeSo = Convert.IsDBNull(dataRow["TongCongHeSo"]) ? null : (System.Decimal?)dataRow["TongCongHeSo"];
			entity.TietGiangGoc = Convert.IsDBNull(dataRow["TietGiangGoc"]) ? null : (System.Decimal?)dataRow["TietGiangGoc"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.ChiPhiDiLai = Convert.IsDBNull(dataRow["ChiPhiDiLai"]) ? null : (System.Decimal?)dataRow["ChiPhiDiLai"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.ThanhTien = Convert.IsDBNull(dataRow["ThanhTien"]) ? null : (System.Decimal?)dataRow["ThanhTien"];
			entity.TongCong = Convert.IsDBNull(dataRow["TongCong"]) ? null : (System.Decimal?)dataRow["TongCong"];
			entity.TietNoKyTruoc = Convert.IsDBNull(dataRow["TietNoKyTruoc"]) ? null : (System.Decimal?)dataRow["TietNoKyTruoc"];
			entity.TietNoKyNay = Convert.IsDBNull(dataRow["TietNoKyNay"]) ? null : (System.Decimal?)dataRow["TietNoKyNay"];
			entity.TongNoGioChuan = Convert.IsDBNull(dataRow["TongNoGioChuan"]) ? null : (System.Decimal?)dataRow["TongNoGioChuan"];
			entity.Thue = Convert.IsDBNull(dataRow["Thue"]) ? null : (System.Decimal?)dataRow["Thue"];
			entity.ThucLanh = Convert.IsDBNull(dataRow["ThucLanh"]) ? null : (System.Decimal?)dataRow["ThucLanh"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.HeSoBacDaoTao = Convert.IsDBNull(dataRow["HeSoBacDaoTao"]) ? null : (System.Decimal?)dataRow["HeSoBacDaoTao"];
			entity.HeSoThucHanh = Convert.IsDBNull(dataRow["HeSoThucHanh"]) ? null : (System.Decimal?)dataRow["HeSoThucHanh"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.MaLoaiHinhDaoTao = Convert.IsDBNull(dataRow["MaLoaiHinhDaoTao"]) ? null : (System.String)dataRow["MaLoaiHinhDaoTao"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoImport"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoImport Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThuLaoImport entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThuLaoImport object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThuLaoImport instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoImport Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThuLaoImport entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThuLaoImportChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThuLaoImport</c>
	///</summary>
	public enum ThuLaoImportChildEntityTypes
	{
	}
	
	#endregion ThuLaoImportChildEntityTypes
	
	#region ThuLaoImportFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThuLaoImportColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoImport"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoImportFilterBuilder : SqlFilterBuilder<ThuLaoImportColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoImportFilterBuilder class.
		/// </summary>
		public ThuLaoImportFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoImportFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoImportFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoImportFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoImportFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoImportFilterBuilder
	
	#region ThuLaoImportParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThuLaoImportColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoImport"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoImportParameterBuilder : ParameterizedSqlFilterBuilder<ThuLaoImportColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoImportParameterBuilder class.
		/// </summary>
		public ThuLaoImportParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoImportParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoImportParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoImportParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoImportParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoImportParameterBuilder
	
	#region ThuLaoImportSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThuLaoImportColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoImport"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThuLaoImportSortBuilder : SqlSortBuilder<ThuLaoImportColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoImportSqlSortBuilder class.
		/// </summary>
		public ThuLaoImportSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThuLaoImportSortBuilder
	
} // end namespace
