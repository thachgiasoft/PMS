﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file VTongHopQuyDoi.cs instead.
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
	/// An object representation of the 'v_TongHop_QuyDoi' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the VTongHopQuyDoi.cs file instead.
	/// All custom implementations should be done in the <see cref="VTongHopQuyDoi"/> class.
	/// </remarks>
	[DataObject]
	public partial class VTongHopQuyDoiServiceBase : ServiceViewBase<VTongHopQuyDoi>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="VTongHopQuyDoi"/> instance .
		///</summary>
		public VTongHopQuyDoiServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="VTongHopQuyDoi"/> instance.
		///</summary>
		///<param name="_maKhoa"></param>
		///<param name="_tenKhoa"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_soTiet1"></param>
		///<param name="_tietDoAn1"></param>
		///<param name="_soTiet2"></param>
		///<param name="_tietDoAn2"></param>
		///<param name="_tietLyThuyet"></param>
		///<param name="_tietThucHanh"></param>
		///<param name="_tietThiNghiem"></param>
		///<param name="_tietThucTap"></param>
		///<param name="_tietDoAn"></param>
		public static VTongHopQuyDoi CreateVTongHopQuyDoi(System.String _maKhoa, System.String _tenKhoa, System.String _namHoc, System.String _hocKy, System.Decimal? _soTiet1, System.Decimal? _tietDoAn1, System.Decimal? _soTiet2, System.Decimal? _tietDoAn2, System.Decimal? _tietLyThuyet, System.Decimal? _tietThucHanh, System.Decimal? _tietThiNghiem, System.Decimal? _tietThucTap, System.Decimal? _tietDoAn)
		{
			VTongHopQuyDoi newEntityVTongHopQuyDoi = new VTongHopQuyDoi();
			newEntityVTongHopQuyDoi.MaKhoa  = _maKhoa;
			newEntityVTongHopQuyDoi.TenKhoa  = _tenKhoa;
			newEntityVTongHopQuyDoi.NamHoc  = _namHoc;
			newEntityVTongHopQuyDoi.HocKy  = _hocKy;
			newEntityVTongHopQuyDoi.SoTiet1  = _soTiet1;
			newEntityVTongHopQuyDoi.TietDoAn1  = _tietDoAn1;
			newEntityVTongHopQuyDoi.SoTiet2  = _soTiet2;
			newEntityVTongHopQuyDoi.TietDoAn2  = _tietDoAn2;
			newEntityVTongHopQuyDoi.TietLyThuyet  = _tietLyThuyet;
			newEntityVTongHopQuyDoi.TietThucHanh  = _tietThucHanh;
			newEntityVTongHopQuyDoi.TietThiNghiem  = _tietThiNghiem;
			newEntityVTongHopQuyDoi.TietThucTap  = _tietThucTap;
			newEntityVTongHopQuyDoi.TietDoAn  = _tietDoAn;
			return newEntityVTongHopQuyDoi;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<VTongHopQuyDoi> securityContext = new SecurityContext<VTongHopQuyDoi>();
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
		public override VList<VTongHopQuyDoi> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{VTongHopQuyDoi} of <c>VTongHopQuyDoi</c> objects.</returns>
		public override VList<VTongHopQuyDoi> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<VTongHopQuyDoi> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.VTongHopQuyDoiProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="VTongHopQuyDoi" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<VTongHopQuyDoi> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="VTongHopQuyDoi" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{VTongHopQuyDoi}"/> </returns>
		public override VList<VTongHopQuyDoi> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<VTongHopQuyDoi> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.VTongHopQuyDoiProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{VTongHopQuyDoi}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>VTongHopQuyDoi</c> objects.</returns>
		public virtual VList<VTongHopQuyDoi> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{VTongHopQuyDoi}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>VTongHopQuyDoi</c> objects.</returns>
		public virtual VList<VTongHopQuyDoi> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{VTongHopQuyDoi}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>VTongHopQuyDoi</c> objects.</returns>
		public override VList<VTongHopQuyDoi> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<VTongHopQuyDoi> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.VTongHopQuyDoiProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>VTongHopQuyDoi</c> objects.</returns>
		public virtual VList<VTongHopQuyDoi> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>VTongHopQuyDoi</c> objects.</returns>
		public virtual VList<VTongHopQuyDoi> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>VTongHopQuyDoi</c> objects.</returns>
		public override VList<VTongHopQuyDoi> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<VTongHopQuyDoi> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.VTongHopQuyDoiProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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
		#endregion
		
		#endregion Data Access Methods
		
	
	}//End Class
} // end namespace



