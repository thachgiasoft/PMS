﻿
/*
	File generated by NetTiers templates [www.NetTiers.com]
	Important: Do not modify this file. Edit the file ViewLuongGiangVien.cs instead.
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
	/// An object representation of the 'View_Luong_GiangVien' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewLuongGiangVien.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewLuongGiangVien"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewLuongGiangVienServiceBase : ServiceViewBase<ViewLuongGiangVien>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewLuongGiangVien"/> instance .
		///</summary>
		public ViewLuongGiangVienServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewLuongGiangVien"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_soTaiKhoan"></param>
		///<param name="_maLop"></param>
		///<param name="_tenLop"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_ngayBatDau"></param>
		///<param name="_ngayKetThuc"></param>
		///<param name="_tietQuyDoi"></param>
		///<param name="_siSoLop"></param>
		///<param name="_soTien"></param>
		///<param name="_thanhTien"></param>
		///<param name="_tongTien"></param>
		///<param name="_thueTncn"></param>
		///<param name="_tienThucNhan"></param>
		///<param name="_maBacDaoTao"></param>
		///<param name="_maHeDaoTao"></param>
		///<param name="_maVaiTroGiangDay"></param>
		///<param name="_maLopHocPhan"></param>
		public static ViewLuongGiangVien CreateViewLuongGiangVien(System.Int32 _maGiangVien, System.String _ho, System.String _ten, System.String _soTaiKhoan, System.String _maLop, System.String _tenLop, System.String _maMonHoc, System.String _tenMonHoc, System.DateTime? _ngayBatDau, System.DateTime? _ngayKetThuc, System.Decimal? _tietQuyDoi, System.Int32? _siSoLop, System.Decimal? _soTien, System.Decimal? _thanhTien, System.Decimal? _tongTien, System.Decimal? _thueTncn, System.Decimal? _tienThucNhan, System.String _maBacDaoTao, System.String _maHeDaoTao, System.String _maVaiTroGiangDay, System.String _maLopHocPhan)
		{
			ViewLuongGiangVien newEntityViewLuongGiangVien = new ViewLuongGiangVien();
			newEntityViewLuongGiangVien.MaGiangVien  = _maGiangVien;
			newEntityViewLuongGiangVien.Ho  = _ho;
			newEntityViewLuongGiangVien.Ten  = _ten;
			newEntityViewLuongGiangVien.SoTaiKhoan  = _soTaiKhoan;
			newEntityViewLuongGiangVien.MaLop  = _maLop;
			newEntityViewLuongGiangVien.TenLop  = _tenLop;
			newEntityViewLuongGiangVien.MaMonHoc  = _maMonHoc;
			newEntityViewLuongGiangVien.TenMonHoc  = _tenMonHoc;
			newEntityViewLuongGiangVien.NgayBatDau  = _ngayBatDau;
			newEntityViewLuongGiangVien.NgayKetThuc  = _ngayKetThuc;
			newEntityViewLuongGiangVien.TietQuyDoi  = _tietQuyDoi;
			newEntityViewLuongGiangVien.SiSoLop  = _siSoLop;
			newEntityViewLuongGiangVien.SoTien  = _soTien;
			newEntityViewLuongGiangVien.ThanhTien  = _thanhTien;
			newEntityViewLuongGiangVien.TongTien  = _tongTien;
			newEntityViewLuongGiangVien.ThueTncn  = _thueTncn;
			newEntityViewLuongGiangVien.TienThucNhan  = _tienThucNhan;
			newEntityViewLuongGiangVien.MaBacDaoTao  = _maBacDaoTao;
			newEntityViewLuongGiangVien.MaHeDaoTao  = _maHeDaoTao;
			newEntityViewLuongGiangVien.MaVaiTroGiangDay  = _maVaiTroGiangDay;
			newEntityViewLuongGiangVien.MaLopHocPhan  = _maLopHocPhan;
			return newEntityViewLuongGiangVien;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewLuongGiangVien> securityContext = new SecurityContext<ViewLuongGiangVien>();
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
		public override VList<ViewLuongGiangVien> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{ViewLuongGiangVien} of <c>ViewLuongGiangVien</c> objects.</returns>
		public override VList<ViewLuongGiangVien> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewLuongGiangVien> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewLuongGiangVienProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="ViewLuongGiangVien" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewLuongGiangVien> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewLuongGiangVien" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewLuongGiangVien}"/> </returns>
		public override VList<ViewLuongGiangVien> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewLuongGiangVien> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewLuongGiangVienProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{ViewLuongGiangVien}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewLuongGiangVien</c> objects.</returns>
		public virtual VList<ViewLuongGiangVien> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewLuongGiangVien}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewLuongGiangVien</c> objects.</returns>
		public virtual VList<ViewLuongGiangVien> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewLuongGiangVien}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewLuongGiangVien</c> objects.</returns>
		public override VList<ViewLuongGiangVien> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewLuongGiangVien> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewLuongGiangVienProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>ViewLuongGiangVien</c> objects.</returns>
		public virtual VList<ViewLuongGiangVien> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewLuongGiangVien</c> objects.</returns>
		public virtual VList<ViewLuongGiangVien> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>ViewLuongGiangVien</c> objects.</returns>
		public override VList<ViewLuongGiangVien> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewLuongGiangVien> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewLuongGiangVienProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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
		
		#region cust_View_Luong_GiangVien_GetByNgay1
		/// <summary>
		///	This method wrap the 'cust_View_Luong_GiangVien_GetByNgay1' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewLuongGiangVien}"/> instance.</returns>
		public virtual VList<ViewLuongGiangVien> GetByNgay1(System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByNgay1( maBacDaoTao, maHeDaoTao, tuNgay, denNgay, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_Luong_GiangVien_GetByNgay1' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewLuongGiangVien}"/> instance.</returns>
		public virtual VList<ViewLuongGiangVien> GetByNgay1(System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNgay1");
			
		
			VList<ViewLuongGiangVien> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewLuongGiangVienProvider.GetByNgay1(transactionManager, start, pageLength , maBacDaoTao, maHeDaoTao, tuNgay, denNgay);
	        
            	
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
		
		#region cust_View_Luong_GiangVien_TheoNgay_GetByNgay
		/// <summary>
		///	This method wrap the 'cust_View_Luong_GiangVien_TheoNgay_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public virtual IDataReader TheoNgay_GetByNgay(System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return TheoNgay_GetByNgay( maBacDaoTao, maHeDaoTao, tuNgay, denNgay, 0, defaultMaxRecords );
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
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public virtual IDataReader TheoNgay_GetByNgay(System.String maBacDaoTao, System.String maHeDaoTao, System.DateTime tuNgay, System.DateTime denNgay, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("TheoNgay_GetByNgay");
			
		
			IDataReader result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewLuongGiangVienProvider.TheoNgay_GetByNgay(transactionManager, start, pageLength , maBacDaoTao, maHeDaoTao, tuNgay, denNgay);
	        
            	
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



