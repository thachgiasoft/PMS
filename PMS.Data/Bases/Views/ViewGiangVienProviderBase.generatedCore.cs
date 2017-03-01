#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="ViewGiangVienProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewGiangVienProviderBaseCore : EntityViewProviderBase<ViewGiangVien>
	{
		#region Custom Methods
		
		
		#region cust_View_GiangVien_LopHocPhan_GetBatDauByTuNgayDenNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetBatDauByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetBatDauByTuNgayDenNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			return LopHocPhan_GetBatDauByTuNgayDenNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetBatDauByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetBatDauByTuNgayDenNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return LopHocPhan_GetBatDauByTuNgayDenNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetBatDauByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetBatDauByTuNgayDenNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return LopHocPhan_GetBatDauByTuNgayDenNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetBatDauByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader LopHocPhan_GetBatDauByTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion

		
		#region cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHoc
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NghienCuuKhoaHoc_GetByMaDonViNamHoc(System.String maDonVi, System.String namHoc)
		{
			return NghienCuuKhoaHoc_GetByMaDonViNamHoc(null, 0, int.MaxValue , maDonVi, namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NghienCuuKhoaHoc_GetByMaDonViNamHoc(int start, int pageLength, System.String maDonVi, System.String namHoc)
		{
			return NghienCuuKhoaHoc_GetByMaDonViNamHoc(null, start, pageLength , maDonVi, namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NghienCuuKhoaHoc_GetByMaDonViNamHoc(TransactionManager transactionManager, System.String maDonVi, System.String namHoc)
		{
			return NghienCuuKhoaHoc_GetByMaDonViNamHoc(transactionManager, 0, int.MaxValue , maDonVi, namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader NghienCuuKhoaHoc_GetByMaDonViNamHoc(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi, System.String namHoc);
		
		#endregion

		
		#region cust_view_GiangVien_GetByMaDonViThongKeThanhTra
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonViThongKeThanhTra' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonViThongKeThanhTra(System.String maDonVi)
		{
			return GetByMaDonViThongKeThanhTra(null, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonViThongKeThanhTra' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonViThongKeThanhTra(int start, int pageLength, System.String maDonVi)
		{
			return GetByMaDonViThongKeThanhTra(null, start, pageLength , maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonViThongKeThanhTra' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonViThongKeThanhTra(TransactionManager transactionManager, System.String maDonVi)
		{
			return GetByMaDonViThongKeThanhTra(transactionManager, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonViThongKeThanhTra' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewGiangVien> GetByMaDonViThongKeThanhTra(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi);
		
		#endregion

		
		#region cust_view_GiangVien_GetByMaDonViNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonViNamHocHocKy(System.String maDonVi, System.String namHoc, System.String hocKy)
		{
			return GetByMaDonViNamHocHocKy(null, 0, int.MaxValue , maDonVi, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonViNamHocHocKy(int start, int pageLength, System.String maDonVi, System.String namHoc, System.String hocKy)
		{
			return GetByMaDonViNamHocHocKy(null, start, pageLength , maDonVi, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonViNamHocHocKy(TransactionManager transactionManager, System.String maDonVi, System.String namHoc, System.String hocKy)
		{
			return GetByMaDonViNamHocHocKy(transactionManager, 0, int.MaxValue , maDonVi, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewGiangVien> GetByMaDonViNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_GiangVien_Nckh_GetByNamHoc
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_Nckh_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Nckh_GetByNamHoc(System.String namHoc)
		{
			return Nckh_GetByNamHoc(null, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_Nckh_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Nckh_GetByNamHoc(int start, int pageLength, System.String namHoc)
		{
			return Nckh_GetByNamHoc(null, start, pageLength , namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_Nckh_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Nckh_GetByNamHoc(TransactionManager transactionManager, System.String namHoc)
		{
			return Nckh_GetByNamHoc(transactionManager, 0, int.MaxValue , namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_Nckh_GetByNamHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader Nckh_GetByNamHoc(TransactionManager transactionManager, int start, int pageLength, System.String namHoc);
		
		#endregion

		
		#region cust_View_GiangVien_LuuKhoaTaiKhoan
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LuuKhoaTaiKhoan' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuKhoaTaiKhoan(System.String xmlData, ref System.Int32 reVal)
		{
			 LuuKhoaTaiKhoan(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LuuKhoaTaiKhoan' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuKhoaTaiKhoan(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuKhoaTaiKhoan(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LuuKhoaTaiKhoan' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuKhoaTaiKhoan(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 LuuKhoaTaiKhoan(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LuuKhoaTaiKhoan' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuKhoaTaiKhoan(TransactionManager transactionManager, int start, int pageLength, System.String xmlData, ref System.Int32 reVal);
		
		#endregion

		
		#region cust_View_GiangVien_Nckh_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_Nckh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Nckh_GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return Nckh_GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_Nckh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Nckh_GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return Nckh_GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_Nckh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Nckh_GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return Nckh_GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_Nckh_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader Nckh_GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_GiangVien_GetByMaDonViMaLoaiGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_GetByMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonViMaLoaiGiangVien(System.String maDonVi, System.String maLoaiGiangVien)
		{
			return GetByMaDonViMaLoaiGiangVien(null, 0, int.MaxValue , maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_GetByMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonViMaLoaiGiangVien(int start, int pageLength, System.String maDonVi, System.String maLoaiGiangVien)
		{
			return GetByMaDonViMaLoaiGiangVien(null, start, pageLength , maDonVi, maLoaiGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_GetByMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonViMaLoaiGiangVien(TransactionManager transactionManager, System.String maDonVi, System.String maLoaiGiangVien)
		{
			return GetByMaDonViMaLoaiGiangVien(transactionManager, 0, int.MaxValue , maDonVi, maLoaiGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_GetByMaDonViMaLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewGiangVien> GetByMaDonViMaLoaiGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi, System.String maLoaiGiangVien);
		
		#endregion

		
		#region cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy(System.String maDonVi, System.String namHoc, System.String hocKy)
		{
			return NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy(null, 0, int.MaxValue , maDonVi, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy(int start, int pageLength, System.String maDonVi, System.String namHoc, System.String hocKy)
		{
			return NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy(null, start, pageLength , maDonVi, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy(TransactionManager transactionManager, System.String maDonVi, System.String namHoc, System.String hocKy)
		{
			return NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy(transactionManager, 0, int.MaxValue , maDonVi, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader NghienCuuKhoaHoc_GetByMaDonViNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_view_GiangVien_GetByMaDonVi
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonVi(System.String maDonVi)
		{
			return GetByMaDonVi(null, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonVi(int start, int pageLength, System.String maDonVi)
		{
			return GetByMaDonVi(null, start, pageLength , maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonVi(TransactionManager transactionManager, System.String maDonVi)
		{
			return GetByMaDonVi(transactionManager, 0, int.MaxValue , maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewGiangVien> GetByMaDonVi(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi);
		
		#endregion

		
		#region cust_View_GiangVien_DonVi_HocHam_HocVi_HoSo_ChucVu_TinhTrang_GetByAll
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_DonVi_HocHam_HocVi_HoSo_ChucVu_TinhTrang_GetByAll' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DonVi_HocHam_HocVi_HoSo_ChucVu_TinhTrang_GetByAll(System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.Int32 maTinhTrang)
		{
			 DonVi_HocHam_HocVi_HoSo_ChucVu_TinhTrang_GetByAll(null, 0, int.MaxValue , maDonVi, maHocHam, maHocVi, maTinhTrang);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_DonVi_HocHam_HocVi_HoSo_ChucVu_TinhTrang_GetByAll' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DonVi_HocHam_HocVi_HoSo_ChucVu_TinhTrang_GetByAll(int start, int pageLength, System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.Int32 maTinhTrang)
		{
			 DonVi_HocHam_HocVi_HoSo_ChucVu_TinhTrang_GetByAll(null, start, pageLength , maDonVi, maHocHam, maHocVi, maTinhTrang);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_DonVi_HocHam_HocVi_HoSo_ChucVu_TinhTrang_GetByAll' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DonVi_HocHam_HocVi_HoSo_ChucVu_TinhTrang_GetByAll(TransactionManager transactionManager, System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.Int32 maTinhTrang)
		{
			 DonVi_HocHam_HocVi_HoSo_ChucVu_TinhTrang_GetByAll(transactionManager, 0, int.MaxValue , maDonVi, maHocHam, maHocVi, maTinhTrang);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_DonVi_HocHam_HocVi_HoSo_ChucVu_TinhTrang_GetByAll' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="maHocHam"> A <c>System.Int32</c> instance.</param>
		/// <param name="maHocVi"> A <c>System.Int32</c> instance.</param>
		/// <param name="maTinhTrang"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DonVi_HocHam_HocVi_HoSo_ChucVu_TinhTrang_GetByAll(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi, System.Int32 maHocHam, System.Int32 maHocVi, System.Int32 maTinhTrang);
		
		#endregion

		
		#region cust_View_GiangVien_LopHocPhan_GetKetThucByTuNgayDenNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetKetThucByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetKetThucByTuNgayDenNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			return LopHocPhan_GetKetThucByTuNgayDenNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetKetThucByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetKetThucByTuNgayDenNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return LopHocPhan_GetKetThucByTuNgayDenNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetKetThucByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetKetThucByTuNgayDenNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return LopHocPhan_GetKetThucByTuNgayDenNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetKetThucByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader LopHocPhan_GetKetThucByTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion

		
		#region cust_View_GiangVien_Nckh_GetByNamHocHocKyMaDonVi
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_Nckh_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Nckh_GetByNamHocHocKyMaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return Nckh_GetByNamHocHocKyMaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_Nckh_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Nckh_GetByNamHocHocKyMaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return Nckh_GetByNamHocHocKyMaDonVi(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_Nckh_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader Nckh_GetByNamHocHocKyMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return Nckh_GetByNamHocHocKyMaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_Nckh_GetByNamHocHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader Nckh_GetByNamHocHocKyMaDonVi(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion

		
		#region cust_View_GiangVien_LopHocPhan_GetByNamHocHocKyMaGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetByNamHocHocKyMaGiangVien(System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return LopHocPhan_GetByNamHocHocKyMaGiangVien(null, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetByNamHocHocKyMaGiangVien(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return LopHocPhan_GetByNamHocHocKyMaGiangVien(null, start, pageLength , namHoc, hocKy, maGiangVien);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetByNamHocHocKyMaGiangVien(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maGiangVien)
		{
			return LopHocPhan_GetByNamHocHocKyMaGiangVien(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVien);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKyMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader LopHocPhan_GetByNamHocHocKyMaGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maGiangVien);
		
		#endregion

		
		#region cust_View_GiangVien_LopHocPhan_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return LopHocPhan_GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return LopHocPhan_GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader LopHocPhan_GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return LopHocPhan_GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_LopHocPhan_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader LopHocPhan_GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_GiangVien_GetByNhomQuyen
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_GetByNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByNhomQuyen(System.String nhomQuyen)
		{
			return GetByNhomQuyen(null, 0, int.MaxValue , nhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_GetByNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByNhomQuyen(int start, int pageLength, System.String nhomQuyen)
		{
			return GetByNhomQuyen(null, start, pageLength , nhomQuyen);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_GetByNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByNhomQuyen(TransactionManager transactionManager, System.String nhomQuyen)
		{
			return GetByNhomQuyen(transactionManager, 0, int.MaxValue , nhomQuyen);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_GiangVien_GetByNhomQuyen' stored procedure. 
		/// </summary>
		/// <param name="nhomQuyen"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewGiangVien> GetByNhomQuyen(TransactionManager transactionManager, int start, int pageLength, System.String nhomQuyen);
		
		#endregion

		
		#region cust_view_GiangVien_GetByMaDonViTuNgayDenNgay
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonViTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonViTuNgayDenNgay(System.String maDonVi, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByMaDonViTuNgayDenNgay(null, 0, int.MaxValue , maDonVi, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonViTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonViTuNgayDenNgay(int start, int pageLength, System.String maDonVi, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByMaDonViTuNgayDenNgay(null, start, pageLength , maDonVi, tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonViTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public VList<ViewGiangVien> GetByMaDonViTuNgayDenNgay(TransactionManager transactionManager, System.String maDonVi, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByMaDonViTuNgayDenNgay(transactionManager, 0, int.MaxValue , maDonVi, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_view_GiangVien_GetByMaDonViTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewGiangVien&gt;"/> instance.</returns>
		public abstract VList<ViewGiangVien> GetByMaDonViTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength, System.String maDonVi, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewGiangVien&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewGiangVien&gt;"/></returns>
		protected static VList&lt;ViewGiangVien&gt; Fill(DataSet dataSet, VList<ViewGiangVien> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewGiangVien>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewGiangVien&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewGiangVien>"/></returns>
		protected static VList&lt;ViewGiangVien&gt; Fill(DataTable dataTable, VList<ViewGiangVien> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewGiangVien c = new ViewGiangVien();
					c.ThuTu = (Convert.IsDBNull(row["ThuTu"]))?(long)0:(System.Int64?)row["ThuTu"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?(int)0:(System.Int32)row["MaGiangVien"];
					c.MaQuanLy = (Convert.IsDBNull(row["MaQuanLy"]))?string.Empty:(System.String)row["MaQuanLy"];
					c.Ho = (Convert.IsDBNull(row["Ho"]))?string.Empty:(System.String)row["Ho"];
					c.Ten = (Convert.IsDBNull(row["Ten"]))?string.Empty:(System.String)row["Ten"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.GioiTinh = (Convert.IsDBNull(row["GioiTinh"]))?string.Empty:(System.String)row["GioiTinh"];
					c.NgaySinh = (Convert.IsDBNull(row["NgaySinh"]))?string.Empty:(System.String)row["NgaySinh"];
					c.MaHocHam = (Convert.IsDBNull(row["MaHocHam"]))?(int)0:(System.Int32?)row["MaHocHam"];
					c.MaHocVi = (Convert.IsDBNull(row["MaHocVi"]))?(int)0:(System.Int32?)row["MaHocVi"];
					c.MaLoaiGiangVien = (Convert.IsDBNull(row["MaLoaiGiangVien"]))?(int)0:(System.Int32?)row["MaLoaiGiangVien"];
					c.TenHocHam = (Convert.IsDBNull(row["TenHocHam"]))?string.Empty:(System.String)row["TenHocHam"];
					c.TenHocVi = (Convert.IsDBNull(row["TenHocVi"]))?string.Empty:(System.String)row["TenHocVi"];
					c.TenLoaiGiangVien = (Convert.IsDBNull(row["TenLoaiGiangVien"]))?string.Empty:(System.String)row["TenLoaiGiangVien"];
					c.MaDonVi = (Convert.IsDBNull(row["MaDonVi"]))?string.Empty:(System.String)row["MaDonVi"];
					c.DonGia = (Convert.IsDBNull(row["DonGia"]))?0.0m:(System.Decimal)row["DonGia"];
					c.TenDonVi = (Convert.IsDBNull(row["TenDonVi"]))?string.Empty:(System.String)row["TenDonVi"];
					c.KhoaTaiKhoan = (Convert.IsDBNull(row["KhoaTaiKhoan"]))?false:(System.Boolean?)row["KhoaTaiKhoan"];
					c.Cmnd = (Convert.IsDBNull(row["Cmnd"]))?string.Empty:(System.String)row["Cmnd"];
					c.ChuyenNganh = (Convert.IsDBNull(row["ChuyenNganh"]))?string.Empty:(System.String)row["ChuyenNganh"];
					c.MaSoThue = (Convert.IsDBNull(row["MaSoThue"]))?string.Empty:(System.String)row["MaSoThue"];
					c.NoiLamViec = (Convert.IsDBNull(row["NoiLamViec"]))?string.Empty:(System.String)row["NoiLamViec"];
					c.AcceptChanges();
					rows.Add(c);
					pagelen -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		*/	
						
		///<summary>
		/// Fill an <see cref="VList&lt;ViewGiangVien&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewGiangVien&gt;"/></returns>
		protected VList<ViewGiangVien> Fill(IDataReader reader, VList<ViewGiangVien> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewGiangVien entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewGiangVien>("ViewGiangVien",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewGiangVien();
					}
					
					entity.SuppressEntityEvents = true;

					entity.ThuTu = reader.IsDBNull(reader.GetOrdinal("ThuTu")) ? null : (System.Int64?)reader["ThuTu"];
					//entity.ThuTu = (Convert.IsDBNull(reader["ThuTu"]))?(long)0:(System.Int64?)reader["ThuTu"];
					entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
					entity.MaQuanLy = (System.String)reader["MaQuanLy"];
					//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
					entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
					//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
					entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
					//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.GioiTinh = (System.String)reader["GioiTinh"];
					//entity.GioiTinh = (Convert.IsDBNull(reader["GioiTinh"]))?string.Empty:(System.String)reader["GioiTinh"];
					entity.NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? null : (System.String)reader["NgaySinh"];
					//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
					entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
					//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
					entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
					//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
					entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
					//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
					entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
					//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
					entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
					//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
					entity.TenLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("TenLoaiGiangVien")) ? null : (System.String)reader["TenLoaiGiangVien"];
					//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
					entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
					//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
					entity.DonGia = (System.Decimal)reader["DonGia"];
					//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal)reader["DonGia"];
					entity.TenDonVi = (System.String)reader["TenDonVi"];
					//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
					entity.KhoaTaiKhoan = reader.IsDBNull(reader.GetOrdinal("KhoaTaiKhoan")) ? null : (System.Boolean?)reader["KhoaTaiKhoan"];
					//entity.KhoaTaiKhoan = (Convert.IsDBNull(reader["KhoaTaiKhoan"]))?false:(System.Boolean?)reader["KhoaTaiKhoan"];
					entity.Cmnd = reader.IsDBNull(reader.GetOrdinal("Cmnd")) ? null : (System.String)reader["Cmnd"];
					//entity.Cmnd = (Convert.IsDBNull(reader["Cmnd"]))?string.Empty:(System.String)reader["Cmnd"];
					entity.ChuyenNganh = reader.IsDBNull(reader.GetOrdinal("ChuyenNganh")) ? null : (System.String)reader["ChuyenNganh"];
					//entity.ChuyenNganh = (Convert.IsDBNull(reader["ChuyenNganh"]))?string.Empty:(System.String)reader["ChuyenNganh"];
					entity.MaSoThue = reader.IsDBNull(reader.GetOrdinal("MaSoThue")) ? null : (System.String)reader["MaSoThue"];
					//entity.MaSoThue = (Convert.IsDBNull(reader["MaSoThue"]))?string.Empty:(System.String)reader["MaSoThue"];
					entity.NoiLamViec = reader.IsDBNull(reader.GetOrdinal("NoiLamViec")) ? null : (System.String)reader["NoiLamViec"];
					//entity.NoiLamViec = (Convert.IsDBNull(reader["NoiLamViec"]))?string.Empty:(System.String)reader["NoiLamViec"];
					entity.AcceptChanges();
					entity.SuppressEntityEvents = false;
					
					rows.Add(entity);
					pageLength -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		
		
		/// <summary>
		/// Refreshes the <see cref="ViewGiangVien"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVien"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewGiangVien entity)
		{
			reader.Read();
			entity.ThuTu = reader.IsDBNull(reader.GetOrdinal("ThuTu")) ? null : (System.Int64?)reader["ThuTu"];
			//entity.ThuTu = (Convert.IsDBNull(reader["ThuTu"]))?(long)0:(System.Int64?)reader["ThuTu"];
			entity.MaGiangVien = (System.Int32)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?(int)0:(System.Int32)reader["MaGiangVien"];
			entity.MaQuanLy = (System.String)reader["MaQuanLy"];
			//entity.MaQuanLy = (Convert.IsDBNull(reader["MaQuanLy"]))?string.Empty:(System.String)reader["MaQuanLy"];
			entity.Ho = reader.IsDBNull(reader.GetOrdinal("Ho")) ? null : (System.String)reader["Ho"];
			//entity.Ho = (Convert.IsDBNull(reader["Ho"]))?string.Empty:(System.String)reader["Ho"];
			entity.Ten = reader.IsDBNull(reader.GetOrdinal("Ten")) ? null : (System.String)reader["Ten"];
			//entity.Ten = (Convert.IsDBNull(reader["Ten"]))?string.Empty:(System.String)reader["Ten"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.GioiTinh = (System.String)reader["GioiTinh"];
			//entity.GioiTinh = (Convert.IsDBNull(reader["GioiTinh"]))?string.Empty:(System.String)reader["GioiTinh"];
			entity.NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? null : (System.String)reader["NgaySinh"];
			//entity.NgaySinh = (Convert.IsDBNull(reader["NgaySinh"]))?string.Empty:(System.String)reader["NgaySinh"];
			entity.MaHocHam = reader.IsDBNull(reader.GetOrdinal("MaHocHam")) ? null : (System.Int32?)reader["MaHocHam"];
			//entity.MaHocHam = (Convert.IsDBNull(reader["MaHocHam"]))?(int)0:(System.Int32?)reader["MaHocHam"];
			entity.MaHocVi = reader.IsDBNull(reader.GetOrdinal("MaHocVi")) ? null : (System.Int32?)reader["MaHocVi"];
			//entity.MaHocVi = (Convert.IsDBNull(reader["MaHocVi"]))?(int)0:(System.Int32?)reader["MaHocVi"];
			entity.MaLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("MaLoaiGiangVien")) ? null : (System.Int32?)reader["MaLoaiGiangVien"];
			//entity.MaLoaiGiangVien = (Convert.IsDBNull(reader["MaLoaiGiangVien"]))?(int)0:(System.Int32?)reader["MaLoaiGiangVien"];
			entity.TenHocHam = reader.IsDBNull(reader.GetOrdinal("TenHocHam")) ? null : (System.String)reader["TenHocHam"];
			//entity.TenHocHam = (Convert.IsDBNull(reader["TenHocHam"]))?string.Empty:(System.String)reader["TenHocHam"];
			entity.TenHocVi = reader.IsDBNull(reader.GetOrdinal("TenHocVi")) ? null : (System.String)reader["TenHocVi"];
			//entity.TenHocVi = (Convert.IsDBNull(reader["TenHocVi"]))?string.Empty:(System.String)reader["TenHocVi"];
			entity.TenLoaiGiangVien = reader.IsDBNull(reader.GetOrdinal("TenLoaiGiangVien")) ? null : (System.String)reader["TenLoaiGiangVien"];
			//entity.TenLoaiGiangVien = (Convert.IsDBNull(reader["TenLoaiGiangVien"]))?string.Empty:(System.String)reader["TenLoaiGiangVien"];
			entity.MaDonVi = reader.IsDBNull(reader.GetOrdinal("MaDonVi")) ? null : (System.String)reader["MaDonVi"];
			//entity.MaDonVi = (Convert.IsDBNull(reader["MaDonVi"]))?string.Empty:(System.String)reader["MaDonVi"];
			entity.DonGia = (System.Decimal)reader["DonGia"];
			//entity.DonGia = (Convert.IsDBNull(reader["DonGia"]))?0.0m:(System.Decimal)reader["DonGia"];
			entity.TenDonVi = (System.String)reader["TenDonVi"];
			//entity.TenDonVi = (Convert.IsDBNull(reader["TenDonVi"]))?string.Empty:(System.String)reader["TenDonVi"];
			entity.KhoaTaiKhoan = reader.IsDBNull(reader.GetOrdinal("KhoaTaiKhoan")) ? null : (System.Boolean?)reader["KhoaTaiKhoan"];
			//entity.KhoaTaiKhoan = (Convert.IsDBNull(reader["KhoaTaiKhoan"]))?false:(System.Boolean?)reader["KhoaTaiKhoan"];
			entity.Cmnd = reader.IsDBNull(reader.GetOrdinal("Cmnd")) ? null : (System.String)reader["Cmnd"];
			//entity.Cmnd = (Convert.IsDBNull(reader["Cmnd"]))?string.Empty:(System.String)reader["Cmnd"];
			entity.ChuyenNganh = reader.IsDBNull(reader.GetOrdinal("ChuyenNganh")) ? null : (System.String)reader["ChuyenNganh"];
			//entity.ChuyenNganh = (Convert.IsDBNull(reader["ChuyenNganh"]))?string.Empty:(System.String)reader["ChuyenNganh"];
			entity.MaSoThue = reader.IsDBNull(reader.GetOrdinal("MaSoThue")) ? null : (System.String)reader["MaSoThue"];
			//entity.MaSoThue = (Convert.IsDBNull(reader["MaSoThue"]))?string.Empty:(System.String)reader["MaSoThue"];
			entity.NoiLamViec = reader.IsDBNull(reader.GetOrdinal("NoiLamViec")) ? null : (System.String)reader["NoiLamViec"];
			//entity.NoiLamViec = (Convert.IsDBNull(reader["NoiLamViec"]))?string.Empty:(System.String)reader["NoiLamViec"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewGiangVien"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewGiangVien"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewGiangVien entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ThuTu = (Convert.IsDBNull(dataRow["ThuTu"]))?(long)0:(System.Int64?)dataRow["ThuTu"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?(int)0:(System.Int32)dataRow["MaGiangVien"];
			entity.MaQuanLy = (Convert.IsDBNull(dataRow["MaQuanLy"]))?string.Empty:(System.String)dataRow["MaQuanLy"];
			entity.Ho = (Convert.IsDBNull(dataRow["Ho"]))?string.Empty:(System.String)dataRow["Ho"];
			entity.Ten = (Convert.IsDBNull(dataRow["Ten"]))?string.Empty:(System.String)dataRow["Ten"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.GioiTinh = (Convert.IsDBNull(dataRow["GioiTinh"]))?string.Empty:(System.String)dataRow["GioiTinh"];
			entity.NgaySinh = (Convert.IsDBNull(dataRow["NgaySinh"]))?string.Empty:(System.String)dataRow["NgaySinh"];
			entity.MaHocHam = (Convert.IsDBNull(dataRow["MaHocHam"]))?(int)0:(System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = (Convert.IsDBNull(dataRow["MaHocVi"]))?(int)0:(System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = (Convert.IsDBNull(dataRow["MaLoaiGiangVien"]))?(int)0:(System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.TenHocHam = (Convert.IsDBNull(dataRow["TenHocHam"]))?string.Empty:(System.String)dataRow["TenHocHam"];
			entity.TenHocVi = (Convert.IsDBNull(dataRow["TenHocVi"]))?string.Empty:(System.String)dataRow["TenHocVi"];
			entity.TenLoaiGiangVien = (Convert.IsDBNull(dataRow["TenLoaiGiangVien"]))?string.Empty:(System.String)dataRow["TenLoaiGiangVien"];
			entity.MaDonVi = (Convert.IsDBNull(dataRow["MaDonVi"]))?string.Empty:(System.String)dataRow["MaDonVi"];
			entity.DonGia = (Convert.IsDBNull(dataRow["DonGia"]))?0.0m:(System.Decimal)dataRow["DonGia"];
			entity.TenDonVi = (Convert.IsDBNull(dataRow["TenDonVi"]))?string.Empty:(System.String)dataRow["TenDonVi"];
			entity.KhoaTaiKhoan = (Convert.IsDBNull(dataRow["KhoaTaiKhoan"]))?false:(System.Boolean?)dataRow["KhoaTaiKhoan"];
			entity.Cmnd = (Convert.IsDBNull(dataRow["Cmnd"]))?string.Empty:(System.String)dataRow["Cmnd"];
			entity.ChuyenNganh = (Convert.IsDBNull(dataRow["ChuyenNganh"]))?string.Empty:(System.String)dataRow["ChuyenNganh"];
			entity.MaSoThue = (Convert.IsDBNull(dataRow["MaSoThue"]))?string.Empty:(System.String)dataRow["MaSoThue"];
			entity.NoiLamViec = (Convert.IsDBNull(dataRow["NoiLamViec"]))?string.Empty:(System.String)dataRow["NoiLamViec"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewGiangVienFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienFilterBuilder : SqlFilterBuilder<ViewGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienFilterBuilder class.
		/// </summary>
		public ViewGiangVienFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienFilterBuilder

	#region ViewGiangVienParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienParameterBuilder : ParameterizedSqlFilterBuilder<ViewGiangVienColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienParameterBuilder class.
		/// </summary>
		public ViewGiangVienParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewGiangVienParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewGiangVienParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewGiangVienParameterBuilder
	
	#region ViewGiangVienSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVien"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewGiangVienSortBuilder : SqlSortBuilder<ViewGiangVienColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienSqlSortBuilder class.
		/// </summary>
		public ViewGiangVienSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewGiangVienSortBuilder

} // end namespace
