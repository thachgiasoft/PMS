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
	/// This class is the base class for any <see cref="ChucNangProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ChucNangProviderBaseCore : EntityProviderBase<PMS.Entities.ChucNang, PMS.Entities.ChucNangKey>
	{		
		#region Get from Many To Many Relationship Functions
		#region GetByMaNhomQuyenFromNhomChucNang
		
		/// <summary>
		///		Gets ChucNang objects from the datasource by MaNhomQuyen in the
		///		NhomChucNang table. Table ChucNang is related to table NhomQuyen
		///		through the (M:N) relationship defined in the NhomChucNang table.
		/// </summary>
		/// <param name="_maNhomQuyen"></param>
		/// <returns>Returns a typed collection of ChucNang objects.</returns>
		public TList<ChucNang> GetByMaNhomQuyenFromNhomChucNang(System.Int32 _maNhomQuyen)
		{
			int count = -1;
			return GetByMaNhomQuyenFromNhomChucNang(null,_maNhomQuyen, 0, int.MaxValue, out count);
			
		}
		
		/// <summary>
		///		Gets PMS.Entities.ChucNang objects from the datasource by MaNhomQuyen in the
		///		NhomChucNang table. Table ChucNang is related to table NhomQuyen
		///		through the (M:N) relationship defined in the NhomChucNang table.
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_maNhomQuyen"></param>
		/// <remarks></remarks>
		/// <returns>Returns a TList of ChucNang objects.</returns>
		public TList<ChucNang> GetByMaNhomQuyenFromNhomChucNang(System.Int32 _maNhomQuyen, int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomQuyenFromNhomChucNang(null, _maNhomQuyen, start, pageLength, out count);
		}
		
		/// <summary>
		///		Gets ChucNang objects from the datasource by MaNhomQuyen in the
		///		NhomChucNang table. Table ChucNang is related to table NhomQuyen
		///		through the (M:N) relationship defined in the NhomChucNang table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomQuyen"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of ChucNang objects.</returns>
		public TList<ChucNang> GetByMaNhomQuyenFromNhomChucNang(TransactionManager transactionManager, System.Int32 _maNhomQuyen)
		{
			int count = -1;
			return GetByMaNhomQuyenFromNhomChucNang(transactionManager, _maNhomQuyen, 0, int.MaxValue, out count);
		}
		
		
		/// <summary>
		///		Gets ChucNang objects from the datasource by MaNhomQuyen in the
		///		NhomChucNang table. Table ChucNang is related to table NhomQuyen
		///		through the (M:N) relationship defined in the NhomChucNang table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of ChucNang objects.</returns>
		public TList<ChucNang> GetByMaNhomQuyenFromNhomChucNang(TransactionManager transactionManager, System.Int32 _maNhomQuyen,int start, int pageLength)
		{
			int count = -1;
			return GetByMaNhomQuyenFromNhomChucNang(transactionManager, _maNhomQuyen, start, pageLength, out count);
		}
		
		/// <summary>
		///		Gets ChucNang objects from the datasource by MaNhomQuyen in the
		///		NhomChucNang table. Table ChucNang is related to table NhomQuyen
		///		through the (M:N) relationship defined in the NhomChucNang table.
		/// </summary>
		/// <param name="_maNhomQuyen"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of ChucNang objects.</returns>
		public TList<ChucNang> GetByMaNhomQuyenFromNhomChucNang(System.Int32 _maNhomQuyen,int start, int pageLength, out int count)
		{
			
			return GetByMaNhomQuyenFromNhomChucNang(null, _maNhomQuyen, start, pageLength, out count);
		}


		/// <summary>
		///		Gets ChucNang objects from the datasource by MaNhomQuyen in the
		///		NhomChucNang table. Table ChucNang is related to table NhomQuyen
		///		through the (M:N) relationship defined in the NhomChucNang table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <param name="_maNhomQuyen"></param>
		/// <remarks></remarks>
		/// <returns>Returns a TList of ChucNang objects.</returns>
		public abstract TList<ChucNang> GetByMaNhomQuyenFromNhomChucNang(TransactionManager transactionManager,System.Int32 _maNhomQuyen, int start, int pageLength, out int count);
		
		#endregion GetByMaNhomQuyenFromNhomChucNang
		
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ChucNangKey key)
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
		/// 	Gets rows from the datasource based on the FK_Modules_Modules key.
		///		FK_Modules_Modules Description: 
		/// </summary>
		/// <param name="_parentId"></param>
		/// <returns>Returns a typed collection of PMS.Entities.ChucNang objects.</returns>
		public TList<ChucNang> GetByParentId(System.Int32? _parentId)
		{
			int count = -1;
			return GetByParentId(_parentId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Modules_Modules key.
		///		FK_Modules_Modules Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parentId"></param>
		/// <returns>Returns a typed collection of PMS.Entities.ChucNang objects.</returns>
		/// <remarks></remarks>
		public TList<ChucNang> GetByParentId(TransactionManager transactionManager, System.Int32? _parentId)
		{
			int count = -1;
			return GetByParentId(transactionManager, _parentId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_Modules_Modules key.
		///		FK_Modules_Modules Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ChucNang objects.</returns>
		public TList<ChucNang> GetByParentId(TransactionManager transactionManager, System.Int32? _parentId, int start, int pageLength)
		{
			int count = -1;
			return GetByParentId(transactionManager, _parentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Modules_Modules key.
		///		fkModulesModules Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_parentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ChucNang objects.</returns>
		public TList<ChucNang> GetByParentId(System.Int32? _parentId, int start, int pageLength)
		{
			int count =  -1;
			return GetByParentId(null, _parentId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Modules_Modules key.
		///		fkModulesModules Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_parentId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of PMS.Entities.ChucNang objects.</returns>
		public TList<ChucNang> GetByParentId(System.Int32? _parentId, int start, int pageLength,out int count)
		{
			return GetByParentId(null, _parentId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Modules_Modules key.
		///		FK_Modules_Modules Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of PMS.Entities.ChucNang objects.</returns>
		public abstract TList<ChucNang> GetByParentId(TransactionManager transactionManager, System.Int32? _parentId, int start, int pageLength, out int count);
		
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
		public override PMS.Entities.ChucNang Get(TransactionManager transactionManager, PMS.Entities.ChucNangKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_Modules index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucNang"/> class.</returns>
		public PMS.Entities.ChucNang GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Modules index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucNang"/> class.</returns>
		public PMS.Entities.ChucNang GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Modules index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucNang"/> class.</returns>
		public PMS.Entities.ChucNang GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Modules index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucNang"/> class.</returns>
		public PMS.Entities.ChucNang GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Modules index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucNang"/> class.</returns>
		public PMS.Entities.ChucNang GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Modules index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ChucNang"/> class.</returns>
		public abstract PMS.Entities.ChucNang GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ChucNang_GetByParentIDTrangThai 
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByParentIDTrangThai' stored procedure. 
		/// </summary>
		/// <param name="parentId"> A <c>System.Int32</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByParentIDTrangThai(System.Int32 parentId, System.Boolean trangThai)
		{
			return GetByParentIDTrangThai(null, 0, int.MaxValue , parentId, trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByParentIDTrangThai' stored procedure. 
		/// </summary>
		/// <param name="parentId"> A <c>System.Int32</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByParentIDTrangThai(int start, int pageLength, System.Int32 parentId, System.Boolean trangThai)
		{
			return GetByParentIDTrangThai(null, start, pageLength , parentId, trangThai);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByParentIDTrangThai' stored procedure. 
		/// </summary>
		/// <param name="parentId"> A <c>System.Int32</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByParentIDTrangThai(TransactionManager transactionManager, System.Int32 parentId, System.Boolean trangThai)
		{
			return GetByParentIDTrangThai(transactionManager, 0, int.MaxValue , parentId, trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByParentIDTrangThai' stored procedure. 
		/// </summary>
		/// <param name="parentId"> A <c>System.Int32</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public abstract TList<ChucNang> GetByParentIDTrangThai(TransactionManager transactionManager, int start, int pageLength , System.Int32 parentId, System.Boolean trangThai);
		
		#endregion
		
		#region cust_ChucNang_GetByTrangThai 
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByTrangThai' stored procedure. 
		/// </summary>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByTrangThai(System.Boolean trangThai)
		{
			return GetByTrangThai(null, 0, int.MaxValue , trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByTrangThai' stored procedure. 
		/// </summary>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByTrangThai(int start, int pageLength, System.Boolean trangThai)
		{
			return GetByTrangThai(null, start, pageLength , trangThai);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByTrangThai' stored procedure. 
		/// </summary>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByTrangThai(TransactionManager transactionManager, System.Boolean trangThai)
		{
			return GetByTrangThai(transactionManager, 0, int.MaxValue , trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByTrangThai' stored procedure. 
		/// </summary>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public abstract TList<ChucNang> GetByTrangThai(TransactionManager transactionManager, int start, int pageLength , System.Boolean trangThai);
		
		#endregion
		
		#region cust_ChucNang_GetByParentIDPhanLoaiTrangThai 
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByParentIDPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="parentId"> A <c>System.Int32</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByParentIDPhanLoaiTrangThai(System.Int32 parentId, System.String phanLoai, System.Boolean trangThai)
		{
			return GetByParentIDPhanLoaiTrangThai(null, 0, int.MaxValue , parentId, phanLoai, trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByParentIDPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="parentId"> A <c>System.Int32</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByParentIDPhanLoaiTrangThai(int start, int pageLength, System.Int32 parentId, System.String phanLoai, System.Boolean trangThai)
		{
			return GetByParentIDPhanLoaiTrangThai(null, start, pageLength , parentId, phanLoai, trangThai);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByParentIDPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="parentId"> A <c>System.Int32</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByParentIDPhanLoaiTrangThai(TransactionManager transactionManager, System.Int32 parentId, System.String phanLoai, System.Boolean trangThai)
		{
			return GetByParentIDPhanLoaiTrangThai(transactionManager, 0, int.MaxValue , parentId, phanLoai, trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByParentIDPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="parentId"> A <c>System.Int32</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public abstract TList<ChucNang> GetByParentIDPhanLoaiTrangThai(TransactionManager transactionManager, int start, int pageLength , System.Int32 parentId, System.String phanLoai, System.Boolean trangThai);
		
		#endregion
		
		#region cust_ChucNang_GetByIDTrangThai 
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByIDTrangThai' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByIDTrangThai(System.Int32 id, System.Boolean trangThai)
		{
			return GetByIDTrangThai(null, 0, int.MaxValue , id, trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByIDTrangThai' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByIDTrangThai(int start, int pageLength, System.Int32 id, System.Boolean trangThai)
		{
			return GetByIDTrangThai(null, start, pageLength , id, trangThai);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByIDTrangThai' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByIDTrangThai(TransactionManager transactionManager, System.Int32 id, System.Boolean trangThai)
		{
			return GetByIDTrangThai(transactionManager, 0, int.MaxValue , id, trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByIDTrangThai' stored procedure. 
		/// </summary>
		/// <param name="id"> A <c>System.Int32</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public abstract TList<ChucNang> GetByIDTrangThai(TransactionManager transactionManager, int start, int pageLength , System.Int32 id, System.Boolean trangThai);
		
		#endregion
		
		#region cust_ChucNang_GetByMaNhomQuyenPhanLoaiTrangThai 
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByMaNhomQuyenPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByMaNhomQuyenPhanLoaiTrangThai(System.Int32 maNhomQuyen, System.String phanLoai, System.Boolean trangThai)
		{
			return GetByMaNhomQuyenPhanLoaiTrangThai(null, 0, int.MaxValue , maNhomQuyen, phanLoai, trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByMaNhomQuyenPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByMaNhomQuyenPhanLoaiTrangThai(int start, int pageLength, System.Int32 maNhomQuyen, System.String phanLoai, System.Boolean trangThai)
		{
			return GetByMaNhomQuyenPhanLoaiTrangThai(null, start, pageLength , maNhomQuyen, phanLoai, trangThai);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByMaNhomQuyenPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByMaNhomQuyenPhanLoaiTrangThai(TransactionManager transactionManager, System.Int32 maNhomQuyen, System.String phanLoai, System.Boolean trangThai)
		{
			return GetByMaNhomQuyenPhanLoaiTrangThai(transactionManager, 0, int.MaxValue , maNhomQuyen, phanLoai, trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByMaNhomQuyenPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public abstract TList<ChucNang> GetByMaNhomQuyenPhanLoaiTrangThai(TransactionManager transactionManager, int start, int pageLength , System.Int32 maNhomQuyen, System.String phanLoai, System.Boolean trangThai);
		
		#endregion
		
		#region cust_ChucNang_GetByTenFormTrangThai 
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByTenFormTrangThai' stored procedure. 
		/// </summary>
		/// <param name="tenForm"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByTenFormTrangThai(System.String tenForm, System.Boolean trangThai)
		{
			return GetByTenFormTrangThai(null, 0, int.MaxValue , tenForm, trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByTenFormTrangThai' stored procedure. 
		/// </summary>
		/// <param name="tenForm"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByTenFormTrangThai(int start, int pageLength, System.String tenForm, System.Boolean trangThai)
		{
			return GetByTenFormTrangThai(null, start, pageLength , tenForm, trangThai);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByTenFormTrangThai' stored procedure. 
		/// </summary>
		/// <param name="tenForm"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByTenFormTrangThai(TransactionManager transactionManager, System.String tenForm, System.Boolean trangThai)
		{
			return GetByTenFormTrangThai(transactionManager, 0, int.MaxValue , tenForm, trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByTenFormTrangThai' stored procedure. 
		/// </summary>
		/// <param name="tenForm"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public abstract TList<ChucNang> GetByTenFormTrangThai(TransactionManager transactionManager, int start, int pageLength , System.String tenForm, System.Boolean trangThai);
		
		#endregion
		
		#region cust_ChucNang_GetByPhanLoaiTrangThai 
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByPhanLoaiTrangThai(System.String phanLoai, System.Boolean trangThai)
		{
			return GetByPhanLoaiTrangThai(null, 0, int.MaxValue , phanLoai, trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByPhanLoaiTrangThai(int start, int pageLength, System.String phanLoai, System.Boolean trangThai)
		{
			return GetByPhanLoaiTrangThai(null, start, pageLength , phanLoai, trangThai);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByPhanLoaiTrangThai(TransactionManager transactionManager, System.String phanLoai, System.Boolean trangThai)
		{
			return GetByPhanLoaiTrangThai(transactionManager, 0, int.MaxValue , phanLoai, trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public abstract TList<ChucNang> GetByPhanLoaiTrangThai(TransactionManager transactionManager, int start, int pageLength , System.String phanLoai, System.Boolean trangThai);
		
		#endregion
		
		#region cust_ChucNang_GetByMaNhomQuyenParentIDPhanLoaiTrangThai 
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByMaNhomQuyenParentIDPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <param name="parentId"> A <c>System.Int32</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByMaNhomQuyenParentIDPhanLoaiTrangThai(System.Int32 maNhomQuyen, System.Int32 parentId, System.String phanLoai, System.Boolean trangThai)
		{
			return GetByMaNhomQuyenParentIDPhanLoaiTrangThai(null, 0, int.MaxValue , maNhomQuyen, parentId, phanLoai, trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByMaNhomQuyenParentIDPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <param name="parentId"> A <c>System.Int32</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByMaNhomQuyenParentIDPhanLoaiTrangThai(int start, int pageLength, System.Int32 maNhomQuyen, System.Int32 parentId, System.String phanLoai, System.Boolean trangThai)
		{
			return GetByMaNhomQuyenParentIDPhanLoaiTrangThai(null, start, pageLength , maNhomQuyen, parentId, phanLoai, trangThai);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByMaNhomQuyenParentIDPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <param name="parentId"> A <c>System.Int32</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByMaNhomQuyenParentIDPhanLoaiTrangThai(TransactionManager transactionManager, System.Int32 maNhomQuyen, System.Int32 parentId, System.String phanLoai, System.Boolean trangThai)
		{
			return GetByMaNhomQuyenParentIDPhanLoaiTrangThai(transactionManager, 0, int.MaxValue , maNhomQuyen, parentId, phanLoai, trangThai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByMaNhomQuyenParentIDPhanLoaiTrangThai' stored procedure. 
		/// </summary>
		/// <param name="maNhomQuyen"> A <c>System.Int32</c> instance.</param>
		/// <param name="parentId"> A <c>System.Int32</c> instance.</param>
		/// <param name="phanLoai"> A <c>System.String</c> instance.</param>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public abstract TList<ChucNang> GetByMaNhomQuyenParentIDPhanLoaiTrangThai(TransactionManager transactionManager, int start, int pageLength , System.Int32 maNhomQuyen, System.Int32 parentId, System.String phanLoai, System.Boolean trangThai);
		
		#endregion
		
		#region cust_ChucNang_GetByMaTaiKhoan 
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByMaTaiKhoan' stored procedure. 
		/// </summary>
		/// <param name="maTaiKhoan"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaTaiKhoan(System.Int32 maTaiKhoan)
		{
			return GetByMaTaiKhoan(null, 0, int.MaxValue , maTaiKhoan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByMaTaiKhoan' stored procedure. 
		/// </summary>
		/// <param name="maTaiKhoan"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaTaiKhoan(int start, int pageLength, System.Int32 maTaiKhoan)
		{
			return GetByMaTaiKhoan(null, start, pageLength , maTaiKhoan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByMaTaiKhoan' stored procedure. 
		/// </summary>
		/// <param name="maTaiKhoan"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaTaiKhoan(TransactionManager transactionManager, System.Int32 maTaiKhoan)
		{
			return GetByMaTaiKhoan(transactionManager, 0, int.MaxValue , maTaiKhoan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByMaTaiKhoan' stored procedure. 
		/// </summary>
		/// <param name="maTaiKhoan"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByMaTaiKhoan(TransactionManager transactionManager, int start, int pageLength , System.Int32 maTaiKhoan);
		
		#endregion
		
		#region cust_ChucNang_GetByTrangThaiNhomQuyen 
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByTrangThaiNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="maNhomQuyen"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByTrangThaiNhomQuyen(System.Boolean trangThai, System.String maNhomQuyen)
		{
			return GetByTrangThaiNhomQuyen(null, 0, int.MaxValue , trangThai, maNhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByTrangThaiNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="maNhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByTrangThaiNhomQuyen(int start, int pageLength, System.Boolean trangThai, System.String maNhomQuyen)
		{
			return GetByTrangThaiNhomQuyen(null, start, pageLength , trangThai, maNhomQuyen);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByTrangThaiNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="maNhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public TList<ChucNang> GetByTrangThaiNhomQuyen(TransactionManager transactionManager, System.Boolean trangThai, System.String maNhomQuyen)
		{
			return GetByTrangThaiNhomQuyen(transactionManager, 0, int.MaxValue , trangThai, maNhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetByTrangThaiNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="trangThai"> A <c>System.Boolean</c> instance.</param>
		/// <param name="maNhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;ChucNang&gt;"/> instance.</returns>
		public abstract TList<ChucNang> GetByTrangThaiNhomQuyen(TransactionManager transactionManager, int start, int pageLength , System.Boolean trangThai, System.String maNhomQuyen);
		
		#endregion
		
		#region cust_ChucNang_GetModulesByGroupID 
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetModulesByGroupID' stored procedure. 
		/// </summary>
		/// <param name="groupId"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetModulesByGroupID(System.Int32 groupId)
		{
			return GetModulesByGroupID(null, 0, int.MaxValue , groupId);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetModulesByGroupID' stored procedure. 
		/// </summary>
		/// <param name="groupId"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetModulesByGroupID(int start, int pageLength, System.Int32 groupId)
		{
			return GetModulesByGroupID(null, start, pageLength , groupId);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetModulesByGroupID' stored procedure. 
		/// </summary>
		/// <param name="groupId"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetModulesByGroupID(TransactionManager transactionManager, System.Int32 groupId)
		{
			return GetModulesByGroupID(transactionManager, 0, int.MaxValue , groupId);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ChucNang_GetModulesByGroupID' stored procedure. 
		/// </summary>
		/// <param name="groupId"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetModulesByGroupID(TransactionManager transactionManager, int start, int pageLength , System.Int32 groupId);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ChucNang&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ChucNang&gt;"/></returns>
		public static TList<ChucNang> Fill(IDataReader reader, TList<ChucNang> rows, int start, int pageLength)
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
				
				PMS.Entities.ChucNang c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ChucNang")
					.Append("|").Append((System.Int32)reader[((int)ChucNangColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ChucNang>(
					key.ToString(), // EntityTrackingKey
					"ChucNang",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ChucNang();
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
					c.Id = (System.Int32)reader[(ChucNangColumn.Id.ToString())];
					c.ParentId = (reader[ChucNangColumn.ParentId.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChucNangColumn.ParentId.ToString())];
					c.PhanLoai = (reader[ChucNangColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucNangColumn.PhanLoai.ToString())];
					c.Menu = (reader[ChucNangColumn.Menu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChucNangColumn.Menu.ToString())];
					c.BeginGroup = (reader[ChucNangColumn.BeginGroup.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChucNangColumn.BeginGroup.ToString())];
					c.RibbonStyle = (reader[ChucNangColumn.RibbonStyle.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChucNangColumn.RibbonStyle.ToString())];
					c.DataLayout = (reader[ChucNangColumn.DataLayout.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(ChucNangColumn.DataLayout.ToString())];
					c.TenChucNang = (reader[ChucNangColumn.TenChucNang.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucNangColumn.TenChucNang.ToString())];
					c.TenForm = (reader[ChucNangColumn.TenForm.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucNangColumn.TenForm.ToString())];
					c.HinhAnh = (reader[ChucNangColumn.HinhAnh.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(ChucNangColumn.HinhAnh.ToString())];
					c.ThuTu = (reader[ChucNangColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChucNangColumn.ThuTu.ToString())];
					c.TenPhuongThuc = (reader[ChucNangColumn.TenPhuongThuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucNangColumn.TenPhuongThuc.ToString())];
					c.ThamSo = (reader[ChucNangColumn.ThamSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucNangColumn.ThamSo.ToString())];
					c.KieuForm = (reader[ChucNangColumn.KieuForm.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucNangColumn.KieuForm.ToString())];
					c.TrangThai = (reader[ChucNangColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChucNangColumn.TrangThai.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChucNang"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChucNang"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ChucNang entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(ChucNangColumn.Id.ToString())];
			entity.ParentId = (reader[ChucNangColumn.ParentId.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChucNangColumn.ParentId.ToString())];
			entity.PhanLoai = (reader[ChucNangColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucNangColumn.PhanLoai.ToString())];
			entity.Menu = (reader[ChucNangColumn.Menu.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChucNangColumn.Menu.ToString())];
			entity.BeginGroup = (reader[ChucNangColumn.BeginGroup.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChucNangColumn.BeginGroup.ToString())];
			entity.RibbonStyle = (reader[ChucNangColumn.RibbonStyle.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChucNangColumn.RibbonStyle.ToString())];
			entity.DataLayout = (reader[ChucNangColumn.DataLayout.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(ChucNangColumn.DataLayout.ToString())];
			entity.TenChucNang = (reader[ChucNangColumn.TenChucNang.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucNangColumn.TenChucNang.ToString())];
			entity.TenForm = (reader[ChucNangColumn.TenForm.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucNangColumn.TenForm.ToString())];
			entity.HinhAnh = (reader[ChucNangColumn.HinhAnh.ToString()] == DBNull.Value) ? null : (System.Byte[])reader[(ChucNangColumn.HinhAnh.ToString())];
			entity.ThuTu = (reader[ChucNangColumn.ThuTu.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ChucNangColumn.ThuTu.ToString())];
			entity.TenPhuongThuc = (reader[ChucNangColumn.TenPhuongThuc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucNangColumn.TenPhuongThuc.ToString())];
			entity.ThamSo = (reader[ChucNangColumn.ThamSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucNangColumn.ThamSo.ToString())];
			entity.KieuForm = (reader[ChucNangColumn.KieuForm.ToString()] == DBNull.Value) ? null : (System.String)reader[(ChucNangColumn.KieuForm.ToString())];
			entity.TrangThai = (reader[ChucNangColumn.TrangThai.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ChucNangColumn.TrangThai.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ChucNang"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ChucNang"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ChucNang entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["ID"];
			entity.ParentId = Convert.IsDBNull(dataRow["ParentID"]) ? null : (System.Int32?)dataRow["ParentID"];
			entity.PhanLoai = Convert.IsDBNull(dataRow["PhanLoai"]) ? null : (System.String)dataRow["PhanLoai"];
			entity.Menu = Convert.IsDBNull(dataRow["Menu"]) ? null : (System.Boolean?)dataRow["Menu"];
			entity.BeginGroup = Convert.IsDBNull(dataRow["BeginGroup"]) ? null : (System.Boolean?)dataRow["BeginGroup"];
			entity.RibbonStyle = Convert.IsDBNull(dataRow["RibbonStyle"]) ? null : (System.Boolean?)dataRow["RibbonStyle"];
			entity.DataLayout = Convert.IsDBNull(dataRow["DataLayout"]) ? null : (System.Byte[])dataRow["DataLayout"];
			entity.TenChucNang = Convert.IsDBNull(dataRow["TenChucNang"]) ? null : (System.String)dataRow["TenChucNang"];
			entity.TenForm = Convert.IsDBNull(dataRow["TenForm"]) ? null : (System.String)dataRow["TenForm"];
			entity.HinhAnh = Convert.IsDBNull(dataRow["HinhAnh"]) ? null : (System.Byte[])dataRow["HinhAnh"];
			entity.ThuTu = Convert.IsDBNull(dataRow["ThuTu"]) ? null : (System.Int32?)dataRow["ThuTu"];
			entity.TenPhuongThuc = Convert.IsDBNull(dataRow["TenPhuongThuc"]) ? null : (System.String)dataRow["TenPhuongThuc"];
			entity.ThamSo = Convert.IsDBNull(dataRow["ThamSo"]) ? null : (System.String)dataRow["ThamSo"];
			entity.KieuForm = Convert.IsDBNull(dataRow["KieuForm"]) ? null : (System.String)dataRow["KieuForm"];
			entity.TrangThai = Convert.IsDBNull(dataRow["TrangThai"]) ? null : (System.Boolean?)dataRow["TrangThai"];
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
		/// <param name="entity">The <see cref="PMS.Entities.ChucNang"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ChucNang Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ChucNang entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region ParentIdSource	
			if (CanDeepLoad(entity, "ChucNang|ParentIdSource", deepLoadType, innerList) 
				&& entity.ParentIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ParentId ?? (int)0);
				ChucNang tmpEntity = EntityManager.LocateEntity<ChucNang>(EntityLocator.ConstructKeyFromPkItems(typeof(ChucNang), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ParentIdSource = tmpEntity;
				else
					entity.ParentIdSource = DataRepository.ChucNangProvider.GetById(transactionManager, (entity.ParentId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ParentIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ParentIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ChucNangProvider.DeepLoad(transactionManager, entity.ParentIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ParentIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetById methods when available
			
			#region NhomChucNangCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<NhomChucNang>|NhomChucNangCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'NhomChucNangCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.NhomChucNangCollection = DataRepository.NhomChucNangProvider.GetByMaChucNang(transactionManager, entity.Id);

				if (deep && entity.NhomChucNangCollection.Count > 0)
				{
					deepHandles.Add("NhomChucNangCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<NhomChucNang>) DataRepository.NhomChucNangProvider.DeepLoad,
						new object[] { transactionManager, entity.NhomChucNangCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MaNhomQuyenNhomQuyenCollection_From_NhomChucNang
			// RelationshipType.ManyToMany
			if (CanDeepLoad(entity, "List<NhomQuyen>|MaNhomQuyenNhomQuyenCollection_From_NhomChucNang", deepLoadType, innerList))
			{
				entity.MaNhomQuyenNhomQuyenCollection_From_NhomChucNang = DataRepository.NhomQuyenProvider.GetByMaChucNangFromNhomChucNang(transactionManager, entity.Id);			 
		
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MaNhomQuyenNhomQuyenCollection_From_NhomChucNang' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MaNhomQuyenNhomQuyenCollection_From_NhomChucNang != null)
				{
					deepHandles.Add("MaNhomQuyenNhomQuyenCollection_From_NhomChucNang",
						new KeyValuePair<Delegate, object>((DeepLoadHandle< NhomQuyen >) DataRepository.NhomQuyenProvider.DeepLoad,
						new object[] { transactionManager, entity.MaNhomQuyenNhomQuyenCollection_From_NhomChucNang, deep, deepLoadType, childTypes, innerList }
					));
				}
			}
			#endregion
			
			
			
			#region ChucNangCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ChucNang>|ChucNangCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ChucNangCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ChucNangCollection = DataRepository.ChucNangProvider.GetByParentId(transactionManager, entity.Id);

				if (deep && entity.ChucNangCollection.Count > 0)
				{
					deepHandles.Add("ChucNangCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ChucNang>) DataRepository.ChucNangProvider.DeepLoad,
						new object[] { transactionManager, entity.ChucNangCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the PMS.Entities.ChucNang object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ChucNang instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ChucNang Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ChucNang entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region ParentIdSource
			if (CanDeepSave(entity, "ChucNang|ParentIdSource", deepSaveType, innerList) 
				&& entity.ParentIdSource != null)
			{
				DataRepository.ChucNangProvider.Save(transactionManager, entity.ParentIdSource);
				entity.ParentId = entity.ParentIdSource.Id;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();

			#region MaNhomQuyenNhomQuyenCollection_From_NhomChucNang>
			if (CanDeepSave(entity.MaNhomQuyenNhomQuyenCollection_From_NhomChucNang, "List<NhomQuyen>|MaNhomQuyenNhomQuyenCollection_From_NhomChucNang", deepSaveType, innerList))
			{
				if (entity.MaNhomQuyenNhomQuyenCollection_From_NhomChucNang.Count > 0 || entity.MaNhomQuyenNhomQuyenCollection_From_NhomChucNang.DeletedItems.Count > 0)
				{
					DataRepository.NhomQuyenProvider.Save(transactionManager, entity.MaNhomQuyenNhomQuyenCollection_From_NhomChucNang); 
					deepHandles.Add("MaNhomQuyenNhomQuyenCollection_From_NhomChucNang",
						new KeyValuePair<Delegate, object>((DeepSaveHandle<NhomQuyen>) DataRepository.NhomQuyenProvider.DeepSave,
						new object[] { transactionManager, entity.MaNhomQuyenNhomQuyenCollection_From_NhomChucNang, deepSaveType, childTypes, innerList }
					));
				}
			}
			#endregion 
	
			#region List<NhomChucNang>
				if (CanDeepSave(entity.NhomChucNangCollection, "List<NhomChucNang>|NhomChucNangCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(NhomChucNang child in entity.NhomChucNangCollection)
					{
						if(child.MaChucNangSource != null)
						{
								child.MaChucNang = child.MaChucNangSource.Id;
						}

						if(child.MaNhomQuyenSource != null)
						{
								child.MaNhomQuyen = child.MaNhomQuyenSource.MaNhomQuyen;
						}

					}

					if (entity.NhomChucNangCollection.Count > 0 || entity.NhomChucNangCollection.DeletedItems.Count > 0)
					{
						//DataRepository.NhomChucNangProvider.Save(transactionManager, entity.NhomChucNangCollection);
						
						deepHandles.Add("NhomChucNangCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< NhomChucNang >) DataRepository.NhomChucNangProvider.DeepSave,
							new object[] { transactionManager, entity.NhomChucNangCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ChucNang>
				if (CanDeepSave(entity.ChucNangCollection, "List<ChucNang>|ChucNangCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ChucNang child in entity.ChucNangCollection)
					{
						if(child.ParentIdSource != null)
						{
							child.ParentId = child.ParentIdSource.Id;
						}
						else
						{
							child.ParentId = entity.Id;
						}

					}

					if (entity.ChucNangCollection.Count > 0 || entity.ChucNangCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ChucNangProvider.Save(transactionManager, entity.ChucNangCollection);
						
						deepHandles.Add("ChucNangCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ChucNang >) DataRepository.ChucNangProvider.DeepSave,
							new object[] { transactionManager, entity.ChucNangCollection, deepSaveType, childTypes, innerList }
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
	
	#region ChucNangChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ChucNang</c>
	///</summary>
	public enum ChucNangChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>ChucNang</c> at ParentIdSource
		///</summary>
		[ChildEntityType(typeof(ChucNang))]
		ChucNang,
		///<summary>
		/// Collection of <c>ChucNang</c> as OneToMany for NhomChucNangCollection
		///</summary>
		[ChildEntityType(typeof(TList<NhomChucNang>))]
		NhomChucNangCollection,
		///<summary>
		/// Collection of <c>ChucNang</c> as ManyToMany for NhomQuyenCollection_From_NhomChucNang
		///</summary>
		[ChildEntityType(typeof(TList<NhomQuyen>))]
		MaNhomQuyenNhomQuyenCollection_From_NhomChucNang,
		///<summary>
		/// Collection of <c>ChucNang</c> as OneToMany for ChucNangCollection
		///</summary>
		[ChildEntityType(typeof(TList<ChucNang>))]
		ChucNangCollection,
	}
	
	#endregion ChucNangChildEntityTypes
	
	#region ChucNangFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ChucNangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChucNang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChucNangFilterBuilder : SqlFilterBuilder<ChucNangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChucNangFilterBuilder class.
		/// </summary>
		public ChucNangFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChucNangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChucNangFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChucNangFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChucNangFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChucNangFilterBuilder
	
	#region ChucNangParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ChucNangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChucNang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChucNangParameterBuilder : ParameterizedSqlFilterBuilder<ChucNangColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChucNangParameterBuilder class.
		/// </summary>
		public ChucNangParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ChucNangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ChucNangParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ChucNangParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ChucNangParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ChucNangParameterBuilder
	
	#region ChucNangSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ChucNangColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChucNang"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ChucNangSortBuilder : SqlSortBuilder<ChucNangColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChucNangSqlSortBuilder class.
		/// </summary>
		public ChucNangSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ChucNangSortBuilder
	
} // end namespace
