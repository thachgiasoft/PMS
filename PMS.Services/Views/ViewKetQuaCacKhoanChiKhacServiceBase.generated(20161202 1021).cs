﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewKetQuaCacKhoanChiKhac.cs instead.
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
	/// An object representation of the 'View_KetQuaCacKhoanChiKhac' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewKetQuaCacKhoanChiKhac.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewKetQuaCacKhoanChiKhac"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewKetQuaCacKhoanChiKhacServiceBase : ServiceViewBase<ViewKetQuaCacKhoanChiKhac>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewKetQuaCacKhoanChiKhac"/> instance .
		///</summary>
		public ViewKetQuaCacKhoanChiKhacServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewKetQuaCacKhoanChiKhac"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_hoTen"></param>
		///<param name="_gioiTinh"></param>
		///<param name="_ngaySinh"></param>
		///<param name="_maHocHam"></param>
		///<param name="_maHocVi"></param>
		///<param name="_maLoaiGiangVien"></param>
		///<param name="_tenHocHam"></param>
		///<param name="_tenHocVi"></param>
		///<param name="_tenLoaiGiangVien"></param>
		///<param name="_maDonVi"></param>
		///<param name="_tenDonVi"></param>
		///<param name="_lop"></param>
		///<param name="_maSo"></param>
		///<param name="_ngay"></param>
		///<param name="_noiDung"></param>
		///<param name="_heSo"></param>
		///<param name="_soTiet"></param>
		///<param name="_tienMotTiet"></param>
		///<param name="_thanhTien"></param>
		///<param name="_phiCongTac"></param>
		///<param name="_tienGiangNgoaiGio"></param>
		///<param name="_tongThanhTien"></param>
		///<param name="_id"></param>
		public static ViewKetQuaCacKhoanChiKhac CreateViewKetQuaCacKhoanChiKhac(System.Int32 _maGiangVien, System.String _maQuanLy, System.String _ho, System.String _ten, System.String _hoTen, System.String _gioiTinh, System.String _ngaySinh, System.Int32? _maHocHam, System.Int32? _maHocVi, System.Int32? _maLoaiGiangVien, System.String _tenHocHam, System.String _tenHocVi, System.String _tenLoaiGiangVien, System.String _maDonVi, System.String _tenDonVi, System.String _lop, System.String _maSo, System.DateTime? _ngay, System.String _noiDung, System.Decimal? _heSo, System.Decimal? _soTiet, System.Decimal? _tienMotTiet, System.Decimal? _thanhTien, System.Decimal? _phiCongTac, System.Decimal? _tienGiangNgoaiGio, System.Decimal? _tongThanhTien, System.Int32 _id)
		{
			ViewKetQuaCacKhoanChiKhac newEntityViewKetQuaCacKhoanChiKhac = new ViewKetQuaCacKhoanChiKhac();
			newEntityViewKetQuaCacKhoanChiKhac.MaGiangVien  = _maGiangVien;
			newEntityViewKetQuaCacKhoanChiKhac.MaQuanLy  = _maQuanLy;
			newEntityViewKetQuaCacKhoanChiKhac.Ho  = _ho;
			newEntityViewKetQuaCacKhoanChiKhac.Ten  = _ten;
			newEntityViewKetQuaCacKhoanChiKhac.HoTen  = _hoTen;
			newEntityViewKetQuaCacKhoanChiKhac.GioiTinh  = _gioiTinh;
			newEntityViewKetQuaCacKhoanChiKhac.NgaySinh  = _ngaySinh;
			newEntityViewKetQuaCacKhoanChiKhac.MaHocHam  = _maHocHam;
			newEntityViewKetQuaCacKhoanChiKhac.MaHocVi  = _maHocVi;
			newEntityViewKetQuaCacKhoanChiKhac.MaLoaiGiangVien  = _maLoaiGiangVien;
			newEntityViewKetQuaCacKhoanChiKhac.TenHocHam  = _tenHocHam;
			newEntityViewKetQuaCacKhoanChiKhac.TenHocVi  = _tenHocVi;
			newEntityViewKetQuaCacKhoanChiKhac.TenLoaiGiangVien  = _tenLoaiGiangVien;
			newEntityViewKetQuaCacKhoanChiKhac.MaDonVi  = _maDonVi;
			newEntityViewKetQuaCacKhoanChiKhac.TenDonVi  = _tenDonVi;
			newEntityViewKetQuaCacKhoanChiKhac.Lop  = _lop;
			newEntityViewKetQuaCacKhoanChiKhac.MaSo  = _maSo;
			newEntityViewKetQuaCacKhoanChiKhac.Ngay  = _ngay;
			newEntityViewKetQuaCacKhoanChiKhac.NoiDung  = _noiDung;
			newEntityViewKetQuaCacKhoanChiKhac.HeSo  = _heSo;
			newEntityViewKetQuaCacKhoanChiKhac.SoTiet  = _soTiet;
			newEntityViewKetQuaCacKhoanChiKhac.TienMotTiet  = _tienMotTiet;
			newEntityViewKetQuaCacKhoanChiKhac.ThanhTien  = _thanhTien;
			newEntityViewKetQuaCacKhoanChiKhac.PhiCongTac  = _phiCongTac;
			newEntityViewKetQuaCacKhoanChiKhac.TienGiangNgoaiGio  = _tienGiangNgoaiGio;
			newEntityViewKetQuaCacKhoanChiKhac.TongThanhTien  = _tongThanhTien;
			newEntityViewKetQuaCacKhoanChiKhac.Id  = _id;
			return newEntityViewKetQuaCacKhoanChiKhac;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewKetQuaCacKhoanChiKhac> securityContext = new SecurityContext<ViewKetQuaCacKhoanChiKhac>();
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
		public override VList<ViewKetQuaCacKhoanChiKhac> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{ViewKetQuaCacKhoanChiKhac} of <c>ViewKetQuaCacKhoanChiKhac</c> objects.</returns>
		public override VList<ViewKetQuaCacKhoanChiKhac> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewKetQuaCacKhoanChiKhac> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKetQuaCacKhoanChiKhacProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="ViewKetQuaCacKhoanChiKhac" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewKetQuaCacKhoanChiKhac> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewKetQuaCacKhoanChiKhac" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewKetQuaCacKhoanChiKhac}"/> </returns>
		public override VList<ViewKetQuaCacKhoanChiKhac> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewKetQuaCacKhoanChiKhac> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewKetQuaCacKhoanChiKhacProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{ViewKetQuaCacKhoanChiKhac}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKetQuaCacKhoanChiKhac</c> objects.</returns>
		public virtual VList<ViewKetQuaCacKhoanChiKhac> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewKetQuaCacKhoanChiKhac}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKetQuaCacKhoanChiKhac</c> objects.</returns>
		public virtual VList<ViewKetQuaCacKhoanChiKhac> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewKetQuaCacKhoanChiKhac}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewKetQuaCacKhoanChiKhac</c> objects.</returns>
		public override VList<ViewKetQuaCacKhoanChiKhac> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewKetQuaCacKhoanChiKhac> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKetQuaCacKhoanChiKhacProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>ViewKetQuaCacKhoanChiKhac</c> objects.</returns>
		public virtual VList<ViewKetQuaCacKhoanChiKhac> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewKetQuaCacKhoanChiKhac</c> objects.</returns>
		public virtual VList<ViewKetQuaCacKhoanChiKhac> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>ViewKetQuaCacKhoanChiKhac</c> objects.</returns>
		public override VList<ViewKetQuaCacKhoanChiKhac> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewKetQuaCacKhoanChiKhac> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewKetQuaCacKhoanChiKhacProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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
		
		#region cust_View_KetQuaCacKhoanChiKhac_GetByNgay
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaCacKhoanChiKhac_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewKetQuaCacKhoanChiKhac}"/> instance.</returns>
		public virtual VList<ViewKetQuaCacKhoanChiKhac> GetByNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay( tuNgay, denNgay, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_KetQuaCacKhoanChiKhac_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewKetQuaCacKhoanChiKhac}"/> instance.</returns>
		public virtual VList<ViewKetQuaCacKhoanChiKhac> GetByNgay(System.DateTime tuNgay, System.DateTime denNgay, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNgay");
			
		
			VList<ViewKetQuaCacKhoanChiKhac> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewKetQuaCacKhoanChiKhacProvider.GetByNgay(transactionManager, start, pageLength , tuNgay, denNgay);
	        
            	
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



