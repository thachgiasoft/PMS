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
	/// This class is the base class for any <see cref="ViewThanhTraTheoThoiKhoaBieuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ViewThanhTraTheoThoiKhoaBieuProviderBaseCore : EntityViewProviderBase<ViewThanhTraTheoThoiKhoaBieu>
	{
		#region Custom Methods
		
		
		#region cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgayKhoa
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgayKhoa' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNgayKhoa(System.String tuNgay, System.String denNgay, System.String khoa)
		{
			return GetByNgayKhoa(null, 0, int.MaxValue , tuNgay, denNgay, khoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgayKhoa' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNgayKhoa(int start, int pageLength, System.String tuNgay, System.String denNgay, System.String khoa)
		{
			return GetByNgayKhoa(null, start, pageLength , tuNgay, denNgay, khoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgayKhoa' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNgayKhoa(TransactionManager transactionManager, System.String tuNgay, System.String denNgay, System.String khoa)
		{
			return GetByNgayKhoa(transactionManager, 0, int.MaxValue , tuNgay, denNgay, khoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgayKhoa' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNgayKhoa(TransactionManager transactionManager, int start, int pageLength, System.String tuNgay, System.String denNgay, System.String khoa);
		
		#endregion

		
		#region cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgayToaNha
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgayToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> ThongKeTheoNgayToaNha(System.String tuNgay, System.String denNgay, System.String toaNha)
		{
			return ThongKeTheoNgayToaNha(null, 0, int.MaxValue , tuNgay, denNgay, toaNha);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgayToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> ThongKeTheoNgayToaNha(int start, int pageLength, System.String tuNgay, System.String denNgay, System.String toaNha)
		{
			return ThongKeTheoNgayToaNha(null, start, pageLength , tuNgay, denNgay, toaNha);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgayToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> ThongKeTheoNgayToaNha(TransactionManager transactionManager, System.String tuNgay, System.String denNgay, System.String toaNha)
		{
			return ThongKeTheoNgayToaNha(transactionManager, 0, int.MaxValue , tuNgay, denNgay, toaNha);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgayToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public abstract VList<ViewThanhTraTheoThoiKhoaBieu> ThongKeTheoNgayToaNha(TransactionManager transactionManager, int start, int pageLength, System.String tuNgay, System.String denNgay, System.String toaNha);
		
		#endregion

		
		#region cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> GetByNgay(System.String tuNgay, System.String denNgay)
		{
			return GetByNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> GetByNgay(int start, int pageLength, System.String tuNgay, System.String denNgay)
		{
			return GetByNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> GetByNgay(TransactionManager transactionManager, System.String tuNgay, System.String denNgay)
		{
			return GetByNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public abstract VList<ViewThanhTraTheoThoiKhoaBieu> GetByNgay(TransactionManager transactionManager, int start, int pageLength, System.String tuNgay, System.String denNgay);
		
		#endregion

		
		#region cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgayKhoa
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgayKhoa' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNgayKhoa(System.String tuNgay, System.String denNgay, System.String khoa)
		{
			return ThongKeTheoNgayKhoa(null, 0, int.MaxValue , tuNgay, denNgay, khoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgayKhoa' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNgayKhoa(int start, int pageLength, System.String tuNgay, System.String denNgay, System.String khoa)
		{
			return ThongKeTheoNgayKhoa(null, start, pageLength , tuNgay, denNgay, khoa);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgayKhoa' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoNgayKhoa(TransactionManager transactionManager, System.String tuNgay, System.String denNgay, System.String khoa)
		{
			return ThongKeTheoNgayKhoa(transactionManager, 0, int.MaxValue , tuNgay, denNgay, khoa);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgayKhoa' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="khoa"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTheoNgayKhoa(TransactionManager transactionManager, int start, int pageLength, System.String tuNgay, System.String denNgay, System.String khoa);
		
		#endregion

		
		#region cust_View_ThanhTraTheoThoiKhoaBieu_GetByMaGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> GetByMaGiangVien(System.String maCanBoGiangDay, System.String tuNgay, System.String denNgay)
		{
			return GetByMaGiangVien(null, 0, int.MaxValue , maCanBoGiangDay, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> GetByMaGiangVien(int start, int pageLength, System.String maCanBoGiangDay, System.String tuNgay, System.String denNgay)
		{
			return GetByMaGiangVien(null, start, pageLength , maCanBoGiangDay, tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> GetByMaGiangVien(TransactionManager transactionManager, System.String maCanBoGiangDay, System.String tuNgay, System.String denNgay)
		{
			return GetByMaGiangVien(transactionManager, 0, int.MaxValue , maCanBoGiangDay, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByMaGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public abstract VList<ViewThanhTraTheoThoiKhoaBieu> GetByMaGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String maCanBoGiangDay, System.String tuNgay, System.String denNgay);
		
		#endregion

		
		#region cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgay
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> ThongKeTheoNgay(System.String tuNgay, System.String denNgay)
		{
			return ThongKeTheoNgay(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> ThongKeTheoNgay(int start, int pageLength, System.String tuNgay, System.String denNgay)
		{
			return ThongKeTheoNgay(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> ThongKeTheoNgay(TransactionManager transactionManager, System.String tuNgay, System.String denNgay)
		{
			return ThongKeTheoNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public abstract VList<ViewThanhTraTheoThoiKhoaBieu> ThongKeTheoNgay(TransactionManager transactionManager, int start, int pageLength, System.String tuNgay, System.String denNgay);
		
		#endregion

		
		#region cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgayCoSoToaNha
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgayCoSoToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> GetByNgayCoSoToaNha(System.String tuNgay, System.String denNgay, System.String toaNha)
		{
			return GetByNgayCoSoToaNha(null, 0, int.MaxValue , tuNgay, denNgay, toaNha);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgayCoSoToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> GetByNgayCoSoToaNha(int start, int pageLength, System.String tuNgay, System.String denNgay, System.String toaNha)
		{
			return GetByNgayCoSoToaNha(null, start, pageLength , tuNgay, denNgay, toaNha);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgayCoSoToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public VList<ViewThanhTraTheoThoiKhoaBieu> GetByNgayCoSoToaNha(TransactionManager transactionManager, System.String tuNgay, System.String denNgay, System.String toaNha)
		{
			return GetByNgayCoSoToaNha(transactionManager, 0, int.MaxValue , tuNgay, denNgay, toaNha);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_GetByNgayCoSoToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> instance.</returns>
		public abstract VList<ViewThanhTraTheoThoiKhoaBieu> GetByNgayCoSoToaNha(TransactionManager transactionManager, int start, int pageLength, System.String tuNgay, System.String denNgay, System.String toaNha);
		
		#endregion

		
		#region cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoGiangVien
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoGiangVien' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoGiangVien(System.String tuNgay, System.String denNgay)
		{
			return ThongKeTheoGiangVien(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoGiangVien' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoGiangVien(int start, int pageLength, System.String tuNgay, System.String denNgay)
		{
			return ThongKeTheoGiangVien(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoGiangVien' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTheoGiangVien(TransactionManager transactionManager, System.String tuNgay, System.String denNgay)
		{
			return ThongKeTheoGiangVien(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_ThongKeTheoGiangVien' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTheoGiangVien(TransactionManager transactionManager, int start, int pageLength, System.String tuNgay, System.String denNgay);
		
		#endregion

		
		#region cust_View_ThanhTraTheoThoiKhoaBieu_SoSanhTienDo
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_SoSanhTienDo' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader SoSanhTienDo(System.String tuNgay, System.String denNgay)
		{
			return SoSanhTienDo(null, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_SoSanhTienDo' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader SoSanhTienDo(int start, int pageLength, System.String tuNgay, System.String denNgay)
		{
			return SoSanhTienDo(null, start, pageLength , tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_SoSanhTienDo' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader SoSanhTienDo(TransactionManager transactionManager, System.String tuNgay, System.String denNgay)
		{
			return SoSanhTienDo(transactionManager, 0, int.MaxValue , tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_View_ThanhTraTheoThoiKhoaBieu_SoSanhTienDo' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader SoSanhTienDo(TransactionManager transactionManager, int start, int pageLength, System.String tuNgay, System.String denNgay);
		
		#endregion

		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/></returns>
		protected static VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt; Fill(DataSet dataSet, VList<ViewThanhTraTheoThoiKhoaBieu> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ViewThanhTraTheoThoiKhoaBieu>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ViewThanhTraTheoThoiKhoaBieu>"/></returns>
		protected static VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt; Fill(DataTable dataTable, VList<ViewThanhTraTheoThoiKhoaBieu> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ViewThanhTraTheoThoiKhoaBieu c = new ViewThanhTraTheoThoiKhoaBieu();
					c.MaLichHoc = (Convert.IsDBNull(row["MaLichHoc"]))?(int)0:(System.Int32)row["MaLichHoc"];
					c.MaGocLopHocPhan = (Convert.IsDBNull(row["MaGocLopHocPhan"]))?string.Empty:(System.String)row["MaGocLopHocPhan"];
					c.MaLopHocPhan = (Convert.IsDBNull(row["MaLopHocPhan"]))?string.Empty:(System.String)row["MaLopHocPhan"];
					c.MaHocPhan = (Convert.IsDBNull(row["MaHocPhan"]))?string.Empty:(System.String)row["MaHocPhan"];
					c.TenHocPhan = (Convert.IsDBNull(row["TenHocPhan"]))?string.Empty:(System.String)row["TenHocPhan"];
					c.LoaiHocPhan = (Convert.IsDBNull(row["LoaiHocPhan"]))?string.Empty:(System.String)row["LoaiHocPhan"];
					c.MaLop = (Convert.IsDBNull(row["MaLop"]))?string.Empty:(System.String)row["MaLop"];
					c.Ngay = (Convert.IsDBNull(row["Ngay"]))?string.Empty:(System.String)row["Ngay"];
					c.Thu = (Convert.IsDBNull(row["Thu"]))?string.Empty:(System.String)row["Thu"];
					c.TietBatDau = (Convert.IsDBNull(row["TietBatDau"]))?(int)0:(System.Int32?)row["TietBatDau"];
					c.SoTiet = (Convert.IsDBNull(row["SoTiet"]))?(int)0:(System.Int32?)row["SoTiet"];
					c.Phong = (Convert.IsDBNull(row["Phong"]))?string.Empty:(System.String)row["Phong"];
					c.Khoa = (Convert.IsDBNull(row["Khoa"]))?string.Empty:(System.String)row["Khoa"];
					c.MaCanBoGiangDay = (Convert.IsDBNull(row["MaCanBoGiangDay"]))?string.Empty:(System.String)row["MaCanBoGiangDay"];
					c.HoTen = (Convert.IsDBNull(row["HoTen"]))?string.Empty:(System.String)row["HoTen"];
					c.TienDo = (Convert.IsDBNull(row["TienDo"]))?string.Empty:(System.String)row["TienDo"];
					c.SiSo = (Convert.IsDBNull(row["SiSo"]))?(int)0:(System.Int32?)row["SiSo"];
					c.MaViPham = (Convert.IsDBNull(row["MaViPham"]))?string.Empty:(System.String)row["MaViPham"];
					c.NoiDungViPham = (Convert.IsDBNull(row["NoiDungViPham"]))?string.Empty:(System.String)row["NoiDungViPham"];
					c.MaHinhThucViPhamHrm = (Convert.IsDBNull(row["MaHinhThucViPhamHrm"]))?Guid.Empty:(System.Guid?)row["MaHinhThucViPhamHrm"];
					c.TenHinhThucViPham = (Convert.IsDBNull(row["TenHinhThucViPham"]))?string.Empty:(System.String)row["TenHinhThucViPham"];
					c.ThoiDiemGhiNhan = (Convert.IsDBNull(row["ThoiDiemGhiNhan"]))?string.Empty:(System.String)row["ThoiDiemGhiNhan"];
					c.LyDo = (Convert.IsDBNull(row["LyDo"]))?string.Empty:(System.String)row["LyDo"];
					c.GhiChu = (Convert.IsDBNull(row["GhiChu"]))?string.Empty:(System.String)row["GhiChu"];
					c.NgayCapNhat = (Convert.IsDBNull(row["NgayCapNhat"]))?string.Empty:(System.String)row["NgayCapNhat"];
					c.NguoiCapNhat = (Convert.IsDBNull(row["NguoiCapNhat"]))?string.Empty:(System.String)row["NguoiCapNhat"];
					c.SoTietGhiNhan = (Convert.IsDBNull(row["SoTietGhiNhan"]))?(int)0:(System.Int32?)row["SoTietGhiNhan"];
					c.XacNhan = (Convert.IsDBNull(row["XacNhan"]))?false:(System.Boolean?)row["XacNhan"];
					c.TrangThai = (Convert.IsDBNull(row["TrangThai"]))?false:(System.Boolean?)row["TrangThai"];
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
		/// Fill an <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ViewThanhTraTheoThoiKhoaBieu&gt;"/></returns>
		protected VList<ViewThanhTraTheoThoiKhoaBieu> Fill(IDataReader reader, VList<ViewThanhTraTheoThoiKhoaBieu> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ViewThanhTraTheoThoiKhoaBieu entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ViewThanhTraTheoThoiKhoaBieu>("ViewThanhTraTheoThoiKhoaBieu",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ViewThanhTraTheoThoiKhoaBieu();
					}
					
					entity.SuppressEntityEvents = true;

					entity.MaLichHoc = (System.Int32)reader["MaLichHoc"];
					//entity.MaLichHoc = (Convert.IsDBNull(reader["MaLichHoc"]))?(int)0:(System.Int32)reader["MaLichHoc"];
					entity.MaGocLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaGocLopHocPhan")) ? null : (System.String)reader["MaGocLopHocPhan"];
					//entity.MaGocLopHocPhan = (Convert.IsDBNull(reader["MaGocLopHocPhan"]))?string.Empty:(System.String)reader["MaGocLopHocPhan"];
					entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
					//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
					entity.MaHocPhan = (System.String)reader["MaHocPhan"];
					//entity.MaHocPhan = (Convert.IsDBNull(reader["MaHocPhan"]))?string.Empty:(System.String)reader["MaHocPhan"];
					entity.TenHocPhan = (System.String)reader["TenHocPhan"];
					//entity.TenHocPhan = (Convert.IsDBNull(reader["TenHocPhan"]))?string.Empty:(System.String)reader["TenHocPhan"];
					entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
					//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
					entity.MaLop = (System.String)reader["MaLop"];
					//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
					entity.Ngay = reader.IsDBNull(reader.GetOrdinal("Ngay")) ? null : (System.String)reader["Ngay"];
					//entity.Ngay = (Convert.IsDBNull(reader["Ngay"]))?string.Empty:(System.String)reader["Ngay"];
					entity.Thu = (System.String)reader["Thu"];
					//entity.Thu = (Convert.IsDBNull(reader["Thu"]))?string.Empty:(System.String)reader["Thu"];
					entity.TietBatDau = reader.IsDBNull(reader.GetOrdinal("TietBatDau")) ? null : (System.Int32?)reader["TietBatDau"];
					//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
					entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
					//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
					entity.Phong = reader.IsDBNull(reader.GetOrdinal("Phong")) ? null : (System.String)reader["Phong"];
					//entity.Phong = (Convert.IsDBNull(reader["Phong"]))?string.Empty:(System.String)reader["Phong"];
					entity.Khoa = reader.IsDBNull(reader.GetOrdinal("Khoa")) ? null : (System.String)reader["Khoa"];
					//entity.Khoa = (Convert.IsDBNull(reader["Khoa"]))?string.Empty:(System.String)reader["Khoa"];
					entity.MaCanBoGiangDay = reader.IsDBNull(reader.GetOrdinal("MaCanBoGiangDay")) ? null : (System.String)reader["MaCanBoGiangDay"];
					//entity.MaCanBoGiangDay = (Convert.IsDBNull(reader["MaCanBoGiangDay"]))?string.Empty:(System.String)reader["MaCanBoGiangDay"];
					entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
					//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
					entity.TienDo = (System.String)reader["TienDo"];
					//entity.TienDo = (Convert.IsDBNull(reader["TienDo"]))?string.Empty:(System.String)reader["TienDo"];
					entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Int32?)reader["SiSo"];
					//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
					entity.MaViPham = reader.IsDBNull(reader.GetOrdinal("MaViPham")) ? null : (System.String)reader["MaViPham"];
					//entity.MaViPham = (Convert.IsDBNull(reader["MaViPham"]))?string.Empty:(System.String)reader["MaViPham"];
					entity.NoiDungViPham = reader.IsDBNull(reader.GetOrdinal("NoiDungViPham")) ? null : (System.String)reader["NoiDungViPham"];
					//entity.NoiDungViPham = (Convert.IsDBNull(reader["NoiDungViPham"]))?string.Empty:(System.String)reader["NoiDungViPham"];
					entity.MaHinhThucViPhamHrm = reader.IsDBNull(reader.GetOrdinal("MaHinhThucViPhamHrm")) ? null : (System.Guid?)reader["MaHinhThucViPhamHrm"];
					//entity.MaHinhThucViPhamHrm = (Convert.IsDBNull(reader["MaHinhThucViPhamHrm"]))?Guid.Empty:(System.Guid?)reader["MaHinhThucViPhamHrm"];
					entity.TenHinhThucViPham = reader.IsDBNull(reader.GetOrdinal("TenHinhThucViPham")) ? null : (System.String)reader["TenHinhThucViPham"];
					//entity.TenHinhThucViPham = (Convert.IsDBNull(reader["TenHinhThucViPham"]))?string.Empty:(System.String)reader["TenHinhThucViPham"];
					entity.ThoiDiemGhiNhan = reader.IsDBNull(reader.GetOrdinal("ThoiDiemGhiNhan")) ? null : (System.String)reader["ThoiDiemGhiNhan"];
					//entity.ThoiDiemGhiNhan = (Convert.IsDBNull(reader["ThoiDiemGhiNhan"]))?string.Empty:(System.String)reader["ThoiDiemGhiNhan"];
					entity.LyDo = reader.IsDBNull(reader.GetOrdinal("LyDo")) ? null : (System.String)reader["LyDo"];
					//entity.LyDo = (Convert.IsDBNull(reader["LyDo"]))?string.Empty:(System.String)reader["LyDo"];
					entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
					//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
					entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
					//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
					entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
					//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
					entity.SoTietGhiNhan = reader.IsDBNull(reader.GetOrdinal("SoTietGhiNhan")) ? null : (System.Int32?)reader["SoTietGhiNhan"];
					//entity.SoTietGhiNhan = (Convert.IsDBNull(reader["SoTietGhiNhan"]))?(int)0:(System.Int32?)reader["SoTietGhiNhan"];
					entity.XacNhan = reader.IsDBNull(reader.GetOrdinal("XacNhan")) ? null : (System.Boolean?)reader["XacNhan"];
					//entity.XacNhan = (Convert.IsDBNull(reader["XacNhan"]))?false:(System.Boolean?)reader["XacNhan"];
					entity.TrangThai = reader.IsDBNull(reader.GetOrdinal("TrangThai")) ? null : (System.Boolean?)reader["TrangThai"];
					//entity.TrangThai = (Convert.IsDBNull(reader["TrangThai"]))?false:(System.Boolean?)reader["TrangThai"];
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
		/// Refreshes the <see cref="ViewThanhTraTheoThoiKhoaBieu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThanhTraTheoThoiKhoaBieu"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ViewThanhTraTheoThoiKhoaBieu entity)
		{
			reader.Read();
			entity.MaLichHoc = (System.Int32)reader["MaLichHoc"];
			//entity.MaLichHoc = (Convert.IsDBNull(reader["MaLichHoc"]))?(int)0:(System.Int32)reader["MaLichHoc"];
			entity.MaGocLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaGocLopHocPhan")) ? null : (System.String)reader["MaGocLopHocPhan"];
			//entity.MaGocLopHocPhan = (Convert.IsDBNull(reader["MaGocLopHocPhan"]))?string.Empty:(System.String)reader["MaGocLopHocPhan"];
			entity.MaLopHocPhan = reader.IsDBNull(reader.GetOrdinal("MaLopHocPhan")) ? null : (System.String)reader["MaLopHocPhan"];
			//entity.MaLopHocPhan = (Convert.IsDBNull(reader["MaLopHocPhan"]))?string.Empty:(System.String)reader["MaLopHocPhan"];
			entity.MaHocPhan = (System.String)reader["MaHocPhan"];
			//entity.MaHocPhan = (Convert.IsDBNull(reader["MaHocPhan"]))?string.Empty:(System.String)reader["MaHocPhan"];
			entity.TenHocPhan = (System.String)reader["TenHocPhan"];
			//entity.TenHocPhan = (Convert.IsDBNull(reader["TenHocPhan"]))?string.Empty:(System.String)reader["TenHocPhan"];
			entity.LoaiHocPhan = reader.IsDBNull(reader.GetOrdinal("LoaiHocPhan")) ? null : (System.String)reader["LoaiHocPhan"];
			//entity.LoaiHocPhan = (Convert.IsDBNull(reader["LoaiHocPhan"]))?string.Empty:(System.String)reader["LoaiHocPhan"];
			entity.MaLop = (System.String)reader["MaLop"];
			//entity.MaLop = (Convert.IsDBNull(reader["MaLop"]))?string.Empty:(System.String)reader["MaLop"];
			entity.Ngay = reader.IsDBNull(reader.GetOrdinal("Ngay")) ? null : (System.String)reader["Ngay"];
			//entity.Ngay = (Convert.IsDBNull(reader["Ngay"]))?string.Empty:(System.String)reader["Ngay"];
			entity.Thu = (System.String)reader["Thu"];
			//entity.Thu = (Convert.IsDBNull(reader["Thu"]))?string.Empty:(System.String)reader["Thu"];
			entity.TietBatDau = reader.IsDBNull(reader.GetOrdinal("TietBatDau")) ? null : (System.Int32?)reader["TietBatDau"];
			//entity.TietBatDau = (Convert.IsDBNull(reader["TietBatDau"]))?(int)0:(System.Int32?)reader["TietBatDau"];
			entity.SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? null : (System.Int32?)reader["SoTiet"];
			//entity.SoTiet = (Convert.IsDBNull(reader["SoTiet"]))?(int)0:(System.Int32?)reader["SoTiet"];
			entity.Phong = reader.IsDBNull(reader.GetOrdinal("Phong")) ? null : (System.String)reader["Phong"];
			//entity.Phong = (Convert.IsDBNull(reader["Phong"]))?string.Empty:(System.String)reader["Phong"];
			entity.Khoa = reader.IsDBNull(reader.GetOrdinal("Khoa")) ? null : (System.String)reader["Khoa"];
			//entity.Khoa = (Convert.IsDBNull(reader["Khoa"]))?string.Empty:(System.String)reader["Khoa"];
			entity.MaCanBoGiangDay = reader.IsDBNull(reader.GetOrdinal("MaCanBoGiangDay")) ? null : (System.String)reader["MaCanBoGiangDay"];
			//entity.MaCanBoGiangDay = (Convert.IsDBNull(reader["MaCanBoGiangDay"]))?string.Empty:(System.String)reader["MaCanBoGiangDay"];
			entity.HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? null : (System.String)reader["HoTen"];
			//entity.HoTen = (Convert.IsDBNull(reader["HoTen"]))?string.Empty:(System.String)reader["HoTen"];
			entity.TienDo = (System.String)reader["TienDo"];
			//entity.TienDo = (Convert.IsDBNull(reader["TienDo"]))?string.Empty:(System.String)reader["TienDo"];
			entity.SiSo = reader.IsDBNull(reader.GetOrdinal("SiSo")) ? null : (System.Int32?)reader["SiSo"];
			//entity.SiSo = (Convert.IsDBNull(reader["SiSo"]))?(int)0:(System.Int32?)reader["SiSo"];
			entity.MaViPham = reader.IsDBNull(reader.GetOrdinal("MaViPham")) ? null : (System.String)reader["MaViPham"];
			//entity.MaViPham = (Convert.IsDBNull(reader["MaViPham"]))?string.Empty:(System.String)reader["MaViPham"];
			entity.NoiDungViPham = reader.IsDBNull(reader.GetOrdinal("NoiDungViPham")) ? null : (System.String)reader["NoiDungViPham"];
			//entity.NoiDungViPham = (Convert.IsDBNull(reader["NoiDungViPham"]))?string.Empty:(System.String)reader["NoiDungViPham"];
			entity.MaHinhThucViPhamHrm = reader.IsDBNull(reader.GetOrdinal("MaHinhThucViPhamHrm")) ? null : (System.Guid?)reader["MaHinhThucViPhamHrm"];
			//entity.MaHinhThucViPhamHrm = (Convert.IsDBNull(reader["MaHinhThucViPhamHrm"]))?Guid.Empty:(System.Guid?)reader["MaHinhThucViPhamHrm"];
			entity.TenHinhThucViPham = reader.IsDBNull(reader.GetOrdinal("TenHinhThucViPham")) ? null : (System.String)reader["TenHinhThucViPham"];
			//entity.TenHinhThucViPham = (Convert.IsDBNull(reader["TenHinhThucViPham"]))?string.Empty:(System.String)reader["TenHinhThucViPham"];
			entity.ThoiDiemGhiNhan = reader.IsDBNull(reader.GetOrdinal("ThoiDiemGhiNhan")) ? null : (System.String)reader["ThoiDiemGhiNhan"];
			//entity.ThoiDiemGhiNhan = (Convert.IsDBNull(reader["ThoiDiemGhiNhan"]))?string.Empty:(System.String)reader["ThoiDiemGhiNhan"];
			entity.LyDo = reader.IsDBNull(reader.GetOrdinal("LyDo")) ? null : (System.String)reader["LyDo"];
			//entity.LyDo = (Convert.IsDBNull(reader["LyDo"]))?string.Empty:(System.String)reader["LyDo"];
			entity.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : (System.String)reader["GhiChu"];
			//entity.GhiChu = (Convert.IsDBNull(reader["GhiChu"]))?string.Empty:(System.String)reader["GhiChu"];
			entity.NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (System.String)reader["NgayCapNhat"];
			//entity.NgayCapNhat = (Convert.IsDBNull(reader["NgayCapNhat"]))?string.Empty:(System.String)reader["NgayCapNhat"];
			entity.NguoiCapNhat = reader.IsDBNull(reader.GetOrdinal("NguoiCapNhat")) ? null : (System.String)reader["NguoiCapNhat"];
			//entity.NguoiCapNhat = (Convert.IsDBNull(reader["NguoiCapNhat"]))?string.Empty:(System.String)reader["NguoiCapNhat"];
			entity.SoTietGhiNhan = reader.IsDBNull(reader.GetOrdinal("SoTietGhiNhan")) ? null : (System.Int32?)reader["SoTietGhiNhan"];
			//entity.SoTietGhiNhan = (Convert.IsDBNull(reader["SoTietGhiNhan"]))?(int)0:(System.Int32?)reader["SoTietGhiNhan"];
			entity.XacNhan = reader.IsDBNull(reader.GetOrdinal("XacNhan")) ? null : (System.Boolean?)reader["XacNhan"];
			//entity.XacNhan = (Convert.IsDBNull(reader["XacNhan"]))?false:(System.Boolean?)reader["XacNhan"];
			entity.TrangThai = reader.IsDBNull(reader.GetOrdinal("TrangThai")) ? null : (System.Boolean?)reader["TrangThai"];
			//entity.TrangThai = (Convert.IsDBNull(reader["TrangThai"]))?false:(System.Boolean?)reader["TrangThai"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ViewThanhTraTheoThoiKhoaBieu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ViewThanhTraTheoThoiKhoaBieu"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ViewThanhTraTheoThoiKhoaBieu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLichHoc = (Convert.IsDBNull(dataRow["MaLichHoc"]))?(int)0:(System.Int32)dataRow["MaLichHoc"];
			entity.MaGocLopHocPhan = (Convert.IsDBNull(dataRow["MaGocLopHocPhan"]))?string.Empty:(System.String)dataRow["MaGocLopHocPhan"];
			entity.MaLopHocPhan = (Convert.IsDBNull(dataRow["MaLopHocPhan"]))?string.Empty:(System.String)dataRow["MaLopHocPhan"];
			entity.MaHocPhan = (Convert.IsDBNull(dataRow["MaHocPhan"]))?string.Empty:(System.String)dataRow["MaHocPhan"];
			entity.TenHocPhan = (Convert.IsDBNull(dataRow["TenHocPhan"]))?string.Empty:(System.String)dataRow["TenHocPhan"];
			entity.LoaiHocPhan = (Convert.IsDBNull(dataRow["LoaiHocPhan"]))?string.Empty:(System.String)dataRow["LoaiHocPhan"];
			entity.MaLop = (Convert.IsDBNull(dataRow["MaLop"]))?string.Empty:(System.String)dataRow["MaLop"];
			entity.Ngay = (Convert.IsDBNull(dataRow["Ngay"]))?string.Empty:(System.String)dataRow["Ngay"];
			entity.Thu = (Convert.IsDBNull(dataRow["Thu"]))?string.Empty:(System.String)dataRow["Thu"];
			entity.TietBatDau = (Convert.IsDBNull(dataRow["TietBatDau"]))?(int)0:(System.Int32?)dataRow["TietBatDau"];
			entity.SoTiet = (Convert.IsDBNull(dataRow["SoTiet"]))?(int)0:(System.Int32?)dataRow["SoTiet"];
			entity.Phong = (Convert.IsDBNull(dataRow["Phong"]))?string.Empty:(System.String)dataRow["Phong"];
			entity.Khoa = (Convert.IsDBNull(dataRow["Khoa"]))?string.Empty:(System.String)dataRow["Khoa"];
			entity.MaCanBoGiangDay = (Convert.IsDBNull(dataRow["MaCanBoGiangDay"]))?string.Empty:(System.String)dataRow["MaCanBoGiangDay"];
			entity.HoTen = (Convert.IsDBNull(dataRow["HoTen"]))?string.Empty:(System.String)dataRow["HoTen"];
			entity.TienDo = (Convert.IsDBNull(dataRow["TienDo"]))?string.Empty:(System.String)dataRow["TienDo"];
			entity.SiSo = (Convert.IsDBNull(dataRow["SiSo"]))?(int)0:(System.Int32?)dataRow["SiSo"];
			entity.MaViPham = (Convert.IsDBNull(dataRow["MaViPham"]))?string.Empty:(System.String)dataRow["MaViPham"];
			entity.NoiDungViPham = (Convert.IsDBNull(dataRow["NoiDungViPham"]))?string.Empty:(System.String)dataRow["NoiDungViPham"];
			entity.MaHinhThucViPhamHrm = (Convert.IsDBNull(dataRow["MaHinhThucViPhamHrm"]))?Guid.Empty:(System.Guid?)dataRow["MaHinhThucViPhamHrm"];
			entity.TenHinhThucViPham = (Convert.IsDBNull(dataRow["TenHinhThucViPham"]))?string.Empty:(System.String)dataRow["TenHinhThucViPham"];
			entity.ThoiDiemGhiNhan = (Convert.IsDBNull(dataRow["ThoiDiemGhiNhan"]))?string.Empty:(System.String)dataRow["ThoiDiemGhiNhan"];
			entity.LyDo = (Convert.IsDBNull(dataRow["LyDo"]))?string.Empty:(System.String)dataRow["LyDo"];
			entity.GhiChu = (Convert.IsDBNull(dataRow["GhiChu"]))?string.Empty:(System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = (Convert.IsDBNull(dataRow["NgayCapNhat"]))?string.Empty:(System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = (Convert.IsDBNull(dataRow["NguoiCapNhat"]))?string.Empty:(System.String)dataRow["NguoiCapNhat"];
			entity.SoTietGhiNhan = (Convert.IsDBNull(dataRow["SoTietGhiNhan"]))?(int)0:(System.Int32?)dataRow["SoTietGhiNhan"];
			entity.XacNhan = (Convert.IsDBNull(dataRow["XacNhan"]))?false:(System.Boolean?)dataRow["XacNhan"];
			entity.TrangThai = (Convert.IsDBNull(dataRow["TrangThai"]))?false:(System.Boolean?)dataRow["TrangThai"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ViewThanhTraTheoThoiKhoaBieuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraTheoThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraTheoThoiKhoaBieuFilterBuilder : SqlFilterBuilder<ViewThanhTraTheoThoiKhoaBieuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraTheoThoiKhoaBieuFilterBuilder class.
		/// </summary>
		public ViewThanhTraTheoThoiKhoaBieuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraTheoThoiKhoaBieuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThanhTraTheoThoiKhoaBieuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraTheoThoiKhoaBieuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThanhTraTheoThoiKhoaBieuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThanhTraTheoThoiKhoaBieuFilterBuilder

	#region ViewThanhTraTheoThoiKhoaBieuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraTheoThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraTheoThoiKhoaBieuParameterBuilder : ParameterizedSqlFilterBuilder<ViewThanhTraTheoThoiKhoaBieuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraTheoThoiKhoaBieuParameterBuilder class.
		/// </summary>
		public ViewThanhTraTheoThoiKhoaBieuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraTheoThoiKhoaBieuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ViewThanhTraTheoThoiKhoaBieuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraTheoThoiKhoaBieuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ViewThanhTraTheoThoiKhoaBieuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ViewThanhTraTheoThoiKhoaBieuParameterBuilder
	
	#region ViewThanhTraTheoThoiKhoaBieuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraTheoThoiKhoaBieu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ViewThanhTraTheoThoiKhoaBieuSortBuilder : SqlSortBuilder<ViewThanhTraTheoThoiKhoaBieuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraTheoThoiKhoaBieuSqlSortBuilder class.
		/// </summary>
		public ViewThanhTraTheoThoiKhoaBieuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ViewThanhTraTheoThoiKhoaBieuSortBuilder

} // end namespace
