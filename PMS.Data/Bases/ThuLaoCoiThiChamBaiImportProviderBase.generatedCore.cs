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
	/// This class is the base class for any <see cref="ThuLaoCoiThiChamBaiImportProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThuLaoCoiThiChamBaiImportProviderBaseCore : EntityProviderBase<PMS.Entities.ThuLaoCoiThiChamBaiImport, PMS.Entities.ThuLaoCoiThiChamBaiImportKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThiChamBaiImportKey key)
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
		public override PMS.Entities.ThuLaoCoiThiChamBaiImport Get(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThiChamBaiImportKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThuLaoCoiThiChamBaiImport index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiChamBaiImport"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiChamBaiImport GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiChamBaiImport index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiChamBaiImport"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiChamBaiImport GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiChamBaiImport index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiChamBaiImport"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiChamBaiImport GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiChamBaiImport index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiChamBaiImport"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiChamBaiImport GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiChamBaiImport index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiChamBaiImport"/> class.</returns>
		public PMS.Entities.ThuLaoCoiThiChamBaiImport GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThuLaoCoiThiChamBaiImport index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThuLaoCoiThiChamBaiImport"/> class.</returns>
		public abstract PMS.Entities.ThuLaoCoiThiChamBaiImport GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThuLaoCoiThiChamBaiImport_GetByNamHocHocKyDotChiTraWeb 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_GetByNamHocHocKyDotChiTraWeb' stored procedure. 
		/// </summary>
		/// <param name="yearStudy"> A <c>System.String</c> instance.</param>
		/// <param name="termId"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotChiTraWeb(System.String yearStudy, System.String termId, System.String professorId, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTraWeb(null, 0, int.MaxValue , yearStudy, termId, professorId, dotChiTra);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_GetByNamHocHocKyDotChiTraWeb' stored procedure. 
		/// </summary>
		/// <param name="yearStudy"> A <c>System.String</c> instance.</param>
		/// <param name="termId"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotChiTraWeb(int start, int pageLength, System.String yearStudy, System.String termId, System.String professorId, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTraWeb(null, start, pageLength , yearStudy, termId, professorId, dotChiTra);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_GetByNamHocHocKyDotChiTraWeb' stored procedure. 
		/// </summary>
		/// <param name="yearStudy"> A <c>System.String</c> instance.</param>
		/// <param name="termId"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHocHocKyDotChiTraWeb(TransactionManager transactionManager, System.String yearStudy, System.String termId, System.String professorId, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTraWeb(transactionManager, 0, int.MaxValue , yearStudy, termId, professorId, dotChiTra);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_GetByNamHocHocKyDotChiTraWeb' stored procedure. 
		/// </summary>
		/// <param name="yearStudy"> A <c>System.String</c> instance.</param>
		/// <param name="termId"> A <c>System.String</c> instance.</param>
		/// <param name="professorId"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHocHocKyDotChiTraWeb(TransactionManager transactionManager, int start, int pageLength , System.String yearStudy, System.String termId, System.String professorId, System.String dotChiTra);
		
		#endregion
		
		#region cust_ThuLaoCoiThiChamBaiImport_GetByNamHocHocKyDotChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_GetByNamHocHocKyDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoCoiThiChamBaiImport&gt;"/> instance.</returns>
		public TList<ThuLaoCoiThiChamBaiImport> GetByNamHocHocKyDotChiTra(System.String namHoc, System.String hocKy, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTra(null, 0, int.MaxValue , namHoc, hocKy, dotChiTra);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_GetByNamHocHocKyDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoCoiThiChamBaiImport&gt;"/> instance.</returns>
		public TList<ThuLaoCoiThiChamBaiImport> GetByNamHocHocKyDotChiTra(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTra(null, start, pageLength , namHoc, hocKy, dotChiTra);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_GetByNamHocHocKyDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoCoiThiChamBaiImport&gt;"/> instance.</returns>
		public TList<ThuLaoCoiThiChamBaiImport> GetByNamHocHocKyDotChiTra(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dotChiTra)
		{
			return GetByNamHocHocKyDotChiTra(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotChiTra);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_GetByNamHocHocKyDotChiTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotChiTra"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ThuLaoCoiThiChamBaiImport&gt;"/> instance.</returns>
		public abstract TList<ThuLaoCoiThiChamBaiImport> GetByNamHocHocKyDotChiTra(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String dotChiTra);
		
		#endregion
		
		#region cust_ThuLaoCoiThiChamBaiImport_XoaDotChiTra 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_XoaDotChiTra' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_XoaDotChiTra' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_XoaDotChiTra' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_XoaDotChiTra' stored procedure. 
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
		
		#region cust_ThuLaoCoiThiChamBaiImport_Import 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_Import' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_Import' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_Import' stored procedure. 
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
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_Import' stored procedure. 
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
		
		#region cust_ThuLaoCoiThiChamBaiImport_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacLoaiHinh"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, System.String maBacLoaiHinh, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, maBacLoaiHinh, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacLoaiHinh"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, System.String maBacLoaiHinh, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, maBacLoaiHinh, dotThanhToan, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacLoaiHinh"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, System.String maBacLoaiHinh, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, maBacLoaiHinh, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacLoaiHinh"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, System.String maBacLoaiHinh, System.Int32 dotThanhToan, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThuLaoCoiThiChamBaiImport_GetDotChiTraByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_GetDotChiTraByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="yearStudy"> A <c>System.String</c> instance.</param>
		/// <param name="termId"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDotChiTraByNamHocHocKy(System.String yearStudy, System.String termId)
		{
			return GetDotChiTraByNamHocHocKy(null, 0, int.MaxValue , yearStudy, termId);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_GetDotChiTraByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="yearStudy"> A <c>System.String</c> instance.</param>
		/// <param name="termId"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDotChiTraByNamHocHocKy(int start, int pageLength, System.String yearStudy, System.String termId)
		{
			return GetDotChiTraByNamHocHocKy(null, start, pageLength , yearStudy, termId);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_GetDotChiTraByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="yearStudy"> A <c>System.String</c> instance.</param>
		/// <param name="termId"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetDotChiTraByNamHocHocKy(TransactionManager transactionManager, System.String yearStudy, System.String termId)
		{
			return GetDotChiTraByNamHocHocKy(transactionManager, 0, int.MaxValue , yearStudy, termId);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThuLaoCoiThiChamBaiImport_GetDotChiTraByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="yearStudy"> A <c>System.String</c> instance.</param>
		/// <param name="termId"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetDotChiTraByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String yearStudy, System.String termId);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThuLaoCoiThiChamBaiImport&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThuLaoCoiThiChamBaiImport&gt;"/></returns>
		public static TList<ThuLaoCoiThiChamBaiImport> Fill(IDataReader reader, TList<ThuLaoCoiThiChamBaiImport> rows, int start, int pageLength)
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
				
				PMS.Entities.ThuLaoCoiThiChamBaiImport c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThuLaoCoiThiChamBaiImport")
					.Append("|").Append((System.Int32)reader[((int)ThuLaoCoiThiChamBaiImportColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThuLaoCoiThiChamBaiImport>(
					key.ToString(), // EntityTrackingKey
					"ThuLaoCoiThiChamBaiImport",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThuLaoCoiThiChamBaiImport();
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
					c.Id = (System.Int32)reader[(ThuLaoCoiThiChamBaiImportColumn.Id.ToString())];
					c.NamHoc = (reader[ThuLaoCoiThiChamBaiImportColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.NamHoc.ToString())];
					c.HocKy = (reader[ThuLaoCoiThiChamBaiImportColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.HocKy.ToString())];
					c.DotChiTra = (reader[ThuLaoCoiThiChamBaiImportColumn.DotChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.DotChiTra.ToString())];
					c.MaGiangVienQuanLy = (reader[ThuLaoCoiThiChamBaiImportColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.MaGiangVienQuanLy.ToString())];
					c.HoTen = (reader[ThuLaoCoiThiChamBaiImportColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.HoTen.ToString())];
					c.NoiDungChi = (reader[ThuLaoCoiThiChamBaiImportColumn.NoiDungChi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.NoiDungChi.ToString())];
					c.MaMonHoc = (reader[ThuLaoCoiThiChamBaiImportColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[ThuLaoCoiThiChamBaiImportColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.TenMonHoc.ToString())];
					c.MaLop = (reader[ThuLaoCoiThiChamBaiImportColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.MaLop.ToString())];
					c.SoBaiQuaTrinh = (reader[ThuLaoCoiThiChamBaiImportColumn.SoBaiQuaTrinh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.SoBaiQuaTrinh.ToString())];
					c.SoBaiGiuaKy = (reader[ThuLaoCoiThiChamBaiImportColumn.SoBaiGiuaKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.SoBaiGiuaKy.ToString())];
					c.SoBaiCuoiKy = (reader[ThuLaoCoiThiChamBaiImportColumn.SoBaiCuoiKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.SoBaiCuoiKy.ToString())];
					c.DonGiaQuaTrinh = (reader[ThuLaoCoiThiChamBaiImportColumn.DonGiaQuaTrinh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.DonGiaQuaTrinh.ToString())];
					c.DonGiaGiuaKy = (reader[ThuLaoCoiThiChamBaiImportColumn.DonGiaGiuaKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.DonGiaGiuaKy.ToString())];
					c.DonGiaCuoiKy = (reader[ThuLaoCoiThiChamBaiImportColumn.DonGiaCuoiKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.DonGiaCuoiKy.ToString())];
					c.ThanhTien = (reader[ThuLaoCoiThiChamBaiImportColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.ThanhTien.ToString())];
					c.SoTienCoiThi = (reader[ThuLaoCoiThiChamBaiImportColumn.SoTienCoiThi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.SoTienCoiThi.ToString())];
					c.NgayCapNhat = (reader[ThuLaoCoiThiChamBaiImportColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ThuLaoCoiThiChamBaiImportColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.NguoiCapNhat.ToString())];
					c.BacDaoTao = (reader[ThuLaoCoiThiChamBaiImportColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.BacDaoTao.ToString())];
					c.GioCoiThi = (reader[ThuLaoCoiThiChamBaiImportColumn.GioCoiThi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiChamBaiImportColumn.GioCoiThi.ToString())];
					c.GioChamThi = (reader[ThuLaoCoiThiChamBaiImportColumn.GioChamThi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiChamBaiImportColumn.GioChamThi.ToString())];
					c.GioRaDe = (reader[ThuLaoCoiThiChamBaiImportColumn.GioRaDe.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiChamBaiImportColumn.GioRaDe.ToString())];
					c.GioToChucThi = (reader[ThuLaoCoiThiChamBaiImportColumn.GioToChucThi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiChamBaiImportColumn.GioToChucThi.ToString())];
					c.GioNhapDiem = (reader[ThuLaoCoiThiChamBaiImportColumn.GioNhapDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiChamBaiImportColumn.GioNhapDiem.ToString())];
					c.TongCong = (reader[ThuLaoCoiThiChamBaiImportColumn.TongCong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiChamBaiImportColumn.TongCong.ToString())];
					c.LoaiHinHdaoTao = (reader[ThuLaoCoiThiChamBaiImportColumn.LoaiHinHdaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.LoaiHinHdaoTao.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoCoiThiChamBaiImport"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoCoiThiChamBaiImport"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThuLaoCoiThiChamBaiImport entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ThuLaoCoiThiChamBaiImportColumn.Id.ToString())];
			entity.NamHoc = (reader[ThuLaoCoiThiChamBaiImportColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.NamHoc.ToString())];
			entity.HocKy = (reader[ThuLaoCoiThiChamBaiImportColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.HocKy.ToString())];
			entity.DotChiTra = (reader[ThuLaoCoiThiChamBaiImportColumn.DotChiTra.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.DotChiTra.ToString())];
			entity.MaGiangVienQuanLy = (reader[ThuLaoCoiThiChamBaiImportColumn.MaGiangVienQuanLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.MaGiangVienQuanLy.ToString())];
			entity.HoTen = (reader[ThuLaoCoiThiChamBaiImportColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.HoTen.ToString())];
			entity.NoiDungChi = (reader[ThuLaoCoiThiChamBaiImportColumn.NoiDungChi.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.NoiDungChi.ToString())];
			entity.MaMonHoc = (reader[ThuLaoCoiThiChamBaiImportColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[ThuLaoCoiThiChamBaiImportColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.TenMonHoc.ToString())];
			entity.MaLop = (reader[ThuLaoCoiThiChamBaiImportColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.MaLop.ToString())];
			entity.SoBaiQuaTrinh = (reader[ThuLaoCoiThiChamBaiImportColumn.SoBaiQuaTrinh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.SoBaiQuaTrinh.ToString())];
			entity.SoBaiGiuaKy = (reader[ThuLaoCoiThiChamBaiImportColumn.SoBaiGiuaKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.SoBaiGiuaKy.ToString())];
			entity.SoBaiCuoiKy = (reader[ThuLaoCoiThiChamBaiImportColumn.SoBaiCuoiKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.SoBaiCuoiKy.ToString())];
			entity.DonGiaQuaTrinh = (reader[ThuLaoCoiThiChamBaiImportColumn.DonGiaQuaTrinh.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.DonGiaQuaTrinh.ToString())];
			entity.DonGiaGiuaKy = (reader[ThuLaoCoiThiChamBaiImportColumn.DonGiaGiuaKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.DonGiaGiuaKy.ToString())];
			entity.DonGiaCuoiKy = (reader[ThuLaoCoiThiChamBaiImportColumn.DonGiaCuoiKy.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.DonGiaCuoiKy.ToString())];
			entity.ThanhTien = (reader[ThuLaoCoiThiChamBaiImportColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.ThanhTien.ToString())];
			entity.SoTienCoiThi = (reader[ThuLaoCoiThiChamBaiImportColumn.SoTienCoiThi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThuLaoCoiThiChamBaiImportColumn.SoTienCoiThi.ToString())];
			entity.NgayCapNhat = (reader[ThuLaoCoiThiChamBaiImportColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ThuLaoCoiThiChamBaiImportColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.NguoiCapNhat.ToString())];
			entity.BacDaoTao = (reader[ThuLaoCoiThiChamBaiImportColumn.BacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.BacDaoTao.ToString())];
			entity.GioCoiThi = (reader[ThuLaoCoiThiChamBaiImportColumn.GioCoiThi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiChamBaiImportColumn.GioCoiThi.ToString())];
			entity.GioChamThi = (reader[ThuLaoCoiThiChamBaiImportColumn.GioChamThi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiChamBaiImportColumn.GioChamThi.ToString())];
			entity.GioRaDe = (reader[ThuLaoCoiThiChamBaiImportColumn.GioRaDe.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiChamBaiImportColumn.GioRaDe.ToString())];
			entity.GioToChucThi = (reader[ThuLaoCoiThiChamBaiImportColumn.GioToChucThi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiChamBaiImportColumn.GioToChucThi.ToString())];
			entity.GioNhapDiem = (reader[ThuLaoCoiThiChamBaiImportColumn.GioNhapDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiChamBaiImportColumn.GioNhapDiem.ToString())];
			entity.TongCong = (reader[ThuLaoCoiThiChamBaiImportColumn.TongCong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThuLaoCoiThiChamBaiImportColumn.TongCong.ToString())];
			entity.LoaiHinHdaoTao = (reader[ThuLaoCoiThiChamBaiImportColumn.LoaiHinHdaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThuLaoCoiThiChamBaiImportColumn.LoaiHinHdaoTao.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThuLaoCoiThiChamBaiImport"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoCoiThiChamBaiImport"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThuLaoCoiThiChamBaiImport entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.DotChiTra = Convert.IsDBNull(dataRow["DotChiTra"]) ? null : (System.String)dataRow["DotChiTra"];
			entity.MaGiangVienQuanLy = Convert.IsDBNull(dataRow["MaGiangVienQuanLy"]) ? null : (System.String)dataRow["MaGiangVienQuanLy"];
			entity.HoTen = Convert.IsDBNull(dataRow["HoTen"]) ? null : (System.String)dataRow["HoTen"];
			entity.NoiDungChi = Convert.IsDBNull(dataRow["NoiDungChi"]) ? null : (System.String)dataRow["NoiDungChi"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.SoBaiQuaTrinh = Convert.IsDBNull(dataRow["SoBaiQuaTrinh"]) ? null : (System.Int32?)dataRow["SoBaiQuaTrinh"];
			entity.SoBaiGiuaKy = Convert.IsDBNull(dataRow["SoBaiGiuaKy"]) ? null : (System.Int32?)dataRow["SoBaiGiuaKy"];
			entity.SoBaiCuoiKy = Convert.IsDBNull(dataRow["SoBaiCuoiKy"]) ? null : (System.Int32?)dataRow["SoBaiCuoiKy"];
			entity.DonGiaQuaTrinh = Convert.IsDBNull(dataRow["DonGiaQuaTrinh"]) ? null : (System.Int32?)dataRow["DonGiaQuaTrinh"];
			entity.DonGiaGiuaKy = Convert.IsDBNull(dataRow["DonGiaGiuaKy"]) ? null : (System.Int32?)dataRow["DonGiaGiuaKy"];
			entity.DonGiaCuoiKy = Convert.IsDBNull(dataRow["DonGiaCuoiKy"]) ? null : (System.Int32?)dataRow["DonGiaCuoiKy"];
			entity.ThanhTien = Convert.IsDBNull(dataRow["ThanhTien"]) ? null : (System.Int32?)dataRow["ThanhTien"];
			entity.SoTienCoiThi = Convert.IsDBNull(dataRow["SoTienCoiThi"]) ? null : (System.Int32?)dataRow["SoTienCoiThi"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.BacDaoTao = Convert.IsDBNull(dataRow["BacDaoTao"]) ? null : (System.String)dataRow["BacDaoTao"];
			entity.GioCoiThi = Convert.IsDBNull(dataRow["GioCoiThi"]) ? null : (System.Decimal?)dataRow["GioCoiThi"];
			entity.GioChamThi = Convert.IsDBNull(dataRow["GioChamThi"]) ? null : (System.Decimal?)dataRow["GioChamThi"];
			entity.GioRaDe = Convert.IsDBNull(dataRow["GioRaDe"]) ? null : (System.Decimal?)dataRow["GioRaDe"];
			entity.GioToChucThi = Convert.IsDBNull(dataRow["GioToChucThi"]) ? null : (System.Decimal?)dataRow["GioToChucThi"];
			entity.GioNhapDiem = Convert.IsDBNull(dataRow["GioNhapDiem"]) ? null : (System.Decimal?)dataRow["GioNhapDiem"];
			entity.TongCong = Convert.IsDBNull(dataRow["TongCong"]) ? null : (System.Decimal?)dataRow["TongCong"];
			entity.LoaiHinHdaoTao = Convert.IsDBNull(dataRow["LoaiHinHDaoTao"]) ? null : (System.String)dataRow["LoaiHinHDaoTao"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ThuLaoCoiThiChamBaiImport"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoCoiThiChamBaiImport Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThiChamBaiImport entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.ThuLaoCoiThiChamBaiImport object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThuLaoCoiThiChamBaiImport instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThuLaoCoiThiChamBaiImport Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThuLaoCoiThiChamBaiImport entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ThuLaoCoiThiChamBaiImportChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThuLaoCoiThiChamBaiImport</c>
	///</summary>
	public enum ThuLaoCoiThiChamBaiImportChildEntityTypes
	{
	}
	
	#endregion ThuLaoCoiThiChamBaiImportChildEntityTypes
	
	#region ThuLaoCoiThiChamBaiImportFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThuLaoCoiThiChamBaiImportColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiChamBaiImport"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiChamBaiImportFilterBuilder : SqlFilterBuilder<ThuLaoCoiThiChamBaiImportColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiChamBaiImportFilterBuilder class.
		/// </summary>
		public ThuLaoCoiThiChamBaiImportFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiChamBaiImportFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoCoiThiChamBaiImportFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiChamBaiImportFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoCoiThiChamBaiImportFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoCoiThiChamBaiImportFilterBuilder
	
	#region ThuLaoCoiThiChamBaiImportParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThuLaoCoiThiChamBaiImportColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiChamBaiImport"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiChamBaiImportParameterBuilder : ParameterizedSqlFilterBuilder<ThuLaoCoiThiChamBaiImportColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiChamBaiImportParameterBuilder class.
		/// </summary>
		public ThuLaoCoiThiChamBaiImportParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiChamBaiImportParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThuLaoCoiThiChamBaiImportParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiChamBaiImportParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThuLaoCoiThiChamBaiImportParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThuLaoCoiThiChamBaiImportParameterBuilder
	
	#region ThuLaoCoiThiChamBaiImportSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThuLaoCoiThiChamBaiImportColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiChamBaiImport"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThuLaoCoiThiChamBaiImportSortBuilder : SqlSortBuilder<ThuLaoCoiThiChamBaiImportColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiChamBaiImportSqlSortBuilder class.
		/// </summary>
		public ThuLaoCoiThiChamBaiImportSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThuLaoCoiThiChamBaiImportSortBuilder
	
} // end namespace
