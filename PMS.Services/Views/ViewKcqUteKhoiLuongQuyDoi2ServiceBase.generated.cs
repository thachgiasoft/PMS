﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewKcqUteKhoiLuongQuyDoi2.cs instead.
*/

#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Security;
using System.Data;

using PMS.Entities;
using PMS.Entities.Validation;
using Entities = PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;


using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion 

namespace PMS.Services
{		
	
	///<summary>
	/// An object representation of the 'view_KcqUte_KhoiLuongQuyDoi2' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewKcqUteKhoiLuongQuyDoi2.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewKcqUteKhoiLuongQuyDoi2"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewKcqUteKhoiLuongQuyDoi2ServiceBase : ServiceViewBase<ViewKcqUteKhoiLuongQuyDoi2>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewKcqUteKhoiLuongQuyDoi2"/> instance .
		///</summary>
		public ViewKcqUteKhoiLuongQuyDoi2ServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewKcqUteKhoiLuongQuyDoi2"/> instance.
		///</summary>
		///<param name="_id"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_nhomMonHoc"></param>
		///<param name="_maHocPhan"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_maDot"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_nhom"></param>
		///<param name="_maLop"></param>
		///<param name="_maDiaDiem"></param>
		///<param name="_tenDiaDiem"></param>
		///<param name="_tienXeDiaDiem"></param>
		///<param name="_maGiangVienQuanLy"></param>
		///<param name="_soTinChi"></param>
		///<param name="_siSo"></param>
		///<param name="_lopClc"></param>
		///<param name="_soTietDayChuNhat"></param>
		///<param name="_soTiet"></param>
		///<param name="_maLoaiHocPhan"></param>
		///<param name="_heSoLopDongLyThuyet"></param>
		///<param name="_heSoLopDongThTnTt"></param>
		///<param name="_tietQuyDoi"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_hoTen"></param>
		///<param name="_tenLoaiHocPhan"></param>
		///<param name="_loaiHocPhan"></param>
		///<param name="_soGioThucGiangTrenLop"></param>
		///<param name="_soGioChuanTinhThem"></param>
		///<param name="_maNhomMon"></param>
		///<param name="_tenNhomMon"></param>
		///<param name="_heSoHocKy"></param>
		public static ViewKcqUteKhoiLuongQuyDoi2 CreateViewKcqUteKhoiLuongQuyDoi2(System.Int32 _id, System.String _maMonHoc, System.String _tenMonHoc, System.String _nhomMonHoc, System.String _maHocPhan, System.String _namHoc, System.String _hocKy, System.String _maDot, System.String _maLopHocPhan, System.String _nhom, System.String _maLop, System.String _maDiaDiem, System.String _tenDiaDiem, System.Decimal? _tienXeDiaDiem, System.String _maGiangVienQuanLy, System.Int32? _soTinChi, System.Int32? _siSo, System.Boolean? _lopClc, System.Int32? _soTietDayChuNhat, System.Decimal? _soTiet, System.Int32? _maLoaiHocPhan, System.Decimal? _heSoLopDongLyThuyet, System.Decimal? _heSoLopDongThTnTt, System.Decimal? _tietQuyDoi, System.String _ho, System.String _ten, System.String _hoTen, System.String _tenLoaiHocPhan, System.String _loaiHocPhan, System.Decimal? _soGioThucGiangTrenLop, System.Decimal? _soGioChuanTinhThem, System.Int32? _maNhomMon, System.String _tenNhomMon, System.Decimal? _heSoHocKy)
		{
			ViewKcqUteKhoiLuongQuyDoi2 newEntityViewKcqUteKhoiLuongQuyDoi2 = new ViewKcqUteKhoiLuongQuyDoi2();
			newEntityViewKcqUteKhoiLuongQuyDoi2.Id  = _id;
			newEntityViewKcqUteKhoiLuongQuyDoi2.MaMonHoc  = _maMonHoc;
			newEntityViewKcqUteKhoiLuongQuyDoi2.TenMonHoc  = _tenMonHoc;
			newEntityViewKcqUteKhoiLuongQuyDoi2.NhomMonHoc  = _nhomMonHoc;
			newEntityViewKcqUteKhoiLuongQuyDoi2.MaHocPhan  = _maHocPhan;
			newEntityViewKcqUteKhoiLuongQuyDoi2.NamHoc  = _namHoc;
			newEntityViewKcqUteKhoiLuongQuyDoi2.HocKy  = _hocKy;
			newEntityViewKcqUteKhoiLuongQuyDoi2.MaDot  = _maDot;
			newEntityViewKcqUteKhoiLuongQuyDoi2.MaLopHocPhan  = _maLopHocPhan;
			newEntityViewKcqUteKhoiLuongQuyDoi2.Nhom  = _nhom;
			newEntityViewKcqUteKhoiLuongQuyDoi2.MaLop  = _maLop;
			newEntityViewKcqUteKhoiLuongQuyDoi2.MaDiaDiem  = _maDiaDiem;
			newEntityViewKcqUteKhoiLuongQuyDoi2.TenDiaDiem  = _tenDiaDiem;
			newEntityViewKcqUteKhoiLuongQuyDoi2.TienXeDiaDiem  = _tienXeDiaDiem;
			newEntityViewKcqUteKhoiLuongQuyDoi2.MaGiangVienQuanLy  = _maGiangVienQuanLy;
			newEntityViewKcqUteKhoiLuongQuyDoi2.SoTinChi  = _soTinChi;
			newEntityViewKcqUteKhoiLuongQuyDoi2.SiSo  = _siSo;
			newEntityViewKcqUteKhoiLuongQuyDoi2.LopClc  = _lopClc;
			newEntityViewKcqUteKhoiLuongQuyDoi2.SoTietDayChuNhat  = _soTietDayChuNhat;
			newEntityViewKcqUteKhoiLuongQuyDoi2.SoTiet  = _soTiet;
			newEntityViewKcqUteKhoiLuongQuyDoi2.MaLoaiHocPhan  = _maLoaiHocPhan;
			newEntityViewKcqUteKhoiLuongQuyDoi2.HeSoLopDongLyThuyet  = _heSoLopDongLyThuyet;
			newEntityViewKcqUteKhoiLuongQuyDoi2.HeSoLopDongThTnTt  = _heSoLopDongThTnTt;
			newEntityViewKcqUteKhoiLuongQuyDoi2.TietQuyDoi  = _tietQuyDoi;
			newEntityViewKcqUteKhoiLuongQuyDoi2.Ho  = _ho;
			newEntityViewKcqUteKhoiLuongQuyDoi2.Ten  = _ten;
			newEntityViewKcqUteKhoiLuongQuyDoi2.HoTen  = _hoTen;
			newEntityViewKcqUteKhoiLuongQuyDoi2.TenLoaiHocPhan  = _tenLoaiHocPhan;
			newEntityViewKcqUteKhoiLuongQuyDoi2.LoaiHocPhan  = _loaiHocPhan;
			newEntityViewKcqUteKhoiLuongQuyDoi2.SoGioThucGiangTrenLop  = _soGioThucGiangTrenLop;
			newEntityViewKcqUteKhoiLuongQuyDoi2.SoGioChuanTinhThem  = _soGioChuanTinhThem;
			newEntityViewKcqUteKhoiLuongQuyDoi2.MaNhomMon  = _maNhomMon;
			newEntityViewKcqUteKhoiLuongQuyDoi2.TenNhomMon  = _tenNhomMon;
			newEntityViewKcqUteKhoiLuongQuyDoi2.HeSoHocKy  = _heSoHocKy;
			return newEntityViewKcqUteKhoiLuongQuyDoi2;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewKcqUteKhoiLuongQuyDoi2> securityContext = new SecurityContext<ViewKcqUteKhoiLuongQuyDoi2>();
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		private static readonly int defaultMaxRecords = 1000000;
		#endregion 
		
		#region Data Access Methods
			
		#region Get 
		/// <summary>
		/// Attempts to do a parameterized version of a simple whereclause. 
		/// Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <remarks>Does NOT Support Advanced Operations such as SubSelects.  See GetPaged for that functionality.</remarks>
		/// <returns>Returns a typed collection of Entity objects.</returns>
		public override VList<ViewKcqUteKhoiLuongQuyDoi2> Get(string whereClause, string orderBy)
		{
			int totalCount = -1;
			return Get(whereClause, orderBy, 0, defaultMaxRecords, out totalCount);
		}

		/// <summary>
		/// Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter to get total records for query</param>
		/// <remarks>Does NOT Support Advanced Operations such as SubSelects.  See GetPaged for that functionality.</remarks>
		/// <returns>Returns a typed collection TList{ViewKcqUteKhoiLuongQuyDoi2} of <c>ViewKcqUteKhoiLuongQuyDoi2</c> objects.</returns>
		public override VList<ViewKcqUteKhoiLuongQuyDoi2> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewKcqUteKhoiLuongQuyDoi2> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKcqUteKhoiLuongQuyDoi2Provider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
				//if borrowed tran, leave open for next call
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen) 
					transactionManager.Rollback();
				
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
			}
			return list;
		}
		
		#endregion Get Methods
		
		#region GetAll
		/// <summary>
		/// Get a complete collection of <see cref="ViewKcqUteKhoiLuongQuyDoi2" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewKcqUteKhoiLuongQuyDoi2> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewKcqUteKhoiLuongQuyDoi2" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewKcqUteKhoiLuongQuyDoi2}"/> </returns>
		public override VList<ViewKcqUteKhoiLuongQuyDoi2> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewKcqUteKhoiLuongQuyDoi2> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewKcqUteKhoiLuongQuyDoi2Provider.GetAll(transactionManager, start, pageLength, out totalCount);	
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen) 
					transactionManager.Rollback();
				
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
			}
			return list;
		}
		#endregion GetAll

		#region GetPaged
		/// <summary>
		/// Gets a page of <see cref="TList{ViewKcqUteKhoiLuongQuyDoi2}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKcqUteKhoiLuongQuyDoi2</c> objects.</returns>
		public virtual VList<ViewKcqUteKhoiLuongQuyDoi2> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewKcqUteKhoiLuongQuyDoi2}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKcqUteKhoiLuongQuyDoi2</c> objects.</returns>
		public virtual VList<ViewKcqUteKhoiLuongQuyDoi2> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewKcqUteKhoiLuongQuyDoi2}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKcqUteKhoiLuongQuyDoi2</c> objects.</returns>
		public override VList<ViewKcqUteKhoiLuongQuyDoi2> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewKcqUteKhoiLuongQuyDoi2> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKcqUteKhoiLuongQuyDoi2Provider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
				//if borrowed tran, leave open for next call
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen) 
					transactionManager.Rollback();
				
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
			}
			return list;			
		}
		
		/// <summary>
		/// Gets the number of rows in the DataSource that match the specified whereClause.
		/// This method is only provided as a workaround for the ObjectDataSource's need to 
		/// execute another method to discover the total count instead of using another param, like our out param.  
		/// This method should be avoided if using the ObjectDataSource or another method.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <returns>Returns the number of rows.</returns>
		public int GetTotalItems(string whereClause, out int totalCount)
		{
			GetPaged(whereClause, null, 0, defaultMaxRecords, out totalCount);
			return totalCount;
		}
		#endregion GetPaged	

		#region Find Methods

		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <returns>Returns a typed collection of <c>ViewKcqUteKhoiLuongQuyDoi2</c> objects.</returns>
		public virtual VList<ViewKcqUteKhoiLuongQuyDoi2> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewKcqUteKhoiLuongQuyDoi2</c> objects.</returns>
		public virtual VList<ViewKcqUteKhoiLuongQuyDoi2> Find(IFilterParameterCollection parameters, string orderBy)
		{
			int count = 0;
			return Find(parameters, orderBy, 0, defaultMaxRecords, out count);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <returns>Returns a typed collection of <c>ViewKcqUteKhoiLuongQuyDoi2</c> objects.</returns>
		public override VList<ViewKcqUteKhoiLuongQuyDoi2> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewKcqUteKhoiLuongQuyDoi2> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKcqUteKhoiLuongQuyDoi2Provider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen) 
					transactionManager.Rollback();
				
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
			}
			
			return list;
		}
		
		#endregion Find Methods
		
		#region Custom Methods
		
		#region cust_View_KcqUte_KhoiLuongQuyDoi2_GetByNamHocHocKyDot
		/// <summary>
		///	This method wrap the 'cust_View_KcqUte_KhoiLuongQuyDoi2_GetByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewKcqUteKhoiLuongQuyDoi2}"/> instance.</returns>
		public virtual VList<ViewKcqUteKhoiLuongQuyDoi2> GetByNamHocHocKyDot(System.String namHoc, System.String hocKy, System.String dot)
		{
			return GetByNamHocHocKyDot( namHoc, hocKy, dot, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_KcqUte_KhoiLuongQuyDoi2_GetByNamHocHocKyDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewKcqUteKhoiLuongQuyDoi2}"/> instance.</returns>
		public virtual VList<ViewKcqUteKhoiLuongQuyDoi2> GetByNamHocHocKyDot(System.String namHoc, System.String hocKy, System.String dot, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNamHocHocKyDot");
			
		
			VList<ViewKcqUteKhoiLuongQuyDoi2> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewKcqUteKhoiLuongQuyDoi2Provider.GetByNamHocHocKyDot(transactionManager, start, pageLength , namHoc, hocKy, dot);
	        
            	
			}
            catch (Exception exc)
            {
				//if open, rollback
                if (transactionManager != null && transactionManager.IsOpen)
                        transactionManager.Rollback();
                    
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
            }
			
			return result;
		}
		#endregion 
		
		#region cust_View_KcqUte_KhoiLuongQuyDoi2_GetByNamHocHocKy
		/// <summary>
		///	This method wrap the 'cust_View_KcqUte_KhoiLuongQuyDoi2_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewKcqUteKhoiLuongQuyDoi2}"/> instance.</returns>
		public virtual VList<ViewKcqUteKhoiLuongQuyDoi2> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy( namHoc, hocKy, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_KcqUte_KhoiLuongQuyDoi2_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewKcqUteKhoiLuongQuyDoi2}"/> instance.</returns>
		public virtual VList<ViewKcqUteKhoiLuongQuyDoi2> GetByNamHocHocKy(System.String namHoc, System.String hocKy, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNamHocHocKy");
			
		
			VList<ViewKcqUteKhoiLuongQuyDoi2> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewKcqUteKhoiLuongQuyDoi2Provider.GetByNamHocHocKy(transactionManager, start, pageLength , namHoc, hocKy);
	        
            	
			}
            catch (Exception exc)
            {
				//if open, rollback
                if (transactionManager != null && transactionManager.IsOpen)
                        transactionManager.Rollback();
                    
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
            }
			
			return result;
		}
		#endregion 
		#endregion
		
		#endregion Data Access Methods
		
	
	}//End Class
} // end namespace



