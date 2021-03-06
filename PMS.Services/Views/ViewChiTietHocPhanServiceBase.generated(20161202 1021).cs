﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewChiTietHocPhan.cs instead.
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
	/// An object representation of the 'View_ChiTiet_HocPhan' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewChiTietHocPhan.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewChiTietHocPhan"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewChiTietHocPhanServiceBase : ServiceViewBase<ViewChiTietHocPhan>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewChiTietHocPhan"/> instance .
		///</summary>
		public ViewChiTietHocPhanServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewChiTietHocPhan"/> instance.
		///</summary>
		///<param name="_maLichHoc"></param>
		///<param name="_maGiangVien"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_soTinChi"></param>
		///<param name="_soLuong"></param>
		///<param name="_maLoaiHocPhan"></param>
		///<param name="_loaiHocPhan"></param>
		///<param name="_nam"></param>
		///<param name="_tuan"></param>
		///<param name="_maPhong"></param>
		///<param name="_maToaNha"></param>
		///<param name="_donViTinh"></param>
		///<param name="_maCoSo"></param>
		///<param name="_maBuoiHoc"></param>
		///<param name="_maLop"></param>
		///<param name="_tietBatDau"></param>
		///<param name="_soTiet"></param>
		///<param name="_loaiHocKy"></param>
		///<param name="_heSoCoSo"></param>
		///<param name="_heSoHocKy"></param>
		///<param name="_tinhTrang"></param>
		public static ViewChiTietHocPhan CreateViewChiTietHocPhan(System.Int32 _maLichHoc, System.String _maGiangVien, System.String _maLopHocPhan, System.String _namHoc, System.String _hocKy, System.String _maMonHoc, System.String _tenMonHoc, System.Decimal? _soTinChi, System.Int32? _soLuong, System.Byte _maLoaiHocPhan, System.String _loaiHocPhan, System.Int32? _nam, System.Int32? _tuan, System.String _maPhong, System.String _maToaNha, System.String _donViTinh, System.String _maCoSo, System.Int32? _maBuoiHoc, System.String _maLop, System.Int32? _tietBatDau, System.Int32? _soTiet, System.Byte? _loaiHocKy, System.Decimal _heSoCoSo, System.Decimal _heSoHocKy, System.Int32 _tinhTrang)
		{
			ViewChiTietHocPhan newEntityViewChiTietHocPhan = new ViewChiTietHocPhan();
			newEntityViewChiTietHocPhan.MaLichHoc  = _maLichHoc;
			newEntityViewChiTietHocPhan.MaGiangVien  = _maGiangVien;
			newEntityViewChiTietHocPhan.MaLopHocPhan  = _maLopHocPhan;
			newEntityViewChiTietHocPhan.NamHoc  = _namHoc;
			newEntityViewChiTietHocPhan.HocKy  = _hocKy;
			newEntityViewChiTietHocPhan.MaMonHoc  = _maMonHoc;
			newEntityViewChiTietHocPhan.TenMonHoc  = _tenMonHoc;
			newEntityViewChiTietHocPhan.SoTinChi  = _soTinChi;
			newEntityViewChiTietHocPhan.SoLuong  = _soLuong;
			newEntityViewChiTietHocPhan.MaLoaiHocPhan  = _maLoaiHocPhan;
			newEntityViewChiTietHocPhan.LoaiHocPhan  = _loaiHocPhan;
			newEntityViewChiTietHocPhan.Nam  = _nam;
			newEntityViewChiTietHocPhan.Tuan  = _tuan;
			newEntityViewChiTietHocPhan.MaPhong  = _maPhong;
			newEntityViewChiTietHocPhan.MaToaNha  = _maToaNha;
			newEntityViewChiTietHocPhan.DonViTinh  = _donViTinh;
			newEntityViewChiTietHocPhan.MaCoSo  = _maCoSo;
			newEntityViewChiTietHocPhan.MaBuoiHoc  = _maBuoiHoc;
			newEntityViewChiTietHocPhan.MaLop  = _maLop;
			newEntityViewChiTietHocPhan.TietBatDau  = _tietBatDau;
			newEntityViewChiTietHocPhan.SoTiet  = _soTiet;
			newEntityViewChiTietHocPhan.LoaiHocKy  = _loaiHocKy;
			newEntityViewChiTietHocPhan.HeSoCoSo  = _heSoCoSo;
			newEntityViewChiTietHocPhan.HeSoHocKy  = _heSoHocKy;
			newEntityViewChiTietHocPhan.TinhTrang  = _tinhTrang;
			return newEntityViewChiTietHocPhan;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewChiTietHocPhan> securityContext = new SecurityContext<ViewChiTietHocPhan>();
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
		public override VList<ViewChiTietHocPhan> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{ViewChiTietHocPhan} of <c>ViewChiTietHocPhan</c> objects.</returns>
		public override VList<ViewChiTietHocPhan> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewChiTietHocPhan> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewChiTietHocPhanProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="ViewChiTietHocPhan" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewChiTietHocPhan> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewChiTietHocPhan" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewChiTietHocPhan}"/> </returns>
		public override VList<ViewChiTietHocPhan> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewChiTietHocPhan> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewChiTietHocPhanProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{ViewChiTietHocPhan}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewChiTietHocPhan</c> objects.</returns>
		public virtual VList<ViewChiTietHocPhan> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewChiTietHocPhan}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewChiTietHocPhan</c> objects.</returns>
		public virtual VList<ViewChiTietHocPhan> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewChiTietHocPhan}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewChiTietHocPhan</c> objects.</returns>
		public override VList<ViewChiTietHocPhan> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewChiTietHocPhan> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewChiTietHocPhanProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>ViewChiTietHocPhan</c> objects.</returns>
		public virtual VList<ViewChiTietHocPhan> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewChiTietHocPhan</c> objects.</returns>
		public virtual VList<ViewChiTietHocPhan> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>ViewChiTietHocPhan</c> objects.</returns>
		public override VList<ViewChiTietHocPhan> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewChiTietHocPhan> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewChiTietHocPhanProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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
		
		#region cust_View_ChiTiet_HocPhan_GetByMaGiangVienMaLopHocPhanMaLop
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_HocPhan_GetByMaGiangVienMaLopHocPhanMaLop' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewChiTietHocPhan}"/> instance.</returns>
		public virtual VList<ViewChiTietHocPhan> GetByMaGiangVienMaLopHocPhanMaLop(System.String maGiangVien, System.String maLopHocPhan, System.String maLop)
		{
			return GetByMaGiangVienMaLopHocPhanMaLop( maGiangVien, maLopHocPhan, maLop, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_HocPhan_GetByMaGiangVienMaLopHocPhanMaLop' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewChiTietHocPhan}"/> instance.</returns>
		public virtual VList<ViewChiTietHocPhan> GetByMaGiangVienMaLopHocPhanMaLop(System.String maGiangVien, System.String maLopHocPhan, System.String maLop, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByMaGiangVienMaLopHocPhanMaLop");
			
		
			VList<ViewChiTietHocPhan> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewChiTietHocPhanProvider.GetByMaGiangVienMaLopHocPhanMaLop(transactionManager, start, pageLength , maGiangVien, maLopHocPhan, maLop);
	        
            	
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
		
		#region cust_View_ChiTiet_HocPhan_GetByMaLopHocPhan
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_HocPhan_GetByMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewChiTietHocPhan}"/> instance.</returns>
		public virtual VList<ViewChiTietHocPhan> GetByMaLopHocPhan(System.String maLopHocPhan)
		{
			return GetByMaLopHocPhan( maLopHocPhan, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_ChiTiet_HocPhan_GetByMaLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList{ViewChiTietHocPhan}"/> instance.</returns>
		public virtual VList<ViewChiTietHocPhan> GetByMaLopHocPhan(System.String maLopHocPhan, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByMaLopHocPhan");
			
		
			VList<ViewChiTietHocPhan> result = null; 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				result = dataProvider.ViewChiTietHocPhanProvider.GetByMaLopHocPhan(transactionManager, start, pageLength , maLopHocPhan);
	        
            	
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



