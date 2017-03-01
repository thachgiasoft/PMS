﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewThanhTraGiangDay.cs instead.
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
	/// An object representation of the 'View_ThanhTraGiangDay' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewThanhTraGiangDay.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewThanhTraGiangDay"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewThanhTraGiangDayServiceBase : ServiceViewBase<ViewThanhTraGiangDay>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewThanhTraGiangDay"/> instance .
		///</summary>
		public ViewThanhTraGiangDayServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewThanhTraGiangDay"/> instance.
		///</summary>
		///<param name="_maHienThi"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_khoa"></param>
		///<param name="_loaiGiangVien"></param>
		///<param name="_tenHocPhan"></param>
		///<param name="_tinhHinhGhiNhan"></param>
		///<param name="_ngay"></param>
		///<param name="_tiet"></param>
		///<param name="_lop"></param>
		///<param name="_phong"></param>
		///<param name="_thoiDiemGhiNhan"></param>
		///<param name="_lyDo"></param>
		///<param name="_ghiChu"></param>
		///<param name="_maHinhThucViPham"></param>
		///<param name="_daBaoSuaTkb"></param>
		///<param name="_hoTen"></param>
		public static ViewThanhTraGiangDay CreateViewThanhTraGiangDay(System.String _maHienThi, System.String _maQuanLy, System.String _khoa, System.String _loaiGiangVien, System.String _tenHocPhan, System.String _tinhHinhGhiNhan, System.DateTime? _ngay, System.String _tiet, System.String _lop, System.String _phong, System.String _thoiDiemGhiNhan, System.String _lyDo, System.String _ghiChu, System.Guid? _maHinhThucViPham, System.Boolean? _daBaoSuaTkb, System.String _hoTen)
		{
			ViewThanhTraGiangDay newEntityViewThanhTraGiangDay = new ViewThanhTraGiangDay();
			newEntityViewThanhTraGiangDay.MaHienThi  = _maHienThi;
			newEntityViewThanhTraGiangDay.MaQuanLy  = _maQuanLy;
			newEntityViewThanhTraGiangDay.Khoa  = _khoa;
			newEntityViewThanhTraGiangDay.LoaiGiangVien  = _loaiGiangVien;
			newEntityViewThanhTraGiangDay.TenHocPhan  = _tenHocPhan;
			newEntityViewThanhTraGiangDay.TinhHinhGhiNhan  = _tinhHinhGhiNhan;
			newEntityViewThanhTraGiangDay.Ngay  = _ngay;
			newEntityViewThanhTraGiangDay.Tiet  = _tiet;
			newEntityViewThanhTraGiangDay.Lop  = _lop;
			newEntityViewThanhTraGiangDay.Phong  = _phong;
			newEntityViewThanhTraGiangDay.ThoiDiemGhiNhan  = _thoiDiemGhiNhan;
			newEntityViewThanhTraGiangDay.LyDo  = _lyDo;
			newEntityViewThanhTraGiangDay.GhiChu  = _ghiChu;
			newEntityViewThanhTraGiangDay.MaHinhThucViPham  = _maHinhThucViPham;
			newEntityViewThanhTraGiangDay.DaBaoSuaTkb  = _daBaoSuaTkb;
			newEntityViewThanhTraGiangDay.HoTen  = _hoTen;
			return newEntityViewThanhTraGiangDay;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewThanhTraGiangDay> securityContext = new SecurityContext<ViewThanhTraGiangDay>();
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
		public override VList<ViewThanhTraGiangDay> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{ViewThanhTraGiangDay} of <c>ViewThanhTraGiangDay</c> objects.</returns>
		public override VList<ViewThanhTraGiangDay> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewThanhTraGiangDay> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewThanhTraGiangDayProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="ViewThanhTraGiangDay" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewThanhTraGiangDay> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewThanhTraGiangDay" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewThanhTraGiangDay}"/> </returns>
		public override VList<ViewThanhTraGiangDay> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewThanhTraGiangDay> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewThanhTraGiangDayProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{ViewThanhTraGiangDay}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewThanhTraGiangDay</c> objects.</returns>
		public virtual VList<ViewThanhTraGiangDay> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewThanhTraGiangDay}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewThanhTraGiangDay</c> objects.</returns>
		public virtual VList<ViewThanhTraGiangDay> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewThanhTraGiangDay}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewThanhTraGiangDay</c> objects.</returns>
		public override VList<ViewThanhTraGiangDay> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewThanhTraGiangDay> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewThanhTraGiangDayProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>ViewThanhTraGiangDay</c> objects.</returns>
		public virtual VList<ViewThanhTraGiangDay> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewThanhTraGiangDay</c> objects.</returns>
		public virtual VList<ViewThanhTraGiangDay> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>ViewThanhTraGiangDay</c> objects.</returns>
		public override VList<ViewThanhTraGiangDay> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewThanhTraGiangDay> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewThanhTraGiangDayProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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
		
		#region cust_View_ThanhTraGiangDay_GetByTuNgayDenNgayMaDonVi
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraGiangDay_GetByTuNgayDenNgayMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewThanhTraGiangDay}"/> instance.</returns>
		public virtual VList<ViewThanhTraGiangDay> GetByTuNgayDenNgayMaDonVi(System.DateTime tuNgay, System.DateTime denNgay, System.String maBoMon)
		{
			return GetByTuNgayDenNgayMaDonVi( tuNgay, denNgay, maBoMon, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraGiangDay_GetByTuNgayDenNgayMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maBoMon"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewThanhTraGiangDay}"/> instance.</returns>
		public virtual VList<ViewThanhTraGiangDay> GetByTuNgayDenNgayMaDonVi(System.DateTime tuNgay, System.DateTime denNgay, System.String maBoMon, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByTuNgayDenNgayMaDonVi");
			
		
			VList<ViewThanhTraGiangDay> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewThanhTraGiangDayProvider.GetByTuNgayDenNgayMaDonVi(transactionManager, start, pageLength , tuNgay, denNgay, maBoMon);
	        
            	
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



