﻿#region Using directives

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
	/// This class is the base class for any <see cref="ViewKhoiLuongGiangDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewKhoiLuongGiangDayProviderBaseCore : EntityViewProviderBase<ViewKhoiLuongGiangDay>
	{
		#region Custom Methods
		
		
		#region cust_View_KhoiLuong_GiangDay_DongBoKcq
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoKcq' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoKcq(System.String namHoc, System.String hocKy, System.String dot)
		{
			 DongBoKcq(null, 0, int.MaxValue , namHoc, hocKy, dot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoKcq' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoKcq(int start, int pageLength, System.String namHoc, System.String hocKy, System.String dot)
		{
			 DongBoKcq(null, start, pageLength , namHoc, hocKy, dot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoKcq' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoKcq(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String dot)
		{
			 DongBoKcq(transactionManager, 0, int.MaxValue , namHoc, hocKy, dot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoKcq' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBoKcq(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String dot);
		
		#endregion

		
		#region cust_View_KhoiLuong_GiangDay_GetByTuNgayDenNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongGiangDay> GetByTuNgayDenNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongGiangDay> GetByTuNgayDenNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongGiangDay> GetByTuNgayDenNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByTuNgayDenNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_GetByTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewKhoiLuongGiangDay> GetByTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion

		
		#region cust_View_KhoiLuong_GiangDay_GetByNamHocHocKy
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongGiangDay> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongGiangDay> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongGiangDay> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewKhoiLuongGiangDay> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_KhoiLuong_GiangDay_DongBoTheoNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoNgay(System.DateTime tuNgay, System.DateTime denNgay)
		{
			 DongBoTheoNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay)
		{
			 DongBoTheoNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay)
		{
			 DongBoTheoNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBoTheoNgay(TransactionManager transactionManager, int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion

		
		#region cust_View_KhoiLuong_GiangDay_DongBoTheoDonVi
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoTheoDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 DongBoTheoDonVi(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoTheoDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 DongBoTheoDonVi(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoTheoDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			 DongBoTheoDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoTheoDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBoTheoDonVi(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion

		
		#region cust_View_KhoiLuong_GiangDay_DongBoTheoDot
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoDot(System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			 DongBoTheoDot(null, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoDot(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			 DongBoTheoDot(null, start, pageLength , namHoc, hocKy, maCauHinhChotGio);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBoTheoDot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio)
		{
			 DongBoTheoDot(transactionManager, 0, int.MaxValue , namHoc, hocKy, maCauHinhChotGio);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBoTheoDot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maCauHinhChotGio"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBoTheoDot(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 maCauHinhChotGio);
		
		#endregion

		
		#region cust_View_KhoiLuong_GiangDay_DongBo
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(System.String namHoc, System.String hocKy)
		{
			 DongBo(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			 DongBo(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void DongBo(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			 DongBo(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_DongBo' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void DongBo(TransactionManager transactionManager, int start, int pageLength, System.String namHoc, System.String hocKy);
		
		#endregion

		
		#region cust_View_KhoiLuong_GiangDay_GetByMaGiangVienMaLopHocPhanMaLop
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_GetByMaGiangVienMaLopHocPhanMaLop' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongGiangDay> GetByMaGiangVienMaLopHocPhanMaLop(System.String maGiangVien, System.String maLopHocPhan, System.String maLop)
		{
			return GetByMaGiangVienMaLopHocPhanMaLop(null, 0, int.MaxValue , maGiangVien, maLopHocPhan, maLop);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_GetByMaGiangVienMaLopHocPhanMaLop' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongGiangDay> GetByMaGiangVienMaLopHocPhanMaLop(int start, int pageLength, System.String maGiangVien, System.String maLopHocPhan, System.String maLop)
		{
			return GetByMaGiangVienMaLopHocPhanMaLop(null, start, pageLength , maGiangVien, maLopHocPhan, maLop);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_GetByMaGiangVienMaLopHocPhanMaLop' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongGiangDay&gt;"/> instance.</returns>
		public VList<ViewKhoiLuongGiangDay> GetByMaGiangVienMaLopHocPhanMaLop(TransactionManager transactionManager, System.String maGiangVien, System.String maLopHocPhan, System.String maLop)
		{
			return GetByMaGiangVienMaLopHocPhanMaLop(transactionManager, 0, int.MaxValue , maGiangVien, maLopHocPhan, maLop);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_KhoiLuong_GiangDay_GetByMaGiangVienMaLopHocPhanMaLop' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="maLop"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewKhoiLuongGiangDay&gt;"/> instance.</returns>
		public abstract VList<ViewKhoiLuongGiangDay> GetByMaGiangVienMaLopHocPhanMaLop(TransactionManager transactionManager, int start, int pageLength, System.String maGiangVien, System.String maLopHocPhan, System.String maLop);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewKhoiLuongGiangDay&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewKhoiLuongGiangDay&gt;"/></returns>
		protected static VList&lt;ViewKhoiLuongGiangDay&gt; Fill(DataSet dataSet, VList<ViewKhoiLuongGiangDay> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewKhoiLuongGiangDay>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewKhoiLuongGiangDay&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewKhoiLuongGiangDay>"/></returns>
		protected static VList&lt;ViewKhoiLuongGiangDay&gt; Fill(DataTable dataTable, VList<ViewKhoiLuongGiangDay> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewKhoiLuongGiangDay c = new ViewKhoiLuongGiangDay();
					c.MaLichHoc = (Convert.IsDBNull(row["MaLichHoc"]))?(int)0:(System.Int32)row["MaLichHoc"];
					c.MaGiangVien = (Convert.IsDBNull(row["MaGiangVien"]))?string.Empty:(System.String)row["MaGiangVien"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.NamHoc = (Convert.IsDBNull(row["NamHoc"]))?string.Empty:(System.String)row["NamHoc"];
					c.HocKy = (Convert.IsDBNull(row["HocKy"]))?string.Empty:(System.String)row["HocKy"];
					c.MaMonHoc = (Convert.IsDBNull(row["MaMonHoc"]))?string.Empty:(System.String)row["MaMonHoc"];
					c.TenMonHoc = (Convert.IsDBNull(row["TenMonHoc"]))?string.Empty:(System.String)row["TenMonHoc"];
					c.Nhom = (Convert.IsDBNull(row["Nhom"]))?string.Empty:(System.String)row["Nhom"];
					c.SoTinChi = (Convert.IsDBNull(row["SoTinChi"]))?0.0m:(System.Decimal)row["SoTinChi"];
					c.LyThuyet = (Convert.IsDBNull(row["LyThuyet"]))?0.0m:(System.Decimal)row["LyThuyet"];
					c.ThucHanh = (Convert.IsDBNull(row["ThucHanh"]))?0.0m:(System.Decimal)row["ThucHanh"];
					c.BaiTap = (Convert.IsDBNull(row["BaiTap"]))?0.0m:(System.Decimal)row["BaiTap"];
					c.BaiTapLon = (Convert.IsDBNull(row["BaiTapLon"]))?0.0m:(System.Decimal)row["BaiTapLon"];
					c.DoAn = (Convert.IsDBNull(row["DoAn"]))?0.0m:(System.Decimal)row["DoAn"];
					c.LuanAn = (Convert.IsDBNull(row["LuanAn"]))?0.0m:(System.Decimal)row["LuanAn"];
					c.TieuLuan = (Convert.IsDBNull(row["TieuLuan"]))?0.0m:(System.Decimal)row["TieuLuan"];
					c.ThucTap = (Convert.IsDBNull(row["ThucTap"]))?0.0m:(System.Decimal)row["ThucTap"];
					c.SoLuong = (Convert.IsDBNull(row["SoLuong"]))?(int)0:(System.Int32)row["SoLuong"];
					c.MaLoaiHocPhan = (Convert.IsDBNull(row["MaLoaiHocPhan"]))?(byte)0:(System.Byte)row["MaLoaiHocPhan"];
					c.LoaiHocPhan = (Convert.IsDBNull(row["LoaiHocPhan"]))?string.Empty:(System.String)row["LoaiHocPhan"];
					c.PhanLoai = (Convert.IsDBNull(row["PhanLoai"]))?string.Empty:(System.String)row["PhanLoai"];
					c.HeSoThanhPhan = (Convert.IsDBNull(row["HeSoThanhPhan"]))?0.0m:(System.Decimal?)row["HeSoThanhPhan"];
					c.Nam = (Convert.IsDBNull(row["Nam"]))?(int)0:(System.Int32?)row["Nam"];
					c.Tuan = (Convert.IsDBNull(row["Tuan"]))?(int)0:(System.Int32?)row["Tuan"];
					c.DonViTinh = (Convert.IsDBNull(row["DonViTinh"]))?string.Empty:(System.String)row["DonViTinh"];
					c.MaBuoiHoc = (Convert.IsDBNull(row["MaBuoiHoc"]))?(int)0:(System.Int32?)row["MaBuoiHoc"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.TietBatDau = (Convert.IsDBNull(row["TietBatDau"]))?(int)0:(System.Int32?)row["TietBatDau"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.TinhTrang = (Convert.IsDBNull(row["TinhTrang"]))?(int)0:(System.Int32)row["TinhTrang"];
					c.NgayDay = (Convert.IsDBNull(row["NgayDay"]))?DateTime.MinValue:(System.DateTime?)row["NgayDay"];
					c.Compensate = (Convert.IsDBNull(row["Compensate"]))?(byte)0:(System.Byte?)row["Compensate"];
					c.MaBacDaoTao = (Convert.IsDBNull(row["MaBacDaoTao"]))?string.Empty:(System.String)row["MaBacDaoTao"];
					c.MaNhomMonHoc = (Convert.IsDBNull(row["MaNhomMonHoc"]))?string.Empty:(System.String)row["MaNhomMonHoc"];
					c.MaPhongHoc = (Convert.IsDBNull(row["MaPhongHoc"]))?string.Empty:(System.String)row["MaPhongHoc"];
					c.MaKhoaHoc = (Convert.IsDBNull(row["MaKhoaHoc"]))?string.Empty:(System.String)row["MaKhoaHoc"];
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
		/// Fill an <see cref="VList&lt;ViewKhoiLuongGiangDay&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewKhoiLuongGiangDay&gt;"/></returns>
		protected VList<ViewKhoiLuongGiangDay> Fill(IDataReader reader, VList<ViewKhoiLuongGiangDay> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewKhoiLuongGiangDay entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewKhoiLuongGiangDay>("ViewKhoiLuongGiangDay",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewKhoiLuongGiangDay();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLichHoc = (System.Int32)reader["MaLichHoc"];
					//entity.MaLichHoc = (Convert.IsDBNull(reader["MaLichHoc"]))?(int)0:(System.Int32)reader["MaLichHoc"];
					entity.MaGiangVien = (System.String)reader["MaGiangVien"];
					//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
					entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.NamHoc = (System.String)reader["NamHoc"];
					//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
					entity.HocKy = (System.String)reader["HocKy"];
					//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
					entity.MaMonHoc = (System.String)reader["MaMonHoc"];
					//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
					entity.TenMonHoc = (System.String)reader["TenMonHoc"];
					//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
					entity.Nhom = reader.IsDBNull(reader.GetOrdinal("Nhom")) ? null : (System.String)reader["Nhom"];
					//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
					entity.SoTinChi = (System.Decimal)reader["SoTinChi"];
					//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
					entity.LyThuyet = (System.Decimal)reader["LyThuyet"];
					//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal)reader["LyThuyet"];
					entity.ThucHanh = (System.Decimal)reader["ThucHanh"];
					//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal)reader["ThucHanh"];
					entity.BaiTap = (System.Decimal)reader["BaiTap"];
					//entity.BaiTap = (Convert.IsDBNull(reader["BaiTap"]))?0.0m:(System.Decimal)reader["BaiTap"];
					entity.BaiTapLon = (System.Decimal)reader["BaiTapLon"];
					//entity.BaiTapLon = (Convert.IsDBNull(reader["BaiTapLon"]))?0.0m:(System.Decimal)reader["BaiTapLon"];
					entity.DoAn = (System.Decimal)reader["DoAn"];
					//entity.DoAn = (Convert.IsDBNull(reader["DoAn"]))?0.0m:(System.Decimal)reader["DoAn"];
					entity.LuanAn = (System.Decimal)reader["LuanAn"];
					//entity.LuanAn = (Convert.IsDBNull(reader["LuanAn"]))?0.0m:(System.Decimal)reader["LuanAn"];
					entity.TieuLuan = (System.Decimal)reader["TieuLuan"];
					//entity.TieuLuan = (Convert.IsDBNull(reader["TieuLuan"]))?0.0m:(System.Decimal)reader["TieuLuan"];
					entity.ThucTap = (System.Decimal)reader["ThucTap"];
					//entity.ThucTap = (Convert.IsDBNull(reader["ThucTap"]))?0.0m:(System.Decimal)reader["ThucTap"];
					entity.SoLuong = (System.Int32)reader["SoLuong"];
					//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32)reader["SoLuong"];
					entity.MaLoaiHocPhan = (System.Byte)reader["MaLoaiHocPhan"];
					//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(byte)0:(System.Byte)reader["MaLoaiHocPhan"];
					entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.PhanLoai = reader.IsDBNull(reader.GetOrdinal("PhanLoai")) ? null : (System.String)reader["PhanLoai"];
					//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
					entity.HeSoThanhPhan = reader.IsDBNull(reader.GetOrdinal("HeSoThanhPhan")) ? null : (System.Decimal?)reader["HeSoThanhPhan"];
					//entity.HeSoThanhPhan = (Convert.IsDBNull(reader["HeSoThanhPhan"]))?0.0m:(System.Decimal?)reader["HeSoThanhPhan"];
					entity.Nam = reader.IsDBNull(reader.GetOrdinal("Nam")) ? null : (System.Int32?)reader["Nam"];
					//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
					entity.Tuan = reader.IsDBNull(reader.GetOrdinal("Tuan")) ? null : (System.Int32?)reader["Tuan"];
					//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
					entity.DonViTinh = reader.IsDBNull(reader.GetOrdinal("DonViTinh")) ? null : (System.String)reader["DonViTinh"];
					//entity.DonViTinh = (Convert.IsDBNull(reader["DonViTinh"]))?string.Empty:(System.String)reader["DonViTinh"];
					entity.MaBuoiHoc = reader.IsDBNull(reader.GetOrdinal("MaBuoiHoc")) ? null : (System.Int32?)reader["MaBuoiHoc"];
					//entity.MaBuoiHoc = (Convert.IsDBNull(reader["MaBuoiHoc"]))?(int)0:(System.Int32?)reader["MaBuoiHoc"];
					entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.TietBatDau = reader.IsDBNull(reader.GetOrdinal("TietBatDau")) ? null : (System.Int32?)reader["TietBatDau"];
					//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.TinhTrang = (System.Int32)reader["TinhTrang"];
					//entity.TinhTrang = (Convert.IsDBNull(reader["TinhTrang"]))?(int)0:(System.Int32)reader["TinhTrang"];
					entity.NgayDay = reader.IsDBNull(reader.GetOrdinal("NgayDay")) ? null : (System.DateTime?)reader["NgayDay"];
					//entity.NgayDay = (Convert.IsDBNull(reader["NgayDay"]))?DateTime.MinValue:(System.DateTime?)reader["NgayDay"];
					entity.Compensate = reader.IsDBNull(reader.GetOrdinal("Compensate")) ? null : (System.Byte?)reader["Compensate"];
					//entity.Compensate = (Convert.IsDBNull(reader["Compensate"]))?(byte)0:(System.Byte?)reader["Compensate"];
					entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
					//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
					entity.MaNhomMonHoc = reader.IsDBNull(reader.GetOrdinal("MaNhomMonHoc")) ? null : (System.String)reader["MaNhomMonHoc"];
					//entity.MaNhomMonHoc = (Convert.IsDBNull(reader["MaNhomMonHoc"]))?string.Empty:(System.String)reader["MaNhomMonHoc"];
					entity.MaPhongHoc = reader.IsDBNull(reader.GetOrdinal("MaPhongHoc")) ? null : (System.String)reader["MaPhongHoc"];
					//entity.MaPhongHoc = (Convert.IsDBNull(reader["MaPhongHoc"]))?string.Empty:(System.String)reader["MaPhongHoc"];
					entity.MaKhoaHoc = reader.IsDBNull(reader.GetOrdinal("MaKhoaHoc")) ? null : (System.String)reader["MaKhoaHoc"];
					//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
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
		/// Refreshes the <see cref="ViewKhoiLuongGiangDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoiLuongGiangDay"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewKhoiLuongGiangDay entity)
		{
			reader.Read();
			entity.MaLichHoc = (System.Int32)reader["MaLichHoc"];
			//entity.MaLichHoc = (Convert.IsDBNull(reader["MaLichHoc"]))?(int)0:(System.Int32)reader["MaLichHoc"];
			entity.MaGiangVien = (System.String)reader["MaGiangVien"];
			//entity.MaGiangVien = (Convert.IsDBNull(reader["MaGiangVien"]))?string.Empty:(System.String)reader["MaGiangVien"];
			entity.MaLopHocPhan = (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.NamHoc = (System.String)reader["NamHoc"];
			//entity.NamHoc = (Convert.IsDBNull(reader["NamHoc"]))?string.Empty:(System.String)reader["NamHoc"];
			entity.HocKy = (System.String)reader["HocKy"];
			//entity.HocKy = (Convert.IsDBNull(reader["HocKy"]))?string.Empty:(System.String)reader["HocKy"];
			entity.MaMonHoc = (System.String)reader["MaMonHoc"];
			//entity.MaMonHoc = (Convert.IsDBNull(reader["MaMonHoc"]))?string.Empty:(System.String)reader["MaMonHoc"];
			entity.TenMonHoc = (System.String)reader["TenMonHoc"];
			//entity.TenMonHoc = (Convert.IsDBNull(reader["TenMonHoc"]))?string.Empty:(System.String)reader["TenMonHoc"];
			entity.Nhom = reader.IsDBNull(reader.GetOrdinal("Nhom")) ? null : (System.String)reader["Nhom"];
			//entity.Nhom = (Convert.IsDBNull(reader["Nhom"]))?string.Empty:(System.String)reader["Nhom"];
			entity.SoTinChi = (System.Decimal)reader["SoTinChi"];
			//entity.SoTinChi = (Convert.IsDBNull(reader["SoTinChi"]))?0.0m:(System.Decimal)reader["SoTinChi"];
			entity.LyThuyet = (System.Decimal)reader["LyThuyet"];
			//entity.LyThuyet = (Convert.IsDBNull(reader["LyThuyet"]))?0.0m:(System.Decimal)reader["LyThuyet"];
			entity.ThucHanh = (System.Decimal)reader["ThucHanh"];
			//entity.ThucHanh = (Convert.IsDBNull(reader["ThucHanh"]))?0.0m:(System.Decimal)reader["ThucHanh"];
			entity.BaiTap = (System.Decimal)reader["BaiTap"];
			//entity.BaiTap = (Convert.IsDBNull(reader["BaiTap"]))?0.0m:(System.Decimal)reader["BaiTap"];
			entity.BaiTapLon = (System.Decimal)reader["BaiTapLon"];
			//entity.BaiTapLon = (Convert.IsDBNull(reader["BaiTapLon"]))?0.0m:(System.Decimal)reader["BaiTapLon"];
			entity.DoAn = (System.Decimal)reader["DoAn"];
			//entity.DoAn = (Convert.IsDBNull(reader["DoAn"]))?0.0m:(System.Decimal)reader["DoAn"];
			entity.LuanAn = (System.Decimal)reader["LuanAn"];
			//entity.LuanAn = (Convert.IsDBNull(reader["LuanAn"]))?0.0m:(System.Decimal)reader["LuanAn"];
			entity.TieuLuan = (System.Decimal)reader["TieuLuan"];
			//entity.TieuLuan = (Convert.IsDBNull(reader["TieuLuan"]))?0.0m:(System.Decimal)reader["TieuLuan"];
			entity.ThucTap = (System.Decimal)reader["ThucTap"];
			//entity.ThucTap = (Convert.IsDBNull(reader["ThucTap"]))?0.0m:(System.Decimal)reader["ThucTap"];
			entity.SoLuong = (System.Int32)reader["SoLuong"];
			//entity.SoLuong = (Convert.IsDBNull(reader["SoLuong"]))?(int)0:(System.Int32)reader["SoLuong"];
			entity.MaLoaiHocPhan = (System.Byte)reader["MaLoaiHocPhan"];
			//entity.MaLoaiHocPhan = (Convert.IsDBNull(reader["MaLoaiHocPhan"]))?(byte)0:(System.Byte)reader["MaLoaiHocPhan"];
			entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.PhanLoai = reader.IsDBNull(reader.GetOrdinal("PhanLoai")) ? null : (System.String)reader["PhanLoai"];
			//entity.PhanLoai = (Convert.IsDBNull(reader["PhanLoai"]))?string.Empty:(System.String)reader["PhanLoai"];
			entity.HeSoThanhPhan = reader.IsDBNull(reader.GetOrdinal("HeSoThanhPhan")) ? null : (System.Decimal?)reader["HeSoThanhPhan"];
			//entity.HeSoThanhPhan = (Convert.IsDBNull(reader["HeSoThanhPhan"]))?0.0m:(System.Decimal?)reader["HeSoThanhPhan"];
			entity.Nam = reader.IsDBNull(reader.GetOrdinal("Nam")) ? null : (System.Int32?)reader["Nam"];
			//entity.Nam = (Convert.IsDBNull(reader["Nam"]))?(int)0:(System.Int32?)reader["Nam"];
			entity.Tuan = reader.IsDBNull(reader.GetOrdinal("Tuan")) ? null : (System.Int32?)reader["Tuan"];
			//entity.Tuan = (Convert.IsDBNull(reader["Tuan"]))?(int)0:(System.Int32?)reader["Tuan"];
			entity.DonViTinh = reader.IsDBNull(reader.GetOrdinal("DonViTinh")) ? null : (System.String)reader["DonViTinh"];
			//entity.DonViTinh = (Convert.IsDBNull(reader["DonViTinh"]))?string.Empty:(System.String)reader["DonViTinh"];
			entity.MaBuoiHoc = reader.IsDBNull(reader.GetOrdinal("MaBuoiHoc")) ? null : (System.Int32?)reader["MaBuoiHoc"];
			//entity.MaBuoiHoc = (Convert.IsDBNull(reader["MaBuoiHoc"]))?(int)0:(System.Int32?)reader["MaBuoiHoc"];
			entity.MaLop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.TietBatDau = reader.IsDBNull(reader.GetOrdinal("TietBatDau")) ? null : (System.Int32?)reader["TietBatDau"];
			//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.TinhTrang = (System.Int32)reader["TinhTrang"];
			//entity.TinhTrang = (Convert.IsDBNull(reader["TinhTrang"]))?(int)0:(System.Int32)reader["TinhTrang"];
			entity.NgayDay = reader.IsDBNull(reader.GetOrdinal("NgayDay")) ? null : (System.DateTime?)reader["NgayDay"];
			//entity.NgayDay = (Convert.IsDBNull(reader["NgayDay"]))?DateTime.MinValue:(System.DateTime?)reader["NgayDay"];
			entity.Compensate = reader.IsDBNull(reader.GetOrdinal("Compensate")) ? null : (System.Byte?)reader["Compensate"];
			//entity.Compensate = (Convert.IsDBNull(reader["Compensate"]))?(byte)0:(System.Byte?)reader["Compensate"];
			entity.MaBacDaoTao = (System.String)reader["MaBacDaoTao"];
			//entity.MaBacDaoTao = (Convert.IsDBNull(reader["MaBacDaoTao"]))?string.Empty:(System.String)reader["MaBacDaoTao"];
			entity.MaNhomMonHoc = reader.IsDBNull(reader.GetOrdinal("MaNhomMonHoc")) ? null : (System.String)reader["MaNhomMonHoc"];
			//entity.MaNhomMonHoc = (Convert.IsDBNull(reader["MaNhomMonHoc"]))?string.Empty:(System.String)reader["MaNhomMonHoc"];
			entity.MaPhongHoc = reader.IsDBNull(reader.GetOrdinal("MaPhongHoc")) ? null : (System.String)reader["MaPhongHoc"];
			//entity.MaPhongHoc = (Convert.IsDBNull(reader["MaPhongHoc"]))?string.Empty:(System.String)reader["MaPhongHoc"];
			entity.MaKhoaHoc = reader.IsDBNull(reader.GetOrdinal("MaKhoaHoc")) ? null : (System.String)reader["MaKhoaHoc"];
			//entity.MaKhoaHoc = (Convert.IsDBNull(reader["MaKhoaHoc"]))?string.Empty:(System.String)reader["MaKhoaHoc"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewKhoiLuongGiangDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewKhoiLuongGiangDay"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewKhoiLuongGiangDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLichHoc = (Convert.IsDBNull(dataRow["MaLichHoc"]))?(int)0:(System.Int32)dataRow["MaLichHoc"];
			entity.MaGiangVien = (Convert.IsDBNull(dataRow["MaGiangVien"]))?string.Empty:(System.String)dataRow["MaGiangVien"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.NamHoc = (Convert.IsDBNull(dataRow["NamHoc"]))?string.Empty:(System.String)dataRow["NamHoc"];
			entity.HocKy = (Convert.IsDBNull(dataRow["HocKy"]))?string.Empty:(System.String)dataRow["HocKy"];
			entity.MaMonHoc = (Convert.IsDBNull(dataRow["MaMonHoc"]))?string.Empty:(System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = (Convert.IsDBNull(dataRow["TenMonHoc"]))?string.Empty:(System.String)dataRow["TenMonHoc"];
			entity.Nhom = (Convert.IsDBNull(dataRow["Nhom"]))?string.Empty:(System.String)dataRow["Nhom"];
			entity.SoTinChi = (Convert.IsDBNull(dataRow["SoTinChi"]))?0.0m:(System.Decimal)dataRow["SoTinChi"];
			entity.LyThuyet = (Convert.IsDBNull(dataRow["LyThuyet"]))?0.0m:(System.Decimal)dataRow["LyThuyet"];
			entity.ThucHanh = (Convert.IsDBNull(dataRow["ThucHanh"]))?0.0m:(System.Decimal)dataRow["ThucHanh"];
			entity.BaiTap = (Convert.IsDBNull(dataRow["BaiTap"]))?0.0m:(System.Decimal)dataRow["BaiTap"];
			entity.BaiTapLon = (Convert.IsDBNull(dataRow["BaiTapLon"]))?0.0m:(System.Decimal)dataRow["BaiTapLon"];
			entity.DoAn = (Convert.IsDBNull(dataRow["DoAn"]))?0.0m:(System.Decimal)dataRow["DoAn"];
			entity.LuanAn = (Convert.IsDBNull(dataRow["LuanAn"]))?0.0m:(System.Decimal)dataRow["LuanAn"];
			entity.TieuLuan = (Convert.IsDBNull(dataRow["TieuLuan"]))?0.0m:(System.Decimal)dataRow["TieuLuan"];
			entity.ThucTap = (Convert.IsDBNull(dataRow["ThucTap"]))?0.0m:(System.Decimal)dataRow["ThucTap"];
			entity.SoLuong = (Convert.IsDBNull(dataRow["SoLuong"]))?(int)0:(System.Int32)dataRow["SoLuong"];
			entity.MaLoaiHocPhan = (Convert.IsDBNull(dataRow["MaLoaiHocPhan"]))?(byte)0:(System.Byte)dataRow["MaLoaiHocPhan"];
			entity.LoaiHocPhan = (Convert.IsDBNull(dataRow["LoaiHocPhan"]))?string.Empty:(System.String)dataRow["LoaiHocPhan"];
			entity.PhanLoai = (Convert.IsDBNull(dataRow["PhanLoai"]))?string.Empty:(System.String)dataRow["PhanLoai"];
			entity.HeSoThanhPhan = (Convert.IsDBNull(dataRow["HeSoThanhPhan"]))?0.0m:(System.Decimal?)dataRow["HeSoThanhPhan"];
			entity.Nam = (Convert.IsDBNull(dataRow["Nam"]))?(int)0:(System.Int32?)dataRow["Nam"];
			entity.Tuan = (Convert.IsDBNull(dataRow["Tuan"]))?(int)0:(System.Int32?)dataRow["Tuan"];
			entity.DonViTinh = (Convert.IsDBNull(dataRow["DonViTinh"]))?string.Empty:(System.String)dataRow["DonViTinh"];
			entity.MaBuoiHoc = (Convert.IsDBNull(dataRow["MaBuoiHoc"]))?(int)0:(System.Int32?)dataRow["MaBuoiHoc"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.TietBatDau = (Convert.IsDBNull(dataRow["TietBatDau"]))?(int)0:(System.Int32?)dataRow["TietBatDau"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.TinhTrang = (Convert.IsDBNull(dataRow["TinhTrang"]))?(int)0:(System.Int32)dataRow["TinhTrang"];
			entity.NgayDay = (Convert.IsDBNull(dataRow["NgayDay"]))?DateTime.MinValue:(System.DateTime?)dataRow["NgayDay"];
			entity.Compensate = (Convert.IsDBNull(dataRow["Compensate"]))?(byte)0:(System.Byte?)dataRow["Compensate"];
			entity.MaBacDaoTao = (Convert.IsDBNull(dataRow["MaBacDaoTao"]))?string.Empty:(System.String)dataRow["MaBacDaoTao"];
			entity.MaNhomMonHoc = (Convert.IsDBNull(dataRow["MaNhomMonHoc"]))?string.Empty:(System.String)dataRow["MaNhomMonHoc"];
			entity.MaPhongHoc = (Convert.IsDBNull(dataRow["MaPhongHoc"]))?string.Empty:(System.String)dataRow["MaPhongHoc"];
			entity.MaKhoaHoc = (Convert.IsDBNull(dataRow["MaKhoaHoc"]))?string.Empty:(System.String)dataRow["MaKhoaHoc"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewKhoiLuongGiangDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongGiangDayFilterBuilder : SqlFilterBuilder<ViewKhoiLuongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		public ViewKhoiLuongGiangDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoiLuongGiangDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoiLuongGiangDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoiLuongGiangDayFilterBuilder

	#region ViewKhoiLuongGiangDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongGiangDayParameterBuilder : ParameterizedSqlFilterBuilder<ViewKhoiLuongGiangDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		public ViewKhoiLuongGiangDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewKhoiLuongGiangDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewKhoiLuongGiangDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewKhoiLuongGiangDayParameterBuilder
	
	#region ViewKhoiLuongGiangDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongGiangDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewKhoiLuongGiangDaySortBuilder : SqlSortBuilder<ViewKhoiLuongGiangDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDaySqlSortBuilder class.
		/// </summary>
		public ViewKhoiLuongGiangDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewKhoiLuongGiangDaySortBuilder

} // end namespace
