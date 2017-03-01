#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="ThanhTraTheoThoiKhoaBieuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ThanhTraTheoThoiKhoaBieuProviderBaseCore : EntityProviderBase<PMS.Entities.ThanhTraTheoThoiKhoaBieu, PMS.Entities.ThanhTraTheoThoiKhoaBieuKey>
	{		
		#region Get from Many To Many Relationship Functions
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.ThanhTraTheoThoiKhoaBieuKey key)
		{
			return Delete(transactionManager, key.MaLichHoc, key.MaCanBoGiangDay);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maLichHoc">. Primary Key.</param>
		/// <param name="_maCanBoGiangDay">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maLichHoc, System.String _maCanBoGiangDay)
		{
			return Delete(null, _maLichHoc, _maCanBoGiangDay);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLichHoc">. Primary Key.</param>
		/// <param name="_maCanBoGiangDay">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maLichHoc, System.String _maCanBoGiangDay);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
		#endregion

		#region Get By Index Functions
		
		/// <summary>
		/// 	Gets a row from the DataSource based on its primary key.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public override PMS.Entities.ThanhTraTheoThoiKhoaBieu Get(TransactionManager transactionManager, PMS.Entities.ThanhTraTheoThoiKhoaBieuKey key, int start, int pageLength)
		{
			return GetByMaLichHocMaCanBoGiangDay(transactionManager, key.MaLichHoc, key.MaCanBoGiangDay, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ThanhTraTheoThoiKhoaBieu index.
		/// </summary>
		/// <param name="_maLichHoc"></param>
		/// <param name="_maCanBoGiangDay"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraTheoThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.ThanhTraTheoThoiKhoaBieu GetByMaLichHocMaCanBoGiangDay(System.Int32 _maLichHoc, System.String _maCanBoGiangDay)
		{
			int count = -1;
			return GetByMaLichHocMaCanBoGiangDay(null,_maLichHoc, _maCanBoGiangDay, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraTheoThoiKhoaBieu index.
		/// </summary>
		/// <param name="_maLichHoc"></param>
		/// <param name="_maCanBoGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraTheoThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.ThanhTraTheoThoiKhoaBieu GetByMaLichHocMaCanBoGiangDay(System.Int32 _maLichHoc, System.String _maCanBoGiangDay, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLichHocMaCanBoGiangDay(null, _maLichHoc, _maCanBoGiangDay, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraTheoThoiKhoaBieu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLichHoc"></param>
		/// <param name="_maCanBoGiangDay"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraTheoThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.ThanhTraTheoThoiKhoaBieu GetByMaLichHocMaCanBoGiangDay(TransactionManager transactionManager, System.Int32 _maLichHoc, System.String _maCanBoGiangDay)
		{
			int count = -1;
			return GetByMaLichHocMaCanBoGiangDay(transactionManager, _maLichHoc, _maCanBoGiangDay, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraTheoThoiKhoaBieu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLichHoc"></param>
		/// <param name="_maCanBoGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraTheoThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.ThanhTraTheoThoiKhoaBieu GetByMaLichHocMaCanBoGiangDay(TransactionManager transactionManager, System.Int32 _maLichHoc, System.String _maCanBoGiangDay, int start, int pageLength)
		{
			int count = -1;
			return GetByMaLichHocMaCanBoGiangDay(transactionManager, _maLichHoc, _maCanBoGiangDay, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraTheoThoiKhoaBieu index.
		/// </summary>
		/// <param name="_maLichHoc"></param>
		/// <param name="_maCanBoGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraTheoThoiKhoaBieu"/> class.</returns>
		public PMS.Entities.ThanhTraTheoThoiKhoaBieu GetByMaLichHocMaCanBoGiangDay(System.Int32 _maLichHoc, System.String _maCanBoGiangDay, int start, int pageLength, out int count)
		{
			return GetByMaLichHocMaCanBoGiangDay(null, _maLichHoc, _maCanBoGiangDay, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ThanhTraTheoThoiKhoaBieu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maLichHoc"></param>
		/// <param name="_maCanBoGiangDay"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.ThanhTraTheoThoiKhoaBieu"/> class.</returns>
		public abstract PMS.Entities.ThanhTraTheoThoiKhoaBieu GetByMaLichHocMaCanBoGiangDay(TransactionManager transactionManager, System.Int32 _maLichHoc, System.String _maCanBoGiangDay, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTheoHocKyMaDonVi 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTheoHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopTheoHocKyMaDonVi(System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return ThongKeTongHopTheoHocKyMaDonVi(null, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTheoHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopTheoHocKyMaDonVi(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return ThongKeTongHopTheoHocKyMaDonVi(null, start, pageLength , namHoc, hocKy, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTheoHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopTheoHocKyMaDonVi(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maDonVi)
		{
			return ThongKeTongHopTheoHocKyMaDonVi(transactionManager, 0, int.MaxValue , namHoc, hocKy, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTheoHocKyMaDonVi' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTongHopTheoHocKyMaDonVi(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maDonVi);
		
		#endregion
		
		#region cust_ThanhTraTheoThoiKhoaBieu_QuyDoi 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(System.String xmlData)
		{
			 QuyDoi(null, 0, int.MaxValue , xmlData);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(int start, int pageLength, System.String xmlData)
		{
			 QuyDoi(null, start, pageLength , xmlData);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void QuyDoi(TransactionManager transactionManager, System.String xmlData)
		{
			 QuyDoi(transactionManager, 0, int.MaxValue , xmlData);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_QuyDoi' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void QuyDoi(TransactionManager transactionManager, int start, int pageLength , System.String xmlData);
		
		#endregion
		
		#region cust_ThanhTraTheoThoiKhoaBieu_KiemTraGioChamThanhTra 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_KiemTraGioChamThanhTra' stored procedure. 
		/// </summary>
		/// <param name="ngayDay"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraGioChamThanhTra(System.String ngayDay, ref System.Boolean reVal)
		{
			 KiemTraGioChamThanhTra(null, 0, int.MaxValue , ngayDay, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_KiemTraGioChamThanhTra' stored procedure. 
		/// </summary>
		/// <param name="ngayDay"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraGioChamThanhTra(int start, int pageLength, System.String ngayDay, ref System.Boolean reVal)
		{
			 KiemTraGioChamThanhTra(null, start, pageLength , ngayDay, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_KiemTraGioChamThanhTra' stored procedure. 
		/// </summary>
		/// <param name="ngayDay"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraGioChamThanhTra(TransactionManager transactionManager, System.String ngayDay, ref System.Boolean reVal)
		{
			 KiemTraGioChamThanhTra(transactionManager, 0, int.MaxValue , ngayDay, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_KiemTraGioChamThanhTra' stored procedure. 
		/// </summary>
		/// <param name="ngayDay"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraGioChamThanhTra(TransactionManager transactionManager, int start, int pageLength , System.String ngayDay, ref System.Boolean reVal);
		
		#endregion
		
		#region cust_ThanhTraTheoThoiKhoaBieu_ThongKeGioThucGiangDaQuyDoiTheoLoaiGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeGioThucGiangDaQuyDoiTheoLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioThucGiangDaQuyDoiTheoLoaiGiangVien(System.DateTime tuNgay, System.DateTime denNgay, System.Int32 maLoaiGiangVien, System.String maDonVi)
		{
			return ThongKeGioThucGiangDaQuyDoiTheoLoaiGiangVien(null, 0, int.MaxValue , tuNgay, denNgay, maLoaiGiangVien, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeGioThucGiangDaQuyDoiTheoLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioThucGiangDaQuyDoiTheoLoaiGiangVien(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.Int32 maLoaiGiangVien, System.String maDonVi)
		{
			return ThongKeGioThucGiangDaQuyDoiTheoLoaiGiangVien(null, start, pageLength , tuNgay, denNgay, maLoaiGiangVien, maDonVi);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeGioThucGiangDaQuyDoiTheoLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeGioThucGiangDaQuyDoiTheoLoaiGiangVien(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay, System.Int32 maLoaiGiangVien, System.String maDonVi)
		{
			return ThongKeGioThucGiangDaQuyDoiTheoLoaiGiangVien(transactionManager, 0, int.MaxValue , tuNgay, denNgay, maLoaiGiangVien, maDonVi);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeGioThucGiangDaQuyDoiTheoLoaiGiangVien' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="maDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeGioThucGiangDaQuyDoiTheoLoaiGiangVien(TransactionManager transactionManager, int start, int pageLength , System.DateTime tuNgay, System.DateTime denNgay, System.Int32 maLoaiGiangVien, System.String maDonVi);
		
		#endregion
		
		#region cust_ThanhTraTheoThoiKhoaBieu_GetByNgayCoSoToaNha 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetByNgayCoSoToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNgayCoSoToaNha(System.String tuNgay, System.String denNgay, System.String toaNha)
		{
			return GetByNgayCoSoToaNha(null, 0, int.MaxValue , tuNgay, denNgay, toaNha);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetByNgayCoSoToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNgayCoSoToaNha(int start, int pageLength, System.String tuNgay, System.String denNgay, System.String toaNha)
		{
			return GetByNgayCoSoToaNha(null, start, pageLength , tuNgay, denNgay, toaNha);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetByNgayCoSoToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByNgayCoSoToaNha(TransactionManager transactionManager, System.String tuNgay, System.String denNgay, System.String toaNha)
		{
			return GetByNgayCoSoToaNha(transactionManager, 0, int.MaxValue , tuNgay, denNgay, toaNha);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetByNgayCoSoToaNha' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.String</c> instance.</param>
		/// <param name="denNgay"> A <c>System.String</c> instance.</param>
		/// <param name="toaNha"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByNgayCoSoToaNha(TransactionManager transactionManager, int start, int pageLength , System.String tuNgay, System.String denNgay, System.String toaNha);
		
		#endregion
		
		#region cust_ThanhTraTheoThoiKhoaBieu_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThanhTraTheoThoiKhoaBieu_KiemTraThoiHanChamThanhTra 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_KiemTraThoiHanChamThanhTra' stored procedure. 
		/// </summary>
		/// <param name="ngayDay"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Boolean</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraThoiHanChamThanhTra(System.String ngayDay, ref System.Boolean reVal)
		{
			 KiemTraThoiHanChamThanhTra(null, 0, int.MaxValue , ngayDay, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_KiemTraThoiHanChamThanhTra' stored procedure. 
		/// </summary>
		/// <param name="ngayDay"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraThoiHanChamThanhTra(int start, int pageLength, System.String ngayDay, ref System.Boolean reVal)
		{
			 KiemTraThoiHanChamThanhTra(null, start, pageLength , ngayDay, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_KiemTraThoiHanChamThanhTra' stored procedure. 
		/// </summary>
		/// <param name="ngayDay"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Boolean</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraThoiHanChamThanhTra(TransactionManager transactionManager, System.String ngayDay, ref System.Boolean reVal)
		{
			 KiemTraThoiHanChamThanhTra(transactionManager, 0, int.MaxValue , ngayDay, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_KiemTraThoiHanChamThanhTra' stored procedure. 
		/// </summary>
		/// <param name="ngayDay"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Boolean</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraThoiHanChamThanhTra(TransactionManager transactionManager, int start, int pageLength , System.String ngayDay, ref System.Boolean reVal);
		
		#endregion
		
		#region cust_ThanhTraTheoThoiKhoaBieu_ThongKeCongViecKhongPhuHop 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeCongViecKhongPhuHop' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiThieuSot"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeCongViecKhongPhuHop(System.DateTime tuNgay, System.DateTime denNgay, System.String khoaDonVi, System.String loaiThieuSot)
		{
			return ThongKeCongViecKhongPhuHop(null, 0, int.MaxValue , tuNgay, denNgay, khoaDonVi, loaiThieuSot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeCongViecKhongPhuHop' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiThieuSot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeCongViecKhongPhuHop(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.String khoaDonVi, System.String loaiThieuSot)
		{
			return ThongKeCongViecKhongPhuHop(null, start, pageLength , tuNgay, denNgay, khoaDonVi, loaiThieuSot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeCongViecKhongPhuHop' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiThieuSot"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeCongViecKhongPhuHop(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay, System.String khoaDonVi, System.String loaiThieuSot)
		{
			return ThongKeCongViecKhongPhuHop(transactionManager, 0, int.MaxValue , tuNgay, denNgay, khoaDonVi, loaiThieuSot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeCongViecKhongPhuHop' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiThieuSot"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeCongViecKhongPhuHop(TransactionManager transactionManager, int start, int pageLength , System.DateTime tuNgay, System.DateTime denNgay, System.String khoaDonVi, System.String loaiThieuSot);
		
		#endregion
		
		#region cust_ThanhTraTheoThoiKhoaBieu_GetMaLopHocPhanByMaCanBoGiangDayNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetMaLopHocPhanByMaCanBoGiangDayNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMaLopHocPhanByMaCanBoGiangDayNamHocHocKy(System.String maCanBoGiangDay, System.String namHoc, System.String hocKy)
		{
			return GetMaLopHocPhanByMaCanBoGiangDayNamHocHocKy(null, 0, int.MaxValue , maCanBoGiangDay, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetMaLopHocPhanByMaCanBoGiangDayNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMaLopHocPhanByMaCanBoGiangDayNamHocHocKy(int start, int pageLength, System.String maCanBoGiangDay, System.String namHoc, System.String hocKy)
		{
			return GetMaLopHocPhanByMaCanBoGiangDayNamHocHocKy(null, start, pageLength , maCanBoGiangDay, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetMaLopHocPhanByMaCanBoGiangDayNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetMaLopHocPhanByMaCanBoGiangDayNamHocHocKy(TransactionManager transactionManager, System.String maCanBoGiangDay, System.String namHoc, System.String hocKy)
		{
			return GetMaLopHocPhanByMaCanBoGiangDayNamHocHocKy(transactionManager, 0, int.MaxValue , maCanBoGiangDay, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetMaLopHocPhanByMaCanBoGiangDayNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetMaLopHocPhanByMaCanBoGiangDayNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String maCanBoGiangDay, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_ThanhTraTheoThoiKhoaBieu_Import 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(System.String xmlData, ref System.Int32 reVal)
		{
			 Import(null, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(int start, int pageLength, System.String xmlData, ref System.Int32 reVal)
		{
			 Import(null, start, pageLength , xmlData, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Import(TransactionManager transactionManager, System.String xmlData, ref System.Int32 reVal)
		{
			 Import(transactionManager, 0, int.MaxValue , xmlData, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_Import' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Import(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_ThanhTraTheoThoiKhoaBieu_GetThanhTraByGiangVien 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetThanhTraByGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThanhTraByGiangVien(System.String maCanBoGiangDay, System.String namHoc, System.String hocKy, System.String maLopHocPhan)
		{
			return GetThanhTraByGiangVien(null, 0, int.MaxValue , maCanBoGiangDay, namHoc, hocKy, maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetThanhTraByGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThanhTraByGiangVien(int start, int pageLength, System.String maCanBoGiangDay, System.String namHoc, System.String hocKy, System.String maLopHocPhan)
		{
			return GetThanhTraByGiangVien(null, start, pageLength , maCanBoGiangDay, namHoc, hocKy, maLopHocPhan);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetThanhTraByGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetThanhTraByGiangVien(TransactionManager transactionManager, System.String maCanBoGiangDay, System.String namHoc, System.String hocKy, System.String maLopHocPhan)
		{
			return GetThanhTraByGiangVien(transactionManager, 0, int.MaxValue , maCanBoGiangDay, namHoc, hocKy, maLopHocPhan);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetThanhTraByGiangVien' stored procedure. 
		/// </summary>
		/// <param name="maCanBoGiangDay"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maLopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetThanhTraByGiangVien(TransactionManager transactionManager, int start, int pageLength , System.String maCanBoGiangDay, System.String namHoc, System.String hocKy, System.String maLopHocPhan);
		
		#endregion
		
		#region cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTheoHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopTheoHocKy(System.String namHoc, System.String hocKy, System.String maQuanLy)
		{
			return ThongKeTongHopTheoHocKy(null, 0, int.MaxValue , namHoc, hocKy, maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopTheoHocKy(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maQuanLy)
		{
			return ThongKeTongHopTheoHocKy(null, start, pageLength , namHoc, hocKy, maQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopTheoHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maQuanLy)
		{
			return ThongKeTongHopTheoHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy, maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTheoHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTongHopTheoHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maQuanLy);
		
		#endregion
		
		#region cust_ThanhTraTheoThoiKhoaBieu_SoSanhChiTietLopHocPhan 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_SoSanhChiTietLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="malopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="loai"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader SoSanhChiTietLopHocPhan(System.String malopHocPhan, System.String loai)
		{
			return SoSanhChiTietLopHocPhan(null, 0, int.MaxValue , malopHocPhan, loai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_SoSanhChiTietLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="malopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="loai"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader SoSanhChiTietLopHocPhan(int start, int pageLength, System.String malopHocPhan, System.String loai)
		{
			return SoSanhChiTietLopHocPhan(null, start, pageLength , malopHocPhan, loai);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_SoSanhChiTietLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="malopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="loai"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader SoSanhChiTietLopHocPhan(TransactionManager transactionManager, System.String malopHocPhan, System.String loai)
		{
			return SoSanhChiTietLopHocPhan(transactionManager, 0, int.MaxValue , malopHocPhan, loai);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_SoSanhChiTietLopHocPhan' stored procedure. 
		/// </summary>
		/// <param name="malopHocPhan"> A <c>System.String</c> instance.</param>
		/// <param name="loai"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader SoSanhChiTietLopHocPhan(TransactionManager transactionManager, int start, int pageLength , System.String malopHocPhan, System.String loai);
		
		#endregion
		
		#region cust_ThanhTraTheoThoiKhoaBieu_GetByMaGiangVienTuNgayDenNgay 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetByMaGiangVienTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienTuNgayDenNgay(System.String maQuanLy, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByMaGiangVienTuNgayDenNgay(null, 0, int.MaxValue , maQuanLy, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetByMaGiangVienTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienTuNgayDenNgay(int start, int pageLength, System.String maQuanLy, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByMaGiangVienTuNgayDenNgay(null, start, pageLength , maQuanLy, tuNgay, denNgay);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetByMaGiangVienTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GetByMaGiangVienTuNgayDenNgay(TransactionManager transactionManager, System.String maQuanLy, System.DateTime tuNgay, System.DateTime denNgay)
		{
			return GetByMaGiangVienTuNgayDenNgay(transactionManager, 0, int.MaxValue , maQuanLy, tuNgay, denNgay);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_GetByMaGiangVienTuNgayDenNgay' stored procedure. 
		/// </summary>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GetByMaGiangVienTuNgayDenNgay(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLy, System.DateTime tuNgay, System.DateTime denNgay);
		
		#endregion
		
		#region cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTungGiangVienTheoNgay 
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTungGiangVienTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopTungGiangVienTheoNgay(System.DateTime tuNgay, System.DateTime denNgay, System.String maQuanLy)
		{
			return ThongKeTongHopTungGiangVienTheoNgay(null, 0, int.MaxValue , tuNgay, denNgay, maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTungGiangVienTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopTungGiangVienTheoNgay(int start, int pageLength, System.DateTime tuNgay, System.DateTime denNgay, System.String maQuanLy)
		{
			return ThongKeTongHopTungGiangVienTheoNgay(null, start, pageLength , tuNgay, denNgay, maQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTungGiangVienTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHopTungGiangVienTheoNgay(TransactionManager transactionManager, System.DateTime tuNgay, System.DateTime denNgay, System.String maQuanLy)
		{
			return ThongKeTongHopTungGiangVienTheoNgay(transactionManager, 0, int.MaxValue , tuNgay, denNgay, maQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_ThanhTraTheoThoiKhoaBieu_ThongKeTongHopTungGiangVienTheoNgay' stored procedure. 
		/// </summary>
		/// <param name="tuNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="denNgay"> A <c>System.DateTime</c> instance.</param>
		/// <param name="maQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTongHopTungGiangVienTheoNgay(TransactionManager transactionManager, int start, int pageLength , System.DateTime tuNgay, System.DateTime denNgay, System.String maQuanLy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ThanhTraTheoThoiKhoaBieu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ThanhTraTheoThoiKhoaBieu&gt;"/></returns>
		public static TList<ThanhTraTheoThoiKhoaBieu> Fill(IDataReader reader, TList<ThanhTraTheoThoiKhoaBieu> rows, int start, int pageLength)
		{
			NetTiersProvider currentProvider = DataRepository.Provider;
            bool useEntityFactory = currentProvider.UseEntityFactory;
            bool enableEntityTracking = currentProvider.EnableEntityTracking;
            LoadPolicy currentLoadPolicy = currentProvider.CurrentLoadPolicy;
			Type entityCreationFactoryType = currentProvider.EntityCreationalFactoryType;
			
			// advance to the starting row
			for (int i = 0; i < start; i++)
			{
				if (!reader.Read())
				return rows; // not enough rows, just return
			}
			for (int i = 0; i < pageLength; i++)
			{
				if (!reader.Read())
					break; // we are done
					
				string key = null;
				
				PMS.Entities.ThanhTraTheoThoiKhoaBieu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ThanhTraTheoThoiKhoaBieu")
					.Append("|").Append((System.Int32)reader[((int)ThanhTraTheoThoiKhoaBieuColumn.MaLichHoc - 1)])
					.Append("|").Append((System.String)reader[((int)ThanhTraTheoThoiKhoaBieuColumn.MaCanBoGiangDay - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ThanhTraTheoThoiKhoaBieu>(
					key.ToString(), // EntityTrackingKey
					"ThanhTraTheoThoiKhoaBieu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.ThanhTraTheoThoiKhoaBieu();
				}
				
				if (!enableEntityTracking ||
					c.EntityState == EntityState.Added ||
					(enableEntityTracking &&
					
						(
							(currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) ||
							(currentLoadPolicy == LoadPolicy.DiscardChanges && c.EntityState != EntityState.Unchanged)
						)
					))
				{
					c.SuppressEntityEvents = true;
					c.MaLichHoc = (System.Int32)reader[(ThanhTraTheoThoiKhoaBieuColumn.MaLichHoc.ToString())];
					c.OriginalMaLichHoc = c.MaLichHoc;
					c.MaViPham = (reader[ThanhTraTheoThoiKhoaBieuColumn.MaViPham.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.MaViPham.ToString())];
					c.MaHinhThucViPhamHrm = (reader[ThanhTraTheoThoiKhoaBieuColumn.MaHinhThucViPhamHrm.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(ThanhTraTheoThoiKhoaBieuColumn.MaHinhThucViPhamHrm.ToString())];
					c.SiSo = (reader[ThanhTraTheoThoiKhoaBieuColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraTheoThoiKhoaBieuColumn.SiSo.ToString())];
					c.ThoiDiemGhiNhan = (reader[ThanhTraTheoThoiKhoaBieuColumn.ThoiDiemGhiNhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.ThoiDiemGhiNhan.ToString())];
					c.LyDo = (reader[ThanhTraTheoThoiKhoaBieuColumn.LyDo.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.LyDo.ToString())];
					c.GhiChu = (reader[ThanhTraTheoThoiKhoaBieuColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.GhiChu.ToString())];
					c.NgayCapNhat = (reader[ThanhTraTheoThoiKhoaBieuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[ThanhTraTheoThoiKhoaBieuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.NguoiCapNhat.ToString())];
					c.MaMonHoc = (reader[ThanhTraTheoThoiKhoaBieuColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.MaMonHoc.ToString())];
					c.MaLopHocPhan = (reader[ThanhTraTheoThoiKhoaBieuColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.MaLopHocPhan.ToString())];
					c.SoTietGhiNhan = (reader[ThanhTraTheoThoiKhoaBieuColumn.SoTietGhiNhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraTheoThoiKhoaBieuColumn.SoTietGhiNhan.ToString())];
					c.MaCanBoGiangDay = (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.MaCanBoGiangDay.ToString())];
					c.OriginalMaCanBoGiangDay = c.MaCanBoGiangDay;
					c.Ngay = (reader[ThanhTraTheoThoiKhoaBieuColumn.Ngay.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.Ngay.ToString())];
					c.TietBatDau = (reader[ThanhTraTheoThoiKhoaBieuColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraTheoThoiKhoaBieuColumn.TietBatDau.ToString())];
					c.SoTiet = (reader[ThanhTraTheoThoiKhoaBieuColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhTraTheoThoiKhoaBieuColumn.SoTiet.ToString())];
					c.Phong = (reader[ThanhTraTheoThoiKhoaBieuColumn.Phong.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.Phong.ToString())];
					c.XacNhan = (reader[ThanhTraTheoThoiKhoaBieuColumn.XacNhan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThanhTraTheoThoiKhoaBieuColumn.XacNhan.ToString())];
					c.SoTietQuyDoi = (reader[ThanhTraTheoThoiKhoaBieuColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhTraTheoThoiKhoaBieuColumn.SoTietQuyDoi.ToString())];
					c.DaXacNhan = (reader[ThanhTraTheoThoiKhoaBieuColumn.DaXacNhan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThanhTraTheoThoiKhoaBieuColumn.DaXacNhan.ToString())];
					c.ThanhLy = (reader[ThanhTraTheoThoiKhoaBieuColumn.ThanhLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.ThanhLy.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThanhTraTheoThoiKhoaBieu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThanhTraTheoThoiKhoaBieu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.ThanhTraTheoThoiKhoaBieu entity)
		{
			if (!reader.Read()) return;
			
			entity.MaLichHoc = (System.Int32)reader[(ThanhTraTheoThoiKhoaBieuColumn.MaLichHoc.ToString())];
			entity.OriginalMaLichHoc = (System.Int32)reader["MaLichHoc"];
			entity.MaViPham = (reader[ThanhTraTheoThoiKhoaBieuColumn.MaViPham.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.MaViPham.ToString())];
			entity.MaHinhThucViPhamHrm = (reader[ThanhTraTheoThoiKhoaBieuColumn.MaHinhThucViPhamHrm.ToString()] == DBNull.Value) ? null : (System.Guid?)reader[(ThanhTraTheoThoiKhoaBieuColumn.MaHinhThucViPhamHrm.ToString())];
			entity.SiSo = (reader[ThanhTraTheoThoiKhoaBieuColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraTheoThoiKhoaBieuColumn.SiSo.ToString())];
			entity.ThoiDiemGhiNhan = (reader[ThanhTraTheoThoiKhoaBieuColumn.ThoiDiemGhiNhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.ThoiDiemGhiNhan.ToString())];
			entity.LyDo = (reader[ThanhTraTheoThoiKhoaBieuColumn.LyDo.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.LyDo.ToString())];
			entity.GhiChu = (reader[ThanhTraTheoThoiKhoaBieuColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.GhiChu.ToString())];
			entity.NgayCapNhat = (reader[ThanhTraTheoThoiKhoaBieuColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[ThanhTraTheoThoiKhoaBieuColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.NguoiCapNhat.ToString())];
			entity.MaMonHoc = (reader[ThanhTraTheoThoiKhoaBieuColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.MaMonHoc.ToString())];
			entity.MaLopHocPhan = (reader[ThanhTraTheoThoiKhoaBieuColumn.MaLopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.MaLopHocPhan.ToString())];
			entity.SoTietGhiNhan = (reader[ThanhTraTheoThoiKhoaBieuColumn.SoTietGhiNhan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraTheoThoiKhoaBieuColumn.SoTietGhiNhan.ToString())];
			entity.MaCanBoGiangDay = (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.MaCanBoGiangDay.ToString())];
			entity.OriginalMaCanBoGiangDay = (System.String)reader["MaCanBoGiangDay"];
			entity.Ngay = (reader[ThanhTraTheoThoiKhoaBieuColumn.Ngay.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.Ngay.ToString())];
			entity.TietBatDau = (reader[ThanhTraTheoThoiKhoaBieuColumn.TietBatDau.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(ThanhTraTheoThoiKhoaBieuColumn.TietBatDau.ToString())];
			entity.SoTiet = (reader[ThanhTraTheoThoiKhoaBieuColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhTraTheoThoiKhoaBieuColumn.SoTiet.ToString())];
			entity.Phong = (reader[ThanhTraTheoThoiKhoaBieuColumn.Phong.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.Phong.ToString())];
			entity.XacNhan = (reader[ThanhTraTheoThoiKhoaBieuColumn.XacNhan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThanhTraTheoThoiKhoaBieuColumn.XacNhan.ToString())];
			entity.SoTietQuyDoi = (reader[ThanhTraTheoThoiKhoaBieuColumn.SoTietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(ThanhTraTheoThoiKhoaBieuColumn.SoTietQuyDoi.ToString())];
			entity.DaXacNhan = (reader[ThanhTraTheoThoiKhoaBieuColumn.DaXacNhan.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(ThanhTraTheoThoiKhoaBieuColumn.DaXacNhan.ToString())];
			entity.ThanhLy = (reader[ThanhTraTheoThoiKhoaBieuColumn.ThanhLy.ToString()] == DBNull.Value) ? null : (System.String)reader[(ThanhTraTheoThoiKhoaBieuColumn.ThanhLy.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.ThanhTraTheoThoiKhoaBieu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThanhTraTheoThoiKhoaBieu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.ThanhTraTheoThoiKhoaBieu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaLichHoc = (System.Int32)dataRow["MaLichHoc"];
			entity.OriginalMaLichHoc = (System.Int32)dataRow["MaLichHoc"];
			entity.MaViPham = Convert.IsDBNull(dataRow["MaViPham"]) ? null : (System.String)dataRow["MaViPham"];
			entity.MaHinhThucViPhamHrm = Convert.IsDBNull(dataRow["MaHinhThucViPhamHrm"]) ? null : (System.Guid?)dataRow["MaHinhThucViPhamHrm"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.ThoiDiemGhiNhan = Convert.IsDBNull(dataRow["ThoiDiemGhiNhan"]) ? null : (System.String)dataRow["ThoiDiemGhiNhan"];
			entity.LyDo = Convert.IsDBNull(dataRow["LyDo"]) ? null : (System.String)dataRow["LyDo"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.MaLopHocPhan = Convert.IsDBNull(dataRow["MaLopHocPhan"]) ? null : (System.String)dataRow["MaLopHocPhan"];
			entity.SoTietGhiNhan = Convert.IsDBNull(dataRow["SoTietGhiNhan"]) ? null : (System.Int32?)dataRow["SoTietGhiNhan"];
			entity.MaCanBoGiangDay = (System.String)dataRow["MaCanBoGiangDay"];
			entity.OriginalMaCanBoGiangDay = (System.String)dataRow["MaCanBoGiangDay"];
			entity.Ngay = Convert.IsDBNull(dataRow["Ngay"]) ? null : (System.String)dataRow["Ngay"];
			entity.TietBatDau = Convert.IsDBNull(dataRow["TietBatDau"]) ? null : (System.Int32?)dataRow["TietBatDau"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.Phong = Convert.IsDBNull(dataRow["Phong"]) ? null : (System.String)dataRow["Phong"];
			entity.XacNhan = Convert.IsDBNull(dataRow["XacNhan"]) ? null : (System.Boolean?)dataRow["XacNhan"];
			entity.SoTietQuyDoi = Convert.IsDBNull(dataRow["SoTietQuyDoi"]) ? null : (System.Decimal?)dataRow["SoTietQuyDoi"];
			entity.DaXacNhan = Convert.IsDBNull(dataRow["DaXacNhan"]) ? null : (System.Boolean?)dataRow["DaXacNhan"];
			entity.ThanhLy = Convert.IsDBNull(dataRow["ThanhLy"]) ? null : (System.String)dataRow["ThanhLy"];
			entity.AcceptChanges();
		}
		#endregion 
		
		#region DeepLoad Methods
		/// <summary>
		/// Deep Loads the <see cref="IEntity"/> object with criteria based of the child 
		/// property collections only N Levels Deep based on the <see cref="DeepLoadType"/>.
		/// </summary>
		/// <remarks>
		/// Use this method with caution as it is possible to DeepLoad with Recursion and traverse an entire object graph.
		/// </remarks>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">The <see cref="PMS.Entities.ThanhTraTheoThoiKhoaBieu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.ThanhTraTheoThoiKhoaBieu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.ThanhTraTheoThoiKhoaBieu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
			//Fire all DeepLoad Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			deepHandles = null;
		}
		
		#endregion 
		
		#region DeepSave Methods

		/// <summary>
		/// Deep Save the entire object graph of the PMS.Entities.ThanhTraTheoThoiKhoaBieu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.ThanhTraTheoThoiKhoaBieu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.ThanhTraTheoThoiKhoaBieu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.ThanhTraTheoThoiKhoaBieu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			//Fire all DeepSave Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			
			// Save Root Entity through Provider, if not already saved in delete mode
			if (entity.IsDeleted)
				this.Save(transactionManager, entity);
				

			deepHandles = null;
						
			return true;
		}
		#endregion
	} // end class
	
	#region ThanhTraTheoThoiKhoaBieuChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.ThanhTraTheoThoiKhoaBieu</c>
	///</summary>
	public enum ThanhTraTheoThoiKhoaBieuChildEntityTypes
	{
	}
	
	#endregion ThanhTraTheoThoiKhoaBieuChildEntityTypes
	
	#region ThanhTraTheoThoiKhoaBieuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ThanhTraTheoThoiKhoaBieuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraTheoThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraTheoThoiKhoaBieuFilterBuilder : SqlFilterBuilder<ThanhTraTheoThoiKhoaBieuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraTheoThoiKhoaBieuFilterBuilder class.
		/// </summary>
		public ThanhTraTheoThoiKhoaBieuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraTheoThoiKhoaBieuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThanhTraTheoThoiKhoaBieuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraTheoThoiKhoaBieuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThanhTraTheoThoiKhoaBieuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThanhTraTheoThoiKhoaBieuFilterBuilder
	
	#region ThanhTraTheoThoiKhoaBieuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ThanhTraTheoThoiKhoaBieuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraTheoThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraTheoThoiKhoaBieuParameterBuilder : ParameterizedSqlFilterBuilder<ThanhTraTheoThoiKhoaBieuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraTheoThoiKhoaBieuParameterBuilder class.
		/// </summary>
		public ThanhTraTheoThoiKhoaBieuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraTheoThoiKhoaBieuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ThanhTraTheoThoiKhoaBieuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ThanhTraTheoThoiKhoaBieuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ThanhTraTheoThoiKhoaBieuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ThanhTraTheoThoiKhoaBieuParameterBuilder
	
	#region ThanhTraTheoThoiKhoaBieuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ThanhTraTheoThoiKhoaBieuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraTheoThoiKhoaBieu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ThanhTraTheoThoiKhoaBieuSortBuilder : SqlSortBuilder<ThanhTraTheoThoiKhoaBieuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraTheoThoiKhoaBieuSqlSortBuilder class.
		/// </summary>
		public ThanhTraTheoThoiKhoaBieuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ThanhTraTheoThoiKhoaBieuSortBuilder
	
} // end namespace
