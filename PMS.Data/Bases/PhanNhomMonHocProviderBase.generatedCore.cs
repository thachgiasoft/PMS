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
	/// This class is the base class for any <see cref="PhanNhomMonHocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PhanNhomMonHocProviderBaseCore : EntityProviderBase<PMS.Entities.PhanNhomMonHoc, PMS.Entities.PhanNhomMonHocKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.PhanNhomMonHocKey key)
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
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PhanNhomMonHoc_NhomMonHoc key.
		///		FK_PhanNhomMonHoc_NhomMonHoc Description: 
		/// </summary>
		/// <param name="_maNhomMonHoc"></param>
		/// <returns>Returns a typed collection of PMS.Entities.PhanNhomMonHoc objects.</returns>
		public TList<PhanNhomMonHoc> GetByMaNhomMonHoc(System.Int32 _maNhomMonHoc)
		{
			int count = -1;
			return GetByMaNhomMonHoc(_maNhomMonHoc, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PhanNhomMonHoc_NhomMonHoc key.
		///		FK_PhanNhomMonHoc_NhomMonHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMonHoc"></param>
		/// <returns>Returns a typed collection of PMS.Entities.PhanNhomMonHoc objects.</returns>
		/// <remarks></remarks>
		public TList<PhanNhomMonHoc> GetByMaNhomMonHoc(TransactionManager transactionManager, System.Int32 _maNhomMonHoc)
		{
			int count = -1;
			return GetByMaNhomMonHoc(transactionManager, _maNhomMonHoc, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PhanNhomMonHoc_NhomMonHoc key.
		///		FK_PhanNhomMonHoc_NhomMonHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMonHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.PhanNhomMonHoc objects.</returns>
		public TList<PhanNhomMonHoc> GetByMaNhomMonHoc(TransactionManager transactionManager, System.Int32 _maNhomMonHoc, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomMonHoc(transactionManager, _maNhomMonHoc, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PhanNhomMonHoc_NhomMonHoc key.
		///		fkPhanNhomMonHocNhomMonHoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhomMonHoc"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.PhanNhomMonHoc objects.</returns>
		public TList<PhanNhomMonHoc> GetByMaNhomMonHoc(System.Int32 _maNhomMonHoc, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaNhomMonHoc(null, _maNhomMonHoc, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PhanNhomMonHoc_NhomMonHoc key.
		///		fkPhanNhomMonHocNhomMonHoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhomMonHoc"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.PhanNhomMonHoc objects.</returns>
		public TList<PhanNhomMonHoc> GetByMaNhomMonHoc(System.Int32 _maNhomMonHoc, int start, int pageLength,out int count)
		{
			return GetByMaNhomMonHoc(null, _maNhomMonHoc, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PhanNhomMonHoc_NhomMonHoc key.
		///		FK_PhanNhomMonHoc_NhomMonHoc Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomMonHoc"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.PhanNhomMonHoc objects.</returns>
		public abstract TList<PhanNhomMonHoc> GetByMaNhomMonHoc(TransactionManager transactionManager, System.Int32 _maNhomMonHoc, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.PhanNhomMonHoc Get(TransactionManager transactionManager, PMS.Entities.PhanNhomMonHocKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PhanNhomMonHoc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanNhomMonHoc"/> class.</returns>
		public PMS.Entities.PhanNhomMonHoc GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanNhomMonHoc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanNhomMonHoc"/> class.</returns>
		public PMS.Entities.PhanNhomMonHoc GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanNhomMonHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanNhomMonHoc"/> class.</returns>
		public PMS.Entities.PhanNhomMonHoc GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanNhomMonHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanNhomMonHoc"/> class.</returns>
		public PMS.Entities.PhanNhomMonHoc GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanNhomMonHoc index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanNhomMonHoc"/> class.</returns>
		public PMS.Entities.PhanNhomMonHoc GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PhanNhomMonHoc index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.PhanNhomMonHoc"/> class.</returns>
		public abstract PMS.Entities.PhanNhomMonHoc GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_PhanNhomMonHoc_GetNhomMonHocByMaMonHocNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetNhomMonHocByMaMonHocNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetNhomMonHocByMaMonHocNamHocHocKy(System.String maMonHoc, System.String namHoc, System.String hocKy, ref System.String nhomMonHoc)
		{
			 GetNhomMonHocByMaMonHocNamHocHocKy(null, 0, int.MaxValue , maMonHoc, namHoc, hocKy, ref nhomMonHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetNhomMonHocByMaMonHocNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetNhomMonHocByMaMonHocNamHocHocKy(int start, int pageLength, System.String maMonHoc, System.String namHoc, System.String hocKy, ref System.String nhomMonHoc)
		{
			 GetNhomMonHocByMaMonHocNamHocHocKy(null, start, pageLength , maMonHoc, namHoc, hocKy, ref nhomMonHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetNhomMonHocByMaMonHocNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetNhomMonHocByMaMonHocNamHocHocKy(TransactionManager transactionManager, System.String maMonHoc, System.String namHoc, System.String hocKy, ref System.String nhomMonHoc)
		{
			 GetNhomMonHocByMaMonHocNamHocHocKy(transactionManager, 0, int.MaxValue , maMonHoc, namHoc, hocKy, ref nhomMonHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetNhomMonHocByMaMonHocNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="nhomMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetNhomMonHocByMaMonHocNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maMonHoc, System.String namHoc, System.String hocKy, ref System.String nhomMonHoc);
		
		#endregion
		
		#region cust_PhanNhomMonHoc_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;PhanNhomMonHoc&gt;"/> instance.</returns>
		public TList<PhanNhomMonHoc> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;PhanNhomMonHoc&gt;"/> instance.</returns>
		public TList<PhanNhomMonHoc> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;PhanNhomMonHoc&gt;"/> instance.</returns>
		public TList<PhanNhomMonHoc> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;PhanNhomMonHoc&gt;"/> instance.</returns>
		public abstract TList<PhanNhomMonHoc> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_PhanNhomMonHoc_GetByNamHocHocKyMaMonHoc 
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetByNamHocHocKyMaMonHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;PhanNhomMonHoc&gt;"/> instance.</returns>
		public TList<PhanNhomMonHoc> GetByNamHocHocKyMaMonHoc(System.String namHoc, System.String hocKy, System.String maMonHoc)
		{
			return GetByNamHocHocKyMaMonHoc(null, 0, int.MaxValue , namHoc, hocKy, maMonHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetByNamHocHocKyMaMonHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;PhanNhomMonHoc&gt;"/> instance.</returns>
		public TList<PhanNhomMonHoc> GetByNamHocHocKyMaMonHoc(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maMonHoc)
		{
			return GetByNamHocHocKyMaMonHoc(null, start, pageLength , namHoc, hocKy, maMonHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetByNamHocHocKyMaMonHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;PhanNhomMonHoc&gt;"/> instance.</returns>
		public TList<PhanNhomMonHoc> GetByNamHocHocKyMaMonHoc(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maMonHoc)
		{
			return GetByNamHocHocKyMaMonHoc(transactionManager, 0, int.MaxValue , namHoc, hocKy, maMonHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetByNamHocHocKyMaMonHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maMonHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;PhanNhomMonHoc&gt;"/> instance.</returns>
		public abstract TList<PhanNhomMonHoc> GetByNamHocHocKyMaMonHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maMonHoc);
		
		#endregion
		
		#region cust_PhanNhomMonHoc_SaoChepTheoNam 
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_SaoChepTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChepTheoNam(System.String namHocNguon, System.String namHocDich)
		{
			 SaoChepTheoNam(null, 0, int.MaxValue , namHocNguon, namHocDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_SaoChepTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChepTheoNam(int start, int pageLength, System.String namHocNguon, System.String namHocDich)
		{
			 SaoChepTheoNam(null, start, pageLength , namHocNguon, namHocDich);
		}
				
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_SaoChepTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void SaoChepTheoNam(TransactionManager transactionManager, System.String namHocNguon, System.String namHocDich)
		{
			 SaoChepTheoNam(transactionManager, 0, int.MaxValue , namHocNguon, namHocDich);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_SaoChepTheoNam' stored procedure. 
		/// </summary>
		/// <param name="namHocNguon"> A <c>System.String</c> instance.</param>
		/// <param name="namHocDich"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void SaoChepTheoNam(TransactionManager transactionManager, int start, int pageLength , System.String namHocNguon, System.String namHocDich);
		
		#endregion
		
		#region cust_PhanNhomMonHoc_DongBoTheoNamHocCDGTVT 
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_DongBoTheoNamHocCDGTVT' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoNamHocCDGTVT(System.String namHoc)
		{
			 DongBoTheoNamHocCDGTVT(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_DongBoTheoNamHocCDGTVT' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoNamHocCDGTVT(int start, int pageLength, System.String namHoc)
		{
			 DongBoTheoNamHocCDGTVT(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_DongBoTheoNamHocCDGTVT' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoNamHocCDGTVT(TransactionManager transactionManager, System.String namHoc)
		{
			 DongBoTheoNamHocCDGTVT(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_DongBoTheoNamHocCDGTVT' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBoTheoNamHocCDGTVT(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_PhanNhomMonHoc_GetByNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHoc(System.String namHoc)
		{
			return GetByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return GetByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return GetByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc);
		
		#endregion
		
		#region cust_PhanNhomMonHoc_SaoChep 
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_PhanNhomMonHoc_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_PhanNhomMonHoc_SaoChep' stored procedure. 
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
		///	This method wrap the 'cust_PhanNhomMonHoc_SaoChep' stored procedure. 
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
		
		#region cust_PhanNhomMonHoc_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, hocKy, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, hocKy, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, System.String hocKy, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_PhanNhomMonHoc_LuuTheoNam 
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_LuuTheoNam' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoNam(System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTheoNam(null, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_LuuTheoNam' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoNam(int start, int pageLength, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTheoNam(null, start, pageLength , xmlData, namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_LuuTheoNam' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTheoNam(TransactionManager transactionManager, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 LuuTheoNam(transactionManager, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_PhanNhomMonHoc_LuuTheoNam' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuTheoNam(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PhanNhomMonHoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PhanNhomMonHoc&gt;"/></returns>
		public static TList<PhanNhomMonHoc> Fill(IDataReader reader, TList<PhanNhomMonHoc> rows, int start, int pageLength)
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
				
				PMS.Entities.PhanNhomMonHoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PhanNhomMonHoc")
					.Append("|").Append((System.Int32)reader[((int)PhanNhomMonHocColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<PhanNhomMonHoc>(
					key.ToString(), // EntityTrackingKey
					"PhanNhomMonHoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.PhanNhomMonHoc();
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
					c.Id = (System.Int32)reader[(PhanNhomMonHocColumn.Id.ToString())];
					c.MaMonHoc = (System.String)reader[(PhanNhomMonHocColumn.MaMonHoc.ToString())];
					c.MaLoaiHocPhan = (reader[PhanNhomMonHocColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(PhanNhomMonHocColumn.MaLoaiHocPhan.ToString())];
					c.MaNhomMonHoc = (System.Int32)reader[(PhanNhomMonHocColumn.MaNhomMonHoc.ToString())];
					c.NamHoc = (reader[PhanNhomMonHocColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(PhanNhomMonHocColumn.NamHoc.ToString())];
					c.HocKy = (reader[PhanNhomMonHocColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(PhanNhomMonHocColumn.HocKy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.PhanNhomMonHoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.PhanNhomMonHoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.PhanNhomMonHoc entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(PhanNhomMonHocColumn.Id.ToString())];
			entity.MaMonHoc = (System.String)reader[(PhanNhomMonHocColumn.MaMonHoc.ToString())];
			entity.MaLoaiHocPhan = (reader[PhanNhomMonHocColumn.MaLoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(PhanNhomMonHocColumn.MaLoaiHocPhan.ToString())];
			entity.MaNhomMonHoc = (System.Int32)reader[(PhanNhomMonHocColumn.MaNhomMonHoc.ToString())];
			entity.NamHoc = (reader[PhanNhomMonHocColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(PhanNhomMonHocColumn.NamHoc.ToString())];
			entity.HocKy = (reader[PhanNhomMonHocColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(PhanNhomMonHocColumn.HocKy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.PhanNhomMonHoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.PhanNhomMonHoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.PhanNhomMonHoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaMonHoc = (System.String)dataRow["MaMonHoc"];
			entity.MaLoaiHocPhan = Convert.IsDBNull(dataRow["MaLoaiHocPhan"]) ? null : (System.Int32?)dataRow["MaLoaiHocPhan"];
			entity.MaNhomMonHoc = (System.Int32)dataRow["MaNhomMonHoc"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
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
		/// <param name="entity">The <see cref="PMS.Entities.PhanNhomMonHoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.PhanNhomMonHoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.PhanNhomMonHoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaNhomMonHocSource	
			if (CanDeepLoad(entity, "NhomMonHoc|MaNhomMonHocSource", deepLoadType, innerList) 
				&& entity.MaNhomMonHocSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MaNhomMonHoc;
				NhomMonHoc tmpEntity = EntityManager.LocateEntity<NhomMonHoc>(EntityLocator.ConstructKeyFromPkItems(typeof(NhomMonHoc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaNhomMonHocSource = tmpEntity;
				else
					entity.MaNhomMonHocSource = DataRepository.NhomMonHocProvider.GetByMaNhomMon(transactionManager, entity.MaNhomMonHoc);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaNhomMonHocSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaNhomMonHocSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.NhomMonHocProvider.DeepLoad(transactionManager, entity.MaNhomMonHocSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaNhomMonHocSource
			
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
		/// Deep Save the entire object graph of the PMS.Entities.PhanNhomMonHoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.PhanNhomMonHoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.PhanNhomMonHoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.PhanNhomMonHoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaNhomMonHocSource
			if (CanDeepSave(entity, "NhomMonHoc|MaNhomMonHocSource", deepSaveType, innerList) 
				&& entity.MaNhomMonHocSource != null)
			{
				DataRepository.NhomMonHocProvider.Save(transactionManager, entity.MaNhomMonHocSource);
				entity.MaNhomMonHoc = entity.MaNhomMonHocSource.MaNhomMon;
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
	
	#region PhanNhomMonHocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.PhanNhomMonHoc</c>
	///</summary>
	public enum PhanNhomMonHocChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>NhomMonHoc</c> at MaNhomMonHocSource
		///</summary>
		[ChildEntityType(typeof(NhomMonHoc))]
		NhomMonHoc,
	}
	
	#endregion PhanNhomMonHocChildEntityTypes
	
	#region PhanNhomMonHocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PhanNhomMonHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanNhomMonHocFilterBuilder : SqlFilterBuilder<PhanNhomMonHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanNhomMonHocFilterBuilder class.
		/// </summary>
		public PhanNhomMonHocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PhanNhomMonHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PhanNhomMonHocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PhanNhomMonHocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PhanNhomMonHocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PhanNhomMonHocFilterBuilder
	
	#region PhanNhomMonHocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PhanNhomMonHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanNhomMonHocParameterBuilder : ParameterizedSqlFilterBuilder<PhanNhomMonHocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanNhomMonHocParameterBuilder class.
		/// </summary>
		public PhanNhomMonHocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PhanNhomMonHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PhanNhomMonHocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PhanNhomMonHocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PhanNhomMonHocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PhanNhomMonHocParameterBuilder
	
	#region PhanNhomMonHocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PhanNhomMonHocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanNhomMonHoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PhanNhomMonHocSortBuilder : SqlSortBuilder<PhanNhomMonHocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanNhomMonHocSqlSortBuilder class.
		/// </summary>
		public PhanNhomMonHocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PhanNhomMonHocSortBuilder
	
} // end namespace
