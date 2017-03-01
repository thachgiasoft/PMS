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
	/// This class is the base class for any <see cref="KcqKetQuaThanhToanThuLaoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class KcqKetQuaThanhToanThuLaoProviderBaseCore : EntityProviderBase<PMS.Entities.KcqKetQuaThanhToanThuLao, PMS.Entities.KcqKetQuaThanhToanThuLaoKey>
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
		public override bool Delete(TransactionManager transactionManager, PMS.Entities.KcqKetQuaThanhToanThuLaoKey key)
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
		public override PMS.Entities.KcqKetQuaThanhToanThuLao Get(TransactionManager transactionManager, PMS.Entities.KcqKetQuaThanhToanThuLaoKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_KcqKetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KcqKetQuaThanhToanThuLao GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KcqKetQuaThanhToanThuLao GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KcqKetQuaThanhToanThuLao GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KcqKetQuaThanhToanThuLao GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKetQuaThanhToanThuLao"/> class.</returns>
		public PMS.Entities.KcqKetQuaThanhToanThuLao GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_KcqKetQuaThanhToanThuLao index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="PMS.Entities.KcqKetQuaThanhToanThuLao"/> class.</returns>
		public abstract PMS.Entities.KcqKetQuaThanhToanThuLao GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#region cust_KcqKetQuaThanhToanThuLao_TongHopKetQuaThanhToanTapSu 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_TongHopKetQuaThanhToanTapSu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TongHopKetQuaThanhToanTapSu(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return TongHopKetQuaThanhToanTapSu(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_TongHopKetQuaThanhToanTapSu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TongHopKetQuaThanhToanTapSu(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return TongHopKetQuaThanhToanTapSu(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_TongHopKetQuaThanhToanTapSu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TongHopKetQuaThanhToanTapSu(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return TongHopKetQuaThanhToanTapSu(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_TongHopKetQuaThanhToanTapSu' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader TongHopKetQuaThanhToanTapSu(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KcqKetQuaThanhToanThuLao_GetSoLanChot 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_GetSoLanChot' stored procedure. 
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
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_GetSoLanChot' stored procedure. 
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
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_GetSoLanChot' stored procedure. 
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
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_GetSoLanChot' stored procedure. 
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
		
		#region cust_KcqKetQuaThanhToanThuLao_TongHopKetQuaThanhToan 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_TongHopKetQuaThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TongHopKetQuaThanhToan(System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return TongHopKetQuaThanhToan(null, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_TongHopKetQuaThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TongHopKetQuaThanhToan(int start, int pageLength, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return TongHopKetQuaThanhToan(null, start, pageLength , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_TongHopKetQuaThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader TongHopKetQuaThanhToan(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot)
		{
			return TongHopKetQuaThanhToan(transactionManager, 0, int.MaxValue , namHoc, hocKy, donVi, loaiGiangVien, lanChot);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_TongHopKetQuaThanhToan' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="donVi"> A <c>System.String</c> instance.</param>
		/// <param name="loaiGiangVien"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader TongHopKetQuaThanhToan(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.String donVi, System.String loaiGiangVien, System.Int32 lanChot);
		
		#endregion
		
		#region cust_KcqKetQuaThanhToanThuLao_HuyChotThuLao 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_HuyChotThuLao' stored procedure. 
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
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_HuyChotThuLao' stored procedure. 
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
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_HuyChotThuLao' stored procedure. 
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
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_HuyChotThuLao' stored procedure. 
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
		
		#region cust_KcqKetQuaThanhToanThuLao_SoSanhHaiLanChot 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_SoSanhHaiLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChota"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotb"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader SoSanhHaiLanChot(System.String namHoc, System.String hocKy, System.Int32 lanChota, System.Int32 lanChotb)
		{
			return SoSanhHaiLanChot(null, 0, int.MaxValue , namHoc, hocKy, lanChota, lanChotb);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_SoSanhHaiLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChota"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotb"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader SoSanhHaiLanChot(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 lanChota, System.Int32 lanChotb)
		{
			return SoSanhHaiLanChot(null, start, pageLength , namHoc, hocKy, lanChota, lanChotb);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_SoSanhHaiLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChota"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotb"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public IDataReader SoSanhHaiLanChot(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 lanChota, System.Int32 lanChotb)
		{
			return SoSanhHaiLanChot(transactionManager, 0, int.MaxValue , namHoc, hocKy, lanChota, lanChotb);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_SoSanhHaiLanChot' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChota"> A <c>System.Int32</c> instance.</param>
		/// <param name="lanChotb"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="IDataReader"/> instance.</returns>
		public abstract IDataReader SoSanhHaiLanChot(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 lanChota, System.Int32 lanChotb);
		
		#endregion
		
		#region cust_KcqKetQuaThanhToanThuLao_ChotThanhToan2 
		
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_ChotThanhToan2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotThanhToan2(System.String namHoc, System.String hocKy, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 ChotThanhToan2(null, 0, int.MaxValue , namHoc, hocKy, lanChot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_ChotThanhToan2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotThanhToan2(int start, int pageLength, System.String namHoc, System.String hocKy, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 ChotThanhToan2(null, start, pageLength , namHoc, hocKy, lanChot, ref reVal);
		}
				
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_ChotThanhToan2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public void ChotThanhToan2(TransactionManager transactionManager, System.String namHoc, System.String hocKy, System.Int32 lanChot, ref System.Int32 reVal)
		{
			 ChotThanhToan2(transactionManager, 0, int.MaxValue , namHoc, hocKy, lanChot, ref reVal);
		}
		
		/// <summary>
		///	This method wrap the 'cust_KcqKetQuaThanhToanThuLao_ChotThanhToan2' stored procedure. 
		/// </summary>
		/// <param name="namHoc"> A <c>System.String</c> instance.</param>
		/// <param name="hocKy"> A <c>System.String</c> instance.</param>
		/// <param name="lanChot"> A <c>System.Int32</c> instance.</param>
			/// <param name="reVal"> A <c>System.Int32</c> instance.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		public abstract void ChotThanhToan2(TransactionManager transactionManager, int start, int pageLength , System.String namHoc, System.String hocKy, System.Int32 lanChot, ref System.Int32 reVal);
		
		#endregion
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;KcqKetQuaThanhToanThuLao&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;KcqKetQuaThanhToanThuLao&gt;"/></returns>
		public static TList<KcqKetQuaThanhToanThuLao> Fill(IDataReader reader, TList<KcqKetQuaThanhToanThuLao> rows, int start, int pageLength)
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
				
				PMS.Entities.KcqKetQuaThanhToanThuLao c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("KcqKetQuaThanhToanThuLao")
					.Append("|").Append((System.Int32)reader[((int)KcqKetQuaThanhToanThuLaoColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<KcqKetQuaThanhToanThuLao>(
					key.ToString(), // EntityTrackingKey
					"KcqKetQuaThanhToanThuLao",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new PMS.Entities.KcqKetQuaThanhToanThuLao();
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
					c.Id = (System.Int32)reader[(KcqKetQuaThanhToanThuLaoColumn.Id.ToString())];
					c.MaGiangVien = (reader[KcqKetQuaThanhToanThuLaoColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKetQuaThanhToanThuLaoColumn.MaGiangVien.ToString())];
					c.NamHoc = (reader[KcqKetQuaThanhToanThuLaoColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.NamHoc.ToString())];
					c.HocKy = (reader[KcqKetQuaThanhToanThuLaoColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.HocKy.ToString())];
					c.MaHocHam = (reader[KcqKetQuaThanhToanThuLaoColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKetQuaThanhToanThuLaoColumn.MaHocHam.ToString())];
					c.MaHocVi = (reader[KcqKetQuaThanhToanThuLaoColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKetQuaThanhToanThuLaoColumn.MaHocVi.ToString())];
					c.MaLoaiGiangVien = (reader[KcqKetQuaThanhToanThuLaoColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKetQuaThanhToanThuLaoColumn.MaLoaiGiangVien.ToString())];
					c.MaDonVi = (reader[KcqKetQuaThanhToanThuLaoColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaDonVi.ToString())];
					c.Loai = (reader[KcqKetQuaThanhToanThuLaoColumn.Loai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.Loai.ToString())];
					c.PhanLoai = (reader[KcqKetQuaThanhToanThuLaoColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.PhanLoai.ToString())];
					c.MaMonHoc = (reader[KcqKetQuaThanhToanThuLaoColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaMonHoc.ToString())];
					c.TenMonHoc = (reader[KcqKetQuaThanhToanThuLaoColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.TenMonHoc.ToString())];
					c.LoaiHocPhan = (reader[KcqKetQuaThanhToanThuLaoColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.LoaiHocPhan.ToString())];
					c.Nhom = (reader[KcqKetQuaThanhToanThuLaoColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.Nhom.ToString())];
					c.MaLop = (reader[KcqKetQuaThanhToanThuLaoColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaLop.ToString())];
					c.LopClc = (reader[KcqKetQuaThanhToanThuLaoColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqKetQuaThanhToanThuLaoColumn.LopClc.ToString())];
					c.SiSo = (reader[KcqKetQuaThanhToanThuLaoColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKetQuaThanhToanThuLaoColumn.SiSo.ToString())];
					c.TietThucDay = (reader[KcqKetQuaThanhToanThuLaoColumn.TietThucDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.TietThucDay.ToString())];
					c.TietChuNhat = (reader[KcqKetQuaThanhToanThuLaoColumn.TietChuNhat.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.TietChuNhat.ToString())];
					c.HeSoHocKy = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoHocKy.ToString())];
					c.HeSoLopDong = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoLopDong.ToString())];
					c.TietQuyDoi = (reader[KcqKetQuaThanhToanThuLaoColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.TietQuyDoi.ToString())];
					c.DonGia = (reader[KcqKetQuaThanhToanThuLaoColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.DonGia.ToString())];
					c.ThanhTien = (reader[KcqKetQuaThanhToanThuLaoColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.ThanhTien.ToString())];
					c.LanChot = (reader[KcqKetQuaThanhToanThuLaoColumn.LanChot.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKetQuaThanhToanThuLaoColumn.LanChot.ToString())];
					c.NgayCapNhat = (reader[KcqKetQuaThanhToanThuLaoColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqKetQuaThanhToanThuLaoColumn.NgayCapNhat.ToString())];
					c.MaHinhThucDaoTao = (reader[KcqKetQuaThanhToanThuLaoColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaHinhThucDaoTao.ToString())];
					c.DonGiaTrongChuan = (reader[KcqKetQuaThanhToanThuLaoColumn.DonGiaTrongChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.DonGiaTrongChuan.ToString())];
					c.DonGiaNgoaiChuan = (reader[KcqKetQuaThanhToanThuLaoColumn.DonGiaNgoaiChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.DonGiaNgoaiChuan.ToString())];
					c.TenCoSo = (reader[KcqKetQuaThanhToanThuLaoColumn.TenCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.TenCoSo.ToString())];
					c.HeSoQuyDoiThucHanhSangLyThuyet = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString())];
					c.HeSoCoSo = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoCoSo.ToString())];
					c.SoGioThucGiangTrenLop = (reader[KcqKetQuaThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString())];
					c.SoGioChuanTinhThem = (reader[KcqKetQuaThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString())];
					c.HeSoChucDanhChuyenMon = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoChucDanhChuyenMon.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoChucDanhChuyenMon.ToString())];
					c.HeSoClcCntn = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoClcCntn.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoClcCntn.ToString())];
					c.HeSoThinhGiangMonChuyenNganh = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoThinhGiangMonChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoThinhGiangMonChuyenNganh.ToString())];
					c.MaNhomMonHoc = (reader[KcqKetQuaThanhToanThuLaoColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaNhomMonHoc.ToString())];
					c.LoaiLop = (reader[KcqKetQuaThanhToanThuLaoColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.LoaiLop.ToString())];
					c.MaBacDaoTao = (reader[KcqKetQuaThanhToanThuLaoColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaBacDaoTao.ToString())];
					c.MalopHocPhan = (reader[KcqKetQuaThanhToanThuLaoColumn.MalopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MalopHocPhan.ToString())];
					c.MaKhoaHoc = (reader[KcqKetQuaThanhToanThuLaoColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaKhoaHoc.ToString())];
					c.HeSoTroCap = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoTroCap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoTroCap.ToString())];
					c.HeSoNgoaiGio = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoNgoaiGio.ToString())];
					c.HeSoLuong = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoLuong.ToString())];
					c.HeSoMonMoi = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoMonMoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoMonMoi.ToString())];
					c.HeSoNienCheTinChi = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoNienCheTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoNienCheTinChi.ToString())];
					c.HeSoNgonNgu = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoNgonNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoNgonNgu.ToString())];
					c.HeSoBacDaoTao = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoBacDaoTao.ToString())];
					c.MaDiaDiem = (reader[KcqKetQuaThanhToanThuLaoColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaDiaDiem.ToString())];
					c.TenDiaDiem = (reader[KcqKetQuaThanhToanThuLaoColumn.TenDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.TenDiaDiem.ToString())];
					c.DonGiaDiaDiem = (reader[KcqKetQuaThanhToanThuLaoColumn.DonGiaDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.DonGiaDiaDiem.ToString())];
					c.TienXeDiaDiem = (reader[KcqKetQuaThanhToanThuLaoColumn.TienXeDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.TienXeDiaDiem.ToString())];
					c.HeSoDiaDiem = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoDiaDiem.ToString())];
					c.SoTinChi = (reader[KcqKetQuaThanhToanThuLaoColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKetQuaThanhToanThuLaoColumn.SoTinChi.ToString())];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqKetQuaThanhToanThuLao"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqKetQuaThanhToanThuLao"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, PMS.Entities.KcqKetQuaThanhToanThuLao entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[(KcqKetQuaThanhToanThuLaoColumn.Id.ToString())];
			entity.MaGiangVien = (reader[KcqKetQuaThanhToanThuLaoColumn.MaGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKetQuaThanhToanThuLaoColumn.MaGiangVien.ToString())];
			entity.NamHoc = (reader[KcqKetQuaThanhToanThuLaoColumn.NamHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.NamHoc.ToString())];
			entity.HocKy = (reader[KcqKetQuaThanhToanThuLaoColumn.HocKy.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.HocKy.ToString())];
			entity.MaHocHam = (reader[KcqKetQuaThanhToanThuLaoColumn.MaHocHam.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKetQuaThanhToanThuLaoColumn.MaHocHam.ToString())];
			entity.MaHocVi = (reader[KcqKetQuaThanhToanThuLaoColumn.MaHocVi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKetQuaThanhToanThuLaoColumn.MaHocVi.ToString())];
			entity.MaLoaiGiangVien = (reader[KcqKetQuaThanhToanThuLaoColumn.MaLoaiGiangVien.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKetQuaThanhToanThuLaoColumn.MaLoaiGiangVien.ToString())];
			entity.MaDonVi = (reader[KcqKetQuaThanhToanThuLaoColumn.MaDonVi.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaDonVi.ToString())];
			entity.Loai = (reader[KcqKetQuaThanhToanThuLaoColumn.Loai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.Loai.ToString())];
			entity.PhanLoai = (reader[KcqKetQuaThanhToanThuLaoColumn.PhanLoai.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.PhanLoai.ToString())];
			entity.MaMonHoc = (reader[KcqKetQuaThanhToanThuLaoColumn.MaMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaMonHoc.ToString())];
			entity.TenMonHoc = (reader[KcqKetQuaThanhToanThuLaoColumn.TenMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.TenMonHoc.ToString())];
			entity.LoaiHocPhan = (reader[KcqKetQuaThanhToanThuLaoColumn.LoaiHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.LoaiHocPhan.ToString())];
			entity.Nhom = (reader[KcqKetQuaThanhToanThuLaoColumn.Nhom.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.Nhom.ToString())];
			entity.MaLop = (reader[KcqKetQuaThanhToanThuLaoColumn.MaLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaLop.ToString())];
			entity.LopClc = (reader[KcqKetQuaThanhToanThuLaoColumn.LopClc.ToString()] == DBNull.Value) ? null : (System.Boolean?)reader[(KcqKetQuaThanhToanThuLaoColumn.LopClc.ToString())];
			entity.SiSo = (reader[KcqKetQuaThanhToanThuLaoColumn.SiSo.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKetQuaThanhToanThuLaoColumn.SiSo.ToString())];
			entity.TietThucDay = (reader[KcqKetQuaThanhToanThuLaoColumn.TietThucDay.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.TietThucDay.ToString())];
			entity.TietChuNhat = (reader[KcqKetQuaThanhToanThuLaoColumn.TietChuNhat.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.TietChuNhat.ToString())];
			entity.HeSoHocKy = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoHocKy.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoHocKy.ToString())];
			entity.HeSoLopDong = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoLopDong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoLopDong.ToString())];
			entity.TietQuyDoi = (reader[KcqKetQuaThanhToanThuLaoColumn.TietQuyDoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.TietQuyDoi.ToString())];
			entity.DonGia = (reader[KcqKetQuaThanhToanThuLaoColumn.DonGia.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.DonGia.ToString())];
			entity.ThanhTien = (reader[KcqKetQuaThanhToanThuLaoColumn.ThanhTien.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.ThanhTien.ToString())];
			entity.LanChot = (reader[KcqKetQuaThanhToanThuLaoColumn.LanChot.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKetQuaThanhToanThuLaoColumn.LanChot.ToString())];
			entity.NgayCapNhat = (reader[KcqKetQuaThanhToanThuLaoColumn.NgayCapNhat.ToString()] == DBNull.Value) ? null : (System.DateTime?)reader[(KcqKetQuaThanhToanThuLaoColumn.NgayCapNhat.ToString())];
			entity.MaHinhThucDaoTao = (reader[KcqKetQuaThanhToanThuLaoColumn.MaHinhThucDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaHinhThucDaoTao.ToString())];
			entity.DonGiaTrongChuan = (reader[KcqKetQuaThanhToanThuLaoColumn.DonGiaTrongChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.DonGiaTrongChuan.ToString())];
			entity.DonGiaNgoaiChuan = (reader[KcqKetQuaThanhToanThuLaoColumn.DonGiaNgoaiChuan.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.DonGiaNgoaiChuan.ToString())];
			entity.TenCoSo = (reader[KcqKetQuaThanhToanThuLaoColumn.TenCoSo.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.TenCoSo.ToString())];
			entity.HeSoQuyDoiThucHanhSangLyThuyet = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoQuyDoiThucHanhSangLyThuyet.ToString())];
			entity.HeSoCoSo = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoCoSo.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoCoSo.ToString())];
			entity.SoGioThucGiangTrenLop = (reader[KcqKetQuaThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.SoGioThucGiangTrenLop.ToString())];
			entity.SoGioChuanTinhThem = (reader[KcqKetQuaThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.SoGioChuanTinhThem.ToString())];
			entity.HeSoChucDanhChuyenMon = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoChucDanhChuyenMon.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoChucDanhChuyenMon.ToString())];
			entity.HeSoClcCntn = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoClcCntn.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoClcCntn.ToString())];
			entity.HeSoThinhGiangMonChuyenNganh = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoThinhGiangMonChuyenNganh.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoThinhGiangMonChuyenNganh.ToString())];
			entity.MaNhomMonHoc = (reader[KcqKetQuaThanhToanThuLaoColumn.MaNhomMonHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaNhomMonHoc.ToString())];
			entity.LoaiLop = (reader[KcqKetQuaThanhToanThuLaoColumn.LoaiLop.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.LoaiLop.ToString())];
			entity.MaBacDaoTao = (reader[KcqKetQuaThanhToanThuLaoColumn.MaBacDaoTao.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaBacDaoTao.ToString())];
			entity.MalopHocPhan = (reader[KcqKetQuaThanhToanThuLaoColumn.MalopHocPhan.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MalopHocPhan.ToString())];
			entity.MaKhoaHoc = (reader[KcqKetQuaThanhToanThuLaoColumn.MaKhoaHoc.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaKhoaHoc.ToString())];
			entity.HeSoTroCap = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoTroCap.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoTroCap.ToString())];
			entity.HeSoNgoaiGio = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoNgoaiGio.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoNgoaiGio.ToString())];
			entity.HeSoLuong = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoLuong.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoLuong.ToString())];
			entity.HeSoMonMoi = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoMonMoi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoMonMoi.ToString())];
			entity.HeSoNienCheTinChi = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoNienCheTinChi.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoNienCheTinChi.ToString())];
			entity.HeSoNgonNgu = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoNgonNgu.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoNgonNgu.ToString())];
			entity.HeSoBacDaoTao = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoBacDaoTao.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoBacDaoTao.ToString())];
			entity.MaDiaDiem = (reader[KcqKetQuaThanhToanThuLaoColumn.MaDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.MaDiaDiem.ToString())];
			entity.TenDiaDiem = (reader[KcqKetQuaThanhToanThuLaoColumn.TenDiaDiem.ToString()] == DBNull.Value) ? null : (System.String)reader[(KcqKetQuaThanhToanThuLaoColumn.TenDiaDiem.ToString())];
			entity.DonGiaDiaDiem = (reader[KcqKetQuaThanhToanThuLaoColumn.DonGiaDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.DonGiaDiaDiem.ToString())];
			entity.TienXeDiaDiem = (reader[KcqKetQuaThanhToanThuLaoColumn.TienXeDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.TienXeDiaDiem.ToString())];
			entity.HeSoDiaDiem = (reader[KcqKetQuaThanhToanThuLaoColumn.HeSoDiaDiem.ToString()] == DBNull.Value) ? null : (System.Decimal?)reader[(KcqKetQuaThanhToanThuLaoColumn.HeSoDiaDiem.ToString())];
			entity.SoTinChi = (reader[KcqKetQuaThanhToanThuLaoColumn.SoTinChi.ToString()] == DBNull.Value) ? null : (System.Int32?)reader[(KcqKetQuaThanhToanThuLaoColumn.SoTinChi.ToString())];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="PMS.Entities.KcqKetQuaThanhToanThuLao"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="PMS.Entities.KcqKetQuaThanhToanThuLao"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, PMS.Entities.KcqKetQuaThanhToanThuLao entity)
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
		/// <param name="entity">The <see cref="PMS.Entities.KcqKetQuaThanhToanThuLao"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">PMS.Entities.KcqKetQuaThanhToanThuLao Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, PMS.Entities.KcqKetQuaThanhToanThuLao entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the PMS.Entities.KcqKetQuaThanhToanThuLao object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">PMS.Entities.KcqKetQuaThanhToanThuLao instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">PMS.Entities.KcqKetQuaThanhToanThuLao Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, PMS.Entities.KcqKetQuaThanhToanThuLao entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region KcqKetQuaThanhToanThuLaoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>PMS.Entities.KcqKetQuaThanhToanThuLao</c>
	///</summary>
	public enum KcqKetQuaThanhToanThuLaoChildEntityTypes
	{
	}
	
	#endregion KcqKetQuaThanhToanThuLaoChildEntityTypes
	
	#region KcqKetQuaThanhToanThuLaoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;KcqKetQuaThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKetQuaThanhToanThuLaoFilterBuilder : SqlFilterBuilder<KcqKetQuaThanhToanThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKetQuaThanhToanThuLaoFilterBuilder class.
		/// </summary>
		public KcqKetQuaThanhToanThuLaoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqKetQuaThanhToanThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqKetQuaThanhToanThuLaoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqKetQuaThanhToanThuLaoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqKetQuaThanhToanThuLaoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqKetQuaThanhToanThuLaoFilterBuilder
	
	#region KcqKetQuaThanhToanThuLaoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;KcqKetQuaThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKetQuaThanhToanThuLaoParameterBuilder : ParameterizedSqlFilterBuilder<KcqKetQuaThanhToanThuLaoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKetQuaThanhToanThuLaoParameterBuilder class.
		/// </summary>
		public KcqKetQuaThanhToanThuLaoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the KcqKetQuaThanhToanThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KcqKetQuaThanhToanThuLaoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KcqKetQuaThanhToanThuLaoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KcqKetQuaThanhToanThuLaoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KcqKetQuaThanhToanThuLaoParameterBuilder
	
	#region KcqKetQuaThanhToanThuLaoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;KcqKetQuaThanhToanThuLaoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKetQuaThanhToanThuLao"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class KcqKetQuaThanhToanThuLaoSortBuilder : SqlSortBuilder<KcqKetQuaThanhToanThuLaoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKetQuaThanhToanThuLaoSqlSortBuilder class.
		/// </summary>
		public KcqKetQuaThanhToanThuLaoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion KcqKetQuaThanhToanThuLaoSortBuilder
	
} // end namespace
