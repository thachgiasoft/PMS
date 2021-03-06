﻿
/*
	File generated by NetTiers templates [www.NetTiers.com]
	Important: Do not modify this file. Edit the file ViewGiangVienLichGiang.cs instead.
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
	/// An object representation of the 'View_GiangVien_LichGiang' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the ViewGiangVienLichGiang.cs file instead.
	/// All custom implementations should be done in the <see cref="ViewGiangVienLichGiang"/> class.
	/// </remarks>
	[DataObject]
	public partial class ViewGiangVienLichGiangServiceBase : ServiceViewBase<ViewGiangVienLichGiang>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewGiangVienLichGiang"/> instance .
		///</summary>
		public ViewGiangVienLichGiangServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewGiangVienLichGiang"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_hoTen"></param>
		///<param name="_chuyenNganh"></param>
		///<param name="_maHocHam"></param>
		///<param name="_cmnd"></param>
		///<param name="_maSoThue"></param>
		///<param name="_thuongTru"></param>
		///<param name="_tenHocHam"></param>
		///<param name="_maHocPhan"></param>
		///<param name="_tenHocPhan"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_tenLopHocPhan"></param>
		///<param name="_maBacDaoTao"></param>
		///<param name="_maLoaiHinh"></param>
		///<param name="_maBacLoaiHinh"></param>
		///<param name="_maLoaiGiangVien"></param>
		///<param name="_maPhong"></param>
		///<param name="_maBuoiHoc"></param>
		///<param name="_maThongTinBuoi"></param>
		///<param name="_thongTinBuoi"></param>
		///<param name="_tenPhong"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_soTiet"></param>
		///<param name="_siSoLop"></param>
		///<param name="_heSoLd"></param>
		///<param name="_heSoTinChi"></param>
		///<param name="_tietQuyDoi"></param>
		///<param name="_donGia"></param>
		///<param name="_tienThem"></param>
		///<param name="_tongCong"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_ngayKyHopDong"></param>
		///<param name="_ngayKetThucHopDong"></param>
		public static ViewGiangVienLichGiang CreateViewGiangVienLichGiang(System.Int32? _maGiangVien, System.String _maQuanLy, System.String _ho, System.String _ten, System.String _hoTen, System.String _chuyenNganh, System.Int32? _maHocHam, System.String _cmnd, System.String _maSoThue, System.String _thuongTru, System.String _tenHocHam, System.String _maHocPhan, System.String _tenHocPhan, System.String _maLopHocPhan, System.String _tenLopHocPhan, System.String _maBacDaoTao, System.String _maLoaiHinh, System.String _maBacLoaiHinh, System.Int32? _maLoaiGiangVien, System.String _maPhong, System.Int32? _maBuoiHoc, System.String _maThongTinBuoi, System.String _thongTinBuoi, System.String _tenPhong, System.String _maMonHoc, System.String _tenMonHoc, System.Decimal _soTiet, System.Int32? _siSoLop, System.Decimal? _heSoLd, System.Decimal _heSoTinChi, System.Decimal? _tietQuyDoi, System.Decimal _donGia, System.Decimal _tienThem, System.Decimal? _tongCong, System.String _namHoc, System.String _hocKy, System.DateTime? _ngayKyHopDong, System.DateTime? _ngayKetThucHopDong)
		{
			ViewGiangVienLichGiang newEntityViewGiangVienLichGiang = new ViewGiangVienLichGiang();
			newEntityViewGiangVienLichGiang.MaGiangVien  = _maGiangVien;
			newEntityViewGiangVienLichGiang.MaQuanLy  = _maQuanLy;
			newEntityViewGiangVienLichGiang.Ho  = _ho;
			newEntityViewGiangVienLichGiang.Ten  = _ten;
			newEntityViewGiangVienLichGiang.HoTen  = _hoTen;
			newEntityViewGiangVienLichGiang.ChuyenNganh  = _chuyenNganh;
			newEntityViewGiangVienLichGiang.MaHocHam  = _maHocHam;
			newEntityViewGiangVienLichGiang.Cmnd  = _cmnd;
			newEntityViewGiangVienLichGiang.MaSoThue  = _maSoThue;
			newEntityViewGiangVienLichGiang.ThuongTru  = _thuongTru;
			newEntityViewGiangVienLichGiang.TenHocHam  = _tenHocHam;
			newEntityViewGiangVienLichGiang.MaHocPhan  = _maHocPhan;
			newEntityViewGiangVienLichGiang.TenHocPhan  = _tenHocPhan;
			newEntityViewGiangVienLichGiang.MaLopHocPhan  = _maLopHocPhan;
			newEntityViewGiangVienLichGiang.TenLopHocPhan  = _tenLopHocPhan;
			newEntityViewGiangVienLichGiang.MaBacDaoTao  = _maBacDaoTao;
			newEntityViewGiangVienLichGiang.MaLoaiHinh  = _maLoaiHinh;
			newEntityViewGiangVienLichGiang.MaBacLoaiHinh  = _maBacLoaiHinh;
			newEntityViewGiangVienLichGiang.MaLoaiGiangVien  = _maLoaiGiangVien;
			newEntityViewGiangVienLichGiang.MaPhong  = _maPhong;
			newEntityViewGiangVienLichGiang.MaBuoiHoc  = _maBuoiHoc;
			newEntityViewGiangVienLichGiang.MaThongTinBuoi  = _maThongTinBuoi;
			newEntityViewGiangVienLichGiang.ThongTinBuoi  = _thongTinBuoi;
			newEntityViewGiangVienLichGiang.TenPhong  = _tenPhong;
			newEntityViewGiangVienLichGiang.MaMonHoc  = _maMonHoc;
			newEntityViewGiangVienLichGiang.TenMonHoc  = _tenMonHoc;
			newEntityViewGiangVienLichGiang.SoTiet  = _soTiet;
			newEntityViewGiangVienLichGiang.SiSoLop  = _siSoLop;
			newEntityViewGiangVienLichGiang.HeSoLd  = _heSoLd;
			newEntityViewGiangVienLichGiang.HeSoTinChi  = _heSoTinChi;
			newEntityViewGiangVienLichGiang.TietQuyDoi  = _tietQuyDoi;
			newEntityViewGiangVienLichGiang.DonGia  = _donGia;
			newEntityViewGiangVienLichGiang.TienThem  = _tienThem;
			newEntityViewGiangVienLichGiang.TongCong  = _tongCong;
			newEntityViewGiangVienLichGiang.NamHoc  = _namHoc;
			newEntityViewGiangVienLichGiang.HocKy  = _hocKy;
			newEntityViewGiangVienLichGiang.NgayKyHopDong  = _ngayKyHopDong;
			newEntityViewGiangVienLichGiang.NgayKetThucHopDong  = _ngayKetThucHopDong;
			return newEntityViewGiangVienLichGiang;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<ViewGiangVienLichGiang> securityContext = new SecurityContext<ViewGiangVienLichGiang>();
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
		public override VList<ViewGiangVienLichGiang> Get(string whereClause, string orderBy)
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
		/// <returns>Returns a typed collection TList{ViewGiangVienLichGiang} of <c>ViewGiangVienLichGiang</c> objects.</returns>
		public override VList<ViewGiangVienLichGiang> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<ViewGiangVienLichGiang> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewGiangVienLichGiangProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// Get a complete collection of <see cref="ViewGiangVienLichGiang" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<ViewGiangVienLichGiang> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="ViewGiangVienLichGiang" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{ViewGiangVienLichGiang}"/> </returns>
		public override VList<ViewGiangVienLichGiang> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<ViewGiangVienLichGiang> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.ViewGiangVienLichGiangProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
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
		/// Gets a page of <see cref="TList{ViewGiangVienLichGiang}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewGiangVienLichGiang</c> objects.</returns>
		public virtual VList<ViewGiangVienLichGiang> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{ViewGiangVienLichGiang}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewGiangVienLichGiang</c> objects.</returns>
		public virtual VList<ViewGiangVienLichGiang> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{ViewGiangVienLichGiang}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>ViewGiangVienLichGiang</c> objects.</returns>
		public override VList<ViewGiangVienLichGiang> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<ViewGiangVienLichGiang> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewGiangVienLichGiangProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
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
		/// <returns>Returns a typed collection of <c>ViewGiangVienLichGiang</c> objects.</returns>
		public virtual VList<ViewGiangVienLichGiang> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>ViewGiangVienLichGiang</c> objects.</returns>
		public virtual VList<ViewGiangVienLichGiang> Find(IFilterParameterCollection parameters, string orderBy)
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
		/// <returns>Returns a typed collection of <c>ViewGiangVienLichGiang</c> objects.</returns>
		public override VList<ViewGiangVienLichGiang> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<ViewGiangVienLichGiang> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.ViewGiangVienLichGiangProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
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
		
		#region cust_View_GiangVien_LichGiang_GetByNamHocHocKyMaBacMaHe
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LichGiang_GetByNamHocHocKyMaBacMaHe' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public virtual void GetByNamHocHocKyMaBacMaHe(System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String maHeDaoTao)
		{
			 GetByNamHocHocKyMaBacMaHe( namHoc, hocKy, maBacDaoTao, maHeDaoTao, 0, defaultMaxRecords );
		}
	
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LichGiang_GetByNamHocHocKyMaBacMaHe' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maBacDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="maHeDaoTao"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public virtual void GetByNamHocHocKyMaBacMaHe(System.String namHoc, System.String hocKy, System.String maBacDaoTao, System.String maHeDaoTao, int start, int pageLength)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetByNamHocHocKyMaBacMaHe");
			
		
			 
			TransactionManager transactionManager = null; 
			
			try
            {
				bool isBorrowedTransaction = ConnectionScope.Current.HasTransaction;				
				
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction();
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
                
				//Call Custom Procedure from Repository
				dataProvider.ViewGiangVienLichGiangProvider.GetByNamHocHocKyMaBacMaHe(transactionManager, start, pageLength , namHoc, hocKy, maBacDaoTao, maHeDaoTao);
	        
				//If success, Commit
				if(!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
					transactionManager.Commit();
            	
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
			
			return ;
		}
		#endregion 
		#endregion
		
		#endregion Data Access Methods
		
	
	}//End Class
} // end namespace



