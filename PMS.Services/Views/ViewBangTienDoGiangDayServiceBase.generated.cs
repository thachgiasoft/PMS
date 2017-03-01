﻿
/*
	File generated by NetTiers templates [www.NetTiers.com]
	Important: Do not modify this file. Edit the file ViewBangTienDoGiangDay.cs instead.
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
	/// An object representation of the 'view_BangTienDoGiangDay' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewBangTienDoGiangDay.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewBangTienDoGiangDay"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewBangTienDoGiangDayServiceBase : ServiceViewBase<ViewBangTienDoGiangDay>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewBangTienDoGiangDay"/> instance .
		///</summary>
		public ViewBangTienDoGiangDayServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewBangTienDoGiangDay"/> instance.
		///</summary>
		///<param name="_maLichHoc"></param>
		///<param name="_maGiangVien"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_maLop"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_maLoaiHocPhan"></param>
		///<param name="_loaiHocPhan"></param>
		///<param name="_phanLoai"></param>
		///<param name="_siSoLop"></param>
		///<param name="_trongGio"></param>
		///<param name="_ngoaiGio"></param>
		///<param name="_chatLuongCao"></param>
		///<param name="_nhom"></param>
		///<param name="_soTinChi"></param>
		///<param name="_lyThuyet"></param>
		///<param name="_thucHanh"></param>
		///<param name="_baiTap"></param>
		///<param name="_baiTapLon"></param>
		///<param name="_doAn"></param>
		///<param name="_luanAn"></param>
		///<param name="_tieuLuan"></param>
		///<param name="_thucTap"></param>
		///<param name="_tuan"></param>
		///<param name="_nam"></param>
		///<param name="_ngayBatDau"></param>
		///<param name="_ngayKetThuc"></param>
		///<param name="_maBuoiHoc"></param>
		///<param name="_tenBuoiHoc"></param>
		///<param name="_thoiGianHoc"></param>
		///<param name="_soTiet"></param>
		///<param name="_tietBatDau"></param>
		///<param name="_ngayTao"></param>
		///<param name="_rowIndex"></param>
		public static ViewBangTienDoGiangDay CreateViewBangTienDoGiangDay(System.Int32 _maLichHoc, System.String _maGiangVien, System.String _ho, System.String _ten, System.String _maLopHocPhan, System.String _maLop, System.String _namHoc, System.String _hocKy, System.String _maMonHoc, System.Byte _maLoaiHocPhan, System.String _loaiHocPhan, System.String _phanLoai, System.Int32? _siSoLop, System.Decimal? _trongGio, System.Decimal? _ngoaiGio, System.Decimal? _chatLuongCao, System.String _nhom, System.Decimal _soTinChi, System.Decimal _lyThuyet, System.Decimal _thucHanh, System.Decimal _baiTap, System.Decimal _baiTapLon, System.Decimal _doAn, System.Decimal _luanAn, System.Decimal _tieuLuan, System.Decimal _thucTap, System.Int32? _tuan, System.Int32? _nam, System.DateTime? _ngayBatDau, System.DateTime? _ngayKetThuc, System.Int32? _maBuoiHoc, System.String _tenBuoiHoc, System.String _thoiGianHoc, System.Int32? _soTiet, System.Int32? _tietBatDau, System.DateTime? _ngayTao, System.Int32? _rowIndex)
		{
			ViewBangTienDoGiangDay newEntityViewBangTienDoGiangDay = new ViewBangTienDoGiangDay();
			newEntityViewBangTienDoGiangDay.MaLichHoc  = _maLichHoc;
			newEntityViewBangTienDoGiangDay.MaGiangVien  = _maGiangVien;
			newEntityViewBangTienDoGiangDay.Ho  = _ho;
			newEntityViewBangTienDoGiangDay.Ten  = _ten;
			newEntityViewBangTienDoGiangDay.MaLopHocPhan  = _maLopHocPhan;
			newEntityViewBangTienDoGiangDay.MaLop  = _maLop;
			newEntityViewBangTienDoGiangDay.NamHoc  = _namHoc;
			newEntityViewBangTienDoGiangDay.HocKy  = _hocKy;
			newEntityViewBangTienDoGiangDay.MaMonHoc  = _maMonHoc;
			newEntityViewBangTienDoGiangDay.MaLoaiHocPhan  = _maLoaiHocPhan;
			newEntityViewBangTienDoGiangDay.LoaiHocPhan  = _loaiHocPhan;
			newEntityViewBangTienDoGiangDay.PhanLoai  = _phanLoai;
			newEntityViewBangTienDoGiangDay.SiSoLop  = _siSoLop;
			newEntityViewBangTienDoGiangDay.TrongGio  = _trongGio;
			newEntityViewBangTienDoGiangDay.NgoaiGio  = _ngoaiGio;
			newEntityViewBangTienDoGiangDay.ChatLuongCao  = _chatLuongCao;
			newEntityViewBangTienDoGiangDay.Nhom  = _nhom;
			newEntityViewBangTienDoGiangDay.SoTinChi  = _soTinChi;
			newEntityViewBangTienDoGiangDay.LyThuyet  = _lyThuyet;
			newEntityViewBangTienDoGiangDay.ThucHanh  = _thucHanh;
			newEntityViewBangTienDoGiangDay.BaiTap  = _baiTap;
			newEntityViewBangTienDoGiangDay.BaiTapLon  = _baiTapLon;
			newEntityViewBangTienDoGiangDay.DoAn  = _doAn;
			newEntityViewBangTienDoGiangDay.LuanAn  = _luanAn;
			newEntityViewBangTienDoGiangDay.TieuLuan  = _tieuLuan;
			newEntityViewBangTienDoGiangDay.ThucTap  = _thucTap;
			newEntityViewBangTienDoGiangDay.Tuan  = _tuan;
			newEntityViewBangTienDoGiangDay.Nam  = _nam;
			newEntityViewBangTienDoGiangDay.NgayBatDau  = _ngayBatDau;
			newEntityViewBangTienDoGiangDay.NgayKetThuc  = _ngayKetThuc;
			newEntityViewBangTienDoGiangDay.MaBuoiHoc  = _maBuoiHoc;
			newEntityViewBangTienDoGiangDay.TenBuoiHoc  = _tenBuoiHoc;
			newEntityViewBangTienDoGiangDay.ThoiGianHoc  = _thoiGianHoc;
			newEntityViewBangTienDoGiangDay.SoTiet  = _soTiet;
			newEntityViewBangTienDoGiangDay.TietBatDau  = _tietBatDau;
			newEntityViewBangTienDoGiangDay.NgayTao  = _ngayTao;
			newEntityViewBangTienDoGiangDay.RowIndex  = _rowIndex;
			return newEntityViewBangTienDoGiangDay;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewBangTienDoGiangDay> securityContext = new SecurityContext<ViewBangTienDoGiangDay>();
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
		public override VList<ViewBangTienDoGiangDay> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{ViewBangTienDoGiangDay} of <c>ViewBangTienDoGiangDay</c> objects.</returns>
		public override VList<ViewBangTienDoGiangDay> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewBangTienDoGiangDay> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewBangTienDoGiangDayProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="ViewBangTienDoGiangDay" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewBangTienDoGiangDay> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewBangTienDoGiangDay" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewBangTienDoGiangDay}"/> </returns>
		public override VList<ViewBangTienDoGiangDay> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewBangTienDoGiangDay> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewBangTienDoGiangDayProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{ViewBangTienDoGiangDay}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewBangTienDoGiangDay</c> objects.</returns>
		public virtual VList<ViewBangTienDoGiangDay> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewBangTienDoGiangDay}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewBangTienDoGiangDay</c> objects.</returns>
		public virtual VList<ViewBangTienDoGiangDay> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewBangTienDoGiangDay}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewBangTienDoGiangDay</c> objects.</returns>
		public override VList<ViewBangTienDoGiangDay> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewBangTienDoGiangDay> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewBangTienDoGiangDayProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>ViewBangTienDoGiangDay</c> objects.</returns>
		public virtual VList<ViewBangTienDoGiangDay> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewBangTienDoGiangDay</c> objects.</returns>
		public virtual VList<ViewBangTienDoGiangDay> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>ViewBangTienDoGiangDay</c> objects.</returns>
		public override VList<ViewBangTienDoGiangDay> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewBangTienDoGiangDay> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewBangTienDoGiangDayProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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



