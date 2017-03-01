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
	/// This class is the base class for any <see cref="SdhKetQuaThanhToanThuLaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SdhKetQuaThanhToanThuLaoProviderBaseCore : EntityProviderBase<PMS.Entities.SdhKetQuaThanhToanThuLao, PMS.Entities.SdhKetQuaThanhToanThuLaoKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.SdhKetQuaThanhToanThuLaoKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _id)
		{
			return Delete(null, _id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _id);		
		
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
		public override PMS.Entities.SdhKetQuaThanhToanThuLao Get(TransactionManager transactionManager, PMS.Entities.SdhKetQuaThanhToanThuLaoKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SdhKetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhKetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.SdhKetQuaThanhToanThuLao GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhKetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhKetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.SdhKetQuaThanhToanThuLao GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhKetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhKetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.SdhKetQuaThanhToanThuLao GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhKetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhKetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.SdhKetQuaThanhToanThuLao GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhKetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhKetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.SdhKetQuaThanhToanThuLao GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SdhKetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.SdhKetQuaThanhToanThuLao"/> class.</returns>
		public abstract PMS.Entities.SdhKetQuaThanhToanThuLao GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_SdhKetQuaThanhToanThuLao_ChotThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_ChotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotThanhToan(System.String namHoc, System.String hocKy, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 ChotThanhToan(null, 0, int.MaxValue , namHoc, hocKy, lanChot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_ChotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotThanhToan(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 ChotThanhToan(null, start, pageLength , namHoc, hocKy, lanChot, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_ChotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotThanhToan(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 ChotThanhToan(transactionManager, 0, int.MaxValue , namHoc, hocKy, lanChot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_ChotThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ChotThanhToan(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 lanChot, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_SdhKetQuaThanhToanThuLao_ThongKeTongHop 
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_ThongKeTongHop' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHop(System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTongHop(null, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_ThongKeTongHop' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHop(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTongHop(null, start, pageLength , namHoc, hocKy, khoaDonVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_ThongKeTongHop' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeTongHop(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeTongHop(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaDonVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_ThongKeTongHop' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaDonVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeTongHop(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaDonVi, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_SdhKetQuaThanhToanThuLao_ThongKeThanhToanChiTietSauDaiHoc 
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_ThongKeThanhToanChiTietSauDaiHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="nganh"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeThanhToanChiTietSauDaiHoc(System.String namHoc, System.String hocKy, System.String khoaHoc, System.String nganh, System.Int32 maLoaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeThanhToanChiTietSauDaiHoc(null, 0, int.MaxValue , namHoc, hocKy, khoaHoc, nganh, maLoaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_ThongKeThanhToanChiTietSauDaiHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="nganh"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeThanhToanChiTietSauDaiHoc(int start, int pageLength, System.String namHoc, System.String hocKy, System.String khoaHoc, System.String nganh, System.Int32 maLoaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeThanhToanChiTietSauDaiHoc(null, start, pageLength , namHoc, hocKy, khoaHoc, nganh, maLoaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_ThongKeThanhToanChiTietSauDaiHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="nganh"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader ThongKeThanhToanChiTietSauDaiHoc(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String khoaHoc, System.String nganh, System.Int32 maLoaiGiangVien, System.Int32 lanChot)
		{
			return ThongKeThanhToanChiTietSauDaiHoc(transactionManager, 0, int.MaxValue , namHoc, hocKy, khoaHoc, nganh, maLoaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_ThongKeThanhToanChiTietSauDaiHoc' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="khoaHoc"> A <c>System.String</c> instance.</param>
		/// <param name="nganh"> A <c>System.String</c> instance.</param>
		/// <param name="maLoaiGiangVien"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader ThongKeThanhToanChiTietSauDaiHoc(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String khoaHoc, System.String nganh, System.Int32 maLoaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_SdhKetQuaThanhToanThuLao_HuyChotThuLao 
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_HuyChotThuLao' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotThuLao(System.String namHoc, System.String hocKy, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 HuyChotThuLao(null, 0, int.MaxValue , namHoc, hocKy, lanChot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_HuyChotThuLao' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotThuLao(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 HuyChotThuLao(null, start, pageLength , namHoc, hocKy, lanChot, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_HuyChotThuLao' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void HuyChotThuLao(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 HuyChotThuLao(transactionManager, 0, int.MaxValue , namHoc, hocKy, lanChot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_HuyChotThuLao' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void HuyChotThuLao(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 lanChot, ref System.Int32 reVal);
		
		#endregion
		
		#region cust_SdhKetQuaThanhToanThuLao_GiangVienXemThuLaoTrenWeb_Ute 
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_GiangVienXemThuLaoTrenWeb_Ute' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GiangVienXemThuLaoTrenWeb_Ute(System.String maGiangVienQuanLy, System.String namHoc, System.String hocKy)
		{
			return GiangVienXemThuLaoTrenWeb_Ute(null, 0, int.MaxValue , maGiangVienQuanLy, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_GiangVienXemThuLaoTrenWeb_Ute' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GiangVienXemThuLaoTrenWeb_Ute(int start, int pageLength, System.String maGiangVienQuanLy, System.String namHoc, System.String hocKy)
		{
			return GiangVienXemThuLaoTrenWeb_Ute(null, start, pageLength , maGiangVienQuanLy, namHoc, hocKy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_GiangVienXemThuLaoTrenWeb_Ute' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader GiangVienXemThuLaoTrenWeb_Ute(TransactionManager transactionManager, System.String maGiangVienQuanLy, System.String namHoc, System.String hocKy)
		{
			return GiangVienXemThuLaoTrenWeb_Ute(transactionManager, 0, int.MaxValue , maGiangVienQuanLy, namHoc, hocKy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_GiangVienXemThuLaoTrenWeb_Ute' stored procedure. 
		/// </summary>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader GiangVienXemThuLaoTrenWeb_Ute(TransactionManager transactionManager, int start, int pageLength , System.String maGiangVienQuanLy, System.String namHoc, System.String hocKy);
		
		#endregion
		
		#region cust_SdhKetQuaThanhToanThuLao_GetSoLanChot 
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_GetSoLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLanChot(System.String namHoc, System.String hocKy, ref System.Int32 ketQua)
		{
			 GetSoLanChot(null, 0, int.MaxValue , namHoc, hocKy, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_GetSoLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLanChot(int start, int pageLength, System.String namHoc, System.String hocKy, ref System.Int32 ketQua)
		{
			 GetSoLanChot(null, start, pageLength , namHoc, hocKy, ref ketQua);
		}
				
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_GetSoLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void GetSoLanChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, ref System.Int32 ketQua)
		{
			 GetSoLanChot(transactionManager, 0, int.MaxValue , namHoc, hocKy, ref ketQua);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_GetSoLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
			/// <param name="ketQua"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void GetSoLanChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, ref System.Int32 ketQua);
		
		#endregion
		
		#region cust_SdhKetQuaThanhToanThuLao_XemThuLaoTrenWebUte 
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_XemThuLaoTrenWebUte' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader XemThuLaoTrenWebUte(System.String namHoc, System.String hocKy, System.String maGiangVienQuanLy)
		{
			return XemThuLaoTrenWebUte(null, 0, int.MaxValue , namHoc, hocKy, maGiangVienQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_XemThuLaoTrenWebUte' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader XemThuLaoTrenWebUte(int start, int pageLength, System.String namHoc, System.String hocKy, System.String maGiangVienQuanLy)
		{
			return XemThuLaoTrenWebUte(null, start, pageLength , namHoc, hocKy, maGiangVienQuanLy);
		}
				
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_XemThuLaoTrenWebUte' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader XemThuLaoTrenWebUte(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String maGiangVienQuanLy)
		{
			return XemThuLaoTrenWebUte(transactionManager, 0, int.MaxValue , namHoc, hocKy, maGiangVienQuanLy);
		}
		
		/// <summary>
		///	This method wrap the 'cust_SdhKetQuaThanhToanThuLao_XemThuLaoTrenWebUte' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="maGiangVienQuanLy"> A <c>System.String</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader XemThuLaoTrenWebUte(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String maGiangVienQuanLy);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SdhKetQuaThanhToanThuLao&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SdhKetQuaThanhToanThuLao&gt;"/></returns>
		public static TList<SdhKetQuaThanhToanThuLao> Fill(IDataReader reader, TList<SdhKetQuaThanhToanThuLao> rows, int start, int pageLength)
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
				
				PMS.Entities.SdhKetQuaThanhToanThuLao c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SdhKetQuaThanhToanThuLao")
					.Append("|").Append((System.Int32)reader[((int)SdhKetQuaThanhToanThuLaoColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<SdhKetQuaThanhToanThuLao>(
					key.ToString(), // EntityTrackingKey
					"SdhKetQuaThanhToanThuLao",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.SdhKetQuaThanhToanThuLao();
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
					c.Id = (System.Int32)reader[(SdhKetQuaThanhToanThuLaoColumn.Id.ToString())];
					c.MaGiangVien = (reader[SdhKetQuaThanhToanThuLaoColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhKetQuaThanhToanThuLaoColumn.MaGiangVien.ToString())];
					c.NamHoc = (reader[SdhKetQuaThanhToanThuLaoColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.NamHoc.ToString())];
					c.HocKy = (reader[SdhKetQuaThanhToanThuLaoColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.HocKy.ToString())];
					c.MaHocHam = (reader[SdhKetQuaThanhToanThuLaoColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhKetQuaThanhToanThuLaoColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[SdhKetQuaThanhToanThuLaoColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhKetQuaThanhToanThuLaoColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[SdhKetQuaThanhToanThuLaoColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhKetQuaThanhToanThuLaoColumn.MaLoaiGiangVien.ToString())];
					c.MaDonVi = (reader[SdhKetQuaThanhToanThuLaoColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaDonVi.ToString())];
					c.Loai = (reader[SdhKetQuaThanhToanThuLaoColumn.Loai.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.Loai.ToString())];
					c.PhanLoai = (reader[SdhKetQuaThanhToanThuLaoColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.PhanLoai.ToString())];
					c.MaMonHoc = (reader[SdhKetQuaThanhToanThuLaoColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[SdhKetQuaThanhToanThuLaoColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.TenMonHoc.ToString())];
					c.LoaiHocPhan = (reader[SdhKetQuaThanhToanThuLaoColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.LoaiHocPhan.ToString())];
					c.Nhom = (reader[SdhKetQuaThanhToanThuLaoColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.Nhom.ToString())];
					c.MaLop = (reader[SdhKetQuaThanhToanThuLaoColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaLop.ToString())];
					c.LopClc = (reader[SdhKetQuaThanhToanThuLaoColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(SdhKetQuaThanhToanThuLaoColumn.LopClc.ToString())];
					c.SiSo = (reader[SdhKetQuaThanhToanThuLaoColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhKetQuaThanhToanThuLaoColumn.SiSo.ToString())];
					c.TietThucDay = (reader[SdhKetQuaThanhToanThuLaoColumn.TietThucDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.TietThucDay.ToString())];
					c.TietChuNhat = (reader[SdhKetQuaThanhToanThuLaoColumn.TietChuNhat.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.TietChuNhat.ToString())];
					c.HeSoHocKy = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoHocKy.ToString())];
					c.HeSoLopDong = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoLopDong.ToString())];
					c.TietQuyDoi = (reader[SdhKetQuaThanhToanThuLaoColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.TietQuyDoi.ToString())];
					c.DonGia = (reader[SdhKetQuaThanhToanThuLaoColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.DonGia.ToString())];
					c.ThanhTien = (reader[SdhKetQuaThanhToanThuLaoColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.ThanhTien.ToString())];
					c.LanChot = (reader[SdhKetQuaThanhToanThuLaoColumn.LanChot.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhKetQuaThanhToanThuLaoColumn.LanChot.ToString())];
					c.NgayCapNhat = (reader[SdhKetQuaThanhToanThuLaoColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(SdhKetQuaThanhToanThuLaoColumn.NgayCapNhat.ToString())];
					c.MaHinhThucDaoTao = (reader[SdhKetQuaThanhToanThuLaoColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaHinhThucDaoTao.ToString())];
					c.DonGiaTrongChuan = (reader[SdhKetQuaThanhToanThuLaoColumn.DonGiaTrongChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.DonGiaTrongChuan.ToString())];
					c.DonGiaNgoaiChuan = (reader[SdhKetQuaThanhToanThuLaoColumn.DonGiaNgoaiChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.DonGiaNgoaiChuan.ToString())];
					c.TenCoSo = (reader[SdhKetQuaThanhToanThuLaoColumn.TenCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.TenCoSo.ToString())];
					c.HeSoQuyDoiThucHanhSangLyThuyet = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString())];
					c.HeSoCoSo = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoCoSo.ToString())];
					c.SoGioThucGiangTrenLop = (reader[SdhKetQuaThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString())];
					c.SoGioChuanTinhThem = (reader[SdhKetQuaThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString())];
					c.HeSoChucDanhChuyenMon = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoChucDanhChuyenMon.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoChucDanhChuyenMon.ToString())];
					c.HeSoClcCntn = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoClcCntn.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoClcCntn.ToString())];
					c.HeSoThinhGiangMonChuyenNganh = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoThinhGiangMonChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoThinhGiangMonChuyenNganh.ToString())];
					c.MaNhomMonHoc = (reader[SdhKetQuaThanhToanThuLaoColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaNhomMonHoc.ToString())];
					c.LoaiLop = (reader[SdhKetQuaThanhToanThuLaoColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.LoaiLop.ToString())];
					c.MaBacDaoTao = (reader[SdhKetQuaThanhToanThuLaoColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaBacDaoTao.ToString())];
					c.MalopHocPhan = (reader[SdhKetQuaThanhToanThuLaoColumn.MalopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MalopHocPhan.ToString())];
					c.MaKhoaHoc = (reader[SdhKetQuaThanhToanThuLaoColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaKhoaHoc.ToString())];
					c.HeSoTroCap = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoTroCap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoTroCap.ToString())];
					c.HeSoNgoaiGio = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoNgoaiGio.ToString())];
					c.HeSoLuong = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoLuong.ToString())];
					c.HeSoMonMoi = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoMonMoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoMonMoi.ToString())];
					c.HeSoNienCheTinChi = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoNienCheTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoNienCheTinChi.ToString())];
					c.HeSoNgonNgu = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoNgonNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoNgonNgu.ToString())];
					c.HeSoBacDaoTao = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoBacDaoTao.ToString())];
					c.MaDiaDiem = (reader[SdhKetQuaThanhToanThuLaoColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaDiaDiem.ToString())];
					c.TenDiaDiem = (reader[SdhKetQuaThanhToanThuLaoColumn.TenDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.TenDiaDiem.ToString())];
					c.DonGiaDiaDiem = (reader[SdhKetQuaThanhToanThuLaoColumn.DonGiaDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.DonGiaDiaDiem.ToString())];
					c.TienXeDiaDiem = (reader[SdhKetQuaThanhToanThuLaoColumn.TienXeDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.TienXeDiaDiem.ToString())];
					c.HeSoDiaDiem = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoDiaDiem.ToString())];
					c.SoTinChi = (reader[SdhKetQuaThanhToanThuLaoColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhKetQuaThanhToanThuLaoColumn.SoTinChi.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SdhKetQuaThanhToanThuLao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SdhKetQuaThanhToanThuLao"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.SdhKetQuaThanhToanThuLao entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(SdhKetQuaThanhToanThuLaoColumn.Id.ToString())];
			entity.MaGiangVien = (reader[SdhKetQuaThanhToanThuLaoColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhKetQuaThanhToanThuLaoColumn.MaGiangVien.ToString())];
			entity.NamHoc = (reader[SdhKetQuaThanhToanThuLaoColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.NamHoc.ToString())];
			entity.HocKy = (reader[SdhKetQuaThanhToanThuLaoColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.HocKy.ToString())];
			entity.MaHocHam = (reader[SdhKetQuaThanhToanThuLaoColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhKetQuaThanhToanThuLaoColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[SdhKetQuaThanhToanThuLaoColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhKetQuaThanhToanThuLaoColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[SdhKetQuaThanhToanThuLaoColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhKetQuaThanhToanThuLaoColumn.MaLoaiGiangVien.ToString())];
			entity.MaDonVi = (reader[SdhKetQuaThanhToanThuLaoColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaDonVi.ToString())];
			entity.Loai = (reader[SdhKetQuaThanhToanThuLaoColumn.Loai.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.Loai.ToString())];
			entity.PhanLoai = (reader[SdhKetQuaThanhToanThuLaoColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.PhanLoai.ToString())];
			entity.MaMonHoc = (reader[SdhKetQuaThanhToanThuLaoColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[SdhKetQuaThanhToanThuLaoColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.TenMonHoc.ToString())];
			entity.LoaiHocPhan = (reader[SdhKetQuaThanhToanThuLaoColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.LoaiHocPhan.ToString())];
			entity.Nhom = (reader[SdhKetQuaThanhToanThuLaoColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.Nhom.ToString())];
			entity.MaLop = (reader[SdhKetQuaThanhToanThuLaoColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaLop.ToString())];
			entity.LopClc = (reader[SdhKetQuaThanhToanThuLaoColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(SdhKetQuaThanhToanThuLaoColumn.LopClc.ToString())];
			entity.SiSo = (reader[SdhKetQuaThanhToanThuLaoColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhKetQuaThanhToanThuLaoColumn.SiSo.ToString())];
			entity.TietThucDay = (reader[SdhKetQuaThanhToanThuLaoColumn.TietThucDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.TietThucDay.ToString())];
			entity.TietChuNhat = (reader[SdhKetQuaThanhToanThuLaoColumn.TietChuNhat.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.TietChuNhat.ToString())];
			entity.HeSoHocKy = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoHocKy.ToString())];
			entity.HeSoLopDong = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoLopDong.ToString())];
			entity.TietQuyDoi = (reader[SdhKetQuaThanhToanThuLaoColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.TietQuyDoi.ToString())];
			entity.DonGia = (reader[SdhKetQuaThanhToanThuLaoColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.DonGia.ToString())];
			entity.ThanhTien = (reader[SdhKetQuaThanhToanThuLaoColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.ThanhTien.ToString())];
			entity.LanChot = (reader[SdhKetQuaThanhToanThuLaoColumn.LanChot.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhKetQuaThanhToanThuLaoColumn.LanChot.ToString())];
			entity.NgayCapNhat = (reader[SdhKetQuaThanhToanThuLaoColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(SdhKetQuaThanhToanThuLaoColumn.NgayCapNhat.ToString())];
			entity.MaHinhThucDaoTao = (reader[SdhKetQuaThanhToanThuLaoColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaHinhThucDaoTao.ToString())];
			entity.DonGiaTrongChuan = (reader[SdhKetQuaThanhToanThuLaoColumn.DonGiaTrongChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.DonGiaTrongChuan.ToString())];
			entity.DonGiaNgoaiChuan = (reader[SdhKetQuaThanhToanThuLaoColumn.DonGiaNgoaiChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.DonGiaNgoaiChuan.ToString())];
			entity.TenCoSo = (reader[SdhKetQuaThanhToanThuLaoColumn.TenCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.TenCoSo.ToString())];
			entity.HeSoQuyDoiThucHanhSangLyThuyet = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString())];
			entity.HeSoCoSo = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoCoSo.ToString())];
			entity.SoGioThucGiangTrenLop = (reader[SdhKetQuaThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString())];
			entity.SoGioChuanTinhThem = (reader[SdhKetQuaThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString())];
			entity.HeSoChucDanhChuyenMon = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoChucDanhChuyenMon.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoChucDanhChuyenMon.ToString())];
			entity.HeSoClcCntn = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoClcCntn.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoClcCntn.ToString())];
			entity.HeSoThinhGiangMonChuyenNganh = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoThinhGiangMonChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoThinhGiangMonChuyenNganh.ToString())];
			entity.MaNhomMonHoc = (reader[SdhKetQuaThanhToanThuLaoColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaNhomMonHoc.ToString())];
			entity.LoaiLop = (reader[SdhKetQuaThanhToanThuLaoColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.LoaiLop.ToString())];
			entity.MaBacDaoTao = (reader[SdhKetQuaThanhToanThuLaoColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaBacDaoTao.ToString())];
			entity.MalopHocPhan = (reader[SdhKetQuaThanhToanThuLaoColumn.MalopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MalopHocPhan.ToString())];
			entity.MaKhoaHoc = (reader[SdhKetQuaThanhToanThuLaoColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaKhoaHoc.ToString())];
			entity.HeSoTroCap = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoTroCap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoTroCap.ToString())];
			entity.HeSoNgoaiGio = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoNgoaiGio.ToString())];
			entity.HeSoLuong = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoLuong.ToString())];
			entity.HeSoMonMoi = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoMonMoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoMonMoi.ToString())];
			entity.HeSoNienCheTinChi = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoNienCheTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoNienCheTinChi.ToString())];
			entity.HeSoNgonNgu = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoNgonNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoNgonNgu.ToString())];
			entity.HeSoBacDaoTao = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoBacDaoTao.ToString())];
			entity.MaDiaDiem = (reader[SdhKetQuaThanhToanThuLaoColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.MaDiaDiem.ToString())];
			entity.TenDiaDiem = (reader[SdhKetQuaThanhToanThuLaoColumn.TenDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(SdhKetQuaThanhToanThuLaoColumn.TenDiaDiem.ToString())];
			entity.DonGiaDiaDiem = (reader[SdhKetQuaThanhToanThuLaoColumn.DonGiaDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.DonGiaDiaDiem.ToString())];
			entity.TienXeDiaDiem = (reader[SdhKetQuaThanhToanThuLaoColumn.TienXeDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.TienXeDiaDiem.ToString())];
			entity.HeSoDiaDiem = (reader[SdhKetQuaThanhToanThuLaoColumn.HeSoDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(SdhKetQuaThanhToanThuLaoColumn.HeSoDiaDiem.ToString())];
			entity.SoTinChi = (reader[SdhKetQuaThanhToanThuLaoColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(SdhKetQuaThanhToanThuLaoColumn.SoTinChi.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.SdhKetQuaThanhToanThuLao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.SdhKetQuaThanhToanThuLao"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.SdhKetQuaThanhToanThuLao entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.MaGiangVien = Convert.IsDBNull(dataRow["MaGiangVien"]) ? null : (System.Int32?)dataRow["MaGiangVien"];
			entity.NamHoc = Convert.IsDBNull(dataRow["NamHoc"]) ? null : (System.String)dataRow["NamHoc"];
			entity.HocKy = Convert.IsDBNull(dataRow["HocKy"]) ? null : (System.String)dataRow["HocKy"];
			entity.MaHocHam = Convert.IsDBNull(dataRow["MaHocHam"]) ? null : (System.Int32?)dataRow["MaHocHam"];
			entity.MaHocVi = Convert.IsDBNull(dataRow["MaHocVi"]) ? null : (System.Int32?)dataRow["MaHocVi"];
			entity.MaLoaiGiangVien = Convert.IsDBNull(dataRow["MaLoaiGiangVien"]) ? null : (System.Int32?)dataRow["MaLoaiGiangVien"];
			entity.MaDonVi = Convert.IsDBNull(dataRow["MaDonVi"]) ? null : (System.String)dataRow["MaDonVi"];
			entity.Loai = Convert.IsDBNull(dataRow["Loai"]) ? null : (System.String)dataRow["Loai"];
			entity.PhanLoai = Convert.IsDBNull(dataRow["PhanLoai"]) ? null : (System.String)dataRow["PhanLoai"];
			entity.MaMonHoc = Convert.IsDBNull(dataRow["MaMonHoc"]) ? null : (System.String)dataRow["MaMonHoc"];
			entity.TenMonHoc = Convert.IsDBNull(dataRow["TenMonHoc"]) ? null : (System.String)dataRow["TenMonHoc"];
			entity.LoaiHocPhan = Convert.IsDBNull(dataRow["LoaiHocPhan"]) ? null : (System.String)dataRow["LoaiHocPhan"];
			entity.Nhom = Convert.IsDBNull(dataRow["Nhom"]) ? null : (System.String)dataRow["Nhom"];
			entity.MaLop = Convert.IsDBNull(dataRow["MaLop"]) ? null : (System.String)dataRow["MaLop"];
			entity.LopClc = Convert.IsDBNull(dataRow["LopClc"]) ? null : (System.Boolean?)dataRow["LopClc"];
			entity.SiSo = Convert.IsDBNull(dataRow["SiSo"]) ? null : (System.Int32?)dataRow["SiSo"];
			entity.TietThucDay = Convert.IsDBNull(dataRow["TietThucDay"]) ? null : (System.Decimal?)dataRow["TietThucDay"];
			entity.TietChuNhat = Convert.IsDBNull(dataRow["TietChuNhat"]) ? null : (System.Decimal?)dataRow["TietChuNhat"];
			entity.HeSoHocKy = Convert.IsDBNull(dataRow["HeSoHocKy"]) ? null : (System.Decimal?)dataRow["HeSoHocKy"];
			entity.HeSoLopDong = Convert.IsDBNull(dataRow["HeSoLopDong"]) ? null : (System.Decimal?)dataRow["HeSoLopDong"];
			entity.TietQuyDoi = Convert.IsDBNull(dataRow["TietQuyDoi"]) ? null : (System.Decimal?)dataRow["TietQuyDoi"];
			entity.DonGia = Convert.IsDBNull(dataRow["DonGia"]) ? null : (System.Decimal?)dataRow["DonGia"];
			entity.ThanhTien = Convert.IsDBNull(dataRow["ThanhTien"]) ? null : (System.Decimal?)dataRow["ThanhTien"];
			entity.LanChot = Convert.IsDBNull(dataRow["LanChot"]) ? null : (System.Int32?)dataRow["LanChot"];
			entity.NgayCapNhat = Convert.IsDBNull(dataRow["NgayCapNhat"]) ? null : (System.DateTime?)dataRow["NgayCapNhat"];
			entity.MaHinhThucDaoTao = Convert.IsDBNull(dataRow["MaHinhThucDaoTao"]) ? null : (System.String)dataRow["MaHinhThucDaoTao"];
			entity.DonGiaTrongChuan = Convert.IsDBNull(dataRow["DonGiaTrongChuan"]) ? null : (System.Decimal?)dataRow["DonGiaTrongChuan"];
			entity.DonGiaNgoaiChuan = Convert.IsDBNull(dataRow["DonGiaNgoaiChuan"]) ? null : (System.Decimal?)dataRow["DonGiaNgoaiChuan"];
			entity.TenCoSo = Convert.IsDBNull(dataRow["TenCoSo"]) ? null : (System.String)dataRow["TenCoSo"];
			entity.HeSoQuyDoiThucHanhSangLyThuyet = Convert.IsDBNull(dataRow["HeSoQuyDoiThucHanhSangLyThuyet"]) ? null : (System.Decimal?)dataRow["HeSoQuyDoiThucHanhSangLyThuyet"];
			entity.HeSoCoSo = Convert.IsDBNull(dataRow["HeSoCoSo"]) ? null : (System.Decimal?)dataRow["HeSoCoSo"];
			entity.SoGioThucGiangTrenLop = Convert.IsDBNull(dataRow["SoGioThucGiangTrenLop"]) ? null : (System.Decimal?)dataRow["SoGioThucGiangTrenLop"];
			entity.SoGioChuanTinhThem = Convert.IsDBNull(dataRow["SoGioChuanTinhThem"]) ? null : (System.Decimal?)dataRow["SoGioChuanTinhThem"];
			entity.HeSoChucDanhChuyenMon = Convert.IsDBNull(dataRow["HeSoChucDanhChuyenMon"]) ? null : (System.Decimal?)dataRow["HeSoChucDanhChuyenMon"];
			entity.HeSoClcCntn = Convert.IsDBNull(dataRow["HeSoClcCntn"]) ? null : (System.Decimal?)dataRow["HeSoClcCntn"];
			entity.HeSoThinhGiangMonChuyenNganh = Convert.IsDBNull(dataRow["HeSoThinhGiangMonChuyenNganh"]) ? null : (System.Decimal?)dataRow["HeSoThinhGiangMonChuyenNganh"];
			entity.MaNhomMonHoc = Convert.IsDBNull(dataRow["MaNhomMonHoc"]) ? null : (System.String)dataRow["MaNhomMonHoc"];
			entity.LoaiLop = Convert.IsDBNull(dataRow["LoaiLop"]) ? null : (System.String)dataRow["LoaiLop"];
			entity.MaBacDaoTao = Convert.IsDBNull(dataRow["MaBacDaoTao"]) ? null : (System.String)dataRow["MaBacDaoTao"];
			entity.MalopHocPhan = Convert.IsDBNull(dataRow["MalopHocPhan"]) ? null : (System.String)dataRow["MalopHocPhan"];
			entity.MaKhoaHoc = Convert.IsDBNull(dataRow["MaKhoaHoc"]) ? null : (System.String)dataRow["MaKhoaHoc"];
			entity.HeSoTroCap = Convert.IsDBNull(dataRow["HeSoTroCap"]) ? null : (System.Decimal?)dataRow["HeSoTroCap"];
			entity.HeSoNgoaiGio = Convert.IsDBNull(dataRow["HeSoNgoaiGio"]) ? null : (System.Decimal?)dataRow["HeSoNgoaiGio"];
			entity.HeSoLuong = Convert.IsDBNull(dataRow["HeSoLuong"]) ? null : (System.Decimal?)dataRow["HeSoLuong"];
			entity.HeSoMonMoi = Convert.IsDBNull(dataRow["HeSoMonMoi"]) ? null : (System.Decimal?)dataRow["HeSoMonMoi"];
			entity.HeSoNienCheTinChi = Convert.IsDBNull(dataRow["HeSoNienCheTinChi"]) ? null : (System.Decimal?)dataRow["HeSoNienCheTinChi"];
			entity.HeSoNgonNgu = Convert.IsDBNull(dataRow["HeSoNgonNgu"]) ? null : (System.Decimal?)dataRow["HeSoNgonNgu"];
			entity.HeSoBacDaoTao = Convert.IsDBNull(dataRow["HeSoBacDaoTao"]) ? null : (System.Decimal?)dataRow["HeSoBacDaoTao"];
			entity.MaDiaDiem = Convert.IsDBNull(dataRow["MaDiaDiem"]) ? null : (System.String)dataRow["MaDiaDiem"];
			entity.TenDiaDiem = Convert.IsDBNull(dataRow["TenDiaDiem"]) ? null : (System.String)dataRow["TenDiaDiem"];
			entity.DonGiaDiaDiem = Convert.IsDBNull(dataRow["DonGiaDiaDiem"]) ? null : (System.Decimal?)dataRow["DonGiaDiaDiem"];
			entity.TienXeDiaDiem = Convert.IsDBNull(dataRow["TienXeDiaDiem"]) ? null : (System.Decimal?)dataRow["TienXeDiaDiem"];
			entity.HeSoDiaDiem = Convert.IsDBNull(dataRow["HeSoDiaDiem"]) ? null : (System.Decimal?)dataRow["HeSoDiaDiem"];
			entity.SoTinChi = Convert.IsDBNull(dataRow["SoTinChi"]) ? null : (System.Int32?)dataRow["SoTinChi"];
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
		/// <param name="entity">The <see cref="PMS.Entities.SdhKetQuaThanhToanThuLao"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.SdhKetQuaThanhToanThuLao Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.SdhKetQuaThanhToanThuLao entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.SdhKetQuaThanhToanThuLao object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.SdhKetQuaThanhToanThuLao instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.SdhKetQuaThanhToanThuLao Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.SdhKetQuaThanhToanThuLao entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region SdhKetQuaThanhToanThuLaoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.SdhKetQuaThanhToanThuLao</c>
	///</summary>
	public enum SdhKetQuaThanhToanThuLaoChildEntityTypes
	{
	}
	
	#endregion SdhKetQuaThanhToanThuLaoChildEntityTypes
	
	#region SdhKetQuaThanhToanThuLaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SdhKetQuaThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhKetQuaThanhToanThuLaoFilterBuilder : SqlFilterBuilder<SdhKetQuaThanhToanThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhKetQuaThanhToanThuLaoFilterBuilder class.
		/// </summary>
		public SdhKetQuaThanhToanThuLaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SdhKetQuaThanhToanThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SdhKetQuaThanhToanThuLaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SdhKetQuaThanhToanThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SdhKetQuaThanhToanThuLaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SdhKetQuaThanhToanThuLaoFilterBuilder
	
	#region SdhKetQuaThanhToanThuLaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SdhKetQuaThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhKetQuaThanhToanThuLaoParameterBuilder : ParameterizedSqlFilterBuilder<SdhKetQuaThanhToanThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhKetQuaThanhToanThuLaoParameterBuilder class.
		/// </summary>
		public SdhKetQuaThanhToanThuLaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SdhKetQuaThanhToanThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SdhKetQuaThanhToanThuLaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SdhKetQuaThanhToanThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SdhKetQuaThanhToanThuLaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SdhKetQuaThanhToanThuLaoParameterBuilder
	
	#region SdhKetQuaThanhToanThuLaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SdhKetQuaThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhKetQuaThanhToanThuLao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SdhKetQuaThanhToanThuLaoSortBuilder : SqlSortBuilder<SdhKetQuaThanhToanThuLaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhKetQuaThanhToanThuLaoSqlSortBuilder class.
		/// </summary>
		public SdhKetQuaThanhToanThuLaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SdhKetQuaThanhToanThuLaoSortBuilder
	
} // end namespace
