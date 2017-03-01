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
	/// This class is the base class for any <see cref="GiangVienTamUngProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GiangVienTamUngProviderBaseCore : EntityProviderBase<PMS.Entities.GiangVienTamUng, PMS.Entities.GiangVienTamUngKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.GiangVienTamUngKey key)
		{
			return Delete(transactionManager, key.MaQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _maQuanLy)
		{
			return Delete(null, _maQuanLy);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _maQuanLy);		
		
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
		public override PMS.Entities.GiangVienTamUng Get(TransactionManager transactionManager, PMS.Entities.GiangVienTamUngKey key, int start, int pageLength)
		{
			return GetByMaQuanLy(transactionManager, key.MaQuanLy, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GiangVienTamUng index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTamUng"/> class.</returns>
		public PMS.Entities.GiangVienTamUng GetByMaQuanLy(System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(null,_maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienTamUng index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTamUng"/> class.</returns>
		public PMS.Entities.GiangVienTamUng GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienTamUng index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTamUng"/> class.</returns>
		public PMS.Entities.GiangVienTamUng GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienTamUng index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTamUng"/> class.</returns>
		public PMS.Entities.GiangVienTamUng GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength)
		{
			int count = -1;
			return GetByMaQuanLy(transactionManager, _maQuanLy, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienTamUng index.
		/// </summary>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTamUng"/> class.</returns>
		public PMS.Entities.GiangVienTamUng GetByMaQuanLy(System.Int32 _maQuanLy, int start, int pageLength, out int count)
		{
			return GetByMaQuanLy(null, _maQuanLy, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GiangVienTamUng index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_maQuanLy"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.GiangVienTamUng"/> class.</returns>
		public abstract PMS.Entities.GiangVienTamUng GetByMaQuanLy(TransactionManager transactionManager, System.Int32 _maQuanLy, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_GiangVienTamUng_Luu 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 Luu(null, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(int start, int pageLength, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 Luu(null, start, pageLength , xmlData, namHoc, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void Luu(TransactionManager transactionManager, System.String xmlData, System.String namHoc, ref System.Int32 reVal)
		{
			 Luu(transactionManager, 0, int.MaxValue , xmlData, namHoc, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_Luu' stored procedure. 
		/// </summary>
		/// <param name="xmlData"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void Luu(TransactionManager transactionManager, int start, int pageLength , System.String xmlData, System.String namHoc, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVienTamUng_GetByMaQuanLyGiangVienNamHoc 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_GetByMaQuanLyGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienTamUng&gt;"/> instance.</returns>
		public TList<GiangVienTamUng> GetByMaQuanLyGiangVienNamHoc(System.String maQuanLyGiangVien, System.String namHoc)
		{
			return GetByMaQuanLyGiangVienNamHoc(null, 0, int.MaxValue , maQuanLyGiangVien, namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_GetByMaQuanLyGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienTamUng&gt;"/> instance.</returns>
		public TList<GiangVienTamUng> GetByMaQuanLyGiangVienNamHoc(int start, int pageLength, System.String maQuanLyGiangVien, System.String namHoc)
		{
			return GetByMaQuanLyGiangVienNamHoc(null, start, pageLength , maQuanLyGiangVien, namHoc);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_GetByMaQuanLyGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienTamUng&gt;"/> instance.</returns>
		public TList<GiangVienTamUng> GetByMaQuanLyGiangVienNamHoc(TransactionManager transactionManager, System.String maQuanLyGiangVien, System.String namHoc)
		{
			return GetByMaQuanLyGiangVienNamHoc(transactionManager, 0, int.MaxValue , maQuanLyGiangVien, namHoc);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_GetByMaQuanLyGiangVienNamHoc' stored procedure. 
		/// </summary>
		/// <param name="maQuanLyGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienTamUng&gt;"/> instance.</returns>
		public abstract TList<GiangVienTamUng> GetByMaQuanLyGiangVienNamHoc(TransactionManager transactionManager, int start, int pageLength , System.String maQuanLyGiangVien, System.String namHoc);
		
		#endregion
		
		#region cust_GiangVienTamUng_KiemTra 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTra(System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 KiemTra(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTra(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 KiemTra(null, start, pageLength , namHoc, hocKy, dotThanhToan, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTra(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 KiemTra(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_KiemTra' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTra(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVienTamUng_KiemTraSoTien 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_KiemTraSoTien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="soTienCoTheUng"> A <c>System.Double</c> instance.</param>
			/// <param name="soTienDaUng"> A <c>System.Double</c> instance.</param>
			/// <param name="soTienConDuocUng"> A <c>System.Double</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraSoTien(System.Int32 maGiangVien, System.String namHoc, System.String hocKy, ref System.Double soTienCoTheUng, ref System.Double soTienDaUng, ref System.Double soTienConDuocUng)
		{
			 KiemTraSoTien(null, 0, int.MaxValue , maGiangVien, namHoc, hocKy, ref soTienCoTheUng, ref soTienDaUng, ref soTienConDuocUng);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_KiemTraSoTien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="soTienCoTheUng"> A <c>System.Double</c> instance.</param>
			/// <param name="soTienDaUng"> A <c>System.Double</c> instance.</param>
			/// <param name="soTienConDuocUng"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraSoTien(int start, int pageLength, System.Int32 maGiangVien, System.String namHoc, System.String hocKy, ref System.Double soTienCoTheUng, ref System.Double soTienDaUng, ref System.Double soTienConDuocUng)
		{
			 KiemTraSoTien(null, start, pageLength , maGiangVien, namHoc, hocKy, ref soTienCoTheUng, ref soTienDaUng, ref soTienConDuocUng);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_KiemTraSoTien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="soTienCoTheUng"> A <c>System.Double</c> instance.</param>
			/// <param name="soTienDaUng"> A <c>System.Double</c> instance.</param>
			/// <param name="soTienConDuocUng"> A <c>System.Double</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void KiemTraSoTien(TransactionManager transactionManager, System.Int32 maGiangVien, System.String namHoc, System.String hocKy, ref System.Double soTienCoTheUng, ref System.Double soTienDaUng, ref System.Double soTienConDuocUng)
		{
			 KiemTraSoTien(transactionManager, 0, int.MaxValue , maGiangVien, namHoc, hocKy, ref soTienCoTheUng, ref soTienDaUng, ref soTienConDuocUng);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_KiemTraSoTien' stored procedure. 
		/// </summary>
		/// <param name="maGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="soTienCoTheUng"> A <c>System.Double</c> instance.</param>
			/// <param name="soTienDaUng"> A <c>System.Double</c> instance.</param>
			/// <param name="soTienConDuocUng"> A <c>System.Double</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void KiemTraSoTien(TransactionManager transactionManager, int start, int pageLength , System.Int32 maGiangVien, System.String namHoc, System.String hocKy, ref System.Double soTienCoTheUng, ref System.Double soTienDaUng, ref System.Double soTienConDuocUng);
		
		#endregion
		
		#region cust_GiangVienTamUng_GetByNamHocHocKy 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienTamUng&gt;"/> instance.</returns>
		public TList<GiangVienTamUng> GetByNamHocHocKy(System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienTamUng&gt;"/> instance.</returns>
		public TList<GiangVienTamUng> GetByNamHocHocKy(int start, int pageLength, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(null, start, pageLength , namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienTamUng&gt;"/> instance.</returns>
		public TList<GiangVienTamUng> GetByNamHocHocKy(TransactionManager transactionManager, System.String namHoc, System.String hocKy)
		{
			return GetByNamHocHocKy(transactionManager, 0, int.MaxValue , namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_GetByNamHocHocKy' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;GiangVienTamUng&gt;"/> instance.</returns>
		public abstract TList<GiangVienTamUng> GetByNamHocHocKy(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_GiangVienTamUng_LuuTamUng 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_LuuTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTamUng(System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 LuuTamUng(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_LuuTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTamUng(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 LuuTamUng(null, start, pageLength , namHoc, hocKy, dotThanhToan, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_LuuTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void LuuTamUng(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 LuuTamUng(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_LuuTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void LuuTamUng(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_GiangVienTamUng_HuyTamUng 
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_HuyTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyTamUng(System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 HuyTamUng(null, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_HuyTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyTamUng(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 HuyTamUng(null, start, pageLength , namHoc, hocKy, dotThanhToan, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_HuyTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyTamUng(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal)
		{
			 HuyTamUng(transactionManager, 0, int.MaxValue , namHoc, hocKy, dotThanhToan, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_GiangVienTamUng_HuyTamUng' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="dotThanhToan"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyTamUng(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 dotThanhToan, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GiangVienTamUng&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GiangVienTamUng&gt;"/></returns>
		public static TList<GiangVienTamUng> Fill(IDataReader reader, TList<GiangVienTamUng> rows, int start, int pageLength)
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
				
				PMS.Entities.GiangVienTamUng c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GiangVienTamUng")
					.Append("|").Append((System.Int32)reader[((int)GiangVienTamUngColumn.MaQuanLy - 1)]).ToString();
					c = EntityManager.LocateOrCreate<GiangVienTamUng>(
					key.ToString(), // EntityTrackingKey
					"GiangVienTamUng",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.GiangVienTamUng();
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
					c.MaQuanLy = (System.Int32)reader[(GiangVienTamUngColumn.MaQuanLy.ToString())];
					c.MaGiangVien = (reader[GiangVienTamUngColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngColumn.MaGiangVien.ToString())];
					c.HoTen = (reader[GiangVienTamUngColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngColumn.HoTen.ToString())];
					c.SoTien = (reader[GiangVienTamUngColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.SoTien.ToString())];
					c.NgayTamUng = (reader[GiangVienTamUngColumn.NgayTamUng.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienTamUngColumn.NgayTamUng.ToString())];
					c.NamHoc = (reader[GiangVienTamUngColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngColumn.NamHoc.ToString())];
					c.HocKy = (reader[GiangVienTamUngColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngColumn.HocKy.ToString())];
					c.GhiChu = (reader[GiangVienTamUngColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngColumn.GhiChu.ToString())];
					c.SoTiet = (reader[GiangVienTamUngColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.SoTiet.ToString())];
					c.NgayCapNhat = (reader[GiangVienTamUngColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngColumn.NgayCapNhat.ToString())];
					c.NguoiCapNhat = (reader[GiangVienTamUngColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngColumn.NguoiCapNhat.ToString())];
					c.DotThanhToan = (reader[GiangVienTamUngColumn.DotThanhToan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngColumn.DotThanhToan.ToString())];
					c.GioNghiaVuGiangDay = (reader[GiangVienTamUngColumn.GioNghiaVuGiangDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.GioNghiaVuGiangDay.ToString())];
					c.GioNghiaVuNckh = (reader[GiangVienTamUngColumn.GioNghiaVuNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.GioNghiaVuNckh.ToString())];
					c.GioGiangDayQuyDoi = (reader[GiangVienTamUngColumn.GioGiangDayQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.GioGiangDayQuyDoi.ToString())];
					c.GioNckh = (reader[GiangVienTamUngColumn.GioNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.GioNckh.ToString())];
					c.DonGia = (reader[GiangVienTamUngColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.DonGia.ToString())];
					c.SoGioQuyDoi = (reader[GiangVienTamUngColumn.SoGioQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.SoGioQuyDoi.ToString())];
					c.SoGioQuyDoiKhoiLuongCongThem = (reader[GiangVienTamUngColumn.SoGioQuyDoiKhoiLuongCongThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.SoGioQuyDoiKhoiLuongCongThem.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienTamUng"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienTamUng"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.GiangVienTamUng entity)
		{
			if (!reader.Read()) return;
			
			entity.MaQuanLy = (System.Int32)reader[(GiangVienTamUngColumn.MaQuanLy.ToString())];
			entity.MaGiangVien = (reader[GiangVienTamUngColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngColumn.MaGiangVien.ToString())];
			entity.HoTen = (reader[GiangVienTamUngColumn.HoTen.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngColumn.HoTen.ToString())];
			entity.SoTien = (reader[GiangVienTamUngColumn.SoTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.SoTien.ToString())];
			entity.NgayTamUng = (reader[GiangVienTamUngColumn.NgayTamUng.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(GiangVienTamUngColumn.NgayTamUng.ToString())];
			entity.NamHoc = (reader[GiangVienTamUngColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngColumn.NamHoc.ToString())];
			entity.HocKy = (reader[GiangVienTamUngColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngColumn.HocKy.ToString())];
			entity.GhiChu = (reader[GiangVienTamUngColumn.GhiChu.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngColumn.GhiChu.ToString())];
			entity.SoTiet = (reader[GiangVienTamUngColumn.SoTiet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.SoTiet.ToString())];
			entity.NgayCapNhat = (reader[GiangVienTamUngColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngColumn.NgayCapNhat.ToString())];
			entity.NguoiCapNhat = (reader[GiangVienTamUngColumn.NguoiCapNhat.ToString()] == DBNull.Value) ? null : (System.String)reader[(GiangVienTamUngColumn.NguoiCapNhat.ToString())];
			entity.DotThanhToan = (reader[GiangVienTamUngColumn.DotThanhToan.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(GiangVienTamUngColumn.DotThanhToan.ToString())];
			entity.GioNghiaVuGiangDay = (reader[GiangVienTamUngColumn.GioNghiaVuGiangDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.GioNghiaVuGiangDay.ToString())];
			entity.GioNghiaVuNckh = (reader[GiangVienTamUngColumn.GioNghiaVuNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.GioNghiaVuNckh.ToString())];
			entity.GioGiangDayQuyDoi = (reader[GiangVienTamUngColumn.GioGiangDayQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.GioGiangDayQuyDoi.ToString())];
			entity.GioNckh = (reader[GiangVienTamUngColumn.GioNckh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.GioNckh.ToString())];
			entity.DonGia = (reader[GiangVienTamUngColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.DonGia.ToString())];
			entity.SoGioQuyDoi = (reader[GiangVienTamUngColumn.SoGioQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.SoGioQuyDoi.ToString())];
			entity.SoGioQuyDoiKhoiLuongCongThem = (reader[GiangVienTamUngColumn.SoGioQuyDoiKhoiLuongCongThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(GiangVienTamUngColumn.SoGioQuyDoiKhoiLuongCongThem.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.GiangVienTamUng"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienTamUng"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.GiangVienTamUng entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MaQuanLy = (System.Int32)dataRow["MaQuanLy"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.HoTen = Convert.IsDBNull(dataRow["HoTen"]) ? null : (System.String)dataRow["HoTen"];
			entity.SoTien = Convert.IsDBNull(dataRow["SoTien"]) ? null : (System.Decimal?)dataRow["SoTien"];
			entity.NgayTamUng = Convert.IsDBNull(dataRow["NgayTamUng"]) ? null : (System.DateTime?)dataRow["NgayTamUng"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.GhiChu = Convert.IsDBNull(dataRow["GhiChu"]) ? null : (System.String)dataRow["GhiChu"];
			entity.SoTiet = Convert.IsDBNull(dataRow["SoTiet"]) ? null : (System.Decimal?)dataRow["SoTiet"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.String)dataRow["NgayCapNhat"];
			entity.NguoiCapNhat = Convert.IsDBNull(dataRow["NguoiCapNhat"]) ? null : (System.String)dataRow["NguoiCapNhat"];
			entity.DotThanhToan = Convert.IsDBNull(dataRow["DotThanhToan"]) ? null : (System.Int32?)dataRow["DotThanhToan"];
			entity.GioNghiaVuGiangDay = Convert.IsDBNull(dataRow["GioNghiaVuGiangDay"]) ? null : (System.Decimal?)dataRow["GioNghiaVuGiangDay"];
			entity.GioNghiaVuNckh = Convert.IsDBNull(dataRow["GioNghiaVuNckh"]) ? null : (System.Decimal?)dataRow["GioNghiaVuNckh"];
			entity.GioGiangDayQuyDoi = Convert.IsDBNull(dataRow["GioGiangDayQuyDoi"]) ? null : (System.Decimal?)dataRow["GioGiangDayQuyDoi"];
			entity.GioNckh = Convert.IsDBNull(dataRow["GioNckh"]) ? null : (System.Decimal?)dataRow["GioNckh"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.SoGioQuyDoi = Convert.IsDBNull(dataRow["SoGioQuyDoi"]) ? null : (System.Decimal?)dataRow["SoGioQuyDoi"];
			entity.SoGioQuyDoiKhoiLuongCongThem = Convert.IsDBNull(dataRow["SoGioQuyDoiKhoiLuongCongThem"]) ? null : (System.Decimal?)dataRow["SoGioQuyDoiKhoiLuongCongThem"];
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
		/// <param name="entity">The <see cref="PMS.Entities.GiangVienTamUng"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienTamUng Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.GiangVienTamUng entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.GiangVienTamUng object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.GiangVienTamUng instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.GiangVienTamUng Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.GiangVienTamUng entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GiangVienTamUngChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.GiangVienTamUng</c>
	///</summary>
	public enum GiangVienTamUngChildEntityTypes
	{
	}
	
	#endregion GiangVienTamUngChildEntityTypes
	
	#region GiangVienTamUngFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GiangVienTamUngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTamUngFilterBuilder : SqlFilterBuilder<GiangVienTamUngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngFilterBuilder class.
		/// </summary>
		public GiangVienTamUngFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienTamUngFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienTamUngFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienTamUngFilterBuilder
	
	#region GiangVienTamUngParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GiangVienTamUngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTamUngParameterBuilder : ParameterizedSqlFilterBuilder<GiangVienTamUngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngParameterBuilder class.
		/// </summary>
		public GiangVienTamUngParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GiangVienTamUngParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GiangVienTamUngParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GiangVienTamUngParameterBuilder
	
	#region GiangVienTamUngSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GiangVienTamUngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTamUng"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GiangVienTamUngSortBuilder : SqlSortBuilder<GiangVienTamUngColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngSqlSortBuilder class.
		/// </summary>
		public GiangVienTamUngSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GiangVienTamUngSortBuilder
	
} // end namespace
