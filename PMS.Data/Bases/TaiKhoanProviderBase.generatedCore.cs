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
	/// This class is the base class for any <see cref="TaiKhoanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TaiKhoanProviderBaseCore : EntityProviderBase<PMS.Entities.TaiKhoan, PMS.Entities.TaiKhoanKey>
	{		
		#region Get from Many To Many Relationship Functions
		#region GetByParentIdFromHeThong
		
		/// <summary>
		///		Gets TaiKhoan objects from the datasource by ParentID in the
		///		HeThong table. Table TaiKhoan is related to table TaiKhoan
		///		through the (M:N) relationship defined in the HeThong table.
		/// </summary>
		/// <param name="_parentId"></param>
		/// <returns>Returns a typed collection of TaiKhoan objects.</returns>
		public TList<TaiKhoan> GetByParentIdFromHeThong(System.Int32 _parentId)
		{
			int count = -1;
			return GetByParentIdFromHeThong(null,_parentId, 0, int.MaxValue, out count);
			
		}
		
		/// <summary>
		///		Gets PMS.Entities.TaiKhoan objects from the datasource by ParentID in the
		///		HeThong table. Table TaiKhoan is related to table TaiKhoan
		///		through the (M:N) relationship defined in the HeThong table.
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_parentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a TList of TaiKhoan objects.</returns>
		public TList<TaiKhoan> GetByParentIdFromHeThong(System.Int32 _parentId, int start, int pageLength)
		{
			int count = -1;
			return GetByParentIdFromHeThong(null, _parentId, start, pageLength, out count);
		}
		
		/// <summary>
		///		Gets TaiKhoan objects from the datasource by ParentID in the
		///		HeThong table. Table TaiKhoan is related to table TaiKhoan
		///		through the (M:N) relationship defined in the HeThong table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of TaiKhoan objects.</returns>
		public TList<TaiKhoan> GetByParentIdFromHeThong(TransactionManager transactionManager, System.Int32 _parentId)
		{
			int count = -1;
			return GetByParentIdFromHeThong(transactionManager, _parentId, 0, int.MaxValue, out count);
		}
		
		
		/// <summary>
		///		Gets TaiKhoan objects from the datasource by ParentID in the
		///		HeThong table. Table TaiKhoan is related to table TaiKhoan
		///		through the (M:N) relationship defined in the HeThong table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of TaiKhoan objects.</returns>
		public TList<TaiKhoan> GetByParentIdFromHeThong(TransactionManager transactionManager, System.Int32 _parentId,int start, int pageLength)
		{
			int count = -1;
			return GetByParentIdFromHeThong(transactionManager, _parentId, start, pageLength, out count);
		}
		
		/// <summary>
		///		Gets TaiKhoan objects from the datasource by ParentID in the
		///		HeThong table. Table TaiKhoan is related to table TaiKhoan
		///		through the (M:N) relationship defined in the HeThong table.
		/// </summary>
		/// <param name="_parentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of TaiKhoan objects.</returns>
		public TList<TaiKhoan> GetByParentIdFromHeThong(System.Int32 _parentId,int start, int pageLength, out int count)
		{
			
			return GetByParentIdFromHeThong(null, _parentId, start, pageLength, out count);
		}


		/// <summary>
		///		Gets TaiKhoan objects from the datasource by ParentID in the
		///		HeThong table. Table TaiKhoan is related to table TaiKhoan
		///		through the (M:N) relationship defined in the HeThong table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <param name="_parentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a TList of TaiKhoan objects.</returns>
		public abstract TList<TaiKhoan> GetByParentIdFromHeThong(TransactionManager transactionManager,System.Int32 _parentId, int start, int pageLength, out int count);
		
		#endregion GetByParentIdFromHeThong
		
		#region GetByUserIdFromHeThong
		
		/// <summary>
		///		Gets TaiKhoan objects from the datasource by UserID in the
		///		HeThong table. Table TaiKhoan is related to table TaiKhoan
		///		through the (M:N) relationship defined in the HeThong table.
		/// </summary>
		/// <param name="_userId"></param>
		/// <returns>Returns a typed collection of TaiKhoan objects.</returns>
		public TList<TaiKhoan> GetByUserIdFromHeThong(System.Int32 _userId)
		{
			int count = -1;
			return GetByUserIdFromHeThong(null,_userId, 0, int.MaxValue, out count);
			
		}
		
		/// <summary>
		///		Gets PMS.Entities.TaiKhoan objects from the datasource by UserID in the
		///		HeThong table. Table TaiKhoan is related to table TaiKhoan
		///		through the (M:N) relationship defined in the HeThong table.
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_userId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a TList of TaiKhoan objects.</returns>
		public TList<TaiKhoan> GetByUserIdFromHeThong(System.Int32 _userId, int start, int pageLength)
		{
			int count = -1;
			return GetByUserIdFromHeThong(null, _userId, start, pageLength, out count);
		}
		
		/// <summary>
		///		Gets TaiKhoan objects from the datasource by UserID in the
		///		HeThong table. Table TaiKhoan is related to table TaiKhoan
		///		through the (M:N) relationship defined in the HeThong table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_userId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of TaiKhoan objects.</returns>
		public TList<TaiKhoan> GetByUserIdFromHeThong(TransactionManager transactionManager, System.Int32 _userId)
		{
			int count = -1;
			return GetByUserIdFromHeThong(transactionManager, _userId, 0, int.MaxValue, out count);
		}
		
		
		/// <summary>
		///		Gets TaiKhoan objects from the datasource by UserID in the
		///		HeThong table. Table TaiKhoan is related to table TaiKhoan
		///		through the (M:N) relationship defined in the HeThong table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_userId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of TaiKhoan objects.</returns>
		public TList<TaiKhoan> GetByUserIdFromHeThong(TransactionManager transactionManager, System.Int32 _userId,int start, int pageLength)
		{
			int count = -1;
			return GetByUserIdFromHeThong(transactionManager, _userId, start, pageLength, out count);
		}
		
		/// <summary>
		///		Gets TaiKhoan objects from the datasource by UserID in the
		///		HeThong table. Table TaiKhoan is related to table TaiKhoan
		///		through the (M:N) relationship defined in the HeThong table.
		/// </summary>
		/// <param name="_userId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of TaiKhoan objects.</returns>
		public TList<TaiKhoan> GetByUserIdFromHeThong(System.Int32 _userId,int start, int pageLength, out int count)
		{
			
			return GetByUserIdFromHeThong(null, _userId, start, pageLength, out count);
		}


		/// <summary>
		///		Gets TaiKhoan objects from the datasource by UserID in the
		///		HeThong table. Table TaiKhoan is related to table TaiKhoan
		///		through the (M:N) relationship defined in the HeThong table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <param name="_userId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a TList of TaiKhoan objects.</returns>
		public abstract TList<TaiKhoan> GetByUserIdFromHeThong(TransactionManager transactionManager,System.Int32 _userId, int start, int pageLength, out int count);
		
		#endregion GetByUserIdFromHeThong
		
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.TaiKhoanKey key)
		{
			return Delete(transactionManager, key.MaTaiKhoan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maTaiKhoan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maTaiKhoan)
		{
			return Delete(null, _maTaiKhoan);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTaiKhoan">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maTaiKhoan);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Users_Groups key.
		///		FK_Users_Groups Description: 
		/// </summary>
		/// <param name="_maNhomQuyen"></param>
		/// <returns>Returns a typed collection of PMS.Entities.TaiKhoan objects.</returns>
		public TList<TaiKhoan> GetByMaNhomQuyen(System.Int32? _maNhomQuyen)
		{
			int count = -1;
			return GetByMaNhomQuyen(_maNhomQuyen, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Users_Groups key.
		///		FK_Users_Groups Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomQuyen"></param>
		/// <returns>Returns a typed collection of PMS.Entities.TaiKhoan objects.</returns>
		/// <remarks></remarks>
		public TList<TaiKhoan> GetByMaNhomQuyen(TransactionManager transactionManager, System.Int32? _maNhomQuyen)
		{
			int count = -1;
			return GetByMaNhomQuyen(transactionManager, _maNhomQuyen, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_Users_Groups key.
		///		FK_Users_Groups Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.TaiKhoan objects.</returns>
		public TList<TaiKhoan> GetByMaNhomQuyen(TransactionManager transactionManager, System.Int32? _maNhomQuyen, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomQuyen(transactionManager, _maNhomQuyen, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Users_Groups key.
		///		fkUsersGroups Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhomQuyen"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.TaiKhoan objects.</returns>
		public TList<TaiKhoan> GetByMaNhomQuyen(System.Int32? _maNhomQuyen, int start, int pageLength)
		{
			int count =  -1;
			return GetByMaNhomQuyen(null, _maNhomQuyen, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Users_Groups key.
		///		fkUsersGroups Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.TaiKhoan objects.</returns>
		public TList<TaiKhoan> GetByMaNhomQuyen(System.Int32? _maNhomQuyen, int start, int pageLength,out int count)
		{
			return GetByMaNhomQuyen(null, _maNhomQuyen, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Users_Groups key.
		///		FK_Users_Groups Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.TaiKhoan objects.</returns>
		public abstract TList<TaiKhoan> GetByMaNhomQuyen(TransactionManager transactionManager, System.Int32? _maNhomQuyen, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.TaiKhoan Get(TransactionManager transactionManager, PMS.Entities.TaiKhoanKey key, int start, int pageLength)
		{
			return GetByMaTaiKhoan(transactionManager, key.MaTaiKhoan, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_Users index.
		/// </summary>
		/// <param name="_tenDangNhap"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TaiKhoan"/> class.</returns>
		public PMS.Entities.TaiKhoan GetByTenDangNhap(System.String _tenDangNhap)
		{
			int count = -1;
			return GetByTenDangNhap(null,_tenDangNhap, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Users index.
		/// </summary>
		/// <param name="_tenDangNhap"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TaiKhoan"/> class.</returns>
		public PMS.Entities.TaiKhoan GetByTenDangNhap(System.String _tenDangNhap, int start, int pageLength)
		{
			int count = -1;
			return GetByTenDangNhap(null, _tenDangNhap, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Users index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_tenDangNhap"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TaiKhoan"/> class.</returns>
		public PMS.Entities.TaiKhoan GetByTenDangNhap(TransactionManager transactionManager, System.String _tenDangNhap)
		{
			int count = -1;
			return GetByTenDangNhap(transactionManager, _tenDangNhap, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Users index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_tenDangNhap"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TaiKhoan"/> class.</returns>
		public PMS.Entities.TaiKhoan GetByTenDangNhap(TransactionManager transactionManager, System.String _tenDangNhap, int start, int pageLength)
		{
			int count = -1;
			return GetByTenDangNhap(transactionManager, _tenDangNhap, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Users index.
		/// </summary>
		/// <param name="_tenDangNhap"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TaiKhoan"/> class.</returns>
		public PMS.Entities.TaiKhoan GetByTenDangNhap(System.String _tenDangNhap, int start, int pageLength, out int count)
		{
			return GetByTenDangNhap(null, _tenDangNhap, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Users index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_tenDangNhap"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TaiKhoan"/> class.</returns>
		public abstract PMS.Entities.TaiKhoan GetByTenDangNhap(TransactionManager transactionManager, System.String _tenDangNhap, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_Users index.
		/// </summary>
		/// <param name="_maTaiKhoan"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TaiKhoan"/> class.</returns>
		public PMS.Entities.TaiKhoan GetByMaTaiKhoan(System.Int32 _maTaiKhoan)
		{
			int count = -1;
			return GetByMaTaiKhoan(null,_maTaiKhoan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Users index.
		/// </summary>
		/// <param name="_maTaiKhoan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TaiKhoan"/> class.</returns>
		public PMS.Entities.TaiKhoan GetByMaTaiKhoan(System.Int32 _maTaiKhoan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaTaiKhoan(null, _maTaiKhoan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Users index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTaiKhoan"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TaiKhoan"/> class.</returns>
		public PMS.Entities.TaiKhoan GetByMaTaiKhoan(TransactionManager transactionManager, System.Int32 _maTaiKhoan)
		{
			int count = -1;
			return GetByMaTaiKhoan(transactionManager, _maTaiKhoan, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Users index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTaiKhoan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TaiKhoan"/> class.</returns>
		public PMS.Entities.TaiKhoan GetByMaTaiKhoan(TransactionManager transactionManager, System.Int32 _maTaiKhoan, int start, int pageLength)
		{
			int count = -1;
			return GetByMaTaiKhoan(transactionManager, _maTaiKhoan, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Users index.
		/// </summary>
		/// <param name="_maTaiKhoan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TaiKhoan"/> class.</returns>
		public PMS.Entities.TaiKhoan GetByMaTaiKhoan(System.Int32 _maTaiKhoan, int start, int pageLength, out int count)
		{
			return GetByMaTaiKhoan(null, _maTaiKhoan, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Users index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maTaiKhoan"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.TaiKhoan"/> class.</returns>
		public abstract PMS.Entities.TaiKhoan GetByMaTaiKhoan(TransactionManager transactionManager, System.Int32 _maTaiKhoan, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_TaiKhoan_GetByTenDangNhapMatKhau 
		
		/// <summary>
		///	This method wrap the 'cust_TaiKhoan_GetByTenDangNhapMatKhau' stored procedure. 
		/// </summary>
		/// <param name="tenDangNhap"> A <c>System.String</c> instance.</param>
		/// <param name="matKhau"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TaiKhoan&gt;"/> instance.</returns>
		public TList<TaiKhoan> GetByTenDangNhapMatKhau(System.String tenDangNhap, System.String matKhau)
		{
			return GetByTenDangNhapMatKhau(null, 0, int.MaxValue , tenDangNhap, matKhau);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TaiKhoan_GetByTenDangNhapMatKhau' stored procedure. 
		/// </summary>
		/// <param name="tenDangNhap"> A <c>System.String</c> instance.</param>
		/// <param name="matKhau"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TaiKhoan&gt;"/> instance.</returns>
		public TList<TaiKhoan> GetByTenDangNhapMatKhau(int start, int pageLength, System.String tenDangNhap, System.String matKhau)
		{
			return GetByTenDangNhapMatKhau(null, start, pageLength , tenDangNhap, matKhau);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TaiKhoan_GetByTenDangNhapMatKhau' stored procedure. 
		/// </summary>
		/// <param name="tenDangNhap"> A <c>System.String</c> instance.</param>
		/// <param name="matKhau"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TaiKhoan&gt;"/> instance.</returns>
		public TList<TaiKhoan> GetByTenDangNhapMatKhau(TransactionManager transactionManager, System.String tenDangNhap, System.String matKhau)
		{
			return GetByTenDangNhapMatKhau(transactionManager, 0, int.MaxValue , tenDangNhap, matKhau);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TaiKhoan_GetByTenDangNhapMatKhau' stored procedure. 
		/// </summary>
		/// <param name="tenDangNhap"> A <c>System.String</c> instance.</param>
		/// <param name="matKhau"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TaiKhoan&gt;"/> instance.</returns>
		public abstract TList<TaiKhoan> GetByTenDangNhapMatKhau(TransactionManager transactionManager, int start, int pageLength , System.String tenDangNhap, System.String matKhau);
		
		#endregion
		
		#region cust_TaiKhoan_GetByNhomQuyenQL 
		
		/// <summary>
		///	This method wrap the 'cust_TaiKhoan_GetByNhomQuyenQL' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TaiKhoan&gt;"/> instance.</returns>
		public TList<TaiKhoan> GetByNhomQuyenQL(System.Int32 maNhomQuyen)
		{
			return GetByNhomQuyenQL(null, 0, int.MaxValue , maNhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TaiKhoan_GetByNhomQuyenQL' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TaiKhoan&gt;"/> instance.</returns>
		public TList<TaiKhoan> GetByNhomQuyenQL(int start, int pageLength, System.Int32 maNhomQuyen)
		{
			return GetByNhomQuyenQL(null, start, pageLength , maNhomQuyen);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TaiKhoan_GetByNhomQuyenQL' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TaiKhoan&gt;"/> instance.</returns>
		public TList<TaiKhoan> GetByNhomQuyenQL(TransactionManager transactionManager, System.Int32 maNhomQuyen)
		{
			return GetByNhomQuyenQL(transactionManager, 0, int.MaxValue , maNhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TaiKhoan_GetByNhomQuyenQL' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TaiKhoan&gt;"/> instance.</returns>
		public abstract TList<TaiKhoan> GetByNhomQuyenQL(TransactionManager transactionManager, int start, int pageLength , System.Int32 maNhomQuyen);
		
		#endregion
		
		#region cust_TaiKhoan_KiemTraPhanQuyenControl 
		
		/// <summary>
		///	This method wrap the 'cust_TaiKhoan_KiemTraPhanQuyenControl' stored procedure. 
		/// </summary>
		/// <param name="maTaiKhoan"> A <c>System.Int32</c> instance.</param>
		/// <param name="tenForm"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraPhanQuyenControl(System.Int32 maTaiKhoan, System.String tenForm, ref System.Boolean reVal)
		{
			 KiemTraPhanQuyenControl(null, 0, int.MaxValue , maTaiKhoan, tenForm, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TaiKhoan_KiemTraPhanQuyenControl' stored procedure. 
		/// </summary>
		/// <param name="maTaiKhoan"> A <c>System.Int32</c> instance.</param>
		/// <param name="tenForm"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraPhanQuyenControl(int start, int pageLength, System.Int32 maTaiKhoan, System.String tenForm, ref System.Boolean reVal)
		{
			 KiemTraPhanQuyenControl(null, start, pageLength , maTaiKhoan, tenForm, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_TaiKhoan_KiemTraPhanQuyenControl' stored procedure. 
		/// </summary>
		/// <param name="maTaiKhoan"> A <c>System.Int32</c> instance.</param>
		/// <param name="tenForm"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraPhanQuyenControl(TransactionManager transactionManager, System.Int32 maTaiKhoan, System.String tenForm, ref System.Boolean reVal)
		{
			 KiemTraPhanQuyenControl(transactionManager, 0, int.MaxValue , maTaiKhoan, tenForm, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_TaiKhoan_KiemTraPhanQuyenControl' stored procedure. 
		/// </summary>
		/// <param name="maTaiKhoan"> A <c>System.Int32</c> instance.</param>
		/// <param name="tenForm"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraPhanQuyenControl(TransactionManager transactionManager, int start, int pageLength , System.Int32 maTaiKhoan, System.String tenForm, ref System.Boolean reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TaiKhoan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TaiKhoan&gt;"/></returns>
		public static TList<TaiKhoan> Fill(IDataReader reader, TList<TaiKhoan> rows, int start, int pageLength)
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
				
				PMS.Entities.TaiKhoan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TaiKhoan")
					.Append("|").Append((System.Int32)reader[((int)TaiKhoanColumn.MaTaiKhoan - 1)]).ToString();
					c = EntityManager.LocateOrCreate<TaiKhoan>(
					key.ToString(), // EntityTrackingKey
					"TaiKhoan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.TaiKhoan();
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
					c.MaTaiKhoan = (System.Int32)reader[(TaiKhoanColumn.MaTaiKhoan.ToString())];
					c.MaNhomQuyen = (reader[TaiKhoanColumn.MaNhomQuyen.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TaiKhoanColumn.MaNhomQuyen.ToString())];
					c.TenDangNhap = (reader[TaiKhoanColumn.TenDangNhap.ToString()] == DBNull.Value) ? null : (System.String)reader[(TaiKhoanColumn.TenDangNhap.ToString())];
					c.MatKhau = (reader[TaiKhoanColumn.MatKhau.ToString()] == DBNull.Value) ? null : (System.String)reader[(TaiKhoanColumn.MatKhau.ToString())];
					c.HoTen = (reader[TaiKhoanColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(TaiKhoanColumn.HoTen.ToString())];
					c.TenMayTinh = (reader[TaiKhoanColumn.TenMayTinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(TaiKhoanColumn.TenMayTinh.ToString())];
					c.DuongDan = (reader[TaiKhoanColumn.DuongDan.ToString()] == DBNull.Value) ? null : (System.String)reader[(TaiKhoanColumn.DuongDan.ToString())];
					c.PhienBan = (reader[TaiKhoanColumn.PhienBan.ToString()] == DBNull.Value) ? null : (System.String)reader[(TaiKhoanColumn.PhienBan.ToString())];
					c.NgayDangNhap = (reader[TaiKhoanColumn.NgayDangNhap.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(TaiKhoanColumn.NgayDangNhap.ToString())];
					c.TrangThai = (reader[TaiKhoanColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(TaiKhoanColumn.TrangThai.ToString())];
					c.SkinName = (reader[TaiKhoanColumn.SkinName.ToString()] == DBNull.Value) ? null : (System.String)reader[(TaiKhoanColumn.SkinName.ToString())];
					c.NgayTao = (reader[TaiKhoanColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(TaiKhoanColumn.NgayTao.ToString())];
					c.ResetPassWordGv = (reader[TaiKhoanColumn.ResetPassWordGv.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(TaiKhoanColumn.ResetPassWordGv.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TaiKhoan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TaiKhoan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.TaiKhoan entity)
		{
			if (!reader.Read()) return;
			
			entity.MaTaiKhoan = (System.Int32)reader[(TaiKhoanColumn.MaTaiKhoan.ToString())];
			entity.MaNhomQuyen = (reader[TaiKhoanColumn.MaNhomQuyen.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(TaiKhoanColumn.MaNhomQuyen.ToString())];
			entity.TenDangNhap = (reader[TaiKhoanColumn.TenDangNhap.ToString()] == DBNull.Value) ? null : (System.String)reader[(TaiKhoanColumn.TenDangNhap.ToString())];
			entity.MatKhau = (reader[TaiKhoanColumn.MatKhau.ToString()] == DBNull.Value) ? null : (System.String)reader[(TaiKhoanColumn.MatKhau.ToString())];
			entity.HoTen = (reader[TaiKhoanColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(TaiKhoanColumn.HoTen.ToString())];
			entity.TenMayTinh = (reader[TaiKhoanColumn.TenMayTinh.ToString()] == DBNull.Value) ? null : (System.String)reader[(TaiKhoanColumn.TenMayTinh.ToString())];
			entity.DuongDan = (reader[TaiKhoanColumn.DuongDan.ToString()] == DBNull.Value) ? null : (System.String)reader[(TaiKhoanColumn.DuongDan.ToString())];
			entity.PhienBan = (reader[TaiKhoanColumn.PhienBan.ToString()] == DBNull.Value) ? null : (System.String)reader[(TaiKhoanColumn.PhienBan.ToString())];
			entity.NgayDangNhap = (reader[TaiKhoanColumn.NgayDangNhap.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(TaiKhoanColumn.NgayDangNhap.ToString())];
			entity.TrangThai = (reader[TaiKhoanColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(TaiKhoanColumn.TrangThai.ToString())];
			entity.SkinName = (reader[TaiKhoanColumn.SkinName.ToString()] == DBNull.Value) ? null : (System.String)reader[(TaiKhoanColumn.SkinName.ToString())];
			entity.NgayTao = (reader[TaiKhoanColumn.NgayTao.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(TaiKhoanColumn.NgayTao.ToString())];
			entity.ResetPassWordGv = (reader[TaiKhoanColumn.ResetPassWordGv.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(TaiKhoanColumn.ResetPassWordGv.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.TaiKhoan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.TaiKhoan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.TaiKhoan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaTaiKhoan = (System.Int32)dataRow["MaTaiKhoan"];
			entity.MaNhomQuyen = Convert.IsDBNull(dataRow["MaNhomQuyen"]) ? null : (System.Int32?)dataRow["MaNhomQuyen"];
			entity.TenDangNhap = Convert.IsDBNull(dataRow["TenDangNhap"]) ? null : (System.String)dataRow["TenDangNhap"];
			entity.MatKhau = Convert.IsDBNull(dataRow["MatKhau"]) ? null : (System.String)dataRow["MatKhau"];
			entity.HoTen = Convert.IsDBNull(dataRow["HoTen"]) ? null : (System.String)dataRow["HoTen"];
			entity.TenMayTinh = Convert.IsDBNull(dataRow["TenMayTinh"]) ? null : (System.String)dataRow["TenMayTinh"];
			entity.DuongDan = Convert.IsDBNull(dataRow["DuongDan"]) ? null : (System.String)dataRow["DuongDan"];
			entity.PhienBan = Convert.IsDBNull(dataRow["PhienBan"]) ? null : (System.String)dataRow["PhienBan"];
			entity.NgayDangNhap = Convert.IsDBNull(dataRow["NgayDangNhap"]) ? null : (System.DateTime?)dataRow["NgayDangNhap"];
			entity.TrangThai = Convert.IsDBNull(dataRow["TrangThai"]) ? null : (System.Boolean?)dataRow["TrangThai"];
			entity.SkinName = Convert.IsDBNull(dataRow["SkinName"]) ? null : (System.String)dataRow["SkinName"];
			entity.NgayTao = Convert.IsDBNull(dataRow["NgayTao"]) ? null : (System.DateTime?)dataRow["NgayTao"];
			entity.ResetPassWordGv = Convert.IsDBNull(dataRow["ResetPassWordGv"]) ? null : (System.Boolean?)dataRow["ResetPassWordGv"];
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
		/// <param name="entity">The <see cref="PMS.Entities.TaiKhoan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.TaiKhoan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.TaiKhoan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region MaNhomQuyenSource	
			if (CanDeepLoad(entity, "NhomQuyen|MaNhomQuyenSource", deepLoadType, innerList) 
				&& entity.MaNhomQuyenSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.MaNhomQuyen ?? (int)0);
				NhomQuyen tmpEntity = EntityManager.LocateEntity<NhomQuyen>(EntityLocator.ConstructKeyFromPkItems(typeof(NhomQuyen), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MaNhomQuyenSource = tmpEntity;
				else
					entity.MaNhomQuyenSource = DataRepository.NhomQuyenProvider.GetByMaNhomQuyen(transactionManager, (entity.MaNhomQuyen ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaNhomQuyenSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaNhomQuyenSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.NhomQuyenProvider.DeepLoad(transactionManager, entity.MaNhomQuyenSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MaNhomQuyenSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMaTaiKhoan methods when available
			
			#region UserIdTaiKhoanCollection_From_HeThong
			// RelationshipType.ManyToMany
			if (CanDeepLoad(entity, "List<TaiKhoan>|UserIdTaiKhoanCollection_From_HeThong", deepLoadType, innerList))
			{
				entity.UserIdTaiKhoanCollection_From_HeThong = DataRepository.TaiKhoanProvider.GetByParentIdFromHeThong(transactionManager, entity.MaTaiKhoan);			 
		
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'UserIdTaiKhoanCollection_From_HeThong' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.UserIdTaiKhoanCollection_From_HeThong != null)
				{
					deepHandles.Add("UserIdTaiKhoanCollection_From_HeThong",
						new KeyValuePair<Delegate, object>((DeepLoadHandle< TaiKhoan >) DataRepository.TaiKhoanProvider.DeepLoad,
						new object[] { transactionManager, entity.UserIdTaiKhoanCollection_From_HeThong, deep, deepLoadType, childTypes, innerList }
					));
				}
			}
			#endregion
			
			
			
			#region HeThongCollectionGetByParentId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<HeThong>|HeThongCollectionGetByParentId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'HeThongCollectionGetByParentId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.HeThongCollectionGetByParentId = DataRepository.HeThongProvider.GetByParentId(transactionManager, entity.MaTaiKhoan);

				if (deep && entity.HeThongCollectionGetByParentId.Count > 0)
				{
					deepHandles.Add("HeThongCollectionGetByParentId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<HeThong>) DataRepository.HeThongProvider.DeepLoad,
						new object[] { transactionManager, entity.HeThongCollectionGetByParentId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ParentIdTaiKhoanCollection_From_HeThong
			// RelationshipType.ManyToMany
			if (CanDeepLoad(entity, "List<TaiKhoan>|ParentIdTaiKhoanCollection_From_HeThong", deepLoadType, innerList))
			{
				entity.ParentIdTaiKhoanCollection_From_HeThong = DataRepository.TaiKhoanProvider.GetByUserIdFromHeThong(transactionManager, entity.MaTaiKhoan);			 
		
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ParentIdTaiKhoanCollection_From_HeThong' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ParentIdTaiKhoanCollection_From_HeThong != null)
				{
					deepHandles.Add("ParentIdTaiKhoanCollection_From_HeThong",
						new KeyValuePair<Delegate, object>((DeepLoadHandle< TaiKhoan >) DataRepository.TaiKhoanProvider.DeepLoad,
						new object[] { transactionManager, entity.ParentIdTaiKhoanCollection_From_HeThong, deep, deepLoadType, childTypes, innerList }
					));
				}
			}
			#endregion
			
			
			
			#region HeThongCollectionGetByUserId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<HeThong>|HeThongCollectionGetByUserId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'HeThongCollectionGetByUserId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.HeThongCollectionGetByUserId = DataRepository.HeThongProvider.GetByUserId(transactionManager, entity.MaTaiKhoan);

				if (deep && entity.HeThongCollectionGetByUserId.Count > 0)
				{
					deepHandles.Add("HeThongCollectionGetByUserId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<HeThong>) DataRepository.HeThongProvider.DeepLoad,
						new object[] { transactionManager, entity.HeThongCollectionGetByUserId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GiangVienCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GiangVien>|GiangVienCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GiangVienCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GiangVienCollection = DataRepository.GiangVienProvider.GetByMaNguoiLap(transactionManager, entity.MaTaiKhoan);

				if (deep && entity.GiangVienCollection.Count > 0)
				{
					deepHandles.Add("GiangVienCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GiangVien>) DataRepository.GiangVienProvider.DeepLoad,
						new object[] { transactionManager, entity.GiangVienCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ReportTemplateCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ReportTemplate>|ReportTemplateCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ReportTemplateCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ReportTemplateCollection = DataRepository.ReportTemplateProvider.GetByUserId(transactionManager, entity.MaTaiKhoan);

				if (deep && entity.ReportTemplateCollection.Count > 0)
				{
					deepHandles.Add("ReportTemplateCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ReportTemplate>) DataRepository.ReportTemplateProvider.DeepLoad,
						new object[] { transactionManager, entity.ReportTemplateCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.TaiKhoan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.TaiKhoan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.TaiKhoan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.TaiKhoan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region MaNhomQuyenSource
			if (CanDeepSave(entity, "NhomQuyen|MaNhomQuyenSource", deepSaveType, innerList) 
				&& entity.MaNhomQuyenSource != null)
			{
				DataRepository.NhomQuyenProvider.Save(transactionManager, entity.MaNhomQuyenSource);
				entity.MaNhomQuyen = entity.MaNhomQuyenSource.MaNhomQuyen;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();

			#region UserIdTaiKhoanCollection_From_HeThong>
			if (CanDeepSave(entity.UserIdTaiKhoanCollection_From_HeThong, "List<TaiKhoan>|UserIdTaiKhoanCollection_From_HeThong", deepSaveType, innerList))
			{
				if (entity.UserIdTaiKhoanCollection_From_HeThong.Count > 0 || entity.UserIdTaiKhoanCollection_From_HeThong.DeletedItems.Count > 0)
				{
					DataRepository.TaiKhoanProvider.Save(transactionManager, entity.UserIdTaiKhoanCollection_From_HeThong); 
					deepHandles.Add("UserIdTaiKhoanCollection_From_HeThong",
						new KeyValuePair<Delegate, object>((DeepSaveHandle<TaiKhoan>) DataRepository.TaiKhoanProvider.DeepSave,
						new object[] { transactionManager, entity.UserIdTaiKhoanCollection_From_HeThong, deepSaveType, childTypes, innerList }
					));
				}
			}
			#endregion 

			#region ParentIdTaiKhoanCollection_From_HeThong>
			if (CanDeepSave(entity.ParentIdTaiKhoanCollection_From_HeThong, "List<TaiKhoan>|ParentIdTaiKhoanCollection_From_HeThong", deepSaveType, innerList))
			{
				if (entity.ParentIdTaiKhoanCollection_From_HeThong.Count > 0 || entity.ParentIdTaiKhoanCollection_From_HeThong.DeletedItems.Count > 0)
				{
					DataRepository.TaiKhoanProvider.Save(transactionManager, entity.ParentIdTaiKhoanCollection_From_HeThong); 
					deepHandles.Add("ParentIdTaiKhoanCollection_From_HeThong",
						new KeyValuePair<Delegate, object>((DeepSaveHandle<TaiKhoan>) DataRepository.TaiKhoanProvider.DeepSave,
						new object[] { transactionManager, entity.ParentIdTaiKhoanCollection_From_HeThong, deepSaveType, childTypes, innerList }
					));
				}
			}
			#endregion 
	
			#region List<HeThong>
				if (CanDeepSave(entity.HeThongCollectionGetByParentId, "List<HeThong>|HeThongCollectionGetByParentId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(HeThong child in entity.HeThongCollectionGetByParentId)
					{
						if(child.ParentIdSource != null)
						{
								child.ParentId = child.ParentIdSource.MaTaiKhoan;
						}

						if(child.UserIdSource != null)
						{
								child.UserId = child.UserIdSource.MaTaiKhoan;
						}

					}

					if (entity.HeThongCollectionGetByParentId.Count > 0 || entity.HeThongCollectionGetByParentId.DeletedItems.Count > 0)
					{
						//DataRepository.HeThongProvider.Save(transactionManager, entity.HeThongCollectionGetByParentId);
						
						deepHandles.Add("HeThongCollectionGetByParentId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< HeThong >) DataRepository.HeThongProvider.DeepSave,
							new object[] { transactionManager, entity.HeThongCollectionGetByParentId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<HeThong>
				if (CanDeepSave(entity.HeThongCollectionGetByUserId, "List<HeThong>|HeThongCollectionGetByUserId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(HeThong child in entity.HeThongCollectionGetByUserId)
					{
						if(child.ParentIdSource != null)
						{
								child.ParentId = child.ParentIdSource.MaTaiKhoan;
						}

						if(child.UserIdSource != null)
						{
								child.UserId = child.UserIdSource.MaTaiKhoan;
						}

					}

					if (entity.HeThongCollectionGetByUserId.Count > 0 || entity.HeThongCollectionGetByUserId.DeletedItems.Count > 0)
					{
						//DataRepository.HeThongProvider.Save(transactionManager, entity.HeThongCollectionGetByUserId);
						
						deepHandles.Add("HeThongCollectionGetByUserId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< HeThong >) DataRepository.HeThongProvider.DeepSave,
							new object[] { transactionManager, entity.HeThongCollectionGetByUserId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GiangVien>
				if (CanDeepSave(entity.GiangVienCollection, "List<GiangVien>|GiangVienCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GiangVien child in entity.GiangVienCollection)
					{
						if(child.MaNguoiLapSource != null)
						{
							child.MaNguoiLap = child.MaNguoiLapSource.MaTaiKhoan;
						}
						else
						{
							child.MaNguoiLap = entity.MaTaiKhoan;
						}

					}

					if (entity.GiangVienCollection.Count > 0 || entity.GiangVienCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GiangVienProvider.Save(transactionManager, entity.GiangVienCollection);
						
						deepHandles.Add("GiangVienCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GiangVien >) DataRepository.GiangVienProvider.DeepSave,
							new object[] { transactionManager, entity.GiangVienCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ReportTemplate>
				if (CanDeepSave(entity.ReportTemplateCollection, "List<ReportTemplate>|ReportTemplateCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ReportTemplate child in entity.ReportTemplateCollection)
					{
						if(child.UserIdSource != null)
						{
							child.UserId = child.UserIdSource.MaTaiKhoan;
						}
						else
						{
							child.UserId = entity.MaTaiKhoan;
						}

					}

					if (entity.ReportTemplateCollection.Count > 0 || entity.ReportTemplateCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ReportTemplateProvider.Save(transactionManager, entity.ReportTemplateCollection);
						
						deepHandles.Add("ReportTemplateCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ReportTemplate >) DataRepository.ReportTemplateProvider.DeepSave,
							new object[] { transactionManager, entity.ReportTemplateCollection, deepSaveType, childTypes, innerList }
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
	
	#region TaiKhoanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.TaiKhoan</c>
	///</summary>
	public enum TaiKhoanChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>NhomQuyen</c> at MaNhomQuyenSource
		///</summary>
		[ChildEntityType(typeof(NhomQuyen))]
		NhomQuyen,
		///<summary>
		/// Collection of <c>TaiKhoan</c> as ManyToMany for TaiKhoanCollection_From_HeThong
		///</summary>
		[ChildEntityType(typeof(TList<TaiKhoan>))]
		UserIdTaiKhoanCollection_From_HeThong,
		///<summary>
		/// Collection of <c>TaiKhoan</c> as OneToMany for HeThongCollection
		///</summary>
		[ChildEntityType(typeof(TList<HeThong>))]
		HeThongCollectionGetByParentId,
		///<summary>
		/// Collection of <c>TaiKhoan</c> as ManyToMany for TaiKhoanCollection_From_HeThong
		///</summary>
		[ChildEntityType(typeof(TList<TaiKhoan>))]
		ParentIdTaiKhoanCollection_From_HeThong,
		///<summary>
		/// Collection of <c>TaiKhoan</c> as OneToMany for HeThongCollection
		///</summary>
		[ChildEntityType(typeof(TList<HeThong>))]
		HeThongCollectionGetByUserId,
		///<summary>
		/// Collection of <c>TaiKhoan</c> as OneToMany for GiangVienCollection
		///</summary>
		[ChildEntityType(typeof(TList<GiangVien>))]
		GiangVienCollection,
		///<summary>
		/// Collection of <c>TaiKhoan</c> as OneToMany for ReportTemplateCollection
		///</summary>
		[ChildEntityType(typeof(TList<ReportTemplate>))]
		ReportTemplateCollection,
	}
	
	#endregion TaiKhoanChildEntityTypes
	
	#region TaiKhoanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TaiKhoanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TaiKhoan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TaiKhoanFilterBuilder : SqlFilterBuilder<TaiKhoanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TaiKhoanFilterBuilder class.
		/// </summary>
		public TaiKhoanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TaiKhoanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TaiKhoanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TaiKhoanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TaiKhoanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TaiKhoanFilterBuilder
	
	#region TaiKhoanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TaiKhoanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TaiKhoan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TaiKhoanParameterBuilder : ParameterizedSqlFilterBuilder<TaiKhoanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TaiKhoanParameterBuilder class.
		/// </summary>
		public TaiKhoanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TaiKhoanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TaiKhoanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TaiKhoanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TaiKhoanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TaiKhoanParameterBuilder
	
	#region TaiKhoanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TaiKhoanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TaiKhoan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TaiKhoanSortBuilder : SqlSortBuilder<TaiKhoanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TaiKhoanSqlSortBuilder class.
		/// </summary>
		public TaiKhoanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TaiKhoanSortBuilder
	
} // end namespace
