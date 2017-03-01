﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewKcqLietKeKhoiLuongGiangDayChiTiet2.cs instead.
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
	/// An object representation of the 'View_KcqLietKeKhoiLuongGiangDayChiTiet2' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewKcqLietKeKhoiLuongGiangDayChiTiet2.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewKcqLietKeKhoiLuongGiangDayChiTiet2ServiceBase : ServiceViewBase<ViewKcqLietKeKhoiLuongGiangDayChiTiet2>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2"/> instance .
		///</summary>
		public ViewKcqLietKeKhoiLuongGiangDayChiTiet2ServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2"/> instance.
		///</summary>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_hoTen"></param>
		///<param name="_maHocHam"></param>
		///<param name="_maHocVi"></param>
		///<param name="_maLoaiGiangVien"></param>
		///<param name="_maDonVi"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_loai"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_nhom"></param>
		///<param name="_maLop"></param>
		///<param name="_siSo"></param>
		///<param name="_soTiet"></param>
		///<param name="_tietChuNhat"></param>
		///<param name="_lopClc"></param>
		///<param name="_heSoLopDong"></param>
		///<param name="_heSoHocKy"></param>
		///<param name="_donGia"></param>
		///<param name="_tongThanhTien"></param>
		///<param name="_tietQuyDoi"></param>
		///<param name="_phanLoai"></param>
		///<param name="_soGioThucGiangTrenLop"></param>
		///<param name="_soGioChuanTinhThem"></param>
		///<param name="_maDiaDiem"></param>
		///<param name="_tenDiaDiem"></param>
		///<param name="_donGiaDiaDiem"></param>
		///<param name="_tienXeDiaDiem"></param>
		///<param name="_heSoDiaDiem"></param>
		///<param name="_soTinChi"></param>
		///<param name="_tenBoMon"></param>
		public static ViewKcqLietKeKhoiLuongGiangDayChiTiet2 CreateViewKcqLietKeKhoiLuongGiangDayChiTiet2(System.String _maQuanLy, System.String _ho, System.String _ten, System.String _hoTen, System.Int32? _maHocHam, System.Int32? _maHocVi, System.Int32? _maLoaiGiangVien, System.String _maDonVi, System.String _namHoc, System.String _hocKy, System.String _loai, System.String _maMonHoc, System.String _tenMonHoc, System.String _nhom, System.String _maLop, System.Int32? _siSo, System.Decimal? _soTiet, System.Int32? _tietChuNhat, System.Boolean? _lopClc, System.Decimal? _heSoLopDong, System.Decimal? _heSoHocKy, System.Decimal? _donGia, System.Decimal? _tongThanhTien, System.Decimal? _tietQuyDoi, System.String _phanLoai, System.Decimal? _soGioThucGiangTrenLop, System.Decimal? _soGioChuanTinhThem, System.String _maDiaDiem, System.String _tenDiaDiem, System.Decimal? _donGiaDiaDiem, System.Decimal? _tienXeDiaDiem, System.Decimal? _heSoDiaDiem, System.Decimal? _soTinChi, System.String _tenBoMon)
		{
			ViewKcqLietKeKhoiLuongGiangDayChiTiet2 newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2 = new ViewKcqLietKeKhoiLuongGiangDayChiTiet2();
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.MaQuanLy  = _maQuanLy;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.Ho  = _ho;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.Ten  = _ten;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.HoTen  = _hoTen;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.MaHocHam  = _maHocHam;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.MaHocVi  = _maHocVi;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.MaLoaiGiangVien  = _maLoaiGiangVien;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.MaDonVi  = _maDonVi;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.NamHoc  = _namHoc;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.HocKy  = _hocKy;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.Loai  = _loai;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.MaMonHoc  = _maMonHoc;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.TenMonHoc  = _tenMonHoc;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.Nhom  = _nhom;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.MaLop  = _maLop;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.SiSo  = _siSo;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.SoTiet  = _soTiet;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.TietChuNhat  = _tietChuNhat;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.LopClc  = _lopClc;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.HeSoLopDong  = _heSoLopDong;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.HeSoHocKy  = _heSoHocKy;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.DonGia  = _donGia;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.TongThanhTien  = _tongThanhTien;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.TietQuyDoi  = _tietQuyDoi;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.PhanLoai  = _phanLoai;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.SoGioThucGiangTrenLop  = _soGioThucGiangTrenLop;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.SoGioChuanTinhThem  = _soGioChuanTinhThem;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.MaDiaDiem  = _maDiaDiem;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.TenDiaDiem  = _tenDiaDiem;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.DonGiaDiaDiem  = _donGiaDiaDiem;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.TienXeDiaDiem  = _tienXeDiaDiem;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.HeSoDiaDiem  = _heSoDiaDiem;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.SoTinChi  = _soTinChi;
			newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2.TenBoMon  = _tenBoMon;
			return newEntityViewKcqLietKeKhoiLuongGiangDayChiTiet2;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> securityContext = new SecurityContext<ViewKcqLietKeKhoiLuongGiangDayChiTiet2>();
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
		public override VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{ViewKcqLietKeKhoiLuongGiangDayChiTiet2} of <c>ViewKcqLietKeKhoiLuongGiangDayChiTiet2</c> objects.</returns>
		public override VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewKcqLietKeKhoiLuongGiangDayChiTiet2}"/> </returns>
		public override VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{ViewKcqLietKeKhoiLuongGiangDayChiTiet2}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKcqLietKeKhoiLuongGiangDayChiTiet2</c> objects.</returns>
		public virtual VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewKcqLietKeKhoiLuongGiangDayChiTiet2}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKcqLietKeKhoiLuongGiangDayChiTiet2</c> objects.</returns>
		public virtual VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewKcqLietKeKhoiLuongGiangDayChiTiet2}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKcqLietKeKhoiLuongGiangDayChiTiet2</c> objects.</returns>
		public override VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>ViewKcqLietKeKhoiLuongGiangDayChiTiet2</c> objects.</returns>
		public virtual VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewKcqLietKeKhoiLuongGiangDayChiTiet2</c> objects.</returns>
		public virtual VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>ViewKcqLietKeKhoiLuongGiangDayChiTiet2</c> objects.</returns>
		public override VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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
		
		#region cust_View_KcqLietKeKhoiLuongGiangDayChiTiet2_GetByNamHocHocKy
		/// <summary>
		///	This method wrap the 'cust_View_KcqLietKeKhoiLuongGiangDayChiTiet2_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewKcqLietKeKhoiLuongGiangDayChiTiet2}"/> instance.</returns>
		public virtual VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy( namHoc, hocKy, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_KcqLietKeKhoiLuongGiangDayChiTiet2_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewKcqLietKeKhoiLuongGiangDayChiTiet2}"/> instance.</returns>
		public virtual VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> GetByNamHocHocKy(System.String namHoc, System.String hocKy, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNamHocHocKy");
			
		
			VList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider.GetByNamHocHocKy(transactionManager, start, pageLength , namHoc, hocKy);
	        
            	
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


