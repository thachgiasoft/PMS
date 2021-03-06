﻿
/*
	File generated by NetTiers templates [www.NetTiers.com]
	Important: Do not modify this file. Edit the file ViewLuongGiangVienTheoNgay.cs instead.
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
	/// An object representation of the 'View_Luong_GiangVien_TheoNgay' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewLuongGiangVienTheoNgay.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewLuongGiangVienTheoNgay"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewLuongGiangVienTheoNgayServiceBase : ServiceViewBase<ViewLuongGiangVienTheoNgay>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewLuongGiangVienTheoNgay"/> instance .
		///</summary>
		public ViewLuongGiangVienTheoNgayServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewLuongGiangVienTheoNgay"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_soTaiKhoan"></param>
		///<param name="_maLop"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_tenLopHocPhan"></param>
		///<param name="_ngayBatDau"></param>
		///<param name="_ngayKetThuc"></param>
		///<param name="_trongGio"></param>
		///<param name="_ngoaiGio"></param>
		///<param name="_tietQuyDoi"></param>
		///<param name="_siSoLop"></param>
		///<param name="_maBacDaoTao"></param>
		///<param name="_maHeDaoTao"></param>
		///<param name="_maLoaiGiangVien"></param>
		///<param name="_soTien"></param>
		///<param name="_tienTruocThue"></param>
		///<param name="_tienThue"></param>
		///<param name="_tienSauThue"></param>
		///<param name="_ngayDay"></param>
		public static ViewLuongGiangVienTheoNgay CreateViewLuongGiangVienTheoNgay(System.Int32 _maGiangVien, System.String _maQuanLy, System.String _ho, System.String _ten, System.String _soTaiKhoan, System.String _maLop, System.String _maMonHoc, System.String _tenMonHoc, System.String _maLopHocPhan, System.String _tenLopHocPhan, System.String _ngayBatDau, System.String _ngayKetThuc, System.Decimal? _trongGio, System.Decimal? _ngoaiGio, System.Decimal? _tietQuyDoi, System.Int32? _siSoLop, System.String _maBacDaoTao, System.String _maHeDaoTao, System.String _maLoaiGiangVien, System.Decimal? _soTien, System.Decimal? _tienTruocThue, System.Decimal? _tienThue, System.Decimal? _tienSauThue, System.DateTime? _ngayDay)
		{
			ViewLuongGiangVienTheoNgay newEntityViewLuongGiangVienTheoNgay = new ViewLuongGiangVienTheoNgay();
			newEntityViewLuongGiangVienTheoNgay.MaGiangVien  = _maGiangVien;
			newEntityViewLuongGiangVienTheoNgay.MaQuanLy  = _maQuanLy;
			newEntityViewLuongGiangVienTheoNgay.Ho  = _ho;
			newEntityViewLuongGiangVienTheoNgay.Ten  = _ten;
			newEntityViewLuongGiangVienTheoNgay.SoTaiKhoan  = _soTaiKhoan;
			newEntityViewLuongGiangVienTheoNgay.MaLop  = _maLop;
			newEntityViewLuongGiangVienTheoNgay.MaMonHoc  = _maMonHoc;
			newEntityViewLuongGiangVienTheoNgay.TenMonHoc  = _tenMonHoc;
			newEntityViewLuongGiangVienTheoNgay.MaLopHocPhan  = _maLopHocPhan;
			newEntityViewLuongGiangVienTheoNgay.TenLopHocPhan  = _tenLopHocPhan;
			newEntityViewLuongGiangVienTheoNgay.NgayBatDau  = _ngayBatDau;
			newEntityViewLuongGiangVienTheoNgay.NgayKetThuc  = _ngayKetThuc;
			newEntityViewLuongGiangVienTheoNgay.TrongGio  = _trongGio;
			newEntityViewLuongGiangVienTheoNgay.NgoaiGio  = _ngoaiGio;
			newEntityViewLuongGiangVienTheoNgay.TietQuyDoi  = _tietQuyDoi;
			newEntityViewLuongGiangVienTheoNgay.SiSoLop  = _siSoLop;
			newEntityViewLuongGiangVienTheoNgay.MaBacDaoTao  = _maBacDaoTao;
			newEntityViewLuongGiangVienTheoNgay.MaHeDaoTao  = _maHeDaoTao;
			newEntityViewLuongGiangVienTheoNgay.MaLoaiGiangVien  = _maLoaiGiangVien;
			newEntityViewLuongGiangVienTheoNgay.SoTien  = _soTien;
			newEntityViewLuongGiangVienTheoNgay.TienTruocThue  = _tienTruocThue;
			newEntityViewLuongGiangVienTheoNgay.TienThue  = _tienThue;
			newEntityViewLuongGiangVienTheoNgay.TienSauThue  = _tienSauThue;
			newEntityViewLuongGiangVienTheoNgay.NgayDay  = _ngayDay;
			return newEntityViewLuongGiangVienTheoNgay;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewLuongGiangVienTheoNgay> securityContext = new SecurityContext<ViewLuongGiangVienTheoNgay>();
		private static readonly string layerExceptionPolicy = "NoneExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		private static readonly int defaultMaxRecords = 10000;
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
		public override VList<ViewLuongGiangVienTheoNgay> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{ViewLuongGiangVienTheoNgay} of <c>ViewLuongGiangVienTheoNgay</c> objects.</returns>
		public override VList<ViewLuongGiangVienTheoNgay> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewLuongGiangVienTheoNgay> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewLuongGiangVienTheoNgayProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="ViewLuongGiangVienTheoNgay" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewLuongGiangVienTheoNgay> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewLuongGiangVienTheoNgay" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewLuongGiangVienTheoNgay}"/> </returns>
		public override VList<ViewLuongGiangVienTheoNgay> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewLuongGiangVienTheoNgay> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewLuongGiangVienTheoNgayProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{ViewLuongGiangVienTheoNgay}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewLuongGiangVienTheoNgay</c> objects.</returns>
		public virtual VList<ViewLuongGiangVienTheoNgay> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewLuongGiangVienTheoNgay}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewLuongGiangVienTheoNgay</c> objects.</returns>
		public virtual VList<ViewLuongGiangVienTheoNgay> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewLuongGiangVienTheoNgay}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewLuongGiangVienTheoNgay</c> objects.</returns>
		public override VList<ViewLuongGiangVienTheoNgay> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewLuongGiangVienTheoNgay> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewLuongGiangVienTheoNgayProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>ViewLuongGiangVienTheoNgay</c> objects.</returns>
		public virtual VList<ViewLuongGiangVienTheoNgay> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewLuongGiangVienTheoNgay</c> objects.</returns>
		public virtual VList<ViewLuongGiangVienTheoNgay> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>ViewLuongGiangVienTheoNgay</c> objects.</returns>
		public override VList<ViewLuongGiangVienTheoNgay> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewLuongGiangVienTheoNgay> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewLuongGiangVienTheoNgayProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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
		
		#region cust_View_Luong_GiangVien_TheoNgay_GetByNgay
		/// <summary>
		///	This method wrap the 'cust_View_Luong_GiangVien_TheoNgay_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewLuongGiangVienTheoNgay}"/> instance.</returns>
		public virtual VList<ViewLuongGiangVienTheoNgay> GetByNgay(System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay( maBacDaoTao, maHeDaoTao, tuNgay, denNgay, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_Luong_GiangVien_TheoNgay_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewLuongGiangVienTheoNgay}"/> instance.</returns>
		public virtual VList<ViewLuongGiangVienTheoNgay> GetByNgay(System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNgay");
			
		
			VList<ViewLuongGiangVienTheoNgay> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewLuongGiangVienTheoNgayProvider.GetByNgay(transactionManager, start, pageLength , maBacDaoTao, maHeDaoTao, tuNgay, denNgay);
	        
            	
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



